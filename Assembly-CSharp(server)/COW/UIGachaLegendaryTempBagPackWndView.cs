using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002218 RID: 8728
	[Token(Token = "0x2002218")]
	public class UIGachaLegendaryTempBagPackWndView : UIBaseView
	{
		// Token: 0x0600BF41 RID: 48961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF41")]
		[Address(RVA = "0x205B674", Offset = "0x205B674", VA = "0x7BBC85B674", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF42 RID: 48962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF42")]
		[Address(RVA = "0x205B9C8", Offset = "0x205B9C8", VA = "0x7BBC85B9C8")]
		public UIGachaLegendaryTempBagPackWndView()
		{
		}

		// Token: 0x0400CF22 RID: 53026
		[Token(Token = "0x400CF22")]
		[FieldOffset(Offset = "0x20")]
		public UILabel WonnedNum;

		// Token: 0x0400CF23 RID: 53027
		[Token(Token = "0x400CF23")]
		[FieldOffset(Offset = "0x28")]
		public UIButton GainBtn;

		// Token: 0x0400CF24 RID: 53028
		[Token(Token = "0x400CF24")]
		[FieldOffset(Offset = "0x30")]
		public UILabel GainLabel;

		// Token: 0x0400CF25 RID: 53029
		[Token(Token = "0x400CF25")]
		[FieldOffset(Offset = "0x38")]
		public UIButton RandomBtn;

		// Token: 0x0400CF26 RID: 53030
		[Token(Token = "0x400CF26")]
		[FieldOffset(Offset = "0x40")]
		public UILabel RandomLabel;

		// Token: 0x0400CF27 RID: 53031
		[Token(Token = "0x400CF27")]
		[FieldOffset(Offset = "0x48")]
		public UILabel RandomTipLabel;

		// Token: 0x0400CF28 RID: 53032
		[Token(Token = "0x400CF28")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Label;

		// Token: 0x0400CF29 RID: 53033
		[Token(Token = "0x400CF29")]
		[FieldOffset(Offset = "0x58")]
		public UIButton QuickSelectBtn;

		// Token: 0x0400CF2A RID: 53034
		[Token(Token = "0x400CF2A")]
		[FieldOffset(Offset = "0x60")]
		public UILabel QuickSelectLabel;

		// Token: 0x0400CF2B RID: 53035
		[Token(Token = "0x400CF2B")]
		[FieldOffset(Offset = "0x68")]
		public UIScrollView ScrollView;

		// Token: 0x0400CF2C RID: 53036
		[Token(Token = "0x400CF2C")]
		[FieldOffset(Offset = "0x70")]
		public UIEasyList EasyList;

		// Token: 0x0400CF2D RID: 53037
		[Token(Token = "0x400CF2D")]
		[FieldOffset(Offset = "0x78")]
		public GameObject NoItemLabel;
	}
}
