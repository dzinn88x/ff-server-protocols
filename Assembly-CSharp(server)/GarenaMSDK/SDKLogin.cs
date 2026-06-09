using System;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BFC RID: 11260
	[Token(Token = "0x2002BFC")]
	public class SDKLogin
	{
		// Token: 0x0600F921 RID: 63777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F921")]
		[Address(RVA = "0x273E73C", Offset = "0x273E73C", VA = "0x7BBCF3E73C")]
		public SDKLogin()
		{
		}

		// Token: 0x0600F922 RID: 63778 RVA: 0x00047C58 File Offset: 0x00045E58
		[Token(Token = "0x600F922")]
		[Address(RVA = "0x273E744", Offset = "0x273E744", VA = "0x7BBCF3E744")]
		public AccountPlatform GetLoginRecord()
		{
			return AccountPlatform.None;
		}

		// Token: 0x0600F923 RID: 63779 RVA: 0x00047C70 File Offset: 0x00045E70
		[Token(Token = "0x600F923")]
		[Address(RVA = "0x273E8AC", Offset = "0x273E8AC", VA = "0x7BBCF3E8AC")]
		public bool PlatformAvailable(AccountPlatform platform)
		{
			return default(bool);
		}

		// Token: 0x0600F924 RID: 63780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F924")]
		[Address(RVA = "0x273E93C", Offset = "0x273E93C", VA = "0x7BBCF3E93C")]
		public void Login(AccountPlatform accountPlatform, bool autoLogin, SDKLogin.LoginSuccessCb loginSuccess, SDKLogin.LoginFailCb loginFail)
		{
		}

		// Token: 0x0600F925 RID: 63781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F925")]
		[Address(RVA = "0x273EB2C", Offset = "0x273EB2C", VA = "0x7BBCF3EB2C")]
		public void Logout()
		{
		}

		// Token: 0x0600F926 RID: 63782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F926")]
		[Address(RVA = "0x273EBC8", Offset = "0x273EBC8", VA = "0x7BBCF3EBC8")]
		public void OnLogin(string msg)
		{
		}

		// Token: 0x04011CD0 RID: 72912
		[Token(Token = "0x4011CD0")]
		[FieldOffset(Offset = "0x10")]
		private SDKLogin.LoginSuccessCb loginSuccessCb;

		// Token: 0x04011CD1 RID: 72913
		[Token(Token = "0x4011CD1")]
		[FieldOffset(Offset = "0x18")]
		private SDKLogin.LoginFailCb loginFailCb;

		// Token: 0x02002BFD RID: 11261
		// (Invoke) Token: 0x0600F928 RID: 63784
		[Token(Token = "0x2002BFD")]
		public delegate void LoginSuccessCb(LoginRsp rsp);

		// Token: 0x02002BFE RID: 11262
		// (Invoke) Token: 0x0600F92C RID: 63788
		[Token(Token = "0x2002BFE")]
		public delegate void LoginFailCb(ErrorCode errCode);
	}
}
