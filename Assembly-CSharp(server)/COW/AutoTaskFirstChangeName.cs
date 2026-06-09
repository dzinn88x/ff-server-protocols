using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001330 RID: 4912
	[Token(Token = "0x2001330")]
	public class AutoTaskFirstChangeName : AutoPopupTask
	{
		// Token: 0x06004DE1 RID: 19937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DE1")]
		[Address(RVA = "0x1558FD8", Offset = "0x1558FD8", VA = "0x7BBBD58FD8", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DE2 RID: 19938 RVA: 0x000179D0 File Offset: 0x00015BD0
		[Token(Token = "0x6004DE2")]
		[Address(RVA = "0x1558FE0", Offset = "0x1558FE0", VA = "0x7BBBD58FE0", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DE3 RID: 19939 RVA: 0x000179E8 File Offset: 0x00015BE8
		[Token(Token = "0x6004DE3")]
		[Address(RVA = "0x155915C", Offset = "0x155915C", VA = "0x7BBBD5915C", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DE4 RID: 19940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE4")]
		[Address(RVA = "0x15591FC", Offset = "0x15591FC", VA = "0x7BBBD591FC")]
		public AutoTaskFirstChangeName()
		{
		}

		// Token: 0x04007546 RID: 30022
		[Token(Token = "0x4007546")]
		[FieldOffset(Offset = "0x10")]
		private UIFirstChangeNamePopupWindowController m_ChangeNameUI;
	}
}
