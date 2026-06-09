using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x020014C4 RID: 5316
	[Token(Token = "0x20014C4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED82C", Offset = "0x10ED82C")]
	internal class UIHudCSShopMysteryBoxOpenController : UIBaseController
	{
		// Token: 0x06005A6B RID: 23147 RVA: 0x0001A928 File Offset: 0x00018B28
		[Token(Token = "0x6005A6B")]
		[Address(RVA = "0x19CEA1C", Offset = "0x19CEA1C", VA = "0x7BBC1CEA1C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005A6C RID: 23148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6C")]
		[Address(RVA = "0x19CEA6C", Offset = "0x19CEA6C", VA = "0x7BBC1CEA6C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005A6D RID: 23149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6D")]
		[Address(RVA = "0x19CED04", Offset = "0x19CED04", VA = "0x7BBC1CED04", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06005A6E RID: 23150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6E")]
		[Address(RVA = "0x19CEDD0", Offset = "0x19CEDD0", VA = "0x7BBC1CEDD0", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6F")]
		[Address(RVA = "0x19CEED0", Offset = "0x19CEED0", VA = "0x7BBC1CEED0")]
		private void Update()
		{
		}

		// Token: 0x06005A70 RID: 23152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A70")]
		[Address(RVA = "0x19CF05C", Offset = "0x19CF05C", VA = "0x7BBC1CF05C")]
		public void SetUIData(List<J\u0082WW~UO> data, float duration)
		{
		}

		// Token: 0x06005A71 RID: 23153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A71")]
		[Address(RVA = "0x19CF670", Offset = "0x19CF670", VA = "0x7BBC1CF670")]
		private void OnConfirmBtnClick()
		{
		}

		// Token: 0x06005A72 RID: 23154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A72")]
		[Address(RVA = "0x19CF724", Offset = "0x19CF724", VA = "0x7BBC1CF724")]
		private void OnOptionItemSelected(params object[] data)
		{
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A73")]
		[Address(RVA = "0x19CF7F4", Offset = "0x19CF7F4", VA = "0x7BBC1CF7F4")]
		private void OnHelpBtnClick()
		{
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A74")]
		[Address(RVA = "0x19CEF38", Offset = "0x19CEF38", VA = "0x7BBC1CEF38")]
		private void AutoChooseOption()
		{
		}

		// Token: 0x06005A75 RID: 23157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A75")]
		[Address(RVA = "0x19CF9E8", Offset = "0x19CF9E8", VA = "0x7BBC1CF9E8")]
		public void OnTimeUp()
		{
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A76")]
		[Address(RVA = "0x19CF9EC", Offset = "0x19CF9EC", VA = "0x7BBC1CF9EC")]
		public UIHudCSShopMysteryBoxOpenController()
		{
		}

		// Token: 0x04007D62 RID: 32098
		[Token(Token = "0x4007D62")]
		[FieldOffset(Offset = "0x58")]
		private UIHudCSShopMysteryBoxOpenView m_View;

		// Token: 0x04007D63 RID: 32099
		[Token(Token = "0x4007D63")]
		[FieldOffset(Offset = "0x60")]
		private List<UIToggleButton> m_ListToggles;

		// Token: 0x04007D64 RID: 32100
		[Token(Token = "0x4007D64")]
		[FieldOffset(Offset = "0x68")]
		private uint m_SelectedBoxItemID;

		// Token: 0x04007D65 RID: 32101
		[Token(Token = "0x4007D65")]
		[FieldOffset(Offset = "0x6C")]
		private uint m_SelectedBoxUniqueID;

		// Token: 0x04007D66 RID: 32102
		[Token(Token = "0x4007D66")]
		[FieldOffset(Offset = "0x70")]
		private UIHudCSMysteryBoxOptionItemView.MysterBoxData m_MysteryBoxData;

		// Token: 0x04007D67 RID: 32103
		[Token(Token = "0x4007D67")]
		[FieldOffset(Offset = "0x80")]
		private List<UIHudCSMysteryBoxOptionItemView.MysterBoxData> m_OptionItemsDataList;

		// Token: 0x04007D68 RID: 32104
		[Token(Token = "0x4007D68")]
		[FieldOffset(Offset = "0x88")]
		private UIHudCommonlTipsController m_CurrentTips;

		// Token: 0x04007D69 RID: 32105
		[Token(Token = "0x4007D69")]
		[FieldOffset(Offset = "0x90")]
		private UITimeLabelHelper m_TimeHelper;
	}
}
