using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001492 RID: 5266
	[Token(Token = "0x2001492")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED1C4", Offset = "0x10ED1C4")]
	public class UIChampionshipTeamCreateFormController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x060058FD RID: 22781 RVA: 0x0001A328 File Offset: 0x00018528
		[Token(Token = "0x60058FD")]
		[Address(RVA = "0x1ECCBF4", Offset = "0x1ECCBF4", VA = "0x7BBC6CCBF4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060058FE RID: 22782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058FE")]
		[Address(RVA = "0x1ECCC44", Offset = "0x1ECCC44", VA = "0x7BBC6CCC44")]
		public void InitUI(EChampionship.TeamScaleType teamScaleType)
		{
		}

		// Token: 0x060058FF RID: 22783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058FF")]
		[Address(RVA = "0x1ECD6A0", Offset = "0x1ECD6A0", VA = "0x7BBC6CD6A0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005900 RID: 22784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005900")]
		[Address(RVA = "0x1ECD888", Offset = "0x1ECD888", VA = "0x7BBC6CD888")]
		private void Confirm()
		{
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005901")]
		[Address(RVA = "0x1ECDCD8", Offset = "0x1ECDCD8", VA = "0x7BBC6CDCD8")]
		private void CancelCallBack()
		{
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005902")]
		[Address(RVA = "0x1ECDBE4", Offset = "0x1ECDBE4", VA = "0x7BBC6CDBE4")]
		private string GetFixContactInfo()
		{
			return null;
		}

		// Token: 0x06005903 RID: 22787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005903")]
		[Address(RVA = "0x1ECDCF8", Offset = "0x1ECDCF8", VA = "0x7BBC6CDCF8")]
		private void SelectFlag()
		{
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005904")]
		[Address(RVA = "0x1ECDD98", Offset = "0x1ECDD98", VA = "0x7BBC6CDD98")]
		private void SelectAvatar()
		{
		}

		// Token: 0x06005905 RID: 22789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005905")]
		[Address(RVA = "0x1ECDE38", Offset = "0x1ECDE38", VA = "0x7BBC6CDE38")]
		private void SelectBanner()
		{
		}

		// Token: 0x06005906 RID: 22790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005906")]
		[Address(RVA = "0x1ECDED8", Offset = "0x1ECDED8", VA = "0x7BBC6CDED8")]
		private void SelectChannel()
		{
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005907")]
		[Address(RVA = "0x1ECDF78", Offset = "0x1ECDF78", VA = "0x7BBC6CDF78", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x0001A340 File Offset: 0x00018540
		[Token(Token = "0x6005908")]
		[Address(RVA = "0x1ECE0B0", Offset = "0x1ECE0B0", VA = "0x7BBC6CE0B0", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005909 RID: 22793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005909")]
		[Address(RVA = "0x1ECE148", Offset = "0x1ECE148", VA = "0x7BBC6CE148")]
		private void NationalFlagSelectHander(object[] args)
		{
		}

		// Token: 0x0600590A RID: 22794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590A")]
		[Address(RVA = "0x1ECE240", Offset = "0x1ECE240", VA = "0x7BBC6CE240")]
		private void ClanAvatarSelectHander(object[] args)
		{
		}

		// Token: 0x0600590B RID: 22795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590B")]
		[Address(RVA = "0x1ECE34C", Offset = "0x1ECE34C", VA = "0x7BBC6CE34C")]
		private void ClanBannerSelectHander(object[] args)
		{
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590C")]
		[Address(RVA = "0x1ECE494", Offset = "0x1ECE494", VA = "0x7BBC6CE494")]
		private void ChannelSelectHandler(object[] args)
		{
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590D")]
		[Address(RVA = "0x1ECE620", Offset = "0x1ECE620", VA = "0x7BBC6CE620")]
		public UIChampionshipTeamCreateFormController()
		{
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600590E")]
		[Address(RVA = "0x1ECE628", Offset = "0x1ECE628", VA = "0x7BBC6CE628")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F498", Offset = "0x113F498")]
		private void <InitUI>b__11_0()
		{
		}

		// Token: 0x04007CB0 RID: 31920
		[Token(Token = "0x4007CB0")]
		[FieldOffset(Offset = "0x98")]
		private NationFlagData m_SelectNationFlag;

		// Token: 0x04007CB1 RID: 31921
		[Token(Token = "0x4007CB1")]
		[FieldOffset(Offset = "0xA0")]
		private HeadPicBaseInfo m_ClanAvatarInfo;

		// Token: 0x04007CB2 RID: 31922
		[Token(Token = "0x4007CB2")]
		[FieldOffset(Offset = "0xA8")]
		private BannerBaseInfo m_ClanBannerInfo;

		// Token: 0x04007CB3 RID: 31923
		[Token(Token = "0x4007CB3")]
		[FieldOffset(Offset = "0xB0")]
		private UIChampionshipTeamCreateFormView m_View;

		// Token: 0x04007CB4 RID: 31924
		[Token(Token = "0x4007CB4")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007CB5 RID: 31925
		[Token(Token = "0x4007CB5")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x04007CB6 RID: 31926
		[Token(Token = "0x4007CB6")]
		[FieldOffset(Offset = "0xC8")]
		private int m_SelectChannelID;

		// Token: 0x04007CB7 RID: 31927
		[Token(Token = "0x4007CB7")]
		[FieldOffset(Offset = "0xCC")]
		private EChampionship.TeamScaleType m_TeamScaleType;

		// Token: 0x04007CB8 RID: 31928
		[Token(Token = "0x4007CB8")]
		[FieldOffset(Offset = "0xD0")]
		public Action CancelAction;

		// Token: 0x04007CB9 RID: 31929
		[Token(Token = "0x4007CB9")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_IsCreatTing;
	}
}
