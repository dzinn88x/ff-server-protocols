using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x0200285F RID: 10335
	[Token(Token = "0x200285F")]
	[Attribute(Name = "RequireComponent", RVA = "0x10FEAF8", Offset = "0x10FEAF8")]
	public class LevelHotzone : BaseLevelObject
	{
		// Token: 0x0600DA20 RID: 55840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DA20")]
		[Address(RVA = "0x1EB2CB8", Offset = "0x1EB2CB8", VA = "0x7BBC6B2CB8", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600DA21 RID: 55841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DA21")]
		[Address(RVA = "0x1EB2D00", Offset = "0x1EB2D00", VA = "0x7BBC6B2D00", Slot = "12")]
		protected override void OnStart()
		{
		}

		// Token: 0x0600DA22 RID: 55842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DA22")]
		[Address(RVA = "0x1EB2D44", Offset = "0x1EB2D44", VA = "0x7BBC6B2D44", Slot = "27")]
		public override void SyncAction(params object[] OSvO{nh)
		{
		}

		// Token: 0x0600DA23 RID: 55843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DA23")]
		[Address(RVA = "0x1EB309C", Offset = "0x1EB309C", VA = "0x7BBC6B309C")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x0600DA24 RID: 55844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DA24")]
		[Address(RVA = "0x1EB32E4", Offset = "0x1EB32E4", VA = "0x7BBC6B32E4")]
		public LevelHotzone()
		{
		}

		// Token: 0x04010A06 RID: 68102
		[Token(Token = "0x4010A06")]
		[FieldOffset(Offset = "0x68")]
		public string hotzoneName;

		// Token: 0x04010A07 RID: 68103
		[Token(Token = "0x4010A07")]
		[FieldOffset(Offset = "0x70")]
		public string hotzoneNameLoc;

		// Token: 0x04010A08 RID: 68104
		[Token(Token = "0x4010A08")]
		[FieldOffset(Offset = "0x78")]
		public float radius;

		// Token: 0x04010A09 RID: 68105
		[Token(Token = "0x4010A09")]
		[FieldOffset(Offset = "0x7C")]
		public float duration;

		// Token: 0x04010A0A RID: 68106
		[Token(Token = "0x4010A0A")]
		[FieldOffset(Offset = "0x80")]
		public CapsuleCollider capCollider;

		// Token: 0x02002860 RID: 10336
		[Token(Token = "0x2002860")]
		public enum ipYldWt
		{
			// Token: 0x04010A0C RID: 68108
			[Token(Token = "0x4010A0C")]
			SYNC,
			// Token: 0x04010A0D RID: 68109
			[Token(Token = "0x4010A0D")]
			DISMISS
		}
	}
}
