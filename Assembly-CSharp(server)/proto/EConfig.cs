using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005B7 RID: 1463
	[Token(Token = "0x20005B7")]
	[ProtoContract]
	public class EConfig
	{
		// Token: 0x06002350 RID: 9040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002350")]
		[Address(RVA = "0x21B9800", Offset = "0x21B9800", VA = "0x7BBC9B9800")]
		public EConfig()
		{
		}

		// Token: 0x020005B8 RID: 1464
		[Token(Token = "0x20005B8")]
		[ProtoContract]
		public enum ConfigFile
		{
			// Token: 0x04001D05 RID: 7429
			[Token(Token = "0x4001D05")]
			ConfigFile_STATS_RANKINGSEAONINFO
		}
	}
}
