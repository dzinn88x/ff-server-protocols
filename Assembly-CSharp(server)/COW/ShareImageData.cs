using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019B6 RID: 6582
	[Token(Token = "0x20019B6")]
	internal class ShareImageData
	{
		// Token: 0x060086F9 RID: 34553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086F9")]
		[Address(RVA = "0x1B37400", Offset = "0x1B37400", VA = "0x7BBC337400")]
		public ShareImageData()
		{
		}

		// Token: 0x040095C8 RID: 38344
		[Token(Token = "0x40095C8")]
		[FieldOffset(Offset = "0x10")]
		public UIUtils.ScreenshotType ScreenshotType;

		// Token: 0x040095C9 RID: 38345
		[Token(Token = "0x40095C9")]
		[FieldOffset(Offset = "0x18")]
		public string FilePath;

		// Token: 0x040095CA RID: 38346
		[Token(Token = "0x40095CA")]
		[FieldOffset(Offset = "0x20")]
		public UIUtils.EShareScreenType ShareScreenType;
	}
}
