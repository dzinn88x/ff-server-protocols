using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021AA RID: 8618
	[Token(Token = "0x20021AA")]
	public class UIDispatchTaskItemView : UIBaseView
	{
		// Token: 0x0600BE64 RID: 48740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE64")]
		[Address(RVA = "0x22068C0", Offset = "0x22068C0", VA = "0x7BBCA068C0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE65 RID: 48741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE65")]
		[Address(RVA = "0x2206BA8", Offset = "0x2206BA8", VA = "0x7BBCA06BA8")]
		public UIDispatchTaskItemView()
		{
		}

		// Token: 0x0400C97C RID: 51580
		[Token(Token = "0x400C97C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject DispatchTaskItemContainer;

		// Token: 0x0400C97D RID: 51581
		[Token(Token = "0x400C97D")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TaskTitle;

		// Token: 0x0400C97E RID: 51582
		[Token(Token = "0x400C97E")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid AwardGrid;

		// Token: 0x0400C97F RID: 51583
		[Token(Token = "0x400C97F")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid AvatarGrid;

		// Token: 0x0400C980 RID: 51584
		[Token(Token = "0x400C980")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Operation;

		// Token: 0x0400C981 RID: 51585
		[Token(Token = "0x400C981")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnDispatch;

		// Token: 0x0400C982 RID: 51586
		[Token(Token = "0x400C982")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnReceive;

		// Token: 0x0400C983 RID: 51587
		[Token(Token = "0x400C983")]
		[FieldOffset(Offset = "0x58")]
		public UILabel LabelProcessing;

		// Token: 0x0400C984 RID: 51588
		[Token(Token = "0x400C984")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ProcessingAnim;

		// Token: 0x0400C985 RID: 51589
		[Token(Token = "0x400C985")]
		[FieldOffset(Offset = "0x68")]
		public GameObject CountDownTimeContainer;
	}
}
