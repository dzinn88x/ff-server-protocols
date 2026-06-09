using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F18 RID: 3864
	[Token(Token = "0x2000F18")]
	public class BitArrayBoolean : BitArray
	{
		// Token: 0x060036BF RID: 14015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036BF")]
		[Address(RVA = "0x25E5F74", Offset = "0x25E5F74", VA = "0x7BBCDE5F74")]
		public BitArrayBoolean(bool v, BitArrayBoolean.EBitArrayBooleanMode mode = BitArrayBoolean.EBitArrayBooleanMode.OR_TRUE)
		{
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C0")]
		[Address(RVA = "0x25E5FCC", Offset = "0x25E5FCC", VA = "0x7BBCDE5FCC")]
		public void SetBooleanValue(bool v)
		{
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C1")]
		[Address(RVA = "0x25E5FF0", Offset = "0x25E5FF0", VA = "0x7BBCDE5FF0")]
		public void SetBooleanValue(uint flag, bool v)
		{
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x00010DB8 File Offset: 0x0000EFB8
		[Token(Token = "0x60036C2")]
		[Address(RVA = "0x25E600C", Offset = "0x25E600C", VA = "0x7BBCDE600C")]
		public bool GetBooleanValue()
		{
			return default(bool);
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		[Token(Token = "0x60036C3")]
		[Address(RVA = "0x25E602C", Offset = "0x25E602C", VA = "0x7BBCDE602C")]
		public static implicit operator bool(BitArrayBoolean ba)
		{
			return default(bool);
		}

		// Token: 0x040049C0 RID: 18880
		[Token(Token = "0x40049C0")]
		[FieldOffset(Offset = "0x14")]
		protected BitArrayBoolean.EBitArrayBooleanMode m_Mode;

		// Token: 0x02000F19 RID: 3865
		[Token(Token = "0x2000F19")]
		public enum EBitArrayBooleanMode
		{
			// Token: 0x040049C2 RID: 18882
			[Token(Token = "0x40049C2")]
			AND_TURE,
			// Token: 0x040049C3 RID: 18883
			[Token(Token = "0x40049C3")]
			OR_TRUE
		}
	}
}
