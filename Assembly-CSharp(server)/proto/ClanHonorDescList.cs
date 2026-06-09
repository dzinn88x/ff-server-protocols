using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A3B RID: 2619
	[Token(Token = "0x2000A3B")]
	[ProtoContract]
	public class ClanHonorDescList
	{
		// Token: 0x06002745 RID: 10053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002745")]
		[Address(RVA = "0x21B85C4", Offset = "0x21B85C4", VA = "0x7BBC9B85C4")]
		public ClanHonorDescList()
		{
		}

		// Token: 0x04002FC8 RID: 12232
		[Token(Token = "0x4002FC8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11200BC", Offset = "0x11200BC")]
		public List<ClanHonorDesc> clan_honor_list;
	}
}
