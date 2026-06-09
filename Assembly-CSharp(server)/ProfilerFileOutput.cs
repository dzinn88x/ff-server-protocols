using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200015B RID: 347
[Token(Token = "0x200015B")]
public class ProfilerFileOutput : MonoBehaviour
{
	// Token: 0x060006AC RID: 1708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x23CBC90", Offset = "0x23CBC90", VA = "0x7BBCBCBC90")]
	private void Start()
	{
	}

	// Token: 0x060006AD RID: 1709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x23CBD88", Offset = "0x23CBD88", VA = "0x7BBCBCBD88")]
	private void Update()
	{
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x23CC020", Offset = "0x23CC020", VA = "0x7BBCBCC020")]
	private void OnDestroy()
	{
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x23CC09C", Offset = "0x23CC09C", VA = "0x7BBCBCC09C")]
	public void Log(string msg)
	{
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x23CBD98", Offset = "0x23CBD98", VA = "0x7BBCBCBD98")]
	public void Flush()
	{
	}

	// Token: 0x060006B1 RID: 1713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x23CC184", Offset = "0x23CC184", VA = "0x7BBCBCC184")]
	public void FlushToFile()
	{
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x23CC068", Offset = "0x23CC068", VA = "0x7BBCBCC068")]
	public void Close()
	{
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x23CC1C0", Offset = "0x23CC1C0", VA = "0x7BBCBCC1C0")]
	public ProfilerFileOutput()
	{
	}

	// Token: 0x0400060B RID: 1547
	[Token(Token = "0x400060B")]
	[FieldOffset(Offset = "0x0")]
	public static ProfilerFileOutput instance;

	// Token: 0x0400060C RID: 1548
	[Token(Token = "0x400060C")]
	[FieldOffset(Offset = "0x18")]
	private List<string> m_OutputText;

	// Token: 0x0400060D RID: 1549
	[Token(Token = "0x400060D")]
	[FieldOffset(Offset = "0x20")]
	private string m_OutputFilePath;

	// Token: 0x0400060E RID: 1550
	[Token(Token = "0x400060E")]
	[FieldOffset(Offset = "0x28")]
	private StreamWriter m_Writer;
}
