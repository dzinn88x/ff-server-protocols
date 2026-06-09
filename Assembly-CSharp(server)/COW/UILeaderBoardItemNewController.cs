using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019CE RID: 6606
	[Token(Token = "0x20019CE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F713C", Offset = "0x10F713C")]
	public class UILeaderBoardItemNewController : UIEasyListItemController
	{
		// Token: 0x060087D2 RID: 34770 RVA: 0x00024A68 File Offset: 0x00022C68
		[Token(Token = "0x60087D2")]
		[Address(RVA = "0x1E29D00", Offset = "0x1E29D00", VA = "0x7BBC629D00")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060087D3 RID: 34771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087D3")]
		[Address(RVA = "0x1E29D50", Offset = "0x1E29D50", VA = "0x7BBC629D50", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060087D4 RID: 34772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087D4")]
		[Address(RVA = "0x1E29E74", Offset = "0x1E29E74", VA = "0x7BBC629E74")]
		public void HideAllUIs()
		{
		}

		// Token: 0x060087D5 RID: 34773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087D5")]
		[Address(RVA = "0x1E2A144", Offset = "0x1E2A144", VA = "0x7BBC62A144", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x060087D6 RID: 34774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087D6")]
		[Address(RVA = "0x1E2AB28", Offset = "0x1E2AB28", VA = "0x7BBC62AB28", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x060087D7 RID: 34775 RVA: 0x00024A80 File Offset: 0x00022C80
		[Token(Token = "0x60087D7")]
		[Address(RVA = "0x1E2A9A4", Offset = "0x1E2A9A4", VA = "0x7BBC62A9A4")]
		private bool IsShowHighLightType()
		{
			return default(bool);
		}

		// Token: 0x060087D8 RID: 34776 RVA: 0x00024A98 File Offset: 0x00022C98
		[Token(Token = "0x60087D8")]
		[Address(RVA = "0x1E2A5F4", Offset = "0x1E2A5F4", VA = "0x7BBC62A5F4")]
		private Vector2 GetProfileHalfSize(Transform baseProfileTopLeft, float w, float h)
		{
			return default(Vector2);
		}

		// Token: 0x060087D9 RID: 34777 RVA: 0x00024AB0 File Offset: 0x00022CB0
		[Token(Token = "0x60087D9")]
		[Address(RVA = "0x1E2A7A0", Offset = "0x1E2A7A0", VA = "0x7BBC62A7A0")]
		private Vector3 GetProfileCenterPos(Transform baseProfileTopLeft, float w, float h)
		{
			return default(Vector3);
		}

		// Token: 0x060087DA RID: 34778 RVA: 0x00024AC8 File Offset: 0x00022CC8
		[Token(Token = "0x60087DA")]
		[Address(RVA = "0x1E2A9B4", Offset = "0x1E2A9B4", VA = "0x7BBC62A9B4")]
		private bool IsInProfileRange(Vector3 centerPos, Vector2 size)
		{
			return default(bool);
		}

		// Token: 0x060087DB RID: 34779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087DB")]
		[Address(RVA = "0x1E2AB90", Offset = "0x1E2AB90", VA = "0x7BBC62AB90")]
		private void SetItemData(LeaderBoardInfo info)
		{
		}

		// Token: 0x060087DC RID: 34780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087DC")]
		[Address(RVA = "0x1E2C1EC", Offset = "0x1E2C1EC", VA = "0x7BBC62C1EC")]
		public void HideBG()
		{
		}

		// Token: 0x060087DD RID: 34781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087DD")]
		[Address(RVA = "0x1E2C248", Offset = "0x1E2C248", VA = "0x7BBC62C248")]
		public void SetIsSelf(bool isSelf)
		{
		}

		// Token: 0x060087DE RID: 34782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087DE")]
		[Address(RVA = "0x1E2AC88", Offset = "0x1E2AC88", VA = "0x7BBC62AC88")]
		private void SetRankUI()
		{
		}

		// Token: 0x060087DF RID: 34783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087DF")]
		[Address(RVA = "0x1E2B1CC", Offset = "0x1E2B1CC", VA = "0x7BBC62B1CC")]
		private void SetPersonKills()
		{
		}

		// Token: 0x060087E0 RID: 34784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087E0")]
		[Address(RVA = "0x1E2B34C", Offset = "0x1E2B34C", VA = "0x7BBC62B34C")]
		private void SetPersonWins()
		{
		}

		// Token: 0x060087E1 RID: 34785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087E1")]
		[Address(RVA = "0x1E2B4D8", Offset = "0x1E2B4D8", VA = "0x7BBC62B4D8")]
		private void SetCSPersonKills()
		{
		}

		// Token: 0x060087E2 RID: 34786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087E2")]
		[Address(RVA = "0x1E2B6E4", Offset = "0x1E2B6E4", VA = "0x7BBC62B6E4")]
		private void SetCSPersonWins()
		{
		}

		// Token: 0x060087E3 RID: 34787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087E3")]
		[Address(RVA = "0x1E2B8FC", Offset = "0x1E2B8FC", VA = "0x7BBC62B8FC")]
		private void SetPersonBadges()
		{
		}

		// Token: 0x060087E4 RID: 34788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087E4")]
		[Address(RVA = "0x1E2BB64", Offset = "0x1E2BB64", VA = "0x7BBC62BB64")]
		private void SetGuildHonor()
		{
		}

		// Token: 0x060087E5 RID: 34789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087E5")]
		[Address(RVA = "0x1E2BCF8", Offset = "0x1E2BCF8", VA = "0x7BBC62BCF8")]
		private void SetGuildRegionHonor()
		{
		}

		// Token: 0x060087E6 RID: 34790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087E6")]
		[Address(RVA = "0x1E2C254", Offset = "0x1E2C254", VA = "0x7BBC62C254")]
		private void SetPersonBaseProfile(Transform attachPoint, bool isBR = false)
		{
		}

		// Token: 0x060087E7 RID: 34791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087E7")]
		[Address(RVA = "0x1E2C488", Offset = "0x1E2C488", VA = "0x7BBC62C488")]
		private void SetGuildLevel(UISprite levelSprite)
		{
		}

		// Token: 0x060087E8 RID: 34792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087E8")]
		[Address(RVA = "0x1E2BF8C", Offset = "0x1E2BF8C", VA = "0x7BBC62BF8C")]
		private void SetTeamScore()
		{
		}

		// Token: 0x060087E9 RID: 34793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087E9")]
		[Address(RVA = "0x1E2C07C", Offset = "0x1E2C07C", VA = "0x7BBC62C07C")]
		private void SetTeamKills()
		{
		}

		// Token: 0x060087EA RID: 34794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087EA")]
		[Address(RVA = "0x1E2C5AC", Offset = "0x1E2C5AC", VA = "0x7BBC62C5AC")]
		private void SetTeamBaseProfile(Transform attachPoint)
		{
		}

		// Token: 0x060087EB RID: 34795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087EB")]
		[Address(RVA = "0x1E2C80C", Offset = "0x1E2C80C", VA = "0x7BBC62C80C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060087EC RID: 34796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087EC")]
		[Address(RVA = "0x1E2C8A8", Offset = "0x1E2C8A8", VA = "0x7BBC62C8A8")]
		public void SetRankFormat(UILeaderBoardItemNewController.RankFormat format, uint maxSize)
		{
		}

		// Token: 0x060087ED RID: 34797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087ED")]
		[Address(RVA = "0x1E2C8B0", Offset = "0x1E2C8B0", VA = "0x7BBC62C8B0")]
		public void SetDisplayType(UILeaderBoardItemNewController.DisplayType displayType)
		{
		}

		// Token: 0x060087EE RID: 34798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087EE")]
		[Address(RVA = "0x1E2C8B8", Offset = "0x1E2C8B8", VA = "0x7BBC62C8B8")]
		public void SetItemTouch(bool flag)
		{
		}

		// Token: 0x060087EF RID: 34799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087EF")]
		[Address(RVA = "0x1E2C8C4", Offset = "0x1E2C8C4", VA = "0x7BBC62C8C4")]
		public void SetBGInfo(int bgWidth)
		{
		}

		// Token: 0x060087F0 RID: 34800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087F0")]
		[Address(RVA = "0x1E2C8CC", Offset = "0x1E2C8CC", VA = "0x7BBC62C8CC")]
		public UILeaderBoardItemNewController()
		{
		}

		// Token: 0x04009654 RID: 38484
		[Token(Token = "0x4009654")]
		[FieldOffset(Offset = "0x70")]
		private UILeaderBoardItemNewController.RankFormat m_RankFormat;

		// Token: 0x04009655 RID: 38485
		[Token(Token = "0x4009655")]
		[FieldOffset(Offset = "0x74")]
		private uint m_MaxSize;

		// Token: 0x04009656 RID: 38486
		[Token(Token = "0x4009656")]
		[FieldOffset(Offset = "0x78")]
		private UILeaderBoardItemNewController.DisplayType m_DisplayType;

		// Token: 0x04009657 RID: 38487
		[Token(Token = "0x4009657")]
		[FieldOffset(Offset = "0x80")]
		private UILeaderBoardItemNewView m_View;

		// Token: 0x04009658 RID: 38488
		[Token(Token = "0x4009658")]
		[FieldOffset(Offset = "0x88")]
		private LeaderBoardInfo m_info;

		// Token: 0x04009659 RID: 38489
		[Token(Token = "0x4009659")]
		[FieldOffset(Offset = "0x90")]
		private UIBaseProfileInfoController m_BaseProfileUI;

		// Token: 0x0400965A RID: 38490
		[Token(Token = "0x400965A")]
		[FieldOffset(Offset = "0x98")]
		private UITeamBaseProfileController m_TeamBaseProfileUI;

		// Token: 0x0400965B RID: 38491
		[Token(Token = "0x400965B")]
		[FieldOffset(Offset = "0xA0")]
		private UIWidget m_ProfileWidget;

		// Token: 0x0400965C RID: 38492
		[Token(Token = "0x400965C")]
		[FieldOffset(Offset = "0xA8")]
		private int m_BGWidth;

		// Token: 0x0400965D RID: 38493
		[Token(Token = "0x400965D")]
		[FieldOffset(Offset = "0xB0")]
		private ulong m_AccountID;

		// Token: 0x0400965E RID: 38494
		[Token(Token = "0x400965E")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_IsSelf;

		// Token: 0x0400965F RID: 38495
		[Token(Token = "0x400965F")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<uint, string> m_RankCupIcon;

		// Token: 0x04009660 RID: 38496
		[Token(Token = "0x4009660")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<uint, string> m_RankBG;

		// Token: 0x04009661 RID: 38497
		[Token(Token = "0x4009661")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_CanTouch;

		// Token: 0x020019CF RID: 6607
		[Token(Token = "0x20019CF")]
		public enum DisplayType
		{
			// Token: 0x04009663 RID: 38499
			[Token(Token = "0x4009663")]
			PersonKills,
			// Token: 0x04009664 RID: 38500
			[Token(Token = "0x4009664")]
			PersonWins,
			// Token: 0x04009665 RID: 38501
			[Token(Token = "0x4009665")]
			PersonBagdges,
			// Token: 0x04009666 RID: 38502
			[Token(Token = "0x4009666")]
			GuildHonor,
			// Token: 0x04009667 RID: 38503
			[Token(Token = "0x4009667")]
			GuildRegionHonor,
			// Token: 0x04009668 RID: 38504
			[Token(Token = "0x4009668")]
			TeamScore,
			// Token: 0x04009669 RID: 38505
			[Token(Token = "0x4009669")]
			TeamKills,
			// Token: 0x0400966A RID: 38506
			[Token(Token = "0x400966A")]
			CSPersonKills,
			// Token: 0x0400966B RID: 38507
			[Token(Token = "0x400966B")]
			CSPersonWins
		}

		// Token: 0x020019D0 RID: 6608
		[Token(Token = "0x20019D0")]
		public enum RankFormat
		{
			// Token: 0x0400966D RID: 38509
			[Token(Token = "0x400966D")]
			Normal,
			// Token: 0x0400966E RID: 38510
			[Token(Token = "0x400966E")]
			TopPercent
		}
	}
}
