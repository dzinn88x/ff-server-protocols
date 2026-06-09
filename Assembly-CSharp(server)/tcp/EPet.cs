using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004EB RID: 1259
	[Token(Token = "0x20004EB")]
	[ProtoContract]
	public class EPet
	{
		// Token: 0x06001F99 RID: 8089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F99")]
		[Address(RVA = "0x24A2D88", Offset = "0x24A2D88", VA = "0x7BBCCA2D88")]
		public EPet()
		{
		}

		// Token: 0x020004EC RID: 1260
		[Token(Token = "0x20004EC")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x04001756 RID: 5974
			[Token(Token = "0x4001756")]
			Proto_NONE,
			// Token: 0x04001757 RID: 5975
			[Token(Token = "0x4001757")]
			Proto_LEVEL_UP_NTF
		}

		// Token: 0x020004ED RID: 1261
		[Token(Token = "0x20004ED")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x04001759 RID: 5977
			[Token(Token = "0x4001759")]
			ErrCode_SUSS
		}
	}
}
