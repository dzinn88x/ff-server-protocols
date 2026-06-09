using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000EA8 RID: 3752
	[Token(Token = "0x2000EA8")]
	public class AnimationLayerDef
	{
		// Token: 0x0600335E RID: 13150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600335E")]
		[Address(RVA = "0x25D9DA4", Offset = "0x25D9DA4", VA = "0x7BBCDD9DA4")]
		public AnimationLayerDef()
		{
		}

		// Token: 0x040046F6 RID: 18166
		[Token(Token = "0x40046F6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int BASE_LAYER;

		// Token: 0x040046F7 RID: 18167
		[Token(Token = "0x40046F7")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int UPPER_BODY_LAYER;

		// Token: 0x040046F8 RID: 18168
		[Token(Token = "0x40046F8")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int UPPER_BODY_ADDITIVE_LAYER;

		// Token: 0x040046F9 RID: 18169
		[Token(Token = "0x40046F9")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int LAYER_NB;

		// Token: 0x040046FA RID: 18170
		[Token(Token = "0x40046FA")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string[] LayerNames;
	}
}
