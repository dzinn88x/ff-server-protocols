using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001907 RID: 6407
	[Token(Token = "0x2001907")]
	internal class UIHudMatchResult2TeamsController : UIHudMatchResultBaseShareController
	{
		// Token: 0x060080BE RID: 32958 RVA: 0x00023208 File Offset: 0x00021408
		[Token(Token = "0x60080BE")]
		[Address(RVA = "0x15BFCF0", Offset = "0x15BFCF0", VA = "0x7BBBDBFCF0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060080BF RID: 32959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080BF")]
		[Address(RVA = "0x15BFD40", Offset = "0x15BFD40", VA = "0x7BBBDBFD40", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060080C0 RID: 32960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080C0")]
		[Address(RVA = "0x15C05CC", Offset = "0x15C05CC", VA = "0x7BBBDC05CC", Slot = "30")]
		protected override void OnMatchStatsChange(MatchStats stats, MatchIncome income)
		{
		}

		// Token: 0x060080C1 RID: 32961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080C1")]
		[Address(RVA = "0x15C0208", Offset = "0x15C0208", VA = "0x7BBBDC0208")]
		public void ShowUI(MatchStats statsData, MatchIncome income)
		{
		}

		// Token: 0x060080C2 RID: 32962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080C2")]
		[Address(RVA = "0x15BFF6C", Offset = "0x15BFF6C", VA = "0x7BBBDBFF6C")]
		private void ShowElements(bool show)
		{
		}

		// Token: 0x060080C3 RID: 32963 RVA: 0x00023220 File Offset: 0x00021420
		[Token(Token = "0x60080C3")]
		[Address(RVA = "0x15C05D0", Offset = "0x15C05D0", VA = "0x7BBBDC05D0")]
		private bool IsLocalTeamWinning(MatchStats stats)
		{
			return default(bool);
		}

		// Token: 0x060080C4 RID: 32964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080C4")]
		[Address(RVA = "0x15C05EC", Offset = "0x15C05EC", VA = "0x7BBBDC05EC")]
		private void InitTeamInfo(bool win, MatchStats statsData)
		{
		}

		// Token: 0x060080C5 RID: 32965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080C5")]
		[Address(RVA = "0x15C0A50", Offset = "0x15C0A50", VA = "0x7BBBDC0A50")]
		private void InitTeammates(UIGrid grid, List<TeammateStats> players, bool win, ulong localUserId)
		{
		}

		// Token: 0x060080C6 RID: 32966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60080C6")]
		[Address(RVA = "0x15C1FF4", Offset = "0x15C1FF4", VA = "0x7BBBDC1FF4", Slot = "36")]
		protected virtual UIHudMatchResult2TeamsView OnCreateView()
		{
			return null;
		}

		// Token: 0x060080C7 RID: 32967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60080C7")]
		[Address(RVA = "0x15C2044", Offset = "0x15C2044", VA = "0x7BBBDC2044")]
		public UIHudMatchResult2TeamsController()
		{
		}

		// Token: 0x040092C8 RID: 37576
		[Token(Token = "0x40092C8")]
		[FieldOffset(Offset = "0xA0")]
		protected UIHudMatchResult2TeamsView m_View;

		// Token: 0x040092C9 RID: 37577
		[Token(Token = "0x40092C9")]
		[FieldOffset(Offset = "0xA8")]
		protected bool m_UIInited;

		// Token: 0x040092CA RID: 37578
		[Token(Token = "0x40092CA")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelFriends friendsModel;
	}
}
