using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000537 RID: 1335
	[Token(Token = "0x2000537")]
	[ProtoContract]
	public class EGeoip
	{
		// Token: 0x0600218B RID: 8587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600218B")]
		[Address(RVA = "0x24A2D38", Offset = "0x24A2D38", VA = "0x7BBCCA2D38")]
		public EGeoip()
		{
		}

		// Token: 0x02000538 RID: 1336
		[Token(Token = "0x2000538")]
		[ProtoContract]
		public enum ChatServer
		{
			// Token: 0x04001930 RID: 6448
			[Token(Token = "0x4001930")]
			ChatServer_None,
			// Token: 0x04001931 RID: 6449
			[Token(Token = "0x4001931")]
			ChatServer_CloseTextChat = 9999
		}
	}
}
