using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000691 RID: 1681
	[Token(Token = "0x2000691")]
	[ProtoContract]
	public class DiamondCostReq
	{
		// Token: 0x060023CF RID: 9167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CF")]
		[Address(RVA = "0x21B9540", Offset = "0x21B9540", VA = "0x7BBC9B9540")]
		public DiamondCostReq()
		{
		}

		// Token: 0x04002113 RID: 8467
		[Token(Token = "0x4002113")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1108ED0", Offset = "0x1108ED0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108ED0", Offset = "0x1108ED0")]
		public string lock_region;
	}
}
