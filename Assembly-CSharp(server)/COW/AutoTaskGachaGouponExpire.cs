using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001331 RID: 4913
	[Token(Token = "0x2001331")]
	internal class AutoTaskGachaGouponExpire : AutoPopupTask
	{
		// Token: 0x06004DE5 RID: 19941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DE5")]
		[Address(RVA = "0x1559204", Offset = "0x1559204", VA = "0x7BBBD59204", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DE6 RID: 19942 RVA: 0x00017A00 File Offset: 0x00015C00
		[Token(Token = "0x6004DE6")]
		[Address(RVA = "0x1559284", Offset = "0x1559284", VA = "0x7BBBD59284", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DE7 RID: 19943 RVA: 0x00017A18 File Offset: 0x00015C18
		[Token(Token = "0x6004DE7")]
		[Address(RVA = "0x1559514", Offset = "0x1559514", VA = "0x7BBBD59514", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DE8 RID: 19944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE8")]
		[Address(RVA = "0x15595B4", Offset = "0x15595B4", VA = "0x7BBBD595B4")]
		public AutoTaskGachaGouponExpire()
		{
		}

		// Token: 0x04007547 RID: 30023
		[Token(Token = "0x4007547")]
		[FieldOffset(Offset = "0x10")]
		private UIGachaCouponExpireInfoController m_PopupWnd;
	}
}
