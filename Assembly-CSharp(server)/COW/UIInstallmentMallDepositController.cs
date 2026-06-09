using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001577 RID: 5495
	[Token(Token = "0x2001577")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE9E4", Offset = "0x10EE9E4")]
	public class UIInstallmentMallDepositController : UIInstallmentMallPurchaseController, IEasyList
	{
		// Token: 0x06005FBB RID: 24507 RVA: 0x0001BAF8 File Offset: 0x00019CF8
		[Token(Token = "0x6005FBB")]
		[Address(RVA = "0x190CD40", Offset = "0x190CD40", VA = "0x7BBC10CD40")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005FBC RID: 24508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBC")]
		[Address(RVA = "0x190CDE0", Offset = "0x190CDE0", VA = "0x7BBC10CDE0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005FBD RID: 24509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBD")]
		[Address(RVA = "0x190CFDC", Offset = "0x190CFDC", VA = "0x7BBC10CFDC", Slot = "40")]
		protected override void RefreshView()
		{
		}

		// Token: 0x06005FBE RID: 24510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBE")]
		[Address(RVA = "0x190D410", Offset = "0x190D410", VA = "0x7BBC10D410")]
		public void SetViewData(uint itemID)
		{
		}

		// Token: 0x06005FBF RID: 24511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBF")]
		[Address(RVA = "0x190D46C", Offset = "0x190D46C", VA = "0x7BBC10D46C")]
		private void OnPurchaseBtnClick()
		{
		}

		// Token: 0x06005FC0 RID: 24512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FC0")]
		[Address(RVA = "0x190D4D0", Offset = "0x190D4D0", VA = "0x7BBC10D4D0", Slot = "41")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005FC1 RID: 24513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC1")]
		[Address(RVA = "0x190D564", Offset = "0x190D564", VA = "0x7BBC10D564", Slot = "42")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005FC2 RID: 24514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC2")]
		[Address(RVA = "0x190D594", Offset = "0x190D594", VA = "0x7BBC10D594")]
		public UIInstallmentMallDepositController()
		{
		}

		// Token: 0x04008029 RID: 32809
		[Token(Token = "0x4008029")]
		[FieldOffset(Offset = "0xB8")]
		private UIInstallmentMallPurchaseView m_View;
	}
}
