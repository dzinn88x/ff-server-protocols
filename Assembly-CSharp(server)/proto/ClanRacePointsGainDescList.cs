using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A40 RID: 2624
	[Token(Token = "0x2000A40")]
	[ProtoContract]
	public class ClanRacePointsGainDescList
	{
		// Token: 0x0600274A RID: 10058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600274A")]
		[Address(RVA = "0x21B8A2C", Offset = "0x21B8A2C", VA = "0x7BBC9B8A2C")]
		public ClanRacePointsGainDescList()
		{
		}

		// Token: 0x04002FDD RID: 12253
		[Token(Token = "0x4002FDD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120260", Offset = "0x1120260")]
		public List<ClanRacePointsGainDesc> rp_gain_list;
	}
}
