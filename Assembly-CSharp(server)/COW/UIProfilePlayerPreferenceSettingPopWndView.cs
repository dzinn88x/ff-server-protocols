using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024AC RID: 9388
	[Token(Token = "0x20024AC")]
	public class UIProfilePlayerPreferenceSettingPopWndView : UIBaseView
	{
		// Token: 0x0600C468 RID: 50280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C468")]
		[Address(RVA = "0x1FEF408", Offset = "0x1FEF408", VA = "0x7BBC7EF408", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C469 RID: 50281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C469")]
		[Address(RVA = "0x1FEFE60", Offset = "0x1FEFE60", VA = "0x7BBC7EFE60")]
		public UIProfilePlayerPreferenceSettingPopWndView()
		{
		}

		// Token: 0x0400ED74 RID: 60788
		[Token(Token = "0x400ED74")]
		[FieldOffset(Offset = "0x20")]
		public UIToggleButton BasicSetting;

		// Token: 0x0400ED75 RID: 60789
		[Token(Token = "0x400ED75")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BasicSettingPanel;

		// Token: 0x0400ED76 RID: 60790
		[Token(Token = "0x400ED76")]
		[FieldOffset(Offset = "0x30")]
		public UILabel NameLabel;

		// Token: 0x0400ED77 RID: 60791
		[Token(Token = "0x400ED77")]
		[FieldOffset(Offset = "0x38")]
		public UIButton ChangeNameBtn;

		// Token: 0x0400ED78 RID: 60792
		[Token(Token = "0x400ED78")]
		[FieldOffset(Offset = "0x40")]
		public UISprite LanguageSprite;

		// Token: 0x0400ED79 RID: 60793
		[Token(Token = "0x400ED79")]
		[FieldOffset(Offset = "0x48")]
		public UIButton ChangeLanguageBtn;

		// Token: 0x0400ED7A RID: 60794
		[Token(Token = "0x400ED7A")]
		[FieldOffset(Offset = "0x50")]
		public Transform Sex;

		// Token: 0x0400ED7B RID: 60795
		[Token(Token = "0x400ED7B")]
		[FieldOffset(Offset = "0x58")]
		public Transform DefaultShow;

		// Token: 0x0400ED7C RID: 60796
		[Token(Token = "0x400ED7C")]
		[FieldOffset(Offset = "0x60")]
		public Transform OnLineTime;

		// Token: 0x0400ED7D RID: 60797
		[Token(Token = "0x400ED7D")]
		[FieldOffset(Offset = "0x68")]
		public Transform ActiveTime;

		// Token: 0x0400ED7E RID: 60798
		[Token(Token = "0x400ED7E")]
		[FieldOffset(Offset = "0x70")]
		public Transform ModePrefer;

		// Token: 0x0400ED7F RID: 60799
		[Token(Token = "0x400ED7F")]
		[FieldOffset(Offset = "0x78")]
		public UIInput InputField;

		// Token: 0x0400ED80 RID: 60800
		[Token(Token = "0x400ED80")]
		[FieldOffset(Offset = "0x80")]
		public BoxCollider InputFieldCollider;

		// Token: 0x0400ED81 RID: 60801
		[Token(Token = "0x400ED81")]
		[FieldOffset(Offset = "0x88")]
		public UILabel SignatureLabel;

		// Token: 0x0400ED82 RID: 60802
		[Token(Token = "0x400ED82")]
		[FieldOffset(Offset = "0x90")]
		public UIToggleButton TagShow;

		// Token: 0x0400ED83 RID: 60803
		[Token(Token = "0x400ED83")]
		[FieldOffset(Offset = "0x98")]
		public GameObject TagShowPanel;

		// Token: 0x0400ED84 RID: 60804
		[Token(Token = "0x400ED84")]
		[FieldOffset(Offset = "0xA0")]
		public UIToggleButton BattleToggleBtn;

		// Token: 0x0400ED85 RID: 60805
		[Token(Token = "0x400ED85")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel BattleLabel1;

		// Token: 0x0400ED86 RID: 60806
		[Token(Token = "0x400ED86")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel BattleTotoalCount;

		// Token: 0x0400ED87 RID: 60807
		[Token(Token = "0x400ED87")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel BattleAcquireConditionsDesc;

		// Token: 0x0400ED88 RID: 60808
		[Token(Token = "0x400ED88")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton LevelReviewTipsBtn;

		// Token: 0x0400ED89 RID: 60809
		[Token(Token = "0x400ED89")]
		[FieldOffset(Offset = "0xC8")]
		public UIGrid Grid;

		// Token: 0x0400ED8A RID: 60810
		[Token(Token = "0x400ED8A")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel LevelConditionNum1;

		// Token: 0x0400ED8B RID: 60811
		[Token(Token = "0x400ED8B")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel LevelConditionNum2;

		// Token: 0x0400ED8C RID: 60812
		[Token(Token = "0x400ED8C")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel LevelConditionNum3;

		// Token: 0x0400ED8D RID: 60813
		[Token(Token = "0x400ED8D")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton BattleConfirmBtn;

		// Token: 0x0400ED8E RID: 60814
		[Token(Token = "0x400ED8E")]
		[FieldOffset(Offset = "0xF0")]
		public UIButton BattleUnConfirmBtn;

		// Token: 0x0400ED8F RID: 60815
		[Token(Token = "0x400ED8F")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject LevelConditionUnLock;

		// Token: 0x0400ED90 RID: 60816
		[Token(Token = "0x400ED90")]
		[FieldOffset(Offset = "0x100")]
		public UIGrid BattleTagGrid;

		// Token: 0x0400ED91 RID: 60817
		[Token(Token = "0x400ED91")]
		[FieldOffset(Offset = "0x108")]
		public UILabel BattleLabel2;

		// Token: 0x0400ED92 RID: 60818
		[Token(Token = "0x400ED92")]
		[FieldOffset(Offset = "0x110")]
		public UIToggleButton SocialToggleBtn;

		// Token: 0x0400ED93 RID: 60819
		[Token(Token = "0x400ED93")]
		[FieldOffset(Offset = "0x118")]
		public UIButton SocialConfirmBtn;

		// Token: 0x0400ED94 RID: 60820
		[Token(Token = "0x400ED94")]
		[FieldOffset(Offset = "0x120")]
		public UILabel SocialDescLabel;

		// Token: 0x0400ED95 RID: 60821
		[Token(Token = "0x400ED95")]
		[FieldOffset(Offset = "0x128")]
		public UIButton SocialUnConfirmBtn;

		// Token: 0x0400ED96 RID: 60822
		[Token(Token = "0x400ED96")]
		[FieldOffset(Offset = "0x130")]
		public UILabel SocialLabel1;

		// Token: 0x0400ED97 RID: 60823
		[Token(Token = "0x400ED97")]
		[FieldOffset(Offset = "0x138")]
		public UIGrid SocialTagGrid;

		// Token: 0x0400ED98 RID: 60824
		[Token(Token = "0x400ED98")]
		[FieldOffset(Offset = "0x140")]
		public UILabel SocialLabel2;

		// Token: 0x0400ED99 RID: 60825
		[Token(Token = "0x400ED99")]
		[FieldOffset(Offset = "0x148")]
		public UIToggleButton PrivateSetting;

		// Token: 0x0400ED9A RID: 60826
		[Token(Token = "0x400ED9A")]
		[FieldOffset(Offset = "0x150")]
		public UIToggleButtonGroup PrivateSettingPanel;

		// Token: 0x0400ED9B RID: 60827
		[Token(Token = "0x400ED9B")]
		[FieldOffset(Offset = "0x158")]
		public UIToggleButton PublicToggle;

		// Token: 0x0400ED9C RID: 60828
		[Token(Token = "0x400ED9C")]
		[FieldOffset(Offset = "0x160")]
		public UIWidget PublicToggleWigit;

		// Token: 0x0400ED9D RID: 60829
		[Token(Token = "0x400ED9D")]
		[FieldOffset(Offset = "0x168")]
		public UIToggleButton PrivateToggle;

		// Token: 0x0400ED9E RID: 60830
		[Token(Token = "0x400ED9E")]
		[FieldOffset(Offset = "0x170")]
		public UIWidget PrivateToggleWigit;
	}
}
