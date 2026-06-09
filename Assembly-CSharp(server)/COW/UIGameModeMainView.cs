using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002235 RID: 8757
	[Token(Token = "0x2002235")]
	public class UIGameModeMainView : UIBaseView
	{
		// Token: 0x0600BF7B RID: 49019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF7B")]
		[Address(RVA = "0x2008E9C", Offset = "0x2008E9C", VA = "0x7BBC808E9C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF7C RID: 49020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF7C")]
		[Address(RVA = "0x20094F0", Offset = "0x20094F0", VA = "0x7BBC8094F0")]
		public UIGameModeMainView()
		{
		}

		// Token: 0x0400D12F RID: 53551
		[Token(Token = "0x400D12F")]
		[FieldOffset(Offset = "0x20")]
		public Transform LeftBottom;

		// Token: 0x0400D130 RID: 53552
		[Token(Token = "0x400D130")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid teamBtnGroup;

		// Token: 0x0400D131 RID: 53553
		[Token(Token = "0x400D131")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButton soloBtn;

		// Token: 0x0400D132 RID: 53554
		[Token(Token = "0x400D132")]
		[FieldOffset(Offset = "0x38")]
		public UIToggleButton duoBtn;

		// Token: 0x0400D133 RID: 53555
		[Token(Token = "0x400D133")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleButton quadBtn;

		// Token: 0x0400D134 RID: 53556
		[Token(Token = "0x400D134")]
		[FieldOffset(Offset = "0x48")]
		public GameObject roomBtnCon;

		// Token: 0x0400D135 RID: 53557
		[Token(Token = "0x400D135")]
		[FieldOffset(Offset = "0x50")]
		public UIButton roomBtn;

		// Token: 0x0400D136 RID: 53558
		[Token(Token = "0x400D136")]
		[FieldOffset(Offset = "0x58")]
		public GameObject trainingBtnCon;

		// Token: 0x0400D137 RID: 53559
		[Token(Token = "0x400D137")]
		[FieldOffset(Offset = "0x60")]
		public GameObject trainingGuide;

		// Token: 0x0400D138 RID: 53560
		[Token(Token = "0x400D138")]
		[FieldOffset(Offset = "0x68")]
		public GameObject trainingLockIcon;

		// Token: 0x0400D139 RID: 53561
		[Token(Token = "0x400D139")]
		[FieldOffset(Offset = "0x70")]
		public GameObject trainingNormalIcon;

		// Token: 0x0400D13A RID: 53562
		[Token(Token = "0x400D13A")]
		[FieldOffset(Offset = "0x78")]
		public UIButton trainingBtn;

		// Token: 0x0400D13B RID: 53563
		[Token(Token = "0x400D13B")]
		[FieldOffset(Offset = "0x80")]
		public UILabel trainingLabel;

		// Token: 0x0400D13C RID: 53564
		[Token(Token = "0x400D13C")]
		[FieldOffset(Offset = "0x88")]
		public UIButton leaveBtn;

		// Token: 0x0400D13D RID: 53565
		[Token(Token = "0x400D13D")]
		[FieldOffset(Offset = "0x90")]
		public UILabel BackLabel;

		// Token: 0x0400D13E RID: 53566
		[Token(Token = "0x400D13E")]
		[FieldOffset(Offset = "0x98")]
		public UIPanel ScrollView;

		// Token: 0x0400D13F RID: 53567
		[Token(Token = "0x400D13F")]
		[FieldOffset(Offset = "0xA0")]
		public UICustomSortTable table;

		// Token: 0x0400D140 RID: 53568
		[Token(Token = "0x400D140")]
		[FieldOffset(Offset = "0xA8")]
		public UIToggleButtonGroup ModeBtnGroup;

		// Token: 0x0400D141 RID: 53569
		[Token(Token = "0x400D141")]
		[FieldOffset(Offset = "0xB0")]
		public Transform ranked;

		// Token: 0x0400D142 RID: 53570
		[Token(Token = "0x400D142")]
		[FieldOffset(Offset = "0xB8")]
		public Transform classic;

		// Token: 0x0400D143 RID: 53571
		[Token(Token = "0x400D143")]
		[FieldOffset(Offset = "0xC0")]
		public Transform csrank;

		// Token: 0x0400D144 RID: 53572
		[Token(Token = "0x400D144")]
		[FieldOffset(Offset = "0xC8")]
		public UICustomSortTable hot;

		// Token: 0x0400D145 RID: 53573
		[Token(Token = "0x400D145")]
		[FieldOffset(Offset = "0xD0")]
		public Transform hot1;

		// Token: 0x0400D146 RID: 53574
		[Token(Token = "0x400D146")]
		[FieldOffset(Offset = "0xD8")]
		public Transform hot2;

		// Token: 0x0400D147 RID: 53575
		[Token(Token = "0x400D147")]
		[FieldOffset(Offset = "0xE0")]
		public UIGrid casualGrid;
	}
}
