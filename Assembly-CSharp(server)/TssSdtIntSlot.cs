using System;
using Il2CppDummyDll;

// Token: 0x02000215 RID: 533
[Token(Token = "0x2000215")]
public class TssSdtIntSlot
{
	// Token: 0x06000A7E RID: 2686 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A7E")]
	[Address(RVA = "0x1C9341C", Offset = "0x1C9341C", VA = "0x7BBC49341C")]
	public static TssSdtIntSlot NewSlot(TssSdtIntSlot slot)
	{
		return null;
	}

	// Token: 0x06000A7F RID: 2687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A7F")]
	[Address(RVA = "0x1C93A54", Offset = "0x1C93A54", VA = "0x7BBC493A54")]
	private static void CollectSlot(TssSdtIntSlot slot)
	{
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A80")]
	[Address(RVA = "0x1C93A58", Offset = "0x1C93A58", VA = "0x7BBC493A58")]
	public TssSdtIntSlot()
	{
	}

	// Token: 0x06000A81 RID: 2689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A81")]
	[Address(RVA = "0x1C93550", Offset = "0x1C93550", VA = "0x7BBC493550")]
	public void SetValue(int v)
	{
	}

	// Token: 0x06000A82 RID: 2690 RVA: 0x00004158 File Offset: 0x00002358
	[Token(Token = "0x6000A82")]
	[Address(RVA = "0x1C934AC", Offset = "0x1C934AC", VA = "0x7BBC4934AC")]
	public int GetValue()
	{
		return 0;
	}

	// Token: 0x04000A04 RID: 2564
	[Token(Token = "0x4000A04")]
	[FieldOffset(Offset = "0x10")]
	private int[] m_value;

	// Token: 0x04000A05 RID: 2565
	[Token(Token = "0x4000A05")]
	[FieldOffset(Offset = "0x18")]
	private int m_xor_key;

	// Token: 0x04000A06 RID: 2566
	[Token(Token = "0x4000A06")]
	[FieldOffset(Offset = "0x1C")]
	private int m_index;
}
