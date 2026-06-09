using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200147E RID: 5246
	[Token(Token = "0x200147E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECF2C", Offset = "0x10ECF2C")]
	public class UIChampionshipLeaderBoardItem : UIEasyListItemController
	{
		// Token: 0x06005882 RID: 22658 RVA: 0x0001A160 File Offset: 0x00018360
		[Token(Token = "0x6005882")]
		[Address(RVA = "0x1EC4404", Offset = "0x1EC4404", VA = "0x7BBC6C4404")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005883 RID: 22659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005883")]
		[Address(RVA = "0x1EC4454", Offset = "0x1EC4454", VA = "0x7BBC6C4454", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005884 RID: 22660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005884")]
		[Address(RVA = "0x1EC4638", Offset = "0x1EC4638", VA = "0x7BBC6C4638", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005885 RID: 22661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005885")]
		[Address(RVA = "0x1EC4D10", Offset = "0x1EC4D10", VA = "0x7BBC6C4D10")]
		private void OnBtnClick()
		{
		}

		// Token: 0x06005886 RID: 22662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005886")]
		[Address(RVA = "0x1EC4E34", Offset = "0x1EC4E34", VA = "0x7BBC6C4E34")]
		public UIChampionshipLeaderBoardItem()
		{
		}

		// Token: 0x04007C5F RID: 31839
		[Token(Token = "0x4007C5F")]
		[FieldOffset(Offset = "0x70")]
		private UIChampionshipLeaderBoardItemView m_View;

		// Token: 0x04007C60 RID: 31840
		[Token(Token = "0x4007C60")]
		[FieldOffset(Offset = "0x78")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007C61 RID: 31841
		[Token(Token = "0x4007C61")]
		[FieldOffset(Offset = "0x80")]
		private UITeamBaseProfileController m_ProfileCtrl;

		// Token: 0x04007C62 RID: 31842
		[Token(Token = "0x4007C62")]
		[FieldOffset(Offset = "0x88")]
		private TeamInfo m_TeamInfo;

		// Token: 0x04007C63 RID: 31843
		[Token(Token = "0x4007C63")]
		[FieldOffset(Offset = "0x90")]
		public uint m_ChampionshipType;

		// Token: 0x04007C64 RID: 31844
		[Token(Token = "0x4007C64")]
		[FieldOffset(Offset = "0x94")]
		public bool m_IsSelf;

		// Token: 0x04007C65 RID: 31845
		[Token(Token = "0x4007C65")]
		[FieldOffset(Offset = "0x98")]
		private LeaderBoardInfo m_Info;
	}
}
