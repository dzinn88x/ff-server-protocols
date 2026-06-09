using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200086C RID: 2156
	[Token(Token = "0x200086C")]
	[ProtoContract]
	public class CSDoGachaSpecialExchangeRes
	{
		// Token: 0x0600257A RID: 9594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257A")]
		[Address(RVA = "0x21B0F78", Offset = "0x21B0F78", VA = "0x7BBC9B0F78")]
		public CSDoGachaSpecialExchangeRes()
		{
		}

		// Token: 0x04002831 RID: 10289
		[Token(Token = "0x4002831")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11129A8", Offset = "0x11129A8")]
		public ExchangeChangeData data;

		// Token: 0x04002832 RID: 10290
		[Token(Token = "0x4002832")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11129BC", Offset = "0x11129BC")]
		public uint purchase_times;
	}
}
