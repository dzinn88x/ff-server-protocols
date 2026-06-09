using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019B1 RID: 6577
	[Token(Token = "0x20019B1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6DE4", Offset = "0x10F6DE4")]
	public class UIIAPBundlePreviewItemController : UIBaseController
	{
		// Token: 0x060086D7 RID: 34519 RVA: 0x00024798 File Offset: 0x00022998
		[Token(Token = "0x60086D7")]
		[Address(RVA = "0x1D290B0", Offset = "0x1D290B0", VA = "0x7BBC5290B0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060086D8 RID: 34520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086D8")]
		[Address(RVA = "0x1D29100", Offset = "0x1D29100", VA = "0x7BBC529100", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060086D9 RID: 34521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086D9")]
		[Address(RVA = "0x1D291E4", Offset = "0x1D291E4", VA = "0x7BBC5291E4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060086DA RID: 34522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086DA")]
		[Address(RVA = "0x1D292B4", Offset = "0x1D292B4", VA = "0x7BBC5292B4")]
		public void SetDragScrollView(UIScrollView scrollView)
		{
		}

		// Token: 0x060086DB RID: 34523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086DB")]
		[Address(RVA = "0x1D293D0", Offset = "0x1D293D0", VA = "0x7BBC5293D0")]
		public void UpdateData(IAPBundleStoreData data)
		{
		}

		// Token: 0x060086DC RID: 34524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086DC")]
		[Address(RVA = "0x1D29830", Offset = "0x1D29830", VA = "0x7BBC529830")]
		public void SetCallback(Action<IAPBundleStoreData> callback)
		{
		}

		// Token: 0x060086DD RID: 34525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086DD")]
		[Address(RVA = "0x1D29838", Offset = "0x1D29838", VA = "0x7BBC529838")]
		private void OnItemClick()
		{
		}

		// Token: 0x060086DE RID: 34526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086DE")]
		[Address(RVA = "0x1D2989C", Offset = "0x1D2989C", VA = "0x7BBC52989C")]
		public UIIAPBundlePreviewItemController()
		{
		}

		// Token: 0x040095B8 RID: 38328
		[Token(Token = "0x40095B8")]
		[FieldOffset(Offset = "0x58")]
		private UIIAPBundlePreviewItemView m_View;

		// Token: 0x040095B9 RID: 38329
		[Token(Token = "0x40095B9")]
		[FieldOffset(Offset = "0x60")]
		private IAPBundleStoreData m_Data;

		// Token: 0x040095BA RID: 38330
		[Token(Token = "0x40095BA")]
		[FieldOffset(Offset = "0x68")]
		private Action<IAPBundleStoreData> m_Callback;
	}
}
