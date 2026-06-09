using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x0200103C RID: 4156
	[Token(Token = "0x200103C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EA98C", Offset = "0x10EA98C")]
	public class UIPopupWindowController : UIBaseController
	{
		// Token: 0x06003F34 RID: 16180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F34")]
		[Address(RVA = "0x2033DE0", Offset = "0x2033DE0", VA = "0x7BBC833DE0", Slot = "28")]
		public virtual string Rule()
		{
			return null;
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F35")]
		[Address(RVA = "0x2033E30", Offset = "0x2033E30", VA = "0x7BBC833E30", Slot = "29")]
		public virtual string CustomTitle()
		{
			return null;
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x00013968 File Offset: 0x00011B68
		[Token(Token = "0x6003F36")]
		[Address(RVA = "0x2033E80", Offset = "0x2033E80", VA = "0x7BBC833E80", Slot = "30")]
		public virtual int GlassDelay()
		{
			return 0;
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x00013980 File Offset: 0x00011B80
		[Token(Token = "0x6003F37")]
		[Address(RVA = "0x2033E88", Offset = "0x2033E88", VA = "0x7BBC833E88", Slot = "31")]
		public virtual int MinGroupDepth()
		{
			return 0;
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F38")]
		[Address(RVA = "0x2033E90", Offset = "0x2033E90", VA = "0x7BBC833E90", Slot = "32")]
		protected virtual string AnimationConfogPath()
		{
			return null;
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F39")]
		[Address(RVA = "0x2033ED8", Offset = "0x2033ED8", VA = "0x7BBC833ED8", Slot = "33")]
		protected virtual void OnTweenAnimationFinish()
		{
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x00013998 File Offset: 0x00011B98
		[Token(Token = "0x6003F3A")]
		[Address(RVA = "0x2033EDC", Offset = "0x2033EDC", VA = "0x7BBC833EDC", Slot = "34")]
		protected virtual bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F3B")]
		[Address(RVA = "0x2033EE4", Offset = "0x2033EE4", VA = "0x7BBC833EE4", Slot = "9")]
		protected override void Awake()
		{
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F3C")]
		[Address(RVA = "0x2023C78", Offset = "0x2023C78", VA = "0x7BBC823C78")]
		public void InitDepth(int startDepth)
		{
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F3D")]
		[Address(RVA = "0x2034CEC", Offset = "0x2034CEC", VA = "0x7BBC834CEC", Slot = "35")]
		protected virtual void OnInitDepth()
		{
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F3E")]
		[Address(RVA = "0x2034CF0", Offset = "0x2034CF0", VA = "0x7BBC834CF0")]
		public void SetTitleKey(string key)
		{
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F3F")]
		[Address(RVA = "0x20239B8", Offset = "0x20239B8", VA = "0x7BBC8239B8")]
		public void SetNavigationController(UIBaseNavigationController navigationController)
		{
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F40")]
		[Address(RVA = "0x2034424", Offset = "0x2034424", VA = "0x7BBC834424")]
		public void AddTweenByConfig(UIPanel mainPanel)
		{
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x000139B0 File Offset: 0x00011BB0
		[Token(Token = "0x6003F41")]
		[Address(RVA = "0x2034DA0", Offset = "0x2034DA0", VA = "0x7BBC834DA0")]
		public int GetMainPanelDepth()
		{
			return 0;
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x000139C8 File Offset: 0x00011BC8
		[Token(Token = "0x6003F42")]
		[Address(RVA = "0x20239C0", Offset = "0x20239C0", VA = "0x7BBC8239C0")]
		public int GetMaxPanelDepth()
		{
			return 0;
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F43")]
		[Address(RVA = "0x2023FD8", Offset = "0x2023FD8", VA = "0x7BBC823FD8")]
		public void IncreasePanelDepth(uint incrementDepth)
		{
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F44")]
		[Address(RVA = "0x2034DD0", Offset = "0x2034DD0", VA = "0x7BBC834DD0", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F45")]
		protected override T OpenChildController<T>(Transform parent, [Optional] Vector3 localPosition, EUIAnchor anchor = EUIAnchor.None, bool noCache = false)
		{
			return null;
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F46")]
		[Address(RVA = "0x2035008", Offset = "0x2035008", VA = "0x7BBC835008", Slot = "12")]
		protected override void OnChildControllerOpenChildController()
		{
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x000139E0 File Offset: 0x00011BE0
		[Token(Token = "0x6003F47")]
		[Address(RVA = "0x20351A0", Offset = "0x20351A0", VA = "0x7BBC8351A0", Slot = "36")]
		public virtual bool ClosedByEsc()
		{
			return default(bool);
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x000139F8 File Offset: 0x00011BF8
		[Token(Token = "0x6003F48")]
		[Address(RVA = "0x20351A8", Offset = "0x20351A8", VA = "0x7BBC8351A8", Slot = "37")]
		public virtual bool IgnoreEsc()
		{
			return default(bool);
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F49")]
		[Address(RVA = "0x20351B0", Offset = "0x20351B0", VA = "0x7BBC8351B0", Slot = "38")]
		public virtual void EnterByReturn()
		{
		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F4A")]
		[Address(RVA = "0x20351B4", Offset = "0x20351B4", VA = "0x7BBC8351B4")]
		public void SetColliderMaskAlpha(UISprite mask, float alpha = 0f)
		{
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x00013A10 File Offset: 0x00011C10
		[Token(Token = "0x6003F4B")]
		[Address(RVA = "0x2033704", Offset = "0x2033704", VA = "0x7BBC833704")]
		public bool HasGlassEnabledInPopupWindowList()
		{
			return default(bool);
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F4C")]
		[Address(RVA = "0x203526C", Offset = "0x203526C", VA = "0x7BBC83526C", Slot = "39")]
		public virtual void OnPopupWindowListChange()
		{
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x00013A28 File Offset: 0x00011C28
		[Token(Token = "0x6003F4D")]
		[Address(RVA = "0x2035270", Offset = "0x2035270", VA = "0x7BBC835270")]
		public bool IsCoverPrePopupWnd()
		{
			return default(bool);
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x00013A40 File Offset: 0x00011C40
		[Token(Token = "0x6003F4E")]
		[Address(RVA = "0x2035284", Offset = "0x2035284", VA = "0x7BBC835284")]
		public bool IsCoveredByPopupWnd()
		{
			return default(bool);
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F4F")]
		[Address(RVA = "0x2032D94", Offset = "0x2032D94", VA = "0x7BBC832D94")]
		public UIPopupWindowController()
		{
		}

		// Token: 0x04004F5C RID: 20316
		[Token(Token = "0x4004F5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected UIBaseNavigationController m_NavigationController;

		// Token: 0x04004F5D RID: 20317
		[Token(Token = "0x4004F5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected List<UITweener> m_PopupTweener;

		// Token: 0x04004F5E RID: 20318
		[Token(Token = "0x4004F5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected UIPanel m_MainPanel;

		// Token: 0x04004F5F RID: 20319
		[Token(Token = "0x4004F5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected UIPanel[] m_ChildPanels;

		// Token: 0x04004F60 RID: 20320
		[Token(Token = "0x4004F60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public UIPopWindowFrameStyle m_frameStyle;

		// Token: 0x04004F61 RID: 20321
		[Token(Token = "0x4004F61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected UIPopupGlassBG m_Glass;

		// Token: 0x04004F62 RID: 20322
		[Token(Token = "0x4004F62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UIGlassBGController GlassCtrl;

		// Token: 0x04004F63 RID: 20323
		[Token(Token = "0x4004F63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected bool m_IsCoverPrePopWnd;
	}
}
