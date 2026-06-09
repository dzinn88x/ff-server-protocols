using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200258F RID: 9615
	[Token(Token = "0x200258F")]
	public class UIWeaponItemView : UIBaseView
	{
		// Token: 0x0600C62E RID: 50734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C62E")]
		[Address(RVA = "0x168885C", Offset = "0x168885C", VA = "0x7BBBE8885C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C62F RID: 50735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C62F")]
		[Address(RVA = "0x1688D1C", Offset = "0x1688D1C", VA = "0x7BBBE88D1C")]
		public UIWeaponItemView()
		{
		}

		// Token: 0x0400F735 RID: 63285
		[Token(Token = "0x400F735")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemButton;

		// Token: 0x0400F736 RID: 63286
		[Token(Token = "0x400F736")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Quality;

		// Token: 0x0400F737 RID: 63287
		[Token(Token = "0x400F737")]
		[FieldOffset(Offset = "0x30")]
		public UISprite QualityBG;

		// Token: 0x0400F738 RID: 63288
		[Token(Token = "0x400F738")]
		[FieldOffset(Offset = "0x38")]
		public GameObject gray;

		// Token: 0x0400F739 RID: 63289
		[Token(Token = "0x400F739")]
		[FieldOffset(Offset = "0x40")]
		public GameObject effectBg;

		// Token: 0x0400F73A RID: 63290
		[Token(Token = "0x400F73A")]
		[FieldOffset(Offset = "0x48")]
		public UISprite VehicleSprite;

		// Token: 0x0400F73B RID: 63291
		[Token(Token = "0x400F73B")]
		[FieldOffset(Offset = "0x50")]
		public UISprite WeaponSprite;

		// Token: 0x0400F73C RID: 63292
		[Token(Token = "0x400F73C")]
		[FieldOffset(Offset = "0x58")]
		public GameObject TipsGO;

		// Token: 0x0400F73D RID: 63293
		[Token(Token = "0x400F73D")]
		[FieldOffset(Offset = "0x60")]
		public UILabel TagLabel;

		// Token: 0x0400F73E RID: 63294
		[Token(Token = "0x400F73E")]
		[FieldOffset(Offset = "0x68")]
		public GameObject HL;

		// Token: 0x0400F73F RID: 63295
		[Token(Token = "0x400F73F")]
		[FieldOffset(Offset = "0x70")]
		public GameObject WL;

		// Token: 0x0400F740 RID: 63296
		[Token(Token = "0x400F740")]
		[FieldOffset(Offset = "0x78")]
		public UISprite stateSprite;

		// Token: 0x0400F741 RID: 63297
		[Token(Token = "0x400F741")]
		[FieldOffset(Offset = "0x80")]
		public UILabel state;

		// Token: 0x0400F742 RID: 63298
		[Token(Token = "0x400F742")]
		[FieldOffset(Offset = "0x88")]
		public UISprite validSprite;

		// Token: 0x0400F743 RID: 63299
		[Token(Token = "0x400F743")]
		[FieldOffset(Offset = "0x90")]
		public UILabel valid;

		// Token: 0x0400F744 RID: 63300
		[Token(Token = "0x400F744")]
		[FieldOffset(Offset = "0x98")]
		public UISprite descSprite;

		// Token: 0x0400F745 RID: 63301
		[Token(Token = "0x400F745")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel description;

		// Token: 0x0400F746 RID: 63302
		[Token(Token = "0x400F746")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite RankIcon;

		// Token: 0x0400F747 RID: 63303
		[Token(Token = "0x400F747")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite Download;
	}
}
