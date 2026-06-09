using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022FC RID: 8956
	[Token(Token = "0x20022FC")]
	public class UIHudLeaderboardItemView : UIBaseView
	{
		// Token: 0x0600C108 RID: 49416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C108")]
		[Address(RVA = "0x15BA89C", Offset = "0x15BA89C", VA = "0x7BBBDBA89C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C109 RID: 49417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C109")]
		[Address(RVA = "0x15BAB74", Offset = "0x15BAB74", VA = "0x7BBBDBAB74")]
		public UIHudLeaderboardItemView()
		{
		}

		// Token: 0x0400D821 RID: 55329
		[Token(Token = "0x400D821")]
		[FieldOffset(Offset = "0x20")]
		public AutoChangeComp m_AutoChangeComp;

		// Token: 0x0400D822 RID: 55330
		[Token(Token = "0x400D822")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BGDefault;

		// Token: 0x0400D823 RID: 55331
		[Token(Token = "0x400D823")]
		[FieldOffset(Offset = "0x30")]
		public GameObject BGLocal;

		// Token: 0x0400D824 RID: 55332
		[Token(Token = "0x400D824")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelName;

		// Token: 0x0400D825 RID: 55333
		[Token(Token = "0x400D825")]
		[FieldOffset(Offset = "0x40")]
		public UILabel LabelClan;

		// Token: 0x0400D826 RID: 55334
		[Token(Token = "0x400D826")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LabelKill;

		// Token: 0x0400D827 RID: 55335
		[Token(Token = "0x400D827")]
		[FieldOffset(Offset = "0x50")]
		public UILabel LabelDead;

		// Token: 0x0400D828 RID: 55336
		[Token(Token = "0x400D828")]
		[FieldOffset(Offset = "0x58")]
		public UILabel LabelAssist;

		// Token: 0x0400D829 RID: 55337
		[Token(Token = "0x400D829")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LabelTotalDamage;

		// Token: 0x0400D82A RID: 55338
		[Token(Token = "0x400D82A")]
		[FieldOffset(Offset = "0x68")]
		public UISprite RankSprite;

		// Token: 0x0400D82B RID: 55339
		[Token(Token = "0x400D82B")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Icon_Celebrity;
	}
}
