using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200166B RID: 5739
	[Token(Token = "0x200166B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F008C", Offset = "0x10F008C")]
	public class UIStandardAdsController : UIBaseController
	{
		// Token: 0x060067D3 RID: 26579 RVA: 0x0001D850 File Offset: 0x0001BA50
		[Token(Token = "0x60067D3")]
		[Address(RVA = "0x163B120", Offset = "0x163B120", VA = "0x7BBBE3B120")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060067D4 RID: 26580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067D4")]
		[Address(RVA = "0x163B170", Offset = "0x163B170", VA = "0x7BBBE3B170", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060067D5 RID: 26581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067D5")]
		[Address(RVA = "0x163B338", Offset = "0x163B338", VA = "0x7BBBE3B338", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060067D6 RID: 26582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067D6")]
		[Address(RVA = "0x163B3EC", Offset = "0x163B3EC", VA = "0x7BBBE3B3EC")]
		public void SetGoposState(bool isEnable)
		{
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067D7")]
		[Address(RVA = "0x163B3F8", Offset = "0x163B3F8", VA = "0x7BBBE3B3F8")]
		public void UpdatePanelDepth(int newDepth)
		{
		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067D8")]
		[Address(RVA = "0x163B494", Offset = "0x163B494", VA = "0x7BBBE3B494")]
		public void SetViewData(List<UIModelLobbyAds.AdInfo> adInfoList, UINavigationUtil.UINavigationFrom newNavType)
		{
		}

		// Token: 0x060067D9 RID: 26585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067D9")]
		[Address(RVA = "0x163BD28", Offset = "0x163BD28", VA = "0x7BBBE3BD28")]
		private void OnAutoScrollAdItem()
		{
		}

		// Token: 0x060067DA RID: 26586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067DA")]
		[Address(RVA = "0x163BE78", Offset = "0x163BE78", VA = "0x7BBBE3BE78")]
		private void GetCenterItem(GameObject centerGo)
		{
		}

		// Token: 0x060067DB RID: 26587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067DB")]
		[Address(RVA = "0x163C054", Offset = "0x163C054", VA = "0x7BBBE3C054")]
		private void onAdsClicked()
		{
		}

		// Token: 0x060067DC RID: 26588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067DC")]
		[Address(RVA = "0x163C1C0", Offset = "0x163C1C0", VA = "0x7BBBE3C1C0")]
		public UIStandardAdsController()
		{
		}

		// Token: 0x040084F5 RID: 34037
		[Token(Token = "0x40084F5")]
		[FieldOffset(Offset = "0x58")]
		private UIStandardAdsView m_View;

		// Token: 0x040084F6 RID: 34038
		[Token(Token = "0x40084F6")]
		[FieldOffset(Offset = "0x60")]
		private UICenterOnChild m_wrapCenter;

		// Token: 0x040084F7 RID: 34039
		[Token(Token = "0x40084F7")]
		[FieldOffset(Offset = "0x68")]
		private List<UILobbyDotController> m_DotCtrls;

		// Token: 0x040084F8 RID: 34040
		[Token(Token = "0x40084F8")]
		[FieldOffset(Offset = "0x70")]
		private List<UIStandardAdsItemController> m_AdItems;

		// Token: 0x040084F9 RID: 34041
		[Token(Token = "0x40084F9")]
		[FieldOffset(Offset = "0x78")]
		private int m_LastSelectedIndex;

		// Token: 0x040084FA RID: 34042
		[Token(Token = "0x40084FA")]
		[FieldOffset(Offset = "0x80")]
		private List<UIModelLobbyAds.AdInfo> m_AdInfoList;

		// Token: 0x040084FB RID: 34043
		[Token(Token = "0x40084FB")]
		[FieldOffset(Offset = "0x88")]
		private uint m_AutoScrollDelayCallID;

		// Token: 0x040084FC RID: 34044
		[Token(Token = "0x40084FC")]
		[FieldOffset(Offset = "0x90")]
		private UIDragScrollView m_Drag;

		// Token: 0x040084FD RID: 34045
		[Token(Token = "0x40084FD")]
		[FieldOffset(Offset = "0x98")]
		private UINavigationUtil.UINavigationFrom m_NavType;

		// Token: 0x040084FE RID: 34046
		[Token(Token = "0x40084FE")]
		[FieldOffset(Offset = "0x9C")]
		private bool m_NeedGopos;
	}
}
