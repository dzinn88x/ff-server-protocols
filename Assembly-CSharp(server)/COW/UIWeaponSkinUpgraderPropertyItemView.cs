using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200259B RID: 9627
	[Token(Token = "0x200259B")]
	public class UIWeaponSkinUpgraderPropertyItemView : UIBaseView
	{
		// Token: 0x0600C646 RID: 50758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C646")]
		[Address(RVA = "0x2231E70", Offset = "0x2231E70", VA = "0x7BBCA31E70", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C647 RID: 50759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C647")]
		[Address(RVA = "0x223219C", Offset = "0x223219C", VA = "0x7BBCA3219C")]
		public UIWeaponSkinUpgraderPropertyItemView()
		{
		}

		// Token: 0x0400F824 RID: 63524
		[Token(Token = "0x400F824")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnWeaponSkinProperty;

		// Token: 0x0400F825 RID: 63525
		[Token(Token = "0x400F825")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ObjCanMove;

		// Token: 0x0400F826 RID: 63526
		[Token(Token = "0x400F826")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ObjChosen;

		// Token: 0x0400F827 RID: 63527
		[Token(Token = "0x400F827")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelDesc;

		// Token: 0x0400F828 RID: 63528
		[Token(Token = "0x400F828")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ObjUnChosen;

		// Token: 0x0400F829 RID: 63529
		[Token(Token = "0x400F829")]
		[FieldOffset(Offset = "0x48")]
		public UISprite SpriteIcon;

		// Token: 0x0400F82A RID: 63530
		[Token(Token = "0x400F82A")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnPropertyOnlySprite;

		// Token: 0x0400F82B RID: 63531
		[Token(Token = "0x400F82B")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ObjOnlyChosen;

		// Token: 0x0400F82C RID: 63532
		[Token(Token = "0x400F82C")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ObjOnlyUnChosen;

		// Token: 0x0400F82D RID: 63533
		[Token(Token = "0x400F82D")]
		[FieldOffset(Offset = "0x68")]
		public UISprite SpriteIcon2;

		// Token: 0x0400F82E RID: 63534
		[Token(Token = "0x400F82E")]
		[FieldOffset(Offset = "0x70")]
		public GameObject ObjTinyProperty;

		// Token: 0x0400F82F RID: 63535
		[Token(Token = "0x400F82F")]
		[FieldOffset(Offset = "0x78")]
		public UISprite SpriteTinyProperty;
	}
}
