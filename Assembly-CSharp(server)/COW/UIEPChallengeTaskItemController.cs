using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020014EE RID: 5358
	[Token(Token = "0x20014EE")]
	public class UIEPChallengeTaskItemController : UIEasyListItemController
	{
		// Token: 0x06005BB6 RID: 23478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB6")]
		[Address(RVA = "0x220CB54", Offset = "0x220CB54", VA = "0x7BBCA0CB54", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005BB7 RID: 23479 RVA: 0x0001AC58 File Offset: 0x00018E58
		[Token(Token = "0x6005BB7")]
		[Address(RVA = "0x220CC38", Offset = "0x220CC38", VA = "0x7BBCA0CC38")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005BB8 RID: 23480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB8")]
		[Address(RVA = "0x220CC88", Offset = "0x220CC88", VA = "0x7BBCA0CC88", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005BB9 RID: 23481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB9")]
		[Address(RVA = "0x220CD70", Offset = "0x220CD70", VA = "0x7BBCA0CD70")]
		private void SetDesc()
		{
		}

		// Token: 0x06005BBA RID: 23482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBA")]
		[Address(RVA = "0x220D528", Offset = "0x220D528", VA = "0x7BBCA0D528")]
		private void _SetDesc()
		{
		}

		// Token: 0x06005BBB RID: 23483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBB")]
		[Address(RVA = "0x220D1BC", Offset = "0x220D1BC", VA = "0x7BBCA0D1BC")]
		private void SetReward()
		{
		}

		// Token: 0x06005BBC RID: 23484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBC")]
		[Address(RVA = "0x220CEE0", Offset = "0x220CEE0", VA = "0x7BBCA0CEE0")]
		private void SetButtonState()
		{
		}

		// Token: 0x06005BBD RID: 23485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBD")]
		[Address(RVA = "0x220DC80", Offset = "0x220DC80", VA = "0x7BBCA0DC80")]
		private void OnBtnClick()
		{
		}

		// Token: 0x06005BBE RID: 23486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBE")]
		[Address(RVA = "0x220DDB4", Offset = "0x220DDB4", VA = "0x7BBCA0DDB4")]
		public UIEPChallengeTaskItemController()
		{
		}

		// Token: 0x04007E20 RID: 32288
		[Token(Token = "0x4007E20")]
		[FieldOffset(Offset = "0x70")]
		private UIEPChallengeTaskItemView m_View;

		// Token: 0x04007E21 RID: 32289
		[Token(Token = "0x4007E21")]
		[FieldOffset(Offset = "0x78")]
		private EPMonthlyQuestInfo m_Info;

		// Token: 0x04007E22 RID: 32290
		[Token(Token = "0x4007E22")]
		[FieldOffset(Offset = "0x80")]
		private EPTarget_Status m_State;

		// Token: 0x04007E23 RID: 32291
		[Token(Token = "0x4007E23")]
		[FieldOffset(Offset = "0x88")]
		private List<UIStandardItemMiniController> m_CacheRewardList;
	}
}
