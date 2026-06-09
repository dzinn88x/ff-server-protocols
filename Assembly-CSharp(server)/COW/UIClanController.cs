using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001721 RID: 5921
	[Token(Token = "0x2001721")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1894", Offset = "0x10F1894")]
	public class UIClanController : UINavigationController, IUIModelDataChangeObserver, IEasyList, ITipsDelegate
	{
		// Token: 0x06006E71 RID: 28273 RVA: 0x0001F1D0 File Offset: 0x0001D3D0
		[Token(Token = "0x6006E71")]
		[Address(RVA = "0x1CEFC04", Offset = "0x1CEFC04", VA = "0x7BBC4EFC04")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006E72 RID: 28274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E72")]
		[Address(RVA = "0x1CEFC54", Offset = "0x1CEFC54", VA = "0x7BBC4EFC54", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006E73 RID: 28275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E73")]
		[Address(RVA = "0x1CF1370", Offset = "0x1CF1370", VA = "0x7BBC4F1370", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006E74 RID: 28276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E74")]
		[Address(RVA = "0x1CF11DC", Offset = "0x1CF11DC", VA = "0x7BBC4F11DC")]
		private void UpdateShareUI()
		{
		}

		// Token: 0x06006E75 RID: 28277 RVA: 0x0001F1E8 File Offset: 0x0001D3E8
		[Token(Token = "0x6006E75")]
		[Address(RVA = "0x1CF164C", Offset = "0x1CF164C", VA = "0x7BBC4F164C", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06006E76 RID: 28278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E76")]
		[Address(RVA = "0x1CF1654", Offset = "0x1CF1654", VA = "0x7BBC4F1654")]
		private void OnClickSetting()
		{
		}

		// Token: 0x06006E77 RID: 28279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E77")]
		[Address(RVA = "0x1CF1714", Offset = "0x1CF1714", VA = "0x7BBC4F1714")]
		private void OnGroupJoin(params object[] data)
		{
		}

		// Token: 0x06006E78 RID: 28280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E78")]
		[Address(RVA = "0x1CF1820", Offset = "0x1CF1820", VA = "0x7BBC4F1820")]
		private void OnKickOutClan(params object[] data)
		{
		}

		// Token: 0x06006E79 RID: 28281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E79")]
		[Address(RVA = "0x1CF19BC", Offset = "0x1CF19BC", VA = "0x7BBC4F19BC")]
		private void OnBtnClanRuleClick()
		{
		}

		// Token: 0x06006E7A RID: 28282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E7A")]
		[Address(RVA = "0x1CF1A78", Offset = "0x1CF1A78", VA = "0x7BBC4F1A78")]
		private void OnShareClick()
		{
		}

		// Token: 0x06006E7B RID: 28283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E7B")]
		[Address(RVA = "0x1CF1DB8", Offset = "0x1CF1DB8", VA = "0x7BBC4F1DB8")]
		private void OnBtnLeaveClanClick()
		{
		}

		// Token: 0x06006E7C RID: 28284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E7C")]
		[Address(RVA = "0x1CF2328", Offset = "0x1CF2328", VA = "0x7BBC4F2328")]
		private void OnBtnDismissClanClick()
		{
		}

		// Token: 0x06006E7D RID: 28285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E7D")]
		[Address(RVA = "0x1CF260C", Offset = "0x1CF260C", VA = "0x7BBC4F260C")]
		private void OnToggleDetailsTabChange()
		{
		}

		// Token: 0x06006E7E RID: 28286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E7E")]
		[Address(RVA = "0x1CF30E0", Offset = "0x1CF30E0", VA = "0x7BBC4F30E0")]
		private void OnToggleRaceTabChange()
		{
		}

		// Token: 0x06006E7F RID: 28287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E7F")]
		[Address(RVA = "0x1CF3384", Offset = "0x1CF3384", VA = "0x7BBC4F3384")]
		private void OnToggleListTabChange()
		{
		}

		// Token: 0x06006E80 RID: 28288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E80")]
		[Address(RVA = "0x1CF3584", Offset = "0x1CF3584", VA = "0x7BBC4F3584")]
		private void RefreshChatAndLogControllers()
		{
		}

		// Token: 0x06006E81 RID: 28289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E81")]
		[Address(RVA = "0x1CF3718", Offset = "0x1CF3718", VA = "0x7BBC4F3718")]
		private void OnToggleChatTabChange()
		{
		}

		// Token: 0x06006E82 RID: 28290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E82")]
		[Address(RVA = "0x1CF3774", Offset = "0x1CF3774", VA = "0x7BBC4F3774")]
		private void OnToggleLogTabChange()
		{
		}

		// Token: 0x06006E83 RID: 28291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E83")]
		[Address(RVA = "0x1CF3924", Offset = "0x1CF3924", VA = "0x7BBC4F3924")]
		private void OnOpenApplyList()
		{
		}

		// Token: 0x06006E84 RID: 28292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E84")]
		[Address(RVA = "0x1CF39C4", Offset = "0x1CF39C4", VA = "0x7BBC4F39C4")]
		private void OnRecruitClick()
		{
		}

		// Token: 0x06006E85 RID: 28293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E85")]
		[Address(RVA = "0x1CF3C60", Offset = "0x1CF3C60", VA = "0x7BBC4F3C60")]
		private void OnClickDetail()
		{
		}

		// Token: 0x06006E86 RID: 28294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E86")]
		[Address(RVA = "0x1CF4344", Offset = "0x1CF4344", VA = "0x7BBC4F4344")]
		private string GetLevelDetailString(ClanLevelData data)
		{
			return null;
		}

		// Token: 0x06006E87 RID: 28295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E87")]
		[Address(RVA = "0x1CF28F8", Offset = "0x1CF28F8", VA = "0x7BBC4F28F8")]
		private void RefreshClanInfo(ClanInfo clanInfo)
		{
		}

		// Token: 0x06006E88 RID: 28296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E88")]
		private void RefreshViewData<DataType>(List<DataType> memberList)
		{
		}

		// Token: 0x06006E89 RID: 28297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E89")]
		[Address(RVA = "0x1CF4D68", Offset = "0x1CF4D68", VA = "0x7BBC4F4D68")]
		private void RefreshClanNum()
		{
		}

		// Token: 0x06006E8A RID: 28298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E8A")]
		[Address(RVA = "0x1CF4F94", Offset = "0x1CF4F94", VA = "0x7BBC4F4F94")]
		private void RefreshDetails(ClanInfo info)
		{
		}

		// Token: 0x06006E8B RID: 28299 RVA: 0x0001F200 File Offset: 0x0001D400
		[Token(Token = "0x6006E8B")]
		[Address(RVA = "0x1CF5508", Offset = "0x1CF5508", VA = "0x7BBC4F5508", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006E8C RID: 28300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E8C")]
		[Address(RVA = "0x1CF5590", Offset = "0x1CF5590", VA = "0x7BBC4F5590", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006E8D RID: 28301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E8D")]
		[Address(RVA = "0x1CF5DBC", Offset = "0x1CF5DBC", VA = "0x7BBC4F5DBC")]
		private void RefreshRaceInfo()
		{
		}

		// Token: 0x06006E8E RID: 28302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E8E")]
		[Address(RVA = "0x1CF60E8", Offset = "0x1CF60E8", VA = "0x7BBC4F60E8")]
		private void UpdateRaceState()
		{
		}

		// Token: 0x06006E8F RID: 28303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E8F")]
		[Address(RVA = "0x1CF626C", Offset = "0x1CF626C", VA = "0x7BBC4F626C", Slot = "41")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006E90 RID: 28304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E90")]
		[Address(RVA = "0x1CF6300", Offset = "0x1CF6300", VA = "0x7BBC4F6300", Slot = "42")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06006E91 RID: 28305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E91")]
		[Address(RVA = "0x1CF6330", Offset = "0x1CF6330", VA = "0x7BBC4F6330")]
		private void OnClickEditName()
		{
		}

		// Token: 0x06006E92 RID: 28306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E92")]
		[Address(RVA = "0x1CF6400", Offset = "0x1CF6400", VA = "0x7BBC4F6400")]
		private void OnClickExtend()
		{
		}

		// Token: 0x06006E93 RID: 28307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E93")]
		[Address(RVA = "0x1CF6CD8", Offset = "0x1CF6CD8", VA = "0x7BBC4F6CD8")]
		public void OnOpenRankList()
		{
		}

		// Token: 0x06006E94 RID: 28308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E94")]
		[Address(RVA = "0x1CF6E78", Offset = "0x1CF6E78", VA = "0x7BBC4F6E78")]
		public void OnClickAddFriend()
		{
		}

		// Token: 0x06006E95 RID: 28309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E95")]
		[Address(RVA = "0x1CF6E8C", Offset = "0x1CF6E8C", VA = "0x7BBC4F6E8C")]
		private void OnClickCheckIn()
		{
		}

		// Token: 0x06006E96 RID: 28310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E96")]
		[Address(RVA = "0x1CF6F2C", Offset = "0x1CF6F2C", VA = "0x7BBC4F6F2C")]
		private void OnClanShopBtnClick()
		{
		}

		// Token: 0x06006E97 RID: 28311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E97")]
		[Address(RVA = "0x1CF7084", Offset = "0x1CF7084", VA = "0x7BBC4F7084")]
		private void OnLuckyBagBtnClick()
		{
		}

		// Token: 0x06006E98 RID: 28312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E98")]
		[Address(RVA = "0x1CF7148", Offset = "0x1CF7148", VA = "0x7BBC4F7148")]
		private void OnClanCurrencyBtnClick(params object[] data)
		{
		}

		// Token: 0x06006E99 RID: 28313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E99")]
		[Address(RVA = "0x1CF7380", Offset = "0x1CF7380", VA = "0x7BBC4F7380", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06006E9A RID: 28314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E9A")]
		[Address(RVA = "0x1CF5F7C", Offset = "0x1CF5F7C", VA = "0x7BBC4F5F7C")]
		private void RefreshClanCurrencyCnt()
		{
		}

		// Token: 0x06006E9B RID: 28315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E9B")]
		[Address(RVA = "0x1CF7598", Offset = "0x1CF7598", VA = "0x7BBC4F7598", Slot = "43")]
		private void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06006E9C RID: 28316 RVA: 0x0001F218 File Offset: 0x0001D418
		[Token(Token = "0x6006E9C")]
		[Address(RVA = "0x1CF75BC", Offset = "0x1CF75BC", VA = "0x7BBC4F75BC")]
		private bool IsPlayLuckyBagAnim()
		{
			return default(bool);
		}

		// Token: 0x06006E9D RID: 28317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E9D")]
		[Address(RVA = "0x1CF7468", Offset = "0x1CF7468", VA = "0x7BBC4F7468")]
		private void PlayLuckyBagAnim()
		{
		}

		// Token: 0x06006E9E RID: 28318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E9E")]
		[Address(RVA = "0x1CF74F4", Offset = "0x1CF74F4", VA = "0x7BBC4F74F4")]
		private void PlayClanSigninAnim()
		{
		}

		// Token: 0x06006E9F RID: 28319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E9F")]
		[Address(RVA = "0x1CF110C", Offset = "0x1CF110C", VA = "0x7BBC4F110C")]
		private void UpdateClanRaceTabWhetherIsOpenning()
		{
		}

		// Token: 0x06006EA0 RID: 28320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EA0")]
		[Address(RVA = "0x1CF12B4", Offset = "0x1CF12B4", VA = "0x7BBC4F12B4")]
		private void UpdateDeputyCaptainButtonState()
		{
		}

		// Token: 0x06006EA1 RID: 28321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EA1")]
		[Address(RVA = "0x1CF75F8", Offset = "0x1CF75F8", VA = "0x7BBC4F75F8")]
		private void OnClickDeputyCaptainApply()
		{
		}

		// Token: 0x06006EA2 RID: 28322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EA2")]
		[Address(RVA = "0x1CF76BC", Offset = "0x1CF76BC", VA = "0x7BBC4F76BC")]
		public UIClanController()
		{
		}

		// Token: 0x06006EA3 RID: 28323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EA3")]
		[Address(RVA = "0x1CF7734", Offset = "0x1CF7734", VA = "0x7BBC4F7734")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114136C", Offset = "0x114136C")]
		private void <RefreshRaceInfo>b__40_0()
		{
		}

		// Token: 0x0400890A RID: 35082
		[Token(Token = "0x400890A")]
		[FieldOffset(Offset = "0xB0")]
		private UIClanViewExt m_View;

		// Token: 0x0400890B RID: 35083
		[Token(Token = "0x400890B")]
		[FieldOffset(Offset = "0xB8")]
		private ClanLuckyBagConfigData m_ClanLuckyBagConfigData;

		// Token: 0x0400890C RID: 35084
		[Token(Token = "0x400890C")]
		[FieldOffset(Offset = "0xC0")]
		private UIPointsRaceController m_RaceController;

		// Token: 0x0400890D RID: 35085
		[Token(Token = "0x400890D")]
		[FieldOffset(Offset = "0xC8")]
		private UIClanChatController m_ChatController;

		// Token: 0x0400890E RID: 35086
		[Token(Token = "0x400890E")]
		[FieldOffset(Offset = "0xD0")]
		private UIClanLogController m_LogController;

		// Token: 0x0400890F RID: 35087
		[Token(Token = "0x400890F")]
		[FieldOffset(Offset = "0xD8")]
		private UIWidget m_DetailBtnWidget;

		// Token: 0x04008910 RID: 35088
		[Token(Token = "0x4008910")]
		[FieldOffset(Offset = "0xE0")]
		private UICommonGuideController m_GuideCtrl;

		// Token: 0x04008911 RID: 35089
		[Token(Token = "0x4008911")]
		[FieldOffset(Offset = "0xE8")]
		private UIModelClan m_ModelClan;

		// Token: 0x04008912 RID: 35090
		[Token(Token = "0x4008912")]
		[FieldOffset(Offset = "0xF0")]
		private bool clanRaceOpened;

		// Token: 0x04008913 RID: 35091
		[Token(Token = "0x4008913")]
		[FieldOffset(Offset = "0xF8")]
		private List<StandardTabItemViewData> m_TabDataList;

		// Token: 0x04008914 RID: 35092
		[Token(Token = "0x4008914")]
		[FieldOffset(Offset = "0x100")]
		private UIStandardTabController m_TabCtrl;

		// Token: 0x02001722 RID: 5922
		[Token(Token = "0x2001722")]
		private enum TabType
		{
			// Token: 0x04008916 RID: 35094
			[Token(Token = "0x4008916")]
			Details,
			// Token: 0x04008917 RID: 35095
			[Token(Token = "0x4008917")]
			List,
			// Token: 0x04008918 RID: 35096
			[Token(Token = "0x4008918")]
			Race
		}

		// Token: 0x02001723 RID: 5923
		[Token(Token = "0x2001723")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F18CC", Offset = "0x10F18CC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006EA5 RID: 28325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006EA5")]
			[Address(RVA = "0x1CF7844", Offset = "0x1CF7844", VA = "0x7BBC4F7844")]
			public <>c()
			{
			}

			// Token: 0x06006EA6 RID: 28326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006EA6")]
			[Address(RVA = "0x1CF784C", Offset = "0x1CF784C", VA = "0x7BBC4F784C")]
			internal void <OnUIInit>b__13_0()
			{
			}

			// Token: 0x06006EA7 RID: 28327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006EA7")]
			[Address(RVA = "0x1CF7924", Offset = "0x1CF7924", VA = "0x7BBC4F7924")]
			internal void <OnUIInit>b__13_1()
			{
			}

			// Token: 0x06006EA8 RID: 28328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006EA8")]
			[Address(RVA = "0x1CF79FC", Offset = "0x1CF79FC", VA = "0x7BBC4F79FC")]
			internal void <OnBtnLeaveClanClick>b__22_0()
			{
			}

			// Token: 0x06006EA9 RID: 28329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006EA9")]
			[Address(RVA = "0x1CF7A9C", Offset = "0x1CF7A9C", VA = "0x7BBC4F7A9C")]
			internal void <OnBtnDismissClanClick>b__23_0()
			{
			}

			// Token: 0x06006EAA RID: 28330 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006EAA")]
			[Address(RVA = "0x1CF7B3C", Offset = "0x1CF7B3C", VA = "0x7BBC4F7B3C")]
			internal void <OnClickExtend>b__45_0()
			{
			}

			// Token: 0x06006EAB RID: 28331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006EAB")]
			[Address(RVA = "0x1CF7B50", Offset = "0x1CF7B50", VA = "0x7BBC4F7B50")]
			internal void <OnClickExtend>b__45_1()
			{
			}

			// Token: 0x04008919 RID: 35097
			[Token(Token = "0x4008919")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIClanController.<>c <>9;

			// Token: 0x0400891A RID: 35098
			[Token(Token = "0x400891A")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__13_0;

			// Token: 0x0400891B RID: 35099
			[Token(Token = "0x400891B")]
			[FieldOffset(Offset = "0x10")]
			public static Action <>9__13_1;

			// Token: 0x0400891C RID: 35100
			[Token(Token = "0x400891C")]
			[FieldOffset(Offset = "0x18")]
			public static Action <>9__22_0;

			// Token: 0x0400891D RID: 35101
			[Token(Token = "0x400891D")]
			[FieldOffset(Offset = "0x20")]
			public static Action <>9__23_0;

			// Token: 0x0400891E RID: 35102
			[Token(Token = "0x400891E")]
			[FieldOffset(Offset = "0x28")]
			public static Action <>9__45_0;

			// Token: 0x0400891F RID: 35103
			[Token(Token = "0x400891F")]
			[FieldOffset(Offset = "0x30")]
			public static Action <>9__45_1;
		}
	}
}
