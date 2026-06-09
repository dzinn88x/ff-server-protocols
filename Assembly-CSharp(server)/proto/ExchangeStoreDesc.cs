using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A9F RID: 2719
	[Token(Token = "0x2000A9F")]
	[ProtoContract]
	public class ExchangeStoreDesc
	{
		// Token: 0x060027A9 RID: 10153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A9")]
		[Address(RVA = "0x21B9E78", Offset = "0x21B9E78", VA = "0x7BBC9B9E78")]
		public ExchangeStoreDesc()
		{
		}

		// Token: 0x040032BF RID: 12991
		[Token(Token = "0x40032BF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112542C", Offset = "0x112542C")]
		public uint store_id;

		// Token: 0x040032C0 RID: 12992
		[Token(Token = "0x40032C0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125440", Offset = "0x1125440")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125440", Offset = "0x1125440")]
		public string store_name;

		// Token: 0x040032C1 RID: 12993
		[Token(Token = "0x40032C1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125490", Offset = "0x1125490")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125490", Offset = "0x1125490")]
		public string open_time;

		// Token: 0x040032C2 RID: 12994
		[Token(Token = "0x40032C2")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11254E0", Offset = "0x11254E0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11254E0", Offset = "0x11254E0")]
		public string close_time;

		// Token: 0x040032C3 RID: 12995
		[Token(Token = "0x40032C3")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125530", Offset = "0x1125530")]
		public uint open_time_stamp;

		// Token: 0x040032C4 RID: 12996
		[Token(Token = "0x40032C4")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125544", Offset = "0x1125544")]
		public uint close_time_stamp;

		// Token: 0x040032C5 RID: 12997
		[Token(Token = "0x40032C5")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125558", Offset = "0x1125558")]
		public bool is_show_time;

		// Token: 0x040032C6 RID: 12998
		[Token(Token = "0x40032C6")]
		[FieldOffset(Offset = "0x39")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112556C", Offset = "0x112556C")]
		public bool check_bundle_switch;

		// Token: 0x040032C7 RID: 12999
		[Token(Token = "0x40032C7")]
		[FieldOffset(Offset = "0x3A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125580", Offset = "0x1125580")]
		public bool need_clan;

		// Token: 0x040032C8 RID: 13000
		[Token(Token = "0x40032C8")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125594", Offset = "0x1125594")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125594", Offset = "0x1125594")]
		public string token_box;
	}
}
