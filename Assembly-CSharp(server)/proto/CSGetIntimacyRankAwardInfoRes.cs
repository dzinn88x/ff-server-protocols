using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000843 RID: 2115
	[Token(Token = "0x2000843")]
	[ProtoContract]
	public class CSGetIntimacyRankAwardInfoRes
	{
		// Token: 0x06002558 RID: 9560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002558")]
		[Address(RVA = "0x21B4398", Offset = "0x21B4398", VA = "0x7BBC9B4398")]
		public CSGetIntimacyRankAwardInfoRes()
		{
		}

		// Token: 0x04002779 RID: 10105
		[Token(Token = "0x4002779")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111684", Offset = "0x1111684")]
		public List<SpecificIntimacyRankAwardInfo> award_info_lists;

		// Token: 0x0400277A RID: 10106
		[Token(Token = "0x400277A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111698", Offset = "0x1111698")]
		public List<IntimacyAwardDesc> intimacy_awards;
	}
}
