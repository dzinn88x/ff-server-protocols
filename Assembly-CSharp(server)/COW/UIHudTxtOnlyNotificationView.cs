using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002392 RID: 9106
	[Token(Token = "0x2002392")]
	public class UIHudTxtOnlyNotificationView : UIBaseView
	{
		// Token: 0x0600C234 RID: 49716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C234")]
		[Address(RVA = "0x15EE168", Offset = "0x15EE168", VA = "0x7BBBDEE168", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C235 RID: 49717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C235")]
		[Address(RVA = "0x15EE258", Offset = "0x15EE258", VA = "0x7BBBDEE258")]
		public UIHudTxtOnlyNotificationView()
		{
		}

		// Token: 0x0400DD0C RID: 56588
		[Token(Token = "0x400DD0C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400DD0D RID: 56589
		[Token(Token = "0x400DD0D")]
		[FieldOffset(Offset = "0x28")]
		public UILabel content;
	}
}
