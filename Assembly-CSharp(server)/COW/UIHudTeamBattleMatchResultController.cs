using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020015F9 RID: 5625
	[Token(Token = "0x20015F9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF7DC", Offset = "0x10EF7DC")]
	internal class UIHudTeamBattleMatchResultController : UIHudMatchResultBaseController
	{
		// Token: 0x0600644E RID: 25678 RVA: 0x0001CD40 File Offset: 0x0001AF40
		[Token(Token = "0x600644E")]
		[Address(RVA = "0x167D240", Offset = "0x167D240", VA = "0x7BBBE7D240")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x0600644F RID: 25679 RVA: 0x0001CD58 File Offset: 0x0001AF58
		// (set) Token: 0x06006450 RID: 25680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008F9")]
		protected ulong WinMVPPlayerAccountID
		{
			[Token(Token = "0x600644F")]
			[Address(RVA = "0x167D290", Offset = "0x167D290", VA = "0x7BBBE7D290")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6006450")]
			[Address(RVA = "0x167D298", Offset = "0x167D298", VA = "0x7BBBE7D298")]
			set
			{
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06006451 RID: 25681 RVA: 0x0001CD70 File Offset: 0x0001AF70
		// (set) Token: 0x06006452 RID: 25682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008FA")]
		protected ulong FailMVPPlayerAccountID
		{
			[Token(Token = "0x6006451")]
			[Address(RVA = "0x167D2A0", Offset = "0x167D2A0", VA = "0x7BBBE7D2A0")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6006452")]
			[Address(RVA = "0x167D2A8", Offset = "0x167D2A8", VA = "0x7BBBE7D2A8")]
			set
			{
			}
		}

		// Token: 0x06006453 RID: 25683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006453")]
		[Address(RVA = "0x167D2B0", Offset = "0x167D2B0", VA = "0x7BBBE7D2B0")]
		protected void UpdateLeftTeamScoreBG(ResourceID spriteID, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
		{
		}

		// Token: 0x06006454 RID: 25684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006454")]
		[Address(RVA = "0x167D39C", Offset = "0x167D39C", VA = "0x7BBBE7D39C")]
		protected void UpdateRightTeamScoreBG(ResourceID spriteID, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
		{
		}

		// Token: 0x06006455 RID: 25685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006455")]
		[Address(RVA = "0x167D488", Offset = "0x167D488", VA = "0x7BBBE7D488")]
		protected void UpdateLeftTeamCustomIcon(ResourceID spriteID, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
		{
		}

		// Token: 0x06006456 RID: 25686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006456")]
		[Address(RVA = "0x167D574", Offset = "0x167D574", VA = "0x7BBBE7D574")]
		protected void UpdateRightTeamCustomIcon(ResourceID spriteID, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
		{
		}

		// Token: 0x06006457 RID: 25687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006457")]
		[Address(RVA = "0x167D660", Offset = "0x167D660", VA = "0x7BBBE7D660")]
		protected void RepositionScoreWidth()
		{
		}

		// Token: 0x06006458 RID: 25688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006458")]
		[Address(RVA = "0x167DBE4", Offset = "0x167DBE4", VA = "0x7BBBE7DBE4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006459 RID: 25689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006459")]
		[Address(RVA = "0x167E1CC", Offset = "0x167E1CC", VA = "0x7BBBE7E1CC", Slot = "45")]
		protected override void OnShowAvatarInfoUI()
		{
		}

		// Token: 0x0600645A RID: 25690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645A")]
		[Address(RVA = "0x167E294", Offset = "0x167E294", VA = "0x7BBBE7E294", Slot = "43")]
		protected override void OnSetMatchResultInfo(MatchStats stats)
		{
		}

		// Token: 0x0600645B RID: 25691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645B")]
		[Address(RVA = "0x167F358", Offset = "0x167F358", VA = "0x7BBBE7F358", Slot = "44")]
		protected override void OnShowMatchResultDetailUI(bool show)
		{
		}

		// Token: 0x0600645C RID: 25692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600645C")]
		[Address(RVA = "0x167F740", Offset = "0x167F740", VA = "0x7BBBE7F740", Slot = "42")]
		protected override EMatchResultPlayerInfoType[] GetInfoTypes()
		{
			return null;
		}

		// Token: 0x0600645D RID: 25693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645D")]
		[Address(RVA = "0x167EF48", Offset = "0x167EF48", VA = "0x7BBBE7EF48")]
		protected void UpdateMVPInfo(List<TeammateStats> players, bool win, bool show = false)
		{
		}

		// Token: 0x0600645E RID: 25694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645E")]
		[Address(RVA = "0x167F7AC", Offset = "0x167F7AC", VA = "0x7BBBE7F7AC", Slot = "49")]
		protected override void OnFixMatchInfoForLanguage()
		{
		}

		// Token: 0x0600645F RID: 25695 RVA: 0x0001CD88 File Offset: 0x0001AF88
		[Token(Token = "0x600645F")]
		[Address(RVA = "0x167F8B0", Offset = "0x167F8B0", VA = "0x7BBBE7F8B0", Slot = "48")]
		protected override bool CheckIsWin(MatchStats stats)
		{
			return default(bool);
		}

		// Token: 0x06006460 RID: 25696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006460")]
		[Address(RVA = "0x167E4AC", Offset = "0x167E4AC", VA = "0x7BBBE7E4AC")]
		private void UpdateTeamInfo(MatchStats stats)
		{
		}

		// Token: 0x06006461 RID: 25697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006461")]
		[Address(RVA = "0x167F0E4", Offset = "0x167F0E4", VA = "0x7BBBE7F0E4")]
		private void UpdateTeammateInfo(bool localTeam, List<TeammateStats> players)
		{
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006462")]
		[Address(RVA = "0x167F9C8", Offset = "0x167F9C8", VA = "0x7BBBE7F9C8")]
		private void OnClickReportBtn()
		{
		}

		// Token: 0x06006463 RID: 25699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006463")]
		[Address(RVA = "0x167FBD8", Offset = "0x167FBD8", VA = "0x7BBBE7FBD8")]
		private void OnClickAddFriendBtn()
		{
		}

		// Token: 0x06006464 RID: 25700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006464")]
		[Address(RVA = "0x167F530", Offset = "0x167F530", VA = "0x7BBBE7F530")]
		private void OnClickLikeBtn()
		{
		}

		// Token: 0x06006465 RID: 25701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006465")]
		[Address(RVA = "0x167F8E4", Offset = "0x167F8E4", VA = "0x7BBBE7F8E4")]
		private Transform GetItemTransform(bool localTeam, int index)
		{
			return null;
		}

		// Token: 0x06006466 RID: 25702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006466")]
		[Address(RVA = "0x167FDE8", Offset = "0x167FDE8", VA = "0x7BBBE7FDE8")]
		public UIHudTeamBattleMatchResultController()
		{
		}

		// Token: 0x040082DA RID: 33498
		[Token(Token = "0x40082DA")]
		private const int SCORE_TO_DIVIDING_LINE_WIDTH = 10;

		// Token: 0x040082DB RID: 33499
		[Token(Token = "0x40082DB")]
		[FieldOffset(Offset = "0x210")]
		protected UIHudTeamBattleMatchResultView m_View;

		// Token: 0x040082DC RID: 33500
		[Token(Token = "0x40082DC")]
		[FieldOffset(Offset = "0x218")]
		protected bool HideGradeInfo;

		// Token: 0x040082DD RID: 33501
		[Token(Token = "0x40082DD")]
		[FieldOffset(Offset = "0x220")]
		private ulong m_WinMVPPlayerAccountID;

		// Token: 0x040082DE RID: 33502
		[Token(Token = "0x40082DE")]
		[FieldOffset(Offset = "0x228")]
		private ulong m_FailMVPPlayerAccountID;
	}
}
