using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B0E RID: 2830
	[Token(Token = "0x2000B0E")]
	[ProtoContract]
	public class BigEventEntryDesc
	{
		// Token: 0x06002816 RID: 10262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002816")]
		[Address(RVA = "0x21AF870", Offset = "0x21AF870", VA = "0x7BBC9AF870")]
		public BigEventEntryDesc()
		{
		}

		// Token: 0x04003576 RID: 13686
		[Token(Token = "0x4003576")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A9B8", Offset = "0x112A9B8")]
		public ELimitedEvent.EventID event_id;

		// Token: 0x04003577 RID: 13687
		[Token(Token = "0x4003577")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A9CC", Offset = "0x112A9CC")]
		public uint entry_id;

		// Token: 0x04003578 RID: 13688
		[Token(Token = "0x4003578")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A9E0", Offset = "0x112A9E0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112A9E0", Offset = "0x112A9E0")]
		public string start_time;

		// Token: 0x04003579 RID: 13689
		[Token(Token = "0x4003579")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AA30", Offset = "0x112AA30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112AA30", Offset = "0x112AA30")]
		public string end_time;

		// Token: 0x0400357A RID: 13690
		[Token(Token = "0x400357A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AA80", Offset = "0x112AA80")]
		public uint start_timestamp;

		// Token: 0x0400357B RID: 13691
		[Token(Token = "0x400357B")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AA94", Offset = "0x112AA94")]
		public uint end_timestamp;

		// Token: 0x0400357C RID: 13692
		[Token(Token = "0x400357C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AAA8", Offset = "0x112AAA8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112AAA8", Offset = "0x112AAA8")]
		public string entry_icon;

		// Token: 0x0400357D RID: 13693
		[Token(Token = "0x400357D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AAF8", Offset = "0x112AAF8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112AAF8", Offset = "0x112AAF8")]
		public string title;

		// Token: 0x0400357E RID: 13694
		[Token(Token = "0x400357E")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AB48", Offset = "0x112AB48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112AB48", Offset = "0x112AB48")]
		public string go_pos;

		// Token: 0x0400357F RID: 13695
		[Token(Token = "0x400357F")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AB98", Offset = "0x112AB98")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112AB98", Offset = "0x112AB98")]
		public string web_url;

		// Token: 0x04003580 RID: 13696
		[Token(Token = "0x4003580")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112ABE8", Offset = "0x112ABE8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112ABE8", Offset = "0x112ABE8")]
		public string is_main_activity;

		// Token: 0x04003581 RID: 13697
		[Token(Token = "0x4003581")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AC38", Offset = "0x112AC38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112AC38", Offset = "0x112AC38")]
		public string cdn_image;

		// Token: 0x04003582 RID: 13698
		[Token(Token = "0x4003582")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112AC88", Offset = "0x112AC88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AC88", Offset = "0x112AC88")]
		public string award_icon;

		// Token: 0x04003583 RID: 13699
		[Token(Token = "0x4003583")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112ACD8", Offset = "0x112ACD8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112ACD8", Offset = "0x112ACD8")]
		public string title_cdn;

		// Token: 0x04003584 RID: 13700
		[Token(Token = "0x4003584")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AD28", Offset = "0x112AD28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112AD28", Offset = "0x112AD28")]
		public string award_bg_cdn;

		// Token: 0x04003585 RID: 13701
		[Token(Token = "0x4003585")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112AD78", Offset = "0x112AD78")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112AD78", Offset = "0x112AD78")]
		public string title_language;

		// Token: 0x04003586 RID: 13702
		[Token(Token = "0x4003586")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112ADC8", Offset = "0x112ADC8")]
		public bool is_push_show;
	}
}
