using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200075B RID: 1883
	[Token(Token = "0x200075B")]
	[ProtoContract]
	public class CSGetCupTeamInfoByTeamIDsOrderlyRes
	{
		// Token: 0x06002468 RID: 9320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002468")]
		[Address(RVA = "0x21B2EC8", Offset = "0x21B2EC8", VA = "0x7BBC9B2EC8")]
		public CSGetCupTeamInfoByTeamIDsOrderlyRes()
		{
		}

		// Token: 0x040024FB RID: 9467
		[Token(Token = "0x40024FB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D2A0", Offset = "0x110D2A0")]
		public List<CupTeamInfo> infos;
	}
}
