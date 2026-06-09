using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021FD RID: 8701
	[Token(Token = "0x20021FD")]
	public class UIFriendRequestItemView : UIBaseView
	{
		// Token: 0x0600BF0B RID: 48907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF0B")]
		[Address(RVA = "0x159C080", Offset = "0x159C080", VA = "0x7BBBD9C080", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF0C RID: 48908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF0C")]
		[Address(RVA = "0x159C304", Offset = "0x159C304", VA = "0x7BBBD9C304")]
		public UIFriendRequestItemView()
		{
		}

		// Token: 0x0400CDE9 RID: 52713
		[Token(Token = "0x400CDE9")]
		[FieldOffset(Offset = "0x20")]
		public GameObject GameFriendProfileContainer;

		// Token: 0x0400CDEA RID: 52714
		[Token(Token = "0x400CDEA")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ItemBtn;

		// Token: 0x0400CDEB RID: 52715
		[Token(Token = "0x400CDEB")]
		[FieldOffset(Offset = "0x30")]
		public GameObject RequestBtnGroupContainer;

		// Token: 0x0400CDEC RID: 52716
		[Token(Token = "0x400CDEC")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BlockBtn;

		// Token: 0x0400CDED RID: 52717
		[Token(Token = "0x400CDED")]
		[FieldOffset(Offset = "0x40")]
		public UIButton RefuseBtn;

		// Token: 0x0400CDEE RID: 52718
		[Token(Token = "0x400CDEE")]
		[FieldOffset(Offset = "0x48")]
		public UIButton AgreeBtn;

		// Token: 0x0400CDEF RID: 52719
		[Token(Token = "0x400CDEF")]
		[FieldOffset(Offset = "0x50")]
		public UISprite FriendBG;

		// Token: 0x0400CDF0 RID: 52720
		[Token(Token = "0x400CDF0")]
		[FieldOffset(Offset = "0x58")]
		public UISprite RequestBG;

		// Token: 0x0400CDF1 RID: 52721
		[Token(Token = "0x400CDF1")]
		[FieldOffset(Offset = "0x60")]
		public UIButton CancelBlockBtn;
	}
}
