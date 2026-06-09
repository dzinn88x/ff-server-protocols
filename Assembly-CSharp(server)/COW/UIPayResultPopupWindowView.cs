using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002486 RID: 9350
	[Token(Token = "0x2002486")]
	internal class UIPayResultPopupWindowView : UIBaseView
	{
		// Token: 0x0600C41C RID: 50204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C41C")]
		[Address(RVA = "0x16ECBBC", Offset = "0x16ECBBC", VA = "0x7BBBEECBBC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C41D RID: 50205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C41D")]
		[Address(RVA = "0x16ED0A4", Offset = "0x16ED0A4", VA = "0x7BBBEED0A4")]
		public UIPayResultPopupWindowView()
		{
		}

		// Token: 0x0400EAEB RID: 60139
		[Token(Token = "0x400EAEB")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel MainWidget;

		// Token: 0x0400EAEC RID: 60140
		[Token(Token = "0x400EAEC")]
		[FieldOffset(Offset = "0x28")]
		public TweenAlpha BgTweenAlpha;

		// Token: 0x0400EAED RID: 60141
		[Token(Token = "0x400EAED")]
		[FieldOffset(Offset = "0x30")]
		public TweenScale WindowTweenScale;

		// Token: 0x0400EAEE RID: 60142
		[Token(Token = "0x400EAEE")]
		[FieldOffset(Offset = "0x38")]
		public TweenAlpha WindowTweenAlpha;

		// Token: 0x0400EAEF RID: 60143
		[Token(Token = "0x400EAEF")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Title;

		// Token: 0x0400EAF0 RID: 60144
		[Token(Token = "0x400EAF0")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BtnCloseGO;

		// Token: 0x0400EAF1 RID: 60145
		[Token(Token = "0x400EAF1")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnClose;

		// Token: 0x0400EAF2 RID: 60146
		[Token(Token = "0x400EAF2")]
		[FieldOffset(Offset = "0x58")]
		public UISprite TextArea;

		// Token: 0x0400EAF3 RID: 60147
		[Token(Token = "0x400EAF3")]
		[FieldOffset(Offset = "0x60")]
		public UITextList Info;

		// Token: 0x0400EAF4 RID: 60148
		[Token(Token = "0x400EAF4")]
		[FieldOffset(Offset = "0x68")]
		public GameObject BtnOKGO;

		// Token: 0x0400EAF5 RID: 60149
		[Token(Token = "0x400EAF5")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnOK;

		// Token: 0x0400EAF6 RID: 60150
		[Token(Token = "0x400EAF6")]
		[FieldOffset(Offset = "0x78")]
		public UISprite BtnOKSprite;

		// Token: 0x0400EAF7 RID: 60151
		[Token(Token = "0x400EAF7")]
		[FieldOffset(Offset = "0x80")]
		public UILabel BtnOKLabel;

		// Token: 0x0400EAF8 RID: 60152
		[Token(Token = "0x400EAF8")]
		[FieldOffset(Offset = "0x88")]
		public GameObject BtnCancelGO;

		// Token: 0x0400EAF9 RID: 60153
		[Token(Token = "0x400EAF9")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnCancel;

		// Token: 0x0400EAFA RID: 60154
		[Token(Token = "0x400EAFA")]
		[FieldOffset(Offset = "0x98")]
		public UISprite BtnCancelSprite;

		// Token: 0x0400EAFB RID: 60155
		[Token(Token = "0x400EAFB")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel BtnCancelLabel;

		// Token: 0x0400EAFC RID: 60156
		[Token(Token = "0x400EAFC")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel Note;
	}
}
