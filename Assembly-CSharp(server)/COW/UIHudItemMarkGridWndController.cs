using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018F2 RID: 6386
	[Token(Token = "0x20018F2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F53DC", Offset = "0x10F53DC")]
	internal class UIHudItemMarkGridWndController : UIBaseController
	{
		// Token: 0x06008006 RID: 32774 RVA: 0x00022EC0 File Offset: 0x000210C0
		[Token(Token = "0x6008006")]
		[Address(RVA = "0x1C48324", Offset = "0x1C48324", VA = "0x7BBC448324")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008007 RID: 32775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008007")]
		[Address(RVA = "0x1C48374", Offset = "0x1C48374", VA = "0x7BBC448374", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008008 RID: 32776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008008")]
		[Address(RVA = "0x1C4867C", Offset = "0x1C4867C", VA = "0x7BBC44867C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008009 RID: 32777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008009")]
		[Address(RVA = "0x1C488EC", Offset = "0x1C488EC", VA = "0x7BBC4488EC")]
		private void RefreshShowList(params object[] param)
		{
		}

		// Token: 0x0600800A RID: 32778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600800A")]
		[Address(RVA = "0x1C4916C", Offset = "0x1C4916C", VA = "0x7BBC44916C")]
		private void OnEnterPickupArea(params object[] param)
		{
		}

		// Token: 0x0600800B RID: 32779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600800B")]
		[Address(RVA = "0x1C49170", Offset = "0x1C49170", VA = "0x7BBC449170")]
		private void OnLocalPlayerBeHit(params object[] param)
		{
		}

		// Token: 0x0600800C RID: 32780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600800C")]
		[Address(RVA = "0x1C49174", Offset = "0x1C49174", VA = "0x7BBC449174")]
		private void ExitChooseWndState()
		{
		}

		// Token: 0x0600800D RID: 32781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600800D")]
		[Address(RVA = "0x1C49340", Offset = "0x1C49340", VA = "0x7BBC449340")]
		private void OnExitPickupArea(params object[] param)
		{
		}

		// Token: 0x0600800E RID: 32782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600800E")]
		[Address(RVA = "0x1C49344", Offset = "0x1C49344", VA = "0x7BBC449344")]
		private void OnChooseOneItemMark(params object[] param)
		{
		}

		// Token: 0x0600800F RID: 32783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600800F")]
		[Address(RVA = "0x1C494E4", Offset = "0x1C494E4", VA = "0x7BBC4494E4")]
		private void OnClickEndShow()
		{
		}

		// Token: 0x06008010 RID: 32784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008010")]
		[Address(RVA = "0x1C494E8", Offset = "0x1C494E8", VA = "0x7BBC4494E8", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008011 RID: 32785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008011")]
		[Address(RVA = "0x1C48980", Offset = "0x1C48980", VA = "0x7BBC448980")]
		public void RefreshPickUpDataList(LevelContainerBase container, bool isTriggerOpen, bool showAllInfo)
		{
		}

		// Token: 0x06008012 RID: 32786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008012")]
		[Address(RVA = "0x1C4923C", Offset = "0x1C4923C", VA = "0x7BBC44923C")]
		private void ClearMarkItemControllers()
		{
		}

		// Token: 0x06008013 RID: 32787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008013")]
		[Address(RVA = "0x1C49694", Offset = "0x1C49694", VA = "0x7BBC449694")]
		private void ShowMarkItemUI(uint dataID, uint Count, Vector3 Position, byte ContainerType)
		{
		}

		// Token: 0x06008014 RID: 32788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008014")]
		[Address(RVA = "0x1C49CCC", Offset = "0x1C49CCC", VA = "0x7BBC449CCC")]
		public UIHudItemMarkGridWndController()
		{
		}

		// Token: 0x04009277 RID: 37495
		[Token(Token = "0x4009277")]
		[FieldOffset(Offset = "0x58")]
		private UIHudMarkItemShowGridWndView m_View;

		// Token: 0x04009278 RID: 37496
		[Token(Token = "0x4009278")]
		[FieldOffset(Offset = "0x60")]
		private List<UIHudItemMarkShowItemController> m_ItemControllers;

		// Token: 0x04009279 RID: 37497
		[Token(Token = "0x4009279")]
		[FieldOffset(Offset = "0x68")]
		private LevelContainerBase m_CurrentContainer;

		// Token: 0x0400927A RID: 37498
		[Token(Token = "0x400927A")]
		[FieldOffset(Offset = "0x70")]
		private uint m_CacheContainerTypeID;

		// Token: 0x0400927B RID: 37499
		[Token(Token = "0x400927B")]
		[FieldOffset(Offset = "0x74")]
		private int m_CurrentLen;

		// Token: 0x0400927C RID: 37500
		[Token(Token = "0x400927C")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 m_CurrentMarkPosition;

		// Token: 0x0400927D RID: 37501
		[Token(Token = "0x400927D")]
		[FieldOffset(Offset = "0x84")]
		private int m_initItemCount;

		// Token: 0x0400927E RID: 37502
		[Token(Token = "0x400927E")]
		[FieldOffset(Offset = "0x88")]
		private bool m_triggerOpen;

		// Token: 0x0400927F RID: 37503
		[Token(Token = "0x400927F")]
		[FieldOffset(Offset = "0x89")]
		private bool m_ShowAllInfo;
	}
}
