using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008A3 RID: 2211
	[Token(Token = "0x20008A3")]
	[ProtoContract]
	public class GetAttendanceRes
	{
		// Token: 0x060025B1 RID: 9649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B1")]
		[Address(RVA = "0x21BA9E4", Offset = "0x21BA9E4", VA = "0x7BBC9BA9E4")]
		public GetAttendanceRes()
		{
		}

		// Token: 0x0400298F RID: 10639
		[Token(Token = "0x400298F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115900", Offset = "0x1115900")]
		public CSGetNewPlayerRewardsListRes new_player_res;

		// Token: 0x04002990 RID: 10640
		[Token(Token = "0x4002990")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115914", Offset = "0x1115914")]
		public CSGetAttendanceListRes attendance_res;

		// Token: 0x04002991 RID: 10641
		[Token(Token = "0x4002991")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115928", Offset = "0x1115928")]
		public CSGetVeteranRewardListRes veteran_res;

		// Token: 0x04002992 RID: 10642
		[Token(Token = "0x4002992")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111593C", Offset = "0x111593C")]
		public CSClanSignInRes clan_sign_in_info;
	}
}
