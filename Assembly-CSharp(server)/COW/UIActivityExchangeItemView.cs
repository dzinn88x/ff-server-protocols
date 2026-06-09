using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020DF RID: 8415
	[Token(Token = "0x20020DF")]
	public class UIActivityExchangeItemView : UIBaseView
	{
		// Token: 0x0600BCCF RID: 48335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCCF")]
		[Address(RVA = "0x1950C10", Offset = "0x1950C10", VA = "0x7BBC150C10", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCD0 RID: 48336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD0")]
		[Address(RVA = "0x1950F9C", Offset = "0x1950F9C", VA = "0x7BBC150F9C")]
		public UIActivityExchangeItemView()
		{
		}

		// Token: 0x0400BEF9 RID: 48889
		[Token(Token = "0x400BEF9")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UIActivityExchangeItem;

		// Token: 0x0400BEFA RID: 48890
		[Token(Token = "0x400BEFA")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollView AwardScrollView;

		// Token: 0x0400BEFB RID: 48891
		[Token(Token = "0x400BEFB")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid AwardGrid;

		// Token: 0x0400BEFC RID: 48892
		[Token(Token = "0x400BEFC")]
		[FieldOffset(Offset = "0x38")]
		public Transform ExchangeItemGrid;

		// Token: 0x0400BEFD RID: 48893
		[Token(Token = "0x400BEFD")]
		[FieldOffset(Offset = "0x40")]
		public UIButton Operation;

		// Token: 0x0400BEFE RID: 48894
		[Token(Token = "0x400BEFE")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BGGray;

		// Token: 0x0400BEFF RID: 48895
		[Token(Token = "0x400BEFF")]
		[FieldOffset(Offset = "0x50")]
		public GameObject BGYellow;

		// Token: 0x0400BF00 RID: 48896
		[Token(Token = "0x400BF00")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Gained;

		// Token: 0x0400BF01 RID: 48897
		[Token(Token = "0x400BF01")]
		[FieldOffset(Offset = "0x60")]
		public UILabel GainedLabel;

		// Token: 0x0400BF02 RID: 48898
		[Token(Token = "0x400BF02")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Title;

		// Token: 0x0400BF03 RID: 48899
		[Token(Token = "0x400BF03")]
		[FieldOffset(Offset = "0x70")]
		public UIToggle RedTipsOnOff;

		// Token: 0x0400BF04 RID: 48900
		[Token(Token = "0x400BF04")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ProgressIcon;

		// Token: 0x0400BF05 RID: 48901
		[Token(Token = "0x400BF05")]
		[FieldOffset(Offset = "0x80")]
		public UILabel ProgressTips;
	}
}
