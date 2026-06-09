using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008BE RID: 2238
	[Token(Token = "0x20008BE")]
	[ProtoContract]
	public class CSDiscountStorePurchaseRes
	{
		// Token: 0x060025CC RID: 9676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CC")]
		[Address(RVA = "0x21B0F50", Offset = "0x21B0F50", VA = "0x7BBC9B0F50")]
		public CSDiscountStorePurchaseRes()
		{
		}

		// Token: 0x04002A13 RID: 10771
		[Token(Token = "0x4002A13")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11165BC", Offset = "0x11165BC")]
		public ExchangeChangeData data;

		// Token: 0x04002A14 RID: 10772
		[Token(Token = "0x4002A14")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11165D0", Offset = "0x11165D0")]
		public uint purchase_count;
	}
}
