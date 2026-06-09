using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000692 RID: 1682
	[Token(Token = "0x2000692")]
	[ProtoContract]
	public class DiamondCostRes
	{
		// Token: 0x060023D0 RID: 9168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D0")]
		[Address(RVA = "0x21B959C", Offset = "0x21B959C", VA = "0x7BBC9B959C")]
		public DiamondCostRes()
		{
		}

		// Token: 0x04002114 RID: 8468
		[Token(Token = "0x4002114")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108F20", Offset = "0x1108F20")]
		public uint diamond_cost;
	}
}
