using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008E0 RID: 2272
	[Token(Token = "0x20008E0")]
	[ProtoContract]
	public class CSUpdateAccountFollowStatReq
	{
		// Token: 0x060025EE RID: 9710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025EE")]
		[Address(RVA = "0x21B7BD4", Offset = "0x21B7BD4", VA = "0x7BBC9B7BD4")]
		public CSUpdateAccountFollowStatReq()
		{
		}

		// Token: 0x04002A79 RID: 10873
		[Token(Token = "0x4002A79")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117084", Offset = "0x1117084")]
		public ulong streamer_id;

		// Token: 0x04002A7A RID: 10874
		[Token(Token = "0x4002A7A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117098", Offset = "0x1117098")]
		public ELive.FollowerType follower_type;
	}
}
