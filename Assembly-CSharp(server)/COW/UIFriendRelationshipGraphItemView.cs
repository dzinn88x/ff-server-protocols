using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021FB RID: 8699
	[Token(Token = "0x20021FB")]
	public class UIFriendRelationshipGraphItemView : UIBaseView
	{
		// Token: 0x0600BF07 RID: 48903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF07")]
		[Address(RVA = "0x1598208", Offset = "0x1598208", VA = "0x7BBBD98208", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF08 RID: 48904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF08")]
		[Address(RVA = "0x1598734", Offset = "0x1598734", VA = "0x7BBBD98734")]
		public UIFriendRelationshipGraphItemView()
		{
		}

		// Token: 0x0400CDC5 RID: 52677
		[Token(Token = "0x400CDC5")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget FriendBG;

		// Token: 0x0400CDC6 RID: 52678
		[Token(Token = "0x400CDC6")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ClosefriendBG;

		// Token: 0x0400CDC7 RID: 52679
		[Token(Token = "0x400CDC7")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget ClosefriendBG2;

		// Token: 0x0400CDC8 RID: 52680
		[Token(Token = "0x400CDC8")]
		[FieldOffset(Offset = "0x38")]
		public UIWidget SelfBG;

		// Token: 0x0400CDC9 RID: 52681
		[Token(Token = "0x400CDC9")]
		[FieldOffset(Offset = "0x40")]
		public GameObject EmptyIcon;

		// Token: 0x0400CDCA RID: 52682
		[Token(Token = "0x400CDCA")]
		[FieldOffset(Offset = "0x48")]
		public UISprite HeadSprite;

		// Token: 0x0400CDCB RID: 52683
		[Token(Token = "0x400CDCB")]
		[FieldOffset(Offset = "0x50")]
		public UIEffectSprite HeadSpriteEffect;

		// Token: 0x0400CDCC RID: 52684
		[Token(Token = "0x400CDCC")]
		[FieldOffset(Offset = "0x58")]
		public UIWidget FakeSprite;

		// Token: 0x0400CDCD RID: 52685
		[Token(Token = "0x400CDCD")]
		[FieldOffset(Offset = "0x60")]
		public UINetworkTexture HeadIcon;

		// Token: 0x0400CDCE RID: 52686
		[Token(Token = "0x400CDCE")]
		[FieldOffset(Offset = "0x68")]
		public UIWidget HeadIconWidget;

		// Token: 0x0400CDCF RID: 52687
		[Token(Token = "0x400CDCF")]
		[FieldOffset(Offset = "0x70")]
		public UIButton DetailInfoBtn;

		// Token: 0x0400CDD0 RID: 52688
		[Token(Token = "0x400CDD0")]
		[FieldOffset(Offset = "0x78")]
		public UIWidget DetailInfoBtnWidget;

		// Token: 0x0400CDD1 RID: 52689
		[Token(Token = "0x400CDD1")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ExtraInfo;

		// Token: 0x0400CDD2 RID: 52690
		[Token(Token = "0x400CDD2")]
		[FieldOffset(Offset = "0x88")]
		public UILabel NickName;

		// Token: 0x0400CDD3 RID: 52691
		[Token(Token = "0x400CDD3")]
		[FieldOffset(Offset = "0x90")]
		public UILabel NickNameScroll;

		// Token: 0x0400CDD4 RID: 52692
		[Token(Token = "0x400CDD4")]
		[FieldOffset(Offset = "0x98")]
		public UIButton AddBtn;

		// Token: 0x0400CDD5 RID: 52693
		[Token(Token = "0x400CDD5")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite ArrowIcon;

		// Token: 0x0400CDD6 RID: 52694
		[Token(Token = "0x400CDD6")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject ClosefriendTips;

		// Token: 0x0400CDD7 RID: 52695
		[Token(Token = "0x400CDD7")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject SelffriendTips;

		// Token: 0x0400CDD8 RID: 52696
		[Token(Token = "0x400CDD8")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject VFX_RelationShipGraphUpdate;
	}
}
