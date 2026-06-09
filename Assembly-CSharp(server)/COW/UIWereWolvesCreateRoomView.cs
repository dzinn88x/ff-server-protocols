using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025A2 RID: 9634
	[Token(Token = "0x20025A2")]
	public class UIWereWolvesCreateRoomView : UIBaseView
	{
		// Token: 0x0600C654 RID: 50772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C654")]
		[Address(RVA = "0x178884C", Offset = "0x178884C", VA = "0x7BBBF8884C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C655 RID: 50773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C655")]
		[Address(RVA = "0x1788E2C", Offset = "0x1788E2C", VA = "0x7BBBF88E2C")]
		public UIWereWolvesCreateRoomView()
		{
		}

		// Token: 0x0400F88C RID: 63628
		[Token(Token = "0x400F88C")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel TopPanel;

		// Token: 0x0400F88D RID: 63629
		[Token(Token = "0x400F88D")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Title;

		// Token: 0x0400F88E RID: 63630
		[Token(Token = "0x400F88E")]
		[FieldOffset(Offset = "0x30")]
		public GameObject RoomGameSettingBtnGo;

		// Token: 0x0400F88F RID: 63631
		[Token(Token = "0x400F88F")]
		[FieldOffset(Offset = "0x38")]
		public UIButton close;

		// Token: 0x0400F890 RID: 63632
		[Token(Token = "0x400F890")]
		[FieldOffset(Offset = "0x40")]
		public GameObject InfoPanel;

		// Token: 0x0400F891 RID: 63633
		[Token(Token = "0x400F891")]
		[FieldOffset(Offset = "0x48")]
		public GameObject RoomSettingPanel;

		// Token: 0x0400F892 RID: 63634
		[Token(Token = "0x400F892")]
		[FieldOffset(Offset = "0x50")]
		public UISprite Map;

		// Token: 0x0400F893 RID: 63635
		[Token(Token = "0x400F893")]
		[FieldOffset(Offset = "0x58")]
		public UILabel MapName;

		// Token: 0x0400F894 RID: 63636
		[Token(Token = "0x400F894")]
		[FieldOffset(Offset = "0x60")]
		public UIInput NameInput;

		// Token: 0x0400F895 RID: 63637
		[Token(Token = "0x400F895")]
		[FieldOffset(Offset = "0x68")]
		public UIInput CodeInput;

		// Token: 0x0400F896 RID: 63638
		[Token(Token = "0x400F896")]
		[FieldOffset(Offset = "0x70")]
		public GameObject PlayerCountSettingRoot;

		// Token: 0x0400F897 RID: 63639
		[Token(Token = "0x400F897")]
		[FieldOffset(Offset = "0x78")]
		public UILabel SettingPagePlayerCountLabel;

		// Token: 0x0400F898 RID: 63640
		[Token(Token = "0x400F898")]
		[FieldOffset(Offset = "0x80")]
		public UIWidget PlayerCountPopMenu;

		// Token: 0x0400F899 RID: 63641
		[Token(Token = "0x400F899")]
		[FieldOffset(Offset = "0x88")]
		public UIWidget WolfCountPopMenu;

		// Token: 0x0400F89A RID: 63642
		[Token(Token = "0x400F89A")]
		[FieldOffset(Offset = "0x90")]
		public UIButton CreateRoomBtn2;

		// Token: 0x0400F89B RID: 63643
		[Token(Token = "0x400F89B")]
		[FieldOffset(Offset = "0x98")]
		public UIButton LanguageBtn;

		// Token: 0x0400F89C RID: 63644
		[Token(Token = "0x400F89C")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite LanguageSprite;

		// Token: 0x0400F89D RID: 63645
		[Token(Token = "0x400F89D")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject LanguagaeCreateRoot;

		// Token: 0x0400F89E RID: 63646
		[Token(Token = "0x400F89E")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject GameSettingPanel;

		// Token: 0x0400F89F RID: 63647
		[Token(Token = "0x400F89F")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton CreateRoomBtn1;

		// Token: 0x0400F8A0 RID: 63648
		[Token(Token = "0x400F8A0")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton ResetBtn;

		// Token: 0x0400F8A1 RID: 63649
		[Token(Token = "0x400F8A1")]
		[FieldOffset(Offset = "0xC8")]
		public UIGrid ParamsGrid;

		// Token: 0x0400F8A2 RID: 63650
		[Token(Token = "0x400F8A2")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject RoomCardGo;
	}
}
