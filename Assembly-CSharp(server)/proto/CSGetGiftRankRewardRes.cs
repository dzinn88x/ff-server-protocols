using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008B7 RID: 2231
	[Token(Token = "0x20008B7")]
	[ProtoContract]
	public class CSGetGiftRankRewardRes
	{
		// Token: 0x060025C5 RID: 9669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C5")]
		[Address(RVA = "0x21B3FD8", Offset = "0x21B3FD8", VA = "0x7BBC9B3FD8")]
		public CSGetGiftRankRewardRes()
		{
		}

		// Token: 0x040029FE RID: 10750
		[Token(Token = "0x40029FE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11163B4", Offset = "0x11163B4")]
		public AwardDesc award;

		// Token: 0x040029FF RID: 10751
		[Token(Token = "0x40029FF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11163C8", Offset = "0x11163C8")]
		public uint[] rewarded_list;
	}
}
