using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B2A RID: 2858
	[Token(Token = "0x2000B2A")]
	[ProtoContract]
	public class SuperFighterEnemyDesc
	{
		// Token: 0x06002832 RID: 10290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002832")]
		[Address(RVA = "0x24A0AAC", Offset = "0x24A0AAC", VA = "0x7BBCCA0AAC")]
		public SuperFighterEnemyDesc()
		{
		}

		// Token: 0x04003637 RID: 13879
		[Token(Token = "0x4003637")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C4C0", Offset = "0x112C4C0")]
		public uint stage;

		// Token: 0x04003638 RID: 13880
		[Token(Token = "0x4003638")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C4D4", Offset = "0x112C4D4")]
		public uint light_punch;

		// Token: 0x04003639 RID: 13881
		[Token(Token = "0x4003639")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C4E8", Offset = "0x112C4E8")]
		public uint heavy_punch;

		// Token: 0x0400363A RID: 13882
		[Token(Token = "0x400363A")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C4FC", Offset = "0x112C4FC")]
		public uint unique_punch;

		// Token: 0x0400363B RID: 13883
		[Token(Token = "0x400363B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C510", Offset = "0x112C510")]
		public uint enemy_health;

		// Token: 0x0400363C RID: 13884
		[Token(Token = "0x400363C")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C524", Offset = "0x112C524")]
		public uint player_health;

		// Token: 0x0400363D RID: 13885
		[Token(Token = "0x400363D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112C538", Offset = "0x112C538")]
		public AwardDesc reward;
	}
}
