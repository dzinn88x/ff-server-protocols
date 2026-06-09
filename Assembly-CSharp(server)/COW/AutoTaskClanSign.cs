using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x0200171F RID: 5919
	[Token(Token = "0x200171F")]
	public class AutoTaskClanSign : AutoPopupTask
	{
		// Token: 0x06006E69 RID: 28265 RVA: 0x0001F170 File Offset: 0x0001D370
		[Token(Token = "0x6006E69")]
		[Address(RVA = "0x1558578", Offset = "0x1558578", VA = "0x7BBBD58578", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06006E6A RID: 28266 RVA: 0x0001F188 File Offset: 0x0001D388
		[Token(Token = "0x6006E6A")]
		[Address(RVA = "0x1558700", Offset = "0x1558700", VA = "0x7BBBD58700", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06006E6B RID: 28267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E6B")]
		[Address(RVA = "0x15587A0", Offset = "0x15587A0", VA = "0x7BBBD587A0", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06006E6C RID: 28268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E6C")]
		[Address(RVA = "0x15587A8", Offset = "0x15587A8", VA = "0x7BBBD587A8")]
		public AutoTaskClanSign()
		{
		}

		// Token: 0x04008908 RID: 35080
		[Token(Token = "0x4008908")]
		[FieldOffset(Offset = "0x10")]
		private UIGuildSignInController m_SignUI;
	}
}
