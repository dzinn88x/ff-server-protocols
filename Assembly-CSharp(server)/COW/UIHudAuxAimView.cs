using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002271 RID: 8817
	[Token(Token = "0x2002271")]
	public class UIHudAuxAimView : UIBaseView
	{
		// Token: 0x0600BFF3 RID: 49139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFF3")]
		[Address(RVA = "0x188A104", Offset = "0x188A104", VA = "0x7BBC08A104", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFF4 RID: 49140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFF4")]
		[Address(RVA = "0x188A32C", Offset = "0x188A32C", VA = "0x7BBC08A32C")]
		public UIHudAuxAimView()
		{
		}

		// Token: 0x0400D3B4 RID: 54196
		[Token(Token = "0x400D3B4")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnAuxAim;

		// Token: 0x0400D3B5 RID: 54197
		[Token(Token = "0x400D3B5")]
		[FieldOffset(Offset = "0x28")]
		public GameObject SpriteSelectedRoot;

		// Token: 0x0400D3B6 RID: 54198
		[Token(Token = "0x400D3B6")]
		[FieldOffset(Offset = "0x30")]
		public UISprite SpriteSelected;

		// Token: 0x0400D3B7 RID: 54199
		[Token(Token = "0x400D3B7")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SpriteNormal;

		// Token: 0x0400D3B8 RID: 54200
		[Token(Token = "0x400D3B8")]
		[FieldOffset(Offset = "0x40")]
		public Transform iconFire;

		// Token: 0x0400D3B9 RID: 54201
		[Token(Token = "0x400D3B9")]
		[FieldOffset(Offset = "0x48")]
		public UIWidget iconWidget;

		// Token: 0x0400D3BA RID: 54202
		[Token(Token = "0x400D3BA")]
		[FieldOffset(Offset = "0x50")]
		public Transform fire_BG;
	}
}
