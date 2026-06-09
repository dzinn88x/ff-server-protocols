using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200074C RID: 1868
	[Token(Token = "0x200074C")]
	[ProtoContract]
	public class CSJoinCupTeamReq
	{
		// Token: 0x06002459 RID: 9305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002459")]
		[Address(RVA = "0x21B65D8", Offset = "0x21B65D8", VA = "0x7BBC9B65D8")]
		public CSJoinCupTeamReq()
		{
		}

		// Token: 0x040024D8 RID: 9432
		[Token(Token = "0x40024D8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CF1C", Offset = "0x110CF1C")]
		public ulong team_id;

		// Token: 0x040024D9 RID: 9433
		[Token(Token = "0x40024D9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CF30", Offset = "0x110CF30")]
		public bool recruit_by_chat;
	}
}
