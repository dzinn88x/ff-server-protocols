using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FBF RID: 4031
	[Token(Token = "0x2000FBF")]
	public class MemoryProfiler
	{
		// Token: 0x06003AD2 RID: 15058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD2")]
		[Address(RVA = "0x245D56C", Offset = "0x245D56C", VA = "0x7BBCC5D56C")]
		public static void BeginMonoProfile(string tag)
		{
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD3")]
		[Address(RVA = "0x245D570", Offset = "0x245D570", VA = "0x7BBCC5D570")]
		public static void EndMonoProfile(string tag, bool additive = false)
		{
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD4")]
		[Address(RVA = "0x245D574", Offset = "0x245D574", VA = "0x7BBCC5D574")]
		public static string GetMonoMemoryStatus()
		{
			return null;
		}

		// Token: 0x06003AD5 RID: 15061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD5")]
		[Address(RVA = "0x245D5C4", Offset = "0x245D5C4", VA = "0x7BBCC5D5C4")]
		public MemoryProfiler()
		{
		}
	}
}
