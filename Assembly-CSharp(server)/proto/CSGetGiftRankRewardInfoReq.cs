using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008B4 RID: 2228
	[Token(Token = "0x20008B4")]
	[ProtoContract]
	public class CSGetGiftRankRewardInfoReq
	{
		// Token: 0x060025C2 RID: 9666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C2")]
		[Address(RVA = "0x21B3FC0", Offset = "0x21B3FC0", VA = "0x7BBC9B3FC0")]
		public CSGetGiftRankRewardInfoReq()
		{
		}

		// Token: 0x040029F8 RID: 10744
		[Token(Token = "0x40029F8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11162EC", Offset = "0x11162EC")]
		public uint rank_id;
	}
}
