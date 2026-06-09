using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000169 RID: 361
[Token(Token = "0x2000169")]
public class IllegalWordDetection
{
	// Token: 0x06000702 RID: 1794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000702")]
	[Address(RVA = "0x24CBD20", Offset = "0x24CBD20", VA = "0x7BBCCCBD20")]
	public static void Init(string[] badwords)
	{
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000703")]
	[Address(RVA = "0x24CC2B0", Offset = "0x24CC2B0", VA = "0x7BBCCCC2B0")]
	private static string OriginalToLower(string text)
	{
		return null;
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x000033A8 File Offset: 0x000015A8
	[Token(Token = "0x6000704")]
	[Address(RVA = "0x24CC324", Offset = "0x24CC324", VA = "0x7BBCCCC324")]
	private static bool EnsuranceLower(string text)
	{
		return default(bool);
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000705")]
	[Address(RVA = "0x24CC398", Offset = "0x24CC398", VA = "0x7BBCCCC398")]
	public static string Filter(string text, string mask = "*")
	{
		return null;
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x000033C0 File Offset: 0x000015C0
	[Token(Token = "0x6000706")]
	[Address(RVA = "0x24CCC9C", Offset = "0x24CCC9C", VA = "0x7BBCCCCC9C")]
	public static bool ContainsIllegalWords(string text)
	{
		return default(bool);
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000707")]
	[Address(RVA = "0x24CC588", Offset = "0x24CC588", VA = "0x7BBCCCC588")]
	public static Dictionary<int, int> DetectIllegalWords(string text)
	{
		return null;
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x000033D8 File Offset: 0x000015D8
	[Token(Token = "0x6000708")]
	[Address(RVA = "0x24CCD2C", Offset = "0x24CCD2C", VA = "0x7BBCCCCD2C")]
	public static bool ContainsSpecialCharacters(string text)
	{
		return default(bool);
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000709")]
	[Address(RVA = "0x24CCE68", Offset = "0x24CCE68", VA = "0x7BBCCCCE68")]
	public IllegalWordDetection()
	{
	}

	// Token: 0x04000679 RID: 1657
	[Token(Token = "0x4000679")]
	[FieldOffset(Offset = "0x0")]
	private static HashSet<string> wordsSet;

	// Token: 0x0400067A RID: 1658
	[Token(Token = "0x400067A")]
	[FieldOffset(Offset = "0x8")]
	private static byte[] fastCheck;

	// Token: 0x0400067B RID: 1659
	[Token(Token = "0x400067B")]
	[FieldOffset(Offset = "0x10")]
	private static byte[] fastLength;

	// Token: 0x0400067C RID: 1660
	[Token(Token = "0x400067C")]
	[FieldOffset(Offset = "0x18")]
	private static byte[] startCache;

	// Token: 0x0400067D RID: 1661
	[Token(Token = "0x400067D")]
	[FieldOffset(Offset = "0x20")]
	private static char[] dectectedBuffer;

	// Token: 0x0400067E RID: 1662
	[Token(Token = "0x400067E")]
	[FieldOffset(Offset = "0x28")]
	private static string SkipList;

	// Token: 0x0400067F RID: 1663
	[Token(Token = "0x400067F")]
	[FieldOffset(Offset = "0x30")]
	private static string SkipList_2;

	// Token: 0x04000680 RID: 1664
	[Token(Token = "0x4000680")]
	[FieldOffset(Offset = "0x38")]
	private static BitArray SkipBitArray;

	// Token: 0x04000681 RID: 1665
	[Token(Token = "0x4000681")]
	[FieldOffset(Offset = "0x40")]
	private static readonly char[] SpecialChars;

	// Token: 0x04000682 RID: 1666
	[Token(Token = "0x4000682")]
	[FieldOffset(Offset = "0x48")]
	private static readonly char[] SpecialChars_2;

	// Token: 0x04000683 RID: 1667
	[Token(Token = "0x4000683")]
	[FieldOffset(Offset = "0x50")]
	private static BitArray endCache;
}
