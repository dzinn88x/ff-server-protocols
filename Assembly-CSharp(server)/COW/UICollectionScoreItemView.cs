using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002179 RID: 8569
	[Token(Token = "0x2002179")]
	public class UICollectionScoreItemView : UIBaseView
	{
		// Token: 0x0600BE02 RID: 48642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE02")]
		[Address(RVA = "0x20AD2D4", Offset = "0x20AD2D4", VA = "0x7BBC8AD2D4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE03 RID: 48643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE03")]
		[Address(RVA = "0x20AD854", Offset = "0x20AD854", VA = "0x7BBC8AD854")]
		public UICollectionScoreItemView()
		{
		}

		// Token: 0x0400C721 RID: 50977
		[Token(Token = "0x400C721")]
		[FieldOffset(Offset = "0x20")]
		public GameObject pro;

		// Token: 0x0400C722 RID: 50978
		[Token(Token = "0x400C722")]
		[FieldOffset(Offset = "0x28")]
		public GameObject down;

		// Token: 0x0400C723 RID: 50979
		[Token(Token = "0x400C723")]
		[FieldOffset(Offset = "0x30")]
		public UISprite down3;

		// Token: 0x0400C724 RID: 50980
		[Token(Token = "0x400C724")]
		[FieldOffset(Offset = "0x38")]
		public TweenAlpha alphaDown3;

		// Token: 0x0400C725 RID: 50981
		[Token(Token = "0x400C725")]
		[FieldOffset(Offset = "0x40")]
		public UISprite down2;

		// Token: 0x0400C726 RID: 50982
		[Token(Token = "0x400C726")]
		[FieldOffset(Offset = "0x48")]
		public TweenAlpha alphaDown2;

		// Token: 0x0400C727 RID: 50983
		[Token(Token = "0x400C727")]
		[FieldOffset(Offset = "0x50")]
		public UISprite down1;

		// Token: 0x0400C728 RID: 50984
		[Token(Token = "0x400C728")]
		[FieldOffset(Offset = "0x58")]
		public TweenAlpha alphaDown1;

		// Token: 0x0400C729 RID: 50985
		[Token(Token = "0x400C729")]
		[FieldOffset(Offset = "0x60")]
		public GameObject up;

		// Token: 0x0400C72A RID: 50986
		[Token(Token = "0x400C72A")]
		[FieldOffset(Offset = "0x68")]
		public UISprite up1;

		// Token: 0x0400C72B RID: 50987
		[Token(Token = "0x400C72B")]
		[FieldOffset(Offset = "0x70")]
		public TweenAlpha alphaUp1;

		// Token: 0x0400C72C RID: 50988
		[Token(Token = "0x400C72C")]
		[FieldOffset(Offset = "0x78")]
		public UISprite up2;

		// Token: 0x0400C72D RID: 50989
		[Token(Token = "0x400C72D")]
		[FieldOffset(Offset = "0x80")]
		public TweenAlpha alphaUp2;

		// Token: 0x0400C72E RID: 50990
		[Token(Token = "0x400C72E")]
		[FieldOffset(Offset = "0x88")]
		public UISprite up3;

		// Token: 0x0400C72F RID: 50991
		[Token(Token = "0x400C72F")]
		[FieldOffset(Offset = "0x90")]
		public TweenAlpha alphaUp3;

		// Token: 0x0400C730 RID: 50992
		[Token(Token = "0x400C730")]
		[FieldOffset(Offset = "0x98")]
		public UILabel scoreName;

		// Token: 0x0400C731 RID: 50993
		[Token(Token = "0x400C731")]
		[FieldOffset(Offset = "0xA0")]
		public TweenAlpha alphaName;

		// Token: 0x0400C732 RID: 50994
		[Token(Token = "0x400C732")]
		[FieldOffset(Offset = "0xA8")]
		public UIProgressBar scoreBar;

		// Token: 0x0400C733 RID: 50995
		[Token(Token = "0x400C733")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite BarFG;

		// Token: 0x0400C734 RID: 50996
		[Token(Token = "0x400C734")]
		[FieldOffset(Offset = "0xB8")]
		public UISprite deltaFg;

		// Token: 0x0400C735 RID: 50997
		[Token(Token = "0x400C735")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel scoreValue;

		// Token: 0x0400C736 RID: 50998
		[Token(Token = "0x400C736")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel deltaValue;
	}
}
