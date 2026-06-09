using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008F6 RID: 2294
	[Token(Token = "0x20008F6")]
	[ProtoContract]
	public class TeamInvitationRes
	{
		// Token: 0x06002604 RID: 9732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002604")]
		[Address(RVA = "0x24A0E08", Offset = "0x24A0E08", VA = "0x7BBCCA0E08")]
		public TeamInvitationRes()
		{
		}

		// Token: 0x04002AA4 RID: 10916
		[Token(Token = "0x4002AA4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11175AC", Offset = "0x11175AC")]
		public ulong account_id;

		// Token: 0x04002AA5 RID: 10917
		[Token(Token = "0x4002AA5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11175C0", Offset = "0x11175C0")]
		public ulong team_id;

		// Token: 0x04002AA6 RID: 10918
		[Token(Token = "0x4002AA6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11175D4", Offset = "0x11175D4")]
		public ulong inviter_id;

		// Token: 0x04002AA7 RID: 10919
		[Token(Token = "0x4002AA7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11175E8", Offset = "0x11175E8")]
		public ulong create_at;
	}
}
