using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001F8C RID: 8076
	[Token(Token = "0x2001F8C")]
	public enum EModelDownloadState
	{
		// Token: 0x0400B594 RID: 46484
		[Token(Token = "0x400B594")]
		None,
		// Token: 0x0400B595 RID: 46485
		[Token(Token = "0x400B595")]
		NeedDownload,
		// Token: 0x0400B596 RID: 46486
		[Token(Token = "0x400B596")]
		Running,
		// Token: 0x0400B597 RID: 46487
		[Token(Token = "0x400B597")]
		Paused,
		// Token: 0x0400B598 RID: 46488
		[Token(Token = "0x400B598")]
		Finished
	}
}
