using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000734 RID: 1844
	[Token(Token = "0x2000734")]
	[ProtoContract]
	public class ClanLeaderboardProfile
	{
		// Token: 0x06002441 RID: 9281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002441")]
		[Address(RVA = "0x21B8768", Offset = "0x21B8768", VA = "0x7BBC9B8768")]
		public ClanLeaderboardProfile()
		{
		}

		// Token: 0x0400248E RID: 9358
		[Token(Token = "0x400248E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C7D8", Offset = "0x110C7D8")]
		public ClanInfo clan_info;
	}
}
