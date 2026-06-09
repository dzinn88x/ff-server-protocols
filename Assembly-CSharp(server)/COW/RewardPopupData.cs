using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200165F RID: 5727
	[Token(Token = "0x200165F")]
	public class RewardPopupData
	{
		// Token: 0x0600676E RID: 26478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676E")]
		[Address(RVA = "0x175DC40", Offset = "0x175DC40", VA = "0x7BBBF5DC40")]
		public RewardPopupData(List<BaseItemInfo> reward_list)
		{
		}

		// Token: 0x0600676F RID: 26479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676F")]
		[Address(RVA = "0x175DC78", Offset = "0x175DC78", VA = "0x7BBBF5DC78")]
		public RewardPopupData(List<BaseItemInfo> reward_list, bool isGift)
		{
		}

		// Token: 0x06006770 RID: 26480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006770")]
		[Address(RVA = "0x175DCB0", Offset = "0x175DCB0", VA = "0x7BBBF5DCB0")]
		public RewardPopupData(List<BaseItemInfo> reward_list, string title)
		{
		}

		// Token: 0x06006771 RID: 26481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006771")]
		[Address(RVA = "0x175DCF4", Offset = "0x175DCF4", VA = "0x7BBBF5DCF4")]
		public RewardPopupData(List<BaseItemInfo> reward_list, string title, RewardBtn btn_data)
		{
		}

		// Token: 0x06006772 RID: 26482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006772")]
		[Address(RVA = "0x175DD3C", Offset = "0x175DD3C", VA = "0x7BBBF5DD3C")]
		public RewardPopupData(List<BaseItemInfo> reward_list, string title, RewardBtn btn_data, string transfer_hint)
		{
		}

		// Token: 0x06006773 RID: 26483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006773")]
		[Address(RVA = "0x175DD90", Offset = "0x175DD90", VA = "0x7BBBF5DD90")]
		public RewardPopupData(List<BaseItemInfo> reward_list, string title, RewardBtn btn_data, string transfer_hint, bool needmerge)
		{
		}

		// Token: 0x040084CA RID: 33994
		[Token(Token = "0x40084CA")]
		[FieldOffset(Offset = "0x10")]
		public List<BaseItemInfo> RewardList;

		// Token: 0x040084CB RID: 33995
		[Token(Token = "0x40084CB")]
		[FieldOffset(Offset = "0x18")]
		public string Title;

		// Token: 0x040084CC RID: 33996
		[Token(Token = "0x40084CC")]
		[FieldOffset(Offset = "0x20")]
		public RewardBtn BtnData;

		// Token: 0x040084CD RID: 33997
		[Token(Token = "0x40084CD")]
		[FieldOffset(Offset = "0x28")]
		public string TransferHint;

		// Token: 0x040084CE RID: 33998
		[Token(Token = "0x40084CE")]
		[FieldOffset(Offset = "0x30")]
		public bool NeedMerge;
	}
}
