using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006E2 RID: 1762
	[Token(Token = "0x20006E2")]
	[ProtoContract]
	public class AccountInfoBasicBundleRes
	{
		// Token: 0x060023F0 RID: 9200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F0")]
		[Address(RVA = "0x21AE4A0", Offset = "0x21AE4A0", VA = "0x7BBC9AE4A0")]
		public AccountInfoBasicBundleRes()
		{
		}

		// Token: 0x04002296 RID: 8854
		[Token(Token = "0x4002296")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109970", Offset = "0x1109970")]
		public List<AccountInfoBasic> infos;
	}
}
