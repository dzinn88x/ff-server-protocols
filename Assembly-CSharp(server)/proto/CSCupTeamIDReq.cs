using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000747 RID: 1863
	[Token(Token = "0x2000747")]
	[ProtoContract]
	public class CSCupTeamIDReq
	{
		// Token: 0x06002454 RID: 9300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002454")]
		[Address(RVA = "0x21B0E38", Offset = "0x21B0E38", VA = "0x7BBC9B0E38")]
		public CSCupTeamIDReq()
		{
		}

		// Token: 0x040024D1 RID: 9425
		[Token(Token = "0x40024D1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CE68", Offset = "0x110CE68")]
		public ulong team_id;
	}
}
