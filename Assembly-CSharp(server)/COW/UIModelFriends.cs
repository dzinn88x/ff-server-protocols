using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x02001E69 RID: 7785
	[Token(Token = "0x2001E69")]
	public class UIModelFriends : UIBaseModel
	{
		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x0600AAD7 RID: 43735 RVA: 0x0002ED10 File Offset: 0x0002CF10
		// (set) Token: 0x0600AAD8 RID: 43736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B46")]
		public bool HasOpenFriendRelationshipGraph
		{
			[Token(Token = "0x600AAD7")]
			[Address(RVA = "0x23ACF9C", Offset = "0x23ACF9C", VA = "0x7BBCBACF9C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600AAD8")]
			[Address(RVA = "0x23ACFA4", Offset = "0x23ACFA4", VA = "0x7BBCBACFA4")]
			set
			{
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x0600AAD9 RID: 43737 RVA: 0x0002ED28 File Offset: 0x0002CF28
		// (set) Token: 0x0600AADA RID: 43738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B47")]
		public int CurRecentPlayersMatchTimes
		{
			[Token(Token = "0x600AAD9")]
			[Address(RVA = "0x23AD038", Offset = "0x23AD038", VA = "0x7BBCBAD038")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600AADA")]
			[Address(RVA = "0x23AD040", Offset = "0x23AD040", VA = "0x7BBCBAD040")]
			set
			{
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x0600AADB RID: 43739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B48")]
		public List<FriendAccountInfo> FriendAccountInfoList
		{
			[Token(Token = "0x600AADB")]
			[Address(RVA = "0x23AD048", Offset = "0x23AD048", VA = "0x7BBCBAD048")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x0600AADC RID: 43740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B49")]
		public List<FriendAccountInfo> GameAccountInfoList
		{
			[Token(Token = "0x600AADC")]
			[Address(RVA = "0x23AD050", Offset = "0x23AD050", VA = "0x7BBCBAD050")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x0600AADD RID: 43741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4A")]
		public List<FriendAccountInfo> FaceBookFriendAccoutInfoList
		{
			[Token(Token = "0x600AADD")]
			[Address(RVA = "0x23AD058", Offset = "0x23AD058", VA = "0x7BBCBAD058")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x0600AADE RID: 43742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4B")]
		public List<FriendAccountInfo> FriendRequestAccountInfoList
		{
			[Token(Token = "0x600AADE")]
			[Address(RVA = "0x23AD060", Offset = "0x23AD060", VA = "0x7BBCBAD060")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x0600AADF RID: 43743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4C")]
		public List<FriendAccountInfo> BlackListAccountInfo
		{
			[Token(Token = "0x600AADF")]
			[Address(RVA = "0x23AD068", Offset = "0x23AD068", VA = "0x7BBCBAD068")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x0600AAE0 RID: 43744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4D")]
		public List<FriendAccountInfo> OnlineFriendAccountInfoList
		{
			[Token(Token = "0x600AAE0")]
			[Address(RVA = "0x23AD070", Offset = "0x23AD070", VA = "0x7BBCBAD070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x0600AAE1 RID: 43745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4E")]
		public List<FriendAccountInfo> SearchAccountResultList
		{
			[Token(Token = "0x600AAE1")]
			[Address(RVA = "0x23AD078", Offset = "0x23AD078", VA = "0x7BBCBAD078")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x0600AAE2 RID: 43746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4F")]
		public List<ulong> RequestedAndBlockedList
		{
			[Token(Token = "0x600AAE2")]
			[Address(RVA = "0x23AD080", Offset = "0x23AD080", VA = "0x7BBCBAD080")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x0600AAE3 RID: 43747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B50")]
		public List<FriendAccountInfo> FollowAccoutInfoList
		{
			[Token(Token = "0x600AAE3")]
			[Address(RVA = "0x23AD088", Offset = "0x23AD088", VA = "0x7BBCBAD088")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x0600AAE4 RID: 43748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B51")]
		public List<ulong> FavorAccountIDs
		{
			[Token(Token = "0x600AAE4")]
			[Address(RVA = "0x23AD090", Offset = "0x23AD090", VA = "0x7BBCBAD090")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AAE5 RID: 43749 RVA: 0x0002ED40 File Offset: 0x0002CF40
		[Token(Token = "0x600AAE5")]
		[Address(RVA = "0x23AD098", Offset = "0x23AD098", VA = "0x7BBCBAD098")]
		public bool IsFavorFriend(ulong accountID)
		{
			return default(bool);
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x0600AAE6 RID: 43750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B52")]
		public static string FriendInvitationPush
		{
			[Token(Token = "0x600AAE6")]
			[Address(RVA = "0x23AD108", Offset = "0x23AD108", VA = "0x7BBCBAD108")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x0600AAE7 RID: 43751 RVA: 0x0002ED58 File Offset: 0x0002CF58
		[Token(Token = "0x17000B53")]
		public int BlackListCount
		{
			[Token(Token = "0x600AAE7")]
			[Address(RVA = "0x23AD1F4", Offset = "0x23AD1F4", VA = "0x7BBCBAD1F4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x0600AAE8 RID: 43752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B54")]
		public List<RecentPlayerInfo> RecentPlayerInfoList
		{
			[Token(Token = "0x600AAE8")]
			[Address(RVA = "0x23AD1FC", Offset = "0x23AD1FC", VA = "0x7BBCBAD1FC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AAE9 RID: 43753 RVA: 0x0002ED70 File Offset: 0x0002CF70
		[Token(Token = "0x600AAE9")]
		[Address(RVA = "0x23AD3CC", Offset = "0x23AD3CC", VA = "0x7BBCBAD3CC", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600AAEA RID: 43754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAEA")]
		[Address(RVA = "0x23AD3D4", Offset = "0x23AD3D4", VA = "0x7BBCBAD3D4", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600AAEB RID: 43755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAEB")]
		[Address(RVA = "0x23AD574", Offset = "0x23AD574", VA = "0x7BBCBAD574", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600AAEC RID: 43756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAEC")]
		[Address(RVA = "0x23AD8D0", Offset = "0x23AD8D0", VA = "0x7BBCBAD8D0")]
		public void SendInviteToGameLink(PlatformType platformType)
		{
		}

		// Token: 0x0600AAED RID: 43757 RVA: 0x0002ED88 File Offset: 0x0002CF88
		[Token(Token = "0x600AAED")]
		[Address(RVA = "0x23ADCA8", Offset = "0x23ADCA8", VA = "0x7BBCBADCA8")]
		public int LastInGameAddedRecentPlayersCount()
		{
			return 0;
		}

		// Token: 0x0600AAEE RID: 43758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAEE")]
		[Address(RVA = "0x23ADE18", Offset = "0x23ADE18", VA = "0x7BBCBADE18")]
		public void AddRecentPlayersFrontEnd()
		{
		}

		// Token: 0x0600AAEF RID: 43759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AAEF")]
		[Address(RVA = "0x23AE738", Offset = "0x23AE738", VA = "0x7BBCBAE738")]
		public List<FriendAccountInfo> GetRecentAccoutInfoList()
		{
			return null;
		}

		// Token: 0x0600AAF0 RID: 43760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF0")]
		[Address(RVA = "0x23AE928", Offset = "0x23AE928", VA = "0x7BBCBAE928")]
		public void RefreshRecentPlayersPresence(bool forceUpdate = false)
		{
		}

		// Token: 0x0600AAF1 RID: 43761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF1")]
		[Address(RVA = "0x23AED64", Offset = "0x23AED64", VA = "0x7BBCBAED64")]
		public void AddRecentPlayers(ERecentPlayerType type, List<ulong> ids)
		{
		}

		// Token: 0x0600AAF2 RID: 43762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF2")]
		[Address(RVA = "0x23AEDE0", Offset = "0x23AEDE0", VA = "0x7BBCBAEDE0")]
		public void AddRecentPlayers(ERecentPlayerType type, params ulong[] ids)
		{
		}

		// Token: 0x0600AAF3 RID: 43763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF3")]
		[Address(RVA = "0x23AE038", Offset = "0x23AE038", VA = "0x7BBCBAE038")]
		public void AddRecentPlayersFrontEnd(ERecentPlayerType type, params ulong[] ids)
		{
		}

		// Token: 0x0600AAF4 RID: 43764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF4")]
		[Address(RVA = "0x23AF0C4", Offset = "0x23AF0C4", VA = "0x7BBCBAF0C4")]
		public void RefreshAllFriendList(bool forceRefresh = false, bool isSilence = false, UIModelFriends.EFriendRequestOption requestOption = UIModelFriends.EFriendRequestOption.OnlyID)
		{
		}

		// Token: 0x0600AAF5 RID: 43765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF5")]
		[Address(RVA = "0x23AEB5C", Offset = "0x23AEB5C", VA = "0x7BBCBAEB5C")]
		public void RequestFriendInfosPresence(EPresenceListType type, ulong[] ids, bool forceUpdate = false)
		{
		}

		// Token: 0x0600AAF6 RID: 43766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF6")]
		[Address(RVA = "0x23AFA58", Offset = "0x23AFA58", VA = "0x7BBCBAFA58")]
		private void RequestRefreshFriendPresences()
		{
		}

		// Token: 0x0600AAF7 RID: 43767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF7")]
		[Address(RVA = "0x23AFCF4", Offset = "0x23AFCF4", VA = "0x7BBCBAFCF4")]
		public void RefreshRecentPlayersPresence(PresenceListRes presenceRes)
		{
		}

		// Token: 0x0600AAF8 RID: 43768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF8")]
		[Address(RVA = "0x23B0504", Offset = "0x23B0504", VA = "0x7BBCBB0504")]
		public void RefreshFriendPresences(PresenceListRes presenceRes)
		{
		}

		// Token: 0x0600AAF9 RID: 43769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAF9")]
		[Address(RVA = "0x23B0DEC", Offset = "0x23B0DEC", VA = "0x7BBCBB0DEC")]
		public void RefreshAddFriendPresence(PresenceListRes presenceRes)
		{
		}

		// Token: 0x0600AAFA RID: 43770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAFA")]
		[Address(RVA = "0x23B1474", Offset = "0x23B1474", VA = "0x7BBCBB1474")]
		public void RefreshSearchedPlayersPresences(PresenceListRes presenceRes)
		{
		}

		// Token: 0x0600AAFB RID: 43771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAFB")]
		[Address(RVA = "0x23B1BCC", Offset = "0x23B1BCC", VA = "0x7BBCBB1BCC")]
		public void RefreshSearchedPlayersPresencesWithoutCondition(PresenceListRes presenceRes)
		{
		}

		// Token: 0x0600AAFC RID: 43772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAFC")]
		[Address(RVA = "0x23B1C48", Offset = "0x23B1C48", VA = "0x7BBCBB1C48")]
		public void RefreshSearchedPlayersPresencesWithCondition(PresenceListRes presenceRes)
		{
		}

		// Token: 0x0600AAFD RID: 43773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAFD")]
		[Address(RVA = "0x23AF3A0", Offset = "0x23AF3A0", VA = "0x7BBCBAF3A0")]
		public void RequestGameFriendIDList(bool isSilence = false, [Optional] Action afterRefreshAction)
		{
		}

		// Token: 0x0600AAFE RID: 43774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAFE")]
		[Address(RVA = "0x23B1CCC", Offset = "0x23B1CCC", VA = "0x7BBCBB1CCC")]
		public void RequestPlatformFriendIDList(bool isSilence = false)
		{
		}

		// Token: 0x0600AAFF RID: 43775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAFF")]
		[Address(RVA = "0x23AF68C", Offset = "0x23AF68C", VA = "0x7BBCBAF68C")]
		public void RefreshGameFriendList([Optional] Action afterRefreshAction, bool isSilence = false, uint requestFlag = 8U)
		{
		}

		// Token: 0x0600AB00 RID: 43776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB00")]
		[Address(RVA = "0x23B25D4", Offset = "0x23B25D4", VA = "0x7BBCBB25D4")]
		public void RefreshPlatformFriendList(bool isSilence = false, uint requestFlag = 8U)
		{
		}

		// Token: 0x0600AB01 RID: 43777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB01")]
		[Address(RVA = "0x23B2118", Offset = "0x23B2118", VA = "0x7BBCBB2118")]
		private void RefreshTotalFriendList(uint requestFlag)
		{
		}

		// Token: 0x0600AB02 RID: 43778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AB02")]
		[Address(RVA = "0x23B2AF0", Offset = "0x23B2AF0", VA = "0x7BBCBB2AF0")]
		public List<FriendAccountInfo> FriendsHasChampionshipTeam()
		{
			return null;
		}

		// Token: 0x0600AB03 RID: 43779 RVA: 0x0002EDA0 File Offset: 0x0002CFA0
		[Token(Token = "0x600AB03")]
		[Address(RVA = "0x23B2E58", Offset = "0x23B2E58", VA = "0x7BBCBB2E58")]
		public static int SortFriendAccountInfo(FriendAccountInfo a, FriendAccountInfo b)
		{
			return 0;
		}

		// Token: 0x0600AB04 RID: 43780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB04")]
		[Address(RVA = "0x23B2E8C", Offset = "0x23B2E8C", VA = "0x7BBCBB2E8C")]
		public void RefreshFriendRequestList(bool forceRefresh = false, bool isSilence = false)
		{
		}

		// Token: 0x0600AB05 RID: 43781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB05")]
		[Address(RVA = "0x23B3160", Offset = "0x23B3160", VA = "0x7BBCBB3160")]
		public void RefreshBlackList(bool forceRefresh = false, bool isSilence = false, bool needDispatch = true)
		{
		}

		// Token: 0x0600AB06 RID: 43782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB06")]
		[Address(RVA = "0x23B3480", Offset = "0x23B3480", VA = "0x7BBCBB3480")]
		public void SearchAccount(string searchName, bool forceRefresh = false)
		{
		}

		// Token: 0x0600AB07 RID: 43783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB07")]
		[Address(RVA = "0x23B3788", Offset = "0x23B3788", VA = "0x7BBCBB3788")]
		private void RefreshSearchAccountInfoPresence(EPresenceListType type = EPresenceListType.SearchedPlayer)
		{
		}

		// Token: 0x0600AB08 RID: 43784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB08")]
		[Address(RVA = "0x23B38D0", Offset = "0x23B38D0", VA = "0x7BBCBB38D0")]
		public void SearchAccount(ulong searchID, bool forceRefresh = false)
		{
		}

		// Token: 0x0600AB09 RID: 43785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB09")]
		[Address(RVA = "0x23B3BD8", Offset = "0x23B3BD8", VA = "0x7BBCBB3BD8")]
		public void SearchByConditions(ESocial.Language language = ESocial.Language.Language_UNLIMITED, ESocial.Gender gender = ESocial.Gender.Gender_NONE, ESocial.TimeActive activeTime = ESocial.TimeActive.TimeActive_NONE, ESocial.ModePrefer modePrefer = ESocial.ModePrefer.ModePrefer_NONE, bool forceRefresh = false)
		{
		}

		// Token: 0x0600AB0A RID: 43786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB0A")]
		[Address(RVA = "0x23AEECC", Offset = "0x23AEECC", VA = "0x7BBCBAEECC")]
		public void RequestAccountInfo(ulong accountId, Action<AccountInfoBasic> onFinished)
		{
		}

		// Token: 0x0600AB0B RID: 43787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB0B")]
		[Address(RVA = "0x23B4070", Offset = "0x23B4070", VA = "0x7BBCBB4070")]
		public void RequestedRecommendedFriendInitData()
		{
		}

		// Token: 0x0600AB0C RID: 43788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB0C")]
		[Address(RVA = "0x23B4258", Offset = "0x23B4258", VA = "0x7BBCBB4258")]
		public void GetRecommendedFriend(bool forceRefresh = false)
		{
		}

		// Token: 0x0600AB0D RID: 43789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB0D")]
		[Address(RVA = "0x23B50CC", Offset = "0x23B50CC", VA = "0x7BBCBB50CC")]
		public void RemoveFriendRequest(ulong remover, ulong removee)
		{
		}

		// Token: 0x0600AB0E RID: 43790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB0E")]
		[Address(RVA = "0x23B52BC", Offset = "0x23B52BC", VA = "0x7BBCBB52BC")]
		public void AddFriendRequest(ulong adder, ulong addee, EFriendAddFrom add_from, uint friend_tag = 0U, bool need_slience = false)
		{
		}

		// Token: 0x0600AB0F RID: 43791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB0F")]
		[Address(RVA = "0x23B58D4", Offset = "0x23B58D4", VA = "0x7BBCBB58D4")]
		public void RequestSetFavorFriendState(ulong adder, ulong addee, bool isMark)
		{
		}

		// Token: 0x0600AB10 RID: 43792 RVA: 0x0002EDB8 File Offset: 0x0002CFB8
		[Token(Token = "0x600AB10")]
		[Address(RVA = "0x23B5B7C", Offset = "0x23B5B7C", VA = "0x7BBCBB5B7C")]
		public bool CanDoFavorFriend()
		{
			return default(bool);
		}

		// Token: 0x0600AB11 RID: 43793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB11")]
		[Address(RVA = "0x23B5660", Offset = "0x23B5660", VA = "0x7BBCBB5660")]
		public void ConfirmFriendRequest(ulong adder, ulong addee, bool need_slience = false)
		{
		}

		// Token: 0x0600AB12 RID: 43794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB12")]
		[Address(RVA = "0x23B5BE8", Offset = "0x23B5BE8", VA = "0x7BBCBB5BE8")]
		public void DeclineFriendRequest(ulong adder, ulong addee, bool need_slience = false)
		{
		}

		// Token: 0x0600AB13 RID: 43795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB13")]
		[Address(RVA = "0x23B5E14", Offset = "0x23B5E14", VA = "0x7BBCBB5E14")]
		public void BlockPlayerRequest(ulong blockID, bool need_slience = false)
		{
		}

		// Token: 0x0600AB14 RID: 43796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB14")]
		[Address(RVA = "0x23B606C", Offset = "0x23B606C", VA = "0x7BBCBB606C")]
		public void CancelBlockRequest(ulong blockID, bool need_slience = false)
		{
		}

		// Token: 0x0600AB15 RID: 43797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB15")]
		[Address(RVA = "0x23B629C", Offset = "0x23B629C", VA = "0x7BBCBB629C")]
		public void RefuseAllFriendRequest(bool need_slience = false)
		{
		}

		// Token: 0x0600AB16 RID: 43798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AB16")]
		[Address(RVA = "0x23B64E0", Offset = "0x23B64E0", VA = "0x7BBCBB64E0")]
		public static string GetFriendStatus(proto.EPresence.AccountPresence presence, f matchMode = f.EMATCHMODE_NONE, l}BQs\u0080\u0082 gameMode = l}BQs\u0080\u0082.EGAMEMODE_NONE, uint mapID = 0U)
		{
			return null;
		}

		// Token: 0x0600AB17 RID: 43799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AB17")]
		[Address(RVA = "0x23B6834", Offset = "0x23B6834", VA = "0x7BBCBB6834")]
		public string GetLastLoginTime(long lastLoginAt)
		{
			return null;
		}

		// Token: 0x0600AB18 RID: 43800 RVA: 0x0002EDD0 File Offset: 0x0002CFD0
		[Token(Token = "0x600AB18")]
		[Address(RVA = "0x23B6C60", Offset = "0x23B6C60", VA = "0x7BBCBB6C60")]
		public bool IsFriend(ulong accountID)
		{
			return default(bool);
		}

		// Token: 0x0600AB19 RID: 43801 RVA: 0x0002EDE8 File Offset: 0x0002CFE8
		[Token(Token = "0x600AB19")]
		[Address(RVA = "0x23B6EEC", Offset = "0x23B6EEC", VA = "0x7BBCBB6EEC")]
		public bool IsUnknowPlayer(ulong accountId)
		{
			return default(bool);
		}

		// Token: 0x0600AB1A RID: 43802 RVA: 0x0002EE00 File Offset: 0x0002D000
		[Token(Token = "0x600AB1A")]
		[Address(RVA = "0x23B6F08", Offset = "0x23B6F08", VA = "0x7BBCBB6F08")]
		public EFriendType GetFriendType(ulong accountId)
		{
			return EFriendType.Unknow;
		}

		// Token: 0x0600AB1B RID: 43803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AB1B")]
		[Address(RVA = "0x23B70D4", Offset = "0x23B70D4", VA = "0x7BBCBB70D4")]
		public string GetFriendTypeString(ulong accountId)
		{
			return null;
		}

		// Token: 0x0600AB1C RID: 43804 RVA: 0x0002EE18 File Offset: 0x0002D018
		[Token(Token = "0x600AB1C")]
		[Address(RVA = "0x23B7264", Offset = "0x23B7264", VA = "0x7BBCBB7264")]
		public Color GetFriendTypeColor(ulong accountId)
		{
			return default(Color);
		}

		// Token: 0x0600AB1D RID: 43805 RVA: 0x0002EE30 File Offset: 0x0002D030
		[Token(Token = "0x600AB1D")]
		[Address(RVA = "0x23B72A4", Offset = "0x23B72A4", VA = "0x7BBCBB72A4")]
		public bool IsIDInCache(ulong accoutID)
		{
			return default(bool);
		}

		// Token: 0x0600AB1E RID: 43806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB1E")]
		[Address(RVA = "0x23B7314", Offset = "0x23B7314", VA = "0x7BBCBB7314")]
		public void ResetRequestCooldown()
		{
		}

		// Token: 0x0600AB1F RID: 43807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AB1F")]
		[Address(RVA = "0x23B73A0", Offset = "0x23B73A0", VA = "0x7BBCBB73A0")]
		public FriendAccountInfo GetFriendInfo(ulong account_id)
		{
			return null;
		}

		// Token: 0x0600AB20 RID: 43808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB20")]
		[Address(RVA = "0x23B7470", Offset = "0x23B7470", VA = "0x7BBCBB7470")]
		public void RemoveFriendByAccountID(ulong account_id)
		{
		}

		// Token: 0x0600AB21 RID: 43809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB21")]
		[Address(RVA = "0x23B78B4", Offset = "0x23B78B4", VA = "0x7BBCBB78B4")]
		public void AddFriendWithPresence(AccountInfoWithPresence account_info)
		{
		}

		// Token: 0x0600AB22 RID: 43810 RVA: 0x0002EE48 File Offset: 0x0002D048
		[Token(Token = "0x600AB22")]
		[Address(RVA = "0x23B7FC0", Offset = "0x23B7FC0", VA = "0x7BBCBB7FC0")]
		public bool CanInviteFriendToGroup(FriendAccountInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600AB23 RID: 43811 RVA: 0x0002EE60 File Offset: 0x0002D060
		[Token(Token = "0x600AB23")]
		[Address(RVA = "0x23B7FDC", Offset = "0x23B7FDC", VA = "0x7BBCBB7FDC")]
		public bool CanJoinFriendGroup(FriendAccountInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600AB24 RID: 43812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB24")]
		[Address(RVA = "0x23B7FE8", Offset = "0x23B7FE8", VA = "0x7BBCBB7FE8")]
		private void SetListAmountLimit(List<FriendAccountInfo> friendList, int pickNum)
		{
		}

		// Token: 0x0600AB25 RID: 43813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB25")]
		[Address(RVA = "0x23B80A8", Offset = "0x23B80A8", VA = "0x7BBCBB80A8")]
		private void SetListAmountLimit(List<RecentPlayerInfo> friendList, int pickNum)
		{
		}

		// Token: 0x0600AB26 RID: 43814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB26")]
		[Address(RVA = "0x23B8168", Offset = "0x23B8168", VA = "0x7BBCBB8168")]
		private void SetListAmountLimit(List<ClanMember> friendList, int pickNum)
		{
		}

		// Token: 0x0600AB27 RID: 43815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AB27")]
		[Address(RVA = "0x23B4F5C", Offset = "0x23B4F5C", VA = "0x7BBCBB4F5C")]
		private List<RecentPlayerInfo> RandomPick(List<RecentPlayerInfo> friendList, int pickNum)
		{
			return null;
		}

		// Token: 0x0600AB28 RID: 43816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AB28")]
		[Address(RVA = "0x23B4DEC", Offset = "0x23B4DEC", VA = "0x7BBCBB4DEC")]
		private List<ClanMember> RandomPick(List<ClanMember> friendList, int pickNum)
		{
			return null;
		}

		// Token: 0x0600AB29 RID: 43817 RVA: 0x0002EE78 File Offset: 0x0002D078
		[Token(Token = "0x600AB29")]
		[Address(RVA = "0x23B8228", Offset = "0x23B8228", VA = "0x7BBCBB8228")]
		public bool IsCelebrity(uint role)
		{
			return default(bool);
		}

		// Token: 0x0600AB2A RID: 43818 RVA: 0x0002EE90 File Offset: 0x0002D090
		[Token(Token = "0x600AB2A")]
		[Address(RVA = "0x23B8234", Offset = "0x23B8234", VA = "0x7BBCBB8234")]
		public bool IsCelebrity(proto.EAccount.Role role)
		{
			return default(bool);
		}

		// Token: 0x0600AB2B RID: 43819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AB2B")]
		[Address(RVA = "0x23B8240", Offset = "0x23B8240", VA = "0x7BBCBB8240")]
		public string GetNameAfterCelebrityCheck(uint role, string name)
		{
			return null;
		}

		// Token: 0x0600AB2C RID: 43820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AB2C")]
		[Address(RVA = "0x23B8244", Offset = "0x23B8244", VA = "0x7BBCBB8244")]
		public string GetNameAfterCelebrityCheck(proto.EAccount.Role role, string name)
		{
			return null;
		}

		// Token: 0x0600AB2D RID: 43821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB2D")]
		[Address(RVA = "0x23B82C0", Offset = "0x23B82C0", VA = "0x7BBCBB82C0")]
		public void AddMatchCount()
		{
		}

		// Token: 0x0600AB2E RID: 43822 RVA: 0x0002EEA8 File Offset: 0x0002D0A8
		[Token(Token = "0x600AB2E")]
		[Address(RVA = "0x23B83F4", Offset = "0x23B83F4", VA = "0x7BBCBB83F4")]
		private bool CheckRecommendFriendCondition()
		{
			return default(bool);
		}

		// Token: 0x0600AB2F RID: 43823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB2F")]
		[Address(RVA = "0x23B86A0", Offset = "0x23B86A0", VA = "0x7BBCBB86A0")]
		public void RefreshRecentTeamPlayers()
		{
		}

		// Token: 0x0600AB30 RID: 43824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB30")]
		[Address(RVA = "0x23B8D60", Offset = "0x23B8D60", VA = "0x7BBCBB8D60")]
		public void RefreshTeamPlayersWhileClanMemberChange()
		{
		}

		// Token: 0x0600AB31 RID: 43825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB31")]
		[Address(RVA = "0x23B909C", Offset = "0x23B909C", VA = "0x7BBCBB909C")]
		public void RecommendFriendWhileInTeam()
		{
		}

		// Token: 0x0600AB32 RID: 43826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB32")]
		[Address(RVA = "0x23BA2EC", Offset = "0x23BA2EC", VA = "0x7BBCBBA2EC")]
		public void RecommendFriendAfterMatch()
		{
		}

		// Token: 0x0600AB33 RID: 43827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AB33")]
		[Address(RVA = "0x23BACBC", Offset = "0x23BACBC", VA = "0x7BBCBBACBC")]
		public List<FriendAccountInfo> SearchFriendInClienData(string info)
		{
			return null;
		}

		// Token: 0x0600AB34 RID: 43828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB34")]
		[Address(RVA = "0x23BB0AC", Offset = "0x23BB0AC", VA = "0x7BBCBBB0AC")]
		public void SetTeamMateSocialInfo(ulong accountID, byte gender, ushort friendCount)
		{
		}

		// Token: 0x0600AB35 RID: 43829 RVA: 0x0002EEC0 File Offset: 0x0002D0C0
		[Token(Token = "0x600AB35")]
		[Address(RVA = "0x23BB240", Offset = "0x23BB240", VA = "0x7BBCBBB240")]
		public bool IsFriendInGame(ulong account_id)
		{
			return default(bool);
		}

		// Token: 0x0600AB36 RID: 43830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB36")]
		[Address(RVA = "0x23BB2B0", Offset = "0x23BB2B0", VA = "0x7BBCBBB2B0")]
		public void CheckFriendInGame(ulong account_id)
		{
		}

		// Token: 0x0600AB37 RID: 43831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB37")]
		[Address(RVA = "0x23BB36C", Offset = "0x23BB36C", VA = "0x7BBCBBB36C")]
		public void ClearInGameFriendData()
		{
		}

		// Token: 0x0600AB38 RID: 43832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB38")]
		[Address(RVA = "0x23BB414", Offset = "0x23BB414", VA = "0x7BBCBBB414")]
		public void CacheAdderInGame(byte[] data)
		{
		}

		// Token: 0x0600AB39 RID: 43833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB39")]
		[Address(RVA = "0x23BB528", Offset = "0x23BB528", VA = "0x7BBCBBB528")]
		public void IgnorePlayerAddRequest(ulong account_id)
		{
		}

		// Token: 0x0600AB3A RID: 43834 RVA: 0x0002EED8 File Offset: 0x0002D0D8
		[Token(Token = "0x600AB3A")]
		[Address(RVA = "0x23BB664", Offset = "0x23BB664", VA = "0x7BBCBBB664")]
		public ulong GetFirstFriendAdder()
		{
			return 0UL;
		}

		// Token: 0x0600AB3B RID: 43835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB3B")]
		[Address(RVA = "0x23BB724", Offset = "0x23BB724", VA = "0x7BBCBBB724")]
		public void CacheNewInviteID(byte[] data)
		{
		}

		// Token: 0x0600AB3C RID: 43836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB3C")]
		[Address(RVA = "0x23BB794", Offset = "0x23BB794", VA = "0x7BBCBBB794")]
		public UIModelFriends()
		{
		}

		// Token: 0x0600AB3D RID: 43837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB3D")]
		[Address(RVA = "0x23BBBDC", Offset = "0x23BBBDC", VA = "0x7BBCBBBBDC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114627C", Offset = "0x114627C")]
		private void <RefreshFriendRequestList>b__117_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AB3E RID: 43838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB3E")]
		[Address(RVA = "0x23BC144", Offset = "0x23BC144", VA = "0x7BBCBBC144")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114628C", Offset = "0x114628C")]
		private void <SearchAccount>b__119_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AB3F RID: 43839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB3F")]
		[Address(RVA = "0x23BC54C", Offset = "0x23BC54C", VA = "0x7BBCBBC54C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114629C", Offset = "0x114629C")]
		private void <SearchAccount>b__121_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AB40 RID: 43840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB40")]
		[Address(RVA = "0x23BC8B8", Offset = "0x23BC8B8", VA = "0x7BBCBBC8B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11462AC", Offset = "0x11462AC")]
		private void <SearchByConditions>b__122_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AB41 RID: 43841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB41")]
		[Address(RVA = "0x23BCF28", Offset = "0x23BCF28", VA = "0x7BBCBBCF28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11462BC", Offset = "0x11462BC")]
		private void <RequestedRecommendedFriendInitData>b__124_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AB42 RID: 43842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB42")]
		[Address(RVA = "0x23BD170", Offset = "0x23BD170", VA = "0x7BBCBBD170")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11462CC", Offset = "0x11462CC")]
		private void <GetRecommendedFriend>b__125_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AB43 RID: 43843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB43")]
		[Address(RVA = "0x23BE3E0", Offset = "0x23BE3E0", VA = "0x7BBCBBE3E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11462DC", Offset = "0x11462DC")]
		private void <RefuseAllFriendRequest>b__134_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400AFF1 RID: 45041
		[Token(Token = "0x400AFF1")]
		public const string NEW_VERSION_AFTER_OB20 = "NEW_ACCOUNT_AFTER_OB20";

		// Token: 0x0400AFF2 RID: 45042
		[Token(Token = "0x400AFF2")]
		private const string GUIDE_FRIEND_RELATIONSHIP_GRAPH = "OpenFriendRelationshipGraph";

		// Token: 0x0400AFF3 RID: 45043
		[Token(Token = "0x400AFF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_HasOpenFriendRelationshipGraph;

		// Token: 0x0400AFF4 RID: 45044
		[Token(Token = "0x400AFF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int m_CurRecentPlayersMatchTimes;

		// Token: 0x0400AFF5 RID: 45045
		[Token(Token = "0x400AFF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<FriendAccountInfo> m_FriendAccountInfoList;

		// Token: 0x0400AFF6 RID: 45046
		[Token(Token = "0x400AFF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<FriendAccountInfo> m_GameFriendAccountInfoList;

		// Token: 0x0400AFF7 RID: 45047
		[Token(Token = "0x400AFF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<FriendAccountInfo> m_PlatformFriendAccountInfoList;

		// Token: 0x0400AFF8 RID: 45048
		[Token(Token = "0x400AFF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<FriendAccountInfo> m_FriendRequestAccountInfoList;

		// Token: 0x0400AFF9 RID: 45049
		[Token(Token = "0x400AFF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<FriendAccountInfo> m_blackListAccountInfo;

		// Token: 0x0400AFFA RID: 45050
		[Token(Token = "0x400AFFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<FriendAccountInfo> m_OnlineFriendAccountInfoList;

		// Token: 0x0400AFFB RID: 45051
		[Token(Token = "0x400AFFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<FriendAccountInfo> m_SearchAccountResultList;

		// Token: 0x0400AFFC RID: 45052
		[Token(Token = "0x400AFFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<ulong> m_RequestedAndBlockedList;

		// Token: 0x0400AFFD RID: 45053
		[Token(Token = "0x400AFFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<FriendAccountInfo> m_FollowAccountInfoList;

		// Token: 0x0400AFFE RID: 45054
		[Token(Token = "0x400AFFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<ulong> m_FavorAccountIDs;

		// Token: 0x0400AFFF RID: 45055
		[Token(Token = "0x400AFFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private HashSet<ulong> m_InGameNewFriendList;

		// Token: 0x0400B000 RID: 45056
		[Token(Token = "0x400B000")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private HashSet<ulong> m_InGameIgnoreAdder;

		// Token: 0x0400B001 RID: 45057
		[Token(Token = "0x400B001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<ulong> m_InGameFriendAdderList;

		// Token: 0x0400B002 RID: 45058
		[Token(Token = "0x400B002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<FriendAccountInfo> m_RecommendedFriendRecentTeammates;

		// Token: 0x0400B003 RID: 45059
		[Token(Token = "0x400B003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<FriendAccountInfo> m_RecommendedFriendClanMember;

		// Token: 0x0400B004 RID: 45060
		[Token(Token = "0x400B004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<FriendAccountInfo> m_RecommendedFriendCommon;

		// Token: 0x0400B005 RID: 45061
		[Token(Token = "0x400B005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<FriendAccountInfo> m_RecommendedFriendNoTag;

		// Token: 0x0400B006 RID: 45062
		[Token(Token = "0x400B006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool m_HasRequestClanMemberList;

		// Token: 0x0400B007 RID: 45063
		[Token(Token = "0x400B007")]
		private const int recommendedFriendAmount = 10;

		// Token: 0x0400B008 RID: 45064
		[Token(Token = "0x400B008")]
		private const int recommendedFriendWithTagAmount = 5;

		// Token: 0x0400B009 RID: 45065
		[Token(Token = "0x400B009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		private bool NeedRequestedRecommendedFriendInitData;

		// Token: 0x0400B00A RID: 45066
		[Token(Token = "0x400B00A")]
		public const uint MAXFAVORFRIENDSCNT = 20U;

		// Token: 0x0400B00B RID: 45067
		[Token(Token = "0x400B00B")]
		public const uint PropID_FriendListUpdate = 2U;

		// Token: 0x0400B00C RID: 45068
		[Token(Token = "0x400B00C")]
		public const uint PropID_FriendRequestListUpdate = 4U;

		// Token: 0x0400B00D RID: 45069
		[Token(Token = "0x400B00D")]
		public const uint PropID_SearchResultListUpdate = 8U;

		// Token: 0x0400B00E RID: 45070
		[Token(Token = "0x400B00E")]
		public const uint PropID_BlackListUpdate = 16U;

		// Token: 0x0400B00F RID: 45071
		[Token(Token = "0x400B00F")]
		public const uint PropID_RecentPlayers = 32U;

		// Token: 0x0400B010 RID: 45072
		[Token(Token = "0x400B010")]
		public const uint PropID_SearchByConditionUpdate = 64U;

		// Token: 0x0400B011 RID: 45073
		[Token(Token = "0x400B011")]
		public const uint PropID_FriendListUpdatePresence = 128U;

		// Token: 0x0400B012 RID: 45074
		[Token(Token = "0x400B012")]
		public const uint PropID_AddFriendCachedUpdate = 256U;

		// Token: 0x0400B013 RID: 45075
		[Token(Token = "0x400B013")]
		private const uint FriendRequestFlag_ID = 2U;

		// Token: 0x0400B014 RID: 45076
		[Token(Token = "0x400B014")]
		private const uint FriendRequestFlag_Info = 4U;

		// Token: 0x0400B015 RID: 45077
		[Token(Token = "0x400B015")]
		private const uint FriendRequestFlag_Presence = 8U;

		// Token: 0x0400B016 RID: 45078
		[Token(Token = "0x400B016")]
		private const uint FriendRequestFlag_Stats = 16U;

		// Token: 0x0400B017 RID: 45079
		[Token(Token = "0x400B017")]
		public const uint FriendAddTag_Team = 2U;

		// Token: 0x0400B018 RID: 45080
		[Token(Token = "0x400B018")]
		public const uint FriendAddTag_Clan = 4U;

		// Token: 0x0400B019 RID: 45081
		[Token(Token = "0x400B019")]
		public const uint FriendAddTag_Friend = 8U;

		// Token: 0x0400B01A RID: 45082
		[Token(Token = "0x400B01A")]
		private const string RECOMMENDFRIENDMATCHCOUNT = "RECOMMENDFRIENDMATCHCOUNT_";

		// Token: 0x0400B01B RID: 45083
		[Token(Token = "0x400B01B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int m_MatchCount;

		// Token: 0x0400B01C RID: 45084
		[Token(Token = "0x400B01C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<ulong> m_LastTeamMember;

		// Token: 0x0400B01D RID: 45085
		[Token(Token = "0x400B01D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool m_EnterGame;

		// Token: 0x0400B01E RID: 45086
		[Token(Token = "0x400B01E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int m_blackListCount;

		// Token: 0x0400B01F RID: 45087
		[Token(Token = "0x400B01F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public readonly Dictionary<ERecentPlayerType, List<ulong>> m_RecentPlayerIDDict;

		// Token: 0x0400B020 RID: 45088
		[Token(Token = "0x400B020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<RecentPlayerInfo> m_RecentPlayerInfoList;

		// Token: 0x0400B021 RID: 45089
		[Token(Token = "0x400B021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<FriendAccountInfo> m_TempRecentAccountInfoList;

		// Token: 0x0400B022 RID: 45090
		[Token(Token = "0x400B022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<ulong> m_TempRecentPlayerIDs;

		// Token: 0x0400B023 RID: 45091
		[Token(Token = "0x400B023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ulong m_LastRefreshRecentPlayerPresenceTime;

		// Token: 0x0400B024 RID: 45092
		[Token(Token = "0x400B024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private uint m_RequestedFriendFlags;

		// Token: 0x0400B025 RID: 45093
		[Token(Token = "0x400B025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string m_SearchedStringCache;

		// Token: 0x0400B026 RID: 45094
		[Token(Token = "0x400B026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private ulong m_SearchedIDCache;

		// Token: 0x0400B027 RID: 45095
		[Token(Token = "0x400B027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private HashSet<object> m_PendingRequest;

		// Token: 0x0400B028 RID: 45096
		[Token(Token = "0x400B028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private HashSet<ulong> m_AddFriendCachedID;

		// Token: 0x0400B029 RID: 45097
		[Token(Token = "0x400B029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Dictionary<ulong, UIModelFriends.TeamMateSocialInfo> m_teamMateSocialInfo;

		// Token: 0x0400B02A RID: 45098
		[Token(Token = "0x400B02A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private ulong m_showInvitePlayerID;

		// Token: 0x02001E6A RID: 7786
		[Token(Token = "0x2001E6A")]
		public enum EFriendRequestOption
		{
			// Token: 0x0400B02C RID: 45100
			[Token(Token = "0x400B02C")]
			None,
			// Token: 0x0400B02D RID: 45101
			[Token(Token = "0x400B02D")]
			OnlyID = 2,
			// Token: 0x0400B02E RID: 45102
			[Token(Token = "0x400B02E")]
			FriendInfo = 6,
			// Token: 0x0400B02F RID: 45103
			[Token(Token = "0x400B02F")]
			FriendPresence = 14,
			// Token: 0x0400B030 RID: 45104
			[Token(Token = "0x400B030")]
			FriendStats = 30
		}

		// Token: 0x02001E6B RID: 7787
		[Token(Token = "0x2001E6B")]
		public class TeamMateSocialInfo
		{
			// Token: 0x0600AB44 RID: 43844 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB44")]
			[Address(RVA = "0x2313EB4", Offset = "0x2313EB4", VA = "0x7BBCB13EB4")]
			public TeamMateSocialInfo()
			{
			}

			// Token: 0x0400B031 RID: 45105
			[Token(Token = "0x400B031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong accountID;

			// Token: 0x0400B032 RID: 45106
			[Token(Token = "0x400B032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ESocial.Gender Gender;

			// Token: 0x0400B033 RID: 45107
			[Token(Token = "0x400B033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int friendCount;
		}

		// Token: 0x02001E6C RID: 7788
		[Token(Token = "0x2001E6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC6C4", Offset = "0x10FC6C4")]
		private sealed class <>c__DisplayClass80_0
		{
			// Token: 0x0600AB45 RID: 43845 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB45")]
			[Address(RVA = "0x2313DEC", Offset = "0x2313DEC", VA = "0x7BBCB13DEC")]
			public <>c__DisplayClass80_0()
			{
			}

			// Token: 0x0600AB46 RID: 43846 RVA: 0x0002EEF0 File Offset: 0x0002D0F0
			[Token(Token = "0x600AB46")]
			[Address(RVA = "0x2313DF4", Offset = "0x2313DF4", VA = "0x7BBCB13DF4")]
			internal bool <get_RecentPlayerInfoList>b__0(FriendAccountInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B034 RID: 45108
			[Token(Token = "0x400B034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			// Token: 0x0400B035 RID: 45109
			[Token(Token = "0x400B035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelFriends <>4__this;
		}

		// Token: 0x02001E6D RID: 7789
		[Token(Token = "0x2001E6D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC6D4", Offset = "0x10FC6D4")]
		private sealed class <>c__DisplayClass100_0
		{
			// Token: 0x0600AB47 RID: 43847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB47")]
			[Address(RVA = "0x23AEEB4", Offset = "0x23AEEB4", VA = "0x7BBCBAEEB4")]
			public <>c__DisplayClass100_0()
			{
			}

			// Token: 0x0400B036 RID: 45110
			[Token(Token = "0x400B036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelFriends <>4__this;

			// Token: 0x0400B037 RID: 45111
			[Token(Token = "0x400B037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ERecentPlayerType type;

			// Token: 0x0400B038 RID: 45112
			[Token(Token = "0x400B038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ulong now;

			// Token: 0x0400B039 RID: 45113
			[Token(Token = "0x400B039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<ulong> checkList;
		}

		// Token: 0x02001E6E RID: 7790
		[Token(Token = "0x2001E6E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC6E4", Offset = "0x10FC6E4")]
		private sealed class <>c__DisplayClass100_1
		{
			// Token: 0x0600AB48 RID: 43848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB48")]
			[Address(RVA = "0x23AEEBC", Offset = "0x23AEEBC", VA = "0x7BBCBAEEBC")]
			public <>c__DisplayClass100_1()
			{
			}

			// Token: 0x0600AB49 RID: 43849 RVA: 0x0002EF08 File Offset: 0x0002D108
			[Token(Token = "0x600AB49")]
			[Address(RVA = "0x23BE72C", Offset = "0x23BE72C", VA = "0x7BBCBBE72C")]
			internal bool <AddRecentPlayersFrontEnd>b__0(RecentPlayerInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B03A RID: 45114
			[Token(Token = "0x400B03A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FriendAccountInfo info;
		}

		// Token: 0x02001E6F RID: 7791
		[Token(Token = "0x2001E6F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC6F4", Offset = "0x10FC6F4")]
		private sealed class <>c__DisplayClass100_2
		{
			// Token: 0x0600AB4A RID: 43850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB4A")]
			[Address(RVA = "0x23AEEC4", Offset = "0x23AEEC4", VA = "0x7BBCBAEEC4")]
			public <>c__DisplayClass100_2()
			{
			}

			// Token: 0x0600AB4B RID: 43851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB4B")]
			[Address(RVA = "0x23BE790", Offset = "0x23BE790", VA = "0x7BBCBBE790")]
			internal void <AddRecentPlayersFrontEnd>b__1(AccountInfoBasic info)
			{
			}

			// Token: 0x0400B03B RID: 45115
			[Token(Token = "0x400B03B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong id;

			// Token: 0x0400B03C RID: 45116
			[Token(Token = "0x400B03C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelFriends.<>c__DisplayClass100_0 CS$<>8__locals1;
		}

		// Token: 0x02001E70 RID: 7792
		[Token(Token = "0x2001E70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC704", Offset = "0x10FC704")]
		private sealed class <>c__DisplayClass100_3
		{
			// Token: 0x0600AB4C RID: 43852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB4C")]
			[Address(RVA = "0x23BEA50", Offset = "0x23BEA50", VA = "0x7BBCBBEA50")]
			public <>c__DisplayClass100_3()
			{
			}

			// Token: 0x0600AB4D RID: 43853 RVA: 0x0002EF20 File Offset: 0x0002D120
			[Token(Token = "0x600AB4D")]
			[Address(RVA = "0x23BEA58", Offset = "0x23BEA58", VA = "0x7BBCBBEA58")]
			internal bool <AddRecentPlayersFrontEnd>b__2(RecentPlayerInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B03D RID: 45117
			[Token(Token = "0x400B03D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AccountInfoBasic info;
		}

		// Token: 0x02001E71 RID: 7793
		[Token(Token = "0x2001E71")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC714", Offset = "0x10FC714")]
		private sealed class <>c__DisplayClass101_0
		{
			// Token: 0x0600AB4E RID: 43854 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB4E")]
			[Address(RVA = "0x23AF398", Offset = "0x23AF398", VA = "0x7BBCBAF398")]
			public <>c__DisplayClass101_0()
			{
			}

			// Token: 0x0600AB4F RID: 43855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB4F")]
			[Address(RVA = "0x23BEABC", Offset = "0x23BEABC", VA = "0x7BBCBBEABC")]
			internal void <RefreshAllFriendList>b__0()
			{
			}

			// Token: 0x0600AB50 RID: 43856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB50")]
			[Address(RVA = "0x23BEAF4", Offset = "0x23BEAF4", VA = "0x7BBCBBEAF4")]
			internal void <RefreshAllFriendList>b__1()
			{
			}

			// Token: 0x0400B03E RID: 45118
			[Token(Token = "0x400B03E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelFriends <>4__this;

			// Token: 0x0400B03F RID: 45119
			[Token(Token = "0x400B03F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isSilence;

			// Token: 0x0400B040 RID: 45120
			[Token(Token = "0x400B040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public UIModelFriends.EFriendRequestOption requestOption;
		}

		// Token: 0x02001E72 RID: 7794
		[Token(Token = "0x2001E72")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC724", Offset = "0x10FC724")]
		private sealed class <>c__DisplayClass104_0
		{
			// Token: 0x0600AB51 RID: 43857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB51")]
			[Address(RVA = "0x23B04F4", Offset = "0x23B04F4", VA = "0x7BBCBB04F4")]
			public <>c__DisplayClass104_0()
			{
			}

			// Token: 0x0400B041 RID: 45121
			[Token(Token = "0x400B041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PresenceListRes presenceRes;
		}

		// Token: 0x02001E73 RID: 7795
		[Token(Token = "0x2001E73")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC734", Offset = "0x10FC734")]
		private sealed class <>c__DisplayClass104_1
		{
			// Token: 0x0600AB52 RID: 43858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB52")]
			[Address(RVA = "0x23B04FC", Offset = "0x23B04FC", VA = "0x7BBCBB04FC")]
			public <>c__DisplayClass104_1()
			{
			}

			// Token: 0x0600AB53 RID: 43859 RVA: 0x0002EF38 File Offset: 0x0002D138
			[Token(Token = "0x600AB53")]
			[Address(RVA = "0x23BEB3C", Offset = "0x23BEB3C", VA = "0x7BBCBBEB3C")]
			internal bool <RefreshRecentPlayersPresence>b__0(RecentPlayerInfo temp)
			{
				return default(bool);
			}

			// Token: 0x0400B042 RID: 45122
			[Token(Token = "0x400B042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			// Token: 0x0400B043 RID: 45123
			[Token(Token = "0x400B043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelFriends.<>c__DisplayClass104_0 CS$<>8__locals1;
		}

		// Token: 0x02001E74 RID: 7796
		[Token(Token = "0x2001E74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC744", Offset = "0x10FC744")]
		private sealed class <>c__DisplayClass105_0
		{
			// Token: 0x0600AB54 RID: 43860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB54")]
			[Address(RVA = "0x23B0DDC", Offset = "0x23B0DDC", VA = "0x7BBCBB0DDC")]
			public <>c__DisplayClass105_0()
			{
			}

			// Token: 0x0400B044 RID: 45124
			[Token(Token = "0x400B044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PresenceListRes presenceRes;
		}

		// Token: 0x02001E75 RID: 7797
		[Token(Token = "0x2001E75")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC754", Offset = "0x10FC754")]
		private sealed class <>c__DisplayClass105_1
		{
			// Token: 0x0600AB55 RID: 43861 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB55")]
			[Address(RVA = "0x23B0DE4", Offset = "0x23B0DE4", VA = "0x7BBCBB0DE4")]
			public <>c__DisplayClass105_1()
			{
			}

			// Token: 0x0600AB56 RID: 43862 RVA: 0x0002EF50 File Offset: 0x0002D150
			[Token(Token = "0x600AB56")]
			[Address(RVA = "0x23BEC1C", Offset = "0x23BEC1C", VA = "0x7BBCBBEC1C")]
			internal bool <RefreshFriendPresences>b__0(FriendAccountInfo info)
			{
				return default(bool);
			}

			// Token: 0x0400B045 RID: 45125
			[Token(Token = "0x400B045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			// Token: 0x0400B046 RID: 45126
			[Token(Token = "0x400B046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelFriends.<>c__DisplayClass105_0 CS$<>8__locals1;
		}

		// Token: 0x02001E76 RID: 7798
		[Token(Token = "0x2001E76")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC764", Offset = "0x10FC764")]
		private sealed class <>c__DisplayClass106_0
		{
			// Token: 0x0600AB57 RID: 43863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB57")]
			[Address(RVA = "0x23B1464", Offset = "0x23B1464", VA = "0x7BBCBB1464")]
			public <>c__DisplayClass106_0()
			{
			}

			// Token: 0x0400B047 RID: 45127
			[Token(Token = "0x400B047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PresenceListRes presenceRes;
		}

		// Token: 0x02001E77 RID: 7799
		[Token(Token = "0x2001E77")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC774", Offset = "0x10FC774")]
		private sealed class <>c__DisplayClass106_1
		{
			// Token: 0x0600AB58 RID: 43864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB58")]
			[Address(RVA = "0x23B146C", Offset = "0x23B146C", VA = "0x7BBCBB146C")]
			public <>c__DisplayClass106_1()
			{
			}

			// Token: 0x0600AB59 RID: 43865 RVA: 0x0002EF68 File Offset: 0x0002D168
			[Token(Token = "0x600AB59")]
			[Address(RVA = "0x23BECEC", Offset = "0x23BECEC", VA = "0x7BBCBBECEC")]
			internal bool <RefreshAddFriendPresence>b__0(FriendAccountInfo info)
			{
				return default(bool);
			}

			// Token: 0x0400B048 RID: 45128
			[Token(Token = "0x400B048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			// Token: 0x0400B049 RID: 45129
			[Token(Token = "0x400B049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelFriends.<>c__DisplayClass106_0 CS$<>8__locals1;
		}

		// Token: 0x02001E78 RID: 7800
		[Token(Token = "0x2001E78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC784", Offset = "0x10FC784")]
		private sealed class <>c__DisplayClass107_0
		{
			// Token: 0x0600AB5A RID: 43866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB5A")]
			[Address(RVA = "0x23B1BBC", Offset = "0x23B1BBC", VA = "0x7BBCBB1BBC")]
			public <>c__DisplayClass107_0()
			{
			}

			// Token: 0x0400B04A RID: 45130
			[Token(Token = "0x400B04A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PresenceListRes presenceRes;
		}

		// Token: 0x02001E79 RID: 7801
		[Token(Token = "0x2001E79")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC794", Offset = "0x10FC794")]
		private sealed class <>c__DisplayClass107_1
		{
			// Token: 0x0600AB5B RID: 43867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB5B")]
			[Address(RVA = "0x23B1BC4", Offset = "0x23B1BC4", VA = "0x7BBCBB1BC4")]
			public <>c__DisplayClass107_1()
			{
			}

			// Token: 0x0600AB5C RID: 43868 RVA: 0x0002EF80 File Offset: 0x0002D180
			[Token(Token = "0x600AB5C")]
			[Address(RVA = "0x23BEDBC", Offset = "0x23BEDBC", VA = "0x7BBCBBEDBC")]
			internal bool <RefreshSearchedPlayersPresences>b__0(FriendAccountInfo info)
			{
				return default(bool);
			}

			// Token: 0x0400B04B RID: 45131
			[Token(Token = "0x400B04B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			// Token: 0x0400B04C RID: 45132
			[Token(Token = "0x400B04C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelFriends.<>c__DisplayClass107_0 CS$<>8__locals1;
		}

		// Token: 0x02001E7A RID: 7802
		[Token(Token = "0x2001E7A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC7A4", Offset = "0x10FC7A4")]
		private sealed class <>c__DisplayClass110_0
		{
			// Token: 0x0600AB5D RID: 43869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB5D")]
			[Address(RVA = "0x23B1CC4", Offset = "0x23B1CC4", VA = "0x7BBCBB1CC4")]
			public <>c__DisplayClass110_0()
			{
			}

			// Token: 0x0600AB5E RID: 43870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB5E")]
			[Address(RVA = "0x23BEE8C", Offset = "0x23BEE8C", VA = "0x7BBCBBEE8C")]
			internal void <RequestGameFriendIDList>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B04D RID: 45133
			[Token(Token = "0x400B04D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelFriends <>4__this;

			// Token: 0x0400B04E RID: 45134
			[Token(Token = "0x400B04E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CSGetFriendIDsReq req;

			// Token: 0x0400B04F RID: 45135
			[Token(Token = "0x400B04F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action afterRefreshAction;
		}

		// Token: 0x02001E7B RID: 7803
		[Token(Token = "0x2001E7B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC7B4", Offset = "0x10FC7B4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600AB60 RID: 43872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB60")]
			[Address(RVA = "0x23BE518", Offset = "0x23BE518", VA = "0x7BBCBBE518")]
			public <>c()
			{
			}

			// Token: 0x0600AB61 RID: 43873 RVA: 0x0002EF98 File Offset: 0x0002D198
			[Token(Token = "0x600AB61")]
			[Address(RVA = "0x23BE520", Offset = "0x23BE520", VA = "0x7BBCBBE520")]
			internal bool <RequestGameFriendIDList>b__110_1(FriendAccountInfo i)
			{
				return default(bool);
			}

			// Token: 0x0600AB62 RID: 43874 RVA: 0x0002EFB0 File Offset: 0x0002D1B0
			[Token(Token = "0x600AB62")]
			[Address(RVA = "0x23BE5E0", Offset = "0x23BE5E0", VA = "0x7BBCBBE5E0")]
			internal bool <RefreshGameFriendList>b__112_1(FriendAccountInfo i)
			{
				return default(bool);
			}

			// Token: 0x0600AB63 RID: 43875 RVA: 0x0002EFC8 File Offset: 0x0002D1C8
			[Token(Token = "0x600AB63")]
			[Address(RVA = "0x23BE6A0", Offset = "0x23BE6A0", VA = "0x7BBCBBE6A0")]
			internal int <RecommendFriendAfterMatch>b__163_0(TeammateStats a, TeammateStats b)
			{
				return 0;
			}

			// Token: 0x0400B050 RID: 45136
			[Token(Token = "0x400B050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIModelFriends.<>c <>9;

			// Token: 0x0400B051 RID: 45137
			[Token(Token = "0x400B051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<FriendAccountInfo> <>9__110_1;

			// Token: 0x0400B052 RID: 45138
			[Token(Token = "0x400B052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<FriendAccountInfo> <>9__112_1;

			// Token: 0x0400B053 RID: 45139
			[Token(Token = "0x400B053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Comparison<TeammateStats> <>9__163_0;
		}

		// Token: 0x02001E7C RID: 7804
		[Token(Token = "0x2001E7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC7C4", Offset = "0x10FC7C4")]
		private sealed class <>c__DisplayClass111_0
		{
			// Token: 0x0600AB64 RID: 43876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB64")]
			[Address(RVA = "0x23B2110", Offset = "0x23B2110", VA = "0x7BBCBB2110")]
			public <>c__DisplayClass111_0()
			{
			}

			// Token: 0x0600AB65 RID: 43877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB65")]
			[Address(RVA = "0x23BF210", Offset = "0x23BF210", VA = "0x7BBCBBF210")]
			internal void <RequestPlatformFriendIDList>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B054 RID: 45140
			[Token(Token = "0x400B054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelFriends <>4__this;

			// Token: 0x0400B055 RID: 45141
			[Token(Token = "0x400B055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CSGetPlatformFriendListReq req;
		}

		// Token: 0x02001E7D RID: 7805
		[Token(Token = "0x2001E7D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC7D4", Offset = "0x10FC7D4")]
		private sealed class <>c__DisplayClass112_0
		{
			// Token: 0x0600AB66 RID: 43878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB66")]
			[Address(RVA = "0x23B25CC", Offset = "0x23B25CC", VA = "0x7BBCBB25CC")]
			public <>c__DisplayClass112_0()
			{
			}

			// Token: 0x0600AB67 RID: 43879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB67")]
			[Address(RVA = "0x23BF4B8", Offset = "0x23BF4B8", VA = "0x7BBCBBF4B8")]
			internal void <RefreshGameFriendList>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B056 RID: 45142
			[Token(Token = "0x400B056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelFriends <>4__this;

			// Token: 0x0400B057 RID: 45143
			[Token(Token = "0x400B057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CSGetFriendListReq req;

			// Token: 0x0400B058 RID: 45144
			[Token(Token = "0x400B058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action afterRefreshAction;

			// Token: 0x0400B059 RID: 45145
			[Token(Token = "0x400B059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public uint requestFlag;
		}

		// Token: 0x02001E7E RID: 7806
		[Token(Token = "0x2001E7E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC7E4", Offset = "0x10FC7E4")]
		private sealed class <>c__DisplayClass113_0
		{
			// Token: 0x0600AB68 RID: 43880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB68")]
			[Address(RVA = "0x23118C8", Offset = "0x23118C8", VA = "0x7BBCB118C8")]
			public <>c__DisplayClass113_0()
			{
			}

			// Token: 0x0600AB69 RID: 43881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB69")]
			[Address(RVA = "0x23118D0", Offset = "0x23118D0", VA = "0x7BBCB118D0")]
			internal void <RefreshPlatformFriendList>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B05A RID: 45146
			[Token(Token = "0x400B05A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelFriends <>4__this;

			// Token: 0x0400B05B RID: 45147
			[Token(Token = "0x400B05B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CSGetPlatformFriendListReq req;

			// Token: 0x0400B05C RID: 45148
			[Token(Token = "0x400B05C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint requestFlag;
		}

		// Token: 0x02001E7F RID: 7807
		[Token(Token = "0x2001E7F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC7F4", Offset = "0x10FC7F4")]
		private sealed class <>c__DisplayClass114_0
		{
			// Token: 0x0600AB6A RID: 43882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB6A")]
			[Address(RVA = "0x2311D80", Offset = "0x2311D80", VA = "0x7BBCB11D80")]
			public <>c__DisplayClass114_0()
			{
			}

			// Token: 0x0600AB6B RID: 43883 RVA: 0x0002EFE0 File Offset: 0x0002D1E0
			[Token(Token = "0x600AB6B")]
			[Address(RVA = "0x2311D88", Offset = "0x2311D88", VA = "0x7BBCB11D88")]
			internal bool <RefreshTotalFriendList>b__0(FriendAccountInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400B05D RID: 45149
			[Token(Token = "0x400B05D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			// Token: 0x0400B05E RID: 45150
			[Token(Token = "0x400B05E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIModelFriends <>4__this;
		}

		// Token: 0x02001E80 RID: 7808
		[Token(Token = "0x2001E80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC804", Offset = "0x10FC804")]
		private sealed class <>c__DisplayClass118_0
		{
			// Token: 0x0600AB6C RID: 43884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB6C")]
			[Address(RVA = "0x2311E38", Offset = "0x2311E38", VA = "0x7BBCB11E38")]
			public <>c__DisplayClass118_0()
			{
			}

			// Token: 0x0600AB6D RID: 43885 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB6D")]
			[Address(RVA = "0x2311E40", Offset = "0x2311E40", VA = "0x7BBCB11E40")]
			internal void <RefreshBlackList>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B05F RID: 45151
			[Token(Token = "0x400B05F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelFriends <>4__this;

			// Token: 0x0400B060 RID: 45152
			[Token(Token = "0x400B060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool needDispatch;
		}

		// Token: 0x02001E81 RID: 7809
		[Token(Token = "0x2001E81")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC814", Offset = "0x10FC814")]
		private sealed class <>c__DisplayClass123_0
		{
			// Token: 0x0600AB6E RID: 43886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB6E")]
			[Address(RVA = "0x231228C", Offset = "0x231228C", VA = "0x7BBCB1228C")]
			public <>c__DisplayClass123_0()
			{
			}

			// Token: 0x0600AB6F RID: 43887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB6F")]
			[Address(RVA = "0x2312294", Offset = "0x2312294", VA = "0x7BBCB12294")]
			internal void <RequestAccountInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B061 RID: 45153
			[Token(Token = "0x400B061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<AccountInfoBasic> onFinished;
		}

		// Token: 0x02001E82 RID: 7810
		[Token(Token = "0x2001E82")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC824", Offset = "0x10FC824")]
		private sealed class <>c__DisplayClass125_0
		{
			// Token: 0x0600AB70 RID: 43888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB70")]
			[Address(RVA = "0x2312360", Offset = "0x2312360", VA = "0x7BBCB12360")]
			public <>c__DisplayClass125_0()
			{
			}

			// Token: 0x0600AB71 RID: 43889 RVA: 0x0002EFF8 File Offset: 0x0002D1F8
			[Token(Token = "0x600AB71")]
			[Address(RVA = "0x2312368", Offset = "0x2312368", VA = "0x7BBCB12368")]
			internal bool <GetRecommendedFriend>b__1(FriendAccountInfo tmp)
			{
				return default(bool);
			}

			// Token: 0x0400B062 RID: 45154
			[Token(Token = "0x400B062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FriendAccountInfo friendInfo;
		}

		// Token: 0x02001E83 RID: 7811
		[Token(Token = "0x2001E83")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC834", Offset = "0x10FC834")]
		private sealed class <>c__DisplayClass125_1
		{
			// Token: 0x0600AB72 RID: 43890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB72")]
			[Address(RVA = "0x23123B4", Offset = "0x23123B4", VA = "0x7BBCB123B4")]
			public <>c__DisplayClass125_1()
			{
			}

			// Token: 0x0600AB73 RID: 43891 RVA: 0x0002F010 File Offset: 0x0002D210
			[Token(Token = "0x600AB73")]
			[Address(RVA = "0x23123BC", Offset = "0x23123BC", VA = "0x7BBCB123BC")]
			internal bool <GetRecommendedFriend>b__2(FriendAccountInfo tmp)
			{
				return default(bool);
			}

			// Token: 0x0400B063 RID: 45155
			[Token(Token = "0x400B063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RecentPlayerInfo recentPlayer;
		}

		// Token: 0x02001E84 RID: 7812
		[Token(Token = "0x2001E84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC844", Offset = "0x10FC844")]
		private sealed class <>c__DisplayClass125_2
		{
			// Token: 0x0600AB74 RID: 43892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB74")]
			[Address(RVA = "0x2312418", Offset = "0x2312418", VA = "0x7BBCB12418")]
			public <>c__DisplayClass125_2()
			{
			}

			// Token: 0x0600AB75 RID: 43893 RVA: 0x0002F028 File Offset: 0x0002D228
			[Token(Token = "0x600AB75")]
			[Address(RVA = "0x2312420", Offset = "0x2312420", VA = "0x7BBCB12420")]
			internal bool <GetRecommendedFriend>b__3(FriendAccountInfo tmp)
			{
				return default(bool);
			}

			// Token: 0x0400B064 RID: 45156
			[Token(Token = "0x400B064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FriendAccountInfo item;
		}

		// Token: 0x02001E85 RID: 7813
		[Token(Token = "0x2001E85")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC854", Offset = "0x10FC854")]
		private sealed class <>c__DisplayClass125_3
		{
			// Token: 0x0600AB76 RID: 43894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB76")]
			[Address(RVA = "0x231246C", Offset = "0x231246C", VA = "0x7BBCB1246C")]
			public <>c__DisplayClass125_3()
			{
			}

			// Token: 0x0600AB77 RID: 43895 RVA: 0x0002F040 File Offset: 0x0002D240
			[Token(Token = "0x600AB77")]
			[Address(RVA = "0x2312474", Offset = "0x2312474", VA = "0x7BBCB12474")]
			internal bool <GetRecommendedFriend>b__4(FriendAccountInfo item)
			{
				return default(bool);
			}

			// Token: 0x0400B065 RID: 45157
			[Token(Token = "0x400B065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FriendAccountInfo recentTeammate;
		}

		// Token: 0x02001E86 RID: 7814
		[Token(Token = "0x2001E86")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC864", Offset = "0x10FC864")]
		private sealed class <>c__DisplayClass125_4
		{
			// Token: 0x0600AB78 RID: 43896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB78")]
			[Address(RVA = "0x23124C0", Offset = "0x23124C0", VA = "0x7BBCB124C0")]
			public <>c__DisplayClass125_4()
			{
			}

			// Token: 0x0600AB79 RID: 43897 RVA: 0x0002F058 File Offset: 0x0002D258
			[Token(Token = "0x600AB79")]
			[Address(RVA = "0x23124C8", Offset = "0x23124C8", VA = "0x7BBCB124C8")]
			internal bool <GetRecommendedFriend>b__5(FriendAccountInfo item)
			{
				return default(bool);
			}

			// Token: 0x0400B066 RID: 45158
			[Token(Token = "0x400B066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FriendAccountInfo clanMember;
		}

		// Token: 0x02001E87 RID: 7815
		[Token(Token = "0x2001E87")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC874", Offset = "0x10FC874")]
		private sealed class <>c__DisplayClass125_5
		{
			// Token: 0x0600AB7A RID: 43898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB7A")]
			[Address(RVA = "0x2312514", Offset = "0x2312514", VA = "0x7BBCB12514")]
			public <>c__DisplayClass125_5()
			{
			}

			// Token: 0x0600AB7B RID: 43899 RVA: 0x0002F070 File Offset: 0x0002D270
			[Token(Token = "0x600AB7B")]
			[Address(RVA = "0x231251C", Offset = "0x231251C", VA = "0x7BBCB1251C")]
			internal bool <GetRecommendedFriend>b__6(FriendAccountInfo item)
			{
				return default(bool);
			}

			// Token: 0x0400B067 RID: 45159
			[Token(Token = "0x400B067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FriendAccountInfo commonFriend;
		}

		// Token: 0x02001E88 RID: 7816
		[Token(Token = "0x2001E88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC884", Offset = "0x10FC884")]
		private sealed class <>c__DisplayClass125_6
		{
			// Token: 0x0600AB7C RID: 43900 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB7C")]
			[Address(RVA = "0x2312568", Offset = "0x2312568", VA = "0x7BBCB12568")]
			public <>c__DisplayClass125_6()
			{
			}

			// Token: 0x0600AB7D RID: 43901 RVA: 0x0002F088 File Offset: 0x0002D288
			[Token(Token = "0x600AB7D")]
			[Address(RVA = "0x2312570", Offset = "0x2312570", VA = "0x7BBCB12570")]
			internal bool <GetRecommendedFriend>b__7(FriendAccountInfo tmp)
			{
				return default(bool);
			}

			// Token: 0x0400B068 RID: 45160
			[Token(Token = "0x400B068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FriendAccountInfo item;
		}

		// Token: 0x02001E89 RID: 7817
		[Token(Token = "0x2001E89")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC894", Offset = "0x10FC894")]
		private sealed class <>c__DisplayClass126_0
		{
			// Token: 0x0600AB7E RID: 43902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB7E")]
			[Address(RVA = "0x23125BC", Offset = "0x23125BC", VA = "0x7BBCB125BC")]
			public <>c__DisplayClass126_0()
			{
			}

			// Token: 0x0600AB7F RID: 43903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB7F")]
			[Address(RVA = "0x23125C4", Offset = "0x23125C4", VA = "0x7BBCB125C4")]
			internal void <RemoveFriendRequest>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B069 RID: 45161
			[Token(Token = "0x400B069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelFriends <>4__this;

			// Token: 0x0400B06A RID: 45162
			[Token(Token = "0x400B06A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong removee;
		}

		// Token: 0x02001E8A RID: 7818
		[Token(Token = "0x2001E8A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC8A4", Offset = "0x10FC8A4")]
		private sealed class <>c__DisplayClass127_0
		{
			// Token: 0x0600AB80 RID: 43904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB80")]
			[Address(RVA = "0x2312600", Offset = "0x2312600", VA = "0x7BBCB12600")]
			public <>c__DisplayClass127_0()
			{
			}

			// Token: 0x0600AB81 RID: 43905 RVA: 0x0002F0A0 File Offset: 0x0002D2A0
			[Token(Token = "0x600AB81")]
			[Address(RVA = "0x2312608", Offset = "0x2312608", VA = "0x7BBCB12608")]
			internal bool <AddFriendRequest>b__1(FriendAccountInfo x)
			{
				return default(bool);
			}

			// Token: 0x0600AB82 RID: 43906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB82")]
			[Address(RVA = "0x2312644", Offset = "0x2312644", VA = "0x7BBCB12644")]
			internal void <AddFriendRequest>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B06B RID: 45163
			[Token(Token = "0x400B06B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong addee;

			// Token: 0x0400B06C RID: 45164
			[Token(Token = "0x400B06C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong adder;
		}

		// Token: 0x02001E8B RID: 7819
		[Token(Token = "0x2001E8B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC8B4", Offset = "0x10FC8B4")]
		private sealed class <>c__DisplayClass128_0
		{
			// Token: 0x0600AB83 RID: 43907 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB83")]
			[Address(RVA = "0x2312A6C", Offset = "0x2312A6C", VA = "0x7BBCB12A6C")]
			public <>c__DisplayClass128_0()
			{
			}

			// Token: 0x0600AB84 RID: 43908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB84")]
			[Address(RVA = "0x2312A74", Offset = "0x2312A74", VA = "0x7BBCB12A74")]
			internal void <RequestSetFavorFriendState>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600AB85 RID: 43909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB85")]
			[Address(RVA = "0x2312DD0", Offset = "0x2312DD0", VA = "0x7BBCB12DD0")]
			internal void <RequestSetFavorFriendState>b__1(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B06D RID: 45165
			[Token(Token = "0x400B06D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelFriends <>4__this;

			// Token: 0x0400B06E RID: 45166
			[Token(Token = "0x400B06E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong addee;
		}

		// Token: 0x02001E8C RID: 7820
		[Token(Token = "0x2001E8C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC8C4", Offset = "0x10FC8C4")]
		private sealed class <>c__DisplayClass130_0
		{
			// Token: 0x0600AB86 RID: 43910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB86")]
			[Address(RVA = "0x231312C", Offset = "0x231312C", VA = "0x7BBCB1312C")]
			public <>c__DisplayClass130_0()
			{
			}

			// Token: 0x0600AB87 RID: 43911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB87")]
			[Address(RVA = "0x2313134", Offset = "0x2313134", VA = "0x7BBCB13134")]
			internal void <ConfirmFriendRequest>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B06F RID: 45167
			[Token(Token = "0x400B06F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelFriends <>4__this;

			// Token: 0x0400B070 RID: 45168
			[Token(Token = "0x400B070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool need_slience;
		}

		// Token: 0x02001E8D RID: 7821
		[Token(Token = "0x2001E8D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC8D4", Offset = "0x10FC8D4")]
		private sealed class <>c__DisplayClass131_0
		{
			// Token: 0x0600AB88 RID: 43912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB88")]
			[Address(RVA = "0x23137D4", Offset = "0x23137D4", VA = "0x7BBCB137D4")]
			public <>c__DisplayClass131_0()
			{
			}

			// Token: 0x0600AB89 RID: 43913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB89")]
			[Address(RVA = "0x23137DC", Offset = "0x23137DC", VA = "0x7BBCB137DC")]
			internal void <DeclineFriendRequest>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B071 RID: 45169
			[Token(Token = "0x400B071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelFriends <>4__this;

			// Token: 0x0400B072 RID: 45170
			[Token(Token = "0x400B072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool need_slience;
		}

		// Token: 0x02001E8E RID: 7822
		[Token(Token = "0x2001E8E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC8E4", Offset = "0x10FC8E4")]
		private sealed class <>c__DisplayClass132_0
		{
			// Token: 0x0600AB8A RID: 43914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB8A")]
			[Address(RVA = "0x2313824", Offset = "0x2313824", VA = "0x7BBCB13824")]
			public <>c__DisplayClass132_0()
			{
			}

			// Token: 0x0600AB8B RID: 43915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB8B")]
			[Address(RVA = "0x231382C", Offset = "0x231382C", VA = "0x7BBCB1382C")]
			internal void <BlockPlayerRequest>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B073 RID: 45171
			[Token(Token = "0x400B073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelFriends <>4__this;

			// Token: 0x0400B074 RID: 45172
			[Token(Token = "0x400B074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool need_slience;
		}

		// Token: 0x02001E8F RID: 7823
		[Token(Token = "0x2001E8F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC8F4", Offset = "0x10FC8F4")]
		private sealed class <>c__DisplayClass133_0
		{
			// Token: 0x0600AB8C RID: 43916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB8C")]
			[Address(RVA = "0x23138BC", Offset = "0x23138BC", VA = "0x7BBCB138BC")]
			public <>c__DisplayClass133_0()
			{
			}

			// Token: 0x0600AB8D RID: 43917 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB8D")]
			[Address(RVA = "0x23138C4", Offset = "0x23138C4", VA = "0x7BBCB138C4")]
			internal void <CancelBlockRequest>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B075 RID: 45173
			[Token(Token = "0x400B075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModelFriends <>4__this;

			// Token: 0x0400B076 RID: 45174
			[Token(Token = "0x400B076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool need_slience;
		}

		// Token: 0x02001E90 RID: 7824
		[Token(Token = "0x2001E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC904", Offset = "0x10FC904")]
		private sealed class <>c__DisplayClass144_0
		{
			// Token: 0x0600AB8E RID: 43918 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB8E")]
			[Address(RVA = "0x2313958", Offset = "0x2313958", VA = "0x7BBCB13958")]
			public <>c__DisplayClass144_0()
			{
			}

			// Token: 0x0600AB8F RID: 43919 RVA: 0x0002F0B8 File Offset: 0x0002D2B8
			[Token(Token = "0x600AB8F")]
			[Address(RVA = "0x2313960", Offset = "0x2313960", VA = "0x7BBCB13960")]
			internal bool <GetFriendInfo>b__0(FriendAccountInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400B077 RID: 45175
			[Token(Token = "0x400B077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong account_id;
		}

		// Token: 0x02001E91 RID: 7825
		[Token(Token = "0x2001E91")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC914", Offset = "0x10FC914")]
		private sealed class <>c__DisplayClass145_0
		{
			// Token: 0x0600AB90 RID: 43920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB90")]
			[Address(RVA = "0x231399C", Offset = "0x231399C", VA = "0x7BBCB1399C")]
			public <>c__DisplayClass145_0()
			{
			}

			// Token: 0x0600AB91 RID: 43921 RVA: 0x0002F0D0 File Offset: 0x0002D2D0
			[Token(Token = "0x600AB91")]
			[Address(RVA = "0x23139A4", Offset = "0x23139A4", VA = "0x7BBCB139A4")]
			internal bool <RemoveFriendByAccountID>b__0(FriendAccountInfo x)
			{
				return default(bool);
			}

			// Token: 0x0600AB92 RID: 43922 RVA: 0x0002F0E8 File Offset: 0x0002D2E8
			[Token(Token = "0x600AB92")]
			[Address(RVA = "0x23139E0", Offset = "0x23139E0", VA = "0x7BBCB139E0")]
			internal bool <RemoveFriendByAccountID>b__4(FriendAccountInfo x)
			{
				return default(bool);
			}

			// Token: 0x0600AB93 RID: 43923 RVA: 0x0002F100 File Offset: 0x0002D300
			[Token(Token = "0x600AB93")]
			[Address(RVA = "0x2313A1C", Offset = "0x2313A1C", VA = "0x7BBCB13A1C")]
			internal bool <RemoveFriendByAccountID>b__1(FriendAccountInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600AB94 RID: 43924 RVA: 0x0002F118 File Offset: 0x0002D318
			[Token(Token = "0x600AB94")]
			[Address(RVA = "0x2313A58", Offset = "0x2313A58", VA = "0x7BBCB13A58")]
			internal bool <RemoveFriendByAccountID>b__2(FriendAccountInfo info)
			{
				return default(bool);
			}

			// Token: 0x0600AB95 RID: 43925 RVA: 0x0002F130 File Offset: 0x0002D330
			[Token(Token = "0x600AB95")]
			[Address(RVA = "0x2313A94", Offset = "0x2313A94", VA = "0x7BBCB13A94")]
			internal bool <RemoveFriendByAccountID>b__3(FriendAccountInfo info)
			{
				return default(bool);
			}

			// Token: 0x0400B078 RID: 45176
			[Token(Token = "0x400B078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong account_id;
		}

		// Token: 0x02001E92 RID: 7826
		[Token(Token = "0x2001E92")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC924", Offset = "0x10FC924")]
		private sealed class <>c__DisplayClass146_0
		{
			// Token: 0x0600AB96 RID: 43926 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB96")]
			[Address(RVA = "0x2313AD0", Offset = "0x2313AD0", VA = "0x7BBCB13AD0")]
			public <>c__DisplayClass146_0()
			{
			}

			// Token: 0x0600AB97 RID: 43927 RVA: 0x0002F148 File Offset: 0x0002D348
			[Token(Token = "0x600AB97")]
			[Address(RVA = "0x2313AD8", Offset = "0x2313AD8", VA = "0x7BBCB13AD8")]
			internal bool <AddFriendWithPresence>b__0(FriendAccountInfo x)
			{
				return default(bool);
			}

			// Token: 0x0600AB98 RID: 43928 RVA: 0x0002F160 File Offset: 0x0002D360
			[Token(Token = "0x600AB98")]
			[Address(RVA = "0x2313B24", Offset = "0x2313B24", VA = "0x7BBCB13B24")]
			internal bool <AddFriendWithPresence>b__1(FriendAccountInfo x)
			{
				return default(bool);
			}

			// Token: 0x0400B079 RID: 45177
			[Token(Token = "0x400B079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FriendAccountInfo info;
		}

		// Token: 0x02001E93 RID: 7827
		[Token(Token = "0x2001E93")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC934", Offset = "0x10FC934")]
		private sealed class <>c__DisplayClass160_0
		{
			// Token: 0x0600AB99 RID: 43929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB99")]
			[Address(RVA = "0x2313B70", Offset = "0x2313B70", VA = "0x7BBCB13B70")]
			public <>c__DisplayClass160_0()
			{
			}

			// Token: 0x0600AB9A RID: 43930 RVA: 0x0002F178 File Offset: 0x0002D378
			[Token(Token = "0x600AB9A")]
			[Address(RVA = "0x2313B78", Offset = "0x2313B78", VA = "0x7BBCB13B78")]
			internal bool <RefreshRecentTeamPlayers>b__0(FriendAccountInfo x)
			{
				return default(bool);
			}

			// Token: 0x0600AB9B RID: 43931 RVA: 0x0002F190 File Offset: 0x0002D390
			[Token(Token = "0x600AB9B")]
			[Address(RVA = "0x2313BCC", Offset = "0x2313BCC", VA = "0x7BBCB13BCC")]
			internal bool <RefreshRecentTeamPlayers>b__1(ClanMember x)
			{
				return default(bool);
			}

			// Token: 0x0400B07A RID: 45178
			[Token(Token = "0x400B07A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GroupMemberInfo member;
		}

		// Token: 0x02001E94 RID: 7828
		[Token(Token = "0x2001E94")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC944", Offset = "0x10FC944")]
		private sealed class <>c__DisplayClass161_0
		{
			// Token: 0x0600AB9C RID: 43932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB9C")]
			[Address(RVA = "0x2313C30", Offset = "0x2313C30", VA = "0x7BBCB13C30")]
			public <>c__DisplayClass161_0()
			{
			}

			// Token: 0x0600AB9D RID: 43933 RVA: 0x0002F1A8 File Offset: 0x0002D3A8
			[Token(Token = "0x600AB9D")]
			[Address(RVA = "0x2313C38", Offset = "0x2313C38", VA = "0x7BBCB13C38")]
			internal bool <RefreshTeamPlayersWhileClanMemberChange>b__0(ClanMember x)
			{
				return default(bool);
			}

			// Token: 0x0400B07B RID: 45179
			[Token(Token = "0x400B07B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong accountID;
		}

		// Token: 0x02001E95 RID: 7829
		[Token(Token = "0x2001E95")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC954", Offset = "0x10FC954")]
		private sealed class <>c__DisplayClass162_0
		{
			// Token: 0x0600AB9E RID: 43934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AB9E")]
			[Address(RVA = "0x2313C84", Offset = "0x2313C84", VA = "0x7BBCB13C84")]
			public <>c__DisplayClass162_0()
			{
			}

			// Token: 0x0600AB9F RID: 43935 RVA: 0x0002F1C0 File Offset: 0x0002D3C0
			[Token(Token = "0x600AB9F")]
			[Address(RVA = "0x2313C8C", Offset = "0x2313C8C", VA = "0x7BBCB13C8C")]
			internal bool <RecommendFriendWhileInTeam>b__0(FriendAccountInfo x)
			{
				return default(bool);
			}

			// Token: 0x0600ABA0 RID: 43936 RVA: 0x0002F1D8 File Offset: 0x0002D3D8
			[Token(Token = "0x600ABA0")]
			[Address(RVA = "0x2313CE0", Offset = "0x2313CE0", VA = "0x7BBCB13CE0")]
			internal bool <RecommendFriendWhileInTeam>b__1(ClanMember x)
			{
				return default(bool);
			}

			// Token: 0x0400B07C RID: 45180
			[Token(Token = "0x400B07C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GroupMemberInfo member;
		}

		// Token: 0x02001E96 RID: 7830
		[Token(Token = "0x2001E96")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC964", Offset = "0x10FC964")]
		private sealed class <>c__DisplayClass162_1
		{
			// Token: 0x0600ABA1 RID: 43937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ABA1")]
			[Address(RVA = "0x2313D44", Offset = "0x2313D44", VA = "0x7BBCB13D44")]
			public <>c__DisplayClass162_1()
			{
			}

			// Token: 0x0600ABA2 RID: 43938 RVA: 0x0002F1F0 File Offset: 0x0002D3F0
			[Token(Token = "0x600ABA2")]
			[Address(RVA = "0x2313D4C", Offset = "0x2313D4C", VA = "0x7BBCB13D4C")]
			internal bool <RecommendFriendWhileInTeam>b__2(GroupMemberInfo x)
			{
				return default(bool);
			}

			// Token: 0x0400B07D RID: 45181
			[Token(Token = "0x400B07D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong id;
		}

		// Token: 0x02001E97 RID: 7831
		[Token(Token = "0x2001E97")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC974", Offset = "0x10FC974")]
		private sealed class <>c__DisplayClass163_0
		{
			// Token: 0x0600ABA3 RID: 43939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ABA3")]
			[Address(RVA = "0x2313D90", Offset = "0x2313D90", VA = "0x7BBCB13D90")]
			public <>c__DisplayClass163_0()
			{
			}

			// Token: 0x0600ABA4 RID: 43940 RVA: 0x0002F208 File Offset: 0x0002D408
			[Token(Token = "0x600ABA4")]
			[Address(RVA = "0x2313D98", Offset = "0x2313D98", VA = "0x7BBCB13D98")]
			internal bool <RecommendFriendAfterMatch>b__1(FriendAccountInfo x)
			{
				return default(bool);
			}

			// Token: 0x0400B07E RID: 45182
			[Token(Token = "0x400B07E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong teamMate;
		}

		// Token: 0x02001E98 RID: 7832
		[Token(Token = "0x2001E98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC984", Offset = "0x10FC984")]
		private sealed class <>c__DisplayClass172_0
		{
			// Token: 0x0600ABA5 RID: 43941 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ABA5")]
			[Address(RVA = "0x2313DD4", Offset = "0x2313DD4", VA = "0x7BBCB13DD4")]
			public <>c__DisplayClass172_0()
			{
			}

			// Token: 0x0600ABA6 RID: 43942 RVA: 0x0002F220 File Offset: 0x0002D420
			[Token(Token = "0x600ABA6")]
			[Address(RVA = "0x2313DDC", Offset = "0x2313DDC", VA = "0x7BBCB13DDC")]
			internal bool <IgnorePlayerAddRequest>b__0(ulong a)
			{
				return default(bool);
			}

			// Token: 0x0400B07F RID: 45183
			[Token(Token = "0x400B07F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong account_id;
		}
	}
}
