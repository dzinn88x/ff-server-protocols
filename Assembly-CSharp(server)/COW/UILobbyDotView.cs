using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023F7 RID: 9207
	[Token(Token = "0x20023F7")]
	internal class UILobbyDotView : UIBaseView
	{
		// Token: 0x0600C2FE RID: 49918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2FE")]
		[Address(RVA = "0x152E3C4", Offset = "0x152E3C4", VA = "0x7BBBD2E3C4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2FF RID: 49919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2FF")]
		[Address(RVA = "0x152E4B4", Offset = "0x152E4B4", VA = "0x7BBBD2E4B4")]
		public UILobbyDotView()
		{
		}

		// Token: 0x0400E174 RID: 57716
		[Token(Token = "0x400E174")]
		[FieldOffset(Offset = "0x20")]
		public GameObject dotEnable;

		// Token: 0x0400E175 RID: 57717
		[Token(Token = "0x400E175")]
		[FieldOffset(Offset = "0x28")]
		public GameObject dotDisable;
	}
}
