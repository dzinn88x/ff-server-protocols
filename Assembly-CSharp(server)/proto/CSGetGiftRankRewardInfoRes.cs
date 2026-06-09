using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008B5 RID: 2229
	[Token(Token = "0x20008B5")]
	[ProtoContract]
	public class CSGetGiftRankRewardInfoRes
	{
		// Token: 0x060025C3 RID: 9667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C3")]
		[Address(RVA = "0x21B3FC8", Offset = "0x21B3FC8", VA = "0x7BBC9B3FC8")]
		public CSGetGiftRankRewardInfoRes()
		{
		}

		// Token: 0x040029F9 RID: 10745
		[Token(Token = "0x40029F9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116300", Offset = "0x1116300")]
		public uint[] receiver_rewarded_list;

		// Token: 0x040029FA RID: 10746
		[Token(Token = "0x40029FA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111633C", Offset = "0x111633C")]
		public uint[] giver_rewarded_list;
	}
}
