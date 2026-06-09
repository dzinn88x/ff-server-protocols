using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020E0 RID: 8416
	[Token(Token = "0x20020E0")]
	public class UIActivityFestivalContentView : UIBaseView
	{
		// Token: 0x0600BCD1 RID: 48337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD1")]
		[Address(RVA = "0x1953A04", Offset = "0x1953A04", VA = "0x7BBC153A04", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCD2 RID: 48338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD2")]
		[Address(RVA = "0x1953E28", Offset = "0x1953E28", VA = "0x7BBC153E28")]
		public UIActivityFestivalContentView()
		{
		}

		// Token: 0x0400BF06 RID: 48902
		[Token(Token = "0x400BF06")]
		[FieldOffset(Offset = "0x20")]
		public UILabel OperationTips;

		// Token: 0x0400BF07 RID: 48903
		[Token(Token = "0x400BF07")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Operation;

		// Token: 0x0400BF08 RID: 48904
		[Token(Token = "0x400BF08")]
		[FieldOffset(Offset = "0x30")]
		public GameObject OperateBtnGray;

		// Token: 0x0400BF09 RID: 48905
		[Token(Token = "0x400BF09")]
		[FieldOffset(Offset = "0x38")]
		public GameObject OperateBtnWhite;

		// Token: 0x0400BF0A RID: 48906
		[Token(Token = "0x400BF0A")]
		[FieldOffset(Offset = "0x40")]
		public GameObject OperateBtnYellow;

		// Token: 0x0400BF0B RID: 48907
		[Token(Token = "0x400BF0B")]
		[FieldOffset(Offset = "0x48")]
		public UILabel OperateBtnTitle;

		// Token: 0x0400BF0C RID: 48908
		[Token(Token = "0x400BF0C")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Gained;

		// Token: 0x0400BF0D RID: 48909
		[Token(Token = "0x400BF0D")]
		[FieldOffset(Offset = "0x58")]
		public UILabel GainedLabel;

		// Token: 0x0400BF0E RID: 48910
		[Token(Token = "0x400BF0E")]
		[FieldOffset(Offset = "0x60")]
		public UIToggleButtonGroup AwardSelectGroup;

		// Token: 0x0400BF0F RID: 48911
		[Token(Token = "0x400BF0F")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ScrollView_NoTabs;

		// Token: 0x0400BF10 RID: 48912
		[Token(Token = "0x400BF10")]
		[FieldOffset(Offset = "0x70")]
		public GameObject ScrollView;

		// Token: 0x0400BF11 RID: 48913
		[Token(Token = "0x400BF11")]
		[FieldOffset(Offset = "0x78")]
		public UITable ContentTable;

		// Token: 0x0400BF12 RID: 48914
		[Token(Token = "0x400BF12")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Introduction;

		// Token: 0x0400BF13 RID: 48915
		[Token(Token = "0x400BF13")]
		[FieldOffset(Offset = "0x88")]
		public UILabel Time;

		// Token: 0x0400BF14 RID: 48916
		[Token(Token = "0x400BF14")]
		[FieldOffset(Offset = "0x90")]
		public GameObject AwardTemplate;

		// Token: 0x0400BF15 RID: 48917
		[Token(Token = "0x400BF15")]
		[FieldOffset(Offset = "0x98")]
		public UIDragScrollView DragArea;
	}
}
