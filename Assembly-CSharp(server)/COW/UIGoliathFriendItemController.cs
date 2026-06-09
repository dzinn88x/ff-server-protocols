using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001378 RID: 4984
	[Token(Token = "0x2001378")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB5D0", Offset = "0x10EB5D0")]
	public class UIGoliathFriendItemController : UIEasyListItemController
	{
		// Token: 0x06004FF7 RID: 20471 RVA: 0x00018528 File Offset: 0x00016728
		[Token(Token = "0x6004FF7")]
		[Address(RVA = "0x1A6E978", Offset = "0x1A6E978", VA = "0x7BBC26E978")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004FF8 RID: 20472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FF8")]
		[Address(RVA = "0x1A6E9C8", Offset = "0x1A6E9C8", VA = "0x7BBC26E9C8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FF9")]
		[Address(RVA = "0x1A6EB30", Offset = "0x1A6EB30", VA = "0x7BBC26EB30", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06004FFA RID: 20474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FFA")]
		[Address(RVA = "0x1A6EB38", Offset = "0x1A6EB38", VA = "0x7BBC26EB38", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06004FFB RID: 20475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FFB")]
		[Address(RVA = "0x1A6EBE8", Offset = "0x1A6EBE8", VA = "0x7BBC26EBE8", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06004FFC RID: 20476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FFC")]
		[Address(RVA = "0x1A6F038", Offset = "0x1A6F038", VA = "0x7BBC26F038")]
		private void OnBtnInviteClick()
		{
		}

		// Token: 0x06004FFD RID: 20477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FFD")]
		[Address(RVA = "0x1A6F334", Offset = "0x1A6F334", VA = "0x7BBC26F334")]
		public UIGoliathFriendItemController()
		{
		}

		// Token: 0x04007689 RID: 30345
		[Token(Token = "0x4007689")]
		[FieldOffset(Offset = "0x70")]
		private UIGoliathFriendItemView m_View;

		// Token: 0x0400768A RID: 30346
		[Token(Token = "0x400768A")]
		[FieldOffset(Offset = "0x78")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x0400768B RID: 30347
		[Token(Token = "0x400768B")]
		[FieldOffset(Offset = "0x80")]
		private UIModelGoliath m_ModelGoliath;

		// Token: 0x0400768C RID: 30348
		[Token(Token = "0x400768C")]
		[FieldOffset(Offset = "0x88")]
		private ulong m_AccountID;

		// Token: 0x0400768D RID: 30349
		[Token(Token = "0x400768D")]
		[FieldOffset(Offset = "0x90")]
		private FastBigEventMsg m_Msg;

		// Token: 0x0400768E RID: 30350
		[Token(Token = "0x400768E")]
		[FieldOffset(Offset = "0x98")]
		private UIBaseProfileInfoController m_BaseProfile;

		// Token: 0x0400768F RID: 30351
		[Token(Token = "0x400768F")]
		private const uint LABEL_COLOR_GROUP_FULL = 3166419967U;

		// Token: 0x04007690 RID: 30352
		[Token(Token = "0x4007690")]
		private const uint LABEL_COLOR_GROUP_NOT_FULL = 4294967295U;

		// Token: 0x04007691 RID: 30353
		[Token(Token = "0x4007691")]
		private const uint BTN_COLOR_GROUP_FULL = 1784566527U;

		// Token: 0x04007692 RID: 30354
		[Token(Token = "0x4007692")]
		private const uint BTN_COLOR_GROUP_NOT_FULL = 4294967295U;
	}
}
