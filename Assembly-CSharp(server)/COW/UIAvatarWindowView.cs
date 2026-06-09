using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002111 RID: 8465
	[Token(Token = "0x2002111")]
	internal class UIAvatarWindowView : UIBaseView
	{
		// Token: 0x0600BD33 RID: 48435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD33")]
		[Address(RVA = "0x141BAE4", Offset = "0x141BAE4", VA = "0x7BBBC1BAE4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD34 RID: 48436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD34")]
		[Address(RVA = "0x141BBD4", Offset = "0x141BBD4", VA = "0x7BBBC1BBD4")]
		public UIAvatarWindowView()
		{
		}

		// Token: 0x0400C1BD RID: 49597
		[Token(Token = "0x400C1BD")]
		[FieldOffset(Offset = "0x20")]
		public Transform UIAvatarWindow;

		// Token: 0x0400C1BE RID: 49598
		[Token(Token = "0x400C1BE")]
		[FieldOffset(Offset = "0x28")]
		public Transform namePanels;
	}
}
