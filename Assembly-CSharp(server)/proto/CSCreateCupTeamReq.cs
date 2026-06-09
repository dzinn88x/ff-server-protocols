using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000744 RID: 1860
	[Token(Token = "0x2000744")]
	[ProtoContract]
	public class CSCreateCupTeamReq
	{
		// Token: 0x06002451 RID: 9297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002451")]
		[Address(RVA = "0x21B0CF0", Offset = "0x21B0CF0", VA = "0x7BBC9B0CF0")]
		public CSCreateCupTeamReq()
		{
		}

		// Token: 0x040024C8 RID: 9416
		[Token(Token = "0x40024C8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CD3C", Offset = "0x110CD3C")]
		public uint cup_type;

		// Token: 0x040024C9 RID: 9417
		[Token(Token = "0x40024C9")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CD50", Offset = "0x110CD50")]
		public uint cup_id;

		// Token: 0x040024CA RID: 9418
		[Token(Token = "0x40024CA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110CD64", Offset = "0x110CD64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CD64", Offset = "0x110CD64")]
		public string team_name;

		// Token: 0x040024CB RID: 9419
		[Token(Token = "0x40024CB")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CDB4", Offset = "0x110CDB4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110CDB4", Offset = "0x110CDB4")]
		public string country_or_area;

		// Token: 0x040024CC RID: 9420
		[Token(Token = "0x40024CC")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CE04", Offset = "0x110CE04")]
		public uint head_pic;

		// Token: 0x040024CD RID: 9421
		[Token(Token = "0x40024CD")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CE18", Offset = "0x110CE18")]
		public uint banner_id;
	}
}
