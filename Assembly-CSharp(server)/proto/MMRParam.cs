using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A4B RID: 2635
	[Token(Token = "0x2000A4B")]
	[ProtoContract]
	public class MMRParam
	{
		// Token: 0x06002755 RID: 10069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002755")]
		[Address(RVA = "0x21BC0D0", Offset = "0x21BC0D0", VA = "0x7BBC9BC0D0")]
		public MMRParam()
		{
		}

		// Token: 0x04003000 RID: 12288
		[Token(Token = "0x4003000")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11206C0", Offset = "0x11206C0")]
		public uint group_mode;

		// Token: 0x04003001 RID: 12289
		[Token(Token = "0x4003001")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11206D4", Offset = "0x11206D4")]
		public uint game_mode;

		// Token: 0x04003002 RID: 12290
		[Token(Token = "0x4003002")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11206E8", Offset = "0x11206E8")]
		public uint map_id;

		// Token: 0x04003003 RID: 12291
		[Token(Token = "0x4003003")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11206FC", Offset = "0x11206FC")]
		public float kill_real_player_avg;

		// Token: 0x04003004 RID: 12292
		[Token(Token = "0x4003004")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120710", Offset = "0x1120710")]
		public float kill_bot_avg;

		// Token: 0x04003005 RID: 12293
		[Token(Token = "0x4003005")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120724", Offset = "0x1120724")]
		public float rank_base_mmr;

		// Token: 0x04003006 RID: 12294
		[Token(Token = "0x4003006")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120738", Offset = "0x1120738")]
		public float real_rank_base_mmr;

		// Token: 0x04003007 RID: 12295
		[Token(Token = "0x4003007")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112074C", Offset = "0x112074C")]
		public float kill_real_player_base_mmr;

		// Token: 0x04003008 RID: 12296
		[Token(Token = "0x4003008")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120760", Offset = "0x1120760")]
		public float kill_bot_base_mmr;
	}
}
