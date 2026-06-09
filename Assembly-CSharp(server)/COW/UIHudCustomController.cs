using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018A1 RID: 6305
	[Token(Token = "0x20018A1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F47F4", Offset = "0x10F47F4")]
	public class UIHudCustomController : UIPopupWindowController
	{
		// Token: 0x06007D19 RID: 32025 RVA: 0x00022518 File Offset: 0x00020718
		[Token(Token = "0x6007D19")]
		[Address(RVA = "0x1A9FB80", Offset = "0x1A9FB80", VA = "0x7BBC29FB80")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007D1A RID: 32026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D1A")]
		[Address(RVA = "0x1A9FBD0", Offset = "0x1A9FBD0", VA = "0x7BBC29FBD0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007D1B RID: 32027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D1B")]
		[Address(RVA = "0x1AA0F98", Offset = "0x1AA0F98", VA = "0x7BBC2A0F98", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007D1C RID: 32028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D1C")]
		[Address(RVA = "0x1AA0E08", Offset = "0x1AA0E08", VA = "0x7BBC2A0E08")]
		private void InitToggle()
		{
		}

		// Token: 0x06007D1D RID: 32029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D1D")]
		[Address(RVA = "0x1AA1390", Offset = "0x1AA1390", VA = "0x7BBC2A1390")]
		private void OnCaseSwitchedToOne()
		{
		}

		// Token: 0x06007D1E RID: 32030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D1E")]
		[Address(RVA = "0x1AA1988", Offset = "0x1AA1988", VA = "0x7BBC2A1988")]
		private void OnCaseSwitchedToTwo()
		{
		}

		// Token: 0x06007D1F RID: 32031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D1F")]
		[Address(RVA = "0x1AA199C", Offset = "0x1AA199C", VA = "0x7BBC2A199C")]
		private void OnArrowClicked()
		{
		}

		// Token: 0x06007D20 RID: 32032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D20")]
		[Address(RVA = "0x1AA1C88", Offset = "0x1AA1C88", VA = "0x7BBC2A1C88")]
		private void OnCloseButtonClick(int from = 262, int to = 132)
		{
		}

		// Token: 0x06007D21 RID: 32033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D21")]
		[Address(RVA = "0x1AA1BC0", Offset = "0x1AA1BC0", VA = "0x7BBC2A1BC0")]
		private void OnExpandClicked(int from = 132, int to = 262)
		{
		}

		// Token: 0x06007D22 RID: 32034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D22")]
		[Address(RVA = "0x1AA1D80", Offset = "0x1AA1D80", VA = "0x7BBC2A1D80")]
		private void ExpandAdjustContainer()
		{
		}

		// Token: 0x06007D23 RID: 32035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D23")]
		[Address(RVA = "0x1AA20B8", Offset = "0x1AA20B8", VA = "0x7BBC2A20B8")]
		private void RefreshAdjustContainer()
		{
		}

		// Token: 0x06007D24 RID: 32036 RVA: 0x00022530 File Offset: 0x00020730
		[Token(Token = "0x6007D24")]
		[Address(RVA = "0x1AA1AE4", Offset = "0x1AA1AE4", VA = "0x7BBC2A1AE4")]
		private bool CheckEnableHidden(string name)
		{
			return default(bool);
		}

		// Token: 0x06007D25 RID: 32037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D25")]
		[Address(RVA = "0x1AA23FC", Offset = "0x1AA23FC", VA = "0x7BBC2A23FC")]
		private void OnHudPressed(params object[] param)
		{
		}

		// Token: 0x06007D26 RID: 32038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D26")]
		[Address(RVA = "0x1AA3378", Offset = "0x1AA3378", VA = "0x7BBC2A3378")]
		private void OnHudChangePosition(params object[] param)
		{
		}

		// Token: 0x06007D27 RID: 32039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D27")]
		[Address(RVA = "0x1AA0688", Offset = "0x1AA0688", VA = "0x7BBC2A0688")]
		private void InitData()
		{
		}

		// Token: 0x06007D28 RID: 32040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D28")]
		[Address(RVA = "0x1AA3620", Offset = "0x1AA3620", VA = "0x7BBC2A3620")]
		private void SetAnchor(Transform transform, EUIAnchor anchor)
		{
		}

		// Token: 0x06007D29 RID: 32041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D29")]
		[Address(RVA = "0x1AA44E0", Offset = "0x1AA44E0", VA = "0x7BBC2A44E0")]
		private void ResetData()
		{
		}

		// Token: 0x06007D2A RID: 32042 RVA: 0x00022548 File Offset: 0x00020748
		[Token(Token = "0x6007D2A")]
		[Address(RVA = "0x1AA3804", Offset = "0x1AA3804", VA = "0x7BBC2A3804")]
		private bool NeedShow(CustomHudItem hudItem)
		{
			return default(bool);
		}

		// Token: 0x06007D2B RID: 32043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D2B")]
		[Address(RVA = "0x1AA4AB0", Offset = "0x1AA4AB0", VA = "0x7BBC2A4AB0")]
		private void OnResetButtonClick()
		{
		}

		// Token: 0x06007D2C RID: 32044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D2C")]
		[Address(RVA = "0x1AA4D44", Offset = "0x1AA4D44", VA = "0x7BBC2A4D44")]
		private void OnConfirmButtonClick()
		{
		}

		// Token: 0x06007D2D RID: 32045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D2D")]
		[Address(RVA = "0x1AA5CF4", Offset = "0x1AA5CF4", VA = "0x7BBC2A5CF4")]
		private void OnCancelButtonClick()
		{
		}

		// Token: 0x06007D2E RID: 32046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D2E")]
		[Address(RVA = "0x1AA13A4", Offset = "0x1AA13A4", VA = "0x7BBC2A13A4")]
		private void OnCaseSwitchClicked(bool forward)
		{
		}

		// Token: 0x06007D2F RID: 32047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D2F")]
		[Address(RVA = "0x1AA5FDC", Offset = "0x1AA5FDC", VA = "0x7BBC2A5FDC")]
		private void PlaySlideEffect(bool forward)
		{
		}

		// Token: 0x06007D30 RID: 32048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D30")]
		[Address(RVA = "0x1AA64C4", Offset = "0x1AA64C4", VA = "0x7BBC2A64C4")]
		private void OnSizeSliderBarChange()
		{
		}

		// Token: 0x06007D31 RID: 32049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D31")]
		[Address(RVA = "0x1AA6788", Offset = "0x1AA6788", VA = "0x7BBC2A6788")]
		private void OnSizeSliderBarChangeFinished()
		{
		}

		// Token: 0x06007D32 RID: 32050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D32")]
		[Address(RVA = "0x1AA695C", Offset = "0x1AA695C", VA = "0x7BBC2A695C")]
		private void OnHiddenStatusChanged()
		{
		}

		// Token: 0x06007D33 RID: 32051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D33")]
		[Address(RVA = "0x1AA6B20", Offset = "0x1AA6B20", VA = "0x7BBC2A6B20")]
		public void OnAlphaSliderBarChange()
		{
		}

		// Token: 0x06007D34 RID: 32052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D34")]
		[Address(RVA = "0x1AA6D18", Offset = "0x1AA6D18", VA = "0x7BBC2A6D18")]
		public void OnAlphaSliderBarChangeFinished()
		{
		}

		// Token: 0x06007D35 RID: 32053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D35")]
		[Address(RVA = "0x1AA22A0", Offset = "0x1AA22A0", VA = "0x7BBC2A22A0")]
		private void UpdateSliderBar(UISlider sliderBar, UILabel label, float value)
		{
		}

		// Token: 0x06007D36 RID: 32054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D36")]
		[Address(RVA = "0x1AA239C", Offset = "0x1AA239C", VA = "0x7BBC2A239C")]
		private void UpdateHiddenToggle(UIToggle toggle, bool isHidden)
		{
		}

		// Token: 0x06007D37 RID: 32055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007D37")]
		[Address(RVA = "0x1AA327C", Offset = "0x1AA327C", VA = "0x7BBC2A327C")]
		private HudConfigItem GetCurrentHudConfigTemporary(string hudName)
		{
			return null;
		}

		// Token: 0x06007D38 RID: 32056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D38")]
		[Address(RVA = "0x1AA3564", Offset = "0x1AA3564", VA = "0x7BBC2A3564")]
		private void ChangeHudConfigTemporary(string hudName, HudConfigItem hudConfig)
		{
		}

		// Token: 0x06007D39 RID: 32057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D39")]
		[Address(RVA = "0x1AA6EC4", Offset = "0x1AA6EC4", VA = "0x7BBC2A6EC4")]
		private void OnHudChanged()
		{
		}

		// Token: 0x06007D3A RID: 32058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D3A")]
		[Address(RVA = "0x1AA6F6C", Offset = "0x1AA6F6C", VA = "0x7BBC2A6F6C")]
		private void OnGrenadeLeftBtnClicked()
		{
		}

		// Token: 0x06007D3B RID: 32059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D3B")]
		[Address(RVA = "0x1AA7030", Offset = "0x1AA7030", VA = "0x7BBC2A7030")]
		private void OnGrenadeRightBtnClicked()
		{
		}

		// Token: 0x06007D3C RID: 32060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D3C")]
		[Address(RVA = "0x1AA70F4", Offset = "0x1AA70F4", VA = "0x7BBC2A70F4")]
		private void OnGrenadeTopBtnClicked()
		{
		}

		// Token: 0x06007D3D RID: 32061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D3D")]
		[Address(RVA = "0x1AA71B0", Offset = "0x1AA71B0", VA = "0x7BBC2A71B0")]
		private void OnGrenadeBottomBtnClicked()
		{
		}

		// Token: 0x06007D3E RID: 32062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D3E")]
		[Address(RVA = "0x1AA3A90", Offset = "0x1AA3A90", VA = "0x7BBC2A3A90")]
		private void SetDirection(int direction)
		{
		}

		// Token: 0x06007D3F RID: 32063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D3F")]
		[Address(RVA = "0x1AA7274", Offset = "0x1AA7274", VA = "0x7BBC2A7274")]
		public UIHudCustomController()
		{
		}

		// Token: 0x06007D40 RID: 32064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D40")]
		[Address(RVA = "0x1AA7344", Offset = "0x1AA7344", VA = "0x7BBC2A7344")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142B24", Offset = "0x1142B24")]
		private void <OnResetButtonClick>b__46_0()
		{
		}

		// Token: 0x06007D41 RID: 32065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007D41")]
		[Address(RVA = "0x1AA7408", Offset = "0x1AA7408", VA = "0x7BBC2A7408")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142B34", Offset = "0x1142B34")]
		private void <OnCancelButtonClick>b__48_0()
		{
		}

		// Token: 0x040090C9 RID: 37065
		[Token(Token = "0x40090C9")]
		[FieldOffset(Offset = "0x98")]
		private UIHudCustomView m_View;

		// Token: 0x040090CA RID: 37066
		[Token(Token = "0x40090CA")]
		[FieldOffset(Offset = "0xA0")]
		private CustomHudItem m_CurrentHudItem;

		// Token: 0x040090CB RID: 37067
		[Token(Token = "0x40090CB")]
		[FieldOffset(Offset = "0xA8")]
		private HudConfigItem m_HudConfigItem;

		// Token: 0x040090CC RID: 37068
		[Token(Token = "0x40090CC")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_FirstCase;

		// Token: 0x040090CD RID: 37069
		[Token(Token = "0x40090CD")]
		[FieldOffset(Offset = "0xB8")]
		private List<CustomHudItem> m_CustomHudList;

		// Token: 0x040090CE RID: 37070
		[Token(Token = "0x40090CE")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<string, HudConfigItem> m_ConfigChangeList;

		// Token: 0x040090CF RID: 37071
		[Token(Token = "0x40090CF")]
		[FieldOffset(Offset = "0xC8")]
		private List<string> m_EnableHiddenList;

		// Token: 0x040090D0 RID: 37072
		[Token(Token = "0x40090D0")]
		private const string m_ReloadName = "HudReloadBtn";

		// Token: 0x040090D1 RID: 37073
		[Token(Token = "0x40090D1")]
		private const string m_ChangeWeaponName = "HudSwapWeaponQuick";

		// Token: 0x040090D2 RID: 37074
		[Token(Token = "0x40090D2")]
		private const string m_LeftFireName = "HudAuxFire";

		// Token: 0x040090D3 RID: 37075
		[Token(Token = "0x40090D3")]
		private const string m_AuxAimName = "HudAuxAim";

		// Token: 0x040090D4 RID: 37076
		[Token(Token = "0x40090D4")]
		private const string m_JoystickName = "HudMovingJoystick";

		// Token: 0x040090D5 RID: 37077
		[Token(Token = "0x40090D5")]
		private const string m_UIHudGrenadeBtnName = "HudGrenadeChange";

		// Token: 0x040090D6 RID: 37078
		[Token(Token = "0x40090D6")]
		private const string m_SwimmingSurfName = "HudSwimmingSurf";

		// Token: 0x040090D7 RID: 37079
		[Token(Token = "0x40090D7")]
		private const int HEIGHT_BUTTONS = 132;

		// Token: 0x040090D8 RID: 37080
		[Token(Token = "0x40090D8")]
		private const int HEIGHT_ADJUST = 262;

		// Token: 0x040090D9 RID: 37081
		[Token(Token = "0x40090D9")]
		private const int HEIGHT_ADJUST_WITH_HIDE = 300;

		// Token: 0x040090DA RID: 37082
		[Token(Token = "0x40090DA")]
		private const int HEIGHT_DIRECTIONS = 341;

		// Token: 0x040090DB RID: 37083
		[Token(Token = "0x40090DB")]
		[FieldOffset(Offset = "0xD0")]
		private UIWidget m_GrenadeWidget;

		// Token: 0x040090DC RID: 37084
		[Token(Token = "0x40090DC")]
		[FieldOffset(Offset = "0xD8")]
		private BoxCollider m_GrenadeCollider;

		// Token: 0x040090DD RID: 37085
		[Token(Token = "0x40090DD")]
		[FieldOffset(Offset = "0xE0")]
		private EdgeDetectHudItem m_GrenadeEdgeDetect;

		// Token: 0x040090DE RID: 37086
		[Token(Token = "0x40090DE")]
		private const int GrenadeHLength = 70;

		// Token: 0x040090DF RID: 37087
		[Token(Token = "0x40090DF")]
		private const int GrenadeVLength = 100;

		// Token: 0x040090E0 RID: 37088
		[Token(Token = "0x40090E0")]
		private const int GrenadeColliderHLength = 340;

		// Token: 0x040090E1 RID: 37089
		[Token(Token = "0x40090E1")]
		private const int GrenadeColliderVLength = 100;

		// Token: 0x040090E2 RID: 37090
		[Token(Token = "0x40090E2")]
		[FieldOffset(Offset = "0xE8")]
		private int m_CurrentGrenadeDirection;

		// Token: 0x040090E3 RID: 37091
		[Token(Token = "0x40090E3")]
		[FieldOffset(Offset = "0xEC")]
		private UIHudCustomController.TweenHeightType m_TweenHeightType;

		// Token: 0x020018A2 RID: 6306
		[Token(Token = "0x20018A2")]
		private enum TweenHeightType
		{
			// Token: 0x040090E5 RID: 37093
			[Token(Token = "0x40090E5")]
			None,
			// Token: 0x040090E6 RID: 37094
			[Token(Token = "0x40090E6")]
			ExpandAdjust
		}

		// Token: 0x020018A3 RID: 6307
		[Token(Token = "0x20018A3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F482C", Offset = "0x10F482C")]
		private sealed class <>c__DisplayClass39_0
		{
			// Token: 0x06007D42 RID: 32066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D42")]
			[Address(RVA = "0x1AA23F4", Offset = "0x1AA23F4", VA = "0x7BBC2A23F4")]
			public <>c__DisplayClass39_0()
			{
			}

			// Token: 0x06007D43 RID: 32067 RVA: 0x00022560 File Offset: 0x00020760
			[Token(Token = "0x6007D43")]
			[Address(RVA = "0x1AA759C", Offset = "0x1AA759C", VA = "0x7BBC2A759C")]
			internal bool <CheckEnableHidden>b__0(string item)
			{
				return default(bool);
			}

			// Token: 0x040090E7 RID: 37095
			[Token(Token = "0x40090E7")]
			[FieldOffset(Offset = "0x10")]
			public string name;
		}

		// Token: 0x020018A4 RID: 6308
		[Token(Token = "0x20018A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F483C", Offset = "0x10F483C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06007D45 RID: 32069 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D45")]
			[Address(RVA = "0x1AA7474", Offset = "0x1AA7474", VA = "0x7BBC2A7474")]
			public <>c()
			{
			}

			// Token: 0x06007D46 RID: 32070 RVA: 0x00022578 File Offset: 0x00020778
			[Token(Token = "0x6007D46")]
			[Address(RVA = "0x1AA747C", Offset = "0x1AA747C", VA = "0x7BBC2A747C")]
			internal bool <OnConfirmButtonClick>b__47_0(CustomHudItem a)
			{
				return default(bool);
			}

			// Token: 0x06007D47 RID: 32071 RVA: 0x00022590 File Offset: 0x00020790
			[Token(Token = "0x6007D47")]
			[Address(RVA = "0x1AA74DC", Offset = "0x1AA74DC", VA = "0x7BBC2A74DC")]
			internal bool <OnConfirmButtonClick>b__47_1(CustomHudItem a)
			{
				return default(bool);
			}

			// Token: 0x06007D48 RID: 32072 RVA: 0x000225A8 File Offset: 0x000207A8
			[Token(Token = "0x6007D48")]
			[Address(RVA = "0x1AA753C", Offset = "0x1AA753C", VA = "0x7BBC2A753C")]
			internal bool <OnConfirmButtonClick>b__47_2(CustomHudItem a)
			{
				return default(bool);
			}

			// Token: 0x040090E8 RID: 37096
			[Token(Token = "0x40090E8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudCustomController.<>c <>9;

			// Token: 0x040090E9 RID: 37097
			[Token(Token = "0x40090E9")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<CustomHudItem> <>9__47_0;

			// Token: 0x040090EA RID: 37098
			[Token(Token = "0x40090EA")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<CustomHudItem> <>9__47_1;

			// Token: 0x040090EB RID: 37099
			[Token(Token = "0x40090EB")]
			[FieldOffset(Offset = "0x18")]
			public static Predicate<CustomHudItem> <>9__47_2;
		}

		// Token: 0x020018A5 RID: 6309
		[Token(Token = "0x20018A5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F484C", Offset = "0x10F484C")]
		private sealed class <>c__DisplayClass49_0
		{
			// Token: 0x06007D49 RID: 32073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D49")]
			[Address(RVA = "0x1AA5FD4", Offset = "0x1AA5FD4", VA = "0x7BBC2A5FD4")]
			public <>c__DisplayClass49_0()
			{
			}

			// Token: 0x06007D4A RID: 32074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D4A")]
			[Address(RVA = "0x1AA75B0", Offset = "0x1AA75B0", VA = "0x7BBC2A75B0")]
			internal void <OnCaseSwitchClicked>b__0()
			{
			}

			// Token: 0x040090EC RID: 37100
			[Token(Token = "0x40090EC")]
			[FieldOffset(Offset = "0x10")]
			public UIHudCustomController <>4__this;

			// Token: 0x040090ED RID: 37101
			[Token(Token = "0x40090ED")]
			[FieldOffset(Offset = "0x18")]
			public bool forward;
		}
	}
}
