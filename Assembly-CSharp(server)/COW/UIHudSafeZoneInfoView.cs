using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200235B RID: 9051
	[Token(Token = "0x200235B")]
	public class UIHudSafeZoneInfoView : UIBaseView
	{
		// Token: 0x0600C1C6 RID: 49606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1C6")]
		[Address(RVA = "0x1663BA0", Offset = "0x1663BA0", VA = "0x7BBBE63BA0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1C7 RID: 49607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1C7")]
		[Address(RVA = "0x1664014", Offset = "0x1664014", VA = "0x7BBBE64014")]
		public UIHudSafeZoneInfoView()
		{
		}

		// Token: 0x0400DB51 RID: 56145
		[Token(Token = "0x400DB51")]
		[FieldOffset(Offset = "0x20")]
		public GameObject InfoContainer;

		// Token: 0x0400DB52 RID: 56146
		[Token(Token = "0x400DB52")]
		[FieldOffset(Offset = "0x28")]
		public GameObject warningTips;

		// Token: 0x0400DB53 RID: 56147
		[Token(Token = "0x400DB53")]
		[FieldOffset(Offset = "0x30")]
		public GameObject centerModeContainer;

		// Token: 0x0400DB54 RID: 56148
		[Token(Token = "0x400DB54")]
		[FieldOffset(Offset = "0x38")]
		public UILabel labelTips;

		// Token: 0x0400DB55 RID: 56149
		[Token(Token = "0x400DB55")]
		[FieldOffset(Offset = "0x40")]
		public UIWidget labelbgwidget;

		// Token: 0x0400DB56 RID: 56150
		[Token(Token = "0x400DB56")]
		[FieldOffset(Offset = "0x48")]
		public UISprite warningIcon;

		// Token: 0x0400DB57 RID: 56151
		[Token(Token = "0x400DB57")]
		[FieldOffset(Offset = "0x50")]
		public UIWidget warningwidget;

		// Token: 0x0400DB58 RID: 56152
		[Token(Token = "0x400DB58")]
		[FieldOffset(Offset = "0x58")]
		public UILabel timeCount;

		// Token: 0x0400DB59 RID: 56153
		[Token(Token = "0x400DB59")]
		[FieldOffset(Offset = "0x60")]
		public TweenAlpha TweenAlpha;

		// Token: 0x0400DB5A RID: 56154
		[Token(Token = "0x400DB5A")]
		[FieldOffset(Offset = "0x68")]
		public GameObject miniModeContainer;

		// Token: 0x0400DB5B RID: 56155
		[Token(Token = "0x400DB5B")]
		[FieldOffset(Offset = "0x70")]
		public UISprite warningIconMini;

		// Token: 0x0400DB5C RID: 56156
		[Token(Token = "0x400DB5C")]
		[FieldOffset(Offset = "0x78")]
		public UILabel MiniTimeCount;

		// Token: 0x0400DB5D RID: 56157
		[Token(Token = "0x400DB5D")]
		[FieldOffset(Offset = "0x80")]
		public TweenAlpha TweenAlphaMini;

		// Token: 0x0400DB5E RID: 56158
		[Token(Token = "0x400DB5E")]
		[FieldOffset(Offset = "0x88")]
		public UISprite UAVIconMini;

		// Token: 0x0400DB5F RID: 56159
		[Token(Token = "0x400DB5F")]
		[FieldOffset(Offset = "0x90")]
		public UILabel UAVLabelMini;

		// Token: 0x0400DB60 RID: 56160
		[Token(Token = "0x400DB60")]
		[FieldOffset(Offset = "0x98")]
		public Animator WarningIconAnimator;

		// Token: 0x0400DB61 RID: 56161
		[Token(Token = "0x400DB61")]
		[FieldOffset(Offset = "0xA0")]
		public UIWidget attentionwidget;
	}
}
