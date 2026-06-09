using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000844 RID: 2116
	[Token(Token = "0x2000844")]
	[ProtoContract]
	public class CSClaimIntimacyAwardReq
	{
		// Token: 0x06002559 RID: 9561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002559")]
		[Address(RVA = "0x21B0898", Offset = "0x21B0898", VA = "0x7BBC9B0898")]
		public CSClaimIntimacyAwardReq()
		{
		}

		// Token: 0x0400277B RID: 10107
		[Token(Token = "0x400277B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11116AC", Offset = "0x11116AC")]
		public ulong related_friend_id;

		// Token: 0x0400277C RID: 10108
		[Token(Token = "0x400277C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11116C0", Offset = "0x11116C0")]
		public EFriend.RelationType relation_type;

		// Token: 0x0400277D RID: 10109
		[Token(Token = "0x400277D")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11116D4", Offset = "0x11116D4")]
		public uint intimacy_level;
	}
}
