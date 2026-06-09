using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002238 RID: 8760
	[Token(Token = "0x2002238")]
	internal class UIGiftGetRewardView : UIBaseView
	{
		// Token: 0x0600BF81 RID: 49025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF81")]
		[Address(RVA = "0x200E0A0", Offset = "0x200E0A0", VA = "0x7BBC80E0A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF82 RID: 49026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF82")]
		[Address(RVA = "0x200E324", Offset = "0x200E324", VA = "0x7BBC80E324")]
		public UIGiftGetRewardView()
		{
		}

		// Token: 0x0400D16A RID: 53610
		[Token(Token = "0x400D16A")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BG;

		// Token: 0x0400D16B RID: 53611
		[Token(Token = "0x400D16B")]
		[FieldOffset(Offset = "0x28")]
		public TweenColor tweenColor;

		// Token: 0x0400D16C RID: 53612
		[Token(Token = "0x400D16C")]
		[FieldOffset(Offset = "0x30")]
		public UIButton OKBtn;

		// Token: 0x0400D16D RID: 53613
		[Token(Token = "0x400D16D")]
		[FieldOffset(Offset = "0x38")]
		public UILabel BtnLabel;

		// Token: 0x0400D16E RID: 53614
		[Token(Token = "0x400D16E")]
		[FieldOffset(Offset = "0x40")]
		public UIButton CloseBtn;

		// Token: 0x0400D16F RID: 53615
		[Token(Token = "0x400D16F")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ReceiverName;

		// Token: 0x0400D170 RID: 53616
		[Token(Token = "0x400D170")]
		[FieldOffset(Offset = "0x50")]
		public UILabel SenderName;

		// Token: 0x0400D171 RID: 53617
		[Token(Token = "0x400D171")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Message;

		// Token: 0x0400D172 RID: 53618
		[Token(Token = "0x400D172")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Title;
	}
}
