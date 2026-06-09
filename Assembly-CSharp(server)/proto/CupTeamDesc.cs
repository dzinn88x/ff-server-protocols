using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B4E RID: 2894
	[Token(Token = "0x2000B4E")]
	[ProtoContract]
	public class CupTeamDesc
	{
		// Token: 0x06002856 RID: 10326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002856")]
		[Address(RVA = "0x21B92B4", Offset = "0x21B92B4", VA = "0x7BBC9B92B4")]
		public CupTeamDesc()
		{
		}

		// Token: 0x040036FF RID: 14079
		[Token(Token = "0x40036FF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DE60", Offset = "0x112DE60")]
		public uint limit_num;

		// Token: 0x04003700 RID: 14080
		[Token(Token = "0x4003700")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DE74", Offset = "0x112DE74")]
		public uint clean_time;

		// Token: 0x04003701 RID: 14081
		[Token(Token = "0x4003701")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DE88", Offset = "0x112DE88")]
		public uint player_apply_num;

		// Token: 0x04003702 RID: 14082
		[Token(Token = "0x4003702")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DE9C", Offset = "0x112DE9C")]
		public uint team_invite_num;

		// Token: 0x04003703 RID: 14083
		[Token(Token = "0x4003703")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DEB0", Offset = "0x112DEB0")]
		public uint team_join_cd;

		// Token: 0x04003704 RID: 14084
		[Token(Token = "0x4003704")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DEC4", Offset = "0x112DEC4")]
		public uint team_exit_cd;
	}
}
