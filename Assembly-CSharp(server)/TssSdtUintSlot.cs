using System;
using Il2CppDummyDll;

// Token: 0x02000217 RID: 535
[Token(Token = "0x2000217")]
public class TssSdtUintSlot
{
	// Token: 0x06000A90 RID: 2704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A90")]
	[Address(RVA = "0x1C94E64", Offset = "0x1C94E64", VA = "0x7BBC494E64")]
	public static TssSdtUintSlot NewSlot(TssSdtUintSlot slot)
	{
		return null;
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A91")]
	[Address(RVA = "0x1C9549C", Offset = "0x1C9549C", VA = "0x7BBC49549C")]
	private static void CollectSlot(TssSdtUintSlot slot)
	{
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A92")]
	[Address(RVA = "0x1C954A0", Offset = "0x1C954A0", VA = "0x7BBC4954A0")]
	public TssSdtUintSlot()
	{
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A93")]
	[Address(RVA = "0x1C94F98", Offset = "0x1C94F98", VA = "0x7BBC494F98")]
	public void SetValue(uint v)
	{
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x00004200 File Offset: 0x00002400
	[Token(Token = "0x6000A94")]
	[Address(RVA = "0x1C94EF4", Offset = "0x1C94EF4", VA = "0x7BBC494EF4")]
	public uint GetValue()
	{
		return 0U;
	}

	// Token: 0x04000A08 RID: 2568
	[Token(Token = "0x4000A08")]
	[FieldOffset(Offset = "0x10")]
	private uint[] m_value;

	// Token: 0x04000A09 RID: 2569
	[Token(Token = "0x4000A09")]
	[FieldOffset(Offset = "0x18")]
	private uint m_xor_key;

	// Token: 0x04000A0A RID: 2570
	[Token(Token = "0x4000A0A")]
	[FieldOffset(Offset = "0x1C")]
	private int m_index;
}
