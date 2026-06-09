using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B52 RID: 6994
	[Token(Token = "0x2001B52")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9BCC", Offset = "0x10F9BCC")]
	internal class UIRelationshipInvitePickWndController : UIPopupWindowController, IEasyList
	{
		// Token: 0x06009657 RID: 38487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009657")]
		[Address(RVA = "0x1E1DE60", Offset = "0x1E1DE60", VA = "0x7BBC61DE60", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06009658 RID: 38488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009658")]
		[Address(RVA = "0x1E1DE68", Offset = "0x1E1DE68", VA = "0x7BBC61DE68", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009659 RID: 38489 RVA: 0x00027BD0 File Offset: 0x00025DD0
		[Token(Token = "0x6009659")]
		[Address(RVA = "0x1E1DEF8", Offset = "0x1E1DEF8", VA = "0x7BBC61DEF8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600965A RID: 38490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600965A")]
		[Address(RVA = "0x1E1DF48", Offset = "0x1E1DF48", VA = "0x7BBC61DF48", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600965B RID: 38491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600965B")]
		[Address(RVA = "0x1E1DF78", Offset = "0x1E1DF78", VA = "0x7BBC61DF78", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600965C RID: 38492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600965C")]
		[Address(RVA = "0x1E1E00C", Offset = "0x1E1E00C", VA = "0x7BBC61E00C")]
		public void SetUIData(List<FriendAccountInfo> needShowFriendList)
		{
		}

		// Token: 0x0600965D RID: 38493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600965D")]
		[Address(RVA = "0x1E1E18C", Offset = "0x1E1E18C", VA = "0x7BBC61E18C")]
		public UIRelationshipInvitePickWndController()
		{
		}

		// Token: 0x04009EFB RID: 40699
		[Token(Token = "0x4009EFB")]
		[FieldOffset(Offset = "0x98")]
		private UIRelationshipInvitePickWndView m_View;
	}
}
