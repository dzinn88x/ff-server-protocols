using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200071B RID: 1819
	[Token(Token = "0x200071B")]
	[ProtoContract]
	public class CSPlayerCSRankingInfoRes
	{
		// Token: 0x06002428 RID: 9256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002428")]
		[Address(RVA = "0x21B6E6C", Offset = "0x21B6E6C", VA = "0x7BBC9B6E6C")]
		public CSPlayerCSRankingInfoRes()
		{
		}

		// Token: 0x04002439 RID: 9273
		[Token(Token = "0x4002439")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BFA4", Offset = "0x110BFA4")]
		public ulong account_id;

		// Token: 0x0400243A RID: 9274
		[Token(Token = "0x400243A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BFB8", Offset = "0x110BFB8")]
		public uint season_id;

		// Token: 0x0400243B RID: 9275
		[Token(Token = "0x400243B")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BFCC", Offset = "0x110BFCC")]
		public uint rank;

		// Token: 0x0400243C RID: 9276
		[Token(Token = "0x400243C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BFE0", Offset = "0x110BFE0")]
		public uint max_rank;

		// Token: 0x0400243D RID: 9277
		[Token(Token = "0x400243D")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BFF4", Offset = "0x110BFF4")]
		public uint ranking_points;

		// Token: 0x0400243E RID: 9278
		[Token(Token = "0x400243E")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C008", Offset = "0x110C008")]
		public bool show_rank;

		// Token: 0x0400243F RID: 9279
		[Token(Token = "0x400243F")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C01C", Offset = "0x110C01C")]
		public uint star;

		// Token: 0x04002440 RID: 9280
		[Token(Token = "0x4002440")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C030", Offset = "0x110C030")]
		public uint hang_ups;

		// Token: 0x04002441 RID: 9281
		[Token(Token = "0x4002441")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C044", Offset = "0x110C044")]
		public bool is_hang_up_ban;

		// Token: 0x04002442 RID: 9282
		[Token(Token = "0x4002442")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C058", Offset = "0x110C058")]
		public uint star_protect_points;
	}
}
