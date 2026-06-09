using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000928 RID: 2344
	[Token(Token = "0x2000928")]
	[ProtoContract]
	public class FakeSubmitRes
	{
		// Token: 0x06002636 RID: 9782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002636")]
		[Address(RVA = "0x21BA2CC", Offset = "0x21BA2CC", VA = "0x7BBC9BA2CC")]
		public FakeSubmitRes()
		{
		}

		// Token: 0x04002B72 RID: 11122
		[Token(Token = "0x4002B72")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118A4C", Offset = "0x1118A4C")]
		public SubmitChampionshipTeamMatchStatsReq fake_submit_req;

		// Token: 0x04002B73 RID: 11123
		[Token(Token = "0x4002B73")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118A60", Offset = "0x1118A60")]
		public FakeSubmitScore score;
	}
}
