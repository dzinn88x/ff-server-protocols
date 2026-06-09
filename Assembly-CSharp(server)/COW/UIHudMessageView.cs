using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002315 RID: 8981
	[Token(Token = "0x2002315")]
	public class UIHudMessageView : UIBaseView
	{
		// Token: 0x0600C13A RID: 49466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C13A")]
		[Address(RVA = "0x17B3764", Offset = "0x17B3764", VA = "0x7BBBFB3764", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C13B RID: 49467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C13B")]
		[Address(RVA = "0x17B3CA8", Offset = "0x17B3CA8", VA = "0x7BBBFB3CA8")]
		public UIHudMessageView()
		{
		}

		// Token: 0x0400D969 RID: 55657
		[Token(Token = "0x400D969")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget MaskContainer;

		// Token: 0x0400D96A RID: 55658
		[Token(Token = "0x400D96A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject QuickChatContent;

		// Token: 0x0400D96B RID: 55659
		[Token(Token = "0x400D96B")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView QuickChatList;

		// Token: 0x0400D96C RID: 55660
		[Token(Token = "0x400D96C")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid QuickChatListGrid;

		// Token: 0x0400D96D RID: 55661
		[Token(Token = "0x400D96D")]
		[FieldOffset(Offset = "0x40")]
		public UIToggle QuickChatBlockToggle;

		// Token: 0x0400D96E RID: 55662
		[Token(Token = "0x400D96E")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ReservationContent;

		// Token: 0x0400D96F RID: 55663
		[Token(Token = "0x400D96F")]
		[FieldOffset(Offset = "0x50")]
		public UIGrid ReservationList;

		// Token: 0x0400D970 RID: 55664
		[Token(Token = "0x400D970")]
		[FieldOffset(Offset = "0x58")]
		public UILabel ReservationOffHint;

		// Token: 0x0400D971 RID: 55665
		[Token(Token = "0x400D971")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ReservationBlock;

		// Token: 0x0400D972 RID: 55666
		[Token(Token = "0x400D972")]
		[FieldOffset(Offset = "0x68")]
		public UIToggle ReservationBlockToggle;

		// Token: 0x0400D973 RID: 55667
		[Token(Token = "0x400D973")]
		[FieldOffset(Offset = "0x70")]
		public GameObject TrainingModeMessageContent;

		// Token: 0x0400D974 RID: 55668
		[Token(Token = "0x400D974")]
		[FieldOffset(Offset = "0x78")]
		public UIInput MessageInput;

		// Token: 0x0400D975 RID: 55669
		[Token(Token = "0x400D975")]
		[FieldOffset(Offset = "0x80")]
		public UIButton SendBtn;

		// Token: 0x0400D976 RID: 55670
		[Token(Token = "0x400D976")]
		[FieldOffset(Offset = "0x88")]
		public UIToggleButtonGroup ToggleBtnGroup;

		// Token: 0x0400D977 RID: 55671
		[Token(Token = "0x400D977")]
		[FieldOffset(Offset = "0x90")]
		public UIGrid BtnGrid;

		// Token: 0x0400D978 RID: 55672
		[Token(Token = "0x400D978")]
		[FieldOffset(Offset = "0x98")]
		public UIToggleButton QuickChatToggle;

		// Token: 0x0400D979 RID: 55673
		[Token(Token = "0x400D979")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject BlockIcon;

		// Token: 0x0400D97A RID: 55674
		[Token(Token = "0x400D97A")]
		[FieldOffset(Offset = "0xA8")]
		public UIToggleButton ReservationToggle;

		// Token: 0x0400D97B RID: 55675
		[Token(Token = "0x400D97B")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject ReservationToggleSprite;

		// Token: 0x0400D97C RID: 55676
		[Token(Token = "0x400D97C")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject ReservationToggleSpriteBanned;

		// Token: 0x0400D97D RID: 55677
		[Token(Token = "0x400D97D")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject UnreadTip;
	}
}
