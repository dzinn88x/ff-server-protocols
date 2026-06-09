using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200150D RID: 5389
	[Token(Token = "0x200150D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE03C", Offset = "0x10EE03C")]
	public class UIEPWeeklyTaskDetailItemController : UIEasyListItemController
	{
		// Token: 0x06005C82 RID: 23682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C82")]
		[Address(RVA = "0x1AD4514", Offset = "0x1AD4514", VA = "0x7BBC2D4514", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005C83 RID: 23683 RVA: 0x0001AEF8 File Offset: 0x000190F8
		[Token(Token = "0x6005C83")]
		[Address(RVA = "0x1AD45F8", Offset = "0x1AD45F8", VA = "0x7BBC2D45F8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005C84 RID: 23684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C84")]
		[Address(RVA = "0x1AD4648", Offset = "0x1AD4648", VA = "0x7BBC2D4648", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005C85 RID: 23685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C85")]
		[Address(RVA = "0x1AD4720", Offset = "0x1AD4720", VA = "0x7BBC2D4720")]
		private void SetUI()
		{
		}

		// Token: 0x06005C86 RID: 23686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C86")]
		[Address(RVA = "0x1AD474C", Offset = "0x1AD474C", VA = "0x7BBC2D474C")]
		private void SetDesc()
		{
		}

		// Token: 0x06005C87 RID: 23687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C87")]
		[Address(RVA = "0x1AD4E6C", Offset = "0x1AD4E6C", VA = "0x7BBC2D4E6C")]
		private void _SetDesc()
		{
		}

		// Token: 0x06005C88 RID: 23688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C88")]
		[Address(RVA = "0x1AD4BCC", Offset = "0x1AD4BCC", VA = "0x7BBC2D4BCC")]
		private void SetReward()
		{
		}

		// Token: 0x06005C89 RID: 23689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C89")]
		[Address(RVA = "0x1AD48F0", Offset = "0x1AD48F0", VA = "0x7BBC2D48F0")]
		private void SetButtonState()
		{
		}

		// Token: 0x06005C8A RID: 23690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8A")]
		[Address(RVA = "0x1AD55C4", Offset = "0x1AD55C4", VA = "0x7BBC2D55C4")]
		private void OnOperateBtn()
		{
		}

		// Token: 0x06005C8B RID: 23691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8B")]
		[Address(RVA = "0x1AD572C", Offset = "0x1AD572C", VA = "0x7BBC2D572C")]
		public UIEPWeeklyTaskDetailItemController()
		{
		}

		// Token: 0x04007EAB RID: 32427
		[Token(Token = "0x4007EAB")]
		[FieldOffset(Offset = "0x70")]
		private UIEPWeeklyTaskDetailItemView m_View;

		// Token: 0x04007EAC RID: 32428
		[Token(Token = "0x4007EAC")]
		[FieldOffset(Offset = "0x78")]
		private EPWeeklyQuestInfo m_Info;

		// Token: 0x04007EAD RID: 32429
		[Token(Token = "0x4007EAD")]
		[FieldOffset(Offset = "0x80")]
		private EPTarget_Status m_State;

		// Token: 0x04007EAE RID: 32430
		[Token(Token = "0x4007EAE")]
		[FieldOffset(Offset = "0x88")]
		private List<UIStandardItemMiniController> m_CacheRewardList;
	}
}
