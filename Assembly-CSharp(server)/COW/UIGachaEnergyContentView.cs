using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200220C RID: 8716
	[Token(Token = "0x200220C")]
	public class UIGachaEnergyContentView : UIBaseView
	{
		// Token: 0x0600BF29 RID: 48937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF29")]
		[Address(RVA = "0x21621F4", Offset = "0x21621F4", VA = "0x7BBC9621F4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF2A RID: 48938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF2A")]
		[Address(RVA = "0x21625F4", Offset = "0x21625F4", VA = "0x7BBC9625F4")]
		public UIGachaEnergyContentView()
		{
		}

		// Token: 0x0400CE8F RID: 52879
		[Token(Token = "0x400CE8F")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget PreviewLeftSide;

		// Token: 0x0400CE90 RID: 52880
		[Token(Token = "0x400CE90")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget PreviewRightSide;

		// Token: 0x0400CE91 RID: 52881
		[Token(Token = "0x400CE91")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Anim;

		// Token: 0x0400CE92 RID: 52882
		[Token(Token = "0x400CE92")]
		[FieldOffset(Offset = "0x38")]
		public GameObject CDNMask01;

		// Token: 0x0400CE93 RID: 52883
		[Token(Token = "0x400CE93")]
		[FieldOffset(Offset = "0x40")]
		public GameObject CDNMask02;

		// Token: 0x0400CE94 RID: 52884
		[Token(Token = "0x400CE94")]
		[FieldOffset(Offset = "0x48")]
		public GameObject EnergyDefaultTitle;

		// Token: 0x0400CE95 RID: 52885
		[Token(Token = "0x400CE95")]
		[FieldOffset(Offset = "0x50")]
		public UINetworkTexture LimitTitleCDN;

		// Token: 0x0400CE96 RID: 52886
		[Token(Token = "0x400CE96")]
		[FieldOffset(Offset = "0x58")]
		public UICountDownIcon CountDownIcon;

		// Token: 0x0400CE97 RID: 52887
		[Token(Token = "0x400CE97")]
		[FieldOffset(Offset = "0x60")]
		public UICountDownLabel GachaCountDownLabel;

		// Token: 0x0400CE98 RID: 52888
		[Token(Token = "0x400CE98")]
		[FieldOffset(Offset = "0x68")]
		public UIButton RefreshBuffBtn;

		// Token: 0x0400CE99 RID: 52889
		[Token(Token = "0x400CE99")]
		[FieldOffset(Offset = "0x70")]
		public UICheckboxButton ChooseCheckBtn;

		// Token: 0x0400CE9A RID: 52890
		[Token(Token = "0x400CE9A")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ChooseState;

		// Token: 0x0400CE9B RID: 52891
		[Token(Token = "0x400CE9B")]
		[FieldOffset(Offset = "0x80")]
		public GameObject BuyBtnGroup;

		// Token: 0x0400CE9C RID: 52892
		[Token(Token = "0x400CE9C")]
		[FieldOffset(Offset = "0x88")]
		public UIButton ShowRewardsBtn;

		// Token: 0x0400CE9D RID: 52893
		[Token(Token = "0x400CE9D")]
		[FieldOffset(Offset = "0x90")]
		public UIWidget GachaPreviewPosition;
	}
}
