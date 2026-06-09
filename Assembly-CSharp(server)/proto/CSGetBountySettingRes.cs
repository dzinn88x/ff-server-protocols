using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000977 RID: 2423
	[Token(Token = "0x2000977")]
	[ProtoContract]
	public class CSGetBountySettingRes
	{
		// Token: 0x06002685 RID: 9861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002685")]
		[Address(RVA = "0x21B2914", Offset = "0x21B2914", VA = "0x7BBC9B2914")]
		public CSGetBountySettingRes()
		{
		}

		// Token: 0x04002C14 RID: 11284
		[Token(Token = "0x4002C14")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119974", Offset = "0x1119974")]
		public BountySettingDesc setting;

		// Token: 0x04002C15 RID: 11285
		[Token(Token = "0x4002C15")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119988", Offset = "0x1119988")]
		public List<BigEventTokenTipsDesc> exchange_token_tips;

		// Token: 0x04002C16 RID: 11286
		[Token(Token = "0x4002C16")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111999C", Offset = "0x111999C")]
		public List<BountyPlayerRatingDesc> player_ratings;
	}
}
