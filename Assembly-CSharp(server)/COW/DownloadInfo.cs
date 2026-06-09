using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001F8D RID: 8077
	[Token(Token = "0x2001F8D")]
	public class DownloadInfo
	{
		// Token: 0x0600B2A5 RID: 45733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2A5")]
		[Address(RVA = "0x1609358", Offset = "0x1609358", VA = "0x7BBBE09358")]
		public DownloadInfo()
		{
		}

		// Token: 0x0400B599 RID: 46489
		[Token(Token = "0x400B599")]
		[FieldOffset(Offset = "0x10")]
		public ResUpdateDownloadContext DownloadContext;

		// Token: 0x0400B59A RID: 46490
		[Token(Token = "0x400B59A")]
		[FieldOffset(Offset = "0x18")]
		public ResVersionInfo.FileInfo DesignatedFileInfo;

		// Token: 0x0400B59B RID: 46491
		[Token(Token = "0x400B59B")]
		[FieldOffset(Offset = "0x20")]
		public bool NeedRetry;
	}
}
