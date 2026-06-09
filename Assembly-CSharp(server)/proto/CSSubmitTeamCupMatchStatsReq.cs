using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200074B RID: 1867
	[Token(Token = "0x200074B")]
	[ProtoContract]
	public class CSSubmitTeamCupMatchStatsReq
	{
		// Token: 0x06002458 RID: 9304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002458")]
		[Address(RVA = "0x21B7708", Offset = "0x21B7708", VA = "0x7BBC9B7708")]
		public CSSubmitTeamCupMatchStatsReq()
		{
		}

		// Token: 0x040024D6 RID: 9430
		[Token(Token = "0x40024D6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CEF4", Offset = "0x110CEF4")]
		public ulong match_id;

		// Token: 0x040024D7 RID: 9431
		[Token(Token = "0x40024D7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CF08", Offset = "0x110CF08")]
		public CupMatchStats stats;
	}
}
