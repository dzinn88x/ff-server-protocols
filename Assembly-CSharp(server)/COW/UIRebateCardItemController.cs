using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B45 RID: 6981
	[Token(Token = "0x2001B45")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F997C", Offset = "0x10F997C")]
	public class UIRebateCardItemController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x060095EB RID: 38379 RVA: 0x00027A50 File Offset: 0x00025C50
		[Token(Token = "0x60095EB")]
		[Address(RVA = "0x1E12B48", Offset = "0x1E12B48", VA = "0x7BBC612B48")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060095EC RID: 38380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095EC")]
		[Address(RVA = "0x1E12B98", Offset = "0x1E12B98", VA = "0x7BBC612B98", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060095ED RID: 38381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095ED")]
		[Address(RVA = "0x1E12F60", Offset = "0x1E12F60", VA = "0x7BBC612F60")]
		private void SetSpriteColorByRebateCardType()
		{
		}

		// Token: 0x060095EE RID: 38382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095EE")]
		[Address(RVA = "0x1E131DC", Offset = "0x1E131DC", VA = "0x7BBC6131DC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060095EF RID: 38383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095EF")]
		[Address(RVA = "0x1E13224", Offset = "0x1E13224", VA = "0x7BBC613224")]
		private void OnBtnRedeemClick()
		{
		}

		// Token: 0x060095F0 RID: 38384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095F0")]
		[Address(RVA = "0x1E13844", Offset = "0x1E13844", VA = "0x7BBC613844")]
		private void OnBtnPurchaseClick()
		{
		}

		// Token: 0x060095F1 RID: 38385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095F1")]
		[Address(RVA = "0x1E13EA0", Offset = "0x1E13EA0", VA = "0x7BBC613EA0")]
		private void GotoSubscription()
		{
		}

		// Token: 0x060095F2 RID: 38386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095F2")]
		[Address(RVA = "0x1E13FD4", Offset = "0x1E13FD4", VA = "0x7BBC613FD4")]
		private void SetStaticData_Descriptions(RebateCardData rebateCardData)
		{
		}

		// Token: 0x060095F3 RID: 38387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095F3")]
		[Address(RVA = "0x1E14E70", Offset = "0x1E14E70", VA = "0x7BBC614E70")]
		private void ToggleByExtraReward(RebateCardData rebateCardData)
		{
		}

		// Token: 0x060095F4 RID: 38388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095F4")]
		[Address(RVA = "0x1E14F60", Offset = "0x1E14F60", VA = "0x7BBC614F60")]
		private void OnExtraRewardClick()
		{
		}

		// Token: 0x060095F5 RID: 38389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095F5")]
		[Address(RVA = "0x1E151B8", Offset = "0x1E151B8", VA = "0x7BBC6151B8")]
		private void OnSubscriptionToggleBoxClick()
		{
		}

		// Token: 0x060095F6 RID: 38390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095F6")]
		[Address(RVA = "0x1E12EF8", Offset = "0x1E12EF8", VA = "0x7BBC612EF8")]
		private void SyncSubscriptionToggleStatus()
		{
		}

		// Token: 0x060095F7 RID: 38391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095F7")]
		[Address(RVA = "0x1E15474", Offset = "0x1E15474", VA = "0x7BBC615474")]
		private void OnSubscriptionHintButtonClick()
		{
		}

		// Token: 0x060095F8 RID: 38392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095F8")]
		[Address(RVA = "0x1E156B4", Offset = "0x1E156B4", VA = "0x7BBC6156B4")]
		private void OnGracePeriodButtonClick()
		{
		}

		// Token: 0x060095F9 RID: 38393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095F9")]
		[Address(RVA = "0x1E15744", Offset = "0x1E15744", VA = "0x7BBC615744")]
		private void OnFixOnHoldButtonClick()
		{
		}

		// Token: 0x060095FA RID: 38394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60095FA")]
		[Address(RVA = "0x1E157D4", Offset = "0x1E157D4", VA = "0x7BBC6157D4")]
		private string GetSKinWeaponPropDesc(uint _rewardId)
		{
			return null;
		}

		// Token: 0x060095FB RID: 38395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60095FB")]
		[Address(RVA = "0x1E15B5C", Offset = "0x1E15B5C", VA = "0x7BBC615B5C")]
		private string GetPropMark(int num)
		{
			return null;
		}

		// Token: 0x060095FC RID: 38396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095FC")]
		[Address(RVA = "0x1E15C00", Offset = "0x1E15C00", VA = "0x7BBC615C00")]
		private void OnHelpBtnClick()
		{
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x060095FD RID: 38397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A41")]
		private UILabel RedeemAmountLabel
		{
			[Token(Token = "0x60095FD")]
			[Address(RVA = "0x1E15E38", Offset = "0x1E15E38", VA = "0x7BBC615E38")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x060095FE RID: 38398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A42")]
		private UILabel TotalAmountLabel
		{
			[Token(Token = "0x60095FE")]
			[Address(RVA = "0x1E15E64", Offset = "0x1E15E64", VA = "0x7BBC615E64")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x060095FF RID: 38399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A43")]
		private UIButton BtnRedeem
		{
			[Token(Token = "0x60095FF")]
			[Address(RVA = "0x1E15E90", Offset = "0x1E15E90", VA = "0x7BBC615E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009600 RID: 38400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009600")]
		[Address(RVA = "0x1E15EBC", Offset = "0x1E15EBC", VA = "0x7BBC615EBC")]
		private UISprite RebateCardSprite(RebateCardType rebateCardType)
		{
			return null;
		}

		// Token: 0x06009601 RID: 38401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009601")]
		[Address(RVA = "0x1E15F1C", Offset = "0x1E15F1C", VA = "0x7BBC615F1C")]
		private void SetStaticData(RebateCardData rebateCardData)
		{
		}

		// Token: 0x06009602 RID: 38402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009602")]
		[Address(RVA = "0x1E16308", Offset = "0x1E16308", VA = "0x7BBC616308")]
		public void SetDynamicData(RebateCardType rebateCardType)
		{
		}

		// Token: 0x06009603 RID: 38403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009603")]
		[Address(RVA = "0x1E16304", Offset = "0x1E16304", VA = "0x7BBC616304")]
		private void UpdatePrice(RebateCardData data)
		{
		}

		// Token: 0x06009604 RID: 38404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009604")]
		[Address(RVA = "0x1E16908", Offset = "0x1E16908", VA = "0x7BBC616908")]
		private void UpdateSubscription(RebateCardData data)
		{
		}

		// Token: 0x06009605 RID: 38405 RVA: 0x00027A68 File Offset: 0x00025C68
		[Token(Token = "0x6009605")]
		[Address(RVA = "0x1E13DA0", Offset = "0x1E13DA0", VA = "0x7BBC613DA0")]
		private bool IsInGracePeriod()
		{
			return default(bool);
		}

		// Token: 0x06009606 RID: 38406 RVA: 0x00027A80 File Offset: 0x00025C80
		[Token(Token = "0x6009606")]
		[Address(RVA = "0x1E17204", Offset = "0x1E17204", VA = "0x7BBC617204")]
		private bool OnHold()
		{
			return default(bool);
		}

		// Token: 0x06009607 RID: 38407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009607")]
		[Address(RVA = "0x1E170FC", Offset = "0x1E170FC", VA = "0x7BBC6170FC")]
		private void UpdateSubscriptionBonus()
		{
		}

		// Token: 0x06009608 RID: 38408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009608")]
		[Address(RVA = "0x1E151E8", Offset = "0x1E151E8", VA = "0x7BBC6151E8")]
		private void UpdatePriceLabel()
		{
		}

		// Token: 0x06009609 RID: 38409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009609")]
		[Address(RVA = "0x1E16FB0", Offset = "0x1E16FB0", VA = "0x7BBC616FB0")]
		private void UpdatePurchaseButton()
		{
		}

		// Token: 0x0600960A RID: 38410 RVA: 0x00027A98 File Offset: 0x00025C98
		[Token(Token = "0x600960A")]
		[Address(RVA = "0x1E17304", Offset = "0x1E17304", VA = "0x7BBC617304", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600960B RID: 38411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600960B")]
		[Address(RVA = "0x1E17348", Offset = "0x1E17348", VA = "0x7BBC617348", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600960C RID: 38412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600960C")]
		[Address(RVA = "0x1E17468", Offset = "0x1E17468", VA = "0x7BBC617468")]
		public UIRebateCardItemController()
		{
		}

		// Token: 0x0600960D RID: 38413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600960D")]
		[Address(RVA = "0x1E17478", Offset = "0x1E17478", VA = "0x7BBC617478")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144CB0", Offset = "0x1144CB0")]
		private void <OnBtnRedeemClick>b__9_1(PayUtility.SubscriptionGracePeriodReminderInfo info)
		{
		}

		// Token: 0x04009ED3 RID: 40659
		[Token(Token = "0x4009ED3")]
		[FieldOffset(Offset = "0x58")]
		private UIRebateCardItemView m_View;

		// Token: 0x04009ED4 RID: 40660
		[Token(Token = "0x4009ED4")]
		[FieldOffset(Offset = "0x60")]
		private RebateCardType m_RebateCardType;

		// Token: 0x04009ED5 RID: 40661
		[Token(Token = "0x4009ED5")]
		[FieldOffset(Offset = "0x68")]
		private RebateCardInfo m_RebateCardInfo;

		// Token: 0x04009ED6 RID: 40662
		[Token(Token = "0x4009ED6")]
		[FieldOffset(Offset = "0x70")]
		private UIModelRebateCard m_Model;

		// Token: 0x04009ED7 RID: 40663
		[Token(Token = "0x4009ED7")]
		private const string REBATE_CARD_SPRITE_NAME_SUFFIX = "_RebateCardTint";

		// Token: 0x04009ED8 RID: 40664
		[Token(Token = "0x4009ED8")]
		[FieldOffset(Offset = "0x78")]
		private bool m_PreferSubscription;

		// Token: 0x04009ED9 RID: 40665
		[Token(Token = "0x4009ED9")]
		private const string PRICE_TEMPLATE = "US${0}";

		// Token: 0x02001B46 RID: 6982
		[Token(Token = "0x2001B46")]
		private class DescLabelInfo
		{
			// Token: 0x0600960E RID: 38414 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600960E")]
			[Address(RVA = "0x1E14E68", Offset = "0x1E14E68", VA = "0x7BBC614E68")]
			public DescLabelInfo()
			{
			}

			// Token: 0x04009EDA RID: 40666
			[Token(Token = "0x4009EDA")]
			[FieldOffset(Offset = "0x10")]
			public string Text;

			// Token: 0x04009EDB RID: 40667
			[Token(Token = "0x4009EDB")]
			[FieldOffset(Offset = "0x18")]
			public EventDelegate.Callback OnClick;
		}

		// Token: 0x02001B47 RID: 6983
		[Token(Token = "0x2001B47")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F99B4", Offset = "0x10F99B4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06009610 RID: 38416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009610")]
			[Address(RVA = "0x1E17530", Offset = "0x1E17530", VA = "0x7BBC617530")]
			public <>c()
			{
			}

			// Token: 0x06009611 RID: 38417 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009611")]
			[Address(RVA = "0x1E17538", Offset = "0x1E17538", VA = "0x7BBC617538")]
			internal void <OnBtnRedeemClick>b__9_0(PayUtility.SubscriptionGracePeriodReminderInfo info)
			{
			}

			// Token: 0x04009EDC RID: 40668
			[Token(Token = "0x4009EDC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIRebateCardItemController.<>c <>9;

			// Token: 0x04009EDD RID: 40669
			[Token(Token = "0x4009EDD")]
			[FieldOffset(Offset = "0x8")]
			public static Action<PayUtility.SubscriptionGracePeriodReminderInfo> <>9__9_0;
		}
	}
}
