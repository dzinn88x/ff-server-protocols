using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023F4 RID: 9204
	[Token(Token = "0x20023F4")]
	internal class UILobbyBonusEventInfoView : UIBaseView
	{
		// Token: 0x0600C2F8 RID: 49912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2F8")]
		[Address(RVA = "0x1529FE0", Offset = "0x1529FE0", VA = "0x7BBBD29FE0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2F9 RID: 49913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2F9")]
		[Address(RVA = "0x152A274", Offset = "0x152A274", VA = "0x7BBBD2A274")]
		public UILobbyBonusEventInfoView()
		{
		}

		// Token: 0x0400E155 RID: 57685
		[Token(Token = "0x400E155")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid Grid;

		// Token: 0x0400E156 RID: 57686
		[Token(Token = "0x400E156")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ExpBonus;

		// Token: 0x0400E157 RID: 57687
		[Token(Token = "0x400E157")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ExpBonusValue;

		// Token: 0x0400E158 RID: 57688
		[Token(Token = "0x400E158")]
		[FieldOffset(Offset = "0x38")]
		public UIButton GoldBonus;

		// Token: 0x0400E159 RID: 57689
		[Token(Token = "0x400E159")]
		[FieldOffset(Offset = "0x40")]
		public UILabel GoldBonusValue;

		// Token: 0x0400E15A RID: 57690
		[Token(Token = "0x400E15A")]
		[FieldOffset(Offset = "0x48")]
		public UIButton GoldLimit;

		// Token: 0x0400E15B RID: 57691
		[Token(Token = "0x400E15B")]
		[FieldOffset(Offset = "0x50")]
		public UILabel GoldLimitValue;

		// Token: 0x0400E15C RID: 57692
		[Token(Token = "0x400E15C")]
		[FieldOffset(Offset = "0x58")]
		public UIButton DebrisLimit;

		// Token: 0x0400E15D RID: 57693
		[Token(Token = "0x400E15D")]
		[FieldOffset(Offset = "0x60")]
		public UILabel DebrisLimitValue;
	}
}
