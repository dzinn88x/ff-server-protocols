using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006F4 RID: 1780
	[Token(Token = "0x20006F4")]
	[ProtoContract]
	public class MatchAccountStats
	{
		// Token: 0x06002402 RID: 9218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002402")]
		[Address(RVA = "0x21BC4FC", Offset = "0x21BC4FC", VA = "0x7BBC9BC4FC")]
		public MatchAccountStats()
		{
		}

		// Token: 0x040022BC RID: 8892
		[Token(Token = "0x40022BC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109E70", Offset = "0x1109E70")]
		public ulong match_id;

		// Token: 0x040022BD RID: 8893
		[Token(Token = "0x40022BD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109E84", Offset = "0x1109E84")]
		public ulong account_id;

		// Token: 0x040022BE RID: 8894
		[Token(Token = "0x40022BE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109E98", Offset = "0x1109E98")]
		public uint create_time;

		// Token: 0x040022BF RID: 8895
		[Token(Token = "0x40022BF")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109EAC", Offset = "0x1109EAC")]
		public uint end_time;

		// Token: 0x040022C0 RID: 8896
		[Token(Token = "0x40022C0")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109EC0", Offset = "0x1109EC0")]
		public MatchIncome income;

		// Token: 0x040022C1 RID: 8897
		[Token(Token = "0x40022C1")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109ED4", Offset = "0x1109ED4")]
		public MatchStats stats;
	}
}
