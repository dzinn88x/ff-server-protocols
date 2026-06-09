using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001927 RID: 6439
	[Token(Token = "0x2001927")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5A44", Offset = "0x10F5A44")]
	internal class UIHudPickupListController : UIBaseController
	{
		// Token: 0x0600820A RID: 33290 RVA: 0x000236B8 File Offset: 0x000218B8
		[Token(Token = "0x600820A")]
		[Address(RVA = "0x1D7021C", Offset = "0x1D7021C", VA = "0x7BBC57021C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600820B RID: 33291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600820B")]
		[Address(RVA = "0x1D7026C", Offset = "0x1D7026C", VA = "0x7BBC57026C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600820C RID: 33292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600820C")]
		[Address(RVA = "0x1D7098C", Offset = "0x1D7098C", VA = "0x7BBC57098C")]
		private void OnShowPickUpList(object[] data)
		{
		}

		// Token: 0x0600820D RID: 33293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600820D")]
		[Address(RVA = "0x1D709A8", Offset = "0x1D709A8", VA = "0x7BBC5709A8")]
		public void SetCustomTrans(Vector3 pos)
		{
		}

		// Token: 0x0600820E RID: 33294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600820E")]
		[Address(RVA = "0x1D70A94", Offset = "0x1D70A94", VA = "0x7BBC570A94")]
		private void OnHIdePickUpList(object[] data)
		{
		}

		// Token: 0x0600820F RID: 33295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600820F")]
		[Address(RVA = "0x1D70AB0", Offset = "0x1D70AB0", VA = "0x7BBC570AB0")]
		private void FreezeAutoPickup(object[] data)
		{
		}

		// Token: 0x06008210 RID: 33296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008210")]
		[Address(RVA = "0x1D70AE0", Offset = "0x1D70AE0", VA = "0x7BBC570AE0")]
		private void RefreshPickLevel(object[] data)
		{
		}

		// Token: 0x06008211 RID: 33297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008211")]
		[Address(RVA = "0x1D70E0C", Offset = "0x1D70E0C", VA = "0x7BBC570E0C")]
		private void RefreshItemState(object[] data)
		{
		}

		// Token: 0x06008212 RID: 33298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008212")]
		[Address(RVA = "0x1D70F50", Offset = "0x1D70F50", VA = "0x7BBC570F50", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008213 RID: 33299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008213")]
		[Address(RVA = "0x1D70FB4", Offset = "0x1D70FB4", VA = "0x7BBC570FB4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008214 RID: 33300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008214")]
		[Address(RVA = "0x1D71490", Offset = "0x1D71490", VA = "0x7BBC571490")]
		private void OnAutoPickUp(object[] data)
		{
		}

		// Token: 0x06008215 RID: 33301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008215")]
		[Address(RVA = "0x1D71AC4", Offset = "0x1D71AC4", VA = "0x7BBC571AC4")]
		private void RefreshAutoPickupList(object[] data)
		{
		}

		// Token: 0x06008216 RID: 33302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008216")]
		[Address(RVA = "0x1D720E8", Offset = "0x1D720E8", VA = "0x7BBC5720E8")]
		private void OnPlayerDead(object[] data)
		{
		}

		// Token: 0x06008217 RID: 33303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008217")]
		[Address(RVA = "0x1D7211C", Offset = "0x1D7211C", VA = "0x7BBC57211C")]
		private void SortList(List<^yE\u007FRJO> targetlist)
		{
		}

		// Token: 0x06008218 RID: 33304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008218")]
		[Address(RVA = "0x1D721F8", Offset = "0x1D721F8", VA = "0x7BBC5721F8")]
		private void OnEnterPickupArea(params object[] param)
		{
		}

		// Token: 0x06008219 RID: 33305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008219")]
		[Address(RVA = "0x1D71ACC", Offset = "0x1D71ACC", VA = "0x7BBC571ACC")]
		private void RefreshCurrentPickUpList(EPickupListOp op)
		{
		}

		// Token: 0x0600821A RID: 33306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600821A")]
		[Address(RVA = "0x1D72618", Offset = "0x1D72618", VA = "0x7BBC572618")]
		private void OnExitPickupArea(params object[] param)
		{
		}

		// Token: 0x0600821B RID: 33307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600821B")]
		[Address(RVA = "0x1D726BC", Offset = "0x1D726BC", VA = "0x7BBC5726BC")]
		private void OnSettingChange(object[] data)
		{
		}

		// Token: 0x0600821C RID: 33308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600821C")]
		[Address(RVA = "0x1D72750", Offset = "0x1D72750", VA = "0x7BBC572750")]
		private void OnInventoryOpen(params object[] param)
		{
		}

		// Token: 0x0600821D RID: 33309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600821D")]
		[Address(RVA = "0x1D72BA0", Offset = "0x1D72BA0", VA = "0x7BBC572BA0", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x0600821E RID: 33310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600821E")]
		[Address(RVA = "0x1D72C3C", Offset = "0x1D72C3C", VA = "0x7BBC572C3C")]
		private void OnInventoryClose(params object[] param)
		{
		}

		// Token: 0x0600821F RID: 33311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600821F")]
		[Address(RVA = "0x1D72D54", Offset = "0x1D72D54", VA = "0x7BBC572D54")]
		private void RefreshPickupItem()
		{
		}

		// Token: 0x06008220 RID: 33312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008220")]
		[Address(RVA = "0x1D73F48", Offset = "0x1D73F48", VA = "0x7BBC573F48")]
		private void RefreshPickupNewItem()
		{
		}

		// Token: 0x06008221 RID: 33313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008221")]
		[Address(RVA = "0x1D72544", Offset = "0x1D72544", VA = "0x7BBC572544")]
		private void RefreshUIData()
		{
		}

		// Token: 0x06008222 RID: 33314 RVA: 0x000236D0 File Offset: 0x000218D0
		[Token(Token = "0x6008222")]
		[Address(RVA = "0x1D74328", Offset = "0x1D74328", VA = "0x7BBC574328")]
		public bool CheckInScrollDrag()
		{
			return default(bool);
		}

		// Token: 0x06008223 RID: 33315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008223")]
		[Address(RVA = "0x1D7286C", Offset = "0x1D7286C", VA = "0x7BBC57286C")]
		private void RefreshTutorial()
		{
		}

		// Token: 0x06008224 RID: 33316 RVA: 0x000236E8 File Offset: 0x000218E8
		[Token(Token = "0x6008224")]
		[Address(RVA = "0x1D74428", Offset = "0x1D74428", VA = "0x7BBC574428")]
		public int GetGridepth()
		{
			return 0;
		}

		// Token: 0x06008225 RID: 33317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008225")]
		[Address(RVA = "0x1D74430", Offset = "0x1D74430", VA = "0x7BBC574430")]
		public UIHudPickupListController()
		{
		}

		// Token: 0x04009372 RID: 37746
		[Token(Token = "0x4009372")]
		[FieldOffset(Offset = "0x58")]
		private UIHudPickupListView m_View;

		// Token: 0x04009373 RID: 37747
		[Token(Token = "0x4009373")]
		[FieldOffset(Offset = "0x60")]
		private List<^yE\u007FRJO> m_CurrentPickupList;

		// Token: 0x04009374 RID: 37748
		[Token(Token = "0x4009374")]
		[FieldOffset(Offset = "0x68")]
		private uint m_CurrentContainerID;

		// Token: 0x04009375 RID: 37749
		[Token(Token = "0x4009375")]
		[FieldOffset(Offset = "0x70")]
		private List<UIHudPickupListItemController> m_ItemControllers;

		// Token: 0x04009376 RID: 37750
		[Token(Token = "0x4009376")]
		[FieldOffset(Offset = "0x78")]
		private List<UIHudPickupListItemController> m_InventoryTrashItemControllers;

		// Token: 0x04009377 RID: 37751
		[Token(Token = "0x4009377")]
		[FieldOffset(Offset = "0x80")]
		private float m_InitLocalX;

		// Token: 0x04009378 RID: 37752
		[Token(Token = "0x4009378")]
		[FieldOffset(Offset = "0x84")]
		private bool m_IsInventoryOpen;

		// Token: 0x04009379 RID: 37753
		[Token(Token = "0x4009379")]
		[FieldOffset(Offset = "0x88")]
		private AutoPickUpHelper m_AutoPickUp;

		// Token: 0x0400937A RID: 37754
		[Token(Token = "0x400937A")]
		[FieldOffset(Offset = "0x90")]
		private int m_ScrollViewDepth;

		// Token: 0x0400937B RID: 37755
		[Token(Token = "0x400937B")]
		[FieldOffset(Offset = "0x94")]
		private bool m_IsEnterPickUpArea;

		// Token: 0x0400937C RID: 37756
		[Token(Token = "0x400937C")]
		[FieldOffset(Offset = "0x98")]
		private int m_MaxPickupLength;

		// Token: 0x0400937D RID: 37757
		[Token(Token = "0x400937D")]
		[FieldOffset(Offset = "0x9C")]
		private int pickupcellwidth;

		// Token: 0x0400937E RID: 37758
		[Token(Token = "0x400937E")]
		[FieldOffset(Offset = "0xA0")]
		private int m_MaxItemCount;
	}
}
