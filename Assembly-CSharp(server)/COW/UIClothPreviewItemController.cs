using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001732 RID: 5938
	[Token(Token = "0x2001732")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1B04", Offset = "0x10F1B04")]
	public class UIClothPreviewItemController : UIBaseController
	{
		// Token: 0x06006F3B RID: 28475 RVA: 0x0001F3B0 File Offset: 0x0001D5B0
		[Token(Token = "0x6006F3B")]
		[Address(RVA = "0x2096108", Offset = "0x2096108", VA = "0x7BBC896108")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006F3C RID: 28476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F3C")]
		[Address(RVA = "0x2096158", Offset = "0x2096158", VA = "0x7BBC896158", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006F3D RID: 28477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F3D")]
		[Address(RVA = "0x209623C", Offset = "0x209623C", VA = "0x7BBC89623C")]
		private void OnClothPreviewBtnClick()
		{
		}

		// Token: 0x06006F3E RID: 28478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F3E")]
		[Address(RVA = "0x209646C", Offset = "0x209646C", VA = "0x7BBC89646C")]
		public void SetSelected(bool flag)
		{
		}

		// Token: 0x06006F3F RID: 28479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F3F")]
		[Address(RVA = "0x20964C8", Offset = "0x20964C8", VA = "0x7BBC8964C8")]
		public void RefreshClothPreviewUI(CSSharedItemData itemdata)
		{
		}

		// Token: 0x06006F40 RID: 28480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F40")]
		[Address(RVA = "0x20965F0", Offset = "0x20965F0", VA = "0x7BBC8965F0")]
		public void ResetDefaultUI(UIModelAvatarBase.EWardrobeType type)
		{
		}

		// Token: 0x06006F41 RID: 28481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F41")]
		[Address(RVA = "0x2096854", Offset = "0x2096854", VA = "0x7BBC896854")]
		public UIClothPreviewItemController()
		{
		}

		// Token: 0x0400896B RID: 35179
		[Token(Token = "0x400896B")]
		[FieldOffset(Offset = "0x58")]
		private UIWidget m_ItemWidget;

		// Token: 0x0400896C RID: 35180
		[Token(Token = "0x400896C")]
		[FieldOffset(Offset = "0x60")]
		private UIClothPreviewItemView m_View;

		// Token: 0x0400896D RID: 35181
		[Token(Token = "0x400896D")]
		[FieldOffset(Offset = "0x68")]
		public UIModelAvatarBase.EWardrobeType ewardrobetype;

		// Token: 0x0400896E RID: 35182
		[Token(Token = "0x400896E")]
		[FieldOffset(Offset = "0x70")]
		private CSSharedItemData m_ClothItemData;
	}
}
