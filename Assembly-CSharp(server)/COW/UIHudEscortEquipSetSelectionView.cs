using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022C8 RID: 8904
	[Token(Token = "0x20022C8")]
	public class UIHudEscortEquipSetSelectionView : UIBaseView
	{
		// Token: 0x0600C0A0 RID: 49312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0A0")]
		[Address(RVA = "0x1C070A4", Offset = "0x1C070A4", VA = "0x7BBC4070A4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0A1 RID: 49313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0A1")]
		[Address(RVA = "0x1C07330", Offset = "0x1C07330", VA = "0x7BBC407330")]
		public UIHudEscortEquipSetSelectionView()
		{
		}

		// Token: 0x0400D675 RID: 54901
		[Token(Token = "0x400D675")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LastTime;

		// Token: 0x0400D676 RID: 54902
		[Token(Token = "0x400D676")]
		[FieldOffset(Offset = "0x28")]
		public GameObject InGameContainer;

		// Token: 0x0400D677 RID: 54903
		[Token(Token = "0x400D677")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LeftTimeShow;

		// Token: 0x0400D678 RID: 54904
		[Token(Token = "0x400D678")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LeftTime;

		// Token: 0x0400D679 RID: 54905
		[Token(Token = "0x400D679")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnConfirm;

		// Token: 0x0400D67A RID: 54906
		[Token(Token = "0x400D67A")]
		[FieldOffset(Offset = "0x48")]
		public GameObject LobbyContainer;

		// Token: 0x0400D67B RID: 54907
		[Token(Token = "0x400D67B")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnClose;

		// Token: 0x0400D67C RID: 54908
		[Token(Token = "0x400D67C")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid Grid;

		// Token: 0x0400D67D RID: 54909
		[Token(Token = "0x400D67D")]
		[FieldOffset(Offset = "0x60")]
		public GameObject LabelNumShow;
	}
}
