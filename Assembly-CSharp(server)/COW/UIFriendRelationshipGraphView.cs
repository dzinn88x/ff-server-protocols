using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021FC RID: 8700
	[Token(Token = "0x20021FC")]
	public class UIFriendRelationshipGraphView : UIBaseView
	{
		// Token: 0x0600BF09 RID: 48905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF09")]
		[Address(RVA = "0x159873C", Offset = "0x159873C", VA = "0x7BBBD9873C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF0A RID: 48906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF0A")]
		[Address(RVA = "0x1598B48", Offset = "0x1598B48", VA = "0x7BBBD98B48")]
		public UIFriendRelationshipGraphView()
		{
		}

		// Token: 0x0400CDD9 RID: 52697
		[Token(Token = "0x400CDD9")]
		[FieldOffset(Offset = "0x20")]
		public GameObject VFX_RelationShip_CloseFriend;

		// Token: 0x0400CDDA RID: 52698
		[Token(Token = "0x400CDDA")]
		[FieldOffset(Offset = "0x28")]
		public UIFriendRelationshipGraphContainer SelfItem;

		// Token: 0x0400CDDB RID: 52699
		[Token(Token = "0x400CDDB")]
		[FieldOffset(Offset = "0x30")]
		public UIFriendRelationshipGraphContainer CloseFriend_1;

		// Token: 0x0400CDDC RID: 52700
		[Token(Token = "0x400CDDC")]
		[FieldOffset(Offset = "0x38")]
		public UIFriendRelationshipGraphContainer BLayerFriend_1;

		// Token: 0x0400CDDD RID: 52701
		[Token(Token = "0x400CDDD")]
		[FieldOffset(Offset = "0x40")]
		public UIFriendRelationshipGraphContainer BLayerFriend_2;

		// Token: 0x0400CDDE RID: 52702
		[Token(Token = "0x400CDDE")]
		[FieldOffset(Offset = "0x48")]
		public UIFriendRelationshipGraphContainer BLayerFriend_3;

		// Token: 0x0400CDDF RID: 52703
		[Token(Token = "0x400CDDF")]
		[FieldOffset(Offset = "0x50")]
		public GameObject CLayer;

		// Token: 0x0400CDE0 RID: 52704
		[Token(Token = "0x400CDE0")]
		[FieldOffset(Offset = "0x58")]
		public UIFriendRelationshipGraphContainer CLayerFriend_1;

		// Token: 0x0400CDE1 RID: 52705
		[Token(Token = "0x400CDE1")]
		[FieldOffset(Offset = "0x60")]
		public UIFriendRelationshipGraphContainer CLayerFriend_2;

		// Token: 0x0400CDE2 RID: 52706
		[Token(Token = "0x400CDE2")]
		[FieldOffset(Offset = "0x68")]
		public UIFriendRelationshipGraphContainer CLayerFriend_3;

		// Token: 0x0400CDE3 RID: 52707
		[Token(Token = "0x400CDE3")]
		[FieldOffset(Offset = "0x70")]
		public UIFriendRelationshipGraphContainer CLayerFriend_4;

		// Token: 0x0400CDE4 RID: 52708
		[Token(Token = "0x400CDE4")]
		[FieldOffset(Offset = "0x78")]
		public UIFriendRelationshipGraphContainer CLayerFriend_5;

		// Token: 0x0400CDE5 RID: 52709
		[Token(Token = "0x400CDE5")]
		[FieldOffset(Offset = "0x80")]
		public UIFriendRelationshipGraphContainer DLayerFriend_1;

		// Token: 0x0400CDE6 RID: 52710
		[Token(Token = "0x400CDE6")]
		[FieldOffset(Offset = "0x88")]
		public UIFriendRelationshipGraphContainer DLayerFriend_2;

		// Token: 0x0400CDE7 RID: 52711
		[Token(Token = "0x400CDE7")]
		[FieldOffset(Offset = "0x90")]
		public UIButton leaveBtn;

		// Token: 0x0400CDE8 RID: 52712
		[Token(Token = "0x400CDE8")]
		[FieldOffset(Offset = "0x98")]
		public UIButton shareBtn;
	}
}
