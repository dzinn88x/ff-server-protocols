using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B81 RID: 7041
	[Token(Token = "0x2001B81")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA36C", Offset = "0x10FA36C")]
	public class UISettingController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x060097B6 RID: 38838 RVA: 0x00027FF0 File Offset: 0x000261F0
		[Token(Token = "0x60097B6")]
		[Address(RVA = "0x1631AC0", Offset = "0x1631AC0", VA = "0x7BBBE31AC0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060097B7 RID: 38839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097B7")]
		[Address(RVA = "0x1631B10", Offset = "0x1631B10", VA = "0x7BBBE31B10", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060097B8 RID: 38840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097B8")]
		[Address(RVA = "0x1632408", Offset = "0x1632408", VA = "0x7BBBE32408")]
		private void InitNotifications()
		{
		}

		// Token: 0x060097B9 RID: 38841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097B9")]
		[Address(RVA = "0x163259C", Offset = "0x163259C", VA = "0x7BBBE3259C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060097BA RID: 38842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097BA")]
		[Address(RVA = "0x16324C4", Offset = "0x16324C4", VA = "0x7BBBE324C4")]
		private void UpdateGraphicsSettingTabTips()
		{
		}

		// Token: 0x060097BB RID: 38843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097BB")]
		[Address(RVA = "0x1632698", Offset = "0x1632698", VA = "0x7BBBE32698")]
		private void OnCloseClick()
		{
		}

		// Token: 0x060097BC RID: 38844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097BC")]
		[Address(RVA = "0x16326A0", Offset = "0x16326A0", VA = "0x7BBBE326A0", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060097BD RID: 38845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60097BD")]
		[Address(RVA = "0x16328AC", Offset = "0x16328AC", VA = "0x7BBBE328AC")]
		private UISettingContentBase GetContent(SettingPageType settingType)
		{
			return null;
		}

		// Token: 0x060097BE RID: 38846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097BE")]
		[Address(RVA = "0x1632F0C", Offset = "0x1632F0C", VA = "0x7BBBE32F0C")]
		private void OnTopTabClick(SettingPageType settingType)
		{
		}

		// Token: 0x060097BF RID: 38847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097BF")]
		[Address(RVA = "0x1633048", Offset = "0x1633048", VA = "0x7BBBE33048", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060097C0 RID: 38848 RVA: 0x00028008 File Offset: 0x00026208
		[Token(Token = "0x60097C0")]
		[Address(RVA = "0x1633484", Offset = "0x1633484", VA = "0x7BBBE33484", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060097C1 RID: 38849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097C1")]
		[Address(RVA = "0x16334E8", Offset = "0x16334E8", VA = "0x7BBBE334E8")]
		public void SetInGameShow(bool isIngame)
		{
		}

		// Token: 0x060097C2 RID: 38850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097C2")]
		[Address(RVA = "0x16336A0", Offset = "0x16336A0", VA = "0x7BBBE336A0")]
		public UISettingController()
		{
		}

		// Token: 0x04009FB9 RID: 40889
		[Token(Token = "0x4009FB9")]
		[FieldOffset(Offset = "0x98")]
		private UISettingView m_View;

		// Token: 0x04009FBA RID: 40890
		[Token(Token = "0x4009FBA")]
		[FieldOffset(Offset = "0xA0")]
		private UICommonGuideController m_CommonGuideCtrl;

		// Token: 0x04009FBB RID: 40891
		[Token(Token = "0x4009FBB")]
		[FieldOffset(Offset = "0xA8")]
		private List<UISettingTabButton> m_TabButtons;

		// Token: 0x04009FBC RID: 40892
		[Token(Token = "0x4009FBC")]
		[FieldOffset(Offset = "0xB0")]
		private bool isInGame;

		// Token: 0x04009FBD RID: 40893
		[Token(Token = "0x4009FBD")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelLogin m_LoginModel;

		// Token: 0x04009FBE RID: 40894
		[Token(Token = "0x4009FBE")]
		[FieldOffset(Offset = "0xC0")]
		private UIDebugInfoController m_debuginfoController;

		// Token: 0x04009FBF RID: 40895
		[Token(Token = "0x4009FBF")]
		[FieldOffset(Offset = "0xC8")]
		private UIAutoPickUpSettingController m_AutoPickUpController;

		// Token: 0x04009FC0 RID: 40896
		[Token(Token = "0x4009FC0")]
		[FieldOffset(Offset = "0xD0")]
		private UIBasicSettingController m_BasicSettingController;

		// Token: 0x04009FC1 RID: 40897
		[Token(Token = "0x4009FC1")]
		[FieldOffset(Offset = "0xD8")]
		private UISoundSettingController m_SoundSettingController;

		// Token: 0x04009FC2 RID: 40898
		[Token(Token = "0x4009FC2")]
		[FieldOffset(Offset = "0xE0")]
		private UISensiSettingController m_SensiSettingController;

		// Token: 0x04009FC3 RID: 40899
		[Token(Token = "0x4009FC3")]
		[FieldOffset(Offset = "0xE8")]
		private UIOperationSettingController m_OperationSettingController;

		// Token: 0x04009FC4 RID: 40900
		[Token(Token = "0x4009FC4")]
		[FieldOffset(Offset = "0xF0")]
		private UINotificationSettingController m_NotificationSettingController;

		// Token: 0x04009FC5 RID: 40901
		[Token(Token = "0x4009FC5")]
		[FieldOffset(Offset = "0xF8")]
		private UIGraphicSettingController m_GraphicSettingController;

		// Token: 0x04009FC6 RID: 40902
		[Token(Token = "0x4009FC6")]
		[FieldOffset(Offset = "0x100")]
		private UISettingContentBase m_CurrentShowContent;
	}
}
