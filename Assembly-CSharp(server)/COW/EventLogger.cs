using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020011C1 RID: 4545
	[Token(Token = "0x20011C1")]
	public static class EventLogger
	{
		// Token: 0x060046C2 RID: 18114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C2")]
		[Address(RVA = "0x1B88F00", Offset = "0x1B88F00", VA = "0x7BBC388F00")]
		public static void OnLogin()
		{
		}

		// Token: 0x060046C3 RID: 18115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C3")]
		[Address(RVA = "0x1B88F04", Offset = "0x1B88F04", VA = "0x7BBC388F04")]
		public static void OnLogout()
		{
		}

		// Token: 0x060046C4 RID: 18116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C4")]
		[Address(RVA = "0x1B8949C", Offset = "0x1B8949C", VA = "0x7BBC38949C")]
		public static void SwitchObserver()
		{
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C5")]
		[Address(RVA = "0x1B89530", Offset = "0x1B89530", VA = "0x7BBC389530")]
		public static void StartObserver(int mode)
		{
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C6")]
		[Address(RVA = "0x1B89674", Offset = "0x1B89674", VA = "0x7BBC389674")]
		public static void ClickEndObserver()
		{
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C7")]
		[Address(RVA = "0x1B89AB8", Offset = "0x1B89AB8", VA = "0x7BBC389AB8")]
		public static void SendLogObserver()
		{
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C8")]
		[Address(RVA = "0x1B89BB8", Offset = "0x1B89BB8", VA = "0x7BBC389BB8")]
		public static void LogSplashBannerGoto(uint id, string goto_url, uint goto_pos)
		{
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C9")]
		[Address(RVA = "0x1B89CE0", Offset = "0x1B89CE0", VA = "0x7BBC389CE0")]
		public static void LogAnniversaySplashBannerGoto(uint id, string goto_url, uint goto_pos)
		{
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046CA")]
		[Address(RVA = "0x1B89E00", Offset = "0x1B89E00", VA = "0x7BBC389E00")]
		public static void LogAnniversaySplashBannerPush(uint event_id, uint entry_id, bool state)
		{
		}

		// Token: 0x060046CB RID: 18123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046CB")]
		[Address(RVA = "0x1B89F2C", Offset = "0x1B89F2C", VA = "0x7BBC389F2C")]
		public static void LogGroupInviteOperation(uint oper_type)
		{
		}

		// Token: 0x060046CC RID: 18124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046CC")]
		[Address(RVA = "0x1B89FD0", Offset = "0x1B89FD0", VA = "0x7BBC389FD0")]
		public static void LogEventLoadingTimeUtilCloseMask(float currentTime)
		{
		}

		// Token: 0x060046CD RID: 18125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046CD")]
		[Address(RVA = "0x1B8A060", Offset = "0x1B8A060", VA = "0x7BBC38A060")]
		public static void LogEventLoadingTime(float currentTime)
		{
		}

		// Token: 0x060046CE RID: 18126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046CE")]
		[Address(RVA = "0x1B8A118", Offset = "0x1B8A118", VA = "0x7BBC38A118")]
		public static void LogEventWaitingForMatchmaking(float currentTime)
		{
		}

		// Token: 0x060046CF RID: 18127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046CF")]
		[Address(RVA = "0x1B8A298", Offset = "0x1B8A298", VA = "0x7BBC38A298")]
		public static void LogAddFriendActively(ulong friend_account_id)
		{
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D0")]
		[Address(RVA = "0x1B8A3D0", Offset = "0x1B8A3D0", VA = "0x7BBC38A3D0")]
		public static void StartLogFPS(EventLogger.EventFPS_RuntimeData.FPSTrackingStep step, float gameTime, float duration)
		{
		}

		// Token: 0x060046D1 RID: 18129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D1")]
		[Address(RVA = "0x1B8AA5C", Offset = "0x1B8AA5C", VA = "0x7BBC38AA5C")]
		public static void LogFPS(float currentTime, float fps)
		{
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D2")]
		[Address(RVA = "0x1B8A50C", Offset = "0x1B8A50C", VA = "0x7BBC38A50C")]
		private static void SendFPSLog()
		{
		}

		// Token: 0x060046D3 RID: 18131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D3")]
		[Address(RVA = "0x1B8ADF4", Offset = "0x1B8ADF4", VA = "0x7BBC38ADF4")]
		public static void LogGameMemory(EventLogger.EGameTimeType _type)
		{
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D4")]
		[Address(RVA = "0x1B8AFC0", Offset = "0x1B8AFC0", VA = "0x7BBC38AFC0")]
		private static void SendGameMemoryLog()
		{
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D5")]
		[Address(RVA = "0x1B8B240", Offset = "0x1B8B240", VA = "0x7BBC38B240")]
		public static void StartLogGameLag()
		{
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D6")]
		[Address(RVA = "0x1B8B410", Offset = "0x1B8B410", VA = "0x7BBC38B410")]
		public static void SetGameTriggerLog(int triggerType, uint id)
		{
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D7")]
		[Address(RVA = "0x1B8B5DC", Offset = "0x1B8B5DC", VA = "0x7BBC38B5DC")]
		public static void SendGameLagLog()
		{
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D8")]
		[Address(RVA = "0x1B8B980", Offset = "0x1B8B980", VA = "0x7BBC38B980")]
		public static void LogPing()
		{
		}

		// Token: 0x060046D9 RID: 18137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D9")]
		[Address(RVA = "0x1B8BF34", Offset = "0x1B8BF34", VA = "0x7BBC38BF34")]
		public static void LogBillboard(uint announcementId = 0U, uint activityId = 0U, string url = "")
		{
		}

		// Token: 0x060046DA RID: 18138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DA")]
		[Address(RVA = "0x1B8C134", Offset = "0x1B8C134", VA = "0x7BBC38C134")]
		public static void LogDisconnectFromNetwork(EventLogger.EDisconnectionType disconnectionType)
		{
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DB")]
		[Address(RVA = "0x1B8C560", Offset = "0x1B8C560", VA = "0x7BBC38C560")]
		public static void SendProfilePageViewTime()
		{
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DC")]
		[Address(RVA = "0x1B89794", Offset = "0x1B89794", VA = "0x7BBC389794")]
		public static void SendEventLog(string eventType, EventLogger.EventLoggerBase payload)
		{
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DD")]
		[Address(RVA = "0x1B8C564", Offset = "0x1B8C564", VA = "0x7BBC38C564")]
		public static void SendNetworkEventLog(string eventType, object payload)
		{
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DE")]
		[Address(RVA = "0x1B8C780", Offset = "0x1B8C780", VA = "0x7BBC38C780")]
		private static string GetCurrentDateTime()
		{
			return null;
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046DF")]
		[Address(RVA = "0x1B8C820", Offset = "0x1B8C820", VA = "0x7BBC38C820")]
		public static EventLogger.EventLoginInfo LoginInfo()
		{
			return null;
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E0")]
		[Address(RVA = "0x1B8D0E4", Offset = "0x1B8D0E4", VA = "0x7BBC38D0E4")]
		public static void LogIAPResult(string item_identifier, int error_code, string error_message, bool is_first_time, UINavigationUtil.UINavigationFrom ui_from)
		{
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E1")]
		[Address(RVA = "0x1B8D2E8", Offset = "0x1B8D2E8", VA = "0x7BBC38D2E8")]
		public static void LogScanIAPInventoryResult(EventLogger.ScanIAPInventoryResult[] results)
		{
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E2")]
		[Address(RVA = "0x1B8D4B4", Offset = "0x1B8D4B4", VA = "0x7BBC38D4B4")]
		public static void LogShare(EventLogger.EventShare share)
		{
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E3")]
		[Address(RVA = "0x1B8D524", Offset = "0x1B8D524", VA = "0x7BBC38D524")]
		public static void LogShareLinkReturn(string url)
		{
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E4")]
		[Address(RVA = "0x1B8D5C8", Offset = "0x1B8D5C8", VA = "0x7BBC38D5C8")]
		public static void LogIAPRebate(int rebate_id, int remaining_days, int error_code, string error_message, UINavigationUtil.UINavigationFrom ui_from)
		{
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E5")]
		[Address(RVA = "0x1B8D7D0", Offset = "0x1B8D7D0", VA = "0x7BBC38D7D0")]
		public static void LogRedeemRebate(int rebate_id, int remaining_days, int redeem_amount, int error_code, string error_message)
		{
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E6")]
		[Address(RVA = "0x1B8D9EC", Offset = "0x1B8D9EC", VA = "0x7BBC38D9EC")]
		public static void LogPlayerClimb(Vector3 pos, string trigger_tag)
		{
		}

		// Token: 0x060046E7 RID: 18151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E7")]
		[Address(RVA = "0x1B8D9F0", Offset = "0x1B8D9F0", VA = "0x7BBC38D9F0")]
		public static void LogReportCheat(ulong cheater, uint reason, {QAb\u0082~u cheaterPlayerID)
		{
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E8")]
		[Address(RVA = "0x1B8E190", Offset = "0x1B8E190", VA = "0x7BBC38E190")]
		public static void LogMatchWeaponInfo(string skinIds)
		{
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E9")]
		[Address(RVA = "0x1B8E194", Offset = "0x1B8E194", VA = "0x7BBC38E194")]
		public static void LogMatchWeaponEquip(uint wpId, uint skinId)
		{
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046EA")]
		[Address(RVA = "0x1B8E198", Offset = "0x1B8E198", VA = "0x7BBC38E198")]
		public static void LogOpenGacha()
		{
		}

		// Token: 0x060046EB RID: 18155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046EB")]
		[Address(RVA = "0x1B8E324", Offset = "0x1B8E324", VA = "0x7BBC38E324")]
		public static void LogOpenGachaRewardPool()
		{
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046EC")]
		[Address(RVA = "0x1B8E4B0", Offset = "0x1B8E4B0", VA = "0x7BBC38E4B0")]
		public static void SendChatEvent(EventLogger.EventChat eventChat)
		{
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046ED")]
		[Address(RVA = "0x1B8E55C", Offset = "0x1B8E55C", VA = "0x7BBC38E55C")]
		public static void LogGiftReceive(uint itemId, uint expireTime)
		{
		}

		// Token: 0x060046EE RID: 18158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046EE")]
		[Address(RVA = "0x1B8E728", Offset = "0x1B8E728", VA = "0x7BBC38E728")]
		public static void LogIAPBundlePurchase(int storeID, int bundleID, float priceUSD, int discount, int rebateID, string productIdentifier, UINavigationUtil.UINavigationFrom ui_from)
		{
		}

		// Token: 0x060046EF RID: 18159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046EF")]
		[Address(RVA = "0x1B8E980", Offset = "0x1B8E980", VA = "0x7BBC38E980")]
		public static void LogElitePassSubscription(bool result, int rebateID, string productIdentifier, int errorCode, string price, UINavigationUtil.UINavigationFrom ui_from)
		{
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F0")]
		[Address(RVA = "0x1B8EB74", Offset = "0x1B8EB74", VA = "0x7BBC38EB74")]
		public static void LogAndroidApplicationDetection(List<int> installedIDs)
		{
		}

		// Token: 0x060046F1 RID: 18161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F1")]
		[Address(RVA = "0x1B8ED80", Offset = "0x1B8ED80", VA = "0x7BBC38ED80")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x113DAA8", Offset = "0x113DAA8")]
		public static void LogChampionshipClick(EventLogger.ChampioshipClickType type, uint championshipType, uint championshipID)
		{
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F2")]
		[Address(RVA = "0x1B8EE6C", Offset = "0x1B8EE6C", VA = "0x7BBC38EE6C")]
		public static void InitCacheLogSend()
		{
		}

		// Token: 0x060046F3 RID: 18163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F3")]
		[Address(RVA = "0x1B88F84", Offset = "0x1B88F84", VA = "0x7BBC388F84")]
		private static void SendCachedLogs()
		{
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F4")]
		[Address(RVA = "0x1B8EF5C", Offset = "0x1B8EF5C", VA = "0x7BBC38EF5C")]
		public static void SendNavigateLogs()
		{
		}

		// Token: 0x060046F5 RID: 18165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F5")]
		[Address(RVA = "0x1B8F110", Offset = "0x1B8F110", VA = "0x7BBC38F110")]
		public static void CacheLobbyClickEvent(EventLogger.ELobbyClickType type)
		{
		}

		// Token: 0x060046F6 RID: 18166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F6")]
		[Address(RVA = "0x1B8F6C0", Offset = "0x1B8F6C0", VA = "0x7BBC38F6C0")]
		public static void CacheManualClickEvent(EventLogger.EManualClickType type)
		{
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F7")]
		[Address(RVA = "0x1B8F9A0", Offset = "0x1B8F9A0", VA = "0x7BBC38F9A0")]
		public static void CacheProfileClickEvent(EventLogger.EProfileClickType type)
		{
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x00015510 File Offset: 0x00013710
		[Token(Token = "0x60046F8")]
		[Address(RVA = "0x1B8FC44", Offset = "0x1B8FC44", VA = "0x7BBC38FC44")]
		private static uint GetShadowOption()
		{
			return 0U;
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F9")]
		[Address(RVA = "0x1B8FD50", Offset = "0x1B8FD50", VA = "0x7BBC38FD50")]
		public static void LogEnterGame()
		{
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046FA")]
		[Address(RVA = "0x1B904C4", Offset = "0x1B904C4", VA = "0x7BBC3904C4")]
		private static void InitLeaveGameLog()
		{
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046FB")]
		[Address(RVA = "0x1B90AB4", Offset = "0x1B90AB4", VA = "0x7BBC390AB4")]
		public static void LogIOSIDFA(string open_id, string idfa)
		{
		}

		// Token: 0x060046FC RID: 18172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046FC")]
		[Address(RVA = "0x1B90B7C", Offset = "0x1B90B7C", VA = "0x7BBC390B7C")]
		public static void LogEnterBattery()
		{
		}

		// Token: 0x060046FD RID: 18173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046FD")]
		[Address(RVA = "0x1B90C08", Offset = "0x1B90C08", VA = "0x7BBC390C08")]
		public static void AddPetClickCnt()
		{
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046FE")]
		[Address(RVA = "0x1B90CA0", Offset = "0x1B90CA0", VA = "0x7BBC390CA0")]
		public static void AddPetId(int id)
		{
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046FF")]
		[Address(RVA = "0x1B90D1C", Offset = "0x1B90D1C", VA = "0x7BBC390D1C")]
		public static void LogLeaveGame()
		{
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004700")]
		[Address(RVA = "0x1B90F20", Offset = "0x1B90F20", VA = "0x7BBC390F20")]
		public static void SendLogLeaveGame()
		{
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004701")]
		[Address(RVA = "0x1B90FD0", Offset = "0x1B90FD0", VA = "0x7BBC390FD0")]
		public static void LogHighFPSSwitch()
		{
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004702")]
		[Address(RVA = "0x1B910E8", Offset = "0x1B910E8", VA = "0x7BBC3910E8")]
		public static void LogOptionalDownloadComplete(int download_type, string optional_version, string package_name, string complete_result)
		{
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004703")]
		[Address(RVA = "0x1B911E8", Offset = "0x1B911E8", VA = "0x7BBC3911E8")]
		public static void LogButtonPosLowerLeftClick()
		{
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004704")]
		[Address(RVA = "0x1B91298", Offset = "0x1B91298", VA = "0x7BBC391298")]
		public static void SendGachaNotifyStateLog(bool shouldNotifyFreeGachas)
		{
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004705")]
		[Address(RVA = "0x1B91340", Offset = "0x1B91340", VA = "0x7BBC391340")]
		public static void LogOptionalDownloadOperation(int download_type, string optional_version, string package_name, string complete_result, EventLogger.EventLog_Optional_Operation opreration)
		{
		}

		// Token: 0x06004706 RID: 18182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004706")]
		[Address(RVA = "0x1B91454", Offset = "0x1B91454", VA = "0x7BBC391454")]
		public static void LogNavigate(UINavigationUtil.UINavigationFrom from, UINavigationUtil.UINavigationPageType to)
		{
		}

		// Token: 0x06004707 RID: 18183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004707")]
		[Address(RVA = "0x1B917B8", Offset = "0x1B917B8", VA = "0x7BBC3917B8")]
		public static void LogClick(EventLogger.ClickType clickType, params string[] hierarchy)
		{
		}

		// Token: 0x06004708 RID: 18184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004708")]
		[Address(RVA = "0x1B91AA8", Offset = "0x1B91AA8", VA = "0x7BBC391AA8")]
		public static void LogBroadCastType(EventLogger.EventBroadCastType type)
		{
		}

		// Token: 0x06004709 RID: 18185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004709")]
		[Address(RVA = "0x1B91D2C", Offset = "0x1B91D2C", VA = "0x7BBC391D2C")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x113DAE4", Offset = "0x113DAE4")]
		public static void CacheMallTabClick(uint mallType, string tabName)
		{
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470A")]
		[Address(RVA = "0x1B92000", Offset = "0x1B92000", VA = "0x7BBC392000")]
		public static void CacheInstallmentClick(EventLogger.EInstallmentClickType type)
		{
		}

		// Token: 0x0600470B RID: 18187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470B")]
		[Address(RVA = "0x1B92198", Offset = "0x1B92198", VA = "0x7BBC392198")]
		public static void CacheBackMall()
		{
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470C")]
		[Address(RVA = "0x1B92298", Offset = "0x1B92298", VA = "0x7BBC392298")]
		public static void LogClickGetAvatarBtn(uint avatarID, bool isbundlebtn)
		{
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470D")]
		[Address(RVA = "0x1B9237C", Offset = "0x1B9237C", VA = "0x7BBC39237C")]
		public static void OnApplicationPause(bool paused)
		{
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470E")]
		[Address(RVA = "0x1B92500", Offset = "0x1B92500", VA = "0x7BBC392500")]
		public static void OnApplicationQuit()
		{
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470F")]
		[Address(RVA = "0x1B925CC", Offset = "0x1B925CC", VA = "0x7BBC3925CC")]
		public static void InitIngameTipsSetting(uint value)
		{
		}

		// Token: 0x06004710 RID: 18192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004710")]
		[Address(RVA = "0x1B92720", Offset = "0x1B92720", VA = "0x7BBC392720")]
		public static void LogIngameTipsSetting(uint value)
		{
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004711")]
		[Address(RVA = "0x1B9279C", Offset = "0x1B9279C", VA = "0x7BBC39279C")]
		public static void SendIngameTipsSetting()
		{
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004712")]
		[Address(RVA = "0x1B92860", Offset = "0x1B92860", VA = "0x7BBC392860")]
		public static void SendBasicSettingLog(EventLogger.EventSettingChangeLog log)
		{
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004713")]
		[Address(RVA = "0x1B9292C", Offset = "0x1B9292C", VA = "0x7BBC39292C")]
		public static void SendMaxSettingLog(EventLogger.EventSettingChangeLog log)
		{
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004714")]
		[Address(RVA = "0x1B929F8", Offset = "0x1B929F8", VA = "0x7BBC3929F8")]
		public static void SendOperationSettingLog(EventLogger.EventSettingChangeLog log)
		{
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004715")]
		[Address(RVA = "0x1B92AC4", Offset = "0x1B92AC4", VA = "0x7BBC392AC4")]
		public static void LogEnterWaitingIslandBattery()
		{
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004716")]
		[Address(RVA = "0x1B92B50", Offset = "0x1B92B50", VA = "0x7BBC392B50")]
		public static void SendLogEnterWaitingIsland()
		{
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004717")]
		[Address(RVA = "0x1B92F40", Offset = "0x1B92F40", VA = "0x7BBC392F40")]
		public static void LogLeaveWaitingIslandBattleStarted(bool battleStarted)
		{
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004718")]
		[Address(RVA = "0x1B92DCC", Offset = "0x1B92DCC", VA = "0x7BBC392DCC")]
		private static void InitLogLeaveWaitingIsland()
		{
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004719")]
		[Address(RVA = "0x1B92FC0", Offset = "0x1B92FC0", VA = "0x7BBC392FC0")]
		public static void SendLogLeaveWaitingIsland()
		{
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471A")]
		[Address(RVA = "0x1B93158", Offset = "0x1B93158", VA = "0x7BBC393158")]
		public static void LogLeaveWaitingIslandPing()
		{
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471B")]
		[Address(RVA = "0x1B9359C", Offset = "0x1B9359C", VA = "0x7BBC39359C")]
		public static void LogClientPushSetting(bool is_first_login = false)
		{
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471C")]
		[Address(RVA = "0x1B93718", Offset = "0x1B93718", VA = "0x7BBC393718")]
		public static void LogClientSettingChange()
		{
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471D")]
		[Address(RVA = "0x1B93914", Offset = "0x1B93914", VA = "0x7BBC393914")]
		public static void LogFriendRecommend(RecommendFriendInfo recommendFriend, int choose)
		{
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471E")]
		[Address(RVA = "0x1B93AD0", Offset = "0x1B93AD0", VA = "0x7BBC393AD0")]
		public static void LogLoginVNLinkClick()
		{
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471F")]
		[Address(RVA = "0x1B93BB8", Offset = "0x1B93BB8", VA = "0x7BBC393BB8")]
		public static void LogLoginVNLinkShow()
		{
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004720")]
		[Address(RVA = "0x1B93C94", Offset = "0x1B93C94", VA = "0x7BBC393C94")]
		public static EventLogger.EventTrainingLocalGame GetTrainingLocalGameInfo()
		{
			return null;
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004721")]
		[Address(RVA = "0x1B93D68", Offset = "0x1B93D68", VA = "0x7BBC393D68")]
		public static void SendTrainingLocalGameLog()
		{
		}

		// Token: 0x06004722 RID: 18210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004722")]
		[Address(RVA = "0x1B93E10", Offset = "0x1B93E10", VA = "0x7BBC393E10")]
		public static EventLogger.EventWereWolvesGame GetEventWereWolvesGame()
		{
			return null;
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004723")]
		[Address(RVA = "0x1B93EE4", Offset = "0x1B93EE4", VA = "0x7BBC393EE4")]
		public static void SendWereWolvesGameLog()
		{
		}

		// Token: 0x06004724 RID: 18212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004724")]
		[Address(RVA = "0x1B93FDC", Offset = "0x1B93FDC", VA = "0x7BBC393FDC")]
		public static void SendBRDeadInfo(int deadReason)
		{
		}

		// Token: 0x06004725 RID: 18213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004725")]
		[Address(RVA = "0x1B941B8", Offset = "0x1B941B8", VA = "0x7BBC3941B8")]
		public static void OnSystemScreenShot()
		{
		}

		// Token: 0x06004726 RID: 18214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004726")]
		[Address(RVA = "0x1B94504", Offset = "0x1B94504", VA = "0x7BBC394504")]
		public static void SendMVPInfoLog(uint rank, bool isMVP)
		{
		}

		// Token: 0x04006DE8 RID: 28136
		[Token(Token = "0x4006DE8")]
		public const string EVENT_TYPE_ADDFRIENDACTIVELY = "EventTypeAddFriendActively";

		// Token: 0x04006DE9 RID: 28137
		[Token(Token = "0x4006DE9")]
		public const string EVENT_TYPE_DISCONNECTFROMNETWORK = "EventTypeDisconnectFromNetwork";

		// Token: 0x04006DEA RID: 28138
		[Token(Token = "0x4006DEA")]
		public const string EVENT_TYPE_GAME_LAG = "EventTypeGameLag";

		// Token: 0x04006DEB RID: 28139
		[Token(Token = "0x4006DEB")]
		public const string EVENT_TYPE_SHARE = "EventTypeShare";

		// Token: 0x04006DEC RID: 28140
		[Token(Token = "0x4006DEC")]
		public const string EVENT_TYPE_SHARE_LINK_RETURN = "EventTypeShareLinkReturn";

		// Token: 0x04006DED RID: 28141
		[Token(Token = "0x4006DED")]
		public const string EVENT_TYPE_IAP_RESULT = "EventTypeIAPResult";

		// Token: 0x04006DEE RID: 28142
		[Token(Token = "0x4006DEE")]
		public const string EVENT_TYPE_IAP_REBATE_RESULT = "EventTypeIAPRebateResult";

		// Token: 0x04006DEF RID: 28143
		[Token(Token = "0x4006DEF")]
		public const string EVENT_TYPE_REDEEM_REBATE_RESULT = "EventTypeRedeemRebateResult";

		// Token: 0x04006DF0 RID: 28144
		[Token(Token = "0x4006DF0")]
		public const string EVENT_TYPE_SPLASHBANNER_GOTO = "EventTypeSplashBannerGoto";

		// Token: 0x04006DF1 RID: 28145
		[Token(Token = "0x4006DF1")]
		public const string EVENT_TYPE_ANNIVERSARY_SPLASHBANNER_GOTO = "EventTypeLimitEventSplashBanner";

		// Token: 0x04006DF2 RID: 28146
		[Token(Token = "0x4006DF2")]
		public const string EVENT_TYPE_OBSERVER_LOG = "EventTypeObserverLog";

		// Token: 0x04006DF3 RID: 28147
		[Token(Token = "0x4006DF3")]
		public const string EVENT_TYPE_REPORT_CHEAT = "EventTypeReport";

		// Token: 0x04006DF4 RID: 28148
		[Token(Token = "0x4006DF4")]
		public const string EVENT_TYPE_GACHA_OPEN = "EventTypeOpenGachaEntrance";

		// Token: 0x04006DF5 RID: 28149
		[Token(Token = "0x4006DF5")]
		public const string EVENT_TYPE_GACHA_REWARDPOOL_OPEN = "EventTypeOpenRewardPoolCount";

		// Token: 0x04006DF6 RID: 28150
		[Token(Token = "0x4006DF6")]
		public const string EVENT_TYPE_GIFT_RECEIVE = "EventTypeGiftReceive";

		// Token: 0x04006DF7 RID: 28151
		[Token(Token = "0x4006DF7")]
		public const string EVENT_TYPE_CHAT = "EventTypeChat";

		// Token: 0x04006DF8 RID: 28152
		[Token(Token = "0x4006DF8")]
		public const string EVENT_TYPE_BILLBOARD = "EventTypeBillboard";

		// Token: 0x04006DF9 RID: 28153
		[Token(Token = "0x4006DF9")]
		public const string EVENT_TYPE_IAP_BUNDLE_PAYMENT = "EventTypeIAPBundlePayment";

		// Token: 0x04006DFA RID: 28154
		[Token(Token = "0x4006DFA")]
		public const string EVENT_TYPE_ELITE_PASS_SUBSCRIBE = "EventTypeElitePassSubscribe";

		// Token: 0x04006DFB RID: 28155
		[Token(Token = "0x4006DFB")]
		public const string EVENT_TYPE_SCAN_IAP_INVENTORY_RESULT = "EventTypeScanIAPInventoryResult";

		// Token: 0x04006DFC RID: 28156
		[Token(Token = "0x4006DFC")]
		public const string EVENT_TYPE_ANDROID_APPLICATION_DETECTION = "EventTypeAndroidApplicationDetection";

		// Token: 0x04006DFD RID: 28157
		[Token(Token = "0x4006DFD")]
		public const string EVENT_TYPE_LOOBY_CLICK_COUNT = "EventTypeLobbyClickCount";

		// Token: 0x04006DFE RID: 28158
		[Token(Token = "0x4006DFE")]
		public const string EVENT_TYPE_MANUAL_CLICK_COUNT = "EventTypeManualClickCount";

		// Token: 0x04006DFF RID: 28159
		[Token(Token = "0x4006DFF")]
		public const string EVENT_TYPE_NAVIGATION_CLICK_COUNT = "EventTypeNavigationClickCount";

		// Token: 0x04006E00 RID: 28160
		[Token(Token = "0x4006E00")]
		public const string EVENT_TYPE_ENTER_GAME = "EventTypeEnterGame";

		// Token: 0x04006E01 RID: 28161
		[Token(Token = "0x4006E01")]
		public const string EVENT_TYPE_LEAVE_GAME = "EventTypeLeaveGame";

		// Token: 0x04006E02 RID: 28162
		[Token(Token = "0x4006E02")]
		public const string EVENT_TYPE_HIGH_FRAME_SWITCH = "EventTypeHighFrameSwitch";

		// Token: 0x04006E03 RID: 28163
		[Token(Token = "0x4006E03")]
		public const string EVENT_TYPE_OPTIONALDOWNLOAD_COMPLETE = "EventTypeOptionalDownloadComplete";

		// Token: 0x04006E04 RID: 28164
		[Token(Token = "0x4006E04")]
		public const string EVENT_TYPE_OPTIONALDOWNLOAD_OPERATION = "EventTypeOptionalDownloadOperation";

		// Token: 0x04006E05 RID: 28165
		[Token(Token = "0x4006E05")]
		public const string EVENT_TYPE_NAVIGATE = "EventTypeNavigate";

		// Token: 0x04006E06 RID: 28166
		[Token(Token = "0x4006E06")]
		public const string EVENT_TYPE_GETAVATAR_BUNDLE = "EventTypeGetAvatarBundleClick";

		// Token: 0x04006E07 RID: 28167
		[Token(Token = "0x4006E07")]
		public const string EVENT_TYPE_PROFILE_CLICK_COUNT = "EventTypeGotoOthersPersonalShowTimes";

		// Token: 0x04006E08 RID: 28168
		[Token(Token = "0x4006E08")]
		public const string EVENT_TYPE_REWARDED_VIDEO_LOAD_LOG = "EventTypeRewardedVideoLoadLog";

		// Token: 0x04006E09 RID: 28169
		[Token(Token = "0x4006E09")]
		public const string EVENT_TYPE_GROUPINVITE_SWITCH = "EventTypeGroupInviteOperation";

		// Token: 0x04006E0A RID: 28170
		[Token(Token = "0x4006E0A")]
		public const string EVENT_TYPE_MTP = "EventTypeMTP";

		// Token: 0x04006E0B RID: 28171
		[Token(Token = "0x4006E0B")]
		public const string EVENT_TYPE_MALL_TAB_CLICK_COUNT = "EventTypeMallTabClickCount";

		// Token: 0x04006E0C RID: 28172
		[Token(Token = "0x4006E0C")]
		public const string EVENT_TYPE_INSTALLMENT_TAB_CLICK_COUNT = "EventTypeInstallmentClickCount";

		// Token: 0x04006E0D RID: 28173
		[Token(Token = "0x4006E0D")]
		public const string EVENT_TYPE_BACK_MALL_COUNT = "EventTypeBackMallCount";

		// Token: 0x04006E0E RID: 28174
		[Token(Token = "0x4006E0E")]
		public const string EVENT_TYPE_INGAME_TIPS = "EventTypeIngameTips";

		// Token: 0x04006E0F RID: 28175
		[Token(Token = "0x4006E0F")]
		public const string EVENT_TYPE_BASIC_SETTING = "EventTypeClientBasicSettingChange";

		// Token: 0x04006E10 RID: 28176
		[Token(Token = "0x4006E10")]
		public const string EVENT_TYPE_MAX_SETTING = "EventTypeClientMaxSettingChange";

		// Token: 0x04006E11 RID: 28177
		[Token(Token = "0x4006E11")]
		public const string EVENT_TYPE_OPERATION_SETTING = "EventTypeClientOperationSettingChange";

		// Token: 0x04006E12 RID: 28178
		[Token(Token = "0x4006E12")]
		public const string EVENT_TYPE_IOS_IDFA = "EventTypeIOSIDFA";

		// Token: 0x04006E13 RID: 28179
		[Token(Token = "0x4006E13")]
		public const string EVENT_TYPE_BACK_BTN_LOWERLEFT_CLICK = "EventTypeBackBTNLowerLeftClick";

		// Token: 0x04006E14 RID: 28180
		[Token(Token = "0x4006E14")]
		public const string EVENT_TYPE_CHAMPIONSHIPCLIKC = "EventTypeChampionshipClick";

		// Token: 0x04006E15 RID: 28181
		[Token(Token = "0x4006E15")]
		public const string EVENT_TYPE_LOGIN_VNLINK = "EventTypeLoginPageEntry";

		// Token: 0x04006E16 RID: 28182
		[Token(Token = "0x4006E16")]
		public const string EVENT_TYPE_GACHA_NOTIFYSTATE = "EventTypeGachaNotifyState";

		// Token: 0x04006E17 RID: 28183
		[Token(Token = "0x4006E17")]
		public const string EVENT_TYPE_ENTER_WAITING_ISLAND = "EventTypeEnterWaitingIsland";

		// Token: 0x04006E18 RID: 28184
		[Token(Token = "0x4006E18")]
		public const string EVENT_TYPE_LEAVE_WAITING_ISLAND = "EventTypeLeaveWaitingIsland";

		// Token: 0x04006E19 RID: 28185
		[Token(Token = "0x4006E19")]
		public const string EVENT_TYPE_CLIENT_CLICK = "EventTypeClientClick";

		// Token: 0x04006E1A RID: 28186
		[Token(Token = "0x4006E1A")]
		public const string EVENT_TYPE_CLIENTSETTING = "EventTypeClientSetting";

		// Token: 0x04006E1B RID: 28187
		[Token(Token = "0x4006E1B")]
		public const string EVENT_TYPE_REJECT_JOIN_GROUP = "EventTypeRejectJoinGroup";

		// Token: 0x04006E1C RID: 28188
		[Token(Token = "0x4006E1C")]
		public const string EVENT_TYPE_REJECT_GROUP_INVITE = "EventTypeRejectGroupInvite";

		// Token: 0x04006E1D RID: 28189
		[Token(Token = "0x4006E1D")]
		public const string EVENT_TYPE_NOTI_REPLACE = "EventTypeNotiWindowReplaced";

		// Token: 0x04006E1E RID: 28190
		[Token(Token = "0x4006E1E")]
		public const string EVENT_TYPE_GROUP_INVITE_WITHIN_CLIENT = "EventTypeGroupInviteWithinClient";

		// Token: 0x04006E1F RID: 28191
		[Token(Token = "0x4006E1F")]
		public const string EVENT_TYPE_RESERVATION_SENT = "EventTypeReservationSent";

		// Token: 0x04006E20 RID: 28192
		[Token(Token = "0x4006E20")]
		public const string EVENT_TYPE_RESERVATION_REPLY = "EventTypeReservationReply";

		// Token: 0x04006E21 RID: 28193
		[Token(Token = "0x4006E21")]
		public const string EVENT_TYPE_RESERVATION_CONFIRM = "EventTypeReservationConfirm";

		// Token: 0x04006E22 RID: 28194
		[Token(Token = "0x4006E22")]
		public const string EVENT_TYPE_MALL_CLICK = "EventTypeShopClick";

		// Token: 0x04006E23 RID: 28195
		[Token(Token = "0x4006E23")]
		public const string EVENT_TYPE_BANNER_CLICK = "EventTypeBannerClick";

		// Token: 0x04006E24 RID: 28196
		[Token(Token = "0x4006E24")]
		public const string EVENT_TYPE_LIMITED_EVENT_SHARE = "EventTypeLimitedEventShare";

		// Token: 0x04006E25 RID: 28197
		[Token(Token = "0x4006E25")]
		public const string EVENT_TYPE_NAVI_PAGE_VIEW_TIME = "EventTypeNaviPageViewTime";

		// Token: 0x04006E26 RID: 28198
		[Token(Token = "0x4006E26")]
		public const string EVENT_TYPE_PROFILEPAGE_VIEW_TIME = "EventTypeProfilePageViewTime";

		// Token: 0x04006E27 RID: 28199
		[Token(Token = "0x4006E27")]
		public const string EVENT_TYPE_BOOYAH_EMOTE_EQUIP = "EventTypeBooyahEmoteEquip";

		// Token: 0x04006E28 RID: 28200
		[Token(Token = "0x4006E28")]
		public const string EVENT_TYPE_BOOYAH_EMOTE_PLAY = "EventTypeBooyahEmotePlay";

		// Token: 0x04006E29 RID: 28201
		[Token(Token = "0x4006E29")]
		public const string EVENT_TYPE_BIGEVENTSPLASH_PUSH = "EventTypeBigEventSplashPush";

		// Token: 0x04006E2A RID: 28202
		[Token(Token = "0x4006E2A")]
		public const string EVENT_TYPE_BROADCAST_TYPE_CNT = "EventTypeBroadCastTypeCnt";

		// Token: 0x04006E2B RID: 28203
		[Token(Token = "0x4006E2B")]
		public const string EVENT_TYPE_FIRST_GUIDE_GAME_SWITH_TO_SOLO = "EventTypeNewbieTransfer";

		// Token: 0x04006E2C RID: 28204
		[Token(Token = "0x4006E2C")]
		public const string EVENT_TYPE_CLOSE_UP_SHARE = "EventTypeCloseUpShare";

		// Token: 0x04006E2D RID: 28205
		[Token(Token = "0x4006E2D")]
		public const string EVENT_TYPE_CLIENT_SETTING_CHANGE = "EventTypeClientSettingChange";

		// Token: 0x04006E2E RID: 28206
		[Token(Token = "0x4006E2E")]
		public const string EVENT_TYPE_FRIEND_RECOMMEND = "EventTypeFriendRecommend";

		// Token: 0x04006E2F RID: 28207
		[Token(Token = "0x4006E2F")]
		public const string EVENT_TYPE_BR_DEADINFO = "EventTypeBRDeadInfo";

		// Token: 0x04006E30 RID: 28208
		[Token(Token = "0x4006E30")]
		public const string EVENT_TYPE_SYSTEM_SCREENSHOT = "EventTypeSystemScreenShot";

		// Token: 0x04006E31 RID: 28209
		[Token(Token = "0x4006E31")]
		public const string EVENT_TYPE_MVPINFO = "EventTypeMVPInfo";

		// Token: 0x04006E32 RID: 28210
		[Token(Token = "0x4006E32")]
		public const string EVENT_TYPE_TRAINING_LOCAL_GAME = "EventTypeTrainingLocalGame";

		// Token: 0x04006E33 RID: 28211
		[Token(Token = "0x4006E33")]
		public const string EVENT_TYPE_WEREWOLVES_GAME = "EventTypeWereWolvesGame";

		// Token: 0x04006E34 RID: 28212
		[Token(Token = "0x4006E34")]
		[FieldOffset(Offset = "0x0")]
		private static EventLogger.EventClick eventClick;

		// Token: 0x04006E35 RID: 28213
		[Token(Token = "0x4006E35")]
		[FieldOffset(Offset = "0x8")]
		private static EventLogger.EventLobbyClickCount eventLobbyClickCount;

		// Token: 0x04006E36 RID: 28214
		[Token(Token = "0x4006E36")]
		[FieldOffset(Offset = "0x10")]
		private static EventLogger.EventManualClickCount eventManualClickCount;

		// Token: 0x04006E37 RID: 28215
		[Token(Token = "0x4006E37")]
		[FieldOffset(Offset = "0x18")]
		private static EventLogger.EventNavigationClickCount eventNavigationClickCount;

		// Token: 0x04006E38 RID: 28216
		[Token(Token = "0x4006E38")]
		[FieldOffset(Offset = "0x20")]
		private static EventLogger.EventGotoOthersPersonalShowTimes eventGotoOthersPersonalShowTimes;

		// Token: 0x04006E39 RID: 28217
		[Token(Token = "0x4006E39")]
		[FieldOffset(Offset = "0x28")]
		private static EventLogger.EventBackMallCount eventBackMallCount;

		// Token: 0x04006E3A RID: 28218
		[Token(Token = "0x4006E3A")]
		[FieldOffset(Offset = "0x30")]
		private static EventLogger.EventInstallmentClickCount eventInstallmentClickCount;

		// Token: 0x04006E3B RID: 28219
		[Token(Token = "0x4006E3B")]
		[FieldOffset(Offset = "0x38")]
		private static EventLogger.EventMallTabClickCount eventMallTabClickCount;

		// Token: 0x04006E3C RID: 28220
		[Token(Token = "0x4006E3C")]
		[FieldOffset(Offset = "0x40")]
		private static List<EventLogger.EventNavigate> eventNavigates;

		// Token: 0x04006E3D RID: 28221
		[Token(Token = "0x4006E3D")]
		[FieldOffset(Offset = "0x48")]
		private static EventLogger.EventBroadCastTypeCnt eventBroadCast;

		// Token: 0x04006E3E RID: 28222
		[Token(Token = "0x4006E3E")]
		[FieldOffset(Offset = "0x50")]
		private static EventLogger.EventTrainingLocalGame eventTrainingLocalGame;

		// Token: 0x04006E3F RID: 28223
		[Token(Token = "0x4006E3F")]
		[FieldOffset(Offset = "0x58")]
		private static EventLogger.EventWereWolvesGame eventWereWolvesGame;

		// Token: 0x04006E40 RID: 28224
		[Token(Token = "0x4006E40")]
		[FieldOffset(Offset = "0x60")]
		public static EventLogger.EventReturnLobbyAfterDeath_RuntimeData EventReturnLobbyAfterDeathRuntimeData;

		// Token: 0x04006E41 RID: 28225
		[Token(Token = "0x4006E41")]
		[FieldOffset(Offset = "0x68")]
		public static EventLogger.EventOpOnBag_RuntimeData EventOpOnBagRuntimeData;

		// Token: 0x04006E42 RID: 28226
		[Token(Token = "0x4006E42")]
		[FieldOffset(Offset = "0x70")]
		public static EventLogger.EventWaitingForMatchmaking_RuntimeData EventWaitingForMatchmakingRuntimeData;

		// Token: 0x04006E43 RID: 28227
		[Token(Token = "0x4006E43")]
		[FieldOffset(Offset = "0x78")]
		public static EventLogger.EventAddFriendActively_RuntimeData EventAddFriendActivelyRuntimeData;

		// Token: 0x04006E44 RID: 28228
		[Token(Token = "0x4006E44")]
		[FieldOffset(Offset = "0x80")]
		public static EventLogger.EventFPS_RuntimeData EventFPSRuntimeData;

		// Token: 0x04006E45 RID: 28229
		[Token(Token = "0x4006E45")]
		[FieldOffset(Offset = "0x88")]
		public static EventLogger.EventGameMemory_RuntimeData EventGameMemoryData;

		// Token: 0x04006E46 RID: 28230
		[Token(Token = "0x4006E46")]
		[FieldOffset(Offset = "0x90")]
		public static EventLogger.EventGameLag_RuntimeData EventGameLagData;

		// Token: 0x04006E47 RID: 28231
		[Token(Token = "0x4006E47")]
		[FieldOffset(Offset = "0x98")]
		public static EventLogger.EventObserverLog EventObserverLogData;

		// Token: 0x04006E48 RID: 28232
		[Token(Token = "0x4006E48")]
		[FieldOffset(Offset = "0xA0")]
		public static bool HasStartObserver;

		// Token: 0x04006E49 RID: 28233
		[Token(Token = "0x4006E49")]
		[FieldOffset(Offset = "0xA8")]
		public static EventLogger.EventElitePassEntry EventElitePassEntryLog;

		// Token: 0x04006E4A RID: 28234
		[Token(Token = "0x4006E4A")]
		[FieldOffset(Offset = "0xB0")]
		public static EventLogger.EventClientPushSetting EventClientPushSettingData;

		// Token: 0x04006E4B RID: 28235
		[Token(Token = "0x4006E4B")]
		[FieldOffset(Offset = "0xB8")]
		public static EventLogger.EventTypeClientSettingChange EventClientSettingChange;

		// Token: 0x04006E4C RID: 28236
		[Token(Token = "0x4006E4C")]
		[FieldOffset(Offset = "0xC0")]
		public static float LoadingStartTime;

		// Token: 0x04006E4D RID: 28237
		[Token(Token = "0x4006E4D")]
		[FieldOffset(Offset = "0xC8")]
		public static string Region;

		// Token: 0x04006E4E RID: 28238
		[Token(Token = "0x4006E4E")]
		[FieldOffset(Offset = "0xD0")]
		public static ulong UserID;

		// Token: 0x04006E4F RID: 28239
		[Token(Token = "0x4006E4F")]
		[FieldOffset(Offset = "0xD8")]
		public static EventLogger.EventEnterGame EnterGame;

		// Token: 0x04006E50 RID: 28240
		[Token(Token = "0x4006E50")]
		[FieldOffset(Offset = "0xE0")]
		public static EventLogger.EventLeaveGame LeaveGame;

		// Token: 0x04006E51 RID: 28241
		[Token(Token = "0x4006E51")]
		[FieldOffset(Offset = "0xE8")]
		public static EventLogger.EventEnterWaitingIsland EnterWaitingIsland;

		// Token: 0x04006E52 RID: 28242
		[Token(Token = "0x4006E52")]
		[FieldOffset(Offset = "0xF0")]
		public static EventLogger.EventLeaveWaitingIsland LeaveWaitingIsland;

		// Token: 0x04006E53 RID: 28243
		[Token(Token = "0x4006E53")]
		[FieldOffset(Offset = "0xF8")]
		public static EventLogger.EventIngameTips IngameTips;

		// Token: 0x04006E54 RID: 28244
		[Token(Token = "0x4006E54")]
		[FieldOffset(Offset = "0x100")]
		private static uint ingameTipsOrginal;

		// Token: 0x04006E55 RID: 28245
		[Token(Token = "0x4006E55")]
		[FieldOffset(Offset = "0x108")]
		public static EventLogger.IngameEnterGameData enterGameData;

		// Token: 0x04006E56 RID: 28246
		[Token(Token = "0x4006E56")]
		[FieldOffset(Offset = "0x110")]
		public static EventLogger.EventBRDeadInfo EventBRDead;

		// Token: 0x04006E57 RID: 28247
		[Token(Token = "0x4006E57")]
		[FieldOffset(Offset = "0x118")]
		private static int fpsIndex;

		// Token: 0x020011C2 RID: 4546
		[Token(Token = "0x20011C2")]
		public class EventLoggerBase
		{
			// Token: 0x06004728 RID: 18216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004728")]
			[Address(RVA = "0x1B94CC0", Offset = "0x1B94CC0", VA = "0x7BBC394CC0")]
			public EventLoggerBase()
			{
			}

			// Token: 0x04006E58 RID: 28248
			[Token(Token = "0x4006E58")]
			[FieldOffset(Offset = "0x10")]
			public string region;

			// Token: 0x04006E59 RID: 28249
			[Token(Token = "0x4006E59")]
			[FieldOffset(Offset = "0x18")]
			public ulong account_id;
		}

		// Token: 0x020011C3 RID: 4547
		[Token(Token = "0x20011C3")]
		public class EventTypeReservationSent : EventLogger.EventLoggerBase
		{
			// Token: 0x06004729 RID: 18217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004729")]
			[Address(RVA = "0x1B94E34", Offset = "0x1B94E34", VA = "0x7BBC394E34")]
			public EventTypeReservationSent()
			{
			}

			// Token: 0x04006E5A RID: 28250
			[Token(Token = "0x4006E5A")]
			[FieldOffset(Offset = "0x20")]
			public ulong received_account_id;
		}

		// Token: 0x020011C4 RID: 4548
		[Token(Token = "0x20011C4")]
		public class EventTypeReservationReply : EventLogger.EventLoggerBase
		{
			// Token: 0x0600472A RID: 18218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600472A")]
			[Address(RVA = "0x1B94E2C", Offset = "0x1B94E2C", VA = "0x7BBC394E2C")]
			public EventTypeReservationReply()
			{
			}

			// Token: 0x04006E5B RID: 28251
			[Token(Token = "0x4006E5B")]
			[FieldOffset(Offset = "0x20")]
			public ulong send_account_id;

			// Token: 0x04006E5C RID: 28252
			[Token(Token = "0x4006E5C")]
			[FieldOffset(Offset = "0x28")]
			public bool action;

			// Token: 0x04006E5D RID: 28253
			[Token(Token = "0x4006E5D")]
			[FieldOffset(Offset = "0x29")]
			public bool if_shield;
		}

		// Token: 0x020011C5 RID: 4549
		[Token(Token = "0x20011C5")]
		public class EventTypeReservationConfirm : EventLogger.EventLoggerBase
		{
			// Token: 0x0600472B RID: 18219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600472B")]
			[Address(RVA = "0x1B94E24", Offset = "0x1B94E24", VA = "0x7BBC394E24")]
			public EventTypeReservationConfirm()
			{
			}

			// Token: 0x04006E5E RID: 28254
			[Token(Token = "0x4006E5E")]
			[FieldOffset(Offset = "0x20")]
			public ulong received_account_id;

			// Token: 0x04006E5F RID: 28255
			[Token(Token = "0x4006E5F")]
			[FieldOffset(Offset = "0x28")]
			public bool if_confirm;
		}

		// Token: 0x020011C6 RID: 4550
		[Token(Token = "0x20011C6")]
		public class EventTypeLimitedEventShare : EventLogger.EventLoggerBase
		{
			// Token: 0x0600472C RID: 18220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600472C")]
			[Address(RVA = "0x1B94E1C", Offset = "0x1B94E1C", VA = "0x7BBC394E1C")]
			public EventTypeLimitedEventShare()
			{
			}

			// Token: 0x04006E60 RID: 28256
			[Token(Token = "0x4006E60")]
			[FieldOffset(Offset = "0x20")]
			public bool share_out;

			// Token: 0x04006E61 RID: 28257
			[Token(Token = "0x4006E61")]
			[FieldOffset(Offset = "0x24")]
			public uint platform;

			// Token: 0x04006E62 RID: 28258
			[Token(Token = "0x4006E62")]
			[FieldOffset(Offset = "0x28")]
			public uint event_id;
		}

		// Token: 0x020011C7 RID: 4551
		[Token(Token = "0x20011C7")]
		public class EventTypeCloseUpShare : EventLogger.EventLoggerBase
		{
			// Token: 0x0600472D RID: 18221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600472D")]
			[Address(RVA = "0x1B94E0C", Offset = "0x1B94E0C", VA = "0x7BBC394E0C")]
			public EventTypeCloseUpShare()
			{
			}

			// Token: 0x04006E63 RID: 28259
			[Token(Token = "0x4006E63")]
			[FieldOffset(Offset = "0x20")]
			public bool share_out;

			// Token: 0x04006E64 RID: 28260
			[Token(Token = "0x4006E64")]
			[FieldOffset(Offset = "0x24")]
			public uint platform;

			// Token: 0x04006E65 RID: 28261
			[Token(Token = "0x4006E65")]
			[FieldOffset(Offset = "0x28")]
			public uint item_id;
		}

		// Token: 0x020011C8 RID: 4552
		[Token(Token = "0x20011C8")]
		public class EventBannerClickLog : EventLogger.EventLoggerBase
		{
			// Token: 0x0600472E RID: 18222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600472E")]
			[Address(RVA = "0x1B94CD0", Offset = "0x1B94CD0", VA = "0x7BBC394CD0")]
			public EventBannerClickLog()
			{
			}

			// Token: 0x04006E66 RID: 28262
			[Token(Token = "0x4006E66")]
			[FieldOffset(Offset = "0x20")]
			public uint banner_type;

			// Token: 0x04006E67 RID: 28263
			[Token(Token = "0x4006E67")]
			[FieldOffset(Offset = "0x24")]
			public uint banner_id;
		}

		// Token: 0x020011C9 RID: 4553
		[Token(Token = "0x20011C9")]
		public class EventObserverLog : EventLogger.EventLoggerBase
		{
			// Token: 0x0600472F RID: 18223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600472F")]
			[Address(RVA = "0x1B94AC0", Offset = "0x1B94AC0", VA = "0x7BBC394AC0")]
			public EventObserverLog()
			{
			}

			// Token: 0x04006E68 RID: 28264
			[Token(Token = "0x4006E68")]
			[FieldOffset(Offset = "0x20")]
			public float observer_time;

			// Token: 0x04006E69 RID: 28265
			[Token(Token = "0x4006E69")]
			[FieldOffset(Offset = "0x24")]
			public uint switch_count;

			// Token: 0x04006E6A RID: 28266
			[Token(Token = "0x4006E6A")]
			[FieldOffset(Offset = "0x28")]
			public bool click_close;

			// Token: 0x04006E6B RID: 28267
			[Token(Token = "0x4006E6B")]
			[FieldOffset(Offset = "0x2C")]
			public int group_mode;
		}

		// Token: 0x020011CA RID: 4554
		[Token(Token = "0x20011CA")]
		public class EventPageDetentionTime : EventLogger.EventLoggerBase
		{
			// Token: 0x06004730 RID: 18224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004730")]
			[Address(RVA = "0x1B94DA4", Offset = "0x1B94DA4", VA = "0x7BBC394DA4")]
			public EventPageDetentionTime()
			{
			}

			// Token: 0x04006E6C RID: 28268
			[Token(Token = "0x4006E6C")]
			[FieldOffset(Offset = "0x20")]
			public string page_name;

			// Token: 0x04006E6D RID: 28269
			[Token(Token = "0x4006E6D")]
			[FieldOffset(Offset = "0x28")]
			public int view_time;
		}

		// Token: 0x020011CB RID: 4555
		[Token(Token = "0x20011CB")]
		public class EventProfilePageViewTime : EventLogger.EventPageDetentionTime
		{
			// Token: 0x06004731 RID: 18225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004731")]
			[Address(RVA = "0x1B94DB4", Offset = "0x1B94DB4", VA = "0x7BBC394DB4")]
			public EventProfilePageViewTime()
			{
			}

			// Token: 0x04006E6E RID: 28270
			[Token(Token = "0x4006E6E")]
			[FieldOffset(Offset = "0x30")]
			public ulong viewed_id;
		}

		// Token: 0x020011CC RID: 4556
		[Token(Token = "0x20011CC")]
		public class EventCilckHistoryStats : EventLogger.EventLoggerBase
		{
			// Token: 0x06004732 RID: 18226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004732")]
			[Address(RVA = "0x1B94CF0", Offset = "0x1B94CF0", VA = "0x7BBC394CF0")]
			public EventCilckHistoryStats()
			{
			}
		}

		// Token: 0x020011CD RID: 4557
		[Token(Token = "0x20011CD")]
		public class EventIOSIDFA : EventLogger.EventLoggerBase
		{
			// Token: 0x06004733 RID: 18227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004733")]
			[Address(RVA = "0x1B90B74", Offset = "0x1B90B74", VA = "0x7BBC390B74")]
			public EventIOSIDFA()
			{
			}

			// Token: 0x04006E6F RID: 28271
			[Token(Token = "0x4006E6F")]
			[FieldOffset(Offset = "0x20")]
			public string open_id;

			// Token: 0x04006E70 RID: 28272
			[Token(Token = "0x4006E70")]
			[FieldOffset(Offset = "0x28")]
			public string idfa;
		}

		// Token: 0x020011CE RID: 4558
		[Token(Token = "0x20011CE")]
		public class EventAddFriendInHistoryStats : EventLogger.EventLoggerBase
		{
			// Token: 0x06004734 RID: 18228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004734")]
			[Address(RVA = "0x1B94CC8", Offset = "0x1B94CC8", VA = "0x7BBC394CC8")]
			public EventAddFriendInHistoryStats()
			{
			}
		}

		// Token: 0x020011CF RID: 4559
		[Token(Token = "0x20011CF")]
		public class EventClickRewardedVideo : EventLogger.EventLoggerBase
		{
			// Token: 0x06004735 RID: 18229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004735")]
			[Address(RVA = "0x1B94CF8", Offset = "0x1B94CF8", VA = "0x7BBC394CF8")]
			public EventClickRewardedVideo()
			{
			}
		}

		// Token: 0x020011D0 RID: 4560
		[Token(Token = "0x20011D0")]
		public class EventGroupInvite : EventLogger.EventLoggerBase
		{
			// Token: 0x06004736 RID: 18230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004736")]
			[Address(RVA = "0x1B94D10", Offset = "0x1B94D10", VA = "0x7BBC394D10")]
			public EventGroupInvite()
			{
			}

			// Token: 0x04006E71 RID: 28273
			[Token(Token = "0x4006E71")]
			[FieldOffset(Offset = "0x20")]
			public ulong inviter;

			// Token: 0x04006E72 RID: 28274
			[Token(Token = "0x4006E72")]
			[FieldOffset(Offset = "0x28")]
			public ulong invitee;
		}

		// Token: 0x020011D1 RID: 4561
		[Token(Token = "0x20011D1")]
		public class EventGroupInviteOperation : EventLogger.EventLoggerBase
		{
			// Token: 0x06004737 RID: 18231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004737")]
			[Address(RVA = "0x1B89FC8", Offset = "0x1B89FC8", VA = "0x7BBC389FC8")]
			public EventGroupInviteOperation()
			{
			}

			// Token: 0x04006E73 RID: 28275
			[Token(Token = "0x4006E73")]
			[FieldOffset(Offset = "0x20")]
			public uint oper_type;
		}

		// Token: 0x020011D2 RID: 4562
		[Token(Token = "0x20011D2")]
		public class EventTypeGroupInviteWithinClient : EventLogger.EventGroupInvite
		{
			// Token: 0x06004738 RID: 18232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004738")]
			[Address(RVA = "0x1B94E14", Offset = "0x1B94E14", VA = "0x7BBC394E14")]
			public EventTypeGroupInviteWithinClient()
			{
			}

			// Token: 0x04006E74 RID: 28276
			[Token(Token = "0x4006E74")]
			[FieldOffset(Offset = "0x30")]
			public uint channel;

			// Token: 0x04006E75 RID: 28277
			[Token(Token = "0x4006E75")]
			[FieldOffset(Offset = "0x34")]
			public uint invitee_type;

			// Token: 0x04006E76 RID: 28278
			[Token(Token = "0x4006E76")]
			[FieldOffset(Offset = "0x38")]
			public ulong group_id;

			// Token: 0x04006E77 RID: 28279
			[Token(Token = "0x4006E77")]
			[FieldOffset(Offset = "0x40")]
			public uint match_mode;

			// Token: 0x04006E78 RID: 28280
			[Token(Token = "0x4006E78")]
			[FieldOffset(Offset = "0x44")]
			public uint game_mode;

			// Token: 0x04006E79 RID: 28281
			[Token(Token = "0x4006E79")]
			[FieldOffset(Offset = "0x48")]
			public uint group_mode;

			// Token: 0x04006E7A RID: 28282
			[Token(Token = "0x4006E7A")]
			[FieldOffset(Offset = "0x50")]
			public uint[] map_ids;

			// Token: 0x04006E7B RID: 28283
			[Token(Token = "0x4006E7B")]
			[FieldOffset(Offset = "0x58")]
			public uint group_type;

			// Token: 0x04006E7C RID: 28284
			[Token(Token = "0x4006E7C")]
			[FieldOffset(Offset = "0x5C")]
			public uint group_size;

			// Token: 0x04006E7D RID: 28285
			[Token(Token = "0x4006E7D")]
			[FieldOffset(Offset = "0x60")]
			public uint result;
		}

		// Token: 0x020011D3 RID: 4563
		[Token(Token = "0x20011D3")]
		public class EventSplashBannerGoto : EventLogger.EventLoggerBase
		{
			// Token: 0x06004739 RID: 18233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004739")]
			[Address(RVA = "0x1B89CD8", Offset = "0x1B89CD8", VA = "0x7BBC389CD8")]
			public EventSplashBannerGoto()
			{
			}

			// Token: 0x04006E7E RID: 28286
			[Token(Token = "0x4006E7E")]
			[FieldOffset(Offset = "0x20")]
			public uint id;

			// Token: 0x04006E7F RID: 28287
			[Token(Token = "0x4006E7F")]
			[FieldOffset(Offset = "0x24")]
			public uint goto_pos;

			// Token: 0x04006E80 RID: 28288
			[Token(Token = "0x4006E80")]
			[FieldOffset(Offset = "0x28")]
			public string goto_url;
		}

		// Token: 0x020011D4 RID: 4564
		[Token(Token = "0x20011D4")]
		public class EventSplashBannerPush : EventLogger.EventLoggerBase
		{
			// Token: 0x0600473A RID: 18234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600473A")]
			[Address(RVA = "0x1B89F24", Offset = "0x1B89F24", VA = "0x7BBC389F24")]
			public EventSplashBannerPush()
			{
			}

			// Token: 0x04006E81 RID: 28289
			[Token(Token = "0x4006E81")]
			[FieldOffset(Offset = "0x20")]
			public bool state;

			// Token: 0x04006E82 RID: 28290
			[Token(Token = "0x4006E82")]
			[FieldOffset(Offset = "0x24")]
			public uint entry_id;

			// Token: 0x04006E83 RID: 28291
			[Token(Token = "0x4006E83")]
			[FieldOffset(Offset = "0x28")]
			public uint event_id;
		}

		// Token: 0x020011D5 RID: 4565
		[Token(Token = "0x20011D5")]
		public class EventWaitingForMatchmaking_RuntimeData
		{
			// Token: 0x0600473B RID: 18235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600473B")]
			[Address(RVA = "0x1B94A90", Offset = "0x1B94A90", VA = "0x7BBC394A90")]
			public EventWaitingForMatchmaking_RuntimeData()
			{
			}

			// Token: 0x04006E84 RID: 28292
			[Token(Token = "0x4006E84")]
			[FieldOffset(Offset = "0x10")]
			public float TimeStart;

			// Token: 0x04006E85 RID: 28293
			[Token(Token = "0x4006E85")]
			[FieldOffset(Offset = "0x14")]
			public uint GroupMode;
		}

		// Token: 0x020011D6 RID: 4566
		[Token(Token = "0x20011D6")]
		public class EventReloadWeapon : EventLogger.EventLoggerBase
		{
			// Token: 0x0600473C RID: 18236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600473C")]
			[Address(RVA = "0x1B94DCC", Offset = "0x1B94DCC", VA = "0x7BBC394DCC")]
			public EventReloadWeapon()
			{
			}

			// Token: 0x04006E86 RID: 28294
			[Token(Token = "0x4006E86")]
			[FieldOffset(Offset = "0x20")]
			public uint weapon_data_id;

			// Token: 0x04006E87 RID: 28295
			[Token(Token = "0x4006E87")]
			[FieldOffset(Offset = "0x24")]
			public uint ammo_in_clip;

			// Token: 0x04006E88 RID: 28296
			[Token(Token = "0x4006E88")]
			[FieldOffset(Offset = "0x28")]
			public uint ammo_capacity;
		}

		// Token: 0x020011D7 RID: 4567
		[Token(Token = "0x20011D7")]
		public class EventReturnLobbyAfterDeath : EventLogger.EventLoggerBase
		{
			// Token: 0x0600473D RID: 18237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600473D")]
			[Address(RVA = "0x1B94DD4", Offset = "0x1B94DD4", VA = "0x7BBC394DD4")]
			public EventReturnLobbyAfterDeath()
			{
			}

			// Token: 0x04006E89 RID: 28297
			[Token(Token = "0x4006E89")]
			[FieldOffset(Offset = "0x20")]
			public uint time_to_wait;
		}

		// Token: 0x020011D8 RID: 4568
		[Token(Token = "0x20011D8")]
		public class EventReturnLobbyAfterDeath_RuntimeData
		{
			// Token: 0x0600473E RID: 18238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600473E")]
			[Address(RVA = "0x1B94A80", Offset = "0x1B94A80", VA = "0x7BBC394A80")]
			public EventReturnLobbyAfterDeath_RuntimeData()
			{
			}

			// Token: 0x04006E8A RID: 28298
			[Token(Token = "0x4006E8A")]
			[FieldOffset(Offset = "0x10")]
			public float TimeDeath;
		}

		// Token: 0x020011D9 RID: 4569
		[Token(Token = "0x20011D9")]
		public class EventOpOnBag : EventLogger.EventLoggerBase
		{
			// Token: 0x0600473F RID: 18239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600473F")]
			[Address(RVA = "0x1B94D9C", Offset = "0x1B94D9C", VA = "0x7BBC394D9C")]
			public EventOpOnBag()
			{
			}

			// Token: 0x04006E8B RID: 28299
			[Token(Token = "0x4006E8B")]
			[FieldOffset(Offset = "0x20")]
			public uint pickup_data_id;
		}

		// Token: 0x020011DA RID: 4570
		[Token(Token = "0x20011DA")]
		public class EventOpOnBag_RuntimeData
		{
			// Token: 0x06004740 RID: 18240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004740")]
			[Address(RVA = "0x1B94A88", Offset = "0x1B94A88", VA = "0x7BBC394A88")]
			public EventOpOnBag_RuntimeData()
			{
			}

			// Token: 0x04006E8C RID: 28300
			[Token(Token = "0x4006E8C")]
			[FieldOffset(Offset = "0x10")]
			public float TimePickup;

			// Token: 0x04006E8D RID: 28301
			[Token(Token = "0x4006E8D")]
			[FieldOffset(Offset = "0x14")]
			public uint PickupItemDataID;
		}

		// Token: 0x020011DB RID: 4571
		[Token(Token = "0x20011DB")]
		public class EventAddFriendActively : EventLogger.EventLoggerBase
		{
			// Token: 0x06004741 RID: 18241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004741")]
			[Address(RVA = "0x1B8A3C8", Offset = "0x1B8A3C8", VA = "0x7BBC38A3C8")]
			public EventAddFriendActively()
			{
			}

			// Token: 0x04006E8E RID: 28302
			[Token(Token = "0x4006E8E")]
			[FieldOffset(Offset = "0x20")]
			public ulong friend_account_id;
		}

		// Token: 0x020011DC RID: 4572
		[Token(Token = "0x20011DC")]
		public class EventAddFriendActively_RuntimeData
		{
			// Token: 0x06004742 RID: 18242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004742")]
			[Address(RVA = "0x1B94A98", Offset = "0x1B94A98", VA = "0x7BBC394A98")]
			public EventAddFriendActively_RuntimeData()
			{
			}

			// Token: 0x04006E8F RID: 28303
			[Token(Token = "0x4006E8F")]
			[FieldOffset(Offset = "0x10")]
			public bool IsSearch;
		}

		// Token: 0x020011DD RID: 4573
		[Token(Token = "0x20011DD")]
		public class EventReport : EventLogger.EventLoggerBase
		{
			// Token: 0x06004743 RID: 18243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004743")]
			[Address(RVA = "0x1B8E188", Offset = "0x1B8E188", VA = "0x7BBC38E188")]
			public EventReport()
			{
			}

			// Token: 0x04006E90 RID: 28304
			[Token(Token = "0x4006E90")]
			[FieldOffset(Offset = "0x20")]
			public ulong reportee;

			// Token: 0x04006E91 RID: 28305
			[Token(Token = "0x4006E91")]
			[FieldOffset(Offset = "0x28")]
			public uint reason;

			// Token: 0x04006E92 RID: 28306
			[Token(Token = "0x4006E92")]
			[FieldOffset(Offset = "0x30")]
			public ulong match_id;

			// Token: 0x04006E93 RID: 28307
			[Token(Token = "0x4006E93")]
			[FieldOffset(Offset = "0x38")]
			public uint map_id;

			// Token: 0x04006E94 RID: 28308
			[Token(Token = "0x4006E94")]
			[FieldOffset(Offset = "0x3C")]
			public uint game_mode;

			// Token: 0x04006E95 RID: 28309
			[Token(Token = "0x4006E95")]
			[FieldOffset(Offset = "0x40")]
			public uint group_mode;

			// Token: 0x04006E96 RID: 28310
			[Token(Token = "0x4006E96")]
			[FieldOffset(Offset = "0x44")]
			public uint match_mode;

			// Token: 0x04006E97 RID: 28311
			[Token(Token = "0x4006E97")]
			[FieldOffset(Offset = "0x48")]
			public ulong teammate_1;

			// Token: 0x04006E98 RID: 28312
			[Token(Token = "0x4006E98")]
			[FieldOffset(Offset = "0x50")]
			public ulong teammate_2;

			// Token: 0x04006E99 RID: 28313
			[Token(Token = "0x4006E99")]
			[FieldOffset(Offset = "0x58")]
			public ulong teammate_3;

			// Token: 0x04006E9A RID: 28314
			[Token(Token = "0x4006E9A")]
			[FieldOffset(Offset = "0x60")]
			public bool is_special;
		}

		// Token: 0x020011DE RID: 4574
		[Token(Token = "0x20011DE")]
		public class EventWeaponSkinInfo : EventLogger.EventLoggerBase
		{
			// Token: 0x06004744 RID: 18244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004744")]
			[Address(RVA = "0x1B94E54", Offset = "0x1B94E54", VA = "0x7BBC394E54")]
			public EventWeaponSkinInfo()
			{
			}

			// Token: 0x04006E9B RID: 28315
			[Token(Token = "0x4006E9B")]
			[FieldOffset(Offset = "0x20")]
			public ulong match_id;

			// Token: 0x04006E9C RID: 28316
			[Token(Token = "0x4006E9C")]
			[FieldOffset(Offset = "0x28")]
			public string weapon_skins;
		}

		// Token: 0x020011DF RID: 4575
		[Token(Token = "0x20011DF")]
		public class EventWeaponEquip : EventLogger.EventLoggerBase
		{
			// Token: 0x06004745 RID: 18245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004745")]
			[Address(RVA = "0x1B94E4C", Offset = "0x1B94E4C", VA = "0x7BBC394E4C")]
			public EventWeaponEquip()
			{
			}

			// Token: 0x04006E9D RID: 28317
			[Token(Token = "0x4006E9D")]
			[FieldOffset(Offset = "0x20")]
			public ulong match_id;

			// Token: 0x04006E9E RID: 28318
			[Token(Token = "0x4006E9E")]
			[FieldOffset(Offset = "0x28")]
			public uint weapon_id;

			// Token: 0x04006E9F RID: 28319
			[Token(Token = "0x4006E9F")]
			[FieldOffset(Offset = "0x2C")]
			public uint collection_id;
		}

		// Token: 0x020011E0 RID: 4576
		[Token(Token = "0x20011E0")]
		public class EventSettingChangeLog : EventLogger.EventLoggerBase
		{
			// Token: 0x06004746 RID: 18246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004746")]
			[Address(RVA = "0x1B94DE4", Offset = "0x1B94DE4", VA = "0x7BBC394DE4")]
			public EventSettingChangeLog()
			{
			}

			// Token: 0x04006EA0 RID: 28320
			[Token(Token = "0x4006EA0")]
			[FieldOffset(Offset = "0x20")]
			public List<string> changed_Settings;

			// Token: 0x04006EA1 RID: 28321
			[Token(Token = "0x4006EA1")]
			[FieldOffset(Offset = "0x28")]
			public bool is_ingame;
		}

		// Token: 0x020011E1 RID: 4577
		[Token(Token = "0x20011E1")]
		public class EventFPS_RuntimeData
		{
			// Token: 0x06004747 RID: 18247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004747")]
			[Address(RVA = "0x1B8AA3C", Offset = "0x1B8AA3C", VA = "0x7BBC38AA3C")]
			public void StartRecording(EventLogger.EventFPS_RuntimeData.FPSTrackingStep step, float gameTime, float duration)
			{
			}

			// Token: 0x06004748 RID: 18248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004748")]
			[Address(RVA = "0x1B8ADE4", Offset = "0x1B8ADE4", VA = "0x7BBC38ADE4")]
			public void Clear()
			{
			}

			// Token: 0x06004749 RID: 18249 RVA: 0x00015528 File Offset: 0x00013728
			[Token(Token = "0x6004749")]
			[Address(RVA = "0x1B8ADC4", Offset = "0x1B8ADC4", VA = "0x7BBC38ADC4")]
			public bool IsExpired(float gameTime)
			{
				return default(bool);
			}

			// Token: 0x0600474A RID: 18250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600474A")]
			[Address(RVA = "0x1B94AA0", Offset = "0x1B94AA0", VA = "0x7BBC394AA0")]
			public EventFPS_RuntimeData()
			{
			}

			// Token: 0x04006EA2 RID: 28322
			[Token(Token = "0x4006EA2")]
			[FieldOffset(Offset = "0x10")]
			public EventLogger.EventFPS_RuntimeData.FPSTrackingStep FPSStep;

			// Token: 0x04006EA3 RID: 28323
			[Token(Token = "0x4006EA3")]
			[FieldOffset(Offset = "0x14")]
			public float EndTime;

			// Token: 0x04006EA4 RID: 28324
			[Token(Token = "0x4006EA4")]
			[FieldOffset(Offset = "0x18")]
			public float TotalFPSValueCount;

			// Token: 0x04006EA5 RID: 28325
			[Token(Token = "0x4006EA5")]
			[FieldOffset(Offset = "0x1C")]
			public float TotalFPSValuePowerCount;

			// Token: 0x04006EA6 RID: 28326
			[Token(Token = "0x4006EA6")]
			[FieldOffset(Offset = "0x20")]
			public uint TotalFPSCount;

			// Token: 0x04006EA7 RID: 28327
			[Token(Token = "0x4006EA7")]
			[FieldOffset(Offset = "0x24")]
			public uint TotalFPSB10Count;

			// Token: 0x04006EA8 RID: 28328
			[Token(Token = "0x4006EA8")]
			[FieldOffset(Offset = "0x28")]
			public uint TotalFPSB20Count;

			// Token: 0x04006EA9 RID: 28329
			[Token(Token = "0x4006EA9")]
			[FieldOffset(Offset = "0x2C")]
			public bool IsRecording;

			// Token: 0x04006EAA RID: 28330
			[Token(Token = "0x4006EAA")]
			[FieldOffset(Offset = "0x30")]
			public int JitterCount;

			// Token: 0x020011E2 RID: 4578
			[Token(Token = "0x20011E2")]
			public enum FPSTrackingStep
			{
				// Token: 0x04006EAC RID: 28332
				[Token(Token = "0x4006EAC")]
				OnBoard,
				// Token: 0x04006EAD RID: 28333
				[Token(Token = "0x4006EAD")]
				InGame,
				// Token: 0x04006EAE RID: 28334
				[Token(Token = "0x4006EAE")]
				NB
			}
		}

		// Token: 0x020011E3 RID: 4579
		[Token(Token = "0x20011E3")]
		public class EventGameLag_RuntimeData
		{
			// Token: 0x0600474B RID: 18251 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600474B")]
			[Address(RVA = "0x1B8B974", Offset = "0x1B8B974", VA = "0x7BBC38B974")]
			public void Clear()
			{
			}

			// Token: 0x0600474C RID: 18252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600474C")]
			[Address(RVA = "0x1B94AB8", Offset = "0x1B94AB8", VA = "0x7BBC394AB8")]
			public EventGameLag_RuntimeData()
			{
			}

			// Token: 0x04006EAF RID: 28335
			[Token(Token = "0x4006EAF")]
			[FieldOffset(Offset = "0x10")]
			public float TotalLagTime;

			// Token: 0x04006EB0 RID: 28336
			[Token(Token = "0x4006EB0")]
			[FieldOffset(Offset = "0x14")]
			public int TotalLagFrameCount;

			// Token: 0x04006EB1 RID: 28337
			[Token(Token = "0x4006EB1")]
			[FieldOffset(Offset = "0x18")]
			public float MatchTime;

			// Token: 0x04006EB2 RID: 28338
			[Token(Token = "0x4006EB2")]
			[FieldOffset(Offset = "0x1C")]
			public int FrameCount;

			// Token: 0x04006EB3 RID: 28339
			[Token(Token = "0x4006EB3")]
			[FieldOffset(Offset = "0x20")]
			public bool isStart;
		}

		// Token: 0x020011E4 RID: 4580
		[Token(Token = "0x20011E4")]
		public class EventGameMemory_RuntimeData
		{
			// Token: 0x0600474D RID: 18253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600474D")]
			[Address(RVA = "0x1B8B238", Offset = "0x1B8B238", VA = "0x7BBC38B238")]
			public void Clear()
			{
			}

			// Token: 0x0600474E RID: 18254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600474E")]
			[Address(RVA = "0x1B94AB0", Offset = "0x1B94AB0", VA = "0x7BBC394AB0")]
			public EventGameMemory_RuntimeData()
			{
			}

			// Token: 0x04006EB4 RID: 28340
			[Token(Token = "0x4006EB4")]
			[FieldOffset(Offset = "0x10")]
			public int Enter_PVP_Memory;

			// Token: 0x04006EB5 RID: 28341
			[Token(Token = "0x4006EB5")]
			[FieldOffset(Offset = "0x14")]
			public int Leave_PVP_Memory;

			// Token: 0x04006EB6 RID: 28342
			[Token(Token = "0x4006EB6")]
			[FieldOffset(Offset = "0x18")]
			public int Enter_PVP_AvailMemory;

			// Token: 0x04006EB7 RID: 28343
			[Token(Token = "0x4006EB7")]
			[FieldOffset(Offset = "0x1C")]
			public int Leave_PVP_AvailMemory;
		}

		// Token: 0x020011E5 RID: 4581
		[Token(Token = "0x20011E5")]
		public class EventGameLag : EventLogger.EventLoggerBase
		{
			// Token: 0x0600474F RID: 18255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600474F")]
			[Address(RVA = "0x1B8B96C", Offset = "0x1B8B96C", VA = "0x7BBC38B96C")]
			public EventGameLag()
			{
			}

			// Token: 0x04006EB8 RID: 28344
			[Token(Token = "0x4006EB8")]
			[FieldOffset(Offset = "0x20")]
			public int frame_count;

			// Token: 0x04006EB9 RID: 28345
			[Token(Token = "0x4006EB9")]
			[FieldOffset(Offset = "0x24")]
			public float match_time;

			// Token: 0x04006EBA RID: 28346
			[Token(Token = "0x4006EBA")]
			[FieldOffset(Offset = "0x28")]
			public float lag_time;

			// Token: 0x04006EBB RID: 28347
			[Token(Token = "0x4006EBB")]
			[FieldOffset(Offset = "0x2C")]
			public int lag_count;

			// Token: 0x04006EBC RID: 28348
			[Token(Token = "0x4006EBC")]
			[FieldOffset(Offset = "0x30")]
			public int quality;

			// Token: 0x04006EBD RID: 28349
			[Token(Token = "0x4006EBD")]
			[FieldOffset(Offset = "0x34")]
			public uint map_id;

			// Token: 0x04006EBE RID: 28350
			[Token(Token = "0x4006EBE")]
			[FieldOffset(Offset = "0x38")]
			public uint game_mode;

			// Token: 0x04006EBF RID: 28351
			[Token(Token = "0x4006EBF")]
			[FieldOffset(Offset = "0x3C")]
			public uint group_mode;

			// Token: 0x04006EC0 RID: 28352
			[Token(Token = "0x4006EC0")]
			[FieldOffset(Offset = "0x40")]
			public uint match_mode;
		}

		// Token: 0x020011E6 RID: 4582
		[Token(Token = "0x20011E6")]
		public class EventSplashInfo : EventLogger.EventLoggerBase
		{
			// Token: 0x06004750 RID: 18256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004750")]
			[Address(RVA = "0x1B94E04", Offset = "0x1B94E04", VA = "0x7BBC394E04")]
			public EventSplashInfo()
			{
			}

			// Token: 0x04006EC1 RID: 28353
			[Token(Token = "0x4006EC1")]
			[FieldOffset(Offset = "0x20")]
			public float currenct_time;

			// Token: 0x04006EC2 RID: 28354
			[Token(Token = "0x4006EC2")]
			[FieldOffset(Offset = "0x24")]
			public uint splash_id;
		}

		// Token: 0x020011E7 RID: 4583
		[Token(Token = "0x20011E7")]
		public class EventBillboardInfo : EventLogger.EventLoggerBase
		{
			// Token: 0x06004751 RID: 18257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004751")]
			[Address(RVA = "0x1B8C12C", Offset = "0x1B8C12C", VA = "0x7BBC38C12C")]
			public EventBillboardInfo()
			{
			}

			// Token: 0x04006EC3 RID: 28355
			[Token(Token = "0x4006EC3")]
			[FieldOffset(Offset = "0x20")]
			public float currenct_time;

			// Token: 0x04006EC4 RID: 28356
			[Token(Token = "0x4006EC4")]
			[FieldOffset(Offset = "0x24")]
			public uint announcement_id;

			// Token: 0x04006EC5 RID: 28357
			[Token(Token = "0x4006EC5")]
			[FieldOffset(Offset = "0x28")]
			public uint activity_id;

			// Token: 0x04006EC6 RID: 28358
			[Token(Token = "0x4006EC6")]
			[FieldOffset(Offset = "0x30")]
			public string url;
		}

		// Token: 0x020011E8 RID: 4584
		[Token(Token = "0x20011E8")]
		public class EventDisconnectFromNetwork : EventLogger.EventLoggerBase
		{
			// Token: 0x06004752 RID: 18258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004752")]
			[Address(RVA = "0x1B8C558", Offset = "0x1B8C558", VA = "0x7BBC38C558")]
			public EventDisconnectFromNetwork()
			{
			}

			// Token: 0x04006EC7 RID: 28359
			[Token(Token = "0x4006EC7")]
			[FieldOffset(Offset = "0x20")]
			public string system_software;

			// Token: 0x04006EC8 RID: 28360
			[Token(Token = "0x4006EC8")]
			[FieldOffset(Offset = "0x28")]
			public string system_hardware;

			// Token: 0x04006EC9 RID: 28361
			[Token(Token = "0x4006EC9")]
			[FieldOffset(Offset = "0x30")]
			public int screen_width;

			// Token: 0x04006ECA RID: 28362
			[Token(Token = "0x4006ECA")]
			[FieldOffset(Offset = "0x34")]
			public int screen_hight;

			// Token: 0x04006ECB RID: 28363
			[Token(Token = "0x4006ECB")]
			[FieldOffset(Offset = "0x38")]
			public string dpi;

			// Token: 0x04006ECC RID: 28364
			[Token(Token = "0x4006ECC")]
			[FieldOffset(Offset = "0x40")]
			public string cpu_hardware;

			// Token: 0x04006ECD RID: 28365
			[Token(Token = "0x4006ECD")]
			[FieldOffset(Offset = "0x48")]
			public int memory;

			// Token: 0x04006ECE RID: 28366
			[Token(Token = "0x4006ECE")]
			[FieldOffset(Offset = "0x50")]
			public string gl_render;

			// Token: 0x04006ECF RID: 28367
			[Token(Token = "0x4006ECF")]
			[FieldOffset(Offset = "0x58")]
			public string gl_version;

			// Token: 0x04006ED0 RID: 28368
			[Token(Token = "0x4006ED0")]
			[FieldOffset(Offset = "0x60")]
			public string network;

			// Token: 0x04006ED1 RID: 28369
			[Token(Token = "0x4006ED1")]
			[FieldOffset(Offset = "0x68")]
			public int disconnection_type;
		}

		// Token: 0x020011E9 RID: 4585
		[Token(Token = "0x20011E9")]
		public enum EventShareAction
		{
			// Token: 0x04006ED3 RID: 28371
			[Token(Token = "0x4006ED3")]
			OpenUI = 1
		}

		// Token: 0x020011EA RID: 4586
		[Token(Token = "0x20011EA")]
		public class EventShare : EventLogger.EventLoggerBase
		{
			// Token: 0x06004753 RID: 18259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004753")]
			[Address(RVA = "0x1B94DEC", Offset = "0x1B94DEC", VA = "0x7BBC394DEC")]
			public EventShare()
			{
			}

			// Token: 0x04006ED4 RID: 28372
			[Token(Token = "0x4006ED4")]
			[FieldOffset(Offset = "0x20")]
			public int action;

			// Token: 0x04006ED5 RID: 28373
			[Token(Token = "0x4006ED5")]
			[FieldOffset(Offset = "0x24")]
			public bool share_out;

			// Token: 0x04006ED6 RID: 28374
			[Token(Token = "0x4006ED6")]
			[FieldOffset(Offset = "0x28")]
			public int platform;

			// Token: 0x04006ED7 RID: 28375
			[Token(Token = "0x4006ED7")]
			[FieldOffset(Offset = "0x2C")]
			public int page_id;
		}

		// Token: 0x020011EB RID: 4587
		[Token(Token = "0x20011EB")]
		public class EventShareLinkReturn : EventLogger.EventLoggerBase
		{
			// Token: 0x06004754 RID: 18260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004754")]
			[Address(RVA = "0x1B8D5C0", Offset = "0x1B8D5C0", VA = "0x7BBC38D5C0")]
			public EventShareLinkReturn()
			{
			}

			// Token: 0x04006ED8 RID: 28376
			[Token(Token = "0x4006ED8")]
			[FieldOffset(Offset = "0x20")]
			public string return_from_url;
		}

		// Token: 0x020011EC RID: 4588
		[Token(Token = "0x20011EC")]
		public class EventGachaNotifyState : EventLogger.EventLoggerBase
		{
			// Token: 0x06004755 RID: 18261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004755")]
			[Address(RVA = "0x1B91338", Offset = "0x1B91338", VA = "0x7BBC391338")]
			public EventGachaNotifyState()
			{
			}

			// Token: 0x04006ED9 RID: 28377
			[Token(Token = "0x4006ED9")]
			[FieldOffset(Offset = "0x20")]
			public bool state;
		}

		// Token: 0x020011ED RID: 4589
		[Token(Token = "0x20011ED")]
		public class EventIAPResult : EventLogger.EventLoggerBase
		{
			// Token: 0x06004756 RID: 18262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004756")]
			[Address(RVA = "0x1B8D2E0", Offset = "0x1B8D2E0", VA = "0x7BBC38D2E0")]
			public EventIAPResult()
			{
			}

			// Token: 0x04006EDA RID: 28378
			[Token(Token = "0x4006EDA")]
			[FieldOffset(Offset = "0x20")]
			public int error_code;

			// Token: 0x04006EDB RID: 28379
			[Token(Token = "0x4006EDB")]
			[FieldOffset(Offset = "0x28")]
			public string error_message;

			// Token: 0x04006EDC RID: 28380
			[Token(Token = "0x4006EDC")]
			[FieldOffset(Offset = "0x30")]
			public string item_identifier;

			// Token: 0x04006EDD RID: 28381
			[Token(Token = "0x4006EDD")]
			[FieldOffset(Offset = "0x38")]
			public bool is_first_topup;

			// Token: 0x04006EDE RID: 28382
			[Token(Token = "0x4006EDE")]
			[FieldOffset(Offset = "0x3C")]
			public uint ui_from;
		}

		// Token: 0x020011EE RID: 4590
		[Token(Token = "0x20011EE")]
		public class EventScanIAPResult : EventLogger.EventLoggerBase
		{
			// Token: 0x06004757 RID: 18263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004757")]
			[Address(RVA = "0x1B8D4AC", Offset = "0x1B8D4AC", VA = "0x7BBC38D4AC")]
			public EventScanIAPResult()
			{
			}

			// Token: 0x04006EDF RID: 28383
			[Token(Token = "0x4006EDF")]
			[FieldOffset(Offset = "0x20")]
			public string results;
		}

		// Token: 0x020011EF RID: 4591
		[Token(Token = "0x20011EF")]
		public class EventIAPRebateResult : EventLogger.EventLoggerBase
		{
			// Token: 0x06004758 RID: 18264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004758")]
			[Address(RVA = "0x1B8D7C8", Offset = "0x1B8D7C8", VA = "0x7BBC38D7C8")]
			public EventIAPRebateResult()
			{
			}

			// Token: 0x04006EE0 RID: 28384
			[Token(Token = "0x4006EE0")]
			[FieldOffset(Offset = "0x20")]
			public int rebate_id;

			// Token: 0x04006EE1 RID: 28385
			[Token(Token = "0x4006EE1")]
			[FieldOffset(Offset = "0x24")]
			public int remaining_days;

			// Token: 0x04006EE2 RID: 28386
			[Token(Token = "0x4006EE2")]
			[FieldOffset(Offset = "0x28")]
			public int error_code;

			// Token: 0x04006EE3 RID: 28387
			[Token(Token = "0x4006EE3")]
			[FieldOffset(Offset = "0x30")]
			public string error_message;

			// Token: 0x04006EE4 RID: 28388
			[Token(Token = "0x4006EE4")]
			[FieldOffset(Offset = "0x38")]
			public uint ui_from;
		}

		// Token: 0x020011F0 RID: 4592
		[Token(Token = "0x20011F0")]
		public class EventRedeemRebateResult : EventLogger.EventLoggerBase
		{
			// Token: 0x06004759 RID: 18265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004759")]
			[Address(RVA = "0x1B8D9E4", Offset = "0x1B8D9E4", VA = "0x7BBC38D9E4")]
			public EventRedeemRebateResult()
			{
			}

			// Token: 0x04006EE5 RID: 28389
			[Token(Token = "0x4006EE5")]
			[FieldOffset(Offset = "0x20")]
			public int rebate_id;

			// Token: 0x04006EE6 RID: 28390
			[Token(Token = "0x4006EE6")]
			[FieldOffset(Offset = "0x24")]
			public int remaining_days;

			// Token: 0x04006EE7 RID: 28391
			[Token(Token = "0x4006EE7")]
			[FieldOffset(Offset = "0x28")]
			public int redeem_amount;

			// Token: 0x04006EE8 RID: 28392
			[Token(Token = "0x4006EE8")]
			[FieldOffset(Offset = "0x2C")]
			public int error_code;

			// Token: 0x04006EE9 RID: 28393
			[Token(Token = "0x4006EE9")]
			[FieldOffset(Offset = "0x30")]
			public string error_message;
		}

		// Token: 0x020011F1 RID: 4593
		[Token(Token = "0x20011F1")]
		public class EventErrorInHTTP : EventLogger.EventLoggerBase
		{
			// Token: 0x0600475A RID: 18266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600475A")]
			[Address(RVA = "0x1B94D08", Offset = "0x1B94D08", VA = "0x7BBC394D08")]
			public EventErrorInHTTP()
			{
			}

			// Token: 0x04006EEA RID: 28394
			[Token(Token = "0x4006EEA")]
			[FieldOffset(Offset = "0x20")]
			public string system_software;

			// Token: 0x04006EEB RID: 28395
			[Token(Token = "0x4006EEB")]
			[FieldOffset(Offset = "0x28")]
			public string system_hardware;

			// Token: 0x04006EEC RID: 28396
			[Token(Token = "0x4006EEC")]
			[FieldOffset(Offset = "0x30")]
			public string network;

			// Token: 0x04006EED RID: 28397
			[Token(Token = "0x4006EED")]
			[FieldOffset(Offset = "0x38")]
			public string url;
		}

		// Token: 0x020011F2 RID: 4594
		[Token(Token = "0x20011F2")]
		public class EventSkyDivingStates : EventLogger.EventLoggerBase
		{
			// Token: 0x0600475B RID: 18267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600475B")]
			[Address(RVA = "0x1B94DFC", Offset = "0x1B94DFC", VA = "0x7BBC394DFC")]
			public EventSkyDivingStates()
			{
			}

			// Token: 0x04006EEE RID: 28398
			[Token(Token = "0x4006EEE")]
			[FieldOffset(Offset = "0x20")]
			public int switch_mode_times;

			// Token: 0x04006EEF RID: 28399
			[Token(Token = "0x4006EEF")]
			[FieldOffset(Offset = "0x24")]
			public uint surfing_duration;

			// Token: 0x04006EF0 RID: 28400
			[Token(Token = "0x4006EF0")]
			[FieldOffset(Offset = "0x28")]
			public uint diving_duration;

			// Token: 0x04006EF1 RID: 28401
			[Token(Token = "0x4006EF1")]
			[FieldOffset(Offset = "0x2C")]
			public uint duration_before_parachuting;

			// Token: 0x04006EF2 RID: 28402
			[Token(Token = "0x4006EF2")]
			[FieldOffset(Offset = "0x30")]
			public uint game_mode;

			// Token: 0x04006EF3 RID: 28403
			[Token(Token = "0x4006EF3")]
			[FieldOffset(Offset = "0x34")]
			public uint map_id;

			// Token: 0x04006EF4 RID: 28404
			[Token(Token = "0x4006EF4")]
			[FieldOffset(Offset = "0x38")]
			public ulong match_id;

			// Token: 0x04006EF5 RID: 28405
			[Token(Token = "0x4006EF5")]
			[FieldOffset(Offset = "0x40")]
			public uint sliding_count;
		}

		// Token: 0x020011F3 RID: 4595
		[Token(Token = "0x20011F3")]
		public class EventClimbLog : EventLogger.EventLoggerBase
		{
			// Token: 0x0600475C RID: 18268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600475C")]
			[Address(RVA = "0x1B94D00", Offset = "0x1B94D00", VA = "0x7BBC394D00")]
			public EventClimbLog()
			{
			}

			// Token: 0x04006EF6 RID: 28406
			[Token(Token = "0x4006EF6")]
			[FieldOffset(Offset = "0x20")]
			public ulong match_id;

			// Token: 0x04006EF7 RID: 28407
			[Token(Token = "0x4006EF7")]
			[FieldOffset(Offset = "0x28")]
			public uint map_id;

			// Token: 0x04006EF8 RID: 28408
			[Token(Token = "0x4006EF8")]
			[FieldOffset(Offset = "0x2C")]
			public uint game_mode;

			// Token: 0x04006EF9 RID: 28409
			[Token(Token = "0x4006EF9")]
			[FieldOffset(Offset = "0x30")]
			public float trigger_pos_x;

			// Token: 0x04006EFA RID: 28410
			[Token(Token = "0x4006EFA")]
			[FieldOffset(Offset = "0x34")]
			public float trigger_pos_y;

			// Token: 0x04006EFB RID: 28411
			[Token(Token = "0x4006EFB")]
			[FieldOffset(Offset = "0x38")]
			public float trigger_pos_z;

			// Token: 0x04006EFC RID: 28412
			[Token(Token = "0x4006EFC")]
			[FieldOffset(Offset = "0x40")]
			public string trigger_tag;
		}

		// Token: 0x020011F4 RID: 4596
		[Token(Token = "0x20011F4")]
		public class EventOpenGachaEntrance : EventLogger.EventLoggerBase
		{
			// Token: 0x0600475D RID: 18269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600475D")]
			[Address(RVA = "0x1B8E31C", Offset = "0x1B8E31C", VA = "0x7BBC38E31C")]
			public EventOpenGachaEntrance()
			{
			}
		}

		// Token: 0x020011F5 RID: 4597
		[Token(Token = "0x20011F5")]
		public class EventNewbieFirstGameSwitchToSolo : EventLogger.EventLoggerBase
		{
			// Token: 0x0600475E RID: 18270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600475E")]
			[Address(RVA = "0x1B94D8C", Offset = "0x1B94D8C", VA = "0x7BBC394D8C")]
			public EventNewbieFirstGameSwitchToSolo()
			{
			}
		}

		// Token: 0x020011F6 RID: 4598
		[Token(Token = "0x20011F6")]
		public class EventOpenRewardPoolCount : EventLogger.EventLoggerBase
		{
			// Token: 0x0600475F RID: 18271 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600475F")]
			[Address(RVA = "0x1B8E4A8", Offset = "0x1B8E4A8", VA = "0x7BBC38E4A8")]
			public EventOpenRewardPoolCount()
			{
			}
		}

		// Token: 0x020011F7 RID: 4599
		[Token(Token = "0x20011F7")]
		public class EventElitePassEntry : EventLogger.EventLoggerBase
		{
			// Token: 0x06004760 RID: 18272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004760")]
			[Address(RVA = "0x1B94AC8", Offset = "0x1B94AC8", VA = "0x7BBC394AC8")]
			public EventElitePassEntry()
			{
			}

			// Token: 0x04006EFD RID: 28413
			[Token(Token = "0x4006EFD")]
			[FieldOffset(Offset = "0x20")]
			public uint ep_main_entry_count;

			// Token: 0x04006EFE RID: 28414
			[Token(Token = "0x4006EFE")]
			[FieldOffset(Offset = "0x24")]
			public uint ep_challenge_entry_count;
		}

		// Token: 0x020011F8 RID: 4600
		[Token(Token = "0x20011F8")]
		public class EventGiftReceive : EventLogger.EventLoggerBase
		{
			// Token: 0x06004761 RID: 18273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004761")]
			[Address(RVA = "0x1B8E720", Offset = "0x1B8E720", VA = "0x7BBC38E720")]
			public EventGiftReceive()
			{
			}

			// Token: 0x04006EFF RID: 28415
			[Token(Token = "0x4006EFF")]
			[FieldOffset(Offset = "0x20")]
			public string current_time;

			// Token: 0x04006F00 RID: 28416
			[Token(Token = "0x4006F00")]
			[FieldOffset(Offset = "0x28")]
			public uint item_id;

			// Token: 0x04006F01 RID: 28417
			[Token(Token = "0x4006F01")]
			[FieldOffset(Offset = "0x2C")]
			public uint expire_time;
		}

		// Token: 0x020011F9 RID: 4601
		[Token(Token = "0x20011F9")]
		public class EventChat : EventLogger.EventLoggerBase
		{
			// Token: 0x06004762 RID: 18274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004762")]
			[Address(RVA = "0x1B94CE8", Offset = "0x1B94CE8", VA = "0x7BBC394CE8")]
			public EventChat()
			{
			}

			// Token: 0x04006F02 RID: 28418
			[Token(Token = "0x4006F02")]
			[FieldOffset(Offset = "0x20")]
			public ulong group_chan_id;

			// Token: 0x04006F03 RID: 28419
			[Token(Token = "0x4006F03")]
			[FieldOffset(Offset = "0x28")]
			public uint group_chat_num;

			// Token: 0x04006F04 RID: 28420
			[Token(Token = "0x4006F04")]
			[FieldOffset(Offset = "0x30")]
			public ulong clan_chan_id;

			// Token: 0x04006F05 RID: 28421
			[Token(Token = "0x4006F05")]
			[FieldOffset(Offset = "0x38")]
			public uint clan_chat_num;

			// Token: 0x04006F06 RID: 28422
			[Token(Token = "0x4006F06")]
			[FieldOffset(Offset = "0x3C")]
			public uint whisper_chat_num;

			// Token: 0x04006F07 RID: 28423
			[Token(Token = "0x4006F07")]
			[FieldOffset(Offset = "0x40")]
			public ulong room_chan_id;

			// Token: 0x04006F08 RID: 28424
			[Token(Token = "0x4006F08")]
			[FieldOffset(Offset = "0x48")]
			public uint room_chat_num;

			// Token: 0x04006F09 RID: 28425
			[Token(Token = "0x4006F09")]
			[FieldOffset(Offset = "0x4C")]
			public uint use_sticker_times;

			// Token: 0x04006F0A RID: 28426
			[Token(Token = "0x4006F0A")]
			[FieldOffset(Offset = "0x50")]
			public ulong world_chan_id;

			// Token: 0x04006F0B RID: 28427
			[Token(Token = "0x4006F0B")]
			[FieldOffset(Offset = "0x58")]
			public uint world_chat_num;

			// Token: 0x04006F0C RID: 28428
			[Token(Token = "0x4006F0C")]
			[FieldOffset(Offset = "0x5C")]
			public uint block_list_size;
		}

		// Token: 0x020011FA RID: 4602
		[Token(Token = "0x20011FA")]
		public class EventTypeClientSettingChange : EventLogger.EventLoggerBase
		{
			// Token: 0x06004763 RID: 18275 RVA: 0x00015540 File Offset: 0x00013740
			[Token(Token = "0x6004763")]
			[Address(RVA = "0x1B9383C", Offset = "0x1B9383C", VA = "0x7BBC39383C")]
			public bool IsChange()
			{
				return default(bool);
			}

			// Token: 0x06004764 RID: 18276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004764")]
			[Address(RVA = "0x1B94B00", Offset = "0x1B94B00", VA = "0x7BBC394B00")]
			public EventTypeClientSettingChange()
			{
			}

			// Token: 0x04006F0D RID: 28429
			[Token(Token = "0x4006F0D")]
			[FieldOffset(Offset = "0x20")]
			public int is_max;

			// Token: 0x04006F0E RID: 28430
			[Token(Token = "0x4006F0E")]
			[FieldOffset(Offset = "0x28")]
			public string cur_general_sensitivity;

			// Token: 0x04006F0F RID: 28431
			[Token(Token = "0x4006F0F")]
			[FieldOffset(Offset = "0x30")]
			public string pre_general_sensitivity;

			// Token: 0x04006F10 RID: 28432
			[Token(Token = "0x4006F10")]
			[FieldOffset(Offset = "0x38")]
			public string cur_free_look_sensitivity;

			// Token: 0x04006F11 RID: 28433
			[Token(Token = "0x4006F11")]
			[FieldOffset(Offset = "0x40")]
			public string pre_free_look_sensitivity;

			// Token: 0x04006F12 RID: 28434
			[Token(Token = "0x4006F12")]
			[FieldOffset(Offset = "0x48")]
			public string cur_music;

			// Token: 0x04006F13 RID: 28435
			[Token(Token = "0x4006F13")]
			[FieldOffset(Offset = "0x50")]
			public string pre_music;

			// Token: 0x04006F14 RID: 28436
			[Token(Token = "0x4006F14")]
			[FieldOffset(Offset = "0x58")]
			public string cur_sound_effects;

			// Token: 0x04006F15 RID: 28437
			[Token(Token = "0x4006F15")]
			[FieldOffset(Offset = "0x60")]
			public string pre_sound_effects;

			// Token: 0x04006F16 RID: 28438
			[Token(Token = "0x4006F16")]
			[FieldOffset(Offset = "0x68")]
			public string cur_voice;

			// Token: 0x04006F17 RID: 28439
			[Token(Token = "0x4006F17")]
			[FieldOffset(Offset = "0x70")]
			public string pre_voice;

			// Token: 0x04006F18 RID: 28440
			[Token(Token = "0x4006F18")]
			[FieldOffset(Offset = "0x78")]
			public string cur_graphics;

			// Token: 0x04006F19 RID: 28441
			[Token(Token = "0x4006F19")]
			[FieldOffset(Offset = "0x80")]
			public string pre_graphics;

			// Token: 0x04006F1A RID: 28442
			[Token(Token = "0x4006F1A")]
			[FieldOffset(Offset = "0x88")]
			public int cur_high_res;

			// Token: 0x04006F1B RID: 28443
			[Token(Token = "0x4006F1B")]
			[FieldOffset(Offset = "0x8C")]
			public int pre_high_res;

			// Token: 0x04006F1C RID: 28444
			[Token(Token = "0x4006F1C")]
			[FieldOffset(Offset = "0x90")]
			public int cur_high_fps;

			// Token: 0x04006F1D RID: 28445
			[Token(Token = "0x4006F1D")]
			[FieldOffset(Offset = "0x94")]
			public int pre_high_fps;

			// Token: 0x04006F1E RID: 28446
			[Token(Token = "0x4006F1E")]
			[FieldOffset(Offset = "0x98")]
			public int cur_shadow;

			// Token: 0x04006F1F RID: 28447
			[Token(Token = "0x4006F1F")]
			[FieldOffset(Offset = "0x9C")]
			public int pre_shadow;

			// Token: 0x04006F20 RID: 28448
			[Token(Token = "0x4006F20")]
			[FieldOffset(Offset = "0xA0")]
			public int cur_free_look;

			// Token: 0x04006F21 RID: 28449
			[Token(Token = "0x4006F21")]
			[FieldOffset(Offset = "0xA4")]
			public int pre_free_look;

			// Token: 0x04006F22 RID: 28450
			[Token(Token = "0x4006F22")]
			[FieldOffset(Offset = "0xA8")]
			public int cur_hitmarker;

			// Token: 0x04006F23 RID: 28451
			[Token(Token = "0x4006F23")]
			[FieldOffset(Offset = "0xAC")]
			public int pre_hitmarker;

			// Token: 0x04006F24 RID: 28452
			[Token(Token = "0x4006F24")]
			[FieldOffset(Offset = "0xB0")]
			public int cur_team_reserve;

			// Token: 0x04006F25 RID: 28453
			[Token(Token = "0x4006F25")]
			[FieldOffset(Offset = "0xB4")]
			public int pre_team_reserve;

			// Token: 0x04006F26 RID: 28454
			[Token(Token = "0x4006F26")]
			[FieldOffset(Offset = "0xB8")]
			public int cur_team_block;

			// Token: 0x04006F27 RID: 28455
			[Token(Token = "0x4006F27")]
			[FieldOffset(Offset = "0xBC")]
			public int pre_team_block;
		}

		// Token: 0x020011FB RID: 4603
		[Token(Token = "0x20011FB")]
		[Serializable]
		public class EventNavigate : EventLogger.EventLoggerBase
		{
			// Token: 0x06004765 RID: 18277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004765")]
			[Address(RVA = "0x1B917B0", Offset = "0x1B917B0", VA = "0x7BBC3917B0")]
			public EventNavigate()
			{
			}

			// Token: 0x04006F28 RID: 28456
			[Token(Token = "0x4006F28")]
			[FieldOffset(Offset = "0x20")]
			public string to;

			// Token: 0x04006F29 RID: 28457
			[Token(Token = "0x4006F29")]
			[FieldOffset(Offset = "0x28")]
			public uint lobby;

			// Token: 0x04006F2A RID: 28458
			[Token(Token = "0x4006F2A")]
			[FieldOffset(Offset = "0x2C")]
			public uint debt;

			// Token: 0x04006F2B RID: 28459
			[Token(Token = "0x4006F2B")]
			[FieldOffset(Offset = "0x30")]
			public uint topup;

			// Token: 0x04006F2C RID: 28460
			[Token(Token = "0x4006F2C")]
			[FieldOffset(Offset = "0x34")]
			public uint splash_banner;

			// Token: 0x04006F2D RID: 28461
			[Token(Token = "0x4006F2D")]
			[FieldOffset(Offset = "0x38")]
			public uint activity;

			// Token: 0x04006F2E RID: 28462
			[Token(Token = "0x4006F2E")]
			[FieldOffset(Offset = "0x3C")]
			public uint notify;

			// Token: 0x04006F2F RID: 28463
			[Token(Token = "0x4006F2F")]
			[FieldOffset(Offset = "0x40")]
			public uint other;

			// Token: 0x04006F30 RID: 28464
			[Token(Token = "0x4006F30")]
			[FieldOffset(Offset = "0x44")]
			public uint lobby_ads;

			// Token: 0x04006F31 RID: 28465
			[Token(Token = "0x4006F31")]
			[FieldOffset(Offset = "0x48")]
			public uint lobby_extra_ads_1;

			// Token: 0x04006F32 RID: 28466
			[Token(Token = "0x4006F32")]
			[FieldOffset(Offset = "0x4C")]
			public uint lobby_extra_ads_2;

			// Token: 0x04006F33 RID: 28467
			[Token(Token = "0x4006F33")]
			[FieldOffset(Offset = "0x50")]
			public uint mall_ads;

			// Token: 0x04006F34 RID: 28468
			[Token(Token = "0x4006F34")]
			[FieldOffset(Offset = "0x54")]
			public uint mall_web_btn;
		}

		// Token: 0x020011FC RID: 4604
		[Token(Token = "0x20011FC")]
		[Serializable]
		public class EventClick : EventLogger.EventLoggerBase
		{
			// Token: 0x06004766 RID: 18278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004766")]
			[Address(RVA = "0x1B91A98", Offset = "0x1B91A98", VA = "0x7BBC391A98")]
			public EventClick()
			{
			}

			// Token: 0x04006F35 RID: 28469
			[Token(Token = "0x4006F35")]
			[FieldOffset(Offset = "0x20")]
			public List<EventLogger.ClickEntry> clicks;
		}

		// Token: 0x020011FD RID: 4605
		[Token(Token = "0x20011FD")]
		[Serializable]
		public class ClickEntry
		{
			// Token: 0x06004767 RID: 18279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004767")]
			[Address(RVA = "0x1B91AA0", Offset = "0x1B91AA0", VA = "0x7BBC391AA0")]
			public ClickEntry()
			{
			}

			// Token: 0x04006F36 RID: 28470
			[Token(Token = "0x4006F36")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04006F37 RID: 28471
			[Token(Token = "0x4006F37")]
			[FieldOffset(Offset = "0x18")]
			public uint cnt;
		}

		// Token: 0x020011FE RID: 4606
		[Token(Token = "0x20011FE")]
		[Serializable]
		public class EventLiveZoneClickCount : EventLogger.EventLoggerBase
		{
			// Token: 0x06004768 RID: 18280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004768")]
			[Address(RVA = "0x1B94D18", Offset = "0x1B94D18", VA = "0x7BBC394D18")]
			public EventLiveZoneClickCount()
			{
			}

			// Token: 0x04006F38 RID: 28472
			[Token(Token = "0x4006F38")]
			[FieldOffset(Offset = "0x20")]
			public List<EventLogger.LiveZoneClickInfo> zone_click_result;
		}

		// Token: 0x020011FF RID: 4607
		[Token(Token = "0x20011FF")]
		public class LiveZoneClickInfo
		{
			// Token: 0x06004769 RID: 18281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004769")]
			[Address(RVA = "0x1B94E5C", Offset = "0x1B94E5C", VA = "0x7BBC394E5C")]
			public LiveZoneClickInfo(ulong id, uint count)
			{
			}

			// Token: 0x04006F39 RID: 28473
			[Token(Token = "0x4006F39")]
			[FieldOffset(Offset = "0x10")]
			public ulong streamer_id;

			// Token: 0x04006F3A RID: 28474
			[Token(Token = "0x4006F3A")]
			[FieldOffset(Offset = "0x18")]
			public uint click_count;
		}

		// Token: 0x02001200 RID: 4608
		[Token(Token = "0x2001200")]
		public class EventIAPBundlePurchase : EventLogger.EventLoggerBase
		{
			// Token: 0x0600476A RID: 18282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600476A")]
			[Address(RVA = "0x1B8E978", Offset = "0x1B8E978", VA = "0x7BBC38E978")]
			public EventIAPBundlePurchase()
			{
			}

			// Token: 0x04006F3B RID: 28475
			[Token(Token = "0x4006F3B")]
			[FieldOffset(Offset = "0x20")]
			public string current_time;

			// Token: 0x04006F3C RID: 28476
			[Token(Token = "0x4006F3C")]
			[FieldOffset(Offset = "0x28")]
			public int store_id;

			// Token: 0x04006F3D RID: 28477
			[Token(Token = "0x4006F3D")]
			[FieldOffset(Offset = "0x2C")]
			public int bundle_id;

			// Token: 0x04006F3E RID: 28478
			[Token(Token = "0x4006F3E")]
			[FieldOffset(Offset = "0x30")]
			public float price_usd;

			// Token: 0x04006F3F RID: 28479
			[Token(Token = "0x4006F3F")]
			[FieldOffset(Offset = "0x34")]
			public int discount;

			// Token: 0x04006F40 RID: 28480
			[Token(Token = "0x4006F40")]
			[FieldOffset(Offset = "0x38")]
			public int rebate_id;

			// Token: 0x04006F41 RID: 28481
			[Token(Token = "0x4006F41")]
			[FieldOffset(Offset = "0x40")]
			public string product_identifier;

			// Token: 0x04006F42 RID: 28482
			[Token(Token = "0x4006F42")]
			[FieldOffset(Offset = "0x48")]
			public uint ui_from;
		}

		// Token: 0x02001201 RID: 4609
		[Token(Token = "0x2001201")]
		public class EventPaymentBundlePurchase : EventLogger.EventLoggerBase
		{
			// Token: 0x0600476B RID: 18283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600476B")]
			[Address(RVA = "0x1B94DAC", Offset = "0x1B94DAC", VA = "0x7BBC394DAC")]
			public EventPaymentBundlePurchase()
			{
			}

			// Token: 0x04006F43 RID: 28483
			[Token(Token = "0x4006F43")]
			[FieldOffset(Offset = "0x20")]
			public string current_time;

			// Token: 0x04006F44 RID: 28484
			[Token(Token = "0x4006F44")]
			[FieldOffset(Offset = "0x28")]
			public int id;

			// Token: 0x04006F45 RID: 28485
			[Token(Token = "0x4006F45")]
			[FieldOffset(Offset = "0x2C")]
			public int discount;

			// Token: 0x04006F46 RID: 28486
			[Token(Token = "0x4006F46")]
			[FieldOffset(Offset = "0x30")]
			public int rebate_id;

			// Token: 0x04006F47 RID: 28487
			[Token(Token = "0x4006F47")]
			[FieldOffset(Offset = "0x38")]
			public string product_identifier;

			// Token: 0x04006F48 RID: 28488
			[Token(Token = "0x4006F48")]
			[FieldOffset(Offset = "0x40")]
			public uint ui_from;
		}

		// Token: 0x02001202 RID: 4610
		[Token(Token = "0x2001202")]
		public class EventBroadCastTypeCnt : EventLogger.EventLoggerBase
		{
			// Token: 0x0600476C RID: 18284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600476C")]
			[Address(RVA = "0x1B91D1C", Offset = "0x1B91D1C", VA = "0x7BBC391D1C")]
			public EventBroadCastTypeCnt()
			{
			}

			// Token: 0x04006F49 RID: 28489
			[Token(Token = "0x4006F49")]
			[FieldOffset(Offset = "0x20")]
			public List<EventLogger.EventBroadCastEntry> entries;
		}

		// Token: 0x02001203 RID: 4611
		[Token(Token = "0x2001203")]
		public class EventBroadCastEntry
		{
			// Token: 0x0600476D RID: 18285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600476D")]
			[Address(RVA = "0x1B91D24", Offset = "0x1B91D24", VA = "0x7BBC391D24")]
			public EventBroadCastEntry()
			{
			}

			// Token: 0x04006F4A RID: 28490
			[Token(Token = "0x4006F4A")]
			[FieldOffset(Offset = "0x10")]
			public EventLogger.EventBroadCastType type;

			// Token: 0x04006F4B RID: 28491
			[Token(Token = "0x4006F4B")]
			[FieldOffset(Offset = "0x14")]
			public int cnt;
		}

		// Token: 0x02001204 RID: 4612
		[Token(Token = "0x2001204")]
		public class EventElitePassSubscribe : EventLogger.EventLoggerBase
		{
			// Token: 0x0600476E RID: 18286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600476E")]
			[Address(RVA = "0x1B8EB6C", Offset = "0x1B8EB6C", VA = "0x7BBC38EB6C")]
			public EventElitePassSubscribe()
			{
			}

			// Token: 0x04006F4C RID: 28492
			[Token(Token = "0x4006F4C")]
			[FieldOffset(Offset = "0x20")]
			public bool result;

			// Token: 0x04006F4D RID: 28493
			[Token(Token = "0x4006F4D")]
			[FieldOffset(Offset = "0x24")]
			public int errorCode;

			// Token: 0x04006F4E RID: 28494
			[Token(Token = "0x4006F4E")]
			[FieldOffset(Offset = "0x28")]
			public string price;

			// Token: 0x04006F4F RID: 28495
			[Token(Token = "0x4006F4F")]
			[FieldOffset(Offset = "0x30")]
			public string product_identifier;

			// Token: 0x04006F50 RID: 28496
			[Token(Token = "0x4006F50")]
			[FieldOffset(Offset = "0x38")]
			public int rebate_id;

			// Token: 0x04006F51 RID: 28497
			[Token(Token = "0x4006F51")]
			[FieldOffset(Offset = "0x3C")]
			public uint ui_from;
		}

		// Token: 0x02001205 RID: 4613
		[Token(Token = "0x2001205")]
		public class EventAndroidApplicationDetection : EventLogger.EventLoggerBase
		{
			// Token: 0x0600476F RID: 18287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600476F")]
			[Address(RVA = "0x1B8ED78", Offset = "0x1B8ED78", VA = "0x7BBC38ED78")]
			public EventAndroidApplicationDetection()
			{
			}

			// Token: 0x04006F52 RID: 28498
			[Token(Token = "0x4006F52")]
			[FieldOffset(Offset = "0x20")]
			public string detection;
		}

		// Token: 0x02001206 RID: 4614
		[Token(Token = "0x2001206")]
		[Serializable]
		public class EventNavigationClickCount : EventLogger.EventLoggerBase
		{
			// Token: 0x06004770 RID: 18288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004770")]
			[Address(RVA = "0x1B94D84", Offset = "0x1B94D84", VA = "0x7BBC394D84")]
			public EventNavigationClickCount()
			{
			}

			// Token: 0x04006F53 RID: 28499
			[Token(Token = "0x4006F53")]
			[FieldOffset(Offset = "0x20")]
			public uint activity_id;

			// Token: 0x04006F54 RID: 28500
			[Token(Token = "0x4006F54")]
			[FieldOffset(Offset = "0x24")]
			public uint navigation_clicks;
		}

		// Token: 0x02001207 RID: 4615
		[Token(Token = "0x2001207")]
		[Serializable]
		public class EventLobbyClickCount : EventLogger.EventLoggerBase
		{
			// Token: 0x06004771 RID: 18289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004771")]
			[Address(RVA = "0x1B8F6B8", Offset = "0x1B8F6B8", VA = "0x7BBC38F6B8")]
			public EventLobbyClickCount()
			{
			}

			// Token: 0x04006F55 RID: 28501
			[Token(Token = "0x4006F55")]
			[FieldOffset(Offset = "0x20")]
			public uint pet_clicks;

			// Token: 0x04006F56 RID: 28502
			[Token(Token = "0x4006F56")]
			[FieldOffset(Offset = "0x24")]
			public uint store_clicks;

			// Token: 0x04006F57 RID: 28503
			[Token(Token = "0x4006F57")]
			[FieldOffset(Offset = "0x28")]
			public uint lottery_clicks;

			// Token: 0x04006F58 RID: 28504
			[Token(Token = "0x4006F58")]
			[FieldOffset(Offset = "0x2C")]
			public uint character_clicks;

			// Token: 0x04006F59 RID: 28505
			[Token(Token = "0x4006F59")]
			[FieldOffset(Offset = "0x30")]
			public uint vault_clicks;

			// Token: 0x04006F5A RID: 28506
			[Token(Token = "0x4006F5A")]
			[FieldOffset(Offset = "0x34")]
			public uint collection_clicks;

			// Token: 0x04006F5B RID: 28507
			[Token(Token = "0x4006F5B")]
			[FieldOffset(Offset = "0x38")]
			public uint friend_clicks;

			// Token: 0x04006F5C RID: 28508
			[Token(Token = "0x4006F5C")]
			[FieldOffset(Offset = "0x3C")]
			public uint leaderboard_clicks;

			// Token: 0x04006F5D RID: 28509
			[Token(Token = "0x4006F5D")]
			[FieldOffset(Offset = "0x40")]
			public uint clan_clicks;

			// Token: 0x04006F5E RID: 28510
			[Token(Token = "0x4006F5E")]
			[FieldOffset(Offset = "0x44")]
			public uint activity_clicks;

			// Token: 0x04006F5F RID: 28511
			[Token(Token = "0x4006F5F")]
			[FieldOffset(Offset = "0x48")]
			public uint ep_challenge_clicks;

			// Token: 0x04006F60 RID: 28512
			[Token(Token = "0x4006F60")]
			[FieldOffset(Offset = "0x4C")]
			public uint beginner_tutorial_clicks;

			// Token: 0x04006F61 RID: 28513
			[Token(Token = "0x4006F61")]
			[FieldOffset(Offset = "0x50")]
			public uint rewarded_video_clicks;

			// Token: 0x04006F62 RID: 28514
			[Token(Token = "0x4006F62")]
			[FieldOffset(Offset = "0x54")]
			public uint elite_pass_clicks;

			// Token: 0x04006F63 RID: 28515
			[Token(Token = "0x4006F63")]
			[FieldOffset(Offset = "0x58")]
			public uint rank_lobby_clicks;

			// Token: 0x04006F64 RID: 28516
			[Token(Token = "0x4006F64")]
			[FieldOffset(Offset = "0x5C")]
			public uint ep_video_clicks;

			// Token: 0x04006F65 RID: 28517
			[Token(Token = "0x4006F65")]
			[FieldOffset(Offset = "0x60")]
			public uint recharge_entrance_clicks;

			// Token: 0x04006F66 RID: 28518
			[Token(Token = "0x4006F66")]
			[FieldOffset(Offset = "0x64")]
			public uint group_show_emote_clicks;

			// Token: 0x04006F67 RID: 28519
			[Token(Token = "0x4006F67")]
			[FieldOffset(Offset = "0x68")]
			public uint manual_clicks;

			// Token: 0x04006F68 RID: 28520
			[Token(Token = "0x4006F68")]
			[FieldOffset(Offset = "0x6C")]
			public uint live_clicks;

			// Token: 0x04006F69 RID: 28521
			[Token(Token = "0x4006F69")]
			[FieldOffset(Offset = "0x70")]
			public uint newplayer_clicks;
		}

		// Token: 0x02001208 RID: 4616
		[Token(Token = "0x2001208")]
		[Serializable]
		public class EventManualClickCount : EventLogger.EventLoggerBase
		{
			// Token: 0x06004772 RID: 18290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004772")]
			[Address(RVA = "0x1B8F998", Offset = "0x1B8F998", VA = "0x7BBC38F998")]
			public EventManualClickCount()
			{
			}

			// Token: 0x04006F6A RID: 28522
			[Token(Token = "0x4006F6A")]
			[FieldOffset(Offset = "0x20")]
			public uint growing_route_clicks;

			// Token: 0x04006F6B RID: 28523
			[Token(Token = "0x4006F6B")]
			[FieldOffset(Offset = "0x24")]
			public uint weapon_clicks;

			// Token: 0x04006F6C RID: 28524
			[Token(Token = "0x4006F6C")]
			[FieldOffset(Offset = "0x28")]
			public uint map_clicks;

			// Token: 0x04006F6D RID: 28525
			[Token(Token = "0x4006F6D")]
			[FieldOffset(Offset = "0x2C")]
			public uint welcome_to_map_clicks;

			// Token: 0x04006F6E RID: 28526
			[Token(Token = "0x4006F6E")]
			[FieldOffset(Offset = "0x30")]
			public uint survive_in_map_clicks;

			// Token: 0x04006F6F RID: 28527
			[Token(Token = "0x4006F6F")]
			[FieldOffset(Offset = "0x34")]
			public uint event_in_map_clicks;

			// Token: 0x04006F70 RID: 28528
			[Token(Token = "0x4006F70")]
			[FieldOffset(Offset = "0x38")]
			public uint move_on_map_clicks;

			// Token: 0x04006F71 RID: 28529
			[Token(Token = "0x4006F71")]
			[FieldOffset(Offset = "0x3C")]
			public uint more_help_clicks;

			// Token: 0x04006F72 RID: 28530
			[Token(Token = "0x4006F72")]
			[FieldOffset(Offset = "0x40")]
			public uint share_clicks;
		}

		// Token: 0x02001209 RID: 4617
		[Token(Token = "0x2001209")]
		public class EventGotoOthersPersonalShowTimes : EventLogger.EventLoggerBase
		{
			// Token: 0x06004773 RID: 18291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004773")]
			[Address(RVA = "0x1B8FC3C", Offset = "0x1B8FC3C", VA = "0x7BBC38FC3C")]
			public EventGotoOthersPersonalShowTimes()
			{
			}

			// Token: 0x04006F73 RID: 28531
			[Token(Token = "0x4006F73")]
			[FieldOffset(Offset = "0x20")]
			public uint group_list;

			// Token: 0x04006F74 RID: 28532
			[Token(Token = "0x4006F74")]
			[FieldOffset(Offset = "0x24")]
			public uint clan_members;

			// Token: 0x04006F75 RID: 28533
			[Token(Token = "0x4006F75")]
			[FieldOffset(Offset = "0x28")]
			public uint friend_list;

			// Token: 0x04006F76 RID: 28534
			[Token(Token = "0x4006F76")]
			[FieldOffset(Offset = "0x2C")]
			public uint search_account;

			// Token: 0x04006F77 RID: 28535
			[Token(Token = "0x4006F77")]
			[FieldOffset(Offset = "0x30")]
			public uint friend_application;

			// Token: 0x04006F78 RID: 28536
			[Token(Token = "0x4006F78")]
			[FieldOffset(Offset = "0x34")]
			public uint leaderboard;

			// Token: 0x04006F79 RID: 28537
			[Token(Token = "0x4006F79")]
			[FieldOffset(Offset = "0x38")]
			public uint chat;
		}

		// Token: 0x0200120A RID: 4618
		[Token(Token = "0x200120A")]
		public class EventVehicleControlMode : EventLogger.EventLoggerBase
		{
			// Token: 0x06004774 RID: 18292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004774")]
			[Address(RVA = "0x1B94E3C", Offset = "0x1B94E3C", VA = "0x7BBC394E3C")]
			public EventVehicleControlMode()
			{
			}

			// Token: 0x04006F7A RID: 28538
			[Token(Token = "0x4006F7A")]
			[FieldOffset(Offset = "0x20")]
			public uint control_mode;
		}

		// Token: 0x0200120B RID: 4619
		[Token(Token = "0x200120B")]
		public class EventEnterGame : EventLogger.EventLoggerBase
		{
			// Token: 0x06004775 RID: 18293 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004775")]
			[Address(RVA = "0x1B94B08", Offset = "0x1B94B08", VA = "0x7BBC394B08")]
			public EventEnterGame()
			{
			}

			// Token: 0x04006F7B RID: 28539
			[Token(Token = "0x4006F7B")]
			[FieldOffset(Offset = "0x20")]
			public string system_software;

			// Token: 0x04006F7C RID: 28540
			[Token(Token = "0x4006F7C")]
			[FieldOffset(Offset = "0x28")]
			public string system_hardware;

			// Token: 0x04006F7D RID: 28541
			[Token(Token = "0x4006F7D")]
			[FieldOffset(Offset = "0x30")]
			public string dpi;

			// Token: 0x04006F7E RID: 28542
			[Token(Token = "0x4006F7E")]
			[FieldOffset(Offset = "0x38")]
			public string cpu_hardware;

			// Token: 0x04006F7F RID: 28543
			[Token(Token = "0x4006F7F")]
			[FieldOffset(Offset = "0x40")]
			public int memory;

			// Token: 0x04006F80 RID: 28544
			[Token(Token = "0x4006F80")]
			[FieldOffset(Offset = "0x48")]
			public string gl_render;

			// Token: 0x04006F81 RID: 28545
			[Token(Token = "0x4006F81")]
			[FieldOffset(Offset = "0x50")]
			public string gl_version;

			// Token: 0x04006F82 RID: 28546
			[Token(Token = "0x4006F82")]
			[FieldOffset(Offset = "0x58")]
			public string device_model;

			// Token: 0x04006F83 RID: 28547
			[Token(Token = "0x4006F83")]
			[FieldOffset(Offset = "0x60")]
			public ulong match_id;

			// Token: 0x04006F84 RID: 28548
			[Token(Token = "0x4006F84")]
			[FieldOffset(Offset = "0x68")]
			public int is_night_mode;

			// Token: 0x04006F85 RID: 28549
			[Token(Token = "0x4006F85")]
			[FieldOffset(Offset = "0x6C")]
			public uint tick_count;

			// Token: 0x04006F86 RID: 28550
			[Token(Token = "0x4006F86")]
			[FieldOffset(Offset = "0x70")]
			public uint group_mode;

			// Token: 0x04006F87 RID: 28551
			[Token(Token = "0x4006F87")]
			[FieldOffset(Offset = "0x74")]
			public uint time_to_wait;

			// Token: 0x04006F88 RID: 28552
			[Token(Token = "0x4006F88")]
			[FieldOffset(Offset = "0x78")]
			public string lib_path;

			// Token: 0x04006F89 RID: 28553
			[Token(Token = "0x4006F89")]
			[FieldOffset(Offset = "0x80")]
			public uint quality;

			// Token: 0x04006F8A RID: 28554
			[Token(Token = "0x4006F8A")]
			[FieldOffset(Offset = "0x84")]
			public uint game_mode;

			// Token: 0x04006F8B RID: 28555
			[Token(Token = "0x4006F8B")]
			[FieldOffset(Offset = "0x88")]
			public string lib_token;

			// Token: 0x04006F8C RID: 28556
			[Token(Token = "0x4006F8C")]
			[FieldOffset(Offset = "0x90")]
			public uint map_id;

			// Token: 0x04006F8D RID: 28557
			[Token(Token = "0x4006F8D")]
			[FieldOffset(Offset = "0x94")]
			public uint shadow_option;

			// Token: 0x04006F8E RID: 28558
			[Token(Token = "0x4006F8E")]
			[FieldOffset(Offset = "0x98")]
			public uint loading_time;
		}

		// Token: 0x0200120C RID: 4620
		[Token(Token = "0x200120C")]
		public class EventLeaveGame : EventLogger.EventLoggerBase
		{
			// Token: 0x06004776 RID: 18294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004776")]
			[Address(RVA = "0x1B90FC8", Offset = "0x1B90FC8", VA = "0x7BBC390FC8")]
			public EventLeaveGame()
			{
			}

			// Token: 0x04006F8F RID: 28559
			[Token(Token = "0x4006F8F")]
			[FieldOffset(Offset = "0x20")]
			public ulong match_id;

			// Token: 0x04006F90 RID: 28560
			[Token(Token = "0x4006F90")]
			[FieldOffset(Offset = "0x28")]
			public uint tick_count;

			// Token: 0x04006F91 RID: 28561
			[Token(Token = "0x4006F91")]
			[FieldOffset(Offset = "0x30")]
			public string system_software;

			// Token: 0x04006F92 RID: 28562
			[Token(Token = "0x4006F92")]
			[FieldOffset(Offset = "0x38")]
			public string system_hardware;

			// Token: 0x04006F93 RID: 28563
			[Token(Token = "0x4006F93")]
			[FieldOffset(Offset = "0x40")]
			public int screen_width;

			// Token: 0x04006F94 RID: 28564
			[Token(Token = "0x4006F94")]
			[FieldOffset(Offset = "0x44")]
			public int screen_hight;

			// Token: 0x04006F95 RID: 28565
			[Token(Token = "0x4006F95")]
			[FieldOffset(Offset = "0x48")]
			public string dpi;

			// Token: 0x04006F96 RID: 28566
			[Token(Token = "0x4006F96")]
			[FieldOffset(Offset = "0x50")]
			public string cpu_hardware;

			// Token: 0x04006F97 RID: 28567
			[Token(Token = "0x4006F97")]
			[FieldOffset(Offset = "0x58")]
			public int memory;

			// Token: 0x04006F98 RID: 28568
			[Token(Token = "0x4006F98")]
			[FieldOffset(Offset = "0x60")]
			public string gl_render;

			// Token: 0x04006F99 RID: 28569
			[Token(Token = "0x4006F99")]
			[FieldOffset(Offset = "0x68")]
			public string gl_version;

			// Token: 0x04006F9A RID: 28570
			[Token(Token = "0x4006F9A")]
			[FieldOffset(Offset = "0x70")]
			public string device_model;

			// Token: 0x04006F9B RID: 28571
			[Token(Token = "0x4006F9B")]
			[FieldOffset(Offset = "0x78")]
			public int quality;

			// Token: 0x04006F9C RID: 28572
			[Token(Token = "0x4006F9C")]
			[FieldOffset(Offset = "0x7C")]
			public uint map_id;

			// Token: 0x04006F9D RID: 28573
			[Token(Token = "0x4006F9D")]
			[FieldOffset(Offset = "0x80")]
			public uint game_mode;

			// Token: 0x04006F9E RID: 28574
			[Token(Token = "0x4006F9E")]
			[FieldOffset(Offset = "0x84")]
			public uint group_mode;

			// Token: 0x04006F9F RID: 28575
			[Token(Token = "0x4006F9F")]
			[FieldOffset(Offset = "0x88")]
			public uint match_mode;

			// Token: 0x04006FA0 RID: 28576
			[Token(Token = "0x4006FA0")]
			[FieldOffset(Offset = "0x8C")]
			public int fps1;

			// Token: 0x04006FA1 RID: 28577
			[Token(Token = "0x4006FA1")]
			[FieldOffset(Offset = "0x90")]
			public int step1;

			// Token: 0x04006FA2 RID: 28578
			[Token(Token = "0x4006FA2")]
			[FieldOffset(Offset = "0x94")]
			public float fps_devi1;

			// Token: 0x04006FA3 RID: 28579
			[Token(Token = "0x4006FA3")]
			[FieldOffset(Offset = "0x98")]
			public uint fps_data_total_count1;

			// Token: 0x04006FA4 RID: 28580
			[Token(Token = "0x4006FA4")]
			[FieldOffset(Offset = "0x9C")]
			public uint fps_data_b10_count1;

			// Token: 0x04006FA5 RID: 28581
			[Token(Token = "0x4006FA5")]
			[FieldOffset(Offset = "0xA0")]
			public uint fps_data_b20_count1;

			// Token: 0x04006FA6 RID: 28582
			[Token(Token = "0x4006FA6")]
			[FieldOffset(Offset = "0xA4")]
			public int jitter_count1;

			// Token: 0x04006FA7 RID: 28583
			[Token(Token = "0x4006FA7")]
			[FieldOffset(Offset = "0xA8")]
			public int fps2;

			// Token: 0x04006FA8 RID: 28584
			[Token(Token = "0x4006FA8")]
			[FieldOffset(Offset = "0xAC")]
			public int step2;

			// Token: 0x04006FA9 RID: 28585
			[Token(Token = "0x4006FA9")]
			[FieldOffset(Offset = "0xB0")]
			public float fps_devi2;

			// Token: 0x04006FAA RID: 28586
			[Token(Token = "0x4006FAA")]
			[FieldOffset(Offset = "0xB4")]
			public uint fps_data_total_count2;

			// Token: 0x04006FAB RID: 28587
			[Token(Token = "0x4006FAB")]
			[FieldOffset(Offset = "0xB8")]
			public uint fps_data_b10_count2;

			// Token: 0x04006FAC RID: 28588
			[Token(Token = "0x4006FAC")]
			[FieldOffset(Offset = "0xBC")]
			public uint fps_data_b20_count2;

			// Token: 0x04006FAD RID: 28589
			[Token(Token = "0x4006FAD")]
			[FieldOffset(Offset = "0xC0")]
			public int jitter_count2;

			// Token: 0x04006FAE RID: 28590
			[Token(Token = "0x4006FAE")]
			[FieldOffset(Offset = "0xC4")]
			public int ping;

			// Token: 0x04006FAF RID: 28591
			[Token(Token = "0x4006FAF")]
			[FieldOffset(Offset = "0xC8")]
			public int maxping;

			// Token: 0x04006FB0 RID: 28592
			[Token(Token = "0x4006FB0")]
			[FieldOffset(Offset = "0xCC")]
			public int ping_total;

			// Token: 0x04006FB1 RID: 28593
			[Token(Token = "0x4006FB1")]
			[FieldOffset(Offset = "0xD0")]
			public int ping_b500;

			// Token: 0x04006FB2 RID: 28594
			[Token(Token = "0x4006FB2")]
			[FieldOffset(Offset = "0xD4")]
			public int ping_a500;

			// Token: 0x04006FB3 RID: 28595
			[Token(Token = "0x4006FB3")]
			[FieldOffset(Offset = "0xD8")]
			public int ping100200;

			// Token: 0x04006FB4 RID: 28596
			[Token(Token = "0x4006FB4")]
			[FieldOffset(Offset = "0xDC")]
			public int ping200300;

			// Token: 0x04006FB5 RID: 28597
			[Token(Token = "0x4006FB5")]
			[FieldOffset(Offset = "0xE0")]
			public int ping300400;

			// Token: 0x04006FB6 RID: 28598
			[Token(Token = "0x4006FB6")]
			[FieldOffset(Offset = "0xE4")]
			public int ping400500;

			// Token: 0x04006FB7 RID: 28599
			[Token(Token = "0x4006FB7")]
			[FieldOffset(Offset = "0xE8")]
			public string gameserver_ip;

			// Token: 0x04006FB8 RID: 28600
			[Token(Token = "0x4006FB8")]
			[FieldOffset(Offset = "0xF0")]
			public string phone_carrier;

			// Token: 0x04006FB9 RID: 28601
			[Token(Token = "0x4006FB9")]
			[FieldOffset(Offset = "0xF8")]
			public string country;

			// Token: 0x04006FBA RID: 28602
			[Token(Token = "0x4006FBA")]
			[FieldOffset(Offset = "0x100")]
			public ulong packet_sent;

			// Token: 0x04006FBB RID: 28603
			[Token(Token = "0x4006FBB")]
			[FieldOffset(Offset = "0x108")]
			public ulong rudp_packet_sent;

			// Token: 0x04006FBC RID: 28604
			[Token(Token = "0x4006FBC")]
			[FieldOffset(Offset = "0x110")]
			public ulong rudp_packet_resent;

			// Token: 0x04006FBD RID: 28605
			[Token(Token = "0x4006FBD")]
			[FieldOffset(Offset = "0x118")]
			public int enter_pvp_memory;

			// Token: 0x04006FBE RID: 28606
			[Token(Token = "0x4006FBE")]
			[FieldOffset(Offset = "0x11C")]
			public int leave_pvp_memory;

			// Token: 0x04006FBF RID: 28607
			[Token(Token = "0x4006FBF")]
			[FieldOffset(Offset = "0x120")]
			public int enter_pvp_avail_memory;

			// Token: 0x04006FC0 RID: 28608
			[Token(Token = "0x4006FC0")]
			[FieldOffset(Offset = "0x124")]
			public int leave_pvp_avail_memory;

			// Token: 0x04006FC1 RID: 28609
			[Token(Token = "0x4006FC1")]
			[FieldOffset(Offset = "0x128")]
			public int low_memory_threshold;

			// Token: 0x04006FC2 RID: 28610
			[Token(Token = "0x4006FC2")]
			[FieldOffset(Offset = "0x12C")]
			public int max_avail_memory;

			// Token: 0x04006FC3 RID: 28611
			[Token(Token = "0x4006FC3")]
			[FieldOffset(Offset = "0x130")]
			public int min_avail_memory;

			// Token: 0x04006FC4 RID: 28612
			[Token(Token = "0x4006FC4")]
			[FieldOffset(Offset = "0x134")]
			public int unload_unused_count;

			// Token: 0x04006FC5 RID: 28613
			[Token(Token = "0x4006FC5")]
			[FieldOffset(Offset = "0x138")]
			public float enter_battery;

			// Token: 0x04006FC6 RID: 28614
			[Token(Token = "0x4006FC6")]
			[FieldOffset(Offset = "0x13C")]
			public float leave_battery;

			// Token: 0x04006FC7 RID: 28615
			[Token(Token = "0x4006FC7")]
			[FieldOffset(Offset = "0x140")]
			public bool is_charge;

			// Token: 0x04006FC8 RID: 28616
			[Token(Token = "0x4006FC8")]
			[FieldOffset(Offset = "0x144")]
			public uint resource_load_count;

			// Token: 0x04006FC9 RID: 28617
			[Token(Token = "0x4006FC9")]
			[FieldOffset(Offset = "0x148")]
			public uint game_time;

			// Token: 0x04006FCA RID: 28618
			[Token(Token = "0x4006FCA")]
			[FieldOffset(Offset = "0x14C")]
			public int global_fps;

			// Token: 0x04006FCB RID: 28619
			[Token(Token = "0x4006FCB")]
			[FieldOffset(Offset = "0x150")]
			public int trigger_near_count;

			// Token: 0x04006FCC RID: 28620
			[Token(Token = "0x4006FCC")]
			[FieldOffset(Offset = "0x154")]
			public int trigger_far_count;

			// Token: 0x04006FCD RID: 28621
			[Token(Token = "0x4006FCD")]
			[FieldOffset(Offset = "0x158")]
			public List<uint> trigger_id_list;

			// Token: 0x04006FCE RID: 28622
			[Token(Token = "0x4006FCE")]
			[FieldOffset(Offset = "0x160")]
			public int pet_id;

			// Token: 0x04006FCF RID: 28623
			[Token(Token = "0x4006FCF")]
			[FieldOffset(Offset = "0x164")]
			public uint pet_click_cnt;

			// Token: 0x04006FD0 RID: 28624
			[Token(Token = "0x4006FD0")]
			[FieldOffset(Offset = "0x168")]
			public uint shadow_option;

			// Token: 0x04006FD1 RID: 28625
			[Token(Token = "0x4006FD1")]
			[FieldOffset(Offset = "0x16C")]
			public uint loading_time;
		}

		// Token: 0x0200120D RID: 4621
		[Token(Token = "0x200120D")]
		public class EventBRDeadInfo : EventLogger.EventLoggerBase
		{
			// Token: 0x06004777 RID: 18295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004777")]
			[Address(RVA = "0x1B94B30", Offset = "0x1B94B30", VA = "0x7BBC394B30")]
			public EventBRDeadInfo()
			{
			}

			// Token: 0x04006FD2 RID: 28626
			[Token(Token = "0x4006FD2")]
			[FieldOffset(Offset = "0x20")]
			public ulong match_id;

			// Token: 0x04006FD3 RID: 28627
			[Token(Token = "0x4006FD3")]
			[FieldOffset(Offset = "0x28")]
			public int quality;

			// Token: 0x04006FD4 RID: 28628
			[Token(Token = "0x4006FD4")]
			[FieldOffset(Offset = "0x2C")]
			public uint map_id;

			// Token: 0x04006FD5 RID: 28629
			[Token(Token = "0x4006FD5")]
			[FieldOffset(Offset = "0x30")]
			public uint game_mode;

			// Token: 0x04006FD6 RID: 28630
			[Token(Token = "0x4006FD6")]
			[FieldOffset(Offset = "0x34")]
			public uint group_mode;

			// Token: 0x04006FD7 RID: 28631
			[Token(Token = "0x4006FD7")]
			[FieldOffset(Offset = "0x38")]
			public uint match_mode;

			// Token: 0x04006FD8 RID: 28632
			[Token(Token = "0x4006FD8")]
			[FieldOffset(Offset = "0x3C")]
			public int dead_reason;
		}

		// Token: 0x0200120E RID: 4622
		[Token(Token = "0x200120E")]
		public class EventHighFPSSwitch : EventLogger.EventLoggerBase
		{
			// Token: 0x06004778 RID: 18296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004778")]
			[Address(RVA = "0x1B91098", Offset = "0x1B91098", VA = "0x7BBC391098")]
			public EventHighFPSSwitch()
			{
			}

			// Token: 0x04006FD9 RID: 28633
			[Token(Token = "0x4006FD9")]
			[FieldOffset(Offset = "0x20")]
			public string device_model;

			// Token: 0x04006FDA RID: 28634
			[Token(Token = "0x4006FDA")]
			[FieldOffset(Offset = "0x28")]
			public bool switch_highfps;
		}

		// Token: 0x0200120F RID: 4623
		[Token(Token = "0x200120F")]
		public class EventOptionalDownloadComplete : EventLogger.EventLoggerBase
		{
			// Token: 0x06004779 RID: 18297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004779")]
			[Address(RVA = "0x1B911E0", Offset = "0x1B911E0", VA = "0x7BBC3911E0")]
			public EventOptionalDownloadComplete()
			{
			}

			// Token: 0x04006FDB RID: 28635
			[Token(Token = "0x4006FDB")]
			[FieldOffset(Offset = "0x20")]
			public string optional_version;

			// Token: 0x04006FDC RID: 28636
			[Token(Token = "0x4006FDC")]
			[FieldOffset(Offset = "0x28")]
			public int download_type;

			// Token: 0x04006FDD RID: 28637
			[Token(Token = "0x4006FDD")]
			[FieldOffset(Offset = "0x30")]
			public string complete_result;

			// Token: 0x04006FDE RID: 28638
			[Token(Token = "0x4006FDE")]
			[FieldOffset(Offset = "0x38")]
			public string package_name;
		}

		// Token: 0x02001210 RID: 4624
		[Token(Token = "0x2001210")]
		public class EventOptionalDownloadOperation : EventLogger.EventLoggerBase
		{
			// Token: 0x0600477A RID: 18298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600477A")]
			[Address(RVA = "0x1B9144C", Offset = "0x1B9144C", VA = "0x7BBC39144C")]
			public EventOptionalDownloadOperation()
			{
			}

			// Token: 0x04006FDF RID: 28639
			[Token(Token = "0x4006FDF")]
			[FieldOffset(Offset = "0x20")]
			public string optional_version;

			// Token: 0x04006FE0 RID: 28640
			[Token(Token = "0x4006FE0")]
			[FieldOffset(Offset = "0x28")]
			public int download_type;

			// Token: 0x04006FE1 RID: 28641
			[Token(Token = "0x4006FE1")]
			[FieldOffset(Offset = "0x30")]
			public string complete_result;

			// Token: 0x04006FE2 RID: 28642
			[Token(Token = "0x4006FE2")]
			[FieldOffset(Offset = "0x38")]
			public string package_name;

			// Token: 0x04006FE3 RID: 28643
			[Token(Token = "0x4006FE3")]
			[FieldOffset(Offset = "0x40")]
			public uint operation;
		}

		// Token: 0x02001211 RID: 4625
		[Token(Token = "0x2001211")]
		public class EventClickGetAvatarBtn : EventLogger.EventLoggerBase
		{
			// Token: 0x0600477B RID: 18299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600477B")]
			[Address(RVA = "0x1B92374", Offset = "0x1B92374", VA = "0x7BBC392374")]
			public EventClickGetAvatarBtn()
			{
			}

			// Token: 0x04006FE4 RID: 28644
			[Token(Token = "0x4006FE4")]
			[FieldOffset(Offset = "0x20")]
			public uint avatar_id;

			// Token: 0x04006FE5 RID: 28645
			[Token(Token = "0x4006FE5")]
			[FieldOffset(Offset = "0x24")]
			public uint get_times;

			// Token: 0x04006FE6 RID: 28646
			[Token(Token = "0x4006FE6")]
			[FieldOffset(Offset = "0x28")]
			public uint bundle_times;
		}

		// Token: 0x02001212 RID: 4626
		[Token(Token = "0x2001212")]
		public class EventRewardedVideoLoadLog : EventLogger.EventLoggerBase
		{
			// Token: 0x0600477C RID: 18300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600477C")]
			[Address(RVA = "0x1B94DDC", Offset = "0x1B94DDC", VA = "0x7BBC394DDC")]
			public EventRewardedVideoLoadLog()
			{
			}

			// Token: 0x04006FE7 RID: 28647
			[Token(Token = "0x4006FE7")]
			[FieldOffset(Offset = "0x20")]
			public uint success;

			// Token: 0x04006FE8 RID: 28648
			[Token(Token = "0x4006FE8")]
			[FieldOffset(Offset = "0x24")]
			public uint failure;
		}

		// Token: 0x02001213 RID: 4627
		[Token(Token = "0x2001213")]
		[Serializable]
		public class EventMallTabClickCount : EventLogger.EventLoggerBase
		{
			// Token: 0x0600477D RID: 18301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600477D")]
			[Address(RVA = "0x1B91FB4", Offset = "0x1B91FB4", VA = "0x7BBC391FB4")]
			public EventMallTabClickCount()
			{
			}

			// Token: 0x04006FE9 RID: 28649
			[Token(Token = "0x4006FE9")]
			[FieldOffset(Offset = "0x20")]
			public List<EventLogger.EventMallTabClickInfo> mall_tab_click_result;
		}

		// Token: 0x02001214 RID: 4628
		[Token(Token = "0x2001214")]
		public class EventVideoWatchTime : EventLogger.EventLoggerBase
		{
			// Token: 0x0600477E RID: 18302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600477E")]
			[Address(RVA = "0x1B94E44", Offset = "0x1B94E44", VA = "0x7BBC394E44")]
			public EventVideoWatchTime()
			{
			}

			// Token: 0x04006FEA RID: 28650
			[Token(Token = "0x4006FEA")]
			[FieldOffset(Offset = "0x20")]
			public ulong watch_time;
		}

		// Token: 0x02001215 RID: 4629
		[Token(Token = "0x2001215")]
		public class EventMallTabClickInfo
		{
			// Token: 0x0600477F RID: 18303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600477F")]
			[Address(RVA = "0x1B91FBC", Offset = "0x1B91FBC", VA = "0x7BBC391FBC")]
			public EventMallTabClickInfo(uint mallType, string name, uint cnt)
			{
			}

			// Token: 0x04006FEB RID: 28651
			[Token(Token = "0x4006FEB")]
			[FieldOffset(Offset = "0x10")]
			public uint mall_type;

			// Token: 0x04006FEC RID: 28652
			[Token(Token = "0x4006FEC")]
			[FieldOffset(Offset = "0x18")]
			public string tab_name;

			// Token: 0x04006FED RID: 28653
			[Token(Token = "0x4006FED")]
			[FieldOffset(Offset = "0x20")]
			public uint count;
		}

		// Token: 0x02001216 RID: 4630
		[Token(Token = "0x2001216")]
		public class EventInstallmentClickCount : EventLogger.EventLoggerBase
		{
			// Token: 0x06004780 RID: 18304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004780")]
			[Address(RVA = "0x1B92190", Offset = "0x1B92190", VA = "0x7BBC392190")]
			public EventInstallmentClickCount()
			{
			}

			// Token: 0x04006FEE RID: 28654
			[Token(Token = "0x4006FEE")]
			[FieldOffset(Offset = "0x20")]
			public uint mall_clicks;

			// Token: 0x04006FEF RID: 28655
			[Token(Token = "0x4006FEF")]
			[FieldOffset(Offset = "0x24")]
			public uint inventory_clicks;

			// Token: 0x04006FF0 RID: 28656
			[Token(Token = "0x4006FF0")]
			[FieldOffset(Offset = "0x28")]
			public uint tutorial_clicks;
		}

		// Token: 0x02001217 RID: 4631
		[Token(Token = "0x2001217")]
		public class EventBackMallCount : EventLogger.EventLoggerBase
		{
			// Token: 0x06004781 RID: 18305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004781")]
			[Address(RVA = "0x1B92290", Offset = "0x1B92290", VA = "0x7BBC392290")]
			public EventBackMallCount()
			{
			}

			// Token: 0x04006FF1 RID: 28657
			[Token(Token = "0x4006FF1")]
			[FieldOffset(Offset = "0x20")]
			public uint back_mall_count;
		}

		// Token: 0x02001218 RID: 4632
		[Token(Token = "0x2001218")]
		public class EventMallItemClickCount : EventLogger.EventLoggerBase
		{
			// Token: 0x06004782 RID: 18306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004782")]
			[Address(RVA = "0x1B94D28", Offset = "0x1B94D28", VA = "0x7BBC394D28")]
			public EventMallItemClickCount()
			{
			}

			// Token: 0x04006FF2 RID: 28658
			[Token(Token = "0x4006FF2")]
			[FieldOffset(Offset = "0x20")]
			public List<EventLogger.EventMallItemClickInfo> clicks;
		}

		// Token: 0x02001219 RID: 4633
		[Token(Token = "0x2001219")]
		public class EventBooyahClickEquip : EventLogger.EventLoggerBase
		{
			// Token: 0x06004783 RID: 18307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004783")]
			[Address(RVA = "0x1B94CD8", Offset = "0x1B94CD8", VA = "0x7BBC394CD8")]
			public EventBooyahClickEquip()
			{
			}

			// Token: 0x04006FF3 RID: 28659
			[Token(Token = "0x4006FF3")]
			[FieldOffset(Offset = "0x20")]
			public uint after_emote_id;

			// Token: 0x04006FF4 RID: 28660
			[Token(Token = "0x4006FF4")]
			[FieldOffset(Offset = "0x24")]
			public uint before_emote_id;
		}

		// Token: 0x0200121A RID: 4634
		[Token(Token = "0x200121A")]
		public class EventBooyahEmotePlay : EventLogger.EventLoggerBase
		{
			// Token: 0x06004784 RID: 18308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004784")]
			[Address(RVA = "0x1B94CE0", Offset = "0x1B94CE0", VA = "0x7BBC394CE0")]
			public EventBooyahEmotePlay()
			{
			}

			// Token: 0x04006FF5 RID: 28661
			[Token(Token = "0x4006FF5")]
			[FieldOffset(Offset = "0x20")]
			public uint emote_id;

			// Token: 0x04006FF6 RID: 28662
			[Token(Token = "0x4006FF6")]
			[FieldOffset(Offset = "0x24")]
			public uint play_num;
		}

		// Token: 0x0200121B RID: 4635
		[Token(Token = "0x200121B")]
		public class EventMallItemClickInfo
		{
			// Token: 0x06004785 RID: 18309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004785")]
			[Address(RVA = "0x1B94D30", Offset = "0x1B94D30", VA = "0x7BBC394D30")]
			public EventMallItemClickInfo(uint shop, uint tab1, uint tab2, uint item_id, uint cnt)
			{
			}

			// Token: 0x04006FF7 RID: 28663
			[Token(Token = "0x4006FF7")]
			[FieldOffset(Offset = "0x10")]
			public uint shop;

			// Token: 0x04006FF8 RID: 28664
			[Token(Token = "0x4006FF8")]
			[FieldOffset(Offset = "0x14")]
			public uint tab1;

			// Token: 0x04006FF9 RID: 28665
			[Token(Token = "0x4006FF9")]
			[FieldOffset(Offset = "0x18")]
			public uint tab2;

			// Token: 0x04006FFA RID: 28666
			[Token(Token = "0x4006FFA")]
			[FieldOffset(Offset = "0x1C")]
			public uint item_id;

			// Token: 0x04006FFB RID: 28667
			[Token(Token = "0x4006FFB")]
			[FieldOffset(Offset = "0x20")]
			public uint cnt;
		}

		// Token: 0x0200121C RID: 4636
		[Token(Token = "0x200121C")]
		public class EventChampionshipClickCount : EventLogger.EventLoggerBase
		{
			// Token: 0x06004786 RID: 18310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004786")]
			[Address(RVA = "0x1B8EE64", Offset = "0x1B8EE64", VA = "0x7BBC38EE64")]
			public EventChampionshipClickCount()
			{
			}

			// Token: 0x04006FFC RID: 28668
			[Token(Token = "0x4006FFC")]
			[FieldOffset(Offset = "0x20")]
			public uint championshipType;

			// Token: 0x04006FFD RID: 28669
			[Token(Token = "0x4006FFD")]
			[FieldOffset(Offset = "0x24")]
			public uint championshipID;

			// Token: 0x04006FFE RID: 28670
			[Token(Token = "0x4006FFE")]
			[FieldOffset(Offset = "0x28")]
			public uint teamClick;

			// Token: 0x04006FFF RID: 28671
			[Token(Token = "0x4006FFF")]
			[FieldOffset(Offset = "0x2C")]
			public uint entranceClick;
		}

		// Token: 0x0200121D RID: 4637
		[Token(Token = "0x200121D")]
		public class EventBackBTNLowerLeftClick : EventLogger.EventLoggerBase
		{
			// Token: 0x06004787 RID: 18311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004787")]
			[Address(RVA = "0x1B91288", Offset = "0x1B91288", VA = "0x7BBC391288")]
			public EventBackBTNLowerLeftClick()
			{
			}

			// Token: 0x04007000 RID: 28672
			[Token(Token = "0x4007000")]
			[FieldOffset(Offset = "0x20")]
			public bool is_lower_left;
		}

		// Token: 0x0200121E RID: 4638
		[Token(Token = "0x200121E")]
		public class EventRejectGroupInvite : EventLogger.EventLoggerBase
		{
			// Token: 0x06004788 RID: 18312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004788")]
			[Address(RVA = "0x1B94DBC", Offset = "0x1B94DBC", VA = "0x7BBC394DBC")]
			public EventRejectGroupInvite()
			{
			}

			// Token: 0x04007001 RID: 28673
			[Token(Token = "0x4007001")]
			[FieldOffset(Offset = "0x20")]
			public ulong inviter_id;

			// Token: 0x04007002 RID: 28674
			[Token(Token = "0x4007002")]
			[FieldOffset(Offset = "0x28")]
			public ulong group_id;

			// Token: 0x04007003 RID: 28675
			[Token(Token = "0x4007003")]
			[FieldOffset(Offset = "0x30")]
			public uint match_mode;

			// Token: 0x04007004 RID: 28676
			[Token(Token = "0x4007004")]
			[FieldOffset(Offset = "0x34")]
			public uint game_mode;

			// Token: 0x04007005 RID: 28677
			[Token(Token = "0x4007005")]
			[FieldOffset(Offset = "0x38")]
			public uint group_mode;

			// Token: 0x04007006 RID: 28678
			[Token(Token = "0x4007006")]
			[FieldOffset(Offset = "0x40")]
			public uint[] map_ids;
		}

		// Token: 0x0200121F RID: 4639
		[Token(Token = "0x200121F")]
		public class EventRejectJoinGroup : EventLogger.EventLoggerBase
		{
			// Token: 0x06004789 RID: 18313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004789")]
			[Address(RVA = "0x1B94DC4", Offset = "0x1B94DC4", VA = "0x7BBC394DC4")]
			public EventRejectJoinGroup()
			{
			}

			// Token: 0x04007007 RID: 28679
			[Token(Token = "0x4007007")]
			[FieldOffset(Offset = "0x20")]
			public ulong applier_id;

			// Token: 0x04007008 RID: 28680
			[Token(Token = "0x4007008")]
			[FieldOffset(Offset = "0x28")]
			public ulong group_id;

			// Token: 0x04007009 RID: 28681
			[Token(Token = "0x4007009")]
			[FieldOffset(Offset = "0x30")]
			public uint match_mode;

			// Token: 0x0400700A RID: 28682
			[Token(Token = "0x400700A")]
			[FieldOffset(Offset = "0x34")]
			public uint game_mode;

			// Token: 0x0400700B RID: 28683
			[Token(Token = "0x400700B")]
			[FieldOffset(Offset = "0x38")]
			public uint group_mode;

			// Token: 0x0400700C RID: 28684
			[Token(Token = "0x400700C")]
			[FieldOffset(Offset = "0x40")]
			public uint[] map_ids;

			// Token: 0x0400700D RID: 28685
			[Token(Token = "0x400700D")]
			[FieldOffset(Offset = "0x48")]
			public uint group_type;

			// Token: 0x0400700E RID: 28686
			[Token(Token = "0x400700E")]
			[FieldOffset(Offset = "0x4C")]
			public uint group_size;
		}

		// Token: 0x02001220 RID: 4640
		[Token(Token = "0x2001220")]
		public class EventNotiWindowReplaced : EventLogger.EventLoggerBase
		{
			// Token: 0x0600478A RID: 18314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600478A")]
			[Address(RVA = "0x1B94D94", Offset = "0x1B94D94", VA = "0x7BBC394D94")]
			public EventNotiWindowReplaced()
			{
			}

			// Token: 0x0400700F RID: 28687
			[Token(Token = "0x400700F")]
			[FieldOffset(Offset = "0x20")]
			public uint old_window_content;

			// Token: 0x04007010 RID: 28688
			[Token(Token = "0x4007010")]
			[FieldOffset(Offset = "0x28")]
			public ulong old_window_exists_time;

			// Token: 0x04007011 RID: 28689
			[Token(Token = "0x4007011")]
			[FieldOffset(Offset = "0x30")]
			public uint new_window_content;
		}

		// Token: 0x02001221 RID: 4641
		[Token(Token = "0x2001221")]
		public class EventSystemScreenShot : EventLogger.EventLoggerBase
		{
			// Token: 0x0600478B RID: 18315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600478B")]
			[Address(RVA = "0x1B944FC", Offset = "0x1B944FC", VA = "0x7BBC3944FC")]
			public EventSystemScreenShot()
			{
			}

			// Token: 0x04007012 RID: 28690
			[Token(Token = "0x4007012")]
			[FieldOffset(Offset = "0x20")]
			public List<string> tags;
		}

		// Token: 0x02001222 RID: 4642
		[Token(Token = "0x2001222")]
		public enum EventLogScene
		{
			// Token: 0x04007014 RID: 28692
			[Token(Token = "0x4007014")]
			None,
			// Token: 0x04007015 RID: 28693
			[Token(Token = "0x4007015")]
			Login,
			// Token: 0x04007016 RID: 28694
			[Token(Token = "0x4007016")]
			Lobby,
			// Token: 0x04007017 RID: 28695
			[Token(Token = "0x4007017")]
			MatchStart,
			// Token: 0x04007018 RID: 28696
			[Token(Token = "0x4007018")]
			InGame,
			// Token: 0x04007019 RID: 28697
			[Token(Token = "0x4007019")]
			MatchEnd
		}

		// Token: 0x02001223 RID: 4643
		[Token(Token = "0x2001223")]
		public enum EventBroadCastType
		{
			// Token: 0x0400701B RID: 28699
			[Token(Token = "0x400701B")]
			None,
			// Token: 0x0400701C RID: 28700
			[Token(Token = "0x400701C")]
			Friends,
			// Token: 0x0400701D RID: 28701
			[Token(Token = "0x400701D")]
			LoudSpeaker,
			// Token: 0x0400701E RID: 28702
			[Token(Token = "0x400701E")]
			Gacha,
			// Token: 0x0400701F RID: 28703
			[Token(Token = "0x400701F")]
			EP,
			// Token: 0x04007020 RID: 28704
			[Token(Token = "0x4007020")]
			InGameDrop
		}

		// Token: 0x02001224 RID: 4644
		[Token(Token = "0x2001224")]
		public class EventMTP : EventLogger.EventLoggerBase
		{
			// Token: 0x0600478C RID: 18316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600478C")]
			[Address(RVA = "0x1B94D20", Offset = "0x1B94D20", VA = "0x7BBC394D20")]
			public EventMTP()
			{
			}

			// Token: 0x04007021 RID: 28705
			[Token(Token = "0x4007021")]
			[FieldOffset(Offset = "0x20")]
			public uint tickCount;

			// Token: 0x04007022 RID: 28706
			[Token(Token = "0x4007022")]
			[FieldOffset(Offset = "0x28")]
			public string info;

			// Token: 0x04007023 RID: 28707
			[Token(Token = "0x4007023")]
			[FieldOffset(Offset = "0x30")]
			public int scene;
		}

		// Token: 0x02001225 RID: 4645
		[Token(Token = "0x2001225")]
		public class EventIngameTips : EventLogger.EventLoggerBase
		{
			// Token: 0x0600478D RID: 18317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600478D")]
			[Address(RVA = "0x1B94B20", Offset = "0x1B94B20", VA = "0x7BBC394B20")]
			public EventIngameTips()
			{
			}

			// Token: 0x04007024 RID: 28708
			[Token(Token = "0x4007024")]
			[FieldOffset(Offset = "0x20")]
			public uint value;
		}

		// Token: 0x02001226 RID: 4646
		[Token(Token = "0x2001226")]
		public class EventEnterWaitingIsland : EventLogger.EventEnterGame
		{
			// Token: 0x0600478E RID: 18318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600478E")]
			[Address(RVA = "0x1B94B10", Offset = "0x1B94B10", VA = "0x7BBC394B10")]
			public EventEnterWaitingIsland()
			{
			}
		}

		// Token: 0x02001227 RID: 4647
		[Token(Token = "0x2001227")]
		public class EventLeaveWaitingIsland : EventLogger.EventLoggerBase
		{
			// Token: 0x0600478F RID: 18319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600478F")]
			[Address(RVA = "0x1B94B18", Offset = "0x1B94B18", VA = "0x7BBC394B18")]
			public EventLeaveWaitingIsland()
			{
			}

			// Token: 0x04007025 RID: 28709
			[Token(Token = "0x4007025")]
			[FieldOffset(Offset = "0x20")]
			public ulong match_id;

			// Token: 0x04007026 RID: 28710
			[Token(Token = "0x4007026")]
			[FieldOffset(Offset = "0x28")]
			public uint tick_count;

			// Token: 0x04007027 RID: 28711
			[Token(Token = "0x4007027")]
			[FieldOffset(Offset = "0x2C")]
			public uint quality;

			// Token: 0x04007028 RID: 28712
			[Token(Token = "0x4007028")]
			[FieldOffset(Offset = "0x30")]
			public float enter_battery;

			// Token: 0x04007029 RID: 28713
			[Token(Token = "0x4007029")]
			[FieldOffset(Offset = "0x34")]
			public float leave_battery;

			// Token: 0x0400702A RID: 28714
			[Token(Token = "0x400702A")]
			[FieldOffset(Offset = "0x38")]
			public bool is_charge;

			// Token: 0x0400702B RID: 28715
			[Token(Token = "0x400702B")]
			[FieldOffset(Offset = "0x39")]
			public bool is_battle_started;

			// Token: 0x0400702C RID: 28716
			[Token(Token = "0x400702C")]
			[FieldOffset(Offset = "0x3C")]
			public uint resource_load_count;

			// Token: 0x0400702D RID: 28717
			[Token(Token = "0x400702D")]
			[FieldOffset(Offset = "0x40")]
			public uint game_time;

			// Token: 0x0400702E RID: 28718
			[Token(Token = "0x400702E")]
			[FieldOffset(Offset = "0x44")]
			public uint group_mode;

			// Token: 0x0400702F RID: 28719
			[Token(Token = "0x400702F")]
			[FieldOffset(Offset = "0x48")]
			public int ping;

			// Token: 0x04007030 RID: 28720
			[Token(Token = "0x4007030")]
			[FieldOffset(Offset = "0x4C")]
			public int maxping;

			// Token: 0x04007031 RID: 28721
			[Token(Token = "0x4007031")]
			[FieldOffset(Offset = "0x50")]
			public int ping_total;

			// Token: 0x04007032 RID: 28722
			[Token(Token = "0x4007032")]
			[FieldOffset(Offset = "0x54")]
			public int ping_b500;

			// Token: 0x04007033 RID: 28723
			[Token(Token = "0x4007033")]
			[FieldOffset(Offset = "0x58")]
			public int ping_a500;

			// Token: 0x04007034 RID: 28724
			[Token(Token = "0x4007034")]
			[FieldOffset(Offset = "0x5C")]
			public int ping100200;

			// Token: 0x04007035 RID: 28725
			[Token(Token = "0x4007035")]
			[FieldOffset(Offset = "0x60")]
			public int ping200300;

			// Token: 0x04007036 RID: 28726
			[Token(Token = "0x4007036")]
			[FieldOffset(Offset = "0x64")]
			public int ping300400;

			// Token: 0x04007037 RID: 28727
			[Token(Token = "0x4007037")]
			[FieldOffset(Offset = "0x68")]
			public int ping400500;

			// Token: 0x04007038 RID: 28728
			[Token(Token = "0x4007038")]
			[FieldOffset(Offset = "0x70")]
			public string client_ip;

			// Token: 0x04007039 RID: 28729
			[Token(Token = "0x4007039")]
			[FieldOffset(Offset = "0x78")]
			public string country;

			// Token: 0x0400703A RID: 28730
			[Token(Token = "0x400703A")]
			[FieldOffset(Offset = "0x80")]
			public string gameserver_ip;
		}

		// Token: 0x02001228 RID: 4648
		[Token(Token = "0x2001228")]
		public class IngameEnterGameData
		{
			// Token: 0x06004790 RID: 18320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004790")]
			[Address(RVA = "0x1B94B28", Offset = "0x1B94B28", VA = "0x7BBC394B28")]
			public IngameEnterGameData()
			{
			}

			// Token: 0x0400703B RID: 28731
			[Token(Token = "0x400703B")]
			[FieldOffset(Offset = "0x10")]
			public int frameCount;

			// Token: 0x0400703C RID: 28732
			[Token(Token = "0x400703C")]
			[FieldOffset(Offset = "0x14")]
			public float time;
		}

		// Token: 0x02001229 RID: 4649
		[Token(Token = "0x2001229")]
		public class EventTrainingLocalGame : EventLogger.EventLoggerBase
		{
			// Token: 0x06004791 RID: 18321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004791")]
			[Address(RVA = "0x1B93D60", Offset = "0x1B93D60", VA = "0x7BBC393D60")]
			public EventTrainingLocalGame()
			{
			}

			// Token: 0x0400703D RID: 28733
			[Token(Token = "0x400703D")]
			[FieldOffset(Offset = "0x20")]
			public uint shooting_game_play_time;

			// Token: 0x0400703E RID: 28734
			[Token(Token = "0x400703E")]
			[FieldOffset(Offset = "0x24")]
			public uint ttl_game_play_time;

			// Token: 0x0400703F RID: 28735
			[Token(Token = "0x400703F")]
			[FieldOffset(Offset = "0x28")]
			public uint boxing_game_play_time;

			// Token: 0x04007040 RID: 28736
			[Token(Token = "0x4007040")]
			[FieldOffset(Offset = "0x2C")]
			public uint vehicle_speed_game_play_time;

			// Token: 0x04007041 RID: 28737
			[Token(Token = "0x4007041")]
			[FieldOffset(Offset = "0x30")]
			public uint ice_wall_game_play_time;

			// Token: 0x04007042 RID: 28738
			[Token(Token = "0x4007042")]
			[FieldOffset(Offset = "0x34")]
			public uint ferris_wheel_use_time;

			// Token: 0x04007043 RID: 28739
			[Token(Token = "0x4007043")]
			[FieldOffset(Offset = "0x38")]
			public uint take_photo_time;

			// Token: 0x04007044 RID: 28740
			[Token(Token = "0x4007044")]
			[FieldOffset(Offset = "0x3C")]
			public uint game_result_share_time;
		}

		// Token: 0x0200122A RID: 4650
		[Token(Token = "0x200122A")]
		public class EventWereWolvesGame : EventLogger.EventLoggerBase
		{
			// Token: 0x06004792 RID: 18322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004792")]
			[Address(RVA = "0x1B93EDC", Offset = "0x1B93EDC", VA = "0x7BBC393EDC")]
			public EventWereWolvesGame()
			{
			}

			// Token: 0x04007045 RID: 28741
			[Token(Token = "0x4007045")]
			[FieldOffset(Offset = "0x20")]
			public ulong match_id;

			// Token: 0x04007046 RID: 28742
			[Token(Token = "0x4007046")]
			[FieldOffset(Offset = "0x28")]
			public uint mic_count;
		}

		// Token: 0x0200122B RID: 4651
		[Token(Token = "0x200122B")]
		public enum EGameTimeType
		{
			// Token: 0x04007048 RID: 28744
			[Token(Token = "0x4007048")]
			EnterPVP,
			// Token: 0x04007049 RID: 28745
			[Token(Token = "0x4007049")]
			LeavePVP
		}

		// Token: 0x0200122C RID: 4652
		[Token(Token = "0x200122C")]
		public enum EDisconnectionType
		{
			// Token: 0x0400704B RID: 28747
			[Token(Token = "0x400704B")]
			TCP,
			// Token: 0x0400704C RID: 28748
			[Token(Token = "0x400704C")]
			UDP_ENTER,
			// Token: 0x0400704D RID: 28749
			[Token(Token = "0x400704D")]
			UDP_INGAME
		}

		// Token: 0x0200122D RID: 4653
		[Token(Token = "0x200122D")]
		public enum BuildVariantType
		{
			// Token: 0x0400704F RID: 28751
			[Token(Token = "0x400704F")]
			Normal,
			// Token: 0x04007050 RID: 28752
			[Token(Token = "0x4007050")]
			Max
		}

		// Token: 0x0200122E RID: 4654
		[Token(Token = "0x200122E")]
		public class EventLoginInfo
		{
			// Token: 0x06004793 RID: 18323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004793")]
			[Address(RVA = "0x1B8D0DC", Offset = "0x1B8D0DC", VA = "0x7BBC38D0DC")]
			public EventLoginInfo()
			{
			}

			// Token: 0x04007051 RID: 28753
			[Token(Token = "0x4007051")]
			[FieldOffset(Offset = "0x10")]
			public ulong account_id;

			// Token: 0x04007052 RID: 28754
			[Token(Token = "0x4007052")]
			[FieldOffset(Offset = "0x18")]
			public string game_server_id;

			// Token: 0x04007053 RID: 28755
			[Token(Token = "0x4007053")]
			[FieldOffset(Offset = "0x20")]
			public string event_time;

			// Token: 0x04007054 RID: 28756
			[Token(Token = "0x4007054")]
			[FieldOffset(Offset = "0x28")]
			public string game_id;

			// Token: 0x04007055 RID: 28757
			[Token(Token = "0x4007055")]
			[FieldOffset(Offset = "0x30")]
			public int plat_id;

			// Token: 0x04007056 RID: 28758
			[Token(Token = "0x4007056")]
			[FieldOffset(Offset = "0x34")]
			public int zone_area_id;

			// Token: 0x04007057 RID: 28759
			[Token(Token = "0x4007057")]
			[FieldOffset(Offset = "0x38")]
			public string client_version;

			// Token: 0x04007058 RID: 28760
			[Token(Token = "0x4007058")]
			[FieldOffset(Offset = "0x40")]
			public string client_version_code;

			// Token: 0x04007059 RID: 28761
			[Token(Token = "0x4007059")]
			[FieldOffset(Offset = "0x48")]
			public string system_software;

			// Token: 0x0400705A RID: 28762
			[Token(Token = "0x400705A")]
			[FieldOffset(Offset = "0x50")]
			public string system_hardware;

			// Token: 0x0400705B RID: 28763
			[Token(Token = "0x400705B")]
			[FieldOffset(Offset = "0x58")]
			public string telecom_oper;

			// Token: 0x0400705C RID: 28764
			[Token(Token = "0x400705C")]
			[FieldOffset(Offset = "0x60")]
			public string network;

			// Token: 0x0400705D RID: 28765
			[Token(Token = "0x400705D")]
			[FieldOffset(Offset = "0x68")]
			public int screen_width;

			// Token: 0x0400705E RID: 28766
			[Token(Token = "0x400705E")]
			[FieldOffset(Offset = "0x6C")]
			public int screen_hight;

			// Token: 0x0400705F RID: 28767
			[Token(Token = "0x400705F")]
			[FieldOffset(Offset = "0x70")]
			public string dpi;

			// Token: 0x04007060 RID: 28768
			[Token(Token = "0x4007060")]
			[FieldOffset(Offset = "0x78")]
			public string cpu_hardware;

			// Token: 0x04007061 RID: 28769
			[Token(Token = "0x4007061")]
			[FieldOffset(Offset = "0x80")]
			public int memory;

			// Token: 0x04007062 RID: 28770
			[Token(Token = "0x4007062")]
			[FieldOffset(Offset = "0x88")]
			public string gl_render;

			// Token: 0x04007063 RID: 28771
			[Token(Token = "0x4007063")]
			[FieldOffset(Offset = "0x90")]
			public string gl_version;

			// Token: 0x04007064 RID: 28772
			[Token(Token = "0x4007064")]
			[FieldOffset(Offset = "0x98")]
			public string device_id;

			// Token: 0x04007065 RID: 28773
			[Token(Token = "0x4007065")]
			[FieldOffset(Offset = "0xA0")]
			public string client_ip;

			// Token: 0x04007066 RID: 28774
			[Token(Token = "0x4007066")]
			[FieldOffset(Offset = "0xA8")]
			public string language;

			// Token: 0x04007067 RID: 28775
			[Token(Token = "0x4007067")]
			[FieldOffset(Offset = "0xB0")]
			public string open_id;

			// Token: 0x04007068 RID: 28776
			[Token(Token = "0x4007068")]
			[FieldOffset(Offset = "0xB8")]
			public string open_id_type;

			// Token: 0x04007069 RID: 28777
			[Token(Token = "0x4007069")]
			[FieldOffset(Offset = "0xC0")]
			public string device_type;

			// Token: 0x0400706A RID: 28778
			[Token(Token = "0x400706A")]
			[FieldOffset(Offset = "0xC8")]
			public string device_model;

			// Token: 0x0400706B RID: 28779
			[Token(Token = "0x400706B")]
			[FieldOffset(Offset = "0xD0")]
			public string region;

			// Token: 0x0400706C RID: 28780
			[Token(Token = "0x400706C")]
			[FieldOffset(Offset = "0xD8")]
			public string others;

			// Token: 0x0400706D RID: 28781
			[Token(Token = "0x400706D")]
			[FieldOffset(Offset = "0xE0")]
			public int sdcard_total_storage;

			// Token: 0x0400706E RID: 28782
			[Token(Token = "0x400706E")]
			[FieldOffset(Offset = "0xE4")]
			public int sdcard_avail_storage;

			// Token: 0x0400706F RID: 28783
			[Token(Token = "0x400706F")]
			[FieldOffset(Offset = "0xE8")]
			public int inner_total_storage;

			// Token: 0x04007070 RID: 28784
			[Token(Token = "0x4007070")]
			[FieldOffset(Offset = "0xEC")]
			public int inner_avail_storage;

			// Token: 0x04007071 RID: 28785
			[Token(Token = "0x4007071")]
			[FieldOffset(Offset = "0xF0")]
			public string lib_token;

			// Token: 0x04007072 RID: 28786
			[Token(Token = "0x4007072")]
			[FieldOffset(Offset = "0xF8")]
			public string serial_a;

			// Token: 0x04007073 RID: 28787
			[Token(Token = "0x4007073")]
			[FieldOffset(Offset = "0x100")]
			public string board_a;

			// Token: 0x04007074 RID: 28788
			[Token(Token = "0x4007074")]
			[FieldOffset(Offset = "0x108")]
			public string brand_a;

			// Token: 0x04007075 RID: 28789
			[Token(Token = "0x4007075")]
			[FieldOffset(Offset = "0x110")]
			public string fingerprint_a;

			// Token: 0x04007076 RID: 28790
			[Token(Token = "0x4007076")]
			[FieldOffset(Offset = "0x118")]
			public string hardware_a;

			// Token: 0x04007077 RID: 28791
			[Token(Token = "0x4007077")]
			[FieldOffset(Offset = "0x120")]
			public string manufacturer_a;

			// Token: 0x04007078 RID: 28792
			[Token(Token = "0x4007078")]
			[FieldOffset(Offset = "0x128")]
			public string bootloader_a;

			// Token: 0x04007079 RID: 28793
			[Token(Token = "0x4007079")]
			[FieldOffset(Offset = "0x130")]
			public string device_a;

			// Token: 0x0400707A RID: 28794
			[Token(Token = "0x400707A")]
			[FieldOffset(Offset = "0x138")]
			public string model_a;

			// Token: 0x0400707B RID: 28795
			[Token(Token = "0x400707B")]
			[FieldOffset(Offset = "0x140")]
			public string product_a;

			// Token: 0x0400707C RID: 28796
			[Token(Token = "0x400707C")]
			[FieldOffset(Offset = "0x148")]
			public string network_operator_a;

			// Token: 0x0400707D RID: 28797
			[Token(Token = "0x400707D")]
			[FieldOffset(Offset = "0x150")]
			public string network_type_a;

			// Token: 0x0400707E RID: 28798
			[Token(Token = "0x400707E")]
			[FieldOffset(Offset = "0x158")]
			public string imei_a;

			// Token: 0x0400707F RID: 28799
			[Token(Token = "0x400707F")]
			[FieldOffset(Offset = "0x160")]
			public string meid_a;

			// Token: 0x04007080 RID: 28800
			[Token(Token = "0x4007080")]
			[FieldOffset(Offset = "0x168")]
			public string subscriber_a;

			// Token: 0x04007081 RID: 28801
			[Token(Token = "0x4007081")]
			[FieldOffset(Offset = "0x170")]
			public bool check_emulator_files_a;

			// Token: 0x04007082 RID: 28802
			[Token(Token = "0x4007082")]
			[FieldOffset(Offset = "0x171")]
			public bool check_emulator_properties_a;

			// Token: 0x04007083 RID: 28803
			[Token(Token = "0x4007083")]
			[FieldOffset(Offset = "0x172")]
			public bool check_emulator_packages_a;

			// Token: 0x04007084 RID: 28804
			[Token(Token = "0x4007084")]
			[FieldOffset(Offset = "0x178")]
			public ulong check_emulator_files_list_a;

			// Token: 0x04007085 RID: 28805
			[Token(Token = "0x4007085")]
			[FieldOffset(Offset = "0x180")]
			public ulong check_emulator_properties_list_a;

			// Token: 0x04007086 RID: 28806
			[Token(Token = "0x4007086")]
			[FieldOffset(Offset = "0x188")]
			public ulong check_emulator_packages_list_a;

			// Token: 0x04007087 RID: 28807
			[Token(Token = "0x4007087")]
			[FieldOffset(Offset = "0x190")]
			public bool is_root;

			// Token: 0x04007088 RID: 28808
			[Token(Token = "0x4007088")]
			[FieldOffset(Offset = "0x198")]
			public string signature_md5;

			// Token: 0x04007089 RID: 28809
			[Token(Token = "0x4007089")]
			[FieldOffset(Offset = "0x1A0")]
			public string sensor_info;

			// Token: 0x0400708A RID: 28810
			[Token(Token = "0x400708A")]
			[FieldOffset(Offset = "0x1A8")]
			public int game_installed_disk_avail_storage;

			// Token: 0x0400708B RID: 28811
			[Token(Token = "0x400708B")]
			[FieldOffset(Offset = "0x1AC")]
			public int game_installed_disk_total_storage;

			// Token: 0x0400708C RID: 28812
			[Token(Token = "0x400708C")]
			[FieldOffset(Offset = "0x1B0")]
			public int external_sdcard_avail_storage;

			// Token: 0x0400708D RID: 28813
			[Token(Token = "0x400708D")]
			[FieldOffset(Offset = "0x1B4")]
			public int external_sdcard_total_storage;

			// Token: 0x0400708E RID: 28814
			[Token(Token = "0x400708E")]
			[FieldOffset(Offset = "0x1B8")]
			public string cpu_architecture;

			// Token: 0x0400708F RID: 28815
			[Token(Token = "0x400708F")]
			[FieldOffset(Offset = "0x1C0")]
			public uint channel_type;

			// Token: 0x04007090 RID: 28816
			[Token(Token = "0x4007090")]
			[FieldOffset(Offset = "0x1C4")]
			public uint cpu_type;
		}

		// Token: 0x0200122F RID: 4655
		[Token(Token = "0x200122F")]
		public enum SharePlatform
		{
			// Token: 0x04007092 RID: 28818
			[Token(Token = "0x4007092")]
			None,
			// Token: 0x04007093 RID: 28819
			[Token(Token = "0x4007093")]
			Garena,
			// Token: 0x04007094 RID: 28820
			[Token(Token = "0x4007094")]
			Facebook,
			// Token: 0x04007095 RID: 28821
			[Token(Token = "0x4007095")]
			VKontakte,
			// Token: 0x04007096 RID: 28822
			[Token(Token = "0x4007096")]
			Line,
			// Token: 0x04007097 RID: 28823
			[Token(Token = "0x4007097")]
			FacebookMessenger,
			// Token: 0x04007098 RID: 28824
			[Token(Token = "0x4007098")]
			CopyLink,
			// Token: 0x04007099 RID: 28825
			[Token(Token = "0x4007099")]
			System = 99
		}

		// Token: 0x02001230 RID: 4656
		[Token(Token = "0x2001230")]
		[Serializable]
		public class ScanIAPInventoryResult
		{
			// Token: 0x06004794 RID: 18324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004794")]
			[Address(RVA = "0x1B94E98", Offset = "0x1B94E98", VA = "0x7BBC394E98")]
			public ScanIAPInventoryResult()
			{
			}

			// Token: 0x0400709A RID: 28826
			[Token(Token = "0x400709A")]
			[FieldOffset(Offset = "0x10")]
			public string item_identifier;

			// Token: 0x0400709B RID: 28827
			[Token(Token = "0x400709B")]
			[FieldOffset(Offset = "0x18")]
			public string error;

			// Token: 0x0400709C RID: 28828
			[Token(Token = "0x400709C")]
			[FieldOffset(Offset = "0x20")]
			public bool success;

			// Token: 0x0400709D RID: 28829
			[Token(Token = "0x400709D")]
			[FieldOffset(Offset = "0x24")]
			public int amount;

			// Token: 0x0400709E RID: 28830
			[Token(Token = "0x400709E")]
			[FieldOffset(Offset = "0x28")]
			public bool promotion;
		}

		// Token: 0x02001231 RID: 4657
		[Token(Token = "0x2001231")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x10EAE34", Offset = "0x10EAE34")]
		public enum ChampioshipClickType
		{
			// Token: 0x040070A0 RID: 28832
			[Token(Token = "0x40070A0")]
			Entrance,
			// Token: 0x040070A1 RID: 28833
			[Token(Token = "0x40070A1")]
			Team
		}

		// Token: 0x02001232 RID: 4658
		[Token(Token = "0x2001232")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x10EAE70", Offset = "0x10EAE70")]
		public enum ELobbyClickType
		{
			// Token: 0x040070A3 RID: 28835
			[Token(Token = "0x40070A3")]
			None = -1,
			// Token: 0x040070A4 RID: 28836
			[Token(Token = "0x40070A4")]
			Store,
			// Token: 0x040070A5 RID: 28837
			[Token(Token = "0x40070A5")]
			Lottery,
			// Token: 0x040070A6 RID: 28838
			[Token(Token = "0x40070A6")]
			Character,
			// Token: 0x040070A7 RID: 28839
			[Token(Token = "0x40070A7")]
			Vault,
			// Token: 0x040070A8 RID: 28840
			[Token(Token = "0x40070A8")]
			Collection,
			// Token: 0x040070A9 RID: 28841
			[Token(Token = "0x40070A9")]
			Friend,
			// Token: 0x040070AA RID: 28842
			[Token(Token = "0x40070AA")]
			LeaderBoard,
			// Token: 0x040070AB RID: 28843
			[Token(Token = "0x40070AB")]
			Clan,
			// Token: 0x040070AC RID: 28844
			[Token(Token = "0x40070AC")]
			Activity,
			// Token: 0x040070AD RID: 28845
			[Token(Token = "0x40070AD")]
			EPChallenge,
			// Token: 0x040070AE RID: 28846
			[Token(Token = "0x40070AE")]
			Tutorial,
			// Token: 0x040070AF RID: 28847
			[Token(Token = "0x40070AF")]
			RewardedVideo,
			// Token: 0x040070B0 RID: 28848
			[Token(Token = "0x40070B0")]
			Pet,
			// Token: 0x040070B1 RID: 28849
			[Token(Token = "0x40070B1")]
			ElitePass,
			// Token: 0x040070B2 RID: 28850
			[Token(Token = "0x40070B2")]
			RankLobby,
			// Token: 0x040070B3 RID: 28851
			[Token(Token = "0x40070B3")]
			EPVideo,
			// Token: 0x040070B4 RID: 28852
			[Token(Token = "0x40070B4")]
			Payment,
			// Token: 0x040070B5 RID: 28853
			[Token(Token = "0x40070B5")]
			GroupEmote,
			// Token: 0x040070B6 RID: 28854
			[Token(Token = "0x40070B6")]
			LiveTv,
			// Token: 0x040070B7 RID: 28855
			[Token(Token = "0x40070B7")]
			TeamPointMatch,
			// Token: 0x040070B8 RID: 28856
			[Token(Token = "0x40070B8")]
			Manual,
			// Token: 0x040070B9 RID: 28857
			[Token(Token = "0x40070B9")]
			NewPlayer,
			// Token: 0x040070BA RID: 28858
			[Token(Token = "0x40070BA")]
			MAXCOUNT
		}

		// Token: 0x02001233 RID: 4659
		[Token(Token = "0x2001233")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x10EAEAC", Offset = "0x10EAEAC")]
		public enum EManualClickType
		{
			// Token: 0x040070BC RID: 28860
			[Token(Token = "0x40070BC")]
			None = -1,
			// Token: 0x040070BD RID: 28861
			[Token(Token = "0x40070BD")]
			GrowningRoute,
			// Token: 0x040070BE RID: 28862
			[Token(Token = "0x40070BE")]
			Weapon,
			// Token: 0x040070BF RID: 28863
			[Token(Token = "0x40070BF")]
			Map,
			// Token: 0x040070C0 RID: 28864
			[Token(Token = "0x40070C0")]
			WelcomeToMap,
			// Token: 0x040070C1 RID: 28865
			[Token(Token = "0x40070C1")]
			SurviveInMap,
			// Token: 0x040070C2 RID: 28866
			[Token(Token = "0x40070C2")]
			EventInMap,
			// Token: 0x040070C3 RID: 28867
			[Token(Token = "0x40070C3")]
			MoveOnMap,
			// Token: 0x040070C4 RID: 28868
			[Token(Token = "0x40070C4")]
			MoreHelp,
			// Token: 0x040070C5 RID: 28869
			[Token(Token = "0x40070C5")]
			Share,
			// Token: 0x040070C6 RID: 28870
			[Token(Token = "0x40070C6")]
			MAXCOUNT
		}

		// Token: 0x02001234 RID: 4660
		[Token(Token = "0x2001234")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x10EAEE8", Offset = "0x10EAEE8")]
		public enum EProfileClickType
		{
			// Token: 0x040070C8 RID: 28872
			[Token(Token = "0x40070C8")]
			None = -1,
			// Token: 0x040070C9 RID: 28873
			[Token(Token = "0x40070C9")]
			Group,
			// Token: 0x040070CA RID: 28874
			[Token(Token = "0x40070CA")]
			Clan,
			// Token: 0x040070CB RID: 28875
			[Token(Token = "0x40070CB")]
			FriendList,
			// Token: 0x040070CC RID: 28876
			[Token(Token = "0x40070CC")]
			SearchList,
			// Token: 0x040070CD RID: 28877
			[Token(Token = "0x40070CD")]
			FriendApply,
			// Token: 0x040070CE RID: 28878
			[Token(Token = "0x40070CE")]
			LeaderBoard,
			// Token: 0x040070CF RID: 28879
			[Token(Token = "0x40070CF")]
			Chat,
			// Token: 0x040070D0 RID: 28880
			[Token(Token = "0x40070D0")]
			MAXCOUNT
		}

		// Token: 0x02001235 RID: 4661
		[Token(Token = "0x2001235")]
		public enum ClickType
		{
			// Token: 0x040070D2 RID: 28882
			[Token(Token = "0x40070D2")]
			None,
			// Token: 0x040070D3 RID: 28883
			[Token(Token = "0x40070D3")]
			Setting,
			// Token: 0x040070D4 RID: 28884
			[Token(Token = "0x40070D4")]
			Pay,
			// Token: 0x040070D5 RID: 28885
			[Token(Token = "0x40070D5")]
			Lobby,
			// Token: 0x040070D6 RID: 28886
			[Token(Token = "0x40070D6")]
			Integrate,
			// Token: 0x040070D7 RID: 28887
			[Token(Token = "0x40070D7")]
			Avatar,
			// Token: 0x040070D8 RID: 28888
			[Token(Token = "0x40070D8")]
			AvatarProfile,
			// Token: 0x040070D9 RID: 28889
			[Token(Token = "0x40070D9")]
			Inventory,
			// Token: 0x040070DA RID: 28890
			[Token(Token = "0x40070DA")]
			UniversalDebrisWindow,
			// Token: 0x040070DB RID: 28891
			[Token(Token = "0x40070DB")]
			Friend,
			// Token: 0x040070DC RID: 28892
			[Token(Token = "0x40070DC")]
			Chat,
			// Token: 0x040070DD RID: 28893
			[Token(Token = "0x40070DD")]
			IAP,
			// Token: 0x040070DE RID: 28894
			[Token(Token = "0x40070DE")]
			Activity,
			// Token: 0x040070DF RID: 28895
			[Token(Token = "0x40070DF")]
			ElitePass = 14,
			// Token: 0x040070E0 RID: 28896
			[Token(Token = "0x40070E0")]
			Mall,
			// Token: 0x040070E1 RID: 28897
			[Token(Token = "0x40070E1")]
			Gacha = 17,
			// Token: 0x040070E2 RID: 28898
			[Token(Token = "0x40070E2")]
			WeaponSkinLobby = 19,
			// Token: 0x040070E3 RID: 28899
			[Token(Token = "0x40070E3")]
			Championship,
			// Token: 0x040070E4 RID: 28900
			[Token(Token = "0x40070E4")]
			WeaponSkinUpgrader,
			// Token: 0x040070E5 RID: 28901
			[Token(Token = "0x40070E5")]
			Profile,
			// Token: 0x040070E6 RID: 28902
			[Token(Token = "0x40070E6")]
			MegaPunch = 24,
			// Token: 0x040070E7 RID: 28903
			[Token(Token = "0x40070E7")]
			Pet,
			// Token: 0x040070E8 RID: 28904
			[Token(Token = "0x40070E8")]
			Clan,
			// Token: 0x040070E9 RID: 28905
			[Token(Token = "0x40070E9")]
			LiveTv,
			// Token: 0x040070EA RID: 28906
			[Token(Token = "0x40070EA")]
			MVP,
			// Token: 0x040070EB RID: 28907
			[Token(Token = "0x40070EB")]
			LeaderBoard,
			// Token: 0x040070EC RID: 28908
			[Token(Token = "0x40070EC")]
			CommonPopMenu,
			// Token: 0x040070ED RID: 28909
			[Token(Token = "0x40070ED")]
			Reservation,
			// Token: 0x040070EE RID: 28910
			[Token(Token = "0x40070EE")]
			HudVehicleHorn,
			// Token: 0x040070EF RID: 28911
			[Token(Token = "0x40070EF")]
			WeaponRack,
			// Token: 0x040070F0 RID: 28912
			[Token(Token = "0x40070F0")]
			Forge,
			// Token: 0x040070F1 RID: 28913
			[Token(Token = "0x40070F1")]
			PortraitCloseup,
			// Token: 0x040070F2 RID: 28914
			[Token(Token = "0x40070F2")]
			Goliath,
			// Token: 0x040070F3 RID: 28915
			[Token(Token = "0x40070F3")]
			SuperCar,
			// Token: 0x040070F4 RID: 28916
			[Token(Token = "0x40070F4")]
			DriftBottleAddFriend,
			// Token: 0x040070F5 RID: 28917
			[Token(Token = "0x40070F5")]
			FFWS,
			// Token: 0x040070F6 RID: 28918
			[Token(Token = "0x40070F6")]
			CSWebTutorial,
			// Token: 0x040070F7 RID: 28919
			[Token(Token = "0x40070F7")]
			SuperFighter,
			// Token: 0x040070F8 RID: 28920
			[Token(Token = "0x40070F8")]
			TokenTips,
			// Token: 0x040070F9 RID: 28921
			[Token(Token = "0x40070F9")]
			HDVehicleDisplay,
			// Token: 0x040070FA RID: 28922
			[Token(Token = "0x40070FA")]
			HDWeaponRack,
			// Token: 0x040070FB RID: 28923
			[Token(Token = "0x40070FB")]
			MatchResult
		}

		// Token: 0x02001236 RID: 4662
		[Token(Token = "0x2001236")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x10EAF24", Offset = "0x10EAF24")]
		public enum EInstallmentClickType
		{
			// Token: 0x040070FD RID: 28925
			[Token(Token = "0x40070FD")]
			Mall,
			// Token: 0x040070FE RID: 28926
			[Token(Token = "0x40070FE")]
			Inventory,
			// Token: 0x040070FF RID: 28927
			[Token(Token = "0x40070FF")]
			Tutorial
		}

		// Token: 0x02001237 RID: 4663
		[Token(Token = "0x2001237")]
		public enum EventLog_Optional_Operation
		{
			// Token: 0x04007101 RID: 28929
			[Token(Token = "0x4007101")]
			None,
			// Token: 0x04007102 RID: 28930
			[Token(Token = "0x4007102")]
			Delete
		}

		// Token: 0x02001238 RID: 4664
		[Token(Token = "0x2001238")]
		public class EventClientPushSetting : EventLogger.EventLoggerBase
		{
			// Token: 0x06004795 RID: 18325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004795")]
			[Address(RVA = "0x1B94AD0", Offset = "0x1B94AD0", VA = "0x7BBC394AD0")]
			public EventClientPushSetting()
			{
			}

			// Token: 0x04007103 RID: 28931
			[Token(Token = "0x4007103")]
			[FieldOffset(Offset = "0x20")]
			public bool friend_apply_push;

			// Token: 0x04007104 RID: 28932
			[Token(Token = "0x4007104")]
			[FieldOffset(Offset = "0x21")]
			public bool is_support_hardware_decoding;

			// Token: 0x04007105 RID: 28933
			[Token(Token = "0x4007105")]
			[FieldOffset(Offset = "0x24")]
			public int max_login_video;

			// Token: 0x04007106 RID: 28934
			[Token(Token = "0x4007106")]
			[FieldOffset(Offset = "0x28")]
			public int max_lobby;

			// Token: 0x04007107 RID: 28935
			[Token(Token = "0x4007107")]
			[FieldOffset(Offset = "0x2C")]
			public int max_lobby_motion;

			// Token: 0x04007108 RID: 28936
			[Token(Token = "0x4007108")]
			[FieldOffset(Offset = "0x30")]
			public int max_audio_style;

			// Token: 0x04007109 RID: 28937
			[Token(Token = "0x4007109")]
			[FieldOffset(Offset = "0x34")]
			public int max_animation;

			// Token: 0x0400710A RID: 28938
			[Token(Token = "0x400710A")]
			[FieldOffset(Offset = "0x38")]
			public int max_special_effects;

			// Token: 0x0400710B RID: 28939
			[Token(Token = "0x400710B")]
			[FieldOffset(Offset = "0x3C")]
			public int max_hd_texture;

			// Token: 0x0400710C RID: 28940
			[Token(Token = "0x400710C")]
			[FieldOffset(Offset = "0x40")]
			public int max_vehicle_VFX;

			// Token: 0x0400710D RID: 28941
			[Token(Token = "0x400710D")]
			[FieldOffset(Offset = "0x44")]
			public bool is_first_login;

			// Token: 0x0400710E RID: 28942
			[Token(Token = "0x400710E")]
			[FieldOffset(Offset = "0x48")]
			public string device_model;
		}

		// Token: 0x02001239 RID: 4665
		[Token(Token = "0x2001239")]
		public class EventTypeFriendRecommend : EventLogger.EventLoggerBase
		{
			// Token: 0x06004796 RID: 18326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004796")]
			[Address(RVA = "0x1B93AC8", Offset = "0x1B93AC8", VA = "0x7BBC393AC8")]
			public EventTypeFriendRecommend()
			{
			}

			// Token: 0x0400710F RID: 28943
			[Token(Token = "0x400710F")]
			[FieldOffset(Offset = "0x20")]
			public int recommend_type;

			// Token: 0x04007110 RID: 28944
			[Token(Token = "0x4007110")]
			[FieldOffset(Offset = "0x28")]
			public ulong recommend_account_id;

			// Token: 0x04007111 RID: 28945
			[Token(Token = "0x4007111")]
			[FieldOffset(Offset = "0x30")]
			public int recommend_account_rank;

			// Token: 0x04007112 RID: 28946
			[Token(Token = "0x4007112")]
			[FieldOffset(Offset = "0x34")]
			public bool if_shield;

			// Token: 0x04007113 RID: 28947
			[Token(Token = "0x4007113")]
			[FieldOffset(Offset = "0x38")]
			public int choose;

			// Token: 0x04007114 RID: 28948
			[Token(Token = "0x4007114")]
			[FieldOffset(Offset = "0x3C")]
			public int cur_friend_num;
		}

		// Token: 0x0200123A RID: 4666
		[Token(Token = "0x200123A")]
		public class EventTypeVNLink : EventLogger.EventLoggerBase
		{
			// Token: 0x06004797 RID: 18327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004797")]
			[Address(RVA = "0x1B93BB0", Offset = "0x1B93BB0", VA = "0x7BBC393BB0")]
			public EventTypeVNLink()
			{
			}

			// Token: 0x04007115 RID: 28949
			[Token(Token = "0x4007115")]
			[FieldOffset(Offset = "0x20")]
			public bool is_transfer;
		}

		// Token: 0x0200123B RID: 4667
		[Token(Token = "0x200123B")]
		public class EventTypeMVPInfo : EventLogger.EventLoggerBase
		{
			// Token: 0x06004798 RID: 18328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004798")]
			[Address(RVA = "0x1B94710", Offset = "0x1B94710", VA = "0x7BBC394710")]
			public EventTypeMVPInfo()
			{
			}

			// Token: 0x04007116 RID: 28950
			[Token(Token = "0x4007116")]
			[FieldOffset(Offset = "0x20")]
			public ulong match_id;

			// Token: 0x04007117 RID: 28951
			[Token(Token = "0x4007117")]
			[FieldOffset(Offset = "0x28")]
			public string ip_region;

			// Token: 0x04007118 RID: 28952
			[Token(Token = "0x4007118")]
			[FieldOffset(Offset = "0x30")]
			public uint map_id;

			// Token: 0x04007119 RID: 28953
			[Token(Token = "0x4007119")]
			[FieldOffset(Offset = "0x34")]
			public uint game_mode;

			// Token: 0x0400711A RID: 28954
			[Token(Token = "0x400711A")]
			[FieldOffset(Offset = "0x38")]
			public uint group_mode;

			// Token: 0x0400711B RID: 28955
			[Token(Token = "0x400711B")]
			[FieldOffset(Offset = "0x3C")]
			public uint match_mode;

			// Token: 0x0400711C RID: 28956
			[Token(Token = "0x400711C")]
			[FieldOffset(Offset = "0x40")]
			public uint rank;

			// Token: 0x0400711D RID: 28957
			[Token(Token = "0x400711D")]
			[FieldOffset(Offset = "0x44")]
			public bool if_mvp;
		}

		// Token: 0x0200123C RID: 4668
		[Token(Token = "0x200123C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAF60", Offset = "0x10EAF60")]
		private sealed class <>c__DisplayClass297_0
		{
			// Token: 0x06004799 RID: 18329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004799")]
			[Address(RVA = "0x1B917A8", Offset = "0x1B917A8", VA = "0x7BBC3917A8")]
			public <>c__DisplayClass297_0()
			{
			}

			// Token: 0x0600479A RID: 18330 RVA: 0x00015558 File Offset: 0x00013758
			[Token(Token = "0x600479A")]
			[Address(RVA = "0x1B94B38", Offset = "0x1B94B38", VA = "0x7BBC394B38")]
			internal bool <LogNavigate>b__0(EventLogger.EventNavigate e)
			{
				return default(bool);
			}

			// Token: 0x0400711E RID: 28958
			[Token(Token = "0x400711E")]
			[FieldOffset(Offset = "0x10")]
			public UINavigationUtil.UINavigationPageType to;
		}

		// Token: 0x0200123D RID: 4669
		[Token(Token = "0x200123D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAF70", Offset = "0x10EAF70")]
		private sealed class <>c__DisplayClass298_0
		{
			// Token: 0x0600479B RID: 18331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600479B")]
			[Address(RVA = "0x1B91A90", Offset = "0x1B91A90", VA = "0x7BBC391A90")]
			public <>c__DisplayClass298_0()
			{
			}

			// Token: 0x0600479C RID: 18332 RVA: 0x00015570 File Offset: 0x00013770
			[Token(Token = "0x600479C")]
			[Address(RVA = "0x1B94BF4", Offset = "0x1B94BF4", VA = "0x7BBC394BF4")]
			internal bool <LogClick>b__0(EventLogger.ClickEntry e)
			{
				return default(bool);
			}

			// Token: 0x0400711F RID: 28959
			[Token(Token = "0x400711F")]
			[FieldOffset(Offset = "0x10")]
			public string name;
		}

		// Token: 0x0200123E RID: 4670
		[Token(Token = "0x200123E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAF80", Offset = "0x10EAF80")]
		private sealed class <>c__DisplayClass299_0
		{
			// Token: 0x0600479D RID: 18333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600479D")]
			[Address(RVA = "0x1B91D14", Offset = "0x1B91D14", VA = "0x7BBC391D14")]
			public <>c__DisplayClass299_0()
			{
			}

			// Token: 0x0600479E RID: 18334 RVA: 0x00015588 File Offset: 0x00013788
			[Token(Token = "0x600479E")]
			[Address(RVA = "0x1B94C2C", Offset = "0x1B94C2C", VA = "0x7BBC394C2C")]
			internal bool <LogBroadCastType>b__0(EventLogger.EventBroadCastEntry e)
			{
				return default(bool);
			}

			// Token: 0x04007120 RID: 28960
			[Token(Token = "0x4007120")]
			[FieldOffset(Offset = "0x10")]
			public EventLogger.EventBroadCastType type;
		}

		// Token: 0x0200123F RID: 4671
		[Token(Token = "0x200123F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAF90", Offset = "0x10EAF90")]
		private sealed class <>c__DisplayClass300_0
		{
			// Token: 0x0600479F RID: 18335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600479F")]
			[Address(RVA = "0x1B91FAC", Offset = "0x1B91FAC", VA = "0x7BBC391FAC")]
			public <>c__DisplayClass300_0()
			{
			}

			// Token: 0x060047A0 RID: 18336 RVA: 0x000155A0 File Offset: 0x000137A0
			[Token(Token = "0x60047A0")]
			[Address(RVA = "0x1B94C68", Offset = "0x1B94C68", VA = "0x7BBC394C68")]
			internal bool <CacheMallTabClick>b__0(EventLogger.EventMallTabClickInfo e)
			{
				return default(bool);
			}

			// Token: 0x04007121 RID: 28961
			[Token(Token = "0x4007121")]
			[FieldOffset(Offset = "0x10")]
			public uint mallType;

			// Token: 0x04007122 RID: 28962
			[Token(Token = "0x4007122")]
			[FieldOffset(Offset = "0x18")]
			public string tabName;
		}
	}
}
