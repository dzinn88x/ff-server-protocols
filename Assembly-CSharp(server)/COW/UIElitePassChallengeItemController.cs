using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001794 RID: 6036
	[Token(Token = "0x2001794")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F254C", Offset = "0x10F254C")]
	internal class UIElitePassChallengeItemController : UIEasyListItemController
	{
		// Token: 0x060072E1 RID: 29409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072E1")]
		[Address(RVA = "0x1AE3BE4", Offset = "0x1AE3BE4", VA = "0x7BBC2E3BE4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060072E2 RID: 29410 RVA: 0x0001FEF0 File Offset: 0x0001E0F0
		[Token(Token = "0x60072E2")]
		[Address(RVA = "0x1AE3E18", Offset = "0x1AE3E18", VA = "0x7BBC2E3E18")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060072E3 RID: 29411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072E3")]
		[Address(RVA = "0x1AE3E68", Offset = "0x1AE3E68", VA = "0x7BBC2E3E68", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060072E4 RID: 29412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072E4")]
		[Address(RVA = "0x1AE568C", Offset = "0x1AE568C", VA = "0x7BBC2E568C")]
		private void OnClaimBtnClick()
		{
		}

		// Token: 0x060072E5 RID: 29413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072E5")]
		[Address(RVA = "0x1AE599C", Offset = "0x1AE599C", VA = "0x7BBC2E599C")]
		private void OnTeamWorkBtnClick()
		{
		}

		// Token: 0x060072E6 RID: 29414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072E6")]
		[Address(RVA = "0x1AE5B24", Offset = "0x1AE5B24", VA = "0x7BBC2E5B24")]
		private void OnGoToEPBtnClick()
		{
		}

		// Token: 0x060072E7 RID: 29415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072E7")]
		[Address(RVA = "0x1AE4A2C", Offset = "0x1AE4A2C", VA = "0x7BBC2E4A2C")]
		private void SetButtonState(EPTarget_Status taskState, bool isEPPlayer, bool isLock, bool isEPOnlyTask)
		{
		}

		// Token: 0x060072E8 RID: 29416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072E8")]
		[Address(RVA = "0x1AE512C", Offset = "0x1AE512C", VA = "0x7BBC2E512C")]
		private void SetReward(BaseItemInfo[] lst)
		{
		}

		// Token: 0x060072E9 RID: 29417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072E9")]
		[Address(RVA = "0x1AE557C", Offset = "0x1AE557C", VA = "0x7BBC2E557C")]
		private void SetBgType(int type)
		{
		}

		// Token: 0x060072EA RID: 29418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072EA")]
		[Address(RVA = "0x1AE5920", Offset = "0x1AE5920", VA = "0x7BBC2E5920")]
		private void GotoEPUpgrade()
		{
		}

		// Token: 0x060072EB RID: 29419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072EB")]
		[Address(RVA = "0x1AE3724", Offset = "0x1AE3724", VA = "0x7BBC2E3724")]
		public void SetItemWidth(int width)
		{
		}

		// Token: 0x060072EC RID: 29420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072EC")]
		[Address(RVA = "0x1AE5B34", Offset = "0x1AE5B34", VA = "0x7BBC2E5B34")]
		public UIElitePassChallengeItemController()
		{
		}

		// Token: 0x04008BB0 RID: 35760
		[Token(Token = "0x4008BB0")]
		[FieldOffset(Offset = "0x70")]
		private UIElitePassChallengeItemView m_View;

		// Token: 0x04008BB1 RID: 35761
		[Token(Token = "0x4008BB1")]
		[FieldOffset(Offset = "0x78")]
		private UIModelElitePass m_EPModel;

		// Token: 0x04008BB2 RID: 35762
		[Token(Token = "0x4008BB2")]
		[FieldOffset(Offset = "0x80")]
		private EPChallengeInfo m_ChallengeInfo;

		// Token: 0x04008BB3 RID: 35763
		[Token(Token = "0x4008BB3")]
		[FieldOffset(Offset = "0x88")]
		private UIElitePassChallengeItemController.EPBtnState m_BtnState;

		// Token: 0x04008BB4 RID: 35764
		[Token(Token = "0x4008BB4")]
		[FieldOffset(Offset = "0x90")]
		private List<UIStandardItemMiniController> m_Rewards;

		// Token: 0x04008BB5 RID: 35765
		[Token(Token = "0x4008BB5")]
		[FieldOffset(Offset = "0x98")]
		private string PREFIX_TEAM_WORK;

		// Token: 0x02001795 RID: 6037
		[Token(Token = "0x2001795")]
		private enum EPBtnState
		{
			// Token: 0x04008BB7 RID: 35767
			[Token(Token = "0x4008BB7")]
			OnGoing,
			// Token: 0x04008BB8 RID: 35768
			[Token(Token = "0x4008BB8")]
			Lock,
			// Token: 0x04008BB9 RID: 35769
			[Token(Token = "0x4008BB9")]
			Claimed,
			// Token: 0x04008BBA RID: 35770
			[Token(Token = "0x4008BBA")]
			Reached,
			// Token: 0x04008BBB RID: 35771
			[Token(Token = "0x4008BBB")]
			ReachedButIsNotEP
		}
	}
}
