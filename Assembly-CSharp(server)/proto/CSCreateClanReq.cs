using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007DC RID: 2012
	[Token(Token = "0x20007DC")]
	[ProtoContract]
	public class CSCreateClanReq
	{
		// Token: 0x060024EB RID: 9451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024EB")]
		[Address(RVA = "0x21B0C90", Offset = "0x21B0C90", VA = "0x7BBC9B0C90")]
		public CSCreateClanReq()
		{
		}

		// Token: 0x04002665 RID: 9829
		[Token(Token = "0x4002665")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FB90", Offset = "0x110FB90")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110FB90", Offset = "0x110FB90")]
		public string clan_name;

		// Token: 0x04002666 RID: 9830
		[Token(Token = "0x4002666")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FBE0", Offset = "0x110FBE0")]
		public ulong captain_id;

		// Token: 0x04002667 RID: 9831
		[Token(Token = "0x4002667")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110FBF4", Offset = "0x110FBF4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FBF4", Offset = "0x110FBF4")]
		public string announcement;

		// Token: 0x04002668 RID: 9832
		[Token(Token = "0x4002668")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110FC44", Offset = "0x110FC44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FC44", Offset = "0x110FC44")]
		public string slogan;

		// Token: 0x04002669 RID: 9833
		[Token(Token = "0x4002669")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FC94", Offset = "0x110FC94")]
		public uint currency_type;

		// Token: 0x0400266A RID: 9834
		[Token(Token = "0x400266A")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FCA8", Offset = "0x110FCA8")]
		public uint entry_type;

		// Token: 0x0400266B RID: 9835
		[Token(Token = "0x400266B")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FCBC", Offset = "0x110FCBC")]
		public uint area_id;

		// Token: 0x0400266C RID: 9836
		[Token(Token = "0x400266C")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FCD0", Offset = "0x110FCD0")]
		public uint play_style;

		// Token: 0x0400266D RID: 9837
		[Token(Token = "0x400266D")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FCE4", Offset = "0x110FCE4")]
		public uint entry_level;

		// Token: 0x0400266E RID: 9838
		[Token(Token = "0x400266E")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FCF8", Offset = "0x110FCF8")]
		public uint entry_rank;
	}
}
