using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace GCommon
{
	// Token: 0x02000FE2 RID: 4066
	[Token(Token = "0x2000FE2")]
	public class ResUpdateDownloadContext : DownloadContext
	{
		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06003BE5 RID: 15333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000706")]
		public List<ResVersionInfo.FileInfo> NeedRetryFileInfo
		{
			[Token(Token = "0x6003BE5")]
			[Address(RVA = "0x29738B0", Offset = "0x29738B0", VA = "0x7BBD1738B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06003BE6 RID: 15334 RVA: 0x00012B10 File Offset: 0x00010D10
		[Token(Token = "0x17000707")]
		public bool IsPendding
		{
			[Token(Token = "0x6003BE6")]
			[Address(RVA = "0x29738B8", Offset = "0x29738B8", VA = "0x7BBD1738B8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06003BE7 RID: 15335 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003BE8 RID: 15336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000708")]
		public string CacheAddr
		{
			[Token(Token = "0x6003BE7")]
			[Address(RVA = "0x29739CC", Offset = "0x29739CC", VA = "0x7BBD1739CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BD08", Offset = "0x113BD08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BE8")]
			[Address(RVA = "0x29739D4", Offset = "0x29739D4", VA = "0x7BBD1739D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BD18", Offset = "0x113BD18")]
			protected set
			{
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06003BE9 RID: 15337 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003BEA RID: 15338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000709")]
		public string OldVersionCacheAddr
		{
			[Token(Token = "0x6003BE9")]
			[Address(RVA = "0x29739DC", Offset = "0x29739DC", VA = "0x7BBD1739DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BD28", Offset = "0x113BD28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003BEA")]
			[Address(RVA = "0x29739E4", Offset = "0x29739E4", VA = "0x7BBD1739E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BD38", Offset = "0x113BD38")]
			protected set
			{
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06003BEB RID: 15339 RVA: 0x00012B28 File Offset: 0x00010D28
		// (set) Token: 0x06003BEC RID: 15340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070A")]
		public bool NeedDownload
		{
			[Token(Token = "0x6003BEB")]
			[Address(RVA = "0x29739EC", Offset = "0x29739EC", VA = "0x7BBD1739EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BD48", Offset = "0x113BD48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BEC")]
			[Address(RVA = "0x29739F4", Offset = "0x29739F4", VA = "0x7BBD1739F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BD58", Offset = "0x113BD58")]
			protected set
			{
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x00012B40 File Offset: 0x00010D40
		// (set) Token: 0x06003BEE RID: 15342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070B")]
		public bool NeedCheckVersion
		{
			[Token(Token = "0x6003BED")]
			[Address(RVA = "0x2973A00", Offset = "0x2973A00", VA = "0x7BBD173A00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BD68", Offset = "0x113BD68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BEE")]
			[Address(RVA = "0x2973A08", Offset = "0x2973A08", VA = "0x7BBD173A08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BD78", Offset = "0x113BD78")]
			protected set
			{
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06003BEF RID: 15343 RVA: 0x00012B58 File Offset: 0x00010D58
		// (set) Token: 0x06003BF0 RID: 15344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070C")]
		public bool RunningCheckVersion
		{
			[Token(Token = "0x6003BEF")]
			[Address(RVA = "0x2973A14", Offset = "0x2973A14", VA = "0x7BBD173A14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BD88", Offset = "0x113BD88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BF0")]
			[Address(RVA = "0x2973A1C", Offset = "0x2973A1C", VA = "0x7BBD173A1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BD98", Offset = "0x113BD98")]
			protected set
			{
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x00012B70 File Offset: 0x00010D70
		// (set) Token: 0x06003BF2 RID: 15346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070D")]
		public long DownloadedSize
		{
			[Token(Token = "0x6003BF1")]
			[Address(RVA = "0x2973A28", Offset = "0x2973A28", VA = "0x7BBD173A28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BDA8", Offset = "0x113BDA8")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6003BF2")]
			[Address(RVA = "0x2973A30", Offset = "0x2973A30", VA = "0x7BBD173A30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BDB8", Offset = "0x113BDB8")]
			protected set
			{
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06003BF3 RID: 15347 RVA: 0x00012B88 File Offset: 0x00010D88
		// (set) Token: 0x06003BF4 RID: 15348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070E")]
		public long TotalZipSize
		{
			[Token(Token = "0x6003BF3")]
			[Address(RVA = "0x2973A38", Offset = "0x2973A38", VA = "0x7BBD173A38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BDC8", Offset = "0x113BDC8")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6003BF4")]
			[Address(RVA = "0x2973A40", Offset = "0x2973A40", VA = "0x7BBD173A40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BDD8", Offset = "0x113BDD8")]
			protected set
			{
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06003BF5 RID: 15349 RVA: 0x00012BA0 File Offset: 0x00010DA0
		// (set) Token: 0x06003BF6 RID: 15350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700070F")]
		public long TotalSize
		{
			[Token(Token = "0x6003BF5")]
			[Address(RVA = "0x2973A48", Offset = "0x2973A48", VA = "0x7BBD173A48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BDE8", Offset = "0x113BDE8")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6003BF6")]
			[Address(RVA = "0x2973A50", Offset = "0x2973A50", VA = "0x7BBD173A50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BDF8", Offset = "0x113BDF8")]
			protected set
			{
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06003BF7 RID: 15351 RVA: 0x00012BB8 File Offset: 0x00010DB8
		// (set) Token: 0x06003BF8 RID: 15352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000710")]
		public bool NeedContinueWithDownloadAll
		{
			[Token(Token = "0x6003BF7")]
			[Address(RVA = "0x2973A58", Offset = "0x2973A58", VA = "0x7BBD173A58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BE08", Offset = "0x113BE08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003BF8")]
			[Address(RVA = "0x2973A60", Offset = "0x2973A60", VA = "0x7BBD173A60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BE18", Offset = "0x113BE18")]
			private set
			{
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06003BF9 RID: 15353 RVA: 0x00012BD0 File Offset: 0x00010DD0
		// (set) Token: 0x06003BFA RID: 15354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000711")]
		public EDownloadContextMode DownloadMode
		{
			[Token(Token = "0x6003BF9")]
			[Address(RVA = "0x2973A6C", Offset = "0x2973A6C", VA = "0x7BBD173A6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BE28", Offset = "0x113BE28")]
			get
			{
				return EDownloadContextMode.AllFile;
			}
			[Token(Token = "0x6003BFA")]
			[Address(RVA = "0x2973A74", Offset = "0x2973A74", VA = "0x7BBD173A74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BE38", Offset = "0x113BE38")]
			protected set
			{
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06003BFB RID: 15355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000712")]
		public string Version
		{
			[Token(Token = "0x6003BFB")]
			[Address(RVA = "0x2973A7C", Offset = "0x2973A7C", VA = "0x7BBD173A7C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003BFC RID: 15356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BFC")]
		[Address(RVA = "0x2973AE0", Offset = "0x2973AE0", VA = "0x7BBD173AE0")]
		public ResUpdateDownloadContext(ResUpdateDownloadEngine owned_engine, ResDownloadType type, int maxLoaderCountSimultaneously)
		{
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BFD")]
		[Address(RVA = "0x2973FDC", Offset = "0x2973FDC", VA = "0x7BBD173FDC", Slot = "4")]
		public override void Clear()
		{
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BFE")]
		[Address(RVA = "0x29740A0", Offset = "0x29740A0", VA = "0x7BBD1740A0")]
		public void WWWLoad(string path, Action<WWW, ResWWWFileLoader> onLoaded, bool isFromRemote, long totalSize = 0L, bool includeVersionDir = true, [Optional] ResVersionInfo.FileInfo file_info)
		{
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BFF")]
		[Address(RVA = "0x297441C", Offset = "0x297441C", VA = "0x7BBD17441C")]
		public void BigFileDownload(ResVersionInfo.FileInfo file_info, string path, Action<UnityWebRequest, ResWithTempFileLoader> onLoaded)
		{
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C00")]
		[Address(RVA = "0x29748C4", Offset = "0x29748C4", VA = "0x7BBD1748C4")]
		public void Unzip(ResVersionInfo.FileInfo file_info, Action<string, ResUnzipFileLoader> onLoaded, bool addProgressSize = false, bool addFirst = false)
		{
		}

		// Token: 0x06003C01 RID: 15361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C01")]
		[Address(RVA = "0x2974BC4", Offset = "0x2974BC4", VA = "0x7BBD174BC4")]
		public string GetLocalPathByPlatfromByFileInfo(ResVersionInfo.FileInfo fileInfo, ResVersionInfo.FileInfo.OpState targetState, bool need_cache = true)
		{
			return null;
		}

		// Token: 0x06003C02 RID: 15362 RVA: 0x00012BE8 File Offset: 0x00010DE8
		[Token(Token = "0x6003C02")]
		[Address(RVA = "0x2974E44", Offset = "0x2974E44", VA = "0x7BBD174E44")]
		protected bool SaveFile(string path, byte[] content)
		{
			return default(bool);
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x00012C00 File Offset: 0x00010E00
		[Token(Token = "0x6003C03")]
		[Address(RVA = "0x297517C", Offset = "0x297517C", VA = "0x7BBD17517C")]
		protected bool MoveTempFile(string relativePath, string tempPath)
		{
			return default(bool);
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C04")]
		[Address(RVA = "0x2975420", Offset = "0x2975420", VA = "0x7BBD175420")]
		protected void ClearTempFile(string tempPath, [Optional] string flagPath)
		{
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C05")]
		[Address(RVA = "0x29755B8", Offset = "0x29755B8", VA = "0x7BBD1755B8")]
		public void ClearAllTempFile()
		{
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C06")]
		[Address(RVA = "0x2975884", Offset = "0x2975884", VA = "0x7BBD175884")]
		public void CleanCache()
		{
		}

		// Token: 0x06003C07 RID: 15367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C07")]
		[Address(RVA = "0x2975AE4", Offset = "0x2975AE4", VA = "0x7BBD175AE4")]
		public void CleanFiltCache()
		{
		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C08")]
		[Address(RVA = "0x2975D6C", Offset = "0x2975D6C", VA = "0x7BBD175D6C")]
		public void CleanCache(string file_name)
		{
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C09")]
		[Address(RVA = "0x2976050", Offset = "0x2976050", VA = "0x7BBD176050", Slot = "8")]
		public virtual void DeleteAllFile()
		{
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0A")]
		[Address(RVA = "0x29765DC", Offset = "0x29765DC", VA = "0x7BBD1765DC")]
		public void DeleleAllReplacedFiles()
		{
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0B")]
		[Address(RVA = "0x2976868", Offset = "0x2976868", VA = "0x7BBD176868", Slot = "6")]
		public override void StartDownload([Optional] Action<ResErrorCode, ResDownloadType> callback)
		{
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0C")]
		[Address(RVA = "0x2976C20", Offset = "0x2976C20", VA = "0x7BBD176C20")]
		public void StartDownloadAllFile(Action<ResErrorCode, ResDownloadType> callback, [Optional] Action<ResErrorCode, ResDownloadType, ResVersionInfo.FileInfo> file_downloaded_notify)
		{
		}

		// Token: 0x06003C0D RID: 15373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0D")]
		[Address(RVA = "0x29776A0", Offset = "0x29776A0", VA = "0x7BBD1776A0")]
		public void StartDownloadDesignatedFile(string ab_path, [Optional] Action<ResErrorCode, ResDownloadType> callback, [Optional] Action<ResErrorCode, ResDownloadType, ResVersionInfo.FileInfo> single_file_call_back)
		{
		}

		// Token: 0x06003C0E RID: 15374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0E")]
		[Address(RVA = "0x2977B50", Offset = "0x2977B50", VA = "0x7BBD177B50", Slot = "5")]
		public override void PauseDownload(bool isPause)
		{
		}

		// Token: 0x06003C0F RID: 15375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C0F")]
		[Address(RVA = "0x2977E54", Offset = "0x2977E54", VA = "0x7BBD177E54", Slot = "9")]
		public virtual void StartGetLocalVersion([Optional] Action<ResDownloadType> on_version_check_finished)
		{
		}

		// Token: 0x06003C10 RID: 15376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C10")]
		[Address(RVA = "0x2977F90", Offset = "0x2977F90", VA = "0x7BBD177F90")]
		protected void onLocalVersionInfoLoaded(bool result)
		{
		}

		// Token: 0x06003C11 RID: 15377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C11")]
		[Address(RVA = "0x29780C4", Offset = "0x29780C4", VA = "0x7BBD1780C4", Slot = "10")]
		public virtual void StartVersionCheck()
		{
		}

		// Token: 0x06003C12 RID: 15378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C12")]
		[Address(RVA = "0x29784C0", Offset = "0x29784C0", VA = "0x7BBD1784C0", Slot = "11")]
		protected virtual void onRemoteVersionInfoLoaded(bool result)
		{
		}

		// Token: 0x06003C13 RID: 15379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C13")]
		[Address(RVA = "0x29786C4", Offset = "0x29786C4", VA = "0x7BBD1786C4")]
		private void onLocalFileInfoLoaded_Pass(bool result)
		{
		}

		// Token: 0x06003C14 RID: 15380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C14")]
		[Address(RVA = "0x2978778", Offset = "0x2978778", VA = "0x7BBD178778")]
		protected void onLocalFileInfoLoaded_Update(bool result)
		{
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C15")]
		[Address(RVA = "0x2978898", Offset = "0x2978898", VA = "0x7BBD178898", Slot = "12")]
		protected virtual void onRemoteFileInfoLoaded(bool result)
		{
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C16")]
		[Address(RVA = "0x29783EC", Offset = "0x29783EC", VA = "0x7BBD1783EC")]
		protected void onVersionChecked()
		{
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C17")]
		[Address(RVA = "0x2977B94", Offset = "0x2977B94", VA = "0x7BBD177B94")]
		public void CheckFileStates()
		{
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C18")]
		[Address(RVA = "0x2976104", Offset = "0x2976104", VA = "0x7BBD176104")]
		protected void CheckNeedDownload(bool refresh_last_download = false)
		{
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C19")]
		[Address(RVA = "0x29791E8", Offset = "0x29791E8", VA = "0x7BBD1791E8")]
		private void UpdateNeedDownloadSize([Optional] ResVersionInfo.FileInfo fileInfo, bool is_unzip = false)
		{
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C1A")]
		[Address(RVA = "0x2979438", Offset = "0x2979438", VA = "0x7BBD179438")]
		protected void NotifyFileDownloaded(ResErrorCode result, ResFileLoader loader)
		{
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C1B")]
		[Address(RVA = "0x297964C", Offset = "0x297964C", VA = "0x7BBD17964C")]
		protected void NotifyFileUnZipped(string hash_code, ResUnzipFileLoader unzip_loader)
		{
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C1C")]
		[Address(RVA = "0x2979C10", Offset = "0x2979C10", VA = "0x7BBD179C10")]
		public ResVersionInfo.FileInfo GetCurrentDownloadFileInfo()
		{
			return null;
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C1D")]
		[Address(RVA = "0x297768C", Offset = "0x297768C", VA = "0x7BBD17768C")]
		public void UpdateLastError(ResErrorCode error)
		{
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x00012C18 File Offset: 0x00010E18
		[Token(Token = "0x6003C1E")]
		[Address(RVA = "0x2979C20", Offset = "0x2979C20", VA = "0x7BBD179C20")]
		public ResErrorCode GetDetailedDownloadError(string error)
		{
			return ResErrorCode.OK;
		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C1F")]
		[Address(RVA = "0x2977A48", Offset = "0x2977A48", VA = "0x7BBD177A48")]
		public ResVersionInfo.FileInfo GetLocalFileInfo(string path)
		{
			return null;
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C20")]
		[Address(RVA = "0x2979C84", Offset = "0x2979C84", VA = "0x7BBD179C84")]
		public List<ResVersionInfo.FileInfo> GetNeedDownloadFileInfos()
		{
			return null;
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x00012C30 File Offset: 0x00010E30
		[Token(Token = "0x6003C21")]
		[Address(RVA = "0x2979C98", Offset = "0x2979C98", VA = "0x7BBD179C98")]
		public bool ABFileExist(string ab_path)
		{
			return default(bool);
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x00012C48 File Offset: 0x00010E48
		[Token(Token = "0x6003C22")]
		[Address(RVA = "0x2979CBC", Offset = "0x2979CBC", VA = "0x7BBD179CBC")]
		public bool FileExist(ResVersionInfo.FileInfo fileInfo)
		{
			return default(bool);
		}

		// Token: 0x06003C23 RID: 15395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C23")]
		[Address(RVA = "0x2979D40", Offset = "0x2979D40", VA = "0x7BBD179D40")]
		public string GetLocalPathByPlatfrom(string path)
		{
			return null;
		}

		// Token: 0x06003C24 RID: 15396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C24")]
		[Address(RVA = "0x2979DD4", Offset = "0x2979DD4", VA = "0x7BBD179DD4", Slot = "7")]
		public override void InvokeFinishCallBack()
		{
		}

		// Token: 0x06003C25 RID: 15397 RVA: 0x00012C60 File Offset: 0x00010E60
		[Token(Token = "0x6003C25")]
		[Address(RVA = "0x2977608", Offset = "0x2977608", VA = "0x7BBD177608")]
		protected bool HaveEnoughStorage(long require_size)
		{
			return default(bool);
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C26")]
		[Address(RVA = "0x2979EA8", Offset = "0x2979EA8", VA = "0x7BBD179EA8")]
		public ResLoaderInfo GetLoaderByFileInfo(ResVersionInfo.FileInfo info)
		{
			return null;
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x00012C78 File Offset: 0x00010E78
		[Token(Token = "0x6003C27")]
		[Address(RVA = "0x2979F30", Offset = "0x2979F30", VA = "0x7BBD179F30")]
		public bool IsInPending()
		{
			return default(bool);
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x00012C90 File Offset: 0x00010E90
		[Token(Token = "0x6003C28")]
		[Address(RVA = "0x2979F6C", Offset = "0x2979F6C", VA = "0x7BBD179F6C")]
		public long GetTotalSizeInByte()
		{
			return 0L;
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x00012CA8 File Offset: 0x00010EA8
		[Token(Token = "0x6003C29")]
		[Address(RVA = "0x2979F84", Offset = "0x2979F84", VA = "0x7BBD179F84")]
		public long GetTotalLoadedSizeInByte()
		{
			return 0L;
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x00012CC0 File Offset: 0x00010EC0
		[Token(Token = "0x6003C2A")]
		[Address(RVA = "0x2979FA0", Offset = "0x2979FA0", VA = "0x7BBD179FA0", Slot = "13")]
		public virtual float GetFileDownloadProcess()
		{
			return 0f;
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C2B")]
		[Address(RVA = "0x297A050", Offset = "0x297A050", VA = "0x7BBD17A050")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BE48", Offset = "0x113BE48")]
		private void <StartDownloadAllFile>b__89_0(UnityWebRequest www, ResWithTempFileLoader loader)
		{
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C2C")]
		[Address(RVA = "0x297A620", Offset = "0x297A620", VA = "0x7BBD17A620")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BE58", Offset = "0x113BE58")]
		private void <StartDownloadAllFile>b__89_1(string hashCode, ResUnzipFileLoader unzip_loader)
		{
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C2D")]
		[Address(RVA = "0x297A624", Offset = "0x297A624", VA = "0x7BBD17A624")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BE68", Offset = "0x113BE68")]
		private void <StartDownloadDesignatedFile>b__90_0(UnityWebRequest www, ResWithTempFileLoader loader)
		{
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C2E")]
		[Address(RVA = "0x297ABF4", Offset = "0x297ABF4", VA = "0x7BBD17ABF4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BE78", Offset = "0x113BE78")]
		private void <StartDownloadDesignatedFile>b__90_1(string hashCode, ResUnzipFileLoader unzip_loader)
		{
		}

		// Token: 0x06003C2F RID: 15407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C2F")]
		[Address(RVA = "0x297ABF8", Offset = "0x297ABF8", VA = "0x7BBD17ABF8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BE88", Offset = "0x113BE88")]
		private void <NotifyFileDownloaded>b__103_0(string hashCode, ResUnzipFileLoader unzip_loader)
		{
		}

		// Token: 0x04004D4A RID: 19786
		[Token(Token = "0x4004D4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int MaxOptionalDownloadThreadCount;

		// Token: 0x04004D4B RID: 19787
		[Token(Token = "0x4004D4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int MultiDownloadGCIndex;

		// Token: 0x04004D4C RID: 19788
		[Token(Token = "0x4004D4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int MaxRetryCount;

		// Token: 0x04004D4D RID: 19789
		[Token(Token = "0x4004D4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string RemoteAddr;

		// Token: 0x04004D4E RID: 19790
		[Token(Token = "0x4004D4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string LocalAddr;

		// Token: 0x04004D4F RID: 19791
		[Token(Token = "0x4004D4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string TempCacheAddr;

		// Token: 0x04004D50 RID: 19792
		[Token(Token = "0x4004D50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string VersionInfoPath;

		// Token: 0x04004D51 RID: 19793
		[Token(Token = "0x4004D51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string FileInfoPath;

		// Token: 0x04004D52 RID: 19794
		[Token(Token = "0x4004D52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string AssetBundlePrefix;

		// Token: 0x04004D53 RID: 19795
		[Token(Token = "0x4004D53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected Action<ResDownloadType> m_OnVersionCheckFinished;

		// Token: 0x04004D54 RID: 19796
		[Token(Token = "0x4004D54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Action<ResErrorCode, ResDownloadType, ResVersionInfo.FileInfo> m_SingleFileFinishedCallBack;

		// Token: 0x04004D55 RID: 19797
		[Token(Token = "0x4004D55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Action<ResErrorCode, ResDownloadType, ResVersionInfo.FileInfo> m_FileFinishedNotify;

		// Token: 0x04004D56 RID: 19798
		[Token(Token = "0x4004D56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<ResVersionInfo.FileInfo> m_NeedRetryFileInfo;

		// Token: 0x04004D57 RID: 19799
		[Token(Token = "0x4004D57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E984", Offset = "0x112E984")]
		private string <CacheAddr>k__BackingField;

		// Token: 0x04004D58 RID: 19800
		[Token(Token = "0x4004D58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E994", Offset = "0x112E994")]
		private string <OldVersionCacheAddr>k__BackingField;

		// Token: 0x04004D59 RID: 19801
		[Token(Token = "0x4004D59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E9A4", Offset = "0x112E9A4")]
		private bool <NeedDownload>k__BackingField;

		// Token: 0x04004D5A RID: 19802
		[Token(Token = "0x4004D5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E9B4", Offset = "0x112E9B4")]
		private bool <NeedCheckVersion>k__BackingField;

		// Token: 0x04004D5B RID: 19803
		[Token(Token = "0x4004D5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E9C4", Offset = "0x112E9C4")]
		private bool <RunningCheckVersion>k__BackingField;

		// Token: 0x04004D5C RID: 19804
		[Token(Token = "0x4004D5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E9D4", Offset = "0x112E9D4")]
		private long <DownloadedSize>k__BackingField;

		// Token: 0x04004D5D RID: 19805
		[Token(Token = "0x4004D5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E9E4", Offset = "0x112E9E4")]
		private long <TotalZipSize>k__BackingField;

		// Token: 0x04004D5E RID: 19806
		[Token(Token = "0x4004D5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E9F4", Offset = "0x112E9F4")]
		private long <TotalSize>k__BackingField;

		// Token: 0x04004D5F RID: 19807
		[Token(Token = "0x4004D5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EA04", Offset = "0x112EA04")]
		private bool <NeedContinueWithDownloadAll>k__BackingField;

		// Token: 0x04004D60 RID: 19808
		[Token(Token = "0x4004D60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public long m_StartDownloadSize;

		// Token: 0x04004D61 RID: 19809
		[Token(Token = "0x4004D61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EA14", Offset = "0x112EA14")]
		private EDownloadContextMode <DownloadMode>k__BackingField;

		// Token: 0x04004D62 RID: 19810
		[Token(Token = "0x4004D62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public List<ResVersionInfo.FileInfo> LastInDownloadFileList;

		// Token: 0x04004D63 RID: 19811
		[Token(Token = "0x4004D63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool HaveVersionUpdate;

		// Token: 0x04004D64 RID: 19812
		[Token(Token = "0x4004D64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		public bool NeedSkipVersion;

		// Token: 0x04004D65 RID: 19813
		[Token(Token = "0x4004D65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		public bool NeedAutoResume;

		// Token: 0x04004D66 RID: 19814
		[Token(Token = "0x4004D66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private HashSet<ResVersionInfo.FileInfo> m_DownloadingFileList;

		// Token: 0x04004D67 RID: 19815
		[Token(Token = "0x4004D67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Dictionary<ResVersionInfo.FileInfo, ResLoaderInfo> m_LoaderInfoMap;

		// Token: 0x04004D68 RID: 19816
		[Token(Token = "0x4004D68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		protected DownloadVersionInfo m_LocalVersionInfo;

		// Token: 0x04004D69 RID: 19817
		[Token(Token = "0x4004D69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		protected DownloadVersionInfo m_RemoteVersionInfo;

		// Token: 0x04004D6A RID: 19818
		[Token(Token = "0x4004D6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		protected ResUpdateDownloadEngine m_OwnedEngine;

		// Token: 0x04004D6B RID: 19819
		[Token(Token = "0x4004D6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		protected bool m_NeedCheckFileState;

		// Token: 0x04004D6C RID: 19820
		[Token(Token = "0x4004D6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		protected List<string> m_NeedRemoveFilePathes;

		// Token: 0x04004D6D RID: 19821
		[Token(Token = "0x4004D6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		protected int m_MaxLoaderCount;

		// Token: 0x04004D6E RID: 19822
		[Token(Token = "0x4004D6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		protected bool m_ShouldOverrideWithFull;
	}
}
