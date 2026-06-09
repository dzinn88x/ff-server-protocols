using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002B0D RID: 11021
	[Token(Token = "0x2002B0D")]
	internal class Projectile : AttackableEntity
	{
		// Token: 0x0600F244 RID: 62020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F244")]
		[Address(RVA = "0x172AFBC", Offset = "0x172AFBC", VA = "0x7BBBF2AFBC", Slot = "11")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600F245 RID: 62021 RVA: 0x00045708 File Offset: 0x00043908
		[Token(Token = "0x600F245")]
		[Address(RVA = "0x172B1F8", Offset = "0x172B1F8", VA = "0x7BBBF2B1F8", Slot = "22")]
		protected override int GetMaxRepDataCount()
		{
			return 0;
		}

		// Token: 0x0600F246 RID: 62022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F246")]
		[Address(RVA = "0x172B200", Offset = "0x172B200", VA = "0x7BBBF2B200", Slot = "14")]
		public override void OnFixedUpdate(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600F247 RID: 62023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F247")]
		[Address(RVA = "0x172B3F0", Offset = "0x172B3F0", VA = "0x7BBBF2B3F0", Slot = "15")]
		public override void OnUpdate(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600F248 RID: 62024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F248")]
		[Address(RVA = "0x172B3F4", Offset = "0x172B3F4", VA = "0x7BBBF2B3F4")]
		public void PushSyncState(Z\u0081h\u0080Czs jcBsT\u0080C, uint ~||\u0082utT)
		{
		}

		// Token: 0x0600F249 RID: 62025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F249")]
		[Address(RVA = "0x172B788", Offset = "0x172B788", VA = "0x7BBBF2B788")]
		public Projectile()
		{
		}

		// Token: 0x040117B2 RID: 71602
		[Token(Token = "0x40117B2")]
		[FieldOffset(Offset = "0x50")]
		protected uint Kpikoyc;

		// Token: 0x040117B3 RID: 71603
		[Token(Token = "0x40117B3")]
		[FieldOffset(Offset = "0x58")]
		protected Projectile.zSFDrK \u0082iAgQB^;

		// Token: 0x040117B4 RID: 71604
		[Token(Token = "0x40117B4")]
		[FieldOffset(Offset = "0x60")]
		private bool ARCZRls;

		// Token: 0x040117B5 RID: 71605
		[Token(Token = "0x40117B5")]
		[FieldOffset(Offset = "0x68")]
		private Queue<Vector3> xWSOxjJ;

		// Token: 0x040117B6 RID: 71606
		[Token(Token = "0x40117B6")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 PFJ\u0081[By;

		// Token: 0x02002B0E RID: 11022
		[Token(Token = "0x2002B0E")]
		protected class zSFDrK : ShadowStateBase
		{
			// Token: 0x0600F24A RID: 62026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F24A")]
			[Address(RVA = "0x172B848", Offset = "0x172B848", VA = "0x7BBBF2B848")]
			public zSFDrK()
			{
			}

			// Token: 0x040117B7 RID: 71607
			[Token(Token = "0x40117B7")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 rTT^h\u007FJ;

			// Token: 0x040117B8 RID: 71608
			[Token(Token = "0x40117B8")]
			[FieldOffset(Offset = "0x24")]
			public Quaternion t~{UBjj;

			// Token: 0x040117B9 RID: 71609
			[Token(Token = "0x40117B9")]
			[FieldOffset(Offset = "0x34")]
			public Vector3 |ZprCW};

			// Token: 0x040117BA RID: 71610
			[Token(Token = "0x40117BA")]
			[FieldOffset(Offset = "0x40")]
			public Quaternion VM\u0081a^HA;

			// Token: 0x040117BB RID: 71611
			[Token(Token = "0x40117BB")]
			[FieldOffset(Offset = "0x50")]
			public Vector3 L\u0080FEeoZ;
		}
	}
}
