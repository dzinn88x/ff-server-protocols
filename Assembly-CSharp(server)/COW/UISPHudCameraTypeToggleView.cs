using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024FF RID: 9471
	[Token(Token = "0x20024FF")]
	internal class UISPHudCameraTypeToggleView : UIBaseView
	{
		// Token: 0x0600C510 RID: 50448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C510")]
		[Address(RVA = "0x1EE67E4", Offset = "0x1EE67E4", VA = "0x7BBC6E67E4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C511 RID: 50449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C511")]
		[Address(RVA = "0x1EE6940", Offset = "0x1EE6940", VA = "0x7BBC6E6940")]
		public UISPHudCameraTypeToggleView()
		{
		}

		// Token: 0x0400F160 RID: 61792
		[Token(Token = "0x400F160")]
		[FieldOffset(Offset = "0x20")]
		public UIButton SwitchBtn;

		// Token: 0x0400F161 RID: 61793
		[Token(Token = "0x400F161")]
		[FieldOffset(Offset = "0x28")]
		public UISprite normal;

		// Token: 0x0400F162 RID: 61794
		[Token(Token = "0x400F162")]
		[FieldOffset(Offset = "0x30")]
		public UISprite FixedCamera;

		// Token: 0x0400F163 RID: 61795
		[Token(Token = "0x400F163")]
		[FieldOffset(Offset = "0x38")]
		public UISprite FreeCamera;
	}
}
