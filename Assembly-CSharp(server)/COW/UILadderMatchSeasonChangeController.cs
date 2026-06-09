using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001539 RID: 5433
	[Token(Token = "0x2001539")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE4A4", Offset = "0x10EE4A4")]
	internal class UILadderMatchSeasonChangeController : UIPopupWindowController
	{
		// Token: 0x06005DC0 RID: 24000 RVA: 0x0001B390 File Offset: 0x00019590
		[Token(Token = "0x6005DC0")]
		[Address(RVA = "0x1E941E8", Offset = "0x1E941E8", VA = "0x7BBC6941E8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005DC1 RID: 24001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC1")]
		[Address(RVA = "0x1E94238", Offset = "0x1E94238", VA = "0x7BBC694238", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06005DC2 RID: 24002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC2")]
		[Address(RVA = "0x1E94738", Offset = "0x1E94738", VA = "0x7BBC694738", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC3")]
		[Address(RVA = "0x1E94C24", Offset = "0x1E94C24", VA = "0x7BBC694C24")]
		private void Update()
		{
		}

		// Token: 0x06005DC4 RID: 24004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC4")]
		[Address(RVA = "0x1E94CBC", Offset = "0x1E94CBC", VA = "0x7BBC694CBC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06005DC5 RID: 24005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC5")]
		[Address(RVA = "0x1E9433C", Offset = "0x1E9433C", VA = "0x7BBC69433C")]
		private void ShowOldSeasonInfo()
		{
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC6")]
		[Address(RVA = "0x1E94D68", Offset = "0x1E94D68", VA = "0x7BBC694D68")]
		private void ShowNewSeasonInfo()
		{
		}

		// Token: 0x06005DC7 RID: 24007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC7")]
		[Address(RVA = "0x1E94FE8", Offset = "0x1E94FE8", VA = "0x7BBC694FE8")]
		private void ShowSeasonRank(uint rank, float rankPoint, string label_show, bool currentSeason)
		{
		}

		// Token: 0x06005DC8 RID: 24008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC8")]
		[Address(RVA = "0x1E956E8", Offset = "0x1E956E8", VA = "0x7BBC6956E8")]
		private void OnContinueBtnClick()
		{
		}

		// Token: 0x06005DC9 RID: 24009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DC9")]
		[Address(RVA = "0x1E95B5C", Offset = "0x1E95B5C", VA = "0x7BBC695B5C")]
		public UILadderMatchSeasonChangeController()
		{
		}

		// Token: 0x04007F69 RID: 32617
		[Token(Token = "0x4007F69")]
		[FieldOffset(Offset = "0x98")]
		private LadderMatchSeasonChangePopupView m_View;

		// Token: 0x04007F6A RID: 32618
		[Token(Token = "0x4007F6A")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelLadderMatch m_LadderModel;

		// Token: 0x04007F6B RID: 32619
		[Token(Token = "0x4007F6B")]
		[FieldOffset(Offset = "0xA8")]
		private int btn_click_count;

		// Token: 0x04007F6C RID: 32620
		[Token(Token = "0x4007F6C")]
		[FieldOffset(Offset = "0xAC")]
		private bool m_WaitForEnd;

		// Token: 0x04007F6D RID: 32621
		[Token(Token = "0x4007F6D")]
		private const float NEEDWAITTIME = 0.5f;

		// Token: 0x04007F6E RID: 32622
		[Token(Token = "0x4007F6E")]
		[FieldOffset(Offset = "0xB0")]
		private float m_WaitForEndTime;

		// Token: 0x04007F6F RID: 32623
		[Token(Token = "0x4007F6F")]
		[FieldOffset(Offset = "0xB4")]
		private float m_ClickWaitTime;

		// Token: 0x04007F70 RID: 32624
		[Token(Token = "0x4007F70")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_CanClick;

		// Token: 0x04007F71 RID: 32625
		[Token(Token = "0x4007F71")]
		[FieldOffset(Offset = "0xC0")]
		private RankingInfo lastSeasonInfo;
	}
}
