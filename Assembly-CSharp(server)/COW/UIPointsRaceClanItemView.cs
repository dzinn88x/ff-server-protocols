using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002491 RID: 9361
	[Token(Token = "0x2002491")]
	internal class UIPointsRaceClanItemView : UIBaseView
	{
		// Token: 0x0600C432 RID: 50226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C432")]
		[Address(RVA = "0x20E7454", Offset = "0x20E7454", VA = "0x7BBC8E7454", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C433 RID: 50227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C433")]
		[Address(RVA = "0x20E76B8", Offset = "0x20E76B8", VA = "0x7BBC8E76B8")]
		public UIPointsRaceClanItemView()
		{
		}

		// Token: 0x0400EB84 RID: 60292
		[Token(Token = "0x400EB84")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Box;

		// Token: 0x0400EB85 RID: 60293
		[Token(Token = "0x400EB85")]
		[FieldOffset(Offset = "0x28")]
		public UISprite BoxIcon;

		// Token: 0x0400EB86 RID: 60294
		[Token(Token = "0x400EB86")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ClaimedObj;

		// Token: 0x0400EB87 RID: 60295
		[Token(Token = "0x400EB87")]
		[FieldOffset(Offset = "0x38")]
		public GameObject UnlockObj;

		// Token: 0x0400EB88 RID: 60296
		[Token(Token = "0x400EB88")]
		[FieldOffset(Offset = "0x40")]
		public UILabel UnlockNumberText;

		// Token: 0x0400EB89 RID: 60297
		[Token(Token = "0x400EB89")]
		[FieldOffset(Offset = "0x48")]
		public GameObject PhaseArrow;

		// Token: 0x0400EB8A RID: 60298
		[Token(Token = "0x400EB8A")]
		[FieldOffset(Offset = "0x50")]
		public GameObject LockObj;

		// Token: 0x0400EB8B RID: 60299
		[Token(Token = "0x400EB8B")]
		[FieldOffset(Offset = "0x58")]
		public UILabel LockNumberText;
	}
}
