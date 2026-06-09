using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000749 RID: 1865
	[Token(Token = "0x2000749")]
	[ProtoContract]
	public class CSCupTeamIDSliceReq
	{
		// Token: 0x06002456 RID: 9302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002456")]
		[Address(RVA = "0x21B0E40", Offset = "0x21B0E40", VA = "0x7BBC9B0E40")]
		public CSCupTeamIDSliceReq()
		{
		}

		// Token: 0x040024D3 RID: 9427
		[Token(Token = "0x40024D3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CE90", Offset = "0x110CE90")]
		public ulong[] team_ids;
	}
}
