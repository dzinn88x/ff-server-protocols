using System;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x0200132F RID: 4911
	[Token(Token = "0x200132F")]
	public class AutoTaskEPTaskGuild : AutoPopupTask
	{
		// Token: 0x06004DDD RID: 19933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DDD")]
		[Address(RVA = "0x1558E24", Offset = "0x1558E24", VA = "0x7BBBD58E24", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DDE RID: 19934 RVA: 0x000179A0 File Offset: 0x00015BA0
		[Token(Token = "0x6004DDE")]
		[Address(RVA = "0x1558E2C", Offset = "0x1558E2C", VA = "0x7BBBD58E2C", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DDF RID: 19935 RVA: 0x000179B8 File Offset: 0x00015BB8
		[Token(Token = "0x6004DDF")]
		[Address(RVA = "0x1558F30", Offset = "0x1558F30", VA = "0x7BBBD58F30", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DE0 RID: 19936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE0")]
		[Address(RVA = "0x1558FD0", Offset = "0x1558FD0", VA = "0x7BBBD58FD0")]
		public AutoTaskEPTaskGuild()
		{
		}

		// Token: 0x04007545 RID: 30021
		[Token(Token = "0x4007545")]
		[FieldOffset(Offset = "0x10")]
		private UIEPTaskGuideController m_EPTaskGuideUI;
	}
}
