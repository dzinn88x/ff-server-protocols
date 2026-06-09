using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008CD RID: 2253
	[Token(Token = "0x20008CD")]
	[ProtoContract]
	public class CSPurchaseMysteryAnotherPoolReq
	{
		// Token: 0x060025DB RID: 9691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x21B6FE0", Offset = "0x21B6FE0", VA = "0x7BBC9B6FE0")]
		public CSPurchaseMysteryAnotherPoolReq()
		{
		}

		// Token: 0x04002A48 RID: 10824
		[Token(Token = "0x4002A48")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116BFC", Offset = "0x1116BFC")]
		public uint price;
	}
}
