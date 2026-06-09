using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007D2 RID: 2002
	[Token(Token = "0x20007D2")]
	[ProtoContract]
	public class CSReadMailRes
	{
		// Token: 0x060024E1 RID: 9441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E1")]
		[Address(RVA = "0x21B71F0", Offset = "0x21B71F0", VA = "0x7BBC9B71F0")]
		public CSReadMailRes()
		{
		}

		// Token: 0x04002659 RID: 9817
		[Token(Token = "0x4002659")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FA28", Offset = "0x110FA28")]
		public AwardData rewards;

		// Token: 0x0400265A RID: 9818
		[Token(Token = "0x400265A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FA3C", Offset = "0x110FA3C")]
		public List<ExchangedAward> exchangedAwards;
	}
}
