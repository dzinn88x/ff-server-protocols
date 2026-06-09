using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200149B RID: 5275
	[Token(Token = "0x200149B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED2FC", Offset = "0x10ED2FC")]
	public class UIChampionshipTeamJoinItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x0600594F RID: 22863 RVA: 0x0001A4A8 File Offset: 0x000186A8
		[Token(Token = "0x600594F")]
		[Address(RVA = "0x1ED3970", Offset = "0x1ED3970", VA = "0x7BBC6D3970")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005950")]
		[Address(RVA = "0x1ED39C0", Offset = "0x1ED39C0", VA = "0x7BBC6D39C0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005951")]
		[Address(RVA = "0x1ED3B70", Offset = "0x1ED3B70", VA = "0x7BBC6D3B70", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005952")]
		[Address(RVA = "0x1ED2F7C", Offset = "0x1ED2F7C", VA = "0x7BBC6D2F7C")]
		public void SetChampionshipType(uint championshipType)
		{
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005953")]
		[Address(RVA = "0x1ED3BB0", Offset = "0x1ED3BB0", VA = "0x7BBC6D3BB0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005954 RID: 22868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005954")]
		[Address(RVA = "0x1ED42FC", Offset = "0x1ED42FC", VA = "0x7BBC6D42FC")]
		private void LookOver()
		{
		}

		// Token: 0x06005955 RID: 22869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005955")]
		[Address(RVA = "0x1ED439C", Offset = "0x1ED439C", VA = "0x7BBC6D439C")]
		private void ApplyFor()
		{
		}

		// Token: 0x06005956 RID: 22870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005956")]
		[Address(RVA = "0x1ED3F8C", Offset = "0x1ED3F8C", VA = "0x7BBC6D3F8C")]
		private void UpdateApplyButtonView()
		{
		}

		// Token: 0x06005957 RID: 22871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005957")]
		[Address(RVA = "0x1ED4438", Offset = "0x1ED4438", VA = "0x7BBC6D4438", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005958 RID: 22872 RVA: 0x0001A4C0 File Offset: 0x000186C0
		[Token(Token = "0x6005958")]
		[Address(RVA = "0x1ED45FC", Offset = "0x1ED45FC", VA = "0x7BBC6D45FC", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005959 RID: 22873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005959")]
		[Address(RVA = "0x1ED4694", Offset = "0x1ED4694", VA = "0x7BBC6D4694")]
		public UIChampionshipTeamJoinItemController()
		{
		}

		// Token: 0x04007CE0 RID: 31968
		[Token(Token = "0x4007CE0")]
		[FieldOffset(Offset = "0x70")]
		private UIChampionshipTeamJoinItemView m_View;

		// Token: 0x04007CE1 RID: 31969
		[Token(Token = "0x4007CE1")]
		[FieldOffset(Offset = "0x78")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007CE2 RID: 31970
		[Token(Token = "0x4007CE2")]
		[FieldOffset(Offset = "0x80")]
		private FriendAccountInfo m_AccountInfo;

		// Token: 0x04007CE3 RID: 31971
		[Token(Token = "0x4007CE3")]
		[FieldOffset(Offset = "0x88")]
		private UIChampionshipTeamJoinController m_Parent;

		// Token: 0x04007CE4 RID: 31972
		[Token(Token = "0x4007CE4")]
		[FieldOffset(Offset = "0x90")]
		private uint m_ChampionshipType;
	}
}
