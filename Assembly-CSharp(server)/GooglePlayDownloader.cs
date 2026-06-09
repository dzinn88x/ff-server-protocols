using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000168 RID: 360
[Token(Token = "0x2000168")]
public class GooglePlayDownloader
{
	// Token: 0x060006F9 RID: 1785 RVA: 0x00003378 File Offset: 0x00001578
	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x274AB58", Offset = "0x274AB58", VA = "0x7BBCF4AB58")]
	public static bool RunningOnAndroid()
	{
		return default(bool);
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x274AE58", Offset = "0x274AE58", VA = "0x7BBCF4AE58")]
	public static string GetExpansionFilePath()
	{
		return null;
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x274B484", Offset = "0x274B484", VA = "0x7BBCF4B484")]
	public static string GetMainOBBPath(string expansionFilePath)
	{
		return null;
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FD")]
	[Address(RVA = "0x274B5DC", Offset = "0x274B5DC", VA = "0x7BBCF4B5DC")]
	public static string GetPatchOBBPath(string expansionFilePath)
	{
		return null;
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060006FE RID: 1790 RVA: 0x00003390 File Offset: 0x00001590
	[Token(Token = "0x1700005D")]
	private static int ObbVersion
	{
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x274B574", Offset = "0x274B574", VA = "0x7BBCF4B574")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x274B6CC", Offset = "0x274B6CC", VA = "0x7BBCF4B6CC")]
	public static void FetchOBB()
	{
	}

	// Token: 0x06000700 RID: 1792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000700")]
	[Address(RVA = "0x274B0E8", Offset = "0x274B0E8", VA = "0x7BBCF4B0E8")]
	private static void populateOBBData()
	{
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000701")]
	[Address(RVA = "0x274BC78", Offset = "0x274BC78", VA = "0x7BBCF4BC78")]
	public GooglePlayDownloader()
	{
	}

	// Token: 0x04000673 RID: 1651
	[Token(Token = "0x4000673")]
	[FieldOffset(Offset = "0x0")]
	public static int OriginalVersionCode;

	// Token: 0x04000674 RID: 1652
	[Token(Token = "0x4000674")]
	[FieldOffset(Offset = "0x8")]
	private static AndroidJavaClass detectAndroidJNI;

	// Token: 0x04000675 RID: 1653
	[Token(Token = "0x4000675")]
	[FieldOffset(Offset = "0x10")]
	private static AndroidJavaClass Environment;

	// Token: 0x04000676 RID: 1654
	[Token(Token = "0x4000676")]
	private const string Environment_MEDIA_MOUNTED = "mounted";

	// Token: 0x04000677 RID: 1655
	[Token(Token = "0x4000677")]
	[FieldOffset(Offset = "0x18")]
	private static string obb_package;

	// Token: 0x04000678 RID: 1656
	[Token(Token = "0x4000678")]
	[FieldOffset(Offset = "0x20")]
	private static int obb_version;
}
