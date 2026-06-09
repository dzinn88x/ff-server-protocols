using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200157A RID: 5498
	[Token(Token = "0x200157A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEA8C", Offset = "0x10EEA8C")]
	public class UIInstallmentMallPayDueController : UIInstallmentMallPurchaseController, IEasyList
	{
		// Token: 0x06005FD5 RID: 24533 RVA: 0x0001BB40 File Offset: 0x00019D40
		[Token(Token = "0x6005FD5")]
		[Address(RVA = "0x190E5CC", Offset = "0x190E5CC", VA = "0x7BBC10E5CC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005FD6 RID: 24534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD6")]
		[Address(RVA = "0x190E61C", Offset = "0x190E61C", VA = "0x7BBC10E61C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005FD7 RID: 24535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD7")]
		[Address(RVA = "0x190E758", Offset = "0x190E758", VA = "0x7BBC10E758", Slot = "40")]
		protected override void RefreshView()
		{
		}

		// Token: 0x06005FD8 RID: 24536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD8")]
		[Address(RVA = "0x190E9BC", Offset = "0x190E9BC", VA = "0x7BBC10E9BC")]
		public void SetViewData(uint itemID)
		{
		}

		// Token: 0x06005FD9 RID: 24537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD9")]
		[Address(RVA = "0x190EA18", Offset = "0x190EA18", VA = "0x7BBC10EA18")]
		private void OnPurchaseBtnClick()
		{
		}

		// Token: 0x06005FDA RID: 24538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FDA")]
		[Address(RVA = "0x190EA7C", Offset = "0x190EA7C", VA = "0x7BBC10EA7C", Slot = "41")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005FDB RID: 24539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FDB")]
		[Address(RVA = "0x190EB10", Offset = "0x190EB10", VA = "0x7BBC10EB10", Slot = "42")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005FDC RID: 24540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FDC")]
		[Address(RVA = "0x190EB40", Offset = "0x190EB40", VA = "0x7BBC10EB40")]
		public UIInstallmentMallPayDueController()
		{
		}

		// Token: 0x0400802F RID: 32815
		[Token(Token = "0x400802F")]
		[FieldOffset(Offset = "0xB8")]
		private UIInstallmentMallPurchaseView m_View;
	}
}
