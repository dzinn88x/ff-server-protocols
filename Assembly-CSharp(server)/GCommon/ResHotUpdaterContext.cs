using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000FD5 RID: 4053
	[Token(Token = "0x2000FD5")]
	public class ResHotUpdaterContext
	{
		// Token: 0x06003B79 RID: 15225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B79")]
		[Address(RVA = "0x2966204", Offset = "0x2966204", VA = "0x7BBD166204")]
		public void ClearContextActionReference()
		{
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B7A")]
		[Address(RVA = "0x29700E8", Offset = "0x29700E8", VA = "0x7BBD1700E8")]
		public ResHotUpdaterContext()
		{
		}

		// Token: 0x04004D00 RID: 19712
		[Token(Token = "0x4004D00")]
		[FieldOffset(Offset = "0x10")]
		public ResDownloadType[] DownloadTypes;

		// Token: 0x04004D01 RID: 19713
		[Token(Token = "0x4004D01")]
		[FieldOffset(Offset = "0x18")]
		public string RemoteAddr;

		// Token: 0x04004D02 RID: 19714
		[Token(Token = "0x4004D02")]
		[FieldOffset(Offset = "0x20")]
		public string VersionInfoPath;

		// Token: 0x04004D03 RID: 19715
		[Token(Token = "0x4004D03")]
		[FieldOffset(Offset = "0x28")]
		public string FileInfoPath;

		// Token: 0x04004D04 RID: 19716
		[Token(Token = "0x4004D04")]
		[FieldOffset(Offset = "0x30")]
		public string AssetBundlePrefix;

		// Token: 0x04004D05 RID: 19717
		[Token(Token = "0x4004D05")]
		[FieldOffset(Offset = "0x38")]
		public int MaxLoaderCountSimultaneously;

		// Token: 0x04004D06 RID: 19718
		[Token(Token = "0x4004D06")]
		[FieldOffset(Offset = "0x3C")]
		public int MaxOptionalDownloadThreadCount;

		// Token: 0x04004D07 RID: 19719
		[Token(Token = "0x4004D07")]
		[FieldOffset(Offset = "0x40")]
		public bool EnableOverrideWithFullData;

		// Token: 0x04004D08 RID: 19720
		[Token(Token = "0x4004D08")]
		[FieldOffset(Offset = "0x44")]
		public int MaxRetryCount;

		// Token: 0x04004D09 RID: 19721
		[Token(Token = "0x4004D09")]
		[FieldOffset(Offset = "0x48")]
		public MonoBehaviour CoroutineHolder;

		// Token: 0x04004D0A RID: 19722
		[Token(Token = "0x4004D0A")]
		[FieldOffset(Offset = "0x50")]
		public Action<ResHotUpdateResult> OnGetRemoteFileInfoFinished;

		// Token: 0x04004D0B RID: 19723
		[Token(Token = "0x4004D0B")]
		[FieldOffset(Offset = "0x58")]
		public Action<ResHotUpdateResult> OnGetLocalVerionFinished;

		// Token: 0x04004D0C RID: 19724
		[Token(Token = "0x4004D0C")]
		[FieldOffset(Offset = "0x60")]
		public Action<ResHotUpdateResult> OnStarted;

		// Token: 0x04004D0D RID: 19725
		[Token(Token = "0x4004D0D")]
		[FieldOffset(Offset = "0x68")]
		public Action<ResErrorCode> OnHotUpdateFinished;

		// Token: 0x04004D0E RID: 19726
		[Token(Token = "0x4004D0E")]
		[FieldOffset(Offset = "0x70")]
		public List<ResDownloadType> PendingDownloadTypes;

		// Token: 0x04004D0F RID: 19727
		[Token(Token = "0x4004D0F")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<ResDownloadType, string> OptionalVersionMap;

		// Token: 0x04004D10 RID: 19728
		[Token(Token = "0x4004D10")]
		[FieldOffset(Offset = "0x80")]
		public string LocalAddr;

		// Token: 0x04004D11 RID: 19729
		[Token(Token = "0x4004D11")]
		[FieldOffset(Offset = "0x88")]
		public string CacheAddr;

		// Token: 0x04004D12 RID: 19730
		[Token(Token = "0x4004D12")]
		[FieldOffset(Offset = "0x90")]
		public string OptionalCacheAddr;

		// Token: 0x04004D13 RID: 19731
		[Token(Token = "0x4004D13")]
		[FieldOffset(Offset = "0x98")]
		public string TempCacheAddr;

		// Token: 0x04004D14 RID: 19732
		[Token(Token = "0x4004D14")]
		[FieldOffset(Offset = "0xA0")]
		public bool NoResourceDownload;
	}
}
