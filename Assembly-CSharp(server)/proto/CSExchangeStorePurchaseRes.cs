using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008AD RID: 2221
	[Token(Token = "0x20008AD")]
	[ProtoContract]
	public class CSExchangeStorePurchaseRes
	{
		// Token: 0x060025BB RID: 9659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025BB")]
		[Address(RVA = "0x21B1278", Offset = "0x21B1278", VA = "0x7BBC9B1278")]
		public CSExchangeStorePurchaseRes()
		{
		}

		// Token: 0x040029DA RID: 10714
		[Token(Token = "0x40029DA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115FA4", Offset = "0x1115FA4")]
		public ExchangeChangeData data;

		// Token: 0x040029DB RID: 10715
		[Token(Token = "0x40029DB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115FB8", Offset = "0x1115FB8")]
		public uint purchase_times;
	}
}
