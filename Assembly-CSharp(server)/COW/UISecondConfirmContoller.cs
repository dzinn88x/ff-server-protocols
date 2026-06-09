using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B78 RID: 7032
	[Token(Token = "0x2001B78")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA254", Offset = "0x10FA254")]
	public class UISecondConfirmContoller : UIPopupWindowController
	{
		// Token: 0x0600977D RID: 38781 RVA: 0x00027F78 File Offset: 0x00026178
		[Token(Token = "0x600977D")]
		[Address(RVA = "0x162E66C", Offset = "0x162E66C", VA = "0x7BBBE2E66C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600977E RID: 38782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600977E")]
		[Address(RVA = "0x162E6BC", Offset = "0x162E6BC", VA = "0x7BBBE2E6BC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600977F RID: 38783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600977F")]
		[Address(RVA = "0x162E8BC", Offset = "0x162E8BC", VA = "0x7BBBE2E8BC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009780 RID: 38784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009780")]
		[Address(RVA = "0x162E988", Offset = "0x162E988", VA = "0x7BBBE2E988")]
		private void OnAssetRefresh(params object[] param)
		{
		}

		// Token: 0x06009781 RID: 38785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009781")]
		[Address(RVA = "0x162E990", Offset = "0x162E990", VA = "0x7BBBE2E990")]
		protected void OnCancelClick()
		{
		}

		// Token: 0x06009782 RID: 38786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009782")]
		[Address(RVA = "0x162E9C4", Offset = "0x162E9C4", VA = "0x7BBBE2E9C4")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x06009783 RID: 38787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009783")]
		[Address(RVA = "0x162E9F8", Offset = "0x162E9F8", VA = "0x7BBBE2E9F8")]
		public void SetData(UISecondConfirmContoller.Style style, [Optional] List<BaseItemInfo> goods, string oneText = "")
		{
		}

		// Token: 0x06009784 RID: 38788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009784")]
		[Address(RVA = "0x162EB04", Offset = "0x162EB04", VA = "0x7BBBE2EB04")]
		private void CreateIconGoodss()
		{
		}

		// Token: 0x06009785 RID: 38789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009785")]
		[Address(RVA = "0x162ECA4", Offset = "0x162ECA4", VA = "0x7BBBE2ECA4")]
		private void CreateTextGoods()
		{
		}

		// Token: 0x06009786 RID: 38790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009786")]
		[Address(RVA = "0x162F05C", Offset = "0x162F05C", VA = "0x7BBBE2F05C")]
		private void CreateOneText()
		{
		}

		// Token: 0x06009787 RID: 38791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009787")]
		[Address(RVA = "0x162F2A4", Offset = "0x162F2A4", VA = "0x7BBBE2F2A4")]
		public void SetOneTextAlignment(NGUIText.Alignment alignment)
		{
		}

		// Token: 0x06009788 RID: 38792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009788")]
		[Address(RVA = "0x162F2EC", Offset = "0x162F2EC", VA = "0x7BBBE2F2EC")]
		public void SetTitle(string title)
		{
		}

		// Token: 0x06009789 RID: 38793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009789")]
		[Address(RVA = "0x162F324", Offset = "0x162F324", VA = "0x7BBBE2F324")]
		public void SetConfirmBtnText(string text)
		{
		}

		// Token: 0x0600978A RID: 38794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600978A")]
		[Address(RVA = "0x162F36C", Offset = "0x162F36C", VA = "0x7BBBE2F36C")]
		public void SetConfirmText(string text)
		{
		}

		// Token: 0x0600978B RID: 38795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600978B")]
		[Address(RVA = "0x162F3B4", Offset = "0x162F3B4", VA = "0x7BBBE2F3B4")]
		public void ShowCancelButton()
		{
		}

		// Token: 0x0600978C RID: 38796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600978C")]
		[Address(RVA = "0x162F410", Offset = "0x162F410", VA = "0x7BBBE2F410")]
		public void SetConfirmCallback(Action action)
		{
		}

		// Token: 0x0600978D RID: 38797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600978D")]
		[Address(RVA = "0x162F418", Offset = "0x162F418", VA = "0x7BBBE2F418")]
		public void SetCancelCallback(Action action)
		{
		}

		// Token: 0x0600978E RID: 38798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600978E")]
		[Address(RVA = "0x162F420", Offset = "0x162F420", VA = "0x7BBBE2F420", Slot = "38")]
		public override void EnterByReturn()
		{
		}

		// Token: 0x0600978F RID: 38799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600978F")]
		[Address(RVA = "0x162F50C", Offset = "0x162F50C", VA = "0x7BBBE2F50C")]
		public UISecondConfirmContoller()
		{
		}

		// Token: 0x04009F9B RID: 40859
		[Token(Token = "0x4009F9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UISecondConfirmView m_View;

		// Token: 0x04009F9C RID: 40860
		[Token(Token = "0x4009F9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<BaseItemInfo> m_Items;

		// Token: 0x04009F9D RID: 40861
		[Token(Token = "0x4009F9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private string m_OneText;

		// Token: 0x04009F9E RID: 40862
		[Token(Token = "0x4009F9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Action m_ConfirmAction;

		// Token: 0x04009F9F RID: 40863
		[Token(Token = "0x4009F9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Action m_CancelAction;

		// Token: 0x02001B79 RID: 7033
		[Token(Token = "0x2001B79")]
		public enum Style
		{
			// Token: 0x04009FA1 RID: 40865
			[Token(Token = "0x4009FA1")]
			IconGoods,
			// Token: 0x04009FA2 RID: 40866
			[Token(Token = "0x4009FA2")]
			TextGoods,
			// Token: 0x04009FA3 RID: 40867
			[Token(Token = "0x4009FA3")]
			OneText
		}
	}
}
