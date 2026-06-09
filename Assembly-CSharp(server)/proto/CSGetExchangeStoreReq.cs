using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008AA RID: 2218
	[Token(Token = "0x20008AA")]
	[ProtoContract]
	public class CSGetExchangeStoreReq
	{
		// Token: 0x060025B8 RID: 9656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B8")]
		[Address(RVA = "0x21B3368", Offset = "0x21B3368", VA = "0x7BBC9B3368")]
		public CSGetExchangeStoreReq()
		{
		}

		// Token: 0x040029D0 RID: 10704
		[Token(Token = "0x40029D0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1115EA0", Offset = "0x1115EA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115EA0", Offset = "0x1115EA0")]
		public string language;
	}
}
