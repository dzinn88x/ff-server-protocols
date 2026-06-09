using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021FE RID: 8702
	[Token(Token = "0x20021FE")]
	public class UIFriendRequestView : UIBaseView
	{
		// Token: 0x0600BF0D RID: 48909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF0D")]
		[Address(RVA = "0x159C30C", Offset = "0x159C30C", VA = "0x7BBBD9C30C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF0E RID: 48910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF0E")]
		[Address(RVA = "0x159C6EC", Offset = "0x159C6EC", VA = "0x7BBBD9C6EC")]
		public UIFriendRequestView()
		{
		}

		// Token: 0x0400CDF2 RID: 52722
		[Token(Token = "0x400CDF2")]
		[FieldOffset(Offset = "0x20")]
		public Transform LeftContainer;

		// Token: 0x0400CDF3 RID: 52723
		[Token(Token = "0x400CDF3")]
		[FieldOffset(Offset = "0x28")]
		public UIButton RequestToggle;

		// Token: 0x0400CDF4 RID: 52724
		[Token(Token = "0x400CDF4")]
		[FieldOffset(Offset = "0x30")]
		public GameObject FriendRequstLabel;

		// Token: 0x0400CDF5 RID: 52725
		[Token(Token = "0x400CDF5")]
		[FieldOffset(Offset = "0x38")]
		public GameObject FriendRequstUnSelected;

		// Token: 0x0400CDF6 RID: 52726
		[Token(Token = "0x400CDF6")]
		[FieldOffset(Offset = "0x40")]
		public GameObject FriendRequstSelected;

		// Token: 0x0400CDF7 RID: 52727
		[Token(Token = "0x400CDF7")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BlocklistToggle;

		// Token: 0x0400CDF8 RID: 52728
		[Token(Token = "0x400CDF8")]
		[FieldOffset(Offset = "0x50")]
		public GameObject BlockListLabel;

		// Token: 0x0400CDF9 RID: 52729
		[Token(Token = "0x400CDF9")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BlockListUnSelected;

		// Token: 0x0400CDFA RID: 52730
		[Token(Token = "0x400CDFA")]
		[FieldOffset(Offset = "0x60")]
		public GameObject BlockListSelected;

		// Token: 0x0400CDFB RID: 52731
		[Token(Token = "0x400CDFB")]
		[FieldOffset(Offset = "0x68")]
		public UIScrollView FriendListScrollView;

		// Token: 0x0400CDFC RID: 52732
		[Token(Token = "0x400CDFC")]
		[FieldOffset(Offset = "0x70")]
		public UIEasyList FirendList;

		// Token: 0x0400CDFD RID: 52733
		[Token(Token = "0x400CDFD")]
		[FieldOffset(Offset = "0x78")]
		public UILabel FriendListEmptyHint;

		// Token: 0x0400CDFE RID: 52734
		[Token(Token = "0x400CDFE")]
		[FieldOffset(Offset = "0x80")]
		public GameObject RequestContainer;

		// Token: 0x0400CDFF RID: 52735
		[Token(Token = "0x400CDFF")]
		[FieldOffset(Offset = "0x88")]
		public UICheckboxButton CheckboxBtn;

		// Token: 0x0400CE00 RID: 52736
		[Token(Token = "0x400CE00")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnRefuseAll;
	}
}
