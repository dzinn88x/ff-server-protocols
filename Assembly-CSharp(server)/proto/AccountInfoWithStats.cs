using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005E7 RID: 1511
	[Token(Token = "0x20005E7")]
	[ProtoContract]
	public class AccountInfoWithStats
	{
		// Token: 0x06002367 RID: 9063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002367")]
		[Address(RVA = "0x21AE590", Offset = "0x21AE590", VA = "0x7BBC9AE590")]
		public AccountInfoWithStats()
		{
		}

		// Token: 0x04001E02 RID: 7682
		[Token(Token = "0x4001E02")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105D98", Offset = "0x1105D98")]
		public ulong account_id;

		// Token: 0x04001E03 RID: 7683
		[Token(Token = "0x4001E03")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105DAC", Offset = "0x1105DAC")]
		public uint games_played;

		// Token: 0x04001E04 RID: 7684
		[Token(Token = "0x4001E04")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105DC0", Offset = "0x1105DC0")]
		public uint wins;

		// Token: 0x04001E05 RID: 7685
		[Token(Token = "0x4001E05")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105DD4", Offset = "0x1105DD4")]
		public uint kills;

		// Token: 0x04001E06 RID: 7686
		[Token(Token = "0x4001E06")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105DE8", Offset = "0x1105DE8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105DE8", Offset = "0x1105DE8")]
		public string detailed_stats;

		// Token: 0x04001E07 RID: 7687
		[Token(Token = "0x4001E07")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105E38", Offset = "0x1105E38")]
		public bool is_cs_ranking;
	}
}
