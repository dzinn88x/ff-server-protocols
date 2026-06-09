using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001850 RID: 6224
	[Token(Token = "0x2001850")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3CC4", Offset = "0x10F3CC4")]
	public class UIGoogleEngagementRewardsController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06007A2F RID: 31279 RVA: 0x000219C0 File Offset: 0x0001FBC0
		[Token(Token = "0x6007A2F")]
		[Address(RVA = "0x1A83D20", Offset = "0x1A83D20", VA = "0x7BBC283D20")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007A30 RID: 31280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A30")]
		[Address(RVA = "0x1A83D70", Offset = "0x1A83D70", VA = "0x7BBC283D70", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007A31 RID: 31281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A31")]
		[Address(RVA = "0x1A84A50", Offset = "0x1A84A50", VA = "0x7BBC284A50", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007A32 RID: 31282 RVA: 0x000219D8 File Offset: 0x0001FBD8
		[Token(Token = "0x6007A32")]
		[Address(RVA = "0x1A84AFC", Offset = "0x1A84AFC", VA = "0x7BBC284AFC", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007A33 RID: 31283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A33")]
		[Address(RVA = "0x1A84B80", Offset = "0x1A84B80", VA = "0x7BBC284B80", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007A34 RID: 31284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A34")]
		[Address(RVA = "0x1A842B0", Offset = "0x1A842B0", VA = "0x7BBC2842B0")]
		private void UpdateUI()
		{
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A35")]
		[Address(RVA = "0x1A85090", Offset = "0x1A85090", VA = "0x7BBC285090")]
		private void OnFirstTimeBtnClick()
		{
		}

		// Token: 0x06007A36 RID: 31286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A36")]
		[Address(RVA = "0x1A85110", Offset = "0x1A85110", VA = "0x7BBC285110")]
		private void OnGoogleAccountBtnClick()
		{
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A37")]
		[Address(RVA = "0x1A8523C", Offset = "0x1A8523C", VA = "0x7BBC28523C")]
		private void UpdateGoogleAccountsUI()
		{
		}

		// Token: 0x06007A38 RID: 31288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A38")]
		[Address(RVA = "0x1A855FC", Offset = "0x1A855FC", VA = "0x7BBC2855FC")]
		private void OnNotNowBtnClick()
		{
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A39")]
		[Address(RVA = "0x1A85668", Offset = "0x1A85668", VA = "0x7BBC285668")]
		private void OnAgreeBtnClick()
		{
		}

		// Token: 0x06007A3A RID: 31290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3A")]
		[Address(RVA = "0x1A857A0", Offset = "0x1A857A0", VA = "0x7BBC2857A0")]
		private void OnSelectedAccountBtnClick()
		{
		}

		// Token: 0x06007A3B RID: 31291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3B")]
		[Address(RVA = "0x1A85B6C", Offset = "0x1A85B6C", VA = "0x7BBC285B6C")]
		private void OnLoginBtnClick()
		{
		}

		// Token: 0x06007A3C RID: 31292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3C")]
		[Address(RVA = "0x1A85BD8", Offset = "0x1A85BD8", VA = "0x7BBC285BD8")]
		private void OnNativeLoginBtnClick()
		{
		}

		// Token: 0x06007A3D RID: 31293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3D")]
		[Address(RVA = "0x1A84E78", Offset = "0x1A84E78", VA = "0x7BBC284E78")]
		private void OnSelectedGoogleAccount(string accountName)
		{
		}

		// Token: 0x06007A3E RID: 31294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3E")]
		[Address(RVA = "0x1A85C08", Offset = "0x1A85C08", VA = "0x7BBC285C08")]
		private void OnTermsOfServiceBtnClick()
		{
		}

		// Token: 0x06007A3F RID: 31295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A3F")]
		[Address(RVA = "0x1A85CCC", Offset = "0x1A85CCC", VA = "0x7BBC285CCC")]
		private void OnHelpAndSupportBtnClick()
		{
		}

		// Token: 0x06007A40 RID: 31296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A40")]
		[Address(RVA = "0x1A85D3C", Offset = "0x1A85D3C", VA = "0x7BBC285D3C")]
		public UIGoogleEngagementRewardsController()
		{
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A41")]
		[Address(RVA = "0x1A85DAC", Offset = "0x1A85DAC", VA = "0x7BBC285DAC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11423D4", Offset = "0x11423D4")]
		private void <OnAgreeBtnClick>b__15_0(bool permitted)
		{
		}

		// Token: 0x04008F13 RID: 36627
		[Token(Token = "0x4008F13")]
		[FieldOffset(Offset = "0x98")]
		private UIGoogleEngagementRewardsView m_View;

		// Token: 0x04008F14 RID: 36628
		[Token(Token = "0x4008F14")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelGoogleEngagementRewards m_Model;

		// Token: 0x04008F15 RID: 36629
		[Token(Token = "0x4008F15")]
		[FieldOffset(Offset = "0xA8")]
		private CommunityWebsiteData m_WebSiteData;

		// Token: 0x04008F16 RID: 36630
		[Token(Token = "0x4008F16")]
		private const UIModelGoogleEngagementRewards.Action DISPLAY_ACTION = UIModelGoogleEngagementRewards.Action.PurchaseElitePass;

		// Token: 0x04008F17 RID: 36631
		[Token(Token = "0x4008F17")]
		private const string FIRST_TIME_KEY = "GOOGLE_ENGAGEMENT_REWARDS_READ";

		// Token: 0x04008F18 RID: 36632
		[Token(Token = "0x4008F18")]
		[FieldOffset(Offset = "0xB0")]
		private string[] m_SelectableAccountNames;

		// Token: 0x04008F19 RID: 36633
		[Token(Token = "0x4008F19")]
		[FieldOffset(Offset = "0xB8")]
		private List<UIGoogleEngagementRewardsAccountItemController> m_AccountItems;

		// Token: 0x04008F1A RID: 36634
		[Token(Token = "0x4008F1A")]
		[FieldOffset(Offset = "0xC0")]
		private string m_SelectedGoogleAccountName;
	}
}
