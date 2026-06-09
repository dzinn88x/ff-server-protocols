using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000873 RID: 2163
	[Token(Token = "0x2000873")]
	[ProtoContract]
	public class CompletionBackpackInfo
	{
		// Token: 0x06002581 RID: 9601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002581")]
		[Address(RVA = "0x21B8F60", Offset = "0x21B8F60", VA = "0x7BBC9B8F60")]
		public CompletionBackpackInfo()
		{
		}

		// Token: 0x0400288C RID: 10380
		[Token(Token = "0x400288C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11132F4", Offset = "0x11132F4")]
		public uint lottery_id;

		// Token: 0x0400288D RID: 10381
		[Token(Token = "0x400288D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113308", Offset = "0x1113308")]
		public List<CompletionItem> items;
	}
}
