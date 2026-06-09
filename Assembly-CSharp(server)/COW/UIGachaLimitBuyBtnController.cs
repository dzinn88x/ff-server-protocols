using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020017FF RID: 6143
	[Token(Token = "0x20017FF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F336C", Offset = "0x10F336C")]
	internal class UIGachaLimitBuyBtnController : UIGachaBuyBtnController
	{
		// Token: 0x06007751 RID: 30545 RVA: 0x00020FD0 File Offset: 0x0001F1D0
		[Token(Token = "0x6007751")]
		[Address(RVA = "0x205D524", Offset = "0x205D524", VA = "0x7BBC85D524")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007752")]
		[Address(RVA = "0x205D574", Offset = "0x205D574", VA = "0x7BBC85D574", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007753")]
		[Address(RVA = "0x205D5D4", Offset = "0x205D5D4", VA = "0x7BBC85D5D4", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007754")]
		[Address(RVA = "0x205D5DC", Offset = "0x205D5DC", VA = "0x7BBC85D5DC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007755 RID: 30549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007755")]
		[Address(RVA = "0x205D5E4", Offset = "0x205D5E4", VA = "0x7BBC85D5E4", Slot = "28")]
		protected override void InitBuyBtnBaseView()
		{
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007756")]
		[Address(RVA = "0x205D618", Offset = "0x205D618", VA = "0x7BBC85D618", Slot = "31")]
		protected override void OnRefreshBuyBtn()
		{
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007757")]
		[Address(RVA = "0x205D698", Offset = "0x205D698", VA = "0x7BBC85D698")]
		public UIGachaLimitBuyBtnController()
		{
		}

		// Token: 0x04008DC3 RID: 36291
		[Token(Token = "0x4008DC3")]
		[FieldOffset(Offset = "0x78")]
		private UIGachaLimitBuyBtnView m_LimitView;
	}
}
