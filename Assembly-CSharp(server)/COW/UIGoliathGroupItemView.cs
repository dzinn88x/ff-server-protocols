using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200223D RID: 8765
	[Token(Token = "0x200223D")]
	public class UIGoliathGroupItemView : UIBaseView
	{
		// Token: 0x0600BF8B RID: 49035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF8B")]
		[Address(RVA = "0x1A71708", Offset = "0x1A71708", VA = "0x7BBC271708", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF8C RID: 49036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF8C")]
		[Address(RVA = "0x1A71D88", Offset = "0x1A71D88", VA = "0x7BBC271D88")]
		public UIGoliathGroupItemView()
		{
		}

		// Token: 0x0400D1A2 RID: 53666
		[Token(Token = "0x400D1A2")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIGoliathGroupItem;

		// Token: 0x0400D1A3 RID: 53667
		[Token(Token = "0x400D1A3")]
		[FieldOffset(Offset = "0x28")]
		public GameObject GroupOpen;

		// Token: 0x0400D1A4 RID: 53668
		[Token(Token = "0x400D1A4")]
		[FieldOffset(Offset = "0x30")]
		public UILabel GroupID;

		// Token: 0x0400D1A5 RID: 53669
		[Token(Token = "0x400D1A5")]
		[FieldOffset(Offset = "0x38")]
		public UILabel GroupState;

		// Token: 0x0400D1A6 RID: 53670
		[Token(Token = "0x400D1A6")]
		[FieldOffset(Offset = "0x40")]
		public UICountDownLabel GroupCountDown;

		// Token: 0x0400D1A7 RID: 53671
		[Token(Token = "0x400D1A7")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnCopyGroupID;

		// Token: 0x0400D1A8 RID: 53672
		[Token(Token = "0x400D1A8")]
		[FieldOffset(Offset = "0x50")]
		public UIWidget CopyGuideRegion;

		// Token: 0x0400D1A9 RID: 53673
		[Token(Token = "0x400D1A9")]
		[FieldOffset(Offset = "0x58")]
		public Transform AFKItemContainer;

		// Token: 0x0400D1AA RID: 53674
		[Token(Token = "0x400D1AA")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnGroupFinished;

		// Token: 0x0400D1AB RID: 53675
		[Token(Token = "0x400D1AB")]
		[FieldOffset(Offset = "0x68")]
		public UILabel AFKRewardBonus;

		// Token: 0x0400D1AC RID: 53676
		[Token(Token = "0x400D1AC")]
		[FieldOffset(Offset = "0x70")]
		public GameObject ActivityNode;

		// Token: 0x0400D1AD RID: 53677
		[Token(Token = "0x400D1AD")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ActivityOpen;

		// Token: 0x0400D1AE RID: 53678
		[Token(Token = "0x400D1AE")]
		[FieldOffset(Offset = "0x80")]
		public UILabel ActivityDesc;

		// Token: 0x0400D1AF RID: 53679
		[Token(Token = "0x400D1AF")]
		[FieldOffset(Offset = "0x88")]
		public Transform ActivityItemContainer;

		// Token: 0x0400D1B0 RID: 53680
		[Token(Token = "0x400D1B0")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnActivityFinished;

		// Token: 0x0400D1B1 RID: 53681
		[Token(Token = "0x400D1B1")]
		[FieldOffset(Offset = "0x98")]
		public GameObject ActivityFinishedFrame;

		// Token: 0x0400D1B2 RID: 53682
		[Token(Token = "0x400D1B2")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject ActivityAwardClaimed;

		// Token: 0x0400D1B3 RID: 53683
		[Token(Token = "0x400D1B3")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject ActivityUnopen;

		// Token: 0x0400D1B4 RID: 53684
		[Token(Token = "0x400D1B4")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton BtnOpenActivity;

		// Token: 0x0400D1B5 RID: 53685
		[Token(Token = "0x400D1B5")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject ActivityCannotOpen;

		// Token: 0x0400D1B6 RID: 53686
		[Token(Token = "0x400D1B6")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject ActivityExpired;

		// Token: 0x0400D1B7 RID: 53687
		[Token(Token = "0x400D1B7")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject GroupUnopen;

		// Token: 0x0400D1B8 RID: 53688
		[Token(Token = "0x400D1B8")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton BtnCreateGroup;

		// Token: 0x0400D1B9 RID: 53689
		[Token(Token = "0x400D1B9")]
		[FieldOffset(Offset = "0xD8")]
		public UIWidget CreateGuideRegion;

		// Token: 0x0400D1BA RID: 53690
		[Token(Token = "0x400D1BA")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject Selected;

		// Token: 0x0400D1BB RID: 53691
		[Token(Token = "0x400D1BB")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject Unselected;

		// Token: 0x0400D1BC RID: 53692
		[Token(Token = "0x400D1BC")]
		[FieldOffset(Offset = "0xF0")]
		public UIButton BtnSelfGroup;
	}
}
