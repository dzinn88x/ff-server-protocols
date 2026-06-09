using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001324 RID: 4900
	[Token(Token = "0x2001324")]
	public class AutoPopupSplashBannerTask : AutoPopupTask
	{
		// Token: 0x06004DB4 RID: 19892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB4")]
		[Address(RVA = "0x1556650", Offset = "0x1556650", VA = "0x7BBBD56650", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x00017820 File Offset: 0x00015A20
		[Token(Token = "0x6004DB5")]
		[Address(RVA = "0x15566D0", Offset = "0x15566D0", VA = "0x7BBBD566D0", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x00017838 File Offset: 0x00015A38
		[Token(Token = "0x6004DB6")]
		[Address(RVA = "0x15569BC", Offset = "0x15569BC", VA = "0x7BBBD569BC", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB7")]
		[Address(RVA = "0x1556CA0", Offset = "0x1556CA0", VA = "0x7BBBD56CA0")]
		private void OnSplashBannerItemClose(bool lateShow = false)
		{
		}

		// Token: 0x06004DB8 RID: 19896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB8")]
		[Address(RVA = "0x1556704", Offset = "0x1556704", VA = "0x7BBBD56704")]
		private void ShowSplashBannerItem(SplashBannerInfo info)
		{
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB9")]
		[Address(RVA = "0x1556D88", Offset = "0x1556D88", VA = "0x7BBBD56D88")]
		public AutoPopupSplashBannerTask()
		{
		}

		// Token: 0x04007539 RID: 30009
		[Token(Token = "0x4007539")]
		[FieldOffset(Offset = "0x10")]
		private SplashBannerInfo m_NextBannerInfo;

		// Token: 0x0400753A RID: 30010
		[Token(Token = "0x400753A")]
		[FieldOffset(Offset = "0x18")]
		private bool m_AllSplashUIClose;
	}
}
