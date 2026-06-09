using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019DE RID: 6622
	[Token(Token = "0x20019DE")]
	public class UILegendClothVaultFeatureItemController : UIBaseController
	{
		// Token: 0x060088B3 RID: 34995 RVA: 0x00024C60 File Offset: 0x00022E60
		[Token(Token = "0x60088B3")]
		[Address(RVA = "0x1CB0630", Offset = "0x1CB0630", VA = "0x7BBC4B0630")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060088B4 RID: 34996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088B4")]
		[Address(RVA = "0x1CB0680", Offset = "0x1CB0680", VA = "0x7BBC4B0680", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060088B5 RID: 34997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088B5")]
		[Address(RVA = "0x1CB0828", Offset = "0x1CB0828", VA = "0x7BBC4B0828", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060088B6 RID: 34998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088B6")]
		[Address(RVA = "0x1CB08F4", Offset = "0x1CB08F4", VA = "0x7BBC4B08F4")]
		public void SetData(LegendClothVaultFeature featureType, ResourceID resId, object data)
		{
		}

		// Token: 0x060088B7 RID: 34999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088B7")]
		[Address(RVA = "0x1CB1044", Offset = "0x1CB1044", VA = "0x7BBC4B1044")]
		private void OnBtnFeatureClick()
		{
		}

		// Token: 0x060088B8 RID: 35000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088B8")]
		[Address(RVA = "0x1CB1260", Offset = "0x1CB1260", VA = "0x7BBC4B1260")]
		private void OnFeatureShow(params object[] data)
		{
		}

		// Token: 0x060088B9 RID: 35001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60088B9")]
		[Address(RVA = "0x1CB1330", Offset = "0x1CB1330", VA = "0x7BBC4B1330")]
		public UILegendClothVaultFeatureItemController()
		{
		}

		// Token: 0x0400970C RID: 38668
		[Token(Token = "0x400970C")]
		[FieldOffset(Offset = "0x58")]
		private UILegendClothVaultFeatureItemView m_View;

		// Token: 0x0400970D RID: 38669
		[Token(Token = "0x400970D")]
		[FieldOffset(Offset = "0x60")]
		private LegendClothVaultFeature m_FeatureType;

		// Token: 0x0400970E RID: 38670
		[Token(Token = "0x400970E")]
		[FieldOffset(Offset = "0x68")]
		private object m_Data;
	}
}
