using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200070E RID: 1806
	[Token(Token = "0x200070E")]
	[ProtoContract]
	public class CSPlayerRankingInfoRes
	{
		// Token: 0x0600241B RID: 9243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241B")]
		[Address(RVA = "0x21B6F00", Offset = "0x21B6F00", VA = "0x7BBC9B6F00")]
		public CSPlayerRankingInfoRes()
		{
		}

		// Token: 0x0400240E RID: 9230
		[Token(Token = "0x400240E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BBF8", Offset = "0x110BBF8")]
		public ulong account_id;

		// Token: 0x0400240F RID: 9231
		[Token(Token = "0x400240F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BC0C", Offset = "0x110BC0C")]
		public uint season_id;

		// Token: 0x04002410 RID: 9232
		[Token(Token = "0x4002410")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BC20", Offset = "0x110BC20")]
		public uint rank;

		// Token: 0x04002411 RID: 9233
		[Token(Token = "0x4002411")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BC34", Offset = "0x110BC34")]
		public uint max_rank;

		// Token: 0x04002412 RID: 9234
		[Token(Token = "0x4002412")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BC48", Offset = "0x110BC48")]
		public uint ranking_points;

		// Token: 0x04002413 RID: 9235
		[Token(Token = "0x4002413")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BC5C", Offset = "0x110BC5C")]
		public bool show_rank;

		// Token: 0x04002414 RID: 9236
		[Token(Token = "0x4002414")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BC70", Offset = "0x110BC70")]
		public RankingInfo last_season_info;

		// Token: 0x04002415 RID: 9237
		[Token(Token = "0x4002415")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BC84", Offset = "0x110BC84")]
		public uint match_token_num;

		// Token: 0x04002416 RID: 9238
		[Token(Token = "0x4002416")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BC98", Offset = "0x110BC98")]
		public uint ranking_bot_points;
	}
}
