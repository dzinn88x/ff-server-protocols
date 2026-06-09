using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004C7 RID: 1223
	[Token(Token = "0x20004C7")]
	[ProtoContract]
	public class ELinkage
	{
		// Token: 0x06001ED9 RID: 7897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED9")]
		[Address(RVA = "0x24A2D58", Offset = "0x24A2D58", VA = "0x7BBCCA2D58")]
		public ELinkage()
		{
		}

		// Token: 0x020004C8 RID: 1224
		[Token(Token = "0x20004C8")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x040016B9 RID: 5817
			[Token(Token = "0x40016B9")]
			Proto_NONE,
			// Token: 0x040016BA RID: 5818
			[Token(Token = "0x40016BA")]
			Proto_UPDATE_NTF
		}

		// Token: 0x020004C9 RID: 1225
		[Token(Token = "0x20004C9")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x040016BC RID: 5820
			[Token(Token = "0x40016BC")]
			ErrCode_SUSS
		}
	}
}
