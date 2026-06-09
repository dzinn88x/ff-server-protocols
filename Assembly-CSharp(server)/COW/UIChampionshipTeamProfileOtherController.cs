using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020014A3 RID: 5283
	[Token(Token = "0x20014A3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED3EC", Offset = "0x10ED3EC")]
	public class UIChampionshipTeamProfileOtherController : UIChampionshipTeamProfileController, IUIModelDataChangeObserver
	{
		// Token: 0x0600597D RID: 22909 RVA: 0x0001A568 File Offset: 0x00018768
		[Token(Token = "0x600597D")]
		[Address(RVA = "0x1ED7844", Offset = "0x1ED7844", VA = "0x7BBC6D7844")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600597E")]
		[Address(RVA = "0x1ED7894", Offset = "0x1ED7894", VA = "0x7BBC6D7894", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600597F")]
		[Address(RVA = "0x1ED7A88", Offset = "0x1ED7A88", VA = "0x7BBC6D7A88", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005980 RID: 22912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005980")]
		[Address(RVA = "0x1EC8EC0", Offset = "0x1EC8EC0", VA = "0x7BBC6C8EC0")]
		public void SetViewData(uint championshipType, uint teamID)
		{
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005981")]
		[Address(RVA = "0x1ED7B38", Offset = "0x1ED7B38", VA = "0x7BBC6D7B38")]
		private void UpdateTeamInfoView()
		{
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005982")]
		[Address(RVA = "0x1ED7B80", Offset = "0x1ED7B80", VA = "0x7BBC6D7B80")]
		private void UpdateTeamMemberView()
		{
		}

		// Token: 0x06005983 RID: 22915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005983")]
		[Address(RVA = "0x1EC8F30", Offset = "0x1EC8F30", VA = "0x7BBC6C8F30")]
		public void SetBtnStatus()
		{
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005984")]
		[Address(RVA = "0x1ED7DFC", Offset = "0x1ED7DFC", VA = "0x7BBC6D7DFC")]
		public void ShowMembers()
		{
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005985")]
		[Address(RVA = "0x1ED7E44", Offset = "0x1ED7E44", VA = "0x7BBC6D7E44")]
		public void ShowRecord()
		{
		}

		// Token: 0x06005986 RID: 22918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005986")]
		[Address(RVA = "0x1ED7EC8", Offset = "0x1ED7EC8", VA = "0x7BBC6D7EC8")]
		private void RecordDetail()
		{
		}

		// Token: 0x06005987 RID: 22919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005987")]
		[Address(RVA = "0x1ED7AC8", Offset = "0x1ED7AC8", VA = "0x7BBC6D7AC8")]
		private void RequestData()
		{
		}

		// Token: 0x06005988 RID: 22920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005988")]
		[Address(RVA = "0x1ED7FB8", Offset = "0x1ED7FB8", VA = "0x7BBC6D7FB8", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005989 RID: 22921 RVA: 0x0001A580 File Offset: 0x00018780
		[Token(Token = "0x6005989")]
		[Address(RVA = "0x1ED828C", Offset = "0x1ED828C", VA = "0x7BBC6D828C", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600598A RID: 22922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600598A")]
		[Address(RVA = "0x1ED8330", Offset = "0x1ED8330", VA = "0x7BBC6D8330")]
		public UIChampionshipTeamProfileOtherController()
		{
		}

		// Token: 0x04007D00 RID: 32000
		[Token(Token = "0x4007D00")]
		[FieldOffset(Offset = "0x90")]
		private UIChampionshipTeamProfileView m_View;

		// Token: 0x04007D01 RID: 32001
		[Token(Token = "0x4007D01")]
		[FieldOffset(Offset = "0x98")]
		private ulong m_TeamID;

		// Token: 0x04007D02 RID: 32002
		[Token(Token = "0x4007D02")]
		[FieldOffset(Offset = "0xA0")]
		private TeamInfo m_TeamInfo;

		// Token: 0x04007D03 RID: 32003
		[Token(Token = "0x4007D03")]
		[FieldOffset(Offset = "0xA8")]
		private TeamMemberListWithAccountInfo m_TeamMemberInfo;

		// Token: 0x04007D04 RID: 32004
		[Token(Token = "0x4007D04")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007D05 RID: 32005
		[Token(Token = "0x4007D05")]
		[FieldOffset(Offset = "0xB8")]
		private CSTeamMatchStatsHistoryRes m_TeamMatchStatsHisotryRes;
	}
}
