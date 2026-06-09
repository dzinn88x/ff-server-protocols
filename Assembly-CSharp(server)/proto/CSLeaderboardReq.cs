using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200072D RID: 1837
	[Token(Token = "0x200072D")]
	[ProtoContract]
	public class CSLeaderboardReq
	{
		// Token: 0x0600243A RID: 9274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243A")]
		[Address(RVA = "0x21B65F8", Offset = "0x21B65F8", VA = "0x7BBC9B65F8")]
		public CSLeaderboardReq()
		{
		}

		// Token: 0x0400246D RID: 9325
		[Token(Token = "0x400246D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C4CC", Offset = "0x110C4CC")]
		public int main_type;

		// Token: 0x0400246E RID: 9326
		[Token(Token = "0x400246E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C4E0", Offset = "0x110C4E0")]
		public int sub_type;

		// Token: 0x0400246F RID: 9327
		[Token(Token = "0x400246F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C4F4", Offset = "0x110C4F4")]
		public ulong main_key;

		// Token: 0x04002470 RID: 9328
		[Token(Token = "0x4002470")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C508", Offset = "0x110C508")]
		public ulong sub_key;

		// Token: 0x04002471 RID: 9329
		[Token(Token = "0x4002471")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C51C", Offset = "0x110C51C")]
		public uint page_index;

		// Token: 0x04002472 RID: 9330
		[Token(Token = "0x4002472")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C530", Offset = "0x110C530")]
		public uint page_size;

		// Token: 0x04002473 RID: 9331
		[Token(Token = "0x4002473")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C544", Offset = "0x110C544")]
		public bool get_self;

		// Token: 0x04002474 RID: 9332
		[Token(Token = "0x4002474")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C558", Offset = "0x110C558")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110C558", Offset = "0x110C558")]
		public string region;

		// Token: 0x04002475 RID: 9333
		[Token(Token = "0x4002475")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110C5A8", Offset = "0x110C5A8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C5A8", Offset = "0x110C5A8")]
		public string lock_region;
	}
}
