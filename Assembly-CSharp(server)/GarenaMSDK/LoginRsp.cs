using System;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BFB RID: 11259
	[Token(Token = "0x2002BFB")]
	public class LoginRsp
	{
		// Token: 0x0600F920 RID: 63776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F920")]
		[Address(RVA = "0x224DC88", Offset = "0x224DC88", VA = "0x7BBCA4DC88")]
		public LoginRsp()
		{
		}

		// Token: 0x04011CCC RID: 72908
		[Token(Token = "0x4011CCC")]
		[FieldOffset(Offset = "0x10")]
		public ErrorCode errCode;

		// Token: 0x04011CCD RID: 72909
		[Token(Token = "0x4011CCD")]
		[FieldOffset(Offset = "0x18")]
		public string openID;

		// Token: 0x04011CCE RID: 72910
		[Token(Token = "0x4011CCE")]
		[FieldOffset(Offset = "0x20")]
		public string accessToken;

		// Token: 0x04011CCF RID: 72911
		[Token(Token = "0x4011CCF")]
		[FieldOffset(Offset = "0x28")]
		public int platform;
	}
}
