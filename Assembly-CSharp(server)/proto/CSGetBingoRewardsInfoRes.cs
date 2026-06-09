using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007C6 RID: 1990
	[Token(Token = "0x20007C6")]
	[ProtoContract]
	public class CSGetBingoRewardsInfoRes
	{
		// Token: 0x060024D5 RID: 9429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D5")]
		[Address(RVA = "0x21B263C", Offset = "0x21B263C", VA = "0x7BBC9B263C")]
		public CSGetBingoRewardsInfoRes()
		{
		}

		// Token: 0x04002615 RID: 9749
		[Token(Token = "0x4002615")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F0DC", Offset = "0x110F0DC")]
		public List<ActivityBingoRewardsInfo> rewards;

		// Token: 0x04002616 RID: 9750
		[Token(Token = "0x4002616")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F0F0", Offset = "0x110F0F0")]
		public AwardData init_awards;
	}
}
