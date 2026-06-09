using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200211F RID: 8479
	[Token(Token = "0x200211F")]
	public class UIBigMapView : UIBaseView
	{
		// Token: 0x0600BD4E RID: 48462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD4E")]
		[Address(RVA = "0x142F364", Offset = "0x142F364", VA = "0x7BBBC2F364", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD4F RID: 48463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD4F")]
		[Address(RVA = "0x142FC8C", Offset = "0x142FC8C", VA = "0x7BBBC2FC8C")]
		public UIBigMapView()
		{
		}

		// Token: 0x0400C242 RID: 49730
		[Token(Token = "0x400C242")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400C243 RID: 49731
		[Token(Token = "0x400C243")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Bg;

		// Token: 0x0400C244 RID: 49732
		[Token(Token = "0x400C244")]
		[FieldOffset(Offset = "0x30")]
		public UIPanel MapContainer;

		// Token: 0x0400C245 RID: 49733
		[Token(Token = "0x400C245")]
		[FieldOffset(Offset = "0x38")]
		public GameObject DebugCatapultContainer;

		// Token: 0x0400C246 RID: 49734
		[Token(Token = "0x400C246")]
		[FieldOffset(Offset = "0x40")]
		public UILabel CatapultMarkLabel;

		// Token: 0x0400C247 RID: 49735
		[Token(Token = "0x400C247")]
		[FieldOffset(Offset = "0x48")]
		public SetRelativeDepth MapEffectDepth;

		// Token: 0x0400C248 RID: 49736
		[Token(Token = "0x400C248")]
		[FieldOffset(Offset = "0x50")]
		public GameObject LeftWidget;

		// Token: 0x0400C249 RID: 49737
		[Token(Token = "0x400C249")]
		[FieldOffset(Offset = "0x58")]
		public UILabel SPSafeZoneTxt;

		// Token: 0x0400C24A RID: 49738
		[Token(Token = "0x400C24A")]
		[FieldOffset(Offset = "0x60")]
		public GameObject HPNode;

		// Token: 0x0400C24B RID: 49739
		[Token(Token = "0x400C24B")]
		[FieldOffset(Offset = "0x68")]
		public UIProgressBar HPBar;

		// Token: 0x0400C24C RID: 49740
		[Token(Token = "0x400C24C")]
		[FieldOffset(Offset = "0x70")]
		public UISprite HPBarFG;

		// Token: 0x0400C24D RID: 49741
		[Token(Token = "0x400C24D")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ProgressLeftEnd;

		// Token: 0x0400C24E RID: 49742
		[Token(Token = "0x400C24E")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ProgressRightEnd;

		// Token: 0x0400C24F RID: 49743
		[Token(Token = "0x400C24F")]
		[FieldOffset(Offset = "0x88")]
		public UILabel HP;

		// Token: 0x0400C250 RID: 49744
		[Token(Token = "0x400C250")]
		[FieldOffset(Offset = "0x90")]
		public GameObject EPNode;

		// Token: 0x0400C251 RID: 49745
		[Token(Token = "0x400C251")]
		[FieldOffset(Offset = "0x98")]
		public UIProgressBar EPBar;

		// Token: 0x0400C252 RID: 49746
		[Token(Token = "0x400C252")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite EPBarFG;

		// Token: 0x0400C253 RID: 49747
		[Token(Token = "0x400C253")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject EPProgressLeftEnd;

		// Token: 0x0400C254 RID: 49748
		[Token(Token = "0x400C254")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject EPProgressRightEnd;

		// Token: 0x0400C255 RID: 49749
		[Token(Token = "0x400C255")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel EP;

		// Token: 0x0400C256 RID: 49750
		[Token(Token = "0x400C256")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject rankingContainer;

		// Token: 0x0400C257 RID: 49751
		[Token(Token = "0x400C257")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject DropAttachmentLabel;

		// Token: 0x0400C258 RID: 49752
		[Token(Token = "0x400C258")]
		[FieldOffset(Offset = "0xD0")]
		public UIGrid AttachmentGrid;

		// Token: 0x0400C259 RID: 49753
		[Token(Token = "0x400C259")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject WolfTipRoot;

		// Token: 0x0400C25A RID: 49754
		[Token(Token = "0x400C25A")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject HumanTipRoot;

		// Token: 0x0400C25B RID: 49755
		[Token(Token = "0x400C25B")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject RightWidget;

		// Token: 0x0400C25C RID: 49756
		[Token(Token = "0x400C25C")]
		[FieldOffset(Offset = "0xF0")]
		public UIButton left_Close;

		// Token: 0x0400C25D RID: 49757
		[Token(Token = "0x400C25D")]
		[FieldOffset(Offset = "0xF8")]
		public UIButton BtnClose;

		// Token: 0x0400C25E RID: 49758
		[Token(Token = "0x400C25E")]
		[FieldOffset(Offset = "0x100")]
		public GameObject Tips1;

		// Token: 0x0400C25F RID: 49759
		[Token(Token = "0x400C25F")]
		[FieldOffset(Offset = "0x108")]
		public GameObject Tips2;

		// Token: 0x0400C260 RID: 49760
		[Token(Token = "0x400C260")]
		[FieldOffset(Offset = "0x110")]
		public GameObject Tips3;

		// Token: 0x0400C261 RID: 49761
		[Token(Token = "0x400C261")]
		[FieldOffset(Offset = "0x118")]
		public GameObject BtnJump;

		// Token: 0x0400C262 RID: 49762
		[Token(Token = "0x400C262")]
		[FieldOffset(Offset = "0x120")]
		public GameObject RightReviveWidget;

		// Token: 0x0400C263 RID: 49763
		[Token(Token = "0x400C263")]
		[FieldOffset(Offset = "0x128")]
		public GameObject Tips4;

		// Token: 0x0400C264 RID: 49764
		[Token(Token = "0x400C264")]
		[FieldOffset(Offset = "0x130")]
		public GameObject Tips5;

		// Token: 0x0400C265 RID: 49765
		[Token(Token = "0x400C265")]
		[FieldOffset(Offset = "0x138")]
		public GameObject Tips6;

		// Token: 0x0400C266 RID: 49766
		[Token(Token = "0x400C266")]
		[FieldOffset(Offset = "0x140")]
		public UIButton BtnRevive;

		// Token: 0x0400C267 RID: 49767
		[Token(Token = "0x400C267")]
		[FieldOffset(Offset = "0x148")]
		public UICountDownLabel CountDown;

		// Token: 0x0400C268 RID: 49768
		[Token(Token = "0x400C268")]
		[FieldOffset(Offset = "0x150")]
		public UIButton BtnQuitRevive;
	}
}
