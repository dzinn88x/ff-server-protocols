using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x0200289B RID: 10395
	[Token(Token = "0x200289B")]
	[Attribute(Name = "RequireComponent", RVA = "0x10FEBAC", Offset = "0x10FEBAC")]
	public class LevelRoom : BaseLevelObject
	{
		// Token: 0x0600DC5A RID: 56410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC5A")]
		[Address(RVA = "0x1D3AB04", Offset = "0x1D3AB04", VA = "0x7BBC53AB04", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600DC5B RID: 56411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC5B")]
		[Address(RVA = "0x1D3AB4C", Offset = "0x1D3AB4C", VA = "0x7BBC53AB4C")]
		private void Awake()
		{
		}

		// Token: 0x0600DC5C RID: 56412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC5C")]
		[Address(RVA = "0x1D3AC74", Offset = "0x1D3AC74", VA = "0x7BBC53AC74")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600DC5D RID: 56413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC5D")]
		[Address(RVA = "0x1D3B2A0", Offset = "0x1D3B2A0", VA = "0x7BBC53B2A0")]
		public void DrawArrow(Vector3 cC|iom\u007F, Vector3 eu|oKIt, Color oQ|F`Ql, float sEh[K\u007F\u0080 = 3f, float sZjI\u0082xT = 20f)
		{
		}

		// Token: 0x0600DC5E RID: 56414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC5E")]
		[Address(RVA = "0x1D3B9BC", Offset = "0x1D3B9BC", VA = "0x7BBC53B9BC")]
		public LevelRoom()
		{
		}

		// Token: 0x04010B9D RID: 68509
		[Token(Token = "0x4010B9D")]
		[FieldOffset(Offset = "0x68")]
		public List<LevelRoom> neighborRooms;

		// Token: 0x04010B9E RID: 68510
		[Token(Token = "0x4010B9E")]
		[FieldOffset(Offset = "0x70")]
		public List<PVEAISpawnPoint> AISpawnPointList;

		// Token: 0x04010B9F RID: 68511
		[Token(Token = "0x4010B9F")]
		[FieldOffset(Offset = "0x78")]
		private BoxCollider QjJxu[q;
	}
}
