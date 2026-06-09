using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002960 RID: 10592
	[Token(Token = "0x2002960")]
	public class SafeZoneLightningMAX : Entity
	{
		// Token: 0x0600E118 RID: 57624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E118")]
		[Address(RVA = "0x173DAF4", Offset = "0x173DAF4", VA = "0x7BBBF3DAF4")]
		public SafeZoneLightningMAX()
		{
		}

		// Token: 0x04011023 RID: 69667
		[Token(Token = "0x4011023")]
		[FieldOffset(Offset = "0x30")]
		public float lightningChangeTime;

		// Token: 0x04011024 RID: 69668
		[Token(Token = "0x4011024")]
		[FieldOffset(Offset = "0x34")]
		public float secondLightningDelayTime;

		// Token: 0x04011025 RID: 69669
		[Token(Token = "0x4011025")]
		[FieldOffset(Offset = "0x38")]
		public float maxHeight;

		// Token: 0x04011026 RID: 69670
		[Token(Token = "0x4011026")]
		[FieldOffset(Offset = "0x3C")]
		public float maxDis;

		// Token: 0x04011027 RID: 69671
		[Token(Token = "0x4011027")]
		[FieldOffset(Offset = "0x40")]
		public float maxScale;

		// Token: 0x04011028 RID: 69672
		[Token(Token = "0x4011028")]
		[FieldOffset(Offset = "0x44")]
		public float maxRandomAngle;

		// Token: 0x04011029 RID: 69673
		[Token(Token = "0x4011029")]
		[FieldOffset(Offset = "0x48")]
		public List<GameObject> vfxs;
	}
}
