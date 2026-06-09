using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001F8E RID: 8078
	[Token(Token = "0x2001F8E")]
	public class UIModelOptionalDownload : UIBaseModel
	{
		// Token: 0x0600B2A6 RID: 45734 RVA: 0x000326E8 File Offset: 0x000308E8
		[Token(Token = "0x600B2A6")]
		[Address(RVA = "0x241F728", Offset = "0x241F728", VA = "0x7BBCC1F728", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B2A7 RID: 45735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2A7")]
		[Address(RVA = "0x241F730", Offset = "0x241F730", VA = "0x7BBCC1F730", Slot = "13")]
		public override void ClearCache()
		{
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x0600B2A8 RID: 45736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C0E")]
		public List<DownloadInfo> DownloadInfoList
		{
			[Token(Token = "0x600B2A8")]
			[Address(RVA = "0x241F834", Offset = "0x241F834", VA = "0x7BBCC1F834")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x0600B2A9 RID: 45737 RVA: 0x00032700 File Offset: 0x00030900
		// (set) Token: 0x0600B2AA RID: 45738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C0F")]
		public EModelDownloadState DownloadState
		{
			[Token(Token = "0x600B2A9")]
			[Address(RVA = "0x241F83C", Offset = "0x241F83C", VA = "0x7BBCC1F83C")]
			get
			{
				return EModelDownloadState.None;
			}
			[Token(Token = "0x600B2AA")]
			[Address(RVA = "0x241F844", Offset = "0x241F844", VA = "0x7BBCC1F844")]
			private set
			{
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600B2AB RID: 45739 RVA: 0x00032718 File Offset: 0x00030918
		// (set) Token: 0x0600B2AC RID: 45740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C10")]
		public bool InSpeedUp
		{
			[Token(Token = "0x600B2AB")]
			[Address(RVA = "0x241FC00", Offset = "0x241FC00", VA = "0x7BBCC1FC00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146C1C", Offset = "0x1146C1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B2AC")]
			[Address(RVA = "0x241FC08", Offset = "0x241FC08", VA = "0x7BBCC1FC08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146C2C", Offset = "0x1146C2C")]
			private set
			{
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x0600B2AD RID: 45741 RVA: 0x00032730 File Offset: 0x00030930
		[Token(Token = "0x17000C11")]
		public bool NeedShowCentre
		{
			[Token(Token = "0x600B2AD")]
			[Address(RVA = "0x241FC14", Offset = "0x241FC14", VA = "0x7BBCC1FC14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B2AE RID: 45742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2AE")]
		[Address(RVA = "0x241FC74", Offset = "0x241FC74", VA = "0x7BBCC1FC74", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600B2AF RID: 45743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2AF")]
		[Address(RVA = "0x2420164", Offset = "0x2420164", VA = "0x7BBCC20164", Slot = "11")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600B2B0 RID: 45744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2B0")]
		[Address(RVA = "0x2420248", Offset = "0x2420248", VA = "0x7BBCC20248", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B2B1 RID: 45745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2B1")]
		[Address(RVA = "0x24202C4", Offset = "0x24202C4", VA = "0x7BBCC202C4")]
		public static string GetIconByDownloadType(ResDownloadType type)
		{
			return null;
		}

		// Token: 0x0600B2B2 RID: 45746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2B2")]
		[Address(RVA = "0x242032C", Offset = "0x242032C", VA = "0x7BBCC2032C")]
		public static string GetRewardIconByActivityState(EActivity.State state)
		{
			return null;
		}

		// Token: 0x0600B2B3 RID: 45747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2B3")]
		[Address(RVA = "0x2420398", Offset = "0x2420398", VA = "0x7BBCC20398")]
		public static string GetPackNameByDownloadType(ResDownloadType type)
		{
			return null;
		}

		// Token: 0x0600B2B4 RID: 45748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2B4")]
		[Address(RVA = "0x2420674", Offset = "0x2420674", VA = "0x7BBCC20674")]
		public static string GetFileNameByDownloadType(ResDownloadType type, ResVersionInfo.FileInfo file_info)
		{
			return null;
		}

		// Token: 0x0600B2B5 RID: 45749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2B5")]
		[Address(RVA = "0x24208C4", Offset = "0x24208C4", VA = "0x7BBCC208C4")]
		public static string GetErrorLocKeyWithErrorCode(ResErrorCode error)
		{
			return null;
		}

		// Token: 0x0600B2B6 RID: 45750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2B6")]
		[Address(RVA = "0x2420928", Offset = "0x2420928", VA = "0x7BBCC20928")]
		public void HintWithErrorCode(ResErrorCode error)
		{
		}

		// Token: 0x0600B2B7 RID: 45751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2B7")]
		[Address(RVA = "0x2420B10", Offset = "0x2420B10", VA = "0x7BBCC20B10")]
		public void CheckOptionalVersionInLauncher()
		{
		}

		// Token: 0x0600B2B8 RID: 45752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2B8")]
		[Address(RVA = "0x2420C04", Offset = "0x2420C04", VA = "0x7BBCC20C04")]
		public void CheckOptionalVersion()
		{
		}

		// Token: 0x0600B2B9 RID: 45753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2B9")]
		[Address(RVA = "0x2420E24", Offset = "0x2420E24", VA = "0x7BBCC20E24")]
		public void CheckOptionalVersion(ResDownloadType type)
		{
		}

		// Token: 0x0600B2BA RID: 45754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2BA")]
		[Address(RVA = "0x2420F2C", Offset = "0x2420F2C", VA = "0x7BBCC20F2C")]
		private void CheckDesignatedFile()
		{
		}

		// Token: 0x0600B2BB RID: 45755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2BB")]
		[Address(RVA = "0x2420D14", Offset = "0x2420D14", VA = "0x7BBCC20D14")]
		private void onVersionChecked()
		{
		}

		// Token: 0x0600B2BC RID: 45756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2BC")]
		[Address(RVA = "0x24220A4", Offset = "0x24220A4", VA = "0x7BBCC220A4")]
		public void OnEnterLobby()
		{
		}

		// Token: 0x0600B2BD RID: 45757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2BD")]
		[Address(RVA = "0x2421418", Offset = "0x2421418", VA = "0x7BBCC21418")]
		private void CheckNeedDownload()
		{
		}

		// Token: 0x0600B2BE RID: 45758 RVA: 0x00032748 File Offset: 0x00030948
		[Token(Token = "0x600B2BE")]
		[Address(RVA = "0x242246C", Offset = "0x242246C", VA = "0x7BBCC2246C")]
		public bool GetAutoDownloadFlag()
		{
			return default(bool);
		}

		// Token: 0x0600B2BF RID: 45759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2BF")]
		[Address(RVA = "0x2421680", Offset = "0x2421680", VA = "0x7BBCC21680")]
		public void CheckAutoDownload()
		{
		}

		// Token: 0x0600B2C0 RID: 45760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2C0")]
		[Address(RVA = "0x2422A5C", Offset = "0x2422A5C", VA = "0x7BBCC22A5C")]
		public void DownloadSingleFile(ResourceID id)
		{
		}

		// Token: 0x0600B2C1 RID: 45761 RVA: 0x00032760 File Offset: 0x00030960
		[Token(Token = "0x600B2C1")]
		[Address(RVA = "0x2422DC4", Offset = "0x2422DC4", VA = "0x7BBCC22DC4")]
		public bool IsOptionalPackedRes(ResourceID id)
		{
			return default(bool);
		}

		// Token: 0x0600B2C2 RID: 45762 RVA: 0x00032778 File Offset: 0x00030978
		[Token(Token = "0x600B2C2")]
		[Address(RVA = "0x2422E54", Offset = "0x2422E54", VA = "0x7BBCC22E54")]
		public bool IsOptionalPackedRes(string ab_path)
		{
			return default(bool);
		}

		// Token: 0x0600B2C3 RID: 45763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2C3")]
		[Address(RVA = "0x2422C38", Offset = "0x2422C38", VA = "0x7BBCC22C38")]
		public void DownloadSingleFile(string ab_path)
		{
		}

		// Token: 0x0600B2C4 RID: 45764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2C4")]
		[Address(RVA = "0x2422F0C", Offset = "0x2422F0C", VA = "0x7BBCC22F0C")]
		public void DownloadAllFileByType(ResDownloadType type)
		{
		}

		// Token: 0x0600B2C5 RID: 45765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2C5")]
		[Address(RVA = "0x24212F0", Offset = "0x24212F0", VA = "0x7BBCC212F0")]
		private void StartDownloadSingle(string ab_path, ResUpdateDownloadContext context)
		{
		}

		// Token: 0x0600B2C6 RID: 45766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2C6")]
		[Address(RVA = "0x24227A4", Offset = "0x24227A4", VA = "0x7BBCC227A4")]
		private void StartDownloadAll(ResUpdateDownloadContext context)
		{
		}

		// Token: 0x0600B2C7 RID: 45767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2C7")]
		[Address(RVA = "0x24230F0", Offset = "0x24230F0", VA = "0x7BBCC230F0")]
		public void ResumeDownload()
		{
		}

		// Token: 0x0600B2C8 RID: 45768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2C8")]
		[Address(RVA = "0x2423180", Offset = "0x2423180", VA = "0x7BBCC23180")]
		public void ResumeDownload(ResUpdateDownloadContext context)
		{
		}

		// Token: 0x0600B2C9 RID: 45769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2C9")]
		[Address(RVA = "0x2423274", Offset = "0x2423274", VA = "0x7BBCC23274")]
		public void PauseDownload(bool need_auto_resume = false)
		{
		}

		// Token: 0x0600B2CA RID: 45770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2CA")]
		[Address(RVA = "0x2422944", Offset = "0x2422944", VA = "0x7BBCC22944")]
		public void PauseDownload(ResUpdateDownloadContext context, bool need_auto_resume = false)
		{
		}

		// Token: 0x0600B2CB RID: 45771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2CB")]
		[Address(RVA = "0x2423404", Offset = "0x2423404", VA = "0x7BBCC23404")]
		public void DeleteAllFile(ResUpdateDownloadContext context)
		{
		}

		// Token: 0x0600B2CC RID: 45772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2CC")]
		[Address(RVA = "0x2423788", Offset = "0x2423788", VA = "0x7BBCC23788")]
		public void CheckAllFileStatesByResID(ResourceID resource_id)
		{
		}

		// Token: 0x0600B2CD RID: 45773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2CD")]
		[Address(RVA = "0x2423848", Offset = "0x2423848", VA = "0x7BBCC23848")]
		public void CheckAllFileStatesByFileName(string file_name)
		{
		}

		// Token: 0x0600B2CE RID: 45774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2CE")]
		[Address(RVA = "0x2423904", Offset = "0x2423904", VA = "0x7BBCC23904")]
		public void CheckAllFileStatesByContextType(ResDownloadType context_type)
		{
		}

		// Token: 0x0600B2CF RID: 45775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2CF")]
		[Address(RVA = "0x2423A20", Offset = "0x2423A20", VA = "0x7BBCC23A20")]
		public void RemoveSingleFileDownload(ResUpdateDownloadContext context, ResVersionInfo.FileInfo fileInfo)
		{
		}

		// Token: 0x0600B2D0 RID: 45776 RVA: 0x00032790 File Offset: 0x00030990
		[Token(Token = "0x600B2D0")]
		[Address(RVA = "0x2423C98", Offset = "0x2423C98", VA = "0x7BBCC23C98")]
		private EActivity.Event GetActivityEventTypeByDownloadType(ResDownloadType type)
		{
			return EActivity.Event.Event_NONE;
		}

		// Token: 0x0600B2D1 RID: 45777 RVA: 0x000327A8 File Offset: 0x000309A8
		[Token(Token = "0x600B2D1")]
		[Address(RVA = "0x2423CBC", Offset = "0x2423CBC", VA = "0x7BBCC23CBC")]
		public static ResDownloadType GetResDownloadTypeWithEventType(uint activity_type)
		{
			return ResDownloadType.None;
		}

		// Token: 0x0600B2D2 RID: 45778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2D2")]
		[Address(RVA = "0x2423D04", Offset = "0x2423D04", VA = "0x7BBCC23D04")]
		public void NotifyService(ResDownloadType type)
		{
		}

		// Token: 0x0600B2D3 RID: 45779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2D3")]
		[Address(RVA = "0x2423F78", Offset = "0x2423F78", VA = "0x7BBCC23F78")]
		private void OnFileDownloadedNotify(ResErrorCode error, ResDownloadType type, ResVersionInfo.FileInfo file_info)
		{
		}

		// Token: 0x0600B2D4 RID: 45780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2D4")]
		[Address(RVA = "0x24240CC", Offset = "0x24240CC", VA = "0x7BBCC240CC")]
		private void OnSingleFileDownloadedFinished(ResErrorCode error, ResDownloadType type, ResVersionInfo.FileInfo file_info)
		{
		}

		// Token: 0x0600B2D5 RID: 45781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2D5")]
		[Address(RVA = "0x24244C8", Offset = "0x24244C8", VA = "0x7BBCC244C8")]
		private void OnDownloadedFinished(ResErrorCode error, ResDownloadType type)
		{
		}

		// Token: 0x0600B2D6 RID: 45782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2D6")]
		[Address(RVA = "0x241F758", Offset = "0x241F758", VA = "0x7BBCC1F758")]
		private void ClearNetWorkTypeCache()
		{
		}

		// Token: 0x0600B2D7 RID: 45783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2D7")]
		[Address(RVA = "0x241FA88", Offset = "0x241FA88", VA = "0x7BBCC1FA88")]
		private void CacheNetWorkType()
		{
		}

		// Token: 0x0600B2D8 RID: 45784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2D8")]
		[Address(RVA = "0x2424838", Offset = "0x2424838", VA = "0x7BBCC24838")]
		private void OnNetWorkCheck()
		{
		}

		// Token: 0x0600B2D9 RID: 45785 RVA: 0x000327C0 File Offset: 0x000309C0
		[Token(Token = "0x600B2D9")]
		[Address(RVA = "0x24249A4", Offset = "0x24249A4", VA = "0x7BBCC249A4")]
		public bool CheckErrorWithDownloadInfo()
		{
			return default(bool);
		}

		// Token: 0x0600B2DA RID: 45786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2DA")]
		[Address(RVA = "0x2421934", Offset = "0x2421934", VA = "0x7BBCC21934")]
		private void RefreshDownloadInfoList(bool need_add_fileinfo = false)
		{
		}

		// Token: 0x0600B2DB RID: 45787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2DB")]
		[Address(RVA = "0x2424B18", Offset = "0x2424B18", VA = "0x7BBCC24B18")]
		public void ResortDownloadInfo()
		{
		}

		// Token: 0x0600B2DC RID: 45788 RVA: 0x000327D8 File Offset: 0x000309D8
		[Token(Token = "0x600B2DC")]
		[Address(RVA = "0x2424C4C", Offset = "0x2424C4C", VA = "0x7BBCC24C4C")]
		public long GetZipSizeWithResID(ResourceID[] res_id_list, [Optional] HashSet<ResVersionInfo.FileInfo> added_file_list)
		{
			return 0L;
		}

		// Token: 0x0600B2DD RID: 45789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2DD")]
		[Address(RVA = "0x24251E0", Offset = "0x24251E0", VA = "0x7BBCC251E0")]
		public string GetHintPackNameWithResID(ResourceID[] res_id_list)
		{
			return null;
		}

		// Token: 0x0600B2DE RID: 45790 RVA: 0x000327F0 File Offset: 0x000309F0
		[Token(Token = "0x600B2DE")]
		[Address(RVA = "0x2424D2C", Offset = "0x2424D2C", VA = "0x7BBCC24D2C")]
		public long GetZipSizeWithResID(ResourceID res_id, [Optional] HashSet<ResVersionInfo.FileInfo> added_file_list)
		{
			return 0L;
		}

		// Token: 0x0600B2DF RID: 45791 RVA: 0x00032808 File Offset: 0x00030A08
		[Token(Token = "0x600B2DF")]
		[Address(RVA = "0x2425608", Offset = "0x2425608", VA = "0x7BBCC25608")]
		public bool NeedSecondConfirmForDownloadSingleFile(ResourceID[] res_id_list)
		{
			return default(bool);
		}

		// Token: 0x0600B2E0 RID: 45792 RVA: 0x00032820 File Offset: 0x00030A20
		[Token(Token = "0x600B2E0")]
		[Address(RVA = "0x2425694", Offset = "0x2425694", VA = "0x7BBCC25694")]
		public bool NeedSecondConfirmForDownloadSingleFile(ResourceID res_id)
		{
			return default(bool);
		}

		// Token: 0x0600B2E1 RID: 45793 RVA: 0x00032838 File Offset: 0x00030A38
		[Token(Token = "0x600B2E1")]
		[Address(RVA = "0x2425810", Offset = "0x2425810", VA = "0x7BBCC25810")]
		public ResErrorCode GetLastErrorCode(ResDownloadType type)
		{
			return ResErrorCode.OK;
		}

		// Token: 0x0600B2E2 RID: 45794 RVA: 0x00032850 File Offset: 0x00030A50
		[Token(Token = "0x600B2E2")]
		[Address(RVA = "0x24258A4", Offset = "0x24258A4", VA = "0x7BBCC258A4")]
		public ResErrorCode GetSingleFileLaseErr(ResVersionInfo.FileInfo fileInfo)
		{
			return ResErrorCode.OK;
		}

		// Token: 0x0600B2E3 RID: 45795 RVA: 0x00032868 File Offset: 0x00030A68
		[Token(Token = "0x600B2E3")]
		[Address(RVA = "0x2422698", Offset = "0x2422698", VA = "0x7BBCC22698")]
		public bool HasBeingDeleted(ResDownloadType type)
		{
			return default(bool);
		}

		// Token: 0x0600B2E4 RID: 45796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2E4")]
		[Address(RVA = "0x2423694", Offset = "0x2423694", VA = "0x7BBCC23694")]
		public void DeletedType(ResDownloadType type)
		{
		}

		// Token: 0x0600B2E5 RID: 45797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2E5")]
		[Address(RVA = "0x2422FFC", Offset = "0x2422FFC", VA = "0x7BBCC22FFC")]
		public void ClearDeletedType(ResDownloadType type)
		{
		}

		// Token: 0x0600B2E6 RID: 45798 RVA: 0x00032880 File Offset: 0x00030A80
		[Token(Token = "0x600B2E6")]
		[Address(RVA = "0x242592C", Offset = "0x242592C", VA = "0x7BBCC2592C")]
		public bool HaveFinishedOptionalDownloadActivity()
		{
			return default(bool);
		}

		// Token: 0x0600B2E7 RID: 45799 RVA: 0x00032898 File Offset: 0x00030A98
		[Token(Token = "0x600B2E7")]
		[Address(RVA = "0x2425ACC", Offset = "0x2425ACC", VA = "0x7BBCC25ACC")]
		public bool IsAllOptionalDownloadActivityAwarded()
		{
			return default(bool);
		}

		// Token: 0x0600B2E8 RID: 45800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2E8")]
		[Address(RVA = "0x2425C74", Offset = "0x2425C74", VA = "0x7BBCC25C74")]
		public void UpdateActivityStateWithDownloadType(ResDownloadType type, ActivityClientInfo info)
		{
		}

		// Token: 0x0600B2E9 RID: 45801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2E9")]
		[Address(RVA = "0x2425DB8", Offset = "0x2425DB8", VA = "0x7BBCC25DB8")]
		public void CheckActivityState()
		{
		}

		// Token: 0x0600B2EA RID: 45802 RVA: 0x000328B0 File Offset: 0x00030AB0
		[Token(Token = "0x600B2EA")]
		[Address(RVA = "0x2425F88", Offset = "0x2425F88", VA = "0x7BBCC25F88")]
		public EActivity.State GetActivityStateByDownloadType(ResDownloadType type, out bool have_activity_info)
		{
			return EActivity.State.State_RECEIVED;
		}

		// Token: 0x0600B2EB RID: 45803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2EB")]
		[Address(RVA = "0x2426034", Offset = "0x2426034", VA = "0x7BBCC26034")]
		public void AwardByDownloadType(ResDownloadType type)
		{
		}

		// Token: 0x0600B2EC RID: 45804 RVA: 0x000328C8 File Offset: 0x00030AC8
		[Token(Token = "0x600B2EC")]
		[Address(RVA = "0x241FFFC", Offset = "0x241FFFC", VA = "0x7BBCC1FFFC")]
		private float GetTargetUnzipSpeed(bool is_speed_up)
		{
			return 0f;
		}

		// Token: 0x0600B2ED RID: 45805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2ED")]
		[Address(RVA = "0x2426148", Offset = "0x2426148", VA = "0x7BBCC26148")]
		public void StartSpeedUp()
		{
		}

		// Token: 0x0600B2EE RID: 45806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2EE")]
		[Address(RVA = "0x24262FC", Offset = "0x24262FC", VA = "0x7BBCC262FC")]
		public void BackToNormalSpeed()
		{
		}

		// Token: 0x0600B2EF RID: 45807 RVA: 0x000328E0 File Offset: 0x00030AE0
		[Token(Token = "0x600B2EF")]
		[Address(RVA = "0x2426404", Offset = "0x2426404", VA = "0x7BBCC26404")]
		public bool IsTipsStateReady()
		{
			return default(bool);
		}

		// Token: 0x0600B2F0 RID: 45808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2F0")]
		[Address(RVA = "0x2426484", Offset = "0x2426484", VA = "0x7BBCC26484")]
		public void SetLocalClothReadyState(bool is_ready, List<uint> need_download_list)
		{
		}

		// Token: 0x0600B2F1 RID: 45809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2F1")]
		[Address(RVA = "0x2426580", Offset = "0x2426580", VA = "0x7BBCC26580")]
		public void SetLocalPetSkinReadyState(bool is_ready)
		{
		}

		// Token: 0x0600B2F2 RID: 45810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2F2")]
		[Address(RVA = "0x2426640", Offset = "0x2426640", VA = "0x7BBCC26640")]
		public void DownloadLocalClothFirst()
		{
		}

		// Token: 0x0600B2F3 RID: 45811 RVA: 0x000328F8 File Offset: 0x00030AF8
		[Token(Token = "0x600B2F3")]
		[Address(RVA = "0x2426810", Offset = "0x2426810", VA = "0x7BBCC26810")]
		public bool NeedShowUpdateTips()
		{
			return default(bool);
		}

		// Token: 0x0600B2F4 RID: 45812 RVA: 0x00032910 File Offset: 0x00030B10
		[Token(Token = "0x600B2F4")]
		[Address(RVA = "0x24268BC", Offset = "0x24268BC", VA = "0x7BBCC268BC")]
		public bool NeedShowPetSkinDownloadTips()
		{
			return default(bool);
		}

		// Token: 0x0600B2F5 RID: 45813 RVA: 0x00032928 File Offset: 0x00030B28
		[Token(Token = "0x600B2F5")]
		[Address(RVA = "0x242696C", Offset = "0x242696C", VA = "0x7BBCC2696C")]
		public bool NeedShowClothesDownloadTips()
		{
			return default(bool);
		}

		// Token: 0x0600B2F6 RID: 45814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2F6")]
		[Address(RVA = "0x24221B4", Offset = "0x24221B4", VA = "0x7BBCC221B4")]
		public void SetDownloadCentreVisible(uint flag, bool visible)
		{
		}

		// Token: 0x0600B2F7 RID: 45815 RVA: 0x00032940 File Offset: 0x00030B40
		[Token(Token = "0x600B2F7")]
		[Address(RVA = "0x2426A1C", Offset = "0x2426A1C", VA = "0x7BBCC26A1C")]
		public EDownloadContextState GetDownloadContextStateByType(ResDownloadType type)
		{
			return EDownloadContextState.None;
		}

		// Token: 0x0600B2F8 RID: 45816 RVA: 0x00032958 File Offset: 0x00030B58
		[Token(Token = "0x600B2F8")]
		[Address(RVA = "0x2426ABC", Offset = "0x2426ABC", VA = "0x7BBCC26ABC")]
		public bool IsMapDownloading(List<ResourceID> mapRes)
		{
			return default(bool);
		}

		// Token: 0x0600B2F9 RID: 45817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2F9")]
		[Address(RVA = "0x2426D54", Offset = "0x2426D54", VA = "0x7BBCC26D54")]
		public UIModelOptionalDownload()
		{
		}

		// Token: 0x0600B2FB RID: 45819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2FB")]
		[Address(RVA = "0x2426EE4", Offset = "0x2426EE4", VA = "0x7BBCC26EE4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146C3C", Offset = "0x1146C3C")]
		private void <CheckOptionalVersionInLauncher>b__50_0()
		{
		}

		// Token: 0x0600B2FC RID: 45820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2FC")]
		[Address(RVA = "0x242701C", Offset = "0x242701C", VA = "0x7BBCC2701C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146C4C", Offset = "0x1146C4C")]
		private void <CheckOptionalVersion>b__51_0()
		{
		}

		// Token: 0x0600B2FD RID: 45821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2FD")]
		[Address(RVA = "0x242715C", Offset = "0x242715C", VA = "0x7BBCC2715C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146C5C", Offset = "0x1146C5C")]
		private void <StartSpeedUp>b__104_0()
		{
		}

		// Token: 0x0400B59C RID: 46492
		[Token(Token = "0x400B59C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<ResDownloadType> m_DownloadTypeList;

		// Token: 0x0400B59D RID: 46493
		[Token(Token = "0x400B59D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<DownloadInfo> m_DownloadInfoList;

		// Token: 0x0400B59E RID: 46494
		[Token(Token = "0x400B59E")]
		public const uint PropID_VersionChecked = 2U;

		// Token: 0x0400B59F RID: 46495
		[Token(Token = "0x400B59F")]
		public const uint PropID_NotifyAssetRefresh = 4U;

		// Token: 0x0400B5A0 RID: 46496
		[Token(Token = "0x400B5A0")]
		public const uint PropID_DownloadFinished = 8U;

		// Token: 0x0400B5A1 RID: 46497
		[Token(Token = "0x400B5A1")]
		public const uint PropID_SingleFileDownloadFinished = 16U;

		// Token: 0x0400B5A2 RID: 46498
		[Token(Token = "0x400B5A2")]
		public const uint PropID_InfoListRefreshed = 32U;

		// Token: 0x0400B5A3 RID: 46499
		[Token(Token = "0x400B5A3")]
		public const uint PropID_ActivityStateRefreshed = 64U;

		// Token: 0x0400B5A4 RID: 46500
		[Token(Token = "0x400B5A4")]
		public const uint PropID_TipsStateRefreshed = 128U;

		// Token: 0x0400B5A5 RID: 46501
		[Token(Token = "0x400B5A5")]
		public const uint PropID_AllFileDownloaded = 256U;

		// Token: 0x0400B5A6 RID: 46502
		[Token(Token = "0x400B5A6")]
		public const uint PropID_DownloadCentreVisibleRefresh = 512U;

		// Token: 0x0400B5A7 RID: 46503
		[Token(Token = "0x400B5A7")]
		private const string NOTIFY_FINISHIED_KEY = "OptionalDownload";

		// Token: 0x0400B5A8 RID: 46504
		[Token(Token = "0x400B5A8")]
		private const string DELTED_KEY = "_Deleted";

		// Token: 0x0400B5A9 RID: 46505
		[Token(Token = "0x400B5A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private EModelDownloadState m_DownloadState;

		// Token: 0x0400B5AA RID: 46506
		[Token(Token = "0x400B5AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool? m_LocalClothReady;

		// Token: 0x0400B5AB RID: 46507
		[Token(Token = "0x400B5AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		private bool? m_LocalPetSkinReady;

		// Token: 0x0400B5AC RID: 46508
		[Token(Token = "0x400B5AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool? m_HaveVersionUpdate;

		// Token: 0x0400B5AD RID: 46509
		[Token(Token = "0x400B5AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113031C", Offset = "0x113031C")]
		private bool <InSpeedUp>k__BackingField;

		// Token: 0x0400B5AE RID: 46510
		[Token(Token = "0x400B5AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private uint m_SpeedUpDelayCall;

		// Token: 0x0400B5AF RID: 46511
		[Token(Token = "0x400B5AF")]
		private const float CHECK_NETWORK_TIME = 5f;

		// Token: 0x0400B5B0 RID: 46512
		[Token(Token = "0x400B5B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_LastCacheNetworkType;

		// Token: 0x0400B5B1 RID: 46513
		[Token(Token = "0x400B5B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private uint m_CheckNetwork_DelayCallID;

		// Token: 0x0400B5B2 RID: 46514
		[Token(Token = "0x400B5B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<ResVersionInfo.FileInfo, ResErrorCode> m_SingleFileLastErrorMap;

		// Token: 0x0400B5B3 RID: 46515
		[Token(Token = "0x400B5B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<ResDownloadType, ActivityClientInfo> m_ActivityInfoMap;

		// Token: 0x0400B5B4 RID: 46516
		[Token(Token = "0x400B5B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<uint> m_NeedDownloadCloths;

		// Token: 0x0400B5B5 RID: 46517
		[Token(Token = "0x400B5B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BitArrayBoolean m_NeedShowCentre;

		// Token: 0x0400B5B6 RID: 46518
		[Token(Token = "0x400B5B6")]
		private const uint ShowCentreFlag_Activity = 2U;

		// Token: 0x0400B5B7 RID: 46519
		[Token(Token = "0x400B5B7")]
		private const uint ShowCentreFlag_NeedDownload = 4U;

		// Token: 0x0400B5B8 RID: 46520
		[Token(Token = "0x400B5B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool EnableAutoDownload;

		// Token: 0x02001F8F RID: 8079
		[Token(Token = "0x2001F8F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD394", Offset = "0x10FD394")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B2FF RID: 45823 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B2FF")]
			[Address(RVA = "0x24271CC", Offset = "0x24271CC", VA = "0x7BBCC271CC")]
			public <>c()
			{
			}

			// Token: 0x0600B300 RID: 45824 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B300")]
			[Address(RVA = "0x24271D4", Offset = "0x24271D4", VA = "0x7BBCC271D4")]
			internal void <NotifyService>b__77_0(HttpErrorCode error, object res)
			{
			}

			// Token: 0x0600B301 RID: 45825 RVA: 0x00032970 File Offset: 0x00030B70
			[Token(Token = "0x600B301")]
			[Address(RVA = "0x24271D8", Offset = "0x24271D8", VA = "0x7BBCC271D8")]
			internal int <ResortDownloadInfo>b__86_0(DownloadInfo a, DownloadInfo b)
			{
				return 0;
			}

			// Token: 0x0400B5B9 RID: 46521
			[Token(Token = "0x400B5B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIModelOptionalDownload.<>c <>9;

			// Token: 0x0400B5BA RID: 46522
			[Token(Token = "0x400B5BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action<HttpErrorCode, object> <>9__77_0;

			// Token: 0x0400B5BB RID: 46523
			[Token(Token = "0x400B5BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Comparison<DownloadInfo> <>9__86_0;
		}
	}
}
