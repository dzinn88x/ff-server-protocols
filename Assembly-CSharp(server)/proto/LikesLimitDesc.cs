using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A36 RID: 2614
	[Token(Token = "0x2000A36")]
	[ProtoContract]
	public class LikesLimitDesc
	{
		// Token: 0x06002740 RID: 10048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002740")]
		[Address(RVA = "0x21BBA34", Offset = "0x21BBA34", VA = "0x7BBC9BBA34")]
		public LikesLimitDesc()
		{
		}

		// Token: 0x04002FAD RID: 12205
		[Token(Token = "0x4002FAD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FE50", Offset = "0x111FE50")]
		public uint max_likes_per_match;

		// Token: 0x04002FAE RID: 12206
		[Token(Token = "0x4002FAE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FE64", Offset = "0x111FE64")]
		public uint max_likes_per_protocol;
	}
}
