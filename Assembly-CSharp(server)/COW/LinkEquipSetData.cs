using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001128 RID: 4392
	[Token(Token = "0x2001128")]
	public class LinkEquipSetData : CSVBaseData
	{
		// Token: 0x060044A8 RID: 17576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044A8")]
		[Address(RVA = "0x14047B0", Offset = "0x14047B0", VA = "0x7BBBC047B0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A9")]
		[Address(RVA = "0x14047BC", Offset = "0x14047BC", VA = "0x7BBBC047BC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044AA RID: 17578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044AA")]
		[Address(RVA = "0x1404958", Offset = "0x1404958", VA = "0x7BBBC04958")]
		public LinkEquipSetData()
		{
		}

		// Token: 0x040054D1 RID: 21713
		[Token(Token = "0x40054D1")]
		[FieldOffset(Offset = "0x10")]
		public uint Id;

		// Token: 0x040054D2 RID: 21714
		[Token(Token = "0x40054D2")]
		[FieldOffset(Offset = "0x18")]
		public EquipIdCountDataList EquipSet1;

		// Token: 0x040054D3 RID: 21715
		[Token(Token = "0x40054D3")]
		[FieldOffset(Offset = "0x20")]
		public EquipIdCountDataList EquipSet2;

		// Token: 0x040054D4 RID: 21716
		[Token(Token = "0x40054D4")]
		[FieldOffset(Offset = "0x28")]
		public EquipIdCountDataList EquipSet3;

		// Token: 0x040054D5 RID: 21717
		[Token(Token = "0x40054D5")]
		[FieldOffset(Offset = "0x30")]
		public EquipIdCountDataList EquipSet4;

		// Token: 0x040054D6 RID: 21718
		[Token(Token = "0x40054D6")]
		[FieldOffset(Offset = "0x38")]
		public EquipIdCountDataList EquipSet5;

		// Token: 0x040054D7 RID: 21719
		[Token(Token = "0x40054D7")]
		[FieldOffset(Offset = "0x40")]
		public EquipIdCountDataList EquipSet6;
	}
}
