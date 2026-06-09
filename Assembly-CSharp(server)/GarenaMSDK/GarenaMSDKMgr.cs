using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GarenaMSDK
{
	// Token: 0x02002BC4 RID: 11204
	[Token(Token = "0x2002BC4")]
	public class GarenaMSDKMgr : MonoBehaviour
	{
		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x0600F80B RID: 63499 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F80C RID: 63500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700120A")]
		public string GuestOpenID
		{
			[Token(Token = "0x600F80B")]
			[Address(RVA = "0x224DC90", Offset = "0x224DC90", VA = "0x7BBCA4DC90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BB28", Offset = "0x114BB28")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F80C")]
			[Address(RVA = "0x224DC98", Offset = "0x224DC98", VA = "0x7BBCA4DC98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BB38", Offset = "0x114BB38")]
			set
			{
			}
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x0600F80D RID: 63501 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F80E RID: 63502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700120B")]
		public string GuestAccessToken
		{
			[Token(Token = "0x600F80D")]
			[Address(RVA = "0x224DCA0", Offset = "0x224DCA0", VA = "0x7BBCA4DCA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BB48", Offset = "0x114BB48")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F80E")]
			[Address(RVA = "0x224DCA8", Offset = "0x224DCA8", VA = "0x7BBCA4DCA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BB58", Offset = "0x114BB58")]
			set
			{
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x0600F80F RID: 63503 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F810 RID: 63504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700120C")]
		public string OpenID
		{
			[Token(Token = "0x600F80F")]
			[Address(RVA = "0x224DCB0", Offset = "0x224DCB0", VA = "0x7BBCA4DCB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BB68", Offset = "0x114BB68")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F810")]
			[Address(RVA = "0x224DCB8", Offset = "0x224DCB8", VA = "0x7BBCA4DCB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BB78", Offset = "0x114BB78")]
			set
			{
			}
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x0600F811 RID: 63505 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F812 RID: 63506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700120D")]
		public string AccessToken
		{
			[Token(Token = "0x600F811")]
			[Address(RVA = "0x224DCC0", Offset = "0x224DCC0", VA = "0x7BBCA4DCC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BB88", Offset = "0x114BB88")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F812")]
			[Address(RVA = "0x224DCC8", Offset = "0x224DCC8", VA = "0x7BBCA4DCC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BB98", Offset = "0x114BB98")]
			set
			{
			}
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x0600F813 RID: 63507 RVA: 0x000476A0 File Offset: 0x000458A0
		// (set) Token: 0x0600F814 RID: 63508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700120E")]
		public AccountPlatform Platform
		{
			[Token(Token = "0x600F813")]
			[Address(RVA = "0x224DCD0", Offset = "0x224DCD0", VA = "0x7BBCA4DCD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BBA8", Offset = "0x114BBA8")]
			get
			{
				return AccountPlatform.None;
			}
			[Token(Token = "0x600F814")]
			[Address(RVA = "0x224DCD8", Offset = "0x224DCD8", VA = "0x7BBCA4DCD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114BBB8", Offset = "0x114BBB8")]
			set
			{
			}
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x0600F815 RID: 63509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700120F")]
		public static GarenaMSDKMgr Instance
		{
			[Token(Token = "0x600F815")]
			[Address(RVA = "0x224DCE0", Offset = "0x224DCE0", VA = "0x7BBCA4DCE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F816 RID: 63510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F816")]
		[Address(RVA = "0x224DD48", Offset = "0x224DD48", VA = "0x7BBCA4DD48")]
		private void Awake()
		{
		}

		// Token: 0x0600F817 RID: 63511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F817")]
		[Address(RVA = "0x224DE08", Offset = "0x224DE08", VA = "0x7BBCA4DE08")]
		private void Start()
		{
		}

		// Token: 0x0600F818 RID: 63512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F818")]
		[Address(RVA = "0x224DE0C", Offset = "0x224DE0C", VA = "0x7BBCA4DE0C")]
		private void Update()
		{
		}

		// Token: 0x0600F819 RID: 63513 RVA: 0x000476B8 File Offset: 0x000458B8
		[Token(Token = "0x600F819")]
		[Address(RVA = "0x224DE10", Offset = "0x224DE10", VA = "0x7BBCA4DE10")]
		public bool IsPlatformInstalled(AccountPlatform platform)
		{
			return default(bool);
		}

		// Token: 0x0600F81A RID: 63514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F81A")]
		[Address(RVA = "0x224DF48", Offset = "0x224DF48", VA = "0x7BBCA4DF48")]
		public void InitSDK(string appId, string appKey, string appPushKey, bool production, bool force = false)
		{
		}

		// Token: 0x0600F81B RID: 63515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F81B")]
		[Address(RVA = "0x224E25C", Offset = "0x224E25C", VA = "0x7BBCA4E25C")]
		public static void SetGoogleClientID(string googleClientID)
		{
		}

		// Token: 0x0600F81C RID: 63516 RVA: 0x000476D0 File Offset: 0x000458D0
		[Token(Token = "0x600F81C")]
		[Address(RVA = "0x224E364", Offset = "0x224E364", VA = "0x7BBCA4E364")]
		public AccountPlatform GetLoginRecord()
		{
			return AccountPlatform.None;
		}

		// Token: 0x0600F81D RID: 63517 RVA: 0x000476E8 File Offset: 0x000458E8
		[Token(Token = "0x600F81D")]
		[Address(RVA = "0x224E394", Offset = "0x224E394", VA = "0x7BBCA4E394")]
		public bool PlatformAvailable(AccountPlatform platform)
		{
			return default(bool);
		}

		// Token: 0x0600F81E RID: 63518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F81E")]
		[Address(RVA = "0x224E3CC", Offset = "0x224E3CC", VA = "0x7BBCA4E3CC")]
		public void Login(AccountPlatform accountPlatform, bool autoLogin, SDKLogin.LoginSuccessCb loginSuccess, SDKLogin.LoginFailCb loginFail)
		{
		}

		// Token: 0x0600F81F RID: 63519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F81F")]
		[Address(RVA = "0x224E42C", Offset = "0x224E42C", VA = "0x7BBCA4E42C")]
		public void Logout()
		{
		}

		// Token: 0x0600F820 RID: 63520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F820")]
		[Address(RVA = "0x224E45C", Offset = "0x224E45C", VA = "0x7BBCA4E45C")]
		public void OnLogin(string msg)
		{
		}

		// Token: 0x0600F821 RID: 63521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F821")]
		[Address(RVA = "0x224E494", Offset = "0x224E494", VA = "0x7BBCA4E494")]
		public void GetBindSession(AccountPlatform platform, SDKBind.GetBindSessionSuccessCb getBindSessionSuccess, SDKBind.GetBindSessionFaildCb getBindSessionFaild)
		{
		}

		// Token: 0x0600F822 RID: 63522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F822")]
		[Address(RVA = "0x224E658", Offset = "0x224E658", VA = "0x7BBCA4E658")]
		public void OnGetBindSession(string msg)
		{
		}

		// Token: 0x0600F823 RID: 63523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F823")]
		[Address(RVA = "0x224E7B0", Offset = "0x224E7B0", VA = "0x7BBCA4E7B0")]
		public void OnClearThirdPartySession()
		{
		}

		// Token: 0x0600F824 RID: 63524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F824")]
		[Address(RVA = "0x224E7FC", Offset = "0x224E7FC", VA = "0x7BBCA4E7FC")]
		public void ResetGuest()
		{
		}

		// Token: 0x0600F825 RID: 63525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F825")]
		[Address(RVA = "0x224E938", Offset = "0x224E938", VA = "0x7BBCA4E938")]
		public void SendGameToSessionException(string message)
		{
		}

		// Token: 0x0600F826 RID: 63526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F826")]
		[Address(RVA = "0x224E93C", Offset = "0x224E93C", VA = "0x7BBCA4E93C")]
		public void SendGameToSessionCallback(string pluginResult)
		{
		}

		// Token: 0x0600F827 RID: 63527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F827")]
		[Address(RVA = "0x224E940", Offset = "0x224E940", VA = "0x7BBCA4E940")]
		public void SendMediaToSessionCallback(string pluginResult)
		{
		}

		// Token: 0x0600F828 RID: 63528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F828")]
		[Address(RVA = "0x224E944", Offset = "0x224E944", VA = "0x7BBCA4E944")]
		public void SendLinkToSessionCallback(string pluginResult)
		{
		}

		// Token: 0x0600F829 RID: 63529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F829")]
		[Address(RVA = "0x224E948", Offset = "0x224E948", VA = "0x7BBCA4E948")]
		public void ShareToFacebookException(string message)
		{
		}

		// Token: 0x0600F82A RID: 63530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F82A")]
		[Address(RVA = "0x224E94C", Offset = "0x224E94C", VA = "0x7BBCA4E94C")]
		public void ShareToFacebookCallback(string pluginResult)
		{
		}

		// Token: 0x0600F82B RID: 63531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F82B")]
		[Address(RVA = "0x224E950", Offset = "0x224E950", VA = "0x7BBCA4E950")]
		public void SendLinkToFacebookCallback(string pluginResult)
		{
		}

		// Token: 0x0600F82C RID: 63532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F82C")]
		[Address(RVA = "0x224E954", Offset = "0x224E954", VA = "0x7BBCA4E954")]
		public void SendRequestInvitationToFacebookCallback(string pluginResult)
		{
		}

		// Token: 0x0600F82D RID: 63533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F82D")]
		[Address(RVA = "0x224E958", Offset = "0x224E958", VA = "0x7BBCA4E958")]
		public void SendGameRequestToFacebookUserCallback(string pluginResult)
		{
		}

		// Token: 0x0600F82E RID: 63534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F82E")]
		[Address(RVA = "0x224EA00", Offset = "0x224EA00", VA = "0x7BBCA4EA00")]
		public void ShareToVkCallback(string pluginResult)
		{
		}

		// Token: 0x0600F82F RID: 63535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F82F")]
		[Address(RVA = "0x224EA04", Offset = "0x224EA04", VA = "0x7BBCA4EA04")]
		public void onGetRebateOptions(string getRebateOptionsResult)
		{
		}

		// Token: 0x0600F830 RID: 63536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F830")]
		[Address(RVA = "0x224EA8C", Offset = "0x224EA8C", VA = "0x7BBCA4EA8C")]
		public void onRedeemResultObtained(string redeemResult)
		{
		}

		// Token: 0x0600F831 RID: 63537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F831")]
		[Address(RVA = "0x224EB14", Offset = "0x224EB14", VA = "0x7BBCA4EB14")]
		public void onPaymentOptionsLoaded(string loadPaymentOptionsResult)
		{
		}

		// Token: 0x0600F832 RID: 63538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F832")]
		[Address(RVA = "0x224EB9C", Offset = "0x224EB9C", VA = "0x7BBCA4EB9C")]
		public void onPaymentProcessed_Exception(string transactionInfo)
		{
		}

		// Token: 0x0600F833 RID: 63539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F833")]
		[Address(RVA = "0x224EC24", Offset = "0x224EC24", VA = "0x7BBCA4EC24")]
		public void onPaymentProcessed(string transactionInfo)
		{
		}

		// Token: 0x0600F834 RID: 63540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F834")]
		[Address(RVA = "0x224ECAC", Offset = "0x224ECAC", VA = "0x7BBCA4ECAC")]
		public void onScanGoogleInAppPurchaseInventoryResult(string result)
		{
		}

		// Token: 0x0600F835 RID: 63541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F835")]
		private static void _DebugCallback<T>(string cb, string tString)
		{
		}

		// Token: 0x0600F836 RID: 63542 RVA: 0x00047700 File Offset: 0x00045900
		[Token(Token = "0x600F836")]
		[Address(RVA = "0x224ED34", Offset = "0x224ED34", VA = "0x7BBCA4ED34")]
		public bool ShouldLogoutForErrorCode(ErrorCode errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600F837 RID: 63543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F837")]
		[Address(RVA = "0x224ED58", Offset = "0x224ED58", VA = "0x7BBCA4ED58")]
		public GarenaMSDKMgr()
		{
		}

		// Token: 0x04011BDF RID: 72671
		[Token(Token = "0x4011BDF")]
		[FieldOffset(Offset = "0x18")]
		public bool EnableDebugLog;

		// Token: 0x04011BE0 RID: 72672
		[Token(Token = "0x4011BE0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131D44", Offset = "0x1131D44")]
		private string <GuestOpenID>k__BackingField;

		// Token: 0x04011BE1 RID: 72673
		[Token(Token = "0x4011BE1")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131D54", Offset = "0x1131D54")]
		private string <GuestAccessToken>k__BackingField;

		// Token: 0x04011BE2 RID: 72674
		[Token(Token = "0x4011BE2")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131D64", Offset = "0x1131D64")]
		private string <OpenID>k__BackingField;

		// Token: 0x04011BE3 RID: 72675
		[Token(Token = "0x4011BE3")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131D74", Offset = "0x1131D74")]
		private string <AccessToken>k__BackingField;

		// Token: 0x04011BE4 RID: 72676
		[Token(Token = "0x4011BE4")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1131D84", Offset = "0x1131D84")]
		private AccountPlatform <Platform>k__BackingField;

		// Token: 0x04011BE5 RID: 72677
		[Token(Token = "0x4011BE5")]
		[FieldOffset(Offset = "0x48")]
		private string appId;

		// Token: 0x04011BE6 RID: 72678
		[Token(Token = "0x4011BE6")]
		[FieldOffset(Offset = "0x50")]
		private string appKey;

		// Token: 0x04011BE7 RID: 72679
		[Token(Token = "0x4011BE7")]
		[FieldOffset(Offset = "0x58")]
		private string appPushKey;

		// Token: 0x04011BE8 RID: 72680
		[Token(Token = "0x4011BE8")]
		[FieldOffset(Offset = "0x60")]
		private SDKLogin sdkLogin;

		// Token: 0x04011BE9 RID: 72681
		[Token(Token = "0x4011BE9")]
		[FieldOffset(Offset = "0x68")]
		private SDKBind sdkBind;

		// Token: 0x04011BEA RID: 72682
		[Token(Token = "0x4011BEA")]
		[FieldOffset(Offset = "0x0")]
		private static GarenaMSDKMgr instance;

		// Token: 0x04011BEB RID: 72683
		[Token(Token = "0x4011BEB")]
		[FieldOffset(Offset = "0x8")]
		private static bool InitFlag;
	}
}
