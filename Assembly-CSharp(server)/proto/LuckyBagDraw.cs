using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007F9 RID: 2041
	[Token(Token = "0x20007F9")]
	[ProtoContract]
	public class LuckyBagDraw
	{
		// Token: 0x06002508 RID: 9480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002508")]
		[Address(RVA = "0x21BC06C", Offset = "0x21BC06C", VA = "0x7BBC9BC06C")]
		public LuckyBagDraw()
		{
		}

		// Token: 0x040026D3 RID: 9939
		[Token(Token = "0x40026D3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11107AC", Offset = "0x11107AC")]
		public ulong account_id;

		// Token: 0x040026D4 RID: 9940
		[Token(Token = "0x40026D4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11107C0", Offset = "0x11107C0")]
		public ulong bag_id;

		// Token: 0x040026D5 RID: 9941
		[Token(Token = "0x40026D5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11107D4", Offset = "0x11107D4")]
		public ulong opened_at;
	}
}
