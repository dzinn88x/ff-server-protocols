using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002273 RID: 8819
	[Token(Token = "0x2002273")]
	public class UIHudBanknoteHintView : UIBaseView
	{
		// Token: 0x0600BFF7 RID: 49143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFF7")]
		[Address(RVA = "0x188C2EC", Offset = "0x188C2EC", VA = "0x7BBC08C2EC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFF8 RID: 49144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFF8")]
		[Address(RVA = "0x188C3DC", Offset = "0x188C3DC", VA = "0x7BBC08C3DC")]
		public UIHudBanknoteHintView()
		{
		}

		// Token: 0x0400D3BC RID: 54204
		[Token(Token = "0x400D3BC")]
		[FieldOffset(Offset = "0x20")]
		public UILabel InfoLabel;

		// Token: 0x0400D3BD RID: 54205
		[Token(Token = "0x400D3BD")]
		[FieldOffset(Offset = "0x28")]
		public UISprite WarningIcon;
	}
}
