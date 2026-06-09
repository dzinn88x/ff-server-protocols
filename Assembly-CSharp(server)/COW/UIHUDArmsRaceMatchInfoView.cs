using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002267 RID: 8807
	[Token(Token = "0x2002267")]
	public class UIHUDArmsRaceMatchInfoView : UIBaseView
	{
		// Token: 0x0600BFDF RID: 49119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFDF")]
		[Address(RVA = "0x16B333C", Offset = "0x16B333C", VA = "0x7BBBEB333C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFE0 RID: 49120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFE0")]
		[Address(RVA = "0x16B36FC", Offset = "0x16B36FC", VA = "0x7BBBEB36FC")]
		public UIHUDArmsRaceMatchInfoView()
		{
		}

		// Token: 0x0400D36D RID: 54125
		[Token(Token = "0x400D36D")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid MaxLevelGrid;

		// Token: 0x0400D36E RID: 54126
		[Token(Token = "0x400D36E")]
		[FieldOffset(Offset = "0x28")]
		public UISprite MaxTenSprite;

		// Token: 0x0400D36F RID: 54127
		[Token(Token = "0x400D36F")]
		[FieldOffset(Offset = "0x30")]
		public UISprite MaxUnitSprite;

		// Token: 0x0400D370 RID: 54128
		[Token(Token = "0x400D370")]
		[FieldOffset(Offset = "0x38")]
		public UILabel BattleTimeLabel;

		// Token: 0x0400D371 RID: 54129
		[Token(Token = "0x400D371")]
		[FieldOffset(Offset = "0x40")]
		public UISprite SelfWeaponIcon;

		// Token: 0x0400D372 RID: 54130
		[Token(Token = "0x400D372")]
		[FieldOffset(Offset = "0x48")]
		public UIGrid SelfLevelGrid;

		// Token: 0x0400D373 RID: 54131
		[Token(Token = "0x400D373")]
		[FieldOffset(Offset = "0x50")]
		public UISprite SelfTenSprite;

		// Token: 0x0400D374 RID: 54132
		[Token(Token = "0x400D374")]
		[FieldOffset(Offset = "0x58")]
		public UISprite SelfUnitSprite;

		// Token: 0x0400D375 RID: 54133
		[Token(Token = "0x400D375")]
		[FieldOffset(Offset = "0x60")]
		public UILabel SelfRank;

		// Token: 0x0400D376 RID: 54134
		[Token(Token = "0x400D376")]
		[FieldOffset(Offset = "0x68")]
		public GameObject RankOneVFX;

		// Token: 0x0400D377 RID: 54135
		[Token(Token = "0x400D377")]
		[FieldOffset(Offset = "0x70")]
		public UISprite TopWeaponIcon;

		// Token: 0x0400D378 RID: 54136
		[Token(Token = "0x400D378")]
		[FieldOffset(Offset = "0x78")]
		public UILabel TopArmLevel;

		// Token: 0x0400D379 RID: 54137
		[Token(Token = "0x400D379")]
		[FieldOffset(Offset = "0x80")]
		public UIGrid TopLevelGrid;

		// Token: 0x0400D37A RID: 54138
		[Token(Token = "0x400D37A")]
		[FieldOffset(Offset = "0x88")]
		public UISprite TopTenSprite;

		// Token: 0x0400D37B RID: 54139
		[Token(Token = "0x400D37B")]
		[FieldOffset(Offset = "0x90")]
		public UISprite TopUintSprite;
	}
}
