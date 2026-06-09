using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B0D RID: 2829
	[Token(Token = "0x2000B0D")]
	[ProtoContract]
	public class BigEventProcessSettingDesc
	{
		// Token: 0x06002815 RID: 10261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002815")]
		[Address(RVA = "0x21AF93C", Offset = "0x21AF93C", VA = "0x7BBC9AF93C")]
		public BigEventProcessSettingDesc()
		{
		}

		// Token: 0x0400356E RID: 13678
		[Token(Token = "0x400356E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A918", Offset = "0x112A918")]
		public ELimitedEvent.EventID event_id;

		// Token: 0x0400356F RID: 13679
		[Token(Token = "0x400356F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A92C", Offset = "0x112A92C")]
		public ELimitedEvent.ProcessType process_type;

		// Token: 0x04003570 RID: 13680
		[Token(Token = "0x4003570")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A940", Offset = "0x112A940")]
		public uint process_id;

		// Token: 0x04003571 RID: 13681
		[Token(Token = "0x4003571")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A954", Offset = "0x112A954")]
		public ulong start_value;

		// Token: 0x04003572 RID: 13682
		[Token(Token = "0x4003572")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A968", Offset = "0x112A968")]
		public ulong end_value;

		// Token: 0x04003573 RID: 13683
		[Token(Token = "0x4003573")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A97C", Offset = "0x112A97C")]
		public uint time_span;

		// Token: 0x04003574 RID: 13684
		[Token(Token = "0x4003574")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A990", Offset = "0x112A990")]
		public uint lower_bound;

		// Token: 0x04003575 RID: 13685
		[Token(Token = "0x4003575")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A9A4", Offset = "0x112A9A4")]
		public uint upper_bound;
	}
}
