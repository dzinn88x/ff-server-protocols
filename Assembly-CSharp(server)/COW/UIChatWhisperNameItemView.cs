using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002156 RID: 8534
	[Token(Token = "0x2002156")]
	public class UIChatWhisperNameItemView : UIBaseView
	{
		// Token: 0x0600BDBC RID: 48572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDBC")]
		[Address(RVA = "0x1BF0A00", Offset = "0x1BF0A00", VA = "0x7BBC3F0A00", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDBD RID: 48573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDBD")]
		[Address(RVA = "0x1BF0CF8", Offset = "0x1BF0CF8", VA = "0x7BBC3F0CF8")]
		public UIChatWhisperNameItemView()
		{
		}

		// Token: 0x0400C535 RID: 50485
		[Token(Token = "0x400C535")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Btn;

		// Token: 0x0400C536 RID: 50486
		[Token(Token = "0x400C536")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Delate;

		// Token: 0x0400C537 RID: 50487
		[Token(Token = "0x400C537")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Highlight;

		// Token: 0x0400C538 RID: 50488
		[Token(Token = "0x400C538")]
		[FieldOffset(Offset = "0x38")]
		public UISprite HeadPic;

		// Token: 0x0400C539 RID: 50489
		[Token(Token = "0x400C539")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Name;

		// Token: 0x0400C53A RID: 50490
		[Token(Token = "0x400C53A")]
		[FieldOffset(Offset = "0x48")]
		public UISprite LadderIcon;

		// Token: 0x0400C53B RID: 50491
		[Token(Token = "0x400C53B")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Status;

		// Token: 0x0400C53C RID: 50492
		[Token(Token = "0x400C53C")]
		[FieldOffset(Offset = "0x58")]
		public UINetworkTexture HeadNetPic;

		// Token: 0x0400C53D RID: 50493
		[Token(Token = "0x400C53D")]
		[FieldOffset(Offset = "0x60")]
		public GameObject UnreadTip;

		// Token: 0x0400C53E RID: 50494
		[Token(Token = "0x400C53E")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Icon_Celebrity;
	}
}
