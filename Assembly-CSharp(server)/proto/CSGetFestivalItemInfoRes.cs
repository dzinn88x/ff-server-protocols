using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007B8 RID: 1976
	[Token(Token = "0x20007B8")]
	[ProtoContract]
	public class CSGetFestivalItemInfoRes
	{
		// Token: 0x060024C7 RID: 9415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024C7")]
		[Address(RVA = "0x21B3728", Offset = "0x21B3728", VA = "0x7BBC9B3728")]
		public CSGetFestivalItemInfoRes()
		{
		}

		// Token: 0x040025F2 RID: 9714
		[Token(Token = "0x40025F2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EBF0", Offset = "0x110EBF0")]
		public uint festival_item_id;

		// Token: 0x040025F3 RID: 9715
		[Token(Token = "0x40025F3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EC04", Offset = "0x110EC04")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110EC04", Offset = "0x110EC04")]
		public string act_text1;

		// Token: 0x040025F4 RID: 9716
		[Token(Token = "0x40025F4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110EC54", Offset = "0x110EC54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110EC54", Offset = "0x110EC54")]
		public string act_text2;

		// Token: 0x040025F5 RID: 9717
		[Token(Token = "0x40025F5")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110ECA4", Offset = "0x110ECA4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110ECA4", Offset = "0x110ECA4")]
		public string act_text3;
	}
}
