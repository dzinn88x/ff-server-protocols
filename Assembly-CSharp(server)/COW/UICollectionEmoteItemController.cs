using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200173A RID: 5946
	[Token(Token = "0x200173A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1BF4", Offset = "0x10F1BF4")]
	internal class UICollectionEmoteItemController : UIEasyListItemController
	{
		// Token: 0x06006FC6 RID: 28614 RVA: 0x0001F590 File Offset: 0x0001D790
		[Token(Token = "0x6006FC6")]
		[Address(RVA = "0x20A6704", Offset = "0x20A6704", VA = "0x7BBC8A6704")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FC7")]
		[Address(RVA = "0x20A6754", Offset = "0x20A6754", VA = "0x7BBC8A6754", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006FC8 RID: 28616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FC8")]
		[Address(RVA = "0x20A6AA0", Offset = "0x20A6AA0", VA = "0x7BBC8A6AA0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006FC9 RID: 28617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FC9")]
		[Address(RVA = "0x20A6B6C", Offset = "0x20A6B6C", VA = "0x7BBC8A6B6C", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06006FCA RID: 28618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FCA")]
		[Address(RVA = "0x20A6D44", Offset = "0x20A6D44", VA = "0x7BBC8A6D44", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06006FCB RID: 28619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FCB")]
		[Address(RVA = "0x20A6D94", Offset = "0x20A6D94", VA = "0x7BBC8A6D94")]
		public void HighLightCurrent(bool updated = false)
		{
		}

		// Token: 0x06006FCC RID: 28620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FCC")]
		[Address(RVA = "0x20A6F4C", Offset = "0x20A6F4C", VA = "0x7BBC8A6F4C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006FCD RID: 28621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FCD")]
		[Address(RVA = "0x20A7A0C", Offset = "0x20A7A0C", VA = "0x7BBC8A7A0C")]
		private void SetRankingItemIcon()
		{
		}

		// Token: 0x06006FCE RID: 28622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FCE")]
		[Address(RVA = "0x20A7C1C", Offset = "0x20A7C1C", VA = "0x7BBC8A7C1C")]
		private void OnItemUpdate(object[] param)
		{
		}

		// Token: 0x06006FCF RID: 28623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FCF")]
		[Address(RVA = "0x20A7C24", Offset = "0x20A7C24", VA = "0x7BBC8A7C24")]
		public void OnDragDropRelease(uint slotIndex)
		{
		}

		// Token: 0x06006FD0 RID: 28624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FD0")]
		[Address(RVA = "0x20A7DD4", Offset = "0x20A7DD4", VA = "0x7BBC8A7DD4")]
		public UICollectionEmoteItemController()
		{
		}

		// Token: 0x040089CE RID: 35278
		[Token(Token = "0x40089CE")]
		[FieldOffset(Offset = "0x70")]
		private UICollectionEmoteItemView m_View;

		// Token: 0x040089CF RID: 35279
		[Token(Token = "0x40089CF")]
		[FieldOffset(Offset = "0x78")]
		private EmoteBaseInfo m_EmoteInfo;

		// Token: 0x040089D0 RID: 35280
		[Token(Token = "0x40089D0")]
		[FieldOffset(Offset = "0x80")]
		private CollectionBaseInfo m_CollectionInfo;

		// Token: 0x040089D1 RID: 35281
		[Token(Token = "0x40089D1")]
		[FieldOffset(Offset = "0x88")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x040089D2 RID: 35282
		[Token(Token = "0x40089D2")]
		[FieldOffset(Offset = "0x90")]
		private bool m_CollectionABReady;

		// Token: 0x040089D3 RID: 35283
		[Token(Token = "0x40089D3")]
		[FieldOffset(Offset = "0x94")]
		private uint m_ItemIconGrey;
	}
}
