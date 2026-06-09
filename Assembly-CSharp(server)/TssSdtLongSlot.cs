using System;
using Il2CppDummyDll;

// Token: 0x02000219 RID: 537
[Token(Token = "0x2000219")]
public class TssSdtLongSlot
{
	// Token: 0x06000AA2 RID: 2722 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AA2")]
	[Address(RVA = "0x1C93B7C", Offset = "0x1C93B7C", VA = "0x7BBC493B7C")]
	public static TssSdtLongSlot NewSlot(TssSdtLongSlot slot)
	{
		return null;
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA3")]
	[Address(RVA = "0x1C941B0", Offset = "0x1C941B0", VA = "0x7BBC4941B0")]
	private static void CollectSlot(TssSdtLongSlot slot)
	{
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA4")]
	[Address(RVA = "0x1C941B4", Offset = "0x1C941B4", VA = "0x7BBC4941B4")]
	public TssSdtLongSlot()
	{
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA5")]
	[Address(RVA = "0x1C93CB0", Offset = "0x1C93CB0", VA = "0x7BBC493CB0")]
	public void SetValue(long v)
	{
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x000042A8 File Offset: 0x000024A8
	[Token(Token = "0x6000AA6")]
	[Address(RVA = "0x1C93C0C", Offset = "0x1C93C0C", VA = "0x7BBC493C0C")]
	public long GetValue()
	{
		return 0L;
	}

	// Token: 0x04000A0C RID: 2572
	[Token(Token = "0x4000A0C")]
	[FieldOffset(Offset = "0x10")]
	private long[] m_value;

	// Token: 0x04000A0D RID: 2573
	[Token(Token = "0x4000A0D")]
	[FieldOffset(Offset = "0x18")]
	private long m_xor_key;

	// Token: 0x04000A0E RID: 2574
	[Token(Token = "0x4000A0E")]
	[FieldOffset(Offset = "0x20")]
	private int m_index;
}
