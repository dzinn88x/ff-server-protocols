using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200090F RID: 2319
	[Token(Token = "0x200090F")]
	[ProtoContract]
	public class TeamChampionshipInfo
	{
		// Token: 0x0600261D RID: 9757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600261D")]
		[Address(RVA = "0x24A0D10", Offset = "0x24A0D10", VA = "0x7BBCCA0D10")]
		public TeamChampionshipInfo()
		{
		}

		// Token: 0x04002AF8 RID: 11000
		[Token(Token = "0x4002AF8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117FC0", Offset = "0x1117FC0")]
		public ulong team_id;

		// Token: 0x04002AF9 RID: 11001
		[Token(Token = "0x4002AF9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117FD4", Offset = "0x1117FD4")]
		public uint championship_type;

		// Token: 0x04002AFA RID: 11002
		[Token(Token = "0x4002AFA")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117FE8", Offset = "0x1117FE8")]
		public uint championship_id;

		// Token: 0x04002AFB RID: 11003
		[Token(Token = "0x4002AFB")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117FFC", Offset = "0x1117FFC")]
		public uint tickets_num;

		// Token: 0x04002AFC RID: 11004
		[Token(Token = "0x4002AFC")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118010", Offset = "0x1118010")]
		public uint trial_games_played;

		// Token: 0x04002AFD RID: 11005
		[Token(Token = "0x4002AFD")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118024", Offset = "0x1118024")]
		public uint trial_kills;

		// Token: 0x04002AFE RID: 11006
		[Token(Token = "0x4002AFE")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118038", Offset = "0x1118038")]
		public uint trial_valid_score;

		// Token: 0x04002AFF RID: 11007
		[Token(Token = "0x4002AFF")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111804C", Offset = "0x111804C")]
		public uint trial_total_score;

		// Token: 0x04002B00 RID: 11008
		[Token(Token = "0x4002B00")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118060", Offset = "0x1118060")]
		public uint trial_pos;

		// Token: 0x04002B01 RID: 11009
		[Token(Token = "0x4002B01")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118074", Offset = "0x1118074")]
		public bool is_enter_final;

		// Token: 0x04002B02 RID: 11010
		[Token(Token = "0x4002B02")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118088", Offset = "0x1118088")]
		public uint final_games_played;

		// Token: 0x04002B03 RID: 11011
		[Token(Token = "0x4002B03")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111809C", Offset = "0x111809C")]
		public uint final_kills;

		// Token: 0x04002B04 RID: 11012
		[Token(Token = "0x4002B04")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11180B0", Offset = "0x11180B0")]
		public uint final_valid_score;

		// Token: 0x04002B05 RID: 11013
		[Token(Token = "0x4002B05")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11180C4", Offset = "0x11180C4")]
		public uint final_total_score;

		// Token: 0x04002B06 RID: 11014
		[Token(Token = "0x4002B06")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11180D8", Offset = "0x11180D8")]
		public uint final_pos;
	}
}
