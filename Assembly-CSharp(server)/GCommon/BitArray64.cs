using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F17 RID: 3863
	[Token(Token = "0x2000F17")]
	public class BitArray64
	{
		// Token: 0x060036B1 RID: 14001 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		[Token(Token = "0x60036B1")]
		[Address(RVA = "0x25E5E0C", Offset = "0x25E5E0C", VA = "0x7BBCDE5E0C")]
		public static bool HasFlag(ulong value, ulong flags)
		{
			return default(bool);
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		[Token(Token = "0x60036B2")]
		[Address(RVA = "0x25E5E18", Offset = "0x25E5E18", VA = "0x7BBCDE5E18")]
		public static bool HasFlagByPos(ulong value, uint pos)
		{
			return default(bool);
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x00010D10 File Offset: 0x0000EF10
		[Token(Token = "0x60036B3")]
		[Address(RVA = "0x25E5E44", Offset = "0x25E5E44", VA = "0x7BBCDE5E44")]
		public static ulong AddFlag(ulong value, ulong flags)
		{
			return 0UL;
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x00010D28 File Offset: 0x0000EF28
		[Token(Token = "0x60036B4")]
		[Address(RVA = "0x25E5E4C", Offset = "0x25E5E4C", VA = "0x7BBCDE5E4C")]
		public static ulong AddFlagByPos(ulong value, uint pos)
		{
			return 0UL;
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x00010D40 File Offset: 0x0000EF40
		[Token(Token = "0x60036B5")]
		[Address(RVA = "0x25E5E6C", Offset = "0x25E5E6C", VA = "0x7BBCDE5E6C")]
		public static ulong RemoveFlag(ulong value, ulong flags)
		{
			return 0UL;
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x00010D58 File Offset: 0x0000EF58
		[Token(Token = "0x60036B6")]
		[Address(RVA = "0x25E5E74", Offset = "0x25E5E74", VA = "0x7BBCDE5E74")]
		public static ulong RemoveFlagByPos(ulong value, ulong pos)
		{
			return 0UL;
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B7")]
		[Address(RVA = "0x25E5E94", Offset = "0x25E5E94", VA = "0x7BBCDE5E94")]
		public BitArray64()
		{
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x00010D70 File Offset: 0x0000EF70
		[Token(Token = "0x60036B8")]
		[Address(RVA = "0x25E5EBC", Offset = "0x25E5EBC", VA = "0x7BBCDE5EBC")]
		public bool HasFlag(ulong flags)
		{
			return default(bool);
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x00010D88 File Offset: 0x0000EF88
		[Token(Token = "0x60036B9")]
		[Address(RVA = "0x25E5ECC", Offset = "0x25E5ECC", VA = "0x7BBCDE5ECC")]
		public bool HasFlagByPos(uint pos)
		{
			return default(bool);
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BA")]
		[Address(RVA = "0x25E5EFC", Offset = "0x25E5EFC", VA = "0x7BBCDE5EFC")]
		public void AddFlag(ulong flags)
		{
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BB")]
		[Address(RVA = "0x25E5F0C", Offset = "0x25E5F0C", VA = "0x7BBCDE5F0C")]
		public void AddFlagByPos(uint pos)
		{
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BC")]
		[Address(RVA = "0x25E5F34", Offset = "0x25E5F34", VA = "0x7BBCDE5F34")]
		public void RemoveFlag(ulong flags)
		{
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BD")]
		[Address(RVA = "0x25E5F44", Offset = "0x25E5F44", VA = "0x7BBCDE5F44")]
		public void RemoveFlagByPos(uint pos)
		{
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		[Token(Token = "0x60036BE")]
		[Address(RVA = "0x25E5F6C", Offset = "0x25E5F6C", VA = "0x7BBCDE5F6C")]
		public ulong GetValue()
		{
			return 0UL;
		}

		// Token: 0x040049BD RID: 18877
		[Token(Token = "0x40049BD")]
		public const ulong NONE = 0UL;

		// Token: 0x040049BE RID: 18878
		[Token(Token = "0x40049BE")]
		public const ulong FULL = 4294967295UL;

		// Token: 0x040049BF RID: 18879
		[Token(Token = "0x40049BF")]
		[FieldOffset(Offset = "0x10")]
		protected ulong m_Value;
	}
}
