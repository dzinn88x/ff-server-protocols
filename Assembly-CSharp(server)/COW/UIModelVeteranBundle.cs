using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02002020 RID: 8224
	[Token(Token = "0x2002020")]
	public class UIModelVeteranBundle : UIBaseModel
	{
		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x0600B755 RID: 46933 RVA: 0x000345C0 File Offset: 0x000327C0
		// (set) Token: 0x0600B756 RID: 46934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA8")]
		public UIModelVeteranBundle.State CurrentVeteranBundlePurchaseState
		{
			[Token(Token = "0x600B755")]
			[Address(RVA = "0x14BC4B8", Offset = "0x14BC4B8", VA = "0x7BBBCBC4B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114785C", Offset = "0x114785C")]
			get
			{
				return UIModelVeteranBundle.State.NotLoaded;
			}
			[Token(Token = "0x600B756")]
			[Address(RVA = "0x14BC4C0", Offset = "0x14BC4C0", VA = "0x7BBBCBC4C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114786C", Offset = "0x114786C")]
			private set
			{
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x0600B757 RID: 46935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA9")]
		public IAPInfoItem VeteranIAPInfo
		{
			[Token(Token = "0x600B757")]
			[Address(RVA = "0x14BC4C8", Offset = "0x14BC4C8", VA = "0x7BBBCBC4C8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B758 RID: 46936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B758")]
		[Address(RVA = "0x14BC4D0", Offset = "0x14BC4D0", VA = "0x7BBBCBC4D0", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600B759 RID: 46937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B759")]
		[Address(RVA = "0x14BC5E8", Offset = "0x14BC5E8", VA = "0x7BBBCBC5E8", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B75A RID: 46938 RVA: 0x000345D8 File Offset: 0x000327D8
		[Token(Token = "0x600B75A")]
		[Address(RVA = "0x14BC660", Offset = "0x14BC660", VA = "0x7BBBCBC660", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B75B RID: 46939 RVA: 0x000345F0 File Offset: 0x000327F0
		[Token(Token = "0x600B75B")]
		[Address(RVA = "0x14BC668", Offset = "0x14BC668", VA = "0x7BBBCBC668")]
		public bool IsVeteranBundleVisible()
		{
			return default(bool);
		}

		// Token: 0x0600B75C RID: 46940 RVA: 0x00034608 File Offset: 0x00032808
		[Token(Token = "0x600B75C")]
		[Address(RVA = "0x14BC778", Offset = "0x14BC778", VA = "0x7BBBCBC778")]
		public bool IsVeteranBundlePurchasable()
		{
			return default(bool);
		}

		// Token: 0x0600B75D RID: 46941 RVA: 0x00034620 File Offset: 0x00032820
		[Token(Token = "0x600B75D")]
		[Address(RVA = "0x14BC858", Offset = "0x14BC858", VA = "0x7BBBCBC858")]
		public bool CanPurchaseVeteranBundle()
		{
			return default(bool);
		}

		// Token: 0x0600B75E RID: 46942 RVA: 0x00034638 File Offset: 0x00032838
		[Token(Token = "0x600B75E")]
		[Address(RVA = "0x14BC74C", Offset = "0x14BC74C", VA = "0x7BBBCBC74C")]
		public int CurVeteranBundleStoreID()
		{
			return 0;
		}

		// Token: 0x0600B75F RID: 46943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B75F")]
		[Address(RVA = "0x14BC8F8", Offset = "0x14BC8F8", VA = "0x7BBBCBC8F8")]
		public IAPBundleStoreData CurVeteranBundleStore()
		{
			return null;
		}

		// Token: 0x0600B760 RID: 46944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B760")]
		[Address(RVA = "0x14BC9C4", Offset = "0x14BC9C4", VA = "0x7BBBCBC9C4")]
		public void ChangeVeteranBundlePurchaseState(UIModelVeteranBundle.State next)
		{
		}

		// Token: 0x0600B761 RID: 46945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B761")]
		[Address(RVA = "0x14BCC00", Offset = "0x14BCC00", VA = "0x7BBBCBCC00")]
		public void Purchase([Optional] IAPBundleStoreData data)
		{
		}

		// Token: 0x0600B762 RID: 46946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B762")]
		[Address(RVA = "0x14BD220", Offset = "0x14BD220", VA = "0x7BBBCBD220")]
		public void OnPurchased(bool success, string productIdentifier, int rebateId)
		{
		}

		// Token: 0x0600B763 RID: 46947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B763")]
		[Address(RVA = "0x14BDAB8", Offset = "0x14BDAB8", VA = "0x7BBBCBDAB8")]
		public void OnIAPBundleResponse(HttpErrorCode errorCode, CSGetAccountIAPInfoRes response)
		{
		}

		// Token: 0x0600B764 RID: 46948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B764")]
		[Address(RVA = "0x14BD798", Offset = "0x14BD798", VA = "0x7BBBCBD798")]
		public void RequestPurchase()
		{
		}

		// Token: 0x0600B765 RID: 46949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B765")]
		[Address(RVA = "0x14BE140", Offset = "0x14BE140", VA = "0x7BBBCBE140")]
		private void OnPurchaseResponse(HttpErrorCode errorCode, object response)
		{
		}

		// Token: 0x0600B766 RID: 46950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B766")]
		[Address(RVA = "0x14BE334", Offset = "0x14BE334", VA = "0x7BBBCBE334")]
		public UIModelVeteranBundle()
		{
		}

		// Token: 0x0400B977 RID: 47479
		[Token(Token = "0x400B977")]
		public const uint PropID_Available = 2U;

		// Token: 0x0400B978 RID: 47480
		[Token(Token = "0x400B978")]
		public const uint PropID_Unavailable = 4U;

		// Token: 0x0400B979 RID: 47481
		[Token(Token = "0x400B979")]
		public const uint PropID_IAPResult = 8U;

		// Token: 0x0400B97A RID: 47482
		[Token(Token = "0x400B97A")]
		public const uint PropID_GotBundle = 16U;

		// Token: 0x0400B97B RID: 47483
		[Token(Token = "0x400B97B")]
		public const uint PropID_Pending = 32U;

		// Token: 0x0400B97C RID: 47484
		[Token(Token = "0x400B97C")]
		public const uint PropID_ProductUpdate = 64U;

		// Token: 0x0400B97D RID: 47485
		[Token(Token = "0x400B97D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113082C", Offset = "0x113082C")]
		private UIModelVeteranBundle.State <CurrentVeteranBundlePurchaseState>k__BackingField;

		// Token: 0x0400B97E RID: 47486
		[Token(Token = "0x400B97E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IAPInfoItem m_VeteranIAPInfo;

		// Token: 0x0400B97F RID: 47487
		[Token(Token = "0x400B97F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IAPBundleStoreData _PendingIAPBundle;

		// Token: 0x02002021 RID: 8225
		[Token(Token = "0x2002021")]
		public enum State
		{
			// Token: 0x0400B981 RID: 47489
			[Token(Token = "0x400B981")]
			NotLoaded,
			// Token: 0x0400B982 RID: 47490
			[Token(Token = "0x400B982")]
			Loading,
			// Token: 0x0400B983 RID: 47491
			[Token(Token = "0x400B983")]
			Purchasable,
			// Token: 0x0400B984 RID: 47492
			[Token(Token = "0x400B984")]
			NotPurchasable,
			// Token: 0x0400B985 RID: 47493
			[Token(Token = "0x400B985")]
			Paying,
			// Token: 0x0400B986 RID: 47494
			[Token(Token = "0x400B986")]
			Exchanging,
			// Token: 0x0400B987 RID: 47495
			[Token(Token = "0x400B987")]
			Pending
		}

		// Token: 0x02002022 RID: 8226
		[Token(Token = "0x2002022")]
		private class VeteranBundlesDelegate : PayUtility.PaymentDelegate
		{
			// Token: 0x17000CAA RID: 3242
			// (get) Token: 0x0600B767 RID: 46951 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CAA")]
			public static UIModelVeteranBundle.VeteranBundlesDelegate I
			{
				[Token(Token = "0x600B767")]
				[Address(RVA = "0x14BC568", Offset = "0x14BC568", VA = "0x7BBBCBC568")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000CAB RID: 3243
			// (get) Token: 0x0600B768 RID: 46952 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CAB")]
			public override string Name
			{
				[Token(Token = "0x600B768")]
				[Address(RVA = "0x14BE478", Offset = "0x14BE478", VA = "0x7BBBCBE478", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600B769 RID: 46953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B769")]
			[Address(RVA = "0x14BE4C0", Offset = "0x14BE4C0", VA = "0x7BBBCBE4C0", Slot = "9")]
			public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
			{
			}

			// Token: 0x0600B76A RID: 46954 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B76A")]
			[Address(RVA = "0x14BE5D8", Offset = "0x14BE5D8", VA = "0x7BBBCBE5D8", Slot = "11")]
			public override PayUtility.PaymentDelegate.ProductPurchasedReaction OnProductPurchased(string reason, PayUtility.PaymentDelegate.ProductPurchasedResult result, string productIdentifier, long rebateId)
			{
				return null;
			}

			// Token: 0x0600B76B RID: 46955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B76B")]
			[Address(RVA = "0x14BE470", Offset = "0x14BE470", VA = "0x7BBBCBE470")]
			public VeteranBundlesDelegate()
			{
			}

			// Token: 0x0400B988 RID: 47496
			[Token(Token = "0x400B988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static UIModelVeteranBundle.VeteranBundlesDelegate _I;
		}

		// Token: 0x02002023 RID: 8227
		[Token(Token = "0x2002023")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD7F4", Offset = "0x10FD7F4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B76D RID: 46957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B76D")]
			[Address(RVA = "0x14BE434", Offset = "0x14BE434", VA = "0x7BBBCBE434")]
			public <>c()
			{
			}

			// Token: 0x0600B76E RID: 46958 RVA: 0x00034650 File Offset: 0x00032850
			[Token(Token = "0x600B76E")]
			[Address(RVA = "0x14BE43C", Offset = "0x14BE43C", VA = "0x7BBBCBE43C")]
			internal bool <OnIAPBundleResponse>b__26_0(IAPInfoItem temp)
			{
				return default(bool);
			}

			// Token: 0x0400B989 RID: 47497
			[Token(Token = "0x400B989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIModelVeteranBundle.<>c <>9;

			// Token: 0x0400B98A RID: 47498
			[Token(Token = "0x400B98A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<IAPInfoItem> <>9__26_0;
		}
	}
}
