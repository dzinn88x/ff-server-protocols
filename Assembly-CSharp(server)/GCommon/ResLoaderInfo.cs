using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FE1 RID: 4065
	[Token(Token = "0x2000FE1")]
	public class ResLoaderInfo
	{
		// Token: 0x06003BE4 RID: 15332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BE4")]
		[Address(RVA = "0x2970174", Offset = "0x2970174", VA = "0x7BBD170174")]
		public ResLoaderInfo()
		{
		}

		// Token: 0x04004D48 RID: 19784
		[Token(Token = "0x4004D48")]
		[FieldOffset(Offset = "0x10")]
		public ResFileLoader Loader;

		// Token: 0x04004D49 RID: 19785
		[Token(Token = "0x4004D49")]
		[FieldOffset(Offset = "0x18")]
		public bool IsUnZip;
	}
}
