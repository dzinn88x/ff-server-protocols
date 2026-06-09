using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02001015 RID: 4117
	[Token(Token = "0x2001015")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EA698", Offset = "0x10EA698")]
	public class UIBaseNavigationController : UIBaseController
	{
		// Token: 0x06003DF5 RID: 15861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF5")]
		[Address(RVA = "0x20232B4", Offset = "0x20232B4", VA = "0x7BBC8232B4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF6")]
		[Address(RVA = "0x20233BC", Offset = "0x20233BC", VA = "0x7BBC8233BC", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06003DF7 RID: 15863 RVA: 0x000134D0 File Offset: 0x000116D0
		[Token(Token = "0x1700072E")]
		public bool IsRoot
		{
			[Token(Token = "0x6003DF7")]
			[Address(RVA = "0x20233C0", Offset = "0x20233C0", VA = "0x7BBC8233C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06003DF8 RID: 15864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700072F")]
		public UINavigationData NavigationData
		{
			[Token(Token = "0x6003DF8")]
			[Address(RVA = "0x20233C8", Offset = "0x20233C8", VA = "0x7BBC8233C8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF9")]
		[Address(RVA = "0x20233D0", Offset = "0x20233D0", VA = "0x7BBC8233D0", Slot = "28")]
		public virtual void OnNavigationShowed(UINavigationData navigationData, bool isRoot)
		{
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DFA")]
		[Address(RVA = "0x20235A8", Offset = "0x20235A8", VA = "0x7BBC8235A8", Slot = "29")]
		public virtual void OnNavigationClosed()
		{
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DFB")]
		[Address(RVA = "0x2023768", Offset = "0x2023768", VA = "0x7BBC823768")]
		public void ShowPopupWindow(UIPopupWindowController popupWindow)
		{
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DFC")]
		[Address(RVA = "0x2023E7C", Offset = "0x2023E7C", VA = "0x7BBC823E7C")]
		public List<UIPopupWindowController> GetPopupWindows()
		{
			return null;
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DFD")]
		[Address(RVA = "0x2023E84", Offset = "0x2023E84", VA = "0x7BBC823E84")]
		public void OnPopupWindowDepthIncrease(UIPopupWindowController popupWindow, uint increaseDepth)
		{
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DFE")]
		[Address(RVA = "0x20240E8", Offset = "0x20240E8", VA = "0x7BBC8240E8")]
		public void OnPopupWindowClose(UIPopupWindowController popupWindow)
		{
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DFF")]
		[Address(RVA = "0x202416C", Offset = "0x202416C", VA = "0x7BBC82416C", Slot = "30")]
		protected virtual void OnPopupWindowListChange()
		{
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E00")]
		[Address(RVA = "0x2024230", Offset = "0x2024230", VA = "0x7BBC824230")]
		public void CloseAllPopupWindows()
		{
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E01")]
		[Address(RVA = "0x2024394", Offset = "0x2024394", VA = "0x7BBC824394")]
		public void ClosePopupWindowsByType(Type popupType)
		{
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E02")]
		[Address(RVA = "0x20244EC", Offset = "0x20244EC", VA = "0x7BBC8244EC")]
		public UIPopupWindowController TopPopupWindows()
		{
			return null;
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x000134E8 File Offset: 0x000116E8
		[Token(Token = "0x6003E03")]
		[Address(RVA = "0x20245A8", Offset = "0x20245A8", VA = "0x7BBC8245A8")]
		public bool HasGlassEnabledInPopupWindowList(UIPopupWindowController popupWnd)
		{
			return default(bool);
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E04")]
		[Address(RVA = "0x20247A8", Offset = "0x20247A8", VA = "0x7BBC8247A8", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06003E05 RID: 15877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E05")]
		[Address(RVA = "0x20248EC", Offset = "0x20248EC", VA = "0x7BBC8248EC")]
		public UIBaseNavigationController()
		{
		}

		// Token: 0x04004E86 RID: 20102
		[Token(Token = "0x4004E86")]
		[FieldOffset(Offset = "0x58")]
		protected UINavigationData m_NavigationData;

		// Token: 0x04004E87 RID: 20103
		[Token(Token = "0x4004E87")]
		[FieldOffset(Offset = "0x60")]
		protected bool m_IsRoot;

		// Token: 0x04004E88 RID: 20104
		[Token(Token = "0x4004E88")]
		[FieldOffset(Offset = "0x61")]
		protected bool m_IsNavigationShowed;

		// Token: 0x04004E89 RID: 20105
		[Token(Token = "0x4004E89")]
		[FieldOffset(Offset = "0x68")]
		protected List<UIPopupWindowController> m_PopupWindows;
	}
}
