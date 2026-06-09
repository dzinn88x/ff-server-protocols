using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C92 RID: 7314
	[Token(Token = "0x2001C92")]
	public class RebateItemData
	{
		// Token: 0x06009FAE RID: 40878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FAE")]
		[Address(RVA = "0x17522F8", Offset = "0x17522F8", VA = "0x7BBBF522F8")]
		public RebateItemData()
		{
		}

		// Token: 0x0400A664 RID: 42596
		[Token(Token = "0x400A664")]
		[FieldOffset(Offset = "0x10")]
		public long RebateId;

		// Token: 0x0400A665 RID: 42597
		[Token(Token = "0x400A665")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x0400A666 RID: 42598
		[Token(Token = "0x400A666")]
		[FieldOffset(Offset = "0x20")]
		public string Description;

		// Token: 0x0400A667 RID: 42599
		[Token(Token = "0x400A667")]
		[FieldOffset(Offset = "0x28")]
		public int TotalDays;

		// Token: 0x0400A668 RID: 42600
		[Token(Token = "0x400A668")]
		[FieldOffset(Offset = "0x2C")]
		public int RemainingDays;

		// Token: 0x0400A669 RID: 42601
		[Token(Token = "0x400A669")]
		[FieldOffset(Offset = "0x30")]
		public int VirtualCurrencyAmunt;

		// Token: 0x0400A66A RID: 42602
		[Token(Token = "0x400A66A")]
		[FieldOffset(Offset = "0x34")]
		public bool CanBuy;

		// Token: 0x0400A66B RID: 42603
		[Token(Token = "0x400A66B")]
		[FieldOffset(Offset = "0x35")]
		public bool CanRedeem;

		// Token: 0x0400A66C RID: 42604
		[Token(Token = "0x400A66C")]
		[FieldOffset(Offset = "0x36")]
		public bool Owned;
	}
}
