using System;
using Il2CppDummyDll;

// Token: 0x0200021F RID: 543
[Token(Token = "0x200021F")]
public class TssSdtUshortSlot
{
	// Token: 0x06000AD8 RID: 2776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AD8")]
	[Address(RVA = "0x1C95D20", Offset = "0x1C95D20", VA = "0x7BBC495D20")]
	public static TssSdtUshortSlot NewSlot(TssSdtUshortSlot slot)
	{
		return null;
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AD9")]
	[Address(RVA = "0x1C9635C", Offset = "0x1C9635C", VA = "0x7BBC49635C")]
	private static void CollectSlot(TssSdtUshortSlot slot)
	{
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ADA")]
	[Address(RVA = "0x1C96360", Offset = "0x1C96360", VA = "0x7BBC496360")]
	public TssSdtUshortSlot()
	{
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ADB")]
	[Address(RVA = "0x1C95E54", Offset = "0x1C95E54", VA = "0x7BBC495E54")]
	public void SetValue(ushort v)
	{
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x000044A0 File Offset: 0x000026A0
	[Token(Token = "0x6000ADC")]
	[Address(RVA = "0x1C95DB0", Offset = "0x1C95DB0", VA = "0x7BBC495DB0")]
	public ushort GetValue()
	{
		return 0;
	}

	// Token: 0x04000A18 RID: 2584
	[Token(Token = "0x4000A18")]
	[FieldOffset(Offset = "0x10")]
	private ushort[] m_value;

	// Token: 0x04000A19 RID: 2585
	[Token(Token = "0x4000A19")]
	[FieldOffset(Offset = "0x18")]
	private ushort m_xor_key;

	// Token: 0x04000A1A RID: 2586
	[Token(Token = "0x4000A1A")]
	[FieldOffset(Offset = "0x1C")]
	private int m_index;
}
