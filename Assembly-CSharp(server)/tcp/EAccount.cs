using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000439 RID: 1081
	[Token(Token = "0x2000439")]
	[ProtoContract]
	public class EAccount
	{
		// Token: 0x06001BEB RID: 7147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEB")]
		[Address(RVA = "0x24A2CE0", Offset = "0x24A2CE0", VA = "0x7BBCCA2CE0")]
		public EAccount()
		{
		}

		// Token: 0x0200043A RID: 1082
		[Token(Token = "0x200043A")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x0400144B RID: 5195
			[Token(Token = "0x400144B")]
			Proto_NONE,
			// Token: 0x0400144C RID: 5196
			[Token(Token = "0x400144C")]
			Proto_MULTILOGIN_NTF,
			// Token: 0x0400144D RID: 5197
			[Token(Token = "0x400144D")]
			Proto_INVALID_CLIENT_VERSION_NTF,
			// Token: 0x0400144E RID: 5198
			[Token(Token = "0x400144E")]
			Proto_ACCOUNT_IN_BLACKLIST_NTF,
			// Token: 0x0400144F RID: 5199
			[Token(Token = "0x400144F")]
			Proto_ACCOUNT_LEVEL_UP_NTF,
			// Token: 0x04001450 RID: 5200
			[Token(Token = "0x4001450")]
			Proto_ACCOUNT_ROLE_CHANGED_NTF
		}

		// Token: 0x0200043B RID: 1083
		[Token(Token = "0x200043B")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x04001452 RID: 5202
			[Token(Token = "0x4001452")]
			ErrCode_SUSS
		}
	}
}
