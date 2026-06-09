using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008C2 RID: 2242
	[Token(Token = "0x20008C2")]
	[ProtoContract]
	public class GiftRewardDetail
	{
		// Token: 0x060025D0 RID: 9680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D0")]
		[Address(RVA = "0x21BAD04", Offset = "0x21BAD04", VA = "0x7BBC9BAD04")]
		public GiftRewardDetail()
		{
		}

		// Token: 0x04002A1D RID: 10781
		[Token(Token = "0x4002A1D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11166FC", Offset = "0x11166FC")]
		public EStore.GiftRankType gift_rank_type;

		// Token: 0x04002A1E RID: 10782
		[Token(Token = "0x4002A1E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116710", Offset = "0x1116710")]
		public List<GiftRewardDesc> gift_rewards;
	}
}
