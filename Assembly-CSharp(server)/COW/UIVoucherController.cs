using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001BFA RID: 7162
	[Token(Token = "0x2001BFA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB49C", Offset = "0x10FB49C")]
	public abstract class UIVoucherController : UIBaseController
	{
		// Token: 0x06009BA3 RID: 39843
		[Token(Token = "0x6009BA3")]
		public abstract void OnVoucherListClose(params object[] data);

		// Token: 0x06009BA4 RID: 39844
		[Token(Token = "0x6009BA4")]
		public abstract void OnVoucherItemClick(params object[] data);

		// Token: 0x06009BA5 RID: 39845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BA5")]
		[Address(RVA = "0x16840EC", Offset = "0x16840EC", VA = "0x7BBBE840EC")]
		public void RefreshTotalPrice(EInventory.CurrencyType currencyType, int totalPrice)
		{
		}

		// Token: 0x06009BA6 RID: 39846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BA6")]
		[Address(RVA = "0x1684114", Offset = "0x1684114", VA = "0x7BBBE84114")]
		public void RefreshTotalPrice(int totalGemsPrice, int totalCoinsPrice)
		{
		}

		// Token: 0x06009BA7 RID: 39847
		[Token(Token = "0x6009BA7")]
		public abstract void OnVoucherBtnClick();

		// Token: 0x06009BA8 RID: 39848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BA8")]
		[Address(RVA = "0x168411C", Offset = "0x168411C", VA = "0x7BBBE8411C", Slot = "31")]
		public virtual void RefreshVoucherData(int totalGemsPrice, int totalCoinsPrice, IVoucher voucher)
		{
		}

		// Token: 0x06009BA9 RID: 39849
		[Token(Token = "0x6009BA9")]
		public abstract void ResetSelectedVoucher();

		// Token: 0x06009BAA RID: 39850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BAA")]
		[Address(RVA = "0x1684128", Offset = "0x1684128", VA = "0x7BBBE84128")]
		protected UIVoucherController()
		{
		}

		// Token: 0x0400A1D7 RID: 41431
		[Token(Token = "0x400A1D7")]
		[FieldOffset(Offset = "0x58")]
		protected int m_TotalGemsPrice;

		// Token: 0x0400A1D8 RID: 41432
		[Token(Token = "0x400A1D8")]
		[FieldOffset(Offset = "0x5C")]
		protected int m_TotalCoinsPrice;

		// Token: 0x0400A1D9 RID: 41433
		[Token(Token = "0x400A1D9")]
		[FieldOffset(Offset = "0x60")]
		protected VoucherData m_SelectedVoucherData;

		// Token: 0x0400A1DA RID: 41434
		[Token(Token = "0x400A1DA")]
		[FieldOffset(Offset = "0x68")]
		protected IVoucher m_Voucher;
	}
}
