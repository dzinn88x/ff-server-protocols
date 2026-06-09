using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002328 RID: 9000
	[Token(Token = "0x2002328")]
	public class UIHudPickupListItemView : UIBaseView
	{
		// Token: 0x0600C160 RID: 49504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C160")]
		[Address(RVA = "0x1D746CC", Offset = "0x1D746CC", VA = "0x7BBC5746CC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C161 RID: 49505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C161")]
		[Address(RVA = "0x1D74A20", Offset = "0x1D74A20", VA = "0x7BBC574A20")]
		public UIHudPickupListItemView()
		{
		}

		// Token: 0x0400DA26 RID: 55846
		[Token(Token = "0x400DA26")]
		[FieldOffset(Offset = "0x20")]
		public GameObject light_mask;

		// Token: 0x0400DA27 RID: 55847
		[Token(Token = "0x400DA27")]
		[FieldOffset(Offset = "0x28")]
		public UITexture Texture;

		// Token: 0x0400DA28 RID: 55848
		[Token(Token = "0x400DA28")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LabelCount;

		// Token: 0x0400DA29 RID: 55849
		[Token(Token = "0x400DA29")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnItemAction;

		// Token: 0x0400DA2A RID: 55850
		[Token(Token = "0x400DA2A")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ItemName;

		// Token: 0x0400DA2B RID: 55851
		[Token(Token = "0x400DA2B")]
		[FieldOffset(Offset = "0x48")]
		public UISprite SpriteItemIcon;

		// Token: 0x0400DA2C RID: 55852
		[Token(Token = "0x400DA2C")]
		[FieldOffset(Offset = "0x50")]
		public GameObject StateIconGO;

		// Token: 0x0400DA2D RID: 55853
		[Token(Token = "0x400DA2D")]
		[FieldOffset(Offset = "0x58")]
		public UISprite StateIcon;

		// Token: 0x0400DA2E RID: 55854
		[Token(Token = "0x400DA2E")]
		[FieldOffset(Offset = "0x60")]
		public UISprite EquipmentDurabilityLostRateMask;

		// Token: 0x0400DA2F RID: 55855
		[Token(Token = "0x400DA2F")]
		[FieldOffset(Offset = "0x68")]
		public GameObject AutoPickupMask;

		// Token: 0x0400DA30 RID: 55856
		[Token(Token = "0x400DA30")]
		[FieldOffset(Offset = "0x70")]
		public GameObject BountyIcon;

		// Token: 0x0400DA31 RID: 55857
		[Token(Token = "0x400DA31")]
		[FieldOffset(Offset = "0x78")]
		public GameObject BountyOtherIcon;
	}
}
