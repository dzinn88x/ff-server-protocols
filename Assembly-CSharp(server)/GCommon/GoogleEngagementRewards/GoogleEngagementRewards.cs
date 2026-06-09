using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.GoogleEngagementRewards
{
	// Token: 0x0200104D RID: 4173
	[Token(Token = "0x200104D")]
	public static class GoogleEngagementRewards
	{
		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06003FBB RID: 16315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000753")]
		private static AndroidJavaClass API
		{
			[Token(Token = "0x6003FBB")]
			[Address(RVA = "0x2119854", Offset = "0x2119854", VA = "0x7BBC919854")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06003FBC RID: 16316 RVA: 0x00013BD8 File Offset: 0x00011DD8
		[Token(Token = "0x17000754")]
		public static bool IsSupported
		{
			[Token(Token = "0x6003FBC")]
			[Address(RVA = "0x21198E8", Offset = "0x21198E8", VA = "0x7BBC9198E8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FBD")]
		[Address(RVA = "0x21199A0", Offset = "0x21199A0", VA = "0x7BBC9199A0")]
		private static void LogVerbose(string log)
		{
		}

		// Token: 0x06003FBE RID: 16318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FBE")]
		[Address(RVA = "0x2119A10", Offset = "0x2119A10", VA = "0x7BBC919A10")]
		private static void Log(string log)
		{
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FBF")]
		[Address(RVA = "0x2119A80", Offset = "0x2119A80", VA = "0x7BBC919A80")]
		private static void LogError(string log)
		{
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06003FC0 RID: 16320 RVA: 0x00013BF0 File Offset: 0x00011DF0
		// (set) Token: 0x06003FC1 RID: 16321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000755")]
		public static bool Inited
		{
			[Token(Token = "0x6003FC0")]
			[Address(RVA = "0x2119AF0", Offset = "0x2119AF0", VA = "0x7BBC919AF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C25C", Offset = "0x113C25C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003FC1")]
			[Address(RVA = "0x2119B40", Offset = "0x2119B40", VA = "0x7BBC919B40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C26C", Offset = "0x113C26C")]
			private set
			{
			}
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC2")]
		[Address(RVA = "0x2119B98", Offset = "0x2119B98", VA = "0x7BBC919B98")]
		public static void Init(GoogleEngagementRewards.Delegate d)
		{
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC3")]
		[Address(RVA = "0x211A314", Offset = "0x211A314", VA = "0x7BBC91A314")]
		private static void SetUnitySendMessageGameObjectName(string name)
		{
		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x00013C08 File Offset: 0x00011E08
		[Token(Token = "0x6003FC4")]
		[Address(RVA = "0x211A444", Offset = "0x211A444", VA = "0x7BBC91A444")]
		public static bool IsGoogleSignedIn()
		{
			return default(bool);
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FC5")]
		[Address(RVA = "0x211A56C", Offset = "0x211A56C", VA = "0x7BBC91A56C")]
		public static string GetGoogleAccount()
		{
			return null;
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC6")]
		[Address(RVA = "0x211A678", Offset = "0x211A678", VA = "0x7BBC91A678")]
		public static void GetGoogleAccessToken()
		{
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC7")]
		[Address(RVA = "0x211A770", Offset = "0x211A770", VA = "0x7BBC91A770")]
		public static void GoogleSignIn()
		{
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC8")]
		[Address(RVA = "0x211A868", Offset = "0x211A868", VA = "0x7BBC91A868")]
		public static void GoogleSignOut()
		{
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x00013C20 File Offset: 0x00011E20
		[Token(Token = "0x6003FC9")]
		[Address(RVA = "0x211A960", Offset = "0x211A960", VA = "0x7BBC91A960")]
		public static bool HasStoredGoogleAccount()
		{
			return default(bool);
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCA")]
		[Address(RVA = "0x211AA64", Offset = "0x211AA64", VA = "0x7BBC91AA64")]
		public static string GetStoredGoogleAccount()
		{
			return null;
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCB")]
		[Address(RVA = "0x211AB74", Offset = "0x211AB74", VA = "0x7BBC91AB74")]
		public static string GetStoredGoogleAuthToken()
		{
			return null;
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FCC")]
		[Address(RVA = "0x211AC84", Offset = "0x211AC84", VA = "0x7BBC91AC84")]
		public static GoogleEngagementRewards.GetAccountsResult GetAccounts()
		{
			return null;
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FCD")]
		[Address(RVA = "0x211AE1C", Offset = "0x211AE1C", VA = "0x7BBC91AE1C")]
		public static void RefreshAccountToken(string accountName)
		{
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FCE")]
		[Address(RVA = "0x211AF68", Offset = "0x211AF68", VA = "0x7BBC91AF68")]
		public static void ClearStoredGoogleAccount()
		{
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FCF")]
		[Address(RVA = "0x211B060", Offset = "0x211B060", VA = "0x7BBC91B060")]
		public static void GoogleRevoke()
		{
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD0")]
		[Address(RVA = "0x211B158", Offset = "0x211B158", VA = "0x7BBC91B158")]
		public static void GetAvailablePromotions()
		{
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD1")]
		[Address(RVA = "0x211B250", Offset = "0x211B250", VA = "0x7BBC91B250")]
		public static void RedeemPromotion(string promotion_code)
		{
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD2")]
		[Address(RVA = "0x211B39C", Offset = "0x211B39C", VA = "0x7BBC91B39C")]
		public static void GetReward(string reward_name)
		{
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD3")]
		[Address(RVA = "0x211B4E8", Offset = "0x211B4E8", VA = "0x7BBC91B4E8")]
		public static void RetryPendingRedeemPromotions()
		{
		}

		// Token: 0x04004F9B RID: 20379
		[Token(Token = "0x4004F9B")]
		public const int REWARDS_ENV_FAKE = 0;

		// Token: 0x04004F9C RID: 20380
		[Token(Token = "0x4004F9C")]
		public const int REWARDS_ENV_STAGING = 1;

		// Token: 0x04004F9D RID: 20381
		[Token(Token = "0x4004F9D")]
		public const int REWARDS_ENV_LIVE = 2;

		// Token: 0x04004F9E RID: 20382
		[Token(Token = "0x4004F9E")]
		[FieldOffset(Offset = "0x0")]
		private static AndroidJavaClass _API;

		// Token: 0x04004F9F RID: 20383
		[Token(Token = "0x4004F9F")]
		[FieldOffset(Offset = "0x8")]
		private static GoogleEngagementRewards.Handler _Handler;

		// Token: 0x04004FA0 RID: 20384
		[Token(Token = "0x4004FA0")]
		[FieldOffset(Offset = "0x10")]
		public static GoogleEngagementRewards.Delegate _Delegate;

		// Token: 0x04004FA1 RID: 20385
		[Token(Token = "0x4004FA1")]
		[FieldOffset(Offset = "0x18")]
		private static bool? _IsSupported;

		// Token: 0x04004FA2 RID: 20386
		[Token(Token = "0x4004FA2")]
		[FieldOffset(Offset = "0x1A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EB8C", Offset = "0x112EB8C")]
		private static bool <Inited>k__BackingField;

		// Token: 0x0200104E RID: 4174
		[Token(Token = "0x200104E")]
		public abstract class Delegate
		{
			// Token: 0x06003FD4 RID: 16340
			[Token(Token = "0x6003FD4")]
			public abstract void Log(string log);

			// Token: 0x06003FD5 RID: 16341
			[Token(Token = "0x6003FD5")]
			public abstract void LogVerbose(string log);

			// Token: 0x06003FD6 RID: 16342
			[Token(Token = "0x6003FD6")]
			public abstract void LogError(string log);

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x06003FD7 RID: 16343
			[Token(Token = "0x17000756")]
			public abstract long AccountID { [Token(Token = "0x6003FD7")] get; }

			// Token: 0x17000757 RID: 1879
			// (get) Token: 0x06003FD8 RID: 16344
			[Token(Token = "0x17000757")]
			public abstract int Env { [Token(Token = "0x6003FD8")] get; }

			// Token: 0x17000758 RID: 1880
			// (get) Token: 0x06003FD9 RID: 16345
			[Token(Token = "0x17000758")]
			public abstract string SponserID { [Token(Token = "0x6003FD9")] get; }

			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x06003FDA RID: 16346
			[Token(Token = "0x17000759")]
			public abstract string API_Key { [Token(Token = "0x6003FDA")] get; }

			// Token: 0x1700075A RID: 1882
			// (get) Token: 0x06003FDB RID: 16347
			[Token(Token = "0x1700075A")]
			public abstract int ClientVersionCode { [Token(Token = "0x6003FDB")] get; }

			// Token: 0x06003FDC RID: 16348
			[Token(Token = "0x6003FDC")]
			public abstract void OnGetGoogleAccessToken(string token);

			// Token: 0x06003FDD RID: 16349
			[Token(Token = "0x6003FDD")]
			public abstract void OnGoogleSignIn();

			// Token: 0x06003FDE RID: 16350
			[Token(Token = "0x6003FDE")]
			public abstract void OnGoogleRevoke();

			// Token: 0x06003FDF RID: 16351
			[Token(Token = "0x6003FDF")]
			public abstract void OnRefreshAuthToken(string accountName);

			// Token: 0x06003FE0 RID: 16352
			[Token(Token = "0x6003FE0")]
			public abstract void OnRefreshAuthTokenError(GoogleEngagementRewards.RefreshTokenError error, string msg);

			// Token: 0x06003FE1 RID: 16353
			[Token(Token = "0x6003FE1")]
			public abstract void OnGetAvailablePromotionsSuccess(GoogleEngagementRewards.PromotionsResult result);

			// Token: 0x06003FE2 RID: 16354
			[Token(Token = "0x6003FE2")]
			public abstract void OnGetAvailablePromotionsFailure(GoogleEngagementRewards.PromotionsResult result);

			// Token: 0x06003FE3 RID: 16355
			[Token(Token = "0x6003FE3")]
			public abstract void OnRedeemPromotionSuccess(GoogleEngagementRewards.Reward reward);

			// Token: 0x06003FE4 RID: 16356
			[Token(Token = "0x6003FE4")]
			public abstract void OnRedeemPromotionFailure(GoogleEngagementRewards.ThrowableJSON throwable);

			// Token: 0x06003FE5 RID: 16357
			[Token(Token = "0x6003FE5")]
			public abstract void OnGetRewardSuccess(GoogleEngagementRewards.Reward reward);

			// Token: 0x06003FE6 RID: 16358
			[Token(Token = "0x6003FE6")]
			public abstract void OnGetRewardFailure(GoogleEngagementRewards.ThrowableJSON throwable);

			// Token: 0x06003FE7 RID: 16359
			[Token(Token = "0x6003FE7")]
			public abstract void RetriedPendingRedeemPromotions();

			// Token: 0x06003FE8 RID: 16360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FE8")]
			[Address(RVA = "0x211B5FC", Offset = "0x211B5FC", VA = "0x7BBC91B5FC")]
			protected Delegate()
			{
			}
		}

		// Token: 0x0200104F RID: 4175
		[Token(Token = "0x200104F")]
		[Serializable]
		public class ThrowableJSON
		{
			// Token: 0x06003FE9 RID: 16361 RVA: 0x00013C38 File Offset: 0x00011E38
			[Token(Token = "0x6003FE9")]
			[Address(RVA = "0x211D174", Offset = "0x211D174", VA = "0x7BBC91D174")]
			public static bool HasValue(GoogleEngagementRewards.ThrowableJSON obj)
			{
				return default(bool);
			}

			// Token: 0x06003FEA RID: 16362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FEA")]
			[Address(RVA = "0x211D1D8", Offset = "0x211D1D8", VA = "0x7BBC91D1D8")]
			public ThrowableJSON()
			{
			}

			// Token: 0x04004FA3 RID: 20387
			[Token(Token = "0x4004FA3")]
			[FieldOffset(Offset = "0x10")]
			public string Message;

			// Token: 0x04004FA4 RID: 20388
			[Token(Token = "0x4004FA4")]
			[FieldOffset(Offset = "0x18")]
			public string LocalizedMessage;

			// Token: 0x04004FA5 RID: 20389
			[Token(Token = "0x4004FA5")]
			[FieldOffset(Offset = "0x20")]
			public string Stacktrace;
		}

		// Token: 0x02001050 RID: 4176
		[Token(Token = "0x2001050")]
		[Serializable]
		public class DataOffer
		{
			// Token: 0x06003FEB RID: 16363 RVA: 0x00013C50 File Offset: 0x00011E50
			[Token(Token = "0x6003FEB")]
			[Address(RVA = "0x211B5E0", Offset = "0x211B5E0", VA = "0x7BBC91B5E0")]
			public static bool HasValue(GoogleEngagementRewards.DataOffer obj)
			{
				return default(bool);
			}

			// Token: 0x06003FEC RID: 16364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FEC")]
			[Address(RVA = "0x211B5F4", Offset = "0x211B5F4", VA = "0x7BBC91B5F4")]
			public DataOffer()
			{
			}

			// Token: 0x04004FA6 RID: 20390
			[Token(Token = "0x4004FA6")]
			[FieldOffset(Offset = "0x10")]
			public long offerInBytes;

			// Token: 0x04004FA7 RID: 20391
			[Token(Token = "0x4004FA7")]
			[FieldOffset(Offset = "0x18")]
			public long offerValidityTimeMillis;
		}

		// Token: 0x02001051 RID: 4177
		[Token(Token = "0x2001051")]
		[Serializable]
		public class Money
		{
			// Token: 0x06003FED RID: 16365 RVA: 0x00013C68 File Offset: 0x00011E68
			[Token(Token = "0x6003FED")]
			[Address(RVA = "0x211D0A4", Offset = "0x211D0A4", VA = "0x7BBC91D0A4")]
			public static bool HasValue(GoogleEngagementRewards.Money obj)
			{
				return default(bool);
			}

			// Token: 0x06003FEE RID: 16366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FEE")]
			[Address(RVA = "0x211D0E8", Offset = "0x211D0E8", VA = "0x7BBC91D0E8")]
			public Money()
			{
			}

			// Token: 0x04004FA8 RID: 20392
			[Token(Token = "0x4004FA8")]
			[FieldOffset(Offset = "0x10")]
			public string currencyCode;

			// Token: 0x04004FA9 RID: 20393
			[Token(Token = "0x4004FA9")]
			[FieldOffset(Offset = "0x18")]
			public long units;

			// Token: 0x04004FAA RID: 20394
			[Token(Token = "0x4004FAA")]
			[FieldOffset(Offset = "0x20")]
			public int nanos;
		}

		// Token: 0x02001052 RID: 4178
		[Token(Token = "0x2001052")]
		[Serializable]
		public class TezOffer
		{
			// Token: 0x06003FEF RID: 16367 RVA: 0x00013C80 File Offset: 0x00011E80
			[Token(Token = "0x6003FEF")]
			[Address(RVA = "0x211B6A4", Offset = "0x211B6A4", VA = "0x7BBC91B6A4")]
			public static bool HasValue(GoogleEngagementRewards.TezOffer obj)
			{
				return default(bool);
			}

			// Token: 0x06003FF0 RID: 16368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FF0")]
			[Address(RVA = "0x211D16C", Offset = "0x211D16C", VA = "0x7BBC91D16C")]
			public TezOffer()
			{
			}

			// Token: 0x04004FAB RID: 20395
			[Token(Token = "0x4004FAB")]
			[FieldOffset(Offset = "0x10")]
			public GoogleEngagementRewards.Money offerAmount;
		}

		// Token: 0x02001053 RID: 4179
		[Token(Token = "0x2001053")]
		[Serializable]
		public class RideCreditOffer
		{
			// Token: 0x06003FF1 RID: 16369 RVA: 0x00013C98 File Offset: 0x00011E98
			[Token(Token = "0x6003FF1")]
			[Address(RVA = "0x211B6EC", Offset = "0x211B6EC", VA = "0x7BBC91B6EC")]
			public static bool HasValue(GoogleEngagementRewards.RideCreditOffer obj)
			{
				return default(bool);
			}

			// Token: 0x06003FF2 RID: 16370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FF2")]
			[Address(RVA = "0x211D164", Offset = "0x211D164", VA = "0x7BBC91D164")]
			public RideCreditOffer()
			{
			}

			// Token: 0x04004FAC RID: 20396
			[Token(Token = "0x4004FAC")]
			[FieldOffset(Offset = "0x10")]
			public string rideProviderName;

			// Token: 0x04004FAD RID: 20397
			[Token(Token = "0x4004FAD")]
			[FieldOffset(Offset = "0x18")]
			public string imageUrl;

			// Token: 0x04004FAE RID: 20398
			[Token(Token = "0x4004FAE")]
			[FieldOffset(Offset = "0x20")]
			public GoogleEngagementRewards.Money offerAmount;
		}

		// Token: 0x02001054 RID: 4180
		[Token(Token = "0x2001054")]
		public enum MoneyOfferType
		{
			// Token: 0x04004FB0 RID: 20400
			[Token(Token = "0x4004FB0")]
			MONEY_OFFER_TYPE_UNSPECIFIED,
			// Token: 0x04004FB1 RID: 20401
			[Token(Token = "0x4004FB1")]
			PLAY_CREDIT_OFFER
		}

		// Token: 0x02001055 RID: 4181
		[Token(Token = "0x2001055")]
		[Serializable]
		public class MoneyOffer
		{
			// Token: 0x06003FF3 RID: 16371 RVA: 0x00013CB0 File Offset: 0x00011EB0
			[Token(Token = "0x6003FF3")]
			[Address(RVA = "0x211B748", Offset = "0x211B748", VA = "0x7BBC91B748")]
			public static bool HasValue(GoogleEngagementRewards.MoneyOffer obj)
			{
				return default(bool);
			}

			// Token: 0x06003FF4 RID: 16372 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FF4")]
			[Address(RVA = "0x211D0F0", Offset = "0x211D0F0", VA = "0x7BBC91D0F0")]
			public MoneyOffer()
			{
			}

			// Token: 0x04004FB2 RID: 20402
			[Token(Token = "0x4004FB2")]
			[FieldOffset(Offset = "0x10")]
			public GoogleEngagementRewards.Money offerAmount;

			// Token: 0x04004FB3 RID: 20403
			[Token(Token = "0x4004FB3")]
			[FieldOffset(Offset = "0x18")]
			public GoogleEngagementRewards.MoneyOfferType moneyOfferType;
		}

		// Token: 0x02001056 RID: 4182
		[Token(Token = "0x2001056")]
		[Serializable]
		public class EngagementOffer
		{
			// Token: 0x06003FF5 RID: 16373 RVA: 0x00013CC8 File Offset: 0x00011EC8
			[Token(Token = "0x6003FF5")]
			[Address(RVA = "0x211B604", Offset = "0x211B604", VA = "0x7BBC91B604")]
			public static bool HasValue(GoogleEngagementRewards.EngagementOffer obj)
			{
				return default(bool);
			}

			// Token: 0x06003FF6 RID: 16374 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FF6")]
			[Address(RVA = "0x211B790", Offset = "0x211B790", VA = "0x7BBC91B790")]
			public EngagementOffer()
			{
			}

			// Token: 0x04004FB4 RID: 20404
			[Token(Token = "0x4004FB4")]
			[FieldOffset(Offset = "0x10")]
			public GoogleEngagementRewards.DataOffer dataOffer;

			// Token: 0x04004FB5 RID: 20405
			[Token(Token = "0x4004FB5")]
			[FieldOffset(Offset = "0x18")]
			public GoogleEngagementRewards.TezOffer tezOffer;

			// Token: 0x04004FB6 RID: 20406
			[Token(Token = "0x4004FB6")]
			[FieldOffset(Offset = "0x20")]
			public GoogleEngagementRewards.RideCreditOffer rideCreditOffer;

			// Token: 0x04004FB7 RID: 20407
			[Token(Token = "0x4004FB7")]
			[FieldOffset(Offset = "0x28")]
			public GoogleEngagementRewards.MoneyOffer moneyOffer;
		}

		// Token: 0x02001057 RID: 4183
		[Token(Token = "0x2001057")]
		[Serializable]
		public class Promotion
		{
			// Token: 0x06003FF7 RID: 16375 RVA: 0x00013CE0 File Offset: 0x00011EE0
			[Token(Token = "0x6003FF7")]
			[Address(RVA = "0x211D0F8", Offset = "0x211D0F8", VA = "0x7BBC91D0F8")]
			public static bool HasValue(GoogleEngagementRewards.Promotion obj)
			{
				return default(bool);
			}

			// Token: 0x06003FF8 RID: 16376 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FF8")]
			[Address(RVA = "0x211D14C", Offset = "0x211D14C", VA = "0x7BBC91D14C")]
			public Promotion()
			{
			}

			// Token: 0x04004FB8 RID: 20408
			[Token(Token = "0x4004FB8")]
			public const long NO_REDEMPTION_LIMIT = -1L;

			// Token: 0x04004FB9 RID: 20409
			[Token(Token = "0x4004FB9")]
			[FieldOffset(Offset = "0x10")]
			public string promotionCode;

			// Token: 0x04004FBA RID: 20410
			[Token(Token = "0x4004FBA")]
			[FieldOffset(Offset = "0x18")]
			public string actionType;

			// Token: 0x04004FBB RID: 20411
			[Token(Token = "0x4004FBB")]
			[FieldOffset(Offset = "0x20")]
			public long numTimesRedeemable;

			// Token: 0x04004FBC RID: 20412
			[Token(Token = "0x4004FBC")]
			[FieldOffset(Offset = "0x28")]
			public GoogleEngagementRewards.EngagementOffer engagementOffer;
		}

		// Token: 0x02001058 RID: 4184
		[Token(Token = "0x2001058")]
		[Serializable]
		public class PromotionsResult
		{
			// Token: 0x06003FF9 RID: 16377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FF9")]
			[Address(RVA = "0x211D154", Offset = "0x211D154", VA = "0x7BBC91D154")]
			public PromotionsResult()
			{
			}

			// Token: 0x04004FBD RID: 20413
			[Token(Token = "0x4004FBD")]
			[FieldOffset(Offset = "0x10")]
			public List<GoogleEngagementRewards.Promotion> Promotions;

			// Token: 0x04004FBE RID: 20414
			[Token(Token = "0x4004FBE")]
			[FieldOffset(Offset = "0x18")]
			public GoogleEngagementRewards.ThrowableJSON Throwable;
		}

		// Token: 0x02001059 RID: 4185
		[Token(Token = "0x2001059")]
		[Serializable]
		public enum RedemptionStatus
		{
			// Token: 0x04004FC0 RID: 20416
			[Token(Token = "0x4004FC0")]
			UNKNOWN_ERROR_CODE,
			// Token: 0x04004FC1 RID: 20417
			[Token(Token = "0x4004FC1")]
			SUCCESS,
			// Token: 0x04004FC2 RID: 20418
			[Token(Token = "0x4004FC2")]
			PENDING,
			// Token: 0x04004FC3 RID: 20419
			[Token(Token = "0x4004FC3")]
			PERMANENT_FAILURE
		}

		// Token: 0x0200105A RID: 4186
		[Token(Token = "0x200105A")]
		[Serializable]
		public class Reward
		{
			// Token: 0x06003FFA RID: 16378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FFA")]
			[Address(RVA = "0x211D15C", Offset = "0x211D15C", VA = "0x7BBC91D15C")]
			public Reward()
			{
			}

			// Token: 0x04004FC4 RID: 20420
			[Token(Token = "0x4004FC4")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04004FC5 RID: 20421
			[Token(Token = "0x4004FC5")]
			[FieldOffset(Offset = "0x18")]
			public string redemptionStatus;

			// Token: 0x04004FC6 RID: 20422
			[Token(Token = "0x4004FC6")]
			[FieldOffset(Offset = "0x20")]
			public long createTime;

			// Token: 0x04004FC7 RID: 20423
			[Token(Token = "0x4004FC7")]
			[FieldOffset(Offset = "0x28")]
			public long updateTime;
		}

		// Token: 0x0200105B RID: 4187
		[Token(Token = "0x200105B")]
		[Serializable]
		public class GetAccountsResult
		{
			// Token: 0x06003FFB RID: 16379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FFB")]
			[Address(RVA = "0x211B798", Offset = "0x211B798", VA = "0x7BBC91B798")]
			public GetAccountsResult()
			{
			}

			// Token: 0x04004FC8 RID: 20424
			[Token(Token = "0x4004FC8")]
			[FieldOffset(Offset = "0x10")]
			public string[] AccountNames;
		}

		// Token: 0x0200105C RID: 4188
		[Token(Token = "0x200105C")]
		public enum RefreshTokenError
		{
			// Token: 0x04004FCA RID: 20426
			[Token(Token = "0x4004FCA")]
			None,
			// Token: 0x04004FCB RID: 20427
			[Token(Token = "0x4004FCB")]
			ActivityResult,
			// Token: 0x04004FCC RID: 20428
			[Token(Token = "0x4004FCC")]
			InvalidAccountName,
			// Token: 0x04004FCD RID: 20429
			[Token(Token = "0x4004FCD")]
			NoAccounts,
			// Token: 0x04004FCE RID: 20430
			[Token(Token = "0x4004FCE")]
			Exception,
			// Token: 0x04004FCF RID: 20431
			[Token(Token = "0x4004FCF")]
			Message
		}

		// Token: 0x0200105D RID: 4189
		[Token(Token = "0x200105D")]
		private class Handler : MonoBehaviour
		{
			// Token: 0x06003FFC RID: 16380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FFC")]
			[Address(RVA = "0x211B7A0", Offset = "0x211B7A0", VA = "0x7BBC91B7A0")]
			private void Start()
			{
			}

			// Token: 0x06003FFD RID: 16381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FFD")]
			[Address(RVA = "0x211B804", Offset = "0x211B804", VA = "0x7BBC91B804")]
			public void gotGoogleAccessToken(string googleAccessToken)
			{
			}

			// Token: 0x06003FFE RID: 16382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FFE")]
			[Address(RVA = "0x211B8CC", Offset = "0x211B8CC", VA = "0x7BBC91B8CC")]
			public void onGoogleSignIn()
			{
			}

			// Token: 0x06003FFF RID: 16383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FFF")]
			[Address(RVA = "0x211B9C0", Offset = "0x211B9C0", VA = "0x7BBC91B9C0")]
			public void onGoogleRevoke()
			{
			}

			// Token: 0x06004000 RID: 16384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004000")]
			[Address(RVA = "0x211BAB4", Offset = "0x211BAB4", VA = "0x7BBC91BAB4")]
			public void onRefreshAccountToken(string accountName)
			{
			}

			// Token: 0x06004001 RID: 16385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004001")]
			[Address(RVA = "0x211BB7C", Offset = "0x211BB7C", VA = "0x7BBC91BB7C")]
			public void onRefreshAccountTokenError_ActivityResult(string throwableJson)
			{
			}

			// Token: 0x06004002 RID: 16386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004002")]
			[Address(RVA = "0x211BC44", Offset = "0x211BC44", VA = "0x7BBC91BC44")]
			public void onRefreshAccountTokenError_InvalidAccountName()
			{
			}

			// Token: 0x06004003 RID: 16387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004003")]
			[Address(RVA = "0x211BD38", Offset = "0x211BD38", VA = "0x7BBC91BD38")]
			public void onRefreshAccountTokenError_NoAccounts()
			{
			}

			// Token: 0x06004004 RID: 16388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004004")]
			[Address(RVA = "0x211BE2C", Offset = "0x211BE2C", VA = "0x7BBC91BE2C")]
			public void onRefreshAccountTokenError_Exception(string throwableJson)
			{
			}

			// Token: 0x06004005 RID: 16389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004005")]
			[Address(RVA = "0x211BEF4", Offset = "0x211BEF4", VA = "0x7BBC91BEF4")]
			public void onRefreshAccountTokenError_Message(string msg)
			{
			}

			// Token: 0x06004006 RID: 16390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004006")]
			[Address(RVA = "0x211BFBC", Offset = "0x211BFBC", VA = "0x7BBC91BFBC")]
			public void getAvailablePromotionsSuccess(string promotionsResultString)
			{
			}

			// Token: 0x06004007 RID: 16391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004007")]
			[Address(RVA = "0x211C084", Offset = "0x211C084", VA = "0x7BBC91C084")]
			public void getAvailablePromotionsFailure(string promotionsResultString)
			{
			}

			// Token: 0x06004008 RID: 16392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004008")]
			[Address(RVA = "0x211C14C", Offset = "0x211C14C", VA = "0x7BBC91C14C")]
			public void redeemPromotionSuccess(string rewardString)
			{
			}

			// Token: 0x06004009 RID: 16393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004009")]
			[Address(RVA = "0x211C214", Offset = "0x211C214", VA = "0x7BBC91C214")]
			public void redeemPromotionFailure(string throwableJsonString)
			{
			}

			// Token: 0x0600400A RID: 16394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600400A")]
			[Address(RVA = "0x211C2DC", Offset = "0x211C2DC", VA = "0x7BBC91C2DC")]
			public void getRewardSuccess(string rewardString)
			{
			}

			// Token: 0x0600400B RID: 16395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600400B")]
			[Address(RVA = "0x211C3A4", Offset = "0x211C3A4", VA = "0x7BBC91C3A4")]
			public void getRewardFailure(string throwableJsonString)
			{
			}

			// Token: 0x0600400C RID: 16396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600400C")]
			[Address(RVA = "0x211C46C", Offset = "0x211C46C", VA = "0x7BBC91C46C")]
			public void retriePendingRedeemPromotions()
			{
			}

			// Token: 0x0600400D RID: 16397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600400D")]
			[Address(RVA = "0x211C560", Offset = "0x211C560", VA = "0x7BBC91C560")]
			public Handler()
			{
			}

			// Token: 0x04004FD0 RID: 20432
			[Token(Token = "0x4004FD0")]
			public const string GAME_OBJECT_NAME = "GoogleEngagementRewardsHandler";

			// Token: 0x0200105E RID: 4190
			[Token(Token = "0x200105E")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA9E4", Offset = "0x10EA9E4")]
			private sealed class <>c__DisplayClass2_0
			{
				// Token: 0x0600400E RID: 16398 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600400E")]
				[Address(RVA = "0x211B8C4", Offset = "0x211B8C4", VA = "0x7BBC91B8C4")]
				public <>c__DisplayClass2_0()
				{
				}

				// Token: 0x0600400F RID: 16399 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600400F")]
				[Address(RVA = "0x211CDB8", Offset = "0x211CDB8", VA = "0x7BBC91CDB8")]
				internal void <gotGoogleAccessToken>b__0()
				{
				}

				// Token: 0x04004FD1 RID: 20433
				[Token(Token = "0x4004FD1")]
				[FieldOffset(Offset = "0x10")]
				public string googleAccessToken;
			}

			// Token: 0x0200105F RID: 4191
			[Token(Token = "0x200105F")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA9F4", Offset = "0x10EA9F4")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06004011 RID: 16401 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004011")]
				[Address(RVA = "0x211C5CC", Offset = "0x211C5CC", VA = "0x7BBC91C5CC")]
				public <>c()
				{
				}

				// Token: 0x06004012 RID: 16402 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004012")]
				[Address(RVA = "0x211C5D4", Offset = "0x211C5D4", VA = "0x7BBC91C5D4")]
				internal void <onGoogleSignIn>b__3_0()
				{
				}

				// Token: 0x06004013 RID: 16403 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004013")]
				[Address(RVA = "0x211C66C", Offset = "0x211C66C", VA = "0x7BBC91C66C")]
				internal void <onGoogleRevoke>b__4_0()
				{
				}

				// Token: 0x06004014 RID: 16404 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004014")]
				[Address(RVA = "0x211C708", Offset = "0x211C708", VA = "0x7BBC91C708")]
				internal void <onRefreshAccountTokenError_InvalidAccountName>b__7_0()
				{
				}

				// Token: 0x06004015 RID: 16405 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004015")]
				[Address(RVA = "0x211C7BC", Offset = "0x211C7BC", VA = "0x7BBC91C7BC")]
				internal void <onRefreshAccountTokenError_NoAccounts>b__8_0()
				{
				}

				// Token: 0x06004016 RID: 16406 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004016")]
				[Address(RVA = "0x211C870", Offset = "0x211C870", VA = "0x7BBC91C870")]
				internal void <retriePendingRedeemPromotions>b__17_0()
				{
				}

				// Token: 0x04004FD2 RID: 20434
				[Token(Token = "0x4004FD2")]
				[FieldOffset(Offset = "0x0")]
				public static readonly GoogleEngagementRewards.Handler.<>c <>9;

				// Token: 0x04004FD3 RID: 20435
				[Token(Token = "0x4004FD3")]
				[FieldOffset(Offset = "0x8")]
				public static Action <>9__3_0;

				// Token: 0x04004FD4 RID: 20436
				[Token(Token = "0x4004FD4")]
				[FieldOffset(Offset = "0x10")]
				public static Action <>9__4_0;

				// Token: 0x04004FD5 RID: 20437
				[Token(Token = "0x4004FD5")]
				[FieldOffset(Offset = "0x18")]
				public static Action <>9__7_0;

				// Token: 0x04004FD6 RID: 20438
				[Token(Token = "0x4004FD6")]
				[FieldOffset(Offset = "0x20")]
				public static Action <>9__8_0;

				// Token: 0x04004FD7 RID: 20439
				[Token(Token = "0x4004FD7")]
				[FieldOffset(Offset = "0x28")]
				public static Action <>9__17_0;
			}

			// Token: 0x02001060 RID: 4192
			[Token(Token = "0x2001060")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAA04", Offset = "0x10EAA04")]
			private sealed class <>c__DisplayClass5_0
			{
				// Token: 0x06004017 RID: 16407 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004017")]
				[Address(RVA = "0x211BB74", Offset = "0x211BB74", VA = "0x7BBC91BB74")]
				public <>c__DisplayClass5_0()
				{
				}

				// Token: 0x06004018 RID: 16408 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004018")]
				[Address(RVA = "0x211CE44", Offset = "0x211CE44", VA = "0x7BBC91CE44")]
				internal void <onRefreshAccountToken>b__0()
				{
				}

				// Token: 0x04004FD8 RID: 20440
				[Token(Token = "0x4004FD8")]
				[FieldOffset(Offset = "0x10")]
				public string accountName;
			}

			// Token: 0x02001061 RID: 4193
			[Token(Token = "0x2001061")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAA14", Offset = "0x10EAA14")]
			private sealed class <>c__DisplayClass6_0
			{
				// Token: 0x06004019 RID: 16409 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004019")]
				[Address(RVA = "0x211BC3C", Offset = "0x211BC3C", VA = "0x7BBC91BC3C")]
				public <>c__DisplayClass6_0()
				{
				}

				// Token: 0x0600401A RID: 16410 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600401A")]
				[Address(RVA = "0x211CED4", Offset = "0x211CED4", VA = "0x7BBC91CED4")]
				internal void <onRefreshAccountTokenError_ActivityResult>b__0()
				{
				}

				// Token: 0x04004FD9 RID: 20441
				[Token(Token = "0x4004FD9")]
				[FieldOffset(Offset = "0x10")]
				public string throwableJson;
			}

			// Token: 0x02001062 RID: 4194
			[Token(Token = "0x2001062")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAA24", Offset = "0x10EAA24")]
			private sealed class <>c__DisplayClass9_0
			{
				// Token: 0x0600401B RID: 16411 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600401B")]
				[Address(RVA = "0x211BEEC", Offset = "0x211BEEC", VA = "0x7BBC91BEEC")]
				public <>c__DisplayClass9_0()
				{
				}

				// Token: 0x0600401C RID: 16412 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600401C")]
				[Address(RVA = "0x211CFA8", Offset = "0x211CFA8", VA = "0x7BBC91CFA8")]
				internal void <onRefreshAccountTokenError_Exception>b__0()
				{
				}

				// Token: 0x04004FDA RID: 20442
				[Token(Token = "0x4004FDA")]
				[FieldOffset(Offset = "0x10")]
				public string throwableJson;
			}

			// Token: 0x02001063 RID: 4195
			[Token(Token = "0x2001063")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAA34", Offset = "0x10EAA34")]
			private sealed class <>c__DisplayClass10_0
			{
				// Token: 0x0600401D RID: 16413 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600401D")]
				[Address(RVA = "0x211BFB4", Offset = "0x211BFB4", VA = "0x7BBC91BFB4")]
				public <>c__DisplayClass10_0()
				{
				}

				// Token: 0x0600401E RID: 16414 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600401E")]
				[Address(RVA = "0x211C90C", Offset = "0x211C90C", VA = "0x7BBC91C90C")]
				internal void <onRefreshAccountTokenError_Message>b__0()
				{
				}

				// Token: 0x04004FDB RID: 20443
				[Token(Token = "0x4004FDB")]
				[FieldOffset(Offset = "0x10")]
				public string msg;
			}

			// Token: 0x02001064 RID: 4196
			[Token(Token = "0x2001064")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAA44", Offset = "0x10EAA44")]
			private sealed class <>c__DisplayClass11_0
			{
				// Token: 0x0600401F RID: 16415 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600401F")]
				[Address(RVA = "0x211C07C", Offset = "0x211C07C", VA = "0x7BBC91C07C")]
				public <>c__DisplayClass11_0()
				{
				}

				// Token: 0x06004020 RID: 16416 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004020")]
				[Address(RVA = "0x211C9C8", Offset = "0x211C9C8", VA = "0x7BBC91C9C8")]
				internal void <getAvailablePromotionsSuccess>b__0()
				{
				}

				// Token: 0x04004FDC RID: 20444
				[Token(Token = "0x4004FDC")]
				[FieldOffset(Offset = "0x10")]
				public string promotionsResultString;
			}

			// Token: 0x02001065 RID: 4197
			[Token(Token = "0x2001065")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAA54", Offset = "0x10EAA54")]
			private sealed class <>c__DisplayClass12_0
			{
				// Token: 0x06004021 RID: 16417 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004021")]
				[Address(RVA = "0x211C144", Offset = "0x211C144", VA = "0x7BBC91C144")]
				public <>c__DisplayClass12_0()
				{
				}

				// Token: 0x06004022 RID: 16418 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004022")]
				[Address(RVA = "0x211CA70", Offset = "0x211CA70", VA = "0x7BBC91CA70")]
				internal void <getAvailablePromotionsFailure>b__0()
				{
				}

				// Token: 0x04004FDD RID: 20445
				[Token(Token = "0x4004FDD")]
				[FieldOffset(Offset = "0x10")]
				public string promotionsResultString;
			}

			// Token: 0x02001066 RID: 4198
			[Token(Token = "0x2001066")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAA64", Offset = "0x10EAA64")]
			private sealed class <>c__DisplayClass13_0
			{
				// Token: 0x06004023 RID: 16419 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004023")]
				[Address(RVA = "0x211C20C", Offset = "0x211C20C", VA = "0x7BBC91C20C")]
				public <>c__DisplayClass13_0()
				{
				}

				// Token: 0x06004024 RID: 16420 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004024")]
				[Address(RVA = "0x211CB18", Offset = "0x211CB18", VA = "0x7BBC91CB18")]
				internal void <redeemPromotionSuccess>b__0()
				{
				}

				// Token: 0x04004FDE RID: 20446
				[Token(Token = "0x4004FDE")]
				[FieldOffset(Offset = "0x10")]
				public string rewardString;
			}

			// Token: 0x02001067 RID: 4199
			[Token(Token = "0x2001067")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAA74", Offset = "0x10EAA74")]
			private sealed class <>c__DisplayClass14_0
			{
				// Token: 0x06004025 RID: 16421 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004025")]
				[Address(RVA = "0x211C2D4", Offset = "0x211C2D4", VA = "0x7BBC91C2D4")]
				public <>c__DisplayClass14_0()
				{
				}

				// Token: 0x06004026 RID: 16422 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004026")]
				[Address(RVA = "0x211CBC0", Offset = "0x211CBC0", VA = "0x7BBC91CBC0")]
				internal void <redeemPromotionFailure>b__0()
				{
				}

				// Token: 0x04004FDF RID: 20447
				[Token(Token = "0x4004FDF")]
				[FieldOffset(Offset = "0x10")]
				public string throwableJsonString;
			}

			// Token: 0x02001068 RID: 4200
			[Token(Token = "0x2001068")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAA84", Offset = "0x10EAA84")]
			private sealed class <>c__DisplayClass15_0
			{
				// Token: 0x06004027 RID: 16423 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004027")]
				[Address(RVA = "0x211C39C", Offset = "0x211C39C", VA = "0x7BBC91C39C")]
				public <>c__DisplayClass15_0()
				{
				}

				// Token: 0x06004028 RID: 16424 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004028")]
				[Address(RVA = "0x211CC68", Offset = "0x211CC68", VA = "0x7BBC91CC68")]
				internal void <getRewardSuccess>b__0()
				{
				}

				// Token: 0x04004FE0 RID: 20448
				[Token(Token = "0x4004FE0")]
				[FieldOffset(Offset = "0x10")]
				public string rewardString;
			}

			// Token: 0x02001069 RID: 4201
			[Token(Token = "0x2001069")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAA94", Offset = "0x10EAA94")]
			private sealed class <>c__DisplayClass16_0
			{
				// Token: 0x06004029 RID: 16425 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6004029")]
				[Address(RVA = "0x211C464", Offset = "0x211C464", VA = "0x7BBC91C464")]
				public <>c__DisplayClass16_0()
				{
				}

				// Token: 0x0600402A RID: 16426 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600402A")]
				[Address(RVA = "0x211CD10", Offset = "0x211CD10", VA = "0x7BBC91CD10")]
				internal void <getRewardFailure>b__0()
				{
				}

				// Token: 0x04004FE1 RID: 20449
				[Token(Token = "0x4004FE1")]
				[FieldOffset(Offset = "0x10")]
				public string throwableJsonString;
			}
		}
	}
}
