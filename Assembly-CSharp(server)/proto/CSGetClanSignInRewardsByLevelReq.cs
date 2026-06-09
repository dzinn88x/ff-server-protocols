using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007E7 RID: 2023
	[Token(Token = "0x20007E7")]
	[ProtoContract]
	public class CSGetClanSignInRewardsByLevelReq
	{
		// Token: 0x060024F6 RID: 9462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024F6")]
		[Address(RVA = "0x21B2CC0", Offset = "0x21B2CC0", VA = "0x7BBC9B2CC0")]
		public CSGetClanSignInRewardsByLevelReq()
		{
		}

		// Token: 0x04002684 RID: 9860
		[Token(Token = "0x4002684")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FF28", Offset = "0x110FF28")]
		public uint clan_level;

		// Token: 0x04002685 RID: 9861
		[Token(Token = "0x4002685")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110FF3C", Offset = "0x110FF3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FF3C", Offset = "0x110FF3C")]
		public string clan_region;
	}
}
