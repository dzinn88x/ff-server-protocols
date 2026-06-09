using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001894 RID: 6292
	[Token(Token = "0x2001894")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F464C", Offset = "0x10F464C")]
	public class UIHUDCommonEquipSetSelectionController : UIPopupWindowController
	{
		// Token: 0x06007CA8 RID: 31912 RVA: 0x000223C8 File Offset: 0x000205C8
		[Token(Token = "0x6007CA8")]
		[Address(RVA = "0x16B7B50", Offset = "0x16B7B50", VA = "0x7BBBEB7B50")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007CA9 RID: 31913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA9")]
		[Address(RVA = "0x16B7BA0", Offset = "0x16B7BA0", VA = "0x7BBBEB7BA0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007CAA RID: 31914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CAA")]
		[Address(RVA = "0x16B8034", Offset = "0x16B8034", VA = "0x7BBBEB8034")]
		public void ShowWindow(int defalutIndex, float showTime)
		{
		}

		// Token: 0x06007CAB RID: 31915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CAB")]
		[Address(RVA = "0x16B7FF4", Offset = "0x16B7FF4", VA = "0x7BBBEB7FF4")]
		private void OnSelectItem(int index)
		{
		}

		// Token: 0x06007CAC RID: 31916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CAC")]
		[Address(RVA = "0x16B8220", Offset = "0x16B8220", VA = "0x7BBBEB8220")]
		private void HighLightIndex(int index, bool hightlight)
		{
		}

		// Token: 0x06007CAD RID: 31917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CAD")]
		[Address(RVA = "0x16B82E4", Offset = "0x16B82E4", VA = "0x7BBBEB82E4")]
		private void OnConfirm()
		{
		}

		// Token: 0x06007CAE RID: 31918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CAE")]
		[Address(RVA = "0x16B8370", Offset = "0x16B8370", VA = "0x7BBBEB8370")]
		private void Update()
		{
		}

		// Token: 0x06007CAF RID: 31919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CAF")]
		[Address(RVA = "0x16B83CC", Offset = "0x16B83CC", VA = "0x7BBBEB83CC")]
		public UIHUDCommonEquipSetSelectionController()
		{
		}

		// Token: 0x04009078 RID: 36984
		[Token(Token = "0x4009078")]
		[FieldOffset(Offset = "0x98")]
		private UIEquipSetSelectionView m_View;

		// Token: 0x04009079 RID: 36985
		[Token(Token = "0x4009079")]
		[FieldOffset(Offset = "0xA0")]
		private int m_SelectedIndex;

		// Token: 0x0400907A RID: 36986
		[Token(Token = "0x400907A")]
		[FieldOffset(Offset = "0xA8")]
		private List<UIEquipSetItemController> m_SetItemUIs;

		// Token: 0x0400907B RID: 36987
		[Token(Token = "0x400907B")]
		[FieldOffset(Offset = "0xB0")]
		private UITimeLabelHelper m_EndTime;
	}
}
