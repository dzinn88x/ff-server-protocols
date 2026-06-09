using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023E1 RID: 9185
	[Token(Token = "0x20023E1")]
	public class UILevelUpView : UIBaseView
	{
		// Token: 0x0600C2D2 RID: 49874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2D2")]
		[Address(RVA = "0x1CB8148", Offset = "0x1CB8148", VA = "0x7BBC4B8148", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2D3 RID: 49875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2D3")]
		[Address(RVA = "0x1CB87C0", Offset = "0x1CB87C0", VA = "0x7BBC4B87C0")]
		public UILevelUpView()
		{
		}

		// Token: 0x0400E076 RID: 57462
		[Token(Token = "0x400E076")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BG;

		// Token: 0x0400E077 RID: 57463
		[Token(Token = "0x400E077")]
		[FieldOffset(Offset = "0x28")]
		public GameObject LevelUpResult;

		// Token: 0x0400E078 RID: 57464
		[Token(Token = "0x400E078")]
		[FieldOffset(Offset = "0x30")]
		public Animation LevelUpAnim;

		// Token: 0x0400E079 RID: 57465
		[Token(Token = "0x400E079")]
		[FieldOffset(Offset = "0x38")]
		public GameObject LabelNone;

		// Token: 0x0400E07A RID: 57466
		[Token(Token = "0x400E07A")]
		[FieldOffset(Offset = "0x40")]
		public UILabel LabelBless;

		// Token: 0x0400E07B RID: 57467
		[Token(Token = "0x400E07B")]
		[FieldOffset(Offset = "0x48")]
		public GameObject CurLevelInfo;

		// Token: 0x0400E07C RID: 57468
		[Token(Token = "0x400E07C")]
		[FieldOffset(Offset = "0x50")]
		public UISprite IconCurEntrance;

		// Token: 0x0400E07D RID: 57469
		[Token(Token = "0x400E07D")]
		[FieldOffset(Offset = "0x58")]
		public UILabel LabelCurEntrance;

		// Token: 0x0400E07E RID: 57470
		[Token(Token = "0x400E07E")]
		[FieldOffset(Offset = "0x60")]
		public GameObject NextLevelInfo;

		// Token: 0x0400E07F RID: 57471
		[Token(Token = "0x400E07F")]
		[FieldOffset(Offset = "0x68")]
		public UISprite IconNextEntrance;

		// Token: 0x0400E080 RID: 57472
		[Token(Token = "0x400E080")]
		[FieldOffset(Offset = "0x70")]
		public UILabel LabelNextEntrance;

		// Token: 0x0400E081 RID: 57473
		[Token(Token = "0x400E081")]
		[FieldOffset(Offset = "0x78")]
		public UILabel LabelNextLevel;

		// Token: 0x0400E082 RID: 57474
		[Token(Token = "0x400E082")]
		[FieldOffset(Offset = "0x80")]
		public UILabel LabelCurLevel;

		// Token: 0x0400E083 RID: 57475
		[Token(Token = "0x400E083")]
		[FieldOffset(Offset = "0x88")]
		public UILabel CurLevelLabel02;

		// Token: 0x0400E084 RID: 57476
		[Token(Token = "0x400E084")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnShowChest;

		// Token: 0x0400E085 RID: 57477
		[Token(Token = "0x400E085")]
		[FieldOffset(Offset = "0x98")]
		public GameObject RewardResult;

		// Token: 0x0400E086 RID: 57478
		[Token(Token = "0x400E086")]
		[FieldOffset(Offset = "0xA0")]
		public Animation RewardAnim;

		// Token: 0x0400E087 RID: 57479
		[Token(Token = "0x400E087")]
		[FieldOffset(Offset = "0xA8")]
		public Transform LeftAwardGrid;

		// Token: 0x0400E088 RID: 57480
		[Token(Token = "0x400E088")]
		[FieldOffset(Offset = "0xB0")]
		public Transform MidAwardGrid;

		// Token: 0x0400E089 RID: 57481
		[Token(Token = "0x400E089")]
		[FieldOffset(Offset = "0xB8")]
		public Transform RightAwardGrid;

		// Token: 0x0400E08A RID: 57482
		[Token(Token = "0x400E08A")]
		[FieldOffset(Offset = "0xC0")]
		public Transform FirstAwardGrid;

		// Token: 0x0400E08B RID: 57483
		[Token(Token = "0x400E08B")]
		[FieldOffset(Offset = "0xC8")]
		public Transform SecondAwardGrid;

		// Token: 0x0400E08C RID: 57484
		[Token(Token = "0x400E08C")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject RewardTitle;

		// Token: 0x0400E08D RID: 57485
		[Token(Token = "0x400E08D")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton BtnChest;

		// Token: 0x0400E08E RID: 57486
		[Token(Token = "0x400E08E")]
		[FieldOffset(Offset = "0xE0")]
		public UISprite IconChest;

		// Token: 0x0400E08F RID: 57487
		[Token(Token = "0x400E08F")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton OKBtn;
	}
}
