using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A51 RID: 2641
	[Token(Token = "0x2000A51")]
	[ProtoContract]
	public class GameOutputDesc
	{
		// Token: 0x0600275B RID: 10075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275B")]
		[Address(RVA = "0x21BA8F8", Offset = "0x21BA8F8", VA = "0x7BBC9BA8F8")]
		public GameOutputDesc()
		{
		}

		// Token: 0x0400302A RID: 12330
		[Token(Token = "0x400302A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120A44", Offset = "0x1120A44")]
		public uint group_mode;

		// Token: 0x0400302B RID: 12331
		[Token(Token = "0x400302B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120A58", Offset = "0x1120A58")]
		public uint time_limit_gp;

		// Token: 0x0400302C RID: 12332
		[Token(Token = "0x400302C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120A6C", Offset = "0x1120A6C")]
		public uint rank_factor_gp;

		// Token: 0x0400302D RID: 12333
		[Token(Token = "0x400302D")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120A80", Offset = "0x1120A80")]
		public uint mode_factor_gp;

		// Token: 0x0400302E RID: 12334
		[Token(Token = "0x400302E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120A94", Offset = "0x1120A94")]
		public uint chicken_factor_gp;

		// Token: 0x0400302F RID: 12335
		[Token(Token = "0x400302F")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120AA8", Offset = "0x1120AA8")]
		public uint time_limit_xp;

		// Token: 0x04003030 RID: 12336
		[Token(Token = "0x4003030")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120ABC", Offset = "0x1120ABC")]
		public uint rank_factor_xp;

		// Token: 0x04003031 RID: 12337
		[Token(Token = "0x4003031")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120AD0", Offset = "0x1120AD0")]
		public uint mode_factor_xp;

		// Token: 0x04003032 RID: 12338
		[Token(Token = "0x4003032")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120AE4", Offset = "0x1120AE4")]
		public uint chicken_factor_xp;

		// Token: 0x04003033 RID: 12339
		[Token(Token = "0x4003033")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120AF8", Offset = "0x1120AF8")]
		public uint game_mode;

		// Token: 0x04003034 RID: 12340
		[Token(Token = "0x4003034")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120B0C", Offset = "0x1120B0C")]
		public uint map_id;
	}
}
