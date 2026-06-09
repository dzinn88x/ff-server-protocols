using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002300 RID: 8960
	[Token(Token = "0x2002300")]
	internal class UIHudLockedTargetView : UIBaseView
	{
		// Token: 0x0600C110 RID: 49424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C110")]
		[Address(RVA = "0x15BBC7C", Offset = "0x15BBC7C", VA = "0x7BBBDBBC7C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C111 RID: 49425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C111")]
		[Address(RVA = "0x15BBE84", Offset = "0x15BBE84", VA = "0x7BBBDBBE84")]
		public UIHudLockedTargetView()
		{
		}

		// Token: 0x0400D83E RID: 55358
		[Token(Token = "0x400D83E")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400D83F RID: 55359
		[Token(Token = "0x400D83F")]
		[FieldOffset(Offset = "0x28")]
		public GameObject icon;

		// Token: 0x0400D840 RID: 55360
		[Token(Token = "0x400D840")]
		[FieldOffset(Offset = "0x30")]
		public UILabel DistanceLabel;

		// Token: 0x0400D841 RID: 55361
		[Token(Token = "0x400D841")]
		[FieldOffset(Offset = "0x38")]
		public UISprite ArrowUp;

		// Token: 0x0400D842 RID: 55362
		[Token(Token = "0x400D842")]
		[FieldOffset(Offset = "0x40")]
		public UISprite ArrowLeft;

		// Token: 0x0400D843 RID: 55363
		[Token(Token = "0x400D843")]
		[FieldOffset(Offset = "0x48")]
		public UISprite ArrowRight;

		// Token: 0x0400D844 RID: 55364
		[Token(Token = "0x400D844")]
		[FieldOffset(Offset = "0x50")]
		public UISprite ArrowDown;
	}
}
