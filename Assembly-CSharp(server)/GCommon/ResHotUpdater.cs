using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TsiU;
using UnityEngine;
using UnityEngine.Networking;

namespace GCommon
{
	// Token: 0x02000FD8 RID: 4056
	[Token(Token = "0x2000FD8")]
	public class ResHotUpdater : TSingleton<ResHotUpdater>
	{
		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06003B8B RID: 15243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006FC")]
		public ResHotUpdaterContext Context
		{
			[Token(Token = "0x6003B8B")]
			[Address(RVA = "0x2963DFC", Offset = "0x2963DFC", VA = "0x7BBD163DFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06003B8C RID: 15244 RVA: 0x00012960 File Offset: 0x00010B60
		[Token(Token = "0x170006FD")]
		public ResErrorCode LastError
		{
			[Token(Token = "0x6003B8C")]
			[Address(RVA = "0x2963E04", Offset = "0x2963E04", VA = "0x7BBD163E04")]
			get
			{
				return ResErrorCode.OK;
			}
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B8D")]
		[Address(RVA = "0x2963E0C", Offset = "0x2963E0C", VA = "0x7BBD163E0C")]
		public void SetLastError(DownloadContext context, ResErrorCode error)
		{
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06003B8E RID: 15246 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003B8F RID: 15247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006FE")]
		public string FakeVersion
		{
			[Token(Token = "0x6003B8E")]
			[Address(RVA = "0x2963EF0", Offset = "0x2963EF0", VA = "0x7BBD163EF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BCB8", Offset = "0x113BCB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003B8F")]
			[Address(RVA = "0x2963EF8", Offset = "0x2963EF8", VA = "0x7BBD163EF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BCC8", Offset = "0x113BCC8")]
			set
			{
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06003B90 RID: 15248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006FF")]
		public string Version
		{
			[Token(Token = "0x6003B90")]
			[Address(RVA = "0x2963F00", Offset = "0x2963F00", VA = "0x7BBD163F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06003B91 RID: 15249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000700")]
		public string OptionalVersion
		{
			[Token(Token = "0x6003B91")]
			[Address(RVA = "0x2964038", Offset = "0x2964038", VA = "0x7BBD164038")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06003B92 RID: 15250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000701")]
		public string PlatformIdentifier
		{
			[Token(Token = "0x6003B92")]
			[Address(RVA = "0x29640AC", Offset = "0x29640AC", VA = "0x7BBD1640AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06003B93 RID: 15251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000702")]
		public string RemotePlatform
		{
			[Token(Token = "0x6003B93")]
			[Address(RVA = "0x29640F4", Offset = "0x29640F4", VA = "0x7BBD1640F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06003B94 RID: 15252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000703")]
		public string ReleaseChannel
		{
			[Token(Token = "0x6003B94")]
			[Address(RVA = "0x296413C", Offset = "0x296413C", VA = "0x7BBD16413C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06003B95 RID: 15253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000704")]
		public string AssetBundleManifestPath
		{
			[Token(Token = "0x6003B95")]
			[Address(RVA = "0x2964184", Offset = "0x2964184", VA = "0x7BBD164184")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06003B96 RID: 15254 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003B97 RID: 15255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000705")]
		public string OriginalVersion
		{
			[Token(Token = "0x6003B96")]
			[Address(RVA = "0x29641B0", Offset = "0x29641B0", VA = "0x7BBD1641B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BCD8", Offset = "0x113BCD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003B97")]
			[Address(RVA = "0x29641B8", Offset = "0x29641B8", VA = "0x7BBD1641B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BCE8", Offset = "0x113BCE8")]
			private set
			{
			}
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B98")]
		[Address(RVA = "0x29641C0", Offset = "0x29641C0", VA = "0x7BBD1641C0")]
		public void Init(ResHotUpdaterContext context)
		{
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B99")]
		[Address(RVA = "0x29644AC", Offset = "0x29644AC", VA = "0x7BBD1644AC")]
		public DownloadContext GetDownloadContextByType(ResDownloadType type)
		{
			return null;
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x00012978 File Offset: 0x00010B78
		[Token(Token = "0x6003B9A")]
		[Address(RVA = "0x29645C4", Offset = "0x29645C4", VA = "0x7BBD1645C4")]
		public bool AddToPendingDownload(DownloadContext context, bool isAddFirst = false)
		{
			return default(bool);
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9B")]
		[Address(RVA = "0x296468C", Offset = "0x296468C", VA = "0x7BBD16468C")]
		public void PauseDownloadByType(ResDownloadType type, bool isPause)
		{
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9C")]
		[Address(RVA = "0x29646C8", Offset = "0x29646C8", VA = "0x7BBD1646C8")]
		public void PauseRunningDownloadWithAllType(bool isPause)
		{
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9D")]
		[Address(RVA = "0x2964798", Offset = "0x2964798", VA = "0x7BBD164798")]
		public void CleanTempCache(ResDownloadType type)
		{
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9E")]
		[Address(RVA = "0x2964984", Offset = "0x2964984", VA = "0x7BBD164984")]
		public void CleanCache()
		{
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9F")]
		[Address(RVA = "0x2964B44", Offset = "0x2964B44", VA = "0x7BBD164B44")]
		public void StartGetLocalVersion()
		{
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA0")]
		[Address(RVA = "0x2964F94", Offset = "0x2964F94", VA = "0x7BBD164F94")]
		public void StartGetLocalFileInfo()
		{
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA1")]
		[Address(RVA = "0x296533C", Offset = "0x296533C", VA = "0x7BBD16533C")]
		public void StartVersionCheck(string remoteAddr, [Optional] string remoteVersion)
		{
		}

		// Token: 0x06003BA2 RID: 15266 RVA: 0x00012990 File Offset: 0x00010B90
		[Token(Token = "0x6003BA2")]
		[Address(RVA = "0x2965D58", Offset = "0x2965D58", VA = "0x7BBD165D58")]
		public ResErrorCode GetDetailedDownloadError(string error)
		{
			return ResErrorCode.OK;
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA3")]
		[Address(RVA = "0x2965DBC", Offset = "0x2965DBC", VA = "0x7BBD165DBC")]
		public void StartHotUpdateDownload(Action<ResErrorCode> onHotUpdateFinished)
		{
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA4")]
		[Address(RVA = "0x29660B8", Offset = "0x29660B8", VA = "0x7BBD1660B8")]
		public void Update(float time)
		{
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA5")]
		[Address(RVA = "0x29661F0", Offset = "0x29661F0", VA = "0x7BBD1661F0")]
		public void ClearContextActionReference()
		{
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA6")]
		[Address(RVA = "0x2966210", Offset = "0x2966210", VA = "0x7BBD166210")]
		public void Clear()
		{
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA7")]
		[Address(RVA = "0x2966360", Offset = "0x2966360", VA = "0x7BBD166360")]
		public void ClearPendingDownloadContext()
		{
		}

		// Token: 0x06003BA8 RID: 15272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA8")]
		[Address(RVA = "0x29664D8", Offset = "0x29664D8", VA = "0x7BBD1664D8")]
		public void WWWLoad(DownloadContext context, string path, Action<WWW, ResWWWFileLoader> onLoaded, bool isFromRemote, long totalSize = 0L, bool includeVersionDir = true, [Optional] ResVersionInfo.FileInfo file_info)
		{
		}

		// Token: 0x06003BA9 RID: 15273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA9")]
		[Address(RVA = "0x2966894", Offset = "0x2966894", VA = "0x7BBD166894")]
		public void Download(DownloadContext context, ResVersionInfo.FileInfo file_info, string path, Action<UnityWebRequest, ResWithTempFileLoader> onLoaded, bool isFromRemote)
		{
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAA")]
		[Address(RVA = "0x2966E44", Offset = "0x2966E44", VA = "0x7BBD166E44")]
		public void BigFileDownload(DownloadContext context, ResVersionInfo.FileInfo file_info, string path, Action<UnityWebRequest, ResWithTempFileLoader> onLoaded)
		{
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAB")]
		[Address(RVA = "0x2967418", Offset = "0x2967418", VA = "0x7BBD167418")]
		public void Unzip(DownloadContext context, ResVersionInfo.FileInfo file_info, Action<string, ResUnzipFileLoader> onLoaded, bool addProgressSize = false, bool addFirst = false)
		{
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BAC")]
		[Address(RVA = "0x2967E04", Offset = "0x2967E04", VA = "0x7BBD167E04")]
		public void HashFile(DownloadContext context, ResVersionInfo.FileInfo file_info, Action<string, ResHashFileLoader> onLoaded, bool addProgressSize = false, bool addFirst = false)
		{
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BAD")]
		[Address(RVA = "0x2967FB0", Offset = "0x2967FB0", VA = "0x7BBD167FB0")]
		public AssetBundle LoadAssetBundle(string path, bool logError = true)
		{
			return null;
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BAE")]
		[Address(RVA = "0x296823C", Offset = "0x296823C", VA = "0x7BBD16823C")]
		public string GetHotUpdateMovieUrl(ResourceID id)
		{
			return null;
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x000129A8 File Offset: 0x00010BA8
		[Token(Token = "0x6003BAF")]
		[Address(RVA = "0x2968424", Offset = "0x2968424", VA = "0x7BBD168424")]
		public long GetTotalSizeInByte(ResDownloadType type = ResDownloadType.CompulsoryRes)
		{
			return 0L;
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x000129C0 File Offset: 0x00010BC0
		[Token(Token = "0x6003BB0")]
		[Address(RVA = "0x2968458", Offset = "0x2968458", VA = "0x7BBD168458")]
		public long GetTotalLoadedSizeInByte(ResDownloadType type = ResDownloadType.CompulsoryRes)
		{
			return 0L;
		}

		// Token: 0x06003BB1 RID: 15281 RVA: 0x000129D8 File Offset: 0x00010BD8
		[Token(Token = "0x6003BB1")]
		[Address(RVA = "0x2968494", Offset = "0x2968494", VA = "0x7BBD168494")]
		public long GetTotalDownloadSizeInByte(ResDownloadType type = ResDownloadType.CompulsoryRes)
		{
			return 0L;
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB2")]
		[Address(RVA = "0x29684B0", Offset = "0x29684B0", VA = "0x7BBD1684B0")]
		public ResVersionInfo.FileInfo GetLocalFileInfo(string path)
		{
			return null;
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB3")]
		[Address(RVA = "0x29686BC", Offset = "0x29686BC", VA = "0x7BBD1686BC")]
		public ResVersionInfo.FileInfo GetRemoteFileInfo(string path)
		{
			return null;
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x000129F0 File Offset: 0x00010BF0
		[Token(Token = "0x6003BB4")]
		[Address(RVA = "0x29686F4", Offset = "0x29686F4", VA = "0x7BBD1686F4")]
		public bool ABFileExist(string ab_path)
		{
			return default(bool);
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB5")]
		[Address(RVA = "0x29680A0", Offset = "0x29680A0", VA = "0x7BBD1680A0")]
		private string GetLocalPathByPlatfrom(string path)
		{
			return null;
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB6")]
		[Address(RVA = "0x29676D0", Offset = "0x29676D0", VA = "0x7BBD1676D0")]
		public string GetLocalPathByPlatfromByFileInfo(ResVersionInfo.FileInfo fileInfo, ResVersionInfo.FileInfo.OpState targetState)
		{
			return null;
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BB7")]
		[Address(RVA = "0x29688B8", Offset = "0x29688B8", VA = "0x7BBD1688B8")]
		private void ClearTempFile(string tempPath, [Optional] string flagPath)
		{
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x00012A08 File Offset: 0x00010C08
		[Token(Token = "0x6003BB8")]
		[Address(RVA = "0x2968A50", Offset = "0x2968A50", VA = "0x7BBD168A50")]
		private bool MoveTempFile(string relativePath, ResFileType type, string tempPath)
		{
			return default(bool);
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x00012A20 File Offset: 0x00010C20
		[Token(Token = "0x6003BB9")]
		[Address(RVA = "0x2968D5C", Offset = "0x2968D5C", VA = "0x7BBD168D5C")]
		private bool SaveFile(string path, ResFileType type, byte[] content)
		{
			return default(bool);
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBA")]
		[Address(RVA = "0x29690F4", Offset = "0x29690F4", VA = "0x7BBD1690F4")]
		private void onLocalVersionInfoLoaded(bool result)
		{
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBB")]
		[Address(RVA = "0x29655A4", Offset = "0x29655A4", VA = "0x7BBD1655A4")]
		private void onRemoveVersionInfoLoaded(bool result)
		{
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBC")]
		[Address(RVA = "0x29691EC", Offset = "0x29691EC", VA = "0x7BBD1691EC")]
		private void onLocalFileInfoLoaded_Pass(bool result)
		{
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBD")]
		[Address(RVA = "0x29692E4", Offset = "0x29692E4", VA = "0x7BBD1692E4")]
		private void onLocalFileInfoLoaded_Hotupdate(bool result)
		{
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBE")]
		[Address(RVA = "0x2969448", Offset = "0x2969448", VA = "0x7BBD169448")]
		private void onRemoteFileInfoLoaded(bool result)
		{
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x00012A38 File Offset: 0x00010C38
		[Token(Token = "0x6003BBF")]
		[Address(RVA = "0x2969FD8", Offset = "0x2969FD8", VA = "0x7BBD169FD8")]
		public static bool IsOptionalMap(ResDownloadType type)
		{
			return default(bool);
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BC0")]
		[Address(RVA = "0x296A000", Offset = "0x296A000", VA = "0x7BBD16A000")]
		public static ResFileType[] GetResFileTypeList(ResDownloadType type)
		{
			return null;
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x00012A50 File Offset: 0x00010C50
		[Token(Token = "0x6003BC1")]
		[Address(RVA = "0x296A248", Offset = "0x296A248", VA = "0x7BBD16A248")]
		public bool CheckHasNeedDownloadFileByType(ResDownloadType type)
		{
			return default(bool);
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x00012A68 File Offset: 0x00010C68
		[Token(Token = "0x6003BC2")]
		[Address(RVA = "0x296A878", Offset = "0x296A878", VA = "0x7BBD16A878")]
		public bool DownloadDesignatedFile(ResDownloadType type, string ab_path, bool useMultiThreadDownload = false)
		{
			return default(bool);
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x00012A80 File Offset: 0x00010C80
		[Token(Token = "0x6003BC3")]
		[Address(RVA = "0x2969658", Offset = "0x2969658", VA = "0x7BBD169658")]
		public bool CheckNeedDownloadByType(ResDownloadType type, bool useMultiThreadDownload = false)
		{
			return default(bool);
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC4")]
		[Address(RVA = "0x296B184", Offset = "0x296B184", VA = "0x7BBD16B184")]
		private void NotifyFileHashed(DownloadContext context, string hash_code, ResHashFileLoader hashFileLoader)
		{
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC5")]
		[Address(RVA = "0x296B3C0", Offset = "0x296B3C0", VA = "0x7BBD16B3C0")]
		public void FinalHash()
		{
		}

		// Token: 0x06003BC6 RID: 15302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC6")]
		[Address(RVA = "0x296B58C", Offset = "0x296B58C", VA = "0x7BBD16B58C")]
		private void NotifyFileUnZiped(DownloadContext context, string hash_code, ResUnzipFileLoader unzip_loader)
		{
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC7")]
		[Address(RVA = "0x296C704", Offset = "0x296C704", VA = "0x7BBD16C704")]
		private void NotifyFileDownloaded(ResErrorCode result, DownloadContext context, ResFileLoader loader)
		{
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x00012A98 File Offset: 0x00010C98
		[Token(Token = "0x6003BC8")]
		[Address(RVA = "0x296C888", Offset = "0x296C888", VA = "0x7BBD16C888")]
		public ResErrorCode SaveVersionInfo(ResDownloadType type)
		{
			return ResErrorCode.OK;
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC9")]
		[Address(RVA = "0x2965FDC", Offset = "0x2965FDC", VA = "0x7BBD165FDC")]
		public void StartDownloadContextByType(ResDownloadType[] type_list, Action<ResErrorCode, ResDownloadType> onDownloadFinished)
		{
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BCA")]
		[Address(RVA = "0x296CAC8", Offset = "0x296CAC8", VA = "0x7BBD16CAC8")]
		public void StartDownloadContextByType(ResDownloadType type, Action<ResErrorCode, ResDownloadType> onDownloadFinished)
		{
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x00012AB0 File Offset: 0x00010CB0
		[Token(Token = "0x6003BCB")]
		[Address(RVA = "0x296AD30", Offset = "0x296AD30", VA = "0x7BBD16AD30")]
		public bool CheckCopyAndUnzipDesignatedFile(string ab_path, ResDownloadType type = ResDownloadType.CompulsoryRes)
		{
			return default(bool);
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BCC")]
		[Address(RVA = "0x296CBDC", Offset = "0x296CBDC", VA = "0x7BBD16CBDC")]
		public void CheckHashFile(float cool_down_time = 0f, ResDownloadType type = ResDownloadType.CompulsoryRes, [Optional] Action<ResErrorCode, ResDownloadType> finished_callback)
		{
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x00012AC8 File Offset: 0x00010CC8
		[Token(Token = "0x6003BCD")]
		[Address(RVA = "0x296D3F4", Offset = "0x296D3F4", VA = "0x7BBD16D3F4")]
		public bool CheckCopyAndUnzipFile(ResDownloadType type = ResDownloadType.CompulsoryRes)
		{
			return default(bool);
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x00012AE0 File Offset: 0x00010CE0
		[Token(Token = "0x6003BCE")]
		[Address(RVA = "0x296DC54", Offset = "0x296DC54", VA = "0x7BBD16DC54")]
		public long GetLocalStoredFileSizeWithType(ResFileType type)
		{
			return 0L;
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x00012AF8 File Offset: 0x00010CF8
		[Token(Token = "0x6003BCF")]
		[Address(RVA = "0x296DED8", Offset = "0x296DED8", VA = "0x7BBD16DED8")]
		public long GetNeedDownloadFileSize(ResDownloadType type)
		{
			return 0L;
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD0")]
		[Address(RVA = "0x296E3F8", Offset = "0x296E3F8", VA = "0x7BBD16E3F8")]
		public ResHotUpdater()
		{
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BD2")]
		[Address(RVA = "0x296E528", Offset = "0x296E528", VA = "0x7BBD16E528")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BCF8", Offset = "0x113BCF8")]
		private void <StartHotUpdateDownload>b__50_0(ResErrorCode result, ResDownloadType type)
		{
		}

		// Token: 0x04004D23 RID: 19747
		[Token(Token = "0x4004D23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool VersionToolsCompressCompulsoryAb;

		// Token: 0x04004D24 RID: 19748
		[Token(Token = "0x4004D24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool SaveUnCompressedCompulsoryAbToPersistDir;

		// Token: 0x04004D25 RID: 19749
		[Token(Token = "0x4004D25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public static bool LoadLocalCompulsoryAbFromStreamDir;

		// Token: 0x04004D26 RID: 19750
		[Token(Token = "0x4004D26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ResHotUpdaterContext m_Context;

		// Token: 0x04004D27 RID: 19751
		[Token(Token = "0x4004D27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ResVersionInfo m_LocalVersionInfo;

		// Token: 0x04004D28 RID: 19752
		[Token(Token = "0x4004D28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ResVersionInfo m_RemoteVersionInfo;

		// Token: 0x04004D29 RID: 19753
		[Token(Token = "0x4004D29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<ResDownloadType, DownloadContext> m_DownloadContextMap;

		// Token: 0x04004D2A RID: 19754
		[Token(Token = "0x4004D2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private LinkedList<DownloadContext> m_PendingDownloadContext;

		// Token: 0x04004D2B RID: 19755
		[Token(Token = "0x4004D2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ResErrorCode m_LastError;

		// Token: 0x04004D2C RID: 19756
		[Token(Token = "0x4004D2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E964", Offset = "0x112E964")]
		private string <FakeVersion>k__BackingField;

		// Token: 0x04004D2D RID: 19757
		[Token(Token = "0x4004D2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string VersionCode;

		// Token: 0x04004D2E RID: 19758
		[Token(Token = "0x4004D2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E974", Offset = "0x112E974")]
		private string <OriginalVersion>k__BackingField;

		// Token: 0x04004D2F RID: 19759
		[Token(Token = "0x4004D2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int FileCount;

		// Token: 0x04004D30 RID: 19760
		[Token(Token = "0x4004D30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<string> FileException;

		// Token: 0x04004D31 RID: 19761
		[Token(Token = "0x4004D31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string FileSimple;

		// Token: 0x04004D32 RID: 19762
		[Token(Token = "0x4004D32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float NextCheckTime;

		// Token: 0x02000FD9 RID: 4057
		[Token(Token = "0x2000FD9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA570", Offset = "0x10EA570")]
		private sealed class <>c__DisplayClass81_0
		{
			// Token: 0x06003BD3 RID: 15315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BD3")]
			[Address(RVA = "0x296AC48", Offset = "0x296AC48", VA = "0x7BBD16AC48")]
			public <>c__DisplayClass81_0()
			{
			}

			// Token: 0x06003BD4 RID: 15316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BD4")]
			[Address(RVA = "0x296E70C", Offset = "0x296E70C", VA = "0x7BBD16E70C")]
			internal void <DownloadDesignatedFile>b__0(UnityWebRequest www, ResWithTempFileLoader loader)
			{
			}

			// Token: 0x04004D33 RID: 19763
			[Token(Token = "0x4004D33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DownloadContext context;

			// Token: 0x04004D34 RID: 19764
			[Token(Token = "0x4004D34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ResHotUpdater <>4__this;
		}

		// Token: 0x02000FDA RID: 4058
		[Token(Token = "0x2000FDA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA580", Offset = "0x10EA580")]
		private sealed class <>c__DisplayClass82_0
		{
			// Token: 0x06003BD5 RID: 15317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BD5")]
			[Address(RVA = "0x296B17C", Offset = "0x296B17C", VA = "0x7BBD16B17C")]
			public <>c__DisplayClass82_0()
			{
			}

			// Token: 0x06003BD6 RID: 15318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BD6")]
			[Address(RVA = "0x296EE00", Offset = "0x296EE00", VA = "0x7BBD16EE00")]
			internal void <CheckNeedDownloadByType>b__0(UnityWebRequest www, ResWithTempFileLoader loader)
			{
			}

			// Token: 0x04004D35 RID: 19765
			[Token(Token = "0x4004D35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DownloadContext context;

			// Token: 0x04004D36 RID: 19766
			[Token(Token = "0x4004D36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ResHotUpdater <>4__this;
		}

		// Token: 0x02000FDB RID: 4059
		[Token(Token = "0x2000FDB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA590", Offset = "0x10EA590")]
		private sealed class <>c__DisplayClass86_0
		{
			// Token: 0x06003BD7 RID: 15319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BD7")]
			[Address(RVA = "0x296C880", Offset = "0x296C880", VA = "0x7BBD16C880")]
			public <>c__DisplayClass86_0()
			{
			}

			// Token: 0x06003BD8 RID: 15320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BD8")]
			[Address(RVA = "0x296F4F4", Offset = "0x296F4F4", VA = "0x7BBD16F4F4")]
			internal void <NotifyFileDownloaded>b__0(string hashCode, ResUnzipFileLoader unzip_loader)
			{
			}

			// Token: 0x04004D37 RID: 19767
			[Token(Token = "0x4004D37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ResHotUpdater <>4__this;

			// Token: 0x04004D38 RID: 19768
			[Token(Token = "0x4004D38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DownloadContext context;
		}

		// Token: 0x02000FDC RID: 4060
		[Token(Token = "0x2000FDC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA5A0", Offset = "0x10EA5A0")]
		private sealed class <>c__DisplayClass90_0
		{
			// Token: 0x06003BD9 RID: 15321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BD9")]
			[Address(RVA = "0x296CBD4", Offset = "0x296CBD4", VA = "0x7BBD16CBD4")]
			public <>c__DisplayClass90_0()
			{
			}

			// Token: 0x06003BDA RID: 15322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BDA")]
			[Address(RVA = "0x296F53C", Offset = "0x296F53C", VA = "0x7BBD16F53C")]
			internal void <CheckCopyAndUnzipDesignatedFile>b__0(string hashCode, ResUnzipFileLoader unzip_loader)
			{
			}

			// Token: 0x06003BDB RID: 15323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BDB")]
			[Address(RVA = "0x296F584", Offset = "0x296F584", VA = "0x7BBD16F584")]
			internal void <CheckCopyAndUnzipDesignatedFile>b__1(WWW www, ResWWWFileLoader loader)
			{
			}

			// Token: 0x04004D39 RID: 19769
			[Token(Token = "0x4004D39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ResHotUpdater <>4__this;

			// Token: 0x04004D3A RID: 19770
			[Token(Token = "0x4004D3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DownloadContext context;

			// Token: 0x04004D3B RID: 19771
			[Token(Token = "0x4004D3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ResVersionInfo.FileInfo fi;

			// Token: 0x04004D3C RID: 19772
			[Token(Token = "0x4004D3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<string, ResUnzipFileLoader> onUnzipped;
		}

		// Token: 0x02000FDD RID: 4061
		[Token(Token = "0x2000FDD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA5B0", Offset = "0x10EA5B0")]
		private sealed class <>c__DisplayClass91_0
		{
			// Token: 0x06003BDC RID: 15324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BDC")]
			[Address(RVA = "0x296D3EC", Offset = "0x296D3EC", VA = "0x7BBD16D3EC")]
			public <>c__DisplayClass91_0()
			{
			}

			// Token: 0x06003BDD RID: 15325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BDD")]
			[Address(RVA = "0x296F9A8", Offset = "0x296F9A8", VA = "0x7BBD16F9A8")]
			internal void <CheckHashFile>b__0(string hashCode, ResHashFileLoader hash_loader)
			{
			}

			// Token: 0x06003BDE RID: 15326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BDE")]
			[Address(RVA = "0x296F9EC", Offset = "0x296F9EC", VA = "0x7BBD16F9EC")]
			internal void <CheckHashFile>b__1(ResErrorCode error_code, ResDownloadType download_type)
			{
			}

			// Token: 0x04004D3D RID: 19773
			[Token(Token = "0x4004D3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ResHotUpdater <>4__this;

			// Token: 0x04004D3E RID: 19774
			[Token(Token = "0x4004D3E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DownloadContext context;

			// Token: 0x04004D3F RID: 19775
			[Token(Token = "0x4004D3F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<ResErrorCode, ResDownloadType> finished_callback;
		}

		// Token: 0x02000FDE RID: 4062
		[Token(Token = "0x2000FDE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA5C0", Offset = "0x10EA5C0")]
		private sealed class <>c__DisplayClass92_0
		{
			// Token: 0x06003BDF RID: 15327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BDF")]
			[Address(RVA = "0x296DC44", Offset = "0x296DC44", VA = "0x7BBD16DC44")]
			public <>c__DisplayClass92_0()
			{
			}

			// Token: 0x06003BE0 RID: 15328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BE0")]
			[Address(RVA = "0x296FA80", Offset = "0x296FA80", VA = "0x7BBD16FA80")]
			internal void <CheckCopyAndUnzipFile>b__0(string hashCode, ResUnzipFileLoader unzip_loader)
			{
			}

			// Token: 0x06003BE1 RID: 15329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BE1")]
			[Address(RVA = "0x296FAC8", Offset = "0x296FAC8", VA = "0x7BBD16FAC8")]
			internal void <CheckCopyAndUnzipFile>b__1(string hashCode, ResHashFileLoader hash_loader)
			{
			}

			// Token: 0x04004D40 RID: 19776
			[Token(Token = "0x4004D40")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ResHotUpdater <>4__this;

			// Token: 0x04004D41 RID: 19777
			[Token(Token = "0x4004D41")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DownloadContext context;

			// Token: 0x04004D42 RID: 19778
			[Token(Token = "0x4004D42")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<string, ResUnzipFileLoader> onUnzipped;
		}

		// Token: 0x02000FDF RID: 4063
		[Token(Token = "0x2000FDF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA5D0", Offset = "0x10EA5D0")]
		private sealed class <>c__DisplayClass92_1
		{
			// Token: 0x06003BE2 RID: 15330 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BE2")]
			[Address(RVA = "0x296DC4C", Offset = "0x296DC4C", VA = "0x7BBD16DC4C")]
			public <>c__DisplayClass92_1()
			{
			}

			// Token: 0x06003BE3 RID: 15331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BE3")]
			[Address(RVA = "0x296FB0C", Offset = "0x296FB0C", VA = "0x7BBD16FB0C")]
			internal void <CheckCopyAndUnzipFile>b__2(WWW www, ResWWWFileLoader loader)
			{
			}

			// Token: 0x04004D43 RID: 19779
			[Token(Token = "0x4004D43")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ResVersionInfo.FileInfo fi;

			// Token: 0x04004D44 RID: 19780
			[Token(Token = "0x4004D44")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ResHotUpdater.<>c__DisplayClass92_0 CS$<>8__locals1;
		}
	}
}
