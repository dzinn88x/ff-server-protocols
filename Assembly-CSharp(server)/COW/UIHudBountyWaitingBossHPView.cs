using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002288 RID: 8840
	[Token(Token = "0x2002288")]
	public class UIHudBountyWaitingBossHPView : UIBaseView
	{
		// Token: 0x0600C021 RID: 49185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C021")]
		[Address(RVA = "0x189EFD4", Offset = "0x189EFD4", VA = "0x7BBC09EFD4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C022 RID: 49186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C022")]
		[Address(RVA = "0x189F168", Offset = "0x189F168", VA = "0x7BBC09F168")]
		public UIHudBountyWaitingBossHPView()
		{
		}

		// Token: 0x0400D44B RID: 54347
		[Token(Token = "0x400D44B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400D44C RID: 54348
		[Token(Token = "0x400D44C")]
		[FieldOffset(Offset = "0x28")]
		public UISprite HPbarfg;

		// Token: 0x0400D44D RID: 54349
		[Token(Token = "0x400D44D")]
		[FieldOffset(Offset = "0x30")]
		public UISprite HPbarbg;

		// Token: 0x0400D44E RID: 54350
		[Token(Token = "0x400D44E")]
		[FieldOffset(Offset = "0x38")]
		public GameObject WarningIcon;

		// Token: 0x0400D44F RID: 54351
		[Token(Token = "0x400D44F")]
		[FieldOffset(Offset = "0x40")]
		public UILabel WarningTxt;
	}
}
