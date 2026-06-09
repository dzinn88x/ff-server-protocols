using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000780 RID: 1920
	[Token(Token = "0x2000780")]
	[ProtoContract]
	public class CSChooseRankingCardsReq
	{
		// Token: 0x0600248F RID: 9359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248F")]
		[Address(RVA = "0x21B0690", Offset = "0x21B0690", VA = "0x7BBC9B0690")]
		public CSChooseRankingCardsReq()
		{
		}

		// Token: 0x04002555 RID: 9557
		[Token(Token = "0x4002555")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DC3C", Offset = "0x110DC3C")]
		public uint card_id;
	}
}
