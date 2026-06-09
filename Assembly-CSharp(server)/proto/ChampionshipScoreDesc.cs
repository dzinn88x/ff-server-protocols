using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AE2 RID: 2786
	[Token(Token = "0x2000AE2")]
	[ProtoContract]
	public class ChampionshipScoreDesc
	{
		// Token: 0x060027EA RID: 10218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EA")]
		[Address(RVA = "0x21B8114", Offset = "0x21B8114", VA = "0x7BBC9B8114")]
		public ChampionshipScoreDesc()
		{
		}

		// Token: 0x04003479 RID: 13433
		[Token(Token = "0x4003479")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128988", Offset = "0x1128988")]
		public uint championship_type;

		// Token: 0x0400347A RID: 13434
		[Token(Token = "0x400347A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112899C", Offset = "0x112899C")]
		public uint rank;

		// Token: 0x0400347B RID: 13435
		[Token(Token = "0x400347B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11289B0", Offset = "0x11289B0")]
		public uint rank_point;

		// Token: 0x0400347C RID: 13436
		[Token(Token = "0x400347C")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11289C4", Offset = "0x11289C4")]
		public uint game_mode;
	}
}
