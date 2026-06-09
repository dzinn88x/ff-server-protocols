using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019BA RID: 6586
	[Token(Token = "0x20019BA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6EF4", Offset = "0x10F6EF4")]
	public class UIInventoryClothSetRecommendController : UIBaseController
	{
		// Token: 0x06008731 RID: 34609 RVA: 0x000248D0 File Offset: 0x00022AD0
		[Token(Token = "0x6008731")]
		[Address(RVA = "0x19166AC", Offset = "0x19166AC", VA = "0x7BBC1166AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008732 RID: 34610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008732")]
		[Address(RVA = "0x19166FC", Offset = "0x19166FC", VA = "0x7BBC1166FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008733 RID: 34611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008733")]
		[Address(RVA = "0x1916D1C", Offset = "0x1916D1C", VA = "0x7BBC116D1C", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008734 RID: 34612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008734")]
		[Address(RVA = "0x1916D24", Offset = "0x1916D24", VA = "0x7BBC116D24", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008735 RID: 34613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008735")]
		[Address(RVA = "0x1916D60", Offset = "0x1916D60", VA = "0x7BBC116D60")]
		public void SetData(uint selectClothID)
		{
		}

		// Token: 0x06008736 RID: 34614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008736")]
		[Address(RVA = "0x191769C", Offset = "0x191769C", VA = "0x7BBC11769C")]
		public void AddClickMaskRegion(UIWidget maskRegion)
		{
		}

		// Token: 0x06008737 RID: 34615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008737")]
		[Address(RVA = "0x19176B0", Offset = "0x19176B0", VA = "0x7BBC1176B0")]
		private void OnDrewUpClothSetClick()
		{
		}

		// Token: 0x06008738 RID: 34616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008738")]
		[Address(RVA = "0x19182B4", Offset = "0x19182B4", VA = "0x7BBC1182B4")]
		public UIInventoryClothSetRecommendController()
		{
		}

		// Token: 0x040095E3 RID: 38371
		[Token(Token = "0x40095E3")]
		[FieldOffset(Offset = "0x58")]
		private UIInventoryClothSetRecommendView m_View;

		// Token: 0x040095E4 RID: 38372
		[Token(Token = "0x40095E4")]
		[FieldOffset(Offset = "0x60")]
		private uint m_SelectClothID;

		// Token: 0x040095E5 RID: 38373
		[Token(Token = "0x40095E5")]
		[FieldOffset(Offset = "0x68")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x040095E6 RID: 38374
		[Token(Token = "0x40095E6")]
		[FieldOffset(Offset = "0x70")]
		private UIModelAvatar m_ModelAvatar;

		// Token: 0x040095E7 RID: 38375
		[Token(Token = "0x40095E7")]
		[FieldOffset(Offset = "0x78")]
		private UIClickMask m_ClickMask;

		// Token: 0x040095E8 RID: 38376
		[Token(Token = "0x40095E8")]
		[FieldOffset(Offset = "0x80")]
		private List<UIInventoryClothSetRecommendController.ClothItemDisplay> m_UIClothSet;

		// Token: 0x020019BB RID: 6587
		[Token(Token = "0x20019BB")]
		private class ClothItemDisplay
		{
			// Token: 0x06008739 RID: 34617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008739")]
			[Address(RVA = "0x1916A00", Offset = "0x1916A00", VA = "0x7BBC116A00")]
			public ClothItemDisplay(UIInventoryClothSetRecommendView view, GameObject ui)
			{
			}

			// Token: 0x0600873A RID: 34618 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600873A")]
			[Address(RVA = "0x1916BF4", Offset = "0x1916BF4", VA = "0x7BBC116BF4")]
			public UIInventoryClothSetRecommendController.ClothItemDisplay Clone()
			{
				return null;
			}

			// Token: 0x0600873B RID: 34619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600873B")]
			[Address(RVA = "0x1917664", Offset = "0x1917664", VA = "0x7BBC117664")]
			public void SetActive(bool value)
			{
			}

			// Token: 0x040095E9 RID: 38377
			[Token(Token = "0x40095E9")]
			[FieldOffset(Offset = "0x10")]
			private GameObject ui;

			// Token: 0x040095EA RID: 38378
			[Token(Token = "0x40095EA")]
			[FieldOffset(Offset = "0x18")]
			private UIInventoryClothSetRecommendView view;

			// Token: 0x040095EB RID: 38379
			[Token(Token = "0x40095EB")]
			[FieldOffset(Offset = "0x20")]
			public UISprite icon;

			// Token: 0x040095EC RID: 38380
			[Token(Token = "0x40095EC")]
			[FieldOffset(Offset = "0x28")]
			public GameObject descargar;
		}

		// Token: 0x020019BC RID: 6588
		[Token(Token = "0x20019BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F6F2C", Offset = "0x10F6F2C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600873D RID: 34621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600873D")]
			[Address(RVA = "0x1918388", Offset = "0x1918388", VA = "0x7BBC118388")]
			public <>c()
			{
			}

			// Token: 0x0600873E RID: 34622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600873E")]
			[Address(RVA = "0x1918390", Offset = "0x1918390", VA = "0x7BBC118390")]
			internal void <SetData>b__11_0(UIInventoryClothSetRecommendController.ClothItemDisplay e)
			{
			}

			// Token: 0x040095ED RID: 38381
			[Token(Token = "0x40095ED")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIInventoryClothSetRecommendController.<>c <>9;

			// Token: 0x040095EE RID: 38382
			[Token(Token = "0x40095EE")]
			[FieldOffset(Offset = "0x8")]
			public static Action<UIInventoryClothSetRecommendController.ClothItemDisplay> <>9__11_0;
		}

		// Token: 0x020019BD RID: 6589
		[Token(Token = "0x20019BD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F6F3C", Offset = "0x10F6F3C")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x0600873F RID: 34623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600873F")]
			[Address(RVA = "0x19182AC", Offset = "0x19182AC", VA = "0x7BBC1182AC")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06008740 RID: 34624 RVA: 0x000248E8 File Offset: 0x00022AE8
			[Token(Token = "0x6008740")]
			[Address(RVA = "0x19183C0", Offset = "0x19183C0", VA = "0x7BBC1183C0")]
			internal bool <OnDrewUpClothSetClick>b__0(AvatarWardrobeData e)
			{
				return default(bool);
			}

			// Token: 0x040095EF RID: 38383
			[Token(Token = "0x40095EF")]
			[FieldOffset(Offset = "0x10")]
			public AvatarWardrobeData selectClothData;
		}
	}
}
