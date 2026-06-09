using System;
using GarenaMSDK;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001F18 RID: 7960
	[Token(Token = "0x2001F18")]
	internal class UIModelLogin : UIBaseModel
	{
		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x0600AEEF RID: 44783 RVA: 0x00030A38 File Offset: 0x0002EC38
		// (set) Token: 0x0600AEF0 RID: 44784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B9E")]
		public uint m_LoginTryTimes
		{
			[Token(Token = "0x600AEEF")]
			[Address(RVA = "0x16439D8", Offset = "0x16439D8", VA = "0x7BBBE439D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114664C", Offset = "0x114664C")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600AEF0")]
			[Address(RVA = "0x16439E0", Offset = "0x16439E0", VA = "0x7BBBE439E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114665C", Offset = "0x114665C")]
			set
			{
			}
		}

		// Token: 0x0600AEF1 RID: 44785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEF1")]
		[Address(RVA = "0x16439E8", Offset = "0x16439E8", VA = "0x7BBBE439E8")]
		public void LogVerbose(string log)
		{
		}

		// Token: 0x0600AEF2 RID: 44786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEF2")]
		[Address(RVA = "0x1643A50", Offset = "0x1643A50", VA = "0x7BBBE43A50")]
		private void StartLoginLoading()
		{
		}

		// Token: 0x0600AEF3 RID: 44787 RVA: 0x00030A50 File Offset: 0x0002EC50
		[Token(Token = "0x600AEF3")]
		[Address(RVA = "0x1643B90", Offset = "0x1643B90", VA = "0x7BBBE43B90")]
		public bool SupportSignIn(PlatformType platformType)
		{
			return default(bool);
		}

		// Token: 0x0600AEF4 RID: 44788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEF4")]
		[Address(RVA = "0x1643C10", Offset = "0x1643C10", VA = "0x7BBBE43C10")]
		public void UpdatePlayerInfoCache()
		{
		}

		// Token: 0x0600AEF5 RID: 44789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEF5")]
		[Address(RVA = "0x1643D9C", Offset = "0x1643D9C", VA = "0x7BBBE43D9C")]
		private void WritePlayerInfoCache(string open_id, UIModelLogin.CachedPlayerInfo info)
		{
		}

		// Token: 0x0600AEF6 RID: 44790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AEF6")]
		[Address(RVA = "0x1643EF8", Offset = "0x1643EF8", VA = "0x7BBBE43EF8")]
		public UIModelLogin.CachedPlayerInfo ReadPlayerInfoCache(string open_id)
		{
			return null;
		}

		// Token: 0x0600AEF7 RID: 44791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEF7")]
		[Address(RVA = "0x1644098", Offset = "0x1644098", VA = "0x7BBBE44098")]
		private void StopReRequestLoginProcess()
		{
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x0600AEF8 RID: 44792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B9F")]
		public string CachedRegion
		{
			[Token(Token = "0x600AEF8")]
			[Address(RVA = "0x1644138", Offset = "0x1644138", VA = "0x7BBBE44138")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x0600AEF9 RID: 44793 RVA: 0x00030A68 File Offset: 0x0002EC68
		// (set) Token: 0x0600AEFA RID: 44794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BA0")]
		public int RegionID
		{
			[Token(Token = "0x600AEF9")]
			[Address(RVA = "0x1644140", Offset = "0x1644140", VA = "0x7BBBE44140")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600AEFA")]
			[Address(RVA = "0x1644148", Offset = "0x1644148", VA = "0x7BBBE44148")]
			set
			{
			}
		}

		// Token: 0x0600AEFB RID: 44795 RVA: 0x00030A80 File Offset: 0x0002EC80
		[Token(Token = "0x600AEFB")]
		[Address(RVA = "0x1644150", Offset = "0x1644150", VA = "0x7BBBE44150", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x0600AEFC RID: 44796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA1")]
		public string DeviceUniqueIdentifier
		{
			[Token(Token = "0x600AEFC")]
			[Address(RVA = "0x1644158", Offset = "0x1644158", VA = "0x7BBBE44158")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AEFD RID: 44797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEFD")]
		[Address(RVA = "0x1644160", Offset = "0x1644160", VA = "0x7BBBE44160")]
		public UIModelLogin()
		{
		}

		// Token: 0x0600AEFE RID: 44798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEFE")]
		[Address(RVA = "0x16441DC", Offset = "0x16441DC", VA = "0x7BBBE441DC")]
		public void RequestServerStatus(string region)
		{
		}

		// Token: 0x0600AEFF RID: 44799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEFF")]
		[Address(RVA = "0x16446DC", Offset = "0x16446DC", VA = "0x7BBBE446DC")]
		public void ShowFailedPanel()
		{
		}

		// Token: 0x0600AF00 RID: 44800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF00")]
		[Address(RVA = "0x16449EC", Offset = "0x16449EC", VA = "0x7BBBE449EC")]
		public void ShowRegionNotOpenPanel(uint time)
		{
		}

		// Token: 0x0600AF01 RID: 44801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF01")]
		[Address(RVA = "0x1644C78", Offset = "0x1644C78", VA = "0x7BBBE44C78")]
		public void LoginSDK(PlatformType platformType, bool autoLogin)
		{
		}

		// Token: 0x0600AF02 RID: 44802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF02")]
		[Address(RVA = "0x1644FFC", Offset = "0x1644FFC", VA = "0x7BBBE44FFC")]
		private void LoginSDK_Garena_Abort_Cancel()
		{
		}

		// Token: 0x0600AF03 RID: 44803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF03")]
		[Address(RVA = "0x164509C", Offset = "0x164509C", VA = "0x7BBBE4509C")]
		private void LoginSDK_Garena_Abort()
		{
		}

		// Token: 0x0600AF04 RID: 44804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF04")]
		[Address(RVA = "0x1645218", Offset = "0x1645218", VA = "0x7BBBE45218")]
		private void OnLoginSDK_Garena_Success(LoginRsp rsp)
		{
		}

		// Token: 0x0600AF05 RID: 44805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF05")]
		[Address(RVA = "0x1645664", Offset = "0x1645664", VA = "0x7BBBE45664")]
		private void _OnLoginSDK_Garena_Failure(ErrorCode errCode)
		{
		}

		// Token: 0x0600AF06 RID: 44806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF06")]
		[Address(RVA = "0x16450B4", Offset = "0x16450B4", VA = "0x7BBBE450B4")]
		private void OnLoginSDK_Garena_Failure(ErrorCode errCode)
		{
		}

		// Token: 0x0600AF07 RID: 44807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF07")]
		[Address(RVA = "0x1644D3C", Offset = "0x1644D3C", VA = "0x7BBBE44D3C")]
		private void LoginSDK_Garena(AccountPlatform accountPlatform, bool autoLogin)
		{
		}

		// Token: 0x0600AF08 RID: 44808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF08")]
		[Address(RVA = "0x1645BB0", Offset = "0x1645BB0", VA = "0x7BBBE45BB0")]
		public void RequestLogin()
		{
		}

		// Token: 0x0600AF09 RID: 44809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF09")]
		[Address(RVA = "0x1646CE4", Offset = "0x1646CE4", VA = "0x7BBBE46CE4")]
		public void RequestRegionChoose(string region)
		{
		}

		// Token: 0x0600AF0A RID: 44810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF0A")]
		[Address(RVA = "0x1646F0C", Offset = "0x1646F0C", VA = "0x7BBBE46F0C")]
		public void RequestGetPlatformProfile()
		{
		}

		// Token: 0x0600AF0B RID: 44811 RVA: 0x00030A98 File Offset: 0x0002EC98
		[Token(Token = "0x600AF0B")]
		[Address(RVA = "0x1647204", Offset = "0x1647204", VA = "0x7BBBE47204")]
		private EAccount.DownloadType GetDownloadType()
		{
			return EAccount.DownloadType.DownloadType_NONE;
		}

		// Token: 0x0600AF0C RID: 44812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF0C")]
		[Address(RVA = "0x1647380", Offset = "0x1647380", VA = "0x7BBBE47380")]
		private void ClearCookie()
		{
		}

		// Token: 0x0600AF0D RID: 44813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF0D")]
		[Address(RVA = "0x16474B8", Offset = "0x16474B8", VA = "0x7BBBE474B8")]
		public void RequestPlatformRegister(string nickname, uint avatar_id, bool requestDefaultNickname = false)
		{
		}

		// Token: 0x0600AF0E RID: 44814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF0E")]
		[Address(RVA = "0x1647B0C", Offset = "0x1647B0C", VA = "0x7BBBE47B0C")]
		public void RequestBind(PlatformType oldPlatform, PlatformType newPlatform, string newOpenId, string newToken)
		{
		}

		// Token: 0x0600AF0F RID: 44815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF0F")]
		[Address(RVA = "0x1647F04", Offset = "0x1647F04", VA = "0x7BBBE47F04")]
		public void RequestLogout(UIModelLogin.ELogoutType type, bool logoutSdk = true)
		{
		}

		// Token: 0x0600AF10 RID: 44816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF10")]
		[Address(RVA = "0x164840C", Offset = "0x164840C", VA = "0x7BBBE4840C")]
		public void RequestDelAccount()
		{
		}

		// Token: 0x0600AF11 RID: 44817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF11")]
		[Address(RVA = "0x16481CC", Offset = "0x16481CC", VA = "0x7BBBE481CC")]
		private void ClearAfterLogout()
		{
		}

		// Token: 0x0600AF12 RID: 44818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF12")]
		[Address(RVA = "0x16485D4", Offset = "0x16485D4", VA = "0x7BBBE485D4", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600AF13 RID: 44819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF13")]
		[Address(RVA = "0x16485E8", Offset = "0x16485E8", VA = "0x7BBBE485E8")]
		private void PopupWrongVersionMessage()
		{
		}

		// Token: 0x0600AF14 RID: 44820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF14")]
		[Address(RVA = "0x1646108", Offset = "0x1646108", VA = "0x7BBBE46108")]
		private void PopupLoginQueueIsFull()
		{
		}

		// Token: 0x0600AF15 RID: 44821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF15")]
		[Address(RVA = "0x1646368", Offset = "0x1646368", VA = "0x7BBBE46368")]
		private void UpdateLoginQueueInfo(LoginQueueInfo info, bool isNew = false)
		{
		}

		// Token: 0x0600AF16 RID: 44822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF16")]
		[Address(RVA = "0x164887C", Offset = "0x164887C", VA = "0x7BBBE4887C")]
		private void ClearQueueInfo()
		{
		}

		// Token: 0x0600AF17 RID: 44823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF17")]
		[Address(RVA = "0x1645468", Offset = "0x1645468", VA = "0x7BBBE45468")]
		private void InitCachedLockRegion()
		{
		}

		// Token: 0x0600AF18 RID: 44824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF18")]
		[Address(RVA = "0x164891C", Offset = "0x164891C", VA = "0x7BBBE4891C")]
		private void UpdateCachedLockRegion(string region)
		{
		}

		// Token: 0x0600AF19 RID: 44825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF19")]
		[Address(RVA = "0x1648A9C", Offset = "0x1648A9C", VA = "0x7BBBE48A9C")]
		private void ProcessLoginError(HttpErrorCode errorCode)
		{
		}

		// Token: 0x0600AF1A RID: 44826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF1A")]
		[Address(RVA = "0x16497E4", Offset = "0x16497E4", VA = "0x7BBBE497E4")]
		private void ProcessAccountForbidden(BlacklistInfoRes blackList)
		{
		}

		// Token: 0x0600AF1B RID: 44827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF1B")]
		[Address(RVA = "0x16498EC", Offset = "0x16498EC", VA = "0x7BBBE498EC")]
		private void OnMiddleLoginRes(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AF1C RID: 44828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF1C")]
		[Address(RVA = "0x16498F4", Offset = "0x16498F4", VA = "0x7BBBE498F4")]
		private void ProcessMiddleLoginRes(HttpErrorCode errorCode, object res, uint login_by = 0U)
		{
		}

		// Token: 0x0600AF1D RID: 44829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF1D")]
		[Address(RVA = "0x164A07C", Offset = "0x164A07C", VA = "0x7BBBE4A07C")]
		private void ProcessLastLoginRes(HttpErrorCode errorCode, object res, object res1)
		{
		}

		// Token: 0x0600AF1E RID: 44830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF1E")]
		[Address(RVA = "0x164C038", Offset = "0x164C038", VA = "0x7BBBE4C038")]
		private void OnGetLoginDesc(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600AF1F RID: 44831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF1F")]
		[Address(RVA = "0x164BE08", Offset = "0x164BE08", VA = "0x7BBBE4BE08")]
		private void RequestStaticDescOnLogin()
		{
		}

		// Token: 0x0600AF20 RID: 44832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF20")]
		[Address(RVA = "0x164D96C", Offset = "0x164D96C", VA = "0x7BBBE4D96C")]
		private void RequestLobbyMessage()
		{
		}

		// Token: 0x0600AF21 RID: 44833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF21")]
		[Address(RVA = "0x164AADC", Offset = "0x164AADC", VA = "0x7BBBE4AADC")]
		private void ProcessSuccessfulLogin(LoginRes loginRes, MajorLoginRes majorRes)
		{
		}

		// Token: 0x0600AF22 RID: 44834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF22")]
		[Address(RVA = "0x164E800", Offset = "0x164E800", VA = "0x7BBBE4E800")]
		private void LoadCSVWithRegion()
		{
		}

		// Token: 0x0600AF23 RID: 44835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF23")]
		[Address(RVA = "0x164D36C", Offset = "0x164D36C", VA = "0x7BBBE4D36C")]
		private void DetectAndroidApplications(CSGetAndroidApplicationToDetectRes androidApplicationToDetectRes)
		{
		}

		// Token: 0x0600AF24 RID: 44836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF24")]
		[Address(RVA = "0x16464AC", Offset = "0x16464AC", VA = "0x7BBBE464AC")]
		private void CreateLoginReqInfoData(ref LoginReq req)
		{
		}

		// Token: 0x0600AF25 RID: 44837 RVA: 0x00030AB0 File Offset: 0x0002ECB0
		[Token(Token = "0x600AF25")]
		[Address(RVA = "0x164EB10", Offset = "0x164EB10", VA = "0x7BBBE4EB10")]
		public bool ShouldShowBindAccount()
		{
			return default(bool);
		}

		// Token: 0x0600AF26 RID: 44838 RVA: 0x00030AC8 File Offset: 0x0002ECC8
		[Token(Token = "0x600AF26")]
		[Address(RVA = "0x164EBA0", Offset = "0x164EBA0", VA = "0x7BBBE4EBA0")]
		public bool PlatformBtnNeedShowOutOfMoreButton(PlatformType platformType)
		{
			return default(bool);
		}

		// Token: 0x0600AF27 RID: 44839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF27")]
		[Address(RVA = "0x164EEF4", Offset = "0x164EEF4", VA = "0x7BBBE4EEF4")]
		public void Bind(PlatformType platform)
		{
		}

		// Token: 0x0600AF28 RID: 44840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF28")]
		[Address(RVA = "0x164EFB0", Offset = "0x164EFB0", VA = "0x7BBBE4EFB0")]
		private void BindGarena(PlatformType platform)
		{
		}

		// Token: 0x0600AF29 RID: 44841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF29")]
		[Address(RVA = "0x164F110", Offset = "0x164F110", VA = "0x7BBBE4F110")]
		private void PlatformLoginDone(PlatformType platformType, string userId, string accessToken)
		{
		}

		// Token: 0x0600AF2A RID: 44842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF2A")]
		[Address(RVA = "0x164F27C", Offset = "0x164F27C", VA = "0x7BBBE4F27C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114666C", Offset = "0x114666C")]
		private void <RequestDelAccount>b__84_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AF2B RID: 44843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF2B")]
		[Address(RVA = "0x164F48C", Offset = "0x164F48C", VA = "0x7BBBE4F48C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114667C", Offset = "0x114667C")]
		private void <ProcessLastLoginRes>b__97_0()
		{
		}

		// Token: 0x0600AF2C RID: 44844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF2C")]
		[Address(RVA = "0x164F490", Offset = "0x164F490", VA = "0x7BBBE4F490")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114668C", Offset = "0x114668C")]
		private void <OnGetLoginDesc>b__98_0()
		{
		}

		// Token: 0x0600AF2D RID: 44845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF2D")]
		[Address(RVA = "0x164F494", Offset = "0x164F494", VA = "0x7BBBE4F494")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114669C", Offset = "0x114669C")]
		private void <BindGarena>b__108_0(BindSessionRsp rsp)
		{
		}

		// Token: 0x0400B2F2 RID: 45810
		[Token(Token = "0x400B2F2")]
		[FieldOffset(Offset = "0x18")]
		public bool m_Registered;

		// Token: 0x0400B2F3 RID: 45811
		[Token(Token = "0x400B2F3")]
		public const uint PropID_LoginRetOK = 2U;

		// Token: 0x0400B2F4 RID: 45812
		[Token(Token = "0x400B2F4")]
		public const uint PropID_LoginRetNewUser = 4U;

		// Token: 0x0400B2F5 RID: 45813
		[Token(Token = "0x400B2F5")]
		public const uint PropID_GuestBindSuccess = 8U;

		// Token: 0x0400B2F6 RID: 45814
		[Token(Token = "0x400B2F6")]
		public const uint PropID_SDKLogin = 16U;

		// Token: 0x0400B2F7 RID: 45815
		[Token(Token = "0x400B2F7")]
		public const uint PropID_LoginRegionChoose = 32U;

		// Token: 0x0400B2F8 RID: 45816
		[Token(Token = "0x400B2F8")]
		public const uint PropID_LoginRegionReChoose = 64U;

		// Token: 0x0400B2F9 RID: 45817
		[Token(Token = "0x400B2F9")]
		public const uint PropID_LoginServerFailure_Logout = 128U;

		// Token: 0x0400B2FA RID: 45818
		[Token(Token = "0x400B2FA")]
		public const uint PropID_RegisterSuccess = 256U;

		// Token: 0x0400B2FB RID: 45819
		[Token(Token = "0x400B2FB")]
		public const uint PropID_LoginGetDescFinish = 512U;

		// Token: 0x0400B2FC RID: 45820
		[Token(Token = "0x400B2FC")]
		public const uint PropID_ShowMaintenanceMessage = 1024U;

		// Token: 0x0400B2FD RID: 45821
		[Token(Token = "0x400B2FD")]
		public const uint PropID_LoginLoadOver = 2048U;

		// Token: 0x0400B2FE RID: 45822
		[Token(Token = "0x400B2FE")]
		public const uint PropID_MajorLoginSuccess = 4096U;

		// Token: 0x0400B2FF RID: 45823
		[Token(Token = "0x400B2FF")]
		private const float TIMEOUT_LOGIN = 10f;

		// Token: 0x0400B300 RID: 45824
		[Token(Token = "0x400B300")]
		private const float TIMEOUT_LOGOUT = 10f;

		// Token: 0x0400B301 RID: 45825
		[Token(Token = "0x400B301")]
		private const float TIMEOUT_REGISTER = 20f;

		// Token: 0x0400B302 RID: 45826
		[Token(Token = "0x400B302")]
		private const float TIMEOUT_BINDING = 20f;

		// Token: 0x0400B303 RID: 45827
		[Token(Token = "0x400B303")]
		private const string KEY_InstantApp = "instantapp";

		// Token: 0x0400B304 RID: 45828
		[Token(Token = "0x400B304")]
		public const string KEY_GUIDE_BINDACCOUNT = "KEY_GUIDE_BINDACCOUNT";

		// Token: 0x0400B305 RID: 45829
		[Token(Token = "0x400B305")]
		private const int ReRequestLogInterval = 5;

		// Token: 0x0400B306 RID: 45830
		[Token(Token = "0x400B306")]
		[FieldOffset(Offset = "0x1C")]
		private uint m_CurRequestLoginDelayCallID;

		// Token: 0x0400B307 RID: 45831
		[Token(Token = "0x400B307")]
		[FieldOffset(Offset = "0x20")]
		public bool IsFirstTimeOpenLobby;

		// Token: 0x0400B308 RID: 45832
		[Token(Token = "0x400B308")]
		[FieldOffset(Offset = "0x21")]
		public bool IsModifyBloodOption;

		// Token: 0x0400B309 RID: 45833
		[Token(Token = "0x400B309")]
		[FieldOffset(Offset = "0x24")]
		private EAccount.DownloadType m_DownLoadType;

		// Token: 0x0400B30A RID: 45834
		[Token(Token = "0x400B30A")]
		[FieldOffset(Offset = "0x28")]
		public bool FirstTimeInLobby;

		// Token: 0x0400B30B RID: 45835
		[Token(Token = "0x400B30B")]
		[FieldOffset(Offset = "0x30")]
		public string loginRegion;

		// Token: 0x0400B30C RID: 45836
		[Token(Token = "0x400B30C")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113010C", Offset = "0x113010C")]
		private uint <m_LoginTryTimes>k__BackingField;

		// Token: 0x0400B30D RID: 45837
		[Token(Token = "0x400B30D")]
		[FieldOffset(Offset = "0x3C")]
		public bool IsFirstGameSquad;

		// Token: 0x0400B30E RID: 45838
		[Token(Token = "0x400B30E")]
		[FieldOffset(Offset = "0x3D")]
		private bool m_NeedRegister;

		// Token: 0x0400B30F RID: 45839
		[Token(Token = "0x400B30F")]
		[FieldOffset(Offset = "0x3E")]
		private bool m_LastQueueAllow;

		// Token: 0x0400B310 RID: 45840
		[Token(Token = "0x400B310")]
		private const string PLAYER_INFO_CACHE_KEY_TEMPLATE = "PlayerInfoCache_{0}";

		// Token: 0x0400B311 RID: 45841
		[Token(Token = "0x400B311")]
		[FieldOffset(Offset = "0x40")]
		private UIPopupMessageBoxController m_LoginQueuePopupController;

		// Token: 0x0400B312 RID: 45842
		[Token(Token = "0x400B312")]
		[FieldOffset(Offset = "0x48")]
		private UILoginQueueInfoPopupWndController m_LoginQueueInfoCtrl;

		// Token: 0x0400B313 RID: 45843
		[Token(Token = "0x400B313")]
		[FieldOffset(Offset = "0x50")]
		private LoginQueueInfo m_CacheQueueInfo;

		// Token: 0x0400B314 RID: 45844
		[Token(Token = "0x400B314")]
		[FieldOffset(Offset = "0x58")]
		private ulong m_LastFetchQueueInfoTime;

		// Token: 0x0400B315 RID: 45845
		[Token(Token = "0x400B315")]
		[FieldOffset(Offset = "0x60")]
		private string m_CachedRegion;

		// Token: 0x0400B316 RID: 45846
		[Token(Token = "0x400B316")]
		[FieldOffset(Offset = "0x68")]
		private int m_RegionID;

		// Token: 0x0400B317 RID: 45847
		[Token(Token = "0x400B317")]
		[FieldOffset(Offset = "0x6C")]
		private bool _PendingLoginSDK_Garena;

		// Token: 0x0400B318 RID: 45848
		[Token(Token = "0x400B318")]
		[FieldOffset(Offset = "0x70")]
		private AccountPlatform _PendingLoginSDK_Garena_AccountPlatform;

		// Token: 0x0400B319 RID: 45849
		[Token(Token = "0x400B319")]
		private const int GMSDK_LOGIN_RETRY_INTERVAL_MAX = 20;

		// Token: 0x0400B31A RID: 45850
		[Token(Token = "0x400B31A")]
		private const int GMSDK_LOGIN_RETRY_INTERVAL_STEP = 5;

		// Token: 0x0400B31B RID: 45851
		[Token(Token = "0x400B31B")]
		[FieldOffset(Offset = "0x74")]
		private int _GMSDKLoginRetryTimes;

		// Token: 0x0400B31C RID: 45852
		[Token(Token = "0x400B31C")]
		private const int AUTO_LOGIN_TIMEOUT_S = 60;

		// Token: 0x0400B31D RID: 45853
		[Token(Token = "0x400B31D")]
		[FieldOffset(Offset = "0x78")]
		private uint _DelayCallId_AbortLoginSDK_Garena;

		// Token: 0x02001F19 RID: 7961
		[Token(Token = "0x2001F19")]
		[Serializable]
		public class CachedPlayerInfo
		{
			// Token: 0x0600AF2E RID: 44846 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF2E")]
			[Address(RVA = "0x1643D94", Offset = "0x1643D94", VA = "0x7BBBE43D94")]
			public CachedPlayerInfo()
			{
			}

			// Token: 0x0400B31E RID: 45854
			[Token(Token = "0x400B31E")]
			[FieldOffset(Offset = "0x10")]
			public string Nickname;
		}

		// Token: 0x02001F1A RID: 7962
		[Token(Token = "0x2001F1A")]
		private class ServerStatusInfo
		{
			// Token: 0x0600AF2F RID: 44847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF2F")]
			[Address(RVA = "0x1651C98", Offset = "0x1651C98", VA = "0x7BBBE51C98")]
			public ServerStatusInfo()
			{
			}

			// Token: 0x0400B31F RID: 45855
			[Token(Token = "0x400B31F")]
			[FieldOffset(Offset = "0x10")]
			public uint code;

			// Token: 0x0400B320 RID: 45856
			[Token(Token = "0x400B320")]
			[FieldOffset(Offset = "0x18")]
			public string billboard_msg;
		}

		// Token: 0x02001F1B RID: 7963
		[Token(Token = "0x2001F1B")]
		public enum ELogoutType
		{
			// Token: 0x0400B322 RID: 45858
			[Token(Token = "0x400B322")]
			Manually,
			// Token: 0x0400B323 RID: 45859
			[Token(Token = "0x400B323")]
			Exception
		}

		// Token: 0x02001F1C RID: 7964
		[Token(Token = "0x2001F1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCE54", Offset = "0x10FCE54")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600AF31 RID: 44849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF31")]
			[Address(RVA = "0x164F568", Offset = "0x164F568", VA = "0x7BBBE4F568")]
			public <>c()
			{
			}

			// Token: 0x0600AF32 RID: 44850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF32")]
			[Address(RVA = "0x164F570", Offset = "0x164F570", VA = "0x7BBBE4F570")]
			internal void <RequestServerStatus>b__58_0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600AF33 RID: 44851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF33")]
			[Address(RVA = "0x164F8C4", Offset = "0x164F8C4", VA = "0x7BBBE4F8C4")]
			internal void <ShowRegionNotOpenPanel>b__60_0()
			{
			}

			// Token: 0x0600AF34 RID: 44852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF34")]
			[Address(RVA = "0x164F944", Offset = "0x164F944", VA = "0x7BBBE4F944")]
			internal void <RequestGetPlatformProfile>b__77_0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600AF35 RID: 44853 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF35")]
			[Address(RVA = "0x164F948", Offset = "0x164F948", VA = "0x7BBBE4F948")]
			internal void <PopupWrongVersionMessage>b__87_0()
			{
			}

			// Token: 0x0600AF36 RID: 44854 RVA: 0x00030AE0 File Offset: 0x0002ECE0
			[Token(Token = "0x600AF36")]
			[Address(RVA = "0x164F9A8", Offset = "0x164F9A8", VA = "0x7BBBE4F9A8")]
			internal bool <ProcessLastLoginRes>b__97_1(AbTestChoice newChoice)
			{
				return default(bool);
			}

			// Token: 0x0600AF37 RID: 44855 RVA: 0x00030AF8 File Offset: 0x0002ECF8
			[Token(Token = "0x600AF37")]
			[Address(RVA = "0x164F9DC", Offset = "0x164F9DC", VA = "0x7BBBE4F9DC")]
			internal int <DetectAndroidApplications>b__103_0(AndroidApplicationToDetectDesc item)
			{
				return 0;
			}

			// Token: 0x0600AF38 RID: 44856 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AF38")]
			[Address(RVA = "0x164FA08", Offset = "0x164FA08", VA = "0x7BBBE4FA08")]
			internal string <DetectAndroidApplications>b__103_1(AndroidApplicationToDetectDesc item)
			{
				return null;
			}

			// Token: 0x0600AF39 RID: 44857 RVA: 0x00030B10 File Offset: 0x0002ED10
			[Token(Token = "0x600AF39")]
			[Address(RVA = "0x164FA34", Offset = "0x164FA34", VA = "0x7BBBE4FA34")]
			internal bool <PlatformBtnNeedShowOutOfMoreButton>b__106_0(CSVBaseData x)
			{
				return default(bool);
			}

			// Token: 0x0600AF3A RID: 44858 RVA: 0x00030B28 File Offset: 0x0002ED28
			[Token(Token = "0x600AF3A")]
			[Address(RVA = "0x164FB44", Offset = "0x164FB44", VA = "0x7BBBE4FB44")]
			internal bool <PlatformBtnNeedShowOutOfMoreButton>b__106_1(CSVBaseData x)
			{
				return default(bool);
			}

			// Token: 0x0600AF3B RID: 44859 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF3B")]
			[Address(RVA = "0x164FC30", Offset = "0x164FC30", VA = "0x7BBBE4FC30")]
			internal void <BindGarena>b__108_1(ErrorCode errCode)
			{
			}

			// Token: 0x0400B324 RID: 45860
			[Token(Token = "0x400B324")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelLogin.<>c <>9;

			// Token: 0x0400B325 RID: 45861
			[Token(Token = "0x400B325")]
			[FieldOffset(Offset = "0x8")]
			public static Action<HttpErrorCode, object> <>9__58_0;

			// Token: 0x0400B326 RID: 45862
			[Token(Token = "0x400B326")]
			[FieldOffset(Offset = "0x10")]
			public static Action <>9__60_0;

			// Token: 0x0400B327 RID: 45863
			[Token(Token = "0x400B327")]
			[FieldOffset(Offset = "0x18")]
			public static Action<HttpErrorCode, object> <>9__77_0;

			// Token: 0x0400B328 RID: 45864
			[Token(Token = "0x400B328")]
			[FieldOffset(Offset = "0x20")]
			public static Action <>9__87_0;

			// Token: 0x0400B329 RID: 45865
			[Token(Token = "0x400B329")]
			[FieldOffset(Offset = "0x28")]
			public static Predicate<AbTestChoice> <>9__97_1;

			// Token: 0x0400B32A RID: 45866
			[Token(Token = "0x400B32A")]
			[FieldOffset(Offset = "0x30")]
			public static Func<AndroidApplicationToDetectDesc, int> <>9__103_0;

			// Token: 0x0400B32B RID: 45867
			[Token(Token = "0x400B32B")]
			[FieldOffset(Offset = "0x38")]
			public static Func<AndroidApplicationToDetectDesc, string> <>9__103_1;

			// Token: 0x0400B32C RID: 45868
			[Token(Token = "0x400B32C")]
			[FieldOffset(Offset = "0x40")]
			public static Predicate<CSVBaseData> <>9__106_0;

			// Token: 0x0400B32D RID: 45869
			[Token(Token = "0x400B32D")]
			[FieldOffset(Offset = "0x48")]
			public static Predicate<CSVBaseData> <>9__106_1;

			// Token: 0x0400B32E RID: 45870
			[Token(Token = "0x400B32E")]
			[FieldOffset(Offset = "0x50")]
			public static SDKBind.GetBindSessionFaildCb <>9__108_1;
		}

		// Token: 0x02001F1D RID: 7965
		[Token(Token = "0x2001F1D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCE64", Offset = "0x10FCE64")]
		private sealed class <>c__DisplayClass71_0
		{
			// Token: 0x0600AF3C RID: 44860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF3C")]
			[Address(RVA = "0x1645BA8", Offset = "0x1645BA8", VA = "0x7BBBE45BA8")]
			public <>c__DisplayClass71_0()
			{
			}

			// Token: 0x0600AF3D RID: 44861 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF3D")]
			[Address(RVA = "0x164FFC4", Offset = "0x164FFC4", VA = "0x7BBBE4FFC4")]
			internal void <OnLoginSDK_Garena_Failure>b__0()
			{
			}

			// Token: 0x0400B32F RID: 45871
			[Token(Token = "0x400B32F")]
			[FieldOffset(Offset = "0x10")]
			public UIModelLogin <>4__this;

			// Token: 0x0400B330 RID: 45872
			[Token(Token = "0x400B330")]
			[FieldOffset(Offset = "0x18")]
			public ErrorCode errCode;
		}

		// Token: 0x02001F1E RID: 7966
		[Token(Token = "0x2001F1E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCE74", Offset = "0x10FCE74")]
		private sealed class <>c__DisplayClass76_0
		{
			// Token: 0x0600AF3E RID: 44862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF3E")]
			[Address(RVA = "0x1646F04", Offset = "0x1646F04", VA = "0x7BBBE46F04")]
			public <>c__DisplayClass76_0()
			{
			}

			// Token: 0x0600AF3F RID: 44863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF3F")]
			[Address(RVA = "0x164FFF8", Offset = "0x164FFF8", VA = "0x7BBBE4FFF8")]
			internal void <RequestRegionChoose>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B331 RID: 45873
			[Token(Token = "0x400B331")]
			[FieldOffset(Offset = "0x10")]
			public UIModelLogin <>4__this;

			// Token: 0x0400B332 RID: 45874
			[Token(Token = "0x400B332")]
			[FieldOffset(Offset = "0x18")]
			public string region;
		}

		// Token: 0x02001F1F RID: 7967
		[Token(Token = "0x2001F1F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCE84", Offset = "0x10FCE84")]
		private sealed class <>c__DisplayClass80_0
		{
			// Token: 0x0600AF40 RID: 44864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF40")]
			[Address(RVA = "0x1647B04", Offset = "0x1647B04", VA = "0x7BBBE47B04")]
			public <>c__DisplayClass80_0()
			{
			}

			// Token: 0x0600AF41 RID: 44865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF41")]
			[Address(RVA = "0x16504E8", Offset = "0x16504E8", VA = "0x7BBBE504E8")]
			internal void <RequestPlatformRegister>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600AF42 RID: 44866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF42")]
			[Address(RVA = "0x1650E88", Offset = "0x1650E88", VA = "0x7BBBE50E88")]
			internal void <RequestPlatformRegister>b__2()
			{
			}

			// Token: 0x0400B333 RID: 45875
			[Token(Token = "0x400B333")]
			[FieldOffset(Offset = "0x10")]
			public UIModelLogin <>4__this;

			// Token: 0x0400B334 RID: 45876
			[Token(Token = "0x400B334")]
			[FieldOffset(Offset = "0x18")]
			public string nickname;

			// Token: 0x0400B335 RID: 45877
			[Token(Token = "0x400B335")]
			[FieldOffset(Offset = "0x20")]
			public uint avatar_id;

			// Token: 0x0400B336 RID: 45878
			[Token(Token = "0x400B336")]
			[FieldOffset(Offset = "0x28")]
			public Action <>9__2;
		}

		// Token: 0x02001F20 RID: 7968
		[Token(Token = "0x2001F20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCE94", Offset = "0x10FCE94")]
		private sealed class <>c__DisplayClass80_1
		{
			// Token: 0x0600AF43 RID: 44867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF43")]
			[Address(RVA = "0x1650E80", Offset = "0x1650E80", VA = "0x7BBBE50E80")]
			public <>c__DisplayClass80_1()
			{
			}

			// Token: 0x0600AF44 RID: 44868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF44")]
			[Address(RVA = "0x1651000", Offset = "0x1651000", VA = "0x7BBBE51000")]
			internal void <RequestPlatformRegister>b__1()
			{
			}

			// Token: 0x0400B337 RID: 45879
			[Token(Token = "0x400B337")]
			[FieldOffset(Offset = "0x10")]
			public string randomName;

			// Token: 0x0400B338 RID: 45880
			[Token(Token = "0x400B338")]
			[FieldOffset(Offset = "0x18")]
			public UIModelLogin.<>c__DisplayClass80_0 CS$<>8__locals1;
		}

		// Token: 0x02001F21 RID: 7969
		[Token(Token = "0x2001F21")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCEA4", Offset = "0x10FCEA4")]
		private sealed class <>c__DisplayClass81_0
		{
			// Token: 0x0600AF45 RID: 44869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF45")]
			[Address(RVA = "0x1647EFC", Offset = "0x1647EFC", VA = "0x7BBBE47EFC")]
			public <>c__DisplayClass81_0()
			{
			}

			// Token: 0x0600AF46 RID: 44870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF46")]
			[Address(RVA = "0x1651188", Offset = "0x1651188", VA = "0x7BBBE51188")]
			internal void <RequestBind>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B339 RID: 45881
			[Token(Token = "0x400B339")]
			[FieldOffset(Offset = "0x10")]
			public PlatformType newPlatform;

			// Token: 0x0400B33A RID: 45882
			[Token(Token = "0x400B33A")]
			[FieldOffset(Offset = "0x18")]
			public UIModelLogin <>4__this;
		}

		// Token: 0x02001F22 RID: 7970
		[Token(Token = "0x2001F22")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCEB4", Offset = "0x10FCEB4")]
		private sealed class <>c__DisplayClass83_0
		{
			// Token: 0x0600AF47 RID: 44871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF47")]
			[Address(RVA = "0x16481C4", Offset = "0x16481C4", VA = "0x7BBBE481C4")]
			public <>c__DisplayClass83_0()
			{
			}

			// Token: 0x0600AF48 RID: 44872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF48")]
			[Address(RVA = "0x165189C", Offset = "0x165189C", VA = "0x7BBBE5189C")]
			internal void <RequestLogout>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B33B RID: 45883
			[Token(Token = "0x400B33B")]
			[FieldOffset(Offset = "0x10")]
			public UIModelLogin <>4__this;

			// Token: 0x0400B33C RID: 45884
			[Token(Token = "0x400B33C")]
			[FieldOffset(Offset = "0x18")]
			public bool logoutSdk;
		}

		// Token: 0x02001F23 RID: 7971
		[Token(Token = "0x2001F23")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCEC4", Offset = "0x10FCEC4")]
		private sealed class <>c__DisplayClass96_0
		{
			// Token: 0x0600AF49 RID: 44873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF49")]
			[Address(RVA = "0x164A074", Offset = "0x164A074", VA = "0x7BBBE4A074")]
			public <>c__DisplayClass96_0()
			{
			}

			// Token: 0x0600AF4A RID: 44874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF4A")]
			[Address(RVA = "0x1651C50", Offset = "0x1651C50", VA = "0x7BBBE51C50")]
			internal void <ProcessMiddleLoginRes>b__0(HttpErrorCode errorCode1, object res1)
			{
			}

			// Token: 0x0400B33D RID: 45885
			[Token(Token = "0x400B33D")]
			[FieldOffset(Offset = "0x10")]
			public UIModelLogin <>4__this;

			// Token: 0x0400B33E RID: 45886
			[Token(Token = "0x400B33E")]
			[FieldOffset(Offset = "0x18")]
			public object res;
		}
	}
}
