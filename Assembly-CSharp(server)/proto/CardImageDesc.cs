using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AC7 RID: 2759
	[Token(Token = "0x2000AC7")]
	[ProtoContract]
	public class CardImageDesc
	{
		// Token: 0x060027D0 RID: 10192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D0")]
		[Address(RVA = "0x21B7E2C", Offset = "0x21B7E2C", VA = "0x7BBC9B7E2C")]
		public CardImageDesc()
		{
		}

		// Token: 0x040033D3 RID: 13267
		[Token(Token = "0x40033D3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112759C", Offset = "0x112759C")]
		public uint id;

		// Token: 0x040033D4 RID: 13268
		[Token(Token = "0x40033D4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11275B0", Offset = "0x11275B0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11275B0", Offset = "0x11275B0")]
		public string img_url;
	}
}
