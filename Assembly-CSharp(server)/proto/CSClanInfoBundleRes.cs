using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007D9 RID: 2009
	[Token(Token = "0x20007D9")]
	[ProtoContract]
	public class CSClanInfoBundleRes
	{
		// Token: 0x060024E8 RID: 9448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E8")]
		[Address(RVA = "0x21B09D0", Offset = "0x21B09D0", VA = "0x7BBC9B09D0")]
		public CSClanInfoBundleRes()
		{
		}

		// Token: 0x04002661 RID: 9825
		[Token(Token = "0x4002661")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FB40", Offset = "0x110FB40")]
		public List<ClanInfo> infos;
	}
}
