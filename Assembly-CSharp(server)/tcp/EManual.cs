using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004D0 RID: 1232
	[Token(Token = "0x20004D0")]
	[ProtoContract]
	public class EManual
	{
		// Token: 0x06001EEA RID: 7914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEA")]
		[Address(RVA = "0x24A2D68", Offset = "0x24A2D68", VA = "0x7BBCCA2D68")]
		public EManual()
		{
		}

		// Token: 0x020004D1 RID: 1233
		[Token(Token = "0x20004D1")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x040016C9 RID: 5833
			[Token(Token = "0x40016C9")]
			Proto_NONE,
			// Token: 0x040016CA RID: 5834
			[Token(Token = "0x40016CA")]
			Proto_WEAPON_REWARD_UPDATE_NTF,
			// Token: 0x040016CB RID: 5835
			[Token(Token = "0x40016CB")]
			Proto_MAP_REWARD_UPDATE_NTF
		}

		// Token: 0x020004D2 RID: 1234
		[Token(Token = "0x20004D2")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x040016CD RID: 5837
			[Token(Token = "0x40016CD")]
			ErrCode_SUSS
		}
	}
}
