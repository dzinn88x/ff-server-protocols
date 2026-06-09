using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017C7 RID: 6087
	[Token(Token = "0x20017C7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2C0C", Offset = "0x10F2C0C")]
	public class UIFriendController : UINavigationController, IUIModelDataChangeObserver, ITipsDelegate, IEasyList
	{
		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x060074D3 RID: 29907 RVA: 0x000206D0 File Offset: 0x0001E8D0
		// (set) Token: 0x060074D4 RID: 29908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700093E")]
		public EFriendTabType CurrentTabType
		{
			[Token(Token = "0x60074D3")]
			[Address(RVA = "0x1DC1F94", Offset = "0x1DC1F94", VA = "0x7BBC5C1F94")]
			get
			{
				return EFriendTabType.eFriend;
			}
			[Token(Token = "0x60074D4")]
			[Address(RVA = "0x1DC1F9C", Offset = "0x1DC1F9C", VA = "0x7BBC5C1F9C")]
			private set
			{
			}
		}

		// Token: 0x060074D5 RID: 29909 RVA: 0x000206E8 File Offset: 0x0001E8E8
		[Token(Token = "0x60074D5")]
		[Address(RVA = "0x1DC27D0", Offset = "0x1DC27D0", VA = "0x7BBC5C27D0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060074D6 RID: 29910 RVA: 0x00020700 File Offset: 0x0001E900
		[Token(Token = "0x60074D6")]
		[Address(RVA = "0x1DC2820", Offset = "0x1DC2820", VA = "0x7BBC5C2820", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x060074D7 RID: 29911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074D7")]
		[Address(RVA = "0x1DC2828", Offset = "0x1DC2828", VA = "0x7BBC5C2828", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060074D8 RID: 29912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074D8")]
		[Address(RVA = "0x1DC35F8", Offset = "0x1DC35F8", VA = "0x7BBC5C35F8")]
		private void InitToggles()
		{
		}

		// Token: 0x060074D9 RID: 29913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074D9")]
		[Address(RVA = "0x1DC3E18", Offset = "0x1DC3E18", VA = "0x7BBC5C3E18", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074DA")]
		[Address(RVA = "0x1DC240C", Offset = "0x1DC240C", VA = "0x7BBC5C240C")]
		private void UpdateShareUI()
		{
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074DB")]
		[Address(RVA = "0x1DC43D4", Offset = "0x1DC43D4", VA = "0x7BBC5C43D4", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060074DC RID: 29916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074DC")]
		[Address(RVA = "0x1DC46E0", Offset = "0x1DC46E0", VA = "0x7BBC5C46E0")]
		private void OnWatchLiveBtnClick()
		{
		}

		// Token: 0x060074DD RID: 29917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074DD")]
		[Address(RVA = "0x1DC46F4", Offset = "0x1DC46F4", VA = "0x7BBC5C46F4")]
		private void OnFriendRelationshipBtnClick()
		{
		}

		// Token: 0x060074DE RID: 29918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074DE")]
		[Address(RVA = "0x1DC4904", Offset = "0x1DC4904", VA = "0x7BBC5C4904")]
		private void OnGetEventReward(params object[] parameters)
		{
		}

		// Token: 0x060074DF RID: 29919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074DF")]
		[Address(RVA = "0x1DC4A78", Offset = "0x1DC4A78", VA = "0x7BBC5C4A78")]
		private void OnGotoPlatformFriends(params object[] parameters)
		{
		}

		// Token: 0x060074E0 RID: 29920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074E0")]
		[Address(RVA = "0x1DC4BAC", Offset = "0x1DC4BAC", VA = "0x7BBC5C4BAC")]
		private void OnSelectPlatformFriend()
		{
		}

		// Token: 0x060074E1 RID: 29921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074E1")]
		[Address(RVA = "0x1DC5990", Offset = "0x1DC5990", VA = "0x7BBC5C5990")]
		private void OnSelectFriend()
		{
		}

		// Token: 0x060074E2 RID: 29922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074E2")]
		[Address(RVA = "0x1DC5AA0", Offset = "0x1DC5AA0", VA = "0x7BBC5C5AA0")]
		private void OnSelectAddFriend()
		{
		}

		// Token: 0x060074E3 RID: 29923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074E3")]
		[Address(RVA = "0x1DC5B90", Offset = "0x1DC5B90", VA = "0x7BBC5C5B90")]
		private void OnSelectShowRelationship()
		{
		}

		// Token: 0x060074E4 RID: 29924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074E4")]
		[Address(RVA = "0x1DC5D24", Offset = "0x1DC5D24", VA = "0x7BBC5C5D24")]
		private void OnSelectFriendReunion()
		{
		}

		// Token: 0x060074E5 RID: 29925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074E5")]
		[Address(RVA = "0x1DC4168", Offset = "0x1DC4168", VA = "0x7BBC5C4168")]
		private void SelectFriendReunion(string param)
		{
		}

		// Token: 0x060074E6 RID: 29926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074E6")]
		[Address(RVA = "0x1DC42A4", Offset = "0x1DC42A4", VA = "0x7BBC5C42A4")]
		private void SelectRelationshipTab()
		{
		}

		// Token: 0x060074E7 RID: 29927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074E7")]
		[Address(RVA = "0x1DC5D9C", Offset = "0x1DC5D9C", VA = "0x7BBC5C5D9C")]
		private void UpdateFriendReunion()
		{
		}

		// Token: 0x060074E8 RID: 29928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074E8")]
		[Address(RVA = "0x1DC6F78", Offset = "0x1DC6F78", VA = "0x7BBC5C6F78")]
		private void HideItemController(UIFriendItemController item)
		{
		}

		// Token: 0x060074E9 RID: 29929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074E9")]
		[Address(RVA = "0x1DC3D58", Offset = "0x1DC3D58", VA = "0x7BBC5C3D58")]
		private void RefreshHint()
		{
		}

		// Token: 0x060074EA RID: 29930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074EA")]
		[Address(RVA = "0x1DC4CB8", Offset = "0x1DC4CB8", VA = "0x7BBC5C4CB8")]
		private void RefreshList(List<FriendAccountInfo> accountList, bool keep_page = false)
		{
		}

		// Token: 0x060074EB RID: 29931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074EB")]
		[Address(RVA = "0x1DC4F34", Offset = "0x1DC4F34", VA = "0x7BBC5C4F34")]
		private void RefreshViewInfo()
		{
		}

		// Token: 0x060074EC RID: 29932 RVA: 0x00020718 File Offset: 0x0001E918
		[Token(Token = "0x60074EC")]
		[Address(RVA = "0x1DC70AC", Offset = "0x1DC70AC", VA = "0x7BBC5C70AC", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074ED")]
		[Address(RVA = "0x1DC7124", Offset = "0x1DC7124", VA = "0x7BBC5C7124", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060074EE RID: 29934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074EE")]
		[Address(RVA = "0x1DC785C", Offset = "0x1DC785C", VA = "0x7BBC5C785C")]
		private void OnOtherClick()
		{
		}

		// Token: 0x060074EF RID: 29935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074EF")]
		[Address(RVA = "0x1DC7AB4", Offset = "0x1DC7AB4", VA = "0x7BBC5C7AB4")]
		private void OnCopyLink()
		{
		}

		// Token: 0x060074F0 RID: 29936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074F0")]
		[Address(RVA = "0x1DC7DB4", Offset = "0x1DC7DB4", VA = "0x7BBC5C7DB4")]
		private void OnInviteClick()
		{
		}

		// Token: 0x060074F1 RID: 29937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074F1")]
		[Address(RVA = "0x1DC7EA4", Offset = "0x1DC7EA4", VA = "0x7BBC5C7EA4")]
		private void OnLineClick()
		{
		}

		// Token: 0x060074F2 RID: 29938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074F2")]
		[Address(RVA = "0x1DC8204", Offset = "0x1DC8204", VA = "0x7BBC5C8204", Slot = "41")]
		private void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x060074F3 RID: 29939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F3")]
		[Address(RVA = "0x1DC8208", Offset = "0x1DC8208", VA = "0x7BBC5C8208", Slot = "42")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060074F4 RID: 29940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074F4")]
		[Address(RVA = "0x1DC82C4", Offset = "0x1DC82C4", VA = "0x7BBC5C82C4", Slot = "43")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074F5")]
		[Address(RVA = "0x1DC82F4", Offset = "0x1DC82F4", VA = "0x7BBC5C82F4")]
		private void OnAddFriendsBtnClicked()
		{
		}

		// Token: 0x060074F6 RID: 29942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074F6")]
		[Address(RVA = "0x1DC8420", Offset = "0x1DC8420", VA = "0x7BBC5C8420")]
		private void OnSearchFriendBtnClicked()
		{
		}

		// Token: 0x060074F7 RID: 29943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074F7")]
		[Address(RVA = "0x1DC8890", Offset = "0x1DC8890", VA = "0x7BBC5C8890")]
		private void OnSearchInputGetFocus()
		{
		}

		// Token: 0x060074F8 RID: 29944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074F8")]
		[Address(RVA = "0x1DC8920", Offset = "0x1DC8920", VA = "0x7BBC5C8920")]
		private void OnSearchInputChange()
		{
		}

		// Token: 0x060074F9 RID: 29945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074F9")]
		[Address(RVA = "0x1DC3B4C", Offset = "0x1DC3B4C", VA = "0x7BBC5C3B4C")]
		private void CheckFriendTabGuide()
		{
		}

		// Token: 0x060074FA RID: 29946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074FA")]
		[Address(RVA = "0x1DC89E0", Offset = "0x1DC89E0", VA = "0x7BBC5C89E0")]
		public UIFriendController()
		{
		}

		// Token: 0x04008C82 RID: 35970
		[Token(Token = "0x4008C82")]
		[FieldOffset(Offset = "0xB0")]
		private UIFriendViewExt m_View;

		// Token: 0x04008C83 RID: 35971
		[Token(Token = "0x4008C83")]
		[FieldOffset(Offset = "0xB8")]
		private UIRelationshipController m_RelationShipController;

		// Token: 0x04008C84 RID: 35972
		[Token(Token = "0x4008C84")]
		[FieldOffset(Offset = "0xC0")]
		private List<StandardTabItemViewData> m_TabDataList;

		// Token: 0x04008C85 RID: 35973
		[Token(Token = "0x4008C85")]
		[FieldOffset(Offset = "0xC8")]
		private UIStandardTabController m_TabCtrl;

		// Token: 0x04008C86 RID: 35974
		[Token(Token = "0x4008C86")]
		[FieldOffset(Offset = "0xD0")]
		private UICountDownController m_CallbackCountdown;

		// Token: 0x04008C87 RID: 35975
		[Token(Token = "0x4008C87")]
		[FieldOffset(Offset = "0xD8")]
		private UIAddFriendController m_AddFriendController;

		// Token: 0x04008C88 RID: 35976
		[Token(Token = "0x4008C88")]
		[FieldOffset(Offset = "0xE0")]
		private EFriendTabType m_CurrentType;

		// Token: 0x04008C89 RID: 35977
		[Token(Token = "0x4008C89")]
		private const string FACEBOOK_ICON_SPRITENAME = "FF_FaceBookIcon";

		// Token: 0x04008C8A RID: 35978
		[Token(Token = "0x4008C8A")]
		private const string VK_ICON_SPRITENAME = "FF_VKIcon";

		// Token: 0x04008C8B RID: 35979
		[Token(Token = "0x4008C8B")]
		private const string GPLUS_ICON_SPRITENAME = "";

		// Token: 0x04008C8C RID: 35980
		[Token(Token = "0x4008C8C")]
		private const int MAX_FRIEND_REQUESTS = 100;

		// Token: 0x04008C8D RID: 35981
		[Token(Token = "0x4008C8D")]
		[FieldOffset(Offset = "0xE8")]
		private string m_InviterUIDFromLink;

		// Token: 0x04008C8E RID: 35982
		[Token(Token = "0x4008C8E")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_IsFirstOpen;

		// Token: 0x04008C8F RID: 35983
		[Token(Token = "0x4008C8F")]
		[FieldOffset(Offset = "0xF1")]
		private bool m_IsFirstNavigationShow;

		// Token: 0x04008C90 RID: 35984
		[Token(Token = "0x4008C90")]
		[FieldOffset(Offset = "0xF4")]
		private int m_scrollWidth;

		// Token: 0x04008C91 RID: 35985
		[Token(Token = "0x4008C91")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_HasSearch;

		// Token: 0x04008C92 RID: 35986
		[Token(Token = "0x4008C92")]
		[FieldOffset(Offset = "0xFC")]
		private uint m_WinkCall;

		// Token: 0x04008C93 RID: 35987
		[Token(Token = "0x4008C93")]
		[FieldOffset(Offset = "0x100")]
		private bool m_isFriendReunionDirty;

		// Token: 0x04008C94 RID: 35988
		[Token(Token = "0x4008C94")]
		private const float REWARDBACKDARK = 0.4f;

		// Token: 0x04008C95 RID: 35989
		[Token(Token = "0x4008C95")]
		private const float REWARDBACKLIGHT = 0.3f;

		// Token: 0x04008C96 RID: 35990
		[Token(Token = "0x4008C96")]
		[FieldOffset(Offset = "0x108")]
		private UICommonGuideController m_RelationshipGraphGuide;

		// Token: 0x04008C97 RID: 35991
		[Token(Token = "0x4008C97")]
		[FieldOffset(Offset = "0x110")]
		private List<UIBaseController> m_FriendReunionControllers;

		// Token: 0x020017C8 RID: 6088
		[Token(Token = "0x20017C8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F2C44", Offset = "0x10F2C44")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060074FC RID: 29948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60074FC")]
			[Address(RVA = "0x158E0D0", Offset = "0x158E0D0", VA = "0x7BBBD8E0D0")]
			public <>c()
			{
			}

			// Token: 0x060074FD RID: 29949 RVA: 0x00020730 File Offset: 0x0001E930
			[Token(Token = "0x60074FD")]
			[Address(RVA = "0x158E0D8", Offset = "0x158E0D8", VA = "0x7BBBD8E0D8")]
			internal bool <OnGotoPlatformFriends>b__34_0(StandardTabItemViewData x)
			{
				return default(bool);
			}

			// Token: 0x060074FE RID: 29950 RVA: 0x00020748 File Offset: 0x0001E948
			[Token(Token = "0x60074FE")]
			[Address(RVA = "0x158E144", Offset = "0x158E144", VA = "0x7BBBD8E144")]
			internal bool <SelectFriendReunion>b__40_0(StandardTabItemViewData x)
			{
				return default(bool);
			}

			// Token: 0x060074FF RID: 29951 RVA: 0x00020760 File Offset: 0x0001E960
			[Token(Token = "0x60074FF")]
			[Address(RVA = "0x158E1B0", Offset = "0x158E1B0", VA = "0x7BBBD8E1B0")]
			internal bool <SelectRelationshipTab>b__41_0(StandardTabItemViewData x)
			{
				return default(bool);
			}

			// Token: 0x06007500 RID: 29952 RVA: 0x00020778 File Offset: 0x0001E978
			[Token(Token = "0x6007500")]
			[Address(RVA = "0x158E21C", Offset = "0x158E21C", VA = "0x7BBBD8E21C")]
			internal bool <RefreshViewInfo>b__47_0(FriendAccountInfo x)
			{
				return default(bool);
			}

			// Token: 0x06007501 RID: 29953 RVA: 0x00020790 File Offset: 0x0001E990
			[Token(Token = "0x6007501")]
			[Address(RVA = "0x158E250", Offset = "0x158E250", VA = "0x7BBBD8E250")]
			internal bool <RefreshViewInfo>b__47_1(FriendAccountInfo x)
			{
				return default(bool);
			}

			// Token: 0x06007502 RID: 29954 RVA: 0x000207A8 File Offset: 0x0001E9A8
			[Token(Token = "0x6007502")]
			[Address(RVA = "0x158E284", Offset = "0x158E284", VA = "0x7BBBD8E284")]
			internal bool <OnDataChanged>b__49_0(StandardTabItemViewData x)
			{
				return default(bool);
			}

			// Token: 0x06007503 RID: 29955 RVA: 0x000207C0 File Offset: 0x0001E9C0
			[Token(Token = "0x6007503")]
			[Address(RVA = "0x158E2F0", Offset = "0x158E2F0", VA = "0x7BBBD8E2F0")]
			internal bool <OnDataChanged>b__49_1(StandardTabItemViewData x)
			{
				return default(bool);
			}

			// Token: 0x06007504 RID: 29956 RVA: 0x000207D8 File Offset: 0x0001E9D8
			[Token(Token = "0x6007504")]
			[Address(RVA = "0x158E35C", Offset = "0x158E35C", VA = "0x7BBBD8E35C")]
			internal bool <OnDataChanged>b__49_2(StandardTabItemViewData x)
			{
				return default(bool);
			}

			// Token: 0x04008C98 RID: 35992
			[Token(Token = "0x4008C98")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIFriendController.<>c <>9;

			// Token: 0x04008C99 RID: 35993
			[Token(Token = "0x4008C99")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<StandardTabItemViewData> <>9__34_0;

			// Token: 0x04008C9A RID: 35994
			[Token(Token = "0x4008C9A")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<StandardTabItemViewData> <>9__40_0;

			// Token: 0x04008C9B RID: 35995
			[Token(Token = "0x4008C9B")]
			[FieldOffset(Offset = "0x18")]
			public static Predicate<StandardTabItemViewData> <>9__41_0;

			// Token: 0x04008C9C RID: 35996
			[Token(Token = "0x4008C9C")]
			[FieldOffset(Offset = "0x20")]
			public static Predicate<FriendAccountInfo> <>9__47_0;

			// Token: 0x04008C9D RID: 35997
			[Token(Token = "0x4008C9D")]
			[FieldOffset(Offset = "0x28")]
			public static Predicate<FriendAccountInfo> <>9__47_1;

			// Token: 0x04008C9E RID: 35998
			[Token(Token = "0x4008C9E")]
			[FieldOffset(Offset = "0x30")]
			public static Predicate<StandardTabItemViewData> <>9__49_0;

			// Token: 0x04008C9F RID: 35999
			[Token(Token = "0x4008C9F")]
			[FieldOffset(Offset = "0x38")]
			public static Predicate<StandardTabItemViewData> <>9__49_1;

			// Token: 0x04008CA0 RID: 36000
			[Token(Token = "0x4008CA0")]
			[FieldOffset(Offset = "0x40")]
			public static Predicate<StandardTabItemViewData> <>9__49_2;
		}
	}
}
