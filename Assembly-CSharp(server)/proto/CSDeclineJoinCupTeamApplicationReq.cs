using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200074E RID: 1870
	[Token(Token = "0x200074E")]
	[ProtoContract]
	public class CSDeclineJoinCupTeamApplicationReq
	{
		// Token: 0x0600245B RID: 9307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245B")]
		[Address(RVA = "0x21B0ED4", Offset = "0x21B0ED4", VA = "0x7BBC9B0ED4")]
		public CSDeclineJoinCupTeamApplicationReq()
		{
		}

		// Token: 0x040024DC RID: 9436
		[Token(Token = "0x40024DC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CF6C", Offset = "0x110CF6C")]
		public ulong[] applicant_ids;

		// Token: 0x040024DD RID: 9437
		[Token(Token = "0x40024DD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CFA8", Offset = "0x110CFA8")]
		public ulong team_id;
	}
}
