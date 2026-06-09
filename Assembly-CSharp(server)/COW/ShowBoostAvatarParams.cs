using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200128D RID: 4749
	[Token(Token = "0x200128D")]
	public class ShowBoostAvatarParams
	{
		// Token: 0x0600499B RID: 18843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600499B")]
		[Address(RVA = "0x1B3887C", Offset = "0x1B3887C", VA = "0x7BBC33887C")]
		public ShowBoostAvatarParams()
		{
		}

		// Token: 0x0400727B RID: 29307
		[Token(Token = "0x400727B")]
		[FieldOffset(Offset = "0x10")]
		public ShowBoostAvatarParams.CheckBoostStateDelegate CheckBoostState;

		// Token: 0x0200128E RID: 4750
		// (Invoke) Token: 0x0600499D RID: 18845
		[Token(Token = "0x200128E")]
		public delegate BoostState CheckBoostStateDelegate(uint itemID);
	}
}
