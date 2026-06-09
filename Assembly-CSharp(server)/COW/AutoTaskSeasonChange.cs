using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x0200133B RID: 4923
	[Token(Token = "0x200133B")]
	internal class AutoTaskSeasonChange : AutoPopupTask
	{
		// Token: 0x06004E0E RID: 19982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E0E")]
		[Address(RVA = "0x155B4CC", Offset = "0x155B4CC", VA = "0x7BBBD5B4CC", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004E0F RID: 19983 RVA: 0x00017BE0 File Offset: 0x00015DE0
		[Token(Token = "0x6004E0F")]
		[Address(RVA = "0x155B54C", Offset = "0x155B54C", VA = "0x7BBBD5B54C", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004E10 RID: 19984 RVA: 0x00017BF8 File Offset: 0x00015DF8
		[Token(Token = "0x6004E10")]
		[Address(RVA = "0x155B6C4", Offset = "0x155B6C4", VA = "0x7BBBD5B6C4", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004E11 RID: 19985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E11")]
		[Address(RVA = "0x155B764", Offset = "0x155B764", VA = "0x7BBBD5B764")]
		public AutoTaskSeasonChange()
		{
		}

		// Token: 0x04007550 RID: 30032
		[Token(Token = "0x4007550")]
		[FieldOffset(Offset = "0x10")]
		private UILadderMatchSeasonChangeController m_LadderMatchSeasonChangeCtrl;
	}
}
