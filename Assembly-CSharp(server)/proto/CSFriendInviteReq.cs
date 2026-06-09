using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200082D RID: 2093
	[Token(Token = "0x200082D")]
	[ProtoContract]
	public class CSFriendInviteReq
	{
		// Token: 0x06002542 RID: 9538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002542")]
		[Address(RVA = "0x21B15A0", Offset = "0x21B15A0", VA = "0x7BBC9B15A0")]
		public CSFriendInviteReq()
		{
		}

		// Token: 0x0400274D RID: 10061
		[Token(Token = "0x400274D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11112EC", Offset = "0x11112EC")]
		public ulong inviter_id;

		// Token: 0x0400274E RID: 10062
		[Token(Token = "0x400274E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111300", Offset = "0x1111300")]
		public uint activity_id;

		// Token: 0x0400274F RID: 10063
		[Token(Token = "0x400274F")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111314", Offset = "0x1111314")]
		public bool is_friend;
	}
}
