using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000704 RID: 1796
	[Token(Token = "0x2000704")]
	[ProtoContract]
	public class CoinsDetail
	{
		// Token: 0x06002412 RID: 9234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002412")]
		[Address(RVA = "0x21B8F40", Offset = "0x21B8F40", VA = "0x7BBC9B8F40")]
		public CoinsDetail()
		{
		}

		// Token: 0x040023C1 RID: 9153
		[Token(Token = "0x40023C1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B4F0", Offset = "0x110B4F0")]
		public uint coin_match;

		// Token: 0x040023C2 RID: 9154
		[Token(Token = "0x40023C2")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B504", Offset = "0x110B504")]
		public uint coin_clan_buff;

		// Token: 0x040023C3 RID: 9155
		[Token(Token = "0x40023C3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B518", Offset = "0x110B518")]
		public uint coin_event_bonus;

		// Token: 0x040023C4 RID: 9156
		[Token(Token = "0x40023C4")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B52C", Offset = "0x110B52C")]
		public uint coin_card;

		// Token: 0x040023C5 RID: 9157
		[Token(Token = "0x40023C5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B540", Offset = "0x110B540")]
		public uint coin_ranking;

		// Token: 0x040023C6 RID: 9158
		[Token(Token = "0x40023C6")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B554", Offset = "0x110B554")]
		public uint coin_championship;
	}
}
