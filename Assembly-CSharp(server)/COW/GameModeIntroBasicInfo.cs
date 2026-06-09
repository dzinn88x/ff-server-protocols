using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018C2 RID: 6338
	[Token(Token = "0x20018C2")]
	public class GameModeIntroBasicInfo
	{
		// Token: 0x06007E3B RID: 32315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E3B")]
		[Address(RVA = "0x187EB70", Offset = "0x187EB70", VA = "0x7BBC07EB70")]
		public GameModeIntroBasicInfo(string icon, string title, string desc)
		{
		}

		// Token: 0x04009199 RID: 37273
		[Token(Token = "0x4009199")]
		[FieldOffset(Offset = "0x10")]
		public string ModeIcon;

		// Token: 0x0400919A RID: 37274
		[Token(Token = "0x400919A")]
		[FieldOffset(Offset = "0x18")]
		public string Title;

		// Token: 0x0400919B RID: 37275
		[Token(Token = "0x400919B")]
		[FieldOffset(Offset = "0x20")]
		public string Desc;
	}
}
