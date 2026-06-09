using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000733 RID: 1843
	[Token(Token = "0x2000733")]
	[ProtoContract]
	public class AccountLeaderboardProfile
	{
		// Token: 0x06002440 RID: 9280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002440")]
		[Address(RVA = "0x21AE604", Offset = "0x21AE604", VA = "0x7BBC9AE604")]
		public AccountLeaderboardProfile()
		{
		}

		// Token: 0x04002489 RID: 9353
		[Token(Token = "0x4002489")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C774", Offset = "0x110C774")]
		public AccountInfoBasic basic_info;

		// Token: 0x0400248A RID: 9354
		[Token(Token = "0x400248A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C788", Offset = "0x110C788")]
		public AccountInfoWithStats stat;

		// Token: 0x0400248B RID: 9355
		[Token(Token = "0x400248B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C79C", Offset = "0x110C79C")]
		public uint rank;

		// Token: 0x0400248C RID: 9356
		[Token(Token = "0x400248C")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C7B0", Offset = "0x110C7B0")]
		public uint ranking_points;

		// Token: 0x0400248D RID: 9357
		[Token(Token = "0x400248D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C7C4", Offset = "0x110C7C4")]
		public byte[] limited_event_info;
	}
}
