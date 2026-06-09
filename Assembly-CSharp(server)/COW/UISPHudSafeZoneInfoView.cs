using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002537 RID: 9527
	[Token(Token = "0x2002537")]
	public class UISPHudSafeZoneInfoView : UIBaseView
	{
		// Token: 0x0600C57E RID: 50558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C57E")]
		[Address(RVA = "0x1EF2B30", Offset = "0x1EF2B30", VA = "0x7BBC6F2B30", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C57F RID: 50559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C57F")]
		[Address(RVA = "0x1EF2E94", Offset = "0x1EF2E94", VA = "0x7BBC6F2E94")]
		public UISPHudSafeZoneInfoView()
		{
		}

		// Token: 0x0400F377 RID: 62327
		[Token(Token = "0x400F377")]
		[FieldOffset(Offset = "0x20")]
		public GameObject InfoContainer;

		// Token: 0x0400F378 RID: 62328
		[Token(Token = "0x400F378")]
		[FieldOffset(Offset = "0x28")]
		public UILabel SafeZoneIndex;

		// Token: 0x0400F379 RID: 62329
		[Token(Token = "0x400F379")]
		[FieldOffset(Offset = "0x30")]
		public UISprite safezoneIndexBg;

		// Token: 0x0400F37A RID: 62330
		[Token(Token = "0x400F37A")]
		[FieldOffset(Offset = "0x38")]
		public GameObject miniModeContainer;

		// Token: 0x0400F37B RID: 62331
		[Token(Token = "0x400F37B")]
		[FieldOffset(Offset = "0x40")]
		public UISprite warningIconMini;

		// Token: 0x0400F37C RID: 62332
		[Token(Token = "0x400F37C")]
		[FieldOffset(Offset = "0x48")]
		public UILabel MiniTimeCount;

		// Token: 0x0400F37D RID: 62333
		[Token(Token = "0x400F37D")]
		[FieldOffset(Offset = "0x50")]
		public TweenAlpha TweenAlphaMini;

		// Token: 0x0400F37E RID: 62334
		[Token(Token = "0x400F37E")]
		[FieldOffset(Offset = "0x58")]
		public UISprite safezoneTimeBg;

		// Token: 0x0400F37F RID: 62335
		[Token(Token = "0x400F37F")]
		[FieldOffset(Offset = "0x60")]
		public UISprite UAVIconMini;

		// Token: 0x0400F380 RID: 62336
		[Token(Token = "0x400F380")]
		[FieldOffset(Offset = "0x68")]
		public UILabel UAVLabelMini;

		// Token: 0x0400F381 RID: 62337
		[Token(Token = "0x400F381")]
		[FieldOffset(Offset = "0x70")]
		public Animator WarningIconAnimator;

		// Token: 0x0400F382 RID: 62338
		[Token(Token = "0x400F382")]
		[FieldOffset(Offset = "0x78")]
		public GameObject BottomGo;
	}
}
