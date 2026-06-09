using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200217A RID: 8570
	[Token(Token = "0x200217A")]
	public class UICollectionVehicleSkinScoreItemView : UIBaseView
	{
		// Token: 0x0600BE04 RID: 48644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE04")]
		[Address(RVA = "0x20ADF34", Offset = "0x20ADF34", VA = "0x7BBC8ADF34", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE05 RID: 48645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE05")]
		[Address(RVA = "0x20AE338", Offset = "0x20AE338", VA = "0x7BBC8AE338")]
		public UICollectionVehicleSkinScoreItemView()
		{
		}

		// Token: 0x0400C737 RID: 50999
		[Token(Token = "0x400C737")]
		[FieldOffset(Offset = "0x20")]
		public UILabel scoreName;

		// Token: 0x0400C738 RID: 51000
		[Token(Token = "0x400C738")]
		[FieldOffset(Offset = "0x28")]
		public TweenAlpha alphaName;

		// Token: 0x0400C739 RID: 51001
		[Token(Token = "0x400C739")]
		[FieldOffset(Offset = "0x30")]
		public GameObject up;

		// Token: 0x0400C73A RID: 51002
		[Token(Token = "0x400C73A")]
		[FieldOffset(Offset = "0x38")]
		public UISprite up1;

		// Token: 0x0400C73B RID: 51003
		[Token(Token = "0x400C73B")]
		[FieldOffset(Offset = "0x40")]
		public TweenAlpha alphaUp1;

		// Token: 0x0400C73C RID: 51004
		[Token(Token = "0x400C73C")]
		[FieldOffset(Offset = "0x48")]
		public UISprite up2;

		// Token: 0x0400C73D RID: 51005
		[Token(Token = "0x400C73D")]
		[FieldOffset(Offset = "0x50")]
		public TweenAlpha alphaUp2;

		// Token: 0x0400C73E RID: 51006
		[Token(Token = "0x400C73E")]
		[FieldOffset(Offset = "0x58")]
		public UISprite up3;

		// Token: 0x0400C73F RID: 51007
		[Token(Token = "0x400C73F")]
		[FieldOffset(Offset = "0x60")]
		public TweenAlpha alphaUp3;

		// Token: 0x0400C740 RID: 51008
		[Token(Token = "0x400C740")]
		[FieldOffset(Offset = "0x68")]
		public GameObject down;

		// Token: 0x0400C741 RID: 51009
		[Token(Token = "0x400C741")]
		[FieldOffset(Offset = "0x70")]
		public UISprite down3;

		// Token: 0x0400C742 RID: 51010
		[Token(Token = "0x400C742")]
		[FieldOffset(Offset = "0x78")]
		public TweenAlpha alphaDown3;

		// Token: 0x0400C743 RID: 51011
		[Token(Token = "0x400C743")]
		[FieldOffset(Offset = "0x80")]
		public UISprite down2;

		// Token: 0x0400C744 RID: 51012
		[Token(Token = "0x400C744")]
		[FieldOffset(Offset = "0x88")]
		public TweenAlpha alphaDown2;

		// Token: 0x0400C745 RID: 51013
		[Token(Token = "0x400C745")]
		[FieldOffset(Offset = "0x90")]
		public UISprite down1;

		// Token: 0x0400C746 RID: 51014
		[Token(Token = "0x400C746")]
		[FieldOffset(Offset = "0x98")]
		public TweenAlpha alphaDown1;
	}
}
