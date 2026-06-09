using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F1E RID: 3870
	[Token(Token = "0x2000F1E")]
	public abstract class CsvDataIndexedReading : CSVBaseData
	{
		// Token: 0x060036FB RID: 14075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FB")]
		[Address(RVA = "0x25EDCB4", Offset = "0x25EDCB4", VA = "0x7BBCDEDCB4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060036FC RID: 14076 RVA: 0x00010EA8 File Offset: 0x0000F0A8
		[Token(Token = "0x170006BE")]
		public override bool UsingIndexedParseData
		{
			[Token(Token = "0x60036FC")]
			[Address(RVA = "0x25EDCB8", Offset = "0x25EDCB8", VA = "0x7BBCDEDCB8", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036FD")]
		[Address(RVA = "0x25EDCC0", Offset = "0x25EDCC0", VA = "0x7BBCDEDCC0", Slot = "7")]
		public override string[] GetHeadColNames()
		{
			return null;
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FE")]
		[Address(RVA = "0x25EDCC8", Offset = "0x25EDCC8", VA = "0x7BBCDEDCC8", Slot = "8")]
		public override void ParseData(IIndexString ss, int[] index)
		{
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FF")]
		[Address(RVA = "0x25EDCCC", Offset = "0x25EDCCC", VA = "0x7BBCDEDCCC")]
		protected CsvDataIndexedReading()
		{
		}
	}
}
