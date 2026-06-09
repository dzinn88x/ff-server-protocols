using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001F90 RID: 8080
	[Token(Token = "0x2001F90")]
	public class UIModelPayment : UIBaseModel
	{
		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x0600B302 RID: 45826 RVA: 0x00032988 File Offset: 0x00030B88
		// (set) Token: 0x0600B303 RID: 45827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C12")]
		public UIModelPayment.PaymentBundleState BundleState
		{
			[Token(Token = "0x600B302")]
			[Address(RVA = "0x2428424", Offset = "0x2428424", VA = "0x7BBCC28424")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146C6C", Offset = "0x1146C6C")]
			get
			{
				return UIModelPayment.PaymentBundleState.NotLoaded;
			}
			[Token(Token = "0x600B303")]
			[Address(RVA = "0x242842C", Offset = "0x242842C", VA = "0x7BBCC2842C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146C7C", Offset = "0x1146C7C")]
			private set
			{
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x0600B304 RID: 45828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C13")]
		public List<PlayLevelInfo> PayLevelInfos
		{
			[Token(Token = "0x600B304")]
			[Address(RVA = "0x2428434", Offset = "0x2428434", VA = "0x7BBCC28434")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x0600B305 RID: 45829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C14")]
		public List<PayLevelRewardDesc> PayLevelRewardDescs
		{
			[Token(Token = "0x600B305")]
			[Address(RVA = "0x242843C", Offset = "0x242843C", VA = "0x7BBCC2843C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x0600B307 RID: 45831 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B306 RID: 45830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C15")]
		public PayLevelPoolDesc PayLevelPoolDesc
		{
			[Token(Token = "0x600B307")]
			[Address(RVA = "0x242844C", Offset = "0x242844C", VA = "0x7BBCC2844C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146C9C", Offset = "0x1146C9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B306")]
			[Address(RVA = "0x2428444", Offset = "0x2428444", VA = "0x7BBCC28444")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146C8C", Offset = "0x1146C8C")]
			private set
			{
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x0600B308 RID: 45832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C16")]
		public PayBundleWindowDesc GrowthFundBundleDesc
		{
			[Token(Token = "0x600B308")]
			[Address(RVA = "0x2428454", Offset = "0x2428454", VA = "0x7BBCC28454")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B309 RID: 45833 RVA: 0x000329A0 File Offset: 0x00030BA0
		[Token(Token = "0x600B309")]
		[Address(RVA = "0x2428518", Offset = "0x2428518", VA = "0x7BBCC28518", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B30A RID: 45834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B30A")]
		[Address(RVA = "0x2428520", Offset = "0x2428520", VA = "0x7BBCC28520", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600B30B RID: 45835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B30B")]
		[Address(RVA = "0x242894C", Offset = "0x242894C", VA = "0x7BBCC2894C")]
		public void RequestSubscriptionBundles()
		{
		}

		// Token: 0x0600B30C RID: 45836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B30C")]
		[Address(RVA = "0x2428C30", Offset = "0x2428C30", VA = "0x7BBCC28C30", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B30D RID: 45837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B30D")]
		[Address(RVA = "0x2428D84", Offset = "0x2428D84", VA = "0x7BBCC28D84")]
		private void GotoState(UIModelPayment.PaymentBundleState next)
		{
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x0600B30E RID: 45838 RVA: 0x000329B8 File Offset: 0x00030BB8
		[Token(Token = "0x17000C17")]
		public bool PaymentEnabled
		{
			[Token(Token = "0x600B30E")]
			[Address(RVA = "0x2428FB4", Offset = "0x2428FB4", VA = "0x7BBCC28FB4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x0600B30F RID: 45839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C18")]
		public string PaymentDisabledMessage
		{
			[Token(Token = "0x600B30F")]
			[Address(RVA = "0x2428FBC", Offset = "0x2428FBC", VA = "0x7BBCC28FBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x0600B310 RID: 45840 RVA: 0x000329D0 File Offset: 0x00030BD0
		[Token(Token = "0x17000C19")]
		public bool PaymentIAPEnabled
		{
			[Token(Token = "0x600B310")]
			[Address(RVA = "0x242900C", Offset = "0x242900C", VA = "0x7BBCC2900C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x0600B311 RID: 45841 RVA: 0x000329E8 File Offset: 0x00030BE8
		[Token(Token = "0x17000C1A")]
		public bool GrowthFundEnabled
		{
			[Token(Token = "0x600B311")]
			[Address(RVA = "0x2429014", Offset = "0x2429014", VA = "0x7BBCC29014")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x0600B312 RID: 45842 RVA: 0x00032A00 File Offset: 0x00030C00
		[Token(Token = "0x17000C1B")]
		public bool PaymentBundlesEnabled
		{
			[Token(Token = "0x600B312")]
			[Address(RVA = "0x242901C", Offset = "0x242901C", VA = "0x7BBCC2901C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x0600B313 RID: 45843 RVA: 0x00032A18 File Offset: 0x00030C18
		[Token(Token = "0x17000C1C")]
		public bool DiamondEventEnabled
		{
			[Token(Token = "0x600B313")]
			[Address(RVA = "0x24290D8", Offset = "0x24290D8", VA = "0x7BBCC290D8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x0600B314 RID: 45844 RVA: 0x00032A30 File Offset: 0x00030C30
		[Token(Token = "0x17000C1D")]
		public bool ShopEnabled
		{
			[Token(Token = "0x600B314")]
			[Address(RVA = "0x24290E0", Offset = "0x24290E0", VA = "0x7BBCC290E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x0600B315 RID: 45845 RVA: 0x00032A48 File Offset: 0x00030C48
		[Token(Token = "0x17000C1E")]
		public bool ShopFirst
		{
			[Token(Token = "0x600B315")]
			[Address(RVA = "0x24290E8", Offset = "0x24290E8", VA = "0x7BBCC290E8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B316 RID: 45846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B316")]
		[Address(RVA = "0x24290F0", Offset = "0x24290F0", VA = "0x7BBCC290F0")]
		public void UpdatePaymentBundles(bool force = false, bool silence = false)
		{
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x0600B317 RID: 45847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C1F")]
		public Dictionary<uint, PayBundleWindowDesc> PaymentBundles
		{
			[Token(Token = "0x600B317")]
			[Address(RVA = "0x24293C0", Offset = "0x24293C0", VA = "0x7BBCC293C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x0600B318 RID: 45848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C20")]
		public List<PayBundleWindowDesc> PaymentBundleList
		{
			[Token(Token = "0x600B318")]
			[Address(RVA = "0x24293C8", Offset = "0x24293C8", VA = "0x7BBCC293C8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x0600B319 RID: 45849 RVA: 0x00032A60 File Offset: 0x00030C60
		// (set) Token: 0x0600B31A RID: 45850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C21")]
		public ulong PaymentBundlesNextResetTime
		{
			[Token(Token = "0x600B319")]
			[Address(RVA = "0x24293D0", Offset = "0x24293D0", VA = "0x7BBCC293D0")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600B31A")]
			[Address(RVA = "0x2429468", Offset = "0x2429468", VA = "0x7BBCC29468")]
			private set
			{
			}
		}

		// Token: 0x0600B31B RID: 45851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B31B")]
		[Address(RVA = "0x2429470", Offset = "0x2429470", VA = "0x7BBCC29470")]
		private void OnUpdatedPaymentBundles(HttpErrorCode error, object resObj)
		{
		}

		// Token: 0x0600B31C RID: 45852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B31C")]
		[Address(RVA = "0x242A5F0", Offset = "0x242A5F0", VA = "0x7BBCC2A5F0")]
		public void OnDisplayPaymentBundles()
		{
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x0600B31D RID: 45853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C22")]
		public List<SpecialStoreDesc> PaymentSpecialStores
		{
			[Token(Token = "0x600B31D")]
			[Address(RVA = "0x242A68C", Offset = "0x242A68C", VA = "0x7BBCC2A68C")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B31E RID: 45854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B31E")]
		[Address(RVA = "0x242A694", Offset = "0x242A694", VA = "0x7BBCC2A694")]
		public void ProcessSpecialStoreDesc(CSGetPBWSpecialStoreRes res)
		{
		}

		// Token: 0x0600B31F RID: 45855 RVA: 0x00032A78 File Offset: 0x00030C78
		[Token(Token = "0x600B31F")]
		[Address(RVA = "0x242A8C0", Offset = "0x242A8C0", VA = "0x7BBCC2A8C0")]
		public bool HasPaymentSpecialStore(EStore.PbwActivityType type)
		{
			return default(bool);
		}

		// Token: 0x0600B320 RID: 45856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B320")]
		[Address(RVA = "0x242AA98", Offset = "0x242AA98", VA = "0x7BBCC2AA98")]
		public void PurchasePaymentBundle(uint id)
		{
		}

		// Token: 0x0600B321 RID: 45857 RVA: 0x00032A90 File Offset: 0x00030C90
		[Token(Token = "0x600B321")]
		[Address(RVA = "0x242ABF4", Offset = "0x242ABF4", VA = "0x7BBCC2ABF4")]
		public UIModelPayment.BundlePurchaseError CheckPaymentBundlePurchasable(uint id)
		{
			return UIModelPayment.BundlePurchaseError.None;
		}

		// Token: 0x0600B322 RID: 45858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B322")]
		[Address(RVA = "0x242A0D4", Offset = "0x242A0D4", VA = "0x7BBCC2A0D4")]
		private void PayForPendingPaymentBundle()
		{
		}

		// Token: 0x0600B323 RID: 45859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B323")]
		[Address(RVA = "0x242AEEC", Offset = "0x242AEEC", VA = "0x7BBCC2AEEC")]
		public void OnPaymentBundlePaid(bool success, string productIdentifier, long rebateId)
		{
		}

		// Token: 0x0600B324 RID: 45860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B324")]
		[Address(RVA = "0x242AFFC", Offset = "0x242AFFC", VA = "0x7BBCC2AFFC")]
		private void ExchangePendingPaymentBundle()
		{
		}

		// Token: 0x0600B325 RID: 45861 RVA: 0x00032AA8 File Offset: 0x00030CA8
		[Token(Token = "0x600B325")]
		[Address(RVA = "0x242B2F4", Offset = "0x242B2F4", VA = "0x7BBCC2B2F4")]
		public bool BuyPaymentBundle(uint bundleID, EStore.PbwConsumeType type)
		{
			return default(bool);
		}

		// Token: 0x0600B326 RID: 45862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B326")]
		[Address(RVA = "0x2429B74", Offset = "0x2429B74", VA = "0x7BBCC29B74")]
		public void CheckFreeBundles()
		{
		}

		// Token: 0x0600B327 RID: 45863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B327")]
		[Address(RVA = "0x242B5B0", Offset = "0x242B5B0", VA = "0x7BBCC2B5B0")]
		private void OnPaymentBundlePaid(HttpErrorCode error, object resObj)
		{
		}

		// Token: 0x0600B328 RID: 45864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B328")]
		[Address(RVA = "0x242B8C4", Offset = "0x242B8C4", VA = "0x7BBCC2B8C4")]
		private void OnPaymentBundleExchanged(HttpErrorCode error, object resObj)
		{
		}

		// Token: 0x0600B329 RID: 45865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B329")]
		[Address(RVA = "0x242BB94", Offset = "0x242BB94", VA = "0x7BBCC2BB94")]
		public void OnPaymentBundleReceived(CSPayBundleWindowPurchaseRes resObj)
		{
		}

		// Token: 0x0600B32A RID: 45866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B32A")]
		[Address(RVA = "0x242C04C", Offset = "0x242C04C", VA = "0x7BBCC2C04C")]
		public void CacheVersion(UIModelPayment.VersionType versionType)
		{
		}

		// Token: 0x0600B32B RID: 45867 RVA: 0x00032AC0 File Offset: 0x00030CC0
		[Token(Token = "0x600B32B")]
		[Address(RVA = "0x242C184", Offset = "0x242C184", VA = "0x7BBCC2C184")]
		public bool SameVersion(UIModelPayment.VersionType versionType)
		{
			return default(bool);
		}

		// Token: 0x0600B32C RID: 45868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B32C")]
		[Address(RVA = "0x242C268", Offset = "0x242C268", VA = "0x7BBCC2C268")]
		private string GetLocalVersion(UIModelPayment.VersionType versionType)
		{
			return null;
		}

		// Token: 0x0600B32D RID: 45869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B32D")]
		[Address(RVA = "0x242C3E8", Offset = "0x242C3E8", VA = "0x7BBCC2C3E8")]
		public Dictionary<uint, UIModelPayment.PaymentButtonDisplayInfo> GetPaymentButton()
		{
			return null;
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x0600B32E RID: 45870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C23")]
		public List<PayItemData> DiamondProducts
		{
			[Token(Token = "0x600B32E")]
			[Address(RVA = "0x242C6E4", Offset = "0x242C6E4", VA = "0x7BBCC2C6E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B32F RID: 45871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B32F")]
		[Address(RVA = "0x2428608", Offset = "0x2428608", VA = "0x7BBCC28608")]
		private void LoadDiamondProductsFromCSV()
		{
		}

		// Token: 0x0600B330 RID: 45872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B330")]
		[Address(RVA = "0x242C6EC", Offset = "0x242C6EC", VA = "0x7BBCC2C6EC")]
		public void ReloadDiamondProducts()
		{
		}

		// Token: 0x0600B331 RID: 45873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B331")]
		[Address(RVA = "0x242C788", Offset = "0x242C788", VA = "0x7BBCC2C788")]
		public void PurchaseDiamondProduct(string productIdentifier)
		{
		}

		// Token: 0x0600B332 RID: 45874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B332")]
		[Address(RVA = "0x242C7F4", Offset = "0x242C7F4", VA = "0x7BBCC2C7F4")]
		private void OnDiamondProductPurchased(string productIdentifier)
		{
		}

		// Token: 0x0600B333 RID: 45875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B333")]
		[Address(RVA = "0x242CB1C", Offset = "0x242CB1C", VA = "0x7BBCC2CB1C")]
		public DiamondSpendEventDesc GetDiamondEventTier()
		{
			return null;
		}

		// Token: 0x0600B334 RID: 45876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B334")]
		[Address(RVA = "0x242CF68", Offset = "0x242CF68", VA = "0x7BBCC2CF68")]
		public void RequestTopupEvent(uint eventType, bool force = false, uint httpOp = 0U)
		{
		}

		// Token: 0x0600B335 RID: 45877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B335")]
		[Address(RVA = "0x242D3BC", Offset = "0x242D3BC", VA = "0x7BBCC2D3BC")]
		public void ReloadDiamondEventProducts()
		{
		}

		// Token: 0x0600B336 RID: 45878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B336")]
		[Address(RVA = "0x242D458", Offset = "0x242D458", VA = "0x7BBCC2D458")]
		public void RequestMysteryBonusSpin()
		{
		}

		// Token: 0x0600B337 RID: 45879 RVA: 0x00032AD8 File Offset: 0x00030CD8
		[Token(Token = "0x600B337")]
		[Address(RVA = "0x242D2D4", Offset = "0x242D2D4", VA = "0x7BBCC2D2D4")]
		private bool CanRequestMysteryBonus()
		{
			return default(bool);
		}

		// Token: 0x0600B338 RID: 45880 RVA: 0x00032AF0 File Offset: 0x00030CF0
		[Token(Token = "0x600B338")]
		[Address(RVA = "0x242D604", Offset = "0x242D604", VA = "0x7BBCC2D604")]
		private bool IsBonusRequestInCoolDown()
		{
			return default(bool);
		}

		// Token: 0x0600B339 RID: 45881 RVA: 0x00032B08 File Offset: 0x00030D08
		[Token(Token = "0x600B339")]
		[Address(RVA = "0x242C938", Offset = "0x242C938", VA = "0x7BBCC2C938")]
		public bool HasBonusTopUpTimes()
		{
			return default(bool);
		}

		// Token: 0x0600B33A RID: 45882 RVA: 0x00032B20 File Offset: 0x00030D20
		[Token(Token = "0x600B33A")]
		[Address(RVA = "0x242C9D0", Offset = "0x242C9D0", VA = "0x7BBCC2C9D0")]
		public uint GetRemainBonusTimes()
		{
			return 0U;
		}

		// Token: 0x0600B33B RID: 45883 RVA: 0x00032B38 File Offset: 0x00030D38
		[Token(Token = "0x600B33B")]
		[Address(RVA = "0x242C96C", Offset = "0x242C96C", VA = "0x7BBCC2C96C")]
		public uint GetBonusPercent()
		{
			return 0U;
		}

		// Token: 0x0600B33C RID: 45884 RVA: 0x00032B50 File Offset: 0x00030D50
		[Token(Token = "0x600B33C")]
		[Address(RVA = "0x242D750", Offset = "0x242D750", VA = "0x7BBCC2D750")]
		public float GetBonusPercentFloat()
		{
			return 0f;
		}

		// Token: 0x0600B33D RID: 45885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B33D")]
		[Address(RVA = "0x242C994", Offset = "0x242C994", VA = "0x7BBCC2C994")]
		public void BonusTopupTimesAdd(uint time)
		{
		}

		// Token: 0x0600B33E RID: 45886 RVA: 0x00032B68 File Offset: 0x00030D68
		[Token(Token = "0x600B33E")]
		[Address(RVA = "0x242D6B8", Offset = "0x242D6B8", VA = "0x7BBCC2D6B8")]
		public bool HasOpeningBonusEvent()
		{
			return default(bool);
		}

		// Token: 0x0600B33F RID: 45887 RVA: 0x00032B80 File Offset: 0x00030D80
		[Token(Token = "0x600B33F")]
		[Address(RVA = "0x242D5DC", Offset = "0x242D5DC", VA = "0x7BBCC2D5DC")]
		public bool IsValidMysteryBonusData()
		{
			return default(bool);
		}

		// Token: 0x0600B340 RID: 45888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B340")]
		[Address(RVA = "0x242CA04", Offset = "0x242CA04", VA = "0x7BBCC2CA04")]
		public void SetMysteryBonusTipsNum()
		{
		}

		// Token: 0x0600B341 RID: 45889 RVA: 0x00032B98 File Offset: 0x00030D98
		[Token(Token = "0x600B341")]
		[Address(RVA = "0x242D788", Offset = "0x242D788", VA = "0x7BBCC2D788")]
		public bool IsValidDiamondEvent()
		{
			return default(bool);
		}

		// Token: 0x0600B342 RID: 45890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B342")]
		[Address(RVA = "0x242D8D4", Offset = "0x242D8D4", VA = "0x7BBCC2D8D4")]
		public void SetDiamondEventTipsNum()
		{
		}

		// Token: 0x0600B343 RID: 45891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B343")]
		[Address(RVA = "0x242D978", Offset = "0x242D978", VA = "0x7BBCC2D978")]
		public void PurchaseDiamondEventProduct(string productIdentifier)
		{
		}

		// Token: 0x0600B344 RID: 45892 RVA: 0x00032BB0 File Offset: 0x00030DB0
		[Token(Token = "0x600B344")]
		[Address(RVA = "0x242D9E4", Offset = "0x242D9E4", VA = "0x7BBCC2D9E4")]
		public static RebateCardType? ConvertToRebateCardType(ESubscription.PriceType price_type)
		{
			return null;
		}

		// Token: 0x0600B345 RID: 45893 RVA: 0x00032BC8 File Offset: 0x00030DC8
		[Token(Token = "0x600B345")]
		[Address(RVA = "0x242DA70", Offset = "0x242DA70", VA = "0x7BBCC2DA70")]
		public static SubscriptionPeriod ConvertToSubscriptionPeriod(ESubscription.PriceType price_type)
		{
			return SubscriptionPeriod.None;
		}

		// Token: 0x0600B346 RID: 45894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B346")]
		[Address(RVA = "0x242DA84", Offset = "0x242DA84", VA = "0x7BBCC2DA84")]
		public PayItemData SubscriptionBundleProductFromCSV(uint store_id)
		{
			return null;
		}

		// Token: 0x0600B347 RID: 45895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B347")]
		[Address(RVA = "0x242DD14", Offset = "0x242DD14", VA = "0x7BBCC2DD14")]
		public List<SubscribeStoreDesc> Subscriptions()
		{
			return null;
		}

		// Token: 0x0600B348 RID: 45896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B348")]
		[Address(RVA = "0x242DC94", Offset = "0x242DC94", VA = "0x7BBCC2DC94")]
		public SubscribeStoreDesc DescriptionOfSubscription(uint store_id)
		{
			return null;
		}

		// Token: 0x0600B349 RID: 45897 RVA: 0x00032BE0 File Offset: 0x00030DE0
		[Token(Token = "0x600B349")]
		[Address(RVA = "0x242DF88", Offset = "0x242DF88", VA = "0x7BBCC2DF88")]
		public bool SubscriptionBundleBonusAvailable(uint store_id)
		{
			return default(bool);
		}

		// Token: 0x0600B34A RID: 45898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B34A")]
		[Address(RVA = "0x242DFD4", Offset = "0x242DFD4", VA = "0x7BBCC2DFD4")]
		public AccountSubscription StatusOfSubscription(uint store_id)
		{
			return null;
		}

		// Token: 0x0600B34B RID: 45899 RVA: 0x00032BF8 File Offset: 0x00030DF8
		[Token(Token = "0x600B34B")]
		[Address(RVA = "0x242DF80", Offset = "0x242DF80", VA = "0x7BBCC2DF80")]
		public bool CanDisplaySubscription(uint store_id)
		{
			return default(bool);
		}

		// Token: 0x0600B34C RID: 45900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B34C")]
		[Address(RVA = "0x24289BC", Offset = "0x24289BC", VA = "0x7BBCC289BC")]
		private void FetchSubscriptionBundles(uint http = 0U)
		{
		}

		// Token: 0x0600B34D RID: 45901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B34D")]
		[Address(RVA = "0x242E05C", Offset = "0x242E05C", VA = "0x7BBCC2E05C")]
		public void ShowSubscriptionBundleHint(uint store_id, Vector3 position)
		{
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x0600B34E RID: 45902 RVA: 0x00032C10 File Offset: 0x00030E10
		[Token(Token = "0x17000C24")]
		public bool HasSeenSubscriptionHub
		{
			[Token(Token = "0x600B34E")]
			[Address(RVA = "0x242E638", Offset = "0x242E638", VA = "0x7BBCC2E638")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x0600B34F RID: 45903 RVA: 0x00032C28 File Offset: 0x00030E28
		[Token(Token = "0x17000C25")]
		public bool HasSeenGrowthFund
		{
			[Token(Token = "0x600B34F")]
			[Address(RVA = "0x242E6B8", Offset = "0x242E6B8", VA = "0x7BBCC2E6B8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B350 RID: 45904 RVA: 0x00032C40 File Offset: 0x00030E40
		[Token(Token = "0x600B350")]
		[Address(RVA = "0x242E738", Offset = "0x242E738", VA = "0x7BBCC2E738")]
		public bool EnableSubscriptionHub()
		{
			return default(bool);
		}

		// Token: 0x0600B351 RID: 45905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B351")]
		[Address(RVA = "0x242E740", Offset = "0x242E740", VA = "0x7BBCC2E740")]
		public void SeenGrowthFund()
		{
		}

		// Token: 0x0600B352 RID: 45906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B352")]
		[Address(RVA = "0x242E86C", Offset = "0x242E86C", VA = "0x7BBCC2E86C")]
		public void SeenSubscriptionHub()
		{
		}

		// Token: 0x0600B353 RID: 45907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B353")]
		[Address(RVA = "0x242EA9C", Offset = "0x242EA9C", VA = "0x7BBCC2EA9C")]
		public void UpdateSubscriptionHubProducts()
		{
		}

		// Token: 0x0600B354 RID: 45908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B354")]
		[Address(RVA = "0x242EB38", Offset = "0x242EB38", VA = "0x7BBCC2EB38")]
		private void UpdateSubscriptionBundleStatus(uint httpOption = 0U)
		{
		}

		// Token: 0x0600B355 RID: 45909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B355")]
		[Address(RVA = "0x242E44C", Offset = "0x242E44C", VA = "0x7BBCC2E44C")]
		public PayItemData SubscriptionProduct_CSV(uint store_id)
		{
			return null;
		}

		// Token: 0x0600B356 RID: 45910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B356")]
		[Address(RVA = "0x242E250", Offset = "0x242E250", VA = "0x7BBCC2E250")]
		public PayItemData SubscriptionProduct_SDK(uint store_id)
		{
			return null;
		}

		// Token: 0x0600B357 RID: 45911 RVA: 0x00032C58 File Offset: 0x00030E58
		[Token(Token = "0x600B357")]
		[Address(RVA = "0x242ECFC", Offset = "0x242ECFC", VA = "0x7BBCC2ECFC")]
		public bool HasRedDotForSubscription(uint store_id)
		{
			return default(bool);
		}

		// Token: 0x0600B358 RID: 45912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B358")]
		[Address(RVA = "0x242E8EC", Offset = "0x242E8EC", VA = "0x7BBCC2E8EC")]
		private void UpdateSubscriptionHubTips()
		{
		}

		// Token: 0x0600B359 RID: 45913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B359")]
		[Address(RVA = "0x242E7C0", Offset = "0x242E7C0", VA = "0x7BBCC2E7C0")]
		private void UpdateGrowthFundTips()
		{
		}

		// Token: 0x0600B35A RID: 45914 RVA: 0x00032C70 File Offset: 0x00030E70
		[Token(Token = "0x600B35A")]
		[Address(RVA = "0x242EF14", Offset = "0x242EF14", VA = "0x7BBCC2EF14")]
		public bool WithinSubscriptionPeriod(uint store_id)
		{
			return default(bool);
		}

		// Token: 0x0600B35B RID: 45915 RVA: 0x00032C88 File Offset: 0x00030E88
		[Token(Token = "0x600B35B")]
		[Address(RVA = "0x242EF58", Offset = "0x242EF58", VA = "0x7BBCC2EF58")]
		public bool WithinSubscriptionPeriod(PayItemData csv, PayItemData sdk)
		{
			return default(bool);
		}

		// Token: 0x0600B35C RID: 45916 RVA: 0x00032CA0 File Offset: 0x00030EA0
		[Token(Token = "0x600B35C")]
		[Address(RVA = "0x242EF80", Offset = "0x242EF80", VA = "0x7BBCC2EF80")]
		public bool Subscribing(uint store_id)
		{
			return default(bool);
		}

		// Token: 0x0600B35D RID: 45917 RVA: 0x00032CB8 File Offset: 0x00030EB8
		[Token(Token = "0x600B35D")]
		[Address(RVA = "0x242ED9C", Offset = "0x242ED9C", VA = "0x7BBCC2ED9C")]
		public bool Subscribing(PayItemData csv, PayItemData sdk)
		{
			return default(bool);
		}

		// Token: 0x0600B35E RID: 45918 RVA: 0x00032CD0 File Offset: 0x00030ED0
		[Token(Token = "0x600B35E")]
		[Address(RVA = "0x242EFC4", Offset = "0x242EFC4", VA = "0x7BBCC2EFC4")]
		public bool InGracePeriod(PayItemData csv, PayItemData sdk)
		{
			return default(bool);
		}

		// Token: 0x0600B35F RID: 45919 RVA: 0x00032CE8 File Offset: 0x00030EE8
		[Token(Token = "0x600B35F")]
		[Address(RVA = "0x242F018", Offset = "0x242F018", VA = "0x7BBCC2F018")]
		public bool IsOnHold(PayItemData csv, PayItemData sdk)
		{
			return default(bool);
		}

		// Token: 0x0600B360 RID: 45920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B360")]
		[Address(RVA = "0x242F040", Offset = "0x242F040", VA = "0x7BBCC2F040")]
		public void OnServerNoticedPayment(uint rebate_card_id)
		{
		}

		// Token: 0x0600B361 RID: 45921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B361")]
		[Address(RVA = "0x242F1AC", Offset = "0x242F1AC", VA = "0x7BBCC2F1AC")]
		public void ClaimSubscriptionBundle(uint store_id)
		{
		}

		// Token: 0x0600B362 RID: 45922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B362")]
		[Address(RVA = "0x242F45C", Offset = "0x242F45C", VA = "0x7BBCC2F45C")]
		private void _ClaimSubscriptionBundle(uint store_id)
		{
		}

		// Token: 0x0600B363 RID: 45923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B363")]
		[Address(RVA = "0x242F678", Offset = "0x242F678", VA = "0x7BBCC2F678")]
		public void Subscribe(uint store_id)
		{
		}

		// Token: 0x0600B364 RID: 45924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B364")]
		[Address(RVA = "0x242FC38", Offset = "0x242FC38", VA = "0x7BBCC2FC38")]
		private void OnSubscribed(string subscriptionProductIdentifier)
		{
		}

		// Token: 0x0600B365 RID: 45925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B365")]
		[Address(RVA = "0x2430264", Offset = "0x2430264", VA = "0x7BBCC30264")]
		public void GetGrowthFundDescs()
		{
		}

		// Token: 0x0600B366 RID: 45926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B366")]
		[Address(RVA = "0x24302C8", Offset = "0x24302C8", VA = "0x7BBCC302C8")]
		public void OnGetPayLevelConfig(CSGetPayLevelConfigRes res)
		{
		}

		// Token: 0x0600B367 RID: 45927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B367")]
		[Address(RVA = "0x2430638", Offset = "0x2430638", VA = "0x7BBCC30638")]
		public PlayLevelInfo GetPayLevelItemInfo(uint id, uint level)
		{
			return null;
		}

		// Token: 0x0600B368 RID: 45928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B368")]
		[Address(RVA = "0x243046C", Offset = "0x243046C", VA = "0x7BBCC3046C")]
		public void GetPayLevelInfo(uint id, bool silence = false)
		{
		}

		// Token: 0x0600B369 RID: 45929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B369")]
		[Address(RVA = "0x2430788", Offset = "0x2430788", VA = "0x7BBCC30788")]
		public void ClaimPayLevelReward(uint id, uint level)
		{
		}

		// Token: 0x0600B36A RID: 45930 RVA: 0x00032D00 File Offset: 0x00030F00
		[Token(Token = "0x600B36A")]
		[Address(RVA = "0x2430A88", Offset = "0x2430A88", VA = "0x7BBCC30A88")]
		public ResourceID GetPayLevelRewardIcon(uint level)
		{
			return default(ResourceID);
		}

		// Token: 0x0600B36B RID: 45931 RVA: 0x00032D18 File Offset: 0x00030F18
		[Token(Token = "0x600B36B")]
		[Address(RVA = "0x2430D3C", Offset = "0x2430D3C", VA = "0x7BBCC30D3C")]
		public uint GetTotalPayLevelRewardDiamondCount()
		{
			return 0U;
		}

		// Token: 0x0600B36C RID: 45932 RVA: 0x00032D30 File Offset: 0x00030F30
		[Token(Token = "0x600B36C")]
		[Address(RVA = "0x2430EE8", Offset = "0x2430EE8", VA = "0x7BBCC30EE8")]
		public uint GetPayLevelMaxLevel()
		{
			return 0U;
		}

		// Token: 0x0600B36D RID: 45933 RVA: 0x00032D48 File Offset: 0x00030F48
		[Token(Token = "0x600B36D")]
		[Address(RVA = "0x243101C", Offset = "0x243101C", VA = "0x7BBCC3101C")]
		public uint GetCurPayLevelInfoFinishedLevel()
		{
			return 0U;
		}

		// Token: 0x0600B36E RID: 45934 RVA: 0x00032D60 File Offset: 0x00030F60
		[Token(Token = "0x600B36E")]
		[Address(RVA = "0x24312E4", Offset = "0x24312E4", VA = "0x7BBCC312E4")]
		public EStore.PayLevelRewardHintType GetCurPayLevelDescHint()
		{
			return EStore.PayLevelRewardHintType.PayLevelRewardHintType_NONE;
		}

		// Token: 0x0600B36F RID: 45935 RVA: 0x00032D78 File Offset: 0x00030F78
		[Token(Token = "0x600B36F")]
		[Address(RVA = "0x2431428", Offset = "0x2431428", VA = "0x7BBCC31428")]
		public bool HasBoughtGrowthFund()
		{
			return default(bool);
		}

		// Token: 0x0600B370 RID: 45936 RVA: 0x00032D90 File Offset: 0x00030F90
		[Token(Token = "0x600B370")]
		[Address(RVA = "0x2431460", Offset = "0x2431460", VA = "0x7BBCC31460")]
		private uint GetBundlePurchaseTimes(uint bundleId)
		{
			return 0U;
		}

		// Token: 0x0600B371 RID: 45937 RVA: 0x00032DA8 File Offset: 0x00030FA8
		[Token(Token = "0x600B371")]
		[Address(RVA = "0x242EDDC", Offset = "0x242EDDC", VA = "0x7BBCC2EDDC")]
		public bool ExistFinishedPayLevelReward()
		{
			return default(bool);
		}

		// Token: 0x0600B372 RID: 45938 RVA: 0x00032DC0 File Offset: 0x00030FC0
		[Token(Token = "0x600B372")]
		[Address(RVA = "0x2431518", Offset = "0x2431518", VA = "0x7BBCC31518")]
		public bool ExistUnawardedPayLevelReward()
		{
			return default(bool);
		}

		// Token: 0x0600B373 RID: 45939 RVA: 0x00032DD8 File Offset: 0x00030FD8
		[Token(Token = "0x600B373")]
		[Address(RVA = "0x2431708", Offset = "0x2431708", VA = "0x7BBCC31708")]
		public EStore.PayLevelInfoState CalcPayLevelInfoState(uint level)
		{
			return EStore.PayLevelInfoState.PayLevelInfoState_RECEIVED;
		}

		// Token: 0x0600B374 RID: 45940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B374")]
		[Address(RVA = "0x24318C8", Offset = "0x24318C8", VA = "0x7BBCC318C8")]
		public UIModelPayment()
		{
		}

		// Token: 0x0600B376 RID: 45942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B376")]
		[Address(RVA = "0x2431DE4", Offset = "0x2431DE4", VA = "0x7BBCC31DE4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146CAC", Offset = "0x1146CAC")]
		private void <RequestMysteryBonusSpin>b__123_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B377 RID: 45943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B377")]
		[Address(RVA = "0x2431F14", Offset = "0x2431F14", VA = "0x7BBCC31F14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146CBC", Offset = "0x1146CBC")]
		private void <UpdateSubscriptionBundleStatus>b__161_0(HttpErrorCode error, object resObj)
		{
		}

		// Token: 0x0600B378 RID: 45944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B378")]
		[Address(RVA = "0x2432134", Offset = "0x2432134", VA = "0x7BBCC32134")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146CCC", Offset = "0x1146CCC")]
		private void <GetPayLevelInfo>b__182_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B5BC RID: 46524
		[Token(Token = "0x400B5BC")]
		[FieldOffset(Offset = "0x18")]
		private WaitingResponseHandler m_WaitingHandler;

		// Token: 0x0400B5BD RID: 46525
		[Token(Token = "0x400B5BD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113032C", Offset = "0x113032C")]
		private UIModelPayment.PaymentBundleState <BundleState>k__BackingField;

		// Token: 0x0400B5BE RID: 46526
		[Token(Token = "0x400B5BE")]
		[FieldOffset(Offset = "0x28")]
		private List<PlayLevelInfo> m_PayLevelInfos;

		// Token: 0x0400B5BF RID: 46527
		[Token(Token = "0x400B5BF")]
		[FieldOffset(Offset = "0x30")]
		private List<PayLevelRewardDesc> m_PayLevelRewardDescs;

		// Token: 0x0400B5C0 RID: 46528
		[Token(Token = "0x400B5C0")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113033C", Offset = "0x113033C")]
		private PayLevelPoolDesc <PayLevelPoolDesc>k__BackingField;

		// Token: 0x0400B5C1 RID: 46529
		[Token(Token = "0x400B5C1")]
		[FieldOffset(Offset = "0x40")]
		private PayBundleWindowDesc m_GrowthFundBundleDesc;

		// Token: 0x0400B5C2 RID: 46530
		[Token(Token = "0x400B5C2")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<uint, ResourceID> m_GrowthFundPics;

		// Token: 0x0400B5C3 RID: 46531
		[Token(Token = "0x400B5C3")]
		public const uint PropID_PaymentBundlesUpdated = 2U;

		// Token: 0x0400B5C4 RID: 46532
		[Token(Token = "0x400B5C4")]
		public const uint PropID_DiamondProductPurchased = 4U;

		// Token: 0x0400B5C5 RID: 46533
		[Token(Token = "0x400B5C5")]
		public const uint PropID_PaymentBundleExchanged = 8U;

		// Token: 0x0400B5C6 RID: 46534
		[Token(Token = "0x400B5C6")]
		public const uint PropID_MysteryBonusUpdated = 16U;

		// Token: 0x0400B5C7 RID: 46535
		[Token(Token = "0x400B5C7")]
		public const uint PropID_MysteryBonusSpinUpdated = 32U;

		// Token: 0x0400B5C8 RID: 46536
		[Token(Token = "0x400B5C8")]
		public const uint PropID_DiamondEvent = 64U;

		// Token: 0x0400B5C9 RID: 46537
		[Token(Token = "0x400B5C9")]
		public const uint PropID_SubscriptionBundlesUpdated = 128U;

		// Token: 0x0400B5CA RID: 46538
		[Token(Token = "0x400B5CA")]
		public const uint PropID_SubscriptionBundleStatusUpdated = 256U;

		// Token: 0x0400B5CB RID: 46539
		[Token(Token = "0x400B5CB")]
		public const uint PropID_SubscriptionBundleClaimed = 512U;

		// Token: 0x0400B5CC RID: 46540
		[Token(Token = "0x400B5CC")]
		public const uint PropID_Subscribed = 1024U;

		// Token: 0x0400B5CD RID: 46541
		[Token(Token = "0x400B5CD")]
		public const uint PropID_DiamondProductsUpdated = 2048U;

		// Token: 0x0400B5CE RID: 46542
		[Token(Token = "0x400B5CE")]
		public const uint PropID_SubscriptionProductsUpdated = 4096U;

		// Token: 0x0400B5CF RID: 46543
		[Token(Token = "0x400B5CF")]
		public const uint PropID_DiamondEventProductsUpdated = 8192U;

		// Token: 0x0400B5D0 RID: 46544
		[Token(Token = "0x400B5D0")]
		public const uint PropID_DiamondEventProductPurchased = 16384U;

		// Token: 0x0400B5D1 RID: 46545
		[Token(Token = "0x400B5D1")]
		public const uint PropID_GetGrowthFundDescs = 32768U;

		// Token: 0x0400B5D2 RID: 46546
		[Token(Token = "0x400B5D2")]
		public const uint PropID_PaymentBundlePurchased = 65536U;

		// Token: 0x0400B5D3 RID: 46547
		[Token(Token = "0x400B5D3")]
		public const uint PropID_GetPayLevelInfo = 131072U;

		// Token: 0x0400B5D4 RID: 46548
		[Token(Token = "0x400B5D4")]
		public const uint PropID_ClaimPayLevelReward = 262144U;

		// Token: 0x0400B5D5 RID: 46549
		[Token(Token = "0x400B5D5")]
		public const string PAYMENTBUNDLENEWBIE = "PaymentBundleNewbie_";

		// Token: 0x0400B5D6 RID: 46550
		[Token(Token = "0x400B5D6")]
		public const string PAYMENTBUNDLEDISCOUNT = "PaymentBundleDiscount_";

		// Token: 0x0400B5D7 RID: 46551
		[Token(Token = "0x400B5D7")]
		private const uint RELOAD_BUNDLES_INTERVAL_S = 1800U;

		// Token: 0x0400B5D8 RID: 46552
		[Token(Token = "0x400B5D8")]
		[FieldOffset(Offset = "0x50")]
		private ulong m_LastReloadBundles;

		// Token: 0x0400B5D9 RID: 46553
		[Token(Token = "0x400B5D9")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<uint, PayBundleWindowDesc> m_PaymentBundles;

		// Token: 0x0400B5DA RID: 46554
		[Token(Token = "0x400B5DA")]
		[FieldOffset(Offset = "0x60")]
		private List<PayBundleWindowDesc> m_PaymentBundleList;

		// Token: 0x0400B5DB RID: 46555
		[Token(Token = "0x400B5DB")]
		[FieldOffset(Offset = "0x68")]
		private ulong m_BundlesNextResetTime;

		// Token: 0x0400B5DC RID: 46556
		[Token(Token = "0x400B5DC")]
		[FieldOffset(Offset = "0x70")]
		private List<SpecialStoreDesc> m_PaymentSpecialStores;

		// Token: 0x0400B5DD RID: 46557
		[Token(Token = "0x400B5DD")]
		[FieldOffset(Offset = "0x78")]
		private uint m_PaymentBundleId_Paying;

		// Token: 0x0400B5DE RID: 46558
		[Token(Token = "0x400B5DE")]
		[FieldOffset(Offset = "0x7C")]
		private uint m_PaymentBundleId_Exchanging;

		// Token: 0x0400B5DF RID: 46559
		[Token(Token = "0x400B5DF")]
		[FieldOffset(Offset = "0x80")]
		private uint m_currentBuyingBundleID;

		// Token: 0x0400B5E0 RID: 46560
		[Token(Token = "0x400B5E0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<UIModelPayment.VersionType, UIModelPayment.VersionInfo> _Versions;

		// Token: 0x0400B5E1 RID: 46561
		[Token(Token = "0x400B5E1")]
		[FieldOffset(Offset = "0x88")]
		private List<PayItemData> _DiamondProducts;

		// Token: 0x0400B5E2 RID: 46562
		[Token(Token = "0x400B5E2")]
		private const int REQUEST_MYSTERYBONUS_INTERVAL_S = 1200;

		// Token: 0x0400B5E3 RID: 46563
		[Token(Token = "0x400B5E3")]
		[FieldOffset(Offset = "0x90")]
		private float m_LastRequestMysteryBonusTime;

		// Token: 0x0400B5E4 RID: 46564
		[Token(Token = "0x400B5E4")]
		[FieldOffset(Offset = "0x98")]
		public MysteryBonusInfo m_MysteryBonusData;

		// Token: 0x0400B5E5 RID: 46565
		[Token(Token = "0x400B5E5")]
		[FieldOffset(Offset = "0xA0")]
		public DiamondSpendEventInfo m_DiamondEventData;

		// Token: 0x0400B5E6 RID: 46566
		[Token(Token = "0x400B5E6")]
		[FieldOffset(Offset = "0xA8")]
		public CSMysteryBonusSpinRes m_MysteryBonusSpinData;

		// Token: 0x0400B5E7 RID: 46567
		[Token(Token = "0x400B5E7")]
		[FieldOffset(Offset = "0xB0")]
		private bool hasRequestSpin;

		// Token: 0x0400B5E8 RID: 46568
		[Token(Token = "0x400B5E8")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<uint, SubscribeStoreDesc> m_DescriptionOfSubscriptions;

		// Token: 0x0400B5E9 RID: 46569
		[Token(Token = "0x400B5E9")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<uint, AccountSubscription> m_StatusOfSubscriptions;

		// Token: 0x0400B5EA RID: 46570
		[Token(Token = "0x400B5EA")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<uint, PayItemData> m_SubscriptionBundleProductsFromCSV;

		// Token: 0x0400B5EB RID: 46571
		[Token(Token = "0x400B5EB")]
		private const string PLAYER_PREFS_KEY_HAS_SEEN_SUBSCRIPTION_HUB = "HasSeenPaymentSubscriptionHub";

		// Token: 0x0400B5EC RID: 46572
		[Token(Token = "0x400B5EC")]
		private const string HAS_SEEN_GROWTH_FUND = "HasSeenPaymentGrowthFund";

		// Token: 0x02001F91 RID: 8081
		[Token(Token = "0x2001F91")]
		public enum PaymentBundleState
		{
			// Token: 0x0400B5EE RID: 46574
			[Token(Token = "0x400B5EE")]
			NotLoaded,
			// Token: 0x0400B5EF RID: 46575
			[Token(Token = "0x400B5EF")]
			Loading,
			// Token: 0x0400B5F0 RID: 46576
			[Token(Token = "0x400B5F0")]
			Loaded,
			// Token: 0x0400B5F1 RID: 46577
			[Token(Token = "0x400B5F1")]
			Paying,
			// Token: 0x0400B5F2 RID: 46578
			[Token(Token = "0x400B5F2")]
			Exchanging
		}

		// Token: 0x02001F92 RID: 8082
		[Token(Token = "0x2001F92")]
		public enum TopupEventType
		{
			// Token: 0x0400B5F4 RID: 46580
			[Token(Token = "0x400B5F4")]
			MysteryBonus,
			// Token: 0x0400B5F5 RID: 46581
			[Token(Token = "0x400B5F5")]
			DiamondEvent
		}

		// Token: 0x02001F93 RID: 8083
		[Token(Token = "0x2001F93")]
		public enum BundlePurchaseError
		{
			// Token: 0x0400B5F7 RID: 46583
			[Token(Token = "0x400B5F7")]
			None,
			// Token: 0x0400B5F8 RID: 46584
			[Token(Token = "0x400B5F8")]
			NotLoaded,
			// Token: 0x0400B5F9 RID: 46585
			[Token(Token = "0x400B5F9")]
			Missing,
			// Token: 0x0400B5FA RID: 46586
			[Token(Token = "0x400B5FA")]
			SoldOut,
			// Token: 0x0400B5FB RID: 46587
			[Token(Token = "0x400B5FB")]
			Pending
		}

		// Token: 0x02001F94 RID: 8084
		[Token(Token = "0x2001F94")]
		private class PaymentBundlesDelegate : PayUtility.PaymentDelegate
		{
			// Token: 0x17000C26 RID: 3110
			// (get) Token: 0x0600B379 RID: 45945 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C26")]
			public static UIModelPayment.PaymentBundlesDelegate I
			{
				[Token(Token = "0x600B379")]
				[Address(RVA = "0x2388408", Offset = "0x2388408", VA = "0x7BBCB88408")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000C27 RID: 3111
			// (get) Token: 0x0600B37A RID: 45946 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C27")]
			public override string Name
			{
				[Token(Token = "0x600B37A")]
				[Address(RVA = "0x2388490", Offset = "0x2388490", VA = "0x7BBCB88490", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600B37B RID: 45947 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B37B")]
			[Address(RVA = "0x23884D8", Offset = "0x23884D8", VA = "0x7BBCB884D8", Slot = "11")]
			public override PayUtility.PaymentDelegate.ProductPurchasedReaction OnProductPurchased(string reason, PayUtility.PaymentDelegate.ProductPurchasedResult result, string productIdentifier, long rebateId)
			{
				return null;
			}

			// Token: 0x0600B37C RID: 45948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B37C")]
			[Address(RVA = "0x2388488", Offset = "0x2388488", VA = "0x7BBCB88488")]
			public PaymentBundlesDelegate()
			{
			}

			// Token: 0x0400B5FC RID: 46588
			[Token(Token = "0x400B5FC")]
			[FieldOffset(Offset = "0x0")]
			private static UIModelPayment.PaymentBundlesDelegate _I;
		}

		// Token: 0x02001F95 RID: 8085
		[Token(Token = "0x2001F95")]
		public enum VersionType
		{
			// Token: 0x0400B5FE RID: 46590
			[Token(Token = "0x400B5FE")]
			IAPProducts,
			// Token: 0x0400B5FF RID: 46591
			[Token(Token = "0x400B5FF")]
			PaymentBundles,
			// Token: 0x0400B600 RID: 46592
			[Token(Token = "0x400B600")]
			RebateCard
		}

		// Token: 0x02001F96 RID: 8086
		[Token(Token = "0x2001F96")]
		private class VersionInfo
		{
			// Token: 0x0600B37D RID: 45949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B37D")]
			[Address(RVA = "0x23888BC", Offset = "0x23888BC", VA = "0x7BBCB888BC")]
			public VersionInfo()
			{
			}

			// Token: 0x0400B601 RID: 46593
			[Token(Token = "0x400B601")]
			[FieldOffset(Offset = "0x10")]
			public string PlayerPrefsKey;

			// Token: 0x0400B602 RID: 46594
			[Token(Token = "0x400B602")]
			[FieldOffset(Offset = "0x18")]
			public Func<string> LocalOverride;

			// Token: 0x0400B603 RID: 46595
			[Token(Token = "0x400B603")]
			[FieldOffset(Offset = "0x20")]
			public Func<string> Remote;
		}

		// Token: 0x02001F97 RID: 8087
		[Token(Token = "0x2001F97")]
		public enum PaymentButtonStyle
		{
			// Token: 0x0400B605 RID: 46597
			[Token(Token = "0x400B605")]
			FirstTime = 1,
			// Token: 0x0400B606 RID: 46598
			[Token(Token = "0x400B606")]
			SecondTime,
			// Token: 0x0400B607 RID: 46599
			[Token(Token = "0x400B607")]
			LessIsMore,
			// Token: 0x0400B608 RID: 46600
			[Token(Token = "0x400B608")]
			MysteryTopupBonus,
			// Token: 0x0400B609 RID: 46601
			[Token(Token = "0x400B609")]
			Normal,
			// Token: 0x0400B60A RID: 46602
			[Token(Token = "0x400B60A")]
			Finished
		}

		// Token: 0x02001F98 RID: 8088
		[Token(Token = "0x2001F98")]
		public class PaymentButtonDisplayInfo
		{
			// Token: 0x0600B37E RID: 45950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B37E")]
			[Address(RVA = "0x23885B8", Offset = "0x23885B8", VA = "0x7BBCB885B8")]
			public PaymentButtonDisplayInfo()
			{
			}

			// Token: 0x0400B60B RID: 46603
			[Token(Token = "0x400B60B")]
			[FieldOffset(Offset = "0x10")]
			public string CdnUrl;

			// Token: 0x0400B60C RID: 46604
			[Token(Token = "0x400B60C")]
			[FieldOffset(Offset = "0x18")]
			public uint StartTime;

			// Token: 0x0400B60D RID: 46605
			[Token(Token = "0x400B60D")]
			[FieldOffset(Offset = "0x1C")]
			public uint EndTime;
		}

		// Token: 0x02001F99 RID: 8089
		[Token(Token = "0x2001F99")]
		private class DiamondProductsDelegate : PayUtility.PaymentDelegate
		{
			// Token: 0x17000C28 RID: 3112
			// (get) Token: 0x0600B37F RID: 45951 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C28")]
			public static UIModelPayment.DiamondProductsDelegate I
			{
				[Token(Token = "0x600B37F")]
				[Address(RVA = "0x2388078", Offset = "0x2388078", VA = "0x7BBCB88078")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000C29 RID: 3113
			// (get) Token: 0x0600B380 RID: 45952 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C29")]
			public override string Name
			{
				[Token(Token = "0x600B380")]
				[Address(RVA = "0x2388100", Offset = "0x2388100", VA = "0x7BBCB88100", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000C2A RID: 3114
			// (get) Token: 0x0600B381 RID: 45953 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600B382 RID: 45954 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000C2A")]
			public override string[] ProductsInDemand
			{
				[Token(Token = "0x600B381")]
				[Address(RVA = "0x2388148", Offset = "0x2388148", VA = "0x7BBCB88148", Slot = "5")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146CDC", Offset = "0x1146CDC")]
				get
				{
					return null;
				}
				[Token(Token = "0x600B382")]
				[Address(RVA = "0x2388150", Offset = "0x2388150", VA = "0x7BBCB88150", Slot = "6")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146CEC", Offset = "0x1146CEC")]
				set
				{
				}
			}

			// Token: 0x0600B383 RID: 45955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B383")]
			[Address(RVA = "0x2388158", Offset = "0x2388158", VA = "0x7BBCB88158", Slot = "9")]
			public override void OnProductsUpdated(string reason, bool result, string[] productIdentifiers)
			{
			}

			// Token: 0x0600B384 RID: 45956 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B384")]
			[Address(RVA = "0x2388270", Offset = "0x2388270", VA = "0x7BBCB88270", Slot = "11")]
			public override PayUtility.PaymentDelegate.ProductPurchasedReaction OnProductPurchased(string reason, PayUtility.PaymentDelegate.ProductPurchasedResult result, string productIdentifier, long rebateId)
			{
				return null;
			}

			// Token: 0x0600B385 RID: 45957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B385")]
			[Address(RVA = "0x23880F8", Offset = "0x23880F8", VA = "0x7BBCB880F8")]
			public DiamondProductsDelegate()
			{
			}

			// Token: 0x0400B60E RID: 46606
			[Token(Token = "0x400B60E")]
			[FieldOffset(Offset = "0x0")]
			private static UIModelPayment.DiamondProductsDelegate _I;

			// Token: 0x0400B60F RID: 46607
			[Token(Token = "0x400B60F")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113034C", Offset = "0x113034C")]
			private string[] <ProductsInDemand>k__BackingField;
		}

		// Token: 0x02001F9A RID: 8090
		[Token(Token = "0x2001F9A")]
		private class DiamondEventDelegate : PayUtility.PaymentDelegate
		{
			// Token: 0x17000C2B RID: 3115
			// (get) Token: 0x0600B386 RID: 45958 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C2B")]
			public static UIModelPayment.DiamondEventDelegate I
			{
				[Token(Token = "0x600B386")]
				[Address(RVA = "0x2387C84", Offset = "0x2387C84", VA = "0x7BBCB87C84")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000C2C RID: 3116
			// (get) Token: 0x0600B387 RID: 45959 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C2C")]
			public override string Name
			{
				[Token(Token = "0x600B387")]
				[Address(RVA = "0x2387D0C", Offset = "0x2387D0C", VA = "0x7BBCB87D0C", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600B388 RID: 45960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B388")]
			[Address(RVA = "0x2387D54", Offset = "0x2387D54", VA = "0x7BBCB87D54", Slot = "9")]
			public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
			{
			}

			// Token: 0x0600B389 RID: 45961 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B389")]
			[Address(RVA = "0x2387E6C", Offset = "0x2387E6C", VA = "0x7BBCB87E6C", Slot = "11")]
			public override PayUtility.PaymentDelegate.ProductPurchasedReaction OnProductPurchased(string reason, PayUtility.PaymentDelegate.ProductPurchasedResult result, string productIdentifier, long rebateId)
			{
				return null;
			}

			// Token: 0x0600B38A RID: 45962 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B38A")]
			[Address(RVA = "0x2387D04", Offset = "0x2387D04", VA = "0x7BBCB87D04")]
			public DiamondEventDelegate()
			{
			}

			// Token: 0x0400B610 RID: 46608
			[Token(Token = "0x400B610")]
			[FieldOffset(Offset = "0x0")]
			private static UIModelPayment.DiamondEventDelegate _I;
		}

		// Token: 0x02001F9B RID: 8091
		[Token(Token = "0x2001F9B")]
		private class SubscriptionHubDelegate : PayUtility.PaymentDelegate
		{
			// Token: 0x17000C2D RID: 3117
			// (get) Token: 0x0600B38B RID: 45963 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C2D")]
			public static UIModelPayment.SubscriptionHubDelegate I
			{
				[Token(Token = "0x600B38B")]
				[Address(RVA = "0x23885C0", Offset = "0x23885C0", VA = "0x7BBCB885C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000C2E RID: 3118
			// (get) Token: 0x0600B38C RID: 45964 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C2E")]
			public override string Name
			{
				[Token(Token = "0x600B38C")]
				[Address(RVA = "0x2388648", Offset = "0x2388648", VA = "0x7BBCB88648", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600B38D RID: 45965 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B38D")]
			[Address(RVA = "0x2388690", Offset = "0x2388690", VA = "0x7BBCB88690", Slot = "11")]
			public override PayUtility.PaymentDelegate.ProductPurchasedReaction OnProductPurchased(string reason, PayUtility.PaymentDelegate.ProductPurchasedResult result, string productIdentifier, long rebateId)
			{
				return null;
			}

			// Token: 0x0600B38E RID: 45966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B38E")]
			[Address(RVA = "0x238876C", Offset = "0x238876C", VA = "0x7BBCB8876C", Slot = "9")]
			public override void OnProductsUpdated(string reason, bool result, string[] productIdentifiers)
			{
			}

			// Token: 0x0600B38F RID: 45967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B38F")]
			[Address(RVA = "0x2388640", Offset = "0x2388640", VA = "0x7BBCB88640")]
			public SubscriptionHubDelegate()
			{
			}

			// Token: 0x0400B611 RID: 46609
			[Token(Token = "0x400B611")]
			[FieldOffset(Offset = "0x0")]
			private static UIModelPayment.SubscriptionHubDelegate _I;

			// Token: 0x0400B612 RID: 46610
			[Token(Token = "0x400B612")]
			[FieldOffset(Offset = "0x20")]
			private string LastSubscribedProductIdentifier;
		}

		// Token: 0x02001F9C RID: 8092
		[Token(Token = "0x2001F9C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD3A4", Offset = "0x10FD3A4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B391 RID: 45969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B391")]
			[Address(RVA = "0x24322D8", Offset = "0x24322D8", VA = "0x7BBCC322D8")]
			public <>c()
			{
			}

			// Token: 0x0600B392 RID: 45970 RVA: 0x00032DF0 File Offset: 0x00030FF0
			[Token(Token = "0x600B392")]
			[Address(RVA = "0x24322E0", Offset = "0x24322E0", VA = "0x7BBCC322E0")]
			internal bool <OnUpdatedPaymentBundles>b__75_0(PayBundleWindowDesc bundle)
			{
				return default(bool);
			}

			// Token: 0x0600B393 RID: 45971 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B393")]
			[Address(RVA = "0x2432314", Offset = "0x2432314", VA = "0x7BBCC32314")]
			internal string <OnUpdatedPaymentBundles>b__75_1(PayBundleWindowDesc bundle)
			{
				return null;
			}

			// Token: 0x0600B394 RID: 45972 RVA: 0x00032E08 File Offset: 0x00031008
			[Token(Token = "0x600B394")]
			[Address(RVA = "0x243238C", Offset = "0x243238C", VA = "0x7BBCC3238C")]
			internal bool <OnUpdatedPaymentBundles>b__75_2(PayBundleWindowDesc bundle)
			{
				return default(bool);
			}

			// Token: 0x0600B395 RID: 45973 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B395")]
			[Address(RVA = "0x24323C0", Offset = "0x24323C0", VA = "0x7BBCC323C0")]
			internal string <OnUpdatedPaymentBundles>b__75_3(PayBundleWindowDesc bundle)
			{
				return null;
			}

			// Token: 0x0600B396 RID: 45974 RVA: 0x00032E20 File Offset: 0x00031020
			[Token(Token = "0x600B396")]
			[Address(RVA = "0x2432438", Offset = "0x2432438", VA = "0x7BBCC32438")]
			internal int <ProcessSpecialStoreDesc>b__80_0(SpecialStoreDesc a, SpecialStoreDesc b)
			{
				return 0;
			}

			// Token: 0x0600B397 RID: 45975 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B397")]
			[Address(RVA = "0x2432480", Offset = "0x2432480", VA = "0x7BBCC32480")]
			internal BaseItemInfo <OnPaymentBundleReceived>b__96_0(AwardDesc reward)
			{
				return null;
			}

			// Token: 0x0600B398 RID: 45976 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B398")]
			[Address(RVA = "0x24324E8", Offset = "0x24324E8", VA = "0x7BBCC324E8")]
			internal CommonRewardItemInfo <OnPaymentBundleReceived>b__96_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600B399 RID: 45977 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B399")]
			[Address(RVA = "0x24324F4", Offset = "0x24324F4", VA = "0x7BBCC324F4")]
			internal PayItemData <LoadDiamondProductsFromCSV>b__109_0(CSVBaseData csvData)
			{
				return null;
			}

			// Token: 0x0600B39A RID: 45978 RVA: 0x00032E38 File Offset: 0x00031038
			[Token(Token = "0x600B39A")]
			[Address(RVA = "0x2432784", Offset = "0x2432784", VA = "0x7BBCC32784")]
			internal bool <LoadDiamondProductsFromCSV>b__109_1(PayItemData p)
			{
				return default(bool);
			}

			// Token: 0x0600B39B RID: 45979 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B39B")]
			[Address(RVA = "0x2432790", Offset = "0x2432790", VA = "0x7BBCC32790")]
			internal string <LoadDiamondProductsFromCSV>b__109_2(PayItemData product)
			{
				return null;
			}

			// Token: 0x0600B39C RID: 45980 RVA: 0x00032E50 File Offset: 0x00031050
			[Token(Token = "0x600B39C")]
			[Address(RVA = "0x24327BC", Offset = "0x24327BC", VA = "0x7BBCC327BC")]
			internal int <GetDiamondEventTier>b__119_0(DiamondSpendEventDesc a, DiamondSpendEventDesc b)
			{
				return 0;
			}

			// Token: 0x0600B39D RID: 45981 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B39D")]
			[Address(RVA = "0x2432804", Offset = "0x2432804", VA = "0x7BBCC32804")]
			internal string <RequestTopupEvent>b__120_1(DiamondSpendEventDesc desc)
			{
				return null;
			}

			// Token: 0x0600B39E RID: 45982 RVA: 0x00032E68 File Offset: 0x00031068
			[Token(Token = "0x600B39E")]
			[Address(RVA = "0x243287C", Offset = "0x243287C", VA = "0x7BBCC3287C")]
			internal int <Subscriptions>b__144_0(SubscribeStoreDesc a, SubscribeStoreDesc b)
			{
				return 0;
			}

			// Token: 0x0600B39F RID: 45983 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B39F")]
			[Address(RVA = "0x24328C0", Offset = "0x24328C0", VA = "0x7BBCC328C0")]
			internal string <FetchSubscriptionBundles>b__149_1(SubscribeStoreDesc desc)
			{
				return null;
			}

			// Token: 0x0600B3A0 RID: 45984 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3A0")]
			[Address(RVA = "0x2432938", Offset = "0x2432938", VA = "0x7BBCC32938")]
			internal void <ClaimSubscriptionBundle>b__174_0(PayUtility.SubscriptionGracePeriodReminderInfo info)
			{
			}

			// Token: 0x0600B3A1 RID: 45985 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B3A1")]
			[Address(RVA = "0x24329C8", Offset = "0x24329C8", VA = "0x7BBCC329C8")]
			internal string <.cctor>b__195_0()
			{
				return null;
			}

			// Token: 0x0600B3A2 RID: 45986 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B3A2")]
			[Address(RVA = "0x2432A28", Offset = "0x2432A28", VA = "0x7BBCC32A28")]
			internal string <.cctor>b__195_1()
			{
				return null;
			}

			// Token: 0x0600B3A3 RID: 45987 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B3A3")]
			[Address(RVA = "0x2432A90", Offset = "0x2432A90", VA = "0x7BBCC32A90")]
			internal string <.cctor>b__195_2()
			{
				return null;
			}

			// Token: 0x0600B3A4 RID: 45988 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B3A4")]
			[Address(RVA = "0x2432AF0", Offset = "0x2432AF0", VA = "0x7BBCC32AF0")]
			internal string <.cctor>b__195_3()
			{
				return null;
			}

			// Token: 0x0600B3A5 RID: 45989 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B3A5")]
			[Address(RVA = "0x2432B58", Offset = "0x2432B58", VA = "0x7BBCC32B58")]
			internal string <.cctor>b__195_4()
			{
				return null;
			}

			// Token: 0x0600B3A6 RID: 45990 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B3A6")]
			[Address(RVA = "0x2432BB8", Offset = "0x2432BB8", VA = "0x7BBCC32BB8")]
			internal string <.cctor>b__195_5()
			{
				return null;
			}

			// Token: 0x0400B613 RID: 46611
			[Token(Token = "0x400B613")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelPayment.<>c <>9;

			// Token: 0x0400B614 RID: 46612
			[Token(Token = "0x400B614")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<PayBundleWindowDesc> <>9__75_0;

			// Token: 0x0400B615 RID: 46613
			[Token(Token = "0x400B615")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<PayBundleWindowDesc, string> <>9__75_1;

			// Token: 0x0400B616 RID: 46614
			[Token(Token = "0x400B616")]
			[FieldOffset(Offset = "0x18")]
			public static Predicate<PayBundleWindowDesc> <>9__75_2;

			// Token: 0x0400B617 RID: 46615
			[Token(Token = "0x400B617")]
			[FieldOffset(Offset = "0x20")]
			public static Converter<PayBundleWindowDesc, string> <>9__75_3;

			// Token: 0x0400B618 RID: 46616
			[Token(Token = "0x400B618")]
			[FieldOffset(Offset = "0x28")]
			public static Comparison<SpecialStoreDesc> <>9__80_0;

			// Token: 0x0400B619 RID: 46617
			[Token(Token = "0x400B619")]
			[FieldOffset(Offset = "0x30")]
			public static Converter<AwardDesc, BaseItemInfo> <>9__96_0;

			// Token: 0x0400B61A RID: 46618
			[Token(Token = "0x400B61A")]
			[FieldOffset(Offset = "0x38")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__96_1;

			// Token: 0x0400B61B RID: 46619
			[Token(Token = "0x400B61B")]
			[FieldOffset(Offset = "0x40")]
			public static Converter<CSVBaseData, PayItemData> <>9__109_0;

			// Token: 0x0400B61C RID: 46620
			[Token(Token = "0x400B61C")]
			[FieldOffset(Offset = "0x48")]
			public static Func<PayItemData, bool> <>9__109_1;

			// Token: 0x0400B61D RID: 46621
			[Token(Token = "0x400B61D")]
			[FieldOffset(Offset = "0x50")]
			public static Converter<PayItemData, string> <>9__109_2;

			// Token: 0x0400B61E RID: 46622
			[Token(Token = "0x400B61E")]
			[FieldOffset(Offset = "0x58")]
			public static Comparison<DiamondSpendEventDesc> <>9__119_0;

			// Token: 0x0400B61F RID: 46623
			[Token(Token = "0x400B61F")]
			[FieldOffset(Offset = "0x60")]
			public static Converter<DiamondSpendEventDesc, string> <>9__120_1;

			// Token: 0x0400B620 RID: 46624
			[Token(Token = "0x400B620")]
			[FieldOffset(Offset = "0x68")]
			public static Comparison<SubscribeStoreDesc> <>9__144_0;

			// Token: 0x0400B621 RID: 46625
			[Token(Token = "0x400B621")]
			[FieldOffset(Offset = "0x70")]
			public static Converter<SubscribeStoreDesc, string> <>9__149_1;

			// Token: 0x0400B622 RID: 46626
			[Token(Token = "0x400B622")]
			[FieldOffset(Offset = "0x78")]
			public static Action<PayUtility.SubscriptionGracePeriodReminderInfo> <>9__174_0;
		}

		// Token: 0x02001F9D RID: 8093
		[Token(Token = "0x2001F9D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD3B4", Offset = "0x10FD3B4")]
		private sealed class <>c__DisplayClass81_0
		{
			// Token: 0x0600B3A7 RID: 45991 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3A7")]
			[Address(RVA = "0x242AA90", Offset = "0x242AA90", VA = "0x7BBCC2AA90")]
			public <>c__DisplayClass81_0()
			{
			}

			// Token: 0x0600B3A8 RID: 45992 RVA: 0x00032E80 File Offset: 0x00031080
			[Token(Token = "0x600B3A8")]
			[Address(RVA = "0x2433BD0", Offset = "0x2433BD0", VA = "0x7BBCC33BD0")]
			internal bool <HasPaymentSpecialStore>b__0(PayBundleWindowDesc x)
			{
				return default(bool);
			}

			// Token: 0x0400B623 RID: 46627
			[Token(Token = "0x400B623")]
			[FieldOffset(Offset = "0x10")]
			public EStore.PbwActivityType type;
		}

		// Token: 0x02001F9E RID: 8094
		[Token(Token = "0x2001F9E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD3C4", Offset = "0x10FD3C4")]
		private sealed class <>c__DisplayClass93_0
		{
			// Token: 0x0600B3A9 RID: 45993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3A9")]
			[Address(RVA = "0x242B5A8", Offset = "0x242B5A8", VA = "0x7BBCC2B5A8")]
			public <>c__DisplayClass93_0()
			{
			}

			// Token: 0x0600B3AA RID: 45994 RVA: 0x00032E98 File Offset: 0x00031098
			[Token(Token = "0x600B3AA")]
			[Address(RVA = "0x2433CE8", Offset = "0x2433CE8", VA = "0x7BBCC33CE8")]
			internal bool <CheckFreeBundles>b__0(PayBundleWindowDesc x)
			{
				return default(bool);
			}

			// Token: 0x0400B624 RID: 46628
			[Token(Token = "0x400B624")]
			[FieldOffset(Offset = "0x10")]
			public SpecialStoreDesc store;
		}

		// Token: 0x02001F9F RID: 8095
		[Token(Token = "0x2001F9F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD3D4", Offset = "0x10FD3D4")]
		private sealed class <>c__DisplayClass120_0
		{
			// Token: 0x0600B3AB RID: 45995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3AB")]
			[Address(RVA = "0x242D2CC", Offset = "0x242D2CC", VA = "0x7BBCC2D2CC")]
			public <>c__DisplayClass120_0()
			{
			}

			// Token: 0x0600B3AC RID: 45996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3AC")]
			[Address(RVA = "0x2432C20", Offset = "0x2432C20", VA = "0x7BBCC32C20")]
			internal void <RequestTopupEvent>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B625 RID: 46629
			[Token(Token = "0x400B625")]
			[FieldOffset(Offset = "0x10")]
			public CSTopupEventInfoReq req;

			// Token: 0x0400B626 RID: 46630
			[Token(Token = "0x400B626")]
			[FieldOffset(Offset = "0x18")]
			public UIModelPayment <>4__this;

			// Token: 0x0400B627 RID: 46631
			[Token(Token = "0x400B627")]
			[FieldOffset(Offset = "0x20")]
			public uint propID;
		}

		// Token: 0x02001FA0 RID: 8096
		[Token(Token = "0x2001FA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD3E4", Offset = "0x10FD3E4")]
		private sealed class <>c__DisplayClass149_0
		{
			// Token: 0x0600B3AD RID: 45997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3AD")]
			[Address(RVA = "0x242E054", Offset = "0x242E054", VA = "0x7BBCC2E054")]
			public <>c__DisplayClass149_0()
			{
			}

			// Token: 0x0600B3AE RID: 45998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3AE")]
			[Address(RVA = "0x24330BC", Offset = "0x24330BC", VA = "0x7BBCC330BC")]
			internal void <FetchSubscriptionBundles>b__0(HttpErrorCode error, object resObj)
			{
			}

			// Token: 0x0400B628 RID: 46632
			[Token(Token = "0x400B628")]
			[FieldOffset(Offset = "0x10")]
			public UIModelPayment <>4__this;

			// Token: 0x0400B629 RID: 46633
			[Token(Token = "0x400B629")]
			[FieldOffset(Offset = "0x18")]
			public uint http;
		}

		// Token: 0x02001FA1 RID: 8097
		[Token(Token = "0x2001FA1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD3F4", Offset = "0x10FD3F4")]
		private sealed class <>c__DisplayClass174_0
		{
			// Token: 0x0600B3AF RID: 45999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3AF")]
			[Address(RVA = "0x242F454", Offset = "0x242F454", VA = "0x7BBCC2F454")]
			public <>c__DisplayClass174_0()
			{
			}

			// Token: 0x0600B3B0 RID: 46000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3B0")]
			[Address(RVA = "0x243365C", Offset = "0x243365C", VA = "0x7BBCC3365C")]
			internal void <ClaimSubscriptionBundle>b__1(PayUtility.SubscriptionGracePeriodReminderInfo info)
			{
			}

			// Token: 0x0400B62A RID: 46634
			[Token(Token = "0x400B62A")]
			[FieldOffset(Offset = "0x10")]
			public UIModelPayment <>4__this;

			// Token: 0x0400B62B RID: 46635
			[Token(Token = "0x400B62B")]
			[FieldOffset(Offset = "0x18")]
			public uint store_id;
		}

		// Token: 0x02001FA2 RID: 8098
		[Token(Token = "0x2001FA2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD404", Offset = "0x10FD404")]
		private sealed class <>c__DisplayClass175_0
		{
			// Token: 0x0600B3B1 RID: 46001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3B1")]
			[Address(RVA = "0x242F670", Offset = "0x242F670", VA = "0x7BBCC2F670")]
			public <>c__DisplayClass175_0()
			{
			}

			// Token: 0x0600B3B2 RID: 46002 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3B2")]
			[Address(RVA = "0x2433690", Offset = "0x2433690", VA = "0x7BBCC33690")]
			internal void <_ClaimSubscriptionBundle>b__0(HttpErrorCode error, object resObj)
			{
			}

			// Token: 0x0400B62C RID: 46636
			[Token(Token = "0x400B62C")]
			[FieldOffset(Offset = "0x10")]
			public UIModelPayment <>4__this;

			// Token: 0x0400B62D RID: 46637
			[Token(Token = "0x400B62D")]
			[FieldOffset(Offset = "0x18")]
			public uint store_id;
		}

		// Token: 0x02001FA3 RID: 8099
		[Token(Token = "0x2001FA3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD414", Offset = "0x10FD414")]
		private sealed class <>c__DisplayClass183_0
		{
			// Token: 0x0600B3B3 RID: 46003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3B3")]
			[Address(RVA = "0x2430A80", Offset = "0x2430A80", VA = "0x7BBCC30A80")]
			public <>c__DisplayClass183_0()
			{
			}

			// Token: 0x0600B3B4 RID: 46004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3B4")]
			[Address(RVA = "0x2433898", Offset = "0x2433898", VA = "0x7BBCC33898")]
			internal void <ClaimPayLevelReward>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B62E RID: 46638
			[Token(Token = "0x400B62E")]
			[FieldOffset(Offset = "0x10")]
			public UIModelPayment <>4__this;

			// Token: 0x0400B62F RID: 46639
			[Token(Token = "0x400B62F")]
			[FieldOffset(Offset = "0x18")]
			public uint id;

			// Token: 0x0400B630 RID: 46640
			[Token(Token = "0x400B630")]
			[FieldOffset(Offset = "0x1C")]
			public uint level;
		}

		// Token: 0x02001FA4 RID: 8100
		[Token(Token = "0x2001FA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD424", Offset = "0x10FD424")]
		private sealed class <>c__DisplayClass192_0
		{
			// Token: 0x0600B3B5 RID: 46005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B3B5")]
			[Address(RVA = "0x2431700", Offset = "0x2431700", VA = "0x7BBCC31700")]
			public <>c__DisplayClass192_0()
			{
			}

			// Token: 0x0600B3B6 RID: 46006 RVA: 0x00032EB0 File Offset: 0x000310B0
			[Token(Token = "0x600B3B6")]
			[Address(RVA = "0x2433B54", Offset = "0x2433B54", VA = "0x7BBCC33B54")]
			internal bool <ExistUnawardedPayLevelReward>b__0(PlayLevelInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B631 RID: 46641
			[Token(Token = "0x400B631")]
			[FieldOffset(Offset = "0x10")]
			public PayLevelRewardDesc item;
		}
	}
}
