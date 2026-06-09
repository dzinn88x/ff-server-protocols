using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010A9 RID: 4265
	[Token(Token = "0x20010A9")]
	public class ClothesUpData : CSVBaseData, IGetId
	{
		// Token: 0x06004289 RID: 17033 RVA: 0x00014808 File Offset: 0x00012A08
		[Token(Token = "0x6004289")]
		[Address(RVA = "0x14FAAFC", Offset = "0x14FAAFC", VA = "0x7BBBCFAAFC", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600428A")]
		[Address(RVA = "0x14FAB04", Offset = "0x14FAB04", VA = "0x7BBBCFAB04", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600428B RID: 17035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600428B")]
		[Address(RVA = "0x14FAB10", Offset = "0x14FAB10", VA = "0x7BBBCFAB10", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600428C RID: 17036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600428C")]
		[Address(RVA = "0x14FACAC", Offset = "0x14FACAC", VA = "0x7BBBCFACAC")]
		public ClothesUpData()
		{
		}

		// Token: 0x0400518E RID: 20878
		[Token(Token = "0x400518E")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x0400518F RID: 20879
		[Token(Token = "0x400518F")]
		[FieldOffset(Offset = "0x14")]
		public uint ClothesID;

		// Token: 0x04005190 RID: 20880
		[Token(Token = "0x4005190")]
		[FieldOffset(Offset = "0x18")]
		public uint EffectsTriggerID;

		// Token: 0x04005191 RID: 20881
		[Token(Token = "0x4005191")]
		[FieldOffset(Offset = "0x1C")]
		public uint ClothesUpID;

		// Token: 0x04005192 RID: 20882
		[Token(Token = "0x4005192")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID EffectIDM;

		// Token: 0x04005193 RID: 20883
		[Token(Token = "0x4005193")]
		[FieldOffset(Offset = "0x24")]
		public ResourceID EffectIDF;
	}
}
