using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200199E RID: 6558
	[Token(Token = "0x200199E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6B84", Offset = "0x10F6B84")]
	public class UIHudWereWolvesTaskWolfListController : UIBaseController, IEasyList
	{
		// Token: 0x06008626 RID: 34342 RVA: 0x00024570 File Offset: 0x00022770
		[Token(Token = "0x6008626")]
		[Address(RVA = "0x1D17954", Offset = "0x1D17954", VA = "0x7BBC517954")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008627 RID: 34343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008627")]
		[Address(RVA = "0x1D179A4", Offset = "0x1D179A4", VA = "0x7BBC5179A4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008628 RID: 34344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008628")]
		[Address(RVA = "0x1D17BE4", Offset = "0x1D17BE4", VA = "0x7BBC517BE4", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06008629 RID: 34345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008629")]
		[Address(RVA = "0x1D17D04", Offset = "0x1D17D04", VA = "0x7BBC517D04", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600862A RID: 34346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600862A")]
		[Address(RVA = "0x1D17F0C", Offset = "0x1D17F0C", VA = "0x7BBC517F0C")]
		private void ShowList(bool value)
		{
		}

		// Token: 0x0600862B RID: 34347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600862B")]
		[Address(RVA = "0x1D17F94", Offset = "0x1D17F94", VA = "0x7BBC517F94")]
		private void OnExpandClick()
		{
		}

		// Token: 0x0600862C RID: 34348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600862C")]
		[Address(RVA = "0x1D17F9C", Offset = "0x1D17F9C", VA = "0x7BBC517F9C")]
		private void OnShrinkClick()
		{
		}

		// Token: 0x0600862D RID: 34349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600862D")]
		[Address(RVA = "0x1D17D70", Offset = "0x1D17D70", VA = "0x7BBC517D70")]
		private void OnRefreshTaskList(params object[] data)
		{
		}

		// Token: 0x0600862E RID: 34350 RVA: 0x00024588 File Offset: 0x00022788
		[Token(Token = "0x600862E")]
		[Address(RVA = "0x1D17FA4", Offset = "0x1D17FA4", VA = "0x7BBC517FA4")]
		private int Cmp(sk~A{Af infoA, sk~A{Af infoB)
		{
			return 0;
		}

		// Token: 0x0600862F RID: 34351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600862F")]
		[Address(RVA = "0x1D18008", Offset = "0x1D18008", VA = "0x7BBC518008", Slot = "28")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06008630 RID: 34352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008630")]
		[Address(RVA = "0x1D180C4", Offset = "0x1D180C4", VA = "0x7BBC5180C4", Slot = "29")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06008631 RID: 34353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008631")]
		[Address(RVA = "0x1D180F4", Offset = "0x1D180F4", VA = "0x7BBC5180F4")]
		private void OnShowTaskList(params object[] data)
		{
		}

		// Token: 0x06008632 RID: 34354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008632")]
		[Address(RVA = "0x1D1819C", Offset = "0x1D1819C", VA = "0x7BBC51819C")]
		public UIHudWereWolvesTaskWolfListController()
		{
		}

		// Token: 0x04009570 RID: 38256
		[Token(Token = "0x4009570")]
		[FieldOffset(Offset = "0x58")]
		private UIHudWereWolvesTaskWolfListView m_View;

		// Token: 0x04009571 RID: 38257
		[Token(Token = "0x4009571")]
		[FieldOffset(Offset = "0x60")]
		private List<sk~A{Af> m_TaskList;
	}
}
