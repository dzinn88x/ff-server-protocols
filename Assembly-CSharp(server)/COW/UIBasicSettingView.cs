using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200211B RID: 8475
	[Token(Token = "0x200211B")]
	public class UIBasicSettingView : UIBaseView
	{
		// Token: 0x0600BD46 RID: 48454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD46")]
		[Address(RVA = "0x14276EC", Offset = "0x14276EC", VA = "0x7BBBC276EC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD47 RID: 48455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD47")]
		[Address(RVA = "0x1427FBC", Offset = "0x1427FBC", VA = "0x7BBBC27FBC")]
		public UIBasicSettingView()
		{
		}

		// Token: 0x0400C217 RID: 49687
		[Token(Token = "0x400C217")]
		[FieldOffset(Offset = "0x20")]
		public UIButton LanPopMenuBtn;

		// Token: 0x0400C218 RID: 49688
		[Token(Token = "0x400C218")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget LanMenuWidget;

		// Token: 0x0400C219 RID: 49689
		[Token(Token = "0x400C219")]
		[FieldOffset(Offset = "0x30")]
		public UISprite SelectedLan;

		// Token: 0x0400C21A RID: 49690
		[Token(Token = "0x400C21A")]
		[FieldOffset(Offset = "0x38")]
		public GameObject CanClickHL;

		// Token: 0x0400C21B RID: 49691
		[Token(Token = "0x400C21B")]
		[FieldOffset(Offset = "0x40")]
		public UIWidget NotchScreen;

		// Token: 0x0400C21C RID: 49692
		[Token(Token = "0x400C21C")]
		[FieldOffset(Offset = "0x48")]
		public GameObject TipsNotchScreen;

		// Token: 0x0400C21D RID: 49693
		[Token(Token = "0x400C21D")]
		[FieldOffset(Offset = "0x50")]
		public UILabel TipNewModeLabel;

		// Token: 0x0400C21E RID: 49694
		[Token(Token = "0x400C21E")]
		[FieldOffset(Offset = "0x58")]
		public UIToggle NorthUpBtn;

		// Token: 0x0400C21F RID: 49695
		[Token(Token = "0x400C21F")]
		[FieldOffset(Offset = "0x60")]
		public UIToggle ViewUpBtn;

		// Token: 0x0400C220 RID: 49696
		[Token(Token = "0x400C220")]
		[FieldOffset(Offset = "0x68")]
		public UIToggleButtonGroup MiniMapScaleAssist;

		// Token: 0x0400C221 RID: 49697
		[Token(Token = "0x400C221")]
		[FieldOffset(Offset = "0x70")]
		public UIToggleButton MiniMapScaleOff;

		// Token: 0x0400C222 RID: 49698
		[Token(Token = "0x400C222")]
		[FieldOffset(Offset = "0x78")]
		public UIToggleButton MiniMapScaleOn;

		// Token: 0x0400C223 RID: 49699
		[Token(Token = "0x400C223")]
		[FieldOffset(Offset = "0x80")]
		public Transform EmptyCenterTrans;

		// Token: 0x0400C224 RID: 49700
		[Token(Token = "0x400C224")]
		[FieldOffset(Offset = "0x88")]
		public UIGrid AccountBtnCenter;

		// Token: 0x0400C225 RID: 49701
		[Token(Token = "0x400C225")]
		[FieldOffset(Offset = "0x90")]
		public UIButton FBBtn;

		// Token: 0x0400C226 RID: 49702
		[Token(Token = "0x400C226")]
		[FieldOffset(Offset = "0x98")]
		public GameObject FBBtnEffect;

		// Token: 0x0400C227 RID: 49703
		[Token(Token = "0x400C227")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton AppleBtn;

		// Token: 0x0400C228 RID: 49704
		[Token(Token = "0x400C228")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject AppleBtnEffect;

		// Token: 0x0400C229 RID: 49705
		[Token(Token = "0x400C229")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton GoogleBtn;

		// Token: 0x0400C22A RID: 49706
		[Token(Token = "0x400C22A")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject GoogleBtnEffect;

		// Token: 0x0400C22B RID: 49707
		[Token(Token = "0x400C22B")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton VKBtn;

		// Token: 0x0400C22C RID: 49708
		[Token(Token = "0x400C22C")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject VKBtnEffect;

		// Token: 0x0400C22D RID: 49709
		[Token(Token = "0x400C22D")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton HWBtn;

		// Token: 0x0400C22E RID: 49710
		[Token(Token = "0x400C22E")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject HWBtnEffect;

		// Token: 0x0400C22F RID: 49711
		[Token(Token = "0x400C22F")]
		[FieldOffset(Offset = "0xE0")]
		public UIButton TwitterBtn;

		// Token: 0x0400C230 RID: 49712
		[Token(Token = "0x400C230")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject TwitterBtnEffect;

		// Token: 0x0400C231 RID: 49713
		[Token(Token = "0x400C231")]
		[FieldOffset(Offset = "0xF0")]
		public UIButton ServiceLinkBtn;

		// Token: 0x0400C232 RID: 49714
		[Token(Token = "0x400C232")]
		[FieldOffset(Offset = "0xF8")]
		public UIButton PlatformCombinedBtn;

		// Token: 0x0400C233 RID: 49715
		[Token(Token = "0x400C233")]
		[FieldOffset(Offset = "0x100")]
		public Transform MorePlatformPanel;

		// Token: 0x0400C234 RID: 49716
		[Token(Token = "0x400C234")]
		[FieldOffset(Offset = "0x108")]
		public UIButton BtnTermsOfService;

		// Token: 0x0400C235 RID: 49717
		[Token(Token = "0x400C235")]
		[FieldOffset(Offset = "0x110")]
		public UIButton BtnPrivacyPolicy;

		// Token: 0x0400C236 RID: 49718
		[Token(Token = "0x400C236")]
		[FieldOffset(Offset = "0x118")]
		public UIButton BtnUserLicence;

		// Token: 0x0400C237 RID: 49719
		[Token(Token = "0x400C237")]
		[FieldOffset(Offset = "0x120")]
		public UIButton LogOutBtn;

		// Token: 0x0400C238 RID: 49720
		[Token(Token = "0x400C238")]
		[FieldOffset(Offset = "0x128")]
		public Transform LogOutBtnTrans;

		// Token: 0x0400C239 RID: 49721
		[Token(Token = "0x400C239")]
		[FieldOffset(Offset = "0x130")]
		public UIButton Resotre;
	}
}
