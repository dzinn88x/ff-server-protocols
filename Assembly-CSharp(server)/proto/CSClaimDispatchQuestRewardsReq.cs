using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200081B RID: 2075
	[Token(Token = "0x200081B")]
	[ProtoContract]
	public class CSClaimDispatchQuestRewardsReq
	{
		// Token: 0x0600252A RID: 9514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600252A")]
		[Address(RVA = "0x21B07B0", Offset = "0x21B07B0", VA = "0x7BBC9B07B0")]
		public CSClaimDispatchQuestRewardsReq()
		{
		}

		// Token: 0x04002720 RID: 10016
		[Token(Token = "0x4002720")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110E50", Offset = "0x1110E50")]
		public uint quest_line;

		// Token: 0x04002721 RID: 10017
		[Token(Token = "0x4002721")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110E64", Offset = "0x1110E64")]
		public uint quest_id;
	}
}
