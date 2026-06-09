using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024D6 RID: 9430
	[Token(Token = "0x20024D6")]
	public class UIRewardedVideoPopupWindowView : UIBaseView
	{
		// Token: 0x0600C4BC RID: 50364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4BC")]
		[Address(RVA = "0x1E21AC4", Offset = "0x1E21AC4", VA = "0x7BBC621AC4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4BD RID: 50365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4BD")]
		[Address(RVA = "0x1E21BE4", Offset = "0x1E21BE4", VA = "0x7BBC621BE4")]
		public UIRewardedVideoPopupWindowView()
		{
		}

		// Token: 0x0400EFD7 RID: 61399
		[Token(Token = "0x400EFD7")]
		[FieldOffset(Offset = "0x20")]
		public UILabel DescLabel;

		// Token: 0x0400EFD8 RID: 61400
		[Token(Token = "0x400EFD8")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnLoadAndPlay;

		// Token: 0x0400EFD9 RID: 61401
		[Token(Token = "0x400EFD9")]
		[FieldOffset(Offset = "0x30")]
		public UILabel BtnText;
	}
}
