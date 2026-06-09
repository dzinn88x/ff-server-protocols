using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x0200133A RID: 4922
	[Token(Token = "0x200133A")]
	internal class AutoTaskSeaonChange : AutoPopupTask
	{
		// Token: 0x06004E0A RID: 19978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E0A")]
		[Address(RVA = "0x155B1EC", Offset = "0x155B1EC", VA = "0x7BBBD5B1EC", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x00017BB0 File Offset: 0x00015DB0
		[Token(Token = "0x6004E0B")]
		[Address(RVA = "0x155B290", Offset = "0x155B290", VA = "0x7BBBD5B290", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004E0C RID: 19980 RVA: 0x00017BC8 File Offset: 0x00015DC8
		[Token(Token = "0x6004E0C")]
		[Address(RVA = "0x155B424", Offset = "0x155B424", VA = "0x7BBBD5B424", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004E0D RID: 19981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E0D")]
		[Address(RVA = "0x155B4C4", Offset = "0x155B4C4", VA = "0x7BBBD5B4C4")]
		public AutoTaskSeaonChange()
		{
		}

		// Token: 0x0400754F RID: 30031
		[Token(Token = "0x400754F")]
		[FieldOffset(Offset = "0x10")]
		private UILadderMatchSeasonChangeController m_LadderMatchSeasonChangeCtrl;
	}
}
