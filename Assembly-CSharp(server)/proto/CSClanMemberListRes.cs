using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007DB RID: 2011
	[Token(Token = "0x20007DB")]
	[ProtoContract]
	public class CSClanMemberListRes
	{
		// Token: 0x060024EA RID: 9450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EA")]
		[Address(RVA = "0x21B0A4C", Offset = "0x21B0A4C", VA = "0x7BBC9B0A4C")]
		public CSClanMemberListRes()
		{
		}

		// Token: 0x04002664 RID: 9828
		[Token(Token = "0x4002664")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FB7C", Offset = "0x110FB7C")]
		public List<CSClanMemberRes> member_list;
	}
}
