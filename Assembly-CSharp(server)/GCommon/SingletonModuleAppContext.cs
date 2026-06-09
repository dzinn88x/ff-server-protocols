using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000ED2 RID: 3794
	[Token(Token = "0x2000ED2")]
	public static class SingletonModuleAppContext
	{
		// Token: 0x0600346F RID: 13423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600346F")]
		[Address(RVA = "0x2492BD8", Offset = "0x2492BD8", VA = "0x7BBCC92BD8")]
		internal static void RegisterModule(ISingletonModule module)
		{
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003470")]
		[Address(RVA = "0x2492C64", Offset = "0x2492C64", VA = "0x7BBCC92C64")]
		public static void InitModules()
		{
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003471")]
		[Address(RVA = "0x2492E0C", Offset = "0x2492E0C", VA = "0x7BBCC92E0C")]
		public static void CleanupModules()
		{
		}

		// Token: 0x04004812 RID: 18450
		[Token(Token = "0x4004812")]
		[FieldOffset(Offset = "0x0")]
		private static List<ISingletonModule> Modules;
	}
}
