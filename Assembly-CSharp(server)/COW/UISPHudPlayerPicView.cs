using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002526 RID: 9510
	[Token(Token = "0x2002526")]
	public class UISPHudPlayerPicView : UIBaseView
	{
		// Token: 0x0600C55C RID: 50524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C55C")]
		[Address(RVA = "0x1EEE420", Offset = "0x1EEE420", VA = "0x7BBC6EE420", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C55D RID: 50525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C55D")]
		[Address(RVA = "0x1EEE540", Offset = "0x1EEE540", VA = "0x7BBC6EE540")]
		public UISPHudPlayerPicView()
		{
		}

		// Token: 0x0400F302 RID: 62210
		[Token(Token = "0x400F302")]
		[FieldOffset(Offset = "0x20")]
		public TweenPosition TweenPosOnShowing;

		// Token: 0x0400F303 RID: 62211
		[Token(Token = "0x400F303")]
		[FieldOffset(Offset = "0x28")]
		public UITexture TexturePlayerPic;

		// Token: 0x0400F304 RID: 62212
		[Token(Token = "0x400F304")]
		[FieldOffset(Offset = "0x30")]
		public GameObject PlayerPicBG;
	}
}
