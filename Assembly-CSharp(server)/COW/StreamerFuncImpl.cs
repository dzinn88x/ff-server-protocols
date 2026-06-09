using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace COW
{
	// Token: 0x02001256 RID: 4694
	[Token(Token = "0x2001256")]
	public class StreamerFuncImpl : IStreamerFunc
	{
		// Token: 0x0600487E RID: 18558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600487E")]
		[Address(RVA = "0x1B4035C", Offset = "0x1B4035C", VA = "0x7BBC34035C", Slot = "4")]
		public Transform GetTargetPlayer()
		{
			return null;
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600487F")]
		[Address(RVA = "0x1B405C0", Offset = "0x1B405C0", VA = "0x7BBC3405C0", Slot = "5")]
		public AsyncOperation LoadSceneAsync(string sourcePath, LoadSceneMode mode)
		{
			return null;
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004880")]
		[Address(RVA = "0x1B40740", Offset = "0x1B40740", VA = "0x7BBC340740", Slot = "6")]
		public AssetBundle GetStreamSceneAB()
		{
			return null;
		}

		// Token: 0x06004881 RID: 18561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004881")]
		[Address(RVA = "0x1B4081C", Offset = "0x1B4081C", VA = "0x7BBC34081C", Slot = "7")]
		public byte[] GetStreamSceneABTexRefInfo()
		{
			return null;
		}

		// Token: 0x06004882 RID: 18562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004882")]
		[Address(RVA = "0x1B408A0", Offset = "0x1B408A0", VA = "0x7BBC3408A0", Slot = "8")]
		public void OnLoadSceneFinish(string sourcePath, bool result)
		{
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004883")]
		[Address(RVA = "0x1B40A00", Offset = "0x1B40A00", VA = "0x7BBC340A00", Slot = "9")]
		public void RepeatAction(float interval, Action action)
		{
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004884")]
		[Address(RVA = "0x1B40A98", Offset = "0x1B40A98", VA = "0x7BBC340A98", Slot = "10")]
		public void NotifySceneEvent(StreamerType type, string name, bool loaded)
		{
		}

		// Token: 0x06004885 RID: 18565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004885")]
		[Address(RVA = "0x1B40BA0", Offset = "0x1B40BA0", VA = "0x7BBC340BA0")]
		public StreamerFuncImpl()
		{
		}
	}
}
