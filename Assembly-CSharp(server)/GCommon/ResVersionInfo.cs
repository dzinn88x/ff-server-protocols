using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000FEA RID: 4074
	[Token(Token = "0x2000FEA")]
	public class ResVersionInfo
	{
		// Token: 0x06003C5E RID: 15454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C5E")]
		[Address(RVA = "0x2964C10", Offset = "0x2964C10", VA = "0x7BBD164C10")]
		public ResVersionInfo(bool isRemote)
		{
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C5F")]
		[Address(RVA = "0x296588C", Offset = "0x296588C", VA = "0x7BBD16588C")]
		public void LoadFromString(DownloadContext downloadContext, ResHotUpdater updaterInst, string removeVersion)
		{
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C60")]
		[Address(RVA = "0x2964CF4", Offset = "0x2964CF4", VA = "0x7BBD164CF4")]
		public void Load(ResHotUpdater updaterInst, string versionInfoPath, Action<bool> onVersionInfoLoaded)
		{
		}

		// Token: 0x06003C61 RID: 15457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C61")]
		[Address(RVA = "0x2965040", Offset = "0x2965040", VA = "0x7BBD165040")]
		public void LoadFileInfo(ResHotUpdater updaterInst, string fileInfoPath, Action<bool> onFileInfoLoaded)
		{
		}

		// Token: 0x06003C62 RID: 15458 RVA: 0x00012D68 File Offset: 0x00010F68
		[Token(Token = "0x6003C62")]
		[Address(RVA = "0x297BC94", Offset = "0x297BC94", VA = "0x7BBD17BC94")]
		private bool LoadLocalFileInfo(ResHotUpdater updaterInst, [Optional] ResFileType[] targetFileType)
		{
			return default(bool);
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C63")]
		[Address(RVA = "0x2963F78", Offset = "0x2963F78", VA = "0x7BBD163F78")]
		public string GetVersionString()
		{
			return null;
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C64")]
		[Address(RVA = "0x29640A0", Offset = "0x29640A0", VA = "0x7BBD1640A0")]
		public string GetOptionVersionString()
		{
			return null;
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C65")]
		[Address(RVA = "0x296A768", Offset = "0x296A768", VA = "0x7BBD16A768")]
		public Dictionary<string, ResVersionInfo.FileInfo> GetFileInfoListWithType(ResFileType fileType)
		{
			return null;
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C66")]
		[Address(RVA = "0x296AC50", Offset = "0x296AC50", VA = "0x7BBD16AC50")]
		public void AddFileInfo(ResVersionInfo.FileInfo fileInfo)
		{
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x00012D80 File Offset: 0x00010F80
		[Token(Token = "0x6003C67")]
		[Address(RVA = "0x2968518", Offset = "0x2968518", VA = "0x7BBD168518")]
		public bool FindFileInfo(string fullName, out ResVersionInfo.FileInfo result)
		{
			return default(bool);
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x00012D98 File Offset: 0x00010F98
		[Token(Token = "0x6003C68")]
		[Address(RVA = "0x297C71C", Offset = "0x297C71C", VA = "0x7BBD17C71C")]
		private bool HaveEnoughStorage()
		{
			return default(bool);
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x00012DB0 File Offset: 0x00010FB0
		[Token(Token = "0x6003C69")]
		[Address(RVA = "0x296BA24", Offset = "0x296BA24", VA = "0x7BBD16BA24")]
		public ResErrorCode SaveFileInfo(ResHotUpdaterContext context)
		{
			return ResErrorCode.OK;
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x00012DC8 File Offset: 0x00010FC8
		[Token(Token = "0x6003C6A")]
		[Address(RVA = "0x297C788", Offset = "0x297C788", VA = "0x7BBD17C788")]
		public ResErrorCode SaveVersionInfo(ResHotUpdaterContext context, ResDownloadType type = ResDownloadType.CompulsoryRes)
		{
			return ResErrorCode.OK;
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x00012DE0 File Offset: 0x00010FE0
		[Token(Token = "0x6003C6B")]
		[Address(RVA = "0x296C9C8", Offset = "0x296C9C8", VA = "0x7BBD16C9C8")]
		public ResErrorCode Save(ResHotUpdater updaterInst, ResDownloadType type = ResDownloadType.CompulsoryRes)
		{
			return ResErrorCode.OK;
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x00012DF8 File Offset: 0x00010FF8
		[Token(Token = "0x6003C6C")]
		[Address(RVA = "0x297B9DC", Offset = "0x297B9DC", VA = "0x7BBD17B9DC")]
		private bool ParseVersion(string content, ref uint majorVersion, ref uint minorVersion, ref uint optionalVersion)
		{
			return default(bool);
		}

		// Token: 0x06003C6D RID: 15469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C6D")]
		[Address(RVA = "0x297CB40", Offset = "0x297CB40", VA = "0x7BBD17CB40")]
		public Dictionary<string, ResVersionInfo.FileInfo> GetFileInfos()
		{
			return null;
		}

		// Token: 0x06003C6E RID: 15470 RVA: 0x00012E10 File Offset: 0x00011010
		[Token(Token = "0x6003C6E")]
		[Address(RVA = "0x297C008", Offset = "0x297C008", VA = "0x7BBD17C008")]
		private bool ParseFile(string content, [Optional] ResFileType[] targetFileTypes, bool from_local = false)
		{
			return default(bool);
		}

		// Token: 0x06003C6F RID: 15471 RVA: 0x00012E28 File Offset: 0x00011028
		[Token(Token = "0x6003C6F")]
		[Address(RVA = "0x296DC64", Offset = "0x296DC64", VA = "0x7BBD16DC64")]
		public long GetStoredFileSize(ResFileType type)
		{
			return 0L;
		}

		// Token: 0x04004D8B RID: 19851
		[Token(Token = "0x4004D8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint MajorVersion;

		// Token: 0x04004D8C RID: 19852
		[Token(Token = "0x4004D8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint MinorVersion;

		// Token: 0x04004D8D RID: 19853
		[Token(Token = "0x4004D8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint OptionalVersion;

		// Token: 0x04004D8E RID: 19854
		[Token(Token = "0x4004D8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_IsRemote;

		// Token: 0x04004D8F RID: 19855
		[Token(Token = "0x4004D8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		private bool m_IsUsingEmbed;

		// Token: 0x04004D90 RID: 19856
		[Token(Token = "0x4004D90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ResFileType m_MaxSkipType;

		// Token: 0x04004D91 RID: 19857
		[Token(Token = "0x4004D91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<string, ResVersionInfo.FileInfo> m_FileInfos;

		// Token: 0x04004D92 RID: 19858
		[Token(Token = "0x4004D92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<ResFileType, Dictionary<string, ResVersionInfo.FileInfo>> m_FileInfoListMapWithType;

		// Token: 0x04004D93 RID: 19859
		[Token(Token = "0x4004D93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<ResFileType, long> m_StoredFileSizeMapWithType;

		// Token: 0x02000FEB RID: 4075
		[Token(Token = "0x2000FEB")]
		public class FileInfo
		{
			// Token: 0x06003C70 RID: 15472 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C70")]
			[Address(RVA = "0x2480DC4", Offset = "0x2480DC4", VA = "0x7BBCC80DC4")]
			public string Print()
			{
				return null;
			}

			// Token: 0x06003C71 RID: 15473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C71")]
			[Address(RVA = "0x2481134", Offset = "0x2481134", VA = "0x7BBCC81134")]
			public ResVersionInfo.FileInfo Clone()
			{
				return null;
			}

			// Token: 0x06003C72 RID: 15474 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C72")]
			[Address(RVA = "0x2481298", Offset = "0x2481298", VA = "0x7BBCC81298")]
			public string GetFullNameWithCDNExt(bool need_cache = true)
			{
				return null;
			}

			// Token: 0x06003C73 RID: 15475 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C73")]
			[Address(RVA = "0x24813F8", Offset = "0x24813F8", VA = "0x7BBCC813F8")]
			public string GetFullNameWithUnzipExt(bool need_cache = true)
			{
				return null;
			}

			// Token: 0x06003C74 RID: 15476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C74")]
			[Address(RVA = "0x2481290", Offset = "0x2481290", VA = "0x7BBCC81290")]
			public FileInfo()
			{
			}

			// Token: 0x04004D94 RID: 19860
			[Token(Token = "0x4004D94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string FullName;

			// Token: 0x04004D95 RID: 19861
			[Token(Token = "0x4004D95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string Hash;

			// Token: 0x04004D96 RID: 19862
			[Token(Token = "0x4004D96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string ZipHash;

			// Token: 0x04004D97 RID: 19863
			[Token(Token = "0x4004D97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public long Size;

			// Token: 0x04004D98 RID: 19864
			[Token(Token = "0x4004D98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public long ZipSize;

			// Token: 0x04004D99 RID: 19865
			[Token(Token = "0x4004D99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ResVersionInfo.FileInfo.OpState State;

			// Token: 0x04004D9A RID: 19866
			[Token(Token = "0x4004D9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool IsCompressed;

			// Token: 0x04004D9B RID: 19867
			[Token(Token = "0x4004D9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public ResFileType FileType;

			// Token: 0x04004D9C RID: 19868
			[Token(Token = "0x4004D9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool IsInSingleList;

			// Token: 0x04004D9D RID: 19869
			[Token(Token = "0x4004D9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private string m_CDNExt;

			// Token: 0x04004D9E RID: 19870
			[Token(Token = "0x4004D9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private string m_UnzipExt;

			// Token: 0x02000FEC RID: 4076
			[Token(Token = "0x2000FEC")]
			public enum OpState
			{
				// Token: 0x04004DA0 RID: 19872
				[Token(Token = "0x4004DA0")]
				Local,
				// Token: 0x04004DA1 RID: 19873
				[Token(Token = "0x4004DA1")]
				Download,
				// Token: 0x04004DA2 RID: 19874
				[Token(Token = "0x4004DA2")]
				Cache,
				// Token: 0x04004DA3 RID: 19875
				[Token(Token = "0x4004DA3")]
				CacheUnzipped
			}
		}

		// Token: 0x02000FED RID: 4077
		[Token(Token = "0x2000FED")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA600", Offset = "0x10EA600")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06003C75 RID: 15477 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C75")]
			[Address(RVA = "0x2480594", Offset = "0x2480594", VA = "0x7BBCC80594")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x06003C76 RID: 15478 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C76")]
			[Address(RVA = "0x248059C", Offset = "0x248059C", VA = "0x7BBCC8059C")]
			internal void <Load>b__0(WWW www, ResWWWFileLoader loader)
			{
			}

			// Token: 0x06003C77 RID: 15479 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C77")]
			[Address(RVA = "0x248091C", Offset = "0x248091C", VA = "0x7BBCC8091C")]
			internal void <Load>b__1(ResErrorCode error, ResDownloadType type)
			{
			}

			// Token: 0x04004DA4 RID: 19876
			[Token(Token = "0x4004DA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ResHotUpdater updaterInst;

			// Token: 0x04004DA5 RID: 19877
			[Token(Token = "0x4004DA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DownloadContext download_context;

			// Token: 0x04004DA6 RID: 19878
			[Token(Token = "0x4004DA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ResVersionInfo <>4__this;

			// Token: 0x04004DA7 RID: 19879
			[Token(Token = "0x4004DA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<bool> onVersionInfoLoaded;
		}

		// Token: 0x02000FEE RID: 4078
		[Token(Token = "0x2000FEE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA610", Offset = "0x10EA610")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06003C78 RID: 15480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C78")]
			[Address(RVA = "0x2480990", Offset = "0x2480990", VA = "0x7BBCC80990")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06003C79 RID: 15481 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C79")]
			[Address(RVA = "0x2480998", Offset = "0x2480998", VA = "0x7BBCC80998")]
			internal void <LoadFileInfo>b__0(WWW www, ResWWWFileLoader loader)
			{
			}

			// Token: 0x06003C7A RID: 15482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C7A")]
			[Address(RVA = "0x2480D38", Offset = "0x2480D38", VA = "0x7BBCC80D38")]
			internal void <LoadFileInfo>b__1(ResErrorCode error, ResDownloadType type)
			{
			}

			// Token: 0x04004DA8 RID: 19880
			[Token(Token = "0x4004DA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ResHotUpdater updaterInst;

			// Token: 0x04004DA9 RID: 19881
			[Token(Token = "0x4004DA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DownloadContext download_context;

			// Token: 0x04004DAA RID: 19882
			[Token(Token = "0x4004DAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ResVersionInfo <>4__this;

			// Token: 0x04004DAB RID: 19883
			[Token(Token = "0x4004DAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<bool> onFileInfoLoaded;
		}

		// Token: 0x02000FEF RID: 4079
		[Token(Token = "0x2000FEF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA620", Offset = "0x10EA620")]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x06003C7B RID: 15483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003C7B")]
			[Address(RVA = "0x2480DAC", Offset = "0x2480DAC", VA = "0x7BBCC80DAC")]
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x06003C7C RID: 15484 RVA: 0x00012E40 File Offset: 0x00011040
			[Token(Token = "0x6003C7C")]
			[Address(RVA = "0x2480DB4", Offset = "0x2480DB4", VA = "0x7BBCC80DB4")]
			internal bool <ParseFile>b__0(ResFileType element)
			{
				return default(bool);
			}

			// Token: 0x04004DAC RID: 19884
			[Token(Token = "0x4004DAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ResFileType fileType;
		}
	}
}
