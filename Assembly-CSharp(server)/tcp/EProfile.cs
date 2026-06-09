using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004F6 RID: 1270
	[Token(Token = "0x20004F6")]
	[ProtoContract]
	public class EProfile
	{
		// Token: 0x06001FC3 RID: 8131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC3")]
		[Address(RVA = "0x24A2D98", Offset = "0x24A2D98", VA = "0x7BBCCA2D98")]
		public EProfile()
		{
		}

		// Token: 0x020004F7 RID: 1271
		[Token(Token = "0x20004F7")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x04001776 RID: 6006
			[Token(Token = "0x4001776")]
			Proto_NONE,
			// Token: 0x04001777 RID: 6007
			[Token(Token = "0x4001777")]
			Proto_NEW_PROFILE_NTF,
			// Token: 0x04001778 RID: 6008
			[Token(Token = "0x4001778")]
			Proto_NEW_SKILL_NTF,
			// Token: 0x04001779 RID: 6009
			[Token(Token = "0x4001779")]
			Proto_PROFILE_CHANGE_NTF,
			// Token: 0x0400177A RID: 6010
			[Token(Token = "0x400177A")]
			Proto_AWAKEN_TASK_CHANGE_NTF
		}

		// Token: 0x020004F8 RID: 1272
		[Token(Token = "0x20004F8")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x0400177C RID: 6012
			[Token(Token = "0x400177C")]
			ErrCode_SUSS
		}
	}
}
