using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022A0 RID: 8864
	[Token(Token = "0x20022A0")]
	public class UIHudControlPointPosMarkView : UIBaseView
	{
		// Token: 0x0600C051 RID: 49233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C051")]
		[Address(RVA = "0x1A967B8", Offset = "0x1A967B8", VA = "0x7BBC2967B8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C052 RID: 49234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C052")]
		[Address(RVA = "0x1A96AA8", Offset = "0x1A96AA8", VA = "0x7BBC296AA8")]
		public UIHudControlPointPosMarkView()
		{
		}

		// Token: 0x0400D4C5 RID: 54469
		[Token(Token = "0x400D4C5")]
		[FieldOffset(Offset = "0x20")]
		public UISprite NormalState;

		// Token: 0x0400D4C6 RID: 54470
		[Token(Token = "0x400D4C6")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ScrambleState;

		// Token: 0x0400D4C7 RID: 54471
		[Token(Token = "0x400D4C7")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ControlPointName;

		// Token: 0x0400D4C8 RID: 54472
		[Token(Token = "0x400D4C8")]
		[FieldOffset(Offset = "0x38")]
		public UILabel PointStatusLabel;

		// Token: 0x0400D4C9 RID: 54473
		[Token(Token = "0x400D4C9")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Timer;

		// Token: 0x0400D4CA RID: 54474
		[Token(Token = "0x400D4CA")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ArrowLeft;

		// Token: 0x0400D4CB RID: 54475
		[Token(Token = "0x400D4CB")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ArrowUp;

		// Token: 0x0400D4CC RID: 54476
		[Token(Token = "0x400D4CC")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ArrowDown;

		// Token: 0x0400D4CD RID: 54477
		[Token(Token = "0x400D4CD")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ArrowRight;

		// Token: 0x0400D4CE RID: 54478
		[Token(Token = "0x400D4CE")]
		[FieldOffset(Offset = "0x68")]
		public UILabel DistanceLabel;

		// Token: 0x0400D4CF RID: 54479
		[Token(Token = "0x400D4CF")]
		[FieldOffset(Offset = "0x70")]
		public UIWidget Container;
	}
}
