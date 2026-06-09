using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200117E RID: 4478
	[Token(Token = "0x200117E")]
	public class RegionSettingData : CSVBaseData
	{
		// Token: 0x060045B0 RID: 17840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B0")]
		[Address(RVA = "0x175303C", Offset = "0x175303C", VA = "0x7BBBF5303C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B1")]
		[Address(RVA = "0x1753048", Offset = "0x1753048", VA = "0x7BBBF53048", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B2")]
		[Address(RVA = "0x175313C", Offset = "0x175313C", VA = "0x7BBBF5313C")]
		public static string GetRegionServerName(int id)
		{
			return null;
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B3")]
		[Address(RVA = "0x17532BC", Offset = "0x17532BC", VA = "0x7BBBF532BC")]
		public RegionSettingData()
		{
		}

		// Token: 0x040056AE RID: 22190
		[Token(Token = "0x40056AE")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x040056AF RID: 22191
		[Token(Token = "0x40056AF")]
		[FieldOffset(Offset = "0x18")]
		public string RegionName;

		// Token: 0x040056B0 RID: 22192
		[Token(Token = "0x40056B0")]
		[FieldOffset(Offset = "0x20")]
		public string RegionServer;
	}
}
