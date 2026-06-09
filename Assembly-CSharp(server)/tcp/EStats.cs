using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000527 RID: 1319
	[Token(Token = "0x2000527")]
	[ProtoContract]
	public class EStats
	{
		// Token: 0x06002177 RID: 8567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002177")]
		[Address(RVA = "0x24A2DB8", Offset = "0x24A2DB8", VA = "0x7BBCCA2DB8")]
		public EStats()
		{
		}

		// Token: 0x02000528 RID: 1320
		[Token(Token = "0x2000528")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x040018C1 RID: 6337
			[Token(Token = "0x40018C1")]
			Proto_NONE,
			// Token: 0x040018C2 RID: 6338
			[Token(Token = "0x40018C2")]
			Proto_MATCHSTATS_NTF
		}

		// Token: 0x02000529 RID: 1321
		[Token(Token = "0x2000529")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x040018C4 RID: 6340
			[Token(Token = "0x40018C4")]
			ErrCode_SUSS
		}
	}
}
