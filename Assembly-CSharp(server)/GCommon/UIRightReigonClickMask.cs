using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x0200101E RID: 4126
	[Token(Token = "0x200101E")]
	public class UIRightReigonClickMask
	{
		// Token: 0x06003E53 RID: 15955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E53")]
		[Address(RVA = "0x203545C", Offset = "0x203545C", VA = "0x7BBC83545C")]
		public UIRightReigonClickMask()
		{
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E54")]
		[Address(RVA = "0x20354D0", Offset = "0x20354D0", VA = "0x7BBC8354D0")]
		public void OpenMask()
		{
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E55")]
		[Address(RVA = "0x203564C", Offset = "0x203564C", VA = "0x7BBC83564C")]
		public void CloseMask()
		{
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x00013638 File Offset: 0x00011838
		[Token(Token = "0x6003E56")]
		[Address(RVA = "0x20357F0", Offset = "0x20357F0", VA = "0x7BBC8357F0")]
		private bool GetMaskPressState()
		{
			return default(bool);
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x00013650 File Offset: 0x00011850
		[Token(Token = "0x6003E57")]
		[Address(RVA = "0x2035994", Offset = "0x2035994", VA = "0x7BBC835994")]
		private bool IsClickPosInRightRegion()
		{
			return default(bool);
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E58")]
		[Address(RVA = "0x2035ADC", Offset = "0x2035ADC", VA = "0x7BBC835ADC")]
		protected void OnUICameraCustomInput()
		{
		}

		// Token: 0x06003E59 RID: 15961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E59")]
		[Address(RVA = "0x2035C80", Offset = "0x2035C80", VA = "0x7BBC835C80")]
		public void AddMaskRegion(UIWidget maskRegion)
		{
		}

		// Token: 0x06003E5A RID: 15962 RVA: 0x00013668 File Offset: 0x00011868
		[Token(Token = "0x6003E5A")]
		[Address(RVA = "0x2035D24", Offset = "0x2035D24", VA = "0x7BBC835D24")]
		private Rect MaskRect(UIWidget maskWidget)
		{
			return default(Rect);
		}

		// Token: 0x04004EAF RID: 20143
		[Token(Token = "0x4004EAF")]
		[FieldOffset(Offset = "0x10")]
		private List<Rect> m_RectRegionList;

		// Token: 0x04004EB0 RID: 20144
		[Token(Token = "0x4004EB0")]
		[FieldOffset(Offset = "0x18")]
		private Vector3 m_ClickWorldPos;

		// Token: 0x04004EB1 RID: 20145
		[Token(Token = "0x4004EB1")]
		[FieldOffset(Offset = "0x28")]
		public Action OnClickInRightRegion;
	}
}
