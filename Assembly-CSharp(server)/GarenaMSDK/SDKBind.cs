using System;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BC6 RID: 11206
	[Token(Token = "0x2002BC6")]
	public class SDKBind
	{
		// Token: 0x0600F83A RID: 63546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F83A")]
		[Address(RVA = "0x224EDE0", Offset = "0x224EDE0", VA = "0x7BBCA4EDE0")]
		public SDKBind()
		{
		}

		// Token: 0x0600F83B RID: 63547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F83B")]
		[Address(RVA = "0x224E4E0", Offset = "0x224E4E0", VA = "0x7BBCA4E4E0")]
		public void GetBindSession(AccountPlatform accountType, SDKBind.GetBindSessionSuccessCb getBindSessionSuccessCb, SDKBind.GetBindSessionFaildCb getBindSessionFaildCb)
		{
		}

		// Token: 0x0600F83C RID: 63548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F83C")]
		[Address(RVA = "0x224E894", Offset = "0x224E894", VA = "0x7BBCA4E894")]
		public void ResetGuest()
		{
		}

		// Token: 0x0600F83D RID: 63549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F83D")]
		[Address(RVA = "0x224E68C", Offset = "0x224E68C", VA = "0x7BBCA4E68C")]
		public void OnGetBindSession(string msg)
		{
		}

		// Token: 0x0600F83E RID: 63550 RVA: 0x00047718 File Offset: 0x00045918
		[Token(Token = "0x600F83E")]
		[Address(RVA = "0x22532E8", Offset = "0x22532E8", VA = "0x7BBCA532E8")]
		public bool CanClearThirdPartySession()
		{
			return default(bool);
		}

		// Token: 0x0600F83F RID: 63551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F83F")]
		[Address(RVA = "0x22532F0", Offset = "0x22532F0", VA = "0x7BBCA532F0")]
		public void ClearThirdPartySession(SDKBind.ClearThirdPartySessionCb cb)
		{
		}

		// Token: 0x0600F840 RID: 63552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F840")]
		[Address(RVA = "0x224E7EC", Offset = "0x224E7EC", VA = "0x7BBCA4E7EC")]
		public void OnClearThirdPartySession()
		{
		}

		// Token: 0x04011BEC RID: 72684
		[Token(Token = "0x4011BEC")]
		[FieldOffset(Offset = "0x10")]
		protected SDKBind.GetBindSessionSuccessCb getBindSessionSuccessCb;

		// Token: 0x04011BED RID: 72685
		[Token(Token = "0x4011BED")]
		[FieldOffset(Offset = "0x18")]
		protected SDKBind.GetBindSessionFaildCb getBindSessionFaildCb;

		// Token: 0x04011BEE RID: 72686
		[Token(Token = "0x4011BEE")]
		[FieldOffset(Offset = "0x20")]
		protected SDKBind.ClearThirdPartySessionCb clearThirdPartySessionCb;

		// Token: 0x04011BEF RID: 72687
		[Token(Token = "0x4011BEF")]
		[FieldOffset(Offset = "0x28")]
		public string bindOpenId;

		// Token: 0x04011BF0 RID: 72688
		[Token(Token = "0x4011BF0")]
		[FieldOffset(Offset = "0x30")]
		public string bindAccessToken;

		// Token: 0x04011BF1 RID: 72689
		[Token(Token = "0x4011BF1")]
		[FieldOffset(Offset = "0x38")]
		public AccountPlatform bindPlatform;

		// Token: 0x02002BC7 RID: 11207
		// (Invoke) Token: 0x0600F842 RID: 63554
		[Token(Token = "0x2002BC7")]
		public delegate void GetBindSessionSuccessCb(BindSessionRsp rsp);

		// Token: 0x02002BC8 RID: 11208
		// (Invoke) Token: 0x0600F846 RID: 63558
		[Token(Token = "0x2002BC8")]
		public delegate void GetBindSessionFaildCb(ErrorCode errorCode);

		// Token: 0x02002BC9 RID: 11209
		// (Invoke) Token: 0x0600F84A RID: 63562
		[Token(Token = "0x2002BC9")]
		public delegate void ClearThirdPartySessionCb();
	}
}
