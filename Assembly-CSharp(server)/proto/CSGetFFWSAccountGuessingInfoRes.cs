using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009BB RID: 2491
	[Token(Token = "0x20009BB")]
	[ProtoContract]
	public class CSGetFFWSAccountGuessingInfoRes
	{
		// Token: 0x060026C9 RID: 9929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C9")]
		[Address(RVA = "0x21B34AC", Offset = "0x21B34AC", VA = "0x7BBC9B34AC")]
		public CSGetFFWSAccountGuessingInfoRes()
		{
		}

		// Token: 0x04002CBA RID: 11450
		[Token(Token = "0x4002CBA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A8D8", Offset = "0x111A8D8")]
		public List<FFWSTeamResultsDesc> team_results;

		// Token: 0x04002CBB RID: 11451
		[Token(Token = "0x4002CBB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A8EC", Offset = "0x111A8EC")]
		public uint[] ai_guess_results;

		// Token: 0x04002CBC RID: 11452
		[Token(Token = "0x4002CBC")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A928", Offset = "0x111A928")]
		public uint[] player_guess_results;

		// Token: 0x04002CBD RID: 11453
		[Token(Token = "0x4002CBD")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A964", Offset = "0x111A964")]
		public List<ELimitedEvent.FFWSGuessingAwardStatus> award_status;
	}
}
