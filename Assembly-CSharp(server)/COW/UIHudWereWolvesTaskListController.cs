using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200199C RID: 6556
	[Token(Token = "0x200199C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6B4C", Offset = "0x10F6B4C")]
	public class UIHudWereWolvesTaskListController : UIBaseController, IEasyList
	{
		// Token: 0x06008619 RID: 34329 RVA: 0x00024540 File Offset: 0x00022740
		[Token(Token = "0x6008619")]
		[Address(RVA = "0x1D16B48", Offset = "0x1D16B48", VA = "0x7BBC516B48")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600861A RID: 34330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600861A")]
		[Address(RVA = "0x1D16B98", Offset = "0x1D16B98", VA = "0x7BBC516B98", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600861B RID: 34331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600861B")]
		[Address(RVA = "0x1D16D00", Offset = "0x1D16D00", VA = "0x7BBC516D00", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600861C RID: 34332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600861C")]
		[Address(RVA = "0x1D16E20", Offset = "0x1D16E20", VA = "0x7BBC516E20", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600861D RID: 34333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600861D")]
		[Address(RVA = "0x1D16E80", Offset = "0x1D16E80", VA = "0x7BBC516E80")]
		private void OnRefreshTaskList(params object[] data)
		{
		}

		// Token: 0x0600861E RID: 34334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600861E")]
		[Address(RVA = "0x1D16FC4", Offset = "0x1D16FC4", VA = "0x7BBC516FC4", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600861F RID: 34335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600861F")]
		[Address(RVA = "0x1D17080", Offset = "0x1D17080", VA = "0x7BBC517080", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06008620 RID: 34336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008620")]
		[Address(RVA = "0x1D170B0", Offset = "0x1D170B0", VA = "0x7BBC5170B0")]
		private void OnShowTaskList(params object[] data)
		{
		}

		// Token: 0x06008621 RID: 34337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008621")]
		[Address(RVA = "0x1D17158", Offset = "0x1D17158", VA = "0x7BBC517158")]
		public UIHudWereWolvesTaskListController()
		{
		}

		// Token: 0x0400956C RID: 38252
		[Token(Token = "0x400956C")]
		[FieldOffset(Offset = "0x58")]
		private UIHudWereWolvesTaskListView m_View;

		// Token: 0x0400956D RID: 38253
		[Token(Token = "0x400956D")]
		[FieldOffset(Offset = "0x60")]
		private List<x\u0081N]zYp> m_TaskList;
	}
}
