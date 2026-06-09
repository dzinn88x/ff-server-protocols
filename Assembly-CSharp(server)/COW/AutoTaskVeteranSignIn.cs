using System;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x0200133E RID: 4926
	[Token(Token = "0x200133E")]
	internal class AutoTaskVeteranSignIn : AutoPopupTask
	{
		// Token: 0x06004E1A RID: 19994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1A")]
		[Address(RVA = "0x155BFA8", Offset = "0x155BFA8", VA = "0x7BBBD5BFA8", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004E1B RID: 19995 RVA: 0x00017C70 File Offset: 0x00015E70
		[Token(Token = "0x6004E1B")]
		[Address(RVA = "0x155C028", Offset = "0x155C028", VA = "0x7BBBD5C028", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x00017C88 File Offset: 0x00015E88
		[Token(Token = "0x6004E1C")]
		[Address(RVA = "0x155C170", Offset = "0x155C170", VA = "0x7BBBD5C170", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E1D")]
		[Address(RVA = "0x155C210", Offset = "0x155C210", VA = "0x7BBBD5C210")]
		public AutoTaskVeteranSignIn()
		{
		}

		// Token: 0x04007553 RID: 30035
		[Token(Token = "0x4007553")]
		[FieldOffset(Offset = "0x10")]
		private UIBaseController m_VeteranUI;
	}
}
