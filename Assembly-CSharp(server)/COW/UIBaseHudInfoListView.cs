using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002119 RID: 8473
	[Token(Token = "0x2002119")]
	public class UIBaseHudInfoListView : UIBaseView
	{
		// Token: 0x0600BD43 RID: 48451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD43")]
		[Address(RVA = "0x14237B8", Offset = "0x14237B8", VA = "0x7BBBC237B8")]
		public UIBaseHudInfoListView()
		{
		}

		// Token: 0x0400C1DE RID: 49630
		[Token(Token = "0x400C1DE")]
		[FieldOffset(Offset = "0x20")]
		public UIButton RightClose;

		// Token: 0x0400C1DF RID: 49631
		[Token(Token = "0x400C1DF")]
		[FieldOffset(Offset = "0x28")]
		public TweenPosition Pivot;

		// Token: 0x0400C1E0 RID: 49632
		[Token(Token = "0x400C1E0")]
		[FieldOffset(Offset = "0x30")]
		public GameObject InfoPanel;

		// Token: 0x0400C1E1 RID: 49633
		[Token(Token = "0x400C1E1")]
		[FieldOffset(Offset = "0x38")]
		public GameObject playerTab;

		// Token: 0x0400C1E2 RID: 49634
		[Token(Token = "0x400C1E2")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleButton PlayerToggleBtn;

		// Token: 0x0400C1E3 RID: 49635
		[Token(Token = "0x400C1E3")]
		[FieldOffset(Offset = "0x48")]
		public GameObject airdropTab;

		// Token: 0x0400C1E4 RID: 49636
		[Token(Token = "0x400C1E4")]
		[FieldOffset(Offset = "0x50")]
		public UIToggleButton AirdropToggleBtn;

		// Token: 0x0400C1E5 RID: 49637
		[Token(Token = "0x400C1E5")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Airdrop;

		// Token: 0x0400C1E6 RID: 49638
		[Token(Token = "0x400C1E6")]
		[FieldOffset(Offset = "0x60")]
		public UIScrollView AirdropList;

		// Token: 0x0400C1E7 RID: 49639
		[Token(Token = "0x400C1E7")]
		[FieldOffset(Offset = "0x68")]
		public UIGrid AirdropGrid;

		// Token: 0x0400C1E8 RID: 49640
		[Token(Token = "0x400C1E8")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Player;

		// Token: 0x0400C1E9 RID: 49641
		[Token(Token = "0x400C1E9")]
		[FieldOffset(Offset = "0x78")]
		public UIScrollView PlayerList;

		// Token: 0x0400C1EA RID: 49642
		[Token(Token = "0x400C1EA")]
		[FieldOffset(Offset = "0x80")]
		public UIEasyList PlayerGrid;

		// Token: 0x0400C1EB RID: 49643
		[Token(Token = "0x400C1EB")]
		[FieldOffset(Offset = "0x88")]
		public GameObject PCBG;

		// Token: 0x0400C1EC RID: 49644
		[Token(Token = "0x400C1EC")]
		[FieldOffset(Offset = "0x90")]
		public GameObject MobileBG;

		// Token: 0x0400C1ED RID: 49645
		[Token(Token = "0x400C1ED")]
		[FieldOffset(Offset = "0x98")]
		public GameObject GlassBG;
	}
}
