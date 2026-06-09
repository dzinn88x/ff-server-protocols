using System;
using Il2CppDummyDll;

namespace GarenaMSDK
{
	// Token: 0x02002BED RID: 11245
	[Token(Token = "0x2002BED")]
	public class SDKIAPTaskResult
	{
		// Token: 0x0600F8AC RID: 63660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F8AC")]
		[Address(RVA = "0x273ADBC", Offset = "0x273ADBC", VA = "0x7BBCF3ADBC")]
		public string IdentifySelf()
		{
			return null;
		}

		// Token: 0x0600F8AD RID: 63661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F8AD")]
		[Address(RVA = "0x273A820", Offset = "0x273A820", VA = "0x7BBCF3A820")]
		public SDKIAPTaskResult()
		{
		}

		// Token: 0x04011CA1 RID: 72865
		[Token(Token = "0x4011CA1")]
		[FieldOffset(Offset = "0x10")]
		public ErrorCode Code;

		// Token: 0x04011CA2 RID: 72866
		[Token(Token = "0x4011CA2")]
		[FieldOffset(Offset = "0x18")]
		public string Msg;
	}
}
