using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F74 RID: 3956
	[Token(Token = "0x2000F74")]
	public interface IHttpManagerMonitor
	{
		// Token: 0x0600398E RID: 14734
		[Token(Token = "0x600398E")]
		void OnStartRequest(HttpManager.EHttpChannel channel, HttpRequest curHttpReq);

		// Token: 0x0600398F RID: 14735
		[Token(Token = "0x600398F")]
		void OnEndRequest(HttpManager.EHttpChannel channel, string cmd, bool hasNext);

		// Token: 0x06003990 RID: 14736
		[Token(Token = "0x6003990")]
		void OnUnauthorized(HttpManager.EHttpChannel channel);

		// Token: 0x06003991 RID: 14737
		[Token(Token = "0x6003991")]
		void OnRetryFailed(HttpManager.EHttpChannel channel, HttpRequest curHttpReq);
	}
}
