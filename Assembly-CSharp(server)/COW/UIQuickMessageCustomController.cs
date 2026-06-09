using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001669 RID: 5737
	[Token(Token = "0x2001669")]
	public class UIQuickMessageCustomController : UIBaseController, IEasyList
	{
		// Token: 0x060067CA RID: 26570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067CA")]
		[Address(RVA = "0x1FF7540", Offset = "0x1FF7540", VA = "0x7BBC7F7540", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060067CB RID: 26571 RVA: 0x0001D820 File Offset: 0x0001BA20
		[Token(Token = "0x60067CB")]
		[Address(RVA = "0x1FF75A4", Offset = "0x1FF75A4", VA = "0x7BBC7F75A4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060067CC RID: 26572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067CC")]
		[Address(RVA = "0x1FF75F4", Offset = "0x1FF75F4", VA = "0x7BBC7F75F4", Slot = "29")]
		private void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060067CD RID: 26573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067CD")]
		[Address(RVA = "0x1FF7624", Offset = "0x1FF7624", VA = "0x7BBC7F7624", Slot = "28")]
		private UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060067CE RID: 26574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067CE")]
		[Address(RVA = "0x1FF76B8", Offset = "0x1FF76B8", VA = "0x7BBC7F76B8")]
		public UIQuickMessageCustomController()
		{
		}

		// Token: 0x040084F3 RID: 34035
		[Token(Token = "0x40084F3")]
		[FieldOffset(Offset = "0x58")]
		private UIQuickMessageCustomView m_View;
	}
}
