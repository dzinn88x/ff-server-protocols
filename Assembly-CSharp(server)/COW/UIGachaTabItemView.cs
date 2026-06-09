using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002229 RID: 8745
	[Token(Token = "0x2002229")]
	public class UIGachaTabItemView : UIBaseView
	{
		// Token: 0x0600BF63 RID: 48995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF63")]
		[Address(RVA = "0x1FA3854", Offset = "0x1FA3854", VA = "0x7BBC7A3854", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF64 RID: 48996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF64")]
		[Address(RVA = "0x1FA3A3C", Offset = "0x1FA3A3C", VA = "0x7BBC7A3A3C")]
		public UIGachaTabItemView()
		{
		}

		// Token: 0x0400D03E RID: 53310
		[Token(Token = "0x400D03E")]
		[FieldOffset(Offset = "0x20")]
		public Animation AnimationScale;

		// Token: 0x0400D03F RID: 53311
		[Token(Token = "0x400D03F")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture NetworkTexture;

		// Token: 0x0400D040 RID: 53312
		[Token(Token = "0x400D040")]
		[FieldOffset(Offset = "0x30")]
		public UIButton ItemBtn;

		// Token: 0x0400D041 RID: 53313
		[Token(Token = "0x400D041")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Icon;

		// Token: 0x0400D042 RID: 53314
		[Token(Token = "0x400D042")]
		[FieldOffset(Offset = "0x40")]
		public UISprite NewsIcon;

		// Token: 0x0400D043 RID: 53315
		[Token(Token = "0x400D043")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Effect_Glow;
	}
}
