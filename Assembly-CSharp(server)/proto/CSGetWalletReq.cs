using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200077A RID: 1914
	[Token(Token = "0x200077A")]
	[ProtoContract]
	public class CSGetWalletReq
	{
		// Token: 0x06002487 RID: 9351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002487")]
		[Address(RVA = "0x21B6290", Offset = "0x21B6290", VA = "0x7BBC9B6290")]
		public CSGetWalletReq()
		{
		}

		// Token: 0x04002548 RID: 9544
		[Token(Token = "0x4002548")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DAFC", Offset = "0x110DAFC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110DAFC", Offset = "0x110DAFC")]
		public string login_token;

		// Token: 0x04002549 RID: 9545
		[Token(Token = "0x4002549")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DB4C", Offset = "0x110DB4C")]
		public bool topup_rebate;
	}
}
