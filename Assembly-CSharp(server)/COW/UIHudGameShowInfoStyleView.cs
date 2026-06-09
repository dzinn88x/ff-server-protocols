using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022D7 RID: 8919
	[Token(Token = "0x20022D7")]
	public class UIHudGameShowInfoStyleView : UIBaseView
	{
		// Token: 0x0600C0BE RID: 49342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0BE")]
		[Address(RVA = "0x1C14758", Offset = "0x1C14758", VA = "0x7BBC414758", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0BF RID: 49343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0BF")]
		[Address(RVA = "0x1C14870", Offset = "0x1C14870", VA = "0x7BBC414870")]
		public UIHudGameShowInfoStyleView()
		{
		}

		// Token: 0x0400D6BB RID: 54971
		[Token(Token = "0x400D6BB")]
		[FieldOffset(Offset = "0x20")]
		public UILabel IntroKey;

		// Token: 0x0400D6BC RID: 54972
		[Token(Token = "0x400D6BC")]
		[FieldOffset(Offset = "0x28")]
		public UILabel IntroKeyBig;

		// Token: 0x0400D6BD RID: 54973
		[Token(Token = "0x400D6BD")]
		[FieldOffset(Offset = "0x30")]
		public UILabel IntroDetail;
	}
}
