using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails
{
	// Token: 0x02001080 RID: 4224
	[Token(Token = "0x2001080")]
	[Serializable]
	public class PCTrailRendererData
	{
		// Token: 0x060040B8 RID: 16568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040B8")]
		[Address(RVA = "0x249A678", Offset = "0x249A678", VA = "0x7BBCC9A678")]
		public PCTrailRendererData()
		{
		}

		// Token: 0x0400503A RID: 20538
		[Token(Token = "0x400503A")]
		[FieldOffset(Offset = "0x10")]
		public Material TrailMaterial;

		// Token: 0x0400503B RID: 20539
		[Token(Token = "0x400503B")]
		[FieldOffset(Offset = "0x18")]
		public float Lifetime;

		// Token: 0x0400503C RID: 20540
		[Token(Token = "0x400503C")]
		[FieldOffset(Offset = "0x1C")]
		public bool UsingSimpleSize;

		// Token: 0x0400503D RID: 20541
		[Token(Token = "0x400503D")]
		[FieldOffset(Offset = "0x20")]
		public float SimpleSizeOverLifeStart;

		// Token: 0x0400503E RID: 20542
		[Token(Token = "0x400503E")]
		[FieldOffset(Offset = "0x24")]
		public float SimpleSizeOverLifeEnd;

		// Token: 0x0400503F RID: 20543
		[Token(Token = "0x400503F")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve SizeOverLife;

		// Token: 0x04005040 RID: 20544
		[Token(Token = "0x4005040")]
		[FieldOffset(Offset = "0x30")]
		public bool UsingSimpleColor;

		// Token: 0x04005041 RID: 20545
		[Token(Token = "0x4005041")]
		[FieldOffset(Offset = "0x34")]
		public Color SimpleColorOverLifeStart;

		// Token: 0x04005042 RID: 20546
		[Token(Token = "0x4005042")]
		[FieldOffset(Offset = "0x44")]
		public Color SimpleColorOverLifeEnd;

		// Token: 0x04005043 RID: 20547
		[Token(Token = "0x4005043")]
		[FieldOffset(Offset = "0x58")]
		public Gradient ColorOverLife;

		// Token: 0x04005044 RID: 20548
		[Token(Token = "0x4005044")]
		[FieldOffset(Offset = "0x60")]
		public bool StretchSizeToFit;

		// Token: 0x04005045 RID: 20549
		[Token(Token = "0x4005045")]
		[FieldOffset(Offset = "0x61")]
		public bool StretchColorToFit;

		// Token: 0x04005046 RID: 20550
		[Token(Token = "0x4005046")]
		[FieldOffset(Offset = "0x64")]
		public float MaterialTileLength;

		// Token: 0x04005047 RID: 20551
		[Token(Token = "0x4005047")]
		[FieldOffset(Offset = "0x68")]
		public bool UseForwardOverride;

		// Token: 0x04005048 RID: 20552
		[Token(Token = "0x4005048")]
		[FieldOffset(Offset = "0x6C")]
		public Vector3 ForwardOverride;

		// Token: 0x04005049 RID: 20553
		[Token(Token = "0x4005049")]
		[FieldOffset(Offset = "0x78")]
		public bool ForwardOverrideRelative;
	}
}
