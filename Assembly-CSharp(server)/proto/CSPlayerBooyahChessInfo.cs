using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200099B RID: 2459
	[Token(Token = "0x200099B")]
	[ProtoContract]
	public class CSPlayerBooyahChessInfo
	{
		// Token: 0x060026A9 RID: 9897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A9")]
		[Address(RVA = "0x21B6E5C", Offset = "0x21B6E5C", VA = "0x7BBC9B6E5C")]
		public CSPlayerBooyahChessInfo()
		{
		}

		// Token: 0x04002C67 RID: 11367
		[Token(Token = "0x4002C67")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A0E0", Offset = "0x111A0E0")]
		public ulong account_id;

		// Token: 0x04002C68 RID: 11368
		[Token(Token = "0x4002C68")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A0F4", Offset = "0x111A0F4")]
		public EMiniGame.GameStatus game_status;

		// Token: 0x04002C69 RID: 11369
		[Token(Token = "0x4002C69")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A108", Offset = "0x111A108")]
		public uint player_index;

		// Token: 0x04002C6A RID: 11370
		[Token(Token = "0x4002C6A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A11C", Offset = "0x111A11C")]
		public uint current_step;

		// Token: 0x04002C6B RID: 11371
		[Token(Token = "0x4002C6B")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A130", Offset = "0x111A130")]
		public uint current_weapon;

		// Token: 0x04002C6C RID: 11372
		[Token(Token = "0x4002C6C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A144", Offset = "0x111A144")]
		public uint booyah_times;

		// Token: 0x04002C6D RID: 11373
		[Token(Token = "0x4002C6D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A158", Offset = "0x111A158")]
		public Chessboard chessboard;

		// Token: 0x04002C6E RID: 11374
		[Token(Token = "0x4002C6E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A16C", Offset = "0x111A16C")]
		public Circle current_circle;

		// Token: 0x04002C6F RID: 11375
		[Token(Token = "0x4002C6F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A180", Offset = "0x111A180")]
		public uint current_reward_cnt;

		// Token: 0x04002C70 RID: 11376
		[Token(Token = "0x4002C70")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A194", Offset = "0x111A194")]
		public uint total_reward_cnt;

		// Token: 0x04002C71 RID: 11377
		[Token(Token = "0x4002C71")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A1A8", Offset = "0x111A1A8")]
		public bool is_booyah;

		// Token: 0x04002C72 RID: 11378
		[Token(Token = "0x4002C72")]
		[FieldOffset(Offset = "0x49")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A1BC", Offset = "0x111A1BC")]
		public bool is_finish;

		// Token: 0x04002C73 RID: 11379
		[Token(Token = "0x4002C73")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A1D0", Offset = "0x111A1D0")]
		public int booyah_index;

		// Token: 0x04002C74 RID: 11380
		[Token(Token = "0x4002C74")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A1E4", Offset = "0x111A1E4")]
		public uint play_times;
	}
}
