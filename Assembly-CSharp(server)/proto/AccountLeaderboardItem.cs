using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000736 RID: 1846
	[Token(Token = "0x2000736")]
	[ProtoContract]
	public class AccountLeaderboardItem
	{
		// Token: 0x06002443 RID: 9283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002443")]
		[Address(RVA = "0x21AE5FC", Offset = "0x21AE5FC", VA = "0x7BBC9AE5FC")]
		public AccountLeaderboardItem()
		{
		}

		// Token: 0x04002492 RID: 9362
		[Token(Token = "0x4002492")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C828", Offset = "0x110C828")]
		public ulong account_id;

		// Token: 0x04002493 RID: 9363
		[Token(Token = "0x4002493")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C83C", Offset = "0x110C83C")]
		public double score;

		// Token: 0x04002494 RID: 9364
		[Token(Token = "0x4002494")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C850", Offset = "0x110C850")]
		public AccountLeaderboardProfile account_profile;

		// Token: 0x04002495 RID: 9365
		[Token(Token = "0x4002495")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C864", Offset = "0x110C864")]
		public int pos;
	}
}
