using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000750 RID: 1872
	[Token(Token = "0x2000750")]
	[ProtoContract]
	public class CSGetCupTeamInvitationListReq
	{
		// Token: 0x0600245D RID: 9309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245D")]
		[Address(RVA = "0x21B2F3C", Offset = "0x21B2F3C", VA = "0x7BBC9B2F3C")]
		public CSGetCupTeamInvitationListReq()
		{
		}

		// Token: 0x040024E0 RID: 9440
		[Token(Token = "0x40024E0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CFE4", Offset = "0x110CFE4")]
		public uint cup_type;

		// Token: 0x040024E1 RID: 9441
		[Token(Token = "0x40024E1")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CFF8", Offset = "0x110CFF8")]
		public uint cup_id;
	}
}
