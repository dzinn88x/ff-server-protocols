using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001E68 RID: 7784
	[Token(Token = "0x2001E68")]
	public class RecentPlayerInfo : IComparable<RecentPlayerInfo>
	{
		// Token: 0x0600AAD4 RID: 43732 RVA: 0x0002ECE0 File Offset: 0x0002CEE0
		[Token(Token = "0x600AAD4")]
		[Address(RVA = "0x1752300", Offset = "0x1752300", VA = "0x7BBBF52300", Slot = "4")]
		public int CompareTo(RecentPlayerInfo other)
		{
			return 0;
		}

		// Token: 0x0600AAD5 RID: 43733 RVA: 0x0002ECF8 File Offset: 0x0002CEF8
		[Token(Token = "0x600AAD5")]
		[Address(RVA = "0x1752388", Offset = "0x1752388", VA = "0x7BBBF52388")]
		public int ComparePresence(EPresence.AccountPresence presence)
		{
			return 0;
		}

		// Token: 0x0600AAD6 RID: 43734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAD6")]
		[Address(RVA = "0x1752424", Offset = "0x1752424", VA = "0x7BBBF52424")]
		public RecentPlayerInfo()
		{
		}

		// Token: 0x0400AFEE RID: 45038
		[Token(Token = "0x400AFEE")]
		[FieldOffset(Offset = "0x10")]
		public ulong m_Time;

		// Token: 0x0400AFEF RID: 45039
		[Token(Token = "0x400AFEF")]
		[FieldOffset(Offset = "0x18")]
		public ERecentPlayerType m_Type;

		// Token: 0x0400AFF0 RID: 45040
		[Token(Token = "0x400AFF0")]
		[FieldOffset(Offset = "0x20")]
		public FriendAccountInfo m_Info;
	}
}
