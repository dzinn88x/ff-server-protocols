using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000ECA RID: 3786
	[Token(Token = "0x2000ECA")]
	public interface IObjectPoolCallback
	{
		// Token: 0x06003435 RID: 13365
		[Token(Token = "0x6003435")]
		void OnAllocated();

		// Token: 0x06003436 RID: 13366
		[Token(Token = "0x6003436")]
		void OnCollected();

		// Token: 0x06003437 RID: 13367
		[Token(Token = "0x6003437")]
		bool IsInPool();
	}
}
