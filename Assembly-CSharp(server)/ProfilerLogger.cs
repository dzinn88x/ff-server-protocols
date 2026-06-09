using System;
using Il2CppDummyDll;

// Token: 0x0200015C RID: 348
[Token(Token = "0x200015C")]
public class ProfilerLogger
{
	// Token: 0x060006B5 RID: 1717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B5")]
	[Address(RVA = "0x23CC234", Offset = "0x23CC234", VA = "0x7BBCBCC234")]
	public static void Flush()
	{
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B6")]
	[Address(RVA = "0x23CC358", Offset = "0x23CC358", VA = "0x7BBCBCC358")]
	public static void OnApplicationQuit()
	{
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B7")]
	[Address(RVA = "0x23CC4A4", Offset = "0x23CC4A4", VA = "0x7BBCBCC4A4")]
	public static void Update()
	{
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B8")]
	[Address(RVA = "0x23CC750", Offset = "0x23CC750", VA = "0x7BBCBCC750")]
	public static void Log(object message)
	{
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B9")]
	[Address(RVA = "0x23CCA54", Offset = "0x23CCA54", VA = "0x7BBCBCCA54")]
	public static void StartLoading()
	{
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BA")]
	[Address(RVA = "0x23CCAD0", Offset = "0x23CCAD0", VA = "0x7BBCBCCAD0")]
	public static void EndLoading()
	{
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x23CC7F4", Offset = "0x23CC7F4", VA = "0x7BBCBCC7F4")]
	private static string ProfileFormatMessage(object message)
	{
		return null;
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x23CC930", Offset = "0x23CC930", VA = "0x7BBCBCC930")]
	public static void WriteToProfileFile(string message)
	{
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x23CCC1C", Offset = "0x23CCC1C", VA = "0x7BBCBCCC1C")]
	public ProfilerLogger()
	{
	}

	// Token: 0x0400060F RID: 1551
	[Token(Token = "0x400060F")]
	[FieldOffset(Offset = "0x0")]
	private static float m_StartTime;

	// Token: 0x04000610 RID: 1552
	[Token(Token = "0x4000610")]
	[FieldOffset(Offset = "0x4")]
	private static int m_FrameCount;

	// Token: 0x04000611 RID: 1553
	[Token(Token = "0x4000611")]
	[FieldOffset(Offset = "0x8")]
	private static float m_LastSecondTime;

	// Token: 0x04000612 RID: 1554
	[Token(Token = "0x4000612")]
	[FieldOffset(Offset = "0xC")]
	private static float m_LastFrameTime;
}
