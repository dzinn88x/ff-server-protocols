using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001326 RID: 4902
	[Token(Token = "0x2001326")]
	public class AutoTaskAddictGuild : AutoPopupTask
	{
		// Token: 0x06004DBE RID: 19902 RVA: 0x00017850 File Offset: 0x00015A50
		[Token(Token = "0x6004DBE")]
		[Address(RVA = "0x1556D90", Offset = "0x1556D90", VA = "0x7BBBD56D90", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DBF RID: 19903 RVA: 0x00017868 File Offset: 0x00015A68
		[Token(Token = "0x6004DBF")]
		[Address(RVA = "0x1556F10", Offset = "0x1556F10", VA = "0x7BBBD56F10", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DC0 RID: 19904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DC0")]
		[Address(RVA = "0x1556FB0", Offset = "0x1556FB0", VA = "0x7BBBD56FB0", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DC1 RID: 19905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC1")]
		[Address(RVA = "0x1556FB8", Offset = "0x1556FB8", VA = "0x7BBBD56FB8")]
		public AutoTaskAddictGuild()
		{
		}

		// Token: 0x0400753B RID: 30011
		[Token(Token = "0x400753B")]
		[FieldOffset(Offset = "0x10")]
		private UIAddictConfirmController m_UIAddictConfirmController;
	}
}
