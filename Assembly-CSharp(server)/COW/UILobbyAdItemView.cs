using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023F2 RID: 9202
	[Token(Token = "0x20023F2")]
	internal class UILobbyAdItemView : UIBaseView
	{
		// Token: 0x0600C2F4 RID: 49908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2F4")]
		[Address(RVA = "0x15255A0", Offset = "0x15255A0", VA = "0x7BBBD255A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2F5 RID: 49909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2F5")]
		[Address(RVA = "0x15256C0", Offset = "0x15256C0", VA = "0x7BBBD256C0")]
		public UILobbyAdItemView()
		{
		}

		// Token: 0x0400E140 RID: 57664
		[Token(Token = "0x400E140")]
		[FieldOffset(Offset = "0x20")]
		public GameObject img1;

		// Token: 0x0400E141 RID: 57665
		[Token(Token = "0x400E141")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture NetworkTexture;

		// Token: 0x0400E142 RID: 57666
		[Token(Token = "0x400E142")]
		[FieldOffset(Offset = "0x30")]
		public UICountDownLabel CountDownLabel;
	}
}
