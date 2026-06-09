using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000751 RID: 1873
	[Token(Token = "0x2000751")]
	[ProtoContract]
	public class CSRemoveCupTeamMemberReq
	{
		// Token: 0x0600245E RID: 9310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x21B73BC", Offset = "0x21B73BC", VA = "0x7BBC9B73BC")]
		public CSRemoveCupTeamMemberReq()
		{
		}

		// Token: 0x040024E2 RID: 9442
		[Token(Token = "0x40024E2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D00C", Offset = "0x110D00C")]
		public ulong team_id;

		// Token: 0x040024E3 RID: 9443
		[Token(Token = "0x40024E3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D020", Offset = "0x110D020")]
		public ulong removee_id;
	}
}
