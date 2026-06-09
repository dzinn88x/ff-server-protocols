using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002411 RID: 9233
	[Token(Token = "0x2002411")]
	internal class UIMallBannerItemView : UIBaseView
	{
		// Token: 0x0600C332 RID: 49970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C332")]
		[Address(RVA = "0x1CE819C", Offset = "0x1CE819C", VA = "0x7BBC4E819C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C333 RID: 49971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C333")]
		[Address(RVA = "0x1CE8338", Offset = "0x1CE8338", VA = "0x7BBC4E8338")]
		public UIMallBannerItemView()
		{
		}

		// Token: 0x0400E3E4 RID: 58340
		[Token(Token = "0x400E3E4")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400E3E5 RID: 58341
		[Token(Token = "0x400E3E5")]
		[FieldOffset(Offset = "0x28")]
		public UISprite bg;

		// Token: 0x0400E3E6 RID: 58342
		[Token(Token = "0x400E3E6")]
		[FieldOffset(Offset = "0x30")]
		public UIEffectSprite banner;

		// Token: 0x0400E3E7 RID: 58343
		[Token(Token = "0x400E3E7")]
		[FieldOffset(Offset = "0x38")]
		public UISprite miniBanner;

		// Token: 0x0400E3E8 RID: 58344
		[Token(Token = "0x400E3E8")]
		[FieldOffset(Offset = "0x40")]
		public UILabel name;
	}
}
