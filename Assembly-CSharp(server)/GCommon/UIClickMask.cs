using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x0200101F RID: 4127
	[Token(Token = "0x200101F")]
	public class UIClickMask
	{
		// Token: 0x06003E5B RID: 15963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5B")]
		[Address(RVA = "0x202846C", Offset = "0x202846C", VA = "0x7BBC82846C")]
		public UIClickMask(Action Action, UIWidget maskRegion)
		{
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5C")]
		[Address(RVA = "0x2028800", Offset = "0x2028800", VA = "0x7BBC828800")]
		public UIClickMask(UIBaseController targetUI, UIWidget maskRegion, bool isHide = false)
		{
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5D")]
		[Address(RVA = "0x2028A8C", Offset = "0x2028A8C", VA = "0x7BBC828A8C")]
		public UIClickMask(GameObject targetGo, UIWidget maskRegion)
		{
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5E")]
		[Address(RVA = "0x2028D0C", Offset = "0x2028D0C", VA = "0x7BBC828D0C")]
		public void AddMaskRegion(UIWidget maskRegion)
		{
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E5F")]
		[Address(RVA = "0x2028DFC", Offset = "0x2028DFC", VA = "0x7BBC828DFC")]
		public void Destroy()
		{
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x00013680 File Offset: 0x00011880
		[Token(Token = "0x6003E60")]
		[Address(RVA = "0x2028F78", Offset = "0x2028F78", VA = "0x7BBC828F78")]
		private bool GetMaskPressState()
		{
			return default(bool);
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x00013698 File Offset: 0x00011898
		[Token(Token = "0x6003E61")]
		[Address(RVA = "0x202911C", Offset = "0x202911C", VA = "0x7BBC82911C")]
		private bool IsClickPosInRightRegion()
		{
			return default(bool);
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E62")]
		[Address(RVA = "0x2029264", Offset = "0x2029264", VA = "0x7BBC829264")]
		private void OnUICameraCustomInput()
		{
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x000136B0 File Offset: 0x000118B0
		[Token(Token = "0x6003E63")]
		[Address(RVA = "0x20286C4", Offset = "0x20286C4", VA = "0x7BBC8286C4")]
		private Rect MaskRect(UIWidget maskWidget)
		{
			return default(Rect);
		}

		// Token: 0x04004EB2 RID: 20146
		[Token(Token = "0x4004EB2")]
		[FieldOffset(Offset = "0x10")]
		private Action m_Action;

		// Token: 0x04004EB3 RID: 20147
		[Token(Token = "0x4004EB3")]
		[FieldOffset(Offset = "0x18")]
		private UIBaseController m_TargetUI;

		// Token: 0x04004EB4 RID: 20148
		[Token(Token = "0x4004EB4")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_TargetGo;

		// Token: 0x04004EB5 RID: 20149
		[Token(Token = "0x4004EB5")]
		[FieldOffset(Offset = "0x28")]
		private List<Rect> m_RectRegionList;

		// Token: 0x04004EB6 RID: 20150
		[Token(Token = "0x4004EB6")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 m_ClickWorldPos;

		// Token: 0x04004EB7 RID: 20151
		[Token(Token = "0x4004EB7")]
		[FieldOffset(Offset = "0x3C")]
		private bool HideTargetUI;
	}
}
