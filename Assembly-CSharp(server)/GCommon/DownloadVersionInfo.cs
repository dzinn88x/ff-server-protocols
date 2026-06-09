using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000FC0 RID: 4032
	[Token(Token = "0x2000FC0")]
	public class DownloadVersionInfo
	{
		// Token: 0x06003AD6 RID: 15062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD6")]
		[Address(RVA = "0x25F09EC", Offset = "0x25F09EC", VA = "0x7BBCDF09EC")]
		public DownloadVersionInfo(bool isRemote, ResDownloadType download_type)
		{
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD7")]
		[Address(RVA = "0x25F0BA8", Offset = "0x25F0BA8", VA = "0x7BBCDF0BA8")]
		public void LoadVersionInfo(ResUpdateDownloadContext update_context, string versionInfoPath, Action<bool> onVersionInfoLoaded)
		{
		}

		// Token: 0x06003AD8 RID: 15064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD8")]
		[Address(RVA = "0x25F1504", Offset = "0x25F1504", VA = "0x7BBCDF1504")]
		public void LoadFromString(ResUpdateDownloadContext downloadContext, string version_string)
		{
		}

		// Token: 0x06003AD9 RID: 15065 RVA: 0x00012450 File Offset: 0x00010650
		[Token(Token = "0x6003AD9")]
		[Address(RVA = "0x25F1588", Offset = "0x25F1588", VA = "0x7BBCDF1588")]
		protected bool ParseVersion(string content, ref uint _version)
		{
			return default(bool);
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADA")]
		[Address(RVA = "0x25F16B4", Offset = "0x25F16B4", VA = "0x7BBCDF16B4")]
		public void LoadFileInfo(ResUpdateDownloadContext downloadContext, string fileInfoPath, Action<bool> onFileInfoLoaded)
		{
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x00012468 File Offset: 0x00010668
		[Token(Token = "0x6003ADB")]
		[Address(RVA = "0x25F18EC", Offset = "0x25F18EC", VA = "0x7BBCDF18EC")]
		private bool LoadLocalFileInfo(ResUpdateDownloadContext downloadContext)
		{
			return default(bool);
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x00012480 File Offset: 0x00010680
		[Token(Token = "0x6003ADC")]
		[Address(RVA = "0x25F1C78", Offset = "0x25F1C78", VA = "0x7BBCDF1C78", Slot = "4")]
		protected virtual bool ParseFile(string content, bool from_local = false)
		{
			return default(bool);
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADD")]
		[Address(RVA = "0x25F24E4", Offset = "0x25F24E4", VA = "0x7BBCDF24E4")]
		public string GetVersionString()
		{
			return null;
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x00012498 File Offset: 0x00010698
		[Token(Token = "0x6003ADE")]
		[Address(RVA = "0x25F24F0", Offset = "0x25F24F0", VA = "0x7BBCDF24F0")]
		public static bool HaveEnoughStorage()
		{
			return default(bool);
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADF")]
		[Address(RVA = "0x25F255C", Offset = "0x25F255C", VA = "0x7BBCDF255C")]
		public Dictionary<string, ResVersionInfo.FileInfo> GetFileInfoList()
		{
			return null;
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AE0")]
		[Address(RVA = "0x25F2564", Offset = "0x25F2564", VA = "0x7BBCDF2564")]
		public HashSet<string> GetDepFileNames()
		{
			return null;
		}

		// Token: 0x06003AE1 RID: 15073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AE1")]
		[Address(RVA = "0x25F256C", Offset = "0x25F256C", VA = "0x7BBCDF256C")]
		public List<ResVersionInfo.FileInfo> GetNeedDownloadFileInfo()
		{
			return null;
		}

		// Token: 0x06003AE2 RID: 15074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE2")]
		[Address(RVA = "0x25F27A4", Offset = "0x25F27A4", VA = "0x7BBCDF27A4")]
		public void ClearVersion()
		{
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE3")]
		[Address(RVA = "0x25F27AC", Offset = "0x25F27AC", VA = "0x7BBCDF27AC", Slot = "5")]
		public virtual void ClearFileInfoList()
		{
		}

		// Token: 0x06003AE4 RID: 15076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE4")]
		[Address(RVA = "0x25F29C8", Offset = "0x25F29C8", VA = "0x7BBCDF29C8")]
		public void ResetFileState(string file_name)
		{
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE5")]
		[Address(RVA = "0x25F2ACC", Offset = "0x25F2ACC", VA = "0x7BBCDF2ACC")]
		public void ClearDownloadFlag()
		{
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x000124B0 File Offset: 0x000106B0
		[Token(Token = "0x6003AE6")]
		[Address(RVA = "0x25F2C34", Offset = "0x25F2C34", VA = "0x7BBCDF2C34")]
		public bool FindFileInfo(string fullName, out ResVersionInfo.FileInfo result)
		{
			return default(bool);
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AE7")]
		[Address(RVA = "0x25F2CD0", Offset = "0x25F2CD0", VA = "0x7BBCDF2CD0")]
		public void AddFileInfo(ResVersionInfo.FileInfo fileInfo)
		{
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x000124C8 File Offset: 0x000106C8
		[Token(Token = "0x6003AE8")]
		[Address(RVA = "0x25F2EEC", Offset = "0x25F2EEC", VA = "0x7BBCDF2EEC", Slot = "6")]
		public virtual ResErrorCode SaveFileInfo(ResUpdateDownloadContext context)
		{
			return ResErrorCode.OK;
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x000124E0 File Offset: 0x000106E0
		[Token(Token = "0x6003AE9")]
		[Address(RVA = "0x25F38CC", Offset = "0x25F38CC", VA = "0x7BBCDF38CC")]
		public ResErrorCode SaveVersionInfo(ResUpdateDownloadContext context)
		{
			return ResErrorCode.OK;
		}

		// Token: 0x06003AEA RID: 15082 RVA: 0x000124F8 File Offset: 0x000106F8
		[Token(Token = "0x6003AEA")]
		[Address(RVA = "0x25F3BC4", Offset = "0x25F3BC4", VA = "0x7BBCDF3BC4")]
		public ResErrorCode Save(ResUpdateDownloadContext context)
		{
			return ResErrorCode.OK;
		}

		// Token: 0x04004C7B RID: 19579
		[Token(Token = "0x4004C7B")]
		[FieldOffset(Offset = "0x10")]
		protected bool m_IsRemote;

		// Token: 0x04004C7C RID: 19580
		[Token(Token = "0x4004C7C")]
		[FieldOffset(Offset = "0x11")]
		public bool m_UsedOld;

		// Token: 0x04004C7D RID: 19581
		[Token(Token = "0x4004C7D")]
		[FieldOffset(Offset = "0x14")]
		public uint Version;

		// Token: 0x04004C7E RID: 19582
		[Token(Token = "0x4004C7E")]
		[FieldOffset(Offset = "0x18")]
		public HashSet<ResFileType> FileTypeList;

		// Token: 0x04004C7F RID: 19583
		[Token(Token = "0x4004C7F")]
		[FieldOffset(Offset = "0x20")]
		protected Dictionary<string, ResVersionInfo.FileInfo> m_FileInfos;

		// Token: 0x04004C80 RID: 19584
		[Token(Token = "0x4004C80")]
		[FieldOffset(Offset = "0x28")]
		protected HashSet<string> m_DepFiles;

		// Token: 0x02000FC1 RID: 4033
		[Token(Token = "0x2000FC1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA550", Offset = "0x10EA550")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06003AEB RID: 15083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AEB")]
			[Address(RVA = "0x2110830", Offset = "0x2110830", VA = "0x7BBC910830")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06003AEC RID: 15084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AEC")]
			[Address(RVA = "0x2110838", Offset = "0x2110838", VA = "0x7BBC910838")]
			internal void <LoadVersionInfo>b__0(WWW www, ResWWWFileLoader loader)
			{
			}

			// Token: 0x06003AED RID: 15085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AED")]
			[Address(RVA = "0x2110BCC", Offset = "0x2110BCC", VA = "0x7BBC910BCC")]
			internal void <LoadVersionInfo>b__1(ResErrorCode error, ResDownloadType type)
			{
			}

			// Token: 0x04004C81 RID: 19585
			[Token(Token = "0x4004C81")]
			[FieldOffset(Offset = "0x10")]
			public ResUpdateDownloadContext update_context;

			// Token: 0x04004C82 RID: 19586
			[Token(Token = "0x4004C82")]
			[FieldOffset(Offset = "0x18")]
			public Action<bool> onVersionInfoLoaded;

			// Token: 0x04004C83 RID: 19587
			[Token(Token = "0x4004C83")]
			[FieldOffset(Offset = "0x20")]
			public DownloadVersionInfo <>4__this;
		}

		// Token: 0x02000FC2 RID: 4034
		[Token(Token = "0x2000FC2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA560", Offset = "0x10EA560")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06003AEE RID: 15086 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AEE")]
			[Address(RVA = "0x211043C", Offset = "0x211043C", VA = "0x7BBC91043C")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06003AEF RID: 15087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AEF")]
			[Address(RVA = "0x2110444", Offset = "0x2110444", VA = "0x7BBC910444")]
			internal void <LoadFileInfo>b__0(WWW www, ResWWWFileLoader loader)
			{
			}

			// Token: 0x06003AF0 RID: 15088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003AF0")]
			[Address(RVA = "0x21107BC", Offset = "0x21107BC", VA = "0x7BBC9107BC")]
			internal void <LoadFileInfo>b__1(ResErrorCode error, ResDownloadType type)
			{
			}

			// Token: 0x04004C84 RID: 19588
			[Token(Token = "0x4004C84")]
			[FieldOffset(Offset = "0x10")]
			public ResUpdateDownloadContext downloadContext;

			// Token: 0x04004C85 RID: 19589
			[Token(Token = "0x4004C85")]
			[FieldOffset(Offset = "0x18")]
			public DownloadVersionInfo <>4__this;

			// Token: 0x04004C86 RID: 19590
			[Token(Token = "0x4004C86")]
			[FieldOffset(Offset = "0x20")]
			public Action<bool> onFileInfoLoaded;
		}
	}
}
