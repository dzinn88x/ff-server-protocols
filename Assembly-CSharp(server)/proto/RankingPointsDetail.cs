using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000703 RID: 1795
	[Token(Token = "0x2000703")]
	[ProtoContract]
	public class RankingPointsDetail
	{
		// Token: 0x06002411 RID: 9233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002411")]
		[Address(RVA = "0x249FB1C", Offset = "0x249FB1C", VA = "0x7BBCC9FB1C")]
		public RankingPointsDetail()
		{
		}

		// Token: 0x040023B8 RID: 9144
		[Token(Token = "0x40023B8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B43C", Offset = "0x110B43C")]
		public int ranking_score;

		// Token: 0x040023B9 RID: 9145
		[Token(Token = "0x40023B9")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B450", Offset = "0x110B450")]
		public int battle_score;

		// Token: 0x040023BA RID: 9146
		[Token(Token = "0x40023BA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B464", Offset = "0x110B464")]
		public int newbie_score;

		// Token: 0x040023BB RID: 9147
		[Token(Token = "0x40023BB")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B478", Offset = "0x110B478")]
		public int victory_score;

		// Token: 0x040023BC RID: 9148
		[Token(Token = "0x40023BC")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B48C", Offset = "0x110B48C")]
		public int first_win_score;

		// Token: 0x040023BD RID: 9149
		[Token(Token = "0x40023BD")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B4A0", Offset = "0x110B4A0")]
		public bool chicken_protect;

		// Token: 0x040023BE RID: 9150
		[Token(Token = "0x40023BE")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B4B4", Offset = "0x110B4B4")]
		public int birth_island_quit_score;

		// Token: 0x040023BF RID: 9151
		[Token(Token = "0x40023BF")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B4C8", Offset = "0x110B4C8")]
		public int scale_ranking_score;

		// Token: 0x040023C0 RID: 9152
		[Token(Token = "0x40023C0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B4DC", Offset = "0x110B4DC")]
		public int scale_battle_score;
	}
}
