using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019CD RID: 6605
	[Token(Token = "0x20019CD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7104", Offset = "0x10F7104")]
	public class UIPlayerLeaderBoardItemController : UIEasyListItemController
	{
		// Token: 0x060087CB RID: 34763 RVA: 0x00024A50 File Offset: 0x00022C50
		[Token(Token = "0x60087CB")]
		[Address(RVA = "0x20E6AE8", Offset = "0x20E6AE8", VA = "0x7BBC8E6AE8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060087CC RID: 34764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087CC")]
		[Address(RVA = "0x20E6B38", Offset = "0x20E6B38", VA = "0x7BBC8E6B38", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060087CD RID: 34765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087CD")]
		[Address(RVA = "0x20E6CAC", Offset = "0x20E6CAC", VA = "0x7BBC8E6CAC")]
		private void OnItemLeaderBoardClick()
		{
		}

		// Token: 0x060087CE RID: 34766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087CE")]
		[Address(RVA = "0x20E6D30", Offset = "0x20E6D30", VA = "0x7BBC8E6D30")]
		public void SetItemData(LeaderBoardInfo info)
		{
		}

		// Token: 0x060087CF RID: 34767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087CF")]
		[Address(RVA = "0x20E7314", Offset = "0x20E7314", VA = "0x7BBC8E7314")]
		public void SetCompareToLastRank(int compare)
		{
		}

		// Token: 0x060087D0 RID: 34768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087D0")]
		[Address(RVA = "0x20E73B0", Offset = "0x20E73B0", VA = "0x7BBC8E73B0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060087D1 RID: 34769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087D1")]
		[Address(RVA = "0x20E744C", Offset = "0x20E744C", VA = "0x7BBC8E744C")]
		public UIPlayerLeaderBoardItemController()
		{
		}

		// Token: 0x0400964B RID: 38475
		[Token(Token = "0x400964B")]
		[FieldOffset(Offset = "0x70")]
		private UILeaderBoardItemView m_View;

		// Token: 0x0400964C RID: 38476
		[Token(Token = "0x400964C")]
		[FieldOffset(Offset = "0x78")]
		private LeaderBoardInfo m_info;

		// Token: 0x0400964D RID: 38477
		[Token(Token = "0x400964D")]
		private const string ODD_BG_SPRITENAME = "leaderboard_list_BG_G";

		// Token: 0x0400964E RID: 38478
		[Token(Token = "0x400964E")]
		private const string EVEN_BG_SPRITENAME = "leaderboard_list_BG_GH";

		// Token: 0x0400964F RID: 38479
		[Token(Token = "0x400964F")]
		private const string ODD_TOP3_BG_SPRITENAME = "leaderboard_list_BG_B";

		// Token: 0x04009650 RID: 38480
		[Token(Token = "0x4009650")]
		private const string EVEN_TOP3_BG_SPRITENAME = "leaderboard_list_BG_BH";

		// Token: 0x04009651 RID: 38481
		[Token(Token = "0x4009651")]
		private const string CUP_NO1_SPRITENAME = "UI_Icon_Cup_01";

		// Token: 0x04009652 RID: 38482
		[Token(Token = "0x4009652")]
		private const string CUP_NO2_SPRITENAME = "UI_Icon_Cup_02";

		// Token: 0x04009653 RID: 38483
		[Token(Token = "0x4009653")]
		private const string CUP_NO3_SPRITENAME = "UI_Icon_Cup_03";
	}
}
