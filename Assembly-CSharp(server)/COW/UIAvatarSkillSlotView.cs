using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200210A RID: 8458
	[Token(Token = "0x200210A")]
	public class UIAvatarSkillSlotView : UIBaseView
	{
		// Token: 0x0600BD25 RID: 48421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD25")]
		[Address(RVA = "0x1E4EE4C", Offset = "0x1E4EE4C", VA = "0x7BBC64EE4C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD26 RID: 48422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD26")]
		[Address(RVA = "0x1E4F350", Offset = "0x1E4F350", VA = "0x7BBC64F350")]
		public UIAvatarSkillSlotView()
		{
		}

		// Token: 0x0400C178 RID: 49528
		[Token(Token = "0x400C178")]
		[FieldOffset(Offset = "0x20")]
		public AvatarSelectionSkillSlot SlotScript;

		// Token: 0x0400C179 RID: 49529
		[Token(Token = "0x400C179")]
		[FieldOffset(Offset = "0x28")]
		public UIButton SlotBtn;

		// Token: 0x0400C17A RID: 49530
		[Token(Token = "0x400C17A")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SelectedHL;

		// Token: 0x0400C17B RID: 49531
		[Token(Token = "0x400C17B")]
		[FieldOffset(Offset = "0x38")]
		public GameObject NormalBG_G;

		// Token: 0x0400C17C RID: 49532
		[Token(Token = "0x400C17C")]
		[FieldOffset(Offset = "0x40")]
		public GameObject NormalBG_Y;

		// Token: 0x0400C17D RID: 49533
		[Token(Token = "0x400C17D")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NormalBG_R;

		// Token: 0x0400C17E RID: 49534
		[Token(Token = "0x400C17E")]
		[FieldOffset(Offset = "0x50")]
		public GameObject NormalBG_N;

		// Token: 0x0400C17F RID: 49535
		[Token(Token = "0x400C17F")]
		[FieldOffset(Offset = "0x58")]
		public GameObject lv_bg;

		// Token: 0x0400C180 RID: 49536
		[Token(Token = "0x400C180")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LvLabel;

		// Token: 0x0400C181 RID: 49537
		[Token(Token = "0x400C181")]
		[FieldOffset(Offset = "0x68")]
		public GameObject lv_bg2;

		// Token: 0x0400C182 RID: 49538
		[Token(Token = "0x400C182")]
		[FieldOffset(Offset = "0x70")]
		public UILabel LvLabel2;

		// Token: 0x0400C183 RID: 49539
		[Token(Token = "0x400C183")]
		[FieldOffset(Offset = "0x78")]
		public GameObject lv_bg3;

		// Token: 0x0400C184 RID: 49540
		[Token(Token = "0x400C184")]
		[FieldOffset(Offset = "0x80")]
		public UILabel LvLabel3;

		// Token: 0x0400C185 RID: 49541
		[Token(Token = "0x400C185")]
		[FieldOffset(Offset = "0x88")]
		public GameObject Empty;

		// Token: 0x0400C186 RID: 49542
		[Token(Token = "0x400C186")]
		[FieldOffset(Offset = "0x90")]
		public GameObject LockGo;

		// Token: 0x0400C187 RID: 49543
		[Token(Token = "0x400C187")]
		[FieldOffset(Offset = "0x98")]
		public GameObject lockSprite;

		// Token: 0x0400C188 RID: 49544
		[Token(Token = "0x400C188")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject unlockAnim;

		// Token: 0x0400C189 RID: 49545
		[Token(Token = "0x400C189")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject newSlotTip;

		// Token: 0x0400C18A RID: 49546
		[Token(Token = "0x400C18A")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject ActiveSkillLock;

		// Token: 0x0400C18B RID: 49547
		[Token(Token = "0x400C18B")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject RedTips;
	}
}
