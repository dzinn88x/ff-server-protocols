using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021F4 RID: 8692
	[Token(Token = "0x20021F4")]
	public class UIForgeItemView : UIBaseView
	{
		// Token: 0x0600BEF9 RID: 48889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEF9")]
		[Address(RVA = "0x1DBE7B4", Offset = "0x1DBE7B4", VA = "0x7BBC5BE7B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEFA RID: 48890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEFA")]
		[Address(RVA = "0x1DBEC08", Offset = "0x1DBEC08", VA = "0x7BBC5BEC08")]
		public UIForgeItemView()
		{
		}

		// Token: 0x0400CD4F RID: 52559
		[Token(Token = "0x400CD4F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIForgeItem;

		// Token: 0x0400CD50 RID: 52560
		[Token(Token = "0x400CD50")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Default;

		// Token: 0x0400CD51 RID: 52561
		[Token(Token = "0x400CD51")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget LocalImg;

		// Token: 0x0400CD52 RID: 52562
		[Token(Token = "0x400CD52")]
		[FieldOffset(Offset = "0x38")]
		public UINetworkTexture NetworkTexture;

		// Token: 0x0400CD53 RID: 52563
		[Token(Token = "0x400CD53")]
		[FieldOffset(Offset = "0x40")]
		public GameObject HighLightBG;

		// Token: 0x0400CD54 RID: 52564
		[Token(Token = "0x400CD54")]
		[FieldOffset(Offset = "0x48")]
		public SetRelativeDepth ItemVFX;

		// Token: 0x0400CD55 RID: 52565
		[Token(Token = "0x400CD55")]
		[FieldOffset(Offset = "0x50")]
		public UISprite BG;

		// Token: 0x0400CD56 RID: 52566
		[Token(Token = "0x400CD56")]
		[FieldOffset(Offset = "0x58")]
		public UISprite BigAward;

		// Token: 0x0400CD57 RID: 52567
		[Token(Token = "0x400CD57")]
		[FieldOffset(Offset = "0x60")]
		public UITable PriceContainer;

		// Token: 0x0400CD58 RID: 52568
		[Token(Token = "0x400CD58")]
		[FieldOffset(Offset = "0x68")]
		public UISprite Material1Icon;

		// Token: 0x0400CD59 RID: 52569
		[Token(Token = "0x400CD59")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Material1Cnt;

		// Token: 0x0400CD5A RID: 52570
		[Token(Token = "0x400CD5A")]
		[FieldOffset(Offset = "0x78")]
		public GameObject Add;

		// Token: 0x0400CD5B RID: 52571
		[Token(Token = "0x400CD5B")]
		[FieldOffset(Offset = "0x80")]
		public UISprite Material2Icon;

		// Token: 0x0400CD5C RID: 52572
		[Token(Token = "0x400CD5C")]
		[FieldOffset(Offset = "0x88")]
		public UILabel Material2Cnt;

		// Token: 0x0400CD5D RID: 52573
		[Token(Token = "0x400CD5D")]
		[FieldOffset(Offset = "0x90")]
		public UIWidget PriceBG;

		// Token: 0x0400CD5E RID: 52574
		[Token(Token = "0x400CD5E")]
		[FieldOffset(Offset = "0x98")]
		public GameObject OwnedTitle;
	}
}
