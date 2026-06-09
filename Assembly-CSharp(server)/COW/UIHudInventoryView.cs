using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022EF RID: 8943
	[Token(Token = "0x20022EF")]
	public class UIHudInventoryView : UIBaseView
	{
		// Token: 0x0600C0EE RID: 49390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0EE")]
		[Address(RVA = "0x1C45854", Offset = "0x1C45854", VA = "0x7BBC445854", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0EF RID: 49391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0EF")]
		[Address(RVA = "0x1C464C4", Offset = "0x1C464C4", VA = "0x7BBC4464C4")]
		public UIHudInventoryView()
		{
		}

		// Token: 0x0400D780 RID: 55168
		[Token(Token = "0x400D780")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose1;

		// Token: 0x0400D781 RID: 55169
		[Token(Token = "0x400D781")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnClose;

		// Token: 0x0400D782 RID: 55170
		[Token(Token = "0x400D782")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView ScrollViewRoot;

		// Token: 0x0400D783 RID: 55171
		[Token(Token = "0x400D783")]
		[FieldOffset(Offset = "0x38")]
		public UIPanel ScrollViewPanel;

		// Token: 0x0400D784 RID: 55172
		[Token(Token = "0x400D784")]
		[FieldOffset(Offset = "0x40")]
		public Transform ItemListGridTF;

		// Token: 0x0400D785 RID: 55173
		[Token(Token = "0x400D785")]
		[FieldOffset(Offset = "0x48")]
		public UIGrid ItemListGrid;

		// Token: 0x0400D786 RID: 55174
		[Token(Token = "0x400D786")]
		[FieldOffset(Offset = "0x50")]
		public UILabel BagCapacity;

		// Token: 0x0400D787 RID: 55175
		[Token(Token = "0x400D787")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Bagrighttxt;

		// Token: 0x0400D788 RID: 55176
		[Token(Token = "0x400D788")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnSort;

		// Token: 0x0400D789 RID: 55177
		[Token(Token = "0x400D789")]
		[FieldOffset(Offset = "0x68")]
		public UISprite SortSpr;

		// Token: 0x0400D78A RID: 55178
		[Token(Token = "0x400D78A")]
		[FieldOffset(Offset = "0x70")]
		public UIPanel TrashGO;

		// Token: 0x0400D78B RID: 55179
		[Token(Token = "0x400D78B")]
		[FieldOffset(Offset = "0x78")]
		public GameObject TrashInfoGO;

		// Token: 0x0400D78C RID: 55180
		[Token(Token = "0x400D78C")]
		[FieldOffset(Offset = "0x80")]
		public GameObject TrashBg1;

		// Token: 0x0400D78D RID: 55181
		[Token(Token = "0x400D78D")]
		[FieldOffset(Offset = "0x88")]
		public GameObject TrashBg2;

		// Token: 0x0400D78E RID: 55182
		[Token(Token = "0x400D78E")]
		[FieldOffset(Offset = "0x90")]
		public Transform VestSlot;

		// Token: 0x0400D78F RID: 55183
		[Token(Token = "0x400D78F")]
		[FieldOffset(Offset = "0x98")]
		public GameObject VestHolderEmptyBG;

		// Token: 0x0400D790 RID: 55184
		[Token(Token = "0x400D790")]
		[FieldOffset(Offset = "0xA0")]
		public UIToggle VestToggle;

		// Token: 0x0400D791 RID: 55185
		[Token(Token = "0x400D791")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject VestHighlightGO;

		// Token: 0x0400D792 RID: 55186
		[Token(Token = "0x400D792")]
		[FieldOffset(Offset = "0xB0")]
		public Transform HelmetSlot;

		// Token: 0x0400D793 RID: 55187
		[Token(Token = "0x400D793")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject HelmetHolderEmptyBG;

		// Token: 0x0400D794 RID: 55188
		[Token(Token = "0x400D794")]
		[FieldOffset(Offset = "0xC0")]
		public UIToggle HelmetToggle;

		// Token: 0x0400D795 RID: 55189
		[Token(Token = "0x400D795")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject HelmetHighlightGO;

		// Token: 0x0400D796 RID: 55190
		[Token(Token = "0x400D796")]
		[FieldOffset(Offset = "0xD0")]
		public Transform BagSlot;

		// Token: 0x0400D797 RID: 55191
		[Token(Token = "0x400D797")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject BagHolderEmptyBG;

		// Token: 0x0400D798 RID: 55192
		[Token(Token = "0x400D798")]
		[FieldOffset(Offset = "0xE0")]
		public UIToggle BagToggle;

		// Token: 0x0400D799 RID: 55193
		[Token(Token = "0x400D799")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject BagHighlightGO;

		// Token: 0x0400D79A RID: 55194
		[Token(Token = "0x400D79A")]
		[FieldOffset(Offset = "0xF0")]
		public Transform CamouflageSlot;

		// Token: 0x0400D79B RID: 55195
		[Token(Token = "0x400D79B")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject CamouflageHolderEmptyBG;

		// Token: 0x0400D79C RID: 55196
		[Token(Token = "0x400D79C")]
		[FieldOffset(Offset = "0x100")]
		public UIToggle CoverToggle;

		// Token: 0x0400D79D RID: 55197
		[Token(Token = "0x400D79D")]
		[FieldOffset(Offset = "0x108")]
		public GameObject CoverHighlightGO;

		// Token: 0x0400D79E RID: 55198
		[Token(Token = "0x400D79E")]
		[FieldOffset(Offset = "0x110")]
		public UILabel DescItemName;

		// Token: 0x0400D79F RID: 55199
		[Token(Token = "0x400D79F")]
		[FieldOffset(Offset = "0x118")]
		public UILabel DescItemInfo;

		// Token: 0x0400D7A0 RID: 55200
		[Token(Token = "0x400D7A0")]
		[FieldOffset(Offset = "0x120")]
		public UILabel DescItemCap;

		// Token: 0x0400D7A1 RID: 55201
		[Token(Token = "0x400D7A1")]
		[FieldOffset(Offset = "0x128")]
		public GameObject DescCapIconGO;

		// Token: 0x0400D7A2 RID: 55202
		[Token(Token = "0x400D7A2")]
		[FieldOffset(Offset = "0x130")]
		public Transform Prim1WeaponSlot;

		// Token: 0x0400D7A3 RID: 55203
		[Token(Token = "0x400D7A3")]
		[FieldOffset(Offset = "0x138")]
		public GameObject P1HolderEmptyBG;

		// Token: 0x0400D7A4 RID: 55204
		[Token(Token = "0x400D7A4")]
		[FieldOffset(Offset = "0x140")]
		public UIToggle PrimaryWToggle;

		// Token: 0x0400D7A5 RID: 55205
		[Token(Token = "0x400D7A5")]
		[FieldOffset(Offset = "0x148")]
		public GameObject PrimaryWHighlightGO;

		// Token: 0x0400D7A6 RID: 55206
		[Token(Token = "0x400D7A6")]
		[FieldOffset(Offset = "0x150")]
		public Transform MeleeWeaponSlot;

		// Token: 0x0400D7A7 RID: 55207
		[Token(Token = "0x400D7A7")]
		[FieldOffset(Offset = "0x158")]
		public GameObject M1HolderEmptyBG;

		// Token: 0x0400D7A8 RID: 55208
		[Token(Token = "0x400D7A8")]
		[FieldOffset(Offset = "0x160")]
		public UIToggle MeleeToggle;

		// Token: 0x0400D7A9 RID: 55209
		[Token(Token = "0x400D7A9")]
		[FieldOffset(Offset = "0x168")]
		public GameObject MeleeHighlightGO;

		// Token: 0x0400D7AA RID: 55210
		[Token(Token = "0x400D7AA")]
		[FieldOffset(Offset = "0x170")]
		public Transform Prim2WeaponSlot;

		// Token: 0x0400D7AB RID: 55211
		[Token(Token = "0x400D7AB")]
		[FieldOffset(Offset = "0x178")]
		public GameObject P2HolderEmptyBG;

		// Token: 0x0400D7AC RID: 55212
		[Token(Token = "0x400D7AC")]
		[FieldOffset(Offset = "0x180")]
		public UIToggle SecondaryWToggle;

		// Token: 0x0400D7AD RID: 55213
		[Token(Token = "0x400D7AD")]
		[FieldOffset(Offset = "0x188")]
		public GameObject SecondaryWHighlightGO;

		// Token: 0x0400D7AE RID: 55214
		[Token(Token = "0x400D7AE")]
		[FieldOffset(Offset = "0x190")]
		public Transform SecWeaponSlot;

		// Token: 0x0400D7AF RID: 55215
		[Token(Token = "0x400D7AF")]
		[FieldOffset(Offset = "0x198")]
		public GameObject S1HolderEmptyBG;

		// Token: 0x0400D7B0 RID: 55216
		[Token(Token = "0x400D7B0")]
		[FieldOffset(Offset = "0x1A0")]
		public UIToggle SideWToggle;

		// Token: 0x0400D7B1 RID: 55217
		[Token(Token = "0x400D7B1")]
		[FieldOffset(Offset = "0x1A8")]
		public GameObject SideWHighlightGO;
	}
}
