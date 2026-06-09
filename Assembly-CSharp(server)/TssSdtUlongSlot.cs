using System;
using Il2CppDummyDll;

// Token: 0x0200021B RID: 539
[Token(Token = "0x200021B")]
public class TssSdtUlongSlot
{
	// Token: 0x06000AB4 RID: 2740 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AB4")]
	[Address(RVA = "0x1C955C4", Offset = "0x1C955C4", VA = "0x7BBC4955C4")]
	public static TssSdtUlongSlot NewSlot(TssSdtUlongSlot slot)
	{
		return null;
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB5")]
	[Address(RVA = "0x1C95BF8", Offset = "0x1C95BF8", VA = "0x7BBC495BF8")]
	private static void CollectSlot(TssSdtUlongSlot slot)
	{
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB6")]
	[Address(RVA = "0x1C95BFC", Offset = "0x1C95BFC", VA = "0x7BBC495BFC")]
	public TssSdtUlongSlot()
	{
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB7")]
	[Address(RVA = "0x1C956F8", Offset = "0x1C956F8", VA = "0x7BBC4956F8")]
	public void SetValue(ulong v)
	{
	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x00004350 File Offset: 0x00002550
	[Token(Token = "0x6000AB8")]
	[Address(RVA = "0x1C95654", Offset = "0x1C95654", VA = "0x7BBC495654")]
	public ulong GetValue()
	{
		return 0UL;
	}

	// Token: 0x04000A10 RID: 2576
	[Token(Token = "0x4000A10")]
	[FieldOffset(Offset = "0x10")]
	private ulong[] m_value;

	// Token: 0x04000A11 RID: 2577
	[Token(Token = "0x4000A11")]
	[FieldOffset(Offset = "0x18")]
	private ulong m_xor_key;

	// Token: 0x04000A12 RID: 2578
	[Token(Token = "0x4000A12")]
	[FieldOffset(Offset = "0x20")]
	private int m_index;
}
