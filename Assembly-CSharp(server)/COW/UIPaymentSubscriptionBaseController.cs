using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001ADA RID: 6874
	[Token(Token = "0x2001ADA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8C1C", Offset = "0x10F8C1C")]
	public abstract class UIPaymentSubscriptionBaseController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06009160 RID: 37216 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009161 RID: 37217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A10")]
		private protected UIModelPayment Payment
		{
			[Token(Token = "0x6009160")]
			[Address(RVA = "0x1F2DFD0", Offset = "0x1F2DFD0", VA = "0x7BBC72DFD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114499C", Offset = "0x114499C")]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6009161")]
			[Address(RVA = "0x1F2DFD8", Offset = "0x1F2DFD8", VA = "0x7BBC72DFD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11449AC", Offset = "0x11449AC")]
			private set
			{
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06009162 RID: 37218 RVA: 0x00026BE0 File Offset: 0x00024DE0
		// (set) Token: 0x06009163 RID: 37219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A11")]
		public UIPaymentSubscriptionHubController.DisplayInfo DisplayInfo
		{
			[Token(Token = "0x6009162")]
			[Address(RVA = "0x1F2DFE0", Offset = "0x1F2DFE0", VA = "0x7BBC72DFE0")]
			get
			{
				return default(UIPaymentSubscriptionHubController.DisplayInfo);
			}
			[Token(Token = "0x6009163")]
			[Address(RVA = "0x1F2DFE8", Offset = "0x1F2DFE8", VA = "0x7BBC72DFE8")]
			set
			{
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06009164 RID: 37220 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009165 RID: 37221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A12")]
		private protected SubscribeStoreDesc SubscriptionDescription
		{
			[Token(Token = "0x6009164")]
			[Address(RVA = "0x1F2E07C", Offset = "0x1F2E07C", VA = "0x7BBC72E07C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11449BC", Offset = "0x11449BC")]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6009165")]
			[Address(RVA = "0x1F2E06C", Offset = "0x1F2E06C", VA = "0x7BBC72E06C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11449CC", Offset = "0x11449CC")]
			private set
			{
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06009166 RID: 37222 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009167 RID: 37223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A13")]
		private protected AccountSubscription SubscriptionStatus
		{
			[Token(Token = "0x6009166")]
			[Address(RVA = "0x1F2E084", Offset = "0x1F2E084", VA = "0x7BBC72E084")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11449DC", Offset = "0x11449DC")]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6009167")]
			[Address(RVA = "0x1F2E074", Offset = "0x1F2E074", VA = "0x7BBC72E074")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11449EC", Offset = "0x11449EC")]
			private set
			{
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06009168 RID: 37224
		[Token(Token = "0x17000A14")]
		protected abstract UILabel PriceLabel { [Token(Token = "0x6009168")] get; }

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06009169 RID: 37225
		[Token(Token = "0x17000A15")]
		protected abstract UILabel PeriodLabel { [Token(Token = "0x6009169")] get; }

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x0600916A RID: 37226
		[Token(Token = "0x17000A16")]
		protected abstract UITable PricingTable { [Token(Token = "0x600916A")] get; }

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x0600916B RID: 37227
		[Token(Token = "0x17000A17")]
		protected abstract UILabel SubscribeButtonLabel { [Token(Token = "0x600916B")] get; }

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x0600916C RID: 37228
		[Token(Token = "0x17000A18")]
		protected abstract UINetworkTextureExt NetworkTexture { [Token(Token = "0x600916C")] get; }

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x0600916D RID: 37229
		[Token(Token = "0x17000A19")]
		protected abstract string NetworkTextureUrl { [Token(Token = "0x600916D")] get; }

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x0600916E RID: 37230
		[Token(Token = "0x17000A1A")]
		protected abstract GameObject BonusGameObject { [Token(Token = "0x600916E")] get; }

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x0600916F RID: 37231
		[Token(Token = "0x17000A1B")]
		protected abstract bool BonusAvailable { [Token(Token = "0x600916F")] get; }

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06009170 RID: 37232
		[Token(Token = "0x17000A1C")]
		protected abstract UILabel BonusLabel { [Token(Token = "0x6009170")] get; }

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06009171 RID: 37233
		[Token(Token = "0x17000A1D")]
		protected abstract int BonusAmount { [Token(Token = "0x6009171")] get; }

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06009172 RID: 37234
		[Token(Token = "0x17000A1E")]
		protected abstract UIButton FixOnHoldButton { [Token(Token = "0x6009172")] get; }

		// Token: 0x06009173 RID: 37235
		[Token(Token = "0x6009173")]
		protected abstract GameObject GameObjectForStatus(bool subscribing);

		// Token: 0x06009174 RID: 37236
		[Token(Token = "0x6009174")]
		protected abstract GameObject GameObjectForGracePeriod(bool inGracePeriod);

		// Token: 0x06009175 RID: 37237
		[Token(Token = "0x6009175")]
		protected abstract GameObject GameObjectForOnHold(bool isOnHold);

		// Token: 0x06009176 RID: 37238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009176")]
		[Address(RVA = "0x1F2E08C", Offset = "0x1F2E08C", VA = "0x7BBC72E08C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009177 RID: 37239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009177")]
		[Address(RVA = "0x1F2E160", Offset = "0x1F2E160", VA = "0x7BBC72E160", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06009178 RID: 37240 RVA: 0x00026BF8 File Offset: 0x00024DF8
		[Token(Token = "0x6009178")]
		[Address(RVA = "0x1F2E19C", Offset = "0x1F2E19C", VA = "0x7BBC72E19C", Slot = "44")]
		public virtual uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009179 RID: 37241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009179")]
		[Address(RVA = "0x1F2E220", Offset = "0x1F2E220", VA = "0x7BBC72E220", Slot = "45")]
		public virtual void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600917A RID: 37242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600917A")]
		[Address(RVA = "0x1F2E2E0", Offset = "0x1F2E2E0", VA = "0x7BBC72E2E0", Slot = "46")]
		protected virtual void UpdateSubscriptionUI()
		{
		}

		// Token: 0x0600917B RID: 37243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600917B")]
		[Address(RVA = "0x1F2E4B8", Offset = "0x1F2E4B8", VA = "0x7BBC72E4B8", Slot = "47")]
		protected virtual void UpdateSubscriptionPrice(PayItemData csv, PayItemData sdk)
		{
		}

		// Token: 0x0600917C RID: 37244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600917C")]
		[Address(RVA = "0x1F2E63C", Offset = "0x1F2E63C", VA = "0x7BBC72E63C", Slot = "48")]
		protected virtual void UpdateSubscriptionPeriod(PayItemData csv, PayItemData sdk)
		{
		}

		// Token: 0x0600917D RID: 37245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600917D")]
		[Address(RVA = "0x1F2E7EC", Offset = "0x1F2E7EC", VA = "0x7BBC72E7EC", Slot = "49")]
		protected virtual void UpdateSubscriptionNetworkTexture()
		{
		}

		// Token: 0x0600917E RID: 37246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600917E")]
		[Address(RVA = "0x1F2E8C4", Offset = "0x1F2E8C4", VA = "0x7BBC72E8C4", Slot = "50")]
		protected virtual void UpdateSubscriptionBonus()
		{
		}

		// Token: 0x0600917F RID: 37247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600917F")]
		[Address(RVA = "0x1F2EA58", Offset = "0x1F2EA58", VA = "0x7BBC72EA58", Slot = "51")]
		protected virtual void UpdateSubscriptionStatus(PayItemData csv, PayItemData sdk)
		{
		}

		// Token: 0x06009180 RID: 37248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009180")]
		[Address(RVA = "0x1F2ECCC", Offset = "0x1F2ECCC", VA = "0x7BBC72ECCC", Slot = "52")]
		protected virtual void UpdateSubscriptionGracePeriod(PayItemData csv, PayItemData sdk)
		{
		}

		// Token: 0x06009181 RID: 37249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009181")]
		[Address(RVA = "0x1F2EEB4", Offset = "0x1F2EEB4", VA = "0x7BBC72EEB4", Slot = "53")]
		protected virtual void UpdateSubscriptionOnHold(PayItemData csv, PayItemData sdk)
		{
		}

		// Token: 0x06009182 RID: 37250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009182")]
		[Address(RVA = "0x1F2F184", Offset = "0x1F2F184", VA = "0x7BBC72F184")]
		private void OnFixOnHoldButtonClick()
		{
		}

		// Token: 0x06009183 RID: 37251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009183")]
		[Address(RVA = "0x1F2F214", Offset = "0x1F2F214", VA = "0x7BBC72F214")]
		protected UIPaymentSubscriptionBaseController()
		{
		}

		// Token: 0x04009C90 RID: 40080
		[Token(Token = "0x4009C90")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FA3C", Offset = "0x112FA3C")]
		private UIModelPayment <Payment>k__BackingField;

		// Token: 0x04009C91 RID: 40081
		[Token(Token = "0x4009C91")]
		[FieldOffset(Offset = "0x60")]
		private UIPaymentSubscriptionHubController.DisplayInfo m_DisplayInfo;

		// Token: 0x04009C92 RID: 40082
		[Token(Token = "0x4009C92")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FA4C", Offset = "0x112FA4C")]
		private SubscribeStoreDesc <SubscriptionDescription>k__BackingField;

		// Token: 0x04009C93 RID: 40083
		[Token(Token = "0x4009C93")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FA5C", Offset = "0x112FA5C")]
		private AccountSubscription <SubscriptionStatus>k__BackingField;
	}
}
