using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000752 RID: 1874
	[Token(Token = "0x2000752")]
	[ProtoContract]
	public class CSQuitCupTeamReq
	{
		// Token: 0x0600245F RID: 9311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245F")]
		[Address(RVA = "0x21B7000", Offset = "0x21B7000", VA = "0x7BBC9B7000")]
		public CSQuitCupTeamReq()
		{
		}

		// Token: 0x040024E4 RID: 9444
		[Token(Token = "0x40024E4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D034", Offset = "0x110D034")]
		public ulong team_id;
	}
}
