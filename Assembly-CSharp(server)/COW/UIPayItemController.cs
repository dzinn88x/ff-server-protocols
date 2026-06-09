using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001AAF RID: 6831
	[Token(Token = "0x2001AAF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F88FC", Offset = "0x10F88FC")]
	public class UIPayItemController : UIBaseController
	{
		// Token: 0x0600901B RID: 36891 RVA: 0x00026670 File Offset: 0x00024870
		[Token(Token = "0x600901B")]
		[Address(RVA = "0x16EBB8C", Offset = "0x16EBB8C", VA = "0x7BBBEEBB8C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600901C RID: 36892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600901C")]
		[Address(RVA = "0x16EBBDC", Offset = "0x16EBBDC", VA = "0x7BBBEEBBDC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600901D RID: 36893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600901D")]
		[Address(RVA = "0x16EBD18", Offset = "0x16EBD18", VA = "0x7BBBEEBD18", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600901E RID: 36894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600901E")]
		[Address(RVA = "0x16EBDE0", Offset = "0x16EBDE0", VA = "0x7BBBEEBDE0")]
		public void SetDragScrollView(UIScrollView scrollView)
		{
		}

		// Token: 0x0600901F RID: 36895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600901F")]
		[Address(RVA = "0x16EBE70", Offset = "0x16EBE70", VA = "0x7BBBEEBE70")]
		public void SetData(PayItemData data)
		{
		}

		// Token: 0x06009020 RID: 36896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009020")]
		[Address(RVA = "0x16EC07C", Offset = "0x16EC07C", VA = "0x7BBBEEC07C")]
		private void SetVirtualCurrencyAmount(PayItemData localData, PayItemData remoteData)
		{
		}

		// Token: 0x06009021 RID: 36897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009021")]
		[Address(RVA = "0x16EC340", Offset = "0x16EC340", VA = "0x7BBBEEC340")]
		private void SetCostString(PayItemData localData, PayItemData remoteData)
		{
		}

		// Token: 0x06009022 RID: 36898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009022")]
		[Address(RVA = "0x16EC400", Offset = "0x16EC400", VA = "0x7BBBEEC400")]
		private void ApplyCdnUrlToNetworkTexture(UINetworkTextureExt networkTexture, string url)
		{
		}

		// Token: 0x06009023 RID: 36899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009023")]
		[Address(RVA = "0x16EC444", Offset = "0x16EC444", VA = "0x7BBBEEC444")]
		private void OnButtonClick()
		{
		}

		// Token: 0x06009024 RID: 36900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009024")]
		[Address(RVA = "0x16EC55C", Offset = "0x16EC55C", VA = "0x7BBBEEC55C")]
		public void PlayBounsAnim(int index)
		{
		}

		// Token: 0x06009025 RID: 36901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009025")]
		[Address(RVA = "0x16EC63C", Offset = "0x16EC63C", VA = "0x7BBBEEC63C")]
		private void PlayAnim()
		{
		}

		// Token: 0x06009026 RID: 36902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009026")]
		[Address(RVA = "0x16EBD40", Offset = "0x16EBD40", VA = "0x7BBBEEBD40")]
		private void CancelDelayCall()
		{
		}

		// Token: 0x06009027 RID: 36903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009027")]
		[Address(RVA = "0x16EC6B0", Offset = "0x16EC6B0", VA = "0x7BBBEEC6B0")]
		public UIPayItemController()
		{
		}

		// Token: 0x04009BF5 RID: 39925
		[Token(Token = "0x4009BF5")]
		[FieldOffset(Offset = "0x58")]
		private UIPayItemView m_View;

		// Token: 0x04009BF6 RID: 39926
		[Token(Token = "0x4009BF6")]
		[FieldOffset(Offset = "0x60")]
		private PayItemData m_Data;

		// Token: 0x04009BF7 RID: 39927
		[Token(Token = "0x4009BF7")]
		[FieldOffset(Offset = "0x68")]
		private UIModelPayment m_ModelPayment;

		// Token: 0x04009BF8 RID: 39928
		[Token(Token = "0x4009BF8")]
		[FieldOffset(Offset = "0x70")]
		private uint m_DelayCall;
	}
}
