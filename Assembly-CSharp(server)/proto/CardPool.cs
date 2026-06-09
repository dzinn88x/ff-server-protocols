using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AC5 RID: 2757
	[Token(Token = "0x2000AC5")]
	[ProtoContract]
	public class CardPool
	{
		// Token: 0x060027CE RID: 10190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CE")]
		[Address(RVA = "0x21B7E88", Offset = "0x21B7E88", VA = "0x7BBC9B7E88")]
		public CardPool()
		{
		}

		// Token: 0x040033CD RID: 13261
		[Token(Token = "0x40033CD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127524", Offset = "0x1127524")]
		public uint card_id;

		// Token: 0x040033CE RID: 13262
		[Token(Token = "0x40033CE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127538", Offset = "0x1127538")]
		public uint pool_weight;

		// Token: 0x040033CF RID: 13263
		[Token(Token = "0x40033CF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112754C", Offset = "0x112754C")]
		public bool is_used;
	}
}
