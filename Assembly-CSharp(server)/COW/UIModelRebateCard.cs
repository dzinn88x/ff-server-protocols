using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001FD2 RID: 8146
	[Token(Token = "0x2001FD2")]
	public class UIModelRebateCard : UIBaseModel
	{
		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x0600B4A9 RID: 46249 RVA: 0x000334B0 File Offset: 0x000316B0
		[Token(Token = "0x17000C38")]
		public bool RebateCardEnabled
		{
			[Token(Token = "0x600B4A9")]
			[Address(RVA = "0x2397430", Offset = "0x2397430", VA = "0x7BBCB97430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B4AA RID: 46250 RVA: 0x000334C8 File Offset: 0x000316C8
		[Token(Token = "0x600B4AA")]
		[Address(RVA = "0x23974EC", Offset = "0x23974EC", VA = "0x7BBCB974EC")]
		public static SubscriptionPeriod Convert(RebateCardType rct)
		{
			return SubscriptionPeriod.None;
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x0600B4AB RID: 46251 RVA: 0x000334E0 File Offset: 0x000316E0
		[Token(Token = "0x17000C39")]
		public bool RebateCardSubscriptionEnabled
		{
			[Token(Token = "0x600B4AB")]
			[Address(RVA = "0x2397508", Offset = "0x2397508", VA = "0x7BBCB97508")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B4AC RID: 46252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4AC")]
		[Address(RVA = "0x239770C", Offset = "0x239770C", VA = "0x7BBCB9770C")]
		public RebateCardInfo RebateCard(RebateCardType rebateCardType)
		{
			return null;
		}

		// Token: 0x0600B4AD RID: 46253 RVA: 0x000334F8 File Offset: 0x000316F8
		[Token(Token = "0x600B4AD")]
		[Address(RVA = "0x2397738", Offset = "0x2397738", VA = "0x7BBCB97738")]
		public bool SupportSubscription(RebateCardType rebateCardType)
		{
			return default(bool);
		}

		// Token: 0x0600B4AE RID: 46254 RVA: 0x00033510 File Offset: 0x00031710
		[Token(Token = "0x600B4AE")]
		[Address(RVA = "0x2397870", Offset = "0x2397870", VA = "0x7BBCB97870")]
		public bool SubscriptionBonusAvailable(RebateCardType rebateCardType)
		{
			return default(bool);
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4AF")]
		[Address(RVA = "0x2397B44", Offset = "0x2397B44", VA = "0x7BBCB97B44")]
		private Action<HttpErrorCode, object> OnGetSubscriptionBonusStatus(RebateCardType rebateCardType)
		{
			return null;
		}

		// Token: 0x0600B4B0 RID: 46256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4B0")]
		[Address(RVA = "0x2397BFC", Offset = "0x2397BFC", VA = "0x7BBCB97BFC")]
		private void OnGetSubscriptionBonusStatus_Week(HttpErrorCode errorCode, object response)
		{
		}

		// Token: 0x0600B4B1 RID: 46257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4B1")]
		[Address(RVA = "0x2397F7C", Offset = "0x2397F7C", VA = "0x7BBCB97F7C")]
		private void OnGetSubscriptionBonusStatus_Month(HttpErrorCode errorCode, object response)
		{
		}

		// Token: 0x0600B4B2 RID: 46258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4B2")]
		[Address(RVA = "0x2397C14", Offset = "0x2397C14", VA = "0x7BBCB97C14")]
		private void OnGetSubscriptionBonusStatus(RebateCardType rebateCardType, HttpErrorCode errorCode, object response)
		{
		}

		// Token: 0x0600B4B3 RID: 46259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4B3")]
		[Address(RVA = "0x2398034", Offset = "0x2398034", VA = "0x7BBCB98034")]
		public string SubscriptionProductIdentifier(RebateCardType rebateCardType)
		{
			return null;
		}

		// Token: 0x0600B4B4 RID: 46260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4B4")]
		[Address(RVA = "0x23981AC", Offset = "0x23981AC", VA = "0x7BBCB981AC")]
		public PayItemData SubscriptionProduct(RebateCardType rebateCardType)
		{
			return null;
		}

		// Token: 0x0600B4B5 RID: 46261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4B5")]
		[Address(RVA = "0x2398234", Offset = "0x2398234", VA = "0x7BBCB98234")]
		public void SetExtraRewardActivitiesRead()
		{
		}

		// Token: 0x0600B4B6 RID: 46262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4B6")]
		[Address(RVA = "0x2398340", Offset = "0x2398340", VA = "0x7BBCB98340")]
		public ActivityGroupDesc GetExtraRewardActivityGroupDesc(RebateCardType type)
		{
			return null;
		}

		// Token: 0x0600B4B7 RID: 46263 RVA: 0x00033528 File Offset: 0x00031728
		[Token(Token = "0x600B4B7")]
		[Address(RVA = "0x2398788", Offset = "0x2398788", VA = "0x7BBCB98788")]
		public UIModelRebateCard.ExtraRewardStatus GetExtraRewardStatus(ActivityGroupDesc desc)
		{
			return UIModelRebateCard.ExtraRewardStatus.None;
		}

		// Token: 0x0600B4B8 RID: 46264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4B8")]
		[Address(RVA = "0x23989A8", Offset = "0x23989A8", VA = "0x7BBCB989A8")]
		public BaseItemInfo GetExtraReward(ActivityGroupDesc desc)
		{
			return null;
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600B4B9 RID: 46265 RVA: 0x00033540 File Offset: 0x00031740
		[Token(Token = "0x17000C3A")]
		public ERebateModelState CurrentModelState
		{
			[Token(Token = "0x600B4B9")]
			[Address(RVA = "0x2398BD4", Offset = "0x2398BD4", VA = "0x7BBCB98BD4")]
			get
			{
				return ERebateModelState.eNone;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x0600B4BA RID: 46266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C3B")]
		public RebateCardInfo MonthCardData
		{
			[Token(Token = "0x600B4BA")]
			[Address(RVA = "0x2398BDC", Offset = "0x2398BDC", VA = "0x7BBCB98BDC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x0600B4BB RID: 46267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C3C")]
		public RebateCardInfo WeekCardData
		{
			[Token(Token = "0x600B4BB")]
			[Address(RVA = "0x2398BE4", Offset = "0x2398BE4", VA = "0x7BBCB98BE4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B4BC RID: 46268 RVA: 0x00033558 File Offset: 0x00031758
		[Token(Token = "0x600B4BC")]
		[Address(RVA = "0x2398BEC", Offset = "0x2398BEC", VA = "0x7BBCB98BEC", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B4BD RID: 46269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4BD")]
		[Address(RVA = "0x2398BF4", Offset = "0x2398BF4", VA = "0x7BBCB98BF4", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B4BE RID: 46270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4BE")]
		[Address(RVA = "0x2399018", Offset = "0x2399018", VA = "0x7BBCB99018", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600B4BF RID: 46271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4BF")]
		[Address(RVA = "0x23994CC", Offset = "0x23994CC", VA = "0x7BBCB994CC", Slot = "7")]
		public override void LoginOffline()
		{
		}

		// Token: 0x0600B4C0 RID: 46272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4C0")]
		[Address(RVA = "0x2397F94", Offset = "0x2397F94", VA = "0x7BBCB97F94")]
		public void LogVerbose(string log)
		{
		}

		// Token: 0x0600B4C1 RID: 46273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4C1")]
		[Address(RVA = "0x23994F4", Offset = "0x23994F4", VA = "0x7BBCB994F4")]
		private void UpdateRebateCardPriceStatus()
		{
		}

		// Token: 0x0600B4C2 RID: 46274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4C2")]
		[Address(RVA = "0x2399520", Offset = "0x2399520", VA = "0x7BBCB99520")]
		private void _UpdateRebateCardLocalizedPriceStatus(RebateCardInfo rebateCardInfo)
		{
		}

		// Token: 0x0600B4C3 RID: 46275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4C3")]
		[Address(RVA = "0x239968C", Offset = "0x239968C", VA = "0x7BBCB9968C")]
		private void UpdateRebateCardSubscriptionStatus()
		{
		}

		// Token: 0x0600B4C4 RID: 46276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4C4")]
		[Address(RVA = "0x23996B8", Offset = "0x23996B8", VA = "0x7BBCB996B8")]
		private void _UpdateRebateCardSubscriptionPriceStatus(RebateCardType rebateCardType)
		{
		}

		// Token: 0x0600B4C5 RID: 46277 RVA: 0x00033570 File Offset: 0x00031770
		[Token(Token = "0x600B4C5")]
		[Address(RVA = "0x23995BC", Offset = "0x23995BC", VA = "0x7BBCB995BC")]
		private RebateCardInfo.ELocalizedPriceStatus GetLocalizedPriceStatus(string productIdentifier)
		{
			return RebateCardInfo.ELocalizedPriceStatus.Unloaded;
		}

		// Token: 0x0600B4C6 RID: 46278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4C6")]
		[Address(RVA = "0x2399390", Offset = "0x2399390", VA = "0x7BBCB99390")]
		public void UpdateRebateCardTips()
		{
		}

		// Token: 0x0600B4C7 RID: 46279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4C7")]
		[Address(RVA = "0x2398548", Offset = "0x2398548", VA = "0x7BBCB98548")]
		private void UpdateExtraRewardTips()
		{
		}

		// Token: 0x0600B4C8 RID: 46280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4C8")]
		[Address(RVA = "0x2399750", Offset = "0x2399750", VA = "0x7BBCB99750")]
		public void UpdateRebateCardActivity()
		{
		}

		// Token: 0x0600B4C9 RID: 46281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4C9")]
		[Address(RVA = "0x2399784", Offset = "0x2399784", VA = "0x7BBCB99784")]
		private void TryClaimExtraReward(RebateCardType rebateCardType)
		{
		}

		// Token: 0x0600B4CA RID: 46282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4CA")]
		[Address(RVA = "0x2398C8C", Offset = "0x2398C8C", VA = "0x7BBCB98C8C")]
		public void ChangeModelState(ERebateModelState nextState, params object[] data)
		{
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x0600B4CB RID: 46283 RVA: 0x00033588 File Offset: 0x00031788
		// (set) Token: 0x0600B4CC RID: 46284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C3D")]
		public bool ShouldNotify
		{
			[Token(Token = "0x600B4CB")]
			[Address(RVA = "0x239A17C", Offset = "0x239A17C", VA = "0x7BBCB9A17C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B4CC")]
			[Address(RVA = "0x239A1E0", Offset = "0x239A1E0", VA = "0x7BBCB9A1E0")]
			set
			{
			}
		}

		// Token: 0x0600B4CD RID: 46285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4CD")]
		[Address(RVA = "0x2399AB4", Offset = "0x2399AB4", VA = "0x7BBCB99AB4")]
		private void UpdateRebateCardLocalNotification()
		{
		}

		// Token: 0x0600B4CE RID: 46286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4CE")]
		[Address(RVA = "0x239A288", Offset = "0x239A288", VA = "0x7BBCB9A288")]
		public void ReloadRebateCardsData()
		{
		}

		// Token: 0x0600B4CF RID: 46287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4CF")]
		[Address(RVA = "0x239A564", Offset = "0x239A564", VA = "0x7BBCB9A564")]
		private void OnRebateCardProductsUpdated()
		{
		}

		// Token: 0x0600B4D0 RID: 46288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4D0")]
		[Address(RVA = "0x239A5E0", Offset = "0x239A5E0", VA = "0x7BBCB9A5E0")]
		private void OnRebateCardSubscriptionProductsUpdated()
		{
		}

		// Token: 0x0600B4D1 RID: 46289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4D1")]
		[Address(RVA = "0x239A65C", Offset = "0x239A65C", VA = "0x7BBCB9A65C")]
		public void PurchaseRebateCard(RebateCardData rebateCardData, bool subscribe)
		{
		}

		// Token: 0x0600B4D2 RID: 46290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4D2")]
		[Address(RVA = "0x239AB00", Offset = "0x239AB00", VA = "0x7BBCB9AB00")]
		private void OnPurchased(string productIdentifier, int rebateId)
		{
		}

		// Token: 0x0600B4D3 RID: 46291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4D3")]
		[Address(RVA = "0x239B0B4", Offset = "0x239B0B4", VA = "0x7BBCB9B0B4")]
		public void ShowSubscriptionTips(RebateCardType rebateCardType, Vector3 position)
		{
		}

		// Token: 0x0600B4D4 RID: 46292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4D4")]
		[Address(RVA = "0x239B26C", Offset = "0x239B26C", VA = "0x7BBCB9B26C")]
		private void OnSubscribed(string productIdentifier)
		{
		}

		// Token: 0x0600B4D5 RID: 46293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4D5")]
		[Address(RVA = "0x239B70C", Offset = "0x239B70C", VA = "0x7BBCB9B70C")]
		public void RequestGetRedeem(int rebateId)
		{
		}

		// Token: 0x0600B4D6 RID: 46294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4D6")]
		[Address(RVA = "0x239B774", Offset = "0x239B774", VA = "0x7BBCB9B774")]
		public void OnRebateOptionRedeemed(PayUtility.RebateOptionRedeemResult result)
		{
		}

		// Token: 0x0600B4D7 RID: 46295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4D7")]
		[Address(RVA = "0x239B8F4", Offset = "0x239B8F4", VA = "0x7BBCB9B8F4")]
		public UIModelRebateCard()
		{
		}

		// Token: 0x0600B4D8 RID: 46296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4D8")]
		[Address(RVA = "0x239BA60", Offset = "0x239BA60", VA = "0x7BBCB9BA60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146E0C", Offset = "0x1146E0C")]
		private void <OnSubscribed>b__65_0(string product_identifier)
		{
		}

		// Token: 0x0400B72A RID: 46890
		[Token(Token = "0x400B72A")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<RebateCardType, EEventType> m_RebateCardActivityType;

		// Token: 0x0400B72B RID: 46891
		[Token(Token = "0x400B72B")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<RebateCardType, bool?> m_SubscriptionBonusAvailable;

		// Token: 0x0400B72C RID: 46892
		[Token(Token = "0x400B72C")]
		[FieldOffset(Offset = "0x28")]
		private ERebateModelState m_CurrentModelState;

		// Token: 0x0400B72D RID: 46893
		[Token(Token = "0x400B72D")]
		[FieldOffset(Offset = "0x30")]
		private RebateCardInfo m_MonthCardData;

		// Token: 0x0400B72E RID: 46894
		[Token(Token = "0x400B72E")]
		[FieldOffset(Offset = "0x38")]
		private RebateCardInfo m_WeekCardData;

		// Token: 0x0400B72F RID: 46895
		[Token(Token = "0x400B72F")]
		[FieldOffset(Offset = "0x40")]
		private ulong m_NextResetTimeSpan;

		// Token: 0x0400B730 RID: 46896
		[Token(Token = "0x400B730")]
		public const uint PropID_RebateCardDataUpdate = 2U;

		// Token: 0x0400B731 RID: 46897
		[Token(Token = "0x400B731")]
		public const uint PropID_PurchaseSuccess = 4U;

		// Token: 0x0400B732 RID: 46898
		[Token(Token = "0x400B732")]
		public const uint PropID_RedeemSuccess = 8U;

		// Token: 0x0400B733 RID: 46899
		[Token(Token = "0x400B733")]
		public const uint PropID_RebateCardPriceUpdate = 16U;

		// Token: 0x0400B734 RID: 46900
		[Token(Token = "0x400B734")]
		public const uint PropID_ShouldNotifyChange = 32U;

		// Token: 0x0400B735 RID: 46901
		[Token(Token = "0x400B735")]
		public const uint PropID_RebateCardSubscriptionUpdate = 128U;

		// Token: 0x0400B736 RID: 46902
		[Token(Token = "0x400B736")]
		public const uint PropID_RebateCardSubscriptionBonusUpdate = 256U;

		// Token: 0x0400B737 RID: 46903
		[Token(Token = "0x400B737")]
		public const uint PropID_RebateCardSubscriptionDone = 512U;

		// Token: 0x0400B738 RID: 46904
		[Token(Token = "0x400B738")]
		private const long REDEEM_RESET_TIME_OF_DAY_UTC_MS = 68400000L;

		// Token: 0x02001FD3 RID: 8147
		[Token(Token = "0x2001FD3")]
		public enum ExtraRewardStatus
		{
			// Token: 0x0400B73A RID: 46906
			[Token(Token = "0x400B73A")]
			None,
			// Token: 0x0400B73B RID: 46907
			[Token(Token = "0x400B73B")]
			Unclaimable,
			// Token: 0x0400B73C RID: 46908
			[Token(Token = "0x400B73C")]
			Claimable,
			// Token: 0x0400B73D RID: 46909
			[Token(Token = "0x400B73D")]
			Claimed
		}

		// Token: 0x02001FD4 RID: 8148
		[Token(Token = "0x2001FD4")]
		private class RebateCardsDelegate : PayUtility.PaymentDelegate
		{
			// Token: 0x17000C3E RID: 3134
			// (get) Token: 0x0600B4D9 RID: 46297 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C3E")]
			public static UIModelRebateCard.RebateCardsDelegate I
			{
				[Token(Token = "0x600B4D9")]
				[Address(RVA = "0x2399310", Offset = "0x2399310", VA = "0x7BBCB99310")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000C3F RID: 3135
			// (get) Token: 0x0600B4DA RID: 46298 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C3F")]
			public override string Name
			{
				[Token(Token = "0x600B4DA")]
				[Address(RVA = "0x239BB34", Offset = "0x239BB34", VA = "0x7BBCB9BB34", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600B4DB RID: 46299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B4DB")]
			[Address(RVA = "0x239BB7C", Offset = "0x239BB7C", VA = "0x7BBCB9BB7C", Slot = "9")]
			public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
			{
			}

			// Token: 0x0600B4DC RID: 46300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B4DC")]
			[Address(RVA = "0x239BCB8", Offset = "0x239BCB8", VA = "0x7BBCB9BCB8", Slot = "10")]
			public override void OnRebateOptionsUpdated(string task, bool result, long[] rebateIds)
			{
			}

			// Token: 0x0600B4DD RID: 46301 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B4DD")]
			[Address(RVA = "0x239BD7C", Offset = "0x239BD7C", VA = "0x7BBCB9BD7C", Slot = "11")]
			public override PayUtility.PaymentDelegate.ProductPurchasedReaction OnProductPurchased(string reason, PayUtility.PaymentDelegate.ProductPurchasedResult result, string productIdentifier, long rebateId)
			{
				return null;
			}

			// Token: 0x0600B4DE RID: 46302 RVA: 0x000335A0 File Offset: 0x000317A0
			[Token(Token = "0x600B4DE")]
			[Address(RVA = "0x239BFD4", Offset = "0x239BFD4", VA = "0x7BBCB9BFD4", Slot = "12")]
			public override bool OnRebateOptionRedeemed(string reason, bool result, PayUtility.RebateOptionRedeemResult update)
			{
				return default(bool);
			}

			// Token: 0x0600B4DF RID: 46303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B4DF")]
			[Address(RVA = "0x239BB2C", Offset = "0x239BB2C", VA = "0x7BBCB9BB2C")]
			public RebateCardsDelegate()
			{
			}

			// Token: 0x0400B73E RID: 46910
			[Token(Token = "0x400B73E")]
			[FieldOffset(Offset = "0x0")]
			private static UIModelRebateCard.RebateCardsDelegate _I;

			// Token: 0x0400B73F RID: 46911
			[Token(Token = "0x400B73F")]
			[FieldOffset(Offset = "0x20")]
			private string LastSubscribedProductIdentifier;
		}
	}
}
