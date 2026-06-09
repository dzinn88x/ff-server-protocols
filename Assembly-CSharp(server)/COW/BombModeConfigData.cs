using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010B9 RID: 4281
	[Token(Token = "0x20010B9")]
	public class BombModeConfigData : CSVBaseData
	{
		// Token: 0x060042C6 RID: 17094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C6")]
		[Address(RVA = "0x14E42B8", Offset = "0x14E42B8", VA = "0x7BBBCE42B8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C7")]
		[Address(RVA = "0x14E42E0", Offset = "0x14E42E0", VA = "0x7BBBCE42E0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C8")]
		[Address(RVA = "0x14E4428", Offset = "0x14E4428", VA = "0x7BBBCE4428")]
		public BombModeConfigData()
		{
		}

		// Token: 0x040051E0 RID: 20960
		[Token(Token = "0x40051E0")]
		[FieldOffset(Offset = "0x10")]
		public uint BombPlantCastingTime;

		// Token: 0x040051E1 RID: 20961
		[Token(Token = "0x40051E1")]
		[FieldOffset(Offset = "0x14")]
		public uint BombRemoveCastingTime;

		// Token: 0x040051E2 RID: 20962
		[Token(Token = "0x40051E2")]
		[FieldOffset(Offset = "0x18")]
		public uint PliersRemoveCastingTime;

		// Token: 0x040051E3 RID: 20963
		[Token(Token = "0x40051E3")]
		[FieldOffset(Offset = "0x1C")]
		public uint PliersID;

		// Token: 0x040051E4 RID: 20964
		[Token(Token = "0x40051E4")]
		[FieldOffset(Offset = "0x20")]
		public uint BombAliveTimeAfterSettle;

		// Token: 0x040051E5 RID: 20965
		[Token(Token = "0x40051E5")]
		[FieldOffset(Offset = "0x24")]
		public uint BombMatchMaxTime;
	}
}
