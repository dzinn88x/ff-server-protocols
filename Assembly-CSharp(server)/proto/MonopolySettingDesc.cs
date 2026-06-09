using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B36 RID: 2870
	[Token(Token = "0x2000B36")]
	[ProtoContract]
	public class MonopolySettingDesc
	{
		// Token: 0x0600283E RID: 10302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283E")]
		[Address(RVA = "0x249E4C4", Offset = "0x249E4C4", VA = "0x7BBCC9E4C4")]
		public MonopolySettingDesc()
		{
		}

		// Token: 0x04003676 RID: 13942
		[Token(Token = "0x4003676")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CB50", Offset = "0x112CB50")]
		public uint max_node;

		// Token: 0x04003677 RID: 13943
		[Token(Token = "0x4003677")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CB64", Offset = "0x112CB64")]
		public uint ticket_id;

		// Token: 0x04003678 RID: 13944
		[Token(Token = "0x4003678")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CB78", Offset = "0x112CB78")]
		public uint token_id;

		// Token: 0x04003679 RID: 13945
		[Token(Token = "0x4003679")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CB8C", Offset = "0x112CB8C")]
		public List<AwardDesc> awards;

		// Token: 0x0400367A RID: 13946
		[Token(Token = "0x400367A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CBA0", Offset = "0x112CBA0")]
		public uint forward_step;

		// Token: 0x0400367B RID: 13947
		[Token(Token = "0x400367B")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CBB4", Offset = "0x112CBB4")]
		public uint backward_step;

		// Token: 0x0400367C RID: 13948
		[Token(Token = "0x400367C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CBC8", Offset = "0x112CBC8")]
		public uint buff_multiple;

		// Token: 0x0400367D RID: 13949
		[Token(Token = "0x400367D")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CBDC", Offset = "0x112CBDC")]
		public uint buff_time;

		// Token: 0x0400367E RID: 13950
		[Token(Token = "0x400367E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CBF0", Offset = "0x112CBF0")]
		public uint token_num;

		// Token: 0x0400367F RID: 13951
		[Token(Token = "0x400367F")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CC04", Offset = "0x112CC04")]
		public uint start_token_num;

		// Token: 0x04003680 RID: 13952
		[Token(Token = "0x4003680")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CC18", Offset = "0x112CC18")]
		public uint phase1_num;

		// Token: 0x04003681 RID: 13953
		[Token(Token = "0x4003681")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CC2C", Offset = "0x112CC2C")]
		public uint phase2_num;

		// Token: 0x04003682 RID: 13954
		[Token(Token = "0x4003682")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CC40", Offset = "0x112CC40")]
		public uint phase3_num;
	}
}
