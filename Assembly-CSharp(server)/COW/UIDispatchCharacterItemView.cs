using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021A8 RID: 8616
	[Token(Token = "0x20021A8")]
	public class UIDispatchCharacterItemView : UIBaseView
	{
		// Token: 0x0600BE60 RID: 48736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE60")]
		[Address(RVA = "0x220632C", Offset = "0x220632C", VA = "0x7BBCA0632C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE61 RID: 48737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE61")]
		[Address(RVA = "0x2206644", Offset = "0x2206644", VA = "0x7BBCA06644")]
		public UIDispatchCharacterItemView()
		{
		}

		// Token: 0x0400C969 RID: 51561
		[Token(Token = "0x400C969")]
		[FieldOffset(Offset = "0x20")]
		public Animation ContentContainer;

		// Token: 0x0400C96A RID: 51562
		[Token(Token = "0x400C96A")]
		[FieldOffset(Offset = "0x28")]
		public TweenAlpha ContentContainerAlpha;

		// Token: 0x0400C96B RID: 51563
		[Token(Token = "0x400C96B")]
		[FieldOffset(Offset = "0x30")]
		public TweenScale ContentContainerScale;

		// Token: 0x0400C96C RID: 51564
		[Token(Token = "0x400C96C")]
		[FieldOffset(Offset = "0x38")]
		public UIButton AvatarBtn;

		// Token: 0x0400C96D RID: 51565
		[Token(Token = "0x400C96D")]
		[FieldOffset(Offset = "0x40")]
		public UISprite AvatarImage;

		// Token: 0x0400C96E RID: 51566
		[Token(Token = "0x400C96E")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Selected;

		// Token: 0x0400C96F RID: 51567
		[Token(Token = "0x400C96F")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Order;

		// Token: 0x0400C970 RID: 51568
		[Token(Token = "0x400C970")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Dispatched;

		// Token: 0x0400C971 RID: 51569
		[Token(Token = "0x400C971")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Name;

		// Token: 0x0400C972 RID: 51570
		[Token(Token = "0x400C972")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Clickvfx;

		// Token: 0x0400C973 RID: 51571
		[Token(Token = "0x400C973")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Commonvfx;
	}
}
