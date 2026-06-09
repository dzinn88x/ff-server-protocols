using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001B56 RID: 6998
	[Token(Token = "0x2001B56")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9C74", Offset = "0x10F9C74")]
	internal class UIRelationshipRewardItemController : UIBaseController
	{
		// Token: 0x0600966C RID: 38508 RVA: 0x00027C18 File Offset: 0x00025E18
		[Token(Token = "0x600966C")]
		[Address(RVA = "0x1E1F230", Offset = "0x1E1F230", VA = "0x7BBC61F230")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600966D RID: 38509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600966D")]
		[Address(RVA = "0x1E1F280", Offset = "0x1E1F280", VA = "0x7BBC61F280", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600966E RID: 38510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600966E")]
		[Address(RVA = "0x1E1F364", Offset = "0x1E1F364", VA = "0x7BBC61F364")]
		public void SetRewardItemInfo(IntimacyAwardDesc desc, IntimacyRankAwardInfo info, ulong accountID)
		{
		}

		// Token: 0x0600966F RID: 38511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600966F")]
		[Address(RVA = "0x1E1F510", Offset = "0x1E1F510", VA = "0x7BBC61F510")]
		private void RefreshRewardState()
		{
		}

		// Token: 0x06009670 RID: 38512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009670")]
		[Address(RVA = "0x1E1F898", Offset = "0x1E1F898", VA = "0x7BBC61F898")]
		private void ReceeiveRewards()
		{
		}

		// Token: 0x06009671 RID: 38513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009671")]
		[Address(RVA = "0x1E1F390", Offset = "0x1E1F390", VA = "0x7BBC61F390")]
		public void SetLocalPosition()
		{
		}

		// Token: 0x06009672 RID: 38514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009672")]
		[Address(RVA = "0x1E1FA7C", Offset = "0x1E1FA7C", VA = "0x7BBC61FA7C")]
		public UIRelationshipRewardItemController()
		{
		}

		// Token: 0x04009F06 RID: 40710
		[Token(Token = "0x4009F06")]
		[FieldOffset(Offset = "0x58")]
		private IntimacyAwardDesc m_desc;

		// Token: 0x04009F07 RID: 40711
		[Token(Token = "0x4009F07")]
		[FieldOffset(Offset = "0x60")]
		private IntimacyRankAwardInfo m_info;

		// Token: 0x04009F08 RID: 40712
		[Token(Token = "0x4009F08")]
		[FieldOffset(Offset = "0x68")]
		private UIRelationshipRewardItemView m_View;

		// Token: 0x04009F09 RID: 40713
		[Token(Token = "0x4009F09")]
		[FieldOffset(Offset = "0x70")]
		private ulong m_AccountID;

		// Token: 0x04009F0A RID: 40714
		[Token(Token = "0x4009F0A")]
		[FieldOffset(Offset = "0x78")]
		private AwardItemState curState;

		// Token: 0x04009F0B RID: 40715
		[Token(Token = "0x4009F0B")]
		private const uint SpecialRankWithSpecialAwards = 5U;
	}
}
