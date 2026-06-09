using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001882 RID: 6274
	[Token(Token = "0x2001882")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F438C", Offset = "0x10F438C")]
	internal class UIHudBombMatchInfoController : UIBaseController
	{
		// Token: 0x06007C0C RID: 31756 RVA: 0x00022170 File Offset: 0x00020370
		[Token(Token = "0x6007C0C")]
		[Address(RVA = "0x1899F50", Offset = "0x1899F50", VA = "0x7BBC099F50")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007C0D RID: 31757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C0D")]
		[Address(RVA = "0x1899FA0", Offset = "0x1899FA0", VA = "0x7BBC099FA0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007C0E RID: 31758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C0E")]
		[Address(RVA = "0x189A5EC", Offset = "0x189A5EC", VA = "0x7BBC09A5EC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007C0F RID: 31759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C0F")]
		[Address(RVA = "0x189A948", Offset = "0x189A948", VA = "0x7BBC09A948", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06007C10 RID: 31760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C10")]
		[Address(RVA = "0x189AA0C", Offset = "0x189AA0C", VA = "0x7BBC09AA0C")]
		private void OnBtnLeaderboardClick()
		{
		}

		// Token: 0x06007C11 RID: 31761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C11")]
		[Address(RVA = "0x189A980", Offset = "0x189A980", VA = "0x7BBC09A980")]
		private void SetUIData()
		{
		}

		// Token: 0x06007C12 RID: 31762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C12")]
		[Address(RVA = "0x189B078", Offset = "0x189B078", VA = "0x7BBC09B078")]
		private void RefreshTeamStatesUI({QAb\u0082~u pId)
		{
		}

		// Token: 0x06007C13 RID: 31763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C13")]
		[Address(RVA = "0x189ACB0", Offset = "0x189ACB0", VA = "0x7BBC09ACB0")]
		private void SetTeamStatesUI(List<{QAb\u0082~u> pids, List<UIHudCSPlayerStateInfoView> views, bool ascending = true)
		{
		}

		// Token: 0x06007C14 RID: 31764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C14")]
		[Address(RVA = "0x189B180", Offset = "0x189B180", VA = "0x7BBC09B180")]
		private void OnPlayerHPChanged(params object[] data)
		{
		}

		// Token: 0x06007C15 RID: 31765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C15")]
		[Address(RVA = "0x189B260", Offset = "0x189B260", VA = "0x7BBC09B260")]
		private void OnPlayerStateChanged(params object[] data)
		{
		}

		// Token: 0x06007C16 RID: 31766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C16")]
		[Address(RVA = "0x189B308", Offset = "0x189B308", VA = "0x7BBC09B308")]
		private void OnPlayerQuit(params object[] data)
		{
		}

		// Token: 0x06007C17 RID: 31767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C17")]
		[Address(RVA = "0x189B3E4", Offset = "0x189B3E4", VA = "0x7BBC09B3E4")]
		private void OnScoreChanged(params object[] data)
		{
		}

		// Token: 0x06007C18 RID: 31768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C18")]
		[Address(RVA = "0x189B624", Offset = "0x189B624", VA = "0x7BBC09B624")]
		private void OnNewPhaseEnter(params object[] data)
		{
		}

		// Token: 0x06007C19 RID: 31769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C19")]
		[Address(RVA = "0x189AAEC", Offset = "0x189AAEC", VA = "0x7BBC09AAEC")]
		private void SetRoundInfoUI()
		{
		}

		// Token: 0x06007C1A RID: 31770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C1A")]
		[Address(RVA = "0x189B810", Offset = "0x189B810", VA = "0x7BBC09B810")]
		private void OnODFactionChanged(params object[] data)
		{
		}

		// Token: 0x06007C1B RID: 31771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C1B")]
		[Address(RVA = "0x189A57C", Offset = "0x189A57C", VA = "0x7BBC09A57C")]
		private void ResetSwitchAnimation()
		{
		}

		// Token: 0x06007C1C RID: 31772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C1C")]
		[Address(RVA = "0x189BB48", Offset = "0x189BB48", VA = "0x7BBC09BB48")]
		private void ShowSwitchFactionSprites(bool v)
		{
		}

		// Token: 0x06007C1D RID: 31773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C1D")]
		[Address(RVA = "0x189BA94", Offset = "0x189BA94", VA = "0x7BBC09BA94")]
		private void ShowFixedFactionSprites(bool v)
		{
		}

		// Token: 0x06007C1E RID: 31774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C1E")]
		[Address(RVA = "0x189BBFC", Offset = "0x189BBFC", VA = "0x7BBC09BBFC")]
		private void ShowFactionVFX(bool v, int odFaction = 0)
		{
		}

		// Token: 0x06007C1F RID: 31775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C1F")]
		[Address(RVA = "0x189B75C", Offset = "0x189B75C", VA = "0x7BBC09B75C")]
		private void SetODFaction(int ODFactionId)
		{
		}

		// Token: 0x06007C20 RID: 31776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C20")]
		[Address(RVA = "0x189BEA0", Offset = "0x189BEA0", VA = "0x7BBC09BEA0")]
		public UIHudBombMatchInfoController()
		{
		}

		// Token: 0x06007C21 RID: 31777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C21")]
		[Address(RVA = "0x189BF30", Offset = "0x189BF30", VA = "0x7BBC09BF30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114291C", Offset = "0x114291C")]
		private void <OnNewPhaseEnter>b__18_0()
		{
		}

		// Token: 0x04009040 RID: 36928
		[Token(Token = "0x4009040")]
		[FieldOffset(Offset = "0x58")]
		private UIHudBombMatchInfoView m_View;

		// Token: 0x04009041 RID: 36929
		[Token(Token = "0x4009041")]
		[FieldOffset(Offset = "0x60")]
		private List<UIHudCSPlayerStateInfoView> m_MyTeamViews;

		// Token: 0x04009042 RID: 36930
		[Token(Token = "0x4009042")]
		[FieldOffset(Offset = "0x68")]
		private List<UIHudCSPlayerStateInfoView> m_OppoTeamViews;

		// Token: 0x04009043 RID: 36931
		[Token(Token = "0x4009043")]
		[FieldOffset(Offset = "0x70")]
		private bkHti^T mGame;

		// Token: 0x04009044 RID: 36932
		[Token(Token = "0x4009044")]
		[FieldOffset(Offset = "0x78")]
		private UIModelMatch m_ModelMatch;

		// Token: 0x04009045 RID: 36933
		[Token(Token = "0x4009045")]
		private const uint TEAMCOUNT = 4U;

		// Token: 0x02001883 RID: 6275
		[Token(Token = "0x2001883")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F43C4", Offset = "0x10F43C4")]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x06007C22 RID: 31778 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C22")]
			[Address(RVA = "0x189BA8C", Offset = "0x189BA8C", VA = "0x7BBC09BA8C")]
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x06007C23 RID: 31779 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C23")]
			[Address(RVA = "0x189BFF0", Offset = "0x189BFF0", VA = "0x7BBC09BFF0")]
			internal void <OnODFactionChanged>b__0()
			{
			}

			// Token: 0x04009046 RID: 36934
			[Token(Token = "0x4009046")]
			[FieldOffset(Offset = "0x10")]
			public UIHudBombMatchInfoController <>4__this;

			// Token: 0x04009047 RID: 36935
			[Token(Token = "0x4009047")]
			[FieldOffset(Offset = "0x18")]
			public int odFaction;
		}
	}
}
