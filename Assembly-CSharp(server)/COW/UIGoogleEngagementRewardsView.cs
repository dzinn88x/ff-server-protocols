using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002247 RID: 8775
	[Token(Token = "0x2002247")]
	internal class UIGoogleEngagementRewardsView : UIBaseView
	{
		// Token: 0x0600BF9F RID: 49055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF9F")]
		[Address(RVA = "0x1A85DB8", Offset = "0x1A85DB8", VA = "0x7BBC285DB8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFA0 RID: 49056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA0")]
		[Address(RVA = "0x1A865D0", Offset = "0x1A865D0", VA = "0x7BBC2865D0")]
		public UIGoogleEngagementRewardsView()
		{
		}

		// Token: 0x0400D23C RID: 53820
		[Token(Token = "0x400D23C")]
		[FieldOffset(Offset = "0x20")]
		public UISprite mask;

		// Token: 0x0400D23D RID: 53821
		[Token(Token = "0x400D23D")]
		[FieldOffset(Offset = "0x28")]
		public UILabel LabelTermsOfService;

		// Token: 0x0400D23E RID: 53822
		[Token(Token = "0x400D23E")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnTermsOfService;

		// Token: 0x0400D23F RID: 53823
		[Token(Token = "0x400D23F")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelHelpAndSupport;

		// Token: 0x0400D240 RID: 53824
		[Token(Token = "0x400D240")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnHelpAndSupport;

		// Token: 0x0400D241 RID: 53825
		[Token(Token = "0x400D241")]
		[FieldOffset(Offset = "0x48")]
		public GameObject GotRewardUI;

		// Token: 0x0400D242 RID: 53826
		[Token(Token = "0x400D242")]
		[FieldOffset(Offset = "0x50")]
		public GameObject FirstTimeUI;

		// Token: 0x0400D243 RID: 53827
		[Token(Token = "0x400D243")]
		[FieldOffset(Offset = "0x58")]
		public UIButton FirstTimeBtn;

		// Token: 0x0400D244 RID: 53828
		[Token(Token = "0x400D244")]
		[FieldOffset(Offset = "0x60")]
		public GameObject RewardsUI;

		// Token: 0x0400D245 RID: 53829
		[Token(Token = "0x400D245")]
		[FieldOffset(Offset = "0x68")]
		public UIButton GoogleAccountBtn;

		// Token: 0x0400D246 RID: 53830
		[Token(Token = "0x400D246")]
		[FieldOffset(Offset = "0x70")]
		public UILabel GoogleAccountBtnLabel;

		// Token: 0x0400D247 RID: 53831
		[Token(Token = "0x400D247")]
		[FieldOffset(Offset = "0x78")]
		public UILabel ActionDescLabel;

		// Token: 0x0400D248 RID: 53832
		[Token(Token = "0x400D248")]
		[FieldOffset(Offset = "0x80")]
		public UILabel RewardDescLabel;

		// Token: 0x0400D249 RID: 53833
		[Token(Token = "0x400D249")]
		[FieldOffset(Offset = "0x88")]
		public UILabel DisclaimerLabel;

		// Token: 0x0400D24A RID: 53834
		[Token(Token = "0x400D24A")]
		[FieldOffset(Offset = "0x90")]
		public UILabel AccountNameLabel;

		// Token: 0x0400D24B RID: 53835
		[Token(Token = "0x400D24B")]
		[FieldOffset(Offset = "0x98")]
		public GameObject GoogleAccountsUI;

		// Token: 0x0400D24C RID: 53836
		[Token(Token = "0x400D24C")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton SelectedAccountBtn;

		// Token: 0x0400D24D RID: 53837
		[Token(Token = "0x400D24D")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel SelectedAccountLabel;

		// Token: 0x0400D24E RID: 53838
		[Token(Token = "0x400D24E")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite AccountsScrollViewBg;

		// Token: 0x0400D24F RID: 53839
		[Token(Token = "0x400D24F")]
		[FieldOffset(Offset = "0xB8")]
		public UIScrollView AccountsScrollView;

		// Token: 0x0400D250 RID: 53840
		[Token(Token = "0x400D250")]
		[FieldOffset(Offset = "0xC0")]
		public UITable AccountsTable;

		// Token: 0x0400D251 RID: 53841
		[Token(Token = "0x400D251")]
		[FieldOffset(Offset = "0xC8")]
		public UIWidget PermissionButtons;

		// Token: 0x0400D252 RID: 53842
		[Token(Token = "0x400D252")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton NotNowBtn;

		// Token: 0x0400D253 RID: 53843
		[Token(Token = "0x400D253")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel NotNowBtnLabel;

		// Token: 0x0400D254 RID: 53844
		[Token(Token = "0x400D254")]
		[FieldOffset(Offset = "0xE0")]
		public UIButton AgreeBtn;

		// Token: 0x0400D255 RID: 53845
		[Token(Token = "0x400D255")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel AgreeBtnLabel;

		// Token: 0x0400D256 RID: 53846
		[Token(Token = "0x400D256")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel GoogleEngagementRewardsLabel;

		// Token: 0x0400D257 RID: 53847
		[Token(Token = "0x400D257")]
		[FieldOffset(Offset = "0xF8")]
		public UIWidget LoginButtons;

		// Token: 0x0400D258 RID: 53848
		[Token(Token = "0x400D258")]
		[FieldOffset(Offset = "0x100")]
		public UIButton LoginBtn;

		// Token: 0x0400D259 RID: 53849
		[Token(Token = "0x400D259")]
		[FieldOffset(Offset = "0x108")]
		public UILabel LoginBtnLabel;

		// Token: 0x0400D25A RID: 53850
		[Token(Token = "0x400D25A")]
		[FieldOffset(Offset = "0x110")]
		public UILabel NativeLoginLabel;

		// Token: 0x0400D25B RID: 53851
		[Token(Token = "0x400D25B")]
		[FieldOffset(Offset = "0x118")]
		public UIButton NativeLoginBtn;

		// Token: 0x0400D25C RID: 53852
		[Token(Token = "0x400D25C")]
		[FieldOffset(Offset = "0x120")]
		public UILabel TitleLabel;

		// Token: 0x0400D25D RID: 53853
		[Token(Token = "0x400D25D")]
		[FieldOffset(Offset = "0x128")]
		public UIButton BtnClose;
	}
}
