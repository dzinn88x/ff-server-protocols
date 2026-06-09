using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using COW;
using GCommon;
using Il2CppDummyDll;

// Token: 0x020000EA RID: 234
[Token(Token = "0x20000EA")]
public class UIBasicSettingController : UISettingContentBase
{
	// Token: 0x06000409 RID: 1033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000409")]
	[Address(RVA = "0x1C99328", Offset = "0x1C99328", VA = "0x7BBC499328")]
	public void SetBindAccountStateDone()
	{
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040A")]
	[Address(RVA = "0x1C99520", Offset = "0x1C99520", VA = "0x7BBC499520", Slot = "28")]
	public override void SetInGameShow(bool isInGame)
	{
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00002B38 File Offset: 0x00000D38
	[Token(Token = "0x600040B")]
	[Address(RVA = "0x1C995EC", Offset = "0x1C995EC", VA = "0x7BBC4995EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040C")]
	[Address(RVA = "0x1C9963C", Offset = "0x1C9963C", VA = "0x7BBC49963C", Slot = "29")]
	protected override void InitSettingInfo()
	{
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040D")]
	[Address(RVA = "0x1C99730", Offset = "0x1C99730", VA = "0x7BBC499730", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040E")]
	[Address(RVA = "0x1C9998C", Offset = "0x1C9998C", VA = "0x7BBC49998C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040F")]
	[Address(RVA = "0x1C99F34", Offset = "0x1C99F34", VA = "0x7BBC499F34")]
	private void InitMiniMap()
	{
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000410")]
	[Address(RVA = "0x1C99ED8", Offset = "0x1C99ED8", VA = "0x7BBC499ED8")]
	private void InitBindPlatformDict()
	{
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000411")]
	[Address(RVA = "0x1C9B140", Offset = "0x1C9B140", VA = "0x7BBC49B140")]
	private void CheckPlatformBtnState(PlatformType platformType)
	{
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00002B50 File Offset: 0x00000D50
	[Token(Token = "0x6000412")]
	[Address(RVA = "0x1C9B288", Offset = "0x1C9B288", VA = "0x7BBC49B288")]
	private bool CheckPlatformBindBtnCanShow(bool showOutOfMore, PlatformType platformType)
	{
		return default(bool);
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000413")]
	[Address(RVA = "0x1C9A800", Offset = "0x1C9A800", VA = "0x7BBC49A800")]
	private void InitBindAccountSetting()
	{
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00002B68 File Offset: 0x00000D68
	[Token(Token = "0x6000414")]
	[Address(RVA = "0x1C9B38C", Offset = "0x1C9B38C", VA = "0x7BBC49B38C")]
	private bool ShouldShowBindAccount()
	{
		return default(bool);
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x00002B80 File Offset: 0x00000D80
	[Token(Token = "0x6000415")]
	[Address(RVA = "0x1C9AFCC", Offset = "0x1C9AFCC", VA = "0x7BBC49AFCC")]
	private bool ShouldShowCustomService()
	{
		return default(bool);
	}

	// Token: 0x06000416 RID: 1046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000416")]
	[Address(RVA = "0x1C9A0D0", Offset = "0x1C9A0D0", VA = "0x7BBC49A0D0")]
	private void InitBtnClickDelegete()
	{
	}

	// Token: 0x06000417 RID: 1047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000417")]
	[Address(RVA = "0x1C99FFC", Offset = "0x1C99FFC", VA = "0x7BBC499FFC")]
	private void InitLanguageSetting()
	{
	}

	// Token: 0x06000418 RID: 1048 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000418")]
	[Address(RVA = "0x1C9B41C", Offset = "0x1C9B41C", VA = "0x7BBC49B41C")]
	private void InitLanguageList()
	{
	}

	// Token: 0x06000419 RID: 1049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000419")]
	[Address(RVA = "0x1C9B6A4", Offset = "0x1C9B6A4", VA = "0x7BBC49B6A4")]
	private void ConfirmSetLan()
	{
	}

	// Token: 0x0600041A RID: 1050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041A")]
	[Address(RVA = "0x1C9B8E0", Offset = "0x1C9B8E0", VA = "0x7BBC49B8E0")]
	private void OnLocLanSelect(object obj)
	{
	}

	// Token: 0x0600041B RID: 1051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041B")]
	[Address(RVA = "0x1C9BC04", Offset = "0x1C9BC04", VA = "0x7BBC49BC04")]
	private void OnFacebookBindClick()
	{
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041C")]
	[Address(RVA = "0x1C9BC38", Offset = "0x1C9BC38", VA = "0x7BBC49BC38")]
	private void OnAppleBindClick()
	{
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041D")]
	[Address(RVA = "0x1C9BC6C", Offset = "0x1C9BC6C", VA = "0x7BBC49BC6C")]
	private void OnVKontakteBindClick()
	{
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041E")]
	[Address(RVA = "0x1C9BCA0", Offset = "0x1C9BCA0", VA = "0x7BBC49BCA0")]
	private void OnTwitterBindClick()
	{
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600041F")]
	[Address(RVA = "0x1C9BCD4", Offset = "0x1C9BCD4", VA = "0x7BBC49BCD4")]
	private void OnHuaweiBindClick()
	{
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000420")]
	[Address(RVA = "0x1C9BD40", Offset = "0x1C9BD40", VA = "0x7BBC49BD40")]
	private void OnGoogleBindClick()
	{
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000421")]
	[Address(RVA = "0x1C9BD74", Offset = "0x1C9BD74", VA = "0x7BBC49BD74")]
	private void OnPlatformCombinedBtnClick()
	{
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000422")]
	[Address(RVA = "0x1C9BF1C", Offset = "0x1C9BF1C", VA = "0x7BBC49BF1C")]
	private void onBtnTermsOfServiceClick()
	{
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000423")]
	[Address(RVA = "0x1C9BF24", Offset = "0x1C9BF24", VA = "0x7BBC49BF24")]
	private void onBtnPrivacyPolicyClick()
	{
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000424")]
	[Address(RVA = "0x1C9BF2C", Offset = "0x1C9BF2C", VA = "0x7BBC49BF2C")]
	private void OnBtnUserLicenceClick()
	{
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000425")]
	[Address(RVA = "0x1C9C1F8", Offset = "0x1C9C1F8", VA = "0x7BBC49C1F8")]
	private void DeleteAccountSecondConfirm()
	{
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000426")]
	[Address(RVA = "0x1C9C594", Offset = "0x1C9C594", VA = "0x7BBC49C594")]
	private void DeleteAccountThirdConfirm()
	{
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000427")]
	[Address(RVA = "0x1C9C8A0", Offset = "0x1C9C8A0", VA = "0x7BBC49C8A0")]
	private void DeleteAccountForthConfirm()
	{
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000428")]
	[Address(RVA = "0x1C9CC04", Offset = "0x1C9CC04", VA = "0x7BBC49CC04")]
	private void OnMinimapModeChange()
	{
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000429")]
	[Address(RVA = "0x1C9CE40", Offset = "0x1C9CE40", VA = "0x7BBC49CE40")]
	private void OnMinimapScaleAssistChange()
	{
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042A")]
	[Address(RVA = "0x1C9CFFC", Offset = "0x1C9CFFC", VA = "0x7BBC49CFFC")]
	private void OnLanPopMenuBtnClick()
	{
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042B")]
	[Address(RVA = "0x1C9D0C4", Offset = "0x1C9D0C4", VA = "0x7BBC49D0C4")]
	private void OnLogoutBtnClick()
	{
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042C")]
	[Address(RVA = "0x1C9D16C", Offset = "0x1C9D16C", VA = "0x7BBC49D16C")]
	private void OnRestoreBtnClick()
	{
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600042D")]
	[Address(RVA = "0x1C9D198", Offset = "0x1C9D198", VA = "0x7BBC49D198")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1132BD8", Offset = "0x1132BD8")]
	private IEnumerator RestoreCoroutine()
	{
		return null;
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042E")]
	[Address(RVA = "0x1C9D238", Offset = "0x1C9D238", VA = "0x7BBC49D238")]
	private void OnServiceBtnClick()
	{
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042F")]
	[Address(RVA = "0x1C9D464", Offset = "0x1C9D464", VA = "0x7BBC49D464")]
	public UIBasicSettingController()
	{
	}

	// Token: 0x06000430 RID: 1072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000430")]
	[Address(RVA = "0x1C9D4D4", Offset = "0x1C9D4D4", VA = "0x7BBC49D4D4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132C3C", Offset = "0x1132C3C")]
	private void <OnLocLanSelect>b__27_0()
	{
	}

	// Token: 0x06000431 RID: 1073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000431")]
	[Address(RVA = "0x1C9D5A0", Offset = "0x1C9D5A0", VA = "0x7BBC49D5A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132C4C", Offset = "0x1132C4C")]
	private void <OnBtnUserLicenceClick>b__37_0()
	{
	}

	// Token: 0x06000432 RID: 1074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000432")]
	[Address(RVA = "0x1C9D5A4", Offset = "0x1C9D5A4", VA = "0x7BBC49D5A4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132C5C", Offset = "0x1132C5C")]
	private void <DeleteAccountSecondConfirm>b__38_0()
	{
	}

	// Token: 0x06000433 RID: 1075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000433")]
	[Address(RVA = "0x1C9D5A8", Offset = "0x1C9D5A8", VA = "0x7BBC49D5A8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132C6C", Offset = "0x1132C6C")]
	private void <DeleteAccountThirdConfirm>b__39_0()
	{
	}

	// Token: 0x040003B9 RID: 953
	[Token(Token = "0x40003B9")]
	private const int TOGGLE_GROUP_ID = 117;

	// Token: 0x040003BA RID: 954
	[Token(Token = "0x40003BA")]
	private const string TXT_NOTCH_TIP = "TXT_NOTCH_TIP";

	// Token: 0x040003BB RID: 955
	[Token(Token = "0x40003BB")]
	[FieldOffset(Offset = "0x60")]
	private UIBasicSettingView m_View;

	// Token: 0x040003BC RID: 956
	[Token(Token = "0x40003BC")]
	[FieldOffset(Offset = "0x68")]
	private UIButton[] m_HideIngameGO;

	// Token: 0x040003BD RID: 957
	[Token(Token = "0x40003BD")]
	[FieldOffset(Offset = "0x70")]
	private LocLang m_SelectedLan;

	// Token: 0x040003BE RID: 958
	[Token(Token = "0x40003BE")]
	[FieldOffset(Offset = "0x78")]
	private List<PopMenuData> m_LanDataList;

	// Token: 0x040003BF RID: 959
	[Token(Token = "0x40003BF")]
	[FieldOffset(Offset = "0x80")]
	private UIModelLogin m_LoginModel;

	// Token: 0x040003C0 RID: 960
	[Token(Token = "0x40003C0")]
	[FieldOffset(Offset = "0x88")]
	private BasicSettingInfo m_SettingInfo;

	// Token: 0x040003C1 RID: 961
	[Token(Token = "0x40003C1")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<PlatformType, bool> m_PlatformNeedShowOutOfMore;

	// Token: 0x040003C2 RID: 962
	[Token(Token = "0x40003C2")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<PlatformType, bool> m_PlatformSupportSignin;

	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1DC8", Offset = "0x10E1DC8")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06000435 RID: 1077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1C9D610", Offset = "0x1C9D610", VA = "0x7BBC49D610")]
		public <>c()
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1C9D618", Offset = "0x1C9D618", VA = "0x7BBC49D618")]
		internal void <DeleteAccountSecondConfirm>b__38_1()
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1C9D6C0", Offset = "0x1C9D6C0", VA = "0x7BBC49D6C0")]
		internal void <DeleteAccountThirdConfirm>b__39_1()
		{
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1C9D768", Offset = "0x1C9D768", VA = "0x7BBC49D768")]
		internal bool <DeleteAccountForthConfirm>b__40_0(string text)
		{
			return default(bool);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1C9D99C", Offset = "0x1C9D99C", VA = "0x7BBC49D99C")]
		internal void <DeleteAccountForthConfirm>b__40_1()
		{
		}

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIBasicSettingController.<>c <>9;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x8")]
		public static Action <>9__38_1;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x10")]
		public static Action <>9__39_1;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x18")]
		public static UIAccountDelPopupController.InputStyleOnOk <>9__40_0;

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x20")]
		public static Action <>9__40_1;
	}

	// Token: 0x020000EC RID: 236
	[Token(Token = "0x20000EC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1DD8", Offset = "0x10E1DD8")]
	private sealed class <RestoreCoroutine>d__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1C9D20C", Offset = "0x1C9D20C", VA = "0x7BBC49D20C")]
		[DebuggerHidden]
		public <RestoreCoroutine>d__46(int <>1__state)
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1C9DA44", Offset = "0x1C9DA44", VA = "0x7BBC49DA44", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1C9DA48", Offset = "0x1C9DA48", VA = "0x7BBC49DA48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		private object Current
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x1C9DC9C", Offset = "0x1C9DC9C", VA = "0x7BBC49DC9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1C9DCA4", Offset = "0x1C9DCA4", VA = "0x7BBC49DCA4", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000044")]
		private object Current
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x1C9DD0C", Offset = "0x1C9DD0C", VA = "0x7BBC49DD0C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x20")]
		public UIBasicSettingController <>4__this;
	}
}
