using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200148F RID: 5263
	[Token(Token = "0x200148F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED154", Offset = "0x10ED154")]
	internal class UIChampionshipRewardItemController : UIBaseController
	{
		// Token: 0x060058EE RID: 22766 RVA: 0x0001A2F8 File Offset: 0x000184F8
		[Token(Token = "0x60058EE")]
		[Address(RVA = "0x1ECBB60", Offset = "0x1ECBB60", VA = "0x7BBC6CBB60")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060058EF RID: 22767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058EF")]
		[Address(RVA = "0x1ECBBB0", Offset = "0x1ECBBB0", VA = "0x7BBC6CBBB0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060058F0 RID: 22768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F0")]
		[Address(RVA = "0x1ECBC94", Offset = "0x1ECBC94", VA = "0x7BBC6CBC94")]
		public void SetViewData(BaseItemInfo data)
		{
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F1")]
		[Address(RVA = "0x1ECBC9C", Offset = "0x1ECBC9C", VA = "0x7BBC6CBC9C")]
		public void RefreshUI()
		{
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F2")]
		[Address(RVA = "0x1ECBD0C", Offset = "0x1ECBD0C", VA = "0x7BBC6CBD0C")]
		private void OnRewardBtnClick()
		{
		}

		// Token: 0x060058F3 RID: 22771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058F3")]
		[Address(RVA = "0x1ECBDF0", Offset = "0x1ECBDF0", VA = "0x7BBC6CBDF0")]
		public UIChampionshipRewardItemController()
		{
		}

		// Token: 0x04007CA5 RID: 31909
		[Token(Token = "0x4007CA5")]
		[FieldOffset(Offset = "0x58")]
		private UIChampionshipRewardItemView m_View;

		// Token: 0x04007CA6 RID: 31910
		[Token(Token = "0x4007CA6")]
		[FieldOffset(Offset = "0x60")]
		private BaseItemInfo m_Data;
	}
}
