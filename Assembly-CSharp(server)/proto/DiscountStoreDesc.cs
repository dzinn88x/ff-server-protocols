using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AA9 RID: 2729
	[Token(Token = "0x2000AA9")]
	[ProtoContract]
	public class DiscountStoreDesc
	{
		// Token: 0x060027B3 RID: 10163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B3")]
		[Address(RVA = "0x21B96D0", Offset = "0x21B96D0", VA = "0x7BBC9B96D0")]
		public DiscountStoreDesc()
		{
		}

		// Token: 0x04003337 RID: 13111
		[Token(Token = "0x4003337")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126354", Offset = "0x1126354")]
		public uint store_id;

		// Token: 0x04003338 RID: 13112
		[Token(Token = "0x4003338")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126368", Offset = "0x1126368")]
		public uint loop_id;

		// Token: 0x04003339 RID: 13113
		[Token(Token = "0x4003339")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112637C", Offset = "0x112637C")]
		public uint refresh_id;

		// Token: 0x0400333A RID: 13114
		[Token(Token = "0x400333A")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126390", Offset = "0x1126390")]
		public uint item_id;

		// Token: 0x0400333B RID: 13115
		[Token(Token = "0x400333B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11263A4", Offset = "0x11263A4")]
		public uint coins_price;

		// Token: 0x0400333C RID: 13116
		[Token(Token = "0x400333C")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11263B8", Offset = "0x11263B8")]
		public uint gems_price;

		// Token: 0x0400333D RID: 13117
		[Token(Token = "0x400333D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11263CC", Offset = "0x11263CC")]
		public float discount_value;

		// Token: 0x0400333E RID: 13118
		[Token(Token = "0x400333E")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11263E0", Offset = "0x11263E0")]
		public uint limited_purchase_times;

		// Token: 0x0400333F RID: 13119
		[Token(Token = "0x400333F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11263F4", Offset = "0x11263F4")]
		public uint purchase_times;

		// Token: 0x04003340 RID: 13120
		[Token(Token = "0x4003340")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126408", Offset = "0x1126408")]
		public uint award_time;
	}
}
