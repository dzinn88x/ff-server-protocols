using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AB9 RID: 2745
	[Token(Token = "0x2000AB9")]
	[ProtoContract]
	public class TeammateIntimacyInfoDesc
	{
		// Token: 0x060027C3 RID: 10179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C3")]
		[Address(RVA = "0x24A0FE8", Offset = "0x24A0FE8", VA = "0x7BBCCA0FE8")]
		public TeammateIntimacyInfoDesc()
		{
		}

		// Token: 0x0400339E RID: 13214
		[Token(Token = "0x400339E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127100", Offset = "0x1127100")]
		public uint idx;

		// Token: 0x0400339F RID: 13215
		[Token(Token = "0x400339F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127114", Offset = "0x1127114")]
		public EFriend.RelationType relation_type;

		// Token: 0x040033A0 RID: 13216
		[Token(Token = "0x40033A0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127128", Offset = "0x1127128")]
		public uint game_mode;

		// Token: 0x040033A1 RID: 13217
		[Token(Token = "0x40033A1")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112713C", Offset = "0x112713C")]
		public uint upper_ranking;

		// Token: 0x040033A2 RID: 13218
		[Token(Token = "0x40033A2")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127150", Offset = "0x1127150")]
		public uint lower_ranking;

		// Token: 0x040033A3 RID: 13219
		[Token(Token = "0x40033A3")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127164", Offset = "0x1127164")]
		public uint intimacy_value;
	}
}
