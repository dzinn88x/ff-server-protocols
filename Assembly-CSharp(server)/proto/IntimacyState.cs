using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000637 RID: 1591
	[Token(Token = "0x2000637")]
	[ProtoContract]
	public class IntimacyState
	{
		// Token: 0x060023A1 RID: 9121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A1")]
		[Address(RVA = "0x21BB61C", Offset = "0x21BB61C", VA = "0x7BBC9BB61C")]
		public IntimacyState()
		{
		}

		// Token: 0x04001F90 RID: 8080
		[Token(Token = "0x4001F90")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108070", Offset = "0x1108070")]
		public ulong friend_id;

		// Token: 0x04001F91 RID: 8081
		[Token(Token = "0x4001F91")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108084", Offset = "0x1108084")]
		public EFriend.RelationType relation_type;

		// Token: 0x04001F92 RID: 8082
		[Token(Token = "0x4001F92")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108098", Offset = "0x1108098")]
		public uint intimacy;

		// Token: 0x04001F93 RID: 8083
		[Token(Token = "0x4001F93")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11080AC", Offset = "0x11080AC")]
		public long create_at;

		// Token: 0x04001F94 RID: 8084
		[Token(Token = "0x4001F94")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11080C0", Offset = "0x11080C0")]
		public uint maintain_days;

		// Token: 0x04001F95 RID: 8085
		[Token(Token = "0x4001F95")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11080D4", Offset = "0x11080D4")]
		public EFriend.SpecialFriendState state;

		// Token: 0x04001F96 RID: 8086
		[Token(Token = "0x4001F96")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11080E8", Offset = "0x11080E8")]
		public long request_at;

		// Token: 0x04001F97 RID: 8087
		[Token(Token = "0x4001F97")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11080FC", Offset = "0x11080FC")]
		public bool is_visible;
	}
}
