using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016CC RID: 5836
	[Token(Token = "0x20016CC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0D1C", Offset = "0x10F0D1C")]
	public class UIAvatarSuitItemController : UIEasyListItemController
	{
		// Token: 0x06006B4D RID: 27469 RVA: 0x0001E630 File Offset: 0x0001C830
		[Token(Token = "0x6006B4D")]
		[Address(RVA = "0x1E50D9C", Offset = "0x1E50D9C", VA = "0x7BBC650D9C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006B4E RID: 27470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B4E")]
		[Address(RVA = "0x1E50DEC", Offset = "0x1E50DEC", VA = "0x7BBC650DEC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006B4F RID: 27471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B4F")]
		[Address(RVA = "0x1E50FC8", Offset = "0x1E50FC8", VA = "0x7BBC650FC8", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006B50 RID: 27472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B50")]
		[Address(RVA = "0x1E5157C", Offset = "0x1E5157C", VA = "0x7BBC65157C")]
		public void OnItemClicked()
		{
		}

		// Token: 0x06006B51 RID: 27473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B51")]
		[Address(RVA = "0x1E51780", Offset = "0x1E51780", VA = "0x7BBC651780")]
		private void OnEquipBtnClick()
		{
		}

		// Token: 0x06006B52 RID: 27474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B52")]
		[Address(RVA = "0x1E51B60", Offset = "0x1E51B60", VA = "0x7BBC651B60")]
		private void OnObtainBtnClick()
		{
		}

		// Token: 0x06006B53 RID: 27475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B53")]
		[Address(RVA = "0x1E512C0", Offset = "0x1E512C0", VA = "0x7BBC6512C0")]
		private void RefreshUI()
		{
		}

		// Token: 0x06006B54 RID: 27476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B54")]
		[Address(RVA = "0x1E51B64", Offset = "0x1E51B64", VA = "0x7BBC651B64")]
		private void ResetButtonState()
		{
		}

		// Token: 0x06006B55 RID: 27477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B55")]
		[Address(RVA = "0x1E51D9C", Offset = "0x1E51D9C", VA = "0x7BBC651D9C")]
		public UIAvatarSuitItemController()
		{
		}

		// Token: 0x04008743 RID: 34627
		[Token(Token = "0x4008743")]
		[FieldOffset(Offset = "0x70")]
		private uint m_SuitID;

		// Token: 0x04008744 RID: 34628
		[Token(Token = "0x4008744")]
		[FieldOffset(Offset = "0x78")]
		private UIAvatarSuitListItemView m_View;

		// Token: 0x04008745 RID: 34629
		[Token(Token = "0x4008745")]
		[FieldOffset(Offset = "0x80")]
		private bool isDefault;

		// Token: 0x04008746 RID: 34630
		[Token(Token = "0x4008746")]
		[FieldOffset(Offset = "0x88")]
		private SuitDisplayData m_Data;

		// Token: 0x04008747 RID: 34631
		[Token(Token = "0x4008747")]
		[FieldOffset(Offset = "0x90")]
		private AvatarSuitData m_SuitData;
	}
}
