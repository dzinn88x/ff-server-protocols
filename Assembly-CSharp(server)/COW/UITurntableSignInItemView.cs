using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200257B RID: 9595
	[Token(Token = "0x200257B")]
	public class UITurntableSignInItemView : UIBaseView
	{
		// Token: 0x0600C606 RID: 50694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C606")]
		[Address(RVA = "0x19F3B70", Offset = "0x19F3B70", VA = "0x7BBC1F3B70", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C607 RID: 50695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C607")]
		[Address(RVA = "0x19F3E50", Offset = "0x19F3E50", VA = "0x7BBC1F3E50")]
		public UITurntableSignInItemView()
		{
		}

		// Token: 0x0400F67F RID: 63103
		[Token(Token = "0x400F67F")]
		[FieldOffset(Offset = "0x20")]
		public BaseItemView BaseItemView;

		// Token: 0x0400F680 RID: 63104
		[Token(Token = "0x400F680")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ItemBtn;

		// Token: 0x0400F681 RID: 63105
		[Token(Token = "0x400F681")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Rare;

		// Token: 0x0400F682 RID: 63106
		[Token(Token = "0x400F682")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Light;

		// Token: 0x0400F683 RID: 63107
		[Token(Token = "0x400F683")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Count;

		// Token: 0x0400F684 RID: 63108
		[Token(Token = "0x400F684")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Sign;

		// Token: 0x0400F685 RID: 63109
		[Token(Token = "0x400F685")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Time;

		// Token: 0x0400F686 RID: 63110
		[Token(Token = "0x400F686")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BigRewardEffect;

		// Token: 0x0400F687 RID: 63111
		[Token(Token = "0x400F687")]
		[FieldOffset(Offset = "0x60")]
		public GameObject GetRewardEffect;

		// Token: 0x0400F688 RID: 63112
		[Token(Token = "0x400F688")]
		[FieldOffset(Offset = "0x68")]
		public UISprite Sprite_Debris;
	}
}
