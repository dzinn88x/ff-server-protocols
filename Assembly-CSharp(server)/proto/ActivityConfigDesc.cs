using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AF6 RID: 2806
	[Token(Token = "0x2000AF6")]
	[ProtoContract]
	public class ActivityConfigDesc
	{
		// Token: 0x060027FE RID: 10238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FE")]
		[Address(RVA = "0x21AEB5C", Offset = "0x21AEB5C", VA = "0x7BBC9AEB5C")]
		public ActivityConfigDesc()
		{
		}

		// Token: 0x040034E2 RID: 13538
		[Token(Token = "0x40034E2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112966C", Offset = "0x112966C")]
		public uint activity_id;

		// Token: 0x040034E3 RID: 13539
		[Token(Token = "0x40034E3")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129680", Offset = "0x1129680")]
		public uint activity_type;

		// Token: 0x040034E4 RID: 13540
		[Token(Token = "0x40034E4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1129694", Offset = "0x1129694")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129694", Offset = "0x1129694")]
		public string start_time;

		// Token: 0x040034E5 RID: 13541
		[Token(Token = "0x40034E5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11296E4", Offset = "0x11296E4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11296E4", Offset = "0x11296E4")]
		public string end_time;

		// Token: 0x040034E6 RID: 13542
		[Token(Token = "0x40034E6")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129734", Offset = "0x1129734")]
		public uint circle_type;

		// Token: 0x040034E7 RID: 13543
		[Token(Token = "0x40034E7")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129748", Offset = "0x1129748")]
		public uint[] match_modes;

		// Token: 0x040034E8 RID: 13544
		[Token(Token = "0x40034E8")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129784", Offset = "0x1129784")]
		public uint process_num;

		// Token: 0x040034E9 RID: 13545
		[Token(Token = "0x40034E9")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129798", Offset = "0x1129798")]
		public uint award_id;

		// Token: 0x040034EA RID: 13546
		[Token(Token = "0x40034EA")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11297AC", Offset = "0x11297AC")]
		public uint award_num;

		// Token: 0x040034EB RID: 13547
		[Token(Token = "0x40034EB")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11297C0", Offset = "0x11297C0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11297C0", Offset = "0x11297C0")]
		public string cdn_url1;

		// Token: 0x040034EC RID: 13548
		[Token(Token = "0x40034EC")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129810", Offset = "0x1129810")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1129810", Offset = "0x1129810")]
		public string cdn_url2;

		// Token: 0x040034ED RID: 13549
		[Token(Token = "0x40034ED")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129860", Offset = "0x1129860")]
		public uint expire_time;
	}
}
