using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020019EB RID: 6635
	[Token(Token = "0x20019EB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F741C", Offset = "0x10F741C")]
	internal class UILobbyAdsController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x0600893F RID: 35135 RVA: 0x00024E40 File Offset: 0x00023040
		[Token(Token = "0x600893F")]
		[Address(RVA = "0x15256C8", Offset = "0x15256C8", VA = "0x7BBBD256C8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008940 RID: 35136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008940")]
		[Address(RVA = "0x1525718", Offset = "0x1525718", VA = "0x7BBBD25718", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008941 RID: 35137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008941")]
		[Address(RVA = "0x1526AB0", Offset = "0x1526AB0", VA = "0x7BBBD26AB0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008942 RID: 35138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008942")]
		[Address(RVA = "0x1526DE8", Offset = "0x1526DE8", VA = "0x7BBBD26DE8")]
		public void UpdateExtraAdHint()
		{
		}

		// Token: 0x06008943 RID: 35139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008943")]
		[Address(RVA = "0x1527018", Offset = "0x1527018", VA = "0x7BBBD27018")]
		private void OnGetCDNAD(object[] data)
		{
		}

		// Token: 0x06008944 RID: 35140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008944")]
		[Address(RVA = "0x1527044", Offset = "0x1527044", VA = "0x7BBBD27044")]
		public void UpdateExtraAdsAnim()
		{
		}

		// Token: 0x06008945 RID: 35141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008945")]
		[Address(RVA = "0x1526088", Offset = "0x1526088", VA = "0x7BBBD26088")]
		private void UpdateExtraAds()
		{
		}

		// Token: 0x06008946 RID: 35142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008946")]
		[Address(RVA = "0x15279B4", Offset = "0x15279B4", VA = "0x7BBBD279B4")]
		private void OnExtraAdsClick(int index)
		{
		}

		// Token: 0x06008947 RID: 35143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008947")]
		[Address(RVA = "0x1527C54", Offset = "0x1527C54", VA = "0x7BBBD27C54")]
		private void SendBannerClickLog(UILobbyAdsController.BannerType bannerType, uint id)
		{
		}

		// Token: 0x06008948 RID: 35144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008948")]
		[Address(RVA = "0x1527DC4", Offset = "0x1527DC4", VA = "0x7BBBD27DC4")]
		private void OnAdClickStateChange(params object[] data)
		{
		}

		// Token: 0x06008949 RID: 35145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008949")]
		[Address(RVA = "0x152737C", Offset = "0x152737C", VA = "0x7BBBD2737C")]
		private void RefreshUIData()
		{
		}

		// Token: 0x0600894A RID: 35146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600894A")]
		[Address(RVA = "0x1527FB4", Offset = "0x1527FB4", VA = "0x7BBBD27FB4")]
		private void OnAutoScrollAdItem()
		{
		}

		// Token: 0x0600894B RID: 35147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600894B")]
		[Address(RVA = "0x1528104", Offset = "0x1528104", VA = "0x7BBBD28104")]
		private void GetCenterItem(GameObject centerGo)
		{
		}

		// Token: 0x0600894C RID: 35148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600894C")]
		[Address(RVA = "0x15281F8", Offset = "0x15281F8", VA = "0x7BBBD281F8")]
		private void onAdsClicked()
		{
		}

		// Token: 0x0600894D RID: 35149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600894D")]
		[Address(RVA = "0x1528400", Offset = "0x1528400", VA = "0x7BBBD28400", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600894E RID: 35150 RVA: 0x00024E58 File Offset: 0x00023058
		[Token(Token = "0x600894E")]
		[Address(RVA = "0x15284F4", Offset = "0x15284F4", VA = "0x7BBBD284F4", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600894F RID: 35151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600894F")]
		[Address(RVA = "0x1528538", Offset = "0x1528538", VA = "0x7BBBD28538")]
		public UILobbyAdsController()
		{
		}

		// Token: 0x04009754 RID: 38740
		[Token(Token = "0x4009754")]
		[FieldOffset(Offset = "0x58")]
		private UILobbyAdsView m_View;

		// Token: 0x04009755 RID: 38741
		[Token(Token = "0x4009755")]
		[FieldOffset(Offset = "0x60")]
		private UICenterOnChild m_wrapCenter;

		// Token: 0x04009756 RID: 38742
		[Token(Token = "0x4009756")]
		[FieldOffset(Offset = "0x68")]
		private List<UILobbyDotController> m_DotCtrls;

		// Token: 0x04009757 RID: 38743
		[Token(Token = "0x4009757")]
		[FieldOffset(Offset = "0x70")]
		private List<UILobbyAdItemController> m_AdItems;

		// Token: 0x04009758 RID: 38744
		[Token(Token = "0x4009758")]
		[FieldOffset(Offset = "0x78")]
		private int m_LastSelectedIndex;

		// Token: 0x04009759 RID: 38745
		[Token(Token = "0x4009759")]
		[FieldOffset(Offset = "0x80")]
		private List<UIModelLobbyAds.AdInfo> m_AdInfoList;

		// Token: 0x0400975A RID: 38746
		[Token(Token = "0x400975A")]
		[FieldOffset(Offset = "0x88")]
		private UIModelLobbyAds m_ModelLobbyAd;

		// Token: 0x0400975B RID: 38747
		[Token(Token = "0x400975B")]
		[FieldOffset(Offset = "0x90")]
		private BoxCollider m_ContentCollider;

		// Token: 0x0400975C RID: 38748
		[Token(Token = "0x400975C")]
		[FieldOffset(Offset = "0x98")]
		private uint m_AutoScrollDelayCallID;

		// Token: 0x0400975D RID: 38749
		[Token(Token = "0x400975D")]
		[FieldOffset(Offset = "0xA0")]
		private List<AdvertDesc> _ExtraAds;

		// Token: 0x0400975E RID: 38750
		[Token(Token = "0x400975E")]
		[FieldOffset(Offset = "0xA8")]
		private UILobbyAdsController.ExtraAdUI[] _ExtraAdUIs;

		// Token: 0x020019EC RID: 6636
		[Token(Token = "0x20019EC")]
		private enum BannerType
		{
			// Token: 0x04009760 RID: 38752
			[Token(Token = "0x4009760")]
			None,
			// Token: 0x04009761 RID: 38753
			[Token(Token = "0x4009761")]
			ActivityLocalization,
			// Token: 0x04009762 RID: 38754
			[Token(Token = "0x4009762")]
			GMT,
			// Token: 0x04009763 RID: 38755
			[Token(Token = "0x4009763")]
			CDNSettingLocal
		}

		// Token: 0x020019ED RID: 6637
		[Token(Token = "0x20019ED")]
		public enum ExtraAdHintType
		{
			// Token: 0x04009765 RID: 38757
			[Token(Token = "0x4009765")]
			NONE,
			// Token: 0x04009766 RID: 38758
			[Token(Token = "0x4009766")]
			RESET_BY_ID,
			// Token: 0x04009767 RID: 38759
			[Token(Token = "0x4009767")]
			RESET_BY_TIME
		}

		// Token: 0x020019EE RID: 6638
		[Token(Token = "0x20019EE")]
		private class ExtraAdUI
		{
			// Token: 0x06008950 RID: 35152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008950")]
			[Address(RVA = "0x1526078", Offset = "0x1526078", VA = "0x7BBBD26078")]
			public ExtraAdUI()
			{
			}

			// Token: 0x04009768 RID: 38760
			[Token(Token = "0x4009768")]
			[FieldOffset(Offset = "0x10")]
			public int idx;

			// Token: 0x04009769 RID: 38761
			[Token(Token = "0x4009769")]
			[FieldOffset(Offset = "0x18")]
			public UIButton Button;

			// Token: 0x0400976A RID: 38762
			[Token(Token = "0x400976A")]
			[FieldOffset(Offset = "0x20")]
			public UINetworkTextureExt NetworkTexture;

			// Token: 0x0400976B RID: 38763
			[Token(Token = "0x400976B")]
			[FieldOffset(Offset = "0x28")]
			public UISprite Bg;

			// Token: 0x0400976C RID: 38764
			[Token(Token = "0x400976C")]
			[FieldOffset(Offset = "0x30")]
			public EventDelegate.Callback OnClick;

			// Token: 0x0400976D RID: 38765
			[Token(Token = "0x400976D")]
			[FieldOffset(Offset = "0x38")]
			public BoxCollider Collider;

			// Token: 0x0400976E RID: 38766
			[Token(Token = "0x400976E")]
			[FieldOffset(Offset = "0x40")]
			public UILobbyAdsController.ExtraAdHintType hintType;

			// Token: 0x0400976F RID: 38767
			[Token(Token = "0x400976F")]
			[FieldOffset(Offset = "0x44")]
			public uint cdnResID;

			// Token: 0x04009770 RID: 38768
			[Token(Token = "0x4009770")]
			[FieldOffset(Offset = "0x48")]
			public GameObject hintTipGO;

			// Token: 0x04009771 RID: 38769
			[Token(Token = "0x4009771")]
			[FieldOffset(Offset = "0x50")]
			public UINavigationUtil.UINavigationFrom from;

			// Token: 0x04009772 RID: 38770
			[Token(Token = "0x4009772")]
			[FieldOffset(Offset = "0x58")]
			public UISprite CountDown;

			// Token: 0x04009773 RID: 38771
			[Token(Token = "0x4009773")]
			[FieldOffset(Offset = "0x60")]
			public UISprite CountDownBG;

			// Token: 0x04009774 RID: 38772
			[Token(Token = "0x4009774")]
			[FieldOffset(Offset = "0x68")]
			public GameObject Anim;

			// Token: 0x04009775 RID: 38773
			[Token(Token = "0x4009775")]
			[FieldOffset(Offset = "0x70")]
			public UICountDownController CountDownCtrl;
		}

		// Token: 0x020019EF RID: 6639
		[Token(Token = "0x20019EF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7454", Offset = "0x10F7454")]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06008951 RID: 35153 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008951")]
			[Address(RVA = "0x1526080", Offset = "0x1526080", VA = "0x7BBBD26080")]
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x06008952 RID: 35154 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008952")]
			[Address(RVA = "0x1528628", Offset = "0x1528628", VA = "0x7BBBD28628")]
			internal void <OnUIInit>b__0()
			{
			}

			// Token: 0x04009776 RID: 38774
			[Token(Token = "0x4009776")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x04009777 RID: 38775
			[Token(Token = "0x4009777")]
			[FieldOffset(Offset = "0x18")]
			public UILobbyAdsController <>4__this;
		}
	}
}
