using System;
using Il2CppDummyDll;

// Token: 0x02000223 RID: 547
[Token(Token = "0x2000223")]
public class TssSdtFloatSlot
{
	// Token: 0x06000AFC RID: 2812 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0x1C92C84", Offset = "0x1C92C84", VA = "0x7BBC492C84")]
	public static TssSdtFloatSlot NewSlot(TssSdtFloatSlot slot)
	{
		return null;
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x1C932F4", Offset = "0x1C932F4", VA = "0x7BBC4932F4")]
	private static void CollectSlot(TssSdtFloatSlot slot)
	{
	}

	// Token: 0x06000AFE RID: 2814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x1C932F8", Offset = "0x1C932F8", VA = "0x7BBC4932F8")]
	public TssSdtFloatSlot()
	{
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x1C92DC0", Offset = "0x1C92DC0", VA = "0x7BBC492DC0")]
	public void SetValue(float v)
	{
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x000045F0 File Offset: 0x000027F0
	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x1C92D14", Offset = "0x1C92D14", VA = "0x7BBC492D14")]
	public float GetValue()
	{
		return 0f;
	}

	// Token: 0x04000A20 RID: 2592
	[Token(Token = "0x4000A20")]
	[FieldOffset(Offset = "0x10")]
	private uint[] m_value;

	// Token: 0x04000A21 RID: 2593
	[Token(Token = "0x4000A21")]
	[FieldOffset(Offset = "0x18")]
	private byte m_xor_key;

	// Token: 0x04000A22 RID: 2594
	[Token(Token = "0x4000A22")]
	[FieldOffset(Offset = "0x1C")]
	private int m_index;
}
