using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AE1 RID: 2785
	[Token(Token = "0x2000AE1")]
	[ProtoContract]
	public class ChampionshipTeamDesc
	{
		// Token: 0x060027E9 RID: 10217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E9")]
		[Address(RVA = "0x21B8214", Offset = "0x21B8214", VA = "0x7BBC9B8214")]
		public ChampionshipTeamDesc()
		{
		}

		// Token: 0x04003471 RID: 13425
		[Token(Token = "0x4003471")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11288E8", Offset = "0x11288E8")]
		public uint player_num_limit;

		// Token: 0x04003472 RID: 13426
		[Token(Token = "0x4003472")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11288FC", Offset = "0x11288FC")]
		public uint limit_num;

		// Token: 0x04003473 RID: 13427
		[Token(Token = "0x4003473")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128910", Offset = "0x1128910")]
		public uint clean_time;

		// Token: 0x04003474 RID: 13428
		[Token(Token = "0x4003474")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128924", Offset = "0x1128924")]
		public uint player_apply_num;

		// Token: 0x04003475 RID: 13429
		[Token(Token = "0x4003475")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128938", Offset = "0x1128938")]
		public uint team_invite_num;

		// Token: 0x04003476 RID: 13430
		[Token(Token = "0x4003476")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112894C", Offset = "0x112894C")]
		public uint team_exit_cd;

		// Token: 0x04003477 RID: 13431
		[Token(Token = "0x4003477")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128960", Offset = "0x1128960")]
		public uint team_join_cd;

		// Token: 0x04003478 RID: 13432
		[Token(Token = "0x4003478")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128974", Offset = "0x1128974")]
		public uint team_scale_type;
	}
}
