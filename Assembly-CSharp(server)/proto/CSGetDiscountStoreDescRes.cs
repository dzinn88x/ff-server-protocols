using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008BC RID: 2236
	[Token(Token = "0x20008BC")]
	[ProtoContract]
	public class CSGetDiscountStoreDescRes
	{
		// Token: 0x060025CA RID: 9674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CA")]
		[Address(RVA = "0x21B3054", Offset = "0x21B3054", VA = "0x7BBC9B3054")]
		public CSGetDiscountStoreDescRes()
		{
		}

		// Token: 0x04002A0C RID: 10764
		[Token(Token = "0x4002A0C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116530", Offset = "0x1116530")]
		public List<DiscountStoreDesc> discountStores;
	}
}
