using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002584 RID: 9604
	[Token(Token = "0x2002584")]
	public class UIVeteranBundleItemView : UIBaseView
	{
		// Token: 0x0600C618 RID: 50712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C618")]
		[Address(RVA = "0x1A0B814", Offset = "0x1A0B814", VA = "0x7BBC20B814", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C619 RID: 50713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C619")]
		[Address(RVA = "0x1A0B904", Offset = "0x1A0B904", VA = "0x7BBC20B904")]
		public UIVeteranBundleItemView()
		{
		}

		// Token: 0x0400F6E4 RID: 63204
		[Token(Token = "0x400F6E4")]
		[FieldOffset(Offset = "0x20")]
		public Transform AwardItemGrid;

		// Token: 0x0400F6E5 RID: 63205
		[Token(Token = "0x400F6E5")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Desc;
	}
}
