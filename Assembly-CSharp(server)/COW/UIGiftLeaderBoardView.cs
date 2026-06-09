using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200223B RID: 8763
	[Token(Token = "0x200223B")]
	internal class UIGiftLeaderBoardView : UIBaseView
	{
		// Token: 0x0600BF87 RID: 49031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF87")]
		[Address(RVA = "0x2012660", Offset = "0x2012660", VA = "0x7BBC812660", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF88 RID: 49032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF88")]
		[Address(RVA = "0x2012A60", Offset = "0x2012A60", VA = "0x7BBC812A60")]
		public UIGiftLeaderBoardView()
		{
		}

		// Token: 0x0400D18F RID: 53647
		[Token(Token = "0x400D18F")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BG;

		// Token: 0x0400D190 RID: 53648
		[Token(Token = "0x400D190")]
		[FieldOffset(Offset = "0x28")]
		public UICountDownLabel LeftTime;

		// Token: 0x0400D191 RID: 53649
		[Token(Token = "0x400D191")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButton ReceiverToggle;

		// Token: 0x0400D192 RID: 53650
		[Token(Token = "0x400D192")]
		[FieldOffset(Offset = "0x38")]
		public UIToggleButton GiverToggle;

		// Token: 0x0400D193 RID: 53651
		[Token(Token = "0x400D193")]
		[FieldOffset(Offset = "0x40")]
		public UIScrollView ContentScrollView;

		// Token: 0x0400D194 RID: 53652
		[Token(Token = "0x400D194")]
		[FieldOffset(Offset = "0x48")]
		public UIEasyList Grid;

		// Token: 0x0400D195 RID: 53653
		[Token(Token = "0x400D195")]
		[FieldOffset(Offset = "0x50")]
		public UILabel title;

		// Token: 0x0400D196 RID: 53654
		[Token(Token = "0x400D196")]
		[FieldOffset(Offset = "0x58")]
		public UIButton BtnClose;

		// Token: 0x0400D197 RID: 53655
		[Token(Token = "0x400D197")]
		[FieldOffset(Offset = "0x60")]
		public GameObject PlayerListTitleBar;

		// Token: 0x0400D198 RID: 53656
		[Token(Token = "0x400D198")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Count;

		// Token: 0x0400D199 RID: 53657
		[Token(Token = "0x400D199")]
		[FieldOffset(Offset = "0x70")]
		public UISprite GiftIcon;

		// Token: 0x0400D19A RID: 53658
		[Token(Token = "0x400D19A")]
		[FieldOffset(Offset = "0x78")]
		public UIEasyList RewardsGrid;

		// Token: 0x0400D19B RID: 53659
		[Token(Token = "0x400D19B")]
		[FieldOffset(Offset = "0x80")]
		public GameObject SelfInfo;

		// Token: 0x0400D19C RID: 53660
		[Token(Token = "0x400D19C")]
		[FieldOffset(Offset = "0x88")]
		public GameObject BaseProfile;
	}
}
