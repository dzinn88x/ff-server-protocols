using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023A9 RID: 9129
	[Token(Token = "0x20023A9")]
	public class UIHudWereWolvesQuickChatItemView : UIBaseView
	{
		// Token: 0x0600C262 RID: 49762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C262")]
		[Address(RVA = "0x1D14324", Offset = "0x1D14324", VA = "0x7BBC514324", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C263 RID: 49763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C263")]
		[Address(RVA = "0x1D14414", Offset = "0x1D14414", VA = "0x7BBC514414")]
		public UIHudWereWolvesQuickChatItemView()
		{
		}

		// Token: 0x0400DDD3 RID: 56787
		[Token(Token = "0x400DDD3")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnItem;

		// Token: 0x0400DDD4 RID: 56788
		[Token(Token = "0x400DDD4")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ContentLabel;
	}
}
