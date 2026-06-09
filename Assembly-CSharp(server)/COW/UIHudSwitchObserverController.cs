using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200196C RID: 6508
	[Token(Token = "0x200196C")]
	internal class UIHudSwitchObserverController : UIBaseController
	{
		// Token: 0x06008462 RID: 33890 RVA: 0x00023EF8 File Offset: 0x000220F8
		[Token(Token = "0x6008462")]
		[Address(RVA = "0x16764FC", Offset = "0x16764FC", VA = "0x7BBBE764FC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008463 RID: 33891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008463")]
		[Address(RVA = "0x167654C", Offset = "0x167654C", VA = "0x7BBBE7654C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008464 RID: 33892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008464")]
		[Address(RVA = "0x16767E8", Offset = "0x16767E8", VA = "0x7BBBE767E8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008465 RID: 33893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008465")]
		[Address(RVA = "0x167695C", Offset = "0x167695C", VA = "0x7BBBE7695C")]
		private void OnSwitchPrevBtnClick()
		{
		}

		// Token: 0x06008466 RID: 33894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008466")]
		[Address(RVA = "0x1676A40", Offset = "0x1676A40", VA = "0x7BBBE76A40")]
		private void OnSwitchNextBtnClick()
		{
		}

		// Token: 0x06008467 RID: 33895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008467")]
		[Address(RVA = "0x1676B24", Offset = "0x1676B24", VA = "0x7BBBE76B24")]
		private void OnObserverInfoListVisibleChanged(object[] data)
		{
		}

		// Token: 0x06008468 RID: 33896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008468")]
		[Address(RVA = "0x1676BCC", Offset = "0x1676BCC", VA = "0x7BBBE76BCC")]
		private void OnObserverSwitch(object[] data)
		{
		}

		// Token: 0x06008469 RID: 33897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008469")]
		[Address(RVA = "0x1676CCC", Offset = "0x1676CCC", VA = "0x7BBBE76CCC")]
		private void OnQuitRevive(object[] data)
		{
		}

		// Token: 0x0600846A RID: 33898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600846A")]
		[Address(RVA = "0x1676DCC", Offset = "0x1676DCC", VA = "0x7BBBE76DCC")]
		public UIHudSwitchObserverController()
		{
		}

		// Token: 0x040094B3 RID: 38067
		[Token(Token = "0x40094B3")]
		[FieldOffset(Offset = "0x58")]
		private UIHudSwitchObserverView m_View;
	}
}
