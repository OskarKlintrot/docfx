﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace Microsoft.DocAsCode.Tests;

public static class CommandLineTest
{
    [Fact]
    public static void PrintsVersion()
    {
        Assert.Equal(0, Program.Main(new[] { "-v" }));
        Assert.Equal(0, Program.Main(new[] { "--version" }));
    }

    [Fact]
    public static void PrintsHelp()
    {
        Assert.Equal(0, Program.Main(new[] { "-h" }));
        Assert.Equal(0, Program.Main(new[] { "--help" }));
        Assert.Equal(0, Program.Main(new[] { "build", "--help" }));
        Assert.Equal(0, Program.Main(new[] { "serve", "--help" }));
        Assert.Equal(0, Program.Main(new[] { "metadata", "--help" }));
        Assert.Equal(0, Program.Main(new[] { "pdf", "--help" }));
        Assert.Equal(0, Program.Main(new[] { "init", "--help" }));
        Assert.Equal(0, Program.Main(new[] { "download", "--help" }));
        Assert.Equal(0, Program.Main(new[] { "merge", "--help" }));
        Assert.Equal(0, Program.Main(new[] { "template", "--help" }));
    }

    [Fact]
    public static void FailForUnknownArgs()
    {
        Assert.Equal(-1, Program.Main(new[] { "--unknown" }));
    }
}
