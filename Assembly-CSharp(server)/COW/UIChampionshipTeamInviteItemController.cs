using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001497 RID: 5271
	[Token(Token = "0x2001497")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED27C", Offset = "0x10ED27C")]
	public class UIChampionshipTeamInviteItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x06005934 RID: 22836 RVA: 0x0001A400 File Offset: 0x00018600
		[Token(Token = "0x6005934")]
		[Address(RVA = "0x1ED1E60", Offset = "0x1ED1E60", VA = "0x7BBC6D1E60")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005935 RID: 22837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005935")]
		[Address(RVA = "0x1ED1EB0", Offset = "0x1ED1EB0", VA = "0x7BBC6D1EB0", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005936 RID: 22838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005936")]
		[Address(RVA = "0x1ED22A0", Offset = "0x1ED22A0", VA = "0x7BBC6D22A0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005937 RID: 22839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005937")]
		[Address(RVA = "0x1ED2470", Offset = "0x1ED2470", VA = "0x7BBC6D2470", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005938 RID: 22840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005938")]
		[Address(RVA = "0x1ED24B0", Offset = "0x1ED24B0", VA = "0x7BBC6D24B0")]
		private void Invite()
		{
		}

		// Token: 0x06005939 RID: 22841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005939")]
		[Address(RVA = "0x1ED1FC4", Offset = "0x1ED1FC4", VA = "0x7BBC6D1FC4")]
		private void UpdateInviteButtonView()
		{
		}

		// Token: 0x0600593A RID: 22842 RVA: 0x0001A418 File Offset: 0x00018618
		[Token(Token = "0x600593A")]
		[Address(RVA = "0x1ED257C", Offset = "0x1ED257C", VA = "0x7BBC6D257C", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600593B RID: 22843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593B")]
		[Address(RVA = "0x1ED2614", Offset = "0x1ED2614", VA = "0x7BBC6D2614", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600593C RID: 22844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593C")]
		[Address(RVA = "0x1ED2950", Offset = "0x1ED2950", VA = "0x7BBC6D2950")]
		public UIChampionshipTeamInviteItemController()
		{
		}

		// Token: 0x04007CCF RID: 31951
		[Token(Token = "0x4007CCF")]
		[FieldOffset(Offset = "0x70")]
		private UIChampionshipTeamInviteItemView m_View;

		// Token: 0x04007CD0 RID: 31952
		[Token(Token = "0x4007CD0")]
		[FieldOffset(Offset = "0x78")]
		private FriendAccountInfo m_FriendAccountInfo;

		// Token: 0x04007CD1 RID: 31953
		[Token(Token = "0x4007CD1")]
		[FieldOffset(Offset = "0x80")]
		private UIBaseProfileInfoController m_BaseProfileUI;

		// Token: 0x04007CD2 RID: 31954
		[Token(Token = "0x4007CD2")]
		[FieldOffset(Offset = "0x88")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007CD3 RID: 31955
		[Token(Token = "0x4007CD3")]
		[FieldOffset(Offset = "0x90")]
		private UIChampionshipTeamInviteController m_Parent;
	}
}
