using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001DE3 RID: 7651
	[Token(Token = "0x2001DE3")]
	public class FastChampionshipTeamInvite : FastMessage
	{
		// Token: 0x0600A738 RID: 42808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A738")]
		[Address(RVA = "0x1B95730", Offset = "0x1B95730", VA = "0x7BBC395730")]
		public FastChampionshipTeamInvite()
		{
		}

		// Token: 0x0400ACD8 RID: 44248
		[Token(Token = "0x400ACD8")]
		[FieldOffset(Offset = "0x18")]
		public ulong TeamID;

		// Token: 0x0400ACD9 RID: 44249
		[Token(Token = "0x400ACD9")]
		[FieldOffset(Offset = "0x20")]
		public uint ChampionshipType;

		// Token: 0x0400ACDA RID: 44250
		[Token(Token = "0x400ACDA")]
		[FieldOffset(Offset = "0x24")]
		public uint ChampionshipID;

		// Token: 0x0400ACDB RID: 44251
		[Token(Token = "0x400ACDB")]
		[FieldOffset(Offset = "0x28")]
		public uint MemberNum;
	}
}
