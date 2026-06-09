using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000924 RID: 2340
	[Token(Token = "0x2000924")]
	[ProtoContract]
	public class CSTeamMatchStatsHistoryReq
	{
		// Token: 0x06002632 RID: 9778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002632")]
		[Address(RVA = "0x21B79A4", Offset = "0x21B79A4", VA = "0x7BBC9B79A4")]
		public CSTeamMatchStatsHistoryReq()
		{
		}

		// Token: 0x04002B62 RID: 11106
		[Token(Token = "0x4002B62")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118894", Offset = "0x1118894")]
		public ulong team_id;

		// Token: 0x04002B63 RID: 11107
		[Token(Token = "0x4002B63")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11188A8", Offset = "0x11188A8")]
		public uint championship_type;

		// Token: 0x04002B64 RID: 11108
		[Token(Token = "0x4002B64")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11188BC", Offset = "0x11188BC")]
		public uint championship_id;
	}
}
