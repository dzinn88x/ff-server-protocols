using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023F8 RID: 9208
	[Token(Token = "0x20023F8")]
	public class UILobbyGroupNewView : UIBaseView
	{
		// Token: 0x0600C300 RID: 49920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C300")]
		[Address(RVA = "0x1538024", Offset = "0x1538024", VA = "0x7BBBD38024", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C301 RID: 49921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C301")]
		[Address(RVA = "0x15392FC", Offset = "0x15392FC", VA = "0x7BBBD392FC")]
		public UILobbyGroupNewView()
		{
		}

		// Token: 0x0400E176 RID: 57718
		[Token(Token = "0x400E176")]
		[FieldOffset(Offset = "0x20")]
		public UIButton OpenBtn;

		// Token: 0x0400E177 RID: 57719
		[Token(Token = "0x400E177")]
		[FieldOffset(Offset = "0x28")]
		public Transform TopRight;

		// Token: 0x0400E178 RID: 57720
		[Token(Token = "0x400E178")]
		[FieldOffset(Offset = "0x30")]
		public GameObject GameVoiceBtnGroup;

		// Token: 0x0400E179 RID: 57721
		[Token(Token = "0x400E179")]
		[FieldOffset(Offset = "0x38")]
		public UIButton MicToggle;

		// Token: 0x0400E17A RID: 57722
		[Token(Token = "0x400E17A")]
		[FieldOffset(Offset = "0x40")]
		public UISprite MicSprite;

		// Token: 0x0400E17B RID: 57723
		[Token(Token = "0x400E17B")]
		[FieldOffset(Offset = "0x48")]
		public UISprite MicMask;

		// Token: 0x0400E17C RID: 57724
		[Token(Token = "0x400E17C")]
		[FieldOffset(Offset = "0x50")]
		public UIButton SpeakerToggle;

		// Token: 0x0400E17D RID: 57725
		[Token(Token = "0x400E17D")]
		[FieldOffset(Offset = "0x58")]
		public UISprite SpeakerSprite;

		// Token: 0x0400E17E RID: 57726
		[Token(Token = "0x400E17E")]
		[FieldOffset(Offset = "0x60")]
		public UISprite SpeakerMask;

		// Token: 0x0400E17F RID: 57727
		[Token(Token = "0x400E17F")]
		[FieldOffset(Offset = "0x68")]
		public UITexture Bg;

		// Token: 0x0400E180 RID: 57728
		[Token(Token = "0x400E180")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BgBtn;

		// Token: 0x0400E181 RID: 57729
		[Token(Token = "0x400E181")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ChampionshipTeamInfo;

		// Token: 0x0400E182 RID: 57730
		[Token(Token = "0x400E182")]
		[FieldOffset(Offset = "0x80")]
		public UILabel TeamName;

		// Token: 0x0400E183 RID: 57731
		[Token(Token = "0x400E183")]
		[FieldOffset(Offset = "0x88")]
		public UILabel TeamScore;

		// Token: 0x0400E184 RID: 57732
		[Token(Token = "0x400E184")]
		[FieldOffset(Offset = "0x90")]
		public Transform GroupCodePivot;

		// Token: 0x0400E185 RID: 57733
		[Token(Token = "0x400E185")]
		[FieldOffset(Offset = "0x98")]
		public GameObject groupCode;

		// Token: 0x0400E186 RID: 57734
		[Token(Token = "0x400E186")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel groupCodeLabel;

		// Token: 0x0400E187 RID: 57735
		[Token(Token = "0x400E187")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel desc;

		// Token: 0x0400E188 RID: 57736
		[Token(Token = "0x400E188")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton groupCodeBtn;

		// Token: 0x0400E189 RID: 57737
		[Token(Token = "0x400E189")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton GroupCodeHelperBtn;

		// Token: 0x0400E18A RID: 57738
		[Token(Token = "0x400E18A")]
		[FieldOffset(Offset = "0xC0")]
		public Transform PublicPivot;

		// Token: 0x0400E18B RID: 57739
		[Token(Token = "0x400E18B")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject PublicRoot;

		// Token: 0x0400E18C RID: 57740
		[Token(Token = "0x400E18C")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton PublicBtn;

		// Token: 0x0400E18D RID: 57741
		[Token(Token = "0x400E18D")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject PublicToggleOn;

		// Token: 0x0400E18E RID: 57742
		[Token(Token = "0x400E18E")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject PublicToggleOff;

		// Token: 0x0400E18F RID: 57743
		[Token(Token = "0x400E18F")]
		[FieldOffset(Offset = "0xE8")]
		public Transform GroupCodePivotLeft;

		// Token: 0x0400E190 RID: 57744
		[Token(Token = "0x400E190")]
		[FieldOffset(Offset = "0xF0")]
		public Transform PublicPivotLeft;

		// Token: 0x0400E191 RID: 57745
		[Token(Token = "0x400E191")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject GroupInviteNode;

		// Token: 0x0400E192 RID: 57746
		[Token(Token = "0x400E192")]
		[FieldOffset(Offset = "0x100")]
		public UIButton ArrowBtn;

		// Token: 0x0400E193 RID: 57747
		[Token(Token = "0x400E193")]
		[FieldOffset(Offset = "0x108")]
		public UISprite friendListArrow;

		// Token: 0x0400E194 RID: 57748
		[Token(Token = "0x400E194")]
		[FieldOffset(Offset = "0x110")]
		public GameObject friends;

		// Token: 0x0400E195 RID: 57749
		[Token(Token = "0x400E195")]
		[FieldOffset(Offset = "0x118")]
		public UIButton refreshBtn;

		// Token: 0x0400E196 RID: 57750
		[Token(Token = "0x400E196")]
		[FieldOffset(Offset = "0x120")]
		public UIInput InputName;

		// Token: 0x0400E197 RID: 57751
		[Token(Token = "0x400E197")]
		[FieldOffset(Offset = "0x128")]
		public UIButton searchBtn;

		// Token: 0x0400E198 RID: 57752
		[Token(Token = "0x400E198")]
		[FieldOffset(Offset = "0x130")]
		public UIScrollView scrollview;

		// Token: 0x0400E199 RID: 57753
		[Token(Token = "0x400E199")]
		[FieldOffset(Offset = "0x138")]
		public UIPanel ScrollPanel;

		// Token: 0x0400E19A RID: 57754
		[Token(Token = "0x400E19A")]
		[FieldOffset(Offset = "0x140")]
		public UIEasyList ListGrid;

		// Token: 0x0400E19B RID: 57755
		[Token(Token = "0x400E19B")]
		[FieldOffset(Offset = "0x148")]
		public UIWrapContent wrapcontent;

		// Token: 0x0400E19C RID: 57756
		[Token(Token = "0x400E19C")]
		[FieldOffset(Offset = "0x150")]
		public UILabel LabelInterAppInvite;

		// Token: 0x0400E19D RID: 57757
		[Token(Token = "0x400E19D")]
		[FieldOffset(Offset = "0x158")]
		public UIGrid GridInterAppInvite;

		// Token: 0x0400E19E RID: 57758
		[Token(Token = "0x400E19E")]
		[FieldOffset(Offset = "0x160")]
		public UIButton BtnLineInvite;

		// Token: 0x0400E19F RID: 57759
		[Token(Token = "0x400E19F")]
		[FieldOffset(Offset = "0x168")]
		public UIButton BtnFBInvite;

		// Token: 0x0400E1A0 RID: 57760
		[Token(Token = "0x400E1A0")]
		[FieldOffset(Offset = "0x170")]
		public UIButton BtnVKInvite;

		// Token: 0x0400E1A1 RID: 57761
		[Token(Token = "0x400E1A1")]
		[FieldOffset(Offset = "0x178")]
		public UIButton BtnOtherInvite;

		// Token: 0x0400E1A2 RID: 57762
		[Token(Token = "0x400E1A2")]
		[FieldOffset(Offset = "0x180")]
		public UIButton BtnJoin;

		// Token: 0x0400E1A3 RID: 57763
		[Token(Token = "0x400E1A3")]
		[FieldOffset(Offset = "0x188")]
		public UILabel NumCnt;

		// Token: 0x0400E1A4 RID: 57764
		[Token(Token = "0x400E1A4")]
		[FieldOffset(Offset = "0x190")]
		public UITable TabTable;

		// Token: 0x0400E1A5 RID: 57765
		[Token(Token = "0x400E1A5")]
		[FieldOffset(Offset = "0x198")]
		public GameObject FriendTab;

		// Token: 0x0400E1A6 RID: 57766
		[Token(Token = "0x400E1A6")]
		[FieldOffset(Offset = "0x1A0")]
		public UIToggleButton FriendToggleBtn;

		// Token: 0x0400E1A7 RID: 57767
		[Token(Token = "0x400E1A7")]
		[FieldOffset(Offset = "0x1A8")]
		public GameObject ClanTab;

		// Token: 0x0400E1A8 RID: 57768
		[Token(Token = "0x400E1A8")]
		[FieldOffset(Offset = "0x1B0")]
		public UIToggleButton ClanToggleBtn;

		// Token: 0x0400E1A9 RID: 57769
		[Token(Token = "0x400E1A9")]
		[FieldOffset(Offset = "0x1B8")]
		public Transform pveMapInfo;

		// Token: 0x0400E1AA RID: 57770
		[Token(Token = "0x400E1AA")]
		[FieldOffset(Offset = "0x1C0")]
		public Transform pveWeaponInfo;

		// Token: 0x0400E1AB RID: 57771
		[Token(Token = "0x400E1AB")]
		[FieldOffset(Offset = "0x1C8")]
		public UIAnchor leaveBtnContainer;

		// Token: 0x0400E1AC RID: 57772
		[Token(Token = "0x400E1AC")]
		[FieldOffset(Offset = "0x1D0")]
		public UIButton leaveBtn;

		// Token: 0x0400E1AD RID: 57773
		[Token(Token = "0x400E1AD")]
		[FieldOffset(Offset = "0x1D8")]
		public GameObject autoMatch;

		// Token: 0x0400E1AE RID: 57774
		[Token(Token = "0x400E1AE")]
		[FieldOffset(Offset = "0x1E0")]
		public TweenPosition AutoMatchTween;

		// Token: 0x0400E1AF RID: 57775
		[Token(Token = "0x400E1AF")]
		[FieldOffset(Offset = "0x1E8")]
		public UIToggle checkBtn;

		// Token: 0x0400E1B0 RID: 57776
		[Token(Token = "0x400E1B0")]
		[FieldOffset(Offset = "0x1F0")]
		public GameObject checkBtnBgNormal;

		// Token: 0x0400E1B1 RID: 57777
		[Token(Token = "0x400E1B1")]
		[FieldOffset(Offset = "0x1F8")]
		public GameObject checkBtnBgDisabled;

		// Token: 0x0400E1B2 RID: 57778
		[Token(Token = "0x400E1B2")]
		[FieldOffset(Offset = "0x200")]
		public GameObject fakeOn;

		// Token: 0x0400E1B3 RID: 57779
		[Token(Token = "0x400E1B3")]
		[FieldOffset(Offset = "0x208")]
		public UIButton readyBtn;

		// Token: 0x0400E1B4 RID: 57780
		[Token(Token = "0x400E1B4")]
		[FieldOffset(Offset = "0x210")]
		public UILabel readyLabel;

		// Token: 0x0400E1B5 RID: 57781
		[Token(Token = "0x400E1B5")]
		[FieldOffset(Offset = "0x218")]
		public GameObject Ready;

		// Token: 0x0400E1B6 RID: 57782
		[Token(Token = "0x400E1B6")]
		[FieldOffset(Offset = "0x220")]
		public GameObject CancelReady;

		// Token: 0x0400E1B7 RID: 57783
		[Token(Token = "0x400E1B7")]
		[FieldOffset(Offset = "0x228")]
		public UISprite readyBtnSprite;

		// Token: 0x0400E1B8 RID: 57784
		[Token(Token = "0x400E1B8")]
		[FieldOffset(Offset = "0x230")]
		public UIButton playBtn;

		// Token: 0x0400E1B9 RID: 57785
		[Token(Token = "0x400E1B9")]
		[FieldOffset(Offset = "0x238")]
		public UIWidget StartGameWidget;

		// Token: 0x0400E1BA RID: 57786
		[Token(Token = "0x400E1BA")]
		[FieldOffset(Offset = "0x240")]
		public UILabel StartLabel;

		// Token: 0x0400E1BB RID: 57787
		[Token(Token = "0x400E1BB")]
		[FieldOffset(Offset = "0x248")]
		public UISprite AllReadySprite;

		// Token: 0x0400E1BC RID: 57788
		[Token(Token = "0x400E1BC")]
		[FieldOffset(Offset = "0x250")]
		public UISprite NotReadySprite;

		// Token: 0x0400E1BD RID: 57789
		[Token(Token = "0x400E1BD")]
		[FieldOffset(Offset = "0x258")]
		public GameObject Guide_start_Anim;

		// Token: 0x0400E1BE RID: 57790
		[Token(Token = "0x400E1BE")]
		[FieldOffset(Offset = "0x260")]
		public Transform BonusInfoAttachPoint;

		// Token: 0x0400E1BF RID: 57791
		[Token(Token = "0x400E1BF")]
		[FieldOffset(Offset = "0x268")]
		public GameObject championshipInfo;

		// Token: 0x0400E1C0 RID: 57792
		[Token(Token = "0x400E1C0")]
		[FieldOffset(Offset = "0x270")]
		public UIButton TicketBtn;

		// Token: 0x0400E1C1 RID: 57793
		[Token(Token = "0x400E1C1")]
		[FieldOffset(Offset = "0x278")]
		public UISprite ItemIcon;

		// Token: 0x0400E1C2 RID: 57794
		[Token(Token = "0x400E1C2")]
		[FieldOffset(Offset = "0x280")]
		public UILabel TicketNum;

		// Token: 0x0400E1C3 RID: 57795
		[Token(Token = "0x400E1C3")]
		[FieldOffset(Offset = "0x288")]
		public GameObject OpenTime;

		// Token: 0x0400E1C4 RID: 57796
		[Token(Token = "0x400E1C4")]
		[FieldOffset(Offset = "0x290")]
		public UILabel OpenTimeLabel;

		// Token: 0x0400E1C5 RID: 57797
		[Token(Token = "0x400E1C5")]
		[FieldOffset(Offset = "0x298")]
		public GameObject LadderTitle;

		// Token: 0x0400E1C6 RID: 57798
		[Token(Token = "0x400E1C6")]
		[FieldOffset(Offset = "0x2A0")]
		public GameObject ReadyEffect;

		// Token: 0x0400E1C7 RID: 57799
		[Token(Token = "0x400E1C7")]
		[FieldOffset(Offset = "0x2A8")]
		public GameObject MatchMaking;
	}
}
