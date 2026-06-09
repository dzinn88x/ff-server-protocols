using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001641 RID: 5697
	[Token(Token = "0x2001641")]
	public class UIHudReaperEquipSetSelectionController : UIPopupWindowController
	{
		// Token: 0x060066CA RID: 26314 RVA: 0x0001D508 File Offset: 0x0001B708
		[Token(Token = "0x60066CA")]
		[Address(RVA = "0x17E9030", Offset = "0x17E9030", VA = "0x7BBBFE9030")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060066CB RID: 26315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066CB")]
		[Address(RVA = "0x17E9080", Offset = "0x17E9080", VA = "0x7BBBFE9080", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060066CC RID: 26316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066CC")]
		[Address(RVA = "0x17E992C", Offset = "0x17E992C", VA = "0x7BBBFE992C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060066CD RID: 26317 RVA: 0x0001D520 File Offset: 0x0001B720
		[Token(Token = "0x60066CD")]
		[Address(RVA = "0x17E96C0", Offset = "0x17E96C0", VA = "0x7BBBFE96C0")]
		private int GetEquipSetUIIndex(uint equipSetID)
		{
			return 0;
		}

		// Token: 0x060066CE RID: 26318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066CE")]
		[Address(RVA = "0x17E9818", Offset = "0x17E9818", VA = "0x7BBBFE9818")]
		private void OnSelectItem(int index)
		{
		}

		// Token: 0x060066CF RID: 26319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066CF")]
		[Address(RVA = "0x17E9934", Offset = "0x17E9934", VA = "0x7BBBFE9934")]
		private void OnConfirm()
		{
		}

		// Token: 0x060066D0 RID: 26320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D0")]
		[Address(RVA = "0x17E9A18", Offset = "0x17E9A18", VA = "0x7BBBFE9A18")]
		private void Update()
		{
		}

		// Token: 0x060066D1 RID: 26321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D1")]
		[Address(RVA = "0x17E9A74", Offset = "0x17E9A74", VA = "0x7BBBFE9A74")]
		public UIHudReaperEquipSetSelectionController()
		{
		}

		// Token: 0x04008469 RID: 33897
		[Token(Token = "0x4008469")]
		[FieldOffset(Offset = "0x98")]
		private UIEquipSetSelectionView m_View;

		// Token: 0x0400846A RID: 33898
		[Token(Token = "0x400846A")]
		[FieldOffset(Offset = "0xA0")]
		private UIEquipSetItemController m_SelectSetUI;

		// Token: 0x0400846B RID: 33899
		[Token(Token = "0x400846B")]
		[FieldOffset(Offset = "0xA8")]
		private List<UIEquipSetItemController> m_SetItemUIs;

		// Token: 0x0400846C RID: 33900
		[Token(Token = "0x400846C")]
		[FieldOffset(Offset = "0xB0")]
		private UITimeLabelHelper m_EndTime;
	}
}
