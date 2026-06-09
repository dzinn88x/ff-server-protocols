using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000657 RID: 1623
	[Token(Token = "0x2000657")]
	[ProtoContract]
	public class CompletionItem
	{
		// Token: 0x060023B6 RID: 9142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B6")]
		[Address(RVA = "0x21B8FD4", Offset = "0x21B8FD4", VA = "0x7BBC9B8FD4")]
		public CompletionItem()
		{
		}

		// Token: 0x04002016 RID: 8214
		[Token(Token = "0x4002016")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108610", Offset = "0x1108610")]
		public uint item_id;

		// Token: 0x04002017 RID: 8215
		[Token(Token = "0x4002017")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108624", Offset = "0x1108624")]
		public uint item_type;

		// Token: 0x04002018 RID: 8216
		[Token(Token = "0x4002018")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108638", Offset = "0x1108638")]
		public uint cnt;

		// Token: 0x04002019 RID: 8217
		[Token(Token = "0x4002019")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110864C", Offset = "0x110864C")]
		public uint expire_time;

		// Token: 0x0400201A RID: 8218
		[Token(Token = "0x400201A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108660", Offset = "0x1108660")]
		public uint id;

		// Token: 0x0400201B RID: 8219
		[Token(Token = "0x400201B")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108674", Offset = "0x1108674")]
		public uint repeat_change_item_id;

		// Token: 0x0400201C RID: 8220
		[Token(Token = "0x400201C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108688", Offset = "0x1108688")]
		public uint repeat_change_item_type;

		// Token: 0x0400201D RID: 8221
		[Token(Token = "0x400201D")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110869C", Offset = "0x110869C")]
		public uint repeat_change_item_num;
	}
}
