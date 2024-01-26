﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

#nullable disable

using System;
using System.Linq;
using Microsoft.AspNetCore.Razor.ProjectEngineHost;
using Microsoft.CodeAnalysis.Razor;
using Microsoft.CodeAnalysis.Razor.ProjectSystem;
using Moq;

namespace Microsoft.CodeAnalysis.Remote.Razor;

public partial class OutOfProcTagHelperResolverTest
{
    private static readonly Lazy<ProjectSnapshotManagerDispatcher> s_projectSnapshotManagerDispatcher = new(() =>
    {
        var dispatcher = new Mock<ProjectSnapshotManagerDispatcher>(MockBehavior.Strict);
        dispatcher.SetupGet(d => d.IsDispatcherThread).Returns(true);
        return dispatcher.Object;
    });

    private class TestProjectSnapshotManager(Workspace workspace, IProjectEngineFactoryProvider projectEngineFactoryProvider) : DefaultProjectSnapshotManager(
        Mock.Of<IErrorReporter>(MockBehavior.Strict),
        Enumerable.Empty<IProjectSnapshotChangeTrigger>(),
        workspace,
        projectEngineFactoryProvider,
        s_projectSnapshotManagerDispatcher.Value)
    {
    }
}