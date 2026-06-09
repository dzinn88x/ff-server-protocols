using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024F5 RID: 9461
	[Token(Token = "0x20024F5")]
	public class UISettingView : UIBaseView
	{
		// Token: 0x0600C4FA RID: 50426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4FA")]
		[Address(RVA = "0x16377C4", Offset = "0x16377C4", VA = "0x7BBBE377C4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4FB RID: 50427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4FB")]
		[Address(RVA = "0x1637D88", Offset = "0x1637D88", VA = "0x7BBBE37D88")]
		public UISettingView()
		{
		}

		// Token: 0x0400F0F1 RID: 61681
		[Token(Token = "0x400F0F1")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel WindowPanel;

		// Token: 0x0400F0F2 RID: 61682
		[Token(Token = "0x400F0F2")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ChangeTabToggle;

		// Token: 0x0400F0F3 RID: 61683
		[Token(Token = "0x400F0F3")]
		[FieldOffset(Offset = "0x30")]
		public GameObject BasicNode;

		// Token: 0x0400F0F4 RID: 61684
		[Token(Token = "0x400F0F4")]
		[FieldOffset(Offset = "0x38")]
		public UIToggleButton BasicButton;

		// Token: 0x0400F0F5 RID: 61685
		[Token(Token = "0x400F0F5")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleButton SensitivyButton;

		// Token: 0x0400F0F6 RID: 61686
		[Token(Token = "0x400F0F6")]
		[FieldOffset(Offset = "0x48")]
		public UIToggleButton OperationButton;

		// Token: 0x0400F0F7 RID: 61687
		[Token(Token = "0x400F0F7")]
		[FieldOffset(Offset = "0x50")]
		public UIToggleButton AutoPickUpTabBtn;

		// Token: 0x0400F0F8 RID: 61688
		[Token(Token = "0x400F0F8")]
		[FieldOffset(Offset = "0x58")]
		public UIToggleButton GraphicsBtn;

		// Token: 0x0400F0F9 RID: 61689
		[Token(Token = "0x400F0F9")]
		[FieldOffset(Offset = "0x60")]
		public GameObject GraphicsTabTips;

		// Token: 0x0400F0FA RID: 61690
		[Token(Token = "0x400F0FA")]
		[FieldOffset(Offset = "0x68")]
		public UIToggleButton SoundButton;

		// Token: 0x0400F0FB RID: 61691
		[Token(Token = "0x400F0FB")]
		[FieldOffset(Offset = "0x70")]
		public GameObject NotificationsTab;

		// Token: 0x0400F0FC RID: 61692
		[Token(Token = "0x400F0FC")]
		[FieldOffset(Offset = "0x78")]
		public UIToggleButton NotificationsButton;

		// Token: 0x0400F0FD RID: 61693
		[Token(Token = "0x400F0FD")]
		[FieldOffset(Offset = "0x80")]
		public GameObject MAXTab;

		// Token: 0x0400F0FE RID: 61694
		[Token(Token = "0x400F0FE")]
		[FieldOffset(Offset = "0x88")]
		public UIToggleButton MAXButton;

		// Token: 0x0400F0FF RID: 61695
		[Token(Token = "0x400F0FF")]
		[FieldOffset(Offset = "0x90")]
		public GameObject DebugInfoTab;

		// Token: 0x0400F100 RID: 61696
		[Token(Token = "0x400F100")]
		[FieldOffset(Offset = "0x98")]
		public UIToggleButton DegbugInfoButton;

		// Token: 0x0400F101 RID: 61697
		[Token(Token = "0x400F101")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject OBTab;

		// Token: 0x0400F102 RID: 61698
		[Token(Token = "0x400F102")]
		[FieldOffset(Offset = "0xA8")]
		public UIToggleButton OBButton;

		// Token: 0x0400F103 RID: 61699
		[Token(Token = "0x400F103")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite bg;

		// Token: 0x0400F104 RID: 61700
		[Token(Token = "0x400F104")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton close;

		// Token: 0x0400F105 RID: 61701
		[Token(Token = "0x400F105")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject Content;

		// Token: 0x0400F106 RID: 61702
		[Token(Token = "0x400F106")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel Region;

		// Token: 0x0400F107 RID: 61703
		[Token(Token = "0x400F107")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject GuidePos;

		// Token: 0x0400F108 RID: 61704
		[Token(Token = "0x400F108")]
		[FieldOffset(Offset = "0xD8")]
		public UIWidget GuidePosWidget;
	}
}
