using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001363 RID: 4963
	[Token(Token = "0x2001363")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB3A8", Offset = "0x10EB3A8")]
	public class UIFFWSPeakDayWndController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06004F43 RID: 20291 RVA: 0x00018258 File Offset: 0x00016458
		[Token(Token = "0x6004F43")]
		[Address(RVA = "0x2283860", Offset = "0x2283860", VA = "0x7BBCA83860")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F44")]
		[Address(RVA = "0x22838B0", Offset = "0x22838B0", VA = "0x7BBCA838B0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004F45 RID: 20293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F45")]
		[Address(RVA = "0x22841D8", Offset = "0x22841D8", VA = "0x7BBCA841D8", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06004F46 RID: 20294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F46")]
		[Address(RVA = "0x22841E0", Offset = "0x22841E0", VA = "0x7BBCA841E0", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F47")]
		[Address(RVA = "0x2284220", Offset = "0x2284220", VA = "0x7BBCA84220")]
		private void CloseAllItem()
		{
		}

		// Token: 0x06004F48 RID: 20296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F48")]
		[Address(RVA = "0x2283AC0", Offset = "0x2283AC0", VA = "0x7BBCA83AC0")]
		private void SetViewData()
		{
		}

		// Token: 0x06004F49 RID: 20297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F49")]
		[Address(RVA = "0x228436C", Offset = "0x228436C", VA = "0x7BBCA8436C")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x06004F4A RID: 20298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F4A")]
		[Address(RVA = "0x2284374", Offset = "0x2284374", VA = "0x7BBCA84374")]
		private void OnBtnClaimClick()
		{
		}

		// Token: 0x06004F4B RID: 20299 RVA: 0x00018270 File Offset: 0x00016470
		[Token(Token = "0x6004F4B")]
		[Address(RVA = "0x2284450", Offset = "0x2284450", VA = "0x7BBCA84450", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06004F4C RID: 20300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F4C")]
		[Address(RVA = "0x2284494", Offset = "0x2284494", VA = "0x7BBCA84494", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06004F4D RID: 20301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F4D")]
		[Address(RVA = "0x2284520", Offset = "0x2284520", VA = "0x7BBCA84520")]
		public UIFFWSPeakDayWndController()
		{
		}

		// Token: 0x0400761E RID: 30238
		[Token(Token = "0x400761E")]
		[FieldOffset(Offset = "0x98")]
		private UIFFWSPeakDayWndView m_View;

		// Token: 0x0400761F RID: 30239
		[Token(Token = "0x400761F")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x04007620 RID: 30240
		[Token(Token = "0x4007620")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x04007621 RID: 30241
		[Token(Token = "0x4007621")]
		[FieldOffset(Offset = "0xB0")]
		private ClientActivityDesc m_Desc;

		// Token: 0x04007622 RID: 30242
		[Token(Token = "0x4007622")]
		[FieldOffset(Offset = "0xB8")]
		private List<UIStandardItemMiniController> itemList;
	}
}
