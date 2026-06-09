using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200233B RID: 9019
	[Token(Token = "0x200233B")]
	public class UIHudQuickChatItemView : UIBaseView
	{
		// Token: 0x0600C186 RID: 49542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C186")]
		[Address(RVA = "0x17E10F4", Offset = "0x17E10F4", VA = "0x7BBBFE10F4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C187 RID: 49543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C187")]
		[Address(RVA = "0x17E11E4", Offset = "0x17E11E4", VA = "0x7BBBFE11E4")]
		public UIHudQuickChatItemView()
		{
		}

		// Token: 0x0400DA99 RID: 55961
		[Token(Token = "0x400DA99")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Btn;

		// Token: 0x0400DA9A RID: 55962
		[Token(Token = "0x400DA9A")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Label;
	}
}
