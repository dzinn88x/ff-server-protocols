using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001336 RID: 4918
	[Token(Token = "0x2001336")]
	public class AutoTaskNewPlayer : AutoPopupTask
	{
		// Token: 0x06004DF9 RID: 19961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF9")]
		[Address(RVA = "0x155A68C", Offset = "0x155A68C", VA = "0x7BBBD5A68C", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DFA RID: 19962 RVA: 0x00017AF0 File Offset: 0x00015CF0
		[Token(Token = "0x6004DFA")]
		[Address(RVA = "0x155A70C", Offset = "0x155A70C", VA = "0x7BBBD5A70C", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DFB RID: 19963 RVA: 0x00017B08 File Offset: 0x00015D08
		[Token(Token = "0x6004DFB")]
		[Address(RVA = "0x155A878", Offset = "0x155A878", VA = "0x7BBBD5A878", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DFC RID: 19964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DFC")]
		[Address(RVA = "0x155A918", Offset = "0x155A918", VA = "0x7BBBD5A918")]
		public AutoTaskNewPlayer()
		{
		}

		// Token: 0x0400754B RID: 30027
		[Token(Token = "0x400754B")]
		[FieldOffset(Offset = "0x10")]
		private UINewPlayerController m_NewPlayerUI;
	}
}
