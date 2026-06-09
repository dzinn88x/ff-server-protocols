using System;
using Il2CppDummyDll;

// Token: 0x02000221 RID: 545
[Token(Token = "0x2000221")]
public class TssSdtByteSlot
{
	// Token: 0x06000AEA RID: 2794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AEA")]
	[Address(RVA = "0x226DB2C", Offset = "0x226DB2C", VA = "0x7BBCA6DB2C")]
	public static TssSdtByteSlot NewSlot(TssSdtByteSlot slot)
	{
		return null;
	}

	// Token: 0x06000AEB RID: 2795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEB")]
	[Address(RVA = "0x226E164", Offset = "0x226E164", VA = "0x7BBCA6E164")]
	private static void CollectSlot(TssSdtByteSlot slot)
	{
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AEC")]
	[Address(RVA = "0x226E168", Offset = "0x226E168", VA = "0x7BBCA6E168")]
	public TssSdtByteSlot()
	{
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AED")]
	[Address(RVA = "0x226DC60", Offset = "0x226DC60", VA = "0x7BBCA6DC60")]
	public void SetValue(byte v)
	{
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x00004548 File Offset: 0x00002748
	[Token(Token = "0x6000AEE")]
	[Address(RVA = "0x226DBBC", Offset = "0x226DBBC", VA = "0x7BBCA6DBBC")]
	public byte GetValue()
	{
		return 0;
	}

	// Token: 0x04000A1C RID: 2588
	[Token(Token = "0x4000A1C")]
	[FieldOffset(Offset = "0x10")]
	private byte[] m_value;

	// Token: 0x04000A1D RID: 2589
	[Token(Token = "0x4000A1D")]
	[FieldOffset(Offset = "0x18")]
	private byte m_xor_key;

	// Token: 0x04000A1E RID: 2590
	[Token(Token = "0x4000A1E")]
	[FieldOffset(Offset = "0x1C")]
	private int m_index;
}
