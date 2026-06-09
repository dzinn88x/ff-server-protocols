using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014F5 RID: 5365
	[Token(Token = "0x20014F5")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDDB4", Offset = "0x10EDDB4")]
	public class UIEPDebrisExchangeController : UIPopupWindowController, IEasyList
	{
		// Token: 0x06005BF7 RID: 23543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF7")]
		[Address(RVA = "0x22139C8", Offset = "0x22139C8", VA = "0x7BBCA139C8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005BF8 RID: 23544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BF8")]
		[Address(RVA = "0x2213B3C", Offset = "0x2213B3C", VA = "0x7BBCA13B3C")]
		private void InitData()
		{
		}

		// Token: 0x06005BF9 RID: 23545 RVA: 0x0001AD30 File Offset: 0x00018F30
		[Token(Token = "0x6005BF9")]
		[Address(RVA = "0x2213C74", Offset = "0x2213C74", VA = "0x7BBCA13C74")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005BFA RID: 23546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFA")]
		[Address(RVA = "0x2213CC4", Offset = "0x2213CC4", VA = "0x7BBCA13CC4")]
		private void OnClaimClick()
		{
		}

		// Token: 0x06005BFB RID: 23547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFB")]
		[Address(RVA = "0x2213D00", Offset = "0x2213D00", VA = "0x7BBCA13D00")]
		public void SetData(int badgeFrom, int badgeTo)
		{
		}

		// Token: 0x06005BFC RID: 23548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFC")]
		[Address(RVA = "0x2213DB4", Offset = "0x2213DB4", VA = "0x7BBCA13DB4")]
		private void ShowReward(int badgeFrom, int badgeTo)
		{
		}

		// Token: 0x06005BFD RID: 23549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BFD")]
		[Address(RVA = "0x2214190", Offset = "0x2214190", VA = "0x7BBCA14190", Slot = "40")]
		private UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005BFE RID: 23550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFE")]
		[Address(RVA = "0x221424C", Offset = "0x221424C", VA = "0x7BBCA1424C", Slot = "41")]
		private void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005BFF RID: 23551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BFF")]
		[Address(RVA = "0x221427C", Offset = "0x221427C", VA = "0x7BBCA1427C")]
		public UIEPDebrisExchangeController()
		{
		}

		// Token: 0x04007E46 RID: 32326
		[Token(Token = "0x4007E46")]
		[FieldOffset(Offset = "0x98")]
		private UIEPDebrisExchangeView m_View;

		// Token: 0x04007E47 RID: 32327
		[Token(Token = "0x4007E47")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelElitePass m_Model;
	}
}
