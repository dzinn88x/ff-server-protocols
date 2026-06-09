using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023E9 RID: 9193
	[Token(Token = "0x20023E9")]
	public class UILinkActivityPVEView : UIBaseView
	{
		// Token: 0x0600C2E2 RID: 49890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E2")]
		[Address(RVA = "0x1CC0F84", Offset = "0x1CC0F84", VA = "0x7BBC4C0F84", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2E3 RID: 49891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E3")]
		[Address(RVA = "0x1CC134C", Offset = "0x1CC134C", VA = "0x7BBC4C134C")]
		public UILinkActivityPVEView()
		{
		}

		// Token: 0x0400E0D9 RID: 57561
		[Token(Token = "0x400E0D9")]
		[FieldOffset(Offset = "0x20")]
		public Animator AnimPlayer;

		// Token: 0x0400E0DA RID: 57562
		[Token(Token = "0x400E0DA")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture Role;

		// Token: 0x0400E0DB RID: 57563
		[Token(Token = "0x400E0DB")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnClose;

		// Token: 0x0400E0DC RID: 57564
		[Token(Token = "0x400E0DC")]
		[FieldOffset(Offset = "0x38")]
		public UICountDownLabel CountDownLabel;

		// Token: 0x0400E0DD RID: 57565
		[Token(Token = "0x400E0DD")]
		[FieldOffset(Offset = "0x40")]
		public UIProgressBar LinkActivityPVEProgress;

		// Token: 0x0400E0DE RID: 57566
		[Token(Token = "0x400E0DE")]
		[FieldOffset(Offset = "0x48")]
		public GameObject CollectionItemRoot;

		// Token: 0x0400E0DF RID: 57567
		[Token(Token = "0x400E0DF")]
		[FieldOffset(Offset = "0x50")]
		public GameObject CollectionItemTemplate;

		// Token: 0x0400E0E0 RID: 57568
		[Token(Token = "0x400E0E0")]
		[FieldOffset(Offset = "0x58")]
		public UILabel EPCountLabelOne;

		// Token: 0x0400E0E1 RID: 57569
		[Token(Token = "0x400E0E1")]
		[FieldOffset(Offset = "0x60")]
		public UILabel EPCountLabelTwo;

		// Token: 0x0400E0E2 RID: 57570
		[Token(Token = "0x400E0E2")]
		[FieldOffset(Offset = "0x68")]
		public UILabel EPCountLabelThree;

		// Token: 0x0400E0E3 RID: 57571
		[Token(Token = "0x400E0E3")]
		[FieldOffset(Offset = "0x70")]
		public UILinkActivityPVERankItem Rank1Item;

		// Token: 0x0400E0E4 RID: 57572
		[Token(Token = "0x400E0E4")]
		[FieldOffset(Offset = "0x78")]
		public UILinkActivityPVERankItem Rank2Item;

		// Token: 0x0400E0E5 RID: 57573
		[Token(Token = "0x400E0E5")]
		[FieldOffset(Offset = "0x80")]
		public UILinkActivityPVERankItem Rank3Item;

		// Token: 0x0400E0E6 RID: 57574
		[Token(Token = "0x400E0E6")]
		[FieldOffset(Offset = "0x88")]
		public UILinkActivityPVERankItem MyRankItem;
	}
}
