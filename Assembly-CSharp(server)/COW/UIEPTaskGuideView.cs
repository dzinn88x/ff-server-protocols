using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021D2 RID: 8658
	[Token(Token = "0x20021D2")]
	public class UIEPTaskGuideView : UIBaseView
	{
		// Token: 0x0600BEB5 RID: 48821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB5")]
		[Address(RVA = "0x1ACF540", Offset = "0x1ACF540", VA = "0x7BBC2CF540", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEB6 RID: 48822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB6")]
		[Address(RVA = "0x1ACF88C", Offset = "0x1ACF88C", VA = "0x7BBC2CF88C")]
		public UIEPTaskGuideView()
		{
		}

		// Token: 0x0400CB6D RID: 52077
		[Token(Token = "0x400CB6D")]
		[FieldOffset(Offset = "0x20")]
		public TweenAlpha AvatarSpr;

		// Token: 0x0400CB6E RID: 52078
		[Token(Token = "0x400CB6E")]
		[FieldOffset(Offset = "0x28")]
		public UILabel GuideInfo;

		// Token: 0x0400CB6F RID: 52079
		[Token(Token = "0x400CB6F")]
		[FieldOffset(Offset = "0x30")]
		public UIButton btnNext;

		// Token: 0x0400CB70 RID: 52080
		[Token(Token = "0x400CB70")]
		[FieldOffset(Offset = "0x38")]
		public UIButton btnNext1;

		// Token: 0x0400CB71 RID: 52081
		[Token(Token = "0x400CB71")]
		[FieldOffset(Offset = "0x40")]
		public GameObject EpTaskEntry;

		// Token: 0x0400CB72 RID: 52082
		[Token(Token = "0x400CB72")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Effect_Circle;

		// Token: 0x0400CB73 RID: 52083
		[Token(Token = "0x400CB73")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Effect_Arrow;

		// Token: 0x0400CB74 RID: 52084
		[Token(Token = "0x400CB74")]
		[FieldOffset(Offset = "0x58")]
		public TweenPosition UI_CommonGuide_Arrow;

		// Token: 0x0400CB75 RID: 52085
		[Token(Token = "0x400CB75")]
		[FieldOffset(Offset = "0x60")]
		public GameObject EpTaskEntryPos;

		// Token: 0x0400CB76 RID: 52086
		[Token(Token = "0x400CB76")]
		[FieldOffset(Offset = "0x68")]
		public Transform ClickEffect;

		// Token: 0x0400CB77 RID: 52087
		[Token(Token = "0x400CB77")]
		[FieldOffset(Offset = "0x70")]
		public UIButton btnEntry;

		// Token: 0x0400CB78 RID: 52088
		[Token(Token = "0x400CB78")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BtnBg;
	}
}
