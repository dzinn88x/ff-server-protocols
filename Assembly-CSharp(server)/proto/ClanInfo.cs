using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007F2 RID: 2034
	[Token(Token = "0x20007F2")]
	[ProtoContract]
	public class ClanInfo
	{
		// Token: 0x06002501 RID: 9473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002501")]
		[Address(RVA = "0x21B869C", Offset = "0x21B869C", VA = "0x7BBC9B869C")]
		public ClanInfo()
		{
		}

		// Token: 0x040026A7 RID: 9895
		[Token(Token = "0x40026A7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111025C", Offset = "0x111025C")]
		public ulong clan_id;

		// Token: 0x040026A8 RID: 9896
		[Token(Token = "0x40026A8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110270", Offset = "0x1110270")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1110270", Offset = "0x1110270")]
		public string clan_name;

		// Token: 0x040026A9 RID: 9897
		[Token(Token = "0x40026A9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11102C0", Offset = "0x11102C0")]
		public ulong create_at;

		// Token: 0x040026AA RID: 9898
		[Token(Token = "0x40026AA")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11102D4", Offset = "0x11102D4")]
		public ulong captain_id;

		// Token: 0x040026AB RID: 9899
		[Token(Token = "0x40026AB")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11102E8", Offset = "0x11102E8")]
		public uint clan_level;

		// Token: 0x040026AC RID: 9900
		[Token(Token = "0x40026AC")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11102FC", Offset = "0x11102FC")]
		public uint capacity;

		// Token: 0x040026AD RID: 9901
		[Token(Token = "0x40026AD")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110310", Offset = "0x1110310")]
		public uint member_num;

		// Token: 0x040026AE RID: 9902
		[Token(Token = "0x40026AE")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110324", Offset = "0x1110324")]
		public uint entry_level;

		// Token: 0x040026AF RID: 9903
		[Token(Token = "0x40026AF")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110338", Offset = "0x1110338")]
		public uint entry_type;

		// Token: 0x040026B0 RID: 9904
		[Token(Token = "0x40026B0")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111034C", Offset = "0x111034C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111034C", Offset = "0x111034C")]
		public string clan_logo;

		// Token: 0x040026B1 RID: 9905
		[Token(Token = "0x40026B1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111039C", Offset = "0x111039C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111039C", Offset = "0x111039C")]
		public string announcement;

		// Token: 0x040026B2 RID: 9906
		[Token(Token = "0x40026B2")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11103EC", Offset = "0x11103EC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11103EC", Offset = "0x11103EC")]
		public string slogan;

		// Token: 0x040026B3 RID: 9907
		[Token(Token = "0x40026B3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111043C", Offset = "0x111043C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111043C", Offset = "0x111043C")]
		public string region;

		// Token: 0x040026B4 RID: 9908
		[Token(Token = "0x40026B4")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111048C", Offset = "0x111048C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111048C", Offset = "0x111048C")]
		public string misc;

		// Token: 0x040026B5 RID: 9909
		[Token(Token = "0x40026B5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11104DC", Offset = "0x11104DC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11104DC", Offset = "0x11104DC")]
		public string vice_captains;

		// Token: 0x040026B6 RID: 9910
		[Token(Token = "0x40026B6")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111052C", Offset = "0x111052C")]
		public uint honor_point;

		// Token: 0x040026B7 RID: 9911
		[Token(Token = "0x40026B7")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110540", Offset = "0x1110540")]
		public uint race_point;

		// Token: 0x040026B8 RID: 9912
		[Token(Token = "0x40026B8")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110554", Offset = "0x1110554")]
		public ulong last_gain_rp_at;

		// Token: 0x040026B9 RID: 9913
		[Token(Token = "0x40026B9")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110568", Offset = "0x1110568")]
		public ulong claim_rp_award_at;

		// Token: 0x040026BA RID: 9914
		[Token(Token = "0x40026BA")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111057C", Offset = "0x111057C")]
		public uint area_id;

		// Token: 0x040026BB RID: 9915
		[Token(Token = "0x40026BB")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110590", Offset = "0x1110590")]
		public uint play_style;

		// Token: 0x040026BC RID: 9916
		[Token(Token = "0x40026BC")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11105A4", Offset = "0x11105A4")]
		public uint entry_rank;

		// Token: 0x040026BD RID: 9917
		[Token(Token = "0x40026BD")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11105B8", Offset = "0x11105B8")]
		public ulong deputy_captain;
	}
}
