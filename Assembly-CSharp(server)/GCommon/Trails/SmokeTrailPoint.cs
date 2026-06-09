using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails
{
	// Token: 0x0200107B RID: 4219
	[Token(Token = "0x200107B")]
	public class SmokeTrailPoint : PCTrailPoint
	{
		// Token: 0x0600408E RID: 16526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408E")]
		[Address(RVA = "0x249BB34", Offset = "0x249BB34", VA = "0x7BBCC9BB34", Slot = "4")]
		public override void Update(float deltaTime)
		{
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600408F")]
		[Address(RVA = "0x249BC14", Offset = "0x249BC14", VA = "0x7BBCC9BC14")]
		public SmokeTrailPoint()
		{
		}

		// Token: 0x04005021 RID: 20513
		[Token(Token = "0x4005021")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 RandomVec;
	}
}
