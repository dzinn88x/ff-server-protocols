using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000816 RID: 2070
	[Token(Token = "0x2000816")]
	[ProtoContract]
	public class CSClaimAwakenTaskRewardsReq
	{
		// Token: 0x06002525 RID: 9509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002525")]
		[Address(RVA = "0x21B0770", Offset = "0x21B0770", VA = "0x7BBC9B0770")]
		public CSClaimAwakenTaskRewardsReq()
		{
		}

		// Token: 0x04002716 RID: 10006
		[Token(Token = "0x4002716")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110D60", Offset = "0x1110D60")]
		public uint original_avatar_id;

		// Token: 0x04002717 RID: 10007
		[Token(Token = "0x4002717")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110D74", Offset = "0x1110D74")]
		public uint task_type;
	}
}
