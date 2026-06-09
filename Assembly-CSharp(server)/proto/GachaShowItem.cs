using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000871 RID: 2161
	[Token(Token = "0x2000871")]
	[ProtoContract]
	public class GachaShowItem
	{
		// Token: 0x0600257F RID: 9599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257F")]
		[Address(RVA = "0x21BA5CC", Offset = "0x21BA5CC", VA = "0x7BBC9BA5CC")]
		public GachaShowItem()
		{
		}

		// Token: 0x0400287C RID: 10364
		[Token(Token = "0x400287C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11131B4", Offset = "0x11131B4")]
		public uint item_id;

		// Token: 0x0400287D RID: 10365
		[Token(Token = "0x400287D")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11131C8", Offset = "0x11131C8")]
		public bool is_show;

		// Token: 0x0400287E RID: 10366
		[Token(Token = "0x400287E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11131DC", Offset = "0x11131DC")]
		public uint repeated_item_id;

		// Token: 0x0400287F RID: 10367
		[Token(Token = "0x400287F")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11131F0", Offset = "0x11131F0")]
		public uint repeated_item_num;

		// Token: 0x04002880 RID: 10368
		[Token(Token = "0x4002880")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113204", Offset = "0x1113204")]
		public EInventory.AwardType item_type;

		// Token: 0x04002881 RID: 10369
		[Token(Token = "0x4002881")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113218", Offset = "0x1113218")]
		public uint item_num;

		// Token: 0x04002882 RID: 10370
		[Token(Token = "0x4002882")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111322C", Offset = "0x111322C")]
		public uint reward_level;

		// Token: 0x04002883 RID: 10371
		[Token(Token = "0x4002883")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113240", Offset = "0x1113240")]
		public uint turntable_props_type;

		// Token: 0x04002884 RID: 10372
		[Token(Token = "0x4002884")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113254", Offset = "0x1113254")]
		public float drop_up_ratio;

		// Token: 0x04002885 RID: 10373
		[Token(Token = "0x4002885")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113268", Offset = "0x1113268")]
		public bool is_drop_up_buffed;

		// Token: 0x04002886 RID: 10374
		[Token(Token = "0x4002886")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111327C", Offset = "0x111327C")]
		public uint id;

		// Token: 0x04002887 RID: 10375
		[Token(Token = "0x4002887")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113290", Offset = "0x1113290")]
		public uint item_duration;

		// Token: 0x04002888 RID: 10376
		[Token(Token = "0x4002888")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11132A4", Offset = "0x11132A4")]
		public bool token_flag;

		// Token: 0x04002889 RID: 10377
		[Token(Token = "0x4002889")]
		[FieldOffset(Offset = "0x41")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11132B8", Offset = "0x11132B8")]
		public bool un_quick_selection;
	}
}
