using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000942 RID: 2370
	[Token(Token = "0x2000942")]
	[ProtoContract]
	public class CSClaimSubscriptionRes
	{
		// Token: 0x06002650 RID: 9808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002650")]
		[Address(RVA = "0x21B0934", Offset = "0x21B0934", VA = "0x7BBC9B0934")]
		public CSClaimSubscriptionRes()
		{
		}

		// Token: 0x04002BA7 RID: 11175
		[Token(Token = "0x4002BA7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118F10", Offset = "0x1118F10")]
		public ExchangeChangeData data;
	}
}
