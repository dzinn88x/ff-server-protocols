using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B4C RID: 6988
	[Token(Token = "0x2001B4C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9A7C", Offset = "0x10F9A7C")]
	internal class UIRelationshipController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x0600962C RID: 38444 RVA: 0x00027B10 File Offset: 0x00025D10
		[Token(Token = "0x600962C")]
		[Address(RVA = "0x1E1A3AC", Offset = "0x1E1A3AC", VA = "0x7BBC61A3AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600962D RID: 38445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600962D")]
		[Address(RVA = "0x1E1A3FC", Offset = "0x1E1A3FC", VA = "0x7BBC61A3FC", Slot = "20")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600962E RID: 38446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600962E")]
		[Address(RVA = "0x1E1A624", Offset = "0x1E1A624", VA = "0x7BBC61A624", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600962F RID: 38447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600962F")]
		[Address(RVA = "0x1E1A6F0", Offset = "0x1E1A6F0", VA = "0x7BBC61A6F0", Slot = "21")]
		public override void Show()
		{
		}

		// Token: 0x06009630 RID: 38448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009630")]
		[Address(RVA = "0x1E1A8A8", Offset = "0x1E1A8A8", VA = "0x7BBC61A8A8", Slot = "22")]
		public override void Hide()
		{
		}

		// Token: 0x06009631 RID: 38449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009631")]
		[Address(RVA = "0x1E1AAC4", Offset = "0x1E1AAC4", VA = "0x7BBC61AAC4")]
		public void ShowContentByCurrentRelationship(EFriend.RelationType currentType)
		{
		}

		// Token: 0x06009632 RID: 38450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009632")]
		[Address(RVA = "0x1E1ACCC", Offset = "0x1E1ACCC", VA = "0x7BBC61ACCC", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009633 RID: 38451 RVA: 0x00027B28 File Offset: 0x00025D28
		[Token(Token = "0x6009633")]
		[Address(RVA = "0x1E1AD48", Offset = "0x1E1AD48", VA = "0x7BBC61AD48", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009634 RID: 38452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009634")]
		[Address(RVA = "0x1E1AD88", Offset = "0x1E1AD88", VA = "0x7BBC61AD88")]
		public UIRelationshipController()
		{
		}

		// Token: 0x04009EEE RID: 40686
		[Token(Token = "0x4009EEE")]
		[FieldOffset(Offset = "0x58")]
		private UIRelationShipView m_View;

		// Token: 0x04009EEF RID: 40687
		[Token(Token = "0x4009EEF")]
		[FieldOffset(Offset = "0x60")]
		private UICloseFriendController m_CloseFriendController;

		// Token: 0x04009EF0 RID: 40688
		[Token(Token = "0x4009EF0")]
		[FieldOffset(Offset = "0x68")]
		private EFriend.RelationType m_CurrentType;
	}
}
