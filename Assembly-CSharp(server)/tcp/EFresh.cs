using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200047D RID: 1149
	[Token(Token = "0x200047D")]
	[ProtoContract]
	public class EFresh
	{
		// Token: 0x06001CEA RID: 7402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEA")]
		[Address(RVA = "0x24A2D28", Offset = "0x24A2D28", VA = "0x7BBCCA2D28")]
		public EFresh()
		{
		}

		// Token: 0x0200047E RID: 1150
		[Token(Token = "0x200047E")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x04001520 RID: 5408
			[Token(Token = "0x4001520")]
			Proto_NONE,
			// Token: 0x04001521 RID: 5409
			[Token(Token = "0x4001521")]
			Proto_UPDATE_NTF
		}

		// Token: 0x0200047F RID: 1151
		[Token(Token = "0x200047F")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x04001523 RID: 5411
			[Token(Token = "0x4001523")]
			ErrCode_SUSS
		}
	}
}
