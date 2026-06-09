using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001493 RID: 5267
	[Token(Token = "0x2001493")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED1FC", Offset = "0x10ED1FC")]
	public class UIChampionshipTeamInfoEditController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x0600590F RID: 22799 RVA: 0x0001A358 File Offset: 0x00018558
		[Token(Token = "0x600590F")]
		[Address(RVA = "0x1ECEB6C", Offset = "0x1ECEB6C", VA = "0x7BBC6CEB6C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005910")]
		[Address(RVA = "0x1ECEBBC", Offset = "0x1ECEBBC", VA = "0x7BBC6CEBBC", Slot = "29")]
		public override string CustomTitle()
		{
			return null;
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005911")]
		[Address(RVA = "0x1ECEC04", Offset = "0x1ECEC04", VA = "0x7BBC6CEC04", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005912")]
		[Address(RVA = "0x1ECF88C", Offset = "0x1ECF88C", VA = "0x7BBC6CF88C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005913")]
		[Address(RVA = "0x1ECF48C", Offset = "0x1ECF48C", VA = "0x7BBC6CF48C")]
		private void InitContactInfo()
		{
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005914")]
		[Address(RVA = "0x1ECFA74", Offset = "0x1ECFA74", VA = "0x7BBC6CFA74")]
		private void Confirm()
		{
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005915")]
		[Address(RVA = "0x1ED0108", Offset = "0x1ED0108", VA = "0x7BBC6D0108")]
		private string GetFixContactInfo()
		{
			return null;
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005916")]
		[Address(RVA = "0x1ED0214", Offset = "0x1ED0214", VA = "0x7BBC6D0214")]
		private void SelectFlag()
		{
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005917")]
		[Address(RVA = "0x1ED02B4", Offset = "0x1ED02B4", VA = "0x7BBC6D02B4")]
		private void SelectChannel()
		{
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005918")]
		[Address(RVA = "0x1ED0354", Offset = "0x1ED0354", VA = "0x7BBC6D0354")]
		private void SelectAvatar()
		{
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005919")]
		[Address(RVA = "0x1ED03F4", Offset = "0x1ED03F4", VA = "0x7BBC6D03F4")]
		private void SelectBanner()
		{
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600591A")]
		[Address(RVA = "0x1ED0494", Offset = "0x1ED0494", VA = "0x7BBC6D0494", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x0001A370 File Offset: 0x00018570
		[Token(Token = "0x600591B")]
		[Address(RVA = "0x1ED0A48", Offset = "0x1ED0A48", VA = "0x7BBC6D0A48", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600591C")]
		[Address(RVA = "0x1ED0AE8", Offset = "0x1ED0AE8", VA = "0x7BBC6D0AE8")]
		private void NationalFlagSelectHander(object[] args)
		{
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600591D")]
		[Address(RVA = "0x1ED0BE0", Offset = "0x1ED0BE0", VA = "0x7BBC6D0BE0")]
		private void ClanAvatarSelectHander(object[] args)
		{
		}

		// Token: 0x0600591E RID: 22814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600591E")]
		[Address(RVA = "0x1ED0CEC", Offset = "0x1ED0CEC", VA = "0x7BBC6D0CEC")]
		private void ClanBannerSelectHander(object[] args)
		{
		}

		// Token: 0x0600591F RID: 22815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600591F")]
		[Address(RVA = "0x1ED0E34", Offset = "0x1ED0E34", VA = "0x7BBC6D0E34")]
		private void ChannelSelectHandler(object[] args)
		{
		}

		// Token: 0x06005920 RID: 22816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005920")]
		[Address(RVA = "0x1ED0FC0", Offset = "0x1ED0FC0", VA = "0x7BBC6D0FC0")]
		public UIChampionshipTeamInfoEditController()
		{
		}

		// Token: 0x06005921 RID: 22817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005921")]
		[Address(RVA = "0x1ED1030", Offset = "0x1ED1030", VA = "0x7BBC6D1030")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F4A8", Offset = "0x113F4A8")]
		private void <OnUIInit>b__11_0()
		{
		}

		// Token: 0x04007CBA RID: 31930
		[Token(Token = "0x4007CBA")]
		[FieldOffset(Offset = "0x98")]
		private NationFlagData m_SelectNationFlag;

		// Token: 0x04007CBB RID: 31931
		[Token(Token = "0x4007CBB")]
		[FieldOffset(Offset = "0xA0")]
		private HeadPicBaseInfo m_ClanAvatarInfo;

		// Token: 0x04007CBC RID: 31932
		[Token(Token = "0x4007CBC")]
		[FieldOffset(Offset = "0xA8")]
		private BannerBaseInfo m_ClanBannerInfo;

		// Token: 0x04007CBD RID: 31933
		[Token(Token = "0x4007CBD")]
		[FieldOffset(Offset = "0xB0")]
		private UIChampionshipTeamCreateFormView m_View;

		// Token: 0x04007CBE RID: 31934
		[Token(Token = "0x4007CBE")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04007CBF RID: 31935
		[Token(Token = "0x4007CBF")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x04007CC0 RID: 31936
		[Token(Token = "0x4007CC0")]
		[FieldOffset(Offset = "0xC8")]
		private int m_SelectChannelID;

		// Token: 0x04007CC1 RID: 31937
		[Token(Token = "0x4007CC1")]
		[FieldOffset(Offset = "0xD0")]
		private List<uint> m_WaitModelPropIDs;

		// Token: 0x04007CC2 RID: 31938
		[Token(Token = "0x4007CC2")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_HasErr;
	}
}
