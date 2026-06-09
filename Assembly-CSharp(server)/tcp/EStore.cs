using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200052B RID: 1323
	[Token(Token = "0x200052B")]
	[ProtoContract]
	public class EStore
	{
		// Token: 0x06002187 RID: 8583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002187")]
		[Address(RVA = "0x24A2DC0", Offset = "0x24A2DC0", VA = "0x7BBCCA2DC0")]
		public EStore()
		{
		}

		// Token: 0x0200052C RID: 1324
		[Token(Token = "0x200052C")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x040018CD RID: 6349
			[Token(Token = "0x40018CD")]
			Proto_NONE,
			// Token: 0x040018CE RID: 6350
			[Token(Token = "0x40018CE")]
			Proto_IAP_PURCHASE_DONE,
			// Token: 0x040018CF RID: 6351
			[Token(Token = "0x40018CF")]
			Proto_PBW_PURCHASE_DONE,
			// Token: 0x040018D0 RID: 6352
			[Token(Token = "0x40018D0")]
			Proto_IAP_INFO_CHANGE
		}

		// Token: 0x0200052D RID: 1325
		[Token(Token = "0x200052D")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x040018D2 RID: 6354
			[Token(Token = "0x40018D2")]
			ErrCode_SUSS
		}
	}
}
