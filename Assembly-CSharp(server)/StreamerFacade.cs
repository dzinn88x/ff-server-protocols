using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using WorldStreamer;

// Token: 0x020001D8 RID: 472
[Token(Token = "0x20001D8")]
public static class StreamerFacade
{
	// Token: 0x060009B8 RID: 2488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B8")]
	[Address(RVA = "0x2262920", Offset = "0x2262920", VA = "0x7BBCA62920")]
	public static void SetImpl(IStreamerFunc impl)
	{
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B9")]
	[Address(RVA = "0x22629B4", Offset = "0x22629B4", VA = "0x7BBCA629B4")]
	public static Transform GetTargetPlayer()
	{
		return null;
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BA")]
	[Address(RVA = "0x2262A8C", Offset = "0x2262A8C", VA = "0x7BBCA62A8C")]
	public static AsyncOperation LoadSceneAsync(string sourcePath, LoadSceneMode mode)
	{
		return null;
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BB")]
	[Address(RVA = "0x2262B80", Offset = "0x2262B80", VA = "0x7BBCA62B80")]
	public static AssetBundle GetStreamSceneAB()
	{
		return null;
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009BC")]
	[Address(RVA = "0x2262C5C", Offset = "0x2262C5C", VA = "0x7BBCA62C5C")]
	public static byte[] GetStreamSceneABTexRefInfo()
	{
		return null;
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BD")]
	[Address(RVA = "0x2262D38", Offset = "0x2262D38", VA = "0x7BBCA62D38")]
	public static void OnLoadSceneFinish(string sourcePath, bool result)
	{
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BE")]
	[Address(RVA = "0x2262E2C", Offset = "0x2262E2C", VA = "0x7BBCA62E2C")]
	public static void RepeatAction(float interval, Action action)
	{
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009BF")]
	[Address(RVA = "0x2262F20", Offset = "0x2262F20", VA = "0x7BBCA62F20")]
	public static void NotifySceneEvent(StreamerType type, string name, bool loaded)
	{
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00003D38 File Offset: 0x00001F38
	// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000B2")]
	public static bool IsMainStreamFinished
	{
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x226308C", Offset = "0x226308C", VA = "0x7BBCA6308C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x226301C", Offset = "0x226301C", VA = "0x7BBCA6301C")]
		set
		{
		}
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C2")]
	[Address(RVA = "0x22630F4", Offset = "0x22630F4", VA = "0x7BBCA630F4")]
	public static void RegistVisibleHandler(StreamerType type, StreamerFacade.VisibleHandler handler, bool isDynamic)
	{
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x2263288", Offset = "0x2263288", VA = "0x7BBCA63288")]
	public static void UnRegistVisibleHandler(StreamerType type, StreamerFacade.VisibleHandler handler, bool isDynamic)
	{
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C4")]
	[Address(RVA = "0x226341C", Offset = "0x226341C", VA = "0x7BBCA6341C")]
	public static void DispatchVisibleEnvent(StreamerType type, bool isDynamic, Vector3 min, Vector3 max)
	{
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x00003D50 File Offset: 0x00001F50
	[Token(Token = "0x60009C5")]
	[Address(RVA = "0x2263C78", Offset = "0x2263C78", VA = "0x7BBCA63C78")]
	public static bool RegistStreamer(StreamerType type)
	{
		return default(bool);
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C6")]
	[Address(RVA = "0x2263E84", Offset = "0x2263E84", VA = "0x7BBCA63E84")]
	public static void UnRegistStreamer(StreamerType type)
	{
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x2263FDC", Offset = "0x2263FDC", VA = "0x7BBCA63FDC")]
	public static void AddStreamer(Streamer streamer)
	{
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x2264068", Offset = "0x2264068", VA = "0x7BBCA64068")]
	public static void StopAllStreamer()
	{
	}

	// Token: 0x04000938 RID: 2360
	[Token(Token = "0x4000938")]
	[FieldOffset(Offset = "0x0")]
	private static IStreamerFunc m_Impl;

	// Token: 0x04000939 RID: 2361
	[Token(Token = "0x4000939")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<StreamerType, StreamerFacade.VisibleFunc> m_Handler;

	// Token: 0x0400093A RID: 2362
	[Token(Token = "0x400093A")]
	[FieldOffset(Offset = "0x10")]
	private static List<Streamer> m_streamerList;

	// Token: 0x0400093B RID: 2363
	[Token(Token = "0x400093B")]
	[FieldOffset(Offset = "0x18")]
	private static bool mIsStreamingFinished;

	// Token: 0x020001D9 RID: 473
	[Token(Token = "0x20001D9")]
	private class VisibleFunc
	{
		// Token: 0x060009CA RID: 2506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x2263DF4", Offset = "0x2263DF4", VA = "0x7BBCA63DF4")]
		public VisibleFunc()
		{
		}

		// Token: 0x0400093C RID: 2364
		[Token(Token = "0x400093C")]
		[FieldOffset(Offset = "0x10")]
		public List<StreamerFacade.VisibleHandler> StaticHandler;

		// Token: 0x0400093D RID: 2365
		[Token(Token = "0x400093D")]
		[FieldOffset(Offset = "0x18")]
		public List<StreamerFacade.VisibleHandler> DynamicHandler;
	}

	// Token: 0x020001DA RID: 474
	// (Invoke) Token: 0x060009CC RID: 2508
	[Token(Token = "0x20001DA")]
	public delegate void VisibleHandler(Vector3 min, Vector3 max);
}
