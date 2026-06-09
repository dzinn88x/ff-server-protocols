using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007FA RID: 2042
	[Token(Token = "0x20007FA")]
	[ProtoContract]
	public class CSGetClanLuckyBagInfoRes
	{
		// Token: 0x06002509 RID: 9481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002509")]
		[Address(RVA = "0x21B2B80", Offset = "0x21B2B80", VA = "0x7BBC9B2B80")]
		public CSGetClanLuckyBagInfoRes()
		{
		}

		// Token: 0x040026D6 RID: 9942
		[Token(Token = "0x40026D6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11107E8", Offset = "0x11107E8")]
		public List<ClanLuckyBag> lucky_bags;

		// Token: 0x040026D7 RID: 9943
		[Token(Token = "0x40026D7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11107FC", Offset = "0x11107FC")]
		public List<LuckyBagDraw> draws;
	}
}
