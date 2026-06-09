using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021ED RID: 8685
	[Token(Token = "0x20021ED")]
	public class UIFFWSTaskItemView : UIBaseView
	{
		// Token: 0x0600BEEB RID: 48875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEEB")]
		[Address(RVA = "0x228D8CC", Offset = "0x228D8CC", VA = "0x7BBCA8D8CC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEEC RID: 48876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEEC")]
		[Address(RVA = "0x228DBA4", Offset = "0x228DBA4", VA = "0x7BBCA8DBA4")]
		public UIFFWSTaskItemView()
		{
		}

		// Token: 0x0400CCEA RID: 52458
		[Token(Token = "0x400CCEA")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIFFWSTaskItem;

		// Token: 0x0400CCEB RID: 52459
		[Token(Token = "0x400CCEB")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget TaskItemContainer;

		// Token: 0x0400CCEC RID: 52460
		[Token(Token = "0x400CCEC")]
		[FieldOffset(Offset = "0x30")]
		public UILabel TaskTitle;

		// Token: 0x0400CCED RID: 52461
		[Token(Token = "0x400CCED")]
		[FieldOffset(Offset = "0x38")]
		public UILabel StoryTaskTitle;

		// Token: 0x0400CCEE RID: 52462
		[Token(Token = "0x400CCEE")]
		[FieldOffset(Offset = "0x40")]
		public UILabel TaskProgress;

		// Token: 0x0400CCEF RID: 52463
		[Token(Token = "0x400CCEF")]
		[FieldOffset(Offset = "0x48")]
		public UIButton ClaimBtn;

		// Token: 0x0400CCF0 RID: 52464
		[Token(Token = "0x400CCF0")]
		[FieldOffset(Offset = "0x50")]
		public UIButton CannotClaimBtn;

		// Token: 0x0400CCF1 RID: 52465
		[Token(Token = "0x400CCF1")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ClaimedLabel;

		// Token: 0x0400CCF2 RID: 52466
		[Token(Token = "0x400CCF2")]
		[FieldOffset(Offset = "0x60")]
		public UIGrid Grid;

		// Token: 0x0400CCF3 RID: 52467
		[Token(Token = "0x400CCF3")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Bg;
	}
}
