using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001ACE RID: 6862
	[Token(Token = "0x2001ACE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8B04", Offset = "0x10F8B04")]
	public class UIPaymentGrowthFundItemController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x060090DA RID: 37082 RVA: 0x00026A18 File Offset: 0x00024C18
		[Token(Token = "0x60090DA")]
		[Address(RVA = "0x1F27B00", Offset = "0x1F27B00", VA = "0x7BBC727B00")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060090DB RID: 37083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090DB")]
		[Address(RVA = "0x1F27B50", Offset = "0x1F27B50", VA = "0x7BBC727B50", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060090DC RID: 37084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090DC")]
		[Address(RVA = "0x1F27CA4", Offset = "0x1F27CA4", VA = "0x7BBC727CA4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060090DD RID: 37085 RVA: 0x00026A30 File Offset: 0x00024C30
		[Token(Token = "0x60090DD")]
		[Address(RVA = "0x1F2774C", Offset = "0x1F2774C", VA = "0x7BBC72774C")]
		public EStore.PayLevelInfoState GetPayLevelInfoState()
		{
			return EStore.PayLevelInfoState.PayLevelInfoState_RECEIVED;
		}

		// Token: 0x060090DE RID: 37086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090DE")]
		[Address(RVA = "0x1F27170", Offset = "0x1F27170", VA = "0x7BBC727170")]
		public void SetData(PayLevelRewardDesc data)
		{
		}

		// Token: 0x060090DF RID: 37087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090DF")]
		[Address(RVA = "0x1F28250", Offset = "0x1F28250", VA = "0x7BBC728250")]
		private void ApplyCdnUrlToNetworkTexture(UINetworkTextureExt networkTexture, string url)
		{
		}

		// Token: 0x060090E0 RID: 37088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090E0")]
		[Address(RVA = "0x1F27CE8", Offset = "0x1F27CE8", VA = "0x7BBC727CE8")]
		private void UpdateContents()
		{
		}

		// Token: 0x060090E1 RID: 37089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090E1")]
		[Address(RVA = "0x1F28294", Offset = "0x1F28294", VA = "0x7BBC728294")]
		private void OnClaimClick()
		{
		}

		// Token: 0x060090E2 RID: 37090 RVA: 0x00026A48 File Offset: 0x00024C48
		[Token(Token = "0x60090E2")]
		[Address(RVA = "0x1F28614", Offset = "0x1F28614", VA = "0x7BBC728614", Slot = "29")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060090E3 RID: 37091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090E3")]
		[Address(RVA = "0x1F28698", Offset = "0x1F28698", VA = "0x7BBC728698", Slot = "28")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060090E4 RID: 37092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090E4")]
		[Address(RVA = "0x1F287B0", Offset = "0x1F287B0", VA = "0x7BBC7287B0")]
		public UIPaymentGrowthFundItemController()
		{
		}

		// Token: 0x04009C5C RID: 40028
		[Token(Token = "0x4009C5C")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentGrowthFundItemView m_View;

		// Token: 0x04009C5D RID: 40029
		[Token(Token = "0x4009C5D")]
		[FieldOffset(Offset = "0x60")]
		private PayLevelRewardDesc m_Data;

		// Token: 0x04009C5E RID: 40030
		[Token(Token = "0x4009C5E")]
		[FieldOffset(Offset = "0x68")]
		private UIModelPayment m_Payment;

		// Token: 0x04009C5F RID: 40031
		[Token(Token = "0x4009C5F")]
		[FieldOffset(Offset = "0x70")]
		private PlayLevelInfo m_Info;
	}
}
