using System;
using Il2CppDummyDll;

// Token: 0x0200021D RID: 541
[Token(Token = "0x200021D")]
public class TssSdtShortSlot
{
	// Token: 0x06000AC6 RID: 2758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AC6")]
	[Address(RVA = "0x1C942D8", Offset = "0x1C942D8", VA = "0x7BBC4942D8")]
	public static TssSdtShortSlot NewSlot(TssSdtShortSlot slot)
	{
		return null;
	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC7")]
	[Address(RVA = "0x1C94914", Offset = "0x1C94914", VA = "0x7BBC494914")]
	private static void CollectSlot(TssSdtShortSlot slot)
	{
	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC8")]
	[Address(RVA = "0x1C94918", Offset = "0x1C94918", VA = "0x7BBC494918")]
	public TssSdtShortSlot()
	{
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC9")]
	[Address(RVA = "0x1C9440C", Offset = "0x1C9440C", VA = "0x7BBC49440C")]
	public void SetValue(short v)
	{
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x000043F8 File Offset: 0x000025F8
	[Token(Token = "0x6000ACA")]
	[Address(RVA = "0x1C94368", Offset = "0x1C94368", VA = "0x7BBC494368")]
	public short GetValue()
	{
		return 0;
	}

	// Token: 0x04000A14 RID: 2580
	[Token(Token = "0x4000A14")]
	[FieldOffset(Offset = "0x10")]
	private short[] m_value;

	// Token: 0x04000A15 RID: 2581
	[Token(Token = "0x4000A15")]
	[FieldOffset(Offset = "0x18")]
	private short m_xor_key;

	// Token: 0x04000A16 RID: 2582
	[Token(Token = "0x4000A16")]
	[FieldOffset(Offset = "0x1C")]
	private int m_index;
}
