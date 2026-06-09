using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using message;

// Token: 0x0200004A RID: 74
[Token(Token = "0x200004A")]
internal class WereWolvesBodyManager
{
	// Token: 0x060000DB RID: 219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x218E438", Offset = "0x218E438", VA = "0x7BBC98E438")]
	public void CreateBody(tDr[}N} bodyInfo)
	{
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x218E744", Offset = "0x218E744", VA = "0x7BBC98E744")]
	public void DelBody(int bodyID)
	{
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x218E808", Offset = "0x218E808", VA = "0x7BBC98E808")]
	public WereWolvesBodyManager()
	{
	}

	// Token: 0x04000101 RID: 257
	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, LevelWereWolvesBody> m_BodysMap;
}
