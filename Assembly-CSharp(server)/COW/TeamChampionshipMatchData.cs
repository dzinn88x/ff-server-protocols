using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020014A5 RID: 5285
	[Token(Token = "0x20014A5")]
	public class TeamChampionshipMatchData
	{
		// Token: 0x060059A1 RID: 22945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A1")]
		[Address(RVA = "0x1B45CE8", Offset = "0x1B45CE8", VA = "0x7BBC345CE8")]
		public TeamChampionshipMatchData()
		{
		}

		// Token: 0x04007D0E RID: 32014
		[Token(Token = "0x4007D0E")]
		[FieldOffset(Offset = "0x10")]
		public TeamChampionshipMatchStats matchStatus;

		// Token: 0x04007D0F RID: 32015
		[Token(Token = "0x4007D0F")]
		[FieldOffset(Offset = "0x18")]
		public bool isValid;
	}
}
