using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020DA RID: 8410
	[Token(Token = "0x20020DA")]
	internal class UIActivityBingoView : UIBaseView
	{
		// Token: 0x0600BCC5 RID: 48325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCC5")]
		[Address(RVA = "0x1A45CE8", Offset = "0x1A45CE8", VA = "0x7BBC245CE8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCC6 RID: 48326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCC6")]
		[Address(RVA = "0x1A46288", Offset = "0x1A46288", VA = "0x7BBC246288")]
		public UIActivityBingoView()
		{
		}

		// Token: 0x0400BEB0 RID: 48816
		[Token(Token = "0x400BEB0")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BGCover;

		// Token: 0x0400BEB1 RID: 48817
		[Token(Token = "0x400BEB1")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture BGNetwork;

		// Token: 0x0400BEB2 RID: 48818
		[Token(Token = "0x400BEB2")]
		[FieldOffset(Offset = "0x30")]
		public GameObject BGDefault;

		// Token: 0x0400BEB3 RID: 48819
		[Token(Token = "0x400BEB3")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid Cards;

		// Token: 0x0400BEB4 RID: 48820
		[Token(Token = "0x400BEB4")]
		[FieldOffset(Offset = "0x40")]
		public Transform RewardSlotRow1;

		// Token: 0x0400BEB5 RID: 48821
		[Token(Token = "0x400BEB5")]
		[FieldOffset(Offset = "0x48")]
		public Transform RewardSlotRow2;

		// Token: 0x0400BEB6 RID: 48822
		[Token(Token = "0x400BEB6")]
		[FieldOffset(Offset = "0x50")]
		public Transform RewardSlotRow3;

		// Token: 0x0400BEB7 RID: 48823
		[Token(Token = "0x400BEB7")]
		[FieldOffset(Offset = "0x58")]
		public Transform RewardSlotColum1;

		// Token: 0x0400BEB8 RID: 48824
		[Token(Token = "0x400BEB8")]
		[FieldOffset(Offset = "0x60")]
		public Transform RewardSlotColum2;

		// Token: 0x0400BEB9 RID: 48825
		[Token(Token = "0x400BEB9")]
		[FieldOffset(Offset = "0x68")]
		public Transform RewardSlotColum3;

		// Token: 0x0400BEBA RID: 48826
		[Token(Token = "0x400BEBA")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Task;

		// Token: 0x0400BEBB RID: 48827
		[Token(Token = "0x400BEBB")]
		[FieldOffset(Offset = "0x78")]
		public UILabel TaskTitle;

		// Token: 0x0400BEBC RID: 48828
		[Token(Token = "0x400BEBC")]
		[FieldOffset(Offset = "0x80")]
		public UILabel TaskProgress;

		// Token: 0x0400BEBD RID: 48829
		[Token(Token = "0x400BEBD")]
		[FieldOffset(Offset = "0x88")]
		public UILabel TaskDesc;

		// Token: 0x0400BEBE RID: 48830
		[Token(Token = "0x400BEBE")]
		[FieldOffset(Offset = "0x90")]
		public UIButton QuickComplete;

		// Token: 0x0400BEBF RID: 48831
		[Token(Token = "0x400BEBF")]
		[FieldOffset(Offset = "0x98")]
		public UILabel QuickCompleteTitle;

		// Token: 0x0400BEC0 RID: 48832
		[Token(Token = "0x400BEC0")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite KeyIcon;

		// Token: 0x0400BEC1 RID: 48833
		[Token(Token = "0x400BEC1")]
		[FieldOffset(Offset = "0xA8")]
		public UIWidget KeyIconMaxSize;

		// Token: 0x0400BEC2 RID: 48834
		[Token(Token = "0x400BEC2")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel KeyCount;

		// Token: 0x0400BEC3 RID: 48835
		[Token(Token = "0x400BEC3")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel IntroTime;

		// Token: 0x0400BEC4 RID: 48836
		[Token(Token = "0x400BEC4")]
		[FieldOffset(Offset = "0xC0")]
		public UIGrid PrizeGrid;

		// Token: 0x0400BEC5 RID: 48837
		[Token(Token = "0x400BEC5")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton Help;
	}
}
