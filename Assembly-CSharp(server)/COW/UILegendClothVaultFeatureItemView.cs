using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023DB RID: 9179
	[Token(Token = "0x20023DB")]
	public class UILegendClothVaultFeatureItemView : UIBaseView
	{
		// Token: 0x0600C2C6 RID: 49862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2C6")]
		[Address(RVA = "0x1CB1338", Offset = "0x1CB1338", VA = "0x7BBC4B1338", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2C7 RID: 49863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2C7")]
		[Address(RVA = "0x1CB159C", Offset = "0x1CB159C", VA = "0x7BBC4B159C")]
		public UILegendClothVaultFeatureItemView()
		{
		}

		// Token: 0x0400E002 RID: 57346
		[Token(Token = "0x400E002")]
		[FieldOffset(Offset = "0x20")]
		public Transform TrChosen;

		// Token: 0x0400E003 RID: 57347
		[Token(Token = "0x400E003")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnFeature;

		// Token: 0x0400E004 RID: 57348
		[Token(Token = "0x400E004")]
		[FieldOffset(Offset = "0x30")]
		public UISprite SpriteFeatureIcon;

		// Token: 0x0400E005 RID: 57349
		[Token(Token = "0x400E005")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SpriteFeatureIconbg;

		// Token: 0x0400E006 RID: 57350
		[Token(Token = "0x400E006")]
		[FieldOffset(Offset = "0x40")]
		public UISprite SpriteQualityBg;

		// Token: 0x0400E007 RID: 57351
		[Token(Token = "0x400E007")]
		[FieldOffset(Offset = "0x48")]
		public UISprite SpriteQuality;

		// Token: 0x0400E008 RID: 57352
		[Token(Token = "0x400E008")]
		[FieldOffset(Offset = "0x50")]
		public UILabel LabelFeatureTitle;

		// Token: 0x0400E009 RID: 57353
		[Token(Token = "0x400E009")]
		[FieldOffset(Offset = "0x58")]
		public UILabel LabelFeatureTip;
	}
}
