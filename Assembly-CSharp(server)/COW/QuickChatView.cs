using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C26 RID: 7206
	[Token(Token = "0x2001C26")]
	public class QuickChatView : MonoBehaviour
	{
		// Token: 0x06009CD3 RID: 40147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CD3")]
		[Address(RVA = "0x174FDF0", Offset = "0x174FDF0", VA = "0x7BBBF4FDF0")]
		public void SetUIData(int index, string message)
		{
		}

		// Token: 0x06009CD4 RID: 40148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009CD4")]
		[Address(RVA = "0x174FE78", Offset = "0x174FE78", VA = "0x7BBBF4FE78")]
		public QuickChatView()
		{
		}

		// Token: 0x0400A2D6 RID: 41686
		[Token(Token = "0x400A2D6")]
		[FieldOffset(Offset = "0x18")]
		public UILabel m_IndexInTeam;

		// Token: 0x0400A2D7 RID: 41687
		[Token(Token = "0x400A2D7")]
		[FieldOffset(Offset = "0x20")]
		public UILabel m_Message;
	}
}
