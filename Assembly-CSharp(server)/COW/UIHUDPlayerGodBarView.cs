using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200232D RID: 9005
	[Token(Token = "0x200232D")]
	internal class UIHUDPlayerGodBarView : UIBaseView
	{
		// Token: 0x0600C16A RID: 49514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C16A")]
		[Address(RVA = "0x16BD9AC", Offset = "0x16BD9AC", VA = "0x7BBBEBD9AC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C16B RID: 49515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C16B")]
		[Address(RVA = "0x16BDA9C", Offset = "0x16BDA9C", VA = "0x7BBBEBDA9C")]
		public UIHUDPlayerGodBarView()
		{
		}

		// Token: 0x0400DA55 RID: 55893
		[Token(Token = "0x400DA55")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400DA56 RID: 55894
		[Token(Token = "0x400DA56")]
		[FieldOffset(Offset = "0x28")]
		public UIProgressBar ProgressBar;
	}
}
