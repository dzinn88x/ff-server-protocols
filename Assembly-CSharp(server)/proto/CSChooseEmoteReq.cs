using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200076D RID: 1901
	[Token(Token = "0x200076D")]
	[ProtoContract]
	public class CSChooseEmoteReq
	{
		// Token: 0x0600247A RID: 9338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247A")]
		[Address(RVA = "0x21B0658", Offset = "0x21B0658", VA = "0x7BBC9B0658")]
		public CSChooseEmoteReq()
		{
		}

		// Token: 0x04002528 RID: 9512
		[Token(Token = "0x4002528")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D82C", Offset = "0x110D82C")]
		public uint slot_id;

		// Token: 0x04002529 RID: 9513
		[Token(Token = "0x4002529")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D840", Offset = "0x110D840")]
		public uint emote_id;

		// Token: 0x0400252A RID: 9514
		[Token(Token = "0x400252A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D854", Offset = "0x110D854")]
		public ulong group_id;
	}
}
