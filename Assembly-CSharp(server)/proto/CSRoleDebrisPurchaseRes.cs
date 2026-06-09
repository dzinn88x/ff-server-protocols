using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000791 RID: 1937
	[Token(Token = "0x2000791")]
	[ProtoContract]
	public class CSRoleDebrisPurchaseRes
	{
		// Token: 0x060024A0 RID: 9376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A0")]
		[Address(RVA = "0x21B7500", Offset = "0x21B7500", VA = "0x7BBC9B7500")]
		public CSRoleDebrisPurchaseRes()
		{
		}

		// Token: 0x040025A1 RID: 9633
		[Token(Token = "0x40025A1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E3BC", Offset = "0x110E3BC")]
		public ExchangeChangeData data;
	}
}
