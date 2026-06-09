using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02002009 RID: 8201
	[Token(Token = "0x2002009")]
	internal class UIModelStoreBox : UIBaseModel
	{
		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x0600B683 RID: 46723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8E")]
		public SortedDictionary<uint, List<BundleShowData>> StoreBundleDict
		{
			[Token(Token = "0x600B683")]
			[Address(RVA = "0x2303AA0", Offset = "0x2303AA0", VA = "0x7BBCB03AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x0600B684 RID: 46724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8F")]
		public SortedDictionary<uint, List<OptionalBundleShowData>> StoreOptionalBundleDict
		{
			[Token(Token = "0x600B684")]
			[Address(RVA = "0x2303AD4", Offset = "0x2303AD4", VA = "0x7BBCB03AD4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x0600B685 RID: 46725 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B686 RID: 46726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C90")]
		public SortedDictionary<uint, List<TreasureBoxShowData>> StoreTreasureBoxDict
		{
			[Token(Token = "0x600B685")]
			[Address(RVA = "0x2303B08", Offset = "0x2303B08", VA = "0x7BBCB03B08")]
			get
			{
				return null;
			}
			[Token(Token = "0x600B686")]
			[Address(RVA = "0x2303B10", Offset = "0x2303B10", VA = "0x7BBCB03B10")]
			set
			{
			}
		}

		// Token: 0x0600B687 RID: 46727 RVA: 0x000340E0 File Offset: 0x000322E0
		[Token(Token = "0x600B687")]
		[Address(RVA = "0x2303B18", Offset = "0x2303B18", VA = "0x7BBCB03B18", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B688 RID: 46728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B688")]
		[Address(RVA = "0x2303B20", Offset = "0x2303B20", VA = "0x7BBCB03B20")]
		public void CSGetTreasureBoxRes(uint httpOp = 0U)
		{
		}

		// Token: 0x0600B689 RID: 46729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B689")]
		[Address(RVA = "0x2303CA0", Offset = "0x2303CA0", VA = "0x7BBCB03CA0")]
		public void ProcessTreasureBox(CSGetTreasureBoxRes treasureBoxRes)
		{
		}

		// Token: 0x0600B68A RID: 46730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B68A")]
		[Address(RVA = "0x2304230", Offset = "0x2304230", VA = "0x7BBCB04230")]
		public void GetBundleRes(uint httpOp = 0U)
		{
		}

		// Token: 0x0600B68B RID: 46731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B68B")]
		[Address(RVA = "0x23043B0", Offset = "0x23043B0", VA = "0x7BBCB043B0")]
		public void ProcessBundle(CSGetBundleRes bundleRes)
		{
		}

		// Token: 0x0600B68C RID: 46732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B68C")]
		[Address(RVA = "0x230462C", Offset = "0x230462C", VA = "0x7BBCB0462C")]
		public void ProcessOptionalBundle(CSGetOptionalBundleRes optionalBundleRes)
		{
		}

		// Token: 0x0600B68D RID: 46733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B68D")]
		[Address(RVA = "0x2304880", Offset = "0x2304880", VA = "0x7BBCB04880")]
		public void ProcessLocalBundle(List<BundleData> bundleData)
		{
		}

		// Token: 0x0600B68E RID: 46734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B68E")]
		[Address(RVA = "0x2304CA4", Offset = "0x2304CA4", VA = "0x7BBCB04CA4")]
		public void ProcessLocalOptionalBundle(List<OptionalBundleData> optionalbundleData)
		{
		}

		// Token: 0x0600B68F RID: 46735 RVA: 0x000340F8 File Offset: 0x000322F8
		[Token(Token = "0x600B68F")]
		[Address(RVA = "0x230511C", Offset = "0x230511C", VA = "0x7BBCB0511C")]
		public bool CheckHasInstallmentItemInBundle(uint bundleID)
		{
			return default(bool);
		}

		// Token: 0x0600B690 RID: 46736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B690")]
		[Address(RVA = "0x2305324", Offset = "0x2305324", VA = "0x7BBCB05324")]
		public List<TreasureBoxShowData> GetTreasureBoxShowDataByID(uint boxID)
		{
			return null;
		}

		// Token: 0x0600B691 RID: 46737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B691")]
		[Address(RVA = "0x23053A4", Offset = "0x23053A4", VA = "0x7BBCB053A4", Slot = "12")]
		protected override void OnSceneChange(params object[] data)
		{
		}

		// Token: 0x0600B692 RID: 46738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B692")]
		[Address(RVA = "0x2305A48", Offset = "0x2305A48", VA = "0x7BBCB05A48")]
		public UIModelStoreBox()
		{
		}

		// Token: 0x0600B693 RID: 46739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B693")]
		[Address(RVA = "0x2305C40", Offset = "0x2305C40", VA = "0x7BBCB05C40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11475EC", Offset = "0x11475EC")]
		private void <CSGetTreasureBoxRes>b__15_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B694 RID: 46740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B694")]
		[Address(RVA = "0x2305D28", Offset = "0x2305D28", VA = "0x7BBCB05D28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11475FC", Offset = "0x11475FC")]
		private void <GetBundleRes>b__17_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B8A6 RID: 47270
		[Token(Token = "0x400B8A6")]
		public const uint PropID_GotTreasureBoxRes = 2U;

		// Token: 0x0400B8A7 RID: 47271
		[Token(Token = "0x400B8A7")]
		public const uint PropID_GotBundleRes = 4U;

		// Token: 0x0400B8A8 RID: 47272
		[Token(Token = "0x400B8A8")]
		[FieldOffset(Offset = "0x18")]
		private UIModelStoreBox.StoreBundleData m_StoreBundleData;

		// Token: 0x0400B8A9 RID: 47273
		[Token(Token = "0x400B8A9")]
		[FieldOffset(Offset = "0x20")]
		private UIModelStoreBox.StoreOptionalBundleData m_StoreOptionalBundleData;

		// Token: 0x0400B8AA RID: 47274
		[Token(Token = "0x400B8AA")]
		[FieldOffset(Offset = "0x28")]
		private SortedDictionary<uint, List<TreasureBoxShowData>> m_StoreTreasureBoxDict;

		// Token: 0x0200200A RID: 8202
		[Token(Token = "0x200200A")]
		private class StoreBundleData
		{
			// Token: 0x0600B695 RID: 46741 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B695")]
			[Address(RVA = "0x2305608", Offset = "0x2305608", VA = "0x7BBCB05608")]
			public void LoadFromServerData()
			{
			}

			// Token: 0x0600B696 RID: 46742 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B696")]
			[Address(RVA = "0x2305988", Offset = "0x2305988", VA = "0x7BBCB05988")]
			public void UnloadData()
			{
			}

			// Token: 0x0600B697 RID: 46743 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B697")]
			[Address(RVA = "0x2304B44", Offset = "0x2304B44", VA = "0x7BBCB04B44")]
			public void AddLocalBundle(uint dataID, BundleShowData data)
			{
			}

			// Token: 0x0600B698 RID: 46744 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B698")]
			[Address(RVA = "0x230454C", Offset = "0x230454C", VA = "0x7BBCB0454C")]
			public void AddServerBundle(BundleShow bundle_show)
			{
			}

			// Token: 0x0600B699 RID: 46745 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B699")]
			[Address(RVA = "0x2303ACC", Offset = "0x2303ACC", VA = "0x7BBCB03ACC")]
			public SortedDictionary<uint, List<BundleShowData>> GetStoreBundleDic()
			{
				return null;
			}

			// Token: 0x0600B69A RID: 46746 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B69A")]
			[Address(RVA = "0x2305B10", Offset = "0x2305B10", VA = "0x7BBCB05B10")]
			public StoreBundleData()
			{
			}

			// Token: 0x0400B8AB RID: 47275
			[Token(Token = "0x400B8AB")]
			[FieldOffset(Offset = "0x10")]
			private SortedDictionary<uint, List<BundleShowData>> m_StoreBundleDic;

			// Token: 0x0400B8AC RID: 47276
			[Token(Token = "0x400B8AC")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<uint, List<BundleShowData>> m_ServerBundleDic;
		}

		// Token: 0x0200200B RID: 8203
		[Token(Token = "0x200200B")]
		private class StoreOptionalBundleData
		{
			// Token: 0x0600B69B RID: 46747 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B69B")]
			[Address(RVA = "0x23057C8", Offset = "0x23057C8", VA = "0x7BBCB057C8")]
			public void LoadFromServerData()
			{
			}

			// Token: 0x0600B69C RID: 46748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B69C")]
			[Address(RVA = "0x23059E8", Offset = "0x23059E8", VA = "0x7BBCB059E8")]
			public void UnloadData()
			{
			}

			// Token: 0x0600B69D RID: 46749 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B69D")]
			[Address(RVA = "0x2304FBC", Offset = "0x2304FBC", VA = "0x7BBCB04FBC")]
			public void AddLocalOptionalBundle(uint dataID, OptionalBundleShowData data)
			{
			}

			// Token: 0x0600B69E RID: 46750 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B69E")]
			[Address(RVA = "0x23047A0", Offset = "0x23047A0", VA = "0x7BBCB047A0")]
			public void AddServerOptionalBundle(OptionalBundleShow bundle_show)
			{
			}

			// Token: 0x0600B69F RID: 46751 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B69F")]
			[Address(RVA = "0x2303B00", Offset = "0x2303B00", VA = "0x7BBCB03B00")]
			public SortedDictionary<uint, List<OptionalBundleShowData>> GetStoreOptionalBundleDic()
			{
				return null;
			}

			// Token: 0x0600B6A0 RID: 46752 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B6A0")]
			[Address(RVA = "0x2305BA8", Offset = "0x2305BA8", VA = "0x7BBCB05BA8")]
			public StoreOptionalBundleData()
			{
			}

			// Token: 0x0400B8AD RID: 47277
			[Token(Token = "0x400B8AD")]
			[FieldOffset(Offset = "0x10")]
			private SortedDictionary<uint, List<OptionalBundleShowData>> m_StoreOptionalBundleDic;

			// Token: 0x0400B8AE RID: 47278
			[Token(Token = "0x400B8AE")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<uint, List<OptionalBundleShowData>> m_ServerOptionalBundleDic;
		}
	}
}
