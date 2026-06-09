using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000668 RID: 1640
	[Token(Token = "0x2000668")]
	[ProtoContract]
	public class ERanking
	{
		// Token: 0x060023BB RID: 9147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BB")]
		[Address(RVA = "0x21B9B24", Offset = "0x21B9B24", VA = "0x7BBC9B9B24")]
		public ERanking()
		{
		}

		// Token: 0x02000669 RID: 1641
		[Token(Token = "0x2000669")]
		[ProtoContract]
		public enum ActivityType
		{
			// Token: 0x0400205B RID: 8283
			[Token(Token = "0x400205B")]
			ActivityType_NONE,
			// Token: 0x0400205C RID: 8284
			[Token(Token = "0x400205C")]
			ActivityType_NO_DEDUCT,
			// Token: 0x0400205D RID: 8285
			[Token(Token = "0x400205D")]
			ActivityType_DOUBLE_RANKING_POINT,
			// Token: 0x0400205E RID: 8286
			[Token(Token = "0x400205E")]
			ActivityType_DOUBLE_TOKEN
		}

		// Token: 0x0200066A RID: 1642
		[Token(Token = "0x200066A")]
		[ProtoContract]
		public enum RankingType
		{
			// Token: 0x04002060 RID: 8288
			[Token(Token = "0x4002060")]
			RankingType_NONE,
			// Token: 0x04002061 RID: 8289
			[Token(Token = "0x4002061")]
			RankingType_NORMAL,
			// Token: 0x04002062 RID: 8290
			[Token(Token = "0x4002062")]
			RankingType_CS
		}
	}
}
