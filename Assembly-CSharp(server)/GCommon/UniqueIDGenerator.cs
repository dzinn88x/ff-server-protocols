using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F5E RID: 3934
	[Token(Token = "0x2000F5E")]
	public class UniqueIDGenerator
	{
		// Token: 0x06003900 RID: 14592 RVA: 0x00011B20 File Offset: 0x0000FD20
		[Token(Token = "0x6003900")]
		[Address(RVA = "0x223D648", Offset = "0x223D648", VA = "0x7BBCA3D648")]
		public uint GetUniqueID()
		{
			return 0U;
		}

		// Token: 0x06003901 RID: 14593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003901")]
		[Address(RVA = "0x223D66C", Offset = "0x223D66C", VA = "0x7BBCA3D66C")]
		public UniqueIDGenerator()
		{
		}

		// Token: 0x04004AD6 RID: 19158
		[Token(Token = "0x4004AD6")]
		[FieldOffset(Offset = "0x0")]
		public static uint INVALID_ID;

		// Token: 0x04004AD7 RID: 19159
		[Token(Token = "0x4004AD7")]
		[FieldOffset(Offset = "0x10")]
		private uint m_NextID;
	}
}
