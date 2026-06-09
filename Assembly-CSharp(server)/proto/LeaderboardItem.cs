using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200072F RID: 1839
	[Token(Token = "0x200072F")]
	[ProtoContract]
	public class LeaderboardItem
	{
		// Token: 0x0600243C RID: 9276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243C")]
		[Address(RVA = "0x21BB93C", Offset = "0x21BB93C", VA = "0x7BBC9BB93C")]
		public LeaderboardItem()
		{
		}

		// Token: 0x04002479 RID: 9337
		[Token(Token = "0x4002479")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C634", Offset = "0x110C634")]
		public ulong unique_id;

		// Token: 0x0400247A RID: 9338
		[Token(Token = "0x400247A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C648", Offset = "0x110C648")]
		public double score;

		// Token: 0x0400247B RID: 9339
		[Token(Token = "0x400247B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C65C", Offset = "0x110C65C")]
		public LeaderboardProfile profile;

		// Token: 0x0400247C RID: 9340
		[Token(Token = "0x400247C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C670", Offset = "0x110C670")]
		public int pos;
	}
}
