using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AB6 RID: 2742
	[Token(Token = "0x2000AB6")]
	[ProtoContract]
	public class FriendIntimacyDesc
	{
		// Token: 0x060027C0 RID: 10176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C0")]
		[Address(RVA = "0x21BA428", Offset = "0x21BA428", VA = "0x7BBC9BA428")]
		public FriendIntimacyDesc()
		{
		}

		// Token: 0x04003389 RID: 13193
		[Token(Token = "0x4003389")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126EE4", Offset = "0x1126EE4")]
		public EFriend.IntimacyType type;

		// Token: 0x0400338A RID: 13194
		[Token(Token = "0x400338A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126EF8", Offset = "0x1126EF8")]
		public uint intimacy;

		// Token: 0x0400338B RID: 13195
		[Token(Token = "0x400338B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126F0C", Offset = "0x1126F0C")]
		public bool enable;

		// Token: 0x0400338C RID: 13196
		[Token(Token = "0x400338C")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126F20", Offset = "0x1126F20")]
		public uint match_mode;

		// Token: 0x0400338D RID: 13197
		[Token(Token = "0x400338D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126F34", Offset = "0x1126F34")]
		public uint game_mode;
	}
}
