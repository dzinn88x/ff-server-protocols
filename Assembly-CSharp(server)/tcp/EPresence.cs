using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004EF RID: 1263
	[Token(Token = "0x20004EF")]
	[ProtoContract]
	public class EPresence
	{
		// Token: 0x06001FA7 RID: 8103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA7")]
		[Address(RVA = "0x24A2D90", Offset = "0x24A2D90", VA = "0x7BBCCA2D90")]
		public EPresence()
		{
		}

		// Token: 0x020004F0 RID: 1264
		[Token(Token = "0x20004F0")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x04001761 RID: 5985
			[Token(Token = "0x4001761")]
			Proto_NONE,
			// Token: 0x04001762 RID: 5986
			[Token(Token = "0x4001762")]
			Proto_PRESENCELIST
		}

		// Token: 0x020004F1 RID: 1265
		[Token(Token = "0x20004F1")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x04001764 RID: 5988
			[Token(Token = "0x4001764")]
			ErrCode_SUSS
		}

		// Token: 0x020004F2 RID: 1266
		[Token(Token = "0x20004F2")]
		[ProtoContract]
		public enum PresenceListType
		{
			// Token: 0x04001766 RID: 5990
			[Token(Token = "0x4001766")]
			PresenceListType_NONE,
			// Token: 0x04001767 RID: 5991
			[Token(Token = "0x4001767")]
			PresenceListType_FRIEND,
			// Token: 0x04001768 RID: 5992
			[Token(Token = "0x4001768")]
			PresenceListType_CLAN
		}
	}
}
