using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001328 RID: 4904
	[Token(Token = "0x2001328")]
	internal class AutoTaskChampionship : AutoPopupTask
	{
		// Token: 0x06004DC6 RID: 19910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DC6")]
		[Address(RVA = "0x15572B4", Offset = "0x15572B4", VA = "0x7BBBD572B4", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DC7 RID: 19911 RVA: 0x000178B0 File Offset: 0x00015AB0
		[Token(Token = "0x6004DC7")]
		[Address(RVA = "0x1557334", Offset = "0x1557334", VA = "0x7BBBD57334", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DC8 RID: 19912 RVA: 0x000178C8 File Offset: 0x00015AC8
		[Token(Token = "0x6004DC8")]
		[Address(RVA = "0x1557B3C", Offset = "0x1557B3C", VA = "0x7BBBD57B3C", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DC9 RID: 19913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DC9")]
		[Address(RVA = "0x1557BDC", Offset = "0x1557BDC", VA = "0x7BBBD57BDC")]
		public AutoTaskChampionship()
		{
		}

		// Token: 0x0400753D RID: 30013
		[Token(Token = "0x400753D")]
		[FieldOffset(Offset = "0x10")]
		private UIChampionshipAnimController m_ChampionshipAnimCtrl;
	}
}
