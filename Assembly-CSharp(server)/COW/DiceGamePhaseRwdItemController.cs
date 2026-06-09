using System;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200138B RID: 5003
	[Token(Token = "0x200138B")]
	public class DiceGamePhaseRwdItemController : MonoBehaviour
	{
		// Token: 0x060050A8 RID: 20648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A8")]
		[Address(RVA = "0x1605FC8", Offset = "0x1605FC8", VA = "0x7BBBE05FC8")]
		private void Start()
		{
		}

		// Token: 0x060050A9 RID: 20649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050A9")]
		[Address(RVA = "0x160607C", Offset = "0x160607C", VA = "0x7BBBE0607C")]
		public void UpdateState(EDiceGamePhaseRwdState s)
		{
		}

		// Token: 0x060050AA RID: 20650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AA")]
		[Address(RVA = "0x16061B8", Offset = "0x16061B8", VA = "0x7BBBE061B8")]
		public void InitItem(MVPProcessRewardDesc reward)
		{
		}

		// Token: 0x060050AB RID: 20651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AB")]
		[Address(RVA = "0x1606964", Offset = "0x1606964", VA = "0x7BBBE06964")]
		private void OnOperate()
		{
		}

		// Token: 0x060050AC RID: 20652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050AC")]
		[Address(RVA = "0x1606B10", Offset = "0x1606B10", VA = "0x7BBBE06B10")]
		public DiceGamePhaseRwdItemController()
		{
		}

		// Token: 0x0400771E RID: 30494
		[Token(Token = "0x400771E")]
		[FieldOffset(Offset = "0x18")]
		public UIButton OperateButton;

		// Token: 0x0400771F RID: 30495
		[Token(Token = "0x400771F")]
		[FieldOffset(Offset = "0x20")]
		public GameObject NormalView;

		// Token: 0x04007720 RID: 30496
		[Token(Token = "0x4007720")]
		[FieldOffset(Offset = "0x28")]
		public GameObject CanClaimView;

		// Token: 0x04007721 RID: 30497
		[Token(Token = "0x4007721")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Claimed;

		// Token: 0x04007722 RID: 30498
		[Token(Token = "0x4007722")]
		[FieldOffset(Offset = "0x38")]
		private bool m_HasInitItemId;

		// Token: 0x04007723 RID: 30499
		[Token(Token = "0x4007723")]
		[FieldOffset(Offset = "0x3C")]
		public uint ProcessId;

		// Token: 0x04007724 RID: 30500
		[Token(Token = "0x4007724")]
		[FieldOffset(Offset = "0x40")]
		public uint ReachNeedCnt;

		// Token: 0x04007725 RID: 30501
		[Token(Token = "0x4007725")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ReachNeedLabel;

		// Token: 0x04007726 RID: 30502
		[Token(Token = "0x4007726")]
		[FieldOffset(Offset = "0x50")]
		private EDiceGamePhaseRwdState state;

		// Token: 0x04007727 RID: 30503
		[Token(Token = "0x4007727")]
		[FieldOffset(Offset = "0x58")]
		private UIModelMVP m_ModelMVP;

		// Token: 0x04007728 RID: 30504
		[Token(Token = "0x4007728")]
		[FieldOffset(Offset = "0x60")]
		private string RewardDesc;
	}
}
