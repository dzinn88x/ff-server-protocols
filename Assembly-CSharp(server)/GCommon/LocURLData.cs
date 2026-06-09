using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000EA6 RID: 3750
	[Token(Token = "0x2000EA6")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x10EA2CC", Offset = "0x10EA2CC")]
	public class LocURLData : CSVBaseData
	{
		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06003359 RID: 13145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000677")]
		public string Key
		{
			[Token(Token = "0x6003359")]
			[Address(RVA = "0x2126BF8", Offset = "0x2126BF8", VA = "0x7BBC926BF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600335A RID: 13146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000678")]
		public string Item
		{
			[Token(Token = "0x600335A")]
			[Address(RVA = "0x2126C00", Offset = "0x2126C00", VA = "0x7BBC926C00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600335B")]
		[Address(RVA = "0x2126CB8", Offset = "0x2126CB8", VA = "0x7BBC926CB8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600335C RID: 13148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600335C")]
		[Address(RVA = "0x2126CC0", Offset = "0x2126CC0", VA = "0x7BBC926CC0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600335D")]
		[Address(RVA = "0x21270EC", Offset = "0x21270EC", VA = "0x7BBC9270EC")]
		public LocURLData()
		{
		}

		// Token: 0x040046F2 RID: 18162
		[Token(Token = "0x40046F2")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<LocLang, string> keyToURL;

		// Token: 0x040046F3 RID: 18163
		[Token(Token = "0x40046F3")]
		[FieldOffset(Offset = "0x18")]
		private string key;

		// Token: 0x02000EA7 RID: 3751
		[Token(Token = "0x2000EA7")]
		public static class Keys
		{
			// Token: 0x040046F4 RID: 18164
			[Token(Token = "0x40046F4")]
			public const string TERMS_OF_SERVICE = "LOC_URL_TERMS_OF_SERVICE";

			// Token: 0x040046F5 RID: 18165
			[Token(Token = "0x40046F5")]
			public const string TERMS_OF_PRIVACY = "LOC_URL_TERMS_OF_PRIVACY";
		}
	}
}
