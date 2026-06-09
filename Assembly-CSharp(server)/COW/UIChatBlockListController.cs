using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016F5 RID: 5877
	[Token(Token = "0x20016F5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F123C", Offset = "0x10F123C")]
	public class UIChatBlockListController : UIPopupWindowController, IEasyList
	{
		// Token: 0x06006D1D RID: 27933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D1D")]
		[Address(RVA = "0x1BDFC28", Offset = "0x1BDFC28", VA = "0x7BBC3DFC28", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006D1E RID: 27934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D1E")]
		[Address(RVA = "0x1BDFF04", Offset = "0x1BDFF04", VA = "0x7BBC3DFF04", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06006D1F RID: 27935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D1F")]
		[Address(RVA = "0x1BDFFD0", Offset = "0x1BDFFD0", VA = "0x7BBC3DFFD0")]
		private void RefreshBlockList(object[] data)
		{
		}

		// Token: 0x06006D20 RID: 27936 RVA: 0x0001EC48 File Offset: 0x0001CE48
		[Token(Token = "0x6006D20")]
		[Address(RVA = "0x1BE0080", Offset = "0x1BE0080", VA = "0x7BBC3E0080")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006D21 RID: 27937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D21")]
		[Address(RVA = "0x1BE00D0", Offset = "0x1BE00D0", VA = "0x7BBC3E00D0", Slot = "41")]
		private void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006D22 RID: 27938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D22")]
		[Address(RVA = "0x1BE0100", Offset = "0x1BE0100", VA = "0x7BBC3E0100", Slot = "40")]
		private UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D23")]
		[Address(RVA = "0x1BE0194", Offset = "0x1BE0194", VA = "0x7BBC3E0194")]
		public UIChatBlockListController()
		{
		}

		// Token: 0x0400887A RID: 34938
		[Token(Token = "0x400887A")]
		[FieldOffset(Offset = "0x98")]
		private UIChatBlockListView m_View;

		// Token: 0x0400887B RID: 34939
		[Token(Token = "0x400887B")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelChat m_Model;
	}
}
