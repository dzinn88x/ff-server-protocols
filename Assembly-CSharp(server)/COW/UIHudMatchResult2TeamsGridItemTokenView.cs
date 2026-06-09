using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200230B RID: 8971
	[Token(Token = "0x200230B")]
	public class UIHudMatchResult2TeamsGridItemTokenView : UIBaseView
	{
		// Token: 0x0600C126 RID: 49446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C126")]
		[Address(RVA = "0x15C52B4", Offset = "0x15C52B4", VA = "0x7BBBDC52B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C127 RID: 49447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C127")]
		[Address(RVA = "0x15C56A4", Offset = "0x15C56A4", VA = "0x7BBBDC56A4")]
		public UIHudMatchResult2TeamsGridItemTokenView()
		{
		}

		// Token: 0x0400D8A9 RID: 55465
		[Token(Token = "0x400D8A9")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Self;

		// Token: 0x0400D8AA RID: 55466
		[Token(Token = "0x400D8AA")]
		[FieldOffset(Offset = "0x28")]
		public UIButton SimpleProfileInfo;

		// Token: 0x0400D8AB RID: 55467
		[Token(Token = "0x400D8AB")]
		[FieldOffset(Offset = "0x30")]
		public GameObject fakeBg;

		// Token: 0x0400D8AC RID: 55468
		[Token(Token = "0x400D8AC")]
		[FieldOffset(Offset = "0x38")]
		public UIEffectSprite bannerBg;

		// Token: 0x0400D8AD RID: 55469
		[Token(Token = "0x400D8AD")]
		[FieldOffset(Offset = "0x40")]
		public UISprite HeadIcon;

		// Token: 0x0400D8AE RID: 55470
		[Token(Token = "0x400D8AE")]
		[FieldOffset(Offset = "0x48")]
		public GameObject infoContainer;

		// Token: 0x0400D8AF RID: 55471
		[Token(Token = "0x400D8AF")]
		[FieldOffset(Offset = "0x50")]
		public UILabel nickname;

		// Token: 0x0400D8B0 RID: 55472
		[Token(Token = "0x400D8B0")]
		[FieldOffset(Offset = "0x58")]
		public UILabel clanName;

		// Token: 0x0400D8B1 RID: 55473
		[Token(Token = "0x400D8B1")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Kill;

		// Token: 0x0400D8B2 RID: 55474
		[Token(Token = "0x400D8B2")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Death;

		// Token: 0x0400D8B3 RID: 55475
		[Token(Token = "0x400D8B3")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Assist;

		// Token: 0x0400D8B4 RID: 55476
		[Token(Token = "0x400D8B4")]
		[FieldOffset(Offset = "0x78")]
		public UILabel Damage;

		// Token: 0x0400D8B5 RID: 55477
		[Token(Token = "0x400D8B5")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Evaluation;

		// Token: 0x0400D8B6 RID: 55478
		[Token(Token = "0x400D8B6")]
		[FieldOffset(Offset = "0x88")]
		public GameObject Mvp;

		// Token: 0x0400D8B7 RID: 55479
		[Token(Token = "0x400D8B7")]
		[FieldOffset(Offset = "0x90")]
		public UIButton AddFriendBtn;
	}
}
