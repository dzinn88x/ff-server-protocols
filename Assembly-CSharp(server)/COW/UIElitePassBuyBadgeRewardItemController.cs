using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200178C RID: 6028
	[Token(Token = "0x200178C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F24AC", Offset = "0x10F24AC")]
	public class UIElitePassBuyBadgeRewardItemController : UIEasyListItemController
	{
		// Token: 0x06007299 RID: 29337 RVA: 0x0001FE48 File Offset: 0x0001E048
		[Token(Token = "0x6007299")]
		[Address(RVA = "0x1ADB498", Offset = "0x1ADB498", VA = "0x7BBC2DB498")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600729A RID: 29338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600729A")]
		[Address(RVA = "0x1ADB4E8", Offset = "0x1ADB4E8", VA = "0x7BBC2DB4E8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600729B RID: 29339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600729B")]
		[Address(RVA = "0x1ADB800", Offset = "0x1ADB800", VA = "0x7BBC2DB800", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600729C RID: 29340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600729C")]
		[Address(RVA = "0x1ADB8CC", Offset = "0x1ADB8CC", VA = "0x7BBC2DB8CC")]
		private void OnChangeSelectedBadgeCount(params object[] param)
		{
		}

		// Token: 0x0600729D RID: 29341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600729D")]
		[Address(RVA = "0x1ADBF60", Offset = "0x1ADBF60", VA = "0x7BBC2DBF60", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600729E RID: 29342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600729E")]
		[Address(RVA = "0x1AD9818", Offset = "0x1AD9818", VA = "0x7BBC2D9818")]
		public void SelectItem(bool isEP)
		{
		}

		// Token: 0x0600729F RID: 29343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600729F")]
		[Address(RVA = "0x1ADC5D4", Offset = "0x1ADC5D4", VA = "0x7BBC2DC5D4", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x060072A0 RID: 29344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A0")]
		[Address(RVA = "0x1ADC66C", Offset = "0x1ADC66C", VA = "0x7BBC2DC66C", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x060072A1 RID: 29345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A1")]
		[Address(RVA = "0x1ADC6EC", Offset = "0x1ADC6EC", VA = "0x7BBC2DC6EC")]
		private void OnFpAwardClick()
		{
		}

		// Token: 0x060072A2 RID: 29346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A2")]
		[Address(RVA = "0x1ADC6F4", Offset = "0x1ADC6F4", VA = "0x7BBC2DC6F4")]
		private void OnEpAwardClick()
		{
		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A3")]
		[Address(RVA = "0x1ADBAD4", Offset = "0x1ADBAD4", VA = "0x7BBC2DBAD4")]
		private void ShowLockState(int badgeCount)
		{
		}

		// Token: 0x060072A4 RID: 29348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072A4")]
		[Address(RVA = "0x1ADC6FC", Offset = "0x1ADC6FC", VA = "0x7BBC2DC6FC")]
		public UIElitePassBuyBadgeRewardItemController()
		{
		}

		// Token: 0x04008B7B RID: 35707
		[Token(Token = "0x4008B7B")]
		[FieldOffset(Offset = "0x70")]
		private EPAwardInfo m_RewardData;

		// Token: 0x04008B7C RID: 35708
		[Token(Token = "0x4008B7C")]
		[FieldOffset(Offset = "0x78")]
		private UIElitePassBuyBadgeRewardItemView m_View;

		// Token: 0x04008B7D RID: 35709
		[Token(Token = "0x4008B7D")]
		[FieldOffset(Offset = "0x80")]
		private bool m_IsClickEpAward;

		// Token: 0x04008B7E RID: 35710
		[Token(Token = "0x4008B7E")]
		[FieldOffset(Offset = "0x84")]
		private int badgeAfter;
	}
}
