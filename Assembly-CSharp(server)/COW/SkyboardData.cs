using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010CA RID: 4298
	[Token(Token = "0x20010CA")]
	public class SkyboardData : CSVBaseData, IGetId
	{
		// Token: 0x06004301 RID: 17153 RVA: 0x00014A30 File Offset: 0x00012C30
		[Token(Token = "0x6004301")]
		[Address(RVA = "0x1B39654", Offset = "0x1B39654", VA = "0x7BBC339654", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004302")]
		[Address(RVA = "0x1B3965C", Offset = "0x1B3965C", VA = "0x7BBC33965C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004303")]
		[Address(RVA = "0x1B39668", Offset = "0x1B39668", VA = "0x7BBC339668", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004304")]
		[Address(RVA = "0x1B39C18", Offset = "0x1B39C18", VA = "0x7BBC339C18")]
		public SkyboardData()
		{
		}

		// Token: 0x0400524B RID: 21067
		[Token(Token = "0x400524B")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400524C RID: 21068
		[Token(Token = "0x400524C")]
		[FieldOffset(Offset = "0x18")]
		public string description;

		// Token: 0x0400524D RID: 21069
		[Token(Token = "0x400524D")]
		[FieldOffset(Offset = "0x20")]
		public uint iID;

		// Token: 0x0400524E RID: 21070
		[Token(Token = "0x400524E")]
		[FieldOffset(Offset = "0x24")]
		public uint sortId;

		// Token: 0x0400524F RID: 21071
		[Token(Token = "0x400524F")]
		[FieldOffset(Offset = "0x28")]
		public float skyDivingMinVSpeed;

		// Token: 0x04005250 RID: 21072
		[Token(Token = "0x4005250")]
		[FieldOffset(Offset = "0x2C")]
		public float skyDivingMaxVSpeed;

		// Token: 0x04005251 RID: 21073
		[Token(Token = "0x4005251")]
		[FieldOffset(Offset = "0x30")]
		public float skyDivingMinHSpeed;

		// Token: 0x04005252 RID: 21074
		[Token(Token = "0x4005252")]
		[FieldOffset(Offset = "0x34")]
		public float skyDivingMaxHSpeed;

		// Token: 0x04005253 RID: 21075
		[Token(Token = "0x4005253")]
		[FieldOffset(Offset = "0x38")]
		public float skyDivingSpeedDelta;

		// Token: 0x04005254 RID: 21076
		[Token(Token = "0x4005254")]
		[FieldOffset(Offset = "0x3C")]
		public float skySurfingMinVSpeed;

		// Token: 0x04005255 RID: 21077
		[Token(Token = "0x4005255")]
		[FieldOffset(Offset = "0x40")]
		public float skySurfingMaxVSpeed;

		// Token: 0x04005256 RID: 21078
		[Token(Token = "0x4005256")]
		[FieldOffset(Offset = "0x44")]
		public float skySurfingMinHSpeed;

		// Token: 0x04005257 RID: 21079
		[Token(Token = "0x4005257")]
		[FieldOffset(Offset = "0x48")]
		public float skySurfingMaxHSpeed;

		// Token: 0x04005258 RID: 21080
		[Token(Token = "0x4005258")]
		[FieldOffset(Offset = "0x4C")]
		public float skySurfingSpeedDelta;

		// Token: 0x04005259 RID: 21081
		[Token(Token = "0x4005259")]
		[FieldOffset(Offset = "0x50")]
		public float swimSurfingSpeed;

		// Token: 0x0400525A RID: 21082
		[Token(Token = "0x400525A")]
		[FieldOffset(Offset = "0x54")]
		public ResourceID previewRes;

		// Token: 0x0400525B RID: 21083
		[Token(Token = "0x400525B")]
		[FieldOffset(Offset = "0x58")]
		public ResourceID inGameRes;

		// Token: 0x0400525C RID: 21084
		[Token(Token = "0x400525C")]
		[FieldOffset(Offset = "0x5C")]
		public ESourceType sourceTypeKey;

		// Token: 0x0400525D RID: 21085
		[Token(Token = "0x400525D")]
		[FieldOffset(Offset = "0x5D")]
		public bool IsWithEffect;

		// Token: 0x0400525E RID: 21086
		[Token(Token = "0x400525E")]
		[FieldOffset(Offset = "0x5E")]
		public bool showHoverboardComponent;
	}
}
