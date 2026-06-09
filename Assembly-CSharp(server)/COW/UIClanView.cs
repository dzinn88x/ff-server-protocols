using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002171 RID: 8561
	[Token(Token = "0x2002171")]
	public class UIClanView : UIBaseView
	{
		// Token: 0x0600BDF2 RID: 48626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDF2")]
		[Address(RVA = "0x1D05CFC", Offset = "0x1D05CFC", VA = "0x7BBC505CFC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDF3 RID: 48627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDF3")]
		[Address(RVA = "0x1D06978", Offset = "0x1D06978", VA = "0x7BBC506978")]
		public UIClanView()
		{
		}

		// Token: 0x0400C66B RID: 50795
		[Token(Token = "0x400C66B")]
		[FieldOffset(Offset = "0x20")]
		public TweenScale TweenScale;

		// Token: 0x0400C66C RID: 50796
		[Token(Token = "0x400C66C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Content;

		// Token: 0x0400C66D RID: 50797
		[Token(Token = "0x400C66D")]
		[FieldOffset(Offset = "0x30")]
		public Transform CountdownTime;

		// Token: 0x0400C66E RID: 50798
		[Token(Token = "0x400C66E")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid BottomRightGrid;

		// Token: 0x0400C66F RID: 50799
		[Token(Token = "0x400C66F")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnApplyDeputyCaptain;

		// Token: 0x0400C670 RID: 50800
		[Token(Token = "0x400C670")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnLuckyBag;

		// Token: 0x0400C671 RID: 50801
		[Token(Token = "0x400C671")]
		[FieldOffset(Offset = "0x50")]
		public UIWidget LuckyBagWidget;

		// Token: 0x0400C672 RID: 50802
		[Token(Token = "0x400C672")]
		[FieldOffset(Offset = "0x58")]
		public Animator LuckyBagAnimator;

		// Token: 0x0400C673 RID: 50803
		[Token(Token = "0x400C673")]
		[FieldOffset(Offset = "0x60")]
		public UIButton CheckInBtn;

		// Token: 0x0400C674 RID: 50804
		[Token(Token = "0x400C674")]
		[FieldOffset(Offset = "0x68")]
		public Animator ClanSigninAnimator;

		// Token: 0x0400C675 RID: 50805
		[Token(Token = "0x400C675")]
		[FieldOffset(Offset = "0x70")]
		public Transform LeftTabContainer;

		// Token: 0x0400C676 RID: 50806
		[Token(Token = "0x400C676")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BtnStore;

		// Token: 0x0400C677 RID: 50807
		[Token(Token = "0x400C677")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnRankList;

		// Token: 0x0400C678 RID: 50808
		[Token(Token = "0x400C678")]
		[FieldOffset(Offset = "0x88")]
		public GameObject RaceOpenIcon;

		// Token: 0x0400C679 RID: 50809
		[Token(Token = "0x400C679")]
		[FieldOffset(Offset = "0x90")]
		public GameObject DetailContent;

		// Token: 0x0400C67A RID: 50810
		[Token(Token = "0x400C67A")]
		[FieldOffset(Offset = "0x98")]
		public UIButton BtnShare;

		// Token: 0x0400C67B RID: 50811
		[Token(Token = "0x400C67B")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton BtnRule;

		// Token: 0x0400C67C RID: 50812
		[Token(Token = "0x400C67C")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton BtnSetting;

		// Token: 0x0400C67D RID: 50813
		[Token(Token = "0x400C67D")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel LabelClanName;

		// Token: 0x0400C67E RID: 50814
		[Token(Token = "0x400C67E")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton BtnEditName;

		// Token: 0x0400C67F RID: 50815
		[Token(Token = "0x400C67F")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton DetailBtn;

		// Token: 0x0400C680 RID: 50816
		[Token(Token = "0x400C680")]
		[FieldOffset(Offset = "0xC8")]
		public UIInput InputClanSlogan;

		// Token: 0x0400C681 RID: 50817
		[Token(Token = "0x400C681")]
		[FieldOffset(Offset = "0xD0")]
		public BoxCollider InputClanSloganCollider;

		// Token: 0x0400C682 RID: 50818
		[Token(Token = "0x400C682")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton BtnEditSlogan;

		// Token: 0x0400C683 RID: 50819
		[Token(Token = "0x400C683")]
		[FieldOffset(Offset = "0xE0")]
		public UIInput InputClanAnnouncement;

		// Token: 0x0400C684 RID: 50820
		[Token(Token = "0x400C684")]
		[FieldOffset(Offset = "0xE8")]
		public BoxCollider InputClanAnnouncementCollider;

		// Token: 0x0400C685 RID: 50821
		[Token(Token = "0x400C685")]
		[FieldOffset(Offset = "0xF0")]
		public UIButton BtnEditAnnouncement;

		// Token: 0x0400C686 RID: 50822
		[Token(Token = "0x400C686")]
		[FieldOffset(Offset = "0xF8")]
		public UISprite CurLevelIcon;

		// Token: 0x0400C687 RID: 50823
		[Token(Token = "0x400C687")]
		[FieldOffset(Offset = "0x100")]
		public UILabel LevelLabel;

		// Token: 0x0400C688 RID: 50824
		[Token(Token = "0x400C688")]
		[FieldOffset(Offset = "0x108")]
		public UIProgressBar ProgressBar;

		// Token: 0x0400C689 RID: 50825
		[Token(Token = "0x400C689")]
		[FieldOffset(Offset = "0x110")]
		public UILabel TotalProgress;

		// Token: 0x0400C68A RID: 50826
		[Token(Token = "0x400C68A")]
		[FieldOffset(Offset = "0x118")]
		public GameObject DetailRightAnchor;

		// Token: 0x0400C68B RID: 50827
		[Token(Token = "0x400C68B")]
		[FieldOffset(Offset = "0x120")]
		public UIToggle ToggleChatTab;

		// Token: 0x0400C68C RID: 50828
		[Token(Token = "0x400C68C")]
		[FieldOffset(Offset = "0x128")]
		public UIToggle ToggleLogTab;

		// Token: 0x0400C68D RID: 50829
		[Token(Token = "0x400C68D")]
		[FieldOffset(Offset = "0x130")]
		public GameObject MemberContent;

		// Token: 0x0400C68E RID: 50830
		[Token(Token = "0x400C68E")]
		[FieldOffset(Offset = "0x138")]
		public UISprite TailArrow;

		// Token: 0x0400C68F RID: 50831
		[Token(Token = "0x400C68F")]
		[FieldOffset(Offset = "0x140")]
		public GameObject TitleBar;

		// Token: 0x0400C690 RID: 50832
		[Token(Token = "0x400C690")]
		[FieldOffset(Offset = "0x148")]
		public UIScrollView ListScrollView_List;

		// Token: 0x0400C691 RID: 50833
		[Token(Token = "0x400C691")]
		[FieldOffset(Offset = "0x150")]
		public UIEasyList ListGrid_List;

		// Token: 0x0400C692 RID: 50834
		[Token(Token = "0x400C692")]
		[FieldOffset(Offset = "0x158")]
		public UILabel LabelOnlineNum;

		// Token: 0x0400C693 RID: 50835
		[Token(Token = "0x400C693")]
		[FieldOffset(Offset = "0x160")]
		public UILabel LabelTotalNum;

		// Token: 0x0400C694 RID: 50836
		[Token(Token = "0x400C694")]
		[FieldOffset(Offset = "0x168")]
		public UILabel LabelClanMaxNum;

		// Token: 0x0400C695 RID: 50837
		[Token(Token = "0x400C695")]
		[FieldOffset(Offset = "0x170")]
		public UIGrid BtnGrid;

		// Token: 0x0400C696 RID: 50838
		[Token(Token = "0x400C696")]
		[FieldOffset(Offset = "0x178")]
		public UIButton BtnApply;

		// Token: 0x0400C697 RID: 50839
		[Token(Token = "0x400C697")]
		[FieldOffset(Offset = "0x180")]
		public UIButton BtnRecruit;

		// Token: 0x0400C698 RID: 50840
		[Token(Token = "0x400C698")]
		[FieldOffset(Offset = "0x188")]
		public UIButton BtnAddFriend;

		// Token: 0x0400C699 RID: 50841
		[Token(Token = "0x400C699")]
		[FieldOffset(Offset = "0x190")]
		public UIButton BtnExtend;

		// Token: 0x0400C69A RID: 50842
		[Token(Token = "0x400C69A")]
		[FieldOffset(Offset = "0x198")]
		public UIButton BtnDismissClan;

		// Token: 0x0400C69B RID: 50843
		[Token(Token = "0x400C69B")]
		[FieldOffset(Offset = "0x1A0")]
		public UIButton BtnLeaveClan;

		// Token: 0x0400C69C RID: 50844
		[Token(Token = "0x400C69C")]
		[FieldOffset(Offset = "0x1A8")]
		public GameObject RaceContent;

		// Token: 0x0400C69D RID: 50845
		[Token(Token = "0x400C69D")]
		[FieldOffset(Offset = "0x1B0")]
		public GameObject TimeBG;

		// Token: 0x0400C69E RID: 50846
		[Token(Token = "0x400C69E")]
		[FieldOffset(Offset = "0x1B8")]
		public UICountDownLabel TimeLabel;
	}
}
