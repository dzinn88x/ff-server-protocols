using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000745 RID: 1861
	[Token(Token = "0x2000745")]
	[ProtoContract]
	public class CSCreateCupTeamRes
	{
		// Token: 0x06002452 RID: 9298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002452")]
		[Address(RVA = "0x21B0D4C", Offset = "0x21B0D4C", VA = "0x7BBC9B0D4C")]
		public CSCreateCupTeamRes()
		{
		}

		// Token: 0x040024CE RID: 9422
		[Token(Token = "0x40024CE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CE2C", Offset = "0x110CE2C")]
		public ulong team_id;
	}
}
