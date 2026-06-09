using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002139 RID: 8505
	[Token(Token = "0x2002139")]
	public class UIChampionshipReviewRewardListView : UIBaseView
	{
		// Token: 0x0600BD82 RID: 48514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD82")]
		[Address(RVA = "0x1ECB840", Offset = "0x1ECB840", VA = "0x7BBC6CB840", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD83 RID: 48515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD83")]
		[Address(RVA = "0x1ECBB58", Offset = "0x1ECBB58", VA = "0x7BBC6CBB58")]
		public UIChampionshipReviewRewardListView()
		{
		}

		// Token: 0x0400C3B7 RID: 50103
		[Token(Token = "0x400C3B7")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget Container;

		// Token: 0x0400C3B8 RID: 50104
		[Token(Token = "0x400C3B8")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnClose;

		// Token: 0x0400C3B9 RID: 50105
		[Token(Token = "0x400C3B9")]
		[FieldOffset(Offset = "0x30")]
		public UILabel EmptyTips;

		// Token: 0x0400C3BA RID: 50106
		[Token(Token = "0x400C3BA")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ScrollViewTop;

		// Token: 0x0400C3BB RID: 50107
		[Token(Token = "0x400C3BB")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ScrollViewBottom;

		// Token: 0x0400C3BC RID: 50108
		[Token(Token = "0x400C3BC")]
		[FieldOffset(Offset = "0x48")]
		public UIPanel ScrollPanel;

		// Token: 0x0400C3BD RID: 50109
		[Token(Token = "0x400C3BD")]
		[FieldOffset(Offset = "0x50")]
		public UIEasyList EasyList;

		// Token: 0x0400C3BE RID: 50110
		[Token(Token = "0x400C3BE")]
		[FieldOffset(Offset = "0x58")]
		public UILabel ChampionLabel;

		// Token: 0x0400C3BF RID: 50111
		[Token(Token = "0x400C3BF")]
		[FieldOffset(Offset = "0x60")]
		public UIGrid Grid;

		// Token: 0x0400C3C0 RID: 50112
		[Token(Token = "0x400C3C0")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ChampionshipDefaultIcon;

		// Token: 0x0400C3C1 RID: 50113
		[Token(Token = "0x400C3C1")]
		[FieldOffset(Offset = "0x70")]
		public UINetworkTexture ChampionshipTexture;
	}
}
