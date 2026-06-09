using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019DF RID: 6623
	[Token(Token = "0x20019DF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7204", Offset = "0x10F7204")]
	public class UILegendClothVaultSlotItemController : UIPopupWindowController
	{
		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x060088BA RID: 35002 RVA: 0x00024C78 File Offset: 0x00022E78
		// (set) Token: 0x060088BB RID: 35003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009BA")]
		public uint ClothId
		{
			[Token(Token = "0x60088BA")]
			[Address(RVA = "0x1CB15A4", Offset = "0x1CB15A4", VA = "0x7BBC4B15A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11437A4", Offset = "0x11437A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60088BB")]
			[Address(RVA = "0x1CB15AC", Offset = "0x1CB15AC", VA = "0x7BBC4B15AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11437B4", Offset = "0x11437B4")]
			private set
			{
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x060088BC RID: 35004 RVA: 0x00024C90 File Offset: 0x00022E90
		// (set) Token: 0x060088BD RID: 35005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009BB")]
		public int Level
		{
			[Token(Token = "0x60088BC")]
			[Address(RVA = "0x1CB15B4", Offset = "0x1CB15B4", VA = "0x7BBC4B15B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11437C4", Offset = "0x11437C4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60088BD")]
			[Address(RVA = "0x1CB15BC", Offset = "0x1CB15BC", VA = "0x7BBC4B15BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11437D4", Offset = "0x11437D4")]
			private set
			{
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x060088BE RID: 35006 RVA: 0x00024CA8 File Offset: 0x00022EA8
		// (set) Token: 0x060088BF RID: 35007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009BC")]
		public bool IsWearing
		{
			[Token(Token = "0x60088BE")]
			[Address(RVA = "0x1CB15C4", Offset = "0x1CB15C4", VA = "0x7BBC4B15C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11437E4", Offset = "0x11437E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60088BF")]
			[Address(RVA = "0x1CB15CC", Offset = "0x1CB15CC", VA = "0x7BBC4B15CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11437F4", Offset = "0x11437F4")]
			private set
			{
			}
		}

		// Token: 0x060088C0 RID: 35008 RVA: 0x00024CC0 File Offset: 0x00022EC0
		[Token(Token = "0x60088C0")]
		[Address(RVA = "0x1CB15D8", Offset = "0x1CB15D8", VA = "0x7BBC4B15D8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060088C1 RID: 35009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088C1")]
		[Address(RVA = "0x1CB1628", Offset = "0x1CB1628", VA = "0x7BBC4B1628", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060088C2 RID: 35010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088C2")]
		[Address(RVA = "0x1CB1764", Offset = "0x1CB1764", VA = "0x7BBC4B1764", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060088C3 RID: 35011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088C3")]
		[Address(RVA = "0x1CB176C", Offset = "0x1CB176C", VA = "0x7BBC4B176C")]
		public void SetData(UIModelAvatarBase.EWardrobeType wardrobeType, uint clothId, int level = -1)
		{
		}

		// Token: 0x060088C4 RID: 35012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088C4")]
		[Address(RVA = "0x1CB1C84", Offset = "0x1CB1C84", VA = "0x7BBC4B1C84")]
		public void SetPageType(LegendClothVaultPageType pageType)
		{
		}

		// Token: 0x060088C5 RID: 35013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088C5")]
		[Address(RVA = "0x1CB1D44", Offset = "0x1CB1D44", VA = "0x7BBC4B1D44")]
		private void OnClickBtnChoose()
		{
		}

		// Token: 0x060088C6 RID: 35014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088C6")]
		[Address(RVA = "0x1CB1F64", Offset = "0x1CB1F64", VA = "0x7BBC4B1F64")]
		private void OnClickBtnCancel()
		{
		}

		// Token: 0x060088C7 RID: 35015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088C7")]
		[Address(RVA = "0x1CB1778", Offset = "0x1CB1778", VA = "0x7BBC4B1778")]
		public void RefreshView()
		{
		}

		// Token: 0x060088C8 RID: 35016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088C8")]
		[Address(RVA = "0x1CB210C", Offset = "0x1CB210C", VA = "0x7BBC4B210C")]
		public void SetIsGenderValid(bool isGenderValid)
		{
		}

		// Token: 0x060088C9 RID: 35017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088C9")]
		[Address(RVA = "0x1CB1F58", Offset = "0x1CB1F58", VA = "0x7BBC4B1F58")]
		public void SetIsWearing(bool isWearing)
		{
		}

		// Token: 0x060088CA RID: 35018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088CA")]
		[Address(RVA = "0x1CB2118", Offset = "0x1CB2118", VA = "0x7BBC4B2118")]
		public UILegendClothVaultSlotItemController()
		{
		}

		// Token: 0x0400970F RID: 38671
		[Token(Token = "0x400970F")]
		[FieldOffset(Offset = "0x98")]
		private UILegendClothVaultSlotItemView m_View;

		// Token: 0x04009710 RID: 38672
		[Token(Token = "0x4009710")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelAvatarBase.EWardrobeType m_WardrobeType;

		// Token: 0x04009711 RID: 38673
		[Token(Token = "0x4009711")]
		[FieldOffset(Offset = "0xA4")]
		private LegendClothVaultPageType m_PageType;

		// Token: 0x04009712 RID: 38674
		[Token(Token = "0x4009712")]
		[FieldOffset(Offset = "0xA8")]
		private Color m_WearingColor;

		// Token: 0x04009713 RID: 38675
		[Token(Token = "0x4009713")]
		[FieldOffset(Offset = "0xB8")]
		private Color m_NotWearingColor;

		// Token: 0x04009714 RID: 38676
		[Token(Token = "0x4009714")]
		private const uint InvalidClothId = 0U;

		// Token: 0x04009715 RID: 38677
		[Token(Token = "0x4009715")]
		[FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F9BC", Offset = "0x112F9BC")]
		private uint <ClothId>k__BackingField;

		// Token: 0x04009716 RID: 38678
		[Token(Token = "0x4009716")]
		[FieldOffset(Offset = "0xCC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F9CC", Offset = "0x112F9CC")]
		private int <Level>k__BackingField;

		// Token: 0x04009717 RID: 38679
		[Token(Token = "0x4009717")]
		[FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F9DC", Offset = "0x112F9DC")]
		private bool <IsWearing>k__BackingField;

		// Token: 0x04009718 RID: 38680
		[Token(Token = "0x4009718")]
		[FieldOffset(Offset = "0xD1")]
		private bool m_IsGenderValid;
	}
}
