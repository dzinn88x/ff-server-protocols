using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001437 RID: 5175
	[Token(Token = "0x2001437")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECA10", Offset = "0x10ECA10")]
	public class UIAwakenLimitAvatarController : UIPopupWindowController
	{
		// Token: 0x060055E4 RID: 21988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E4")]
		[Address(RVA = "0x141BBDC", Offset = "0x141BBDC", VA = "0x7BBBC1BBDC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060055E5 RID: 21989 RVA: 0x00019950 File Offset: 0x00017B50
		[Token(Token = "0x60055E5")]
		[Address(RVA = "0x141BD70", Offset = "0x141BD70", VA = "0x7BBBC1BD70")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060055E6 RID: 21990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E6")]
		[Address(RVA = "0x141BDC0", Offset = "0x141BDC0", VA = "0x7BBBC1BDC0")]
		private void OnGotoClick()
		{
		}

		// Token: 0x060055E7 RID: 21991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E7")]
		[Address(RVA = "0x141C2F4", Offset = "0x141C2F4", VA = "0x7BBBC1C2F4")]
		public UIAwakenLimitAvatarController()
		{
		}

		// Token: 0x04007AAC RID: 31404
		[Token(Token = "0x4007AAC")]
		[FieldOffset(Offset = "0x98")]
		private UIAwakenLimitAvatarView m_View;

		// Token: 0x04007AAD RID: 31405
		[Token(Token = "0x4007AAD")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelAvatarProfile m_Model;
	}
}
