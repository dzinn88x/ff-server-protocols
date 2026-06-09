using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200081E RID: 2078
	[Token(Token = "0x200081E")]
	[ProtoContract]
	public class CSClaimDispatchQuestRewardsRes
	{
		// Token: 0x0600252D RID: 9517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252D")]
		[Address(RVA = "0x21B07B8", Offset = "0x21B07B8", VA = "0x7BBC9B07B8")]
		public CSClaimDispatchQuestRewardsRes()
		{
		}

		// Token: 0x04002724 RID: 10020
		[Token(Token = "0x4002724")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110EA0", Offset = "0x1110EA0")]
		public AvatarDispatchQuest avatar_dispatch_state;

		// Token: 0x04002725 RID: 10021
		[Token(Token = "0x4002725")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110EB4", Offset = "0x1110EB4")]
		public uint critical_times;

		// Token: 0x04002726 RID: 10022
		[Token(Token = "0x4002726")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110EC8", Offset = "0x1110EC8")]
		public List<ExchangedAward> exchangedAwards;
	}
}
