using System;
using Il2CppDummyDll;

// Token: 0x02000225 RID: 549
[Token(Token = "0x2000225")]
public class TssSdtDoubleSlot
{
	// Token: 0x06000B0E RID: 2830 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B0E")]
	[Address(RVA = "0x1C929E4", Offset = "0x1C929E4", VA = "0x7BBC4929E4")]
	public static TssSdtDoubleSlot NewSlot(TssSdtDoubleSlot slot)
	{
		return null;
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0F")]
	[Address(RVA = "0x1C92A3C", Offset = "0x1C92A3C", VA = "0x7BBC492A3C")]
	private static void CollectSlot(TssSdtDoubleSlot slot)
	{
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B10")]
	[Address(RVA = "0x1C92A40", Offset = "0x1C92A40", VA = "0x7BBC492A40")]
	public TssSdtDoubleSlot()
	{
	}

	// Token: 0x06000B11 RID: 2833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B11")]
	[Address(RVA = "0x1C92AE4", Offset = "0x1C92AE4", VA = "0x7BBC492AE4")]
	public void SetValue(double v)
	{
	}

	// Token: 0x06000B12 RID: 2834 RVA: 0x00004698 File Offset: 0x00002898
	[Token(Token = "0x6000B12")]
	[Address(RVA = "0x1C92BA0", Offset = "0x1C92BA0", VA = "0x7BBC492BA0")]
	public double GetValue()
	{
		return 0.0;
	}

	// Token: 0x04000A24 RID: 2596
	[Token(Token = "0x4000A24")]
	[FieldOffset(Offset = "0x10")]
	private ulong[] m_value;

	// Token: 0x04000A25 RID: 2597
	[Token(Token = "0x4000A25")]
	[FieldOffset(Offset = "0x18")]
	private byte m_xor_key;

	// Token: 0x04000A26 RID: 2598
	[Token(Token = "0x4000A26")]
	[FieldOffset(Offset = "0x1C")]
	private int m_index;
}
