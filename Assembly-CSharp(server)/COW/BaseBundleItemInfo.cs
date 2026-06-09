using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001C49 RID: 7241
	[Token(Token = "0x2001C49")]
	public class BaseBundleItemInfo
	{
		// Token: 0x06009D6E RID: 40302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D6E")]
		[Address(RVA = "0x21CDEA4", Offset = "0x21CDEA4", VA = "0x7BBC9CDEA4")]
		public BaseBundleItemInfo(BundleShowData bundleitem)
		{
		}

		// Token: 0x06009D6F RID: 40303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D6F")]
		[Address(RVA = "0x21CDF1C", Offset = "0x21CDF1C", VA = "0x7BBC9CDF1C")]
		public BaseBundleItemInfo(TreasureBoxShowData bundleitem)
		{
		}

		// Token: 0x0400A386 RID: 41862
		[Token(Token = "0x400A386")]
		[FieldOffset(Offset = "0x10")]
		public uint award_id;

		// Token: 0x0400A387 RID: 41863
		[Token(Token = "0x400A387")]
		[FieldOffset(Offset = "0x14")]
		public bool is_preview;

		// Token: 0x0400A388 RID: 41864
		[Token(Token = "0x400A388")]
		[FieldOffset(Offset = "0x18")]
		public uint preview_avatar;
	}
}
