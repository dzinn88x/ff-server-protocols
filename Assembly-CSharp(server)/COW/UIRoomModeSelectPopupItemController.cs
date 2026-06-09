using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B69 RID: 7017
	[Token(Token = "0x2001B69")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9F7C", Offset = "0x10F9F7C")]
	public class UIRoomModeSelectPopupItemController : UIEasyListItemController
	{
		// Token: 0x060096FE RID: 38654 RVA: 0x00027DC8 File Offset: 0x00025FC8
		[Token(Token = "0x60096FE")]
		[Address(RVA = "0x1A1B438", Offset = "0x1A1B438", VA = "0x7BBC21B438")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060096FF RID: 38655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096FF")]
		[Address(RVA = "0x1A1B488", Offset = "0x1A1B488", VA = "0x7BBC21B488", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06009700 RID: 38656 RVA: 0x00027DE0 File Offset: 0x00025FE0
		[Token(Token = "0x6009700")]
		[Address(RVA = "0x1A1B5F0", Offset = "0x1A1B5F0", VA = "0x7BBC21B5F0")]
		public bool IsSelect()
		{
			return default(bool);
		}

		// Token: 0x06009701 RID: 38657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009701")]
		[Address(RVA = "0x1A1B630", Offset = "0x1A1B630", VA = "0x7BBC21B630", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009702 RID: 38658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009702")]
		[Address(RVA = "0x1A1B714", Offset = "0x1A1B714", VA = "0x7BBC21B714")]
		private void OnClickSelectBtn()
		{
		}

		// Token: 0x06009703 RID: 38659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009703")]
		[Address(RVA = "0x1A1B7E8", Offset = "0x1A1B7E8", VA = "0x7BBC21B7E8")]
		public UIRoomModeSelectPopupItemController()
		{
		}

		// Token: 0x04009F4B RID: 40779
		[Token(Token = "0x4009F4B")]
		[FieldOffset(Offset = "0x70")]
		private UIRoomModeSelectPopupItemView m_View;

		// Token: 0x04009F4C RID: 40780
		[Token(Token = "0x4009F4C")]
		[FieldOffset(Offset = "0x78")]
		private FRoomModeSelectData m_Data;
	}
}
