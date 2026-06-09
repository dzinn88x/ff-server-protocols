using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200243D RID: 9277
	[Token(Token = "0x200243D")]
	internal class UIMatchResultZombieScreenshotSelfItemView : UIBaseView
	{
		// Token: 0x0600C38A RID: 50058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C38A")]
		[Address(RVA = "0x1482070", Offset = "0x1482070", VA = "0x7BBBC82070", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C38B RID: 50059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C38B")]
		[Address(RVA = "0x14822FC", Offset = "0x14822FC", VA = "0x7BBBC822FC")]
		public UIMatchResultZombieScreenshotSelfItemView()
		{
		}

		// Token: 0x0400E733 RID: 59187
		[Token(Token = "0x400E733")]
		[FieldOffset(Offset = "0x20")]
		public GameObject baseProfile;

		// Token: 0x0400E734 RID: 59188
		[Token(Token = "0x400E734")]
		[FieldOffset(Offset = "0x28")]
		public GameObject briefProfile;

		// Token: 0x0400E735 RID: 59189
		[Token(Token = "0x400E735")]
		[FieldOffset(Offset = "0x30")]
		public UISprite WeaponIcon;

		// Token: 0x0400E736 RID: 59190
		[Token(Token = "0x400E736")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Kills;

		// Token: 0x0400E737 RID: 59191
		[Token(Token = "0x400E737")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Damages;

		// Token: 0x0400E738 RID: 59192
		[Token(Token = "0x400E738")]
		[FieldOffset(Offset = "0x48")]
		public UILabel SurvivedTime;

		// Token: 0x0400E739 RID: 59193
		[Token(Token = "0x400E739")]
		[FieldOffset(Offset = "0x50")]
		public UISprite NormalBG;

		// Token: 0x0400E73A RID: 59194
		[Token(Token = "0x400E73A")]
		[FieldOffset(Offset = "0x58")]
		public UISprite FirstBG;

		// Token: 0x0400E73B RID: 59195
		[Token(Token = "0x400E73B")]
		[FieldOffset(Offset = "0x60")]
		public GameObject MVPIcon;
	}
}
