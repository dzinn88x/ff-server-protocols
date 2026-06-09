using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B20 RID: 2848
	[Token(Token = "0x2000B20")]
	[ProtoContract]
	public class BooyahDayProcessRewardDesc
	{
		// Token: 0x06002828 RID: 10280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002828")]
		[Address(RVA = "0x21AFCC8", Offset = "0x21AFCC8", VA = "0x7BBC9AFCC8")]
		public BooyahDayProcessRewardDesc()
		{
		}

		// Token: 0x04003606 RID: 13830
		[Token(Token = "0x4003606")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BF84", Offset = "0x112BF84")]
		public uint id;

		// Token: 0x04003607 RID: 13831
		[Token(Token = "0x4003607")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BF98", Offset = "0x112BF98")]
		public ulong progress;

		// Token: 0x04003608 RID: 13832
		[Token(Token = "0x4003608")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BFAC", Offset = "0x112BFAC")]
		public List<AwardDesc> award_items;
	}
}
