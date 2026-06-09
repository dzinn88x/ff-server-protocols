using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;
using tcp;

namespace COW
{
	// Token: 0x02001A83 RID: 6787
	[Token(Token = "0x2001A83")]
	public static class UINavigationUtil
	{
		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06008F16 RID: 36630 RVA: 0x00026298 File Offset: 0x00024498
		// (set) Token: 0x06008F17 RID: 36631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009EB")]
		public static UINavigationUtil.UINavigationFrom From
		{
			[Token(Token = "0x6008F16")]
			[Address(RVA = "0x14BD748", Offset = "0x14BD748", VA = "0x7BBBCBD748")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144798", Offset = "0x1144798")]
			get
			{
				return UINavigationUtil.UINavigationFrom.None;
			}
			[Token(Token = "0x6008F17")]
			[Address(RVA = "0x14D91B8", Offset = "0x14D91B8", VA = "0x7BBBCD91B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11447A8", Offset = "0x11447A8")]
			private set
			{
			}
		}

		// Token: 0x06008F18 RID: 36632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F18")]
		[Address(RVA = "0x14C718C", Offset = "0x14C718C", VA = "0x7BBBCC718C")]
		public static void GotoNavigation(UINavigationUtil.UINavigationFrom from, UINavigationUtil.UINavigationPageType to, [Optional] UINavigationUtil.GotoParams gotoParams)
		{
		}

		// Token: 0x06008F19 RID: 36633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F19")]
		[Address(RVA = "0x14DFBC4", Offset = "0x14DFBC4", VA = "0x7BBBCDFBC4")]
		public static void GotoTermsOfService()
		{
		}

		// Token: 0x06008F1A RID: 36634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F1A")]
		[Address(RVA = "0x14DFDA4", Offset = "0x14DFDA4", VA = "0x7BBBCDFDA4")]
		public static void GotoPrivacyPolicy()
		{
		}

		// Token: 0x06008F1B RID: 36635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F1B")]
		[Address(RVA = "0x14D2904", Offset = "0x14D2904", VA = "0x7BBBCD2904")]
		public static void GotoWebView(UINavigationUtil.UINavigationFrom from, string url, [Optional] object extra)
		{
		}

		// Token: 0x06008F1C RID: 36636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F1C")]
		[Address(RVA = "0x14E0568", Offset = "0x14E0568", VA = "0x7BBBCE0568")]
		public static void GotoTutorialWebView(UINavigationUtil.UINavigationFrom from, string url, [Optional] object extra, [Optional] Action callback)
		{
		}

		// Token: 0x06008F1D RID: 36637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F1D")]
		[Address(RVA = "0x14E0720", Offset = "0x14E0720", VA = "0x7BBBCE0720")]
		public static void GotoNavigation(UINavigationUtil.UINavigationFrom from, uint gotoPos, [Optional] string param, [Optional] object extra)
		{
		}

		// Token: 0x06008F1E RID: 36638 RVA: 0x000262B0 File Offset: 0x000244B0
		[Token(Token = "0x6008F1E")]
		[Address(RVA = "0x14BD1C8", Offset = "0x14BD1C8", VA = "0x7BBBCBD1C8")]
		public static uint MakeGoPos(UINavigationUtil.UINavigationPageType mainType, uint subType1 = 0U, uint subType2 = 0U, uint subType3 = 0U)
		{
			return 0U;
		}

		// Token: 0x06008F1F RID: 36639 RVA: 0x000262C8 File Offset: 0x000244C8
		[Token(Token = "0x6008F1F")]
		[Address(RVA = "0x14E087C", Offset = "0x14E087C", VA = "0x7BBBCE087C")]
		public static uint GetMainType(uint gotoPos)
		{
			return 0U;
		}

		// Token: 0x06008F20 RID: 36640 RVA: 0x000262E0 File Offset: 0x000244E0
		[Token(Token = "0x6008F20")]
		[Address(RVA = "0x14E0898", Offset = "0x14E0898", VA = "0x7BBBCE0898")]
		public static uint GetSubType1(uint gotoPos)
		{
			return 0U;
		}

		// Token: 0x06008F21 RID: 36641 RVA: 0x000262F8 File Offset: 0x000244F8
		[Token(Token = "0x6008F21")]
		[Address(RVA = "0x14E08BC", Offset = "0x14E08BC", VA = "0x7BBBCE08BC")]
		private static uint GetSubType2(uint gotoPos)
		{
			return 0U;
		}

		// Token: 0x06008F22 RID: 36642 RVA: 0x00026310 File Offset: 0x00024510
		[Token(Token = "0x6008F22")]
		[Address(RVA = "0x14E08E8", Offset = "0x14E08E8", VA = "0x7BBBCE08E8")]
		private static uint GetSubType3(uint gotoPos)
		{
			return 0U;
		}

		// Token: 0x06008F23 RID: 36643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F23")]
		[Address(RVA = "0x14E0914", Offset = "0x14E0914", VA = "0x7BBBCE0914")]
		public static void ReturnToLobby()
		{
		}

		// Token: 0x06008F24 RID: 36644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F24")]
		[Address(RVA = "0x14D9770", Offset = "0x14D9770", VA = "0x7BBBCD9770")]
		private static void GotoProfilePage(ulong accountId, UINavigationUtil.UINavagationProfileType subType, ulong subtype3)
		{
		}

		// Token: 0x06008F25 RID: 36645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F25")]
		[Address(RVA = "0x14D99FC", Offset = "0x14D99FC", VA = "0x7BBBCD99FC")]
		private static void GotoGroup(UINavigationUtil.UINavigationGroupType groupType)
		{
		}

		// Token: 0x06008F26 RID: 36646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F26")]
		[Address(RVA = "0x14D9B1C", Offset = "0x14D9B1C", VA = "0x7BBBCD9B1C")]
		public static void GotoMall(UINavigationUtil.UINavigationFrom from, UINavigationUtil.UINavigationMallType mallType, uint mallTabType = 0U, uint subType = 0U, [Optional] List<uint> itemIDList, [Optional] List<FriendInfo> lobbySeletFriendList, EGiftStore_BuddyType type = EGiftStore_BuddyType.BT_NONE, CollectionDataManager.ECollectionWeaponType weaponPageFilterType = CollectionDataManager.ECollectionWeaponType.all, uint weaponPageFilterId = 0U)
		{
		}

		// Token: 0x06008F27 RID: 36647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F27")]
		[Address(RVA = "0x14D9F64", Offset = "0x14D9F64", VA = "0x7BBBCD9F64")]
		private static void GotoVault(UINavigationUtil.UINavigationVaultType vaultType, uint bundleItemID)
		{
		}

		// Token: 0x06008F28 RID: 36648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F28")]
		[Address(RVA = "0x14DD16C", Offset = "0x14DD16C", VA = "0x7BBBCDD16C")]
		private static void GotoPet()
		{
		}

		// Token: 0x06008F29 RID: 36649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F29")]
		[Address(RVA = "0x14DD208", Offset = "0x14DD208", VA = "0x7BBBCDD208")]
		private static void GotoGoogleEngagementRewards()
		{
		}

		// Token: 0x06008F2A RID: 36650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F2A")]
		[Address(RVA = "0x14DA0F8", Offset = "0x14DA0F8", VA = "0x7BBBCDA0F8")]
		private static void GotoClan(UINavigationUtil.UINavigationClanType subType, string param)
		{
		}

		// Token: 0x06008F2B RID: 36651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F2B")]
		[Address(RVA = "0x14DA264", Offset = "0x14DA264", VA = "0x7BBBCDA264")]
		private static void GotoPayment(UIPaymentController.Tab tab, UIPaymentBundleType type = UIPaymentBundleType.Default)
		{
		}

		// Token: 0x06008F2C RID: 36652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F2C")]
		[Address(RVA = "0x14DD344", Offset = "0x14DD344", VA = "0x7BBBCDD344")]
		private static void GotoSubscriptionHub(uint store_id = 0U)
		{
		}

		// Token: 0x06008F2D RID: 36653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F2D")]
		[Address(RVA = "0x14DD638", Offset = "0x14DD638", VA = "0x7BBBCDD638")]
		private static void GotoPaymentFirstTimeWindow()
		{
		}

		// Token: 0x06008F2E RID: 36654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F2E")]
		[Address(RVA = "0x14DD6D8", Offset = "0x14DD6D8", VA = "0x7BBBCDD6D8")]
		private static void GotoNewPlayerLevelUpWindow(UINewPlayerController.NewbieTab tab = UINewPlayerController.NewbieTab.UpGrade)
		{
		}

		// Token: 0x06008F2F RID: 36655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F2F")]
		[Address(RVA = "0x14E0994", Offset = "0x14E0994", VA = "0x7BBBCE0994")]
		private static void GotoRebateCard()
		{
		}

		// Token: 0x06008F30 RID: 36656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F30")]
		[Address(RVA = "0x14DB990", Offset = "0x14DB990", VA = "0x7BBBCDB990")]
		private static void GotoIAPBundle([Optional] IAPBundleStoreData data)
		{
		}

		// Token: 0x06008F31 RID: 36657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F31")]
		[Address(RVA = "0x14DD7D0", Offset = "0x14DD7D0", VA = "0x7BBBCDD7D0")]
		private static void GotoRampageStore()
		{
		}

		// Token: 0x06008F32 RID: 36658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F32")]
		[Address(RVA = "0x14E0A7C", Offset = "0x14E0A7C", VA = "0x7BBBCE0A7C")]
		public static void ShowRewards(UINavigationUtil.ShowRewardsParams param)
		{
		}

		// Token: 0x06008F33 RID: 36659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008F33")]
		[Address(RVA = "0x14E10B4", Offset = "0x14E10B4", VA = "0x7BBBCE10B4")]
		private static List<BaseItemInfo> AssembleRewardsList(ExchangeChangeData data)
		{
			return null;
		}

		// Token: 0x06008F34 RID: 36660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008F34")]
		[Address(RVA = "0x14E134C", Offset = "0x14E134C", VA = "0x7BBBCE134C")]
		private static List<CommonRewardItemInfo> FixPetRewardLevel(List<CommonRewardItemInfo> list)
		{
			return null;
		}

		// Token: 0x06008F35 RID: 36661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F35")]
		[Address(RVA = "0x14DFF84", Offset = "0x14DFF84", VA = "0x7BBBCDFF84")]
		private static void OpenWebView(string url, [Optional] UINavigationUtil.WebViewOptions options)
		{
		}

		// Token: 0x06008F36 RID: 36662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F36")]
		[Address(RVA = "0x14DCC2C", Offset = "0x14DCC2C", VA = "0x7BBBCDCC2C")]
		private static void GotoGainItemPreview()
		{
		}

		// Token: 0x06008F37 RID: 36663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F37")]
		[Address(RVA = "0x14DCE38", Offset = "0x14DCE38", VA = "0x7BBBCDCE38")]
		private static void GotoLadderMatch(uint subType1 = 0U, uint subType2 = 0U)
		{
		}

		// Token: 0x06008F38 RID: 36664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F38")]
		[Address(RVA = "0x14DA7E4", Offset = "0x14DA7E4", VA = "0x7BBBCDA7E4")]
		private static void GotoActivityByTabtype(uint tabType, uint id = 0U)
		{
		}

		// Token: 0x06008F39 RID: 36665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F39")]
		[Address(RVA = "0x14DA928", Offset = "0x14DA928", VA = "0x7BBBCDA928")]
		private static void GotoActivity(UIActivityMasterController.ActivityCategory actvType, uint id = 0U)
		{
		}

		// Token: 0x06008F3A RID: 36666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F3A")]
		[Address(RVA = "0x14DD8DC", Offset = "0x14DD8DC", VA = "0x7BBBCDD8DC")]
		private static void GotoMail(uint id = 0U)
		{
		}

		// Token: 0x06008F3B RID: 36667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008F3B")]
		private static T GetActivityPopUpWindow<T>() where T : UIPopupWindowController
		{
			return null;
		}

		// Token: 0x06008F3C RID: 36668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F3C")]
		[Address(RVA = "0x14DAA6C", Offset = "0x14DAA6C", VA = "0x7BBBCDAA6C")]
		private static void GotoFriends(UINavigationUtil.UINavigationFriendType subType, string param)
		{
		}

		// Token: 0x06008F3D RID: 36669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F3D")]
		[Address(RVA = "0x14E1534", Offset = "0x14E1534", VA = "0x7BBBCE1534")]
		private static void GotoFriends_Reunion()
		{
		}

		// Token: 0x06008F3E RID: 36670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F3E")]
		[Address(RVA = "0x14DADAC", Offset = "0x14DADAC", VA = "0x7BBBCDADAC")]
		private static void GotoLoadout()
		{
		}

		// Token: 0x06008F3F RID: 36671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F3F")]
		[Address(RVA = "0x14DAE4C", Offset = "0x14DAE4C", VA = "0x7BBBCDAE4C")]
		private static void GotoSettings()
		{
		}

		// Token: 0x06008F40 RID: 36672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F40")]
		[Address(RVA = "0x14DAF08", Offset = "0x14DAF08", VA = "0x7BBBCDAF08")]
		private static void GotoTutorial()
		{
		}

		// Token: 0x06008F41 RID: 36673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F41")]
		[Address(RVA = "0x14DB164", Offset = "0x14DB164", VA = "0x7BBBCDB164")]
		private static void GotoAvatarProfile(uint avatarid)
		{
		}

		// Token: 0x06008F42 RID: 36674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F42")]
		[Address(RVA = "0x14DB288", Offset = "0x14DB288", VA = "0x7BBBCDB288")]
		private static void GotoElitePassControllers(UINavigationUtil.UINavigationElitePassType subType1, uint subType2)
		{
		}

		// Token: 0x06008F43 RID: 36675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F43")]
		[Address(RVA = "0x14E190C", Offset = "0x14E190C", VA = "0x7BBBCE190C")]
		private static void GotoElitePassPreorder()
		{
		}

		// Token: 0x06008F44 RID: 36676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F44")]
		[Address(RVA = "0x14E17AC", Offset = "0x14E17AC", VA = "0x7BBBCE17AC")]
		private static void GotoElitePassUpgrade()
		{
		}

		// Token: 0x06008F45 RID: 36677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F45")]
		[Address(RVA = "0x14E1C60", Offset = "0x14E1C60", VA = "0x7BBBCE1C60")]
		private static void GotoElitePass()
		{
		}

		// Token: 0x06008F46 RID: 36678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F46")]
		[Address(RVA = "0x14DB3A8", Offset = "0x14DB3A8", VA = "0x7BBBCDB3A8")]
		private static void GotoTask(int tab)
		{
		}

		// Token: 0x06008F47 RID: 36679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F47")]
		[Address(RVA = "0x14DB470", Offset = "0x14DB470", VA = "0x7BBBCDB470")]
		private static void GotoEPTask(int tab)
		{
		}

		// Token: 0x06008F48 RID: 36680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F48")]
		[Address(RVA = "0x14E15D0", Offset = "0x14E15D0", VA = "0x7BBBCE15D0")]
		private static void GotoElitePassPurchaseBadge(uint count = 1U)
		{
		}

		// Token: 0x06008F49 RID: 36681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F49")]
		[Address(RVA = "0x14E1A6C", Offset = "0x14E1A6C", VA = "0x7BBBCE1A6C")]
		private static void GotoElitePassSubscription()
		{
		}

		// Token: 0x06008F4A RID: 36682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008F4A")]
		[Address(RVA = "0x14DB538", Offset = "0x14DB538", VA = "0x7BBBCDB538")]
		public static UIBaseController GotoVeteran(int tab)
		{
			return null;
		}

		// Token: 0x06008F4B RID: 36683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F4B")]
		[Address(RVA = "0x14DDF64", Offset = "0x14DDF64", VA = "0x7BBBCDDF64")]
		public static void GotoChampionshipWarmUp()
		{
		}

		// Token: 0x06008F4C RID: 36684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F4C")]
		[Address(RVA = "0x14DE118", Offset = "0x14DE118", VA = "0x7BBBCDE118")]
		public static void GotoChampionshipDefault()
		{
		}

		// Token: 0x06008F4D RID: 36685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F4D")]
		[Address(RVA = "0x14DDAA8", Offset = "0x14DDAA8", VA = "0x7BBBCDDAA8")]
		public static void GoToMysteryMall()
		{
		}

		// Token: 0x06008F4E RID: 36686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F4E")]
		[Address(RVA = "0x14DEBC0", Offset = "0x14DEBC0", VA = "0x7BBBCDEBC0")]
		private static void GotoGoliath(int tabType, string captainID)
		{
		}

		// Token: 0x06008F4F RID: 36687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F4F")]
		[Address(RVA = "0x14DF048", Offset = "0x14DF048", VA = "0x7BBBCDF048")]
		private static void GotoSuperFighter()
		{
		}

		// Token: 0x06008F50 RID: 36688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F50")]
		[Address(RVA = "0x14E1DC0", Offset = "0x14E1DC0", VA = "0x7BBBCE1DC0")]
		public static void GotoLegendClothVault(LegendClothVaultPageType pageType, uint legendId = 1U)
		{
		}

		// Token: 0x06008F51 RID: 36689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F51")]
		[Address(RVA = "0x14DF17C", Offset = "0x14DF17C", VA = "0x7BBBCDF17C")]
		private static void GoToFFWS(uint subGopos)
		{
		}

		// Token: 0x06008F52 RID: 36690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F52")]
		[Address(RVA = "0x14DF950", Offset = "0x14DF950", VA = "0x7BBBCDF950")]
		private static void GotoSuperCarMain()
		{
		}

		// Token: 0x06008F53 RID: 36691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F53")]
		[Address(RVA = "0x14DEDF4", Offset = "0x14DEDF4", VA = "0x7BBBCDEDF4")]
		public static void GotoMVPDiceGame()
		{
		}

		// Token: 0x06008F54 RID: 36692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F54")]
		[Address(RVA = "0x14D920C", Offset = "0x14D920C", VA = "0x7BBBCD920C")]
		public static void GotoWeaponSkinMain()
		{
		}

		// Token: 0x06008F55 RID: 36693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F55")]
		[Address(RVA = "0x14E1FD4", Offset = "0x14E1FD4", VA = "0x7BBBCE1FD4")]
		public static void GotoWeaponSkinMain(uint skinId)
		{
		}

		// Token: 0x06008F56 RID: 36694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F56")]
		[Address(RVA = "0x14D941C", Offset = "0x14D941C", VA = "0x7BBBCD941C")]
		public static void GotoWeaponSkinUpgrader(SkinOwnAndOpenInfo info)
		{
		}

		// Token: 0x06008F57 RID: 36695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F57")]
		[Address(RVA = "0x14DC9D8", Offset = "0x14DC9D8", VA = "0x7BBBCDC9D8")]
		private static void GotoChampionshipLobby()
		{
		}

		// Token: 0x06008F58 RID: 36696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F58")]
		[Address(RVA = "0x14DBED0", Offset = "0x14DBED0", VA = "0x7BBBCDBED0")]
		private static void GotoChampionship(uint championshipType)
		{
		}

		// Token: 0x06008F59 RID: 36697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F59")]
		[Address(RVA = "0x14DC558", Offset = "0x14DC558", VA = "0x7BBBCDC558")]
		private static void GotoChampionshipOtherTeam(UIChampionshipOtherFormController.NavArgs cpNavArgs)
		{
		}

		// Token: 0x06008F5A RID: 36698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F5A")]
		[Address(RVA = "0x14DC800", Offset = "0x14DC800", VA = "0x7BBBCDC800")]
		private static void GotoChampionshipNormalGameStats([Optional] UIChampionshipGameStatsController.NavArgs args)
		{
		}

		// Token: 0x06008F5B RID: 36699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F5B")]
		[Address(RVA = "0x14DB600", Offset = "0x14DB600", VA = "0x7BBBCDB600")]
		private static void GotoGacha(int subGoPos = -1)
		{
		}

		// Token: 0x06008F5C RID: 36700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F5C")]
		[Address(RVA = "0x14DBD44", Offset = "0x14DBD44", VA = "0x7BBBCDBD44")]
		private static void GotoForge(uint tabType = 0U, uint itemId = 0U)
		{
		}

		// Token: 0x06008F5D RID: 36701 RVA: 0x00026328 File Offset: 0x00024528
		[Token(Token = "0x6008F5D")]
		[Address(RVA = "0x14E21B0", Offset = "0x14E21B0", VA = "0x7BBBCE21B0")]
		public static UINavigationUtil.UINavigationMallTabType ChangeItemtype2MallType(uint itemType)
		{
			return UINavigationUtil.UINavigationMallTabType.MallTabTypeNone;
		}

		// Token: 0x06008F5E RID: 36702 RVA: 0x00026340 File Offset: 0x00024540
		[Token(Token = "0x6008F5E")]
		[Address(RVA = "0x14E221C", Offset = "0x14E221C", VA = "0x7BBBCE221C")]
		public static UINavigationUtil.UINavigationMallTabType ChangeItemtype2MallType(CSSharedItemDataManager.ItemType itemType)
		{
			return UINavigationUtil.UINavigationMallTabType.MallTabTypeNone;
		}

		// Token: 0x06008F5F RID: 36703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F5F")]
		[Address(RVA = "0x14DBB04", Offset = "0x14DBB04", VA = "0x7BBBCDBB04")]
		private static void GotoChat(EChannel.ChannelType channelType, ulong channelID = 0UL, [Optional] MessageInfo info)
		{
		}

		// Token: 0x06008F60 RID: 36704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F60")]
		[Address(RVA = "0x14DCB8C", Offset = "0x14DCB8C", VA = "0x7BBBCDCB8C")]
		private static void GotoRewardedVideo()
		{
		}

		// Token: 0x06008F61 RID: 36705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F61")]
		[Address(RVA = "0x14DCD38", Offset = "0x14DCD38", VA = "0x7BBBCDCD38")]
		private static void GotoLeaderboard(string deepLink)
		{
		}

		// Token: 0x06008F62 RID: 36706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F62")]
		[Address(RVA = "0x14DD2A8", Offset = "0x14DD2A8", VA = "0x7BBBCDD2A8")]
		private static void GotoLiveTv()
		{
		}

		// Token: 0x06008F63 RID: 36707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008F63")]
		[Address(RVA = "0x14E2288", Offset = "0x14E2288", VA = "0x7BBBCE2288")]
		public static string MakeGoToMapModeParam(f matchModeId, l}BQs\u0080\u0082 gameModeId, EMapName mapId = EMapName.EMapParadise, int groupPlayerNum = 0)
		{
			return null;
		}

		// Token: 0x06008F64 RID: 36708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F64")]
		[Address(RVA = "0x14DE2CC", Offset = "0x14DE2CC", VA = "0x7BBBCDE2CC")]
		private static void GotoMapMode(string mapModeIDStr)
		{
		}

		// Token: 0x04009A7C RID: 39548
		[Token(Token = "0x4009A7C")]
		private const int m_RandomMapId = 99;

		// Token: 0x04009A7D RID: 39549
		[Token(Token = "0x4009A7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FA0C", Offset = "0x112FA0C")]
		private static UINavigationUtil.UINavigationFrom <From>k__BackingField;

		// Token: 0x02001A84 RID: 6788
		[Token(Token = "0x2001A84")]
		public enum UINavigationFrom
		{
			// Token: 0x04009A7F RID: 39551
			[Token(Token = "0x4009A7F")]
			None,
			// Token: 0x04009A80 RID: 39552
			[Token(Token = "0x4009A80")]
			Lobby,
			// Token: 0x04009A81 RID: 39553
			[Token(Token = "0x4009A81")]
			DeepLink,
			// Token: 0x04009A82 RID: 39554
			[Token(Token = "0x4009A82")]
			Activity,
			// Token: 0x04009A83 RID: 39555
			[Token(Token = "0x4009A83")]
			IAP,
			// Token: 0x04009A84 RID: 39556
			[Token(Token = "0x4009A84")]
			LobbyAds,
			// Token: 0x04009A85 RID: 39557
			[Token(Token = "0x4009A85")]
			LobbyExtraAds,
			// Token: 0x04009A86 RID: 39558
			[Token(Token = "0x4009A86")]
			MallAds,
			// Token: 0x04009A87 RID: 39559
			[Token(Token = "0x4009A87")]
			Announcement,
			// Token: 0x04009A88 RID: 39560
			[Token(Token = "0x4009A88")]
			SplashBanner,
			// Token: 0x04009A89 RID: 39561
			[Token(Token = "0x4009A89")]
			RollNotice,
			// Token: 0x04009A8A RID: 39562
			[Token(Token = "0x4009A8A")]
			FriendReunionReward,
			// Token: 0x04009A8B RID: 39563
			[Token(Token = "0x4009A8B")]
			ActivityReward,
			// Token: 0x04009A8C RID: 39564
			[Token(Token = "0x4009A8C")]
			Debt,
			// Token: 0x04009A8D RID: 39565
			[Token(Token = "0x4009A8D")]
			ElitePass,
			// Token: 0x04009A8E RID: 39566
			[Token(Token = "0x4009A8E")]
			FirstTimePayment,
			// Token: 0x04009A8F RID: 39567
			[Token(Token = "0x4009A8F")]
			MatchAfterLottery_OpenAll,
			// Token: 0x04009A90 RID: 39568
			[Token(Token = "0x4009A90")]
			MatchAfterLottery_OpenOne,
			// Token: 0x04009A91 RID: 39569
			[Token(Token = "0x4009A91")]
			Clan,
			// Token: 0x04009A92 RID: 39570
			[Token(Token = "0x4009A92")]
			UnlockSkill,
			// Token: 0x04009A93 RID: 39571
			[Token(Token = "0x4009A93")]
			SendGift,
			// Token: 0x04009A94 RID: 39572
			[Token(Token = "0x4009A94")]
			SendGift_Fast,
			// Token: 0x04009A95 RID: 39573
			[Token(Token = "0x4009A95")]
			Mall,
			// Token: 0x04009A96 RID: 39574
			[Token(Token = "0x4009A96")]
			Gacha_OneTime,
			// Token: 0x04009A97 RID: 39575
			[Token(Token = "0x4009A97")]
			Gacha_TenTimes,
			// Token: 0x04009A98 RID: 39576
			[Token(Token = "0x4009A98")]
			ModifyClanName,
			// Token: 0x04009A99 RID: 39577
			[Token(Token = "0x4009A99")]
			ModifyNickname,
			// Token: 0x04009A9A RID: 39578
			[Token(Token = "0x4009A9A")]
			ActivityReward_Festival,
			// Token: 0x04009A9B RID: 39579
			[Token(Token = "0x4009A9B")]
			Forge,
			// Token: 0x04009A9C RID: 39580
			[Token(Token = "0x4009A9C")]
			PreviewCgShow,
			// Token: 0x04009A9D RID: 39581
			[Token(Token = "0x4009A9D")]
			DeleteAccount,
			// Token: 0x04009A9E RID: 39582
			[Token(Token = "0x4009A9E")]
			AnnouncementReward,
			// Token: 0x04009A9F RID: 39583
			[Token(Token = "0x4009A9F")]
			CommonReward,
			// Token: 0x04009AA0 RID: 39584
			[Token(Token = "0x4009AA0")]
			AvatarProfile_GainAvatar,
			// Token: 0x04009AA1 RID: 39585
			[Token(Token = "0x4009AA1")]
			AvatarProfile_GainBundle,
			// Token: 0x04009AA2 RID: 39586
			[Token(Token = "0x4009AA2")]
			AvatarProfile_Vault,
			// Token: 0x04009AA3 RID: 39587
			[Token(Token = "0x4009AA3")]
			ElitePass_BadgePurchase,
			// Token: 0x04009AA4 RID: 39588
			[Token(Token = "0x4009AA4")]
			ElitePass_Challenge,
			// Token: 0x04009AA5 RID: 39589
			[Token(Token = "0x4009AA5")]
			ElitePass_Reward,
			// Token: 0x04009AA6 RID: 39590
			[Token(Token = "0x4009AA6")]
			Friend,
			// Token: 0x04009AA7 RID: 39591
			[Token(Token = "0x4009AA7")]
			Gacha_ExchangeActivity,
			// Token: 0x04009AA8 RID: 39592
			[Token(Token = "0x4009AA8")]
			IAPBundle_Preview,
			// Token: 0x04009AA9 RID: 39593
			[Token(Token = "0x4009AA9")]
			Inventory,
			// Token: 0x04009AAA RID: 39594
			[Token(Token = "0x4009AAA")]
			Lobby_VideoTutorial,
			// Token: 0x04009AAB RID: 39595
			[Token(Token = "0x4009AAB")]
			Lobby_WebTutorial,
			// Token: 0x04009AAC RID: 39596
			[Token(Token = "0x4009AAC")]
			Login_TermsOfService,
			// Token: 0x04009AAD RID: 39597
			[Token(Token = "0x4009AAD")]
			LotteryReward,
			// Token: 0x04009AAE RID: 39598
			[Token(Token = "0x4009AAE")]
			Pet_ModifyName,
			// Token: 0x04009AAF RID: 39599
			[Token(Token = "0x4009AAF")]
			Policy,
			// Token: 0x04009AB0 RID: 39600
			[Token(Token = "0x4009AB0")]
			ProfileTrendItem,
			// Token: 0x04009AB1 RID: 39601
			[Token(Token = "0x4009AB1")]
			LadderMatch_SeasonStats,
			// Token: 0x04009AB2 RID: 39602
			[Token(Token = "0x4009AB2")]
			LadderMatch_SeasonStatsDetail,
			// Token: 0x04009AB3 RID: 39603
			[Token(Token = "0x4009AB3")]
			Setting_TermsOfService,
			// Token: 0x04009AB4 RID: 39604
			[Token(Token = "0x4009AB4")]
			Setting_PrivacyPolicy,
			// Token: 0x04009AB5 RID: 39605
			[Token(Token = "0x4009AB5")]
			Setting_CustomerService,
			// Token: 0x04009AB6 RID: 39606
			[Token(Token = "0x4009AB6")]
			AutoPopup,
			// Token: 0x04009AB7 RID: 39607
			[Token(Token = "0x4009AB7")]
			PopupMenu,
			// Token: 0x04009AB8 RID: 39608
			[Token(Token = "0x4009AB8")]
			LadderMatch_LeaderboardItem,
			// Token: 0x04009AB9 RID: 39609
			[Token(Token = "0x4009AB9")]
			Chat_MessageItem,
			// Token: 0x04009ABA RID: 39610
			[Token(Token = "0x4009ABA")]
			Clan_Item,
			// Token: 0x04009ABB RID: 39611
			[Token(Token = "0x4009ABB")]
			Group_Invite,
			// Token: 0x04009ABC RID: 39612
			[Token(Token = "0x4009ABC")]
			Player_LeaderboardItem,
			// Token: 0x04009ABD RID: 39613
			[Token(Token = "0x4009ABD")]
			LeaderboardItem,
			// Token: 0x04009ABE RID: 39614
			[Token(Token = "0x4009ABE")]
			FriendSearchItem,
			// Token: 0x04009ABF RID: 39615
			[Token(Token = "0x4009ABF")]
			FriendApplyItem,
			// Token: 0x04009AC0 RID: 39616
			[Token(Token = "0x4009AC0")]
			LadderMatch_Rules,
			// Token: 0x04009AC1 RID: 39617
			[Token(Token = "0x4009AC1")]
			LadderLobby,
			// Token: 0x04009AC2 RID: 39618
			[Token(Token = "0x4009AC2")]
			PVEPrepare,
			// Token: 0x04009AC3 RID: 39619
			[Token(Token = "0x4009AC3")]
			PVEWeaponSelection,
			// Token: 0x04009AC4 RID: 39620
			[Token(Token = "0x4009AC4")]
			PaymentActivity,
			// Token: 0x04009AC5 RID: 39621
			[Token(Token = "0x4009AC5")]
			PaymentTotal,
			// Token: 0x04009AC6 RID: 39622
			[Token(Token = "0x4009AC6")]
			PaymentBundle,
			// Token: 0x04009AC7 RID: 39623
			[Token(Token = "0x4009AC7")]
			PaymentRebateCard,
			// Token: 0x04009AC8 RID: 39624
			[Token(Token = "0x4009AC8")]
			Pet_Mall,
			// Token: 0x04009AC9 RID: 39625
			[Token(Token = "0x4009AC9")]
			ActivityGW_Token,
			// Token: 0x04009ACA RID: 39626
			[Token(Token = "0x4009ACA")]
			PveLuckyDraw,
			// Token: 0x04009ACB RID: 39627
			[Token(Token = "0x4009ACB")]
			GoogleEngagementRewards,
			// Token: 0x04009ACC RID: 39628
			[Token(Token = "0x4009ACC")]
			LiveTv,
			// Token: 0x04009ACD RID: 39629
			[Token(Token = "0x4009ACD")]
			LiveTver,
			// Token: 0x04009ACE RID: 39630
			[Token(Token = "0x4009ACE")]
			LobbyExtraAds_1,
			// Token: 0x04009ACF RID: 39631
			[Token(Token = "0x4009ACF")]
			LobbyExtraAds_2,
			// Token: 0x04009AD0 RID: 39632
			[Token(Token = "0x4009AD0")]
			Championship,
			// Token: 0x04009AD1 RID: 39633
			[Token(Token = "0x4009AD1")]
			ChampionshipTeamProfile,
			// Token: 0x04009AD2 RID: 39634
			[Token(Token = "0x4009AD2")]
			ChampionshipGameStats,
			// Token: 0x04009AD3 RID: 39635
			[Token(Token = "0x4009AD3")]
			ManualWeapon,
			// Token: 0x04009AD4 RID: 39636
			[Token(Token = "0x4009AD4")]
			Manual,
			// Token: 0x04009AD5 RID: 39637
			[Token(Token = "0x4009AD5")]
			MallWebBtn,
			// Token: 0x04009AD6 RID: 39638
			[Token(Token = "0x4009AD6")]
			PaymentShop,
			// Token: 0x04009AD7 RID: 39639
			[Token(Token = "0x4009AD7")]
			PaymentDiamondEvent,
			// Token: 0x04009AD8 RID: 39640
			[Token(Token = "0x4009AD8")]
			LinkActivity,
			// Token: 0x04009AD9 RID: 39641
			[Token(Token = "0x4009AD9")]
			GameModeMain,
			// Token: 0x04009ADA RID: 39642
			[Token(Token = "0x4009ADA")]
			ChampionshipLobby,
			// Token: 0x04009ADB RID: 39643
			[Token(Token = "0x4009ADB")]
			VeteranTask,
			// Token: 0x04009ADC RID: 39644
			[Token(Token = "0x4009ADC")]
			VeteranTaskReward,
			// Token: 0x04009ADD RID: 39645
			[Token(Token = "0x4009ADD")]
			Gacha_BuyBuff,
			// Token: 0x04009ADE RID: 39646
			[Token(Token = "0x4009ADE")]
			UpgradeCard,
			// Token: 0x04009ADF RID: 39647
			[Token(Token = "0x4009ADF")]
			PaymentFirstTimeWindow = 97,
			// Token: 0x04009AE0 RID: 39648
			[Token(Token = "0x4009AE0")]
			InviteGroupBox,
			// Token: 0x04009AE1 RID: 39649
			[Token(Token = "0x4009AE1")]
			IAPDiamondPurchase = 100,
			// Token: 0x04009AE2 RID: 39650
			[Token(Token = "0x4009AE2")]
			EPQuest,
			// Token: 0x04009AE3 RID: 39651
			[Token(Token = "0x4009AE3")]
			EPUpgradeReward,
			// Token: 0x04009AE4 RID: 39652
			[Token(Token = "0x4009AE4")]
			CDKeyPopUp,
			// Token: 0x04009AE5 RID: 39653
			[Token(Token = "0x4009AE5")]
			AnniversaryEnter = 105,
			// Token: 0x04009AE6 RID: 39654
			[Token(Token = "0x4009AE6")]
			MysteryMallLuckyDraw,
			// Token: 0x04009AE7 RID: 39655
			[Token(Token = "0x4009AE7")]
			MysteryMall,
			// Token: 0x04009AE8 RID: 39656
			[Token(Token = "0x4009AE8")]
			ThreeYearFestivalEnter,
			// Token: 0x04009AE9 RID: 39657
			[Token(Token = "0x4009AE9")]
			PaymentGrowthFund,
			// Token: 0x04009AEA RID: 39658
			[Token(Token = "0x4009AEA")]
			GrowthFundAd,
			// Token: 0x04009AEB RID: 39659
			[Token(Token = "0x4009AEB")]
			IntegrateGacha,
			// Token: 0x04009AEC RID: 39660
			[Token(Token = "0x4009AEC")]
			WeaponSkinMainEnter = 113,
			// Token: 0x04009AED RID: 39661
			[Token(Token = "0x4009AED")]
			WeaponSkinUpgrader = 115,
			// Token: 0x04009AEE RID: 39662
			[Token(Token = "0x4009AEE")]
			Bounty,
			// Token: 0x04009AEF RID: 39663
			[Token(Token = "0x4009AEF")]
			Gacha_WeaponSkin,
			// Token: 0x04009AF0 RID: 39664
			[Token(Token = "0x4009AF0")]
			PreviewItem,
			// Token: 0x04009AF1 RID: 39665
			[Token(Token = "0x4009AF1")]
			Loadout = 120,
			// Token: 0x04009AF2 RID: 39666
			[Token(Token = "0x4009AF2")]
			ChampionshipNoticeItem = 122,
			// Token: 0x04009AF3 RID: 39667
			[Token(Token = "0x4009AF3")]
			MVPMain,
			// Token: 0x04009AF4 RID: 39668
			[Token(Token = "0x4009AF4")]
			Goliath,
			// Token: 0x04009AF5 RID: 39669
			[Token(Token = "0x4009AF5")]
			InvitationTipsBox,
			// Token: 0x04009AF6 RID: 39670
			[Token(Token = "0x4009AF6")]
			GameFriendItem,
			// Token: 0x04009AF7 RID: 39671
			[Token(Token = "0x4009AF7")]
			PlatformFriendItem,
			// Token: 0x04009AF8 RID: 39672
			[Token(Token = "0x4009AF8")]
			FriendRelationshipGraphItem,
			// Token: 0x04009AF9 RID: 39673
			[Token(Token = "0x4009AF9")]
			RoomObserverItem,
			// Token: 0x04009AFA RID: 39674
			[Token(Token = "0x4009AFA")]
			RoomPlayerItem,
			// Token: 0x04009AFB RID: 39675
			[Token(Token = "0x4009AFB")]
			FFWS,
			// Token: 0x04009AFC RID: 39676
			[Token(Token = "0x4009AFC")]
			SuperFighterMain = 133,
			// Token: 0x04009AFD RID: 39677
			[Token(Token = "0x4009AFD")]
			SuperCar,
			// Token: 0x04009AFE RID: 39678
			[Token(Token = "0x4009AFE")]
			HDVehicleDisplay,
			// Token: 0x04009AFF RID: 39679
			[Token(Token = "0x4009AFF")]
			HDWeaponRack,
			// Token: 0x04009B00 RID: 39680
			[Token(Token = "0x4009B00")]
			Login_Main,
			// Token: 0x04009B01 RID: 39681
			[Token(Token = "0x4009B01")]
			AvatarAwaken
		}

		// Token: 0x02001A85 RID: 6789
		[Token(Token = "0x2001A85")]
		public enum UINavigationPageType
		{
			// Token: 0x04009B03 RID: 39683
			[Token(Token = "0x4009B03")]
			None,
			// Token: 0x04009B04 RID: 39684
			[Token(Token = "0x4009B04")]
			Profile,
			// Token: 0x04009B05 RID: 39685
			[Token(Token = "0x4009B05")]
			Group,
			// Token: 0x04009B06 RID: 39686
			[Token(Token = "0x4009B06")]
			Mall,
			// Token: 0x04009B07 RID: 39687
			[Token(Token = "0x4009B07")]
			Vault,
			// Token: 0x04009B08 RID: 39688
			[Token(Token = "0x4009B08")]
			Clan,
			// Token: 0x04009B09 RID: 39689
			[Token(Token = "0x4009B09")]
			Recharge,
			// Token: 0x04009B0A RID: 39690
			[Token(Token = "0x4009B0A")]
			Activity,
			// Token: 0x04009B0B RID: 39691
			[Token(Token = "0x4009B0B")]
			Friends,
			// Token: 0x04009B0C RID: 39692
			[Token(Token = "0x4009B0C")]
			Loadout,
			// Token: 0x04009B0D RID: 39693
			[Token(Token = "0x4009B0D")]
			Setting,
			// Token: 0x04009B0E RID: 39694
			[Token(Token = "0x4009B0E")]
			Tutorial,
			// Token: 0x04009B0F RID: 39695
			[Token(Token = "0x4009B0F")]
			RebateCard,
			// Token: 0x04009B10 RID: 39696
			[Token(Token = "0x4009B10")]
			AvatarProfile,
			// Token: 0x04009B11 RID: 39697
			[Token(Token = "0x4009B11")]
			ElitePass,
			// Token: 0x04009B12 RID: 39698
			[Token(Token = "0x4009B12")]
			Gacha,
			// Token: 0x04009B13 RID: 39699
			[Token(Token = "0x4009B13")]
			IAPBundle,
			// Token: 0x04009B14 RID: 39700
			[Token(Token = "0x4009B14")]
			Chat,
			// Token: 0x04009B15 RID: 39701
			[Token(Token = "0x4009B15")]
			Forge,
			// Token: 0x04009B16 RID: 39702
			[Token(Token = "0x4009B16")]
			RewardedVideo,
			// Token: 0x04009B17 RID: 39703
			[Token(Token = "0x4009B17")]
			GainItemPreview,
			// Token: 0x04009B18 RID: 39704
			[Token(Token = "0x4009B18")]
			Leaderboard,
			// Token: 0x04009B19 RID: 39705
			[Token(Token = "0x4009B19")]
			LadderMatch,
			// Token: 0x04009B1A RID: 39706
			[Token(Token = "0x4009B1A")]
			IngameDrop,
			// Token: 0x04009B1B RID: 39707
			[Token(Token = "0x4009B1B")]
			Payment = 25,
			// Token: 0x04009B1C RID: 39708
			[Token(Token = "0x4009B1C")]
			Pet,
			// Token: 0x04009B1D RID: 39709
			[Token(Token = "0x4009B1D")]
			ActivityGW,
			// Token: 0x04009B1E RID: 39710
			[Token(Token = "0x4009B1E")]
			GoogleEngagementRewards,
			// Token: 0x04009B1F RID: 39711
			[Token(Token = "0x4009B1F")]
			LiveTv,
			// Token: 0x04009B20 RID: 39712
			[Token(Token = "0x4009B20")]
			Championship = 31,
			// Token: 0x04009B21 RID: 39713
			[Token(Token = "0x4009B21")]
			ChampionshipTeamProfile,
			// Token: 0x04009B22 RID: 39714
			[Token(Token = "0x4009B22")]
			ChampionshipNormalGameStats,
			// Token: 0x04009B23 RID: 39715
			[Token(Token = "0x4009B23")]
			ChampionshipTeamOtherProfile,
			// Token: 0x04009B24 RID: 39716
			[Token(Token = "0x4009B24")]
			ChampionshipGameWinnerDetail,
			// Token: 0x04009B25 RID: 39717
			[Token(Token = "0x4009B25")]
			Task,
			// Token: 0x04009B26 RID: 39718
			[Token(Token = "0x4009B26")]
			ChampionshipLobby,
			// Token: 0x04009B27 RID: 39719
			[Token(Token = "0x4009B27")]
			Veteran,
			// Token: 0x04009B28 RID: 39720
			[Token(Token = "0x4009B28")]
			SubscriptionHub,
			// Token: 0x04009B29 RID: 39721
			[Token(Token = "0x4009B29")]
			PaymentFirstTimeWindow = 41,
			// Token: 0x04009B2A RID: 39722
			[Token(Token = "0x4009B2A")]
			NewPlayerLevelUp,
			// Token: 0x04009B2B RID: 39723
			[Token(Token = "0x4009B2B")]
			EPTask,
			// Token: 0x04009B2C RID: 39724
			[Token(Token = "0x4009B2C")]
			RampageStore = 45,
			// Token: 0x04009B2D RID: 39725
			[Token(Token = "0x4009B2D")]
			Mail,
			// Token: 0x04009B2E RID: 39726
			[Token(Token = "0x4009B2E")]
			AnniversaryAct,
			// Token: 0x04009B2F RID: 39727
			[Token(Token = "0x4009B2F")]
			MystertyMall,
			// Token: 0x04009B30 RID: 39728
			[Token(Token = "0x4009B30")]
			ThreeYearFestivalMain = 50,
			// Token: 0x04009B31 RID: 39729
			[Token(Token = "0x4009B31")]
			Bounty,
			// Token: 0x04009B32 RID: 39730
			[Token(Token = "0x4009B32")]
			IntegrateGacha,
			// Token: 0x04009B33 RID: 39731
			[Token(Token = "0x4009B33")]
			GotoMapMode,
			// Token: 0x04009B34 RID: 39732
			[Token(Token = "0x4009B34")]
			WeaponSkinMain,
			// Token: 0x04009B35 RID: 39733
			[Token(Token = "0x4009B35")]
			WeaponSkinUpgrader,
			// Token: 0x04009B36 RID: 39734
			[Token(Token = "0x4009B36")]
			ChampionshipWarmUp,
			// Token: 0x04009B37 RID: 39735
			[Token(Token = "0x4009B37")]
			ChampionshipDefault,
			// Token: 0x04009B38 RID: 39736
			[Token(Token = "0x4009B38")]
			LadderMatchDetail = 59,
			// Token: 0x04009B39 RID: 39737
			[Token(Token = "0x4009B39")]
			SuperCar = 62,
			// Token: 0x04009B3A RID: 39738
			[Token(Token = "0x4009B3A")]
			Goliath,
			// Token: 0x04009B3B RID: 39739
			[Token(Token = "0x4009B3B")]
			PortraitCloseup,
			// Token: 0x04009B3C RID: 39740
			[Token(Token = "0x4009B3C")]
			MVPStore,
			// Token: 0x04009B3D RID: 39741
			[Token(Token = "0x4009B3D")]
			MVPDiceGame,
			// Token: 0x04009B3E RID: 39742
			[Token(Token = "0x4009B3E")]
			SuperFighter,
			// Token: 0x04009B3F RID: 39743
			[Token(Token = "0x4009B3F")]
			FFWS,
			// Token: 0x04009B40 RID: 39744
			[Token(Token = "0x4009B40")]
			AvatarAwaken,
			// Token: 0x04009B41 RID: 39745
			[Token(Token = "0x4009B41")]
			FFWSMain,
			// Token: 0x04009B42 RID: 39746
			[Token(Token = "0x4009B42")]
			FFWSGuess,
			// Token: 0x04009B43 RID: 39747
			[Token(Token = "0x4009B43")]
			FFWSLive,
			// Token: 0x04009B44 RID: 39748
			[Token(Token = "0x4009B44")]
			FFWSSignIn,
			// Token: 0x04009B45 RID: 39749
			[Token(Token = "0x4009B45")]
			FFWSStore,
			// Token: 0x04009B46 RID: 39750
			[Token(Token = "0x4009B46")]
			FFWSMission,
			// Token: 0x04009B47 RID: 39751
			[Token(Token = "0x4009B47")]
			WebView = 99
		}

		// Token: 0x02001A86 RID: 6790
		[Token(Token = "0x2001A86")]
		public enum UINavagationProfileType
		{
			// Token: 0x04009B49 RID: 39753
			[Token(Token = "0x4009B49")]
			ProfileDefault,
			// Token: 0x04009B4A RID: 39754
			[Token(Token = "0x4009B4A")]
			profileRankHistory,
			// Token: 0x04009B4B RID: 39755
			[Token(Token = "0x4009B4B")]
			ProfileStreamer,
			// Token: 0x04009B4C RID: 39756
			[Token(Token = "0x4009B4C")]
			ProfileChampionshipHistory
		}

		// Token: 0x02001A87 RID: 6791
		[Token(Token = "0x2001A87")]
		public enum UINavigationMallExType
		{
			// Token: 0x04009B4E RID: 39758
			[Token(Token = "0x4009B4E")]
			FFEx = 800000301,
			// Token: 0x04009B4F RID: 39759
			[Token(Token = "0x4009B4F")]
			DrawCardEx,
			// Token: 0x04009B50 RID: 39760
			[Token(Token = "0x4009B50")]
			RankEx,
			// Token: 0x04009B51 RID: 39761
			[Token(Token = "0x4009B51")]
			GachaEx
		}

		// Token: 0x02001A88 RID: 6792
		[Token(Token = "0x2001A88")]
		public enum UINavigationGroupType
		{
			// Token: 0x04009B53 RID: 39763
			[Token(Token = "0x4009B53")]
			GroupDuo = 1,
			// Token: 0x04009B54 RID: 39764
			[Token(Token = "0x4009B54")]
			GroupSquad
		}

		// Token: 0x02001A89 RID: 6793
		[Token(Token = "0x2001A89")]
		public enum UINavigationMallType
		{
			// Token: 0x04009B56 RID: 39766
			[Token(Token = "0x4009B56")]
			MallTypeNone,
			// Token: 0x04009B57 RID: 39767
			[Token(Token = "0x4009B57")]
			MallTypeNormal,
			// Token: 0x04009B58 RID: 39768
			[Token(Token = "0x4009B58")]
			MallTypeWeapon,
			// Token: 0x04009B59 RID: 39769
			[Token(Token = "0x4009B59")]
			MallTypeBox,
			// Token: 0x04009B5A RID: 39770
			[Token(Token = "0x4009B5A")]
			MallTypeGift,
			// Token: 0x04009B5B RID: 39771
			[Token(Token = "0x4009B5B")]
			MallTypeExchange
		}

		// Token: 0x02001A8A RID: 6794
		[Token(Token = "0x2001A8A")]
		public enum UINavigationMallTabType
		{
			// Token: 0x04009B5D RID: 39773
			[Token(Token = "0x4009B5D")]
			MallTabTypeNone,
			// Token: 0x04009B5E RID: 39774
			[Token(Token = "0x4009B5E")]
			MallTabTypeAll,
			// Token: 0x04009B5F RID: 39775
			[Token(Token = "0x4009B5F")]
			MallTabTypeExclusive,
			// Token: 0x04009B60 RID: 39776
			[Token(Token = "0x4009B60")]
			MallTabTypeAds,
			// Token: 0x04009B61 RID: 39777
			[Token(Token = "0x4009B61")]
			MallTabTypeNewItem,
			// Token: 0x04009B62 RID: 39778
			[Token(Token = "0x4009B62")]
			MallTabTypeTreasureBox,
			// Token: 0x04009B63 RID: 39779
			[Token(Token = "0x4009B63")]
			MallTabTypeBundle,
			// Token: 0x04009B64 RID: 39780
			[Token(Token = "0x4009B64")]
			MallTabTypeAvatar,
			// Token: 0x04009B65 RID: 39781
			[Token(Token = "0x4009B65")]
			MallTabTypeClothes,
			// Token: 0x04009B66 RID: 39782
			[Token(Token = "0x4009B66")]
			MallTabTypeWeapon,
			// Token: 0x04009B67 RID: 39783
			[Token(Token = "0x4009B67")]
			MallTabTypeProps,
			// Token: 0x04009B68 RID: 39784
			[Token(Token = "0x4009B68")]
			MallTabTypeCollection,
			// Token: 0x04009B69 RID: 39785
			[Token(Token = "0x4009B69")]
			MallTabTypePet,
			// Token: 0x04009B6A RID: 39786
			[Token(Token = "0x4009B6A")]
			MallTabTypeOther,
			// Token: 0x04009B6B RID: 39787
			[Token(Token = "0x4009B6B")]
			MallTabTypeDiscount,
			// Token: 0x04009B6C RID: 39788
			[Token(Token = "0x4009B6C")]
			MallTabInstallment,
			// Token: 0x04009B6D RID: 39789
			[Token(Token = "0x4009B6D")]
			MallTabTypeSpecialViewStart = 50,
			// Token: 0x04009B6E RID: 39790
			[Token(Token = "0x4009B6E")]
			MallTabTypeGiftLeadBoard,
			// Token: 0x04009B6F RID: 39791
			[Token(Token = "0x4009B6F")]
			MallTabHide = 99
		}

		// Token: 0x02001A8B RID: 6795
		[Token(Token = "0x2001A8B")]
		public enum UINavigationVaultType
		{
			// Token: 0x04009B71 RID: 39793
			[Token(Token = "0x4009B71")]
			ChangeClothes = 1,
			// Token: 0x04009B72 RID: 39794
			[Token(Token = "0x4009B72")]
			ChangeApperance,
			// Token: 0x04009B73 RID: 39795
			[Token(Token = "0x4009B73")]
			SelectBundle
		}

		// Token: 0x02001A8C RID: 6796
		[Token(Token = "0x2001A8C")]
		public enum UINavigationElitePassType
		{
			// Token: 0x04009B75 RID: 39797
			[Token(Token = "0x4009B75")]
			ElitePass = 1,
			// Token: 0x04009B76 RID: 39798
			[Token(Token = "0x4009B76")]
			ElitePassChallenge,
			// Token: 0x04009B77 RID: 39799
			[Token(Token = "0x4009B77")]
			ElitePassPurchaseBadge,
			// Token: 0x04009B78 RID: 39800
			[Token(Token = "0x4009B78")]
			ElitePassUpgrade,
			// Token: 0x04009B79 RID: 39801
			[Token(Token = "0x4009B79")]
			ElitePassPreorder,
			// Token: 0x04009B7A RID: 39802
			[Token(Token = "0x4009B7A")]
			ElitePassSubscription
		}

		// Token: 0x02001A8D RID: 6797
		[Token(Token = "0x2001A8D")]
		public enum UINavigationFriendType
		{
			// Token: 0x04009B7C RID: 39804
			[Token(Token = "0x4009B7C")]
			PlatformFriends = 1,
			// Token: 0x04009B7D RID: 39805
			[Token(Token = "0x4009B7D")]
			GameFriends,
			// Token: 0x04009B7E RID: 39806
			[Token(Token = "0x4009B7E")]
			Requests,
			// Token: 0x04009B7F RID: 39807
			[Token(Token = "0x4009B7F")]
			Search,
			// Token: 0x04009B80 RID: 39808
			[Token(Token = "0x4009B80")]
			Reunion,
			// Token: 0x04009B81 RID: 39809
			[Token(Token = "0x4009B81")]
			Relationship
		}

		// Token: 0x02001A8E RID: 6798
		[Token(Token = "0x2001A8E")]
		public enum UINavigationClanType
		{
			// Token: 0x04009B83 RID: 39811
			[Token(Token = "0x4009B83")]
			Clan = 1,
			// Token: 0x04009B84 RID: 39812
			[Token(Token = "0x4009B84")]
			SrarchClanById
		}

		// Token: 0x02001A8F RID: 6799
		[Token(Token = "0x2001A8F")]
		public enum UINavigationFFWSType
		{
			// Token: 0x04009B86 RID: 39814
			[Token(Token = "0x4009B86")]
			Main = 1,
			// Token: 0x04009B87 RID: 39815
			[Token(Token = "0x4009B87")]
			Guess,
			// Token: 0x04009B88 RID: 39816
			[Token(Token = "0x4009B88")]
			Live,
			// Token: 0x04009B89 RID: 39817
			[Token(Token = "0x4009B89")]
			Task,
			// Token: 0x04009B8A RID: 39818
			[Token(Token = "0x4009B8A")]
			Store,
			// Token: 0x04009B8B RID: 39819
			[Token(Token = "0x4009B8B")]
			SignIn
		}

		// Token: 0x02001A90 RID: 6800
		[Token(Token = "0x2001A90")]
		public class GotoParams
		{
			// Token: 0x06008F65 RID: 36709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F65")]
			[Address(RVA = "0x1AF2B4C", Offset = "0x1AF2B4C", VA = "0x7BBC2F2B4C")]
			public GotoParams()
			{
			}

			// Token: 0x04009B8C RID: 39820
			[Token(Token = "0x4009B8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong SubType1;

			// Token: 0x04009B8D RID: 39821
			[Token(Token = "0x4009B8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong SubType2;

			// Token: 0x04009B8E RID: 39822
			[Token(Token = "0x4009B8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ulong SubType3;

			// Token: 0x04009B8F RID: 39823
			[Token(Token = "0x4009B8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string Param;

			// Token: 0x04009B90 RID: 39824
			[Token(Token = "0x4009B90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public object Extra;
		}

		// Token: 0x02001A91 RID: 6801
		[Token(Token = "0x2001A91")]
		public class ShowRewardsParams
		{
			// Token: 0x06008F66 RID: 36710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F66")]
			[Address(RVA = "0x1AF2B54", Offset = "0x1AF2B54", VA = "0x7BBC2F2B54")]
			public ShowRewardsParams()
			{
			}

			// Token: 0x04009B91 RID: 39825
			[Token(Token = "0x4009B91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint ItemID;

			// Token: 0x04009B92 RID: 39826
			[Token(Token = "0x4009B92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint Count;

			// Token: 0x04009B93 RID: 39827
			[Token(Token = "0x4009B93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ExchangeChangeData Data;
		}

		// Token: 0x02001A92 RID: 6802
		[Token(Token = "0x2001A92")]
		public class WebViewOptions
		{
			// Token: 0x06008F67 RID: 36711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F67")]
			[Address(RVA = "0x1AF2B5C", Offset = "0x1AF2B5C", VA = "0x7BBC2F2B5C")]
			public WebViewOptions()
			{
			}

			// Token: 0x04009B94 RID: 39828
			[Token(Token = "0x4009B94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UINavigationUtil.WebViewOptions.WebViewStyle Style;

			// Token: 0x04009B95 RID: 39829
			[Token(Token = "0x4009B95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool PrefersExternal;

			// Token: 0x04009B96 RID: 39830
			[Token(Token = "0x4009B96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			public bool RecordTime;

			// Token: 0x04009B97 RID: 39831
			[Token(Token = "0x4009B97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string Title;

			// Token: 0x04009B98 RID: 39832
			[Token(Token = "0x4009B98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action CloseCallBack;

			// Token: 0x02001A93 RID: 6803
			[Token(Token = "0x2001A93")]
			public enum WebViewStyle
			{
				// Token: 0x04009B9A RID: 39834
				[Token(Token = "0x4009B9A")]
				Normal,
				// Token: 0x04009B9B RID: 39835
				[Token(Token = "0x4009B9B")]
				Lite,
				// Token: 0x04009B9C RID: 39836
				[Token(Token = "0x4009B9C")]
				Tutorial
			}
		}

		// Token: 0x02001A94 RID: 6804
		[Token(Token = "0x2001A94")]
		public enum UINavigationLadderMatchType
		{
			// Token: 0x04009B9E RID: 39838
			[Token(Token = "0x4009B9E")]
			LadderMatch,
			// Token: 0x04009B9F RID: 39839
			[Token(Token = "0x4009B9F")]
			CSLadderMatch
		}

		// Token: 0x02001A95 RID: 6805
		[Token(Token = "0x2001A95")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F85DC", Offset = "0x10F85DC")]
		private sealed class <>c__DisplayClass45_0
		{
			// Token: 0x06008F68 RID: 36712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F68")]
			[Address(RVA = "0x1AF2980", Offset = "0x1AF2980", VA = "0x7BBC2F2980")]
			public <>c__DisplayClass45_0()
			{
			}

			// Token: 0x06008F69 RID: 36713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F69")]
			[Address(RVA = "0x1AF2988", Offset = "0x1AF2988", VA = "0x7BBC2F2988")]
			internal void <ShowRewards>b__0()
			{
			}

			// Token: 0x06008F6A RID: 36714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F6A")]
			[Address(RVA = "0x1AF29D0", Offset = "0x1AF29D0", VA = "0x7BBC2F29D0")]
			internal void <ShowRewards>b__1()
			{
			}

			// Token: 0x06008F6B RID: 36715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F6B")]
			[Address(RVA = "0x1AF2A14", Offset = "0x1AF2A14", VA = "0x7BBC2F2A14")]
			internal void <ShowRewards>b__2()
			{
			}

			// Token: 0x06008F6C RID: 36716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F6C")]
			[Address(RVA = "0x1AF2AA0", Offset = "0x1AF2AA0", VA = "0x7BBC2F2AA0")]
			internal void <ShowRewards>b__3()
			{
			}

			// Token: 0x04009BA0 RID: 39840
			[Token(Token = "0x4009BA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelMall mall;

			// Token: 0x04009BA1 RID: 39841
			[Token(Token = "0x4009BA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UINavigationUtil.ShowRewardsParams param;
		}

		// Token: 0x02001A96 RID: 6806
		[Token(Token = "0x2001A96")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F85EC", Offset = "0x10F85EC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008F6E RID: 36718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F6E")]
			[Address(RVA = "0x1AF26C0", Offset = "0x1AF26C0", VA = "0x7BBC2F26C0")]
			public <>c()
			{
			}

			// Token: 0x06008F6F RID: 36719 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6008F6F")]
			[Address(RVA = "0x1AF26C8", Offset = "0x1AF26C8", VA = "0x7BBC2F26C8")]
			internal CommonRewardItemInfo <ShowRewards>b__45_4(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x06008F70 RID: 36720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F70")]
			[Address(RVA = "0x1AF26D4", Offset = "0x1AF26D4", VA = "0x7BBC2F26D4")]
			internal void <GotoMVPDiceGame>b__80_0()
			{
			}

			// Token: 0x04009BA2 RID: 39842
			[Token(Token = "0x4009BA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UINavigationUtil.<>c <>9;

			// Token: 0x04009BA3 RID: 39843
			[Token(Token = "0x4009BA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__45_4;

			// Token: 0x04009BA4 RID: 39844
			[Token(Token = "0x4009BA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action <>9__80_0;
		}

		// Token: 0x02001A97 RID: 6807
		[Token(Token = "0x2001A97")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F85FC", Offset = "0x10F85FC")]
		private sealed class <>c__DisplayClass80_0
		{
			// Token: 0x06008F71 RID: 36721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F71")]
			[Address(RVA = "0x1AF2B14", Offset = "0x1AF2B14", VA = "0x7BBC2F2B14")]
			public <>c__DisplayClass80_0()
			{
			}

			// Token: 0x06008F72 RID: 36722 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F72")]
			[Address(RVA = "0x1AF2B1C", Offset = "0x1AF2B1C", VA = "0x7BBC2F2B1C")]
			internal void <GotoMVPDiceGame>b__1(HttpErrorCode e, object o)
			{
			}

			// Token: 0x04009BA5 RID: 39845
			[Token(Token = "0x4009BA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action OpenMVPStore;
		}
	}
}
