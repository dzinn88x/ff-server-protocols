using System;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON
{
	// Token: 0x02002BA9 RID: 11177
	[Token(Token = "0x2002BA9")]
	public enum JSONNodeType
	{
		// Token: 0x04011B33 RID: 72499
		[Token(Token = "0x4011B33")]
		Array = 1,
		// Token: 0x04011B34 RID: 72500
		[Token(Token = "0x4011B34")]
		Object,
		// Token: 0x04011B35 RID: 72501
		[Token(Token = "0x4011B35")]
		String,
		// Token: 0x04011B36 RID: 72502
		[Token(Token = "0x4011B36")]
		Number,
		// Token: 0x04011B37 RID: 72503
		[Token(Token = "0x4011B37")]
		NullValue,
		// Token: 0x04011B38 RID: 72504
		[Token(Token = "0x4011B38")]
		Boolean,
		// Token: 0x04011B39 RID: 72505
		[Token(Token = "0x4011B39")]
		None,
		// Token: 0x04011B3A RID: 72506
		[Token(Token = "0x4011B3A")]
		Custom = 255
	}
}
