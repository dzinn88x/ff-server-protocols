using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200237E RID: 9086
	[Token(Token = "0x200237E")]
	public class UIHudTestRecipeView : UIBaseView
	{
		// Token: 0x0600C20C RID: 49676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C20C")]
		[Address(RVA = "0x15E586C", Offset = "0x15E586C", VA = "0x7BBBDE586C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C20D RID: 49677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C20D")]
		[Address(RVA = "0x15E5C4C", Offset = "0x15E5C4C", VA = "0x7BBBDE5C4C")]
		public UIHudTestRecipeView()
		{
		}

		// Token: 0x0400DC7C RID: 56444
		[Token(Token = "0x400DC7C")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ToggleRecipeDebug;

		// Token: 0x0400DC7D RID: 56445
		[Token(Token = "0x400DC7D")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Test;

		// Token: 0x0400DC7E RID: 56446
		[Token(Token = "0x400DC7E")]
		[FieldOffset(Offset = "0x30")]
		public GameObject wardrobeBtnTemplate;

		// Token: 0x0400DC7F RID: 56447
		[Token(Token = "0x400DC7F")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid wardrobeTypeGrid;

		// Token: 0x0400DC80 RID: 56448
		[Token(Token = "0x400DC80")]
		[FieldOffset(Offset = "0x40")]
		public GameObject recipeBtnTemplate;

		// Token: 0x0400DC81 RID: 56449
		[Token(Token = "0x400DC81")]
		[FieldOffset(Offset = "0x48")]
		public UIEasyList recipeEasyList;

		// Token: 0x0400DC82 RID: 56450
		[Token(Token = "0x400DC82")]
		[FieldOffset(Offset = "0x50")]
		public GameObject avatarBtnTemplate;

		// Token: 0x0400DC83 RID: 56451
		[Token(Token = "0x400DC83")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid avatarGrid;

		// Token: 0x0400DC84 RID: 56452
		[Token(Token = "0x400DC84")]
		[FieldOffset(Offset = "0x60")]
		public UIGrid UtilGrid;

		// Token: 0x0400DC85 RID: 56453
		[Token(Token = "0x400DC85")]
		[FieldOffset(Offset = "0x68")]
		public UIButton ClearAllRecipeBtn;

		// Token: 0x0400DC86 RID: 56454
		[Token(Token = "0x400DC86")]
		[FieldOffset(Offset = "0x70")]
		public UICheckboxButton UseDefaultQualityCheckBox;

		// Token: 0x0400DC87 RID: 56455
		[Token(Token = "0x400DC87")]
		[FieldOffset(Offset = "0x78")]
		public UICheckboxButton UseHighQualityCheckBox;

		// Token: 0x0400DC88 RID: 56456
		[Token(Token = "0x400DC88")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BroadcastToOthers;

		// Token: 0x0400DC89 RID: 56457
		[Token(Token = "0x400DC89")]
		[FieldOffset(Offset = "0x88")]
		public UIInput searchInput;

		// Token: 0x0400DC8A RID: 56458
		[Token(Token = "0x400DC8A")]
		[FieldOffset(Offset = "0x90")]
		public UIEasyList searchEasyList;
	}
}
