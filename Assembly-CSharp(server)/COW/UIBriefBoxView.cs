using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002123 RID: 8483
	[Token(Token = "0x2002123")]
	public class UIBriefBoxView : UIBaseView
	{
		// Token: 0x0600BD56 RID: 48470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD56")]
		[Address(RVA = "0x1C1A194", Offset = "0x1C1A194", VA = "0x7BBC41A194", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD57 RID: 48471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD57")]
		[Address(RVA = "0x1C1B534", Offset = "0x1C1B534", VA = "0x7BBC41B534")]
		public UIBriefBoxView()
		{
		}

		// Token: 0x0400C29D RID: 49821
		[Token(Token = "0x400C29D")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel WindowPanel;

		// Token: 0x0400C29E RID: 49822
		[Token(Token = "0x400C29E")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget Container;

		// Token: 0x0400C29F RID: 49823
		[Token(Token = "0x400C29F")]
		[FieldOffset(Offset = "0x30")]
		public Transform ProfileContainer;

		// Token: 0x0400C2A0 RID: 49824
		[Token(Token = "0x400C2A0")]
		[FieldOffset(Offset = "0x38")]
		public Transform ProfilePivot;

		// Token: 0x0400C2A1 RID: 49825
		[Token(Token = "0x400C2A1")]
		[FieldOffset(Offset = "0x40")]
		public UISprite LanguageSprite;

		// Token: 0x0400C2A2 RID: 49826
		[Token(Token = "0x400C2A2")]
		[FieldOffset(Offset = "0x48")]
		public MinWidgetTableItem MinWidget;

		// Token: 0x0400C2A3 RID: 49827
		[Token(Token = "0x400C2A3")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ScrollViewRoot;

		// Token: 0x0400C2A4 RID: 49828
		[Token(Token = "0x400C2A4")]
		[FieldOffset(Offset = "0x58")]
		public UIScrollView ScrollView;

		// Token: 0x0400C2A5 RID: 49829
		[Token(Token = "0x400C2A5")]
		[FieldOffset(Offset = "0x60")]
		public LayoutTable Other;

		// Token: 0x0400C2A6 RID: 49830
		[Token(Token = "0x400C2A6")]
		[FieldOffset(Offset = "0x68")]
		public Transform Rank;

		// Token: 0x0400C2A7 RID: 49831
		[Token(Token = "0x400C2A7")]
		[FieldOffset(Offset = "0x70")]
		public GameObject SeaSonBrContainer;

		// Token: 0x0400C2A8 RID: 49832
		[Token(Token = "0x400C2A8")]
		[FieldOffset(Offset = "0x78")]
		public GameObject SeaSonCsContainer;

		// Token: 0x0400C2A9 RID: 49833
		[Token(Token = "0x400C2A9")]
		[FieldOffset(Offset = "0x80")]
		public GameObject SeaSonCsCoontainer;

		// Token: 0x0400C2AA RID: 49834
		[Token(Token = "0x400C2AA")]
		[FieldOffset(Offset = "0x88")]
		public UILabel PersonSeaSonDesNowCS;

		// Token: 0x0400C2AB RID: 49835
		[Token(Token = "0x400C2AB")]
		[FieldOffset(Offset = "0x90")]
		public UILabel PersonSeaSonDesNowCS_S;

		// Token: 0x0400C2AC RID: 49836
		[Token(Token = "0x400C2AC")]
		[FieldOffset(Offset = "0x98")]
		public GameObject PersonSeaHistoryBRRoot;

		// Token: 0x0400C2AD RID: 49837
		[Token(Token = "0x400C2AD")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel PersonSeaSonDesHistoryCS;

		// Token: 0x0400C2AE RID: 49838
		[Token(Token = "0x400C2AE")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite PersonRankIconHistoryCS;

		// Token: 0x0400C2AF RID: 49839
		[Token(Token = "0x400C2AF")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject PersonHeroicMarkCSRoot;

		// Token: 0x0400C2B0 RID: 49840
		[Token(Token = "0x400C2B0")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton CSNotObtainedIconBth;

		// Token: 0x0400C2B1 RID: 49841
		[Token(Token = "0x400C2B1")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite HeroicMarkCSIcon;

		// Token: 0x0400C2B2 RID: 49842
		[Token(Token = "0x400C2B2")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton HeroicMarkCSIconBtn;

		// Token: 0x0400C2B3 RID: 49843
		[Token(Token = "0x400C2B3")]
		[FieldOffset(Offset = "0xD0")]
		public Transform HeroicCSEffect;

		// Token: 0x0400C2B4 RID: 49844
		[Token(Token = "0x400C2B4")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel PersonSeaSonRankNameCS;

		// Token: 0x0400C2B5 RID: 49845
		[Token(Token = "0x400C2B5")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel PersonSeaSonRankNameHistoryCS;

		// Token: 0x0400C2B6 RID: 49846
		[Token(Token = "0x400C2B6")]
		[FieldOffset(Offset = "0xE8")]
		public UISprite PersonRankIconCS;

		// Token: 0x0400C2B7 RID: 49847
		[Token(Token = "0x400C2B7")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject StarIcon;

		// Token: 0x0400C2B8 RID: 49848
		[Token(Token = "0x400C2B8")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel NowMaxRankTxt;

		// Token: 0x0400C2B9 RID: 49849
		[Token(Token = "0x400C2B9")]
		[FieldOffset(Offset = "0x100")]
		public UIGrid NowCSGrid;

		// Token: 0x0400C2BA RID: 49850
		[Token(Token = "0x400C2BA")]
		[FieldOffset(Offset = "0x108")]
		public GameObject nowstar1;

		// Token: 0x0400C2BB RID: 49851
		[Token(Token = "0x400C2BB")]
		[FieldOffset(Offset = "0x110")]
		public GameObject nowstar2;

		// Token: 0x0400C2BC RID: 49852
		[Token(Token = "0x400C2BC")]
		[FieldOffset(Offset = "0x118")]
		public GameObject nowstar3;

		// Token: 0x0400C2BD RID: 49853
		[Token(Token = "0x400C2BD")]
		[FieldOffset(Offset = "0x120")]
		public GameObject nowstar4;

		// Token: 0x0400C2BE RID: 49854
		[Token(Token = "0x400C2BE")]
		[FieldOffset(Offset = "0x128")]
		public GameObject nowstar5;

		// Token: 0x0400C2BF RID: 49855
		[Token(Token = "0x400C2BF")]
		[FieldOffset(Offset = "0x130")]
		public GameObject nowblackstar1;

		// Token: 0x0400C2C0 RID: 49856
		[Token(Token = "0x400C2C0")]
		[FieldOffset(Offset = "0x138")]
		public GameObject nowblackstar2;

		// Token: 0x0400C2C1 RID: 49857
		[Token(Token = "0x400C2C1")]
		[FieldOffset(Offset = "0x140")]
		public GameObject nowblackstar3;

		// Token: 0x0400C2C2 RID: 49858
		[Token(Token = "0x400C2C2")]
		[FieldOffset(Offset = "0x148")]
		public GameObject nowblackstar4;

		// Token: 0x0400C2C3 RID: 49859
		[Token(Token = "0x400C2C3")]
		[FieldOffset(Offset = "0x150")]
		public GameObject nowblackstar5;

		// Token: 0x0400C2C4 RID: 49860
		[Token(Token = "0x400C2C4")]
		[FieldOffset(Offset = "0x158")]
		public UILabel HistoryMaxRankTxt;

		// Token: 0x0400C2C5 RID: 49861
		[Token(Token = "0x400C2C5")]
		[FieldOffset(Offset = "0x160")]
		public UIGrid HistoryCsGrid;

		// Token: 0x0400C2C6 RID: 49862
		[Token(Token = "0x400C2C6")]
		[FieldOffset(Offset = "0x168")]
		public GameObject Historystar1;

		// Token: 0x0400C2C7 RID: 49863
		[Token(Token = "0x400C2C7")]
		[FieldOffset(Offset = "0x170")]
		public GameObject Historystar2;

		// Token: 0x0400C2C8 RID: 49864
		[Token(Token = "0x400C2C8")]
		[FieldOffset(Offset = "0x178")]
		public GameObject Historystar3;

		// Token: 0x0400C2C9 RID: 49865
		[Token(Token = "0x400C2C9")]
		[FieldOffset(Offset = "0x180")]
		public GameObject Historystar4;

		// Token: 0x0400C2CA RID: 49866
		[Token(Token = "0x400C2CA")]
		[FieldOffset(Offset = "0x188")]
		public GameObject Historystar5;

		// Token: 0x0400C2CB RID: 49867
		[Token(Token = "0x400C2CB")]
		[FieldOffset(Offset = "0x190")]
		public GameObject Historyblackstar1;

		// Token: 0x0400C2CC RID: 49868
		[Token(Token = "0x400C2CC")]
		[FieldOffset(Offset = "0x198")]
		public GameObject Historyblackstar2;

		// Token: 0x0400C2CD RID: 49869
		[Token(Token = "0x400C2CD")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject Historyblackstar3;

		// Token: 0x0400C2CE RID: 49870
		[Token(Token = "0x400C2CE")]
		[FieldOffset(Offset = "0x1A8")]
		public GameObject Historyblackstar4;

		// Token: 0x0400C2CF RID: 49871
		[Token(Token = "0x400C2CF")]
		[FieldOffset(Offset = "0x1B0")]
		public GameObject Historyblackstar5;

		// Token: 0x0400C2D0 RID: 49872
		[Token(Token = "0x400C2D0")]
		[FieldOffset(Offset = "0x1B8")]
		public GameObject SeaSonBrCootainer;

		// Token: 0x0400C2D1 RID: 49873
		[Token(Token = "0x400C2D1")]
		[FieldOffset(Offset = "0x1C0")]
		public UILabel PersonSeaSonDesNow;

		// Token: 0x0400C2D2 RID: 49874
		[Token(Token = "0x400C2D2")]
		[FieldOffset(Offset = "0x1C8")]
		public UILabel PersonSeaSonDesNow_S;

		// Token: 0x0400C2D3 RID: 49875
		[Token(Token = "0x400C2D3")]
		[FieldOffset(Offset = "0x1D0")]
		public GameObject PersonSeaSonBRRoot;

		// Token: 0x0400C2D4 RID: 49876
		[Token(Token = "0x400C2D4")]
		[FieldOffset(Offset = "0x1D8")]
		public UILabel PersonSeaSonDesHistory;

		// Token: 0x0400C2D5 RID: 49877
		[Token(Token = "0x400C2D5")]
		[FieldOffset(Offset = "0x1E0")]
		public UISprite PersonRankIconHistory;

		// Token: 0x0400C2D6 RID: 49878
		[Token(Token = "0x400C2D6")]
		[FieldOffset(Offset = "0x1E8")]
		public GameObject PersonHeroicMarkBRRoot;

		// Token: 0x0400C2D7 RID: 49879
		[Token(Token = "0x400C2D7")]
		[FieldOffset(Offset = "0x1F0")]
		public UIButton BRNotObtainedIconBth;

		// Token: 0x0400C2D8 RID: 49880
		[Token(Token = "0x400C2D8")]
		[FieldOffset(Offset = "0x1F8")]
		public UISprite HeroicMarkBRIcon;

		// Token: 0x0400C2D9 RID: 49881
		[Token(Token = "0x400C2D9")]
		[FieldOffset(Offset = "0x200")]
		public UIButton HeroicMarkBRIconBtn;

		// Token: 0x0400C2DA RID: 49882
		[Token(Token = "0x400C2DA")]
		[FieldOffset(Offset = "0x208")]
		public Transform HeroicBREffect;

		// Token: 0x0400C2DB RID: 49883
		[Token(Token = "0x400C2DB")]
		[FieldOffset(Offset = "0x210")]
		public UILabel PersonSeaSonRankName;

		// Token: 0x0400C2DC RID: 49884
		[Token(Token = "0x400C2DC")]
		[FieldOffset(Offset = "0x218")]
		public UILabel PersonSeaSonRankNameHistory;

		// Token: 0x0400C2DD RID: 49885
		[Token(Token = "0x400C2DD")]
		[FieldOffset(Offset = "0x220")]
		public UISprite PersonRankIcon;

		// Token: 0x0400C2DE RID: 49886
		[Token(Token = "0x400C2DE")]
		[FieldOffset(Offset = "0x228")]
		public UILabel PersonSeaSonRankPoint;

		// Token: 0x0400C2DF RID: 49887
		[Token(Token = "0x400C2DF")]
		[FieldOffset(Offset = "0x230")]
		public UILabel PersonSeaSonHistoryRankPoint;

		// Token: 0x0400C2E0 RID: 49888
		[Token(Token = "0x400C2E0")]
		[FieldOffset(Offset = "0x238")]
		public GameObject HeroicLeveContainer;

		// Token: 0x0400C2E1 RID: 49889
		[Token(Token = "0x400C2E1")]
		[FieldOffset(Offset = "0x240")]
		public UILadderMatchHeroicLevelView HeroicLevelView;

		// Token: 0x0400C2E2 RID: 49890
		[Token(Token = "0x400C2E2")]
		[FieldOffset(Offset = "0x248")]
		public GameObject HeroicLeveContainerMax;

		// Token: 0x0400C2E3 RID: 49891
		[Token(Token = "0x400C2E3")]
		[FieldOffset(Offset = "0x250")]
		public UILadderMatchHeroicLevelView HeroicLevelViewMax;

		// Token: 0x0400C2E4 RID: 49892
		[Token(Token = "0x400C2E4")]
		[FieldOffset(Offset = "0x258")]
		public Transform Tag;

		// Token: 0x0400C2E5 RID: 49893
		[Token(Token = "0x400C2E5")]
		[FieldOffset(Offset = "0x260")]
		public UIGrid TagGrid;

		// Token: 0x0400C2E6 RID: 49894
		[Token(Token = "0x400C2E6")]
		[FieldOffset(Offset = "0x268")]
		public ProfileTagView ProfileItem;

		// Token: 0x0400C2E7 RID: 49895
		[Token(Token = "0x400C2E7")]
		[FieldOffset(Offset = "0x270")]
		public Transform SocialTag;

		// Token: 0x0400C2E8 RID: 49896
		[Token(Token = "0x400C2E8")]
		[FieldOffset(Offset = "0x278")]
		public UIGrid SocialTagGrid;

		// Token: 0x0400C2E9 RID: 49897
		[Token(Token = "0x400C2E9")]
		[FieldOffset(Offset = "0x280")]
		public ProfileTagView SocialProfileItem;

		// Token: 0x0400C2EA RID: 49898
		[Token(Token = "0x400C2EA")]
		[FieldOffset(Offset = "0x288")]
		public GameObject LineBG02;

		// Token: 0x0400C2EB RID: 49899
		[Token(Token = "0x400C2EB")]
		[FieldOffset(Offset = "0x290")]
		public Transform Desc;

		// Token: 0x0400C2EC RID: 49900
		[Token(Token = "0x400C2EC")]
		[FieldOffset(Offset = "0x298")]
		public UILabel DescLabel;

		// Token: 0x0400C2ED RID: 49901
		[Token(Token = "0x400C2ED")]
		[FieldOffset(Offset = "0x2A0")]
		public UIGrid ItemGrid;

		// Token: 0x0400C2EE RID: 49902
		[Token(Token = "0x400C2EE")]
		[FieldOffset(Offset = "0x2A8")]
		public GameObject Report;

		// Token: 0x0400C2EF RID: 49903
		[Token(Token = "0x400C2EF")]
		[FieldOffset(Offset = "0x2B0")]
		public UIButton ReportBtn;

		// Token: 0x0400C2F0 RID: 49904
		[Token(Token = "0x400C2F0")]
		[FieldOffset(Offset = "0x2B8")]
		public GameObject ReportDisableGO;

		// Token: 0x0400C2F1 RID: 49905
		[Token(Token = "0x400C2F1")]
		[FieldOffset(Offset = "0x2C0")]
		public UILabel ReportDisableLabel;

		// Token: 0x0400C2F2 RID: 49906
		[Token(Token = "0x400C2F2")]
		[FieldOffset(Offset = "0x2C8")]
		public Transform Center;
	}
}
