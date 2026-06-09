using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A7A RID: 2682
	[Token(Token = "0x2000A7A")]
	[ProtoContract]
	public class EventSettingDesc
	{
		// Token: 0x06002784 RID: 10116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002784")]
		[Address(RVA = "0x21B9C84", Offset = "0x21B9C84", VA = "0x7BBC9B9C84")]
		public EventSettingDesc()
		{
		}

		// Token: 0x04003129 RID: 12585
		[Token(Token = "0x4003129")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122588", Offset = "0x1122588")]
		public uint ep_event_id;

		// Token: 0x0400312A RID: 12586
		[Token(Token = "0x400312A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112259C", Offset = "0x112259C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112259C", Offset = "0x112259C")]
		public string start_time;

		// Token: 0x0400312B RID: 12587
		[Token(Token = "0x400312B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11225EC", Offset = "0x11225EC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11225EC", Offset = "0x11225EC")]
		public string end_time;

		// Token: 0x0400312C RID: 12588
		[Token(Token = "0x400312C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112263C", Offset = "0x112263C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112263C", Offset = "0x112263C")]
		public string ep_event_name;

		// Token: 0x0400312D RID: 12589
		[Token(Token = "0x400312D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112268C", Offset = "0x112268C")]
		public uint ep_badge;

		// Token: 0x0400312E RID: 12590
		[Token(Token = "0x400312E")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11226A0", Offset = "0x11226A0")]
		public uint gold_limit_improved;

		// Token: 0x0400312F RID: 12591
		[Token(Token = "0x400312F")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11226B4", Offset = "0x11226B4")]
		public uint fp_challenge;

		// Token: 0x04003130 RID: 12592
		[Token(Token = "0x4003130")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11226C8", Offset = "0x11226C8")]
		public long start_timestamp;

		// Token: 0x04003131 RID: 12593
		[Token(Token = "0x4003131")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11226DC", Offset = "0x11226DC")]
		public long end_timestamp;

		// Token: 0x04003132 RID: 12594
		[Token(Token = "0x4003132")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11226F0", Offset = "0x11226F0")]
		public uint completion_per_round;

		// Token: 0x04003133 RID: 12595
		[Token(Token = "0x4003133")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122704", Offset = "0x1122704")]
		public uint completion_per_day;
	}
}
