using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000762 RID: 1890
	[Token(Token = "0x2000762")]
	[ProtoContract]
	public class SubmitTeamCupMatchStatsReq
	{
		// Token: 0x0600246F RID: 9327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600246F")]
		[Address(RVA = "0x24A09E0", Offset = "0x24A09E0", VA = "0x7BBCCA09E0")]
		public SubmitTeamCupMatchStatsReq()
		{
		}

		// Token: 0x04002514 RID: 9492
		[Token(Token = "0x4002514")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D55C", Offset = "0x110D55C")]
		public ulong match_id;

		// Token: 0x04002515 RID: 9493
		[Token(Token = "0x4002515")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D570", Offset = "0x110D570")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110D570", Offset = "0x110D570")]
		public string lock_region;

		// Token: 0x04002516 RID: 9494
		[Token(Token = "0x4002516")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D5C0", Offset = "0x110D5C0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110D5C0", Offset = "0x110D5C0")]
		public string noti_region;

		// Token: 0x04002517 RID: 9495
		[Token(Token = "0x4002517")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D610", Offset = "0x110D610")]
		public CupMatchStats stats;
	}
}
