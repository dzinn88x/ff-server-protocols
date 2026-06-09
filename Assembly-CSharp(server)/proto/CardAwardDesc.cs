using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AC6 RID: 2758
	[Token(Token = "0x2000AC6")]
	[ProtoContract]
	public class CardAwardDesc
	{
		// Token: 0x060027CF RID: 10191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CF")]
		[Address(RVA = "0x21B7E24", Offset = "0x21B7E24", VA = "0x7BBC9B7E24")]
		public CardAwardDesc()
		{
		}

		// Token: 0x040033D0 RID: 13264
		[Token(Token = "0x40033D0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127560", Offset = "0x1127560")]
		public uint card_id;

		// Token: 0x040033D1 RID: 13265
		[Token(Token = "0x40033D1")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127574", Offset = "0x1127574")]
		public uint pool_weight;

		// Token: 0x040033D2 RID: 13266
		[Token(Token = "0x40033D2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127588", Offset = "0x1127588")]
		public AwardFromCard award;
	}
}
