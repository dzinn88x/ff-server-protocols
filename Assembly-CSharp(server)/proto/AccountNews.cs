using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000606 RID: 1542
	[Token(Token = "0x2000606")]
	[ProtoContract]
	public class AccountNews
	{
		// Token: 0x06002382 RID: 9090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002382")]
		[Address(RVA = "0x21AE680", Offset = "0x21AE680", VA = "0x7BBC9AE680")]
		public AccountNews()
		{
		}

		// Token: 0x04001EC3 RID: 7875
		[Token(Token = "0x4001EC3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11070F8", Offset = "0x11070F8")]
		public EAccount.NewsType type;

		// Token: 0x04001EC4 RID: 7876
		[Token(Token = "0x4001EC4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110710C", Offset = "0x110710C")]
		public AccountNewsContent content;

		// Token: 0x04001EC5 RID: 7877
		[Token(Token = "0x4001EC5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107120", Offset = "0x1107120")]
		public long update_time;
	}
}
