using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001274 RID: 4724
	[Token(Token = "0x2001274")]
	internal class ShadowStateBase
	{
		// Token: 0x0600491E RID: 18718 RVA: 0x00016260 File Offset: 0x00014460
		[Token(Token = "0x600491E")]
		[Address(RVA = "0x1B36C58", Offset = "0x1B36C58", VA = "0x7BBC336C58")]
		public bool IncreaseSimTick()
		{
			return default(bool);
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x00016278 File Offset: 0x00014478
		[Token(Token = "0x600491F")]
		[Address(RVA = "0x1B36D08", Offset = "0x1B36D08", VA = "0x7BBC336D08")]
		public float GetDeltaTimeInLerp()
		{
			return 0f;
		}

		// Token: 0x06004920 RID: 18720 RVA: 0x00016290 File Offset: 0x00014490
		[Token(Token = "0x6004920")]
		[Address(RVA = "0x1B36DDC", Offset = "0x1B36DDC", VA = "0x7BBC336DDC")]
		public float GetLerpRatio()
		{
			return 0f;
		}

		// Token: 0x06004921 RID: 18721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004921")]
		[Address(RVA = "0x1B36E08", Offset = "0x1B36E08", VA = "0x7BBC336E08")]
		public ShadowStateBase()
		{
		}

		// Token: 0x04007212 RID: 29202
		[Token(Token = "0x4007212")]
		[FieldOffset(Offset = "0x10")]
		public uint TargetTickCount;

		// Token: 0x04007213 RID: 29203
		[Token(Token = "0x4007213")]
		[FieldOffset(Offset = "0x14")]
		public uint SimTick;
	}
}
