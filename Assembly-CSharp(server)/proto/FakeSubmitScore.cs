using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000926 RID: 2342
	[Token(Token = "0x2000926")]
	[ProtoContract]
	public class FakeSubmitScore
	{
		// Token: 0x06002634 RID: 9780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002634")]
		[Address(RVA = "0x21BA2D4", Offset = "0x21BA2D4", VA = "0x7BBC9BA2D4")]
		public FakeSubmitScore()
		{
		}

		// Token: 0x04002B66 RID: 11110
		[Token(Token = "0x4002B66")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11188E4", Offset = "0x11188E4")]
		public int rank_score;

		// Token: 0x04002B67 RID: 11111
		[Token(Token = "0x4002B67")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11188F8", Offset = "0x11188F8")]
		public int battle_score;

		// Token: 0x04002B68 RID: 11112
		[Token(Token = "0x4002B68")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111890C", Offset = "0x111890C")]
		public int total_score;
	}
}
