using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007D0 RID: 2000
	[Token(Token = "0x20007D0")]
	[ProtoContract]
	public class ClientActivityDesc
	{
		// Token: 0x060024DF RID: 9439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DF")]
		[Address(RVA = "0x21B8B34", Offset = "0x21B8B34", VA = "0x7BBC9B8B34")]
		public ClientActivityDesc()
		{
		}

		// Token: 0x04002637 RID: 9783
		[Token(Token = "0x4002637")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F528", Offset = "0x110F528")]
		public uint group_id;

		// Token: 0x04002638 RID: 9784
		[Token(Token = "0x4002638")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F53C", Offset = "0x110F53C")]
		public uint activity_id;

		// Token: 0x04002639 RID: 9785
		[Token(Token = "0x4002639")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F550", Offset = "0x110F550")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F550", Offset = "0x110F550")]
		public string act_title;

		// Token: 0x0400263A RID: 9786
		[Token(Token = "0x400263A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F5A0", Offset = "0x110F5A0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F5A0", Offset = "0x110F5A0")]
		public string act_text;

		// Token: 0x0400263B RID: 9787
		[Token(Token = "0x400263B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F5F0", Offset = "0x110F5F0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F5F0", Offset = "0x110F5F0")]
		public string award_context;

		// Token: 0x0400263C RID: 9788
		[Token(Token = "0x400263C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F640", Offset = "0x110F640")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F640", Offset = "0x110F640")]
		public string image_url;

		// Token: 0x0400263D RID: 9789
		[Token(Token = "0x400263D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F690", Offset = "0x110F690")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F690", Offset = "0x110F690")]
		public string image_url_for_lobby;

		// Token: 0x0400263E RID: 9790
		[Token(Token = "0x400263E")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F6E0", Offset = "0x110F6E0")]
		public uint activity_type;

		// Token: 0x0400263F RID: 9791
		[Token(Token = "0x400263F")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F6F4", Offset = "0x110F6F4")]
		public uint sort_id;

		// Token: 0x04002640 RID: 9792
		[Token(Token = "0x4002640")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F708", Offset = "0x110F708")]
		public uint is_process_show;

		// Token: 0x04002641 RID: 9793
		[Token(Token = "0x4002641")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F71C", Offset = "0x110F71C")]
		public uint act_tag;

		// Token: 0x04002642 RID: 9794
		[Token(Token = "0x4002642")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F730", Offset = "0x110F730")]
		public uint gos_pos;

		// Token: 0x04002643 RID: 9795
		[Token(Token = "0x4002643")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F744", Offset = "0x110F744")]
		public long start_time;

		// Token: 0x04002644 RID: 9796
		[Token(Token = "0x4002644")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F758", Offset = "0x110F758")]
		public long end_time;

		// Token: 0x04002645 RID: 9797
		[Token(Token = "0x4002645")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F76C", Offset = "0x110F76C")]
		public uint cdt_value;

		// Token: 0x04002646 RID: 9798
		[Token(Token = "0x4002646")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F780", Offset = "0x110F780")]
		public List<AwardDesc> awards;

		// Token: 0x04002647 RID: 9799
		[Token(Token = "0x4002647")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F794", Offset = "0x110F794")]
		public List<Item> exchange_items;

		// Token: 0x04002648 RID: 9800
		[Token(Token = "0x4002648")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F7A8", Offset = "0x110F7A8")]
		public long show_time;

		// Token: 0x04002649 RID: 9801
		[Token(Token = "0x4002649")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F7BC", Offset = "0x110F7BC")]
		public uint table_type;

		// Token: 0x0400264A RID: 9802
		[Token(Token = "0x400264A")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F7D0", Offset = "0x110F7D0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F7D0", Offset = "0x110F7D0")]
		public string original_start_time;

		// Token: 0x0400264B RID: 9803
		[Token(Token = "0x400264B")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F820", Offset = "0x110F820")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F820", Offset = "0x110F820")]
		public string original_end_time;

		// Token: 0x0400264C RID: 9804
		[Token(Token = "0x400264C")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F870", Offset = "0x110F870")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F870", Offset = "0x110F870")]
		public string image_url_for_top_up;

		// Token: 0x0400264D RID: 9805
		[Token(Token = "0x400264D")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F8C0", Offset = "0x110F8C0")]
		public uint affiliate_table;

		// Token: 0x0400264E RID: 9806
		[Token(Token = "0x400264E")]
		[FieldOffset(Offset = "0xAC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F8D4", Offset = "0x110F8D4")]
		public uint activity_class;

		// Token: 0x0400264F RID: 9807
		[Token(Token = "0x400264F")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F8E8", Offset = "0x110F8E8")]
		public long[] hint_reset_time;

		// Token: 0x04002650 RID: 9808
		[Token(Token = "0x4002650")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F924", Offset = "0x110F924")]
		public uint pre_cdt_gos_pos;

		// Token: 0x04002651 RID: 9809
		[Token(Token = "0x4002651")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F938", Offset = "0x110F938")]
		public uint[] pre_cdt_item_ids;

		// Token: 0x04002652 RID: 9810
		[Token(Token = "0x4002652")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F974", Offset = "0x110F974")]
		public uint min_level;

		// Token: 0x04002653 RID: 9811
		[Token(Token = "0x4002653")]
		[FieldOffset(Offset = "0xCC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F988", Offset = "0x110F988")]
		public uint max_level;

		// Token: 0x04002654 RID: 9812
		[Token(Token = "0x4002654")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F99C", Offset = "0x110F99C")]
		public bool big_prize;

		// Token: 0x04002655 RID: 9813
		[Token(Token = "0x4002655")]
		[FieldOffset(Offset = "0xD4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F9B0", Offset = "0x110F9B0")]
		public EActivity.SubType sub_type;

		// Token: 0x04002656 RID: 9814
		[Token(Token = "0x4002656")]
		[FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F9C4", Offset = "0x110F9C4")]
		public long stop_show_time;
	}
}
