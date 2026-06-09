using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200239D RID: 9117
	[Token(Token = "0x200239D")]
	public class UIHudVehicleStatsView : UIBaseView
	{
		// Token: 0x0600C24A RID: 49738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C24A")]
		[Address(RVA = "0x15F2FB8", Offset = "0x15F2FB8", VA = "0x7BBBDF2FB8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C24B RID: 49739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C24B")]
		[Address(RVA = "0x15F331C", Offset = "0x15F331C", VA = "0x7BBBDF331C")]
		public UIHudVehicleStatsView()
		{
		}

		// Token: 0x0400DD39 RID: 56633
		[Token(Token = "0x400DD39")]
		[FieldOffset(Offset = "0x20")]
		public Transform SpeedPointer;

		// Token: 0x0400DD3A RID: 56634
		[Token(Token = "0x400DD3A")]
		[FieldOffset(Offset = "0x28")]
		public UILabel LabelSpeed;

		// Token: 0x0400DD3B RID: 56635
		[Token(Token = "0x400DD3B")]
		[FieldOffset(Offset = "0x30")]
		public GameObject HPNode;

		// Token: 0x0400DD3C RID: 56636
		[Token(Token = "0x400DD3C")]
		[FieldOffset(Offset = "0x38")]
		public UISprite HPIcon;

		// Token: 0x0400DD3D RID: 56637
		[Token(Token = "0x400DD3D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Effect_VFX;

		// Token: 0x0400DD3E RID: 56638
		[Token(Token = "0x400DD3E")]
		[FieldOffset(Offset = "0x48")]
		public GameObject UpgradeNode;

		// Token: 0x0400DD3F RID: 56639
		[Token(Token = "0x400DD3F")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Armor;

		// Token: 0x0400DD40 RID: 56640
		[Token(Token = "0x400DD40")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Missile;

		// Token: 0x0400DD41 RID: 56641
		[Token(Token = "0x400DD41")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Boost;

		// Token: 0x0400DD42 RID: 56642
		[Token(Token = "0x400DD42")]
		[FieldOffset(Offset = "0x68")]
		public GameObject LV1;

		// Token: 0x0400DD43 RID: 56643
		[Token(Token = "0x400DD43")]
		[FieldOffset(Offset = "0x70")]
		public GameObject LV2;

		// Token: 0x0400DD44 RID: 56644
		[Token(Token = "0x400DD44")]
		[FieldOffset(Offset = "0x78")]
		public GameObject LV3;

		// Token: 0x0400DD45 RID: 56645
		[Token(Token = "0x400DD45")]
		[FieldOffset(Offset = "0x80")]
		public GameObject LV4;
	}
}
