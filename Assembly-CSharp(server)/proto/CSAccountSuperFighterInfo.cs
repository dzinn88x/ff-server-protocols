using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200098D RID: 2445
	[Token(Token = "0x200098D")]
	[ProtoContract]
	public class CSAccountSuperFighterInfo
	{
		// Token: 0x0600269B RID: 9883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269B")]
		[Address(RVA = "0x21B0198", Offset = "0x21B0198", VA = "0x7BBC9B0198")]
		public CSAccountSuperFighterInfo()
		{
		}

		// Token: 0x04002C40 RID: 11328
		[Token(Token = "0x4002C40")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119D98", Offset = "0x1119D98")]
		public uint win_round;

		// Token: 0x04002C41 RID: 11329
		[Token(Token = "0x4002C41")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119DAC", Offset = "0x1119DAC")]
		public uint enemy_stage;

		// Token: 0x04002C42 RID: 11330
		[Token(Token = "0x4002C42")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119DC0", Offset = "0x1119DC0")]
		public uint player_health;

		// Token: 0x04002C43 RID: 11331
		[Token(Token = "0x4002C43")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119DD4", Offset = "0x1119DD4")]
		public uint enemy_health;
	}
}
