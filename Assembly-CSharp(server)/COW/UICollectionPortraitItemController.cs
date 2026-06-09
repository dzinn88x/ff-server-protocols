using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200173D RID: 5949
	[Token(Token = "0x200173D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1C74", Offset = "0x10F1C74")]
	internal class UICollectionPortraitItemController : UIEasyListItemController
	{
		// Token: 0x06006FDA RID: 28634 RVA: 0x0001F5C0 File Offset: 0x0001D7C0
		[Token(Token = "0x6006FDA")]
		[Address(RVA = "0x20AAD94", Offset = "0x20AAD94", VA = "0x7BBC8AAD94")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006FDB RID: 28635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FDB")]
		[Address(RVA = "0x20AADE4", Offset = "0x20AADE4", VA = "0x7BBC8AADE4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006FDC RID: 28636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FDC")]
		[Address(RVA = "0x20AB028", Offset = "0x20AB028", VA = "0x7BBC8AB028", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006FDD RID: 28637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FDD")]
		[Address(RVA = "0x20AB0E8", Offset = "0x20AB0E8", VA = "0x7BBC8AB0E8", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06006FDE RID: 28638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FDE")]
		[Address(RVA = "0x20AB25C", Offset = "0x20AB25C", VA = "0x7BBC8AB25C")]
		public void HighLightCurrent()
		{
		}

		// Token: 0x06006FDF RID: 28639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FDF")]
		[Address(RVA = "0x20AB36C", Offset = "0x20AB36C", VA = "0x7BBC8AB36C", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06006FE0 RID: 28640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE0")]
		[Address(RVA = "0x20AB3BC", Offset = "0x20AB3BC", VA = "0x7BBC8AB3BC", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006FE1 RID: 28641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE1")]
		[Address(RVA = "0x20AB9BC", Offset = "0x20AB9BC", VA = "0x7BBC8AB9BC")]
		private void OnHeadPicUpdate(object[] param)
		{
		}

		// Token: 0x06006FE2 RID: 28642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE2")]
		[Address(RVA = "0x20AB7AC", Offset = "0x20AB7AC", VA = "0x7BBC8AB7AC")]
		private void SetRankingItemIcon()
		{
		}

		// Token: 0x06006FE3 RID: 28643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE3")]
		[Address(RVA = "0x20AB9C0", Offset = "0x20AB9C0", VA = "0x7BBC8AB9C0")]
		public UICollectionPortraitItemController()
		{
		}

		// Token: 0x040089D9 RID: 35289
		[Token(Token = "0x40089D9")]
		[FieldOffset(Offset = "0x70")]
		private UICollectionPortraitItemView m_View;

		// Token: 0x040089DA RID: 35290
		[Token(Token = "0x40089DA")]
		[FieldOffset(Offset = "0x78")]
		private HeadPicBaseInfo m_HeadPicInfo;

		// Token: 0x040089DB RID: 35291
		[Token(Token = "0x40089DB")]
		[FieldOffset(Offset = "0x80")]
		private UIModelCollection m_ModelCollection;
	}
}
