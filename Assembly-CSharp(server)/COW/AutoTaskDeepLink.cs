using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x0200132D RID: 4909
	[Token(Token = "0x200132D")]
	internal class AutoTaskDeepLink : AutoPopupTask
	{
		// Token: 0x06004DD5 RID: 19925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DD5")]
		[Address(RVA = "0x15589EC", Offset = "0x15589EC", VA = "0x7BBBD589EC", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x00017940 File Offset: 0x00015B40
		[Token(Token = "0x6004DD6")]
		[Address(RVA = "0x15589F4", Offset = "0x15589F4", VA = "0x7BBBD589F4", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DD7 RID: 19927 RVA: 0x00017958 File Offset: 0x00015B58
		[Token(Token = "0x6004DD7")]
		[Address(RVA = "0x15589FC", Offset = "0x15589FC", VA = "0x7BBBD589FC", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DD8 RID: 19928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD8")]
		[Address(RVA = "0x1558AE4", Offset = "0x1558AE4", VA = "0x7BBBD58AE4")]
		public AutoTaskDeepLink()
		{
		}
	}
}
