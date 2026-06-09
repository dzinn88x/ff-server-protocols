using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001358 RID: 4952
	[Token(Token = "0x2001358")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB238", Offset = "0x10EB238")]
	internal class UIFFWSGuessAwardPageController : UIPopupWindowController
	{
		// Token: 0x06004EB2 RID: 20146 RVA: 0x00018078 File Offset: 0x00016278
		[Token(Token = "0x6004EB2")]
		[Address(RVA = "0x22740A0", Offset = "0x22740A0", VA = "0x7BBCA740A0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004EB3 RID: 20147 RVA: 0x00018090 File Offset: 0x00016290
		[Token(Token = "0x6004EB3")]
		[Address(RVA = "0x22740F0", Offset = "0x22740F0", VA = "0x7BBCA740F0", Slot = "34")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x06004EB4 RID: 20148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB4")]
		[Address(RVA = "0x22740F8", Offset = "0x22740F8", VA = "0x7BBCA740F8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004EB5 RID: 20149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB5")]
		[Address(RVA = "0x2274458", Offset = "0x2274458", VA = "0x7BBCA74458", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB6")]
		[Address(RVA = "0x2274520", Offset = "0x2274520", VA = "0x7BBCA74520")]
		public void SetData(List<AwardDesc> winAwards, List<AwardDesc> loseAwards, ELimitedEvent.FFWSGuessingAwardType claimType)
		{
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB7")]
		[Address(RVA = "0x22743CC", Offset = "0x22743CC", VA = "0x7BBCA743CC")]
		private void PlayEntranceAnim()
		{
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB8")]
		[Address(RVA = "0x2274AC8", Offset = "0x2274AC8", VA = "0x7BBCA74AC8")]
		private void OnEntranceAnimFinishing()
		{
		}

		// Token: 0x06004EB9 RID: 20153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB9")]
		[Address(RVA = "0x2274480", Offset = "0x2274480", VA = "0x7BBCA74480")]
		private void CancelDelayCall()
		{
		}

		// Token: 0x06004EBA RID: 20154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EBA")]
		[Address(RVA = "0x2274B24", Offset = "0x2274B24", VA = "0x7BBCA74B24")]
		public UIFFWSGuessAwardPageController()
		{
		}

		// Token: 0x040075E6 RID: 30182
		[Token(Token = "0x40075E6")]
		[FieldOffset(Offset = "0x98")]
		private UIFFWSGuessAwardPageView m_View;

		// Token: 0x040075E7 RID: 30183
		[Token(Token = "0x40075E7")]
		[FieldOffset(Offset = "0xA0")]
		private float m_ShowClickCloseBtnDuration;

		// Token: 0x040075E8 RID: 30184
		[Token(Token = "0x40075E8")]
		[FieldOffset(Offset = "0xA4")]
		private uint m_DelayCallID;
	}
}
