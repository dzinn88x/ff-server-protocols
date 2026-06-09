using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002458 RID: 9304
	[Token(Token = "0x2002458")]
	internal class UINationalFlagItemView : UIBaseView
	{
		// Token: 0x0600C3C0 RID: 50112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3C0")]
		[Address(RVA = "0x14D7A24", Offset = "0x14D7A24", VA = "0x7BBBCD7A24", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3C1 RID: 50113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3C1")]
		[Address(RVA = "0x14D7B44", Offset = "0x14D7B44", VA = "0x7BBBCD7B44")]
		public UINationalFlagItemView()
		{
		}

		// Token: 0x0400E8B1 RID: 59569
		[Token(Token = "0x400E8B1")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Item;

		// Token: 0x0400E8B2 RID: 59570
		[Token(Token = "0x400E8B2")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Flag;

		// Token: 0x0400E8B3 RID: 59571
		[Token(Token = "0x400E8B3")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Nation;
	}
}
