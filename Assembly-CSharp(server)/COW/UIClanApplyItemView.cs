using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200215D RID: 8541
	[Token(Token = "0x200215D")]
	internal class UIClanApplyItemView : UIBaseView
	{
		// Token: 0x0600BDCA RID: 48586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDCA")]
		[Address(RVA = "0x1BF87A0", Offset = "0x1BF87A0", VA = "0x7BBC3F87A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDCB RID: 48587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDCB")]
		[Address(RVA = "0x1BF8AF4", Offset = "0x1BF8AF4", VA = "0x7BBC3F8AF4")]
		public UIClanApplyItemView()
		{
		}

		// Token: 0x0400C57B RID: 50555
		[Token(Token = "0x400C57B")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIClanApplyItem;

		// Token: 0x0400C57C RID: 50556
		[Token(Token = "0x400C57C")]
		[FieldOffset(Offset = "0x28")]
		public UISprite SelectLine;

		// Token: 0x0400C57D RID: 50557
		[Token(Token = "0x400C57D")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget ClanItemInfoContainer;

		// Token: 0x0400C57E RID: 50558
		[Token(Token = "0x400C57E")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ClanPosition;

		// Token: 0x0400C57F RID: 50559
		[Token(Token = "0x400C57F")]
		[FieldOffset(Offset = "0x40")]
		public UILabel HonorPointLabel;

		// Token: 0x0400C580 RID: 50560
		[Token(Token = "0x400C580")]
		[FieldOffset(Offset = "0x48")]
		public UILabel AccountState_Online;

		// Token: 0x0400C581 RID: 50561
		[Token(Token = "0x400C581")]
		[FieldOffset(Offset = "0x50")]
		public UILabel AccountState_Offline;

		// Token: 0x0400C582 RID: 50562
		[Token(Token = "0x400C582")]
		[FieldOffset(Offset = "0x58")]
		public UILabel AccountState_InGame;

		// Token: 0x0400C583 RID: 50563
		[Token(Token = "0x400C583")]
		[FieldOffset(Offset = "0x60")]
		public Transform AccountInfoContainer;

		// Token: 0x0400C584 RID: 50564
		[Token(Token = "0x400C584")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ApplyBtnGroup;

		// Token: 0x0400C585 RID: 50565
		[Token(Token = "0x400C585")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnComfirm;

		// Token: 0x0400C586 RID: 50566
		[Token(Token = "0x400C586")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BtnRefuse;
	}
}
