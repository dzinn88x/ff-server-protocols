using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001133 RID: 4403
	[Token(Token = "0x2001133")]
	public class LoginQualityBgData : CSVBaseData
	{
		// Token: 0x060044CD RID: 17613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044CD")]
		[Address(RVA = "0x1A54364", Offset = "0x1A54364", VA = "0x7BBC254364", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CE")]
		[Address(RVA = "0x1A54370", Offset = "0x1A54370", VA = "0x7BBC254370", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CF")]
		[Address(RVA = "0x1A54488", Offset = "0x1A54488", VA = "0x7BBC254488")]
		public LoginQualityBgData()
		{
		}

		// Token: 0x040054F5 RID: 21749
		[Token(Token = "0x40054F5")]
		[FieldOffset(Offset = "0x10")]
		public uint LoginId;

		// Token: 0x040054F6 RID: 21750
		[Token(Token = "0x40054F6")]
		[FieldOffset(Offset = "0x18")]
		public string CountryCode;

		// Token: 0x040054F7 RID: 21751
		[Token(Token = "0x40054F7")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID ResId;
	}
}
