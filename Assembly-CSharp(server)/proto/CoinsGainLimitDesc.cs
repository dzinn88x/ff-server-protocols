using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A4F RID: 2639
	[Token(Token = "0x2000A4F")]
	[ProtoContract]
	public class CoinsGainLimitDesc
	{
		// Token: 0x06002759 RID: 10073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002759")]
		[Address(RVA = "0x21B8F48", Offset = "0x21B8F48", VA = "0x7BBC9B8F48")]
		public CoinsGainLimitDesc()
		{
		}

		// Token: 0x04003028 RID: 12328
		[Token(Token = "0x4003028")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120A1C", Offset = "0x1120A1C")]
		public uint coins_gain_limit;
	}
}
