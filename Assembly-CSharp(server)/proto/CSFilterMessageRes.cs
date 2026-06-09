using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200072C RID: 1836
	[Token(Token = "0x200072C")]
	[ProtoContract]
	public class CSFilterMessageRes
	{
		// Token: 0x06002439 RID: 9273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002439")]
		[Address(RVA = "0x21B13E0", Offset = "0x21B13E0", VA = "0x7BBC9B13E0")]
		public CSFilterMessageRes()
		{
		}

		// Token: 0x0400246A RID: 9322
		[Token(Token = "0x400246A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C454", Offset = "0x110C454")]
		public bool is_dirty;

		// Token: 0x0400246B RID: 9323
		[Token(Token = "0x400246B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C468", Offset = "0x110C468")]
		public List<string> dirty_words;

		// Token: 0x0400246C RID: 9324
		[Token(Token = "0x400246C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C47C", Offset = "0x110C47C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110C47C", Offset = "0x110C47C")]
		public string filtered_text;
	}
}
