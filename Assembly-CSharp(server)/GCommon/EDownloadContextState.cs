using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FD6 RID: 4054
	[Token(Token = "0x2000FD6")]
	public enum EDownloadContextState
	{
		// Token: 0x04004D16 RID: 19734
		[Token(Token = "0x4004D16")]
		None,
		// Token: 0x04004D17 RID: 19735
		[Token(Token = "0x4004D17")]
		ReadyForStart,
		// Token: 0x04004D18 RID: 19736
		[Token(Token = "0x4004D18")]
		Download,
		// Token: 0x04004D19 RID: 19737
		[Token(Token = "0x4004D19")]
		Paused,
		// Token: 0x04004D1A RID: 19738
		[Token(Token = "0x4004D1A")]
		DownloadFinished
	}
}
