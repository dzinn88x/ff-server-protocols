using System;
using GCommon.GoogleEngagementRewards;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020012C7 RID: 4807
	[Token(Token = "0x20012C7")]
	public class GoogleEngagementRewardsManager
	{
		// Token: 0x06004B87 RID: 19335 RVA: 0x00016A70 File Offset: 0x00014C70
		[Token(Token = "0x6004B87")]
		[Address(RVA = "0x1D8DE40", Offset = "0x1D8DE40", VA = "0x7BBC58DE40")]
		public static bool IsSupported()
		{
			return default(bool);
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06004B88 RID: 19336 RVA: 0x00016A88 File Offset: 0x00014C88
		[Token(Token = "0x1700084D")]
		public static bool Inited
		{
			[Token(Token = "0x6004B88")]
			[Address(RVA = "0x1D8DE48", Offset = "0x1D8DE48", VA = "0x7BBC58DE48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B89")]
		[Address(RVA = "0x1D8DE50", Offset = "0x1D8DE50", VA = "0x7BBC58DE50")]
		public static void Init()
		{
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x00016AA0 File Offset: 0x00014CA0
		[Token(Token = "0x6004B8A")]
		[Address(RVA = "0x1D8DE94", Offset = "0x1D8DE94", VA = "0x7BBC58DE94")]
		public static bool IsGoogleSignedIn()
		{
			return default(bool);
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B8B")]
		[Address(RVA = "0x1D8DE9C", Offset = "0x1D8DE9C", VA = "0x7BBC58DE9C")]
		public static string GetGoogleAccount()
		{
			return null;
		}

		// Token: 0x06004B8C RID: 19340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8C")]
		[Address(RVA = "0x1D8DEEC", Offset = "0x1D8DEEC", VA = "0x7BBC58DEEC")]
		public static void GoogleSignIn()
		{
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8D")]
		[Address(RVA = "0x1D8DEF0", Offset = "0x1D8DEF0", VA = "0x7BBC58DEF0")]
		public static void GoogleSignOut()
		{
		}

		// Token: 0x06004B8E RID: 19342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B8E")]
		[Address(RVA = "0x1D8DEF4", Offset = "0x1D8DEF4", VA = "0x7BBC58DEF4")]
		public static void GoogleRevoke()
		{
		}

		// Token: 0x06004B8F RID: 19343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B8F")]
		[Address(RVA = "0x1D8DEF8", Offset = "0x1D8DEF8", VA = "0x7BBC58DEF8")]
		public static string[] GetGoogleAccounts()
		{
			return null;
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B90")]
		[Address(RVA = "0x1D8DF00", Offset = "0x1D8DF00", VA = "0x7BBC58DF00")]
		public static void RefreshGoogleAccountToken(string accountName)
		{
		}

		// Token: 0x06004B91 RID: 19345 RVA: 0x00016AB8 File Offset: 0x00014CB8
		[Token(Token = "0x6004B91")]
		[Address(RVA = "0x1D8DF04", Offset = "0x1D8DF04", VA = "0x7BBC58DF04")]
		public static bool HasStoredGoogleAccount()
		{
			return default(bool);
		}

		// Token: 0x06004B92 RID: 19346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B92")]
		[Address(RVA = "0x1D8DF0C", Offset = "0x1D8DF0C", VA = "0x7BBC58DF0C")]
		public static string GetStoredGoogleAccount()
		{
			return null;
		}

		// Token: 0x06004B93 RID: 19347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B93")]
		[Address(RVA = "0x1D8DF5C", Offset = "0x1D8DF5C", VA = "0x7BBC58DF5C")]
		public static void ClearStoredGoogleAccount()
		{
		}

		// Token: 0x06004B94 RID: 19348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B94")]
		[Address(RVA = "0x1D8DF60", Offset = "0x1D8DF60", VA = "0x7BBC58DF60")]
		public static void GetAvailablePromotions()
		{
		}

		// Token: 0x06004B95 RID: 19349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B95")]
		[Address(RVA = "0x1D8DF64", Offset = "0x1D8DF64", VA = "0x7BBC58DF64")]
		public static void RedeemPromotion(string promotionCode)
		{
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B96")]
		[Address(RVA = "0x1D8DF68", Offset = "0x1D8DF68", VA = "0x7BBC58DF68")]
		public static void RetryPendingRedeemPromotions()
		{
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B97")]
		[Address(RVA = "0x1D8DF6C", Offset = "0x1D8DF6C", VA = "0x7BBC58DF6C")]
		public GoogleEngagementRewardsManager()
		{
		}

		// Token: 0x0400739E RID: 29598
		[Token(Token = "0x400739E")]
		[FieldOffset(Offset = "0x0")]
		private static GoogleEngagementRewardsManager.GERDelegate _Delegate;

		// Token: 0x020012C8 RID: 4808
		[Token(Token = "0x20012C8")]
		private class GERDelegate : GoogleEngagementRewards.Delegate
		{
			// Token: 0x1700084E RID: 2126
			// (get) Token: 0x06004B98 RID: 19352 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700084E")]
			public override string SponserID
			{
				[Token(Token = "0x6004B98")]
				[Address(RVA = "0x1D8DF74", Offset = "0x1D8DF74", VA = "0x7BBC58DF74", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700084F RID: 2127
			// (get) Token: 0x06004B99 RID: 19353 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700084F")]
			public override string API_Key
			{
				[Token(Token = "0x6004B99")]
				[Address(RVA = "0x1D8E078", Offset = "0x1D8E078", VA = "0x7BBC58E078", Slot = "10")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000850 RID: 2128
			// (get) Token: 0x06004B9A RID: 19354 RVA: 0x00016AD0 File Offset: 0x00014CD0
			[Token(Token = "0x17000850")]
			public override long AccountID
			{
				[Token(Token = "0x6004B9A")]
				[Address(RVA = "0x1D8E17C", Offset = "0x1D8E17C", VA = "0x7BBC58E17C", Slot = "7")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17000851 RID: 2129
			// (get) Token: 0x06004B9B RID: 19355 RVA: 0x00016AE8 File Offset: 0x00014CE8
			[Token(Token = "0x17000851")]
			public override int ClientVersionCode
			{
				[Token(Token = "0x6004B9B")]
				[Address(RVA = "0x1D8E21C", Offset = "0x1D8E21C", VA = "0x7BBC58E21C", Slot = "11")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000852 RID: 2130
			// (get) Token: 0x06004B9C RID: 19356 RVA: 0x00016B00 File Offset: 0x00014D00
			[Token(Token = "0x17000852")]
			public override int Env
			{
				[Token(Token = "0x6004B9C")]
				[Address(RVA = "0x1D8E224", Offset = "0x1D8E224", VA = "0x7BBC58E224", Slot = "8")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06004B9D RID: 19357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B9D")]
			[Address(RVA = "0x1D8E2B8", Offset = "0x1D8E2B8", VA = "0x7BBC58E2B8", Slot = "5")]
			public override void LogVerbose(string log)
			{
			}

			// Token: 0x06004B9E RID: 19358 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B9E")]
			[Address(RVA = "0x1D8E350", Offset = "0x1D8E350", VA = "0x7BBC58E350", Slot = "4")]
			public override void Log(string log)
			{
			}

			// Token: 0x06004B9F RID: 19359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B9F")]
			[Address(RVA = "0x1D8E3B8", Offset = "0x1D8E3B8", VA = "0x7BBC58E3B8", Slot = "6")]
			public override void LogError(string log)
			{
			}

			// Token: 0x06004BA0 RID: 19360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BA0")]
			[Address(RVA = "0x1D8E420", Offset = "0x1D8E420", VA = "0x7BBC58E420", Slot = "12")]
			public override void OnGetGoogleAccessToken(string token)
			{
			}

			// Token: 0x06004BA1 RID: 19361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BA1")]
			[Address(RVA = "0x1D8E494", Offset = "0x1D8E494", VA = "0x7BBC58E494", Slot = "13")]
			public override void OnGoogleSignIn()
			{
			}

			// Token: 0x06004BA2 RID: 19362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BA2")]
			[Address(RVA = "0x1D8E4EC", Offset = "0x1D8E4EC", VA = "0x7BBC58E4EC", Slot = "15")]
			public override void OnRefreshAuthToken(string accountName)
			{
			}

			// Token: 0x06004BA3 RID: 19363 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BA3")]
			[Address(RVA = "0x1D8E560", Offset = "0x1D8E560", VA = "0x7BBC58E560", Slot = "16")]
			public override void OnRefreshAuthTokenError(GoogleEngagementRewards.RefreshTokenError error, string msg)
			{
			}

			// Token: 0x06004BA4 RID: 19364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BA4")]
			[Address(RVA = "0x1D8E748", Offset = "0x1D8E748", VA = "0x7BBC58E748", Slot = "14")]
			public override void OnGoogleRevoke()
			{
			}

			// Token: 0x06004BA5 RID: 19365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BA5")]
			[Address(RVA = "0x1D8E7A0", Offset = "0x1D8E7A0", VA = "0x7BBC58E7A0", Slot = "17")]
			public override void OnGetAvailablePromotionsSuccess(GoogleEngagementRewards.PromotionsResult result)
			{
			}

			// Token: 0x06004BA6 RID: 19366 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BA6")]
			[Address(RVA = "0x1D8E824", Offset = "0x1D8E824", VA = "0x7BBC58E824", Slot = "18")]
			public override void OnGetAvailablePromotionsFailure(GoogleEngagementRewards.PromotionsResult result)
			{
			}

			// Token: 0x06004BA7 RID: 19367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BA7")]
			[Address(RVA = "0x1D8E8A8", Offset = "0x1D8E8A8", VA = "0x7BBC58E8A8", Slot = "19")]
			public override void OnRedeemPromotionSuccess(GoogleEngagementRewards.Reward reward)
			{
			}

			// Token: 0x06004BA8 RID: 19368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BA8")]
			[Address(RVA = "0x1D8E92C", Offset = "0x1D8E92C", VA = "0x7BBC58E92C", Slot = "20")]
			public override void OnRedeemPromotionFailure(GoogleEngagementRewards.ThrowableJSON throwable)
			{
			}

			// Token: 0x06004BA9 RID: 19369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BA9")]
			[Address(RVA = "0x1D8E9B0", Offset = "0x1D8E9B0", VA = "0x7BBC58E9B0", Slot = "21")]
			public override void OnGetRewardSuccess(GoogleEngagementRewards.Reward reward)
			{
			}

			// Token: 0x06004BAA RID: 19370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BAA")]
			[Address(RVA = "0x1D8EA34", Offset = "0x1D8EA34", VA = "0x7BBC58EA34", Slot = "22")]
			public override void OnGetRewardFailure(GoogleEngagementRewards.ThrowableJSON throwable)
			{
			}

			// Token: 0x06004BAB RID: 19371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BAB")]
			[Address(RVA = "0x1D8EAB8", Offset = "0x1D8EAB8", VA = "0x7BBC58EAB8", Slot = "23")]
			public override void RetriedPendingRedeemPromotions()
			{
			}

			// Token: 0x06004BAC RID: 19372 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004BAC")]
			[Address(RVA = "0x1D8DE8C", Offset = "0x1D8DE8C", VA = "0x7BBC58DE8C")]
			public GERDelegate()
			{
			}

			// Token: 0x0400739F RID: 29599
			[Token(Token = "0x400739F")]
			private const string API_KEY = "AIzaSyBZnUZF66hhNseGbNt6xhJLo7qhHmc_Ofk";
		}
	}
}
