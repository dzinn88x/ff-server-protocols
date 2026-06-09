using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000714 RID: 1812
	[Token(Token = "0x2000714")]
	[ProtoContract]
	public class CSResetNeedLastSeasonInfoReq
	{
		// Token: 0x06002421 RID: 9249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002421")]
		[Address(RVA = "0x21B74F0", Offset = "0x21B74F0", VA = "0x7BBC9B74F0")]
		public CSResetNeedLastSeasonInfoReq()
		{
		}

		// Token: 0x0400242C RID: 9260
		[Token(Token = "0x400242C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BE50", Offset = "0x110BE50")]
		public uint season_id;
	}
}
