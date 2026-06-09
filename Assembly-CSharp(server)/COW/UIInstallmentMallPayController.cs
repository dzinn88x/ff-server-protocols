using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001579 RID: 5497
	[Token(Token = "0x2001579")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEA54", Offset = "0x10EEA54")]
	public class UIInstallmentMallPayController : UIInstallmentMallPurchaseController, IEasyList
	{
		// Token: 0x06005FCD RID: 24525 RVA: 0x0001BB28 File Offset: 0x00019D28
		[Token(Token = "0x6005FCD")]
		[Address(RVA = "0x190E050", Offset = "0x190E050", VA = "0x7BBC10E050")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005FCE RID: 24526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCE")]
		[Address(RVA = "0x190E0A0", Offset = "0x190E0A0", VA = "0x7BBC10E0A0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCF")]
		[Address(RVA = "0x190E1DC", Offset = "0x190E1DC", VA = "0x7BBC10E1DC", Slot = "40")]
		protected override void RefreshView()
		{
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD0")]
		[Address(RVA = "0x190E440", Offset = "0x190E440", VA = "0x7BBC10E440")]
		public void SetViewData(uint itemID)
		{
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD1")]
		[Address(RVA = "0x190E49C", Offset = "0x190E49C", VA = "0x7BBC10E49C")]
		private void OnPurchaseBtnClick()
		{
		}

		// Token: 0x06005FD2 RID: 24530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FD2")]
		[Address(RVA = "0x190E500", Offset = "0x190E500", VA = "0x7BBC10E500", Slot = "41")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005FD3 RID: 24531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD3")]
		[Address(RVA = "0x190E594", Offset = "0x190E594", VA = "0x7BBC10E594", Slot = "42")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD4")]
		[Address(RVA = "0x190E5C4", Offset = "0x190E5C4", VA = "0x7BBC10E5C4")]
		public UIInstallmentMallPayController()
		{
		}

		// Token: 0x0400802E RID: 32814
		[Token(Token = "0x400802E")]
		[FieldOffset(Offset = "0xB8")]
		private UIInstallmentMallPurchaseView m_View;
	}
}
