using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014EF RID: 5359
	[Token(Token = "0x20014EF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDCC4", Offset = "0x10EDCC4")]
	public class UIEPDailyRewardItemController : UIBaseController
	{
		// Token: 0x06005BBF RID: 23487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BBF")]
		[Address(RVA = "0x220E1B0", Offset = "0x220E1B0", VA = "0x7BBCA0E1B0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005BC0 RID: 23488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC0")]
		[Address(RVA = "0x220E270", Offset = "0x220E270", VA = "0x7BBCA0E270")]
		public void InitData(EPDailyRewardInfo data)
		{
		}

		// Token: 0x06005BC1 RID: 23489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC1")]
		[Address(RVA = "0x220E47C", Offset = "0x220E47C", VA = "0x7BBCA0E47C")]
		private void SetButtonState()
		{
		}

		// Token: 0x06005BC2 RID: 23490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC2")]
		[Address(RVA = "0x220E6C0", Offset = "0x220E6C0", VA = "0x7BBCA0E6C0")]
		private void OnOperateBtn()
		{
		}

		// Token: 0x06005BC3 RID: 23491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC3")]
		[Address(RVA = "0x220E8C8", Offset = "0x220E8C8", VA = "0x7BBCA0E8C8")]
		public UIEPDailyRewardItemController()
		{
		}

		// Token: 0x04007E24 RID: 32292
		[Token(Token = "0x4007E24")]
		[FieldOffset(Offset = "0x58")]
		public GameObject LockGO;

		// Token: 0x04007E25 RID: 32293
		[Token(Token = "0x4007E25")]
		[FieldOffset(Offset = "0x60")]
		public GameObject UnLockGO;

		// Token: 0x04007E26 RID: 32294
		[Token(Token = "0x4007E26")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ClaimedGO;

		// Token: 0x04007E27 RID: 32295
		[Token(Token = "0x4007E27")]
		[FieldOffset(Offset = "0x70")]
		public GameObject CanCliamEffect;

		// Token: 0x04007E28 RID: 32296
		[Token(Token = "0x4007E28")]
		[FieldOffset(Offset = "0x78")]
		public GameObject TipGO;

		// Token: 0x04007E29 RID: 32297
		[Token(Token = "0x4007E29")]
		[FieldOffset(Offset = "0x80")]
		public UILabel AwardCntLabel;

		// Token: 0x04007E2A RID: 32298
		[Token(Token = "0x4007E2A")]
		[FieldOffset(Offset = "0x88")]
		public UIButton OperBtn;

		// Token: 0x04007E2B RID: 32299
		[Token(Token = "0x4007E2B")]
		[FieldOffset(Offset = "0x90")]
		private UIStandardItemMAXBController m_Ctrl;

		// Token: 0x04007E2C RID: 32300
		[Token(Token = "0x4007E2C")]
		[FieldOffset(Offset = "0x98")]
		private EPDailyRewardInfo m_Data;

		// Token: 0x020014F0 RID: 5360
		[Token(Token = "0x20014F0")]
		private enum ERewardStatus
		{
			// Token: 0x04007E2E RID: 32302
			[Token(Token = "0x4007E2E")]
			UnFinish,
			// Token: 0x04007E2F RID: 32303
			[Token(Token = "0x4007E2F")]
			Available,
			// Token: 0x04007E30 RID: 32304
			[Token(Token = "0x4007E30")]
			Received
		}
	}
}
