using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001323 RID: 4899
	[Token(Token = "0x2001323")]
	public class AutoPopupNewbieVeteranTask : AutoPopupTask
	{
		// Token: 0x06004DB0 RID: 19888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB0")]
		[Address(RVA = "0x1556470", Offset = "0x1556470", VA = "0x7BBBD56470", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x000177F0 File Offset: 0x000159F0
		[Token(Token = "0x6004DB1")]
		[Address(RVA = "0x1556478", Offset = "0x1556478", VA = "0x7BBBD56478", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x00017808 File Offset: 0x00015A08
		[Token(Token = "0x6004DB2")]
		[Address(RVA = "0x1556518", Offset = "0x1556518", VA = "0x7BBBD56518", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB3")]
		[Address(RVA = "0x1556640", Offset = "0x1556640", VA = "0x7BBBD56640")]
		public AutoPopupNewbieVeteranTask()
		{
		}

		// Token: 0x04007538 RID: 30008
		[Token(Token = "0x4007538")]
		[FieldOffset(Offset = "0x10")]
		private UICheckIsNewbieOrVeteranController m_CheckUI;
	}
}
