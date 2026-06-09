using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007AD RID: 1965
	[Token(Token = "0x20007AD")]
	[ProtoContract]
	public class CSGetNewPlayerRewardsListRes
	{
		// Token: 0x060024BC RID: 9404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024BC")]
		[Address(RVA = "0x21B4F68", Offset = "0x21B4F68", VA = "0x7BBC9B4F68")]
		public CSGetNewPlayerRewardsListRes()
		{
		}

		// Token: 0x040025DA RID: 9690
		[Token(Token = "0x40025DA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E934", Offset = "0x110E934")]
		public List<NewPlayerRewardItem> rewards;

		// Token: 0x040025DB RID: 9691
		[Token(Token = "0x40025DB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E948", Offset = "0x110E948")]
		public ulong expire_time;
	}
}
