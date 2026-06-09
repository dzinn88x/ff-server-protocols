using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000903 RID: 2307
	[Token(Token = "0x2000903")]
	[ProtoContract]
	public class CSDeclineInviteToTeamReq
	{
		// Token: 0x06002611 RID: 9745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002611")]
		[Address(RVA = "0x21B0EC4", Offset = "0x21B0EC4", VA = "0x7BBC9B0EC4")]
		public CSDeclineInviteToTeamReq()
		{
		}

		// Token: 0x04002AD1 RID: 10961
		[Token(Token = "0x4002AD1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117B60", Offset = "0x1117B60")]
		public ulong[] inviter_ids;
	}
}
