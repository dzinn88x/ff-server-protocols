using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000552 RID: 1362
	[Token(Token = "0x2000552")]
	[ProtoContract]
	public class ECreatePlayer
	{
		// Token: 0x0600231F RID: 8991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600231F")]
		[Address(RVA = "0x24A2D18", Offset = "0x24A2D18", VA = "0x7BBCCA2D18")]
		public ECreatePlayer()
		{
		}

		// Token: 0x02000553 RID: 1363
		[Token(Token = "0x2000553")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x040019F0 RID: 6640
			[Token(Token = "0x40019F0")]
			ErrCode_NORMAL,
			// Token: 0x040019F1 RID: 6641
			[Token(Token = "0x40019F1")]
			ErrCode_NEGATIVE_GEMS,
			// Token: 0x040019F2 RID: 6642
			[Token(Token = "0x40019F2")]
			ErrCode_CSRANKING_BANNED
		}
	}
}
