using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002330 RID: 9008
	[Token(Token = "0x2002330")]
	public class UIHudPopupView : UIBaseView
	{
		// Token: 0x0600C170 RID: 49520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C170")]
		[Address(RVA = "0x1D85598", Offset = "0x1D85598", VA = "0x7BBC585598", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C171 RID: 49521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C171")]
		[Address(RVA = "0x1D85734", Offset = "0x1D85734", VA = "0x7BBC585734")]
		public UIHudPopupView()
		{
		}

		// Token: 0x0400DA7A RID: 55930
		[Token(Token = "0x400DA7A")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel MainPanel;

		// Token: 0x0400DA7B RID: 55931
		[Token(Token = "0x400DA7B")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Bg;

		// Token: 0x0400DA7C RID: 55932
		[Token(Token = "0x400DA7C")]
		[FieldOffset(Offset = "0x30")]
		public UIPanel LabelPanel;

		// Token: 0x0400DA7D RID: 55933
		[Token(Token = "0x400DA7D")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Message;

		// Token: 0x0400DA7E RID: 55934
		[Token(Token = "0x400DA7E")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Messageshow;
	}
}
