using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021CD RID: 8653
	[Token(Token = "0x20021CD")]
	public class UIEPDebrisExchangeView : UIBaseView
	{
		// Token: 0x0600BEAB RID: 48811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEAB")]
		[Address(RVA = "0x2214284", Offset = "0x2214284", VA = "0x7BBCA14284", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEAC RID: 48812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEAC")]
		[Address(RVA = "0x2214518", Offset = "0x2214518", VA = "0x7BBCA14518")]
		public UIEPDebrisExchangeView()
		{
		}

		// Token: 0x0400CB47 RID: 52039
		[Token(Token = "0x400CB47")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BGStyle0;

		// Token: 0x0400CB48 RID: 52040
		[Token(Token = "0x400CB48")]
		[FieldOffset(Offset = "0x28")]
		public Transform BGTopPos0;

		// Token: 0x0400CB49 RID: 52041
		[Token(Token = "0x400CB49")]
		[FieldOffset(Offset = "0x30")]
		public Transform BGBottomPos0;

		// Token: 0x0400CB4A RID: 52042
		[Token(Token = "0x400CB4A")]
		[FieldOffset(Offset = "0x38")]
		public UIButton ConfirmBtn;

		// Token: 0x0400CB4B RID: 52043
		[Token(Token = "0x400CB4B")]
		[FieldOffset(Offset = "0x40")]
		public UISprite BadgeCntFrom;

		// Token: 0x0400CB4C RID: 52044
		[Token(Token = "0x400CB4C")]
		[FieldOffset(Offset = "0x48")]
		public UILabel CntFrom;

		// Token: 0x0400CB4D RID: 52045
		[Token(Token = "0x400CB4D")]
		[FieldOffset(Offset = "0x50")]
		public UISprite BadgeCntTo;

		// Token: 0x0400CB4E RID: 52046
		[Token(Token = "0x400CB4E")]
		[FieldOffset(Offset = "0x58")]
		public UILabel CntTo;

		// Token: 0x0400CB4F RID: 52047
		[Token(Token = "0x400CB4F")]
		[FieldOffset(Offset = "0x60")]
		public UIEasyList RewardList;
	}
}
