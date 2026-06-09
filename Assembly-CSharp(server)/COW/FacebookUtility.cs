using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001240 RID: 4672
	[Token(Token = "0x2001240")]
	public class FacebookUtility
	{
		// Token: 0x060047A1 RID: 18337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A1")]
		[Address(RVA = "0x1B9536C", Offset = "0x1B9536C", VA = "0x7BBC39536C")]
		public static FacebookUtility Instance()
		{
			return null;
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A2")]
		[Address(RVA = "0x1B95438", Offset = "0x1B95438", VA = "0x7BBC395438")]
		public void OpenFBMainPage(string fbEventID)
		{
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A3")]
		[Address(RVA = "0x1B95430", Offset = "0x1B95430", VA = "0x7BBC395430")]
		public FacebookUtility()
		{
		}

		// Token: 0x04007123 RID: 28963
		[Token(Token = "0x4007123")]
		[FieldOffset(Offset = "0x0")]
		private static FacebookUtility _instance;

		// Token: 0x04007124 RID: 28964
		[Token(Token = "0x4007124")]
		[FieldOffset(Offset = "0x10")]
		public Action<string> OnLoginFailed;

		// Token: 0x04007125 RID: 28965
		[Token(Token = "0x4007125")]
		[FieldOffset(Offset = "0x18")]
		public Action OnLoginSucess;

		// Token: 0x04007126 RID: 28966
		[Token(Token = "0x4007126")]
		[FieldOffset(Offset = "0x20")]
		public Action OnLoginCancel;

		// Token: 0x04007127 RID: 28967
		[Token(Token = "0x4007127")]
		[FieldOffset(Offset = "0x8")]
		private static string FacebookURL_Web;

		// Token: 0x04007128 RID: 28968
		[Token(Token = "0x4007128")]
		[FieldOffset(Offset = "0x10")]
		private static string FacebookURL_APP;
	}
}
