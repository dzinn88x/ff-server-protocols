using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019F4 RID: 6644
	[Token(Token = "0x20019F4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F74F4", Offset = "0x10F74F4")]
	internal class UILobbyCoinsController : UIBaseController, IUIModelDataChangeObserver, ITipsDelegate
	{
		// Token: 0x06008971 RID: 35185 RVA: 0x00024EB8 File Offset: 0x000230B8
		[Token(Token = "0x6008971")]
		[Address(RVA = "0x152C52C", Offset = "0x152C52C", VA = "0x7BBBD2C52C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008972 RID: 35186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008972")]
		[Address(RVA = "0x152C57C", Offset = "0x152C57C", VA = "0x7BBBD2C57C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008973 RID: 35187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008973")]
		[Address(RVA = "0x152CFD4", Offset = "0x152CFD4", VA = "0x7BBBD2CFD4", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06008974 RID: 35188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008974")]
		[Address(RVA = "0x152D2E4", Offset = "0x152D2E4", VA = "0x7BBBD2D2E4")]
		private void OnBtnMonthCardClick()
		{
		}

		// Token: 0x06008975 RID: 35189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008975")]
		[Address(RVA = "0x152D61C", Offset = "0x152D61C", VA = "0x7BBBD2D61C")]
		public void OnClickPayDiamondButton()
		{
		}

		// Token: 0x06008976 RID: 35190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008976")]
		[Address(RVA = "0x152D708", Offset = "0x152D708", VA = "0x7BBBD2D708")]
		public void UpdateCoinsData()
		{
		}

		// Token: 0x06008977 RID: 35191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008977")]
		[Address(RVA = "0x152D830", Offset = "0x152D830", VA = "0x7BBBD2D830")]
		private void RefreshCoinsAndDiamonds()
		{
		}

		// Token: 0x06008978 RID: 35192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008978")]
		[Address(RVA = "0x152C964", Offset = "0x152C964", VA = "0x7BBBD2C964")]
		private void RefreshRebateCards()
		{
		}

		// Token: 0x06008979 RID: 35193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008979")]
		[Address(RVA = "0x152CE58", Offset = "0x152CE58", VA = "0x7BBBD2CE58")]
		private void UpdateRebateCardTips()
		{
		}

		// Token: 0x0600897A RID: 35194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600897A")]
		[Address(RVA = "0x152DAD8", Offset = "0x152DAD8", VA = "0x7BBBD2DAD8", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600897B RID: 35195 RVA: 0x00024ED0 File Offset: 0x000230D0
		[Token(Token = "0x600897B")]
		[Address(RVA = "0x152DBB0", Offset = "0x152DBB0", VA = "0x7BBBD2DBB0", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600897C RID: 35196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600897C")]
		[Address(RVA = "0x152DC0C", Offset = "0x152DC0C", VA = "0x7BBBD2DC0C")]
		public void OnCoinsUpdate(params object[] data)
		{
		}

		// Token: 0x0600897D RID: 35197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600897D")]
		[Address(RVA = "0x152DC10", Offset = "0x152DC10", VA = "0x7BBBD2DC10", Slot = "30")]
		public void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x0600897E RID: 35198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600897E")]
		[Address(RVA = "0x152CD04", Offset = "0x152CD04", VA = "0x7BBBD2CD04")]
		private void UpdatePaymentRedDot()
		{
		}

		// Token: 0x0600897F RID: 35199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600897F")]
		[Address(RVA = "0x152DC2C", Offset = "0x152DC2C", VA = "0x7BBBD2DC2C")]
		public UILobbyCoinsController()
		{
		}

		// Token: 0x04009794 RID: 38804
		[Token(Token = "0x4009794")]
		[FieldOffset(Offset = "0x58")]
		private UILobbyCoinsView m_View;

		// Token: 0x04009795 RID: 38805
		[Token(Token = "0x4009795")]
		[FieldOffset(Offset = "0x60")]
		private UIModelPayment m_Payment;

		// Token: 0x04009796 RID: 38806
		[Token(Token = "0x4009796")]
		[FieldOffset(Offset = "0x68")]
		private UIModelRebateCard m_RebateCard;
	}
}
