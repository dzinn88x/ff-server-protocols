using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007F4 RID: 2036
	[Token(Token = "0x20007F4")]
	[ProtoContract]
	public class ClanMemberListWithAccountInfo
	{
		// Token: 0x06002503 RID: 9475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002503")]
		[Address(RVA = "0x21B8878", Offset = "0x21B8878", VA = "0x7BBC9B8878")]
		public ClanMemberListWithAccountInfo()
		{
		}

		// Token: 0x040026C6 RID: 9926
		[Token(Token = "0x40026C6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11106A8", Offset = "0x11106A8")]
		public List<ClanMemberWithAccountInfo> member_list;
	}
}
