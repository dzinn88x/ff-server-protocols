using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002514 RID: 9492
	[Token(Token = "0x2002514")]
	internal class UISPHudItemInfoView : UIBaseView
	{
		// Token: 0x0600C538 RID: 50488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C538")]
		[Address(RVA = "0x1EE841C", Offset = "0x1EE841C", VA = "0x7BBC6E841C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C539 RID: 50489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C539")]
		[Address(RVA = "0x1EE853C", Offset = "0x1EE853C", VA = "0x7BBC6E853C")]
		public UISPHudItemInfoView()
		{
		}

		// Token: 0x0400F250 RID: 62032
		[Token(Token = "0x400F250")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnGrenade;

		// Token: 0x0400F251 RID: 62033
		[Token(Token = "0x400F251")]
		[FieldOffset(Offset = "0x28")]
		public UISprite icon;

		// Token: 0x0400F252 RID: 62034
		[Token(Token = "0x400F252")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ItemCount;
	}
}
