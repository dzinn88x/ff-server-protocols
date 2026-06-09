using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020001D7 RID: 471
[Token(Token = "0x20001D7")]
public class StreamerFuncDefaultImpl : IStreamerFunc
{
	// Token: 0x060009B0 RID: 2480 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B0")]
	[Address(RVA = "0x22643F0", Offset = "0x22643F0", VA = "0x7BBCA643F0", Slot = "4")]
	public Transform GetTargetPlayer()
	{
		return null;
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B1")]
	[Address(RVA = "0x22643F8", Offset = "0x22643F8", VA = "0x7BBCA643F8", Slot = "5")]
	public AsyncOperation LoadSceneAsync(string sourcePath, LoadSceneMode mode)
	{
		return null;
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B2")]
	[Address(RVA = "0x2264400", Offset = "0x2264400", VA = "0x7BBCA64400", Slot = "6")]
	public AssetBundle GetStreamSceneAB()
	{
		return null;
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009B3")]
	[Address(RVA = "0x2264408", Offset = "0x2264408", VA = "0x7BBCA64408", Slot = "7")]
	public byte[] GetStreamSceneABTexRefInfo()
	{
		return null;
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B4")]
	[Address(RVA = "0x2264410", Offset = "0x2264410", VA = "0x7BBCA64410", Slot = "8")]
	public void OnLoadSceneFinish(string sourcePath, bool result)
	{
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B5")]
	[Address(RVA = "0x2264414", Offset = "0x2264414", VA = "0x7BBCA64414", Slot = "9")]
	public void RepeatAction(float interval, Action action)
	{
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B6")]
	[Address(RVA = "0x2264418", Offset = "0x2264418", VA = "0x7BBCA64418", Slot = "10")]
	public void NotifySceneEvent(StreamerType type, string name, bool loaded)
	{
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009B7")]
	[Address(RVA = "0x22629AC", Offset = "0x22629AC", VA = "0x7BBCA629AC")]
	public StreamerFuncDefaultImpl()
	{
	}
}
