using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023AA RID: 9130
	[Token(Token = "0x20023AA")]
	public class UIHudWereWolvesQuickChatScrollView : UIBaseView
	{
		// Token: 0x0600C264 RID: 49764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C264")]
		[Address(RVA = "0x1D14C8C", Offset = "0x1D14C8C", VA = "0x7BBC514C8C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C265 RID: 49765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C265")]
		[Address(RVA = "0x1D14D7C", Offset = "0x1D14D7C", VA = "0x7BBC514D7C")]
		public UIHudWereWolvesQuickChatScrollView()
		{
		}

		// Token: 0x0400DDD5 RID: 56789
		[Token(Token = "0x400DDD5")]
		[FieldOffset(Offset = "0x20")]
		public UIButton bgmask;

		// Token: 0x0400DDD6 RID: 56790
		[Token(Token = "0x400DDD6")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList QuickChatEasyList;
	}
}
