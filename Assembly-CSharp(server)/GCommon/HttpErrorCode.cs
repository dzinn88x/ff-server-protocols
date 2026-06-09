using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F72 RID: 3954
	[Token(Token = "0x2000F72")]
	public enum HttpErrorCode
	{
		// Token: 0x04004B18 RID: 19224
		[Token(Token = "0x4004B18")]
		OK,
		// Token: 0x04004B19 RID: 19225
		[Token(Token = "0x4004B19")]
		InvalidArgs,
		// Token: 0x04004B1A RID: 19226
		[Token(Token = "0x4004B1A")]
		Exception,
		// Token: 0x04004B1B RID: 19227
		[Token(Token = "0x4004B1B")]
		Timeout,
		// Token: 0x04004B1C RID: 19228
		[Token(Token = "0x4004B1C")]
		DataTypeError,
		// Token: 0x04004B1D RID: 19229
		[Token(Token = "0x4004B1D")]
		SSLAuthError,
		// Token: 0x04004B1E RID: 19230
		[Token(Token = "0x4004B1E")]
		DefaultHttpOK = 200
	}
}
