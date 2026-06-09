using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200159C RID: 5532
	[Token(Token = "0x200159C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEDAC", Offset = "0x10EEDAC")]
	public class UIMallGiftFriendItemController : UIEasyListItemController
	{
		// Token: 0x06006118 RID: 24856 RVA: 0x0001C008 File Offset: 0x0001A208
		[Token(Token = "0x6006118")]
		[Address(RVA = "0x1C72230", Offset = "0x1C72230", VA = "0x7BBC472230")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006119")]
		[Address(RVA = "0x1C72280", Offset = "0x1C72280", VA = "0x7BBC472280", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600611A RID: 24858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611A")]
		[Address(RVA = "0x1C72360", Offset = "0x1C72360", VA = "0x7BBC472360", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600611B RID: 24859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611B")]
		[Address(RVA = "0x1C72438", Offset = "0x1C72438", VA = "0x7BBC472438")]
		private void RefreshData(FriendInfo data)
		{
		}

		// Token: 0x0600611C RID: 24860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611C")]
		[Address(RVA = "0x1C72ADC", Offset = "0x1C72ADC", VA = "0x7BBC472ADC", Slot = "29")]
		public override void OnItemBtnClick()
		{
		}

		// Token: 0x0600611D RID: 24861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611D")]
		[Address(RVA = "0x1C729B0", Offset = "0x1C729B0", VA = "0x7BBC4729B0")]
		public void UpdateBanner(uint bannerId)
		{
		}

		// Token: 0x0600611E RID: 24862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611E")]
		[Address(RVA = "0x1C72CCC", Offset = "0x1C72CCC", VA = "0x7BBC472CCC")]
		public void UpdateBanner(BannerData bannerData)
		{
		}

		// Token: 0x0600611F RID: 24863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600611F")]
		[Address(RVA = "0x1C72884", Offset = "0x1C72884", VA = "0x7BBC472884")]
		public void UpdateHeadPic(uint iid)
		{
		}

		// Token: 0x06006120 RID: 24864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006120")]
		[Address(RVA = "0x1C72E8C", Offset = "0x1C72E8C", VA = "0x7BBC472E8C")]
		public void UpdateHeadPic(HeadPicData data)
		{
		}

		// Token: 0x06006121 RID: 24865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006121")]
		[Address(RVA = "0x1C72F90", Offset = "0x1C72F90", VA = "0x7BBC472F90")]
		public UIMallGiftFriendItemController()
		{
		}

		// Token: 0x040080FE RID: 33022
		[Token(Token = "0x40080FE")]
		[FieldOffset(Offset = "0x70")]
		private UIMallGiftFriendItemView m_View;

		// Token: 0x040080FF RID: 33023
		[Token(Token = "0x40080FF")]
		[FieldOffset(Offset = "0x78")]
		private FriendInfo m_Info;
	}
}
