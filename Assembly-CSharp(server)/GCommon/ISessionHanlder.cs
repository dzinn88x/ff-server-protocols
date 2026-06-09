using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F96 RID: 3990
	[Token(Token = "0x2000F96")]
	public interface ISessionHanlder
	{
		// Token: 0x06003A17 RID: 14871
		[Token(Token = "0x6003A17")]
		void OnConnected(bool result);

		// Token: 0x06003A18 RID: 14872
		[Token(Token = "0x6003A18")]
		void OnDisconnected(DisconnectedReason reason = DisconnectedReason.Unknown);

		// Token: 0x06003A19 RID: 14873
		[Token(Token = "0x6003A19")]
		void OnPingSent(int lastSentTime);
	}
}
