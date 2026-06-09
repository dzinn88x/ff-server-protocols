using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001360 RID: 4960
	[Token(Token = "0x2001360")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB360", Offset = "0x10EB360")]
	internal class UIFFWSMainPageController : UINaviPopController, IUIModelDataChangeObserver
	{
		// Token: 0x06004F16 RID: 20246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F16")]
		[Address(RVA = "0x227E078", Offset = "0x227E078", VA = "0x7BBCA7E078", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x000181F8 File Offset: 0x000163F8
		[Token(Token = "0x6004F17")]
		[Address(RVA = "0x227FAF4", Offset = "0x227FAF4", VA = "0x7BBCA7FAF4", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x00018210 File Offset: 0x00016410
		[Token(Token = "0x6004F18")]
		[Address(RVA = "0x227FB78", Offset = "0x227FB78", VA = "0x7BBCA7FB78")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F19")]
		[Address(RVA = "0x227FBC8", Offset = "0x227FBC8", VA = "0x7BBCA7FBC8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F1A")]
		[Address(RVA = "0x228039C", Offset = "0x228039C", VA = "0x7BBCA8039C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06004F1B RID: 20251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F1B")]
		[Address(RVA = "0x2280638", Offset = "0x2280638", VA = "0x7BBCA80638", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F1C")]
		[Address(RVA = "0x22808B4", Offset = "0x22808B4", VA = "0x7BBCA808B4", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F1D")]
		[Address(RVA = "0x2280A00", Offset = "0x2280A00", VA = "0x7BBCA80A00", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06004F1E RID: 20254 RVA: 0x00018228 File Offset: 0x00016428
		[Token(Token = "0x6004F1E")]
		[Address(RVA = "0x2280A08", Offset = "0x2280A08", VA = "0x7BBCA80A08", Slot = "35")]
		public override EFrontendBGMType GetBGMType()
		{
			return EFrontendBGMType.NONE;
		}

		// Token: 0x06004F1F RID: 20255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F1F")]
		[Address(RVA = "0x227E364", Offset = "0x227E364", VA = "0x7BBCA7E364")]
		private void RefreshView()
		{
		}

		// Token: 0x06004F20 RID: 20256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F20")]
		[Address(RVA = "0x227ECE0", Offset = "0x227ECE0", VA = "0x7BBCA7ECE0")]
		private void RefreshEntranceGuess()
		{
		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F21")]
		[Address(RVA = "0x227F918", Offset = "0x227F918", VA = "0x7BBCA7F918")]
		private void RefreshTaskTip()
		{
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F22")]
		[Address(RVA = "0x227E57C", Offset = "0x227E57C", VA = "0x7BBCA7E57C")]
		private void RefreshEntranceMission()
		{
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F23")]
		[Address(RVA = "0x2280CF4", Offset = "0x2280CF4", VA = "0x7BBCA80CF4")]
		private void RefreshAvatarStatus(bool isAwaken)
		{
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F24")]
		[Address(RVA = "0x2280A10", Offset = "0x2280A10", VA = "0x7BBCA80A10")]
		private void RefreshEntranceLive()
		{
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F25")]
		[Address(RVA = "0x227F2BC", Offset = "0x227F2BC", VA = "0x7BBCA7F2BC")]
		private void RefreshEntranceExchange()
		{
		}

		// Token: 0x06004F26 RID: 20262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F26")]
		[Address(RVA = "0x227F3E0", Offset = "0x227F3E0", VA = "0x7BBCA7F3E0")]
		private void RefreshEntranceCheckIn()
		{
		}

		// Token: 0x06004F27 RID: 20263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F27")]
		[Address(RVA = "0x2280C80", Offset = "0x2280C80", VA = "0x7BBCA80C80")]
		private void RefreshTimeView()
		{
		}

		// Token: 0x06004F28 RID: 20264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F28")]
		[Address(RVA = "0x227F998", Offset = "0x227F998", VA = "0x7BBCA7F998")]
		private void RefreshTokenView()
		{
		}

		// Token: 0x06004F29 RID: 20265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F29")]
		[Address(RVA = "0x2280B04", Offset = "0x2280B04", VA = "0x7BBCA80B04")]
		private void RefreshEntranceWebEvent()
		{
		}

		// Token: 0x06004F2A RID: 20266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F2A")]
		[Address(RVA = "0x2280BBC", Offset = "0x2280BBC", VA = "0x7BBCA80BBC")]
		private void RefreshEntranceCup()
		{
		}

		// Token: 0x06004F2B RID: 20267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F2B")]
		[Address(RVA = "0x227F530", Offset = "0x227F530", VA = "0x7BBCA7F530")]
		private void RefreshEntrancePeakDay()
		{
		}

		// Token: 0x06004F2C RID: 20268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F2C")]
		[Address(RVA = "0x2280E34", Offset = "0x2280E34", VA = "0x7BBCA80E34")]
		private void AutoOpenLiveIfNeed()
		{
		}

		// Token: 0x06004F2D RID: 20269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F2D")]
		[Address(RVA = "0x228067C", Offset = "0x228067C", VA = "0x7BBCA8067C")]
		private void AutoOpenPeakDayWndIfNeed()
		{
		}

		// Token: 0x06004F2E RID: 20270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F2E")]
		[Address(RVA = "0x227E490", Offset = "0x227E490", VA = "0x7BBCA7E490")]
		private void AutoOpenChampionUrlIfNeed()
		{
		}

		// Token: 0x06004F2F RID: 20271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F2F")]
		[Address(RVA = "0x2280F48", Offset = "0x2280F48", VA = "0x7BBCA80F48")]
		private void OnBtnTokenClick()
		{
		}

		// Token: 0x06004F30 RID: 20272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F30")]
		[Address(RVA = "0x2281188", Offset = "0x2281188", VA = "0x7BBCA81188")]
		private void OnBtnRuleClick()
		{
		}

		// Token: 0x06004F31 RID: 20273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F31")]
		[Address(RVA = "0x2281344", Offset = "0x2281344", VA = "0x7BBCA81344")]
		private void OnBtnGuessClick()
		{
		}

		// Token: 0x06004F32 RID: 20274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F32")]
		[Address(RVA = "0x22817C0", Offset = "0x22817C0", VA = "0x7BBCA817C0")]
		private void OnBtnPeakDayClick()
		{
		}

		// Token: 0x06004F33 RID: 20275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F33")]
		[Address(RVA = "0x2281A98", Offset = "0x2281A98", VA = "0x7BBCA81A98")]
		private void OnBtnWebClick()
		{
		}

		// Token: 0x06004F34 RID: 20276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F34")]
		[Address(RVA = "0x2281BDC", Offset = "0x2281BDC", VA = "0x7BBCA81BDC")]
		private void OnBtnCupClick()
		{
		}

		// Token: 0x06004F35 RID: 20277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F35")]
		[Address(RVA = "0x2281F04", Offset = "0x2281F04", VA = "0x7BBCA81F04")]
		private void OnBtnMissionClick()
		{
		}

		// Token: 0x06004F36 RID: 20278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F36")]
		[Address(RVA = "0x2282024", Offset = "0x2282024", VA = "0x7BBCA82024")]
		private void OnBtnExchangeClick()
		{
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F37")]
		[Address(RVA = "0x2282188", Offset = "0x2282188", VA = "0x7BBCA82188")]
		private void OnBtnCheckInClick()
		{
		}

		// Token: 0x06004F38 RID: 20280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F38")]
		[Address(RVA = "0x2280E80", Offset = "0x2280E80", VA = "0x7BBCA80E80")]
		private void OpenLive()
		{
		}

		// Token: 0x06004F39 RID: 20281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F39")]
		[Address(RVA = "0x22822EC", Offset = "0x22822EC", VA = "0x7BBCA822EC")]
		private void OnBtnLiveClick()
		{
		}

		// Token: 0x06004F3A RID: 20282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F3A")]
		[Address(RVA = "0x228166C", Offset = "0x228166C", VA = "0x7BBCA8166C")]
		private void PlaySwitchPageAnim(UIFFWSMainPageController.SwitchPageAnimType animType)
		{
		}

		// Token: 0x06004F3B RID: 20283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F3B")]
		[Address(RVA = "0x22823E0", Offset = "0x22823E0", VA = "0x7BBCA823E0")]
		private void ProcessAnimEvt(params object[] data)
		{
		}

		// Token: 0x06004F3C RID: 20284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F3C")]
		[Address(RVA = "0x2282520", Offset = "0x2282520", VA = "0x7BBCA82520")]
		private void OnSwitchAnimFinished(UIFFWSMainPageController.SwitchPageAnimType animType)
		{
		}

		// Token: 0x06004F3D RID: 20285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F3D")]
		[Address(RVA = "0x22826A4", Offset = "0x22826A4", VA = "0x7BBCA826A4")]
		private void OnPageClose(params object[] data)
		{
		}

		// Token: 0x06004F3E RID: 20286 RVA: 0x00018240 File Offset: 0x00016440
		[Token(Token = "0x6004F3E")]
		[Address(RVA = "0x227E3C8", Offset = "0x227E3C8", VA = "0x7BBCA7E3C8")]
		private bool IsCurrentNavigation()
		{
			return default(bool);
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F3F")]
		[Address(RVA = "0x2282864", Offset = "0x2282864", VA = "0x7BBCA82864")]
		public UIFFWSMainPageController()
		{
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F40")]
		[Address(RVA = "0x22828F4", Offset = "0x22828F4", VA = "0x7BBCA828F4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DF8C", Offset = "0x113DF8C")]
		private void <OnDataChanged>b__12_0()
		{
		}

		// Token: 0x0400760A RID: 30218
		[Token(Token = "0x400760A")]
		[FieldOffset(Offset = "0xB8")]
		private UIFFWSMainPageView m_View;

		// Token: 0x0400760B RID: 30219
		[Token(Token = "0x400760B")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x0400760C RID: 30220
		[Token(Token = "0x400760C")]
		[FieldOffset(Offset = "0xC8")]
		private UIModelFFWS m_ModelFFWS;

		// Token: 0x0400760D RID: 30221
		[Token(Token = "0x400760D")]
		[FieldOffset(Offset = "0xD0")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x0400760E RID: 30222
		[Token(Token = "0x400760E")]
		[FieldOffset(Offset = "0xD8")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x0400760F RID: 30223
		[Token(Token = "0x400760F")]
		[FieldOffset(Offset = "0xE0")]
		private uint m_DelayCallAutoPeakDay;

		// Token: 0x04007610 RID: 30224
		[Token(Token = "0x4007610")]
		[FieldOffset(Offset = "0xE4")]
		private uint m_DelayCallAutoChampion;

		// Token: 0x04007611 RID: 30225
		[Token(Token = "0x4007611")]
		[FieldOffset(Offset = "0xE8")]
		private uint m_DelayCallAutoLive;

		// Token: 0x04007612 RID: 30226
		[Token(Token = "0x4007612")]
		[FieldOffset(Offset = "0xF0")]
		private UICountDownController m_CountDownCtrl;

		// Token: 0x04007613 RID: 30227
		[Token(Token = "0x4007613")]
		[FieldOffset(Offset = "0xF8")]
		private UICommonGuideController m_TutorialGuess;

		// Token: 0x04007614 RID: 30228
		[Token(Token = "0x4007614")]
		[FieldOffset(Offset = "0x100")]
		private UICommonGuideController m_TutorialMission;

		// Token: 0x04007615 RID: 30229
		[Token(Token = "0x4007615")]
		[FieldOffset(Offset = "0x108")]
		private UICommonGuideController m_TutorialAwaken;

		// Token: 0x02001361 RID: 4961
		[Token(Token = "0x2001361")]
		private enum SwitchPageAnimType
		{
			// Token: 0x04007617 RID: 30231
			[Token(Token = "0x4007617")]
			MainOnly,
			// Token: 0x04007618 RID: 30232
			[Token(Token = "0x4007618")]
			MainToGuess,
			// Token: 0x04007619 RID: 30233
			[Token(Token = "0x4007619")]
			MainToMission,
			// Token: 0x0400761A RID: 30234
			[Token(Token = "0x400761A")]
			GuessBackToMain,
			// Token: 0x0400761B RID: 30235
			[Token(Token = "0x400761B")]
			MissionBackToMain
		}

		// Token: 0x02001362 RID: 4962
		[Token(Token = "0x2001362")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB398", Offset = "0x10EB398")]
		private sealed class <>c__DisplayClass49_0
		{
			// Token: 0x06004F41 RID: 20289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F41")]
			[Address(RVA = "0x22823D8", Offset = "0x22823D8", VA = "0x7BBCA823D8")]
			public <>c__DisplayClass49_0()
			{
			}

			// Token: 0x06004F42 RID: 20290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F42")]
			[Address(RVA = "0x2282980", Offset = "0x2282980", VA = "0x7BBCA82980")]
			internal void <PlaySwitchPageAnim>b__0()
			{
			}

			// Token: 0x0400761C RID: 30236
			[Token(Token = "0x400761C")]
			[FieldOffset(Offset = "0x10")]
			public UIFFWSMainPageController.SwitchPageAnimType animType;

			// Token: 0x0400761D RID: 30237
			[Token(Token = "0x400761D")]
			[FieldOffset(Offset = "0x18")]
			public UIFFWSMainPageController <>4__this;
		}
	}
}
