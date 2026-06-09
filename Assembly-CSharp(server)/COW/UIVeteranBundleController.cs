using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BC6 RID: 7110
	[Token(Token = "0x2001BC6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAD74", Offset = "0x10FAD74")]
	public class UIVeteranBundleController : UIBaseController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x060099BA RID: 39354 RVA: 0x00028770 File Offset: 0x00026970
		[Token(Token = "0x60099BA")]
		[Address(RVA = "0x1A09EBC", Offset = "0x1A09EBC", VA = "0x7BBC209EBC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060099BB RID: 39355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099BB")]
		[Address(RVA = "0x1A09F0C", Offset = "0x1A09F0C", VA = "0x7BBC209F0C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060099BC RID: 39356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099BC")]
		[Address(RVA = "0x1A0A9AC", Offset = "0x1A0A9AC", VA = "0x7BBC20A9AC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060099BD RID: 39357 RVA: 0x00028788 File Offset: 0x00026988
		[Token(Token = "0x60099BD")]
		[Address(RVA = "0x1A0A9F0", Offset = "0x1A0A9F0", VA = "0x7BBC20A9F0", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060099BE RID: 39358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099BE")]
		[Address(RVA = "0x1A0AA34", Offset = "0x1A0AA34", VA = "0x7BBC20AA34", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060099BF RID: 39359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099BF")]
		[Address(RVA = "0x1A0B1E0", Offset = "0x1A0B1E0", VA = "0x7BBC20B1E0")]
		private void OnClickOperation()
		{
		}

		// Token: 0x060099C0 RID: 39360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099C0")]
		[Address(RVA = "0x1A0ABE8", Offset = "0x1A0ABE8", VA = "0x7BBC20ABE8")]
		private void UpdatePrice(IAPBundleStoreData data)
		{
		}

		// Token: 0x060099C1 RID: 39361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099C1")]
		[Address(RVA = "0x1A0A0A4", Offset = "0x1A0A0A4", VA = "0x7BBC20A0A4")]
		private void UpdateView()
		{
		}

		// Token: 0x060099C2 RID: 39362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60099C2")]
		[Address(RVA = "0x1A0B278", Offset = "0x1A0B278", VA = "0x7BBC20B278", Slot = "30")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060099C3 RID: 39363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099C3")]
		[Address(RVA = "0x1A0B30C", Offset = "0x1A0B30C", VA = "0x7BBC20B30C", Slot = "31")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060099C4 RID: 39364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099C4")]
		[Address(RVA = "0x1A0A770", Offset = "0x1A0A770", VA = "0x7BBC20A770")]
		private void UpdateClaimState()
		{
		}

		// Token: 0x060099C5 RID: 39365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099C5")]
		[Address(RVA = "0x1A0B33C", Offset = "0x1A0B33C", VA = "0x7BBC20B33C")]
		public UIVeteranBundleController()
		{
		}

		// Token: 0x060099C6 RID: 39366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099C6")]
		[Address(RVA = "0x1A0B344", Offset = "0x1A0B344", VA = "0x7BBC20B344")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144F68", Offset = "0x1144F68")]
		private void <UpdateView>b__9_1(Texture texture)
		{
		}

		// Token: 0x0400A0E2 RID: 41186
		[Token(Token = "0x400A0E2")]
		[FieldOffset(Offset = "0x58")]
		private UIModelVeteranBundle m_IAPBundleModel;

		// Token: 0x0400A0E3 RID: 41187
		[Token(Token = "0x400A0E3")]
		[FieldOffset(Offset = "0x60")]
		private UIVeteranBundleView m_View;

		// Token: 0x02001BC7 RID: 7111
		[Token(Token = "0x2001BC7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FADAC", Offset = "0x10FADAC")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x060099C7 RID: 39367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60099C7")]
			[Address(RVA = "0x1A0B270", Offset = "0x1A0B270", VA = "0x7BBC20B270")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x060099C8 RID: 39368 RVA: 0x000287A0 File Offset: 0x000269A0
			[Token(Token = "0x60099C8")]
			[Address(RVA = "0x1A0B524", Offset = "0x1A0B524", VA = "0x7BBC20B524")]
			internal bool <UpdateView>b__2(AdvertDesc temp)
			{
				return default(bool);
			}

			// Token: 0x0400A0E4 RID: 41188
			[Token(Token = "0x400A0E4")]
			[FieldOffset(Offset = "0x10")]
			public VeteranBigPrizeDesc desc;
		}

		// Token: 0x02001BC8 RID: 7112
		[Token(Token = "0x2001BC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FADBC", Offset = "0x10FADBC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060099CA RID: 39370 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60099CA")]
			[Address(RVA = "0x1A0B4B0", Offset = "0x1A0B4B0", VA = "0x7BBC20B4B0")]
			public <>c()
			{
			}

			// Token: 0x060099CB RID: 39371 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60099CB")]
			[Address(RVA = "0x1A0B4B8", Offset = "0x1A0B4B8", VA = "0x7BBC20B4B8")]
			internal string <UpdateView>b__9_0(KeyValuePair<uint, List<BundleShowData>> p)
			{
				return null;
			}

			// Token: 0x0400A0E5 RID: 41189
			[Token(Token = "0x400A0E5")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIVeteranBundleController.<>c <>9;

			// Token: 0x0400A0E6 RID: 41190
			[Token(Token = "0x400A0E6")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<KeyValuePair<uint, List<BundleShowData>>, string> <>9__9_0;
		}
	}
}
