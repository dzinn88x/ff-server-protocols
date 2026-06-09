using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023B3 RID: 9139
	[Token(Token = "0x20023B3")]
	public class UIHudWereWolvesVoteItemView : UIBaseView
	{
		// Token: 0x0600C276 RID: 49782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C276")]
		[Address(RVA = "0x1D1E750", Offset = "0x1D1E750", VA = "0x7BBC51E750", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C277 RID: 49783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C277")]
		[Address(RVA = "0x1D1EB08", Offset = "0x1D1EB08", VA = "0x7BBC51EB08")]
		public UIHudWereWolvesVoteItemView()
		{
		}

		// Token: 0x0400DDF2 RID: 56818
		[Token(Token = "0x400DDF2")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnItem;

		// Token: 0x0400DDF3 RID: 56819
		[Token(Token = "0x400DDF3")]
		[FieldOffset(Offset = "0x28")]
		public GameObject SelfBG;

		// Token: 0x0400DDF4 RID: 56820
		[Token(Token = "0x400DDF4")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BG;

		// Token: 0x0400DDF5 RID: 56821
		[Token(Token = "0x400DDF5")]
		[FieldOffset(Offset = "0x38")]
		public UILabel NameLabel;

		// Token: 0x0400DDF6 RID: 56822
		[Token(Token = "0x400DDF6")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnQuickChat;

		// Token: 0x0400DDF7 RID: 56823
		[Token(Token = "0x400DDF7")]
		[FieldOffset(Offset = "0x48")]
		public UISprite HeadPic;

		// Token: 0x0400DDF8 RID: 56824
		[Token(Token = "0x400DDF8")]
		[FieldOffset(Offset = "0x50")]
		public UISprite HeadPicBg;

		// Token: 0x0400DDF9 RID: 56825
		[Token(Token = "0x400DDF9")]
		[FieldOffset(Offset = "0x58")]
		public GameObject SelectObj;

		// Token: 0x0400DDFA RID: 56826
		[Token(Token = "0x400DDFA")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Voted;

		// Token: 0x0400DDFB RID: 56827
		[Token(Token = "0x400DDFB")]
		[FieldOffset(Offset = "0x68")]
		public UISprite CountBG;

		// Token: 0x0400DDFC RID: 56828
		[Token(Token = "0x400DDFC")]
		[FieldOffset(Offset = "0x70")]
		public UILabel CountLabel;

		// Token: 0x0400DDFD RID: 56829
		[Token(Token = "0x400DDFD")]
		[FieldOffset(Offset = "0x78")]
		public GameObject DeadSprite;

		// Token: 0x0400DDFE RID: 56830
		[Token(Token = "0x400DDFE")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Mic;

		// Token: 0x0400DDFF RID: 56831
		[Token(Token = "0x400DDFF")]
		[FieldOffset(Offset = "0x88")]
		public UIGrid VotedGridList;
	}
}
