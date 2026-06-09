using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002513 RID: 9491
	[Token(Token = "0x2002513")]
	public class UISPHudInfoListView : UIBaseView
	{
		// Token: 0x0600C536 RID: 50486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C536")]
		[Address(RVA = "0x1EE7F70", Offset = "0x1EE7F70", VA = "0x7BBC6E7F70", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C537 RID: 50487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C537")]
		[Address(RVA = "0x1EE83BC", Offset = "0x1EE83BC", VA = "0x7BBC6E83BC")]
		public UISPHudInfoListView()
		{
		}

		// Token: 0x0400F240 RID: 62016
		[Token(Token = "0x400F240")]
		[FieldOffset(Offset = "0x20")]
		public UIButton RightClose;

		// Token: 0x0400F241 RID: 62017
		[Token(Token = "0x400F241")]
		[FieldOffset(Offset = "0x28")]
		public TweenPosition Pivot;

		// Token: 0x0400F242 RID: 62018
		[Token(Token = "0x400F242")]
		[FieldOffset(Offset = "0x30")]
		public GameObject InfoPanel;

		// Token: 0x0400F243 RID: 62019
		[Token(Token = "0x400F243")]
		[FieldOffset(Offset = "0x38")]
		public GameObject playerTab;

		// Token: 0x0400F244 RID: 62020
		[Token(Token = "0x400F244")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleButton PlayerToggleBtn;

		// Token: 0x0400F245 RID: 62021
		[Token(Token = "0x400F245")]
		[FieldOffset(Offset = "0x48")]
		public GameObject airdropTab;

		// Token: 0x0400F246 RID: 62022
		[Token(Token = "0x400F246")]
		[FieldOffset(Offset = "0x50")]
		public UIToggleButton AirdropToggleBtn;

		// Token: 0x0400F247 RID: 62023
		[Token(Token = "0x400F247")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Airdrop;

		// Token: 0x0400F248 RID: 62024
		[Token(Token = "0x400F248")]
		[FieldOffset(Offset = "0x60")]
		public UIScrollView AirdropList;

		// Token: 0x0400F249 RID: 62025
		[Token(Token = "0x400F249")]
		[FieldOffset(Offset = "0x68")]
		public UIGrid AirdropGrid;

		// Token: 0x0400F24A RID: 62026
		[Token(Token = "0x400F24A")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Player;

		// Token: 0x0400F24B RID: 62027
		[Token(Token = "0x400F24B")]
		[FieldOffset(Offset = "0x78")]
		public UIScrollView PlayerList;

		// Token: 0x0400F24C RID: 62028
		[Token(Token = "0x400F24C")]
		[FieldOffset(Offset = "0x80")]
		public UIEasyList PlayerGrid;

		// Token: 0x0400F24D RID: 62029
		[Token(Token = "0x400F24D")]
		[FieldOffset(Offset = "0x88")]
		public GameObject PCBG;

		// Token: 0x0400F24E RID: 62030
		[Token(Token = "0x400F24E")]
		[FieldOffset(Offset = "0x90")]
		public GameObject MobileBG;

		// Token: 0x0400F24F RID: 62031
		[Token(Token = "0x400F24F")]
		[FieldOffset(Offset = "0x98")]
		public GameObject GlassBG;
	}
}
