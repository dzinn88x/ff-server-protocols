using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A23 RID: 6691
	[Token(Token = "0x2001A23")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7994", Offset = "0x10F7994")]
	public class UILoginController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008C29 RID: 35881 RVA: 0x000256F8 File Offset: 0x000238F8
		[Token(Token = "0x6008C29")]
		[Address(RVA = "0x19E0318", Offset = "0x19E0318", VA = "0x7BBC1E0318")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008C2A RID: 35882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C2A")]
		[Address(RVA = "0x19E0368", Offset = "0x19E0368", VA = "0x7BBC1E0368")]
		private void InitLoginButtons()
		{
		}

		// Token: 0x06008C2B RID: 35883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C2B")]
		[Address(RVA = "0x19E0E8C", Offset = "0x19E0E8C", VA = "0x7BBC1E0E8C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008C2C RID: 35884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C2C")]
		[Address(RVA = "0x19E2704", Offset = "0x19E2704", VA = "0x7BBC1E2704")]
		private void InitPPTOP()
		{
		}

		// Token: 0x06008C2D RID: 35885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C2D")]
		[Address(RVA = "0x19E2A64", Offset = "0x19E2A64", VA = "0x7BBC1E2A64")]
		private void ChangeTOSState(object[] data)
		{
		}

		// Token: 0x06008C2E RID: 35886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C2E")]
		[Address(RVA = "0x19E1B94", Offset = "0x19E1B94", VA = "0x7BBC1E1B94")]
		private void InitTOS()
		{
		}

		// Token: 0x06008C2F RID: 35887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C2F")]
		[Address(RVA = "0x19E2AAC", Offset = "0x19E2AAC", VA = "0x7BBC1E2AAC")]
		private void UpdateBtnBoxCollider(UIButton button, Vector2 newSize, Vector2 newPos)
		{
		}

		// Token: 0x06008C30 RID: 35888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C30")]
		[Address(RVA = "0x19E2BF4", Offset = "0x19E2BF4", VA = "0x7BBC1E2BF4")]
		private void OnToggleTOSChange()
		{
		}

		// Token: 0x06008C31 RID: 35889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C31")]
		[Address(RVA = "0x19E2F58", Offset = "0x19E2F58", VA = "0x7BBC1E2F58")]
		private void OnBtnServiceClick()
		{
		}

		// Token: 0x06008C32 RID: 35890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C32")]
		[Address(RVA = "0x19E2FD8", Offset = "0x19E2FD8", VA = "0x7BBC1E2FD8")]
		private void OnBtnPrivacyClick()
		{
		}

		// Token: 0x06008C33 RID: 35891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C33")]
		[Address(RVA = "0x19E2434", Offset = "0x19E2434", VA = "0x7BBC1E2434")]
		private void InitAgeCheck()
		{
		}

		// Token: 0x06008C34 RID: 35892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C34")]
		[Address(RVA = "0x19E2090", Offset = "0x19E2090", VA = "0x7BBC1E2090")]
		private void RestorePlatformLogin()
		{
		}

		// Token: 0x06008C35 RID: 35893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C35")]
		[Address(RVA = "0x19E3058", Offset = "0x19E3058", VA = "0x7BBC1E3058")]
		private void AutoLogin(PlatformType platformType)
		{
		}

		// Token: 0x06008C36 RID: 35894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C36")]
		[Address(RVA = "0x19E34E8", Offset = "0x19E34E8", VA = "0x7BBC1E34E8")]
		private void ManualLogin(PlatformType platformType)
		{
		}

		// Token: 0x06008C37 RID: 35895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C37")]
		[Address(RVA = "0x19E37BC", Offset = "0x19E37BC", VA = "0x7BBC1E37BC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008C38 RID: 35896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C38")]
		[Address(RVA = "0x19E3B40", Offset = "0x19E3B40", VA = "0x7BBC1E3B40")]
		private void OnServerChanged()
		{
		}

		// Token: 0x06008C39 RID: 35897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C39")]
		[Address(RVA = "0x19E3C6C", Offset = "0x19E3C6C", VA = "0x7BBC1E3C6C")]
		private void OnBtnRegisterClick(object[] data)
		{
		}

		// Token: 0x06008C3A RID: 35898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C3A")]
		[Address(RVA = "0x19E3DAC", Offset = "0x19E3DAC", VA = "0x7BBC1E3DAC")]
		private void OnBtnGuestLogin()
		{
		}

		// Token: 0x06008C3B RID: 35899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C3B")]
		[Address(RVA = "0x19E3F44", Offset = "0x19E3F44", VA = "0x7BBC1E3F44")]
		private void OnBtnLoginVKClick()
		{
		}

		// Token: 0x06008C3C RID: 35900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C3C")]
		[Address(RVA = "0x19E3F4C", Offset = "0x19E3F4C", VA = "0x7BBC1E3F4C")]
		private void OnBtnFacebookClick()
		{
		}

		// Token: 0x06008C3D RID: 35901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C3D")]
		[Address(RVA = "0x19E3F54", Offset = "0x19E3F54", VA = "0x7BBC1E3F54")]
		private void OnBtnTwitterClick()
		{
		}

		// Token: 0x06008C3E RID: 35902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C3E")]
		[Address(RVA = "0x19E3F5C", Offset = "0x19E3F5C", VA = "0x7BBC1E3F5C")]
		private void OnBtnAppleClick()
		{
		}

		// Token: 0x06008C3F RID: 35903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C3F")]
		[Address(RVA = "0x19E3F64", Offset = "0x19E3F64", VA = "0x7BBC1E3F64")]
		private void OnBtnHuaweiClick()
		{
		}

		// Token: 0x06008C40 RID: 35904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C40")]
		[Address(RVA = "0x19E3FD0", Offset = "0x19E3FD0", VA = "0x7BBC1E3FD0")]
		private void OnBtnVKClick()
		{
		}

		// Token: 0x06008C41 RID: 35905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C41")]
		[Address(RVA = "0x19E3FD8", Offset = "0x19E3FD8", VA = "0x7BBC1E3FD8")]
		private void OnBtnGoogleClick()
		{
		}

		// Token: 0x06008C42 RID: 35906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C42")]
		[Address(RVA = "0x19E3FE0", Offset = "0x19E3FE0", VA = "0x7BBC1E3FE0")]
		private void OnMoreChannelClick()
		{
		}

		// Token: 0x06008C43 RID: 35907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C43")]
		[Address(RVA = "0x19E4538", Offset = "0x19E4538", VA = "0x7BBC1E4538")]
		private void GotoLobby()
		{
		}

		// Token: 0x06008C44 RID: 35908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C44")]
		[Address(RVA = "0x19E468C", Offset = "0x19E468C", VA = "0x7BBC1E468C", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008C45 RID: 35909 RVA: 0x00025710 File Offset: 0x00023910
		[Token(Token = "0x6008C45")]
		[Address(RVA = "0x19E5274", Offset = "0x19E5274", VA = "0x7BBC1E5274", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008C46 RID: 35910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C46")]
		[Address(RVA = "0x19E18D0", Offset = "0x19E18D0", VA = "0x7BBC1E18D0")]
		private void SelectDefaultServer()
		{
		}

		// Token: 0x06008C47 RID: 35911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C47")]
		[Address(RVA = "0x19E52B8", Offset = "0x19E52B8", VA = "0x7BBC1E52B8")]
		private void OnBtnStartGameClick()
		{
		}

		// Token: 0x06008C48 RID: 35912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C48")]
		[Address(RVA = "0x19E5348", Offset = "0x19E5348", VA = "0x7BBC1E5348")]
		private void ProcessStartGame()
		{
		}

		// Token: 0x06008C49 RID: 35913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C49")]
		[Address(RVA = "0x19E5170", Offset = "0x19E5170", VA = "0x7BBC1E5170")]
		private void OnLogoutBtnClick()
		{
		}

		// Token: 0x06008C4A RID: 35914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C4A")]
		[Address(RVA = "0x19E5524", Offset = "0x19E5524", VA = "0x7BBC1E5524")]
		private void OnConfirmChangeServer(params object[] data)
		{
		}

		// Token: 0x06008C4B RID: 35915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C4B")]
		[Address(RVA = "0x19E5710", Offset = "0x19E5710", VA = "0x7BBC1E5710")]
		private void UpdateLoginButtons()
		{
		}

		// Token: 0x06008C4C RID: 35916 RVA: 0x00025728 File Offset: 0x00023928
		[Token(Token = "0x6008C4C")]
		[Address(RVA = "0x19E5E6C", Offset = "0x19E5E6C", VA = "0x7BBC1E5E6C")]
		private bool CheckToggleEnable()
		{
			return default(bool);
		}

		// Token: 0x06008C4D RID: 35917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C4D")]
		[Address(RVA = "0x19E1A98", Offset = "0x19E1A98", VA = "0x7BBC1E1A98")]
		private void Refresh()
		{
		}

		// Token: 0x06008C4E RID: 35918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C4E")]
		[Address(RVA = "0x19E5F48", Offset = "0x19E5F48", VA = "0x7BBC1E5F48")]
		private void RefreshCachedPlayerInfo()
		{
		}

		// Token: 0x06008C4F RID: 35919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C4F")]
		[Address(RVA = "0x19E6248", Offset = "0x19E6248", VA = "0x7BBC1E6248")]
		private void RefreshLoginRegion()
		{
		}

		// Token: 0x06008C50 RID: 35920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C50")]
		[Address(RVA = "0x19E29D4", Offset = "0x19E29D4", VA = "0x7BBC1E29D4")]
		private void RefreshServerInfo(object[] data)
		{
		}

		// Token: 0x06008C51 RID: 35921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008C51")]
		[Address(RVA = "0x19E3E90", Offset = "0x19E3E90", VA = "0x7BBC1E3E90")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1144294", Offset = "0x1144294")]
		private IEnumerator SetButtonCoolDown(UIButton btn, float delayTime)
		{
			return null;
		}

		// Token: 0x06008C52 RID: 35922 RVA: 0x00025740 File Offset: 0x00023940
		[Token(Token = "0x6008C52")]
		[Address(RVA = "0x19E3114", Offset = "0x19E3114", VA = "0x7BBC1E3114")]
		private bool CheckIfPolicyPopupNeeded(Action callback1, Action<PlatformType> callback2, PlatformType type)
		{
			return default(bool);
		}

		// Token: 0x06008C53 RID: 35923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C53")]
		[Address(RVA = "0x19E69D8", Offset = "0x19E69D8", VA = "0x7BBC1E69D8")]
		private void OnEventCloseLogin(object[] data)
		{
		}

		// Token: 0x06008C54 RID: 35924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C54")]
		[Address(RVA = "0x19E69E0", Offset = "0x19E69E0", VA = "0x7BBC1E69E0")]
		private void OnEventBGSwithc(object[] data)
		{
		}

		// Token: 0x06008C55 RID: 35925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C55")]
		[Address(RVA = "0x19E22F0", Offset = "0x19E22F0", VA = "0x7BBC1E22F0")]
		private void ShowMaintenanceMessage(string content)
		{
		}

		// Token: 0x06008C56 RID: 35926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C56")]
		[Address(RVA = "0x19E6EB4", Offset = "0x19E6EB4", VA = "0x7BBC1E6EB4")]
		private void OnDebugClick()
		{
		}

		// Token: 0x06008C57 RID: 35927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C57")]
		[Address(RVA = "0x19E25DC", Offset = "0x19E25DC", VA = "0x7BBC1E25DC")]
		private void InitBG()
		{
		}

		// Token: 0x06008C58 RID: 35928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C58")]
		[Address(RVA = "0x19E6AB8", Offset = "0x19E6AB8", VA = "0x7BBC1E6AB8")]
		public void ShowSpineBG(ResourceID spineBGResID)
		{
		}

		// Token: 0x06008C59 RID: 35929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C59")]
		[Address(RVA = "0x19E6EB8", Offset = "0x19E6EB8", VA = "0x7BBC1E6EB8")]
		private void OnVNLinkClick()
		{
		}

		// Token: 0x06008C5A RID: 35930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C5A")]
		[Address(RVA = "0x19E6654", Offset = "0x19E6654", VA = "0x7BBC1E6654")]
		private void RefreshVNLink()
		{
		}

		// Token: 0x06008C5B RID: 35931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C5B")]
		[Address(RVA = "0x19E7058", Offset = "0x19E7058", VA = "0x7BBC1E7058")]
		public UILoginController()
		{
		}

		// Token: 0x040098CF RID: 39119
		[Token(Token = "0x40098CF")]
		public const string ACCOUNTREGION = "ACCOUNTREGION_{0}";

		// Token: 0x040098D0 RID: 39120
		[Token(Token = "0x40098D0")]
		public const string VNLINKLOG = "LOGINPAGEVNLINKLOG_{0}";

		// Token: 0x040098D1 RID: 39121
		[Token(Token = "0x40098D1")]
		private const uint VNLinkSee = 1U;

		// Token: 0x040098D2 RID: 39122
		[Token(Token = "0x40098D2")]
		private const uint VNLinkClick = 2U;

		// Token: 0x040098D3 RID: 39123
		[Token(Token = "0x40098D3")]
		[FieldOffset(Offset = "0x58")]
		private UILoginView m_View;

		// Token: 0x040098D4 RID: 39124
		[Token(Token = "0x40098D4")]
		[FieldOffset(Offset = "0x60")]
		private UIVersionController m_UIVersion;

		// Token: 0x040098D5 RID: 39125
		[Token(Token = "0x40098D5")]
		[FieldOffset(Offset = "0x68")]
		private bool m_platfromLogined;

		// Token: 0x040098D6 RID: 39126
		[Token(Token = "0x40098D6")]
		[FieldOffset(Offset = "0x70")]
		private UIPopupMessageBoxController m_MaintenanceMessageCtrl;

		// Token: 0x040098D7 RID: 39127
		[Token(Token = "0x40098D7")]
		[FieldOffset(Offset = "0x78")]
		private uint limitedAge;

		// Token: 0x040098D8 RID: 39128
		[Token(Token = "0x40098D8")]
		[FieldOffset(Offset = "0x7C")]
		private ResourceID m_LoginBGSpine1;

		// Token: 0x040098D9 RID: 39129
		[Token(Token = "0x40098D9")]
		[FieldOffset(Offset = "0x80")]
		private ResourceID m_LoginBGSpine2;

		// Token: 0x040098DA RID: 39130
		[Token(Token = "0x40098DA")]
		[FieldOffset(Offset = "0x84")]
		private ResourceID m_LoginBGSpineTrial;

		// Token: 0x040098DB RID: 39131
		[Token(Token = "0x40098DB")]
		[FieldOffset(Offset = "0x88")]
		private GameObject m_SpineBG;

		// Token: 0x040098DC RID: 39132
		[Token(Token = "0x40098DC")]
		[FieldOffset(Offset = "0x90")]
		private ResourceID m_CurrentSpineBGResID;

		// Token: 0x02001A24 RID: 6692
		[Token(Token = "0x2001A24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F79CC", Offset = "0x10F79CC")]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x06008C5C RID: 35932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008C5C")]
			[Address(RVA = "0x19E37B4", Offset = "0x19E37B4", VA = "0x7BBC1E37B4")]
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x06008C5D RID: 35933 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008C5D")]
			[Address(RVA = "0x19E71DC", Offset = "0x19E71DC", VA = "0x7BBC1E71DC")]
			internal void <ManualLogin>b__0()
			{
			}

			// Token: 0x040098DD RID: 39133
			[Token(Token = "0x40098DD")]
			[FieldOffset(Offset = "0x10")]
			public PlatformType platformType;
		}

		// Token: 0x02001A25 RID: 6693
		[Token(Token = "0x2001A25")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F79DC", Offset = "0x10F79DC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008C5F RID: 35935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008C5F")]
			[Address(RVA = "0x19E7134", Offset = "0x19E7134", VA = "0x7BBC1E7134")]
			public <>c()
			{
			}

			// Token: 0x06008C60 RID: 35936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008C60")]
			[Address(RVA = "0x19E713C", Offset = "0x19E713C", VA = "0x7BBC1E713C")]
			internal void <ProcessStartGame>b__45_0()
			{
			}

			// Token: 0x040098DE RID: 39134
			[Token(Token = "0x40098DE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UILoginController.<>c <>9;

			// Token: 0x040098DF RID: 39135
			[Token(Token = "0x40098DF")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__45_0;
		}

		// Token: 0x02001A26 RID: 6694
		[Token(Token = "0x2001A26")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F79EC", Offset = "0x10F79EC")]
		private sealed class <SetButtonCoolDown>d__54 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008C61 RID: 35937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008C61")]
			[Address(RVA = "0x19E69A4", Offset = "0x19E69A4", VA = "0x7BBC1E69A4")]
			[DebuggerHidden]
			public <SetButtonCoolDown>d__54(int <>1__state)
			{
			}

			// Token: 0x06008C62 RID: 35938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008C62")]
			[Address(RVA = "0x19E7394", Offset = "0x19E7394", VA = "0x7BBC1E7394", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008C63 RID: 35939 RVA: 0x00025758 File Offset: 0x00023958
			[Token(Token = "0x6008C63")]
			[Address(RVA = "0x19E7398", Offset = "0x19E7398", VA = "0x7BBC1E7398", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009DB RID: 2523
			// (get) Token: 0x06008C64 RID: 35940 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009DB")]
			private object Current
			{
				[Token(Token = "0x6008C64")]
				[Address(RVA = "0x19E7470", Offset = "0x19E7470", VA = "0x7BBC1E7470", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008C65 RID: 35941 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008C65")]
			[Address(RVA = "0x19E7478", Offset = "0x19E7478", VA = "0x7BBC1E7478", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009DC RID: 2524
			// (get) Token: 0x06008C66 RID: 35942 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009DC")]
			private object Current
			{
				[Token(Token = "0x6008C66")]
				[Address(RVA = "0x19E74E0", Offset = "0x19E74E0", VA = "0x7BBC1E74E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040098E0 RID: 39136
			[Token(Token = "0x40098E0")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040098E1 RID: 39137
			[Token(Token = "0x40098E1")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040098E2 RID: 39138
			[Token(Token = "0x40098E2")]
			[FieldOffset(Offset = "0x20")]
			public float delayTime;

			// Token: 0x040098E3 RID: 39139
			[Token(Token = "0x40098E3")]
			[FieldOffset(Offset = "0x28")]
			public UILoginController <>4__this;

			// Token: 0x040098E4 RID: 39140
			[Token(Token = "0x40098E4")]
			[FieldOffset(Offset = "0x30")]
			public UIButton btn;
		}

		// Token: 0x02001A27 RID: 6695
		[Token(Token = "0x2001A27")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F79FC", Offset = "0x10F79FC")]
		private sealed class <>c__DisplayClass55_0
		{
			// Token: 0x06008C67 RID: 35943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008C67")]
			[Address(RVA = "0x19E69D0", Offset = "0x19E69D0", VA = "0x7BBC1E69D0")]
			public <>c__DisplayClass55_0()
			{
			}

			// Token: 0x06008C68 RID: 35944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008C68")]
			[Address(RVA = "0x19E728C", Offset = "0x19E728C", VA = "0x7BBC1E728C")]
			internal void <CheckIfPolicyPopupNeeded>b__0()
			{
			}

			// Token: 0x040098E5 RID: 39141
			[Token(Token = "0x40098E5")]
			[FieldOffset(Offset = "0x10")]
			public Action callback1;

			// Token: 0x040098E6 RID: 39142
			[Token(Token = "0x40098E6")]
			[FieldOffset(Offset = "0x18")]
			public Action<PlatformType> callback2;

			// Token: 0x040098E7 RID: 39143
			[Token(Token = "0x40098E7")]
			[FieldOffset(Offset = "0x20")]
			public PlatformType type;
		}
	}
}
