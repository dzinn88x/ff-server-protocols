using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002212 RID: 8722
	[Token(Token = "0x2002212")]
	public class UIGachaLegendaryBuyBtnView : UIBaseView
	{
		// Token: 0x0600BF35 RID: 48949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF35")]
		[Address(RVA = "0x205732C", Offset = "0x205732C", VA = "0x7BBC85732C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF36 RID: 48950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF36")]
		[Address(RVA = "0x205741C", Offset = "0x205741C", VA = "0x7BBC85741C")]
		public UIGachaLegendaryBuyBtnView()
		{
		}

		// Token: 0x0400CED0 RID: 52944
		[Token(Token = "0x400CED0")]
		[FieldOffset(Offset = "0x20")]
		public UIGachaBuyBtnBaseView UIGachaBuyBtnBaseView;

		// Token: 0x0400CED1 RID: 52945
		[Token(Token = "0x400CED1")]
		[FieldOffset(Offset = "0x28")]
		public UISprite NewsIcon;
	}
}
