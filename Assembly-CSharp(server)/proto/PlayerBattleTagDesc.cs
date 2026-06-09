using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B44 RID: 2884
	[Token(Token = "0x2000B44")]
	[ProtoContract]
	public class PlayerBattleTagDesc
	{
		// Token: 0x0600284C RID: 10316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284C")]
		[Address(RVA = "0x249F650", Offset = "0x249F650", VA = "0x7BBCC9F650")]
		public PlayerBattleTagDesc()
		{
		}

		// Token: 0x040036C0 RID: 14016
		[Token(Token = "0x40036C0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D514", Offset = "0x112D514")]
		public ESocial.PlayerBattleTagID tag_id;

		// Token: 0x040036C1 RID: 14017
		[Token(Token = "0x40036C1")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D528", Offset = "0x112D528")]
		public uint tag_sub_id;

		// Token: 0x040036C2 RID: 14018
		[Token(Token = "0x40036C2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D53C", Offset = "0x112D53C")]
		public uint game_mode;

		// Token: 0x040036C3 RID: 14019
		[Token(Token = "0x40036C3")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D550", Offset = "0x112D550")]
		public uint match_mode;

		// Token: 0x040036C4 RID: 14020
		[Token(Token = "0x40036C4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D564", Offset = "0x112D564")]
		public uint tag_priority;

		// Token: 0x040036C5 RID: 14021
		[Token(Token = "0x40036C5")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D578", Offset = "0x112D578")]
		public List<PlayerBattleTagCdt> battle_tag_cdt;
	}
}
