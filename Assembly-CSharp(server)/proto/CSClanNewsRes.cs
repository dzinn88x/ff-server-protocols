using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007F7 RID: 2039
	[Token(Token = "0x20007F7")]
	[ProtoContract]
	public class CSClanNewsRes
	{
		// Token: 0x06002506 RID: 9478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002506")]
		[Address(RVA = "0x21B0B24", Offset = "0x21B0B24", VA = "0x7BBC9B0B24")]
		public CSClanNewsRes()
		{
		}

		// Token: 0x040026CB RID: 9931
		[Token(Token = "0x40026CB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111070C", Offset = "0x111070C")]
		public List<ClanNews> news;
	}
}
