using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001325 RID: 4901
	[Token(Token = "0x2001325")]
	public abstract class AutoPopupTask
	{
		// Token: 0x06004DBA RID: 19898
		[Token(Token = "0x6004DBA")]
		public abstract ServiceMessageTypeHTTP[] NeedHttpRequests();

		// Token: 0x06004DBB RID: 19899
		[Token(Token = "0x6004DBB")]
		public abstract bool Do();

		// Token: 0x06004DBC RID: 19900
		[Token(Token = "0x6004DBC")]
		public abstract bool IsDone();

		// Token: 0x06004DBD RID: 19901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DBD")]
		[Address(RVA = "0x1556648", Offset = "0x1556648", VA = "0x7BBBD56648")]
		protected AutoPopupTask()
		{
		}
	}
}
