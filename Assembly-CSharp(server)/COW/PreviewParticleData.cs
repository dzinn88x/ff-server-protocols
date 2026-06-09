using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001173 RID: 4467
	[Token(Token = "0x2001173")]
	public class PreviewParticleData : CSVBaseData
	{
		// Token: 0x0600458B RID: 17803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600458B")]
		[Address(RVA = "0x1748F0C", Offset = "0x1748F0C", VA = "0x7BBBF48F0C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600458C RID: 17804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600458C")]
		[Address(RVA = "0x1748F18", Offset = "0x1748F18", VA = "0x7BBBF48F18", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600458D RID: 17805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600458D")]
		[Address(RVA = "0x1749184", Offset = "0x1749184", VA = "0x7BBBF49184")]
		public PreviewParticleData()
		{
		}

		// Token: 0x0400566E RID: 22126
		[Token(Token = "0x400566E")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x0400566F RID: 22127
		[Token(Token = "0x400566F")]
		[FieldOffset(Offset = "0x14")]
		public ResourceID previewRes;

		// Token: 0x04005670 RID: 22128
		[Token(Token = "0x4005670")]
		[FieldOffset(Offset = "0x18")]
		public float PosX;

		// Token: 0x04005671 RID: 22129
		[Token(Token = "0x4005671")]
		[FieldOffset(Offset = "0x1C")]
		public float PosY;

		// Token: 0x04005672 RID: 22130
		[Token(Token = "0x4005672")]
		[FieldOffset(Offset = "0x20")]
		public float PosZ;

		// Token: 0x04005673 RID: 22131
		[Token(Token = "0x4005673")]
		[FieldOffset(Offset = "0x24")]
		public float RotX;

		// Token: 0x04005674 RID: 22132
		[Token(Token = "0x4005674")]
		[FieldOffset(Offset = "0x28")]
		public float RotY;

		// Token: 0x04005675 RID: 22133
		[Token(Token = "0x4005675")]
		[FieldOffset(Offset = "0x2C")]
		public float RotZ;
	}
}
