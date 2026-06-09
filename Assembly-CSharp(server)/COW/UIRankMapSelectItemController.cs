using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B43 RID: 6979
	[Token(Token = "0x2001B43")]
	public class UIRankMapSelectItemController : UIEasyListItemController, IUIModelDataChangeObserver
	{
		// Token: 0x060095D8 RID: 38360 RVA: 0x000279D8 File Offset: 0x00025BD8
		[Token(Token = "0x60095D8")]
		[Address(RVA = "0x1E0F83C", Offset = "0x1E0F83C", VA = "0x7BBC60F83C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060095D9 RID: 38361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095D9")]
		[Address(RVA = "0x1E0F88C", Offset = "0x1E0F88C", VA = "0x7BBC60F88C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060095DA RID: 38362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095DA")]
		[Address(RVA = "0x1E0FA38", Offset = "0x1E0FA38", VA = "0x7BBC60FA38", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060095DB RID: 38363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095DB")]
		[Address(RVA = "0x1E0FAEC", Offset = "0x1E0FAEC", VA = "0x7BBC60FAEC", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060095DC RID: 38364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095DC")]
		[Address(RVA = "0x1E100D4", Offset = "0x1E100D4", VA = "0x7BBC6100D4", Slot = "34")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060095DD RID: 38365 RVA: 0x000279F0 File Offset: 0x00025BF0
		[Token(Token = "0x60095DD")]
		[Address(RVA = "0x1E10398", Offset = "0x1E10398", VA = "0x7BBC610398", Slot = "35")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060095DE RID: 38366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095DE")]
		[Address(RVA = "0x1E103DC", Offset = "0x1E103DC", VA = "0x7BBC6103DC")]
		private void OnSelectedButtonClick()
		{
		}

		// Token: 0x060095DF RID: 38367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095DF")]
		[Address(RVA = "0x1E105CC", Offset = "0x1E105CC", VA = "0x7BBC6105CC")]
		private void OnItemButtonClick()
		{
		}

		// Token: 0x060095E0 RID: 38368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60095E0")]
		[Address(RVA = "0x1E10AE0", Offset = "0x1E10AE0", VA = "0x7BBC610AE0")]
		public UIRankMapSelectItemController()
		{
		}

		// Token: 0x04009ECF RID: 40655
		[Token(Token = "0x4009ECF")]
		[FieldOffset(Offset = "0x70")]
		private UIRankMapSelectItemView m_View;

		// Token: 0x04009ED0 RID: 40656
		[Token(Token = "0x4009ED0")]
		[FieldOffset(Offset = "0x78")]
		private MapOpeningInfo m_Data;

		// Token: 0x04009ED1 RID: 40657
		[Token(Token = "0x4009ED1")]
		[FieldOffset(Offset = "0x80")]
		private UICommonOptionalDownloaderController m_Downloader;
	}
}
