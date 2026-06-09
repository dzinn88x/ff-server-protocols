using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CEE RID: 7406
	[Token(Token = "0x2001CEE")]
	[Serializable]
	internal class MatchResultScoreListConfig
	{
		// Token: 0x0600A193 RID: 41363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A193")]
		[Address(RVA = "0x1A5CC74", Offset = "0x1A5CC74", VA = "0x7BBC25CC74")]
		public MatchResultScoreListConfig()
		{
		}

		// Token: 0x0400A7FD RID: 43005
		[Token(Token = "0x400A7FD")]
		[FieldOffset(Offset = "0x10")]
		public MatchResultScore[] scoreList;
	}
}
