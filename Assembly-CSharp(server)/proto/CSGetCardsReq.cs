using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000877 RID: 2167
	[Token(Token = "0x2000877")]
	[ProtoContract]
	public class CSGetCardsReq
	{
		// Token: 0x06002585 RID: 9605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002585")]
		[Address(RVA = "0x21B2AA0", Offset = "0x21B2AA0", VA = "0x7BBC9B2AA0")]
		public CSGetCardsReq()
		{
		}

		// Token: 0x04002896 RID: 10390
		[Token(Token = "0x4002896")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113448", Offset = "0x1113448")]
		public uint lottery_id;

		// Token: 0x04002897 RID: 10391
		[Token(Token = "0x4002897")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111345C", Offset = "0x111345C")]
		public uint[] id_list;
	}
}
