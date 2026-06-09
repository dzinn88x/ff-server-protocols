using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B53 RID: 6995
	[Token(Token = "0x2001B53")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9C04", Offset = "0x10F9C04")]
	internal class UIRelationshipInviteSucessWndController : UIPopupWindowController
	{
		// Token: 0x0600965E RID: 38494 RVA: 0x00027BE8 File Offset: 0x00025DE8
		[Token(Token = "0x600965E")]
		[Address(RVA = "0x1E1E2BC", Offset = "0x1E1E2BC", VA = "0x7BBC61E2BC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600965F RID: 38495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600965F")]
		[Address(RVA = "0x1E1E30C", Offset = "0x1E1E30C", VA = "0x7BBC61E30C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009660 RID: 38496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009660")]
		[Address(RVA = "0x1E1E3F0", Offset = "0x1E1E3F0", VA = "0x7BBC61E3F0")]
		public void SetUIData(BaseProfileInfo myInfo, FriendAccountInfo friendInfo)
		{
		}

		// Token: 0x06009661 RID: 38497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009661")]
		[Address(RVA = "0x1E1E5B0", Offset = "0x1E1E5B0", VA = "0x7BBC61E5B0")]
		public UIRelationshipInviteSucessWndController()
		{
		}

		// Token: 0x04009EFC RID: 40700
		[Token(Token = "0x4009EFC")]
		[FieldOffset(Offset = "0x98")]
		private UIRelationshipInviteSucessWndView m_View;
	}
}
