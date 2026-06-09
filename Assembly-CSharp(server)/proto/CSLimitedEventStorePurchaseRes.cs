using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000956 RID: 2390
	[Token(Token = "0x2000956")]
	[ProtoContract]
	public class CSLimitedEventStorePurchaseRes
	{
		// Token: 0x06002664 RID: 9828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002664")]
		[Address(RVA = "0x21B67A0", Offset = "0x21B67A0", VA = "0x7BBC9B67A0")]
		public CSLimitedEventStorePurchaseRes()
		{
		}

		// Token: 0x04002BD3 RID: 11219
		[Token(Token = "0x4002BD3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119384", Offset = "0x1119384")]
		public ExchangeChangeData data;
	}
}
