using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000705 RID: 1797
	[Token(Token = "0x2000705")]
	[ProtoContract]
	public class ExpDetail
	{
		// Token: 0x06002413 RID: 9235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002413")]
		[Address(RVA = "0x21B9FAC", Offset = "0x21B9FAC", VA = "0x7BBC9B9FAC")]
		public ExpDetail()
		{
		}

		// Token: 0x040023C7 RID: 9159
		[Token(Token = "0x40023C7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B568", Offset = "0x110B568")]
		public uint exp_match;

		// Token: 0x040023C8 RID: 9160
		[Token(Token = "0x40023C8")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B57C", Offset = "0x110B57C")]
		public uint exp_clan_buff;

		// Token: 0x040023C9 RID: 9161
		[Token(Token = "0x40023C9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B590", Offset = "0x110B590")]
		public uint exp_event_bonus;

		// Token: 0x040023CA RID: 9162
		[Token(Token = "0x40023CA")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B5A4", Offset = "0x110B5A4")]
		public uint exp_card;

		// Token: 0x040023CB RID: 9163
		[Token(Token = "0x40023CB")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B5B8", Offset = "0x110B5B8")]
		public uint exp_ranking;

		// Token: 0x040023CC RID: 9164
		[Token(Token = "0x40023CC")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B5CC", Offset = "0x110B5CC")]
		public uint exp_championship;

		// Token: 0x040023CD RID: 9165
		[Token(Token = "0x40023CD")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B5E0", Offset = "0x110B5E0")]
		public uint exp_other_bonus;
	}
}
