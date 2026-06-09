using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010CF RID: 4303
	[Token(Token = "0x20010CF")]
	public class VehicleSkinData : CSVBaseData
	{
		// Token: 0x06004313 RID: 17171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004313")]
		[Address(RVA = "0x179912C", Offset = "0x179912C", VA = "0x7BBBF9912C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004314")]
		[Address(RVA = "0x1799138", Offset = "0x1799138", VA = "0x7BBBF99138", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004315")]
		[Address(RVA = "0x179A138", Offset = "0x179A138", VA = "0x7BBBF9A138")]
		public VehicleSkinData()
		{
		}

		// Token: 0x04005284 RID: 21124
		[Token(Token = "0x4005284")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04005285 RID: 21125
		[Token(Token = "0x4005285")]
		[FieldOffset(Offset = "0x18")]
		public string PropertyDescription;

		// Token: 0x04005286 RID: 21126
		[Token(Token = "0x4005286")]
		[FieldOffset(Offset = "0x20")]
		public uint iID;

		// Token: 0x04005287 RID: 21127
		[Token(Token = "0x4005287")]
		[FieldOffset(Offset = "0x24")]
		public uint VehicleID;

		// Token: 0x04005288 RID: 21128
		[Token(Token = "0x4005288")]
		[FieldOffset(Offset = "0x28")]
		public uint sortId;

		// Token: 0x04005289 RID: 21129
		[Token(Token = "0x4005289")]
		[FieldOffset(Offset = "0x2C")]
		public uint basedConfigID;

		// Token: 0x0400528A RID: 21130
		[Token(Token = "0x400528A")]
		[FieldOffset(Offset = "0x30")]
		public ResourceID previewRes;

		// Token: 0x0400528B RID: 21131
		[Token(Token = "0x400528B")]
		[FieldOffset(Offset = "0x34")]
		public ResourceID inGameRes;

		// Token: 0x0400528C RID: 21132
		[Token(Token = "0x400528C")]
		[FieldOffset(Offset = "0x38")]
		public ResourceID inGameWithEffectRes;

		// Token: 0x0400528D RID: 21133
		[Token(Token = "0x400528D")]
		[FieldOffset(Offset = "0x3C")]
		public bool IsWithEffect;
	}
}
