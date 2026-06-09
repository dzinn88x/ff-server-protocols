using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021CC RID: 8652
	[Token(Token = "0x20021CC")]
	public class UIEPDailyTaskView : UIBaseView
	{
		// Token: 0x0600BEA9 RID: 48809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEA9")]
		[Address(RVA = "0x22134A4", Offset = "0x22134A4", VA = "0x7BBCA134A4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEAA RID: 48810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEAA")]
		[Address(RVA = "0x22139C0", Offset = "0x22139C0", VA = "0x7BBCA139C0")]
		public UIEPDailyTaskView()
		{
		}

		// Token: 0x0400CB33 RID: 52019
		[Token(Token = "0x400CB33")]
		[FieldOffset(Offset = "0x20")]
		public UIButton TaskMask;

		// Token: 0x0400CB34 RID: 52020
		[Token(Token = "0x400CB34")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TaskDesc;

		// Token: 0x0400CB35 RID: 52021
		[Token(Token = "0x400CB35")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Process;

		// Token: 0x0400CB36 RID: 52022
		[Token(Token = "0x400CB36")]
		[FieldOffset(Offset = "0x38")]
		public Transform ProcessTrans;

		// Token: 0x0400CB37 RID: 52023
		[Token(Token = "0x400CB37")]
		[FieldOffset(Offset = "0x40")]
		public GameObject FPDesc;

		// Token: 0x0400CB38 RID: 52024
		[Token(Token = "0x400CB38")]
		[FieldOffset(Offset = "0x48")]
		public UIButton UpgradeBtn;

		// Token: 0x0400CB39 RID: 52025
		[Token(Token = "0x400CB39")]
		[FieldOffset(Offset = "0x50")]
		public GameObject EPDesc;

		// Token: 0x0400CB3A RID: 52026
		[Token(Token = "0x400CB3A")]
		[FieldOffset(Offset = "0x58")]
		public UIButton DailySignBtn;

		// Token: 0x0400CB3B RID: 52027
		[Token(Token = "0x400CB3B")]
		[FieldOffset(Offset = "0x60")]
		public UINetworkTexture CDNTexture;

		// Token: 0x0400CB3C RID: 52028
		[Token(Token = "0x400CB3C")]
		[FieldOffset(Offset = "0x68")]
		public Transform Pos1;

		// Token: 0x0400CB3D RID: 52029
		[Token(Token = "0x400CB3D")]
		[FieldOffset(Offset = "0x70")]
		public Transform Pos2;

		// Token: 0x0400CB3E RID: 52030
		[Token(Token = "0x400CB3E")]
		[FieldOffset(Offset = "0x78")]
		public Transform Pos3;

		// Token: 0x0400CB3F RID: 52031
		[Token(Token = "0x400CB3F")]
		[FieldOffset(Offset = "0x80")]
		public Transform Pos4;

		// Token: 0x0400CB40 RID: 52032
		[Token(Token = "0x400CB40")]
		[FieldOffset(Offset = "0x88")]
		public Transform Pos5;

		// Token: 0x0400CB41 RID: 52033
		[Token(Token = "0x400CB41")]
		[FieldOffset(Offset = "0x90")]
		public Transform Pos6;

		// Token: 0x0400CB42 RID: 52034
		[Token(Token = "0x400CB42")]
		[FieldOffset(Offset = "0x98")]
		public Transform Pos7;

		// Token: 0x0400CB43 RID: 52035
		[Token(Token = "0x400CB43")]
		[FieldOffset(Offset = "0xA0")]
		public Transform Pos8;

		// Token: 0x0400CB44 RID: 52036
		[Token(Token = "0x400CB44")]
		[FieldOffset(Offset = "0xA8")]
		public Animation ProcessAnim;

		// Token: 0x0400CB45 RID: 52037
		[Token(Token = "0x400CB45")]
		[FieldOffset(Offset = "0xB0")]
		public UIScrollView TaskScrollView;

		// Token: 0x0400CB46 RID: 52038
		[Token(Token = "0x400CB46")]
		[FieldOffset(Offset = "0xB8")]
		public UIEasyList TaskList;
	}
}
