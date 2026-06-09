using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001673 RID: 5747
	[Token(Token = "0x2001673")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F01DC", Offset = "0x10F01DC")]
	public class UIStandardSubTabItemController : UIBaseController, ITipsDelegate
	{
		// Token: 0x0600682B RID: 26667 RVA: 0x0001D910 File Offset: 0x0001BB10
		[Token(Token = "0x600682B")]
		[Address(RVA = "0x2130274", Offset = "0x2130274", VA = "0x7BBC930274")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600682C")]
		[Address(RVA = "0x21302C4", Offset = "0x21302C4", VA = "0x7BBC9302C4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600682D RID: 26669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600682D")]
		[Address(RVA = "0x21303F0", Offset = "0x21303F0", VA = "0x7BBC9303F0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600682E RID: 26670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600682E")]
		[Address(RVA = "0x213059C", Offset = "0x213059C", VA = "0x7BBC93059C")]
		public void SetViewData(StandardSubTabItemViewData data, int data_index)
		{
		}

		// Token: 0x0600682F RID: 26671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600682F")]
		[Address(RVA = "0x2130CE0", Offset = "0x2130CE0", VA = "0x7BBC930CE0")]
		private void OnItemBtnSelect()
		{
		}

		// Token: 0x06006830 RID: 26672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006830")]
		[Address(RVA = "0x2130E60", Offset = "0x2130E60", VA = "0x7BBC930E60")]
		public void UpdateSelectState(bool isSelect)
		{
		}

		// Token: 0x06006831 RID: 26673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006831")]
		[Address(RVA = "0x2130EE8", Offset = "0x2130EE8", VA = "0x7BBC930EE8")]
		public void ExecuteBtnTabItemClick()
		{
		}

		// Token: 0x06006832 RID: 26674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006832")]
		[Address(RVA = "0x2130F50", Offset = "0x2130F50", VA = "0x7BBC930F50", Slot = "28")]
		public void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06006833 RID: 26675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006833")]
		[Address(RVA = "0x21307D4", Offset = "0x21307D4", VA = "0x7BBC9307D4")]
		public void CheckTagState()
		{
		}

		// Token: 0x06006834 RID: 26676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006834")]
		[Address(RVA = "0x2130BE0", Offset = "0x2130BE0", VA = "0x7BBC930BE0")]
		public void CheckTipButton()
		{
		}

		// Token: 0x06006835 RID: 26677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006835")]
		[Address(RVA = "0x2130FBC", Offset = "0x2130FBC", VA = "0x7BBC930FBC")]
		public void SetLock(bool b)
		{
		}

		// Token: 0x06006836 RID: 26678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006836")]
		[Address(RVA = "0x213101C", Offset = "0x213101C", VA = "0x7BBC93101C")]
		public void RegistTipEvent(ETipsType tipType)
		{
		}

		// Token: 0x06006837 RID: 26679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006837")]
		[Address(RVA = "0x2131100", Offset = "0x2131100", VA = "0x7BBC931100")]
		public UIStandardSubTabItemController()
		{
		}

		// Token: 0x0400851C RID: 34076
		[Token(Token = "0x400851C")]
		[FieldOffset(Offset = "0x58")]
		private UIStandardSubTabItemView m_View;

		// Token: 0x0400851D RID: 34077
		[Token(Token = "0x400851D")]
		[FieldOffset(Offset = "0x60")]
		private StandardSubTabItemViewData m_Data;

		// Token: 0x0400851E RID: 34078
		[Token(Token = "0x400851E")]
		[FieldOffset(Offset = "0x68")]
		private int m_Index;

		// Token: 0x0400851F RID: 34079
		[Token(Token = "0x400851F")]
		[FieldOffset(Offset = "0x70")]
		public UIStandardTabItemController mainTab;

		// Token: 0x04008520 RID: 34080
		[Token(Token = "0x4008520")]
		[FieldOffset(Offset = "0x78")]
		private List<ETipsType> tipList;
	}
}
