using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020019D4 RID: 6612
	[Token(Token = "0x20019D4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7174", Offset = "0x10F7174")]
	public class UILeaderBoardNewController : UINavigationController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x060087F4 RID: 34804 RVA: 0x00024AE0 File Offset: 0x00022CE0
		[Token(Token = "0x60087F4")]
		[Address(RVA = "0x1E2D6F8", Offset = "0x1E2D6F8", VA = "0x7BBC62D6F8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060087F5 RID: 34805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087F5")]
		[Address(RVA = "0x1E2D748", Offset = "0x1E2D748", VA = "0x7BBC62D748", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060087F6 RID: 34806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087F6")]
		[Address(RVA = "0x1E2E050", Offset = "0x1E2E050", VA = "0x7BBC62E050")]
		private void InitSeasonInfo()
		{
		}

		// Token: 0x060087F7 RID: 34807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087F7")]
		[Address(RVA = "0x1E2F450", Offset = "0x1E2F450", VA = "0x7BBC62F450")]
		private void InitBGWidth()
		{
		}

		// Token: 0x060087F8 RID: 34808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087F8")]
		[Address(RVA = "0x1E2E4A4", Offset = "0x1E2E4A4", VA = "0x7BBC62E4A4")]
		private void InitTabInfoList()
		{
		}

		// Token: 0x060087F9 RID: 34809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087F9")]
		[Address(RVA = "0x1E2E95C", Offset = "0x1E2E95C", VA = "0x7BBC62E95C")]
		private void InitCallBackDic()
		{
		}

		// Token: 0x060087FA RID: 34810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087FA")]
		[Address(RVA = "0x1E2F40C", Offset = "0x1E2F40C", VA = "0x7BBC62F40C")]
		private void InitFliterDic()
		{
		}

		// Token: 0x060087FB RID: 34811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087FB")]
		[Address(RVA = "0x1E2F78C", Offset = "0x1E2F78C", VA = "0x7BBC62F78C")]
		private void AddRankFliter()
		{
		}

		// Token: 0x060087FC RID: 34812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087FC")]
		[Address(RVA = "0x1E300F8", Offset = "0x1E300F8", VA = "0x7BBC6300F8")]
		private void AddCasualFliter()
		{
		}

		// Token: 0x060087FD RID: 34813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087FD")]
		[Address(RVA = "0x1E30984", Offset = "0x1E30984", VA = "0x7BBC630984")]
		private void AddCSRankFliter()
		{
		}

		// Token: 0x060087FE RID: 34814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087FE")]
		[Address(RVA = "0x1E30F80", Offset = "0x1E30F80", VA = "0x7BBC630F80")]
		private void AddChampionshipFliter()
		{
		}

		// Token: 0x060087FF RID: 34815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60087FF")]
		[Address(RVA = "0x1E31678", Offset = "0x1E31678", VA = "0x7BBC631678")]
		private void AddGuildFliter()
		{
		}

		// Token: 0x06008800 RID: 34816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008800")]
		[Address(RVA = "0x1E31D58", Offset = "0x1E31D58", VA = "0x7BBC631D58")]
		private void AddBadgesFliter()
		{
		}

		// Token: 0x06008801 RID: 34817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008801")]
		[Address(RVA = "0x1E321A0", Offset = "0x1E321A0", VA = "0x7BBC6321A0")]
		private void CreateTabs()
		{
		}

		// Token: 0x06008802 RID: 34818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008802")]
		[Address(RVA = "0x1E326C4", Offset = "0x1E326C4", VA = "0x7BBC6326C4")]
		private void OnRankTabClick()
		{
		}

		// Token: 0x06008803 RID: 34819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008803")]
		[Address(RVA = "0x1E33560", Offset = "0x1E33560", VA = "0x7BBC633560")]
		private void OnCasualTabClick()
		{
		}

		// Token: 0x06008804 RID: 34820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008804")]
		[Address(RVA = "0x1E33718", Offset = "0x1E33718", VA = "0x7BBC633718")]
		private void OnCSRankTabClick()
		{
		}

		// Token: 0x06008805 RID: 34821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008805")]
		[Address(RVA = "0x1E338D0", Offset = "0x1E338D0", VA = "0x7BBC6338D0")]
		private void OnChampionshipTabClick()
		{
		}

		// Token: 0x06008806 RID: 34822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008806")]
		[Address(RVA = "0x1E33BCC", Offset = "0x1E33BCC", VA = "0x7BBC633BCC")]
		private void OnGuildTabClick()
		{
		}

		// Token: 0x06008807 RID: 34823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008807")]
		[Address(RVA = "0x1E33DCC", Offset = "0x1E33DCC", VA = "0x7BBC633DCC")]
		private void OnElitePassTabClick()
		{
		}

		// Token: 0x06008808 RID: 34824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008808")]
		[Address(RVA = "0x1E3287C", Offset = "0x1E3287C", VA = "0x7BBC63287C")]
		private void InitFliterByConfig(Func<FliterData, List<PopMenuData>> func, string tabFliter)
		{
		}

		// Token: 0x06008809 RID: 34825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008809")]
		[Address(RVA = "0x1E33FCC", Offset = "0x1E33FCC", VA = "0x7BBC633FCC")]
		private List<PopMenuData> GenerateFilterData(FliterData fliterData)
		{
			return null;
		}

		// Token: 0x0600880A RID: 34826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600880A")]
		[Address(RVA = "0x1E34288", Offset = "0x1E34288", VA = "0x7BBC634288")]
		private void OnFliterSelected(object data)
		{
		}

		// Token: 0x0600880B RID: 34827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600880B")]
		[Address(RVA = "0x1E343F8", Offset = "0x1E343F8", VA = "0x7BBC6343F8")]
		private void OnGuildRegionFliterSelected(object data)
		{
		}

		// Token: 0x0600880C RID: 34828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600880C")]
		[Address(RVA = "0x1E3460C", Offset = "0x1E3460C", VA = "0x7BBC63460C")]
		private void OnGuildGlobalFliterSelected(object data)
		{
		}

		// Token: 0x0600880D RID: 34829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600880D")]
		[Address(RVA = "0x1E346E4", Offset = "0x1E346E4", VA = "0x7BBC6346E4")]
		private void OnGuildWeekTotalFliterSelected(object data)
		{
		}

		// Token: 0x0600880E RID: 34830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600880E")]
		[Address(RVA = "0x1E3312C", Offset = "0x1E3312C", VA = "0x7BBC63312C")]
		private void RefreshUI()
		{
		}

		// Token: 0x0600880F RID: 34831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600880F")]
		[Address(RVA = "0x1E34710", Offset = "0x1E34710", VA = "0x7BBC634710")]
		private string BuildDeepLink()
		{
			return null;
		}

		// Token: 0x06008810 RID: 34832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008810")]
		[Address(RVA = "0x1E32B08", Offset = "0x1E32B08", VA = "0x7BBC632B08")]
		private void SetFliter(string fliter1 = "", string fliter2 = "", string fliter3 = "", string fliter4 = "")
		{
		}

		// Token: 0x06008811 RID: 34833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008811")]
		[Address(RVA = "0x1E32C04", Offset = "0x1E32C04", VA = "0x7BBC632C04")]
		private void UpdateStyle()
		{
		}

		// Token: 0x06008812 RID: 34834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008812")]
		[Address(RVA = "0x1E348AC", Offset = "0x1E348AC", VA = "0x7BBC6348AC", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06008813 RID: 34835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008813")]
		[Address(RVA = "0x1E34D9C", Offset = "0x1E34D9C", VA = "0x7BBC634D9C", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06008814 RID: 34836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008814")]
		[Address(RVA = "0x1E324A0", Offset = "0x1E324A0", VA = "0x7BBC6324A0")]
		private void NavigationToLeaderBoard()
		{
		}

		// Token: 0x06008815 RID: 34837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008815")]
		[Address(RVA = "0x1E34F60", Offset = "0x1E34F60", VA = "0x7BBC634F60")]
		private void SetPopMenuData(UILeaderBoardNewController.DeepLinkLayer layer, string fliter)
		{
		}

		// Token: 0x06008816 RID: 34838 RVA: 0x00024AF8 File Offset: 0x00022CF8
		[Token(Token = "0x6008816")]
		[Address(RVA = "0x1E35068", Offset = "0x1E35068", VA = "0x7BBC635068", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06008817 RID: 34839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008817")]
		[Address(RVA = "0x1E35070", Offset = "0x1E35070", VA = "0x7BBC635070", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008818 RID: 34840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008818")]
		[Address(RVA = "0x1E351E0", Offset = "0x1E351E0", VA = "0x7BBC6351E0")]
		private void OnPlayerFriendKillsSoloSelected()
		{
		}

		// Token: 0x06008819 RID: 34841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008819")]
		[Address(RVA = "0x1E35328", Offset = "0x1E35328", VA = "0x7BBC635328")]
		private void OnPlayerFriendKillsDuoSelected()
		{
		}

		// Token: 0x0600881A RID: 34842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600881A")]
		[Address(RVA = "0x1E353A4", Offset = "0x1E353A4", VA = "0x7BBC6353A4")]
		private void OnPlayerFriendKillsTeamSelected()
		{
		}

		// Token: 0x0600881B RID: 34843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600881B")]
		[Address(RVA = "0x1E35420", Offset = "0x1E35420", VA = "0x7BBC635420")]
		private void OnPlayerFriendWinsSoloSelected()
		{
		}

		// Token: 0x0600881C RID: 34844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600881C")]
		[Address(RVA = "0x1E354A0", Offset = "0x1E354A0", VA = "0x7BBC6354A0")]
		private void OnPlayerFriendWinsDuoSelected()
		{
		}

		// Token: 0x0600881D RID: 34845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600881D")]
		[Address(RVA = "0x1E35520", Offset = "0x1E35520", VA = "0x7BBC635520")]
		private void OnPlayerFriendWinsTeamSelected()
		{
		}

		// Token: 0x0600881E RID: 34846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600881E")]
		[Address(RVA = "0x1E355A0", Offset = "0x1E355A0", VA = "0x7BBC6355A0")]
		private void OnPlayerRegionKillsSoloSelected()
		{
		}

		// Token: 0x0600881F RID: 34847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600881F")]
		[Address(RVA = "0x1E35858", Offset = "0x1E35858", VA = "0x7BBC635858")]
		private void OnPlayerRegionKillsDuaSelected()
		{
		}

		// Token: 0x06008820 RID: 34848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008820")]
		[Address(RVA = "0x1E359DC", Offset = "0x1E359DC", VA = "0x7BBC6359DC")]
		private void OnPlayerRegionKillsTeamSelected()
		{
		}

		// Token: 0x06008821 RID: 34849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008821")]
		[Address(RVA = "0x1E35B60", Offset = "0x1E35B60", VA = "0x7BBC635B60")]
		private void OnPlayerRegionWinsSoloSelected()
		{
		}

		// Token: 0x06008822 RID: 34850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008822")]
		[Address(RVA = "0x1E35CE8", Offset = "0x1E35CE8", VA = "0x7BBC635CE8")]
		private void OnPlayerRegionWinsDuoSelected()
		{
		}

		// Token: 0x06008823 RID: 34851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008823")]
		[Address(RVA = "0x1E35E70", Offset = "0x1E35E70", VA = "0x7BBC635E70")]
		private void OnPlayerRegionWinsTeamSelected()
		{
		}

		// Token: 0x06008824 RID: 34852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008824")]
		[Address(RVA = "0x1E35FF8", Offset = "0x1E35FF8", VA = "0x7BBC635FF8")]
		private void OnPlayerFriendCasualKillsSoloSelected()
		{
		}

		// Token: 0x06008825 RID: 34853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008825")]
		[Address(RVA = "0x1E36074", Offset = "0x1E36074", VA = "0x7BBC636074")]
		private void OnPlayerFriendCasualKillsDuoSelected()
		{
		}

		// Token: 0x06008826 RID: 34854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008826")]
		[Address(RVA = "0x1E360F0", Offset = "0x1E360F0", VA = "0x7BBC6360F0")]
		private void OnPlayerFriendCasualKillsTeamSelected()
		{
		}

		// Token: 0x06008827 RID: 34855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008827")]
		[Address(RVA = "0x1E3616C", Offset = "0x1E3616C", VA = "0x7BBC63616C")]
		private void OnPlayerFriendCasualWinsSoloSelected()
		{
		}

		// Token: 0x06008828 RID: 34856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008828")]
		[Address(RVA = "0x1E361EC", Offset = "0x1E361EC", VA = "0x7BBC6361EC")]
		private void OnPlayerFriendCasualWinsDuoSelected()
		{
		}

		// Token: 0x06008829 RID: 34857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008829")]
		[Address(RVA = "0x1E3626C", Offset = "0x1E3626C", VA = "0x7BBC63626C")]
		private void OnPlayerFriendCasualWinsTeamSelected()
		{
		}

		// Token: 0x0600882A RID: 34858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600882A")]
		[Address(RVA = "0x1E362EC", Offset = "0x1E362EC", VA = "0x7BBC6362EC")]
		private void OnPlayerFriendCSKillsSelected()
		{
		}

		// Token: 0x0600882B RID: 34859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600882B")]
		[Address(RVA = "0x1E36370", Offset = "0x1E36370", VA = "0x7BBC636370")]
		private void OnPlayerFriendCSWinsSelected()
		{
		}

		// Token: 0x0600882C RID: 34860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600882C")]
		[Address(RVA = "0x1E363F4", Offset = "0x1E363F4", VA = "0x7BBC6363F4")]
		private void OnPlayerRegionCSKillsSelected()
		{
		}

		// Token: 0x0600882D RID: 34861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600882D")]
		[Address(RVA = "0x1E36580", Offset = "0x1E36580", VA = "0x7BBC636580")]
		private void OnPlayerRegionCSWinsSelected()
		{
		}

		// Token: 0x0600882E RID: 34862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600882E")]
		[Address(RVA = "0x1E3670C", Offset = "0x1E3670C", VA = "0x7BBC63670C")]
		private void OnFFCTeamRegionKillsSelected()
		{
		}

		// Token: 0x0600882F RID: 34863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600882F")]
		[Address(RVA = "0x1E36894", Offset = "0x1E36894", VA = "0x7BBC636894")]
		private void OnFFCTeamRegionScoreSelected()
		{
		}

		// Token: 0x06008830 RID: 34864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008830")]
		[Address(RVA = "0x1E36A1C", Offset = "0x1E36A1C", VA = "0x7BBC636A1C")]
		private void OnThirdPartyTeamRegionScoreSelected()
		{
		}

		// Token: 0x06008831 RID: 34865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008831")]
		[Address(RVA = "0x1E36BA4", Offset = "0x1E36BA4", VA = "0x7BBC636BA4")]
		private void OnThirdPartyTeamRegionKillsSelected()
		{
		}

		// Token: 0x06008832 RID: 34866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008832")]
		[Address(RVA = "0x1E36D2C", Offset = "0x1E36D2C", VA = "0x7BBC636D2C")]
		private void OnGuildRegionWeekHonorSelected()
		{
		}

		// Token: 0x06008833 RID: 34867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008833")]
		[Address(RVA = "0x1E37108", Offset = "0x1E37108", VA = "0x7BBC637108")]
		private void OnGuildRegionTotalHonorSelected()
		{
		}

		// Token: 0x06008834 RID: 34868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008834")]
		[Address(RVA = "0x1E37254", Offset = "0x1E37254", VA = "0x7BBC637254")]
		private void OnGuildGlobalHonorSelected()
		{
		}

		// Token: 0x06008835 RID: 34869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008835")]
		[Address(RVA = "0x1E37318", Offset = "0x1E37318", VA = "0x7BBC637318")]
		private void OnPlayerFriendBadgesSelected()
		{
		}

		// Token: 0x06008836 RID: 34870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008836")]
		[Address(RVA = "0x1E37398", Offset = "0x1E37398", VA = "0x7BBC637398")]
		private void OnPlayerRegionBadgesSelected()
		{
		}

		// Token: 0x06008837 RID: 34871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008837")]
		[Address(RVA = "0x1E37518", Offset = "0x1E37518", VA = "0x7BBC637518")]
		private void OnPlayerGlobalBadgesSelected()
		{
		}

		// Token: 0x06008838 RID: 34872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008838")]
		[Address(RVA = "0x1E37644", Offset = "0x1E37644", VA = "0x7BBC637644")]
		private void BeforeRequestData(int propID)
		{
		}

		// Token: 0x06008839 RID: 34873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008839")]
		[Address(RVA = "0x1E3525C", Offset = "0x1E3525C", VA = "0x7BBC63525C")]
		private void RequestFriendData(int propID)
		{
		}

		// Token: 0x0600883A RID: 34874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600883A")]
		[Address(RVA = "0x1E35724", Offset = "0x1E35724", VA = "0x7BBC635724")]
		private void RequestData(int propID, int mainType = 0, int subType = 0, ulong mainKey = 0UL, ulong subKey = 0UL, string region = "", uint httpOp = 0U, bool force = false, uint pageIndex = 0U, uint pageSize = 100U, bool getSelf = true)
		{
		}

		// Token: 0x0600883B RID: 34875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600883B")]
		[Address(RVA = "0x1E37718", Offset = "0x1E37718", VA = "0x7BBC637718")]
		private void SwitchListTitle()
		{
		}

		// Token: 0x0600883C RID: 34876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600883C")]
		[Address(RVA = "0x1E2DEB8", Offset = "0x1E2DEB8", VA = "0x7BBC62DEB8")]
		private void HideAllListTitle()
		{
		}

		// Token: 0x0600883D RID: 34877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600883D")]
		[Address(RVA = "0x1E37870", Offset = "0x1E37870", VA = "0x7BBC637870")]
		private void RefreshListFriendPlayer()
		{
		}

		// Token: 0x0600883E RID: 34878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600883E")]
		[Address(RVA = "0x1E37C60", Offset = "0x1E37C60", VA = "0x7BBC637C60")]
		private void RefreshListPlayer()
		{
		}

		// Token: 0x0600883F RID: 34879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600883F")]
		[Address(RVA = "0x1E37F38", Offset = "0x1E37F38", VA = "0x7BBC637F38")]
		private void RefreshListGuild()
		{
		}

		// Token: 0x06008840 RID: 34880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008840")]
		[Address(RVA = "0x1E381EC", Offset = "0x1E381EC", VA = "0x7BBC6381EC")]
		private void RefreshListTeam()
		{
		}

		// Token: 0x06008841 RID: 34881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008841")]
		[Address(RVA = "0x1E37B1C", Offset = "0x1E37B1C", VA = "0x7BBC637B1C")]
		private void SetSelfTipsInfoActive(bool show)
		{
		}

		// Token: 0x06008842 RID: 34882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008842")]
		[Address(RVA = "0x1E384D4", Offset = "0x1E384D4", VA = "0x7BBC6384D4", Slot = "39")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06008843 RID: 34883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008843")]
		[Address(RVA = "0x1E37C1C", Offset = "0x1E37C1C", VA = "0x7BBC637C1C")]
		private void SetItemBGInfo(UILeaderBoardItemNewController ctrl)
		{
		}

		// Token: 0x06008844 RID: 34884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008844")]
		[Address(RVA = "0x1E38664", Offset = "0x1E38664", VA = "0x7BBC638664", Slot = "40")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06008845 RID: 34885 RVA: 0x00024B10 File Offset: 0x00022D10
		[Token(Token = "0x6008845")]
		[Address(RVA = "0x1E3489C", Offset = "0x1E3489C", VA = "0x7BBC63489C")]
		public int GetBGWidth1()
		{
			return 0;
		}

		// Token: 0x06008846 RID: 34886 RVA: 0x00024B28 File Offset: 0x00022D28
		[Token(Token = "0x6008846")]
		[Address(RVA = "0x1E348A4", Offset = "0x1E348A4", VA = "0x7BBC6348A4")]
		public int GetBGWidth2()
		{
			return 0;
		}

		// Token: 0x06008847 RID: 34887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008847")]
		[Address(RVA = "0x1E331D0", Offset = "0x1E331D0", VA = "0x7BBC6331D0")]
		private void SetSeasonBtnState(bool show)
		{
		}

		// Token: 0x06008848 RID: 34888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008848")]
		[Address(RVA = "0x1E33230", Offset = "0x1E33230", VA = "0x7BBC633230")]
		private void SetCSSeasonBtnState(bool show)
		{
		}

		// Token: 0x06008849 RID: 34889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008849")]
		[Address(RVA = "0x1E33290", Offset = "0x1E33290", VA = "0x7BBC633290")]
		private void SetShareBtnState(bool share1Show, bool share2Show)
		{
		}

		// Token: 0x0600884A RID: 34890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600884A")]
		[Address(RVA = "0x1E330CC", Offset = "0x1E330CC", VA = "0x7BBC6330CC")]
		private void SetProfileBtnState(bool show)
		{
		}

		// Token: 0x0600884B RID: 34891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600884B")]
		[Address(RVA = "0x1E38694", Offset = "0x1E38694", VA = "0x7BBC638694")]
		private void OnSeasonTipsBtnClick()
		{
		}

		// Token: 0x0600884C RID: 34892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600884C")]
		[Address(RVA = "0x1E38B38", Offset = "0x1E38B38", VA = "0x7BBC638B38")]
		private void OnCSSeasonTipsBtnClick()
		{
		}

		// Token: 0x0600884D RID: 34893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600884D")]
		[Address(RVA = "0x1E36EAC", Offset = "0x1E36EAC", VA = "0x7BBC636EAC")]
		private void SetGuildWeekTipsInfo()
		{
		}

		// Token: 0x0600884E RID: 34894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600884E")]
		[Address(RVA = "0x1E3342C", Offset = "0x1E3342C", VA = "0x7BBC63342C")]
		private void HideGuildWeekTipsInfo()
		{
		}

		// Token: 0x0600884F RID: 34895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600884F")]
		[Address(RVA = "0x1E38FF4", Offset = "0x1E38FF4", VA = "0x7BBC638FF4", Slot = "41")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008850 RID: 34896 RVA: 0x00024B40 File Offset: 0x00022D40
		[Token(Token = "0x6008850")]
		[Address(RVA = "0x1E394D8", Offset = "0x1E394D8", VA = "0x7BBC6394D8", Slot = "42")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008851 RID: 34897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008851")]
		[Address(RVA = "0x1E34E54", Offset = "0x1E34E54", VA = "0x7BBC634E54")]
		private string GetDeepLink(UILeaderBoardNewController.DeepLinkLayer layer)
		{
			return null;
		}

		// Token: 0x06008852 RID: 34898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008852")]
		[Address(RVA = "0x1E3954C", Offset = "0x1E3954C", VA = "0x7BBC63954C")]
		private void OnShareClick()
		{
		}

		// Token: 0x06008853 RID: 34899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008853")]
		[Address(RVA = "0x1E39634", Offset = "0x1E39634", VA = "0x7BBC639634")]
		private void OnProfileClick()
		{
		}

		// Token: 0x06008854 RID: 34900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008854")]
		[Address(RVA = "0x1E3986C", Offset = "0x1E3986C", VA = "0x7BBC63986C", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x06008855 RID: 34901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008855")]
		[Address(RVA = "0x1E398E4", Offset = "0x1E398E4", VA = "0x7BBC6398E4", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x06008856 RID: 34902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008856")]
		[Address(RVA = "0x1E3997C", Offset = "0x1E3997C", VA = "0x7BBC63997C")]
		private void OnLeaderBoardItemSelected(params object[] param)
		{
		}

		// Token: 0x06008857 RID: 34903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008857")]
		[Address(RVA = "0x1E34C80", Offset = "0x1E34C80", VA = "0x7BBC634C80")]
		private void TryShowPreviewAvatar(ulong accountID)
		{
		}

		// Token: 0x06008858 RID: 34904 RVA: 0x00024B58 File Offset: 0x00022D58
		[Token(Token = "0x6008858")]
		[Address(RVA = "0x1E39304", Offset = "0x1E39304", VA = "0x7BBC639304")]
		private bool ShowAvatar(ulong accountID)
		{
			return default(bool);
		}

		// Token: 0x06008859 RID: 34905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008859")]
		[Address(RVA = "0x1E33BC4", Offset = "0x1E33BC4", VA = "0x7BBC633BC4")]
		private void ClearSelectedAccountID()
		{
		}

		// Token: 0x0600885A RID: 34906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600885A")]
		[Address(RVA = "0x1E33488", Offset = "0x1E33488", VA = "0x7BBC633488")]
		private void ShowLoading(bool show)
		{
		}

		// Token: 0x0600885B RID: 34907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600885B")]
		[Address(RVA = "0x1E39A38", Offset = "0x1E39A38", VA = "0x7BBC639A38")]
		public UILeaderBoardNewController()
		{
		}

		// Token: 0x0600885D RID: 34909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600885D")]
		[Address(RVA = "0x1E3B854", Offset = "0x1E3B854", VA = "0x7BBC63B854")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11436C0", Offset = "0x11436C0")]
		private void <OnGuildRegionWeekHonorSelected>b__140_0()
		{
		}

		// Token: 0x0600885E RID: 34910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600885E")]
		[Address(RVA = "0x1E3B908", Offset = "0x1E3B908", VA = "0x7BBC63B908")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11436D0", Offset = "0x11436D0")]
		private void <OnGuildRegionTotalHonorSelected>b__141_0()
		{
		}

		// Token: 0x04009679 RID: 38521
		[Token(Token = "0x4009679")]
		[FieldOffset(Offset = "0xB0")]
		private UILeaderBoardNewView m_View;

		// Token: 0x0400967A RID: 38522
		[Token(Token = "0x400967A")]
		[FieldOffset(Offset = "0xB8")]
		private UINavigationData m_NavData;

		// Token: 0x0400967B RID: 38523
		[Token(Token = "0x400967B")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelLeaderBoard m_ModelLeaderBoard;

		// Token: 0x0400967C RID: 38524
		[Token(Token = "0x400967C")]
		[FieldOffset(Offset = "0xC8")]
		public bool m_LeaderBoardMenuCreated;

		// Token: 0x0400967D RID: 38525
		[Token(Token = "0x400967D")]
		[FieldOffset(Offset = "0xCC")]
		private int m_RequestPropIDs;

		// Token: 0x0400967E RID: 38526
		[Token(Token = "0x400967E")]
		[FieldOffset(Offset = "0xD0")]
		private Action m_RefreshList;

		// Token: 0x0400967F RID: 38527
		[Token(Token = "0x400967F")]
		[FieldOffset(Offset = "0xD8")]
		private UILeaderBoardItemNewController m_SelfRankUI;

		// Token: 0x04009680 RID: 38528
		[Token(Token = "0x4009680")]
		[FieldOffset(Offset = "0xE0")]
		private UILeaderBoardItemNewController.DisplayType m_ListItemDisplayType;

		// Token: 0x04009681 RID: 38529
		[Token(Token = "0x4009681")]
		[FieldOffset(Offset = "0xE8")]
		private string m_DeepLink;

		// Token: 0x04009682 RID: 38530
		[Token(Token = "0x4009682")]
		[FieldOffset(Offset = "0xF0")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x04009683 RID: 38531
		[Token(Token = "0x4009683")]
		[FieldOffset(Offset = "0xF8")]
		private UIModelAvatarProfile m_ModelAvatarProfile;

		// Token: 0x04009684 RID: 38532
		[Token(Token = "0x4009684")]
		[FieldOffset(Offset = "0x100")]
		private UIStandardDrawerTabController m_DrawerTabCtrl;

		// Token: 0x04009685 RID: 38533
		[Token(Token = "0x4009685")]
		[FieldOffset(Offset = "0x108")]
		private List<UIPopMenuLeaderBoardControler> m_PopMenusList;

		// Token: 0x04009686 RID: 38534
		[Token(Token = "0x4009686")]
		[FieldOffset(Offset = "0x110")]
		private Dictionary<string, Action> m_DicCallBack;

		// Token: 0x04009687 RID: 38535
		[Token(Token = "0x4009687")]
		[FieldOffset(Offset = "0x118")]
		private List<string> m_Fliters;

		// Token: 0x04009688 RID: 38536
		[Token(Token = "0x4009688")]
		[FieldOffset(Offset = "0x120")]
		private Dictionary<string, List<FliterData>> m_DicFliterData;

		// Token: 0x04009689 RID: 38537
		[Token(Token = "0x4009689")]
		[FieldOffset(Offset = "0x128")]
		private List<TabInfo> m_TabList;

		// Token: 0x0400968A RID: 38538
		[Token(Token = "0x400968A")]
		[FieldOffset(Offset = "0x130")]
		private int m_BGWidth1;

		// Token: 0x0400968B RID: 38539
		[Token(Token = "0x400968B")]
		[FieldOffset(Offset = "0x134")]
		private int m_BGWidth2;

		// Token: 0x0400968C RID: 38540
		[Token(Token = "0x400968C")]
		[FieldOffset(Offset = "0x138")]
		private UILeaderBoardNewController.EStyle m_CurrStyle;

		// Token: 0x0400968D RID: 38541
		[Token(Token = "0x400968D")]
		[FieldOffset(Offset = "0x140")]
		private ulong m_SelectedAccountID;

		// Token: 0x0400968E RID: 38542
		[Token(Token = "0x400968E")]
		[FieldOffset(Offset = "0x148")]
		private bool m_InitedBGWidth;

		// Token: 0x0400968F RID: 38543
		[Token(Token = "0x400968F")]
		[FieldOffset(Offset = "0x150")]
		private UIRoot uiRoot;

		// Token: 0x04009690 RID: 38544
		[Token(Token = "0x4009690")]
		public const string DL_Rank = "Rank";

		// Token: 0x04009691 RID: 38545
		[Token(Token = "0x4009691")]
		public const string DL_Casual = "Casual";

		// Token: 0x04009692 RID: 38546
		[Token(Token = "0x4009692")]
		public const string DL_CSRank = "CSRank";

		// Token: 0x04009693 RID: 38547
		[Token(Token = "0x4009693")]
		public const string DL_Team = "Team";

		// Token: 0x04009694 RID: 38548
		[Token(Token = "0x4009694")]
		public const string DL_Guild = "Guild";

		// Token: 0x04009695 RID: 38549
		[Token(Token = "0x4009695")]
		public const string DL_Badges = "Badges";

		// Token: 0x04009696 RID: 38550
		[Token(Token = "0x4009696")]
		public const string DL_Friend = "Friend";

		// Token: 0x04009697 RID: 38551
		[Token(Token = "0x4009697")]
		public const string DL_Region = "Region";

		// Token: 0x04009698 RID: 38552
		[Token(Token = "0x4009698")]
		public const string DL_Global = "Global";

		// Token: 0x04009699 RID: 38553
		[Token(Token = "0x4009699")]
		public const string DL_FFC = "FFC";

		// Token: 0x0400969A RID: 38554
		[Token(Token = "0x400969A")]
		public const string DL_ThirdParty = "Third Party";

		// Token: 0x0400969B RID: 38555
		[Token(Token = "0x400969B")]
		public const string DL_Kill = "Kill";

		// Token: 0x0400969C RID: 38556
		[Token(Token = "0x400969C")]
		public const string DL_Win = "Win";

		// Token: 0x0400969D RID: 38557
		[Token(Token = "0x400969D")]
		public const string DL_Score = "Score";

		// Token: 0x0400969E RID: 38558
		[Token(Token = "0x400969E")]
		public const string DL_GuildWeek = "GuildWeek";

		// Token: 0x0400969F RID: 38559
		[Token(Token = "0x400969F")]
		public const string DL_GuildTotal = "GuildTotal";

		// Token: 0x040096A0 RID: 38560
		[Token(Token = "0x40096A0")]
		public const string DL_SOLO = "Solo";

		// Token: 0x040096A1 RID: 38561
		[Token(Token = "0x40096A1")]
		public const string DL_DUO = "Duo";

		// Token: 0x040096A2 RID: 38562
		[Token(Token = "0x40096A2")]
		public const string DL_SQUA = "Squa";

		// Token: 0x040096A3 RID: 38563
		[Token(Token = "0x40096A3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string DL_RankFriendKillSOLO;

		// Token: 0x040096A4 RID: 38564
		[Token(Token = "0x40096A4")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string DL_RankFriendKillDUO;

		// Token: 0x040096A5 RID: 38565
		[Token(Token = "0x40096A5")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string DL_RankFriendKillSQUA;

		// Token: 0x040096A6 RID: 38566
		[Token(Token = "0x40096A6")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string DL_RankFriendWinSOLO;

		// Token: 0x040096A7 RID: 38567
		[Token(Token = "0x40096A7")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string DL_RankFriendWinDUO;

		// Token: 0x040096A8 RID: 38568
		[Token(Token = "0x40096A8")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string DL_RankFriendWinSQUA;

		// Token: 0x040096A9 RID: 38569
		[Token(Token = "0x40096A9")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string DL_RankRegionKillSOLO;

		// Token: 0x040096AA RID: 38570
		[Token(Token = "0x40096AA")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string DL_RankRegionKillDUO;

		// Token: 0x040096AB RID: 38571
		[Token(Token = "0x40096AB")]
		[FieldOffset(Offset = "0x40")]
		public static readonly string DL_RankRegionKillSQUA;

		// Token: 0x040096AC RID: 38572
		[Token(Token = "0x40096AC")]
		[FieldOffset(Offset = "0x48")]
		public static readonly string DL_RankRegionWinSOLO;

		// Token: 0x040096AD RID: 38573
		[Token(Token = "0x40096AD")]
		[FieldOffset(Offset = "0x50")]
		public static readonly string DL_RankRegionWinDUO;

		// Token: 0x040096AE RID: 38574
		[Token(Token = "0x40096AE")]
		[FieldOffset(Offset = "0x58")]
		public static readonly string DL_RankRegionWinSQUA;

		// Token: 0x040096AF RID: 38575
		[Token(Token = "0x40096AF")]
		[FieldOffset(Offset = "0x60")]
		public static readonly string DL_CasualFriendKillSOLO;

		// Token: 0x040096B0 RID: 38576
		[Token(Token = "0x40096B0")]
		[FieldOffset(Offset = "0x68")]
		public static readonly string DL_CasualFriendKillDUO;

		// Token: 0x040096B1 RID: 38577
		[Token(Token = "0x40096B1")]
		[FieldOffset(Offset = "0x70")]
		public static readonly string DL_CasualFriendKillSQUA;

		// Token: 0x040096B2 RID: 38578
		[Token(Token = "0x40096B2")]
		[FieldOffset(Offset = "0x78")]
		public static readonly string DL_CasualFriendWinSOLO;

		// Token: 0x040096B3 RID: 38579
		[Token(Token = "0x40096B3")]
		[FieldOffset(Offset = "0x80")]
		public static readonly string DL_CasualFriendWinDUO;

		// Token: 0x040096B4 RID: 38580
		[Token(Token = "0x40096B4")]
		[FieldOffset(Offset = "0x88")]
		public static readonly string DL_CasualFriendWinSQUA;

		// Token: 0x040096B5 RID: 38581
		[Token(Token = "0x40096B5")]
		[FieldOffset(Offset = "0x90")]
		public static readonly string DL_CSRankFriendKill;

		// Token: 0x040096B6 RID: 38582
		[Token(Token = "0x40096B6")]
		[FieldOffset(Offset = "0x98")]
		public static readonly string DL_CSRankFriendWin;

		// Token: 0x040096B7 RID: 38583
		[Token(Token = "0x40096B7")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly string DL_CSRankRegionKill;

		// Token: 0x040096B8 RID: 38584
		[Token(Token = "0x40096B8")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly string DL_CSRankRegionWin;

		// Token: 0x040096B9 RID: 38585
		[Token(Token = "0x40096B9")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly string DL_TeamFFCKill;

		// Token: 0x040096BA RID: 38586
		[Token(Token = "0x40096BA")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly string DL_TeamFFCScore;

		// Token: 0x040096BB RID: 38587
		[Token(Token = "0x40096BB")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly string DL_TeamThirdPartyKill;

		// Token: 0x040096BC RID: 38588
		[Token(Token = "0x40096BC")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly string DL_TeamThirdPartyScore;

		// Token: 0x040096BD RID: 38589
		[Token(Token = "0x40096BD")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly string DL_GuildRegionWeek;

		// Token: 0x040096BE RID: 38590
		[Token(Token = "0x40096BE")]
		[FieldOffset(Offset = "0xD8")]
		public static readonly string DL_GuildRegionTotal;

		// Token: 0x040096BF RID: 38591
		[Token(Token = "0x40096BF")]
		[FieldOffset(Offset = "0xE0")]
		public static readonly string DL_GuildGlobal;

		// Token: 0x040096C0 RID: 38592
		[Token(Token = "0x40096C0")]
		[FieldOffset(Offset = "0xE8")]
		public static readonly string DL_EPBadgesFriend;

		// Token: 0x040096C1 RID: 38593
		[Token(Token = "0x40096C1")]
		[FieldOffset(Offset = "0xF0")]
		public static readonly string DL_EPBadgesRegion;

		// Token: 0x040096C2 RID: 38594
		[Token(Token = "0x40096C2")]
		[FieldOffset(Offset = "0xF8")]
		public static readonly string DL_EPBadgesGlobal;

		// Token: 0x040096C3 RID: 38595
		[Token(Token = "0x40096C3")]
		[FieldOffset(Offset = "0x158")]
		public LeaderBoardInfo m_SelectedInfo;

		// Token: 0x040096C4 RID: 38596
		[Token(Token = "0x40096C4")]
		[FieldOffset(Offset = "0x160")]
		private bool m_ClanLocalWeekSelected;

		// Token: 0x020019D5 RID: 6613
		[Token(Token = "0x20019D5")]
		private enum EStyle
		{
			// Token: 0x040096C6 RID: 38598
			[Token(Token = "0x40096C6")]
			Short,
			// Token: 0x040096C7 RID: 38599
			[Token(Token = "0x40096C7")]
			Long
		}

		// Token: 0x020019D6 RID: 6614
		[Token(Token = "0x20019D6")]
		public enum DeepLinkLayer
		{
			// Token: 0x040096C9 RID: 38601
			[Token(Token = "0x40096C9")]
			L0,
			// Token: 0x040096CA RID: 38602
			[Token(Token = "0x40096CA")]
			L1,
			// Token: 0x040096CB RID: 38603
			[Token(Token = "0x40096CB")]
			L2,
			// Token: 0x040096CC RID: 38604
			[Token(Token = "0x40096CC")]
			L3
		}

		// Token: 0x020019D7 RID: 6615
		[Token(Token = "0x20019D7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F71AC", Offset = "0x10F71AC")]
		private sealed class <>c__DisplayClass110_0
		{
			// Token: 0x0600885F RID: 34911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600885F")]
			[Address(RVA = "0x1E34E4C", Offset = "0x1E34E4C", VA = "0x7BBC634E4C")]
			public <>c__DisplayClass110_0()
			{
			}

			// Token: 0x06008860 RID: 34912 RVA: 0x00024B70 File Offset: 0x00022D70
			[Token(Token = "0x6008860")]
			[Address(RVA = "0x1E3B990", Offset = "0x1E3B990", VA = "0x7BBC63B990")]
			internal bool <NavigationToLeaderBoard>b__0(TabInfo tabinfo)
			{
				return default(bool);
			}

			// Token: 0x040096CD RID: 38605
			[Token(Token = "0x40096CD")]
			[FieldOffset(Offset = "0x10")]
			public string fliter1;
		}
	}
}
