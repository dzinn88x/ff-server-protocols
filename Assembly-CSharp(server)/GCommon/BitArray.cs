using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F16 RID: 3862
	[Token(Token = "0x2000F16")]
	public class BitArray
	{
		// Token: 0x060036A3 RID: 13987 RVA: 0x00010C08 File Offset: 0x0000EE08
		[Token(Token = "0x60036A3")]
		[Address(RVA = "0x25E5CBC", Offset = "0x25E5CBC", VA = "0x7BBCDE5CBC")]
		public static bool HasFlag(uint value, uint flags)
		{
			return default(bool);
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x00010C20 File Offset: 0x0000EE20
		[Token(Token = "0x60036A4")]
		[Address(RVA = "0x25E5CC8", Offset = "0x25E5CC8", VA = "0x7BBCDE5CC8")]
		public static bool HasFlagByPos(uint value, uint pos)
		{
			return default(bool);
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x00010C38 File Offset: 0x0000EE38
		[Token(Token = "0x60036A5")]
		[Address(RVA = "0x25E5CF0", Offset = "0x25E5CF0", VA = "0x7BBCDE5CF0")]
		public static uint AddFlag(uint value, uint flags)
		{
			return 0U;
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x00010C50 File Offset: 0x0000EE50
		[Token(Token = "0x60036A6")]
		[Address(RVA = "0x25E5CF8", Offset = "0x25E5CF8", VA = "0x7BBCDE5CF8")]
		public static uint AddFlagByPos(uint value, uint pos)
		{
			return 0U;
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x00010C68 File Offset: 0x0000EE68
		[Token(Token = "0x60036A7")]
		[Address(RVA = "0x25E5D14", Offset = "0x25E5D14", VA = "0x7BBCDE5D14")]
		public static uint RemoveFlag(uint value, uint flags)
		{
			return 0U;
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x00010C80 File Offset: 0x0000EE80
		[Token(Token = "0x60036A8")]
		[Address(RVA = "0x25E5D1C", Offset = "0x25E5D1C", VA = "0x7BBCDE5D1C")]
		public static uint RemoveFlagByPos(uint value, uint pos)
		{
			return 0U;
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036A9")]
		[Address(RVA = "0x25E5D38", Offset = "0x25E5D38", VA = "0x7BBCDE5D38")]
		public BitArray()
		{
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x00010C98 File Offset: 0x0000EE98
		[Token(Token = "0x60036AA")]
		[Address(RVA = "0x25E5D60", Offset = "0x25E5D60", VA = "0x7BBCDE5D60")]
		public bool HasFlag(uint flags)
		{
			return default(bool);
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x00010CB0 File Offset: 0x0000EEB0
		[Token(Token = "0x60036AB")]
		[Address(RVA = "0x25E5D70", Offset = "0x25E5D70", VA = "0x7BBCDE5D70")]
		public bool HasFlagByPos(uint pos)
		{
			return default(bool);
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AC")]
		[Address(RVA = "0x25E5D9C", Offset = "0x25E5D9C", VA = "0x7BBCDE5D9C")]
		public void AddFlag(uint flags)
		{
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AD")]
		[Address(RVA = "0x25E5DAC", Offset = "0x25E5DAC", VA = "0x7BBCDE5DAC")]
		public void AddFlagByPos(uint pos)
		{
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AE")]
		[Address(RVA = "0x25E5DD0", Offset = "0x25E5DD0", VA = "0x7BBCDE5DD0")]
		public void RemoveFlag(uint flags)
		{
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AF")]
		[Address(RVA = "0x25E5DE0", Offset = "0x25E5DE0", VA = "0x7BBCDE5DE0")]
		public void RemoveFlagByPos(uint pos)
		{
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		[Token(Token = "0x60036B0")]
		[Address(RVA = "0x25E5E04", Offset = "0x25E5E04", VA = "0x7BBCDE5E04")]
		public uint GetValue()
		{
			return 0U;
		}

		// Token: 0x040049BA RID: 18874
		[Token(Token = "0x40049BA")]
		public const uint NONE = 0U;

		// Token: 0x040049BB RID: 18875
		[Token(Token = "0x40049BB")]
		public const uint FULL = 4294967295U;

		// Token: 0x040049BC RID: 18876
		[Token(Token = "0x40049BC")]
		[FieldOffset(Offset = "0x10")]
		protected uint m_Value;
	}
}
