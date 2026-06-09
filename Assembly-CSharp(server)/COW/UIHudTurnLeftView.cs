using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200238F RID: 9103
	[Token(Token = "0x200238F")]
	internal class UIHudTurnLeftView : UIBaseView
	{
		// Token: 0x0600C22E RID: 49710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C22E")]
		[Address(RVA = "0x15ED3F0", Offset = "0x15ED3F0", VA = "0x7BBBDED3F0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C22F RID: 49711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C22F")]
		[Address(RVA = "0x15ED4E0", Offset = "0x15ED4E0", VA = "0x7BBBDED4E0")]
		public UIHudTurnLeftView()
		{
		}

		// Token: 0x0400DD05 RID: 56581
		[Token(Token = "0x400DD05")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnTurnLeft;

		// Token: 0x0400DD06 RID: 56582
		[Token(Token = "0x400DD06")]
		[FieldOffset(Offset = "0x28")]
		public UILabel BtnName;
	}
}
