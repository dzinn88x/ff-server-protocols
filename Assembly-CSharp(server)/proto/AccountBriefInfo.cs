using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000608 RID: 1544
	[Token(Token = "0x2000608")]
	[ProtoContract]
	public class AccountBriefInfo
	{
		// Token: 0x06002384 RID: 9092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002384")]
		[Address(RVA = "0x21AE398", Offset = "0x21AE398", VA = "0x7BBC9AE398")]
		public AccountBriefInfo()
		{
		}

		// Token: 0x04001ECA RID: 7882
		[Token(Token = "0x4001ECA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107184", Offset = "0x1107184")]
		public AccountInfoBasic basic_info;

		// Token: 0x04001ECB RID: 7883
		[Token(Token = "0x4001ECB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107198", Offset = "0x1107198")]
		public SocialBasicInfo social_info;
	}
}
