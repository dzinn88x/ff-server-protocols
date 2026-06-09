using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001327 RID: 4903
	[Token(Token = "0x2001327")]
	internal class AutoTaskBigEventAutoEntry : AutoPopupTask
	{
		// Token: 0x06004DC2 RID: 19906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DC2")]
		[Address(RVA = "0x1556FC0", Offset = "0x1556FC0", VA = "0x7BBBD56FC0", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DC3 RID: 19907 RVA: 0x00017880 File Offset: 0x00015A80
		[Token(Token = "0x6004DC3")]
		[Address(RVA = "0x1557064", Offset = "0x1557064", VA = "0x7BBBD57064", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DC4 RID: 19908 RVA: 0x00017898 File Offset: 0x00015A98
		[Token(Token = "0x6004DC4")]
		[Address(RVA = "0x155720C", Offset = "0x155720C", VA = "0x7BBBD5720C", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DC5 RID: 19909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC5")]
		[Address(RVA = "0x15572AC", Offset = "0x15572AC", VA = "0x7BBBD572AC")]
		public AutoTaskBigEventAutoEntry()
		{
		}

		// Token: 0x0400753C RID: 30012
		[Token(Token = "0x400753C")]
		[FieldOffset(Offset = "0x10")]
		private UIAnniversaryLobbyEnterWndControler m_PopupWnd;
	}
}
