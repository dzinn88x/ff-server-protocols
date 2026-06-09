using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CF3 RID: 7411
	[Token(Token = "0x2001CF3")]
	[Serializable]
	internal class ServerConfig
	{
		// Token: 0x0600A19E RID: 41374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A19E")]
		[Address(RVA = "0x1B33BE4", Offset = "0x1B33BE4", VA = "0x7BBC333BE4")]
		public ServerConfig()
		{
		}

		// Token: 0x0400A806 RID: 43014
		[Token(Token = "0x400A806")]
		[FieldOffset(Offset = "0x10")]
		public string serverName;

		// Token: 0x0400A807 RID: 43015
		[Token(Token = "0x400A807")]
		[FieldOffset(Offset = "0x18")]
		public string serverUrl;

		// Token: 0x0400A808 RID: 43016
		[Token(Token = "0x400A808")]
		[FieldOffset(Offset = "0x20")]
		public bool garenaOverride;

		// Token: 0x0400A809 RID: 43017
		[Token(Token = "0x400A809")]
		[FieldOffset(Offset = "0x21")]
		public bool garenaSandbox;

		// Token: 0x0400A80A RID: 43018
		[Token(Token = "0x400A80A")]
		[FieldOffset(Offset = "0x22")]
		public bool skipVersionCheck;
	}
}
