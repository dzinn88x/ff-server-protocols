using System;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x02001B68 RID: 7016
	[Token(Token = "0x2001B68")]
	public class FRoomModeSelectData
	{
		// Token: 0x060096FD RID: 38653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60096FD")]
		[Address(RVA = "0x1B95314", Offset = "0x1B95314", VA = "0x7BBC395314")]
		public FRoomModeSelectData()
		{
		}

		// Token: 0x04009F46 RID: 40774
		[Token(Token = "0x4009F46")]
		[FieldOffset(Offset = "0x10")]
		public EMatch.GameMode gamemode;

		// Token: 0x04009F47 RID: 40775
		[Token(Token = "0x4009F47")]
		[FieldOffset(Offset = "0x14")]
		public EMatch.GroupMode groupMode;

		// Token: 0x04009F48 RID: 40776
		[Token(Token = "0x4009F48")]
		[FieldOffset(Offset = "0x18")]
		public bool select;

		// Token: 0x04009F49 RID: 40777
		[Token(Token = "0x4009F49")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04009F4A RID: 40778
		[Token(Token = "0x4009F4A")]
		[FieldOffset(Offset = "0x28")]
		public string icon;
	}
}
