using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200131F RID: 4895
	[Token(Token = "0x200131F")]
	public static class TextMessageConfig
	{
		// Token: 0x06004DA8 RID: 19880 RVA: 0x000177C0 File Offset: 0x000159C0
		[Token(Token = "0x6004DA8")]
		[Address(RVA = "0x1B476DC", Offset = "0x1B476DC", VA = "0x7BBC3476DC")]
		public static bool IsChatServerValid()
		{
			return default(bool);
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06004DA9 RID: 19881 RVA: 0x000177D8 File Offset: 0x000159D8
		[Token(Token = "0x17000864")]
		public static bool IsAvailable
		{
			[Token(Token = "0x6004DA9")]
			[Address(RVA = "0x1B477A8", Offset = "0x1B477A8", VA = "0x7BBC3477A8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04007529 RID: 29993
		[Token(Token = "0x4007529")]
		public const int INVALID_SERVERZONE_ID = 9999;

		// Token: 0x0400752A RID: 29994
		[Token(Token = "0x400752A")]
		[FieldOffset(Offset = "0x0")]
		public static int ServerZoneID;

		// Token: 0x0400752B RID: 29995
		[Token(Token = "0x400752B")]
		[FieldOffset(Offset = "0x8")]
		public static string ServerAddr;
	}
}
