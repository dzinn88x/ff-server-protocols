using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017C4 RID: 6084
	[Token(Token = "0x20017C4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2B9C", Offset = "0x10F2B9C")]
	public class UIFriendCallbackController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x060074BD RID: 29885 RVA: 0x00020658 File Offset: 0x0001E858
		[Token(Token = "0x60074BD")]
		[Address(RVA = "0x1DC02BC", Offset = "0x1DC02BC", VA = "0x7BBC5C02BC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060074BE RID: 29886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074BE")]
		[Address(RVA = "0x1DC030C", Offset = "0x1DC030C", VA = "0x7BBC5C030C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060074BF RID: 29887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074BF")]
		[Address(RVA = "0x1DC0744", Offset = "0x1DC0744", VA = "0x7BBC5C0744", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060074C0 RID: 29888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074C0")]
		[Address(RVA = "0x1DC048C", Offset = "0x1DC048C", VA = "0x7BBC5C048C")]
		private void SetData()
		{
		}

		// Token: 0x060074C1 RID: 29889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074C1")]
		[Address(RVA = "0x1DC0B20", Offset = "0x1DC0B20", VA = "0x7BBC5C0B20")]
		private void RefreshList(List<FriendAccountInfo> accountList, bool keep_page = false)
		{
		}

		// Token: 0x060074C2 RID: 29890 RVA: 0x00020670 File Offset: 0x0001E870
		[Token(Token = "0x60074C2")]
		[Address(RVA = "0x1DC0D9C", Offset = "0x1DC0D9C", VA = "0x7BBC5C0D9C", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060074C3 RID: 29891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074C3")]
		[Address(RVA = "0x1DC0DE0", Offset = "0x1DC0DE0", VA = "0x7BBC5C0DE0")]
		private void OnInviteButtonClick()
		{
		}

		// Token: 0x060074C4 RID: 29892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C4")]
		[Address(RVA = "0x1DC1210", Offset = "0x1DC1210", VA = "0x7BBC5C1210", Slot = "42")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074C5")]
		[Address(RVA = "0x1DC12A4", Offset = "0x1DC12A4", VA = "0x7BBC5C12A4", Slot = "43")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060074C6 RID: 29894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074C6")]
		[Address(RVA = "0x1DC07B0", Offset = "0x1DC07B0", VA = "0x7BBC5C07B0")]
		private List<FriendAccountInfo> GetCallbackData()
		{
			return null;
		}

		// Token: 0x060074C7 RID: 29895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074C7")]
		[Address(RVA = "0x1DC12D4", Offset = "0x1DC12D4", VA = "0x7BBC5C12D4")]
		public UIFriendCallbackController()
		{
		}

		// Token: 0x04008C73 RID: 35955
		[Token(Token = "0x4008C73")]
		[FieldOffset(Offset = "0x98")]
		private UIFriendCallbackView m_View;

		// Token: 0x04008C74 RID: 35956
		[Token(Token = "0x4008C74")]
		[FieldOffset(Offset = "0xA0")]
		private ActivityGroupDesc m_Data;
	}
}
