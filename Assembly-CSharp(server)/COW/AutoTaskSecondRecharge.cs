using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x0200133C RID: 4924
	[Token(Token = "0x200133C")]
	internal class AutoTaskSecondRecharge : AutoPopupTask
	{
		// Token: 0x06004E12 RID: 19986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E12")]
		[Address(RVA = "0x155B76C", Offset = "0x155B76C", VA = "0x7BBBD5B76C", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004E13 RID: 19987 RVA: 0x00017C10 File Offset: 0x00015E10
		[Token(Token = "0x6004E13")]
		[Address(RVA = "0x155B774", Offset = "0x155B774", VA = "0x7BBBD5B774", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004E14 RID: 19988 RVA: 0x00017C28 File Offset: 0x00015E28
		[Token(Token = "0x6004E14")]
		[Address(RVA = "0x155B944", Offset = "0x155B944", VA = "0x7BBBD5B944", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E15")]
		[Address(RVA = "0x155B9E4", Offset = "0x155B9E4", VA = "0x7BBBD5B9E4")]
		public AutoTaskSecondRecharge()
		{
		}

		// Token: 0x04007551 RID: 30033
		[Token(Token = "0x4007551")]
		[FieldOffset(Offset = "0x10")]
		private UISecondRechargeController m_PopupWnd;
	}
}
