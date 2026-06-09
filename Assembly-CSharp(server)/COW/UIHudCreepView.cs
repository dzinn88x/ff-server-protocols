using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022A1 RID: 8865
	[Token(Token = "0x20022A1")]
	public class UIHudCreepView : UIBaseView
	{
		// Token: 0x0600C053 RID: 49235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C053")]
		[Address(RVA = "0x1A96DE8", Offset = "0x1A96DE8", VA = "0x7BBC296DE8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C054 RID: 49236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C054")]
		[Address(RVA = "0x1A96F74", Offset = "0x1A96F74", VA = "0x7BBC296F74")]
		public UIHudCreepView()
		{
		}

		// Token: 0x0400D4D0 RID: 54480
		[Token(Token = "0x400D4D0")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnCreep;

		// Token: 0x0400D4D1 RID: 54481
		[Token(Token = "0x400D4D1")]
		[FieldOffset(Offset = "0x28")]
		public UISprite BGCreep;

		// Token: 0x0400D4D2 RID: 54482
		[Token(Token = "0x400D4D2")]
		[FieldOffset(Offset = "0x30")]
		public UISprite CreepSprite;

		// Token: 0x0400D4D3 RID: 54483
		[Token(Token = "0x400D4D3")]
		[FieldOffset(Offset = "0x38")]
		public UISprite HightlightSpr;

		// Token: 0x0400D4D4 RID: 54484
		[Token(Token = "0x400D4D4")]
		[FieldOffset(Offset = "0x40")]
		public UILabel BtnName;
	}
}
