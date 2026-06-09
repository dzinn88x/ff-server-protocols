using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200221D RID: 8733
	[Token(Token = "0x200221D")]
	public class UIGachaLimitExtraListItemView : UIBaseView
	{
		// Token: 0x0600BF4B RID: 48971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF4B")]
		[Address(RVA = "0x20650F8", Offset = "0x20650F8", VA = "0x7BBC8650F8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF4C RID: 48972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF4C")]
		[Address(RVA = "0x206552C", Offset = "0x206552C", VA = "0x7BBC86552C")]
		public UIGachaLimitExtraListItemView()
		{
		}

		// Token: 0x0400CF6F RID: 53103
		[Token(Token = "0x400CF6F")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget RootViewWidget;

		// Token: 0x0400CF70 RID: 53104
		[Token(Token = "0x400CF70")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ItemBtn;

		// Token: 0x0400CF71 RID: 53105
		[Token(Token = "0x400CF71")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ItemNormalBgYellowPx;

		// Token: 0x0400CF72 RID: 53106
		[Token(Token = "0x400CF72")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ItemNormalBgBlackPx;

		// Token: 0x0400CF73 RID: 53107
		[Token(Token = "0x400CF73")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ItemLock;

		// Token: 0x0400CF74 RID: 53108
		[Token(Token = "0x400CF74")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ItemMaskUnlock;

		// Token: 0x0400CF75 RID: 53109
		[Token(Token = "0x400CF75")]
		[FieldOffset(Offset = "0x50")]
		public UILabel UIItemLabelLocked;

		// Token: 0x0400CF76 RID: 53110
		[Token(Token = "0x400CF76")]
		[FieldOffset(Offset = "0x58")]
		public UISprite ItemIconReceived;

		// Token: 0x0400CF77 RID: 53111
		[Token(Token = "0x400CF77")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ItemUnLock;

		// Token: 0x0400CF78 RID: 53112
		[Token(Token = "0x400CF78")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ItemMaskLock;

		// Token: 0x0400CF79 RID: 53113
		[Token(Token = "0x400CF79")]
		[FieldOffset(Offset = "0x70")]
		public UILabel UIItemLabelUnlock;

		// Token: 0x0400CF7A RID: 53114
		[Token(Token = "0x400CF7A")]
		[FieldOffset(Offset = "0x78")]
		public UISprite ItemIcon;

		// Token: 0x0400CF7B RID: 53115
		[Token(Token = "0x400CF7B")]
		[FieldOffset(Offset = "0x80")]
		public Animation ItemIconAnim;

		// Token: 0x0400CF7C RID: 53116
		[Token(Token = "0x400CF7C")]
		[FieldOffset(Offset = "0x88")]
		public GameObject ItemIconVfx;

		// Token: 0x0400CF7D RID: 53117
		[Token(Token = "0x400CF7D")]
		[FieldOffset(Offset = "0x90")]
		public GameObject ItemIconHightLight;

		// Token: 0x0400CF7E RID: 53118
		[Token(Token = "0x400CF7E")]
		[FieldOffset(Offset = "0x98")]
		public GameObject GainEffect;
	}
}
