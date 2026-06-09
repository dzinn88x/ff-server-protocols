using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002591 RID: 9617
	[Token(Token = "0x2002591")]
	public class UIWeaponMainView : UIBaseView
	{
		// Token: 0x0600C632 RID: 50738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C632")]
		[Address(RVA = "0x168ADF8", Offset = "0x168ADF8", VA = "0x7BBBE8ADF8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C633 RID: 50739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C633")]
		[Address(RVA = "0x168B614", Offset = "0x168B614", VA = "0x7BBBE8B614")]
		public UIWeaponMainView()
		{
		}

		// Token: 0x0400F74D RID: 63309
		[Token(Token = "0x400F74D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Preview;

		// Token: 0x0400F74E RID: 63310
		[Token(Token = "0x400F74E")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Preview3D;

		// Token: 0x0400F74F RID: 63311
		[Token(Token = "0x400F74F")]
		[FieldOffset(Offset = "0x30")]
		public UILabel noPreviewTips;

		// Token: 0x0400F750 RID: 63312
		[Token(Token = "0x400F750")]
		[FieldOffset(Offset = "0x38")]
		public UILabel noWeaponObtained;

		// Token: 0x0400F751 RID: 63313
		[Token(Token = "0x400F751")]
		[FieldOffset(Offset = "0x40")]
		public GameObject btnGroup;

		// Token: 0x0400F752 RID: 63314
		[Token(Token = "0x400F752")]
		[FieldOffset(Offset = "0x48")]
		public UIButton equipBtn;

		// Token: 0x0400F753 RID: 63315
		[Token(Token = "0x400F753")]
		[FieldOffset(Offset = "0x50")]
		public UILabel btnName;

		// Token: 0x0400F754 RID: 63316
		[Token(Token = "0x400F754")]
		[FieldOffset(Offset = "0x58")]
		public UIButton showBtn;

		// Token: 0x0400F755 RID: 63317
		[Token(Token = "0x400F755")]
		[FieldOffset(Offset = "0x60")]
		public UISprite ShowBtnSprite;

		// Token: 0x0400F756 RID: 63318
		[Token(Token = "0x400F756")]
		[FieldOffset(Offset = "0x68")]
		public UILabel showBtnName;

		// Token: 0x0400F757 RID: 63319
		[Token(Token = "0x400F757")]
		[FieldOffset(Offset = "0x70")]
		public GameObject check;

		// Token: 0x0400F758 RID: 63320
		[Token(Token = "0x400F758")]
		[FieldOffset(Offset = "0x78")]
		public GameObject EffectContainer;

		// Token: 0x0400F759 RID: 63321
		[Token(Token = "0x400F759")]
		[FieldOffset(Offset = "0x80")]
		public ParticleSystem FireEffect;

		// Token: 0x0400F75A RID: 63322
		[Token(Token = "0x400F75A")]
		[FieldOffset(Offset = "0x88")]
		public ParticleSystem FireSparks;

		// Token: 0x0400F75B RID: 63323
		[Token(Token = "0x400F75B")]
		[FieldOffset(Offset = "0x90")]
		public Transform Container;

		// Token: 0x0400F75C RID: 63324
		[Token(Token = "0x400F75C")]
		[FieldOffset(Offset = "0x98")]
		public UILabel navigation;

		// Token: 0x0400F75D RID: 63325
		[Token(Token = "0x400F75D")]
		[FieldOffset(Offset = "0xA0")]
		public UIWidget collectionBg;

		// Token: 0x0400F75E RID: 63326
		[Token(Token = "0x400F75E")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject weaponContainer;

		// Token: 0x0400F75F RID: 63327
		[Token(Token = "0x400F75F")]
		[FieldOffset(Offset = "0xB0")]
		public UIWidget weaponBg;

		// Token: 0x0400F760 RID: 63328
		[Token(Token = "0x400F760")]
		[FieldOffset(Offset = "0xB8")]
		public UIWidget wpTypePopMenu;

		// Token: 0x0400F761 RID: 63329
		[Token(Token = "0x400F761")]
		[FieldOffset(Offset = "0xC0")]
		public Transform popmenuContainer;

		// Token: 0x0400F762 RID: 63330
		[Token(Token = "0x400F762")]
		[FieldOffset(Offset = "0xC8")]
		public UIWidget wpListPopMenu;

		// Token: 0x0400F763 RID: 63331
		[Token(Token = "0x400F763")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton wpListPopBtn;

		// Token: 0x0400F764 RID: 63332
		[Token(Token = "0x400F764")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject wpListArrUp;

		// Token: 0x0400F765 RID: 63333
		[Token(Token = "0x400F765")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel wpSelected;

		// Token: 0x0400F766 RID: 63334
		[Token(Token = "0x400F766")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject wpListArrDown;

		// Token: 0x0400F767 RID: 63335
		[Token(Token = "0x400F767")]
		[FieldOffset(Offset = "0xF0")]
		public UIScrollView ScrollView;

		// Token: 0x0400F768 RID: 63336
		[Token(Token = "0x400F768")]
		[FieldOffset(Offset = "0xF8")]
		public UITable2 table;

		// Token: 0x0400F769 RID: 63337
		[Token(Token = "0x400F769")]
		[FieldOffset(Offset = "0x100")]
		public UICollectionCategoryTitle Title;

		// Token: 0x0400F76A RID: 63338
		[Token(Token = "0x400F76A")]
		[FieldOffset(Offset = "0x108")]
		public UILabel Name;

		// Token: 0x0400F76B RID: 63339
		[Token(Token = "0x400F76B")]
		[FieldOffset(Offset = "0x110")]
		public UITable2Item SplitLine;

		// Token: 0x0400F76C RID: 63340
		[Token(Token = "0x400F76C")]
		[FieldOffset(Offset = "0x118")]
		public UISprite line;
	}
}
