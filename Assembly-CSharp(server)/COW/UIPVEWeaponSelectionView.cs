using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024B9 RID: 9401
	[Token(Token = "0x20024B9")]
	internal class UIPVEWeaponSelectionView : UIBaseView
	{
		// Token: 0x0600C482 RID: 50306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C482")]
		[Address(RVA = "0x16EA778", Offset = "0x16EA778", VA = "0x7BBBEEA778", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C483 RID: 50307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C483")]
		[Address(RVA = "0x16EAAFC", Offset = "0x16EAAFC", VA = "0x7BBBEEAAFC")]
		public UIPVEWeaponSelectionView()
		{
		}

		// Token: 0x0400EEEF RID: 61167
		[Token(Token = "0x400EEEF")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Close;

		// Token: 0x0400EEF0 RID: 61168
		[Token(Token = "0x400EEF0")]
		[FieldOffset(Offset = "0x28")]
		public UISprite primaryWPSprite;

		// Token: 0x0400EEF1 RID: 61169
		[Token(Token = "0x400EEF1")]
		[FieldOffset(Offset = "0x30")]
		public UISprite validSprite;

		// Token: 0x0400EEF2 RID: 61170
		[Token(Token = "0x400EEF2")]
		[FieldOffset(Offset = "0x38")]
		public UILabel valid;

		// Token: 0x0400EEF3 RID: 61171
		[Token(Token = "0x400EEF3")]
		[FieldOffset(Offset = "0x40")]
		public UILabel skillDesc;

		// Token: 0x0400EEF4 RID: 61172
		[Token(Token = "0x400EEF4")]
		[FieldOffset(Offset = "0x48")]
		public GameObject skillicon;

		// Token: 0x0400EEF5 RID: 61173
		[Token(Token = "0x400EEF5")]
		[FieldOffset(Offset = "0x50")]
		public UILabel description;

		// Token: 0x0400EEF6 RID: 61174
		[Token(Token = "0x400EEF6")]
		[FieldOffset(Offset = "0x58")]
		public Transform weaponProperty;

		// Token: 0x0400EEF7 RID: 61175
		[Token(Token = "0x400EEF7")]
		[FieldOffset(Offset = "0x60")]
		public UIScrollView ScrollTab;

		// Token: 0x0400EEF8 RID: 61176
		[Token(Token = "0x400EEF8")]
		[FieldOffset(Offset = "0x68")]
		public UIGrid tabGrid;

		// Token: 0x0400EEF9 RID: 61177
		[Token(Token = "0x400EEF9")]
		[FieldOffset(Offset = "0x70")]
		public UIToggleButtonGroup tabToggleGroup;

		// Token: 0x0400EEFA RID: 61178
		[Token(Token = "0x400EEFA")]
		[FieldOffset(Offset = "0x78")]
		public UIScrollView ScrollView;

		// Token: 0x0400EEFB RID: 61179
		[Token(Token = "0x400EEFB")]
		[FieldOffset(Offset = "0x80")]
		public UIEasyList weaponGrid;
	}
}
