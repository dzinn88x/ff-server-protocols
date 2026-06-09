using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001ECD RID: 7885
	[Token(Token = "0x2001ECD")]
	public class UIModelIAPBundle : UIBaseModel
	{
		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x0600ACFB RID: 44283 RVA: 0x0002FCB8 File Offset: 0x0002DEB8
		// (set) Token: 0x0600ACFC RID: 44284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B6B")]
		public UIModelIAPBundle.State CurrentState
		{
			[Token(Token = "0x600ACFB")]
			[Address(RVA = "0x236AF5C", Offset = "0x236AF5C", VA = "0x7BBCB6AF5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114643C", Offset = "0x114643C")]
			get
			{
				return UIModelIAPBundle.State.NotLoaded;
			}
			[Token(Token = "0x600ACFC")]
			[Address(RVA = "0x236AF64", Offset = "0x236AF64", VA = "0x7BBCB6AF64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114644C", Offset = "0x114644C")]
			private set
			{
			}
		}

		// Token: 0x0600ACFD RID: 44285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACFD")]
		[Address(RVA = "0x236AF6C", Offset = "0x236AF6C", VA = "0x7BBCB6AF6C", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600ACFE RID: 44286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACFE")]
		[Address(RVA = "0x236B5B4", Offset = "0x236B5B4", VA = "0x7BBCB6B5B4", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600ACFF RID: 44287 RVA: 0x0002FCD0 File Offset: 0x0002DED0
		[Token(Token = "0x600ACFF")]
		[Address(RVA = "0x236B62C", Offset = "0x236B62C", VA = "0x7BBCB6B62C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600AD00 RID: 44288 RVA: 0x0002FCE8 File Offset: 0x0002DEE8
		[Token(Token = "0x600AD00")]
		[Address(RVA = "0x236B4E8", Offset = "0x236B4E8", VA = "0x7BBCB6B4E8")]
		public bool AllPurchasable()
		{
			return default(bool);
		}

		// Token: 0x0600AD01 RID: 44289 RVA: 0x0002FD00 File Offset: 0x0002DF00
		[Token(Token = "0x600AD01")]
		[Address(RVA = "0x236B634", Offset = "0x236B634", VA = "0x7BBCB6B634")]
		public EStoreType GetCurBundleStoreType()
		{
			return EStoreType.None;
		}

		// Token: 0x0600AD02 RID: 44290 RVA: 0x0002FD18 File Offset: 0x0002DF18
		[Token(Token = "0x600AD02")]
		[Address(RVA = "0x236B714", Offset = "0x236B714", VA = "0x7BBCB6B714")]
		public bool IsVisible()
		{
			return default(bool);
		}

		// Token: 0x0600AD03 RID: 44291 RVA: 0x0002FD30 File Offset: 0x0002DF30
		[Token(Token = "0x600AD03")]
		[Address(RVA = "0x236B908", Offset = "0x236B908", VA = "0x7BBCB6B908")]
		public bool IsPurchasable()
		{
			return default(bool);
		}

		// Token: 0x0600AD04 RID: 44292 RVA: 0x0002FD48 File Offset: 0x0002DF48
		[Token(Token = "0x600AD04")]
		[Address(RVA = "0x236B900", Offset = "0x236B900", VA = "0x7BBCB6B900")]
		public int CurrentIAPBundleStoreID()
		{
			return 0;
		}

		// Token: 0x0600AD05 RID: 44293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD05")]
		[Address(RVA = "0x236B658", Offset = "0x236B658", VA = "0x7BBCB6B658")]
		public IAPBundleStoreData CurrentIAPBundleStore()
		{
			return null;
		}

		// Token: 0x0600AD06 RID: 44294 RVA: 0x0002FD60 File Offset: 0x0002DF60
		[Token(Token = "0x600AD06")]
		[Address(RVA = "0x236B9A4", Offset = "0x236B9A4", VA = "0x7BBCB6B9A4")]
		public ulong PurchaseEnd_S()
		{
			return 0UL;
		}

		// Token: 0x0600AD07 RID: 44295 RVA: 0x0002FD78 File Offset: 0x0002DF78
		[Token(Token = "0x600AD07")]
		[Address(RVA = "0x236B9D4", Offset = "0x236B9D4", VA = "0x7BBCB6B9D4")]
		public ulong EndTime_S()
		{
			return 0UL;
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x0600AD08 RID: 44296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B6C")]
		public string Slogan
		{
			[Token(Token = "0x600AD08")]
			[Address(RVA = "0x236B9DC", Offset = "0x236B9DC", VA = "0x7BBCB6B9DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AD09 RID: 44297 RVA: 0x0002FD90 File Offset: 0x0002DF90
		[Token(Token = "0x600AD09")]
		[Address(RVA = "0x236B9E4", Offset = "0x236B9E4", VA = "0x7BBCB6B9E4")]
		public int PurchaseCountdown_S()
		{
			return 0;
		}

		// Token: 0x0600AD0A RID: 44298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD0A")]
		[Address(RVA = "0x236BA68", Offset = "0x236BA68", VA = "0x7BBCB6BA68")]
		public void OnDeepLinked()
		{
		}

		// Token: 0x0600AD0B RID: 44299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD0B")]
		[Address(RVA = "0x236BA94", Offset = "0x236BA94", VA = "0x7BBCB6BA94")]
		public void GotoState(UIModelIAPBundle.State next)
		{
		}

		// Token: 0x0600AD0C RID: 44300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD0C")]
		[Address(RVA = "0x236C018", Offset = "0x236C018", VA = "0x7BBCB6C018")]
		public void FakeTrigger()
		{
		}

		// Token: 0x0600AD0D RID: 44301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD0D")]
		[Address(RVA = "0x236C3F0", Offset = "0x236C3F0", VA = "0x7BBCB6C3F0")]
		public void Purchase([Optional] IAPBundleStoreData data)
		{
		}

		// Token: 0x0600AD0E RID: 44302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD0E")]
		[Address(RVA = "0x236C9E0", Offset = "0x236C9E0", VA = "0x7BBCB6C9E0")]
		private void OnPurchased(bool success, string productIdentifier, int rebateId)
		{
		}

		// Token: 0x0600AD0F RID: 44303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD0F")]
		[Address(RVA = "0x236D344", Offset = "0x236D344", VA = "0x7BBCB6D344")]
		public void RequestIAPBundle()
		{
		}

		// Token: 0x0600AD10 RID: 44304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD10")]
		[Address(RVA = "0x236D5D4", Offset = "0x236D5D4", VA = "0x7BBCB6D5D4")]
		private void OnIAPBundleResponse(HttpErrorCode errorCode, object response)
		{
		}

		// Token: 0x0600AD11 RID: 44305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD11")]
		[Address(RVA = "0x236D028", Offset = "0x236D028", VA = "0x7BBCB6D028")]
		public void RequestPurchase()
		{
		}

		// Token: 0x0600AD12 RID: 44306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD12")]
		[Address(RVA = "0x236DF2C", Offset = "0x236DF2C", VA = "0x7BBCB6DF2C")]
		public void RequestDiamondPurchase(IAPBundleStoreData data)
		{
		}

		// Token: 0x0600AD13 RID: 44307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD13")]
		[Address(RVA = "0x236E230", Offset = "0x236E230", VA = "0x7BBCB6E230")]
		private void OnPurchaseResponse(HttpErrorCode errorCode, object response)
		{
		}

		// Token: 0x0600AD14 RID: 44308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD14")]
		[Address(RVA = "0x236E41C", Offset = "0x236E41C", VA = "0x7BBCB6E41C")]
		public void OnReceivedPurchasedBundle(CSIAPPurchaseRes response)
		{
		}

		// Token: 0x0600AD15 RID: 44309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AD15")]
		[Address(RVA = "0x236E79C", Offset = "0x236E79C", VA = "0x7BBCB6E79C")]
		public string GetNotifyText()
		{
			return null;
		}

		// Token: 0x0600AD16 RID: 44310 RVA: 0x0002FDA8 File Offset: 0x0002DFA8
		[Token(Token = "0x600AD16")]
		[Address(RVA = "0x236BEF4", Offset = "0x236BEF4", VA = "0x7BBCB6BEF4")]
		public bool GetIsFirstTime()
		{
			return default(bool);
		}

		// Token: 0x0600AD17 RID: 44311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD17")]
		[Address(RVA = "0x236EA98", Offset = "0x236EA98", VA = "0x7BBCB6EA98")]
		public void SetIsFirstTime(bool isFirstTime)
		{
		}

		// Token: 0x0600AD18 RID: 44312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD18")]
		[Address(RVA = "0x236EB68", Offset = "0x236EB68", VA = "0x7BBCB6EB68")]
		public UIModelIAPBundle()
		{
		}

		// Token: 0x0600AD19 RID: 44313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD19")]
		[Address(RVA = "0x236EBE0", Offset = "0x236EBE0", VA = "0x7BBCB6EBE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114645C", Offset = "0x114645C")]
		private void <RequestDiamondPurchase>b__41_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B168 RID: 45416
		[Token(Token = "0x400B168")]
		public const uint PropID_Available = 2U;

		// Token: 0x0400B169 RID: 45417
		[Token(Token = "0x400B169")]
		public const uint PropID_Unavailable = 4U;

		// Token: 0x0400B16A RID: 45418
		[Token(Token = "0x400B16A")]
		public const uint PropID_IAPResult = 8U;

		// Token: 0x0400B16B RID: 45419
		[Token(Token = "0x400B16B")]
		public const uint PropID_GotBundle = 16U;

		// Token: 0x0400B16C RID: 45420
		[Token(Token = "0x400B16C")]
		public const uint PropID_Pending = 32U;

		// Token: 0x0400B16D RID: 45421
		[Token(Token = "0x400B16D")]
		public const uint PropID_DiamondExchanging = 64U;

		// Token: 0x0400B16E RID: 45422
		[Token(Token = "0x400B16E")]
		public const uint PropID_DiamondPurchaseFail = 128U;

		// Token: 0x0400B16F RID: 45423
		[Token(Token = "0x400B16F")]
		public const uint PropID_ProductUpdate = 256U;

		// Token: 0x0400B170 RID: 45424
		[Token(Token = "0x400B170")]
		public const uint PropID_DiamondGotBundle = 512U;

		// Token: 0x0400B171 RID: 45425
		[Token(Token = "0x400B171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_CurrentStoreID;

		// Token: 0x0400B172 RID: 45426
		[Token(Token = "0x400B172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ulong m_EndTime_S;

		// Token: 0x0400B173 RID: 45427
		[Token(Token = "0x400B173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string m_Slogan;

		// Token: 0x0400B174 RID: 45428
		[Token(Token = "0x400B174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113008C", Offset = "0x113008C")]
		private UIModelIAPBundle.State <CurrentState>k__BackingField;

		// Token: 0x0400B175 RID: 45429
		[Token(Token = "0x400B175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_DeepLink;

		// Token: 0x0400B176 RID: 45430
		[Token(Token = "0x400B176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IAPBundleStoreData _PendingIAPBundle;

		// Token: 0x0400B177 RID: 45431
		[Token(Token = "0x400B177")]
		private const string PLAYER_PREFS_KEY_IAP_BUNDLE = "IAPBundleEndTime";

		// Token: 0x02001ECE RID: 7886
		[Token(Token = "0x2001ECE")]
		public enum State
		{
			// Token: 0x0400B179 RID: 45433
			[Token(Token = "0x400B179")]
			NotLoaded,
			// Token: 0x0400B17A RID: 45434
			[Token(Token = "0x400B17A")]
			Loading,
			// Token: 0x0400B17B RID: 45435
			[Token(Token = "0x400B17B")]
			Purchasable,
			// Token: 0x0400B17C RID: 45436
			[Token(Token = "0x400B17C")]
			NotPurchasable,
			// Token: 0x0400B17D RID: 45437
			[Token(Token = "0x400B17D")]
			Paying,
			// Token: 0x0400B17E RID: 45438
			[Token(Token = "0x400B17E")]
			Exchanging,
			// Token: 0x0400B17F RID: 45439
			[Token(Token = "0x400B17F")]
			Pending,
			// Token: 0x0400B180 RID: 45440
			[Token(Token = "0x400B180")]
			DiamondExchanging
		}

		// Token: 0x02001ECF RID: 7887
		[Token(Token = "0x2001ECF")]
		private class IAPBundlesDelegate : PayUtility.PaymentDelegate
		{
			// Token: 0x17000B6D RID: 2925
			// (get) Token: 0x0600AD1A RID: 44314 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000B6D")]
			public static UIModelIAPBundle.IAPBundlesDelegate I
			{
				[Token(Token = "0x600AD1A")]
				[Address(RVA = "0x236B468", Offset = "0x236B468", VA = "0x7BBCB6B468")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B6E RID: 2926
			// (get) Token: 0x0600AD1B RID: 44315 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000B6E")]
			public override string Name
			{
				[Token(Token = "0x600AD1B")]
				[Address(RVA = "0x236ED10", Offset = "0x236ED10", VA = "0x7BBCB6ED10", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600AD1C RID: 44316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AD1C")]
			[Address(RVA = "0x236ED58", Offset = "0x236ED58", VA = "0x7BBCB6ED58", Slot = "9")]
			public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
			{
			}

			// Token: 0x0600AD1D RID: 44317 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AD1D")]
			[Address(RVA = "0x236EE70", Offset = "0x236EE70", VA = "0x7BBCB6EE70", Slot = "11")]
			public override PayUtility.PaymentDelegate.ProductPurchasedReaction OnProductPurchased(string reason, PayUtility.PaymentDelegate.ProductPurchasedResult result, string productIdentifier, long rebateId)
			{
				return null;
			}

			// Token: 0x0600AD1E RID: 44318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AD1E")]
			[Address(RVA = "0x236ED08", Offset = "0x236ED08", VA = "0x7BBCB6ED08")]
			public IAPBundlesDelegate()
			{
			}

			// Token: 0x0400B181 RID: 45441
			[Token(Token = "0x400B181")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static UIModelIAPBundle.IAPBundlesDelegate _I;
		}

		// Token: 0x02001ED0 RID: 7888
		[Token(Token = "0x2001ED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCB84", Offset = "0x10FCB84")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600AD20 RID: 44320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AD20")]
			[Address(RVA = "0x236EC58", Offset = "0x236EC58", VA = "0x7BBCB6EC58")]
			public <>c()
			{
			}

			// Token: 0x0600AD21 RID: 44321 RVA: 0x0002FDC0 File Offset: 0x0002DFC0
			[Token(Token = "0x600AD21")]
			[Address(RVA = "0x236EC60", Offset = "0x236EC60", VA = "0x7BBCB6EC60")]
			internal bool <OnIAPBundleResponse>b__39_0(IAPInfoItem temp)
			{
				return default(bool);
			}

			// Token: 0x0600AD22 RID: 44322 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AD22")]
			[Address(RVA = "0x236EC94", Offset = "0x236EC94", VA = "0x7BBCB6EC94")]
			internal BaseItemInfo <OnReceivedPurchasedBundle>b__43_0(AwardDesc reward)
			{
				return null;
			}

			// Token: 0x0600AD23 RID: 44323 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AD23")]
			[Address(RVA = "0x236ECFC", Offset = "0x236ECFC", VA = "0x7BBCB6ECFC")]
			internal CommonRewardItemInfo <OnReceivedPurchasedBundle>b__43_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0400B182 RID: 45442
			[Token(Token = "0x400B182")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIModelIAPBundle.<>c <>9;

			// Token: 0x0400B183 RID: 45443
			[Token(Token = "0x400B183")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<IAPInfoItem> <>9__39_0;

			// Token: 0x0400B184 RID: 45444
			[Token(Token = "0x400B184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Converter<AwardDesc, BaseItemInfo> <>9__43_0;

			// Token: 0x0400B185 RID: 45445
			[Token(Token = "0x400B185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__43_1;
		}
	}
}
