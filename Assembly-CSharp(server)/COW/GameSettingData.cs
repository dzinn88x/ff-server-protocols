using System;
using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using COW.HUD;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020012EF RID: 4847
	[Token(Token = "0x20012EF")]
	public static class GameSettingData
	{
		// Token: 0x06004CB0 RID: 19632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB0")]
		[Address(RVA = "0x1B6D2B0", Offset = "0x1B6D2B0", VA = "0x7BBC36D2B0")]
		public static void SetLoclizationLanguage(LocLang locLang)
		{
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x00016F80 File Offset: 0x00015180
		[Token(Token = "0x6004CB1")]
		[Address(RVA = "0x1B6D3D8", Offset = "0x1B6D3D8", VA = "0x7BBC36D3D8")]
		public static LocLang GetLoclizationLanguage()
		{
			return LocLang.None;
		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB2")]
		[Address(RVA = "0x1B6D494", Offset = "0x1B6D494", VA = "0x7BBC36D494")]
		public static void SetSensitivity(float sen)
		{
		}

		// Token: 0x06004CB3 RID: 19635 RVA: 0x00016F98 File Offset: 0x00015198
		[Token(Token = "0x6004CB3")]
		[Address(RVA = "0x1B6D544", Offset = "0x1B6D544", VA = "0x7BBC36D544")]
		public static float GetSensitivity()
		{
			return 0f;
		}

		// Token: 0x06004CB4 RID: 19636 RVA: 0x00016FB0 File Offset: 0x000151B0
		[Token(Token = "0x6004CB4")]
		[Address(RVA = "0x1B6D658", Offset = "0x1B6D658", VA = "0x7BBC36D658")]
		public static float GetAndroidSensitivityByType(int type)
		{
			return 0f;
		}

		// Token: 0x06004CB5 RID: 19637 RVA: 0x00016FC8 File Offset: 0x000151C8
		[Token(Token = "0x6004CB5")]
		[Address(RVA = "0x1B6D774", Offset = "0x1B6D774", VA = "0x7BBC36D774")]
		public static bool IsUseNewDeathCameraMode(int modeID)
		{
			return default(bool);
		}

		// Token: 0x06004CB6 RID: 19638 RVA: 0x00016FE0 File Offset: 0x000151E0
		[Token(Token = "0x6004CB6")]
		[Address(RVA = "0x1B6D8B4", Offset = "0x1B6D8B4", VA = "0x7BBC36D8B4")]
		public static float GetIosSensivivityByType(int type)
		{
			return 0f;
		}

		// Token: 0x06004CB7 RID: 19639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB7")]
		[Address(RVA = "0x1B6D9D0", Offset = "0x1B6D9D0", VA = "0x7BBC36D9D0")]
		public static void SetAuxAimSensitivity(float sen)
		{
		}

		// Token: 0x06004CB8 RID: 19640 RVA: 0x00016FF8 File Offset: 0x000151F8
		[Token(Token = "0x6004CB8")]
		[Address(RVA = "0x1B6DA80", Offset = "0x1B6DA80", VA = "0x7BBC36DA80")]
		public static bool IsUsingSpHudCsplayerInfo()
		{
			return default(bool);
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CB9")]
		[Address(RVA = "0x1B6DBBC", Offset = "0x1B6DBBC", VA = "0x7BBC36DBBC")]
		public static void SetUsingSpHudCsplayerInfo(bool use)
		{
		}

		// Token: 0x06004CBA RID: 19642 RVA: 0x00017010 File Offset: 0x00015210
		[Token(Token = "0x6004CBA")]
		[Address(RVA = "0x1B6DC94", Offset = "0x1B6DC94", VA = "0x7BBC36DC94")]
		public static float GetAuxAimSensitivity()
		{
			return 0f;
		}

		// Token: 0x06004CBB RID: 19643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CBB")]
		[Address(RVA = "0x1B6DD9C", Offset = "0x1B6DD9C", VA = "0x7BBC36DD9C")]
		public static void SetMusicVolume(float volume)
		{
		}

		// Token: 0x06004CBC RID: 19644 RVA: 0x00017028 File Offset: 0x00015228
		[Token(Token = "0x6004CBC")]
		[Address(RVA = "0x1B6DE1C", Offset = "0x1B6DE1C", VA = "0x7BBC36DE1C")]
		public static float GetMusicVolume()
		{
			return 0f;
		}

		// Token: 0x06004CBD RID: 19645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CBD")]
		[Address(RVA = "0x1B6DE90", Offset = "0x1B6DE90", VA = "0x7BBC36DE90")]
		public static void SetSoundEffect(float volume)
		{
		}

		// Token: 0x06004CBE RID: 19646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CBE")]
		[Address(RVA = "0x1B6DF10", Offset = "0x1B6DF10", VA = "0x7BBC36DF10")]
		public static void SetPCFireSound(float volume)
		{
		}

		// Token: 0x06004CBF RID: 19647 RVA: 0x00017040 File Offset: 0x00015240
		[Token(Token = "0x6004CBF")]
		[Address(RVA = "0x1B6DF90", Offset = "0x1B6DF90", VA = "0x7BBC36DF90")]
		public static float GetPCFireSound()
		{
			return 0f;
		}

		// Token: 0x06004CC0 RID: 19648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC0")]
		[Address(RVA = "0x1B6E004", Offset = "0x1B6E004", VA = "0x7BBC36E004")]
		public static void SetPCAchievementSound(float volume)
		{
		}

		// Token: 0x06004CC1 RID: 19649 RVA: 0x00017058 File Offset: 0x00015258
		[Token(Token = "0x6004CC1")]
		[Address(RVA = "0x1B6E084", Offset = "0x1B6E084", VA = "0x7BBC36E084")]
		public static float GetPCAchievementSound()
		{
			return 0f;
		}

		// Token: 0x06004CC2 RID: 19650 RVA: 0x00017070 File Offset: 0x00015270
		[Token(Token = "0x6004CC2")]
		[Address(RVA = "0x1B6E0F8", Offset = "0x1B6E0F8", VA = "0x7BBC36E0F8")]
		public static bool GetAutoFire()
		{
			return default(bool);
		}

		// Token: 0x06004CC3 RID: 19651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC3")]
		[Address(RVA = "0x1B6E2C8", Offset = "0x1B6E2C8", VA = "0x7BBC36E2C8")]
		public static void SetAutoFire(bool autoFire)
		{
		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x00017088 File Offset: 0x00015288
		[Token(Token = "0x6004CC4")]
		[Address(RVA = "0x1B6E3A0", Offset = "0x1B6E3A0", VA = "0x7BBC36E3A0")]
		public static bool GetAutoSwitchWeapon()
		{
			return default(bool);
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC5")]
		[Address(RVA = "0x1B6E454", Offset = "0x1B6E454", VA = "0x7BBC36E454")]
		public static void SetAutoSwitchWeapon(bool flag)
		{
		}

		// Token: 0x06004CC6 RID: 19654 RVA: 0x000170A0 File Offset: 0x000152A0
		[Token(Token = "0x6004CC6")]
		[Address(RVA = "0x1B6E4D4", Offset = "0x1B6E4D4", VA = "0x7BBC36E4D4")]
		public static bool IsAutoFireMode(bool ck = false)
		{
			return default(bool);
		}

		// Token: 0x06004CC7 RID: 19655 RVA: 0x000170B8 File Offset: 0x000152B8
		[Token(Token = "0x6004CC7")]
		[Address(RVA = "0x1B6E588", Offset = "0x1B6E588", VA = "0x7BBC36E588")]
		public static float GetSoundEffect()
		{
			return 0f;
		}

		// Token: 0x06004CC8 RID: 19656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC8")]
		[Address(RVA = "0x1B6E5FC", Offset = "0x1B6E5FC", VA = "0x7BBC36E5FC")]
		public static void SetGameVoiceVolume(float volume)
		{
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x000170D0 File Offset: 0x000152D0
		[Token(Token = "0x6004CC9")]
		[Address(RVA = "0x1B6E67C", Offset = "0x1B6E67C", VA = "0x7BBC36E67C")]
		public static float GetGameVoiceVolume()
		{
			return 0f;
		}

		// Token: 0x06004CCA RID: 19658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CCA")]
		[Address(RVA = "0x1B6E6F0", Offset = "0x1B6E6F0", VA = "0x7BBC36E6F0")]
		public static void SetMinimapMode(UIHudMinimapController.|}Myxy~ mode)
		{
		}

		// Token: 0x06004CCB RID: 19659 RVA: 0x000170E8 File Offset: 0x000152E8
		[Token(Token = "0x6004CCB")]
		[Address(RVA = "0x1B6E768", Offset = "0x1B6E768", VA = "0x7BBC36E768")]
		public static UIHudMinimapController.|}Myxy~ GetMinimapMode()
		{
			return UIHudMinimapController.|}Myxy~.NorthUp;
		}

		// Token: 0x06004CCC RID: 19660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CCC")]
		[Address(RVA = "0x1B6E7DC", Offset = "0x1B6E7DC", VA = "0x7BBC36E7DC")]
		public static void SetMiniMapScaleAssistEnabled(bool enabled)
		{
		}

		// Token: 0x06004CCD RID: 19661 RVA: 0x00017100 File Offset: 0x00015300
		[Token(Token = "0x6004CCD")]
		[Address(RVA = "0x1B6E85C", Offset = "0x1B6E85C", VA = "0x7BBC36E85C")]
		public static bool GetMiniMapScaleAssistEnabled()
		{
			return default(bool);
		}

		// Token: 0x06004CCE RID: 19662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CCE")]
		[Address(RVA = "0x1B6E8DC", Offset = "0x1B6E8DC", VA = "0x7BBC36E8DC")]
		public static void SetQuality(GGfm}Dt q)
		{
		}

		// Token: 0x06004CCF RID: 19663 RVA: 0x00017118 File Offset: 0x00015318
		[Token(Token = "0x6004CCF")]
		[Address(RVA = "0x1B6EBB0", Offset = "0x1B6EBB0", VA = "0x7BBC36EBB0")]
		public static GGfm}Dt GetRecommendedQuality(bool InAfterSystemInited = true)
		{
			return GGfm}Dt.High;
		}

		// Token: 0x06004CD0 RID: 19664 RVA: 0x00017130 File Offset: 0x00015330
		[Token(Token = "0x6004CD0")]
		[Address(RVA = "0x1B6EA4C", Offset = "0x1B6EA4C", VA = "0x7BBC36EA4C")]
		public static GGfm}Dt GetQuality(bool InAfterSystemInited = true)
		{
			return GGfm}Dt.High;
		}

		// Token: 0x06004CD1 RID: 19665 RVA: 0x00017148 File Offset: 0x00015348
		[Token(Token = "0x6004CD1")]
		[Address(RVA = "0x1B6ED10", Offset = "0x1B6ED10", VA = "0x7BBC36ED10")]
		public static Rqvv|Tq GetGraphicQuality()
		{
			return (Rqvv|Tq)0;
		}

		// Token: 0x06004CD2 RID: 19666 RVA: 0x00017160 File Offset: 0x00015360
		[Token(Token = "0x6004CD2")]
		[Address(RVA = "0x1B6EDDC", Offset = "0x1B6EDDC", VA = "0x7BBC36EDDC")]
		public static bool IsMemoryHighest()
		{
			return default(bool);
		}

		// Token: 0x06004CD3 RID: 19667 RVA: 0x00017178 File Offset: 0x00015378
		[Token(Token = "0x6004CD3")]
		[Address(RVA = "0x1B6EE5C", Offset = "0x1B6EE5C", VA = "0x7BBC36EE5C")]
		public static MsgkYpB GetMemoryLevel()
		{
			return MsgkYpB.Low;
		}

		// Token: 0x06004CD4 RID: 19668 RVA: 0x00017190 File Offset: 0x00015390
		[Token(Token = "0x6004CD4")]
		[Address(RVA = "0x1B6EF24", Offset = "0x1B6EF24", VA = "0x7BBC36EF24")]
		public static bool IsHighFramerate()
		{
			return default(bool);
		}

		// Token: 0x06004CD5 RID: 19669 RVA: 0x000171A8 File Offset: 0x000153A8
		[Token(Token = "0x6004CD5")]
		[Address(RVA = "0x1B6F14C", Offset = "0x1B6F14C", VA = "0x7BBC36F14C")]
		public static bool ShowHighFrameOption()
		{
			return default(bool);
		}

		// Token: 0x06004CD6 RID: 19670 RVA: 0x000171C0 File Offset: 0x000153C0
		[Token(Token = "0x6004CD6")]
		[Address(RVA = "0x1B6F1D8", Offset = "0x1B6F1D8", VA = "0x7BBC36F1D8")]
		public static bool IsLowMemoryIOS()
		{
			return default(bool);
		}

		// Token: 0x06004CD7 RID: 19671 RVA: 0x000171D8 File Offset: 0x000153D8
		[Token(Token = "0x6004CD7")]
		[Address(RVA = "0x1B6F264", Offset = "0x1B6F264", VA = "0x7BBC36F264")]
		public static bool IsForceUseLowResource()
		{
			return default(bool);
		}

		// Token: 0x06004CD8 RID: 19672 RVA: 0x000171F0 File Offset: 0x000153F0
		[Token(Token = "0x6004CD8")]
		[Address(RVA = "0x1B6F2F0", Offset = "0x1B6F2F0", VA = "0x7BBC36F2F0")]
		private static bool CheckShadowSupport()
		{
			return default(bool);
		}

		// Token: 0x06004CD9 RID: 19673 RVA: 0x00017208 File Offset: 0x00015408
		[Token(Token = "0x6004CD9")]
		[Address(RVA = "0x1B6F2F8", Offset = "0x1B6F2F8", VA = "0x7BBC36F2F8")]
		public static bool ShowShadowOption()
		{
			return default(bool);
		}

		// Token: 0x06004CDA RID: 19674 RVA: 0x00017220 File Offset: 0x00015420
		[Token(Token = "0x6004CDA")]
		[Address(RVA = "0x1B6F3E8", Offset = "0x1B6F3E8", VA = "0x7BBC36F3E8")]
		public static bool IsHDGraphics()
		{
			return default(bool);
		}

		// Token: 0x06004CDB RID: 19675 RVA: 0x00017238 File Offset: 0x00015438
		[Token(Token = "0x6004CDB")]
		[Address(RVA = "0x1B6F474", Offset = "0x1B6F474", VA = "0x7BBC36F474")]
		public static Rqvv|Tq GetMapDesertGraphicQuality()
		{
			return (Rqvv|Tq)0;
		}

		// Token: 0x06004CDC RID: 19676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CDC")]
		[Address(RVA = "0x1B6F508", Offset = "0x1B6F508", VA = "0x7BBC36F508")]
		public static void SetInGameFilter(EInGameFilterSetting b)
		{
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x00017250 File Offset: 0x00015450
		[Token(Token = "0x6004CDD")]
		[Address(RVA = "0x1B6F580", Offset = "0x1B6F580", VA = "0x7BBC36F580")]
		public static EInGameFilterSetting GetInGameFilter()
		{
			return EInGameFilterSetting.Classic;
		}

		// Token: 0x06004CDE RID: 19678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CDE")]
		[Address(RVA = "0x1B6F5F4", Offset = "0x1B6F5F4", VA = "0x7BBC36F5F4")]
		public static void Set1xScopeSensitivity(float sen)
		{
		}

		// Token: 0x06004CDF RID: 19679 RVA: 0x00017268 File Offset: 0x00015468
		[Token(Token = "0x6004CDF")]
		[Address(RVA = "0x1B6F674", Offset = "0x1B6F674", VA = "0x7BBC36F674")]
		public static float Get1xScopeSensitivity()
		{
			return 0f;
		}

		// Token: 0x06004CE0 RID: 19680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE0")]
		[Address(RVA = "0x1B6F7D8", Offset = "0x1B6F7D8", VA = "0x7BBC36F7D8")]
		public static void Set2xScopeSensitivity(float sen)
		{
		}

		// Token: 0x06004CE1 RID: 19681 RVA: 0x00017280 File Offset: 0x00015480
		[Token(Token = "0x6004CE1")]
		[Address(RVA = "0x1B6F858", Offset = "0x1B6F858", VA = "0x7BBC36F858")]
		public static float Get2xScopeSensitivity()
		{
			return 0f;
		}

		// Token: 0x06004CE2 RID: 19682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE2")]
		[Address(RVA = "0x1B6F8B8", Offset = "0x1B6F8B8", VA = "0x7BBC36F8B8")]
		public static void Set4xScopeSensitivity(float sen)
		{
		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x00017298 File Offset: 0x00015498
		[Token(Token = "0x6004CE3")]
		[Address(RVA = "0x1B6F938", Offset = "0x1B6F938", VA = "0x7BBC36F938")]
		public static float Get4xScopeSensitivity()
		{
			return 0f;
		}

		// Token: 0x06004CE4 RID: 19684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE4")]
		[Address(RVA = "0x1B6F998", Offset = "0x1B6F998", VA = "0x7BBC36F998")]
		public static void Set8xScopeSensitivity(float sen)
		{
		}

		// Token: 0x06004CE5 RID: 19685 RVA: 0x000172B0 File Offset: 0x000154B0
		[Token(Token = "0x6004CE5")]
		[Address(RVA = "0x1B6FA18", Offset = "0x1B6FA18", VA = "0x7BBC36FA18")]
		public static float Get8xScopeSensitivity()
		{
			return 0f;
		}

		// Token: 0x06004CE6 RID: 19686 RVA: 0x000172C8 File Offset: 0x000154C8
		[Token(Token = "0x6004CE6")]
		[Address(RVA = "0x1B6F6D4", Offset = "0x1B6F6D4", VA = "0x7BBC36F6D4")]
		public static float GetScopeSensitivity(int x)
		{
			return 0f;
		}

		// Token: 0x06004CE7 RID: 19687 RVA: 0x000172E0 File Offset: 0x000154E0
		[Token(Token = "0x6004CE7")]
		[Address(RVA = "0x1B6FA78", Offset = "0x1B6FA78", VA = "0x7BBC36FA78")]
		public static EAimAssist GetAimAssistSetting()
		{
			return EAimAssist.AllOn;
		}

		// Token: 0x06004CE8 RID: 19688 RVA: 0x000172F8 File Offset: 0x000154F8
		[Token(Token = "0x6004CE8")]
		[Address(RVA = "0x1B6FAEC", Offset = "0x1B6FAEC", VA = "0x7BBC36FAEC")]
		public static EOpenScopeOperate GetOpenScopeOperate()
		{
			return EOpenScopeOperate.Tradition;
		}

		// Token: 0x06004CE9 RID: 19689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CE9")]
		[Address(RVA = "0x1B6FB60", Offset = "0x1B6FB60", VA = "0x7BBC36FB60")]
		public static void SetOpenScopeOperate(EOpenScopeOperate o)
		{
		}

		// Token: 0x06004CEA RID: 19690 RVA: 0x00017310 File Offset: 0x00015510
		[Token(Token = "0x6004CEA")]
		[Address(RVA = "0x1B6FBD8", Offset = "0x1B6FBD8", VA = "0x7BBC36FBD8")]
		public static ENotchScreen GetNotchScreen()
		{
			return ENotchScreen.On;
		}

		// Token: 0x06004CEB RID: 19691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEB")]
		[Address(RVA = "0x1B6FD1C", Offset = "0x1B6FD1C", VA = "0x7BBC36FD1C")]
		public static void SetNotchScreen(ENotchScreen o)
		{
		}

		// Token: 0x06004CEC RID: 19692 RVA: 0x00017328 File Offset: 0x00015528
		[Token(Token = "0x6004CEC")]
		[Address(RVA = "0x1B6FD94", Offset = "0x1B6FD94", VA = "0x7BBC36FD94")]
		public static EControlMode GetVehicleControlMode()
		{
			return EControlMode.Default;
		}

		// Token: 0x06004CED RID: 19693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CED")]
		[Address(RVA = "0x1B6FE08", Offset = "0x1B6FE08", VA = "0x7BBC36FE08")]
		public static void SetVehicleControlMode(EControlMode c)
		{
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x00017340 File Offset: 0x00015540
		[Token(Token = "0x6004CEE")]
		[Address(RVA = "0x1B6FE80", Offset = "0x1B6FE80", VA = "0x7BBC36FE80")]
		public static ELeftFireSetting GetLeftFireSetting()
		{
			return ELeftFireSetting.Often;
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x00017358 File Offset: 0x00015558
		[Token(Token = "0x6004CEF")]
		[Address(RVA = "0x1B6FEF4", Offset = "0x1B6FEF4", VA = "0x7BBC36FEF4")]
		public static EChangeWeaponSetting GetChangeWeaponSetting()
		{
			return EChangeWeaponSetting.On;
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x00017370 File Offset: 0x00015570
		[Token(Token = "0x6004CF0")]
		[Address(RVA = "0x1B6FF68", Offset = "0x1B6FF68", VA = "0x7BBC36FF68")]
		public static EReloadSetting GetReloadSetting()
		{
			return EReloadSetting.On;
		}

		// Token: 0x06004CF1 RID: 19697 RVA: 0x00017388 File Offset: 0x00015588
		[Token(Token = "0x6004CF1")]
		[Address(RVA = "0x1B6FFDC", Offset = "0x1B6FFDC", VA = "0x7BBC36FFDC")]
		public static bool GetUseAuxAimSetting()
		{
			return default(bool);
		}

		// Token: 0x06004CF2 RID: 19698 RVA: 0x000173A0 File Offset: 0x000155A0
		[Token(Token = "0x6004CF2")]
		[Address(RVA = "0x1B7005C", Offset = "0x1B7005C", VA = "0x7BBC37005C")]
		public static ESafeZoneModeSetting GetSafeZoneInfoMode()
		{
			return ESafeZoneModeSetting.Center;
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF3")]
		[Address(RVA = "0x1B700D0", Offset = "0x1B700D0", VA = "0x7BBC3700D0")]
		public static void SetCurClanLevel(uint level)
		{
		}

		// Token: 0x06004CF4 RID: 19700 RVA: 0x000173B8 File Offset: 0x000155B8
		[Token(Token = "0x6004CF4")]
		[Address(RVA = "0x1B70148", Offset = "0x1B70148", VA = "0x7BBC370148")]
		public static uint GetCurClanLevel()
		{
			return 0U;
		}

		// Token: 0x06004CF5 RID: 19701 RVA: 0x000173D0 File Offset: 0x000155D0
		[Token(Token = "0x6004CF5")]
		[Address(RVA = "0x1B701BC", Offset = "0x1B701BC", VA = "0x7BBC3701BC")]
		public static EAutoSlidingSetting GetAutoSlidingSetting()
		{
			return EAutoSlidingSetting.On;
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x000173E8 File Offset: 0x000155E8
		[Token(Token = "0x6004CF6")]
		[Address(RVA = "0x1B70230", Offset = "0x1B70230", VA = "0x7BBC370230")]
		public static EAutoPickup GetAutoPickupSetting(string itemType = "AutoPickup")
		{
			return EAutoPickup.On;
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06004CF7 RID: 19703 RVA: 0x00017400 File Offset: 0x00015600
		// (set) Token: 0x06004CF8 RID: 19704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000856")]
		public static bool AutoPickSettingChanged
		{
			[Token(Token = "0x6004CF7")]
			[Address(RVA = "0x1B702A0", Offset = "0x1B702A0", VA = "0x7BBC3702A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DE28", Offset = "0x113DE28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004CF8")]
			[Address(RVA = "0x1B70308", Offset = "0x1B70308", VA = "0x7BBC370308")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DE38", Offset = "0x113DE38")]
			set
			{
			}
		}

		// Token: 0x06004CF9 RID: 19705 RVA: 0x00017418 File Offset: 0x00015618
		[Token(Token = "0x6004CF9")]
		[Address(RVA = "0x1B70378", Offset = "0x1B70378", VA = "0x7BBC370378")]
		public static int GetHudSelection()
		{
			return 0;
		}

		// Token: 0x06004CFA RID: 19706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CFA")]
		[Address(RVA = "0x1B703EC", Offset = "0x1B703EC", VA = "0x7BBC3703EC")]
		public static void SetHudSeletion(int selection)
		{
		}

		// Token: 0x06004CFB RID: 19707 RVA: 0x00017430 File Offset: 0x00015630
		[Token(Token = "0x6004CFB")]
		[Address(RVA = "0x1B70464", Offset = "0x1B70464", VA = "0x7BBC370464")]
		public static int GetHudGrenadeDirection()
		{
			return 0;
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x00017448 File Offset: 0x00015648
		[Token(Token = "0x6004CFC")]
		[Address(RVA = "0x1B70538", Offset = "0x1B70538", VA = "0x7BBC370538")]
		public static int GetHudGrenadeDirection(int selection)
		{
			return 0;
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CFD")]
		[Address(RVA = "0x1B705F0", Offset = "0x1B705F0", VA = "0x7BBC3705F0")]
		public static void SetHudGrenadeDirection(int direction)
		{
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x00017460 File Offset: 0x00015660
		[Token(Token = "0x6004CFE")]
		[Address(RVA = "0x1B6F068", Offset = "0x1B6F068", VA = "0x7BBC36F068")]
		public static bool HasHighFPSSetting()
		{
			return default(bool);
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x00017478 File Offset: 0x00015678
		[Token(Token = "0x6004CFF")]
		[Address(RVA = "0x1B6F0D8", Offset = "0x1B6F0D8", VA = "0x7BBC36F0D8")]
		public static EHighFPS GetHighFPSSetting()
		{
			return EHighFPS.On;
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D00")]
		[Address(RVA = "0x1B706D0", Offset = "0x1B706D0", VA = "0x7BBC3706D0")]
		public static void SetHighFPSSetting(EHighFPS value)
		{
		}

		// Token: 0x06004D01 RID: 19713 RVA: 0x00017490 File Offset: 0x00015690
		[Token(Token = "0x6004D01")]
		[Address(RVA = "0x1B70754", Offset = "0x1B70754", VA = "0x7BBC370754")]
		public static EShowShadow GetShadowSetting()
		{
			return EShowShadow.On;
		}

		// Token: 0x06004D02 RID: 19714 RVA: 0x000174A8 File Offset: 0x000156A8
		[Token(Token = "0x6004D02")]
		[Address(RVA = "0x1B7084C", Offset = "0x1B7084C", VA = "0x7BBC37084C")]
		public static bool GetDownloadCentreNeedShow()
		{
			return default(bool);
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D03")]
		[Address(RVA = "0x1B7092C", Offset = "0x1B7092C", VA = "0x7BBC37092C")]
		public static void SetDownloadCentreNeedShow(bool need_show)
		{
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D04")]
		[Address(RVA = "0x1B709AC", Offset = "0x1B709AC", VA = "0x7BBC3709AC")]
		public static void SetAcceptUnknowPlayerGroupInvite(bool value)
		{
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x000174C0 File Offset: 0x000156C0
		[Token(Token = "0x6004D05")]
		[Address(RVA = "0x1B70A2C", Offset = "0x1B70A2C", VA = "0x7BBC370A2C")]
		public static bool GetAcceptUnknowPlayerGroupInvite()
		{
			return default(bool);
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D06")]
		[Address(RVA = "0x1B70B0C", Offset = "0x1B70B0C", VA = "0x7BBC370B0C")]
		public static void SetAcceptReserveInvite(bool value)
		{
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x000174D8 File Offset: 0x000156D8
		[Token(Token = "0x6004D07")]
		[Address(RVA = "0x1B70B8C", Offset = "0x1B70B8C", VA = "0x7BBC370B8C")]
		public static bool GetAcceptReserveInvite()
		{
			return default(bool);
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D08")]
		[Address(RVA = "0x1B70C6C", Offset = "0x1B70C6C", VA = "0x7BBC370C6C")]
		public static void SetEnableQuickChat(bool value)
		{
		}

		// Token: 0x06004D09 RID: 19721 RVA: 0x000174F0 File Offset: 0x000156F0
		[Token(Token = "0x6004D09")]
		[Address(RVA = "0x1B70CEC", Offset = "0x1B70CEC", VA = "0x7BBC370CEC")]
		public static bool GetEnableQuickChat()
		{
			return default(bool);
		}

		// Token: 0x06004D0A RID: 19722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0A")]
		[Address(RVA = "0x1B70DC0", Offset = "0x1B70DC0", VA = "0x7BBC370DC0")]
		public static void SetEnableQuickChatSound(bool value)
		{
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x00017508 File Offset: 0x00015708
		[Token(Token = "0x6004D0B")]
		[Address(RVA = "0x1B70E40", Offset = "0x1B70E40", VA = "0x7BBC370E40")]
		public static bool GetEnableQuickChatSound()
		{
			return default(bool);
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0C")]
		[Address(RVA = "0x1B70F14", Offset = "0x1B70F14", VA = "0x7BBC370F14")]
		public static void SetAcceptGroupInvite(bool value)
		{
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x00017520 File Offset: 0x00015720
		[Token(Token = "0x6004D0D")]
		[Address(RVA = "0x1B70F94", Offset = "0x1B70F94", VA = "0x7BBC370F94")]
		public static bool GetAcceptGroupInvite()
		{
			return default(bool);
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0E")]
		[Address(RVA = "0x1B71074", Offset = "0x1B71074", VA = "0x7BBC371074")]
		public static void SetCustomRoomReplayEnabled(bool enabled)
		{
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x00017538 File Offset: 0x00015738
		[Token(Token = "0x6004D0F")]
		[Address(RVA = "0x1B710F4", Offset = "0x1B710F4", VA = "0x7BBC3710F4")]
		public static bool GetCustomRoomReplayEnabled()
		{
			return default(bool);
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D10")]
		[Address(RVA = "0x1B71174", Offset = "0x1B71174", VA = "0x7BBC371174")]
		public static void SetCustomRoomDelayOBEnabled(bool enabled)
		{
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x00017550 File Offset: 0x00015750
		[Token(Token = "0x6004D11")]
		[Address(RVA = "0x1B711F4", Offset = "0x1B711F4", VA = "0x7BBC3711F4")]
		public static bool GetCustomRoomDelayOBEnabled()
		{
			return default(bool);
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D12")]
		[Address(RVA = "0x1B71274", Offset = "0x1B71274", VA = "0x7BBC371274")]
		public static void SetCustomRoomOpeningCamEnable(bool enabled)
		{
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x00017568 File Offset: 0x00015768
		[Token(Token = "0x6004D13")]
		[Address(RVA = "0x1B712F4", Offset = "0x1B712F4", VA = "0x7BBC3712F4")]
		public static bool GetCustomRoomOpeningCamEnabled()
		{
			return default(bool);
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D14")]
		[Address(RVA = "0x1B71374", Offset = "0x1B71374", VA = "0x7BBC371374")]
		public static void SetCustomRoomMVPEnable(bool enabled)
		{
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x00017580 File Offset: 0x00015780
		[Token(Token = "0x6004D15")]
		[Address(RVA = "0x1B713F4", Offset = "0x1B713F4", VA = "0x7BBC3713F4")]
		public static bool GetCustomRoomMVPEnabled()
		{
			return default(bool);
		}

		// Token: 0x06004D16 RID: 19734 RVA: 0x00017598 File Offset: 0x00015798
		[Token(Token = "0x6004D16")]
		[Address(RVA = "0x1B71474", Offset = "0x1B71474", VA = "0x7BBC371474")]
		public static bool GetHitHintClassic()
		{
			return default(bool);
		}

		// Token: 0x06004D17 RID: 19735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D17")]
		[Address(RVA = "0x1B714F4", Offset = "0x1B714F4", VA = "0x7BBC3714F4")]
		public static void SetHitHintClassic(bool enabled)
		{
		}

		// Token: 0x06004D18 RID: 19736 RVA: 0x000175B0 File Offset: 0x000157B0
		[Token(Token = "0x6004D18")]
		[Address(RVA = "0x1B71574", Offset = "0x1B71574", VA = "0x7BBC371574")]
		public static bool GetNameClassicEnable()
		{
			return default(bool);
		}

		// Token: 0x06004D19 RID: 19737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D19")]
		[Address(RVA = "0x1B715F4", Offset = "0x1B715F4", VA = "0x7BBC3715F4")]
		public static void SetNameClassicEnable(bool enabled)
		{
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x000175C8 File Offset: 0x000157C8
		[Token(Token = "0x6004D1A")]
		[Address(RVA = "0x1B71674", Offset = "0x1B71674", VA = "0x7BBC371674")]
		public static float GetCustomRoomDelayOBSeconds()
		{
			return 0f;
		}

		// Token: 0x06004D1B RID: 19739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D1B")]
		[Address(RVA = "0x1B716E8", Offset = "0x1B716E8", VA = "0x7BBC3716E8")]
		public static void SetCustomRoomDelayOBSeconds(float value)
		{
		}

		// Token: 0x06004D1C RID: 19740 RVA: 0x000175E0 File Offset: 0x000157E0
		[Token(Token = "0x6004D1C")]
		[Address(RVA = "0x1B71768", Offset = "0x1B71768", VA = "0x7BBC371768")]
		public static bool GetCustomRoomPerspectiveType()
		{
			return default(bool);
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D1D")]
		[Address(RVA = "0x1B717C4", Offset = "0x1B717C4", VA = "0x7BBC3717C4")]
		public static void SetCustomRoomPerspectiveType(bool left)
		{
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x000175F8 File Offset: 0x000157F8
		[Token(Token = "0x6004D1E")]
		[Address(RVA = "0x1B7181C", Offset = "0x1B7181C", VA = "0x7BBC37181C")]
		public static bool GetCustomRoomPerspectiveColorType()
		{
			return default(bool);
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D1F")]
		[Address(RVA = "0x1B71878", Offset = "0x1B71878", VA = "0x7BBC371878")]
		public static void SetCustomRoomPerspectiveColorType(bool stuffed)
		{
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D20")]
		[Address(RVA = "0x1B718CC", Offset = "0x1B718CC", VA = "0x7BBC3718CC")]
		public static void SetCustomRoomPlayerSightEnabled(bool enable)
		{
		}

		// Token: 0x06004D21 RID: 19745 RVA: 0x00017610 File Offset: 0x00015810
		[Token(Token = "0x6004D21")]
		[Address(RVA = "0x1B7194C", Offset = "0x1B7194C", VA = "0x7BBC37194C")]
		public static bool GetCustomRoomPlayerSightEnabled()
		{
			return default(bool);
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D22")]
		[Address(RVA = "0x1B719CC", Offset = "0x1B719CC", VA = "0x7BBC3719CC")]
		public static string GetChatBlockList()
		{
			return null;
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D23")]
		[Address(RVA = "0x1B71A40", Offset = "0x1B71A40", VA = "0x7BBC371A40")]
		public static void SetChatBlockList(string jsonData)
		{
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x00017628 File Offset: 0x00015828
		[Token(Token = "0x6004D24")]
		[Address(RVA = "0x1B71AB8", Offset = "0x1B71AB8", VA = "0x7BBC371AB8")]
		public static float GetResolutionReduceRate()
		{
			return 0f;
		}

		// Token: 0x06004D25 RID: 19749 RVA: 0x00017640 File Offset: 0x00015840
		[Token(Token = "0x6004D25")]
		[Address(RVA = "0x1B71B78", Offset = "0x1B71B78", VA = "0x7BBC371B78")]
		public static bool GetVideoDecoderChecked()
		{
			return default(bool);
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D26")]
		[Address(RVA = "0x1B71BF8", Offset = "0x1B71BF8", VA = "0x7BBC371BF8")]
		public static void SetVideoDecoderChecked(bool check)
		{
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06004D27 RID: 19751 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004D28 RID: 19752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000857")]
		public static string LocalPlayerUserID
		{
			[Token(Token = "0x6004D27")]
			[Address(RVA = "0x1B71C78", Offset = "0x1B71C78", VA = "0x7BBC371C78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D28")]
			[Address(RVA = "0x1B71DA8", Offset = "0x1B71DA8", VA = "0x7BBC371DA8")]
			set
			{
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06004D29 RID: 19753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000858")]
		public static string LobbySettingTipsKey
		{
			[Token(Token = "0x6004D29")]
			[Address(RVA = "0x1B71E14", Offset = "0x1B71E14", VA = "0x7BBC371E14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06004D2A RID: 19754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000859")]
		public static string GraphicsSettingTabTipsKey
		{
			[Token(Token = "0x6004D2A")]
			[Address(RVA = "0x1B71F08", Offset = "0x1B71F08", VA = "0x7BBC371F08")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06004D2B RID: 19755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085A")]
		public static string FilterSettingTipsKey
		{
			[Token(Token = "0x6004D2B")]
			[Address(RVA = "0x1B71FFC", Offset = "0x1B71FFC", VA = "0x7BBC371FFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06004D2C RID: 19756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085B")]
		private static string PlayerEverLogIn
		{
			[Token(Token = "0x6004D2C")]
			[Address(RVA = "0x1B720F0", Offset = "0x1B720F0", VA = "0x7BBC3720F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x00017658 File Offset: 0x00015858
		[Token(Token = "0x6004D2D")]
		[Address(RVA = "0x1B721F8", Offset = "0x1B721F8", VA = "0x7BBC3721F8")]
		public static bool GetIsNewUser()
		{
			return default(bool);
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D2E")]
		[Address(RVA = "0x1B72274", Offset = "0x1B72274", VA = "0x7BBC372274")]
		public static void SetNewUser()
		{
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x00017670 File Offset: 0x00015870
		[Token(Token = "0x6004D2F")]
		[Address(RVA = "0x1B722E8", Offset = "0x1B722E8", VA = "0x7BBC3722E8")]
		public static bool GetEverLoggedIn()
		{
			return default(bool);
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D30")]
		[Address(RVA = "0x1B7238C", Offset = "0x1B7238C", VA = "0x7BBC37238C")]
		public static void SetEverLoggedIn()
		{
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x00017688 File Offset: 0x00015888
		[Token(Token = "0x6004D31")]
		[Address(RVA = "0x1B72424", Offset = "0x1B72424", VA = "0x7BBC372424")]
		public static bool GetFriendRecommendState()
		{
			return default(bool);
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D32")]
		[Address(RVA = "0x1B724E4", Offset = "0x1B724E4", VA = "0x7BBC3724E4")]
		public static void SetFriendRecommendState(bool state)
		{
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D33")]
		[Address(RVA = "0x1B725A0", Offset = "0x1B725A0", VA = "0x7BBC3725A0")]
		public static void SetSpectatorCameraMoveSpeed(float b)
		{
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x000176A0 File Offset: 0x000158A0
		[Token(Token = "0x6004D34")]
		[Address(RVA = "0x1B725A4", Offset = "0x1B725A4", VA = "0x7BBC3725A4")]
		public static float GetSpectatorCameraMoveSpeed()
		{
			return 0f;
		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x000176B8 File Offset: 0x000158B8
		[Token(Token = "0x6004D35")]
		[Address(RVA = "0x1B725AC", Offset = "0x1B725AC", VA = "0x7BBC3725AC")]
		public static bool IsUnloadEmbeddedSceneObjects()
		{
			return default(bool);
		}

		// Token: 0x04007448 RID: 29768
		[Token(Token = "0x4007448")]
		public const string LoclizationSettingKey = "Localization";

		// Token: 0x04007449 RID: 29769
		[Token(Token = "0x4007449")]
		public const string SensitivitySettingKey = "Sensitivity";

		// Token: 0x0400744A RID: 29770
		[Token(Token = "0x400744A")]
		public const string AuxAimSensitivitySettingKey = "AuxAimSensitivity";

		// Token: 0x0400744B RID: 29771
		[Token(Token = "0x400744B")]
		public const string SpHudPlayerInfoIsBasicSettingKey = "SpHudPlayerInfoIsBasic";

		// Token: 0x0400744C RID: 29772
		[Token(Token = "0x400744C")]
		public const string MusicSettingKey = "Music";

		// Token: 0x0400744D RID: 29773
		[Token(Token = "0x400744D")]
		public const string SoundEffectSettingKey = "SoundEffect";

		// Token: 0x0400744E RID: 29774
		[Token(Token = "0x400744E")]
		public const string GameVoiceSettingKey = "GameVoice";

		// Token: 0x0400744F RID: 29775
		[Token(Token = "0x400744F")]
		public const string MinimapSettingKey = "MiniMap";

		// Token: 0x04007450 RID: 29776
		[Token(Token = "0x4007450")]
		public const string MinimapScaleAssistKey = "MiniMapScaleAssist";

		// Token: 0x04007451 RID: 29777
		[Token(Token = "0x4007451")]
		public const string QualitySettingKey = "Quality";

		// Token: 0x04007452 RID: 29778
		[Token(Token = "0x4007452")]
		public const string QualitySettingRecommendKey = "QualityRecommend";

		// Token: 0x04007453 RID: 29779
		[Token(Token = "0x4007453")]
		public const string ScopeSensitivitySettingKeyPrefix = "ScopeSensitivity_";

		// Token: 0x04007454 RID: 29780
		[Token(Token = "0x4007454")]
		public const string AimAssistKey = "AimAssist";

		// Token: 0x04007455 RID: 29781
		[Token(Token = "0x4007455")]
		public const string OpenScopeOperateKey = "OpenScopeOperate";

		// Token: 0x04007456 RID: 29782
		[Token(Token = "0x4007456")]
		public const string LeftFireKey = "LeftFire";

		// Token: 0x04007457 RID: 29783
		[Token(Token = "0x4007457")]
		public const string ChangeWeaponKey = "ChangeWeapon";

		// Token: 0x04007458 RID: 29784
		[Token(Token = "0x4007458")]
		public const string ReloadKey = "Reload";

		// Token: 0x04007459 RID: 29785
		[Token(Token = "0x4007459")]
		public const string UseAuxAimKey = "UseAuxAimNew";

		// Token: 0x0400745A RID: 29786
		[Token(Token = "0x400745A")]
		public const string SafeZoneInfoModeKey = "IngameTipsMode";

		// Token: 0x0400745B RID: 29787
		[Token(Token = "0x400745B")]
		public const string BrightnessSettingKey = "BrightnessSetting";

		// Token: 0x0400745C RID: 29788
		[Token(Token = "0x400745C")]
		public const string CurClanLevel = "CurClanLevel";

		// Token: 0x0400745D RID: 29789
		[Token(Token = "0x400745D")]
		public const string AutoSlidingKey = "AutoSliding";

		// Token: 0x0400745E RID: 29790
		[Token(Token = "0x400745E")]
		public const string AutoPickUpKey = "AutoPickup";

		// Token: 0x0400745F RID: 29791
		[Token(Token = "0x400745F")]
		public const string NotchScreenKey = "NotchScreen";

		// Token: 0x04007460 RID: 29792
		[Token(Token = "0x4007460")]
		public const string VehicleControlModeKey = "VehicleControlMode";

		// Token: 0x04007461 RID: 29793
		[Token(Token = "0x4007461")]
		public const string HighFPSKey = "HighFPS";

		// Token: 0x04007462 RID: 29794
		[Token(Token = "0x4007462")]
		public const string ShowShadowKey = "ShowShadow";

		// Token: 0x04007463 RID: 29795
		[Token(Token = "0x4007463")]
		public const string AcceptUnknowPlayerGroupInviteKey = "AcceptUnknowPlayerGroupInvite";

		// Token: 0x04007464 RID: 29796
		[Token(Token = "0x4007464")]
		public const string AcceptReserveInviteKey = "AcceptReserveInvite";

		// Token: 0x04007465 RID: 29797
		[Token(Token = "0x4007465")]
		public const string AcceptGroupInviteKey = "AcceptGroupInviteKey";

		// Token: 0x04007466 RID: 29798
		[Token(Token = "0x4007466")]
		public const string AutoFireKey = "AutoFire";

		// Token: 0x04007467 RID: 29799
		[Token(Token = "0x4007467")]
		public const string AutoSwitchKey = "AutoSwitch";

		// Token: 0x04007468 RID: 29800
		[Token(Token = "0x4007468")]
		public const string HitHint = "HitHint";

		// Token: 0x04007469 RID: 29801
		[Token(Token = "0x4007469")]
		public const string NameClassicEnable = "NameClassicEnable";

		// Token: 0x0400746A RID: 29802
		[Token(Token = "0x400746A")]
		public const string NeedMaxSettingGuide = "NeedMaxSettingGuide";

		// Token: 0x0400746B RID: 29803
		[Token(Token = "0x400746B")]
		public const string HUDGrenadeDirection = "HUDGrenadeDirection";

		// Token: 0x0400746C RID: 29804
		[Token(Token = "0x400746C")]
		public const string HUDSelection = "ConfigSelected";

		// Token: 0x0400746D RID: 29805
		[Token(Token = "0x400746D")]
		public const string NewUser = "NewUser";

		// Token: 0x0400746E RID: 29806
		[Token(Token = "0x400746E")]
		public const string EnableQuickChat = "EnableQuickChat";

		// Token: 0x0400746F RID: 29807
		[Token(Token = "0x400746F")]
		public const string EnableQuickChatSound = "EnableQuickChatSound";

		// Token: 0x04007470 RID: 29808
		[Token(Token = "0x4007470")]
		public const string DownloadCentreShowKey = "ShowDownloadCentre";

		// Token: 0x04007471 RID: 29809
		[Token(Token = "0x4007471")]
		public const string ChatBlockListKey = "ChatBlockList";

		// Token: 0x04007472 RID: 29810
		[Token(Token = "0x4007472")]
		public const string MaxLobbyOpenKey = "MaxLobbyOpen";

		// Token: 0x04007473 RID: 29811
		[Token(Token = "0x4007473")]
		public const string SpectatorCamerMoveSpeedKey = "SpectatorCamerMoveSpeed";

		// Token: 0x04007474 RID: 29812
		[Token(Token = "0x4007474")]
		public const string ReduceResolutionKey = "ReduceResolution";

		// Token: 0x04007475 RID: 29813
		[Token(Token = "0x4007475")]
		public const string RegisteredOnThisDevice = "RegisteredOnThisDevice";

		// Token: 0x04007476 RID: 29814
		[Token(Token = "0x4007476")]
		public const string RecommendFriends = "RecommendFriends_";

		// Token: 0x04007477 RID: 29815
		[Token(Token = "0x4007477")]
		public const string KEY_CUSTOMROOM_RECORD_REPLAY_ENABLED = "KEY_CUSTOMROOM_RECORD_REPLAY_ENABLED";

		// Token: 0x04007478 RID: 29816
		[Token(Token = "0x4007478")]
		public const string KEY_CUSTOMROOM_RECORD_DELAY_OB_ENABLED = "KEY_CUSTOMROOM_RECORD_DELAY_OB_ENABLED";

		// Token: 0x04007479 RID: 29817
		[Token(Token = "0x4007479")]
		public const string KEY_CUSTOMROOM_DELAY_OB_SECONDS = "KEY_CUSTOMROOM_DELAY_OB_SECONDS";

		// Token: 0x0400747A RID: 29818
		[Token(Token = "0x400747A")]
		public const string KEY_CUSTOMROOM_PERSPECTIVE_TYPE = "KEY_CUSTOMROOM_PERSPECTIVE_TYPE";

		// Token: 0x0400747B RID: 29819
		[Token(Token = "0x400747B")]
		public const string KEY_CUSTOMROOM_PERSPECTIVE_COLOR_TYPE = "KEY_CUSTOMROOM_PERSPECTIVE_COLOR_TYPE";

		// Token: 0x0400747C RID: 29820
		[Token(Token = "0x400747C")]
		public const string KEY_CUSTOMROOM_FIRE_SOUND = "KEY_CUSTOMROOM_FIRE_SOUND";

		// Token: 0x0400747D RID: 29821
		[Token(Token = "0x400747D")]
		public const string KEY_CUSTOMROOM_ACHIEVEMENT_SOUND = "KEY_CUSTOMROOM_ACHIEVEMENT_SOUND";

		// Token: 0x0400747E RID: 29822
		[Token(Token = "0x400747E")]
		public const string KEY_CUSTOMROOM_PLAYERSIGHT_ENABLED = "KEY_CUSTOMROOM_PLAYERSIGHT_ENABLED_TEMP";

		// Token: 0x0400747F RID: 29823
		[Token(Token = "0x400747F")]
		public const string KEY_CUSTOMROOM_OPENINGCAM_ENABLED = "KEY_CUSTOMROOM_OPENINGCAM_ENABLED";

		// Token: 0x04007480 RID: 29824
		[Token(Token = "0x4007480")]
		public const string KEY_CUSTOMROOM_SPMVP_ENABLED = "SPMVP";

		// Token: 0x04007481 RID: 29825
		[Token(Token = "0x4007481")]
		public const string KEY_MAXSETTING_VIDEODECODER_CHECKED = "KEY_MAXSETTING_VIDEODECODER_CHECKED";

		// Token: 0x04007482 RID: 29826
		[Token(Token = "0x4007482")]
		public const string UseHDAnimation = "UseHDAnimation";

		// Token: 0x04007483 RID: 29827
		[Token(Token = "0x4007483")]
		public const string HDWeaponEffect = "HDWeaponEffect";

		// Token: 0x04007484 RID: 29828
		[Token(Token = "0x4007484")]
		public const string HDTexture = "HDTexture";

		// Token: 0x04007485 RID: 29829
		[Token(Token = "0x4007485")]
		public const string HDVehicleVFX = "HDVehicleVFX";

		// Token: 0x04007486 RID: 29830
		[Token(Token = "0x4007486")]
		public const string AudioEngineTypeKey = "AudioEngineType";

		// Token: 0x04007487 RID: 29831
		[Token(Token = "0x4007487")]
		public const string KEY_MAXSETTING_LOGINViDEO_ENABLED = "KEY_MAXSETTING_LOGINViDEO_ENABLED";

		// Token: 0x04007488 RID: 29832
		[Token(Token = "0x4007488")]
		public const float MAX_SENSITIVITY = 1f;

		// Token: 0x04007489 RID: 29833
		[Token(Token = "0x4007489")]
		public const float MAX_MUSICVOLUME = 1f;

		// Token: 0x0400748A RID: 29834
		[Token(Token = "0x400748A")]
		public const float MAX_SOUNDEFFECTVOLUME = 1f;

		// Token: 0x0400748B RID: 29835
		[Token(Token = "0x400748B")]
		public const float MAX_GAMEVOICEVVOLUME = 1f;

		// Token: 0x0400748C RID: 29836
		[Token(Token = "0x400748C")]
		public const float DEFAULT_1xSCOPE_SENSE = 0.8f;

		// Token: 0x0400748D RID: 29837
		[Token(Token = "0x400748D")]
		public const float DEFAULT_2xSCOPE_SENSE = 0.7f;

		// Token: 0x0400748E RID: 29838
		[Token(Token = "0x400748E")]
		public const float DEFAULT_4xSCOPE_SENSE = 0.6f;

		// Token: 0x0400748F RID: 29839
		[Token(Token = "0x400748F")]
		public const float DEFAULT_8xSCOPE_SENSE = 0.5f;

		// Token: 0x04007490 RID: 29840
		[Token(Token = "0x4007490")]
		public const int HUDGRENADETOP = 0;

		// Token: 0x04007491 RID: 29841
		[Token(Token = "0x4007491")]
		public const int HUDGRENADEBOTTOM = 1;

		// Token: 0x04007492 RID: 29842
		[Token(Token = "0x4007492")]
		public const int HUDGRENADELEFT = 2;

		// Token: 0x04007493 RID: 29843
		[Token(Token = "0x4007493")]
		public const int HUDGRENADERIGHT = 3;

		// Token: 0x04007494 RID: 29844
		[Token(Token = "0x4007494")]
		[FieldOffset(Offset = "0x0")]
		private static bool? m_AutoFire;

		// Token: 0x04007495 RID: 29845
		[Token(Token = "0x4007495")]
		[FieldOffset(Offset = "0x4")]
		private static GGfm}Dt m_cacheQuality;

		// Token: 0x04007496 RID: 29846
		[Token(Token = "0x4007496")]
		[FieldOffset(Offset = "0x8")]
		private static float m_SensitivitySetting;

		// Token: 0x04007497 RID: 29847
		[Token(Token = "0x4007497")]
		[FieldOffset(Offset = "0xC")]
		private static float m_AuxAimSensitivity;

		// Token: 0x04007498 RID: 29848
		[Token(Token = "0x4007498")]
		[FieldOffset(Offset = "0x10")]
		private static int m_CurrentMaxLobbyType;

		// Token: 0x04007499 RID: 29849
		[Token(Token = "0x4007499")]
		public const int HD_COMMONLOBBY = 0;

		// Token: 0x0400749A RID: 29850
		[Token(Token = "0x400749A")]
		public const int HD_WALKLOBBY = 5;

		// Token: 0x0400749B RID: 29851
		[Token(Token = "0x400749B")]
		public const int HD_STANDLOBBY = 10;

		// Token: 0x0400749C RID: 29852
		[Token(Token = "0x400749C")]
		[FieldOffset(Offset = "0x14")]
		private static bool m_HasReadShowMaxLobbyState;

		// Token: 0x0400749D RID: 29853
		[Token(Token = "0x400749D")]
		[FieldOffset(Offset = "0x15")]
		private static bool? m_IsUsingSpHudCsplayerInfo;

		// Token: 0x0400749E RID: 29854
		[Token(Token = "0x400749E")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<string, object> m_OriginalSettingDictionary;

		// Token: 0x0400749F RID: 29855
		[Token(Token = "0x400749F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F6FC", Offset = "0x112F6FC")]
		private static bool <AutoPickSettingChanged>k__BackingField;

		// Token: 0x040074A0 RID: 29856
		[Token(Token = "0x40074A0")]
		[FieldOffset(Offset = "0x28")]
		private static StringBuilder m_StringBuilder;

		// Token: 0x040074A1 RID: 29857
		[Token(Token = "0x40074A1")]
		[FieldOffset(Offset = "0x30")]
		private static string m_LocalPlayerUserID;

		// Token: 0x040074A2 RID: 29858
		[Token(Token = "0x40074A2")]
		[FieldOffset(Offset = "0x38")]
		private static string m_LobbySettingTipsKey;

		// Token: 0x040074A3 RID: 29859
		[Token(Token = "0x40074A3")]
		[FieldOffset(Offset = "0x40")]
		private static string m_GraphicsSettingTipsKey;

		// Token: 0x040074A4 RID: 29860
		[Token(Token = "0x40074A4")]
		[FieldOffset(Offset = "0x48")]
		private static string m_FilterSettingTipsKey;
	}
}
