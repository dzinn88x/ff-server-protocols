using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007CE RID: 1998
	[Token(Token = "0x20007CE")]
	[ProtoContract]
	public class ClientActivityEntranceSwitchDesc
	{
		// Token: 0x060024DD RID: 9437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DD")]
		[Address(RVA = "0x21B8BFC", Offset = "0x21B8BFC", VA = "0x7BBC9B8BFC")]
		public ClientActivityEntranceSwitchDesc()
		{
		}

		// Token: 0x04002626 RID: 9766
		[Token(Token = "0x4002626")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F2A8", Offset = "0x110F2A8")]
		public uint id;

		// Token: 0x04002627 RID: 9767
		[Token(Token = "0x4002627")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F2BC", Offset = "0x110F2BC")]
		public long show_time;

		// Token: 0x04002628 RID: 9768
		[Token(Token = "0x4002628")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F2D0", Offset = "0x110F2D0")]
		public long start_time_stamp;

		// Token: 0x04002629 RID: 9769
		[Token(Token = "0x4002629")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F2E4", Offset = "0x110F2E4")]
		public long end_time_stamp;

		// Token: 0x0400262A RID: 9770
		[Token(Token = "0x400262A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F2F8", Offset = "0x110F2F8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F2F8", Offset = "0x110F2F8")]
		public string go_url;

		// Token: 0x0400262B RID: 9771
		[Token(Token = "0x400262B")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F348", Offset = "0x110F348")]
		public uint go_pos;

		// Token: 0x0400262C RID: 9772
		[Token(Token = "0x400262C")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F35C", Offset = "0x110F35C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F35C", Offset = "0x110F35C")]
		public string cdn_url;

		// Token: 0x0400262D RID: 9773
		[Token(Token = "0x400262D")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F3AC", Offset = "0x110F3AC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F3AC", Offset = "0x110F3AC")]
		public string tip_cdn_url;

		// Token: 0x0400262E RID: 9774
		[Token(Token = "0x400262E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F3FC", Offset = "0x110F3FC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F3FC", Offset = "0x110F3FC")]
		public string start_time;

		// Token: 0x0400262F RID: 9775
		[Token(Token = "0x400262F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F44C", Offset = "0x110F44C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F44C", Offset = "0x110F44C")]
		public string end_time;
	}
}
