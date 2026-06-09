using System;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x02001B6F RID: 7023
	[Token(Token = "0x2001B6F")]
	public class RoomPopMeanData
	{
		// Token: 0x06009739 RID: 38713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009739")]
		[Address(RVA = "0x1B32010", Offset = "0x1B32010", VA = "0x7BBC332010")]
		public RoomPopMeanData()
		{
		}

		// Token: 0x04009F74 RID: 40820
		[Token(Token = "0x4009F74")]
		[FieldOffset(Offset = "0x10")]
		public RoomPlayerInfo m_info;

		// Token: 0x04009F75 RID: 40821
		[Token(Token = "0x4009F75")]
		[FieldOffset(Offset = "0x18")]
		public int team_index;
	}
}
