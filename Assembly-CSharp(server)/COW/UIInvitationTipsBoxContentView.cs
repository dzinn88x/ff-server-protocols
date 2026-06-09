using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023CC RID: 9164
	[Token(Token = "0x20023CC")]
	public class UIInvitationTipsBoxContentView : UIBaseView
	{
		// Token: 0x0600C2A8 RID: 49832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2A8")]
		[Address(RVA = "0x1921030", Offset = "0x1921030", VA = "0x7BBC121030", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2A9 RID: 49833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2A9")]
		[Address(RVA = "0x1921574", Offset = "0x1921574", VA = "0x7BBC121574")]
		public UIInvitationTipsBoxContentView()
		{
		}

		// Token: 0x0400DF16 RID: 57110
		[Token(Token = "0x400DF16")]
		[FieldOffset(Offset = "0x20")]
		public Animation Ani;

		// Token: 0x0400DF17 RID: 57111
		[Token(Token = "0x400DF17")]
		[FieldOffset(Offset = "0x28")]
		public UIPanel ContentPanel;

		// Token: 0x0400DF18 RID: 57112
		[Token(Token = "0x400DF18")]
		[FieldOffset(Offset = "0x30")]
		public AnimEvtForwarderIncludeParam AnimIncludeParam;

		// Token: 0x0400DF19 RID: 57113
		[Token(Token = "0x400DF19")]
		[FieldOffset(Offset = "0x38")]
		public UISprite ChangeImage;

		// Token: 0x0400DF1A RID: 57114
		[Token(Token = "0x400DF1A")]
		[FieldOffset(Offset = "0x40")]
		public UIToggle IgnoreToggle;

		// Token: 0x0400DF1B RID: 57115
		[Token(Token = "0x400DF1B")]
		[FieldOffset(Offset = "0x48")]
		public UILabel IgnoreLabel;

		// Token: 0x0400DF1C RID: 57116
		[Token(Token = "0x400DF1C")]
		[FieldOffset(Offset = "0x50")]
		public GameObject InviteRoot;

		// Token: 0x0400DF1D RID: 57117
		[Token(Token = "0x400DF1D")]
		[FieldOffset(Offset = "0x58")]
		public UISprite InviteFromBG;

		// Token: 0x0400DF1E RID: 57118
		[Token(Token = "0x400DF1E")]
		[FieldOffset(Offset = "0x60")]
		public UILabel InviteFrom;

		// Token: 0x0400DF1F RID: 57119
		[Token(Token = "0x400DF1F")]
		[FieldOffset(Offset = "0x68")]
		public UISprite TimeCircle;

		// Token: 0x0400DF20 RID: 57120
		[Token(Token = "0x400DF20")]
		[FieldOffset(Offset = "0x70")]
		public UILabel TimeLabel;

		// Token: 0x0400DF21 RID: 57121
		[Token(Token = "0x400DF21")]
		[FieldOffset(Offset = "0x78")]
		public UILabel TipsTypeLabel;

		// Token: 0x0400DF22 RID: 57122
		[Token(Token = "0x400DF22")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnClose;

		// Token: 0x0400DF23 RID: 57123
		[Token(Token = "0x400DF23")]
		[FieldOffset(Offset = "0x88")]
		public UISprite Sprite;

		// Token: 0x0400DF24 RID: 57124
		[Token(Token = "0x400DF24")]
		[FieldOffset(Offset = "0x90")]
		public UILabel MessageLabel;

		// Token: 0x0400DF25 RID: 57125
		[Token(Token = "0x400DF25")]
		[FieldOffset(Offset = "0x98")]
		public UIButton NameButton;

		// Token: 0x0400DF26 RID: 57126
		[Token(Token = "0x400DF26")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel MessageLabel2;

		// Token: 0x0400DF27 RID: 57127
		[Token(Token = "0x400DF27")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton AcceptBtn;

		// Token: 0x0400DF28 RID: 57128
		[Token(Token = "0x400DF28")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton RejectBtn;

		// Token: 0x0400DF29 RID: 57129
		[Token(Token = "0x400DF29")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel TeamInfoLabel;

		// Token: 0x0400DF2A RID: 57130
		[Token(Token = "0x400DF2A")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject Mask;
	}
}
