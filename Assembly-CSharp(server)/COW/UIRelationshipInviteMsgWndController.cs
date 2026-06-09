using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B51 RID: 6993
	[Token(Token = "0x2001B51")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9B94", Offset = "0x10F9B94")]
	internal class UIRelationshipInviteMsgWndController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x0600964E RID: 38478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600964E")]
		[Address(RVA = "0x1E1D6E0", Offset = "0x1E1D6E0", VA = "0x7BBC61D6E0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600964F RID: 38479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600964F")]
		[Address(RVA = "0x1E1D7E0", Offset = "0x1E1D7E0", VA = "0x7BBC61D7E0", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06009650 RID: 38480 RVA: 0x00027BA0 File Offset: 0x00025DA0
		[Token(Token = "0x6009650")]
		[Address(RVA = "0x1E1D894", Offset = "0x1E1D894", VA = "0x7BBC61D894")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009651 RID: 38481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009651")]
		[Address(RVA = "0x1E1D8E4", Offset = "0x1E1D8E4", VA = "0x7BBC61D8E4")]
		public void SetUIData(List<RelationshipMessageInfo> msgInfos)
		{
		}

		// Token: 0x06009652 RID: 38482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009652")]
		[Address(RVA = "0x1E1DA5C", Offset = "0x1E1DA5C", VA = "0x7BBC61DA5C", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06009653 RID: 38483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009653")]
		[Address(RVA = "0x1E1DAF0", Offset = "0x1E1DAF0", VA = "0x7BBC61DAF0", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06009654 RID: 38484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009654")]
		[Address(RVA = "0x1E1DB20", Offset = "0x1E1DB20", VA = "0x7BBC61DB20", Slot = "42")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009655 RID: 38485 RVA: 0x00027BB8 File Offset: 0x00025DB8
		[Token(Token = "0x6009655")]
		[Address(RVA = "0x1E1DD1C", Offset = "0x1E1DD1C", VA = "0x7BBC61DD1C", Slot = "43")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009656 RID: 38486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009656")]
		[Address(RVA = "0x1E1DD60", Offset = "0x1E1DD60", VA = "0x7BBC61DD60")]
		public UIRelationshipInviteMsgWndController()
		{
		}

		// Token: 0x04009EFA RID: 40698
		[Token(Token = "0x4009EFA")]
		[FieldOffset(Offset = "0x98")]
		private UIRelationshipInviteMsgWndView m_View;
	}
}
