using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001720 RID: 5920
	[Token(Token = "0x2001720")]
	public class AutoTaskClanLuckyBag : AutoPopupTask
	{
		// Token: 0x06006E6D RID: 28269 RVA: 0x0001F1A0 File Offset: 0x0001D3A0
		[Token(Token = "0x6006E6D")]
		[Address(RVA = "0x1558248", Offset = "0x1558248", VA = "0x7BBBD58248", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06006E6E RID: 28270 RVA: 0x0001F1B8 File Offset: 0x0001D3B8
		[Token(Token = "0x6006E6E")]
		[Address(RVA = "0x1558450", Offset = "0x1558450", VA = "0x7BBBD58450", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06006E6F RID: 28271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E6F")]
		[Address(RVA = "0x15584F0", Offset = "0x15584F0", VA = "0x7BBBD584F0", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06006E70 RID: 28272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E70")]
		[Address(RVA = "0x1558570", Offset = "0x1558570", VA = "0x7BBBD58570")]
		public AutoTaskClanLuckyBag()
		{
		}

		// Token: 0x04008909 RID: 35081
		[Token(Token = "0x4008909")]
		[FieldOffset(Offset = "0x10")]
		private UILuckyBagController m_LuckyBagUI;
	}
}
