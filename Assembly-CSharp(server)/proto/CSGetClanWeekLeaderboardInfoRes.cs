using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007EB RID: 2027
	[Token(Token = "0x20007EB")]
	[ProtoContract]
	public class CSGetClanWeekLeaderboardInfoRes
	{
		// Token: 0x060024FA RID: 9466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FA")]
		[Address(RVA = "0x21B2D1C", Offset = "0x21B2D1C", VA = "0x7BBC9B2D1C")]
		public CSGetClanWeekLeaderboardInfoRes()
		{
		}

		// Token: 0x0400268D RID: 9869
		[Token(Token = "0x400268D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110054", Offset = "0x1110054")]
		public long main_key;

		// Token: 0x0400268E RID: 9870
		[Token(Token = "0x400268E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110068", Offset = "0x1110068")]
		public uint next_refresh_time;
	}
}
