using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000635 RID: 1589
	[Token(Token = "0x2000635")]
	[ProtoContract]
	public class AccountInfoWithSocialInfo
	{
		// Token: 0x0600239F RID: 9119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239F")]
		[Address(RVA = "0x21AE588", Offset = "0x21AE588", VA = "0x7BBC9AE588")]
		public AccountInfoWithSocialInfo()
		{
		}

		// Token: 0x04001F8C RID: 8076
		[Token(Token = "0x4001F8C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108020", Offset = "0x1108020")]
		public AccountInfoBasic account_info_basic;

		// Token: 0x04001F8D RID: 8077
		[Token(Token = "0x4001F8D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108034", Offset = "0x1108034")]
		public SocialBasicInfo social_basic_info;
	}
}
