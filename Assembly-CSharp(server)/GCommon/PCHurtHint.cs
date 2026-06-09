using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EAE RID: 3758
	[Token(Token = "0x2000EAE")]
	public class PCHurtHint : MonoBehaviour
	{
		// Token: 0x06003377 RID: 13175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003377")]
		[Address(RVA = "0x246D4B8", Offset = "0x246D4B8", VA = "0x7BBCC6D4B8")]
		public PCHurtHint()
		{
		}

		// Token: 0x04004798 RID: 18328
		[Token(Token = "0x4004798")]
		[FieldOffset(Offset = "0x18")]
		public GameObject HintGo;

		// Token: 0x04004799 RID: 18329
		[Token(Token = "0x4004799")]
		[FieldOffset(Offset = "0x20")]
		public TweenAlpha HitGoAlpha;

		// Token: 0x0400479A RID: 18330
		[Token(Token = "0x400479A")]
		[FieldOffset(Offset = "0x28")]
		public TweenScale ArrowScale;

		// Token: 0x0400479B RID: 18331
		[Token(Token = "0x400479B")]
		[FieldOffset(Offset = "0x30")]
		public TweenColor ArrowColor;

		// Token: 0x0400479C RID: 18332
		[Token(Token = "0x400479C")]
		[FieldOffset(Offset = "0x38")]
		public TweenColor ArcColor;

		// Token: 0x0400479D RID: 18333
		[Token(Token = "0x400479D")]
		[FieldOffset(Offset = "0x40")]
		public int HintDurationTime;

		// Token: 0x0400479E RID: 18334
		[Token(Token = "0x400479E")]
		[FieldOffset(Offset = "0x44")]
		public float ArrowUpTime;

		// Token: 0x0400479F RID: 18335
		[Token(Token = "0x400479F")]
		[FieldOffset(Offset = "0x48")]
		public float ArrowDownTime;

		// Token: 0x040047A0 RID: 18336
		[Token(Token = "0x40047A0")]
		[FieldOffset(Offset = "0x4C")]
		public Vector3 ArrowDelateScale;

		// Token: 0x040047A1 RID: 18337
		[Token(Token = "0x40047A1")]
		[FieldOffset(Offset = "0x58")]
		public int MaxHitLevel;

		// Token: 0x040047A2 RID: 18338
		[Token(Token = "0x40047A2")]
		[FieldOffset(Offset = "0x60")]
		public float[] LevelTime;

		// Token: 0x040047A3 RID: 18339
		[Token(Token = "0x40047A3")]
		[FieldOffset(Offset = "0x68")]
		public Color NormalColor;

		// Token: 0x040047A4 RID: 18340
		[Token(Token = "0x40047A4")]
		[FieldOffset(Offset = "0x78")]
		public Color DeepColor;
	}
}
