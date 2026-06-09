using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000738 RID: 1848
	[Token(Token = "0x2000738")]
	[ProtoContract]
	public class CSGetLeaderBoardThresholdScoreRes
	{
		// Token: 0x06002445 RID: 9285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002445")]
		[Address(RVA = "0x21B4434", Offset = "0x21B4434", VA = "0x7BBC9B4434")]
		public CSGetLeaderBoardThresholdScoreRes()
		{
		}

		// Token: 0x04002499 RID: 9369
		[Token(Token = "0x4002499")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C8B4", Offset = "0x110C8B4")]
		public double score;
	}
}
