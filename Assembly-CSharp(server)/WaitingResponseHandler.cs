using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200014E RID: 334
[Token(Token = "0x200014E")]
public class WaitingResponseHandler
{
	// Token: 0x0600065C RID: 1628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065C")]
	[Address(RVA = "0x218D458", Offset = "0x218D458", VA = "0x7BBC98D458")]
	public void Init()
	{
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065D")]
	[Address(RVA = "0x218D45C", Offset = "0x218D45C", VA = "0x7BBC98D45C")]
	public void Clear()
	{
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065E")]
	[Address(RVA = "0x218D4BC", Offset = "0x218D4BC", VA = "0x7BBC98D4BC")]
	public void Wait(string id)
	{
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065F")]
	[Address(RVA = "0x218D5B4", Offset = "0x218D5B4", VA = "0x7BBC98D5B4")]
	public void CancelWait(string id)
	{
	}

	// Token: 0x06000660 RID: 1632 RVA: 0x00003270 File Offset: 0x00001470
	[Token(Token = "0x6000660")]
	[Address(RVA = "0x218D660", Offset = "0x218D660", VA = "0x7BBC98D660")]
	public bool IsPending(string id)
	{
		return default(bool);
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000661")]
	[Address(RVA = "0x218D6D0", Offset = "0x218D6D0", VA = "0x7BBC98D6D0")]
	public WaitingResponseHandler()
	{
	}

	// Token: 0x040005B0 RID: 1456
	[Token(Token = "0x40005B0")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, bool> m_WaitingDict;
}
