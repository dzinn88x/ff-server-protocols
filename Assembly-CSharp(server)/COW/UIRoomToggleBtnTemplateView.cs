using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024EC RID: 9452
	[Token(Token = "0x20024EC")]
	internal class UIRoomToggleBtnTemplateView : UIBaseView
	{
		// Token: 0x0600C4E8 RID: 50408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4E8")]
		[Address(RVA = "0x1A245D4", Offset = "0x1A245D4", VA = "0x7BBC2245D4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4E9 RID: 50409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4E9")]
		[Address(RVA = "0x1A24828", Offset = "0x1A24828", VA = "0x7BBC224828")]
		public UIRoomToggleBtnTemplateView()
		{
		}

		// Token: 0x0400F073 RID: 61555
		[Token(Token = "0x400F073")]
		[FieldOffset(Offset = "0x20")]
		public UIToggleButtonGroup ToggleBtnGo;

		// Token: 0x0400F074 RID: 61556
		[Token(Token = "0x400F074")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ToggleBtnLabel;

		// Token: 0x0400F075 RID: 61557
		[Token(Token = "0x400F075")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButton EnabledToggle;

		// Token: 0x0400F076 RID: 61558
		[Token(Token = "0x400F076")]
		[FieldOffset(Offset = "0x38")]
		public UISprite EnabledLabelCheckmark;

		// Token: 0x0400F077 RID: 61559
		[Token(Token = "0x400F077")]
		[FieldOffset(Offset = "0x40")]
		public UILabel EnabledLabel;

		// Token: 0x0400F078 RID: 61560
		[Token(Token = "0x400F078")]
		[FieldOffset(Offset = "0x48")]
		public UIToggleButton DisabledToggle;

		// Token: 0x0400F079 RID: 61561
		[Token(Token = "0x400F079")]
		[FieldOffset(Offset = "0x50")]
		public UISprite DisabledLabelCheckmark;

		// Token: 0x0400F07A RID: 61562
		[Token(Token = "0x400F07A")]
		[FieldOffset(Offset = "0x58")]
		public UILabel DisabledLabel;
	}
}
