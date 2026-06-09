using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001333 RID: 4915
	[Token(Token = "0x2001333")]
	internal class AutoTaskIAPBundleFirstTime : AutoPopupTask
	{
		// Token: 0x06004DED RID: 19949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DED")]
		[Address(RVA = "0x1559E88", Offset = "0x1559E88", VA = "0x7BBBD59E88", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x00017A60 File Offset: 0x00015C60
		[Token(Token = "0x6004DEE")]
		[Address(RVA = "0x1559F08", Offset = "0x1559F08", VA = "0x7BBBD59F08", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x00017A78 File Offset: 0x00015C78
		[Token(Token = "0x6004DEF")]
		[Address(RVA = "0x155A270", Offset = "0x155A270", VA = "0x7BBBD5A270", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DF0 RID: 19952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF0")]
		[Address(RVA = "0x155A310", Offset = "0x155A310", VA = "0x7BBBD5A310")]
		public AutoTaskIAPBundleFirstTime()
		{
		}

		// Token: 0x04007549 RID: 30025
		[Token(Token = "0x4007549")]
		[FieldOffset(Offset = "0x10")]
		private UIIAPBundleController m_IAPBundleController;
	}
}
