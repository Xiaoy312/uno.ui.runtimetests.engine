﻿#nullable enable

using System;
using System.Linq;

namespace Uno.UI.RuntimeTests;

internal record TestCaseResult
{
	public TestResult TestResult { get; init; }
	public string? TestName { get; init; }
	public TimeSpan Duration { get; init; }
	public string? Message { get; init; }
}
