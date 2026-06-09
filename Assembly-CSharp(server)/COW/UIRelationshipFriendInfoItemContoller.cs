using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B4E RID: 6990
	[Token(Token = "0x2001B4E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9AEC", Offset = "0x10F9AEC")]
	internal class UIRelationshipFriendInfoItemContoller : UIEasyListItemController
	{
		// Token: 0x0600963C RID: 38460 RVA: 0x00027B58 File Offset: 0x00025D58
		[Token(Token = "0x600963C")]
		[Address(RVA = "0x1E1B3FC", Offset = "0x1E1B3FC", VA = "0x7BBC61B3FC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600963D RID: 38461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600963D")]
		[Address(RVA = "0x1E1B44C", Offset = "0x1E1B44C", VA = "0x7BBC61B44C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600963E RID: 38462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600963E")]
		[Address(RVA = "0x1E1B530", Offset = "0x1E1B530", VA = "0x7BBC61B530")]
		private void OnChooseItemClick()
		{
		}

		// Token: 0x0600963F RID: 38463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600963F")]
		[Address(RVA = "0x1E1B658", Offset = "0x1E1B658", VA = "0x7BBC61B658", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06009640 RID: 38464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009640")]
		[Address(RVA = "0x1E1B800", Offset = "0x1E1B800", VA = "0x7BBC61B800")]
		public UIRelationshipFriendInfoItemContoller()
		{
		}

		// Token: 0x04009EF2 RID: 40690
		[Token(Token = "0x4009EF2")]
		[FieldOffset(Offset = "0x70")]
		private UIBaseProfileInfoController uIBaseProfileInfo;

		// Token: 0x04009EF3 RID: 40691
		[Token(Token = "0x4009EF3")]
		[FieldOffset(Offset = "0x78")]
		private UIRelationshipFriendInfoItemView m_View;

		// Token: 0x04009EF4 RID: 40692
		[Token(Token = "0x4009EF4")]
		[FieldOffset(Offset = "0x80")]
		private FriendAccountInfo m_friendInfo;
	}
}
