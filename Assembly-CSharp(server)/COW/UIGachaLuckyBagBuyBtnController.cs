using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200180C RID: 6156
	[Token(Token = "0x200180C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F34CC", Offset = "0x10F34CC")]
	public class UIGachaLuckyBagBuyBtnController : UIGachaBuyBtnController
	{
		// Token: 0x060077B7 RID: 30647 RVA: 0x00021168 File Offset: 0x0001F368
		[Token(Token = "0x60077B7")]
		[Address(RVA = "0x2066844", Offset = "0x2066844", VA = "0x7BBC866844")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060077B8 RID: 30648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077B8")]
		[Address(RVA = "0x2066894", Offset = "0x2066894", VA = "0x7BBC866894", Slot = "28")]
		protected override void InitBuyBtnBaseView()
		{
		}

		// Token: 0x060077B9 RID: 30649 RVA: 0x00021180 File Offset: 0x0001F380
		[Token(Token = "0x60077B9")]
		[Address(RVA = "0x20668C8", Offset = "0x20668C8", VA = "0x7BBC8668C8", Slot = "29")]
		public override bool OnBeforeSingleBuy(bool isRepurchase)
		{
			return default(bool);
		}

		// Token: 0x060077BA RID: 30650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077BA")]
		[Address(RVA = "0x2066C28", Offset = "0x2066C28", VA = "0x7BBC866C28", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060077BB RID: 30651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077BB")]
		[Address(RVA = "0x2066C88", Offset = "0x2066C88", VA = "0x7BBC866C88", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060077BC RID: 30652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077BC")]
		[Address(RVA = "0x2066C90", Offset = "0x2066C90", VA = "0x7BBC866C90", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060077BD RID: 30653 RVA: 0x00021198 File Offset: 0x0001F398
		[Token(Token = "0x60077BD")]
		[Address(RVA = "0x20669F4", Offset = "0x20669F4", VA = "0x7BBC8669F4")]
		private bool IsAllRewardsOwned()
		{
			return default(bool);
		}

		// Token: 0x060077BE RID: 30654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077BE")]
		[Address(RVA = "0x2066C98", Offset = "0x2066C98", VA = "0x7BBC866C98")]
		public UIGachaLuckyBagBuyBtnController()
		{
		}

		// Token: 0x04008E05 RID: 36357
		[Token(Token = "0x4008E05")]
		[FieldOffset(Offset = "0x78")]
		private UIGachaLuckyBagBuyBtnView m_LuckyBagView;
	}
}
