using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001AF7 RID: 6903
	[Token(Token = "0x2001AF7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8FF4", Offset = "0x10F8FF4")]
	public class UIPetNormalGridController : UIBaseController, IEasyList
	{
		// Token: 0x06009293 RID: 37523 RVA: 0x00027060 File Offset: 0x00025260
		[Token(Token = "0x6009293")]
		[Address(RVA = "0x20E0B90", Offset = "0x20E0B90", VA = "0x7BBC8E0B90")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009294 RID: 37524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009294")]
		[Address(RVA = "0x20E0BE0", Offset = "0x20E0BE0", VA = "0x7BBC8E0BE0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009295 RID: 37525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009295")]
		[Address(RVA = "0x20E0C70", Offset = "0x20E0C70", VA = "0x7BBC8E0C70", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009296 RID: 37526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009296")]
		[Address(RVA = "0x20DC5DC", Offset = "0x20DC5DC", VA = "0x7BBC8DC5DC")]
		public void ShowActionGridList(List<PetActionData> dataShowList)
		{
		}

		// Token: 0x06009297 RID: 37527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009297")]
		[Address(RVA = "0x20DC684", Offset = "0x20DC684", VA = "0x7BBC8DC684")]
		public void ShowSkinGridList(List<PetSkinData> dataShowList)
		{
		}

		// Token: 0x06009298 RID: 37528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009298")]
		[Address(RVA = "0x20E0C78", Offset = "0x20E0C78", VA = "0x7BBC8E0C78", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06009299 RID: 37529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009299")]
		public void ShowItemAtIndex<T>(int index) where T : UIEasyListItemController
		{
		}

		// Token: 0x0600929A RID: 37530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600929A")]
		[Address(RVA = "0x20E0D24", Offset = "0x20E0D24", VA = "0x7BBC8E0D24", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600929B RID: 37531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600929B")]
		[Address(RVA = "0x20E0D54", Offset = "0x20E0D54", VA = "0x7BBC8E0D54")]
		public UIPetNormalGridController()
		{
		}

		// Token: 0x04009D02 RID: 40194
		[Token(Token = "0x4009D02")]
		private const int ALL_GRID_COLUMN = 3;

		// Token: 0x04009D03 RID: 40195
		[Token(Token = "0x4009D03")]
		[FieldOffset(Offset = "0x58")]
		private UIPetNormalScrollViewView m_View;

		// Token: 0x04009D04 RID: 40196
		[Token(Token = "0x4009D04")]
		[FieldOffset(Offset = "0x60")]
		private UIShowType m_ShowGridFlag;
	}
}
