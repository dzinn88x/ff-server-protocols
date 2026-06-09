using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024B1 RID: 9393
	[Token(Token = "0x20024B1")]
	public class UIProfileView : UIBaseView
	{
		// Token: 0x0600C472 RID: 50290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C472")]
		[Address(RVA = "0x1FF4394", Offset = "0x1FF4394", VA = "0x7BBC7F4394", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C473 RID: 50291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C473")]
		[Address(RVA = "0x1FF7438", Offset = "0x1FF7438", VA = "0x7BBC7F7438")]
		public UIProfileView()
		{
		}

		// Token: 0x0400EDCC RID: 60876
		[Token(Token = "0x400EDCC")]
		[FieldOffset(Offset = "0x20")]
		public UITexture Bg;

		// Token: 0x0400EDCD RID: 60877
		[Token(Token = "0x400EDCD")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ChampionshipIcon;

		// Token: 0x0400EDCE RID: 60878
		[Token(Token = "0x400EDCE")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ProfileNodeAll;

		// Token: 0x0400EDCF RID: 60879
		[Token(Token = "0x400EDCF")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid profilegrid;

		// Token: 0x0400EDD0 RID: 60880
		[Token(Token = "0x400EDD0")]
		[FieldOffset(Offset = "0x40")]
		public Animation ProfilegridAnimation;

		// Token: 0x0400EDD1 RID: 60881
		[Token(Token = "0x400EDD1")]
		[FieldOffset(Offset = "0x48")]
		public Transform Item1;

		// Token: 0x0400EDD2 RID: 60882
		[Token(Token = "0x400EDD2")]
		[FieldOffset(Offset = "0x50")]
		public Transform Item2;

		// Token: 0x0400EDD3 RID: 60883
		[Token(Token = "0x400EDD3")]
		[FieldOffset(Offset = "0x58")]
		public Transform Item3;

		// Token: 0x0400EDD4 RID: 60884
		[Token(Token = "0x400EDD4")]
		[FieldOffset(Offset = "0x60")]
		public Transform profileshowoneitem;

		// Token: 0x0400EDD5 RID: 60885
		[Token(Token = "0x400EDD5")]
		[FieldOffset(Offset = "0x68")]
		public Transform ProfileFightBrMenu;

		// Token: 0x0400EDD6 RID: 60886
		[Token(Token = "0x400EDD6")]
		[FieldOffset(Offset = "0x70")]
		public Transform ProfileFightCSMenu;

		// Token: 0x0400EDD7 RID: 60887
		[Token(Token = "0x400EDD7")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ProfileDeslabel1;

		// Token: 0x0400EDD8 RID: 60888
		[Token(Token = "0x400EDD8")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnProfileNodeALLShare;

		// Token: 0x0400EDD9 RID: 60889
		[Token(Token = "0x400EDD9")]
		[FieldOffset(Offset = "0x88")]
		public UIButton ProfileNodeRuleBtn;

		// Token: 0x0400EDDA RID: 60890
		[Token(Token = "0x400EDDA")]
		[FieldOffset(Offset = "0x90")]
		public GameObject HistoryNode;

		// Token: 0x0400EDDB RID: 60891
		[Token(Token = "0x400EDDB")]
		[FieldOffset(Offset = "0x98")]
		public GameObject ContentNode;

		// Token: 0x0400EDDC RID: 60892
		[Token(Token = "0x400EDDC")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton BtnProfileNodeHistoryShare;

		// Token: 0x0400EDDD RID: 60893
		[Token(Token = "0x400EDDD")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel HistoryTime;

		// Token: 0x0400EDDE RID: 60894
		[Token(Token = "0x400EDDE")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel HistoryMatchMode;

		// Token: 0x0400EDDF RID: 60895
		[Token(Token = "0x400EDDF")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel HistoryGameMode;

		// Token: 0x0400EDE0 RID: 60896
		[Token(Token = "0x400EDE0")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel HistoryMapID;

		// Token: 0x0400EDE1 RID: 60897
		[Token(Token = "0x400EDE1")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject GroupHC1;

		// Token: 0x0400EDE2 RID: 60898
		[Token(Token = "0x400EDE2")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject GroupHC2;

		// Token: 0x0400EDE3 RID: 60899
		[Token(Token = "0x400EDE3")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject GroupHC3;

		// Token: 0x0400EDE4 RID: 60900
		[Token(Token = "0x400EDE4")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject GroupHC4;

		// Token: 0x0400EDE5 RID: 60901
		[Token(Token = "0x400EDE5")]
		[FieldOffset(Offset = "0xE8")]
		public UIEasyList HistoryList;

		// Token: 0x0400EDE6 RID: 60902
		[Token(Token = "0x400EDE6")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel HistoryRating;

		// Token: 0x0400EDE7 RID: 60903
		[Token(Token = "0x400EDE7")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel HistoryDeltaRating;

		// Token: 0x0400EDE8 RID: 60904
		[Token(Token = "0x400EDE8")]
		[FieldOffset(Offset = "0x100")]
		public UILabel HistoryRank;

		// Token: 0x0400EDE9 RID: 60905
		[Token(Token = "0x400EDE9")]
		[FieldOffset(Offset = "0x108")]
		public UILabel HistoryTotalRank;

		// Token: 0x0400EDEA RID: 60906
		[Token(Token = "0x400EDEA")]
		[FieldOffset(Offset = "0x110")]
		public GameObject LoseInfo1;

		// Token: 0x0400EDEB RID: 60907
		[Token(Token = "0x400EDEB")]
		[FieldOffset(Offset = "0x118")]
		public GameObject WinInfo1;

		// Token: 0x0400EDEC RID: 60908
		[Token(Token = "0x400EDEC")]
		[FieldOffset(Offset = "0x120")]
		public UILabel HistoryNodeMapName;

		// Token: 0x0400EDED RID: 60909
		[Token(Token = "0x400EDED")]
		[FieldOffset(Offset = "0x128")]
		public UILabel HistoryKill;

		// Token: 0x0400EDEE RID: 60910
		[Token(Token = "0x400EDEE")]
		[FieldOffset(Offset = "0x130")]
		public UILabel HistoryDamage;

		// Token: 0x0400EDEF RID: 60911
		[Token(Token = "0x400EDEF")]
		[FieldOffset(Offset = "0x138")]
		public UILabel HistoryRevive;

		// Token: 0x0400EDF0 RID: 60912
		[Token(Token = "0x400EDF0")]
		[FieldOffset(Offset = "0x140")]
		public UILabel HistoryHeadShoot;

		// Token: 0x0400EDF1 RID: 60913
		[Token(Token = "0x400EDF1")]
		[FieldOffset(Offset = "0x148")]
		public UILabel historySurvivalLabel;

		// Token: 0x0400EDF2 RID: 60914
		[Token(Token = "0x400EDF2")]
		[FieldOffset(Offset = "0x150")]
		public UILabel HistorySurvival;

		// Token: 0x0400EDF3 RID: 60915
		[Token(Token = "0x400EDF3")]
		[FieldOffset(Offset = "0x158")]
		public UISprite HistoryAchiveIcon;

		// Token: 0x0400EDF4 RID: 60916
		[Token(Token = "0x400EDF4")]
		[FieldOffset(Offset = "0x160")]
		public UILabel HistoryDescription;

		// Token: 0x0400EDF5 RID: 60917
		[Token(Token = "0x400EDF5")]
		[FieldOffset(Offset = "0x168")]
		public UIGrid HistoryTeammate;

		// Token: 0x0400EDF6 RID: 60918
		[Token(Token = "0x400EDF6")]
		[FieldOffset(Offset = "0x170")]
		public UIButton HistoryDetailBtn;

		// Token: 0x0400EDF7 RID: 60919
		[Token(Token = "0x400EDF7")]
		[FieldOffset(Offset = "0x178")]
		public GameObject EmptyNode;

		// Token: 0x0400EDF8 RID: 60920
		[Token(Token = "0x400EDF8")]
		[FieldOffset(Offset = "0x180")]
		public GameObject PersonShowNode;

		// Token: 0x0400EDF9 RID: 60921
		[Token(Token = "0x400EDF9")]
		[FieldOffset(Offset = "0x188")]
		public UIButton PersonBtnCloseup;

		// Token: 0x0400EDFA RID: 60922
		[Token(Token = "0x400EDFA")]
		[FieldOffset(Offset = "0x190")]
		public Transform MarryTr;

		// Token: 0x0400EDFB RID: 60923
		[Token(Token = "0x400EDFB")]
		[FieldOffset(Offset = "0x198")]
		public UISprite MarryIcon;

		// Token: 0x0400EDFC RID: 60924
		[Token(Token = "0x400EDFC")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject PersonalCard;

		// Token: 0x0400EDFD RID: 60925
		[Token(Token = "0x400EDFD")]
		[FieldOffset(Offset = "0x1A8")]
		public UISprite PersonProfileInfobg;

		// Token: 0x0400EDFE RID: 60926
		[Token(Token = "0x400EDFE")]
		[FieldOffset(Offset = "0x1B0")]
		public UISprite PersonfakeBg;

		// Token: 0x0400EDFF RID: 60927
		[Token(Token = "0x400EDFF")]
		[FieldOffset(Offset = "0x1B8")]
		public UISprite PersonProfileInfobgLow;

		// Token: 0x0400EE00 RID: 60928
		[Token(Token = "0x400EE00")]
		[FieldOffset(Offset = "0x1C0")]
		public UISprite PersonfakeLow;

		// Token: 0x0400EE01 RID: 60929
		[Token(Token = "0x400EE01")]
		[FieldOffset(Offset = "0x1C8")]
		public GameObject PersonFavorSprite;

		// Token: 0x0400EE02 RID: 60930
		[Token(Token = "0x400EE02")]
		[FieldOffset(Offset = "0x1D0")]
		public UISprite PersonHeadSprite;

		// Token: 0x0400EE03 RID: 60931
		[Token(Token = "0x400EE03")]
		[FieldOffset(Offset = "0x1D8")]
		public GameObject PersonFakeSprite;

		// Token: 0x0400EE04 RID: 60932
		[Token(Token = "0x400EE04")]
		[FieldOffset(Offset = "0x1E0")]
		public GameObject Icon_Celebrity;

		// Token: 0x0400EE05 RID: 60933
		[Token(Token = "0x400EE05")]
		[FieldOffset(Offset = "0x1E8")]
		public UIButton epbtn;

		// Token: 0x0400EE06 RID: 60934
		[Token(Token = "0x400EE06")]
		[FieldOffset(Offset = "0x1F0")]
		public GameObject EPTipsContainer;

		// Token: 0x0400EE07 RID: 60935
		[Token(Token = "0x400EE07")]
		[FieldOffset(Offset = "0x1F8")]
		public UIButton EPHelperMaskBtn;

		// Token: 0x0400EE08 RID: 60936
		[Token(Token = "0x400EE08")]
		[FieldOffset(Offset = "0x200")]
		public UIButton likebtn;

		// Token: 0x0400EE09 RID: 60937
		[Token(Token = "0x400EE09")]
		[FieldOffset(Offset = "0x208")]
		public GameObject LikeTipsContainer;

		// Token: 0x0400EE0A RID: 60938
		[Token(Token = "0x400EE0A")]
		[FieldOffset(Offset = "0x210")]
		public UIButton LikeHelperMaskBtn;

		// Token: 0x0400EE0B RID: 60939
		[Token(Token = "0x400EE0B")]
		[FieldOffset(Offset = "0x218")]
		public GameObject PersoninfoContainer;

		// Token: 0x0400EE0C RID: 60940
		[Token(Token = "0x400EE0C")]
		[FieldOffset(Offset = "0x220")]
		public UISprite Personvip;

		// Token: 0x0400EE0D RID: 60941
		[Token(Token = "0x400EE0D")]
		[FieldOffset(Offset = "0x228")]
		public UILabel PersonvipLv;

		// Token: 0x0400EE0E RID: 60942
		[Token(Token = "0x400EE0E")]
		[FieldOffset(Offset = "0x230")]
		public UILabel Personlevel;

		// Token: 0x0400EE0F RID: 60943
		[Token(Token = "0x400EE0F")]
		[FieldOffset(Offset = "0x238")]
		public UICustomHoverButton PersonlevelBtn;

		// Token: 0x0400EE10 RID: 60944
		[Token(Token = "0x400EE10")]
		[FieldOffset(Offset = "0x240")]
		public UILabel PersonclanName;

		// Token: 0x0400EE11 RID: 60945
		[Token(Token = "0x400EE11")]
		[FieldOffset(Offset = "0x248")]
		public UILabel PersonLagr;

		// Token: 0x0400EE12 RID: 60946
		[Token(Token = "0x400EE12")]
		[FieldOffset(Offset = "0x250")]
		public UISprite PlayerSex;

		// Token: 0x0400EE13 RID: 60947
		[Token(Token = "0x400EE13")]
		[FieldOffset(Offset = "0x258")]
		public UISprite LanguageSprite;

		// Token: 0x0400EE14 RID: 60948
		[Token(Token = "0x400EE14")]
		[FieldOffset(Offset = "0x260")]
		public Transform PersonnicknameTr;

		// Token: 0x0400EE15 RID: 60949
		[Token(Token = "0x400EE15")]
		[FieldOffset(Offset = "0x268")]
		public UILabel Personnickname;

		// Token: 0x0400EE16 RID: 60950
		[Token(Token = "0x400EE16")]
		[FieldOffset(Offset = "0x270")]
		public UILabel IDLabel;

		// Token: 0x0400EE17 RID: 60951
		[Token(Token = "0x400EE17")]
		[FieldOffset(Offset = "0x278")]
		public UIButton copybtn;

		// Token: 0x0400EE18 RID: 60952
		[Token(Token = "0x400EE18")]
		[FieldOffset(Offset = "0x280")]
		public UILabel likeslabel;

		// Token: 0x0400EE19 RID: 60953
		[Token(Token = "0x400EE19")]
		[FieldOffset(Offset = "0x288")]
		public UISprite PinIcon;

		// Token: 0x0400EE1A RID: 60954
		[Token(Token = "0x400EE1A")]
		[FieldOffset(Offset = "0x290")]
		public UIButton BtnPin;

		// Token: 0x0400EE1B RID: 60955
		[Token(Token = "0x400EE1B")]
		[FieldOffset(Offset = "0x298")]
		public UIButton Guildbtn;

		// Token: 0x0400EE1C RID: 60956
		[Token(Token = "0x400EE1C")]
		[FieldOffset(Offset = "0x2A0")]
		public UISprite GuildBtnSpr;

		// Token: 0x0400EE1D RID: 60957
		[Token(Token = "0x400EE1D")]
		[FieldOffset(Offset = "0x2A8")]
		public UICustomHoverButton huoyue;

		// Token: 0x0400EE1E RID: 60958
		[Token(Token = "0x400EE1E")]
		[FieldOffset(Offset = "0x2B0")]
		public UISprite huoyuespr;

		// Token: 0x0400EE1F RID: 60959
		[Token(Token = "0x400EE1F")]
		[FieldOffset(Offset = "0x2B8")]
		public UICustomHoverButton onlinetime;

		// Token: 0x0400EE20 RID: 60960
		[Token(Token = "0x400EE20")]
		[FieldOffset(Offset = "0x2C0")]
		public UISprite onlinetimespr;

		// Token: 0x0400EE21 RID: 60961
		[Token(Token = "0x400EE21")]
		[FieldOffset(Offset = "0x2C8")]
		public UICustomHoverButton modelikes;

		// Token: 0x0400EE22 RID: 60962
		[Token(Token = "0x400EE22")]
		[FieldOffset(Offset = "0x2D0")]
		public UISprite modelikesspr;

		// Token: 0x0400EE23 RID: 60963
		[Token(Token = "0x400EE23")]
		[FieldOffset(Offset = "0x2D8")]
		public UIToggleButtonGroup SeaSonInfoToogleGroup;

		// Token: 0x0400EE24 RID: 60964
		[Token(Token = "0x400EE24")]
		[FieldOffset(Offset = "0x2E0")]
		public UIGrid SeaSonInfoToggleGrid;

		// Token: 0x0400EE25 RID: 60965
		[Token(Token = "0x400EE25")]
		[FieldOffset(Offset = "0x2E8")]
		public GameObject SeaSonBrContainer;

		// Token: 0x0400EE26 RID: 60966
		[Token(Token = "0x400EE26")]
		[FieldOffset(Offset = "0x2F0")]
		public UIToggleButton SeaSonBrBtn;

		// Token: 0x0400EE27 RID: 60967
		[Token(Token = "0x400EE27")]
		[FieldOffset(Offset = "0x2F8")]
		public GameObject SeaSonCsContainer;

		// Token: 0x0400EE28 RID: 60968
		[Token(Token = "0x400EE28")]
		[FieldOffset(Offset = "0x300")]
		public UIToggleButton SeaSonCsBtn;

		// Token: 0x0400EE29 RID: 60969
		[Token(Token = "0x400EE29")]
		[FieldOffset(Offset = "0x308")]
		public GameObject SeaSonCsCoontainer;

		// Token: 0x0400EE2A RID: 60970
		[Token(Token = "0x400EE2A")]
		[FieldOffset(Offset = "0x310")]
		public UILabel CSSEASON_S;

		// Token: 0x0400EE2B RID: 60971
		[Token(Token = "0x400EE2B")]
		[FieldOffset(Offset = "0x318")]
		public UILabel CSeason_L;

		// Token: 0x0400EE2C RID: 60972
		[Token(Token = "0x400EE2C")]
		[FieldOffset(Offset = "0x320")]
		public Transform PersonSeaSonDesHistoryCSRoot;

		// Token: 0x0400EE2D RID: 60973
		[Token(Token = "0x400EE2D")]
		[FieldOffset(Offset = "0x328")]
		public UISprite PersonRankIconHistoryCS;

		// Token: 0x0400EE2E RID: 60974
		[Token(Token = "0x400EE2E")]
		[FieldOffset(Offset = "0x330")]
		public UICustomHoverButton PersonRankIconHistoryCSBtn;

		// Token: 0x0400EE2F RID: 60975
		[Token(Token = "0x400EE2F")]
		[FieldOffset(Offset = "0x338")]
		public UILabel PersonSeaSonDesHistoryCS;

		// Token: 0x0400EE30 RID: 60976
		[Token(Token = "0x400EE30")]
		[FieldOffset(Offset = "0x340")]
		public Transform PersonHeroicMarkCSRoot;

		// Token: 0x0400EE31 RID: 60977
		[Token(Token = "0x400EE31")]
		[FieldOffset(Offset = "0x348")]
		public UILabel HeroicMarkLabel;

		// Token: 0x0400EE32 RID: 60978
		[Token(Token = "0x400EE32")]
		[FieldOffset(Offset = "0x350")]
		public Transform CSNotObtainedIcon;

		// Token: 0x0400EE33 RID: 60979
		[Token(Token = "0x400EE33")]
		[FieldOffset(Offset = "0x358")]
		public UIButton CSNotObtainedBtn;

		// Token: 0x0400EE34 RID: 60980
		[Token(Token = "0x400EE34")]
		[FieldOffset(Offset = "0x360")]
		public UISprite HeroicMarkCSIcon;

		// Token: 0x0400EE35 RID: 60981
		[Token(Token = "0x400EE35")]
		[FieldOffset(Offset = "0x368")]
		public UIButton HeroicMarkCSIconBtn;

		// Token: 0x0400EE36 RID: 60982
		[Token(Token = "0x400EE36")]
		[FieldOffset(Offset = "0x370")]
		public Transform HeroicCSEffect;

		// Token: 0x0400EE37 RID: 60983
		[Token(Token = "0x400EE37")]
		[FieldOffset(Offset = "0x378")]
		public UILabel PersonSeaSonDesNowCS;

		// Token: 0x0400EE38 RID: 60984
		[Token(Token = "0x400EE38")]
		[FieldOffset(Offset = "0x380")]
		public UILabel PersonSeaSonRankNameCS;

		// Token: 0x0400EE39 RID: 60985
		[Token(Token = "0x400EE39")]
		[FieldOffset(Offset = "0x388")]
		public UILabel PersonSeaSonRankNameHistoryCS;

		// Token: 0x0400EE3A RID: 60986
		[Token(Token = "0x400EE3A")]
		[FieldOffset(Offset = "0x390")]
		public UISprite PersonRankIconCS;

		// Token: 0x0400EE3B RID: 60987
		[Token(Token = "0x400EE3B")]
		[FieldOffset(Offset = "0x398")]
		public UICustomHoverButton PersonRankIconCSBtn;

		// Token: 0x0400EE3C RID: 60988
		[Token(Token = "0x400EE3C")]
		[FieldOffset(Offset = "0x3A0")]
		public GameObject StarIcon;

		// Token: 0x0400EE3D RID: 60989
		[Token(Token = "0x400EE3D")]
		[FieldOffset(Offset = "0x3A8")]
		public UILabel NowMaxRankTxt;

		// Token: 0x0400EE3E RID: 60990
		[Token(Token = "0x400EE3E")]
		[FieldOffset(Offset = "0x3B0")]
		public UIGrid NowCSGrid;

		// Token: 0x0400EE3F RID: 60991
		[Token(Token = "0x400EE3F")]
		[FieldOffset(Offset = "0x3B8")]
		public GameObject nowstar1;

		// Token: 0x0400EE40 RID: 60992
		[Token(Token = "0x400EE40")]
		[FieldOffset(Offset = "0x3C0")]
		public GameObject nowstar2;

		// Token: 0x0400EE41 RID: 60993
		[Token(Token = "0x400EE41")]
		[FieldOffset(Offset = "0x3C8")]
		public GameObject nowstar3;

		// Token: 0x0400EE42 RID: 60994
		[Token(Token = "0x400EE42")]
		[FieldOffset(Offset = "0x3D0")]
		public GameObject nowstar4;

		// Token: 0x0400EE43 RID: 60995
		[Token(Token = "0x400EE43")]
		[FieldOffset(Offset = "0x3D8")]
		public GameObject nowstar5;

		// Token: 0x0400EE44 RID: 60996
		[Token(Token = "0x400EE44")]
		[FieldOffset(Offset = "0x3E0")]
		public GameObject nowblackstar1;

		// Token: 0x0400EE45 RID: 60997
		[Token(Token = "0x400EE45")]
		[FieldOffset(Offset = "0x3E8")]
		public GameObject nowblackstar2;

		// Token: 0x0400EE46 RID: 60998
		[Token(Token = "0x400EE46")]
		[FieldOffset(Offset = "0x3F0")]
		public GameObject nowblackstar3;

		// Token: 0x0400EE47 RID: 60999
		[Token(Token = "0x400EE47")]
		[FieldOffset(Offset = "0x3F8")]
		public GameObject nowblackstar4;

		// Token: 0x0400EE48 RID: 61000
		[Token(Token = "0x400EE48")]
		[FieldOffset(Offset = "0x400")]
		public GameObject nowblackstar5;

		// Token: 0x0400EE49 RID: 61001
		[Token(Token = "0x400EE49")]
		[FieldOffset(Offset = "0x408")]
		public UILabel HistoryMaxRankTxt;

		// Token: 0x0400EE4A RID: 61002
		[Token(Token = "0x400EE4A")]
		[FieldOffset(Offset = "0x410")]
		public UIGrid HistoryCsGrid;

		// Token: 0x0400EE4B RID: 61003
		[Token(Token = "0x400EE4B")]
		[FieldOffset(Offset = "0x418")]
		public GameObject Historystar1;

		// Token: 0x0400EE4C RID: 61004
		[Token(Token = "0x400EE4C")]
		[FieldOffset(Offset = "0x420")]
		public GameObject Historystar2;

		// Token: 0x0400EE4D RID: 61005
		[Token(Token = "0x400EE4D")]
		[FieldOffset(Offset = "0x428")]
		public GameObject Historystar3;

		// Token: 0x0400EE4E RID: 61006
		[Token(Token = "0x400EE4E")]
		[FieldOffset(Offset = "0x430")]
		public GameObject Historystar4;

		// Token: 0x0400EE4F RID: 61007
		[Token(Token = "0x400EE4F")]
		[FieldOffset(Offset = "0x438")]
		public GameObject Historystar5;

		// Token: 0x0400EE50 RID: 61008
		[Token(Token = "0x400EE50")]
		[FieldOffset(Offset = "0x440")]
		public GameObject Historyblackstar1;

		// Token: 0x0400EE51 RID: 61009
		[Token(Token = "0x400EE51")]
		[FieldOffset(Offset = "0x448")]
		public GameObject Historyblackstar2;

		// Token: 0x0400EE52 RID: 61010
		[Token(Token = "0x400EE52")]
		[FieldOffset(Offset = "0x450")]
		public GameObject Historyblackstar3;

		// Token: 0x0400EE53 RID: 61011
		[Token(Token = "0x400EE53")]
		[FieldOffset(Offset = "0x458")]
		public GameObject Historyblackstar4;

		// Token: 0x0400EE54 RID: 61012
		[Token(Token = "0x400EE54")]
		[FieldOffset(Offset = "0x460")]
		public GameObject Historyblackstar5;

		// Token: 0x0400EE55 RID: 61013
		[Token(Token = "0x400EE55")]
		[FieldOffset(Offset = "0x468")]
		public GameObject SeaSonBrCootainer;

		// Token: 0x0400EE56 RID: 61014
		[Token(Token = "0x400EE56")]
		[FieldOffset(Offset = "0x470")]
		public UILabel BRSEASON_S;

		// Token: 0x0400EE57 RID: 61015
		[Token(Token = "0x400EE57")]
		[FieldOffset(Offset = "0x478")]
		public UILabel BRSeason_L;

		// Token: 0x0400EE58 RID: 61016
		[Token(Token = "0x400EE58")]
		[FieldOffset(Offset = "0x480")]
		public Transform PersonSeaSonDesHistoryRoot;

		// Token: 0x0400EE59 RID: 61017
		[Token(Token = "0x400EE59")]
		[FieldOffset(Offset = "0x488")]
		public UILabel PersonSeaSonDesHistory;

		// Token: 0x0400EE5A RID: 61018
		[Token(Token = "0x400EE5A")]
		[FieldOffset(Offset = "0x490")]
		public UISprite PersonRankIconHistory;

		// Token: 0x0400EE5B RID: 61019
		[Token(Token = "0x400EE5B")]
		[FieldOffset(Offset = "0x498")]
		public UICustomHoverButton PersonRankIconHistoryBtn;

		// Token: 0x0400EE5C RID: 61020
		[Token(Token = "0x400EE5C")]
		[FieldOffset(Offset = "0x4A0")]
		public Transform PersonBRHeroicMarkRoot;

		// Token: 0x0400EE5D RID: 61021
		[Token(Token = "0x400EE5D")]
		[FieldOffset(Offset = "0x4A8")]
		public Transform BRNotObtainedIcon;

		// Token: 0x0400EE5E RID: 61022
		[Token(Token = "0x400EE5E")]
		[FieldOffset(Offset = "0x4B0")]
		public UIButton BRNotObtainedBtn;

		// Token: 0x0400EE5F RID: 61023
		[Token(Token = "0x400EE5F")]
		[FieldOffset(Offset = "0x4B8")]
		public UISprite HeroicMarkBRIcon;

		// Token: 0x0400EE60 RID: 61024
		[Token(Token = "0x400EE60")]
		[FieldOffset(Offset = "0x4C0")]
		public UIButton HeroicMarkBRIconBtn;

		// Token: 0x0400EE61 RID: 61025
		[Token(Token = "0x400EE61")]
		[FieldOffset(Offset = "0x4C8")]
		public Transform HeroicBREffect;

		// Token: 0x0400EE62 RID: 61026
		[Token(Token = "0x400EE62")]
		[FieldOffset(Offset = "0x4D0")]
		public UILabel PersonSeaSonDesNow;

		// Token: 0x0400EE63 RID: 61027
		[Token(Token = "0x400EE63")]
		[FieldOffset(Offset = "0x4D8")]
		public UILabel PersonSeaSonRankName;

		// Token: 0x0400EE64 RID: 61028
		[Token(Token = "0x400EE64")]
		[FieldOffset(Offset = "0x4E0")]
		public UILabel PersonSeaSonRankNameHistory;

		// Token: 0x0400EE65 RID: 61029
		[Token(Token = "0x400EE65")]
		[FieldOffset(Offset = "0x4E8")]
		public UISprite PersonRankIcon;

		// Token: 0x0400EE66 RID: 61030
		[Token(Token = "0x400EE66")]
		[FieldOffset(Offset = "0x4F0")]
		public UICustomHoverButton PersonRankIconBtn;

		// Token: 0x0400EE67 RID: 61031
		[Token(Token = "0x400EE67")]
		[FieldOffset(Offset = "0x4F8")]
		public UILabel PersonSeaSonRankPoint;

		// Token: 0x0400EE68 RID: 61032
		[Token(Token = "0x400EE68")]
		[FieldOffset(Offset = "0x500")]
		public UILabel PersonSeaSonHistoryRankPoint;

		// Token: 0x0400EE69 RID: 61033
		[Token(Token = "0x400EE69")]
		[FieldOffset(Offset = "0x508")]
		public GameObject HeroicLeveContainer;

		// Token: 0x0400EE6A RID: 61034
		[Token(Token = "0x400EE6A")]
		[FieldOffset(Offset = "0x510")]
		public UILadderMatchHeroicLevelView HeroicLevelView;

		// Token: 0x0400EE6B RID: 61035
		[Token(Token = "0x400EE6B")]
		[FieldOffset(Offset = "0x518")]
		public GameObject HeroicLeveContainerMax;

		// Token: 0x0400EE6C RID: 61036
		[Token(Token = "0x400EE6C")]
		[FieldOffset(Offset = "0x520")]
		public UILadderMatchHeroicLevelView HeroicLevelViewMax;

		// Token: 0x0400EE6D RID: 61037
		[Token(Token = "0x400EE6D")]
		[FieldOffset(Offset = "0x528")]
		public UISprite PersonEPBadge;

		// Token: 0x0400EE6E RID: 61038
		[Token(Token = "0x400EE6E")]
		[FieldOffset(Offset = "0x530")]
		public UILabel PersonBadgeCntLabel;

		// Token: 0x0400EE6F RID: 61039
		[Token(Token = "0x400EE6F")]
		[FieldOffset(Offset = "0x538")]
		public UIButton BtnEPDocument;

		// Token: 0x0400EE70 RID: 61040
		[Token(Token = "0x400EE70")]
		[FieldOffset(Offset = "0x540")]
		public GameObject EpBriefDetailList;

		// Token: 0x0400EE71 RID: 61041
		[Token(Token = "0x400EE71")]
		[FieldOffset(Offset = "0x548")]
		public UIGrid EPDetailGrid;

		// Token: 0x0400EE72 RID: 61042
		[Token(Token = "0x400EE72")]
		[FieldOffset(Offset = "0x550")]
		public UISprite EPAwardicon1;

		// Token: 0x0400EE73 RID: 61043
		[Token(Token = "0x400EE73")]
		[FieldOffset(Offset = "0x558")]
		public UILabel EPAwardnum1;

		// Token: 0x0400EE74 RID: 61044
		[Token(Token = "0x400EE74")]
		[FieldOffset(Offset = "0x560")]
		public UISprite EPAwardicon2;

		// Token: 0x0400EE75 RID: 61045
		[Token(Token = "0x400EE75")]
		[FieldOffset(Offset = "0x568")]
		public UILabel EPAwardnum2;

		// Token: 0x0400EE76 RID: 61046
		[Token(Token = "0x400EE76")]
		[FieldOffset(Offset = "0x570")]
		public UISprite EPAwardicon3;

		// Token: 0x0400EE77 RID: 61047
		[Token(Token = "0x400EE77")]
		[FieldOffset(Offset = "0x578")]
		public UILabel EPAwardnum3;

		// Token: 0x0400EE78 RID: 61048
		[Token(Token = "0x400EE78")]
		[FieldOffset(Offset = "0x580")]
		public UISprite EPAwardicon4;

		// Token: 0x0400EE79 RID: 61049
		[Token(Token = "0x400EE79")]
		[FieldOffset(Offset = "0x588")]
		public UILabel EPAwardnum4;

		// Token: 0x0400EE7A RID: 61050
		[Token(Token = "0x400EE7A")]
		[FieldOffset(Offset = "0x590")]
		public UIButton EpBriefBtn;

		// Token: 0x0400EE7B RID: 61051
		[Token(Token = "0x400EE7B")]
		[FieldOffset(Offset = "0x598")]
		public GameObject EpFullDetailList;

		// Token: 0x0400EE7C RID: 61052
		[Token(Token = "0x400EE7C")]
		[FieldOffset(Offset = "0x5A0")]
		public UIGrid EPFullDetailGrid;

		// Token: 0x0400EE7D RID: 61053
		[Token(Token = "0x400EE7D")]
		[FieldOffset(Offset = "0x5A8")]
		public UIButton EpFullBtn;

		// Token: 0x0400EE7E RID: 61054
		[Token(Token = "0x400EE7E")]
		[FieldOffset(Offset = "0x5B0")]
		public UISprite EPFullBg;

		// Token: 0x0400EE7F RID: 61055
		[Token(Token = "0x400EE7F")]
		[FieldOffset(Offset = "0x5B8")]
		public UISprite EPFullBgSpr;

		// Token: 0x0400EE80 RID: 61056
		[Token(Token = "0x400EE80")]
		[FieldOffset(Offset = "0x5C0")]
		public UILabel PersonalsignatureKey;

		// Token: 0x0400EE81 RID: 61057
		[Token(Token = "0x400EE81")]
		[FieldOffset(Offset = "0x5C8")]
		public UILabel Personalsignature;

		// Token: 0x0400EE82 RID: 61058
		[Token(Token = "0x400EE82")]
		[FieldOffset(Offset = "0x5D0")]
		public GameObject FightBiaoqianTr1;

		// Token: 0x0400EE83 RID: 61059
		[Token(Token = "0x400EE83")]
		[FieldOffset(Offset = "0x5D8")]
		public UILabel FightBiaoqian;

		// Token: 0x0400EE84 RID: 61060
		[Token(Token = "0x400EE84")]
		[FieldOffset(Offset = "0x5E0")]
		public GameObject FightBiaoqianTr2;

		// Token: 0x0400EE85 RID: 61061
		[Token(Token = "0x400EE85")]
		[FieldOffset(Offset = "0x5E8")]
		public UILabel FightBiaoqianNoKey;

		// Token: 0x0400EE86 RID: 61062
		[Token(Token = "0x400EE86")]
		[FieldOffset(Offset = "0x5F0")]
		public UILabel SocialBiaoqianNoKey;

		// Token: 0x0400EE87 RID: 61063
		[Token(Token = "0x400EE87")]
		[FieldOffset(Offset = "0x5F8")]
		public GameObject SocialBiaoqianTr2;

		// Token: 0x0400EE88 RID: 61064
		[Token(Token = "0x400EE88")]
		[FieldOffset(Offset = "0x600")]
		public GameObject SocialBiaoqianTr1;

		// Token: 0x0400EE89 RID: 61065
		[Token(Token = "0x400EE89")]
		[FieldOffset(Offset = "0x608")]
		public UILabel SocialBiaoqian;

		// Token: 0x0400EE8A RID: 61066
		[Token(Token = "0x400EE8A")]
		[FieldOffset(Offset = "0x610")]
		public UIButton PersonBtnSetting;

		// Token: 0x0400EE8B RID: 61067
		[Token(Token = "0x400EE8B")]
		[FieldOffset(Offset = "0x618")]
		public UIButton PersonBtnAddFriend;

		// Token: 0x0400EE8C RID: 61068
		[Token(Token = "0x400EE8C")]
		[FieldOffset(Offset = "0x620")]
		public UISprite FrendAddIcon;

		// Token: 0x0400EE8D RID: 61069
		[Token(Token = "0x400EE8D")]
		[FieldOffset(Offset = "0x628")]
		public GameObject FriendAddText;

		// Token: 0x0400EE8E RID: 61070
		[Token(Token = "0x400EE8E")]
		[FieldOffset(Offset = "0x630")]
		public UIButton PersonalShareBtn;

		// Token: 0x0400EE8F RID: 61071
		[Token(Token = "0x400EE8F")]
		[FieldOffset(Offset = "0x638")]
		public Animator ShareIconAnimator;

		// Token: 0x0400EE90 RID: 61072
		[Token(Token = "0x400EE90")]
		[FieldOffset(Offset = "0x640")]
		public UIGrid PersonTrendGrid;

		// Token: 0x0400EE91 RID: 61073
		[Token(Token = "0x400EE91")]
		[FieldOffset(Offset = "0x648")]
		public GameObject PersonNoTrend;

		// Token: 0x0400EE92 RID: 61074
		[Token(Token = "0x400EE92")]
		[FieldOffset(Offset = "0x650")]
		public UILabel GuildName;

		// Token: 0x0400EE93 RID: 61075
		[Token(Token = "0x400EE93")]
		[FieldOffset(Offset = "0x658")]
		public UISprite GuildIcon;

		// Token: 0x0400EE94 RID: 61076
		[Token(Token = "0x400EE94")]
		[FieldOffset(Offset = "0x660")]
		public GameObject GuildTip;

		// Token: 0x0400EE95 RID: 61077
		[Token(Token = "0x400EE95")]
		[FieldOffset(Offset = "0x668")]
		public GameObject LeftItem;

		// Token: 0x0400EE96 RID: 61078
		[Token(Token = "0x400EE96")]
		[FieldOffset(Offset = "0x670")]
		public UIGrid ClothPreviewSuitGroup;

		// Token: 0x0400EE97 RID: 61079
		[Token(Token = "0x400EE97")]
		[FieldOffset(Offset = "0x678")]
		public UIGrid ClothPreviewGroup;

		// Token: 0x0400EE98 RID: 61080
		[Token(Token = "0x400EE98")]
		[FieldOffset(Offset = "0x680")]
		public GameObject ItemDesc;

		// Token: 0x0400EE99 RID: 61081
		[Token(Token = "0x400EE99")]
		[FieldOffset(Offset = "0x688")]
		public GameObject itemsdesc;

		// Token: 0x0400EE9A RID: 61082
		[Token(Token = "0x400EE9A")]
		[FieldOffset(Offset = "0x690")]
		public UILabel itemDescLabel;

		// Token: 0x0400EE9B RID: 61083
		[Token(Token = "0x400EE9B")]
		[FieldOffset(Offset = "0x698")]
		public GameObject itemsname;

		// Token: 0x0400EE9C RID: 61084
		[Token(Token = "0x400EE9C")]
		[FieldOffset(Offset = "0x6A0")]
		public UISprite CalBg;

		// Token: 0x0400EE9D RID: 61085
		[Token(Token = "0x400EE9D")]
		[FieldOffset(Offset = "0x6A8")]
		public UILabel itemNameLabel;

		// Token: 0x0400EE9E RID: 61086
		[Token(Token = "0x400EE9E")]
		[FieldOffset(Offset = "0x6B0")]
		public UISprite ScreenshotTopBanner;

		// Token: 0x0400EE9F RID: 61087
		[Token(Token = "0x400EE9F")]
		[FieldOffset(Offset = "0x6B8")]
		public UINetworkTexture HeadshotRemote;

		// Token: 0x0400EEA0 RID: 61088
		[Token(Token = "0x400EEA0")]
		[FieldOffset(Offset = "0x6C0")]
		public GameObject HeadshotDefault;

		// Token: 0x0400EEA1 RID: 61089
		[Token(Token = "0x400EEA1")]
		[FieldOffset(Offset = "0x6C8")]
		public UIEffectSprite HeadshotLocal;

		// Token: 0x0400EEA2 RID: 61090
		[Token(Token = "0x400EEA2")]
		[FieldOffset(Offset = "0x6D0")]
		public UILabel PlayerNickname;

		// Token: 0x0400EEA3 RID: 61091
		[Token(Token = "0x400EEA3")]
		[FieldOffset(Offset = "0x6D8")]
		public UILabel PlayerID;

		// Token: 0x0400EEA4 RID: 61092
		[Token(Token = "0x400EEA4")]
		[FieldOffset(Offset = "0x6E0")]
		public UISprite ScreenShotLine;

		// Token: 0x0400EEA5 RID: 61093
		[Token(Token = "0x400EEA5")]
		[FieldOffset(Offset = "0x6E8")]
		public UISprite ScreenShotBg;

		// Token: 0x0400EEA6 RID: 61094
		[Token(Token = "0x400EEA6")]
		[FieldOffset(Offset = "0x6F0")]
		public UISprite FreeFireLogo;

		// Token: 0x0400EEA7 RID: 61095
		[Token(Token = "0x400EEA7")]
		[FieldOffset(Offset = "0x6F8")]
		public GameObject SceenShotProfileNodeAll;

		// Token: 0x0400EEA8 RID: 61096
		[Token(Token = "0x400EEA8")]
		[FieldOffset(Offset = "0x700")]
		public UIGrid ScreenShotprofilegrid;

		// Token: 0x0400EEA9 RID: 61097
		[Token(Token = "0x400EEA9")]
		[FieldOffset(Offset = "0x708")]
		public Transform ScreenShotprofileshowoneitem;

		// Token: 0x0400EEAA RID: 61098
		[Token(Token = "0x400EEAA")]
		[FieldOffset(Offset = "0x710")]
		public UILabel ProfilenoDEsHAREDeslabel;

		// Token: 0x0400EEAB RID: 61099
		[Token(Token = "0x400EEAB")]
		[FieldOffset(Offset = "0x718")]
		public GameObject SceenShotProfileHistory;
	}
}
