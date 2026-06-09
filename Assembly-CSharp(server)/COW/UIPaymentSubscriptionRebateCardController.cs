using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001ADC RID: 6876
	[Token(Token = "0x2001ADC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8C8C", Offset = "0x10F8C8C")]
	public class UIPaymentSubscriptionRebateCardController : UIPaymentSubscriptionBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x0600919C RID: 37276 RVA: 0x00026C58 File Offset: 0x00024E58
		[Token(Token = "0x600919C")]
		[Address(RVA = "0x1F34E2C", Offset = "0x1F34E2C", VA = "0x7BBC734E2C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600919D RID: 37277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600919D")]
		[Address(RVA = "0x1F34E7C", Offset = "0x1F34E7C", VA = "0x7BBC734E7C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600919E RID: 37278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600919E")]
		[Address(RVA = "0x1F3507C", Offset = "0x1F3507C", VA = "0x7BBC73507C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x0600919F RID: 37279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2A")]
		protected override UILabel PriceLabel
		{
			[Token(Token = "0x600919F")]
			[Address(RVA = "0x1F35214", Offset = "0x1F35214", VA = "0x7BBC735214", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x060091A0 RID: 37280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2B")]
		protected override UILabel PeriodLabel
		{
			[Token(Token = "0x60091A0")]
			[Address(RVA = "0x1F35240", Offset = "0x1F35240", VA = "0x7BBC735240", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x060091A1 RID: 37281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2C")]
		protected override UITable PricingTable
		{
			[Token(Token = "0x60091A1")]
			[Address(RVA = "0x1F3526C", Offset = "0x1F3526C", VA = "0x7BBC73526C", Slot = "32")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x060091A2 RID: 37282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2D")]
		protected override UILabel SubscribeButtonLabel
		{
			[Token(Token = "0x60091A2")]
			[Address(RVA = "0x1F35298", Offset = "0x1F35298", VA = "0x7BBC735298", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x060091A3 RID: 37283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2E")]
		protected override UINetworkTextureExt NetworkTexture
		{
			[Token(Token = "0x60091A3")]
			[Address(RVA = "0x1F352C4", Offset = "0x1F352C4", VA = "0x7BBC7352C4", Slot = "34")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x060091A4 RID: 37284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2F")]
		protected override string NetworkTextureUrl
		{
			[Token(Token = "0x60091A4")]
			[Address(RVA = "0x1F352F0", Offset = "0x1F352F0", VA = "0x7BBC7352F0", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x060091A5 RID: 37285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A30")]
		protected override GameObject BonusGameObject
		{
			[Token(Token = "0x60091A5")]
			[Address(RVA = "0x1F3531C", Offset = "0x1F3531C", VA = "0x7BBC73531C", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x060091A6 RID: 37286 RVA: 0x00026C70 File Offset: 0x00024E70
		[Token(Token = "0x17000A31")]
		protected override bool BonusAvailable
		{
			[Token(Token = "0x60091A6")]
			[Address(RVA = "0x1F3535C", Offset = "0x1F3535C", VA = "0x7BBC73535C", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x060091A7 RID: 37287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A32")]
		protected override UILabel BonusLabel
		{
			[Token(Token = "0x60091A7")]
			[Address(RVA = "0x1F353FC", Offset = "0x1F353FC", VA = "0x7BBC7353FC", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x060091A8 RID: 37288 RVA: 0x00026C88 File Offset: 0x00024E88
		[Token(Token = "0x17000A33")]
		protected override int BonusAmount
		{
			[Token(Token = "0x60091A8")]
			[Address(RVA = "0x1F35428", Offset = "0x1F35428", VA = "0x7BBC735428", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x060091A9 RID: 37289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A34")]
		protected override UIButton FixOnHoldButton
		{
			[Token(Token = "0x60091A9")]
			[Address(RVA = "0x1F354E4", Offset = "0x1F354E4", VA = "0x7BBC7354E4", Slot = "40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060091AA RID: 37290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091AA")]
		[Address(RVA = "0x1F35510", Offset = "0x1F35510", VA = "0x7BBC735510", Slot = "41")]
		protected override GameObject GameObjectForStatus(bool subscribing)
		{
			return null;
		}

		// Token: 0x060091AB RID: 37291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091AB")]
		[Address(RVA = "0x1F3555C", Offset = "0x1F3555C", VA = "0x7BBC73555C", Slot = "42")]
		protected override GameObject GameObjectForGracePeriod(bool inGracePeriod)
		{
			return null;
		}

		// Token: 0x060091AC RID: 37292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60091AC")]
		[Address(RVA = "0x1F355A8", Offset = "0x1F355A8", VA = "0x7BBC7355A8", Slot = "43")]
		protected override GameObject GameObjectForOnHold(bool isOnHold)
		{
			return null;
		}

		// Token: 0x060091AD RID: 37293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091AD")]
		[Address(RVA = "0x1F355E0", Offset = "0x1F355E0", VA = "0x7BBC7355E0", Slot = "46")]
		protected override void UpdateSubscriptionUI()
		{
		}

		// Token: 0x060091AE RID: 37294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091AE")]
		[Address(RVA = "0x1F356D4", Offset = "0x1F356D4", VA = "0x7BBC7356D4")]
		private void UpdateRebateCardUI(RebateCardInfo info)
		{
		}

		// Token: 0x060091AF RID: 37295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091AF")]
		[Address(RVA = "0x1F358E0", Offset = "0x1F358E0", VA = "0x7BBC7358E0")]
		private void UpdateRebateCardDescriptions(RebateCardInfo info)
		{
		}

		// Token: 0x060091B0 RID: 37296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091B0")]
		[Address(RVA = "0x1F361B8", Offset = "0x1F361B8", VA = "0x7BBC7361B8")]
		private void OnSubscribeButtonClick()
		{
		}

		// Token: 0x060091B1 RID: 37297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091B1")]
		[Address(RVA = "0x1F36494", Offset = "0x1F36494", VA = "0x7BBC736494")]
		private void OnInfoButtonClick()
		{
		}

		// Token: 0x060091B2 RID: 37298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091B2")]
		[Address(RVA = "0x1F365B0", Offset = "0x1F365B0", VA = "0x7BBC7365B0")]
		private void OnGracePeriodButtonClick()
		{
		}

		// Token: 0x060091B3 RID: 37299 RVA: 0x00026CA0 File Offset: 0x00024EA0
		[Token(Token = "0x60091B3")]
		[Address(RVA = "0x1F36640", Offset = "0x1F36640", VA = "0x7BBC736640", Slot = "44")]
		public override uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060091B4 RID: 37300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091B4")]
		[Address(RVA = "0x1F3668C", Offset = "0x1F3668C", VA = "0x7BBC73668C", Slot = "45")]
		public override void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060091B5 RID: 37301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60091B5")]
		[Address(RVA = "0x1F36A0C", Offset = "0x1F36A0C", VA = "0x7BBC736A0C")]
		public UIPaymentSubscriptionRebateCardController()
		{
		}

		// Token: 0x04009C95 RID: 40085
		[Token(Token = "0x4009C95")]
		[FieldOffset(Offset = "0x78")]
		private UIPaymentSubscriptionRebateCardView m_View;

		// Token: 0x04009C96 RID: 40086
		[Token(Token = "0x4009C96")]
		[FieldOffset(Offset = "0x80")]
		private UIModelRebateCard RebateCard;

		// Token: 0x04009C97 RID: 40087
		[Token(Token = "0x4009C97")]
		[FieldOffset(Offset = "0x88")]
		private RebateCardType? m_RebateCardType;
	}
}
