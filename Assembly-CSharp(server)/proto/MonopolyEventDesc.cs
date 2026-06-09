using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B37 RID: 2871
	[Token(Token = "0x2000B37")]
	[ProtoContract]
	public class MonopolyEventDesc
	{
		// Token: 0x0600283F RID: 10303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283F")]
		[Address(RVA = "0x249E404", Offset = "0x249E404", VA = "0x7BBCC9E404")]
		public MonopolyEventDesc()
		{
		}

		// Token: 0x04003683 RID: 13955
		[Token(Token = "0x4003683")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CC54", Offset = "0x112CC54")]
		public uint id;

		// Token: 0x04003684 RID: 13956
		[Token(Token = "0x4003684")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CC68", Offset = "0x112CC68")]
		public uint phase;

		// Token: 0x04003685 RID: 13957
		[Token(Token = "0x4003685")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CC7C", Offset = "0x112CC7C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112CC7C", Offset = "0x112CC7C")]
		public string event_title;

		// Token: 0x04003686 RID: 13958
		[Token(Token = "0x4003686")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CCCC", Offset = "0x112CCCC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112CCCC", Offset = "0x112CCCC")]
		public string event_desc;

		// Token: 0x04003687 RID: 13959
		[Token(Token = "0x4003687")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CD1C", Offset = "0x112CD1C")]
		public MonopolyEventOption event_option1;

		// Token: 0x04003688 RID: 13960
		[Token(Token = "0x4003688")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CD30", Offset = "0x112CD30")]
		public MonopolyEventOption event_option2;

		// Token: 0x04003689 RID: 13961
		[Token(Token = "0x4003689")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CD44", Offset = "0x112CD44")]
		public bool is_mission;

		// Token: 0x0400368A RID: 13962
		[Token(Token = "0x400368A")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CD58", Offset = "0x112CD58")]
		public uint weight;
	}
}
