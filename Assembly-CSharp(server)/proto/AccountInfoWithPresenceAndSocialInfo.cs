using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000636 RID: 1590
	[Token(Token = "0x2000636")]
	[ProtoContract]
	public class AccountInfoWithPresenceAndSocialInfo
	{
		// Token: 0x060023A0 RID: 9120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A0")]
		[Address(RVA = "0x21AE580", Offset = "0x21AE580", VA = "0x7BBC9AE580")]
		public AccountInfoWithPresenceAndSocialInfo()
		{
		}

		// Token: 0x04001F8E RID: 8078
		[Token(Token = "0x4001F8E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108048", Offset = "0x1108048")]
		public AccountInfoWithPresence account_info_with_presence;

		// Token: 0x04001F8F RID: 8079
		[Token(Token = "0x4001F8F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110805C", Offset = "0x110805C")]
		public SocialBasicInfo social_basic_info;
	}
}
