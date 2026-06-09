using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002110 RID: 8464
	[Token(Token = "0x2002110")]
	public class UIAvatarUniversalDebrisExchangeView : UIBaseView
	{
		// Token: 0x0600BD31 RID: 48433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD31")]
		[Address(RVA = "0x1E558B8", Offset = "0x1E558B8", VA = "0x7BBC6558B8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD32 RID: 48434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD32")]
		[Address(RVA = "0x1E55BEC", Offset = "0x1E55BEC", VA = "0x7BBC655BEC")]
		public UIAvatarUniversalDebrisExchangeView()
		{
		}

		// Token: 0x0400C1B1 RID: 49585
		[Token(Token = "0x400C1B1")]
		[FieldOffset(Offset = "0x20")]
		public UIEasyList AvatarEasyList;

		// Token: 0x0400C1B2 RID: 49586
		[Token(Token = "0x400C1B2")]
		[FieldOffset(Offset = "0x28")]
		public UILabel CurExchangedCnt;

		// Token: 0x0400C1B3 RID: 49587
		[Token(Token = "0x400C1B3")]
		[FieldOffset(Offset = "0x30")]
		public UILabel universalDebrisCnt;

		// Token: 0x0400C1B4 RID: 49588
		[Token(Token = "0x400C1B4")]
		[FieldOffset(Offset = "0x38")]
		public UISprite currentDebrisIcon;

		// Token: 0x0400C1B5 RID: 49589
		[Token(Token = "0x400C1B5")]
		[FieldOffset(Offset = "0x40")]
		public UILabel currentAvatarName;

		// Token: 0x0400C1B6 RID: 49590
		[Token(Token = "0x400C1B6")]
		[FieldOffset(Offset = "0x48")]
		public UILabel currentDebrisCnt;

		// Token: 0x0400C1B7 RID: 49591
		[Token(Token = "0x400C1B7")]
		[FieldOffset(Offset = "0x50")]
		public UIButton plusBtn;

		// Token: 0x0400C1B8 RID: 49592
		[Token(Token = "0x400C1B8")]
		[FieldOffset(Offset = "0x58")]
		public UIButton minusBtn;

		// Token: 0x0400C1B9 RID: 49593
		[Token(Token = "0x400C1B9")]
		[FieldOffset(Offset = "0x60")]
		public UIButton exchangeAllBtn;

		// Token: 0x0400C1BA RID: 49594
		[Token(Token = "0x400C1BA")]
		[FieldOffset(Offset = "0x68")]
		public UISlider slider;

		// Token: 0x0400C1BB RID: 49595
		[Token(Token = "0x400C1BB")]
		[FieldOffset(Offset = "0x70")]
		public UIButton UseBtn;

		// Token: 0x0400C1BC RID: 49596
		[Token(Token = "0x400C1BC")]
		[FieldOffset(Offset = "0x78")]
		public UISprite BtnBG;
	}
}
