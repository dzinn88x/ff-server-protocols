using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002597 RID: 9623
	[Token(Token = "0x2002597")]
	public class UIWeaponSkinUpgraderFeatureView : UIBaseView
	{
		// Token: 0x0600C63E RID: 50750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C63E")]
		[Address(RVA = "0x222DC20", Offset = "0x222DC20", VA = "0x7BBCA2DC20", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C63F RID: 50751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C63F")]
		[Address(RVA = "0x222E28C", Offset = "0x222E28C", VA = "0x7BBCA2E28C")]
		public UIWeaponSkinUpgraderFeatureView()
		{
		}

		// Token: 0x0400F7F4 RID: 63476
		[Token(Token = "0x400F7F4")]
		[FieldOffset(Offset = "0x20")]
		public Animator ShowFeatureAnim;

		// Token: 0x0400F7F5 RID: 63477
		[Token(Token = "0x400F7F5")]
		[FieldOffset(Offset = "0x28")]
		public GameObject UIContent;

		// Token: 0x0400F7F6 RID: 63478
		[Token(Token = "0x400F7F6")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BGSprite;

		// Token: 0x0400F7F7 RID: 63479
		[Token(Token = "0x400F7F7")]
		[FieldOffset(Offset = "0x38")]
		public UITexture GachaFeature_Bg;

		// Token: 0x0400F7F8 RID: 63480
		[Token(Token = "0x400F7F8")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ObjAnnouncementArea;

		// Token: 0x0400F7F9 RID: 63481
		[Token(Token = "0x400F7F9")]
		[FieldOffset(Offset = "0x48")]
		public GameObject InterfaceMask;

		// Token: 0x0400F7FA RID: 63482
		[Token(Token = "0x400F7FA")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ItemShow;

		// Token: 0x0400F7FB RID: 63483
		[Token(Token = "0x400F7FB")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ItemInfoContainer;

		// Token: 0x0400F7FC RID: 63484
		[Token(Token = "0x400F7FC")]
		[FieldOffset(Offset = "0x60")]
		public BaseItemView BaseInfoView;

		// Token: 0x0400F7FD RID: 63485
		[Token(Token = "0x400F7FD")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Bottom_btn;

		// Token: 0x0400F7FE RID: 63486
		[Token(Token = "0x400F7FE")]
		[FieldOffset(Offset = "0x70")]
		public UIButton ShareBtn;

		// Token: 0x0400F7FF RID: 63487
		[Token(Token = "0x400F7FF")]
		[FieldOffset(Offset = "0x78")]
		public Animator ShareIconAnimator;

		// Token: 0x0400F800 RID: 63488
		[Token(Token = "0x400F800")]
		[FieldOffset(Offset = "0x80")]
		public UIButton OkBtn;

		// Token: 0x0400F801 RID: 63489
		[Token(Token = "0x400F801")]
		[FieldOffset(Offset = "0x88")]
		public GameObject propertyContainer;

		// Token: 0x0400F802 RID: 63490
		[Token(Token = "0x400F802")]
		[FieldOffset(Offset = "0x90")]
		public UIGrid scoreGrid;

		// Token: 0x0400F803 RID: 63491
		[Token(Token = "0x400F803")]
		[FieldOffset(Offset = "0x98")]
		public UILabel ItemNameLabel;

		// Token: 0x0400F804 RID: 63492
		[Token(Token = "0x400F804")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite IPTag;

		// Token: 0x0400F805 RID: 63493
		[Token(Token = "0x400F805")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject propertyVioContainer;

		// Token: 0x0400F806 RID: 63494
		[Token(Token = "0x400F806")]
		[FieldOffset(Offset = "0xB0")]
		public UIGrid scoreVioGrid;

		// Token: 0x0400F807 RID: 63495
		[Token(Token = "0x400F807")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel ItemNameVioLabel;

		// Token: 0x0400F808 RID: 63496
		[Token(Token = "0x400F808")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite IPTagVio;

		// Token: 0x0400F809 RID: 63497
		[Token(Token = "0x400F809")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject propertyRedContainer;

		// Token: 0x0400F80A RID: 63498
		[Token(Token = "0x400F80A")]
		[FieldOffset(Offset = "0xD0")]
		public UIGrid scoreRedGrid;

		// Token: 0x0400F80B RID: 63499
		[Token(Token = "0x400F80B")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel ItemNameRedLabel;

		// Token: 0x0400F80C RID: 63500
		[Token(Token = "0x400F80C")]
		[FieldOffset(Offset = "0xE0")]
		public UISprite IPTagRed;
	}
}
