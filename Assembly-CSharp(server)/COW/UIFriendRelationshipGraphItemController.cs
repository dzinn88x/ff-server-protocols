using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017CD RID: 6093
	[Token(Token = "0x20017CD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2CFC", Offset = "0x10F2CFC")]
	public class UIFriendRelationshipGraphItemController : UIBaseController
	{
		// Token: 0x0600753B RID: 30011 RVA: 0x000208F8 File Offset: 0x0001EAF8
		[Token(Token = "0x600753B")]
		[Address(RVA = "0x1597D24", Offset = "0x1597D24", VA = "0x7BBBD97D24")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x0600753C RID: 30012 RVA: 0x00020910 File Offset: 0x0001EB10
		[Token(Token = "0x1700094F")]
		public ulong AccountID
		{
			[Token(Token = "0x600753C")]
			[Address(RVA = "0x1597CAC", Offset = "0x1597CAC", VA = "0x7BBBD97CAC")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x0600753D RID: 30013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600753D")]
		[Address(RVA = "0x1597D74", Offset = "0x1597D74", VA = "0x7BBBD97D74")]
		public UIFriendRelationshipGraphItemController()
		{
		}

		// Token: 0x0600753E RID: 30014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600753E")]
		[Address(RVA = "0x15969BC", Offset = "0x15969BC", VA = "0x7BBBD969BC")]
		public void SetData(FriendAccountInfo accountInfo, bool canAddFriend)
		{
		}

		// Token: 0x0600753F RID: 30015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600753F")]
		[Address(RVA = "0x1595730", Offset = "0x1595730", VA = "0x7BBBD95730")]
		public void SetData(BaseProfileInfo info, bool canAddFriend)
		{
		}

		// Token: 0x06007540 RID: 30016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007540")]
		[Address(RVA = "0x1597434", Offset = "0x1597434", VA = "0x7BBBD97434")]
		public void ClearData()
		{
		}

		// Token: 0x06007541 RID: 30017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007541")]
		[Address(RVA = "0x1594C5C", Offset = "0x1594C5C", VA = "0x7BBBD94C5C")]
		public void UpdateItemParam(UIFriendRelationshipGraphContainer container)
		{
		}

		// Token: 0x06007542 RID: 30018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007542")]
		[Address(RVA = "0x1597180", Offset = "0x1597180", VA = "0x7BBBD97180")]
		public void ShowAnimVFX()
		{
		}

		// Token: 0x06007543 RID: 30019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007543")]
		[Address(RVA = "0x1597CB4", Offset = "0x1597CB4", VA = "0x7BBBD97CB4")]
		public void EanbelAddFriend(bool enabel)
		{
		}

		// Token: 0x06007544 RID: 30020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007544")]
		[Address(RVA = "0x1595AA4", Offset = "0x1595AA4", VA = "0x7BBBD95AA4")]
		public void SetIfSelf(bool self)
		{
		}

		// Token: 0x06007545 RID: 30021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007545")]
		[Address(RVA = "0x1597E6C", Offset = "0x1597E6C", VA = "0x7BBBD97E6C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007546 RID: 30022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007546")]
		[Address(RVA = "0x1597FA8", Offset = "0x1597FA8", VA = "0x7BBBD97FA8")]
		private void OnAddBtnClick()
		{
		}

		// Token: 0x06007547 RID: 30023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007547")]
		[Address(RVA = "0x15980EC", Offset = "0x15980EC", VA = "0x7BBBD980EC")]
		private void OnDetailInfoBtnClick()
		{
		}

		// Token: 0x06007548 RID: 30024 RVA: 0x00020928 File Offset: 0x0001EB28
		[Token(Token = "0x6007548")]
		[Address(RVA = "0x1597DE8", Offset = "0x1597DE8", VA = "0x7BBBD97DE8")]
		private uint GetAddFriendTag(FriendAccountInfo accountInfo)
		{
			return 0U;
		}

		// Token: 0x04008CC8 RID: 36040
		[Token(Token = "0x4008CC8")]
		[FieldOffset(Offset = "0x58")]
		private UIFriendRelationshipGraphItemView m_View;

		// Token: 0x04008CC9 RID: 36041
		[Token(Token = "0x4008CC9")]
		[FieldOffset(Offset = "0x60")]
		private ulong m_AccountID;

		// Token: 0x04008CCA RID: 36042
		[Token(Token = "0x4008CCA")]
		[FieldOffset(Offset = "0x68")]
		private uint m_FriendTag;

		// Token: 0x04008CCB RID: 36043
		[Token(Token = "0x4008CCB")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_IsSelf;

		// Token: 0x04008CCC RID: 36044
		[Token(Token = "0x4008CCC")]
		[FieldOffset(Offset = "0x6D")]
		private bool m_IsFriend;

		// Token: 0x04008CCD RID: 36045
		[Token(Token = "0x4008CCD")]
		[FieldOffset(Offset = "0x70")]
		private EUIFriendRelationshipType m_RelationshipType;

		// Token: 0x04008CCE RID: 36046
		[Token(Token = "0x4008CCE")]
		[FieldOffset(Offset = "0x74")]
		private Vector2 m_HeadIconSize;

		// Token: 0x04008CCF RID: 36047
		[Token(Token = "0x4008CCF")]
		[FieldOffset(Offset = "0x80")]
		public Action fnClickHeadIconCallBack;
	}
}
