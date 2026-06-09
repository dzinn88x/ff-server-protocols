using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002481 RID: 9345
	[Token(Token = "0x2002481")]
	internal class UIPaymentTabItemView : UIBaseView
	{
		// Token: 0x0600C412 RID: 50194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C412")]
		[Address(RVA = "0x1F37BD8", Offset = "0x1F37BD8", VA = "0x7BBC737BD8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C413 RID: 50195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C413")]
		[Address(RVA = "0x1F37EA8", Offset = "0x1F37EA8", VA = "0x7BBC737EA8")]
		public UIPaymentTabItemView()
		{
		}

		// Token: 0x0400EAC7 RID: 60103
		[Token(Token = "0x400EAC7")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Button;

		// Token: 0x0400EAC8 RID: 60104
		[Token(Token = "0x400EAC8")]
		[FieldOffset(Offset = "0x28")]
		public UISprite NoteSprite;

		// Token: 0x0400EAC9 RID: 60105
		[Token(Token = "0x400EAC9")]
		[FieldOffset(Offset = "0x30")]
		public UILabel NoteLabel;

		// Token: 0x0400EACA RID: 60106
		[Token(Token = "0x400EACA")]
		[FieldOffset(Offset = "0x38")]
		public UISprite RedDot;

		// Token: 0x0400EACB RID: 60107
		[Token(Token = "0x400EACB")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Normal;

		// Token: 0x0400EACC RID: 60108
		[Token(Token = "0x400EACC")]
		[FieldOffset(Offset = "0x48")]
		public UILabel NormalLabel;

		// Token: 0x0400EACD RID: 60109
		[Token(Token = "0x400EACD")]
		[FieldOffset(Offset = "0x50")]
		public UISprite SubscriptionSprite;

		// Token: 0x0400EACE RID: 60110
		[Token(Token = "0x400EACE")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Selected;

		// Token: 0x0400EACF RID: 60111
		[Token(Token = "0x400EACF")]
		[FieldOffset(Offset = "0x60")]
		public UISprite SelectedSprite;

		// Token: 0x0400EAD0 RID: 60112
		[Token(Token = "0x400EAD0")]
		[FieldOffset(Offset = "0x68")]
		public UILabel SelectedLabel;
	}
}
