using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007F3 RID: 2035
	[Token(Token = "0x20007F3")]
	[ProtoContract]
	public class ClanMemberWithAccountInfo
	{
		// Token: 0x06002502 RID: 9474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002502")]
		[Address(RVA = "0x21B88EC", Offset = "0x21B88EC", VA = "0x7BBC9B88EC")]
		public ClanMemberWithAccountInfo()
		{
		}

		// Token: 0x040026BE RID: 9918
		[Token(Token = "0x40026BE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11105CC", Offset = "0x11105CC")]
		public AccountInfoBasic basic_info;

		// Token: 0x040026BF RID: 9919
		[Token(Token = "0x40026BF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11105E0", Offset = "0x11105E0")]
		public ulong clan_id;

		// Token: 0x040026C0 RID: 9920
		[Token(Token = "0x40026C0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11105F4", Offset = "0x11105F4")]
		public uint member_type;

		// Token: 0x040026C1 RID: 9921
		[Token(Token = "0x40026C1")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110608", Offset = "0x1110608")]
		public ulong join_at;

		// Token: 0x040026C2 RID: 9922
		[Token(Token = "0x40026C2")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111061C", Offset = "0x111061C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111061C", Offset = "0x111061C")]
		public string region;

		// Token: 0x040026C3 RID: 9923
		[Token(Token = "0x40026C3")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111066C", Offset = "0x111066C")]
		public uint honor_point;

		// Token: 0x040026C4 RID: 9924
		[Token(Token = "0x40026C4")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110680", Offset = "0x1110680")]
		public uint race_point;

		// Token: 0x040026C5 RID: 9925
		[Token(Token = "0x40026C5")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110694", Offset = "0x1110694")]
		public ulong last_gain_rp_at;
	}
}
