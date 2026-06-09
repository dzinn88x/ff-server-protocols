using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002B84 RID: 11140
	[Token(Token = "0x2002B84")]
	public class TrainingSceneRenderGroupPreset : MonoBehaviour
	{
		// Token: 0x0600F665 RID: 63077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F665")]
		[Address(RVA = "0x16CCF04", Offset = "0x16CCF04", VA = "0x7BBBECCF04")]
		private void Awake()
		{
		}

		// Token: 0x0600F666 RID: 63078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F666")]
		[Address(RVA = "0x16CD060", Offset = "0x16CD060", VA = "0x7BBBECD060")]
		public TrainingSceneRenderGroupPreset()
		{
		}

		// Token: 0x04011A96 RID: 72342
		[Token(Token = "0x4011A96")]
		[FieldOffset(Offset = "0x18")]
		public TrainingSceneRenderGroupPreset.ZoneTypeRender[] ZoneTypeRenders;

		// Token: 0x02002B85 RID: 11141
		[Token(Token = "0x2002B85")]
		[Serializable]
		public struct ZoneTypeRender
		{
			// Token: 0x04011A97 RID: 72343
			[Token(Token = "0x4011A97")]
			[FieldOffset(Offset = "0x0")]
			public {Z|h[YF ZoneType;

			// Token: 0x04011A98 RID: 72344
			[Token(Token = "0x4011A98")]
			[FieldOffset(Offset = "0x8")]
			public BhMVRuO[] ContainRenderGroup;
		}
	}
}
