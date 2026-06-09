using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020026AF RID: 9903
	[Token(Token = "0x20026AF")]
	internal class Airdrop : AttackableEntity
	{
		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x0600CD2A RID: 52522 RVA: 0x00037020 File Offset: 0x00035220
		// (set) Token: 0x0600CD2B RID: 52523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000DC0")]
		public bool vXnMryz
		{
			[Token(Token = "0x600CD2A")]
			[Address(RVA = "0x18C1428", Offset = "0x18C1428", VA = "0x7BBC0C1428")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148C58", Offset = "0x1148C58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600CD2B")]
			[Address(RVA = "0x18C1430", Offset = "0x18C1430", VA = "0x7BBC0C1430")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1148C68", Offset = "0x1148C68")]
			protected set
			{
			}
		}

		// Token: 0x0600CD2C RID: 52524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD2C")]
		[Address(RVA = "0x18C143C", Offset = "0x18C143C", VA = "0x7BBC0C143C", Slot = "11")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600CD2D RID: 52525 RVA: 0x00037038 File Offset: 0x00035238
		[Token(Token = "0x600CD2D")]
		[Address(RVA = "0x18C1678", Offset = "0x18C1678", VA = "0x7BBC0C1678", Slot = "22")]
		protected override int GetMaxRepDataCount()
		{
			return 0;
		}

		// Token: 0x0600CD2E RID: 52526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD2E")]
		[Address(RVA = "0x18C1680", Offset = "0x18C1680", VA = "0x7BBC0C1680", Slot = "14")]
		public override void OnFixedUpdate(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600CD2F RID: 52527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD2F")]
		[Address(RVA = "0x18C1908", Offset = "0x18C1908", VA = "0x7BBC0C1908")]
		public void PushSyncState(kWhqVZl jcBsT\u0080C, uint ~||\u0082utT)
		{
		}

		// Token: 0x0600CD30 RID: 52528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD30")]
		[Address(RVA = "0x18C1C94", Offset = "0x18C1C94", VA = "0x7BBC0C1C94")]
		public void PlayAnimInWater()
		{
		}

		// Token: 0x0600CD31 RID: 52529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD31")]
		[Address(RVA = "0x18C1D1C", Offset = "0x18C1D1C", VA = "0x7BBC0C1D1C", Slot = "55")]
		public virtual void SyncReEnter()
		{
		}

		// Token: 0x0600CD32 RID: 52530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD32")]
		[Address(RVA = "0x18C1D20", Offset = "0x18C1D20", VA = "0x7BBC0C1D20")]
		public Airdrop()
		{
		}

		// Token: 0x040100F5 RID: 65781
		[Token(Token = "0x40100F5")]
		[FieldOffset(Offset = "0x50")]
		public Animator m_AirdropAnim;

		// Token: 0x040100F6 RID: 65782
		[Token(Token = "0x40100F6")]
		[FieldOffset(Offset = "0x58")]
		protected uint Kpikoyc;

		// Token: 0x040100F7 RID: 65783
		[Token(Token = "0x40100F7")]
		[FieldOffset(Offset = "0x5C")]
		protected Vector3 ~|ZKo[\u007F;

		// Token: 0x040100F8 RID: 65784
		[Token(Token = "0x40100F8")]
		[FieldOffset(Offset = "0x68")]
		protected Vector3 hRMvJXF;

		// Token: 0x040100F9 RID: 65785
		[Token(Token = "0x40100F9")]
		[FieldOffset(Offset = "0x78")]
		private Airdrop.zSFDrK \u0082iAgQB^;

		// Token: 0x040100FA RID: 65786
		[Token(Token = "0x40100FA")]
		[FieldOffset(Offset = "0x80")]
		private bool ARCZRls;

		// Token: 0x040100FB RID: 65787
		[Token(Token = "0x40100FB")]
		[FieldOffset(Offset = "0x88")]
		private Queue<Vector3> xWSOxjJ;

		// Token: 0x040100FC RID: 65788
		[Token(Token = "0x40100FC")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 PFJ\u0081[By;

		// Token: 0x040100FD RID: 65789
		[Token(Token = "0x40100FD")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1130B8C", Offset = "0x1130B8C")]
		private bool <S[{Qywu>k__BackingField;

		// Token: 0x020026B0 RID: 9904
		[Token(Token = "0x20026B0")]
		public enum kkpE~GL
		{
			// Token: 0x040100FF RID: 65791
			[Token(Token = "0x40100FF")]
			AIRDROPNORMAL,
			// Token: 0x04010100 RID: 65792
			[Token(Token = "0x4010100")]
			AIRDROPPACKAGE
		}

		// Token: 0x020026B1 RID: 9905
		[Token(Token = "0x20026B1")]
		private class zSFDrK : ShadowStateBase
		{
			// Token: 0x0600CD33 RID: 52531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CD33")]
			[Address(RVA = "0x18C1E00", Offset = "0x18C1E00", VA = "0x7BBC0C1E00")]
			public zSFDrK()
			{
			}

			// Token: 0x04010101 RID: 65793
			[Token(Token = "0x4010101")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 rTT^h\u007FJ;

			// Token: 0x04010102 RID: 65794
			[Token(Token = "0x4010102")]
			[FieldOffset(Offset = "0x24")]
			public Quaternion t~{UBjj;

			// Token: 0x04010103 RID: 65795
			[Token(Token = "0x4010103")]
			[FieldOffset(Offset = "0x34")]
			public Vector3 |ZprCW};

			// Token: 0x04010104 RID: 65796
			[Token(Token = "0x4010104")]
			[FieldOffset(Offset = "0x40")]
			public Quaternion VM\u0081a^HA;

			// Token: 0x04010105 RID: 65797
			[Token(Token = "0x4010105")]
			[FieldOffset(Offset = "0x50")]
			public Vector3 L\u0080FEeoZ;
		}
	}
}
