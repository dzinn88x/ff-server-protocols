using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024FC RID: 9468
	[Token(Token = "0x20024FC")]
	internal class UISPHudAirdropItemView : UIBaseView
	{
		// Token: 0x0600C50A RID: 50442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C50A")]
		[Address(RVA = "0x1A277A0", Offset = "0x1A277A0", VA = "0x7BBC2277A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C50B RID: 50443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C50B")]
		[Address(RVA = "0x1A27A1C", Offset = "0x1A27A1C", VA = "0x7BBC227A1C")]
		public UISPHudAirdropItemView()
		{
		}

		// Token: 0x0400F14F RID: 61775
		[Token(Token = "0x400F14F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton AirpDropBtn;

		// Token: 0x0400F150 RID: 61776
		[Token(Token = "0x400F150")]
		[FieldOffset(Offset = "0x28")]
		public UILabel NumLabel;

		// Token: 0x0400F151 RID: 61777
		[Token(Token = "0x400F151")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Item1;

		// Token: 0x0400F152 RID: 61778
		[Token(Token = "0x400F152")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Item2;

		// Token: 0x0400F153 RID: 61779
		[Token(Token = "0x400F153")]
		[FieldOffset(Offset = "0x40")]
		public UISprite Item3;

		// Token: 0x0400F154 RID: 61780
		[Token(Token = "0x400F154")]
		[FieldOffset(Offset = "0x48")]
		public UISprite Item4;

		// Token: 0x0400F155 RID: 61781
		[Token(Token = "0x400F155")]
		[FieldOffset(Offset = "0x50")]
		public UISprite Item5;

		// Token: 0x0400F156 RID: 61782
		[Token(Token = "0x400F156")]
		[FieldOffset(Offset = "0x58")]
		public GameObject EmptyLabel;

		// Token: 0x0400F157 RID: 61783
		[Token(Token = "0x400F157")]
		[FieldOffset(Offset = "0x60")]
		public UISprite SelectedBG;
	}
}
