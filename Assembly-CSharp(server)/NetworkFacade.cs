using System;
using Il2CppDummyDll;

// Token: 0x02000231 RID: 561
[Token(Token = "0x2000231")]
public static class NetworkFacade
{
	// Token: 0x06000B40 RID: 2880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B40")]
	[Address(RVA = "0x2290D14", Offset = "0x2290D14", VA = "0x7BBCA90D14")]
	public static void SetImpl(INetworkInterface impl)
	{
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000B41 RID: 2881 RVA: 0x00004818 File Offset: 0x00002A18
	[Token(Token = "0x170000C2")]
	public static bool EnableVibrateFeature
	{
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x2290DA0", Offset = "0x2290DA0", VA = "0x7BBCA90DA0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x04000A32 RID: 2610
	[Token(Token = "0x4000A32")]
	[FieldOffset(Offset = "0x0")]
	private static INetworkInterface m_Impl;
}
