using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017B6 RID: 6070
	[Token(Token = "0x20017B6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2974", Offset = "0x10F2974")]
	public class UIEscortTutorialController : UIPopupWindowController
	{
		// Token: 0x06007424 RID: 29732 RVA: 0x000203E8 File Offset: 0x0001E5E8
		[Token(Token = "0x6007424")]
		[Address(RVA = "0x1E7C59C", Offset = "0x1E7C59C", VA = "0x7BBC67C59C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007425 RID: 29733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007425")]
		[Address(RVA = "0x1E7C5EC", Offset = "0x1E7C5EC", VA = "0x7BBC67C5EC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007426 RID: 29734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007426")]
		[Address(RVA = "0x1E7D228", Offset = "0x1E7D228", VA = "0x7BBC67D228", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007427 RID: 29735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007427")]
		[Address(RVA = "0x1E7D230", Offset = "0x1E7D230", VA = "0x7BBC67D230", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007428")]
		[Address(RVA = "0x1E7D2C0", Offset = "0x1E7D2C0", VA = "0x7BBC67D2C0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007429")]
		[Address(RVA = "0x1E7D2C8", Offset = "0x1E7D2C8", VA = "0x7BBC67D2C8")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x0600742A RID: 29738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600742A")]
		[Address(RVA = "0x1E7D2D0", Offset = "0x1E7D2D0", VA = "0x7BBC67D2D0")]
		private void OnLeftClick()
		{
		}

		// Token: 0x0600742B RID: 29739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600742B")]
		[Address(RVA = "0x1E7D394", Offset = "0x1E7D394", VA = "0x7BBC67D394")]
		private void OnRightClick()
		{
		}

		// Token: 0x0600742C RID: 29740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600742C")]
		[Address(RVA = "0x1E7D460", Offset = "0x1E7D460", VA = "0x7BBC67D460")]
		private void getCenteredGo(GameObject centerGo)
		{
		}

		// Token: 0x0600742D RID: 29741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600742D")]
		[Address(RVA = "0x1E7D0D4", Offset = "0x1E7D0D4", VA = "0x7BBC67D0D4")]
		private void UpdateShowLeftOrRight()
		{
		}

		// Token: 0x0600742E RID: 29742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600742E")]
		[Address(RVA = "0x1E7D048", Offset = "0x1E7D048", VA = "0x7BBC67D048")]
		private void updateGuideMessage(int index)
		{
		}

		// Token: 0x0600742F RID: 29743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600742F")]
		[Address(RVA = "0x1E7D5DC", Offset = "0x1E7D5DC", VA = "0x7BBC67D5DC")]
		public UIEscortTutorialController()
		{
		}

		// Token: 0x04008C26 RID: 35878
		[Token(Token = "0x4008C26")]
		[FieldOffset(Offset = "0x94")]
		private uint m_MaxCount;

		// Token: 0x04008C27 RID: 35879
		[Token(Token = "0x4008C27")]
		[FieldOffset(Offset = "0x98")]
		private UIEscortTutorialView m_View;

		// Token: 0x04008C28 RID: 35880
		[Token(Token = "0x4008C28")]
		[FieldOffset(Offset = "0xA0")]
		private UICenterOnChild m_Wrap;

		// Token: 0x04008C29 RID: 35881
		[Token(Token = "0x4008C29")]
		[FieldOffset(Offset = "0xA8")]
		private List<GameObject> m_DotsGo;

		// Token: 0x04008C2A RID: 35882
		[Token(Token = "0x4008C2A")]
		[FieldOffset(Offset = "0xB0")]
		private List<Transform> m_ContentsGo;

		// Token: 0x04008C2B RID: 35883
		[Token(Token = "0x4008C2B")]
		[FieldOffset(Offset = "0xB8")]
		private int m_Selected;

		// Token: 0x04008C2C RID: 35884
		[Token(Token = "0x4008C2C")]
		[FieldOffset(Offset = "0xC0")]
		private string[] m_GuideMessages;
	}
}
