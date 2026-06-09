using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200167A RID: 5754
	[Token(Token = "0x200167A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F02F4", Offset = "0x10F02F4")]
	public class UIHudChangeClothButtonController : UIBaseController
	{
		// Token: 0x06006870 RID: 26736 RVA: 0x0001D9D0 File Offset: 0x0001BBD0
		[Token(Token = "0x6006870")]
		[Address(RVA = "0x19D1A8C", Offset = "0x19D1A8C", VA = "0x7BBC1D1A8C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006871 RID: 26737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006871")]
		[Address(RVA = "0x19D1ADC", Offset = "0x19D1ADC", VA = "0x7BBC1D1ADC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006872 RID: 26738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006872")]
		[Address(RVA = "0x19D1D88", Offset = "0x19D1D88", VA = "0x7BBC1D1D88")]
		private void OnChangeClothClick()
		{
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006873")]
		[Address(RVA = "0x19D21E0", Offset = "0x19D21E0", VA = "0x7BBC1D21E0")]
		private void AutoChangeCloth()
		{
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006874")]
		[Address(RVA = "0x19D21E4", Offset = "0x19D21E4", VA = "0x7BBC1D21E4")]
		public UIHudChangeClothButtonController()
		{
		}

		// Token: 0x04008540 RID: 34112
		[Token(Token = "0x4008540")]
		[FieldOffset(Offset = "0x58")]
		private UIHudChangeClothButtonView m_View;

		// Token: 0x04008541 RID: 34113
		[Token(Token = "0x4008541")]
		[FieldOffset(Offset = "0x60")]
		private UIHudChangeClothListController ctrl;

		// Token: 0x04008542 RID: 34114
		[Token(Token = "0x4008542")]
		[FieldOffset(Offset = "0x68")]
		private List<InventoryClothInfo> allClothsId;
	}
}
