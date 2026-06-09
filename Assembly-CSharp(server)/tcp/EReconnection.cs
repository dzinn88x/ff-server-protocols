using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000535 RID: 1333
	[Token(Token = "0x2000535")]
	[ProtoContract]
	public class EReconnection
	{
		// Token: 0x0600218A RID: 8586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218A")]
		[Address(RVA = "0x24A2DA8", Offset = "0x24A2DA8", VA = "0x7BBCCA2DA8")]
		public EReconnection()
		{
		}

		// Token: 0x02000536 RID: 1334
		[Token(Token = "0x2000536")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x0400192A RID: 6442
			[Token(Token = "0x400192A")]
			Proto_NONE,
			// Token: 0x0400192B RID: 6443
			[Token(Token = "0x400192B")]
			Proto_CHECK,
			// Token: 0x0400192C RID: 6444
			[Token(Token = "0x400192C")]
			Proto_CLEAR,
			// Token: 0x0400192D RID: 6445
			[Token(Token = "0x400192D")]
			Proto_GAMEINFO,
			// Token: 0x0400192E RID: 6446
			[Token(Token = "0x400192E")]
			Proto_ROOMINFO
		}
	}
}
