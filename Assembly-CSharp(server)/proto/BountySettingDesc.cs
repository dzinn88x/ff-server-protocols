using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B11 RID: 2833
	[Token(Token = "0x2000B11")]
	[ProtoContract]
	public class BountySettingDesc
	{
		// Token: 0x06002819 RID: 10265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002819")]
		[Address(RVA = "0x21AFE90", Offset = "0x21AFE90", VA = "0x7BBC9AFE90")]
		public BountySettingDesc()
		{
		}

		// Token: 0x04003591 RID: 13713
		[Token(Token = "0x4003591")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AEE0", Offset = "0x112AEE0")]
		public uint model_id1;

		// Token: 0x04003592 RID: 13714
		[Token(Token = "0x4003592")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AEF4", Offset = "0x112AEF4")]
		public uint model_show_timestamp1;

		// Token: 0x04003593 RID: 13715
		[Token(Token = "0x4003593")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AF08", Offset = "0x112AF08")]
		public uint model_start_timestamp1;

		// Token: 0x04003594 RID: 13716
		[Token(Token = "0x4003594")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AF1C", Offset = "0x112AF1C")]
		public uint model_end_timestamp1;

		// Token: 0x04003595 RID: 13717
		[Token(Token = "0x4003595")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AF30", Offset = "0x112AF30")]
		public uint model_id2;

		// Token: 0x04003596 RID: 13718
		[Token(Token = "0x4003596")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AF44", Offset = "0x112AF44")]
		public uint model_show_timestamp2;

		// Token: 0x04003597 RID: 13719
		[Token(Token = "0x4003597")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AF58", Offset = "0x112AF58")]
		public uint model_start_timestamp2;

		// Token: 0x04003598 RID: 13720
		[Token(Token = "0x4003598")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AF6C", Offset = "0x112AF6C")]
		public uint model_end_timestamp2;

		// Token: 0x04003599 RID: 13721
		[Token(Token = "0x4003599")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AF80", Offset = "0x112AF80")]
		public uint web_event_show_timestamp;

		// Token: 0x0400359A RID: 13722
		[Token(Token = "0x400359A")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AF94", Offset = "0x112AF94")]
		public uint web_event_start_timestamp;

		// Token: 0x0400359B RID: 13723
		[Token(Token = "0x400359B")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AFA8", Offset = "0x112AFA8")]
		public uint web_event_end_timestamp;

		// Token: 0x0400359C RID: 13724
		[Token(Token = "0x400359C")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AFBC", Offset = "0x112AFBC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112AFBC", Offset = "0x112AFBC")]
		public string web_event_url;

		// Token: 0x0400359D RID: 13725
		[Token(Token = "0x400359D")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B00C", Offset = "0x112B00C")]
		public uint purchase_show_timestamp;

		// Token: 0x0400359E RID: 13726
		[Token(Token = "0x400359E")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B020", Offset = "0x112B020")]
		public uint purchase_start_timestamp;

		// Token: 0x0400359F RID: 13727
		[Token(Token = "0x400359F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B034", Offset = "0x112B034")]
		public uint purchase_end_timestamp;

		// Token: 0x040035A0 RID: 13728
		[Token(Token = "0x40035A0")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B048", Offset = "0x112B048")]
		public uint calc_start_timestamp;

		// Token: 0x040035A1 RID: 13729
		[Token(Token = "0x40035A1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B05C", Offset = "0x112B05C")]
		public uint token_id;

		// Token: 0x040035A2 RID: 13730
		[Token(Token = "0x40035A2")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B070", Offset = "0x112B070")]
		public uint process_id;

		// Token: 0x040035A3 RID: 13731
		[Token(Token = "0x40035A3")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B084", Offset = "0x112B084")]
		public uint warm_up_start_timestamp;

		// Token: 0x040035A4 RID: 13732
		[Token(Token = "0x40035A4")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B098", Offset = "0x112B098")]
		public bool task_switch;

		// Token: 0x040035A5 RID: 13733
		[Token(Token = "0x40035A5")]
		[FieldOffset(Offset = "0x65")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B0AC", Offset = "0x112B0AC")]
		public bool store_switch;

		// Token: 0x040035A6 RID: 13734
		[Token(Token = "0x40035A6")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B0C0", Offset = "0x112B0C0")]
		public uint master_id;

		// Token: 0x040035A7 RID: 13735
		[Token(Token = "0x40035A7")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B0D4", Offset = "0x112B0D4")]
		public uint nightmare_id;

		// Token: 0x040035A8 RID: 13736
		[Token(Token = "0x40035A8")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112B0E8", Offset = "0x112B0E8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B0E8", Offset = "0x112B0E8")]
		public string before_key;

		// Token: 0x040035A9 RID: 13737
		[Token(Token = "0x40035A9")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B138", Offset = "0x112B138")]
		public uint shop_gopos;

		// Token: 0x040035AA RID: 13738
		[Token(Token = "0x40035AA")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B14C", Offset = "0x112B14C")]
		public uint subshop_gopos;

		// Token: 0x040035AB RID: 13739
		[Token(Token = "0x40035AB")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112B160", Offset = "0x112B160")]
		public uint bounty_show_end_timestamp;
	}
}
