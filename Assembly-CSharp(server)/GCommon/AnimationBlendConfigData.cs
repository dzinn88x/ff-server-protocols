using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000EEB RID: 3819
	[Token(Token = "0x2000EEB")]
	public class AnimationBlendConfigData : CSVBaseData
	{
		// Token: 0x0600353F RID: 13631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600353F")]
		[Address(RVA = "0x25D8324", Offset = "0x25D8324", VA = "0x7BBCDD8324", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003540")]
		[Address(RVA = "0x25D8330", Offset = "0x25D8330", VA = "0x7BBCDD8330", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x00010020 File Offset: 0x0000E220
		[Token(Token = "0x6003541")]
		[Address(RVA = "0x25D8750", Offset = "0x25D8750", VA = "0x7BBCDD8750")]
		public static long MakeTransitionID(AnimationID fadeOutAnim, AnimationID fadeInAnim)
		{
			return 0L;
		}

		// Token: 0x06003542 RID: 13634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003542")]
		[Address(RVA = "0x25D8944", Offset = "0x25D8944", VA = "0x7BBCDD8944")]
		public AnimationBlendConfigData()
		{
		}

		// Token: 0x040048A7 RID: 18599
		[Token(Token = "0x40048A7")]
		[FieldOffset(Offset = "0x10")]
		public long TransitionID;

		// Token: 0x040048A8 RID: 18600
		[Token(Token = "0x40048A8")]
		[FieldOffset(Offset = "0x18")]
		public bool UseFixedDuration;

		// Token: 0x040048A9 RID: 18601
		[Token(Token = "0x40048A9")]
		[FieldOffset(Offset = "0x1C")]
		public float TransitionDuration;
	}
}
