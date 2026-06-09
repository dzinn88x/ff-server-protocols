using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AA0 RID: 2720
	[Token(Token = "0x2000AA0")]
	[ProtoContract]
	public class ExchangeStoreItemDesc
	{
		// Token: 0x060027AA RID: 10154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AA")]
		[Address(RVA = "0x21B9EDC", Offset = "0x21B9EDC", VA = "0x7BBC9B9EDC")]
		public ExchangeStoreItemDesc()
		{
		}

		// Token: 0x040032C9 RID: 13001
		[Token(Token = "0x40032C9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11255E4", Offset = "0x11255E4")]
		public uint store_id;

		// Token: 0x040032CA RID: 13002
		[Token(Token = "0x40032CA")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11255F8", Offset = "0x11255F8")]
		public uint commodity_id;

		// Token: 0x040032CB RID: 13003
		[Token(Token = "0x40032CB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112560C", Offset = "0x112560C")]
		public uint sort_id;

		// Token: 0x040032CC RID: 13004
		[Token(Token = "0x40032CC")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125620", Offset = "0x1125620")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125620", Offset = "0x1125620")]
		public string name;

		// Token: 0x040032CD RID: 13005
		[Token(Token = "0x40032CD")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125670", Offset = "0x1125670")]
		public uint item_id;

		// Token: 0x040032CE RID: 13006
		[Token(Token = "0x40032CE")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125684", Offset = "0x1125684")]
		public uint currency_id;

		// Token: 0x040032CF RID: 13007
		[Token(Token = "0x40032CF")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125698", Offset = "0x1125698")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125698", Offset = "0x1125698")]
		public string currency_name;

		// Token: 0x040032D0 RID: 13008
		[Token(Token = "0x40032D0")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11256E8", Offset = "0x11256E8")]
		public uint currency_price;

		// Token: 0x040032D1 RID: 13009
		[Token(Token = "0x40032D1")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11256FC", Offset = "0x11256FC")]
		public uint tag_type;

		// Token: 0x040032D2 RID: 13010
		[Token(Token = "0x40032D2")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125710", Offset = "0x1125710")]
		public uint tag_value;

		// Token: 0x040032D3 RID: 13011
		[Token(Token = "0x40032D3")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125724", Offset = "0x1125724")]
		public uint limited_purchase_times;

		// Token: 0x040032D4 RID: 13012
		[Token(Token = "0x40032D4")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125738", Offset = "0x1125738")]
		public uint purchase_times;

		// Token: 0x040032D5 RID: 13013
		[Token(Token = "0x40032D5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112574C", Offset = "0x112574C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112574C", Offset = "0x112574C")]
		public string added_time;

		// Token: 0x040032D6 RID: 13014
		[Token(Token = "0x40032D6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112579C", Offset = "0x112579C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112579C", Offset = "0x112579C")]
		public string expire_time;

		// Token: 0x040032D7 RID: 13015
		[Token(Token = "0x40032D7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11257EC", Offset = "0x11257EC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11257EC", Offset = "0x11257EC")]
		public string language;

		// Token: 0x040032D8 RID: 13016
		[Token(Token = "0x40032D8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112583C", Offset = "0x112583C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112583C", Offset = "0x112583C")]
		public string image_url;

		// Token: 0x040032D9 RID: 13017
		[Token(Token = "0x40032D9")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112588C", Offset = "0x112588C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112588C", Offset = "0x112588C")]
		public string real_image_url;

		// Token: 0x040032DA RID: 13018
		[Token(Token = "0x40032DA")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11258DC", Offset = "0x11258DC")]
		public uint gems_cost;

		// Token: 0x040032DB RID: 13019
		[Token(Token = "0x40032DB")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11258F0", Offset = "0x11258F0")]
		public uint min_clan_level;

		// Token: 0x040032DC RID: 13020
		[Token(Token = "0x40032DC")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125904", Offset = "0x1125904")]
		public uint award_time;

		// Token: 0x040032DD RID: 13021
		[Token(Token = "0x40032DD")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125918", Offset = "0x1125918")]
		public long expire_timestamp;
	}
}
