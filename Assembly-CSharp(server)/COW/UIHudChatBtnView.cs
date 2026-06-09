using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002298 RID: 8856
	[Token(Token = "0x2002298")]
	public class UIHudChatBtnView : UIBaseView
	{
		// Token: 0x0600C041 RID: 49217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C041")]
		[Address(RVA = "0x1A90BBC", Offset = "0x1A90BBC", VA = "0x7BBC290BBC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C042 RID: 49218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C042")]
		[Address(RVA = "0x1A90DB4", Offset = "0x1A90DB4", VA = "0x7BBC290DB4")]
		public UIHudChatBtnView()
		{
		}

		// Token: 0x0400D48A RID: 54410
		[Token(Token = "0x400D48A")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ChatBtn;

		// Token: 0x0400D48B RID: 54411
		[Token(Token = "0x400D48B")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget WidgetContainer;

		// Token: 0x0400D48C RID: 54412
		[Token(Token = "0x400D48C")]
		[FieldOffset(Offset = "0x30")]
		public GameObject CloseIcon;

		// Token: 0x0400D48D RID: 54413
		[Token(Token = "0x400D48D")]
		[FieldOffset(Offset = "0x38")]
		public UISprite CDBlock;

		// Token: 0x0400D48E RID: 54414
		[Token(Token = "0x400D48E")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Icon;

		// Token: 0x0400D48F RID: 54415
		[Token(Token = "0x400D48F")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Tip;
	}
}
