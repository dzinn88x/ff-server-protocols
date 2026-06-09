using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001703 RID: 5891
	[Token(Token = "0x2001703")]
	internal class ChatWhisperNameData
	{
		// Token: 0x06006D99 RID: 28057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D99")]
		[Address(RVA = "0x14F6904", Offset = "0x14F6904", VA = "0x7BBBCF6904")]
		public ChatWhisperNameData()
		{
		}

		// Token: 0x040088A0 RID: 34976
		[Token(Token = "0x40088A0")]
		[FieldOffset(Offset = "0x10")]
		public FriendAccountInfo m_FriendInfo;

		// Token: 0x040088A1 RID: 34977
		[Token(Token = "0x40088A1")]
		[FieldOffset(Offset = "0x18")]
		public bool m_IsSelect;

		// Token: 0x040088A2 RID: 34978
		[Token(Token = "0x40088A2")]
		[FieldOffset(Offset = "0x1C")]
		public EWhipserContainerShowTab m_CurTab;
	}
}
