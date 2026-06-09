using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002503 RID: 9475
	[Token(Token = "0x2002503")]
	public class UISPHudCSRoundMVPView : UIBaseView
	{
		// Token: 0x0600C518 RID: 50456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C518")]
		[Address(RVA = "0x1EE19E0", Offset = "0x1EE19E0", VA = "0x7BBC6E19E0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C519 RID: 50457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C519")]
		[Address(RVA = "0x1EE1F38", Offset = "0x1EE1F38", VA = "0x7BBC6E1F38")]
		public UISPHudCSRoundMVPView()
		{
		}

		// Token: 0x0400F19F RID: 61855
		[Token(Token = "0x400F19F")]
		[FieldOffset(Offset = "0x20")]
		public Animator Animator;

		// Token: 0x0400F1A0 RID: 61856
		[Token(Token = "0x400F1A0")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Content;

		// Token: 0x0400F1A1 RID: 61857
		[Token(Token = "0x400F1A1")]
		[FieldOffset(Offset = "0x30")]
		public UISprite WinSpriteLeft;

		// Token: 0x0400F1A2 RID: 61858
		[Token(Token = "0x400F1A2")]
		[FieldOffset(Offset = "0x38")]
		public UISprite WinSpriteRight;

		// Token: 0x0400F1A3 RID: 61859
		[Token(Token = "0x400F1A3")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Kill;

		// Token: 0x0400F1A4 RID: 61860
		[Token(Token = "0x400F1A4")]
		[FieldOffset(Offset = "0x48")]
		public UILabel KillValue;

		// Token: 0x0400F1A5 RID: 61861
		[Token(Token = "0x400F1A5")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Damage;

		// Token: 0x0400F1A6 RID: 61862
		[Token(Token = "0x400F1A6")]
		[FieldOffset(Offset = "0x58")]
		public UILabel DamageValue;

		// Token: 0x0400F1A7 RID: 61863
		[Token(Token = "0x400F1A7")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Assist;

		// Token: 0x0400F1A8 RID: 61864
		[Token(Token = "0x400F1A8")]
		[FieldOffset(Offset = "0x68")]
		public UILabel AssistValue;

		// Token: 0x0400F1A9 RID: 61865
		[Token(Token = "0x400F1A9")]
		[FieldOffset(Offset = "0x70")]
		public GameObject mvpPlayer;

		// Token: 0x0400F1AA RID: 61866
		[Token(Token = "0x400F1AA")]
		[FieldOffset(Offset = "0x78")]
		public UITexture Avatar;

		// Token: 0x0400F1AB RID: 61867
		[Token(Token = "0x400F1AB")]
		[FieldOffset(Offset = "0x80")]
		public UILabel roundNum;

		// Token: 0x0400F1AC RID: 61868
		[Token(Token = "0x400F1AC")]
		[FieldOffset(Offset = "0x88")]
		public UILabel MVPPlayerName;

		// Token: 0x0400F1AD RID: 61869
		[Token(Token = "0x400F1AD")]
		[FieldOffset(Offset = "0x90")]
		public GameObject DefaultFaction_Right;

		// Token: 0x0400F1AE RID: 61870
		[Token(Token = "0x400F1AE")]
		[FieldOffset(Offset = "0x98")]
		public UISprite wolf_R;

		// Token: 0x0400F1AF RID: 61871
		[Token(Token = "0x400F1AF")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject RightTeam;

		// Token: 0x0400F1B0 RID: 61872
		[Token(Token = "0x400F1B0")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject DefaultFaction_Left;

		// Token: 0x0400F1B1 RID: 61873
		[Token(Token = "0x400F1B1")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite wolf_L;

		// Token: 0x0400F1B2 RID: 61874
		[Token(Token = "0x400F1B2")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject LeftTeam;

		// Token: 0x0400F1B3 RID: 61875
		[Token(Token = "0x400F1B3")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject FactionIcon;

		// Token: 0x0400F1B4 RID: 61876
		[Token(Token = "0x400F1B4")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite wolf;
	}
}
