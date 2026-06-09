using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000842 RID: 2114
	[Token(Token = "0x2000842")]
	[ProtoContract]
	public class SpecificIntimacyRankAwardInfo
	{
		// Token: 0x06002557 RID: 9559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002557")]
		[Address(RVA = "0x24A0704", Offset = "0x24A0704", VA = "0x7BBCCA0704")]
		public SpecificIntimacyRankAwardInfo()
		{
		}

		// Token: 0x04002776 RID: 10102
		[Token(Token = "0x4002776")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111648", Offset = "0x1111648")]
		public ulong related_friend_id;

		// Token: 0x04002777 RID: 10103
		[Token(Token = "0x4002777")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111165C", Offset = "0x111165C")]
		public EFriend.RelationType relation_type;

		// Token: 0x04002778 RID: 10104
		[Token(Token = "0x4002778")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111670", Offset = "0x1111670")]
		public List<IntimacyRankAwardInfo> award_infos;
	}
}
