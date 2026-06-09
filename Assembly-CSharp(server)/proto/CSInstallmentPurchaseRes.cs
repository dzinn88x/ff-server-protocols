using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008C7 RID: 2247
	[Token(Token = "0x20008C7")]
	[ProtoContract]
	public class CSInstallmentPurchaseRes
	{
		// Token: 0x060025D5 RID: 9685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D5")]
		[Address(RVA = "0x21B65B0", Offset = "0x21B65B0", VA = "0x7BBC9B65B0")]
		public CSInstallmentPurchaseRes()
		{
		}

		// Token: 0x04002A32 RID: 10802
		[Token(Token = "0x4002A32")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116918", Offset = "0x1116918")]
		public ExchangeChangeData data;
	}
}
