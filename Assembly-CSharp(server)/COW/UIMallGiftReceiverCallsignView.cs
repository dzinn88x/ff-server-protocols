using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002418 RID: 9240
	[Token(Token = "0x2002418")]
	internal class UIMallGiftReceiverCallsignView : UIBaseView
	{
		// Token: 0x0600C340 RID: 49984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C340")]
		[Address(RVA = "0x1C7370C", Offset = "0x1C7370C", VA = "0x7BBC47370C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C341 RID: 49985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C341")]
		[Address(RVA = "0x1C7382C", Offset = "0x1C7382C", VA = "0x7BBC47382C")]
		public UIMallGiftReceiverCallsignView()
		{
		}

		// Token: 0x0400E4A2 RID: 58530
		[Token(Token = "0x400E4A2")]
		[FieldOffset(Offset = "0x20")]
		public UILabel name;

		// Token: 0x0400E4A3 RID: 58531
		[Token(Token = "0x400E4A3")]
		[FieldOffset(Offset = "0x28")]
		public UISprite bg;

		// Token: 0x0400E4A4 RID: 58532
		[Token(Token = "0x400E4A4")]
		[FieldOffset(Offset = "0x30")]
		public GameObject fakeBg;
	}
}
