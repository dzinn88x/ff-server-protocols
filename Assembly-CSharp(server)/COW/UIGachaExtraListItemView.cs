using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200220E RID: 8718
	[Token(Token = "0x200220E")]
	public class UIGachaExtraListItemView : UIBaseView
	{
		// Token: 0x0600BF2D RID: 48941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF2D")]
		[Address(RVA = "0x21638F8", Offset = "0x21638F8", VA = "0x7BBC9638F8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF2E RID: 48942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF2E")]
		[Address(RVA = "0x2163CC0", Offset = "0x2163CC0", VA = "0x7BBC963CC0")]
		public UIGachaExtraListItemView()
		{
		}

		// Token: 0x0400CEA3 RID: 52899
		[Token(Token = "0x400CEA3")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget RootViewWidget;

		// Token: 0x0400CEA4 RID: 52900
		[Token(Token = "0x400CEA4")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ItemBtn;

		// Token: 0x0400CEA5 RID: 52901
		[Token(Token = "0x400CEA5")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ItemNormalBgYellowPx;

		// Token: 0x0400CEA6 RID: 52902
		[Token(Token = "0x400CEA6")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ItemNormalBgBlackPx;

		// Token: 0x0400CEA7 RID: 52903
		[Token(Token = "0x400CEA7")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ItemLock;

		// Token: 0x0400CEA8 RID: 52904
		[Token(Token = "0x400CEA8")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ItemMaskUnlock;

		// Token: 0x0400CEA9 RID: 52905
		[Token(Token = "0x400CEA9")]
		[FieldOffset(Offset = "0x50")]
		public UILabel UIItemLabelLocked;

		// Token: 0x0400CEAA RID: 52906
		[Token(Token = "0x400CEAA")]
		[FieldOffset(Offset = "0x58")]
		public UISprite ItemIconReceived;

		// Token: 0x0400CEAB RID: 52907
		[Token(Token = "0x400CEAB")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ItemUnLock;

		// Token: 0x0400CEAC RID: 52908
		[Token(Token = "0x400CEAC")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ItemMaskLock;

		// Token: 0x0400CEAD RID: 52909
		[Token(Token = "0x400CEAD")]
		[FieldOffset(Offset = "0x70")]
		public UILabel UIItemLabelUnlock;

		// Token: 0x0400CEAE RID: 52910
		[Token(Token = "0x400CEAE")]
		[FieldOffset(Offset = "0x78")]
		public UISprite ItemIcon;

		// Token: 0x0400CEAF RID: 52911
		[Token(Token = "0x400CEAF")]
		[FieldOffset(Offset = "0x80")]
		public Animation ItemIconAnim;

		// Token: 0x0400CEB0 RID: 52912
		[Token(Token = "0x400CEB0")]
		[FieldOffset(Offset = "0x88")]
		public GameObject ItemIconHightLight;
	}
}
