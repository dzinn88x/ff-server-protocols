using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010B5 RID: 4277
	[Token(Token = "0x20010B5")]
	public class BigHeadData : CSVBaseData
	{
		// Token: 0x060042B6 RID: 17078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042B6")]
		[Address(RVA = "0x14E32DC", Offset = "0x14E32DC", VA = "0x7BBBCE32DC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042B7 RID: 17079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B7")]
		[Address(RVA = "0x14E32E8", Offset = "0x14E32E8", VA = "0x7BBBCE32E8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042B8 RID: 17080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042B8")]
		[Address(RVA = "0x14E3740", Offset = "0x14E3740", VA = "0x7BBBCE3740")]
		public BigHeadData()
		{
		}

		// Token: 0x040051D0 RID: 20944
		[Token(Token = "0x40051D0")]
		[FieldOffset(Offset = "0x10")]
		public uint Lv;

		// Token: 0x040051D1 RID: 20945
		[Token(Token = "0x40051D1")]
		[FieldOffset(Offset = "0x14")]
		public float HeadScale;

		// Token: 0x040051D2 RID: 20946
		[Token(Token = "0x40051D2")]
		[FieldOffset(Offset = "0x18")]
		public float HeadShotDamageScale;

		// Token: 0x040051D3 RID: 20947
		[Token(Token = "0x40051D3")]
		[FieldOffset(Offset = "0x1C")]
		public int KillScore;

		// Token: 0x040051D4 RID: 20948
		[Token(Token = "0x40051D4")]
		[FieldOffset(Offset = "0x20")]
		public int BoostKillScore;

		// Token: 0x040051D5 RID: 20949
		[Token(Token = "0x40051D5")]
		[FieldOffset(Offset = "0x24")]
		public uint HeadAvatar;

		// Token: 0x040051D6 RID: 20950
		[Token(Token = "0x40051D6")]
		[FieldOffset(Offset = "0x28")]
		public int NeedKillCount;

		// Token: 0x040051D7 RID: 20951
		[Token(Token = "0x40051D7")]
		[FieldOffset(Offset = "0x2C")]
		public ResourceID EffectID;

		// Token: 0x040051D8 RID: 20952
		[Token(Token = "0x40051D8")]
		[FieldOffset(Offset = "0x30")]
		public ResourceID HeadIcon;

		// Token: 0x040051D9 RID: 20953
		[Token(Token = "0x40051D9")]
		[FieldOffset(Offset = "0x34")]
		public ResourceID LightHeadIcon;

		// Token: 0x040051DA RID: 20954
		[Token(Token = "0x40051DA")]
		[FieldOffset(Offset = "0x38")]
		public ResourceID LightOffHeadIcon;

		// Token: 0x040051DB RID: 20955
		[Token(Token = "0x40051DB")]
		[FieldOffset(Offset = "0x40")]
		public string Name;
	}
}
