using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011A9 RID: 4521
	[Token(Token = "0x20011A9")]
	public class WebViewSettingData : CSVBaseData
	{
		// Token: 0x06004653 RID: 18003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004653")]
		[Address(RVA = "0x23DF120", Offset = "0x23DF120", VA = "0x7BBCBDF120", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004654")]
		[Address(RVA = "0x23DF128", Offset = "0x23DF128", VA = "0x7BBCBDF128", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004655")]
		[Address(RVA = "0x23DF1F8", Offset = "0x23DF1F8", VA = "0x7BBCBDF1F8")]
		public WebViewSettingData()
		{
		}

		// Token: 0x040057A3 RID: 22435
		[Token(Token = "0x40057A3")]
		[FieldOffset(Offset = "0x10")]
		public string Url;

		// Token: 0x040057A4 RID: 22436
		[Token(Token = "0x40057A4")]
		[FieldOffset(Offset = "0x18")]
		public bool UseWebPage;
	}
}
