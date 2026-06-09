using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.GMSDK
{
	// Token: 0x02002BBF RID: 11199
	[Token(Token = "0x2002BBF")]
	internal static class GGErrorCodeManager
	{
		// Token: 0x0600F802 RID: 63490 RVA: 0x00047688 File Offset: 0x00045888
		[Token(Token = "0x600F802")]
		[Address(RVA = "0x2741A84", Offset = "0x2741A84", VA = "0x7BBCF41A84")]
		public static bool IsFatal(GGErrorCode value)
		{
			return default(bool);
		}

		// Token: 0x04011B8D RID: 72589
		[Token(Token = "0x4011B8D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<GGErrorCode, string> _CodeTexts;
	}
}
