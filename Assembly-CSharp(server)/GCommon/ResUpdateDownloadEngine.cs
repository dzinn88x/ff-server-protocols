using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TsiU;

namespace GCommon
{
	// Token: 0x02000FE5 RID: 4069
	[Token(Token = "0x2000FE5")]
	public class ResUpdateDownloadEngine : TSingleton<ResUpdateDownloadEngine>
	{
		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06003C3B RID: 15419 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003C3C RID: 15420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000713")]
		public ResHotUpdaterContext HotUpdaterContext
		{
			[Token(Token = "0x6003C3B")]
			[Address(RVA = "0x2973FD4", Offset = "0x2973FD4", VA = "0x7BBD173FD4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BEB8", Offset = "0x113BEB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C3C")]
			[Address(RVA = "0x297ABFC", Offset = "0x297ABFC", VA = "0x7BBD17ABFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BEC8", Offset = "0x113BEC8")]
			private set
			{
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06003C3D RID: 15421 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003C3E RID: 15422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000714")]
		public string CDNAddr
		{
			[Token(Token = "0x6003C3D")]
			[Address(RVA = "0x29783E4", Offset = "0x29783E4", VA = "0x7BBD1783E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BED8", Offset = "0x113BED8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003C3E")]
			[Address(RVA = "0x297AC04", Offset = "0x297AC04", VA = "0x7BBD17AC04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BEE8", Offset = "0x113BEE8")]
			set
			{
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06003C3F RID: 15423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000715")]
		public string PlatformIdentifierForOptionals
		{
			[Token(Token = "0x6003C3F")]
			[Address(RVA = "0x2978478", Offset = "0x2978478", VA = "0x7BBD178478")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C40")]
		[Address(RVA = "0x297AC0C", Offset = "0x297AC0C", VA = "0x7BBD17AC0C")]
		public void Init(ResHotUpdaterContext updater_context, int multi_download_gc_index, bool need_init_file_length)
		{
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C41")]
		[Address(RVA = "0x297ACF8", Offset = "0x297ACF8", VA = "0x7BBD17ACF8")]
		public void SetVersionMap(Dictionary<ResDownloadType, string> version_map)
		{
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C42")]
		[Address(RVA = "0x297AD00", Offset = "0x297AD00", VA = "0x7BBD17AD00")]
		public void SetSpeedScale(float speed_scale)
		{
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x00012D08 File Offset: 0x00010F08
		[Token(Token = "0x6003C43")]
		[Address(RVA = "0x2976960", Offset = "0x2976960", VA = "0x7BBD176960")]
		public bool AddToPendingDownload(ResUpdateDownloadContext context, bool isAddFirst = false)
		{
			return default(bool);
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C44")]
		[Address(RVA = "0x2976920", Offset = "0x2976920", VA = "0x7BBD176920")]
		public void PauseDownloadByType(ResDownloadType type, bool isPause, bool need_auto_resume = false)
		{
		}

		// Token: 0x06003C45 RID: 15429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C45")]
		[Address(RVA = "0x297AF78", Offset = "0x297AF78", VA = "0x7BBD17AF78")]
		public void PauseDownloadByType(ResUpdateDownloadContext context, bool isPause, bool need_auto_resume = false)
		{
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C46")]
		[Address(RVA = "0x2973920", Offset = "0x2973920", VA = "0x7BBD173920")]
		public ResUpdateDownloadContext GetRunningDownloadContext()
		{
			return null;
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C47")]
		[Address(RVA = "0x297ADD0", Offset = "0x297ADD0", VA = "0x7BBD17ADD0")]
		public ResUpdateDownloadContext GetDownloadContextByType(ResDownloadType type)
		{
			return null;
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C48")]
		[Address(RVA = "0x297B09C", Offset = "0x297B09C", VA = "0x7BBD17B09C")]
		public void StartGetLocalVersionInfo(List<ResDownloadType> type_list, Action finished_callback)
		{
		}

		// Token: 0x06003C49 RID: 15433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C49")]
		[Address(RVA = "0x297B320", Offset = "0x297B320", VA = "0x7BBD17B320")]
		public void StartGetLocalVersionInfo(ResDownloadType type, Action finished_callback)
		{
		}

		// Token: 0x06003C4A RID: 15434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4A")]
		[Address(RVA = "0x297B424", Offset = "0x297B424", VA = "0x7BBD17B424")]
		public void Update(float time)
		{
		}

		// Token: 0x06003C4B RID: 15435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4B")]
		[Address(RVA = "0x2979170", Offset = "0x2979170", VA = "0x7BBD179170")]
		public void RegistFileNameToEngine(string full_name, ResDownloadType type)
		{
		}

		// Token: 0x06003C4C RID: 15436 RVA: 0x00012D20 File Offset: 0x00010F20
		[Token(Token = "0x6003C4C")]
		[Address(RVA = "0x297B560", Offset = "0x297B560", VA = "0x7BBD17B560")]
		public ResDownloadType GetDownloadTypeByFileName(string full_name)
		{
			return ResDownloadType.None;
		}

		// Token: 0x06003C4D RID: 15437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C4D")]
		[Address(RVA = "0x2968820", Offset = "0x2968820", VA = "0x7BBD168820")]
		public string GetLocalPathByPlatfrom(string full_name)
		{
			return null;
		}

		// Token: 0x06003C4E RID: 15438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C4E")]
		[Address(RVA = "0x29687D0", Offset = "0x29687D0", VA = "0x7BBD1687D0")]
		public ResVersionInfo.FileInfo GetLocalFileInfo(string full_name)
		{
			return null;
		}

		// Token: 0x06003C4F RID: 15439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C4F")]
		[Address(RVA = "0x297B61C", Offset = "0x297B61C", VA = "0x7BBD17B61C")]
		public void DeleteFilesByDownloadType(ResDownloadType type)
		{
		}

		// Token: 0x06003C50 RID: 15440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C50")]
		[Address(RVA = "0x2977AA0", Offset = "0x2977AA0", VA = "0x7BBD177AA0")]
		public void RemoveFromPending(ResUpdateDownloadContext context)
		{
		}

		// Token: 0x06003C51 RID: 15441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C51")]
		[Address(RVA = "0x297B6F8", Offset = "0x297B6F8", VA = "0x7BBD17B6F8")]
		public ResUpdateDownloadEngine()
		{
		}

		// Token: 0x04004D6F RID: 19823
		[Token(Token = "0x4004D6F")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, int> RESDOWNLOADTYPE_LEVEL_MAP;

		// Token: 0x04004D70 RID: 19824
		[Token(Token = "0x4004D70")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<ResDownloadType, string> VersionMap;

		// Token: 0x04004D71 RID: 19825
		[Token(Token = "0x4004D71")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, ResDownloadType> m_FileNameMap;

		// Token: 0x04004D72 RID: 19826
		[Token(Token = "0x4004D72")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<ResDownloadType, ResUpdateDownloadContext> m_DownloadContextMap;

		// Token: 0x04004D73 RID: 19827
		[Token(Token = "0x4004D73")]
		[FieldOffset(Offset = "0x28")]
		private LinkedList<ResUpdateDownloadContext> m_PendingDownloadContext;

		// Token: 0x04004D74 RID: 19828
		[Token(Token = "0x4004D74")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EA24", Offset = "0x112EA24")]
		private ResHotUpdaterContext <HotUpdaterContext>k__BackingField;

		// Token: 0x04004D75 RID: 19829
		[Token(Token = "0x4004D75")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EA34", Offset = "0x112EA34")]
		private string <CDNAddr>k__BackingField;

		// Token: 0x04004D76 RID: 19830
		[Token(Token = "0x4004D76")]
		[FieldOffset(Offset = "0x40")]
		public int UnZipBuffSize;

		// Token: 0x04004D77 RID: 19831
		[Token(Token = "0x4004D77")]
		[FieldOffset(Offset = "0x44")]
		public bool NeedInitFileLength;

		// Token: 0x04004D78 RID: 19832
		[Token(Token = "0x4004D78")]
		[FieldOffset(Offset = "0x48")]
		public int MultiDownloadGCIndex;

		// Token: 0x04004D79 RID: 19833
		[Token(Token = "0x4004D79")]
		private const int BASE_UNZIP_SIZE = 102400;

		// Token: 0x02000FE6 RID: 4070
		[Token(Token = "0x2000FE6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA5E0", Offset = "0x10EA5E0")]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x06003C53 RID: 15443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C53")]
			[Address(RVA = "0x297B318", Offset = "0x297B318", VA = "0x7BBD17B318")]
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x06003C54 RID: 15444 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C54")]
			[Address(RVA = "0x297B940", Offset = "0x297B940", VA = "0x7BBD17B940")]
			internal void <StartGetLocalVersionInfo>b__0(ResDownloadType _context_type)
			{
			}

			// Token: 0x04004D7A RID: 19834
			[Token(Token = "0x4004D7A")]
			[FieldOffset(Offset = "0x10")]
			public ResUpdateDownloadEngine <>4__this;

			// Token: 0x04004D7B RID: 19835
			[Token(Token = "0x4004D7B")]
			[FieldOffset(Offset = "0x18")]
			public List<ResDownloadType> type_list;

			// Token: 0x04004D7C RID: 19836
			[Token(Token = "0x4004D7C")]
			[FieldOffset(Offset = "0x20")]
			public Action finished_callback;
		}

		// Token: 0x02000FE7 RID: 4071
		[Token(Token = "0x2000FE7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA5F0", Offset = "0x10EA5F0")]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x06003C55 RID: 15445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C55")]
			[Address(RVA = "0x297B41C", Offset = "0x297B41C", VA = "0x7BBD17B41C")]
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x06003C56 RID: 15446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C56")]
			[Address(RVA = "0x297B980", Offset = "0x297B980", VA = "0x7BBD17B980")]
			internal void <StartGetLocalVersionInfo>b__0(ResDownloadType _context_type)
			{
			}

			// Token: 0x04004D7D RID: 19837
			[Token(Token = "0x4004D7D")]
			[FieldOffset(Offset = "0x10")]
			public Action finished_callback;
		}
	}
}
