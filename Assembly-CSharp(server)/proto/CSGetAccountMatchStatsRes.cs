using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006ED RID: 1773
	[Token(Token = "0x20006ED")]
	[ProtoContract]
	public class CSGetAccountMatchStatsRes
	{
		// Token: 0x060023FB RID: 9211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FB")]
		[Address(RVA = "0x21B1770", Offset = "0x21B1770", VA = "0x7BBC9B1770")]
		public CSGetAccountMatchStatsRes()
		{
		}

		// Token: 0x040022AB RID: 8875
		[Token(Token = "0x40022AB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109D1C", Offset = "0x1109D1C")]
		public MatchIncome income;

		// Token: 0x040022AC RID: 8876
		[Token(Token = "0x40022AC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109D30", Offset = "0x1109D30")]
		public MatchStats stats;
	}
}
