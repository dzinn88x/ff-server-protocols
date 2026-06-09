using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F09 RID: 3849
	[Token(Token = "0x2000F09")]
	public static class LocLangConvert
	{
		// Token: 0x0600362B RID: 13867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362B")]
		[Address(RVA = "0x2116098", Offset = "0x2116098", VA = "0x7BBC916098")]
		public static string GetAbbr(LocLang lang)
		{
			return null;
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x000107A0 File Offset: 0x0000E9A0
		[Token(Token = "0x600362C")]
		[Address(RVA = "0x2122158", Offset = "0x2122158", VA = "0x7BBC922158")]
		public static LocLang GetLocLang(string abbr)
		{
			return LocLang.None;
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x000107B8 File Offset: 0x0000E9B8
		[Token(Token = "0x600362D")]
		[Address(RVA = "0x2122590", Offset = "0x2122590", VA = "0x7BBC922590")]
		public static LocLang GetLocLang(SystemLanguage systemLan)
		{
			return LocLang.None;
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x000107D0 File Offset: 0x0000E9D0
		[Token(Token = "0x600362E")]
		[Address(RVA = "0x2122740", Offset = "0x2122740", VA = "0x7BBC922740")]
		private static LocLang GetAdvanceLang()
		{
			return LocLang.None;
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362F")]
		[Address(RVA = "0x2122B14", Offset = "0x2122B14", VA = "0x7BBC922B14")]
		public static string GetLocLangName(LocLang loc)
		{
			return null;
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003630")]
		[Address(RVA = "0x2123254", Offset = "0x2123254", VA = "0x7BBC923254")]
		public static string GetLocLangName(ESocial.Language loc)
		{
			return null;
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003631")]
		[Address(RVA = "0x2123988", Offset = "0x2123988", VA = "0x7BBC923988")]
		public static string GetLocLangNamePic(LocLang loc)
		{
			return null;
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003632")]
		[Address(RVA = "0x2123A08", Offset = "0x2123A08", VA = "0x7BBC923A08")]
		public static string GetLocLangNamePic(ESocial.Language loc)
		{
			return null;
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003633")]
		[Address(RVA = "0x2123A88", Offset = "0x2123A88", VA = "0x7BBC923A88")]
		public static List<LocLang> GetLanguageList()
		{
			return null;
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003634")]
		[Address(RVA = "0x2123D9C", Offset = "0x2123D9C", VA = "0x7BBC923D9C")]
		public static List<ESocial.Language> GetServerLanguageList()
		{
			return null;
		}

		// Token: 0x0400497E RID: 18814
		[Token(Token = "0x400497E")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, LocLang> langsDic;
	}
}
