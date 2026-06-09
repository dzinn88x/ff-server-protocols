using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x0200132C RID: 4908
	[Token(Token = "0x200132C")]
	public class AutoTaskDebt : AutoPopupTask
	{
		// Token: 0x06004DD1 RID: 19921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD1")]
		[Address(RVA = "0x15587B0", Offset = "0x15587B0", VA = "0x7BBBD587B0", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DD2 RID: 19922 RVA: 0x00017910 File Offset: 0x00015B10
		[Token(Token = "0x6004DD2")]
		[Address(RVA = "0x15587B8", Offset = "0x15587B8", VA = "0x7BBBD587B8", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DD3 RID: 19923 RVA: 0x00017928 File Offset: 0x00015B28
		[Token(Token = "0x6004DD3")]
		[Address(RVA = "0x1558944", Offset = "0x1558944", VA = "0x7BBBD58944", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DD4 RID: 19924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD4")]
		[Address(RVA = "0x15589E4", Offset = "0x15589E4", VA = "0x7BBBD589E4")]
		public AutoTaskDebt()
		{
		}

		// Token: 0x04007543 RID: 30019
		[Token(Token = "0x4007543")]
		[FieldOffset(Offset = "0x10")]
		private UIDebtWindowController m_DebtUI;
	}
}
