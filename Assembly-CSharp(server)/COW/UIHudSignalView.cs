using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002361 RID: 9057
	[Token(Token = "0x2002361")]
	internal class UIHudSignalView : UIBaseView
	{
		// Token: 0x0600C1D2 RID: 49618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1D2")]
		[Address(RVA = "0x1665558", Offset = "0x1665558", VA = "0x7BBBE65558", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1D3 RID: 49619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1D3")]
		[Address(RVA = "0x1665648", Offset = "0x1665648", VA = "0x7BBBE65648")]
		public UIHudSignalView()
		{
		}

		// Token: 0x0400DB84 RID: 56196
		[Token(Token = "0x400DB84")]
		[FieldOffset(Offset = "0x20")]
		public UISprite SignalIcon;

		// Token: 0x0400DB85 RID: 56197
		[Token(Token = "0x400DB85")]
		[FieldOffset(Offset = "0x28")]
		public UILabel SignalLabel;
	}
}
