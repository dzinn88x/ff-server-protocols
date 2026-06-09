using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x020028A3 RID: 10403
	[Token(Token = "0x20028A3")]
	public class LevelSmokeDrum : LevelBaseDrum
	{
		// Token: 0x0600DC7E RID: 56446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DC7E")]
		[Address(RVA = "0x1D3CFE0", Offset = "0x1D3CFE0", VA = "0x7BBC53CFE0", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600DC7F RID: 56447 RVA: 0x0003D038 File Offset: 0x0003B238
		[Token(Token = "0x600DC7F")]
		[Address(RVA = "0x1D3D028", Offset = "0x1D3D028", VA = "0x7BBC53D028", Slot = "36")]
		public override ResourceID GetModelResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600DC80 RID: 56448 RVA: 0x0003D050 File Offset: 0x0003B250
		[Token(Token = "0x600DC80")]
		[Address(RVA = "0x1D3D078", Offset = "0x1D3D078", VA = "0x7BBC53D078", Slot = "38")]
		public override ResourceID GetExplodeEffect()
		{
			return default(ResourceID);
		}

		// Token: 0x0600DC81 RID: 56449 RVA: 0x0003D068 File Offset: 0x0003B268
		[Token(Token = "0x600DC81")]
		[Address(RVA = "0x1D3D0C8", Offset = "0x1D3D0C8", VA = "0x7BBC53D0C8", Slot = "39")]
		public override ResourceID GetExplodeSound()
		{
			return default(ResourceID);
		}

		// Token: 0x0600DC82 RID: 56450 RVA: 0x0003D080 File Offset: 0x0003B280
		[Token(Token = "0x600DC82")]
		[Address(RVA = "0x1D3D118", Offset = "0x1D3D118", VA = "0x7BBC53D118", Slot = "41")]
		public override float GetEffectTime()
		{
			return 0f;
		}

		// Token: 0x0600DC83 RID: 56451 RVA: 0x0003D098 File Offset: 0x0003B298
		[Token(Token = "0x600DC83")]
		[Address(RVA = "0x1D3D120", Offset = "0x1D3D120", VA = "0x7BBC53D120", Slot = "40")]
		public override LevelBaseDrum.|smcIav OilDrumType()
		{
			return LevelBaseDrum.|smcIav.None;
		}

		// Token: 0x0600DC84 RID: 56452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC84")]
		[Address(RVA = "0x1D3D128", Offset = "0x1D3D128", VA = "0x7BBC53D128", Slot = "43")]
		protected override void zyfWDnr(byte l]jgxbG, byte TzzPYjI)
		{
		}

		// Token: 0x0600DC85 RID: 56453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DC85")]
		[Address(RVA = "0x1D3D32C", Offset = "0x1D3D32C", VA = "0x7BBC53D32C")]
		public LevelSmokeDrum()
		{
		}

		// Token: 0x04010BB2 RID: 68530
		[Token(Token = "0x4010BB2")]
		[FieldOffset(Offset = "0x78")]
		public BoxCollider m_Trigger;
	}
}
