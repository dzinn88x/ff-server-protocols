using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001938 RID: 6456
	[Token(Token = "0x2001938")]
	public class QuickChatShowItem
	{
		// Token: 0x060082D4 RID: 33492 RVA: 0x000238B0 File Offset: 0x00021AB0
		[Token(Token = "0x60082D4")]
		[Address(RVA = "0x174FD38", Offset = "0x174FD38", VA = "0x7BBBF4FD38")]
		public bool IsShow()
		{
			return default(bool);
		}

		// Token: 0x060082D5 RID: 33493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60082D5")]
		[Address(RVA = "0x174FDE8", Offset = "0x174FDE8", VA = "0x7BBBF4FDE8")]
		public QuickChatShowItem()
		{
		}

		// Token: 0x04009400 RID: 37888
		[Token(Token = "0x4009400")]
		[FieldOffset(Offset = "0x10")]
		public float m_ShowTimstamp;

		// Token: 0x04009401 RID: 37889
		[Token(Token = "0x4009401")]
		[FieldOffset(Offset = "0x18")]
		public QuickChatView m_ShowChatView;
	}
}
