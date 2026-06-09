using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007F5 RID: 2037
	[Token(Token = "0x20007F5")]
	[ProtoContract]
	public class ClanLeaderboardRes
	{
		// Token: 0x06002504 RID: 9476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002504")]
		[Address(RVA = "0x21B8770", Offset = "0x21B8770", VA = "0x7BBC9B8770")]
		public ClanLeaderboardRes()
		{
		}

		// Token: 0x040026C7 RID: 9927
		[Token(Token = "0x40026C7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11106BC", Offset = "0x11106BC")]
		public List<ClanLeaderboardItem> items;

		// Token: 0x040026C8 RID: 9928
		[Token(Token = "0x40026C8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11106D0", Offset = "0x11106D0")]
		public ClanLeaderboardItem self;

		// Token: 0x040026C9 RID: 9929
		[Token(Token = "0x40026C9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11106E4", Offset = "0x11106E4")]
		public uint leaderboard_size;
	}
}
