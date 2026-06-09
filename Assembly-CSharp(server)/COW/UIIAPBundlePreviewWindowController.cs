using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019B2 RID: 6578
	[Token(Token = "0x20019B2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6E1C", Offset = "0x10F6E1C")]
	internal class UIIAPBundlePreviewWindowController : UIPopupWindowController
	{
		// Token: 0x060086DF RID: 34527 RVA: 0x000247B0 File Offset: 0x000229B0
		[Token(Token = "0x60086DF")]
		[Address(RVA = "0x1D29A8C", Offset = "0x1D29A8C", VA = "0x7BBC529A8C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060086E0 RID: 34528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086E0")]
		[Address(RVA = "0x1D29ADC", Offset = "0x1D29ADC", VA = "0x7BBC529ADC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060086E1 RID: 34529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086E1")]
		[Address(RVA = "0x1D29C98", Offset = "0x1D29C98", VA = "0x7BBC529C98", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060086E2 RID: 34530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086E2")]
		[Address(RVA = "0x1D29CC0", Offset = "0x1D29CC0", VA = "0x7BBC529CC0")]
		protected void CheckScreenshotOnVisibilityChanged()
		{
		}

		// Token: 0x060086E3 RID: 34531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60086E3")]
		[Address(RVA = "0x1D29D74", Offset = "0x1D29D74", VA = "0x7BBC529D74")]
		private string ScreenshotFilePath(IAPBundleStoreData data)
		{
			return null;
		}

		// Token: 0x060086E4 RID: 34532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086E4")]
		[Address(RVA = "0x1D29B8C", Offset = "0x1D29B8C", VA = "0x7BBC529B8C")]
		private void TakeScreenshots(int index = 0)
		{
		}

		// Token: 0x060086E5 RID: 34533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086E5")]
		[Address(RVA = "0x1D29E94", Offset = "0x1D29E94", VA = "0x7BBC529E94", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x060086E6 RID: 34534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086E6")]
		[Address(RVA = "0x1D29F40", Offset = "0x1D29F40", VA = "0x7BBC529F40", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060086E7 RID: 34535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086E7")]
		[Address(RVA = "0x1D29F48", Offset = "0x1D29F48", VA = "0x7BBC529F48")]
		private void ClearItemControllers()
		{
		}

		// Token: 0x060086E8 RID: 34536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086E8")]
		[Address(RVA = "0x1D2A094", Offset = "0x1D2A094", VA = "0x7BBC52A094")]
		private void UpdateItemControllers()
		{
		}

		// Token: 0x060086E9 RID: 34537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086E9")]
		[Address(RVA = "0x1D2A6D8", Offset = "0x1D2A6D8", VA = "0x7BBC52A6D8")]
		private void OnItemClick(IAPBundleStoreData data)
		{
		}

		// Token: 0x060086EA RID: 34538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086EA")]
		[Address(RVA = "0x1D29B88", Offset = "0x1D29B88", VA = "0x7BBC529B88")]
		private void UpdateData()
		{
		}

		// Token: 0x060086EB RID: 34539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086EB")]
		[Address(RVA = "0x1D2A754", Offset = "0x1D2A754", VA = "0x7BBC52A754")]
		public UIIAPBundlePreviewWindowController()
		{
		}

		// Token: 0x040095BB RID: 38331
		[Token(Token = "0x40095BB")]
		[FieldOffset(Offset = "0x98")]
		private UIIAPBundlePreviewWindowView m_View;

		// Token: 0x040095BC RID: 38332
		[Token(Token = "0x40095BC")]
		[FieldOffset(Offset = "0xA0")]
		private int m_ScreenshotIndex;

		// Token: 0x040095BD RID: 38333
		[Token(Token = "0x40095BD")]
		private const float DELAY_DETAIL = 0.1f;

		// Token: 0x040095BE RID: 38334
		[Token(Token = "0x40095BE")]
		private const float DELAY_SCREENSHOT = 1f;

		// Token: 0x040095BF RID: 38335
		[Token(Token = "0x40095BF")]
		[FieldOffset(Offset = "0xA8")]
		private List<UIIAPBundlePreviewItemController> m_ItemControllers;

		// Token: 0x040095C0 RID: 38336
		[Token(Token = "0x40095C0")]
		[FieldOffset(Offset = "0xB0")]
		private List<IAPBundleStoreData> m_IAPBundles;

		// Token: 0x020019B3 RID: 6579
		[Token(Token = "0x20019B3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F6E54", Offset = "0x10F6E54")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x060086EC RID: 34540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60086EC")]
			[Address(RVA = "0x1D29E8C", Offset = "0x1D29E8C", VA = "0x7BBC529E8C")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x060086ED RID: 34541 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60086ED")]
			[Address(RVA = "0x1D2A938", Offset = "0x1D2A938", VA = "0x7BBC52A938")]
			internal void <TakeScreenshots>b__0()
			{
			}

			// Token: 0x060086EE RID: 34542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60086EE")]
			[Address(RVA = "0x1D2AAD0", Offset = "0x1D2AAD0", VA = "0x7BBC52AAD0")]
			internal void <TakeScreenshots>b__1()
			{
			}

			// Token: 0x040095C1 RID: 38337
			[Token(Token = "0x40095C1")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x040095C2 RID: 38338
			[Token(Token = "0x40095C2")]
			[FieldOffset(Offset = "0x18")]
			public UIIAPBundlePreviewWindowController <>4__this;

			// Token: 0x040095C3 RID: 38339
			[Token(Token = "0x40095C3")]
			[FieldOffset(Offset = "0x20")]
			public Action <>9__1;
		}

		// Token: 0x020019B4 RID: 6580
		[Token(Token = "0x20019B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F6E64", Offset = "0x10F6E64")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060086F0 RID: 34544 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60086F0")]
			[Address(RVA = "0x1D2A858", Offset = "0x1D2A858", VA = "0x7BBC52A858")]
			public <>c()
			{
			}

			// Token: 0x060086F1 RID: 34545 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60086F1")]
			[Address(RVA = "0x1D2A860", Offset = "0x1D2A860", VA = "0x7BBC52A860")]
			internal IAPBundleStoreData <UpdateItemControllers>b__15_0(CSVBaseData d)
			{
				return null;
			}

			// Token: 0x060086F2 RID: 34546 RVA: 0x000247C8 File Offset: 0x000229C8
			[Token(Token = "0x60086F2")]
			[Address(RVA = "0x1D2A8E0", Offset = "0x1D2A8E0", VA = "0x7BBC52A8E0")]
			internal int <UpdateItemControllers>b__15_1(IAPBundleStoreData a, IAPBundleStoreData b)
			{
				return 0;
			}

			// Token: 0x040095C4 RID: 38340
			[Token(Token = "0x40095C4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIIAPBundlePreviewWindowController.<>c <>9;

			// Token: 0x040095C5 RID: 38341
			[Token(Token = "0x40095C5")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<CSVBaseData, IAPBundleStoreData> <>9__15_0;

			// Token: 0x040095C6 RID: 38342
			[Token(Token = "0x40095C6")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<IAPBundleStoreData> <>9__15_1;
		}
	}
}
