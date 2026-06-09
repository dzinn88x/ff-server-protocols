using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200225E RID: 8798
	[Token(Token = "0x200225E")]
	public class UIHudAOHIntroInfoView : UIBaseView
	{
		// Token: 0x0600BFCD RID: 49101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFCD")]
		[Address(RVA = "0x1D64528", Offset = "0x1D64528", VA = "0x7BBC564528", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFCE RID: 49102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFCE")]
		[Address(RVA = "0x1D64618", Offset = "0x1D64618", VA = "0x7BBC564618")]
		public UIHudAOHIntroInfoView()
		{
		}

		// Token: 0x0400D358 RID: 54104
		[Token(Token = "0x400D358")]
		[FieldOffset(Offset = "0x20")]
		public UILabel IntroKey;

		// Token: 0x0400D359 RID: 54105
		[Token(Token = "0x400D359")]
		[FieldOffset(Offset = "0x28")]
		public UILabel IntroDetail;
	}
}
