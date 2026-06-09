using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000981 RID: 2433
	[Token(Token = "0x2000981")]
	[ProtoContract]
	public class GoliathAFKGroupMember
	{
		// Token: 0x0600268F RID: 9871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268F")]
		[Address(RVA = "0x21BAF6C", Offset = "0x21BAF6C", VA = "0x7BBC9BAF6C")]
		public GoliathAFKGroupMember()
		{
		}

		// Token: 0x04002C2C RID: 11308
		[Token(Token = "0x4002C2C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119B54", Offset = "0x1119B54")]
		public ulong account_id;

		// Token: 0x04002C2D RID: 11309
		[Token(Token = "0x4002C2D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1119B68", Offset = "0x1119B68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119B68", Offset = "0x1119B68")]
		public string nickname;

		// Token: 0x04002C2E RID: 11310
		[Token(Token = "0x4002C2E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119BB8", Offset = "0x1119BB8")]
		public bool award_claimed;
	}
}
