using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000917 RID: 2327
	[Token(Token = "0x2000917")]
	[ProtoContract]
	public class TeamMatchStats
	{
		// Token: 0x06002625 RID: 9765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002625")]
		[Address(RVA = "0x24A0E94", Offset = "0x24A0E94", VA = "0x7BBCCA0E94")]
		public TeamMatchStats()
		{
		}

		// Token: 0x04002B2F RID: 11055
		[Token(Token = "0x4002B2F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118470", Offset = "0x1118470")]
		public ulong team_id;

		// Token: 0x04002B30 RID: 11056
		[Token(Token = "0x4002B30")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118484", Offset = "0x1118484")]
		public ulong[] member_account_ids;

		// Token: 0x04002B31 RID: 11057
		[Token(Token = "0x4002B31")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11184C0", Offset = "0x11184C0")]
		public uint rank;

		// Token: 0x04002B32 RID: 11058
		[Token(Token = "0x4002B32")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11184D4", Offset = "0x11184D4")]
		public uint kills;

		// Token: 0x04002B33 RID: 11059
		[Token(Token = "0x4002B33")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11184E8", Offset = "0x11184E8")]
		public uint damage;

		// Token: 0x04002B34 RID: 11060
		[Token(Token = "0x4002B34")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11184FC", Offset = "0x11184FC")]
		public uint moving_distance;

		// Token: 0x04002B35 RID: 11061
		[Token(Token = "0x4002B35")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118510", Offset = "0x1118510")]
		public uint revival_count;

		// Token: 0x04002B36 RID: 11062
		[Token(Token = "0x4002B36")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118524", Offset = "0x1118524")]
		public uint survival_time;

		// Token: 0x04002B37 RID: 11063
		[Token(Token = "0x4002B37")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118538", Offset = "0x1118538")]
		public uint headshot_kills;

		// Token: 0x04002B38 RID: 11064
		[Token(Token = "0x4002B38")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111854C", Offset = "0x111854C")]
		public uint birth_island_quit;

		// Token: 0x04002B39 RID: 11065
		[Token(Token = "0x4002B39")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118560", Offset = "0x1118560")]
		public uint knockdown_count;

		// Token: 0x04002B3A RID: 11066
		[Token(Token = "0x4002B3A")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118574", Offset = "0x1118574")]
		public uint team_count;

		// Token: 0x04002B3B RID: 11067
		[Token(Token = "0x4002B3B")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118588", Offset = "0x1118588")]
		public uint direct_kills;
	}
}
