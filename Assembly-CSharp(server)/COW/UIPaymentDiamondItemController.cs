using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001AC9 RID: 6857
	[Token(Token = "0x2001AC9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8A84", Offset = "0x10F8A84")]
	public class UIPaymentDiamondItemController : UIBaseController
	{
		// Token: 0x060090AF RID: 37039 RVA: 0x00026988 File Offset: 0x00024B88
		[Token(Token = "0x60090AF")]
		[Address(RVA = "0x1F2371C", Offset = "0x1F2371C", VA = "0x7BBC72371C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060090B0 RID: 37040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090B0")]
		[Address(RVA = "0x1F2376C", Offset = "0x1F2376C", VA = "0x7BBC72376C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060090B1 RID: 37041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090B1")]
		[Address(RVA = "0x1F237D0", Offset = "0x1F237D0", VA = "0x7BBC7237D0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060090B2 RID: 37042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090B2")]
		[Address(RVA = "0x1F22B08", Offset = "0x1F22B08", VA = "0x7BBC722B08")]
		public void SetData(string price, int min, int max)
		{
		}

		// Token: 0x060090B3 RID: 37043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090B3")]
		[Address(RVA = "0x1F22C60", Offset = "0x1F22C60", VA = "0x7BBC722C60")]
		public void SetSelected(bool selected, bool isLocked)
		{
		}

		// Token: 0x060090B4 RID: 37044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090B4")]
		[Address(RVA = "0x1F237D8", Offset = "0x1F237D8", VA = "0x7BBC7237D8")]
		public UIPaymentDiamondItemController()
		{
		}

		// Token: 0x04009C4E RID: 40014
		[Token(Token = "0x4009C4E")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentDiamondItemView m_View;

		// Token: 0x04009C4F RID: 40015
		[Token(Token = "0x4009C4F")]
		[FieldOffset(Offset = "0x60")]
		private Color selectedColor;

		// Token: 0x04009C50 RID: 40016
		[Token(Token = "0x4009C50")]
		[FieldOffset(Offset = "0x70")]
		private Color lockedColor;
	}
}
