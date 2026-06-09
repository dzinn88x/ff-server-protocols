using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000599 RID: 1433
	[Token(Token = "0x2000599")]
	[ProtoContract]
	public class EGameServerManager
	{
		// Token: 0x06002348 RID: 9032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002348")]
		[Address(RVA = "0x21B9818", Offset = "0x21B9818", VA = "0x7BBC9B9818")]
		public EGameServerManager()
		{
		}

		// Token: 0x0200059A RID: 1434
		[Token(Token = "0x200059A")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x04001C73 RID: 7283
			[Token(Token = "0x4001C73")]
			Proto_NONE,
			// Token: 0x04001C74 RID: 7284
			[Token(Token = "0x4001C74")]
			Proto_REPORT,
			// Token: 0x04001C75 RID: 7285
			[Token(Token = "0x4001C75")]
			Proto_PLAYERLOGIN,
			// Token: 0x04001C76 RID: 7286
			[Token(Token = "0x4001C76")]
			Proto_PLAYERLOGOUT,
			// Token: 0x04001C77 RID: 7287
			[Token(Token = "0x4001C77")]
			Proto_ENDMATCH,
			// Token: 0x04001C78 RID: 7288
			[Token(Token = "0x4001C78")]
			Proto_CUSTOMROOM_MATCHSTATS
		}

		// Token: 0x0200059B RID: 1435
		[Token(Token = "0x200059B")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x04001C7A RID: 7290
			[Token(Token = "0x4001C7A")]
			ErrCode_SUSS,
			// Token: 0x04001C7B RID: 7291
			[Token(Token = "0x4001C7B")]
			ErrCode_ROOMFULL = 8
		}

		// Token: 0x0200059C RID: 1436
		[Token(Token = "0x200059C")]
		[ProtoContract]
		public enum HandleGSLoad
		{
			// Token: 0x04001C7D RID: 7293
			[Token(Token = "0x4001C7D")]
			HandleGSLoad_NONE,
			// Token: 0x04001C7E RID: 7294
			[Token(Token = "0x4001C7E")]
			HandleGSLoad_UPDATE,
			// Token: 0x04001C7F RID: 7295
			[Token(Token = "0x4001C7F")]
			HandleGSLoad_DELETE
		}
	}
}
