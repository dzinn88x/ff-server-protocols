using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009A5 RID: 2469
	[Token(Token = "0x20009A5")]
	[ProtoContract]
	public class CSMonopolyRollReq
	{
		// Token: 0x060026B3 RID: 9907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B3")]
		[Address(RVA = "0x21B6B8C", Offset = "0x21B6B8C", VA = "0x7BBC9B6B8C")]
		public CSMonopolyRollReq()
		{
		}

		// Token: 0x04002C8F RID: 11407
		[Token(Token = "0x4002C8F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A400", Offset = "0x111A400")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111A400", Offset = "0x111A400")]
		public string language;
	}
}
