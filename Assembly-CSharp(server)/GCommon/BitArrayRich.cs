using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F1A RID: 3866
	[Token(Token = "0x2000F1A")]
	public class BitArrayRich
	{
		// Token: 0x060036C4 RID: 14020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C4")]
		[Address(RVA = "0x25E606C", Offset = "0x25E606C", VA = "0x7BBCDE606C")]
		public BitArrayRich(uint length)
		{
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C5")]
		[Address(RVA = "0x25E60F8", Offset = "0x25E60F8", VA = "0x7BBCDE60F8")]
		public BitArrayRich(byte[] data)
		{
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		[Token(Token = "0x60036C6")]
		[Address(RVA = "0x25E6128", Offset = "0x25E6128", VA = "0x7BBCDE6128")]
		public bool HasFlagByPos(uint pos)
		{
			return default(bool);
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C7")]
		[Address(RVA = "0x25E6200", Offset = "0x25E6200", VA = "0x7BBCDE6200")]
		public void AddFlagByPos(uint pos)
		{
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036C8")]
		[Address(RVA = "0x25E6314", Offset = "0x25E6314", VA = "0x7BBCDE6314")]
		public void RemoveFlagByPos(uint pos)
		{
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x00010E00 File Offset: 0x0000F000
		[Token(Token = "0x60036C9")]
		[Address(RVA = "0x25E63F8", Offset = "0x25E63F8", VA = "0x7BBCDE63F8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x00010E18 File Offset: 0x0000F018
		[Token(Token = "0x60036CA")]
		[Address(RVA = "0x25E64BC", Offset = "0x25E64BC", VA = "0x7BBCDE64BC", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x00010E30 File Offset: 0x0000F030
		[Token(Token = "0x60036CB")]
		[Address(RVA = "0x25E61C8", Offset = "0x25E61C8", VA = "0x7BBCDE61C8")]
		private int GetValueIndexByPos(uint pos)
		{
			return 0;
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036CC")]
		[Address(RVA = "0x25E64F0", Offset = "0x25E64F0", VA = "0x7BBCDE64F0")]
		public byte[] GetValue()
		{
			return null;
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x00010E48 File Offset: 0x0000F048
		[Token(Token = "0x60036CD")]
		[Address(RVA = "0x25E6588", Offset = "0x25E6588", VA = "0x7BBCDE6588")]
		public int GetValueLength()
		{
			return 0;
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CE")]
		[Address(RVA = "0x25E65B4", Offset = "0x25E65B4", VA = "0x7BBCDE65B4")]
		public void SetValue(byte[] value)
		{
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CF")]
		[Address(RVA = "0x25E6700", Offset = "0x25E6700", VA = "0x7BBCDE6700")]
		public void SetFull()
		{
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x00010E60 File Offset: 0x0000F060
		[Token(Token = "0x60036D0")]
		[Address(RVA = "0x25E6804", Offset = "0x25E6804", VA = "0x7BBCDE6804")]
		public static byte BitCount(byte n)
		{
			return 0;
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x00010E78 File Offset: 0x0000F078
		[Token(Token = "0x60036D1")]
		[Address(RVA = "0x25E6830", Offset = "0x25E6830", VA = "0x7BBCDE6830")]
		public uint GetFlagCount()
		{
			return 0U;
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D2")]
		[Address(RVA = "0x25E6634", Offset = "0x25E6634", VA = "0x7BBCDE6634")]
		private void UpdateFlagCount()
		{
		}

		// Token: 0x040049C4 RID: 18884
		[Token(Token = "0x40049C4")]
		[FieldOffset(Offset = "0x10")]
		private byte[] data_array;

		// Token: 0x040049C5 RID: 18885
		[Token(Token = "0x40049C5")]
		[FieldOffset(Offset = "0x18")]
		private uint m_FlagCount;
	}
}
