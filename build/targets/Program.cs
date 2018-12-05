using System;
using System.Linq;
using System.Threading.Tasks;
using ProcNet;
using static Bullseye.Targets;
using static ProcNet.Proc;

namespace targets
{
	public class Program
	{
		private static string T(string t) => t.Replace("Target", "").ToLowerInvariant();
		private static string[] D(params string[] ts) => DependsOn(ts.Select(T).ToArray());
		private static void Chain(string t, params string[] ts) => Target(T(t), D(ts));
		private static void T(string t, Action a, params string[] ts) => Target(T(t), D(ts), a);
		private static void TAsync(string t, Func<Task> a, params string[] ts) => Target(T(t), D(ts), a);

		public static async Task<int> Main(string[] args)
		{
			Chain(nameof(Default), nameof(DrinkTeaTarget), nameof(GitStatus));

			T(nameof(MakeTea), MakeTea);

			T(nameof(DrinkTeaTarget), DrinkTeaTarget.Exec, nameof(MakeTea));

			T(nameof(GitStatus), GitStatus.Execute);

			try
			{
				await RunTargetsAsync(args);
			}
			catch (ProcExecException ex)
			{
				return ex.ExitCode ?? 1;
			}
			return 0;
		}

		public static void Default() => Console.WriteLine("Start default");
		public static void MakeTea() => Console.WriteLine("Tea made");
	}

	public static class DrinkTeaTarget
	{
		public static void Exec() => Console.WriteLine("Ahh... lovely!");

	}
	public static class GitStatus
	{
		public static void Execute()
		{
			 Exec(new ExecArguments("dotnet", "xunit") { WorkingDirectory = @"src\Tests\Tests"});
		}
	}
}
