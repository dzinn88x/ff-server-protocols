using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200227F RID: 8831
	[Token(Token = "0x200227F")]
	public class UIHudBombHintView : UIBaseView
	{
		// Token: 0x0600C00F RID: 49167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C00F")]
		[Address(RVA = "0x1899E58", Offset = "0x1899E58", VA = "0x7BBC099E58", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C010 RID: 49168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C010")]
		[Address(RVA = "0x1899F48", Offset = "0x1899F48", VA = "0x7BBC099F48")]
		public UIHudBombHintView()
		{
		}

		// Token: 0x0400D414 RID: 54292
		[Token(Token = "0x400D414")]
		[FieldOffset(Offset = "0x20")]
		public UILabel InfoLabel;

		// Token: 0x0400D415 RID: 54293
		[Token(Token = "0x400D415")]
		[FieldOffset(Offset = "0x28")]
		public UISprite WarningIcon;
	}
}
