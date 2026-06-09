using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001507 RID: 5383
	[Token(Token = "0x2001507")]
	public class UIEPWeeklyRewardItemController : MonoBehaviour
	{
		// Token: 0x06005C61 RID: 23649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C61")]
		[Address(RVA = "0x1AD1E08", Offset = "0x1AD1E08", VA = "0x7BBC2D1E08")]
		private void Start()
		{
		}

		// Token: 0x06005C62 RID: 23650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C62")]
		[Address(RVA = "0x1AD1EBC", Offset = "0x1AD1EBC", VA = "0x7BBC2D1EBC")]
		public void SetData(EPWeeklyRewardInfo data)
		{
		}

		// Token: 0x06005C63 RID: 23651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C63")]
		[Address(RVA = "0x1AD1F60", Offset = "0x1AD1F60", VA = "0x7BBC2D1F60")]
		private void SetView()
		{
		}

		// Token: 0x06005C64 RID: 23652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C64")]
		[Address(RVA = "0x1AD28FC", Offset = "0x1AD28FC", VA = "0x7BBC2D28FC")]
		private void OnOperate()
		{
		}

		// Token: 0x06005C65 RID: 23653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C65")]
		[Address(RVA = "0x1AD2AC4", Offset = "0x1AD2AC4", VA = "0x7BBC2D2AC4")]
		public UIEPWeeklyRewardItemController()
		{
		}

		// Token: 0x04007E90 RID: 32400
		[Token(Token = "0x4007E90")]
		[FieldOffset(Offset = "0x18")]
		public GameObject CanOpenEffect;

		// Token: 0x04007E91 RID: 32401
		[Token(Token = "0x4007E91")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Icon;

		// Token: 0x04007E92 RID: 32402
		[Token(Token = "0x4007E92")]
		[FieldOffset(Offset = "0x28")]
		public UIButton OperateButton;

		// Token: 0x04007E93 RID: 32403
		[Token(Token = "0x4007E93")]
		[FieldOffset(Offset = "0x30")]
		public UILabel NeedCnt;

		// Token: 0x04007E94 RID: 32404
		[Token(Token = "0x4007E94")]
		[FieldOffset(Offset = "0x38")]
		public UISprite TipsIcon;

		// Token: 0x04007E95 RID: 32405
		[Token(Token = "0x4007E95")]
		[FieldOffset(Offset = "0x40")]
		public GameObject OnGoingIcon;

		// Token: 0x04007E96 RID: 32406
		[Token(Token = "0x4007E96")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ClaimIcon;

		// Token: 0x04007E97 RID: 32407
		[Token(Token = "0x4007E97")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ReachIcon;

		// Token: 0x04007E98 RID: 32408
		[Token(Token = "0x4007E98")]
		[FieldOffset(Offset = "0x58")]
		private UIModelElitePass m_ModelEp;

		// Token: 0x04007E99 RID: 32409
		[Token(Token = "0x4007E99")]
		[FieldOffset(Offset = "0x60")]
		private EPWeeklyRewardInfo m_Data;

		// Token: 0x04007E9A RID: 32410
		[Token(Token = "0x4007E9A")]
		[FieldOffset(Offset = "0x68")]
		private string RewardDesc;

		// Token: 0x04007E9B RID: 32411
		[Token(Token = "0x4007E9B")]
		[FieldOffset(Offset = "0x70")]
		private UIEPWeeklyRewardItemController.EOperateStatus m_OperateStatus;

		// Token: 0x02001508 RID: 5384
		[Token(Token = "0x2001508")]
		private enum EOperateStatus
		{
			// Token: 0x04007E9D RID: 32413
			[Token(Token = "0x4007E9D")]
			None,
			// Token: 0x04007E9E RID: 32414
			[Token(Token = "0x4007E9E")]
			UnFinished,
			// Token: 0x04007E9F RID: 32415
			[Token(Token = "0x4007E9F")]
			CanReceive,
			// Token: 0x04007EA0 RID: 32416
			[Token(Token = "0x4007EA0")]
			Received
		}
	}
}
