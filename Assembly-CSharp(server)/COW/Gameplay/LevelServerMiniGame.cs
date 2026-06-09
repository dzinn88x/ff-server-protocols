using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x0200289D RID: 10397
	[Token(Token = "0x200289D")]
	public class LevelServerMiniGame : BaseLevelObject
	{
		// Token: 0x0600DC5F RID: 56415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC5F")]
		[Address(RVA = "0x1D3BA54", Offset = "0x1D3BA54", VA = "0x7BBC53BA54", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600DC60 RID: 56416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC60")]
		[Address(RVA = "0x1D3BA9C", Offset = "0x1D3BA9C", VA = "0x7BBC53BA9C")]
		public LevelServerMiniGame()
		{
		}

		// Token: 0x04010BA2 RID: 68514
		[Token(Token = "0x4010BA2")]
		[FieldOffset(Offset = "0x68")]
		public MLY^mpx gameType;

		// Token: 0x04010BA3 RID: 68515
		[Token(Token = "0x4010BA3")]
		[FieldOffset(Offset = "0x6C")]
		public float Radius;

		// Token: 0x04010BA4 RID: 68516
		[Token(Token = "0x4010BA4")]
		[FieldOffset(Offset = "0x70")]
		public Transform[] SpawnPoints;
	}
}
