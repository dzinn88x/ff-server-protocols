using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009F7 RID: 2551
	[Token(Token = "0x20009F7")]
	[ProtoContract]
	public class ActivityDesc
	{
		// Token: 0x06002701 RID: 9985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002701")]
		[Address(RVA = "0x21AEC18", Offset = "0x21AEC18", VA = "0x7BBC9AEC18")]
		public ActivityDesc()
		{
		}

		// Token: 0x04002E28 RID: 11816
		[Token(Token = "0x4002E28")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C764", Offset = "0x111C764")]
		public uint group_id;

		// Token: 0x04002E29 RID: 11817
		[Token(Token = "0x4002E29")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C778", Offset = "0x111C778")]
		public uint activity_id;

		// Token: 0x04002E2A RID: 11818
		[Token(Token = "0x4002E2A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C78C", Offset = "0x111C78C")]
		public uint activity_type;

		// Token: 0x04002E2B RID: 11819
		[Token(Token = "0x4002E2B")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C7A0", Offset = "0x111C7A0")]
		public uint sort_id;

		// Token: 0x04002E2C RID: 11820
		[Token(Token = "0x4002E2C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C7B4", Offset = "0x111C7B4")]
		public uint is_process_show;

		// Token: 0x04002E2D RID: 11821
		[Token(Token = "0x4002E2D")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C7C8", Offset = "0x111C7C8")]
		public uint act_tag;

		// Token: 0x04002E2E RID: 11822
		[Token(Token = "0x4002E2E")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C7DC", Offset = "0x111C7DC")]
		public uint gos_pos;

		// Token: 0x04002E2F RID: 11823
		[Token(Token = "0x4002E2F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C7F0", Offset = "0x111C7F0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111C7F0", Offset = "0x111C7F0")]
		public string start_time;

		// Token: 0x04002E30 RID: 11824
		[Token(Token = "0x4002E30")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C840", Offset = "0x111C840")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111C840", Offset = "0x111C840")]
		public string end_time;

		// Token: 0x04002E31 RID: 11825
		[Token(Token = "0x4002E31")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C890", Offset = "0x111C890")]
		public EActivity.CircleType circle_type;

		// Token: 0x04002E32 RID: 11826
		[Token(Token = "0x4002E32")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C8A4", Offset = "0x111C8A4")]
		public EActivity.PreConditionType pre_cdt_type1;

		// Token: 0x04002E33 RID: 11827
		[Token(Token = "0x4002E33")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C8B8", Offset = "0x111C8B8")]
		public uint pre_cdt_value1;

		// Token: 0x04002E34 RID: 11828
		[Token(Token = "0x4002E34")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C8CC", Offset = "0x111C8CC")]
		public EActivity.PreConditionType pre_cdt_type2;

		// Token: 0x04002E35 RID: 11829
		[Token(Token = "0x4002E35")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C8E0", Offset = "0x111C8E0")]
		public uint pre_cdt_value2;

		// Token: 0x04002E36 RID: 11830
		[Token(Token = "0x4002E36")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C8F4", Offset = "0x111C8F4")]
		public EActivity.PreConditionType pre_cdt_type3;

		// Token: 0x04002E37 RID: 11831
		[Token(Token = "0x4002E37")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C908", Offset = "0x111C908")]
		public uint pre_cdt_value3;

		// Token: 0x04002E38 RID: 11832
		[Token(Token = "0x4002E38")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C91C", Offset = "0x111C91C")]
		public EActivity.ConditionType cdt_type;

		// Token: 0x04002E39 RID: 11833
		[Token(Token = "0x4002E39")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C930", Offset = "0x111C930")]
		public uint cdt_value;

		// Token: 0x04002E3A RID: 11834
		[Token(Token = "0x4002E3A")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C944", Offset = "0x111C944")]
		public List<AwardDesc> awards;

		// Token: 0x04002E3B RID: 11835
		[Token(Token = "0x4002E3B")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C958", Offset = "0x111C958")]
		public List<Item> exchange_items;

		// Token: 0x04002E3C RID: 11836
		[Token(Token = "0x4002E3C")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C96C", Offset = "0x111C96C")]
		public EActivity.PreConditionType pre_cdt_type4;

		// Token: 0x04002E3D RID: 11837
		[Token(Token = "0x4002E3D")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C980", Offset = "0x111C980")]
		public uint pre_cdt_value4;

		// Token: 0x04002E3E RID: 11838
		[Token(Token = "0x4002E3E")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C994", Offset = "0x111C994")]
		public EActivity.PreConditionType pre_cdt_type5;

		// Token: 0x04002E3F RID: 11839
		[Token(Token = "0x4002E3F")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C9A8", Offset = "0x111C9A8")]
		public uint pre_cdt_value5;

		// Token: 0x04002E40 RID: 11840
		[Token(Token = "0x4002E40")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C9BC", Offset = "0x111C9BC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111C9BC", Offset = "0x111C9BC")]
		public string show_time;

		// Token: 0x04002E41 RID: 11841
		[Token(Token = "0x4002E41")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CA0C", Offset = "0x111CA0C")]
		public uint table_type;

		// Token: 0x04002E42 RID: 11842
		[Token(Token = "0x4002E42")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CA20", Offset = "0x111CA20")]
		public uint pre_activity_id;

		// Token: 0x04002E43 RID: 11843
		[Token(Token = "0x4002E43")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CA34", Offset = "0x111CA34")]
		public uint settle_limit;

		// Token: 0x04002E44 RID: 11844
		[Token(Token = "0x4002E44")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CA48", Offset = "0x111CA48")]
		public uint affiliate_table;

		// Token: 0x04002E45 RID: 11845
		[Token(Token = "0x4002E45")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CA5C", Offset = "0x111CA5C")]
		public uint activity_class;

		// Token: 0x04002E46 RID: 11846
		[Token(Token = "0x4002E46")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CA70", Offset = "0x111CA70")]
		public long[] hint_reset_time;

		// Token: 0x04002E47 RID: 11847
		[Token(Token = "0x4002E47")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CAAC", Offset = "0x111CAAC")]
		public uint pre_cdt_gos_pos;

		// Token: 0x04002E48 RID: 11848
		[Token(Token = "0x4002E48")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CAC0", Offset = "0x111CAC0")]
		public uint[] pre_cdt_item_ids;

		// Token: 0x04002E49 RID: 11849
		[Token(Token = "0x4002E49")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CAFC", Offset = "0x111CAFC")]
		public uint min_level;

		// Token: 0x04002E4A RID: 11850
		[Token(Token = "0x4002E4A")]
		[FieldOffset(Offset = "0xC4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CB10", Offset = "0x111CB10")]
		public uint max_level;

		// Token: 0x04002E4B RID: 11851
		[Token(Token = "0x4002E4B")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CB24", Offset = "0x111CB24")]
		public EActivity.Platform platform;

		// Token: 0x04002E4C RID: 11852
		[Token(Token = "0x4002E4C")]
		[FieldOffset(Offset = "0xCC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CB38", Offset = "0x111CB38")]
		public uint pre_cdt_switch;

		// Token: 0x04002E4D RID: 11853
		[Token(Token = "0x4002E4D")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CB4C", Offset = "0x111CB4C")]
		public bool big_prize;

		// Token: 0x04002E4E RID: 11854
		[Token(Token = "0x4002E4E")]
		[FieldOffset(Offset = "0xD4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CB60", Offset = "0x111CB60")]
		public EActivity.SubType sub_type;

		// Token: 0x04002E4F RID: 11855
		[Token(Token = "0x4002E4F")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111CB74", Offset = "0x111CB74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111CB74", Offset = "0x111CB74")]
		public string stop_show_time;
	}
}
