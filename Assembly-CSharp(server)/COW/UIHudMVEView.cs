using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002318 RID: 8984
	[Token(Token = "0x2002318")]
	public class UIHudMVEView : UIBaseView
	{
		// Token: 0x0600C140 RID: 49472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C140")]
		[Address(RVA = "0x15BCAF0", Offset = "0x15BCAF0", VA = "0x7BBBDBCAF0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C141 RID: 49473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C141")]
		[Address(RVA = "0x15BCC8C", Offset = "0x15BCC8C", VA = "0x7BBBDBCC8C")]
		public UIHudMVEView()
		{
		}

		// Token: 0x0400D998 RID: 55704
		[Token(Token = "0x400D998")]
		[FieldOffset(Offset = "0x20")]
		public UISprite EnergyBar;

		// Token: 0x0400D999 RID: 55705
		[Token(Token = "0x400D999")]
		[FieldOffset(Offset = "0x28")]
		public UISprite EnergyBar2;

		// Token: 0x0400D99A RID: 55706
		[Token(Token = "0x400D99A")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnMVE;

		// Token: 0x0400D99B RID: 55707
		[Token(Token = "0x400D99B")]
		[FieldOffset(Offset = "0x38")]
		public UISprite BtnSprite;

		// Token: 0x0400D99C RID: 55708
		[Token(Token = "0x400D99C")]
		[FieldOffset(Offset = "0x40")]
		public UILabel BtnName;
	}
}
