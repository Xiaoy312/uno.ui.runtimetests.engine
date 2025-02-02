﻿#nullable enable

using System;
using System.Linq;
using System.Reflection;

namespace Uno.UI.RuntimeTests;

public class UnitTestClassInfo
{
	public UnitTestClassInfo(
		Type? type,
		MethodInfo[]? tests,
		MethodInfo? initialize,
		MethodInfo? cleanup)
	{
		Type = type;
		TestClassName = Type?.Name ?? "(null)";
		Tests = tests;
		Initialize = initialize;
		Cleanup = cleanup;
	}

	public string TestClassName { get; }

	public Type? Type { get; }

	public MethodInfo[]? Tests { get; }

	public MethodInfo? Initialize { get; }

	public MethodInfo? Cleanup { get; }

	public override string ToString() => TestClassName;
}
