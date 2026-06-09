using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001334 RID: 4916
	[Token(Token = "0x2001334")]
	public class AutoTaskLeveUp : AutoPopupTask
	{
		// Token: 0x06004DF1 RID: 19953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF1")]
		[Address(RVA = "0x155A318", Offset = "0x155A318", VA = "0x7BBBD5A318", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x00017A90 File Offset: 0x00015C90
		[Token(Token = "0x6004DF2")]
		[Address(RVA = "0x155A320", Offset = "0x155A320", VA = "0x7BBBD5A320", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x00017AA8 File Offset: 0x00015CA8
		[Token(Token = "0x6004DF3")]
		[Address(RVA = "0x155A5E4", Offset = "0x155A5E4", VA = "0x7BBBD5A5E4", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DF4 RID: 19956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF4")]
		[Address(RVA = "0x155A684", Offset = "0x155A684", VA = "0x7BBBD5A684")]
		public AutoTaskLeveUp()
		{
		}

		// Token: 0x0400754A RID: 30026
		[Token(Token = "0x400754A")]
		[FieldOffset(Offset = "0x10")]
		private UILevelUpController m_LeveupWnd;
	}
}
