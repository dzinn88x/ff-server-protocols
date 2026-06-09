using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025F8 RID: 9720
	[Token(Token = "0x20025F8")]
	public class UICenterTargetHelper : MonoBehaviour
	{
		// Token: 0x0600C8AE RID: 51374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8AE")]
		[Address(RVA = "0x1C24090", Offset = "0x1C24090", VA = "0x7BBC424090")]
		private void Awake()
		{
		}

		// Token: 0x0600C8AF RID: 51375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8AF")]
		[Address(RVA = "0x1C24220", Offset = "0x1C24220", VA = "0x7BBC424220")]
		[Attribute(Name = "ContextMenu", RVA = "0x11484C4", Offset = "0x11484C4")]
		public void InitHelper()
		{
		}

		// Token: 0x0600C8B0 RID: 51376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8B0")]
		[Address(RVA = "0x1C24D8C", Offset = "0x1C24D8C", VA = "0x7BBC424D8C")]
		[Attribute(Name = "ContextMenu", RVA = "0x11484FC", Offset = "0x11484FC")]
		public void ClearGapArray()
		{
		}

		// Token: 0x0600C8B1 RID: 51377 RVA: 0x00036258 File Offset: 0x00034458
		[Token(Token = "0x600C8B1")]
		[Address(RVA = "0x1C247FC", Offset = "0x1C247FC", VA = "0x7BBC4247FC")]
		private float GetWidgetPosOffset(UIWidget widget)
		{
			return 0f;
		}

		// Token: 0x0600C8B2 RID: 51378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8B2")]
		[Address(RVA = "0x1C248B0", Offset = "0x1C248B0", VA = "0x7BBC4248B0")]
		private void LayoutLabel()
		{
		}

		// Token: 0x0600C8B3 RID: 51379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8B3")]
		[Address(RVA = "0x1C24D94", Offset = "0x1C24D94", VA = "0x7BBC424D94")]
		public UICenterTargetHelper()
		{
		}

		// Token: 0x0400FB13 RID: 64275
		[Token(Token = "0x400FB13")]
		[FieldOffset(Offset = "0x18")]
		public UIWidget[] m_WidgetArray;

		// Token: 0x0400FB14 RID: 64276
		[Token(Token = "0x400FB14")]
		[FieldOffset(Offset = "0x20")]
		public float[] m_GapBetweenWidgetArray;

		// Token: 0x0400FB15 RID: 64277
		[Token(Token = "0x400FB15")]
		[FieldOffset(Offset = "0x28")]
		private float[] m_WidgetSizeXArray;

		// Token: 0x0400FB16 RID: 64278
		[Token(Token = "0x400FB16")]
		[FieldOffset(Offset = "0x30")]
		private float m_TotalSize;

		// Token: 0x0400FB17 RID: 64279
		[Token(Token = "0x400FB17")]
		[FieldOffset(Offset = "0x34")]
		public bool m_IsIgnoreInactive;
	}
}
