using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001BB7 RID: 7095
	[Token(Token = "0x2001BB7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAAF4", Offset = "0x10FAAF4")]
	public class UITreasureBoxOpenWndontroller : UIPopupWindowController
	{
		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x0600994B RID: 39243 RVA: 0x00028590 File Offset: 0x00026790
		// (set) Token: 0x0600994A RID: 39242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A4D")]
		private uint SelectCnt
		{
			[Token(Token = "0x600994B")]
			[Address(RVA = "0x19F26A0", Offset = "0x19F26A0", VA = "0x7BBC1F26A0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600994A")]
			[Address(RVA = "0x19F23CC", Offset = "0x19F23CC", VA = "0x7BBC1F23CC")]
			set
			{
			}
		}

		// Token: 0x0600994C RID: 39244 RVA: 0x000285A8 File Offset: 0x000267A8
		[Token(Token = "0x600994C")]
		[Address(RVA = "0x19F26A8", Offset = "0x19F26A8", VA = "0x7BBC1F26A8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600994D RID: 39245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600994D")]
		[Address(RVA = "0x19F26F8", Offset = "0x19F26F8", VA = "0x7BBC1F26F8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600994E RID: 39246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600994E")]
		[Address(RVA = "0x19F2948", Offset = "0x19F2948", VA = "0x7BBC1F2948")]
		public void RefreshView(uint itemID)
		{
		}

		// Token: 0x0600994F RID: 39247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600994F")]
		[Address(RVA = "0x19F2BEC", Offset = "0x19F2BEC", VA = "0x7BBC1F2BEC")]
		private void OnOpenBtnClick()
		{
		}

		// Token: 0x06009950 RID: 39248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009950")]
		[Address(RVA = "0x19F2CD8", Offset = "0x19F2CD8", VA = "0x7BBC1F2CD8")]
		private void OnPlusBtnClick()
		{
		}

		// Token: 0x06009951 RID: 39249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009951")]
		[Address(RVA = "0x19F2CF8", Offset = "0x19F2CF8", VA = "0x7BBC1F2CF8")]
		private void OnMinsBtnClick()
		{
		}

		// Token: 0x06009952 RID: 39250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009952")]
		[Address(RVA = "0x19F2D10", Offset = "0x19F2D10", VA = "0x7BBC1F2D10")]
		private void OnSliderValueChange()
		{
		}

		// Token: 0x06009953 RID: 39251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009953")]
		[Address(RVA = "0x19F23E4", Offset = "0x19F23E4", VA = "0x7BBC1F23E4")]
		private void OnSelectCntChange()
		{
		}

		// Token: 0x06009954 RID: 39252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009954")]
		[Address(RVA = "0x19F2E80", Offset = "0x19F2E80", VA = "0x7BBC1F2E80")]
		public UITreasureBoxOpenWndontroller()
		{
		}

		// Token: 0x0400A0AA RID: 41130
		[Token(Token = "0x400A0AA")]
		[FieldOffset(Offset = "0x98")]
		private UITreasureBoxOpenWndView m_View;

		// Token: 0x0400A0AB RID: 41131
		[Token(Token = "0x400A0AB")]
		[FieldOffset(Offset = "0xA0")]
		private Item m_Item;

		// Token: 0x0400A0AC RID: 41132
		[Token(Token = "0x400A0AC")]
		[FieldOffset(Offset = "0xA8")]
		private int maxOpenCnt;

		// Token: 0x0400A0AD RID: 41133
		[Token(Token = "0x400A0AD")]
		[FieldOffset(Offset = "0xB0")]
		private UIStandardItemMAXBController m_ItemCtrl;

		// Token: 0x0400A0AE RID: 41134
		[Token(Token = "0x400A0AE")]
		[FieldOffset(Offset = "0xB8")]
		private uint m_SelectCnt;

		// Token: 0x0400A0AF RID: 41135
		[Token(Token = "0x400A0AF")]
		[FieldOffset(Offset = "0xBC")]
		private bool m_IsSliderChange;
	}
}
