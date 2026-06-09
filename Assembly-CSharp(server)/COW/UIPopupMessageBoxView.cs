using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200249D RID: 9373
	[Token(Token = "0x200249D")]
	internal class UIPopupMessageBoxView : UIBaseView
	{
		// Token: 0x0600C44A RID: 50250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C44A")]
		[Address(RVA = "0x216E6A4", Offset = "0x216E6A4", VA = "0x7BBC96E6A4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C44B RID: 50251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C44B")]
		[Address(RVA = "0x216EB7C", Offset = "0x216EB7C", VA = "0x7BBC96EB7C")]
		public UIPopupMessageBoxView()
		{
		}

		// Token: 0x0400EBF3 RID: 60403
		[Token(Token = "0x400EBF3")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel MainWidget;

		// Token: 0x0400EBF4 RID: 60404
		[Token(Token = "0x400EBF4")]
		[FieldOffset(Offset = "0x28")]
		public TweenAlpha BgTweenAlpha;

		// Token: 0x0400EBF5 RID: 60405
		[Token(Token = "0x400EBF5")]
		[FieldOffset(Offset = "0x30")]
		public TweenScale WindowTweenScale;

		// Token: 0x0400EBF6 RID: 60406
		[Token(Token = "0x400EBF6")]
		[FieldOffset(Offset = "0x38")]
		public TweenAlpha WindowTweenAlpha;

		// Token: 0x0400EBF7 RID: 60407
		[Token(Token = "0x400EBF7")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BtnCloseGO;

		// Token: 0x0400EBF8 RID: 60408
		[Token(Token = "0x400EBF8")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnClose;

		// Token: 0x0400EBF9 RID: 60409
		[Token(Token = "0x400EBF9")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Title;

		// Token: 0x0400EBFA RID: 60410
		[Token(Token = "0x400EBFA")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BtnCancelGO;

		// Token: 0x0400EBFB RID: 60411
		[Token(Token = "0x400EBFB")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnCancel;

		// Token: 0x0400EBFC RID: 60412
		[Token(Token = "0x400EBFC")]
		[FieldOffset(Offset = "0x68")]
		public UISprite BtnCancelSprite;

		// Token: 0x0400EBFD RID: 60413
		[Token(Token = "0x400EBFD")]
		[FieldOffset(Offset = "0x70")]
		public UILabel BtnCancelLabel;

		// Token: 0x0400EBFE RID: 60414
		[Token(Token = "0x400EBFE")]
		[FieldOffset(Offset = "0x78")]
		public GameObject BtnOKGO;

		// Token: 0x0400EBFF RID: 60415
		[Token(Token = "0x400EBFF")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnOK;

		// Token: 0x0400EC00 RID: 60416
		[Token(Token = "0x400EC00")]
		[FieldOffset(Offset = "0x88")]
		public UISprite BtnOKSprite;

		// Token: 0x0400EC01 RID: 60417
		[Token(Token = "0x400EC01")]
		[FieldOffset(Offset = "0x90")]
		public UILabel BtnOKLabel;

		// Token: 0x0400EC02 RID: 60418
		[Token(Token = "0x400EC02")]
		[FieldOffset(Offset = "0x98")]
		public UISprite TextArea;

		// Token: 0x0400EC03 RID: 60419
		[Token(Token = "0x400EC03")]
		[FieldOffset(Offset = "0xA0")]
		public UITextList Info;

		// Token: 0x0400EC04 RID: 60420
		[Token(Token = "0x400EC04")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel Note;
	}
}
