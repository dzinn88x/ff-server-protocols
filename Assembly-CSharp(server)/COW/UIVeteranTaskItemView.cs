using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002588 RID: 9608
	[Token(Token = "0x2002588")]
	public class UIVeteranTaskItemView : UIBaseView
	{
		// Token: 0x0600C620 RID: 50720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C620")]
		[Address(RVA = "0x1683254", Offset = "0x1683254", VA = "0x7BBBE83254", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C621 RID: 50721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C621")]
		[Address(RVA = "0x1683514", Offset = "0x1683514", VA = "0x7BBBE83514")]
		public UIVeteranTaskItemView()
		{
		}

		// Token: 0x0400F70D RID: 63245
		[Token(Token = "0x400F70D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BGSpriteLight;

		// Token: 0x0400F70E RID: 63246
		[Token(Token = "0x400F70E")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BGSpriteDark;

		// Token: 0x0400F70F RID: 63247
		[Token(Token = "0x400F70F")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid Grid;

		// Token: 0x0400F710 RID: 63248
		[Token(Token = "0x400F710")]
		[FieldOffset(Offset = "0x38")]
		public UIButton Operation;

		// Token: 0x0400F711 RID: 63249
		[Token(Token = "0x400F711")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ClaimedState;

		// Token: 0x0400F712 RID: 63250
		[Token(Token = "0x400F712")]
		[FieldOffset(Offset = "0x48")]
		public GameObject UnfinishedState;

		// Token: 0x0400F713 RID: 63251
		[Token(Token = "0x400F713")]
		[FieldOffset(Offset = "0x50")]
		public GameObject FinishedState;

		// Token: 0x0400F714 RID: 63252
		[Token(Token = "0x400F714")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Title;

		// Token: 0x0400F715 RID: 63253
		[Token(Token = "0x400F715")]
		[FieldOffset(Offset = "0x60")]
		public UILabel ProgressTips;

		// Token: 0x0400F716 RID: 63254
		[Token(Token = "0x400F716")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Desc;
	}
}
