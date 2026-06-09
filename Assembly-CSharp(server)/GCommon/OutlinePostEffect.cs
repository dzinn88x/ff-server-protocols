using System;
using Il2CppDummyDll;
using UnityStandardAssets.ImageEffects;

namespace GCommon
{
	// Token: 0x02000ED9 RID: 3801
	[Token(Token = "0x2000ED9")]
	public class OutlinePostEffect : PostEffectsBase
	{
		// Token: 0x060034A0 RID: 13472 RVA: 0x0000FD38 File Offset: 0x0000DF38
		[Token(Token = "0x60034A0")]
		[Address(RVA = "0x246C8F8", Offset = "0x246C8F8", VA = "0x7BBCC6C8F8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034A1")]
		[Address(RVA = "0x246C900", Offset = "0x246C900", VA = "0x7BBCC6C900")]
		public OutlinePostEffect()
		{
		}

		// Token: 0x04004845 RID: 18501
		[Token(Token = "0x4004845")]
		[FieldOffset(Offset = "0x28")]
		public float farClipPlane;

		// Token: 0x04004846 RID: 18502
		[Token(Token = "0x4004846")]
		[FieldOffset(Offset = "0x2C")]
		public float width;

		// Token: 0x04004847 RID: 18503
		[Token(Token = "0x4004847")]
		[FieldOffset(Offset = "0x30")]
		public float brightness;

		// Token: 0x04004848 RID: 18504
		[Token(Token = "0x4004848")]
		[FieldOffset(Offset = "0x34")]
		public float brightnessWidth;

		// Token: 0x04004849 RID: 18505
		[Token(Token = "0x4004849")]
		[FieldOffset(Offset = "0x38")]
		public int blurIterations;
	}
}
