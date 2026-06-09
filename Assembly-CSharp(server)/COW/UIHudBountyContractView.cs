using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002285 RID: 8837
	[Token(Token = "0x2002285")]
	internal class UIHudBountyContractView : UIBaseView
	{
		// Token: 0x0600C01B RID: 49179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C01B")]
		[Address(RVA = "0x189EEB4", Offset = "0x189EEB4", VA = "0x7BBC09EEB4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C01C RID: 49180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C01C")]
		[Address(RVA = "0x189EFCC", Offset = "0x189EFCC", VA = "0x7BBC09EFCC")]
		public UIHudBountyContractView()
		{
		}

		// Token: 0x0400D440 RID: 54336
		[Token(Token = "0x400D440")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnBountyContract;

		// Token: 0x0400D441 RID: 54337
		[Token(Token = "0x400D441")]
		[FieldOffset(Offset = "0x28")]
		public UISprite BGBountyContract;

		// Token: 0x0400D442 RID: 54338
		[Token(Token = "0x400D442")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BountyIcon;
	}
}
