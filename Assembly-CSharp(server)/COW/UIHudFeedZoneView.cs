using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022CF RID: 8911
	[Token(Token = "0x20022CF")]
	public class UIHudFeedZoneView : UIBaseView
	{
		// Token: 0x0600C0AE RID: 49326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0AE")]
		[Address(RVA = "0x1C0BAD0", Offset = "0x1C0BAD0", VA = "0x7BBC40BAD0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0AF RID: 49327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0AF")]
		[Address(RVA = "0x1C0BBC0", Offset = "0x1C0BBC0", VA = "0x7BBC40BBC0")]
		public UIHudFeedZoneView()
		{
		}

		// Token: 0x0400D69C RID: 54940
		[Token(Token = "0x400D69C")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnFeedZone;

		// Token: 0x0400D69D RID: 54941
		[Token(Token = "0x400D69D")]
		[FieldOffset(Offset = "0x28")]
		public ParticleSystem FlashEffect;
	}
}
