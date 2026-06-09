using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017FB RID: 6139
	[Token(Token = "0x20017FB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3334", Offset = "0x10F3334")]
	public class UIGachaLegendaryBuyBtnController : UIGachaBuyBtnController
	{
		// Token: 0x0600773F RID: 30527 RVA: 0x00020F70 File Offset: 0x0001F170
		[Token(Token = "0x600773F")]
		[Address(RVA = "0x2056F38", Offset = "0x2056F38", VA = "0x7BBC856F38")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007740")]
		[Address(RVA = "0x2056F88", Offset = "0x2056F88", VA = "0x7BBC856F88", Slot = "28")]
		protected override void InitBuyBtnBaseView()
		{
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007741")]
		[Address(RVA = "0x2056FBC", Offset = "0x2056FBC", VA = "0x7BBC856FBC")]
		public void RefreshPurchaseInfo(uint gachaID)
		{
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x00020F88 File Offset: 0x0001F188
		[Token(Token = "0x6007742")]
		[Address(RVA = "0x205700C", Offset = "0x205700C", VA = "0x7BBC85700C", Slot = "29")]
		public override bool OnBeforeSingleBuy(bool isRepurchase)
		{
			return default(bool);
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x00020FA0 File Offset: 0x0001F1A0
		[Token(Token = "0x6007743")]
		[Address(RVA = "0x2057160", Offset = "0x2057160", VA = "0x7BBC857160", Slot = "30")]
		public override bool OnBeforeMultiBuy(bool isRepurchase)
		{
			return default(bool);
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007744")]
		[Address(RVA = "0x20572B4", Offset = "0x20572B4", VA = "0x7BBC8572B4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007745")]
		[Address(RVA = "0x2057314", Offset = "0x2057314", VA = "0x7BBC857314", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007746")]
		[Address(RVA = "0x205731C", Offset = "0x205731C", VA = "0x7BBC85731C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007747")]
		[Address(RVA = "0x2057324", Offset = "0x2057324", VA = "0x7BBC857324")]
		public UIGachaLegendaryBuyBtnController()
		{
		}

		// Token: 0x04008DAE RID: 36270
		[Token(Token = "0x4008DAE")]
		[FieldOffset(Offset = "0x78")]
		private UIGachaLegendaryBuyBtnView m_LegendaryBuyBtnView;

		// Token: 0x04008DAF RID: 36271
		[Token(Token = "0x4008DAF")]
		[FieldOffset(Offset = "0x80")]
		private uint m_GachaID;

		// Token: 0x04008DB0 RID: 36272
		[Token(Token = "0x4008DB0")]
		[FieldOffset(Offset = "0x88")]
		private GachaDesc m_Desc;
	}
}
