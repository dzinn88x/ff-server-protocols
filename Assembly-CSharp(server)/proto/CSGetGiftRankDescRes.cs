using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008B3 RID: 2227
	[Token(Token = "0x20008B3")]
	[ProtoContract]
	public class CSGetGiftRankDescRes
	{
		// Token: 0x060025C1 RID: 9665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C1")]
		[Address(RVA = "0x21B3F4C", Offset = "0x21B3F4C", VA = "0x7BBC9B3F4C")]
		public CSGetGiftRankDescRes()
		{
		}

		// Token: 0x040029F6 RID: 10742
		[Token(Token = "0x40029F6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11162C4", Offset = "0x11162C4")]
		public ClientGiftRankDesc gift_rank_desc;

		// Token: 0x040029F7 RID: 10743
		[Token(Token = "0x40029F7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11162D8", Offset = "0x11162D8")]
		public List<GiftRewardDetail> gift_reward_detail;
	}
}
