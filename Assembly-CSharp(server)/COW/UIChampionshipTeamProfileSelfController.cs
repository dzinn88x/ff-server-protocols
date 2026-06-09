using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014A4 RID: 5284
	[Token(Token = "0x20014A4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED424", Offset = "0x10ED424")]
	public class UIChampionshipTeamProfileSelfController : UIChampionshipTeamProfileController, IUIModelDataChangeObserver
	{
		// Token: 0x0600598B RID: 22923 RVA: 0x0001A598 File Offset: 0x00018798
		[Token(Token = "0x600598B")]
		[Address(RVA = "0x1ED8334", Offset = "0x1ED8334", VA = "0x7BBC6D8334")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600598C RID: 22924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600598C")]
		[Address(RVA = "0x1ED8384", Offset = "0x1ED8384", VA = "0x7BBC6D8384", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600598D RID: 22925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600598D")]
		[Address(RVA = "0x1ED89BC", Offset = "0x1ED89BC", VA = "0x7BBC6D89BC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600598E RID: 22926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600598E")]
		[Address(RVA = "0x1ED89FC", Offset = "0x1ED89FC", VA = "0x7BBC6D89FC")]
		public void SetViewData(uint championshipType)
		{
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600598F")]
		[Address(RVA = "0x1ED8A04", Offset = "0x1ED8A04", VA = "0x7BBC6D8A04")]
		public void UpdateTeamInfoView()
		{
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005990")]
		[Address(RVA = "0x1ED92EC", Offset = "0x1ED92EC", VA = "0x7BBC6D92EC")]
		public void UpdateTeamMemberView()
		{
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005991")]
		[Address(RVA = "0x1ED95A4", Offset = "0x1ED95A4", VA = "0x7BBC6D95A4")]
		private void OnExitTeam()
		{
		}

		// Token: 0x06005992 RID: 22930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005992")]
		[Address(RVA = "0x1ED9888", Offset = "0x1ED9888", VA = "0x7BBC6D9888")]
		private void OnCreateTeamClick()
		{
		}

		// Token: 0x06005993 RID: 22931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005993")]
		[Address(RVA = "0x1ED9B44", Offset = "0x1ED9B44", VA = "0x7BBC6D9B44")]
		private void OnBtnChatRecruitClick()
		{
		}

		// Token: 0x06005994 RID: 22932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005994")]
		[Address(RVA = "0x1ED9BE0", Offset = "0x1ED9BE0", VA = "0x7BBC6D9BE0")]
		private void OnJoinTeamOnlick()
		{
		}

		// Token: 0x06005995 RID: 22933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005995")]
		[Address(RVA = "0x1ED9D98", Offset = "0x1ED9D98", VA = "0x7BBC6D9D98")]
		private void OnRecruit()
		{
		}

		// Token: 0x06005996 RID: 22934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005996")]
		[Address(RVA = "0x1ED9E38", Offset = "0x1ED9E38", VA = "0x7BBC6D9E38")]
		private void OnRecourdDetail()
		{
		}

		// Token: 0x06005997 RID: 22935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005997")]
		[Address(RVA = "0x1ED87E8", Offset = "0x1ED87E8", VA = "0x7BBC6D87E8")]
		private void RequestData()
		{
		}

		// Token: 0x06005998 RID: 22936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005998")]
		[Address(RVA = "0x1ED9F30", Offset = "0x1ED9F30", VA = "0x7BBC6D9F30", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005999 RID: 22937 RVA: 0x0001A5B0 File Offset: 0x000187B0
		[Token(Token = "0x6005999")]
		[Address(RVA = "0x1EDAA1C", Offset = "0x1EDAA1C", VA = "0x7BBC6DAA1C", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600599A RID: 22938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600599A")]
		[Address(RVA = "0x1EDAB04", Offset = "0x1EDAB04", VA = "0x7BBC6DAB04")]
		public void ShowMembers()
		{
		}

		// Token: 0x0600599B RID: 22939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600599B")]
		[Address(RVA = "0x1EDAB2C", Offset = "0x1EDAB2C", VA = "0x7BBC6DAB2C")]
		public void ShowRecord()
		{
		}

		// Token: 0x0600599C RID: 22940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600599C")]
		[Address(RVA = "0x1EDAB98", Offset = "0x1EDAB98", VA = "0x7BBC6DAB98")]
		private void ShowInvite()
		{
		}

		// Token: 0x0600599D RID: 22941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600599D")]
		[Address(RVA = "0x1EDAC64", Offset = "0x1EDAC64", VA = "0x7BBC6DAC64")]
		private void ShowApplyAndInvite()
		{
		}

		// Token: 0x0600599E RID: 22942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600599E")]
		[Address(RVA = "0x1EDAD40", Offset = "0x1EDAD40", VA = "0x7BBC6DAD40")]
		public void ShowCreateTeamWnd()
		{
		}

		// Token: 0x0600599F RID: 22943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600599F")]
		[Address(RVA = "0x1EDAE04", Offset = "0x1EDAE04", VA = "0x7BBC6DAE04")]
		public UIChampionshipTeamProfileSelfController()
		{
		}

		// Token: 0x060059A0 RID: 22944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A0")]
		[Address(RVA = "0x1EDAE70", Offset = "0x1EDAE70", VA = "0x7BBC6DAE70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F508", Offset = "0x113F508")]
		private void <OnExitTeam>b__14_0()
		{
		}

		// Token: 0x04007D06 RID: 32006
		[Token(Token = "0x4007D06")]
		private const string TabApply = "TabApply";

		// Token: 0x04007D07 RID: 32007
		[Token(Token = "0x4007D07")]
		private const string TabInvite = "TabInvite";

		// Token: 0x04007D08 RID: 32008
		[Token(Token = "0x4007D08")]
		[FieldOffset(Offset = "0x90")]
		private UIChampionshipTeamProfileView m_View;

		// Token: 0x04007D09 RID: 32009
		[Token(Token = "0x4007D09")]
		[FieldOffset(Offset = "0x98")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007D0A RID: 32010
		[Token(Token = "0x4007D0A")]
		[FieldOffset(Offset = "0xA0")]
		private StandardTabItemViewData m_SelectedTab;

		// Token: 0x04007D0B RID: 32011
		[Token(Token = "0x4007D0B")]
		[FieldOffset(Offset = "0xA8")]
		private List<StandardTabItemViewData> m_InfoTabDatas;

		// Token: 0x04007D0C RID: 32012
		[Token(Token = "0x4007D0C")]
		[FieldOffset(Offset = "0xB0")]
		private UIChampionshipMemberReviewPopupController m_MemberReviewPopupCtrl;

		// Token: 0x04007D0D RID: 32013
		[Token(Token = "0x4007D0D")]
		[FieldOffset(Offset = "0xB8")]
		public Action SignUpPopupWndCancelAction;
	}
}
