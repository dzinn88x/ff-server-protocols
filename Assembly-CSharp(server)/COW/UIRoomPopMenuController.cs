using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B70 RID: 7024
	[Token(Token = "0x2001B70")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA094", Offset = "0x10FA094")]
	public class UIRoomPopMenuController : UIPopupWindowController
	{
		// Token: 0x0600973A RID: 38714 RVA: 0x00027E70 File Offset: 0x00026070
		[Token(Token = "0x600973A")]
		[Address(RVA = "0x1A20170", Offset = "0x1A20170", VA = "0x7BBC220170")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600973B RID: 38715 RVA: 0x00027E88 File Offset: 0x00026088
		[Token(Token = "0x600973B")]
		[Address(RVA = "0x1A201C0", Offset = "0x1A201C0", VA = "0x7BBC2201C0", Slot = "34")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x0600973C RID: 38716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600973C")]
		[Address(RVA = "0x1A201C8", Offset = "0x1A201C8", VA = "0x7BBC2201C8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600973D RID: 38717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600973D")]
		[Address(RVA = "0x1A203D4", Offset = "0x1A203D4", VA = "0x7BBC2203D4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600973E RID: 38718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600973E")]
		[Address(RVA = "0x1A204A0", Offset = "0x1A204A0", VA = "0x7BBC2204A0")]
		public void UpdateMenuData(RoomPlayerInfo info, [Optional] List<CommonPopMenuData> list)
		{
		}

		// Token: 0x0600973F RID: 38719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600973F")]
		[Address(RVA = "0x1A20BF4", Offset = "0x1A20BF4", VA = "0x7BBC220BF4")]
		private void ResizeMenuWidth()
		{
		}

		// Token: 0x06009740 RID: 38720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009740")]
		[Address(RVA = "0x1A20ECC", Offset = "0x1A20ECC", VA = "0x7BBC220ECC")]
		private void ComputePopPosition(int itemNum)
		{
		}

		// Token: 0x06009741 RID: 38721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009741")]
		[Address(RVA = "0x1A2116C", Offset = "0x1A2116C", VA = "0x7BBC22116C")]
		private void OnAddFriend()
		{
		}

		// Token: 0x06009742 RID: 38722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009742")]
		[Address(RVA = "0x1A212B4", Offset = "0x1A212B4", VA = "0x7BBC2212B4")]
		private void OnMaskClick()
		{
		}

		// Token: 0x06009743 RID: 38723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009743")]
		[Address(RVA = "0x1A212BC", Offset = "0x1A212BC", VA = "0x7BBC2212BC")]
		private void OnClickeMenuItem(object[] data)
		{
		}

		// Token: 0x06009744 RID: 38724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009744")]
		[Address(RVA = "0x1A212C4", Offset = "0x1A212C4", VA = "0x7BBC2212C4")]
		public UIRoomPopMenuController()
		{
		}

		// Token: 0x04009F76 RID: 40822
		[Token(Token = "0x4009F76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private RoomPlayerInfo m_info;

		// Token: 0x04009F77 RID: 40823
		[Token(Token = "0x4009F77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int CellWidth;

		// Token: 0x04009F78 RID: 40824
		[Token(Token = "0x4009F78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int CellHeight;

		// Token: 0x04009F79 RID: 40825
		[Token(Token = "0x4009F79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int CellWidthPadding;

		// Token: 0x04009F7A RID: 40826
		[Token(Token = "0x4009F7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int m_NewCellWidth;

		// Token: 0x04009F7B RID: 40827
		[Token(Token = "0x4009F7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector2 m_showOffset;

		// Token: 0x04009F7C RID: 40828
		[Token(Token = "0x4009F7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector2 m_clickPos;

		// Token: 0x04009F7D RID: 40829
		[Token(Token = "0x4009F7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int m_offset;

		// Token: 0x04009F7E RID: 40830
		[Token(Token = "0x4009F7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int m_activatedMenuWidth;

		// Token: 0x04009F7F RID: 40831
		[Token(Token = "0x4009F7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int m_activatedMenuHeight;

		// Token: 0x04009F80 RID: 40832
		[Token(Token = "0x4009F80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float m_scale;

		// Token: 0x04009F81 RID: 40833
		[Token(Token = "0x4009F81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private UIRoomPopMenuView m_View;

		// Token: 0x04009F82 RID: 40834
		[Token(Token = "0x4009F82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<UICommonPopMenuItemController> m_ItemControllerList;
	}
}
