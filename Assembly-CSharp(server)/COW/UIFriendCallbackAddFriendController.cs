using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020017C3 RID: 6083
	[Token(Token = "0x20017C3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2B64", Offset = "0x10F2B64")]
	public class UIFriendCallbackAddFriendController : UIPopupWindowController
	{
		// Token: 0x060074B6 RID: 29878 RVA: 0x00020640 File Offset: 0x0001E840
		[Token(Token = "0x60074B6")]
		[Address(RVA = "0x1DBF9B8", Offset = "0x1DBF9B8", VA = "0x7BBC5BF9B8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060074B7 RID: 29879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074B7")]
		[Address(RVA = "0x1DBFA08", Offset = "0x1DBFA08", VA = "0x7BBC5BFA08", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060074B8 RID: 29880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074B8")]
		[Address(RVA = "0x1DBFBE0", Offset = "0x1DBFBE0", VA = "0x7BBC5BFBE0", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060074B9 RID: 29881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074B9")]
		[Address(RVA = "0x1DBFC94", Offset = "0x1DBFC94", VA = "0x7BBC5BFC94")]
		public void SetData(FriendAccountInfo data, Action action)
		{
		}

		// Token: 0x060074BA RID: 29882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074BA")]
		[Address(RVA = "0x1DBFF48", Offset = "0x1DBFF48", VA = "0x7BBC5BFF48")]
		private void OnBtnReWriteClicked()
		{
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074BB")]
		[Address(RVA = "0x1DBFFFC", Offset = "0x1DBFFFC", VA = "0x7BBC5BFFFC")]
		private void OnBtnAddFriendClicked()
		{
		}

		// Token: 0x060074BC RID: 29884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074BC")]
		[Address(RVA = "0x1DC0120", Offset = "0x1DC0120", VA = "0x7BBC5C0120")]
		public UIFriendCallbackAddFriendController()
		{
		}

		// Token: 0x04008C6F RID: 35951
		[Token(Token = "0x4008C6F")]
		[FieldOffset(Offset = "0x98")]
		private UIFriendCallbackAddFriendView m_View;

		// Token: 0x04008C70 RID: 35952
		[Token(Token = "0x4008C70")]
		[FieldOffset(Offset = "0xA0")]
		private FriendAccountInfo m_Data;

		// Token: 0x04008C71 RID: 35953
		[Token(Token = "0x4008C71")]
		[FieldOffset(Offset = "0xA8")]
		private UIBaseProfileInfoController m_BaseProfile;

		// Token: 0x04008C72 RID: 35954
		[Token(Token = "0x4008C72")]
		[FieldOffset(Offset = "0xB0")]
		private Action m_afterAddAction;
	}
}
