using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200098F RID: 2447
	[Token(Token = "0x200098F")]
	[ProtoContract]
	public class CSSuperFighterAttackRes
	{
		// Token: 0x0600269D RID: 9885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269D")]
		[Address(RVA = "0x21B7718", Offset = "0x21B7718", VA = "0x7BBC9B7718")]
		public CSSuperFighterAttackRes()
		{
		}

		// Token: 0x04002C45 RID: 11333
		[Token(Token = "0x4002C45")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119DFC", Offset = "0x1119DFC")]
		public uint player_damage;

		// Token: 0x04002C46 RID: 11334
		[Token(Token = "0x4002C46")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119E10", Offset = "0x1119E10")]
		public ELimitedEvent.SuperFighterManner enemy_manner;

		// Token: 0x04002C47 RID: 11335
		[Token(Token = "0x4002C47")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119E24", Offset = "0x1119E24")]
		public uint enemy_damage;

		// Token: 0x04002C48 RID: 11336
		[Token(Token = "0x4002C48")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119E38", Offset = "0x1119E38")]
		public ELimitedEvent.SuperFighterResult result;

		// Token: 0x04002C49 RID: 11337
		[Token(Token = "0x4002C49")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119E4C", Offset = "0x1119E4C")]
		public bool is_big_reward;

		// Token: 0x04002C4A RID: 11338
		[Token(Token = "0x4002C4A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119E60", Offset = "0x1119E60")]
		public AwardDesc reward;
	}
}
