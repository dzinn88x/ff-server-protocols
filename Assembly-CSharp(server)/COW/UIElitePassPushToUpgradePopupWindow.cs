using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200179F RID: 6047
	[Token(Token = "0x200179F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2704", Offset = "0x10F2704")]
	public class UIElitePassPushToUpgradePopupWindow : UIPopupWindowController, IEasyList
	{
		// Token: 0x06007363 RID: 29539 RVA: 0x000200E8 File Offset: 0x0001E2E8
		[Token(Token = "0x6007363")]
		[Address(RVA = "0x1E6A468", Offset = "0x1E6A468", VA = "0x7BBC66A468")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007364 RID: 29540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007364")]
		[Address(RVA = "0x1E6A4B8", Offset = "0x1E6A4B8", VA = "0x7BBC66A4B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007365 RID: 29541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007365")]
		[Address(RVA = "0x1E6A628", Offset = "0x1E6A628", VA = "0x7BBC66A628")]
		public void OnOKButtonClick()
		{
		}

		// Token: 0x06007366 RID: 29542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007366")]
		[Address(RVA = "0x1E6A630", Offset = "0x1E6A630", VA = "0x7BBC66A630")]
		public void OnUpgradeBtnClick()
		{
		}

		// Token: 0x06007367 RID: 29543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007367")]
		[Address(RVA = "0x1E6A6BC", Offset = "0x1E6A6BC", VA = "0x7BBC66A6BC")]
		public void SetRewardsData(List<CommonRewardItemInfo> infoList)
		{
		}

		// Token: 0x06007368 RID: 29544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007368")]
		[Address(RVA = "0x1E6A780", Offset = "0x1E6A780", VA = "0x7BBC66A780", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007369")]
		[Address(RVA = "0x1E6A814", Offset = "0x1E6A814", VA = "0x7BBC66A814", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600736A RID: 29546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600736A")]
		[Address(RVA = "0x1E6A844", Offset = "0x1E6A844", VA = "0x7BBC66A844")]
		public UIElitePassPushToUpgradePopupWindow()
		{
		}

		// Token: 0x04008BE2 RID: 35810
		[Token(Token = "0x4008BE2")]
		[FieldOffset(Offset = "0x98")]
		private UIElitePassPushToUpgradePopupView m_View;
	}
}
