using System;
using Il2CppDummyDll;

// Token: 0x0200022E RID: 558
[Token(Token = "0x200022E")]
public static class VibrateFacade
{
	// Token: 0x06000B3A RID: 2874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B3A")]
	[Address(RVA = "0x218CB94", Offset = "0x218CB94", VA = "0x7BBC98CB94")]
	public static void SetImpl(IVibrateInterface impl)
	{
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x06000B3B RID: 2875 RVA: 0x000047E8 File Offset: 0x000029E8
	[Token(Token = "0x170000BF")]
	public static bool EnableVibrateFeature
	{
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x218CC20", Offset = "0x218CC20", VA = "0x7BBC98CC20")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x04000A31 RID: 2609
	[Token(Token = "0x4000A31")]
	[FieldOffset(Offset = "0x0")]
	private static IVibrateInterface m_Impl;
}
