using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x0200133D RID: 4925
	[Token(Token = "0x200133D")]
	internal class AutoTaskShowTask : AutoPopupTask
	{
		// Token: 0x06004E16 RID: 19990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E16")]
		[Address(RVA = "0x155B9EC", Offset = "0x155B9EC", VA = "0x7BBBD5B9EC", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x00017C40 File Offset: 0x00015E40
		[Token(Token = "0x6004E17")]
		[Address(RVA = "0x155BA58", Offset = "0x155BA58", VA = "0x7BBBD5BA58", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x00017C58 File Offset: 0x00015E58
		[Token(Token = "0x6004E18")]
		[Address(RVA = "0x155BF00", Offset = "0x155BF00", VA = "0x7BBBD5BF00", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E19")]
		[Address(RVA = "0x155BFA0", Offset = "0x155BFA0", VA = "0x7BBBD5BFA0")]
		public AutoTaskShowTask()
		{
		}

		// Token: 0x04007552 RID: 30034
		[Token(Token = "0x4007552")]
		[FieldOffset(Offset = "0x10")]
		private UITaskController m_TaskUI;
	}
}
