using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023FF RID: 9215
	[Token(Token = "0x20023FF")]
	public class UILobbyNewView : UIBaseView
	{
		// Token: 0x0600C30E RID: 49934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C30E")]
		[Address(RVA = "0x19D56E0", Offset = "0x19D56E0", VA = "0x7BBC1D56E0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C30F RID: 49935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C30F")]
		[Address(RVA = "0x19D86FC", Offset = "0x19D86FC", VA = "0x7BBC1D86FC")]
		public UILobbyNewView()
		{
		}

		// Token: 0x0400E231 RID: 57905
		[Token(Token = "0x400E231")]
		[FieldOffset(Offset = "0x20")]
		public UISprite HDMask;

		// Token: 0x0400E232 RID: 57906
		[Token(Token = "0x400E232")]
		[FieldOffset(Offset = "0x28")]
		public TweenAlpha TweenAlphaGroupMaskScene;

		// Token: 0x0400E233 RID: 57907
		[Token(Token = "0x400E233")]
		[FieldOffset(Offset = "0x30")]
		public Transform AvatarPanel;

		// Token: 0x0400E234 RID: 57908
		[Token(Token = "0x400E234")]
		[FieldOffset(Offset = "0x38")]
		public Transform EmotePanelContainer;

		// Token: 0x0400E235 RID: 57909
		[Token(Token = "0x400E235")]
		[FieldOffset(Offset = "0x40")]
		public Transform EquipSetsContainer;

		// Token: 0x0400E236 RID: 57910
		[Token(Token = "0x400E236")]
		[FieldOffset(Offset = "0x48")]
		public Transform PanelGroupMask;

		// Token: 0x0400E237 RID: 57911
		[Token(Token = "0x400E237")]
		[FieldOffset(Offset = "0x50")]
		public TweenAlpha TweenAlphaGroupMask;

		// Token: 0x0400E238 RID: 57912
		[Token(Token = "0x400E238")]
		[FieldOffset(Offset = "0x58")]
		public Transform TopLeft;

		// Token: 0x0400E239 RID: 57913
		[Token(Token = "0x400E239")]
		[FieldOffset(Offset = "0x60")]
		public TweenPosition TweenPosPanelTopLeft;

		// Token: 0x0400E23A RID: 57914
		[Token(Token = "0x400E23A")]
		[FieldOffset(Offset = "0x68")]
		public UIButton PaymentButton;

		// Token: 0x0400E23B RID: 57915
		[Token(Token = "0x400E23B")]
		[FieldOffset(Offset = "0x70")]
		public UISprite PaymentButtonDefaultSprite;

		// Token: 0x0400E23C RID: 57916
		[Token(Token = "0x400E23C")]
		[FieldOffset(Offset = "0x78")]
		public UINetworkTexture PaymentButtonNetworkTexture;

		// Token: 0x0400E23D RID: 57917
		[Token(Token = "0x400E23D")]
		[FieldOffset(Offset = "0x80")]
		public GameObject CountDownLabel;

		// Token: 0x0400E23E RID: 57918
		[Token(Token = "0x400E23E")]
		[FieldOffset(Offset = "0x88")]
		public Transform profile;

		// Token: 0x0400E23F RID: 57919
		[Token(Token = "0x400E23F")]
		[FieldOffset(Offset = "0x90")]
		public Transform AdsContainer;

		// Token: 0x0400E240 RID: 57920
		[Token(Token = "0x400E240")]
		[FieldOffset(Offset = "0x98")]
		public Transform mapModesPanel;

		// Token: 0x0400E241 RID: 57921
		[Token(Token = "0x400E241")]
		[FieldOffset(Offset = "0xA0")]
		public Transform TopRight;

		// Token: 0x0400E242 RID: 57922
		[Token(Token = "0x400E242")]
		[FieldOffset(Offset = "0xA8")]
		public TweenPosition TweenPosPanelTopRight;

		// Token: 0x0400E243 RID: 57923
		[Token(Token = "0x400E243")]
		[FieldOffset(Offset = "0xB0")]
		public UIGrid ActivityContainer;

		// Token: 0x0400E244 RID: 57924
		[Token(Token = "0x400E244")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton BtnFFWSMain;

		// Token: 0x0400E245 RID: 57925
		[Token(Token = "0x400E245")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject FFWSTips;

		// Token: 0x0400E246 RID: 57926
		[Token(Token = "0x400E246")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite SpriteFFWSLive;

		// Token: 0x0400E247 RID: 57927
		[Token(Token = "0x400E247")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite SpriteFFWSPeakDay;

		// Token: 0x0400E248 RID: 57928
		[Token(Token = "0x400E248")]
		[FieldOffset(Offset = "0xD8")]
		public Transform CountDownFFWS;

		// Token: 0x0400E249 RID: 57929
		[Token(Token = "0x400E249")]
		[FieldOffset(Offset = "0xE0")]
		public UIWidget HDIAPBundleContainer;

		// Token: 0x0400E24A RID: 57930
		[Token(Token = "0x400E24A")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton NewPlayerSigninBtn;

		// Token: 0x0400E24B RID: 57931
		[Token(Token = "0x400E24B")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject NewPlayerSigninEffect;

		// Token: 0x0400E24C RID: 57932
		[Token(Token = "0x400E24C")]
		[FieldOffset(Offset = "0xF8")]
		public Animator newPlayerIconAnimator;

		// Token: 0x0400E24D RID: 57933
		[Token(Token = "0x400E24D")]
		[FieldOffset(Offset = "0x100")]
		public Transform NewPlayerCountDown;

		// Token: 0x0400E24E RID: 57934
		[Token(Token = "0x400E24E")]
		[FieldOffset(Offset = "0x108")]
		public UIButton BtnGoliath;

		// Token: 0x0400E24F RID: 57935
		[Token(Token = "0x400E24F")]
		[FieldOffset(Offset = "0x110")]
		public UISprite GoliathIcon;

		// Token: 0x0400E250 RID: 57936
		[Token(Token = "0x400E250")]
		[FieldOffset(Offset = "0x118")]
		public GameObject GoliathTips;

		// Token: 0x0400E251 RID: 57937
		[Token(Token = "0x400E251")]
		[FieldOffset(Offset = "0x120")]
		public Transform GoliathCountDown;

		// Token: 0x0400E252 RID: 57938
		[Token(Token = "0x400E252")]
		[FieldOffset(Offset = "0x128")]
		public UIButton BtnSuperFighter;

		// Token: 0x0400E253 RID: 57939
		[Token(Token = "0x400E253")]
		[FieldOffset(Offset = "0x130")]
		public Transform SuperFighterCountDown;

		// Token: 0x0400E254 RID: 57940
		[Token(Token = "0x400E254")]
		[FieldOffset(Offset = "0x138")]
		public GameObject SuperFighterTips;

		// Token: 0x0400E255 RID: 57941
		[Token(Token = "0x400E255")]
		[FieldOffset(Offset = "0x140")]
		public UIButton BtnChampionship;

		// Token: 0x0400E256 RID: 57942
		[Token(Token = "0x400E256")]
		[FieldOffset(Offset = "0x148")]
		public GameObject ChampionshipEffect;

		// Token: 0x0400E257 RID: 57943
		[Token(Token = "0x400E257")]
		[FieldOffset(Offset = "0x150")]
		public GameObject FFCIcon;

		// Token: 0x0400E258 RID: 57944
		[Token(Token = "0x400E258")]
		[FieldOffset(Offset = "0x158")]
		public UITipsButton ChampionshipWarmupRedPoint;

		// Token: 0x0400E259 RID: 57945
		[Token(Token = "0x400E259")]
		[FieldOffset(Offset = "0x160")]
		public UITipsButton ChampionshipTrialOpenRedPoint;

		// Token: 0x0400E25A RID: 57946
		[Token(Token = "0x400E25A")]
		[FieldOffset(Offset = "0x168")]
		public UITipsButton ChampionshipApplyInviteRedPoint;

		// Token: 0x0400E25B RID: 57947
		[Token(Token = "0x400E25B")]
		[FieldOffset(Offset = "0x170")]
		public GameObject FFCIconUnOpen;

		// Token: 0x0400E25C RID: 57948
		[Token(Token = "0x400E25C")]
		[FieldOffset(Offset = "0x178")]
		public Transform ChampionshipCountDown;

		// Token: 0x0400E25D RID: 57949
		[Token(Token = "0x400E25D")]
		[FieldOffset(Offset = "0x180")]
		public UIWidget ChampionGuide;

		// Token: 0x0400E25E RID: 57950
		[Token(Token = "0x400E25E")]
		[FieldOffset(Offset = "0x188")]
		public UIButton SuperCarBtn;

		// Token: 0x0400E25F RID: 57951
		[Token(Token = "0x400E25F")]
		[FieldOffset(Offset = "0x190")]
		public GameObject SuperCarTips;

		// Token: 0x0400E260 RID: 57952
		[Token(Token = "0x400E260")]
		[FieldOffset(Offset = "0x198")]
		public Transform SuperCarCountDown;

		// Token: 0x0400E261 RID: 57953
		[Token(Token = "0x400E261")]
		[FieldOffset(Offset = "0x1A0")]
		public Transform OptionalDownloaderContainer;

		// Token: 0x0400E262 RID: 57954
		[Token(Token = "0x400E262")]
		[FieldOffset(Offset = "0x1A8")]
		public UIButton mapModeBtn;

		// Token: 0x0400E263 RID: 57955
		[Token(Token = "0x400E263")]
		[FieldOffset(Offset = "0x1B0")]
		public UISprite mapModeBtnBg;

		// Token: 0x0400E264 RID: 57956
		[Token(Token = "0x400E264")]
		[FieldOffset(Offset = "0x1B8")]
		public UILabel matchModelSelected;

		// Token: 0x0400E265 RID: 57957
		[Token(Token = "0x400E265")]
		[FieldOffset(Offset = "0x1C0")]
		public UISprite matchModeTag;

		// Token: 0x0400E266 RID: 57958
		[Token(Token = "0x400E266")]
		[FieldOffset(Offset = "0x1C8")]
		public GameObject NormalVeiw;

		// Token: 0x0400E267 RID: 57959
		[Token(Token = "0x400E267")]
		[FieldOffset(Offset = "0x1D0")]
		public UILabel gameModeSelected;

		// Token: 0x0400E268 RID: 57960
		[Token(Token = "0x400E268")]
		[FieldOffset(Offset = "0x1D8")]
		public UILabel mapModeSelected;

		// Token: 0x0400E269 RID: 57961
		[Token(Token = "0x400E269")]
		[FieldOffset(Offset = "0x1E0")]
		public GameObject BonusVeiw;

		// Token: 0x0400E26A RID: 57962
		[Token(Token = "0x400E26A")]
		[FieldOffset(Offset = "0x1E8")]
		public UILabel BgameModeSelected;

		// Token: 0x0400E26B RID: 57963
		[Token(Token = "0x400E26B")]
		[FieldOffset(Offset = "0x1F0")]
		public GameObject BonusReward;

		// Token: 0x0400E26C RID: 57964
		[Token(Token = "0x400E26C")]
		[FieldOffset(Offset = "0x1F8")]
		public UILabel ladderExtraBonusTxt;

		// Token: 0x0400E26D RID: 57965
		[Token(Token = "0x400E26D")]
		[FieldOffset(Offset = "0x200")]
		public GameObject ChampionshipBonusReward;

		// Token: 0x0400E26E RID: 57966
		[Token(Token = "0x400E26E")]
		[FieldOffset(Offset = "0x208")]
		public UILabel GoldBonusLabel;

		// Token: 0x0400E26F RID: 57967
		[Token(Token = "0x400E26F")]
		[FieldOffset(Offset = "0x210")]
		public UILabel ExpBonusLabel;

		// Token: 0x0400E270 RID: 57968
		[Token(Token = "0x400E270")]
		[FieldOffset(Offset = "0x218")]
		public UILabel BmapModeSelected;

		// Token: 0x0400E271 RID: 57969
		[Token(Token = "0x400E271")]
		[FieldOffset(Offset = "0x220")]
		public GameObject NoDudectView;

		// Token: 0x0400E272 RID: 57970
		[Token(Token = "0x400E272")]
		[FieldOffset(Offset = "0x228")]
		public GameObject DoubleTokenView;

		// Token: 0x0400E273 RID: 57971
		[Token(Token = "0x400E273")]
		[FieldOffset(Offset = "0x230")]
		public GameObject DoublePointView;

		// Token: 0x0400E274 RID: 57972
		[Token(Token = "0x400E274")]
		[FieldOffset(Offset = "0x238")]
		public UILabel RankRPLabel;

		// Token: 0x0400E275 RID: 57973
		[Token(Token = "0x400E275")]
		[FieldOffset(Offset = "0x240")]
		public UIButton HelperBtn;

		// Token: 0x0400E276 RID: 57974
		[Token(Token = "0x400E276")]
		[FieldOffset(Offset = "0x248")]
		public GameObject MapHintContainer;

		// Token: 0x0400E277 RID: 57975
		[Token(Token = "0x400E277")]
		[FieldOffset(Offset = "0x250")]
		public UILabel NewModeTip;

		// Token: 0x0400E278 RID: 57976
		[Token(Token = "0x400E278")]
		[FieldOffset(Offset = "0x258")]
		public UILabel ActivityTip;

		// Token: 0x0400E279 RID: 57977
		[Token(Token = "0x400E279")]
		[FieldOffset(Offset = "0x260")]
		public GameObject MapModeTipsAnim;

		// Token: 0x0400E27A RID: 57978
		[Token(Token = "0x400E27A")]
		[FieldOffset(Offset = "0x268")]
		public UIWidget RankCompetitionGuide;

		// Token: 0x0400E27B RID: 57979
		[Token(Token = "0x400E27B")]
		[FieldOffset(Offset = "0x270")]
		public UIButton teamModeBtn;

		// Token: 0x0400E27C RID: 57980
		[Token(Token = "0x400E27C")]
		[FieldOffset(Offset = "0x278")]
		public UISprite teamIcon;

		// Token: 0x0400E27D RID: 57981
		[Token(Token = "0x400E27D")]
		[FieldOffset(Offset = "0x280")]
		public GameObject TeamModeTipsAnim;

		// Token: 0x0400E27E RID: 57982
		[Token(Token = "0x400E27E")]
		[FieldOffset(Offset = "0x288")]
		public GameObject teamModesPanel;

		// Token: 0x0400E27F RID: 57983
		[Token(Token = "0x400E27F")]
		[FieldOffset(Offset = "0x290")]
		public UISprite teamIconDulicate;

		// Token: 0x0400E280 RID: 57984
		[Token(Token = "0x400E280")]
		[FieldOffset(Offset = "0x298")]
		public UIToggleButton teamBtn;

		// Token: 0x0400E281 RID: 57985
		[Token(Token = "0x400E281")]
		[FieldOffset(Offset = "0x2A0")]
		public UISprite teamBtnBG;

		// Token: 0x0400E282 RID: 57986
		[Token(Token = "0x400E282")]
		[FieldOffset(Offset = "0x2A8")]
		public UIToggleButton duoBtn;

		// Token: 0x0400E283 RID: 57987
		[Token(Token = "0x400E283")]
		[FieldOffset(Offset = "0x2B0")]
		public UISprite duoBtnBG;

		// Token: 0x0400E284 RID: 57988
		[Token(Token = "0x400E284")]
		[FieldOffset(Offset = "0x2B8")]
		public UIToggleButton soloBtn;

		// Token: 0x0400E285 RID: 57989
		[Token(Token = "0x400E285")]
		[FieldOffset(Offset = "0x2C0")]
		public UISprite soloBtnBG;

		// Token: 0x0400E286 RID: 57990
		[Token(Token = "0x400E286")]
		[FieldOffset(Offset = "0x2C8")]
		public GameObject TipNewModeBtn;

		// Token: 0x0400E287 RID: 57991
		[Token(Token = "0x400E287")]
		[FieldOffset(Offset = "0x2D0")]
		public UILabel TipNewModeLabel;

		// Token: 0x0400E288 RID: 57992
		[Token(Token = "0x400E288")]
		[FieldOffset(Offset = "0x2D8")]
		public UIButton BtnLadderMatch;

		// Token: 0x0400E289 RID: 57993
		[Token(Token = "0x400E289")]
		[FieldOffset(Offset = "0x2E0")]
		public GameObject SpriteLadderMatch;

		// Token: 0x0400E28A RID: 57994
		[Token(Token = "0x400E28A")]
		[FieldOffset(Offset = "0x2E8")]
		public GameObject LadderMatchDaily;

		// Token: 0x0400E28B RID: 57995
		[Token(Token = "0x400E28B")]
		[FieldOffset(Offset = "0x2F0")]
		public UILabel LabelDailyTask;

		// Token: 0x0400E28C RID: 57996
		[Token(Token = "0x400E28C")]
		[FieldOffset(Offset = "0x2F8")]
		public Transform pveMapInfo;

		// Token: 0x0400E28D RID: 57997
		[Token(Token = "0x400E28D")]
		[FieldOffset(Offset = "0x300")]
		public UIButton InviteBtn;

		// Token: 0x0400E28E RID: 57998
		[Token(Token = "0x400E28E")]
		[FieldOffset(Offset = "0x308")]
		public UILabel PlusLabel;

		// Token: 0x0400E28F RID: 57999
		[Token(Token = "0x400E28F")]
		[FieldOffset(Offset = "0x310")]
		public UILabel Label;

		// Token: 0x0400E290 RID: 58000
		[Token(Token = "0x400E290")]
		[FieldOffset(Offset = "0x318")]
		public Transform Left;

		// Token: 0x0400E291 RID: 58001
		[Token(Token = "0x400E291")]
		[FieldOffset(Offset = "0x320")]
		public TweenPosition TweenPosPanelLeft;

		// Token: 0x0400E292 RID: 58002
		[Token(Token = "0x400E292")]
		[FieldOffset(Offset = "0x328")]
		public UIGrid BtnGroupGrid;

		// Token: 0x0400E293 RID: 58003
		[Token(Token = "0x400E293")]
		[FieldOffset(Offset = "0x330")]
		public GameObject Store;

		// Token: 0x0400E294 RID: 58004
		[Token(Token = "0x400E294")]
		[FieldOffset(Offset = "0x338")]
		public Transform VFXMysteryTip;

		// Token: 0x0400E295 RID: 58005
		[Token(Token = "0x400E295")]
		[FieldOffset(Offset = "0x340")]
		public UISprite BgBtnStore;

		// Token: 0x0400E296 RID: 58006
		[Token(Token = "0x400E296")]
		[FieldOffset(Offset = "0x348")]
		public UIButton BtnStore;

		// Token: 0x0400E297 RID: 58007
		[Token(Token = "0x400E297")]
		[FieldOffset(Offset = "0x350")]
		public UISprite StoreIcon;

		// Token: 0x0400E298 RID: 58008
		[Token(Token = "0x400E298")]
		[FieldOffset(Offset = "0x358")]
		public UIWidget ShopGuide;

		// Token: 0x0400E299 RID: 58009
		[Token(Token = "0x400E299")]
		[FieldOffset(Offset = "0x360")]
		public GameObject Gacha;

		// Token: 0x0400E29A RID: 58010
		[Token(Token = "0x400E29A")]
		[FieldOffset(Offset = "0x368")]
		public UIButton BtnGacha;

		// Token: 0x0400E29B RID: 58011
		[Token(Token = "0x400E29B")]
		[FieldOffset(Offset = "0x370")]
		public GameObject GachaNewTips;

		// Token: 0x0400E29C RID: 58012
		[Token(Token = "0x400E29C")]
		[FieldOffset(Offset = "0x378")]
		public UIWidget GachaGuide;

		// Token: 0x0400E29D RID: 58013
		[Token(Token = "0x400E29D")]
		[FieldOffset(Offset = "0x380")]
		public GameObject Avatar;

		// Token: 0x0400E29E RID: 58014
		[Token(Token = "0x400E29E")]
		[FieldOffset(Offset = "0x388")]
		public UIWidget RoleGuide;

		// Token: 0x0400E29F RID: 58015
		[Token(Token = "0x400E29F")]
		[FieldOffset(Offset = "0x390")]
		public UIButton BtnAvatar;

		// Token: 0x0400E2A0 RID: 58016
		[Token(Token = "0x400E2A0")]
		[FieldOffset(Offset = "0x398")]
		public GameObject AvatarNewGO;

		// Token: 0x0400E2A1 RID: 58017
		[Token(Token = "0x400E2A1")]
		[FieldOffset(Offset = "0x3A0")]
		public UIWidget AvatarWidget;

		// Token: 0x0400E2A2 RID: 58018
		[Token(Token = "0x400E2A2")]
		[FieldOffset(Offset = "0x3A8")]
		public Transform AwakenGuideGo;

		// Token: 0x0400E2A3 RID: 58019
		[Token(Token = "0x400E2A3")]
		[FieldOffset(Offset = "0x3B0")]
		public GameObject Valut;

		// Token: 0x0400E2A4 RID: 58020
		[Token(Token = "0x400E2A4")]
		[FieldOffset(Offset = "0x3B8")]
		public UISprite VaultBG;

		// Token: 0x0400E2A5 RID: 58021
		[Token(Token = "0x400E2A5")]
		[FieldOffset(Offset = "0x3C0")]
		public UIButton BtnCustomize;

		// Token: 0x0400E2A6 RID: 58022
		[Token(Token = "0x400E2A6")]
		[FieldOffset(Offset = "0x3C8")]
		public GameObject Reminder;

		// Token: 0x0400E2A7 RID: 58023
		[Token(Token = "0x400E2A7")]
		[FieldOffset(Offset = "0x3D0")]
		public UIWidget VaultGuide;

		// Token: 0x0400E2A8 RID: 58024
		[Token(Token = "0x400E2A8")]
		[FieldOffset(Offset = "0x3D8")]
		public GameObject Pet;

		// Token: 0x0400E2A9 RID: 58025
		[Token(Token = "0x400E2A9")]
		[FieldOffset(Offset = "0x3E0")]
		public GameObject PetNewGO;

		// Token: 0x0400E2AA RID: 58026
		[Token(Token = "0x400E2AA")]
		[FieldOffset(Offset = "0x3E8")]
		public UIButton BtnPet;

		// Token: 0x0400E2AB RID: 58027
		[Token(Token = "0x400E2AB")]
		[FieldOffset(Offset = "0x3F0")]
		public UIWidget PetGuide;

		// Token: 0x0400E2AC RID: 58028
		[Token(Token = "0x400E2AC")]
		[FieldOffset(Offset = "0x3F8")]
		public GameObject Collection;

		// Token: 0x0400E2AD RID: 58029
		[Token(Token = "0x400E2AD")]
		[FieldOffset(Offset = "0x400")]
		public GameObject CollectionNewGO;

		// Token: 0x0400E2AE RID: 58030
		[Token(Token = "0x400E2AE")]
		[FieldOffset(Offset = "0x408")]
		public UIButton BtnCollection;

		// Token: 0x0400E2AF RID: 58031
		[Token(Token = "0x400E2AF")]
		[FieldOffset(Offset = "0x410")]
		public UIWidget CollectGuide;

		// Token: 0x0400E2B0 RID: 58032
		[Token(Token = "0x400E2B0")]
		[FieldOffset(Offset = "0x418")]
		public UIWidget CollectionWidget;

		// Token: 0x0400E2B1 RID: 58033
		[Token(Token = "0x400E2B1")]
		[FieldOffset(Offset = "0x420")]
		public GameObject HDEP;

		// Token: 0x0400E2B2 RID: 58034
		[Token(Token = "0x400E2B2")]
		[FieldOffset(Offset = "0x428")]
		public UIButton BtnEP;

		// Token: 0x0400E2B3 RID: 58035
		[Token(Token = "0x400E2B3")]
		[FieldOffset(Offset = "0x430")]
		public UIWidget EPGuide;

		// Token: 0x0400E2B4 RID: 58036
		[Token(Token = "0x400E2B4")]
		[FieldOffset(Offset = "0x438")]
		public UIWidget EPWidget;

		// Token: 0x0400E2B5 RID: 58037
		[Token(Token = "0x400E2B5")]
		[FieldOffset(Offset = "0x440")]
		public GameObject EPNewTag;

		// Token: 0x0400E2B6 RID: 58038
		[Token(Token = "0x400E2B6")]
		[FieldOffset(Offset = "0x448")]
		public GameObject WeaponSkinMain;

		// Token: 0x0400E2B7 RID: 58039
		[Token(Token = "0x400E2B7")]
		[FieldOffset(Offset = "0x450")]
		public UIButton BtnWeaponSKin;

		// Token: 0x0400E2B8 RID: 58040
		[Token(Token = "0x400E2B8")]
		[FieldOffset(Offset = "0x458")]
		public GameObject WSUUpgradeTag;

		// Token: 0x0400E2B9 RID: 58041
		[Token(Token = "0x400E2B9")]
		[FieldOffset(Offset = "0x460")]
		public GameObject WSUSysNewTag;

		// Token: 0x0400E2BA RID: 58042
		[Token(Token = "0x400E2BA")]
		[FieldOffset(Offset = "0x468")]
		public GameObject MapOpeningContainer;

		// Token: 0x0400E2BB RID: 58043
		[Token(Token = "0x400E2BB")]
		[FieldOffset(Offset = "0x470")]
		public Transform Right;

		// Token: 0x0400E2BC RID: 58044
		[Token(Token = "0x400E2BC")]
		[FieldOffset(Offset = "0x478")]
		public TweenPosition TweenPosPanelRight;

		// Token: 0x0400E2BD RID: 58045
		[Token(Token = "0x400E2BD")]
		[FieldOffset(Offset = "0x480")]
		public UIGrid BtnPanel;

		// Token: 0x0400E2BE RID: 58046
		[Token(Token = "0x400E2BE")]
		[FieldOffset(Offset = "0x488")]
		public UIButton BtnLeadBoard;

		// Token: 0x0400E2BF RID: 58047
		[Token(Token = "0x400E2BF")]
		[FieldOffset(Offset = "0x490")]
		public UIButton BtnEvent;

		// Token: 0x0400E2C0 RID: 58048
		[Token(Token = "0x400E2C0")]
		[FieldOffset(Offset = "0x498")]
		public Animator EventIconAnimator;

		// Token: 0x0400E2C1 RID: 58049
		[Token(Token = "0x400E2C1")]
		[FieldOffset(Offset = "0x4A0")]
		public UISprite EventIcon;

		// Token: 0x0400E2C2 RID: 58050
		[Token(Token = "0x400E2C2")]
		[FieldOffset(Offset = "0x4A8")]
		public GameObject snowman;

		// Token: 0x0400E2C3 RID: 58051
		[Token(Token = "0x400E2C3")]
		[FieldOffset(Offset = "0x4B0")]
		public Transform VFXContainer;

		// Token: 0x0400E2C4 RID: 58052
		[Token(Token = "0x400E2C4")]
		[FieldOffset(Offset = "0x4B8")]
		public UIButton BtnTask;

		// Token: 0x0400E2C5 RID: 58053
		[Token(Token = "0x400E2C5")]
		[FieldOffset(Offset = "0x4C0")]
		public UIWidget TaskGuide;

		// Token: 0x0400E2C6 RID: 58054
		[Token(Token = "0x400E2C6")]
		[FieldOffset(Offset = "0x4C8")]
		public UIButton BtnClan;

		// Token: 0x0400E2C7 RID: 58055
		[Token(Token = "0x400E2C7")]
		[FieldOffset(Offset = "0x4D0")]
		public UIWidget ClanWidget;

		// Token: 0x0400E2C8 RID: 58056
		[Token(Token = "0x400E2C8")]
		[FieldOffset(Offset = "0x4D8")]
		public GameObject ClanIcon;

		// Token: 0x0400E2C9 RID: 58057
		[Token(Token = "0x400E2C9")]
		[FieldOffset(Offset = "0x4E0")]
		public GameObject ClanActivity;

		// Token: 0x0400E2CA RID: 58058
		[Token(Token = "0x400E2CA")]
		[FieldOffset(Offset = "0x4E8")]
		public GameObject ClanActivityEffect;

		// Token: 0x0400E2CB RID: 58059
		[Token(Token = "0x400E2CB")]
		[FieldOffset(Offset = "0x4F0")]
		public UIButton BtnManual;

		// Token: 0x0400E2CC RID: 58060
		[Token(Token = "0x400E2CC")]
		[FieldOffset(Offset = "0x4F8")]
		public UIWidget ManualWidget;

		// Token: 0x0400E2CD RID: 58061
		[Token(Token = "0x400E2CD")]
		[FieldOffset(Offset = "0x500")]
		public GameObject Tag;

		// Token: 0x0400E2CE RID: 58062
		[Token(Token = "0x400E2CE")]
		[FieldOffset(Offset = "0x508")]
		public GameObject Tips;

		// Token: 0x0400E2CF RID: 58063
		[Token(Token = "0x400E2CF")]
		[FieldOffset(Offset = "0x510")]
		public Animator ManualIconAnimator;

		// Token: 0x0400E2D0 RID: 58064
		[Token(Token = "0x400E2D0")]
		[FieldOffset(Offset = "0x518")]
		public GameObject LiveTv;

		// Token: 0x0400E2D1 RID: 58065
		[Token(Token = "0x400E2D1")]
		[FieldOffset(Offset = "0x520")]
		public Animator BubbleAni;

		// Token: 0x0400E2D2 RID: 58066
		[Token(Token = "0x400E2D2")]
		[FieldOffset(Offset = "0x528")]
		public GameObject EsportsOnBubble;

		// Token: 0x0400E2D3 RID: 58067
		[Token(Token = "0x400E2D3")]
		[FieldOffset(Offset = "0x530")]
		public UIPanel EsportsClipPanel;

		// Token: 0x0400E2D4 RID: 58068
		[Token(Token = "0x400E2D4")]
		[FieldOffset(Offset = "0x538")]
		public UILabel EsportsBubbleLabel;

		// Token: 0x0400E2D5 RID: 58069
		[Token(Token = "0x400E2D5")]
		[FieldOffset(Offset = "0x540")]
		public TweenPosition EsportsBubbleTween;

		// Token: 0x0400E2D6 RID: 58070
		[Token(Token = "0x400E2D6")]
		[FieldOffset(Offset = "0x548")]
		public UIButton EsportsBubbleBtn;

		// Token: 0x0400E2D7 RID: 58071
		[Token(Token = "0x400E2D7")]
		[FieldOffset(Offset = "0x550")]
		public UIButton BtnLive;

		// Token: 0x0400E2D8 RID: 58072
		[Token(Token = "0x400E2D8")]
		[FieldOffset(Offset = "0x558")]
		public UIWidget LiveTvWidget;

		// Token: 0x0400E2D9 RID: 58073
		[Token(Token = "0x400E2D9")]
		[FieldOffset(Offset = "0x560")]
		public GameObject VFX_EsportsOnBubble;

		// Token: 0x0400E2DA RID: 58074
		[Token(Token = "0x400E2DA")]
		[FieldOffset(Offset = "0x568")]
		public Transform RightBottom;

		// Token: 0x0400E2DB RID: 58075
		[Token(Token = "0x400E2DB")]
		[FieldOffset(Offset = "0x570")]
		public TweenPosition TweenPosPanelRightBottom;

		// Token: 0x0400E2DC RID: 58076
		[Token(Token = "0x400E2DC")]
		[FieldOffset(Offset = "0x578")]
		public UIButton playBtn;

		// Token: 0x0400E2DD RID: 58077
		[Token(Token = "0x400E2DD")]
		[FieldOffset(Offset = "0x580")]
		public UILabel playLabel;

		// Token: 0x0400E2DE RID: 58078
		[Token(Token = "0x400E2DE")]
		[FieldOffset(Offset = "0x588")]
		public GameObject autoMatch;

		// Token: 0x0400E2DF RID: 58079
		[Token(Token = "0x400E2DF")]
		[FieldOffset(Offset = "0x590")]
		public UIButton checkBtn;

		// Token: 0x0400E2E0 RID: 58080
		[Token(Token = "0x400E2E0")]
		[FieldOffset(Offset = "0x598")]
		public GameObject checkOn;

		// Token: 0x0400E2E1 RID: 58081
		[Token(Token = "0x400E2E1")]
		[FieldOffset(Offset = "0x5A0")]
		public Transform LoadOutContainer;

		// Token: 0x0400E2E2 RID: 58082
		[Token(Token = "0x400E2E2")]
		[FieldOffset(Offset = "0x5A8")]
		public UIWidget LoadoutGuideWidget;

		// Token: 0x0400E2E3 RID: 58083
		[Token(Token = "0x400E2E3")]
		[FieldOffset(Offset = "0x5B0")]
		public GameObject soloPanel;

		// Token: 0x0400E2E4 RID: 58084
		[Token(Token = "0x400E2E4")]
		[FieldOffset(Offset = "0x5B8")]
		public GameObject MatchMaking;

		// Token: 0x0400E2E5 RID: 58085
		[Token(Token = "0x400E2E5")]
		[FieldOffset(Offset = "0x5C0")]
		public UIButton BtnEnterGameSG;

		// Token: 0x0400E2E6 RID: 58086
		[Token(Token = "0x400E2E6")]
		[FieldOffset(Offset = "0x5C8")]
		public UIWidget BtnEnterGameSGWidget;

		// Token: 0x0400E2E7 RID: 58087
		[Token(Token = "0x400E2E7")]
		[FieldOffset(Offset = "0x5D0")]
		public UILabel StartMatchLabel;

		// Token: 0x0400E2E8 RID: 58088
		[Token(Token = "0x400E2E8")]
		[FieldOffset(Offset = "0x5D8")]
		public Transform SoloBonusInfoAttachPoint;

		// Token: 0x0400E2E9 RID: 58089
		[Token(Token = "0x400E2E9")]
		[FieldOffset(Offset = "0x5E0")]
		public GameObject Guide_start_Anim;

		// Token: 0x0400E2EA RID: 58090
		[Token(Token = "0x400E2EA")]
		[FieldOffset(Offset = "0x5E8")]
		public UIWidget IAPBundleContainer;

		// Token: 0x0400E2EB RID: 58091
		[Token(Token = "0x400E2EB")]
		[FieldOffset(Offset = "0x5F0")]
		public UIButton BtnBundleChoose1From3;

		// Token: 0x0400E2EC RID: 58092
		[Token(Token = "0x400E2EC")]
		[FieldOffset(Offset = "0x5F8")]
		public GameObject VFX_BundleChoose1From3_NotCliam;

		// Token: 0x0400E2ED RID: 58093
		[Token(Token = "0x400E2ED")]
		[FieldOffset(Offset = "0x600")]
		public UIButton BtnBundleWeb;

		// Token: 0x0400E2EE RID: 58094
		[Token(Token = "0x400E2EE")]
		[FieldOffset(Offset = "0x608")]
		public UICountDownLabel IAPBundleCountdownLabel;

		// Token: 0x0400E2EF RID: 58095
		[Token(Token = "0x400E2EF")]
		[FieldOffset(Offset = "0x610")]
		public Transform pveWeaponInfo;

		// Token: 0x0400E2F0 RID: 58096
		[Token(Token = "0x400E2F0")]
		[FieldOffset(Offset = "0x618")]
		public GameObject Age18Logo;

		// Token: 0x0400E2F1 RID: 58097
		[Token(Token = "0x400E2F1")]
		[FieldOffset(Offset = "0x620")]
		public GameObject EPContainer;

		// Token: 0x0400E2F2 RID: 58098
		[Token(Token = "0x400E2F2")]
		[FieldOffset(Offset = "0x628")]
		public UIWidget EPGuideWidget;

		// Token: 0x0400E2F3 RID: 58099
		[Token(Token = "0x400E2F3")]
		[FieldOffset(Offset = "0x630")]
		public GameObject EPTaskContainer;

		// Token: 0x0400E2F4 RID: 58100
		[Token(Token = "0x400E2F4")]
		[FieldOffset(Offset = "0x638")]
		public Transform LeftBottom;

		// Token: 0x0400E2F5 RID: 58101
		[Token(Token = "0x400E2F5")]
		[FieldOffset(Offset = "0x640")]
		public UIGrid LeftBottomBtnGroup;

		// Token: 0x0400E2F6 RID: 58102
		[Token(Token = "0x400E2F6")]
		[FieldOffset(Offset = "0x648")]
		public UIButton RewardedVideoBtn;

		// Token: 0x0400E2F7 RID: 58103
		[Token(Token = "0x400E2F7")]
		[FieldOffset(Offset = "0x650")]
		public GameObject RewardedVideoRedDot;

		// Token: 0x0400E2F8 RID: 58104
		[Token(Token = "0x400E2F8")]
		[FieldOffset(Offset = "0x658")]
		public UIButton VeteranSigninBtn;

		// Token: 0x0400E2F9 RID: 58105
		[Token(Token = "0x400E2F9")]
		[FieldOffset(Offset = "0x660")]
		public GameObject VeteranRedDot;

		// Token: 0x0400E2FA RID: 58106
		[Token(Token = "0x400E2FA")]
		[FieldOffset(Offset = "0x668")]
		public UIButton GoogleEngagementRewardsBtn;

		// Token: 0x0400E2FB RID: 58107
		[Token(Token = "0x400E2FB")]
		[FieldOffset(Offset = "0x670")]
		public Animator LeftBottomSideBtnGroup;

		// Token: 0x0400E2FC RID: 58108
		[Token(Token = "0x400E2FC")]
		[FieldOffset(Offset = "0x678")]
		public Transform guidesprite;

		// Token: 0x0400E2FD RID: 58109
		[Token(Token = "0x400E2FD")]
		[FieldOffset(Offset = "0x680")]
		public UIButton webTutorial;

		// Token: 0x0400E2FE RID: 58110
		[Token(Token = "0x400E2FE")]
		[FieldOffset(Offset = "0x688")]
		public UIButton videoTutorial;

		// Token: 0x0400E2FF RID: 58111
		[Token(Token = "0x400E2FF")]
		[FieldOffset(Offset = "0x690")]
		public UIButton BtnTutorial;

		// Token: 0x0400E300 RID: 58112
		[Token(Token = "0x400E300")]
		[FieldOffset(Offset = "0x698")]
		public UIButton PCReplayEntry;

		// Token: 0x0400E301 RID: 58113
		[Token(Token = "0x400E301")]
		[FieldOffset(Offset = "0x6A0")]
		public UIButton TestToggleButton;

		// Token: 0x0400E302 RID: 58114
		[Token(Token = "0x400E302")]
		[FieldOffset(Offset = "0x6A8")]
		public Transform WardrobePanel;

		// Token: 0x0400E303 RID: 58115
		[Token(Token = "0x400E303")]
		[FieldOffset(Offset = "0x6B0")]
		public Transform groupPanel;

		// Token: 0x0400E304 RID: 58116
		[Token(Token = "0x400E304")]
		[FieldOffset(Offset = "0x6B8")]
		public Transform InventoryPanel;

		// Token: 0x0400E305 RID: 58117
		[Token(Token = "0x400E305")]
		[FieldOffset(Offset = "0x6C0")]
		public Transform NewPlayerSigninPanel;

		// Token: 0x0400E306 RID: 58118
		[Token(Token = "0x400E306")]
		[FieldOffset(Offset = "0x6C8")]
		public UIButton BtnStateChange;

		// Token: 0x0400E307 RID: 58119
		[Token(Token = "0x400E307")]
		[FieldOffset(Offset = "0x6D0")]
		public GameObject BtnStateWalk;

		// Token: 0x0400E308 RID: 58120
		[Token(Token = "0x400E308")]
		[FieldOffset(Offset = "0x6D8")]
		public GameObject BtnStateStop;

		// Token: 0x0400E309 RID: 58121
		[Token(Token = "0x400E309")]
		[FieldOffset(Offset = "0x6E0")]
		public UIWidget InviteBoxContainer;

		// Token: 0x0400E30A RID: 58122
		[Token(Token = "0x400E30A")]
		[FieldOffset(Offset = "0x6E8")]
		public UIWidget HDWeaponRack;

		// Token: 0x0400E30B RID: 58123
		[Token(Token = "0x400E30B")]
		[FieldOffset(Offset = "0x6F0")]
		public UIWidget HDVehicleDisplay;

		// Token: 0x0400E30C RID: 58124
		[Token(Token = "0x400E30C")]
		[FieldOffset(Offset = "0x6F8")]
		public Transform EnterAnimContainer;
	}
}
