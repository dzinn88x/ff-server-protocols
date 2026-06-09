using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002349 RID: 9033
	[Token(Token = "0x2002349")]
	public class UIHudReaperMatchResultItemView : UIBaseView
	{
		// Token: 0x0600C1A2 RID: 49570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1A2")]
		[Address(RVA = "0x17EB804", Offset = "0x17EB804", VA = "0x7BBBFEB804", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1A3 RID: 49571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1A3")]
		[Address(RVA = "0x17EBACC", Offset = "0x17EBACC", VA = "0x7BBBFEBACC")]
		public UIHudReaperMatchResultItemView()
		{
		}

		// Token: 0x0400DACF RID: 56015
		[Token(Token = "0x400DACF")]
		[FieldOffset(Offset = "0x20")]
		public GameObject bg;

		// Token: 0x0400DAD0 RID: 56016
		[Token(Token = "0x400DAD0")]
		[FieldOffset(Offset = "0x28")]
		public GameObject selfBg;

		// Token: 0x0400DAD1 RID: 56017
		[Token(Token = "0x400DAD1")]
		[FieldOffset(Offset = "0x30")]
		public GameObject TopBG;

		// Token: 0x0400DAD2 RID: 56018
		[Token(Token = "0x400DAD2")]
		[FieldOffset(Offset = "0x38")]
		public UISprite HeadIcon;

		// Token: 0x0400DAD3 RID: 56019
		[Token(Token = "0x400DAD3")]
		[FieldOffset(Offset = "0x40")]
		public UILabel nickname;

		// Token: 0x0400DAD4 RID: 56020
		[Token(Token = "0x400DAD4")]
		[FieldOffset(Offset = "0x48")]
		public UILabel clanName;

		// Token: 0x0400DAD5 RID: 56021
		[Token(Token = "0x400DAD5")]
		[FieldOffset(Offset = "0x50")]
		public UILabel ReaperKill;

		// Token: 0x0400DAD6 RID: 56022
		[Token(Token = "0x400DAD6")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Kill;

		// Token: 0x0400DAD7 RID: 56023
		[Token(Token = "0x400DAD7")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Rank;

		// Token: 0x0400DAD8 RID: 56024
		[Token(Token = "0x400DAD8")]
		[FieldOffset(Offset = "0x68")]
		public UIButton AddFriendBtn;
	}
}
