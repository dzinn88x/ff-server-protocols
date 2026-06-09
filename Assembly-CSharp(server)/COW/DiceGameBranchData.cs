using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001391 RID: 5009
	[Token(Token = "0x2001391")]
	public class DiceGameBranchData
	{
		// Token: 0x060050C5 RID: 20677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050C5")]
		[Address(RVA = "0x1605FC0", Offset = "0x1605FC0", VA = "0x7BBBE05FC0")]
		public DiceGameBranchData()
		{
		}

		// Token: 0x0400774F RID: 30543
		[Token(Token = "0x400774F")]
		[FieldOffset(Offset = "0x10")]
		public EDiceGameBranchStyle style;

		// Token: 0x04007750 RID: 30544
		[Token(Token = "0x4007750")]
		[FieldOffset(Offset = "0x18")]
		public string Desc;

		// Token: 0x04007751 RID: 30545
		[Token(Token = "0x4007751")]
		[FieldOffset(Offset = "0x20")]
		public string WndTitle;

		// Token: 0x04007752 RID: 30546
		[Token(Token = "0x4007752")]
		[FieldOffset(Offset = "0x28")]
		public Action Opt1;

		// Token: 0x04007753 RID: 30547
		[Token(Token = "0x4007753")]
		[FieldOffset(Offset = "0x30")]
		public Action Opt2;

		// Token: 0x04007754 RID: 30548
		[Token(Token = "0x4007754")]
		[FieldOffset(Offset = "0x38")]
		public uint para1;

		// Token: 0x04007755 RID: 30549
		[Token(Token = "0x4007755")]
		[FieldOffset(Offset = "0x3C")]
		public uint para2;

		// Token: 0x04007756 RID: 30550
		[Token(Token = "0x4007756")]
		[FieldOffset(Offset = "0x40")]
		public string Opt1Key;

		// Token: 0x04007757 RID: 30551
		[Token(Token = "0x4007757")]
		[FieldOffset(Offset = "0x48")]
		public string Opt2Key;

		// Token: 0x04007758 RID: 30552
		[Token(Token = "0x4007758")]
		[FieldOffset(Offset = "0x50")]
		public Action CloseAction;
	}
}
