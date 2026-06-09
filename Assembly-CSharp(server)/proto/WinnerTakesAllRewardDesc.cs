using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A71 RID: 2673
	[Token(Token = "0x2000A71")]
	[ProtoContract]
	public class WinnerTakesAllRewardDesc
	{
		// Token: 0x0600277B RID: 10107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277B")]
		[Address(RVA = "0x24A1B54", Offset = "0x24A1B54", VA = "0x7BBCCA1B54")]
		public WinnerTakesAllRewardDesc()
		{
		}

		// Token: 0x040030F9 RID: 12537
		[Token(Token = "0x40030F9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122114", Offset = "0x1122114")]
		public uint group_mode;

		// Token: 0x040030FA RID: 12538
		[Token(Token = "0x40030FA")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122128", Offset = "0x1122128")]
		public uint first_chip_num;

		// Token: 0x040030FB RID: 12539
		[Token(Token = "0x40030FB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112213C", Offset = "0x112213C")]
		public uint second_chip_num;

		// Token: 0x040030FC RID: 12540
		[Token(Token = "0x40030FC")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122150", Offset = "0x1122150")]
		public uint third_chip_num;
	}
}
