using System;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001964 RID: 6500
	[Token(Token = "0x2001964")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F62D4", Offset = "0x10F62D4")]
	internal class UIHudSpeedupAreaController : UIHudButtonBaseController
	{
		// Token: 0x06008419 RID: 33817 RVA: 0x00023DF0 File Offset: 0x00021FF0
		[Token(Token = "0x6008419")]
		[Address(RVA = "0x16713FC", Offset = "0x16713FC", VA = "0x7BBBE713FC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600841A RID: 33818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600841A")]
		[Address(RVA = "0x167144C", Offset = "0x167144C", VA = "0x7BBBE7144C")]
		public GameObject GetCollider()
		{
			return null;
		}

		// Token: 0x0600841B RID: 33819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600841B")]
		[Address(RVA = "0x167148C", Offset = "0x167148C", VA = "0x7BBBE7148C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600841C RID: 33820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600841C")]
		[Address(RVA = "0x1671944", Offset = "0x1671944", VA = "0x7BBBE71944", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600841D RID: 33821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600841D")]
		[Address(RVA = "0x1671CB0", Offset = "0x1671CB0", VA = "0x7BBBE71CB0")]
		private void OnChangeCancelVisible(params object[] data)
		{
		}

		// Token: 0x0600841E RID: 33822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600841E")]
		[Address(RVA = "0x1671D58", Offset = "0x1671D58", VA = "0x7BBBE71D58")]
		private void OnSightingStateChanged(params object[] data)
		{
		}

		// Token: 0x0600841F RID: 33823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600841F")]
		[Address(RVA = "0x1671EF0", Offset = "0x1671EF0", VA = "0x7BBBE71EF0")]
		private void OnPullBoldUnderSightingChanged(params object[] data)
		{
		}

		// Token: 0x06008420 RID: 33824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008420")]
		[Address(RVA = "0x1671FCC", Offset = "0x1671FCC", VA = "0x7BBBE71FCC")]
		private void Update()
		{
		}

		// Token: 0x06008421 RID: 33825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008421")]
		[Address(RVA = "0x16723B4", Offset = "0x16723B4", VA = "0x7BBBE723B4", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06008422 RID: 33826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008422")]
		[Address(RVA = "0x16720A0", Offset = "0x16720A0", VA = "0x7BBBE720A0")]
		private void SetHightlight(bool highlight, Player localPlayer)
		{
		}

		// Token: 0x06008423 RID: 33827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008423")]
		[Address(RVA = "0x1672458", Offset = "0x1672458", VA = "0x7BBBE72458")]
		private void OnTutorialRunFaster(params object[] data)
		{
		}

		// Token: 0x06008424 RID: 33828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008424")]
		[Address(RVA = "0x16725B4", Offset = "0x16725B4", VA = "0x7BBBE725B4")]
		private void OnTutorialSliding(params object[] data)
		{
		}

		// Token: 0x06008425 RID: 33829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008425")]
		[Address(RVA = "0x1672654", Offset = "0x1672654", VA = "0x7BBBE72654")]
		private void HideSlidingTutorial()
		{
		}

		// Token: 0x06008426 RID: 33830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008426")]
		[Address(RVA = "0x16726D8", Offset = "0x16726D8", VA = "0x7BBBE726D8")]
		private void OnLocalPlayerStateChange(params object[] data)
		{
		}

		// Token: 0x06008427 RID: 33831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008427")]
		[Address(RVA = "0x1672B28", Offset = "0x1672B28", VA = "0x7BBBE72B28")]
		private void OnLocalPlayerAdd(params object[] data)
		{
		}

		// Token: 0x06008428 RID: 33832 RVA: 0x00023E08 File Offset: 0x00022008
		[Token(Token = "0x6008428")]
		[Address(RVA = "0x1672B10", Offset = "0x1672B10", VA = "0x7BBBE72B10")]
		private bool IsInAir(Player.T[m state)
		{
			return default(bool);
		}

		// Token: 0x06008429 RID: 33833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008429")]
		[Address(RVA = "0x16728D0", Offset = "0x16728D0", VA = "0x7BBBE728D0")]
		private void UpdateState([Optional] Player localPlayer)
		{
		}

		// Token: 0x0600842A RID: 33834 RVA: 0x00023E20 File Offset: 0x00022020
		[Token(Token = "0x600842A")]
		[Address(RVA = "0x1672B30", Offset = "0x1672B30", VA = "0x7BBBE72B30")]
		private bool UpdateShowing(Player.T[m state)
		{
			return default(bool);
		}

		// Token: 0x0600842B RID: 33835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600842B")]
		[Address(RVA = "0x1672C20", Offset = "0x1672C20", VA = "0x7BBBE72C20")]
		private void UpdateIconSprite(Player.T[m state, bool inAir, bool haveFlight)
		{
		}

		// Token: 0x0600842C RID: 33836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600842C")]
		[Address(RVA = "0x16723FC", Offset = "0x16723FC", VA = "0x7BBBE723FC")]
		private void UpdateIconSprite(string sprite)
		{
		}

		// Token: 0x0600842D RID: 33837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600842D")]
		[Address(RVA = "0x1672FC0", Offset = "0x1672FC0", VA = "0x7BBBE72FC0")]
		private void ShowSkateboardDashTutorial()
		{
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600842E")]
		[Address(RVA = "0x1673060", Offset = "0x1673060", VA = "0x7BBBE73060")]
		private void OnLocalPlayerSkateboardDashCd(params object[] param)
		{
		}

		// Token: 0x0600842F RID: 33839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600842F")]
		[Address(RVA = "0x1672E1C", Offset = "0x1672E1C", VA = "0x7BBBE72E1C")]
		private void ShowCdBar(float cd, float remain)
		{
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008430")]
		[Address(RVA = "0x16730F0", Offset = "0x16730F0", VA = "0x7BBBE730F0")]
		private void OnClick()
		{
		}

		// Token: 0x06008431 RID: 33841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008431")]
		[Address(RVA = "0x167310C", Offset = "0x167310C", VA = "0x7BBBE7310C")]
		private void UpdateClickSkyDashingBtnCount()
		{
		}

		// Token: 0x06008432 RID: 33842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008432")]
		[Address(RVA = "0x16731C4", Offset = "0x16731C4", VA = "0x7BBBE731C4")]
		private void OnLocalPlayerTeamParachuteModeChange(params object[] param)
		{
		}

		// Token: 0x06008433 RID: 33843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008433")]
		[Address(RVA = "0x16732B4", Offset = "0x16732B4", VA = "0x7BBBE732B4")]
		public UIHudSpeedupAreaController()
		{
		}

		// Token: 0x04009499 RID: 38041
		[Token(Token = "0x4009499")]
		private const string ICON_SKYDASHING = "UI_icon_AutoSliding";

		// Token: 0x0400949A RID: 38042
		[Token(Token = "0x400949A")]
		private const string ICON_SPEEDUP = "UI_icon_speedup";

		// Token: 0x0400949B RID: 38043
		[Token(Token = "0x400949B")]
		private const string ICON_Skateboarding = "UI_icon_AutoSliding";

		// Token: 0x0400949C RID: 38044
		[Token(Token = "0x400949C")]
		private const string ICON_FLIGHT_SKYDASHING = "UI_icon_Mounts_Accelerate";

		// Token: 0x0400949D RID: 38045
		[Token(Token = "0x400949D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string m_IconUse;

		// Token: 0x0400949E RID: 38046
		[Token(Token = "0x400949E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UIHudSpeedupAreaView m_View;

		// Token: 0x0400949F RID: 38047
		[Token(Token = "0x400949F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_IsHighlight;

		// Token: 0x040094A0 RID: 38048
		[Token(Token = "0x40094A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_bIsPullingBolt;

		// Token: 0x040094A1 RID: 38049
		[Token(Token = "0x40094A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		private bool m_ShowingInAirBtnSprite;

		// Token: 0x040094A2 RID: 38050
		[Token(Token = "0x40094A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private uint m_ClickSkyDashingBtnCount;

		// Token: 0x040094A3 RID: 38051
		[Token(Token = "0x40094A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UIEventTrigger m_Trigger;

		// Token: 0x040094A4 RID: 38052
		[Token(Token = "0x40094A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_IsFollowHide;
	}
}
