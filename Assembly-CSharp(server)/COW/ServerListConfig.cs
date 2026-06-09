using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CF2 RID: 7410
	[Token(Token = "0x2001CF2")]
	[Serializable]
	internal class ServerListConfig
	{
		// Token: 0x0600A19C RID: 41372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A19C")]
		[Address(RVA = "0x1B33BEC", Offset = "0x1B33BEC", VA = "0x7BBC333BEC")]
		public ServerConfig GetServerConfigByURL(string url)
		{
			return null;
		}

		// Token: 0x0600A19D RID: 41373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A19D")]
		[Address(RVA = "0x1B33CF0", Offset = "0x1B33CF0", VA = "0x7BBC333CF0")]
		public ServerListConfig()
		{
		}

		// Token: 0x0400A805 RID: 43013
		[Token(Token = "0x400A805")]
		[FieldOffset(Offset = "0x10")]
		public ServerConfig[] serverList;
	}
}
