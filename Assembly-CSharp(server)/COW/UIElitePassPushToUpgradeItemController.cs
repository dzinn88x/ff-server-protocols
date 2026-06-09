using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200179E RID: 6046
	[Token(Token = "0x200179E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F26CC", Offset = "0x10F26CC")]
	public class UIElitePassPushToUpgradeItemController : UIEasyListItemController
	{
		// Token: 0x0600735F RID: 29535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600735F")]
		[Address(RVA = "0x1E69CC8", Offset = "0x1E69CC8", VA = "0x7BBC669CC8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007360 RID: 29536 RVA: 0x000200D0 File Offset: 0x0001E2D0
		[Token(Token = "0x6007360")]
		[Address(RVA = "0x1E69F58", Offset = "0x1E69F58", VA = "0x7BBC669F58")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007361 RID: 29537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007361")]
		[Address(RVA = "0x1E69FA8", Offset = "0x1E69FA8", VA = "0x7BBC669FA8", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06007362 RID: 29538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007362")]
		[Address(RVA = "0x1E6A338", Offset = "0x1E6A338", VA = "0x7BBC66A338")]
		public UIElitePassPushToUpgradeItemController()
		{
		}

		// Token: 0x04008BDF RID: 35807
		[Token(Token = "0x4008BDF")]
		[FieldOffset(Offset = "0x70")]
		private UICommonRewardItemView m_View;

		// Token: 0x04008BE0 RID: 35808
		[Token(Token = "0x4008BE0")]
		[FieldOffset(Offset = "0x78")]
		public CommonRewardItemInfo m_Info;

		// Token: 0x04008BE1 RID: 35809
		[Token(Token = "0x4008BE1")]
		[FieldOffset(Offset = "0x80")]
		private UIStandardItemMAXBController m_childController;
	}
}
