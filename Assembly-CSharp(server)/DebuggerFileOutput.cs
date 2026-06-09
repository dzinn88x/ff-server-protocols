using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200015A RID: 346
[Token(Token = "0x200015A")]
public class DebuggerFileOutput : MonoBehaviour
{
	// Token: 0x060006A3 RID: 1699 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x23E52B0", Offset = "0x23E52B0", VA = "0x7BBCBE52B0")]
	private void Start()
	{
	}

	// Token: 0x060006A4 RID: 1700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x23E5418", Offset = "0x23E5418", VA = "0x7BBCBE5418")]
	private void Update()
	{
	}

	// Token: 0x060006A5 RID: 1701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x23E572C", Offset = "0x23E572C", VA = "0x7BBCBE572C")]
	private void OnDestroy()
	{
	}

	// Token: 0x060006A6 RID: 1702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x23E5154", Offset = "0x23E5154", VA = "0x7BBCBE5154")]
	public void Log(string msg)
	{
	}

	// Token: 0x060006A7 RID: 1703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x23E5428", Offset = "0x23E5428", VA = "0x7BBCBE5428")]
	public void Flush()
	{
	}

	// Token: 0x060006A8 RID: 1704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x23E44F8", Offset = "0x23E44F8", VA = "0x7BBCBE44F8")]
	public void FlushToFile()
	{
	}

	// Token: 0x060006A9 RID: 1705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x23E4680", Offset = "0x23E4680", VA = "0x7BBCBE4680")]
	public void Close()
	{
	}

	// Token: 0x060006AA RID: 1706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x23E5774", Offset = "0x23E5774", VA = "0x7BBCBE5774")]
	public DebuggerFileOutput()
	{
	}

	// Token: 0x04000607 RID: 1543
	[Token(Token = "0x4000607")]
	[FieldOffset(Offset = "0x0")]
	public static DebuggerFileOutput instance;

	// Token: 0x04000608 RID: 1544
	[Token(Token = "0x4000608")]
	[FieldOffset(Offset = "0x18")]
	private List<string> m_OutputText;

	// Token: 0x04000609 RID: 1545
	[Token(Token = "0x4000609")]
	[FieldOffset(Offset = "0x20")]
	private string m_OutputFilePath;

	// Token: 0x0400060A RID: 1546
	[Token(Token = "0x400060A")]
	[FieldOffset(Offset = "0x28")]
	private StreamWriter m_Writer;
}
