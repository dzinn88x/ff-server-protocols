using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020028C7 RID: 10439
	[Token(Token = "0x20028C7")]
	internal class LevelUAV : AttackableEntity
	{
		// Token: 0x0600DD1A RID: 56602 RVA: 0x0003D2D8 File Offset: 0x0003B4D8
		[Token(Token = "0x600DD1A")]
		[Address(RVA = "0x1D467A8", Offset = "0x1D467A8", VA = "0x7BBC5467A8", Slot = "22")]
		protected override int GetMaxRepDataCount()
		{
			return 0;
		}

		// Token: 0x0600DD1B RID: 56603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD1B")]
		[Address(RVA = "0x1D467B0", Offset = "0x1D467B0", VA = "0x7BBC5467B0")]
		public void Init(uint RMyQn\u007FA, uint cyhvhI\u0082 = 0U, uint SfusqvD = 0U)
		{
		}

		// Token: 0x0600DD1C RID: 56604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD1C")]
		[Address(RVA = "0x1D4698C", Offset = "0x1D4698C", VA = "0x7BBC54698C")]
		public void PushSyncState(Vector3 \u007FefF\u0081U^, uint ~||\u0082utT)
		{
		}

		// Token: 0x0600DD1D RID: 56605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD1D")]
		[Address(RVA = "0x1D46BE4", Offset = "0x1D46BE4", VA = "0x7BBC546BE4", Slot = "14")]
		public override void OnFixedUpdate(float \u0081}x[tOF, float OsUltaA)
		{
		}

		// Token: 0x0600DD1E RID: 56606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD1E")]
		[Address(RVA = "0x1D471B0", Offset = "0x1D471B0", VA = "0x7BBC5471B0", Slot = "48")]
		public override void TakeDamage(woZmHkA JkgWmeJ, [Optional] ohSG[ek \u0081{zLQ\u007FM, [Optional] List<float> `KEFVvE, uint iYO}d|F = 0U)
		{
		}

		// Token: 0x0600DD1F RID: 56607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD1F")]
		[Address(RVA = "0x1D474CC", Offset = "0x1D474CC", VA = "0x7BBC5474CC")]
		public void Dead(int \u0082e}hHlf)
		{
		}

		// Token: 0x0600DD20 RID: 56608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD20")]
		[Address(RVA = "0x1D470F0", Offset = "0x1D470F0", VA = "0x7BBC5470F0")]
		public void UpdateAnim(float aixgwfQ)
		{
		}

		// Token: 0x0600DD21 RID: 56609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DD21")]
		[Address(RVA = "0x1D47870", Offset = "0x1D47870", VA = "0x7BBC547870")]
		private CommonParticleEffect xdYCtFz(ResourceID WohWctT, ResourceID vDjNXFh)
		{
			return null;
		}

		// Token: 0x0600DD22 RID: 56610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD22")]
		[Address(RVA = "0x1D47BA8", Offset = "0x1D47BA8", VA = "0x7BBC547BA8")]
		public LevelUAV()
		{
		}

		// Token: 0x04010D15 RID: 68885
		[Token(Token = "0x4010D15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected uint Kpikoyc;

		// Token: 0x04010D16 RID: 68886
		[Token(Token = "0x4010D16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected LevelUAV.zSFDrK \u0082iAgQB^;

		// Token: 0x04010D17 RID: 68887
		[Token(Token = "0x4010D17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public uint UAV_ID;

		// Token: 0x04010D18 RID: 68888
		[Token(Token = "0x4010D18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject m_ModelObject;

		// Token: 0x04010D19 RID: 68889
		[Token(Token = "0x4010D19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Animation m_Animation;

		// Token: 0x04010D1A RID: 68890
		[Token(Token = "0x4010D1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool \u0080rKLL;

		// Token: 0x04010D1B RID: 68891
		[Token(Token = "0x4010D1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public {QAb\u0082~u m_OwnerID;

		// Token: 0x04010D1C RID: 68892
		[Token(Token = "0x4010D1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public uint m_UAVItemID;

		// Token: 0x04010D1D RID: 68893
		[Token(Token = "0x4010D1D")]
		public const string IdleAnimName = "Idle";

		// Token: 0x04010D1E RID: 68894
		[Token(Token = "0x4010D1E")]
		public const string FlyAnimName = "Fly_F";

		// Token: 0x04010D1F RID: 68895
		[Token(Token = "0x4010D1F")]
		public const string ANIM_SPEED_PARAM = "Speed";

		// Token: 0x020028C8 RID: 10440
		[Token(Token = "0x20028C8")]
		protected class zSFDrK : ShadowStateBase
		{
			// Token: 0x0600DD23 RID: 56611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DD23")]
			[Address(RVA = "0x1D47C50", Offset = "0x1D47C50", VA = "0x7BBC547C50")]
			public zSFDrK()
			{
			}

			// Token: 0x04010D20 RID: 68896
			[Token(Token = "0x4010D20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 |ZprCW};

			// Token: 0x04010D21 RID: 68897
			[Token(Token = "0x4010D21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 rTT^h\u007FJ;

			// Token: 0x04010D22 RID: 68898
			[Token(Token = "0x4010D22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Quaternion VM\u0081a^HA;

			// Token: 0x04010D23 RID: 68899
			[Token(Token = "0x4010D23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Quaternion t~{UBjj;
		}
	}
}
