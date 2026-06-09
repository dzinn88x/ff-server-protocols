using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020017BB RID: 6075
	[Token(Token = "0x20017BB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F29F4", Offset = "0x10F29F4")]
	public class UIFastSendGiftFriendItemController : UIEasyListItemController
	{
		// Token: 0x0600744E RID: 29774 RVA: 0x00020460 File Offset: 0x0001E660
		[Token(Token = "0x600744E")]
		[Address(RVA = "0x1DB4178", Offset = "0x1DB4178", VA = "0x7BBC5B4178")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600744F RID: 29775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600744F")]
		[Address(RVA = "0x1DB41C8", Offset = "0x1DB41C8", VA = "0x7BBC5B41C8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007450 RID: 29776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007450")]
		[Address(RVA = "0x1DB42A8", Offset = "0x1DB42A8", VA = "0x7BBC5B42A8", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06007451 RID: 29777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007451")]
		[Address(RVA = "0x1DB4380", Offset = "0x1DB4380", VA = "0x7BBC5B4380")]
		private void RefreshData(FriendInfo data)
		{
		}

		// Token: 0x06007452 RID: 29778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007452")]
		[Address(RVA = "0x1DB49C0", Offset = "0x1DB49C0", VA = "0x7BBC5B49C0", Slot = "29")]
		public override void OnItemBtnClick()
		{
		}

		// Token: 0x06007453 RID: 29779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007453")]
		[Address(RVA = "0x1DB4894", Offset = "0x1DB4894", VA = "0x7BBC5B4894")]
		public void UpdateBanner(uint bannerId)
		{
		}

		// Token: 0x06007454 RID: 29780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007454")]
		[Address(RVA = "0x1DB4BB0", Offset = "0x1DB4BB0", VA = "0x7BBC5B4BB0")]
		public void UpdateBanner(BannerData bannerData)
		{
		}

		// Token: 0x06007455 RID: 29781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007455")]
		[Address(RVA = "0x1DB4768", Offset = "0x1DB4768", VA = "0x7BBC5B4768")]
		public void UpdateHeadPic(uint iid)
		{
		}

		// Token: 0x06007456 RID: 29782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007456")]
		[Address(RVA = "0x1DB4D70", Offset = "0x1DB4D70", VA = "0x7BBC5B4D70")]
		public void UpdateHeadPic(HeadPicData data)
		{
		}

		// Token: 0x06007457 RID: 29783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007457")]
		[Address(RVA = "0x1DB4E74", Offset = "0x1DB4E74", VA = "0x7BBC5B4E74")]
		public UIFastSendGiftFriendItemController()
		{
		}

		// Token: 0x04008C3D RID: 35901
		[Token(Token = "0x4008C3D")]
		[FieldOffset(Offset = "0x70")]
		private UIFastSendGiftFriendItemView m_View;

		// Token: 0x04008C3E RID: 35902
		[Token(Token = "0x4008C3E")]
		[FieldOffset(Offset = "0x78")]
		private FriendInfo m_Info;
	}
}
