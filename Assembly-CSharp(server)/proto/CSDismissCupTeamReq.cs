using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000754 RID: 1876
	[Token(Token = "0x2000754")]
	[ProtoContract]
	public class CSDismissCupTeamReq
	{
		// Token: 0x06002461 RID: 9313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002461")]
		[Address(RVA = "0x21B0F60", Offset = "0x21B0F60", VA = "0x7BBC9B0F60")]
		public CSDismissCupTeamReq()
		{
		}

		// Token: 0x040024EA RID: 9450
		[Token(Token = "0x40024EA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D124", Offset = "0x110D124")]
		public ulong team_id;
	}
}
