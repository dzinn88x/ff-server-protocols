using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004E4 RID: 1252
	[Token(Token = "0x20004E4")]
	[ProtoContract]
	public class EMtp
	{
		// Token: 0x06001F72 RID: 8050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F72")]
		[Address(RVA = "0x24A2D80", Offset = "0x24A2D80", VA = "0x7BBCCA2D80")]
		public EMtp()
		{
		}

		// Token: 0x020004E5 RID: 1253
		[Token(Token = "0x20004E5")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x0400173C RID: 5948
			[Token(Token = "0x400173C")]
			Proto_NONE,
			// Token: 0x0400173D RID: 5949
			[Token(Token = "0x400173D")]
			Proto_RECV_ANTI_DATA,
			// Token: 0x0400173E RID: 5950
			[Token(Token = "0x400173E")]
			Proto_SEND_DATA_TO_CLIENT_NTF,
			// Token: 0x0400173F RID: 5951
			[Token(Token = "0x400173F")]
			Proto_LIGHT_FEATURE_NTF,
			// Token: 0x04001740 RID: 5952
			[Token(Token = "0x4001740")]
			Proto_TICK_USER,
			// Token: 0x04001741 RID: 5953
			[Token(Token = "0x4001741")]
			Proto_SEC_REPORT_FLOW
		}

		// Token: 0x020004E6 RID: 1254
		[Token(Token = "0x20004E6")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x04001743 RID: 5955
			[Token(Token = "0x4001743")]
			ErrCode_SUSS
		}
	}
}
