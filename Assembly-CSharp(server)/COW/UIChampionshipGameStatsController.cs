using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200147B RID: 5243
	[Token(Token = "0x200147B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECEBC", Offset = "0x10ECEBC")]
	public class UIChampionshipGameStatsController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x06005863 RID: 22627 RVA: 0x0001A0E8 File Offset: 0x000182E8
		[Token(Token = "0x6005863")]
		[Address(RVA = "0x1C3569C", Offset = "0x1C3569C", VA = "0x7BBC43569C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005864 RID: 22628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005864")]
		[Address(RVA = "0x1C356EC", Offset = "0x1C356EC", VA = "0x7BBC4356EC")]
		protected object GetView()
		{
			return null;
		}

		// Token: 0x06005865 RID: 22629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005865")]
		[Address(RVA = "0x1C356F4", Offset = "0x1C356F4", VA = "0x7BBC4356F4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005866 RID: 22630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005866")]
		[Address(RVA = "0x1C35940", Offset = "0x1C35940", VA = "0x7BBC435940", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06005867 RID: 22631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005867")]
		[Address(RVA = "0x1C35E18", Offset = "0x1C35E18", VA = "0x7BBC435E18", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06005868 RID: 22632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005868")]
		[Address(RVA = "0x1C35E20", Offset = "0x1C35E20", VA = "0x7BBC435E20", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005869 RID: 22633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005869")]
		[Address(RVA = "0x1C35D60", Offset = "0x1C35D60", VA = "0x7BBC435D60")]
		private void RequestData()
		{
		}

		// Token: 0x0600586A RID: 22634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600586A")]
		[Address(RVA = "0x1C35E60", Offset = "0x1C35E60", VA = "0x7BBC435E60")]
		private void UpdateTeamInfo()
		{
		}

		// Token: 0x0600586B RID: 22635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600586B")]
		[Address(RVA = "0x1C35B74", Offset = "0x1C35B74", VA = "0x7BBC435B74")]
		private void UpdateSeasonInfo()
		{
		}

		// Token: 0x0600586C RID: 22636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600586C")]
		[Address(RVA = "0x1C35F78", Offset = "0x1C35F78", VA = "0x7BBC435F78")]
		private void UpdateStatsInfo(CSTeamChampionshipSeasonStatsRes res)
		{
		}

		// Token: 0x0600586D RID: 22637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586D")]
		[Address(RVA = "0x1C3657C", Offset = "0x1C3657C", VA = "0x7BBC43657C")]
		private string SecFormat(uint _sec)
		{
			return null;
		}

		// Token: 0x0600586E RID: 22638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600586E")]
		[Address(RVA = "0x1C36618", Offset = "0x1C36618", VA = "0x7BBC436618")]
		private string uniFormat(uint n)
		{
			return null;
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600586F")]
		[Address(RVA = "0x1C366AC", Offset = "0x1C366AC", VA = "0x7BBC4366AC")]
		private void OnViewMatchHistoryBtnClick()
		{
		}

		// Token: 0x06005870 RID: 22640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005870")]
		[Address(RVA = "0x1C36800", Offset = "0x1C36800", VA = "0x7BBC436800")]
		protected void OnShareBtnClick()
		{
		}

		// Token: 0x06005871 RID: 22641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005871")]
		[Address(RVA = "0x1C368E0", Offset = "0x1C368E0", VA = "0x7BBC4368E0", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x06005872 RID: 22642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005872")]
		[Address(RVA = "0x1C36990", Offset = "0x1C36990", VA = "0x7BBC436990", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x06005873 RID: 22643 RVA: 0x0001A100 File Offset: 0x00018300
		[Token(Token = "0x6005873")]
		[Address(RVA = "0x1C36A70", Offset = "0x1C36A70", VA = "0x7BBC436A70", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06005874 RID: 22644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005874")]
		[Address(RVA = "0x1C36A78", Offset = "0x1C36A78", VA = "0x7BBC436A78", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005875 RID: 22645 RVA: 0x0001A118 File Offset: 0x00018318
		[Token(Token = "0x6005875")]
		[Address(RVA = "0x1C36C50", Offset = "0x1C36C50", VA = "0x7BBC436C50", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005876 RID: 22646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005876")]
		[Address(RVA = "0x1C36CF0", Offset = "0x1C36CF0", VA = "0x7BBC436CF0")]
		public UIChampionshipGameStatsController()
		{
		}

		// Token: 0x04007C4C RID: 31820
		[Token(Token = "0x4007C4C")]
		[FieldOffset(Offset = "0xB0")]
		private UIChampionshipGameStatsView m_View;

		// Token: 0x04007C4D RID: 31821
		[Token(Token = "0x4007C4D")]
		[FieldOffset(Offset = "0xB8")]
		protected UIModelChampionship m_ModelChampionship;

		// Token: 0x04007C4E RID: 31822
		[Token(Token = "0x4007C4E")]
		[FieldOffset(Offset = "0xC0")]
		protected ChampionshipOpenInfoDesc m_ChampionshipOpenInfo;

		// Token: 0x04007C4F RID: 31823
		[Token(Token = "0x4007C4F")]
		[FieldOffset(Offset = "0xC8")]
		private UIChampionshipTeamOverviewController m_TeamOverviewUI;

		// Token: 0x04007C50 RID: 31824
		[Token(Token = "0x4007C50")]
		[FieldOffset(Offset = "0xD0")]
		private ulong m_TeamID;

		// Token: 0x04007C51 RID: 31825
		[Token(Token = "0x4007C51")]
		[FieldOffset(Offset = "0xD8")]
		private TeamInfo m_TeamInfo;

		// Token: 0x04007C52 RID: 31826
		[Token(Token = "0x4007C52")]
		[FieldOffset(Offset = "0xE0")]
		private uint m_ChampionshipType;

		// Token: 0x0200147C RID: 5244
		[Token(Token = "0x200147C")]
		public class NavArgs
		{
			// Token: 0x06005877 RID: 22647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005877")]
			[Address(RVA = "0x1C2E3D4", Offset = "0x1C2E3D4", VA = "0x7BBC42E3D4")]
			public NavArgs()
			{
			}

			// Token: 0x04007C53 RID: 31827
			[Token(Token = "0x4007C53")]
			[FieldOffset(Offset = "0x10")]
			public ulong teamID;

			// Token: 0x04007C54 RID: 31828
			[Token(Token = "0x4007C54")]
			[FieldOffset(Offset = "0x18")]
			public TeamInfo teamInfo;

			// Token: 0x04007C55 RID: 31829
			[Token(Token = "0x4007C55")]
			[FieldOffset(Offset = "0x20")]
			public uint championshipType;
		}
	}
}
