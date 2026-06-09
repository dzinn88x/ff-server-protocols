using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001132 RID: 4402
	[Token(Token = "0x2001132")]
	public class LoginPlatformData : CSVBaseData
	{
		// Token: 0x060044CA RID: 17610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044CA")]
		[Address(RVA = "0x1A5423C", Offset = "0x1A5423C", VA = "0x7BBC25423C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CB")]
		[Address(RVA = "0x1A54244", Offset = "0x1A54244", VA = "0x7BBC254244", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CC")]
		[Address(RVA = "0x1A542FC", Offset = "0x1A542FC", VA = "0x7BBC2542FC")]
		public LoginPlatformData()
		{
		}

		// Token: 0x040054F3 RID: 21747
		[Token(Token = "0x40054F3")]
		[FieldOffset(Offset = "0x10")]
		public string Country;

		// Token: 0x040054F4 RID: 21748
		[Token(Token = "0x40054F4")]
		[FieldOffset(Offset = "0x18")]
		public PlatformType Platformtype;
	}
}
