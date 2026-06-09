using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EAB RID: 3755
	[Token(Token = "0x2000EAB")]
	public class AIWarningRegionTool
	{
		// Token: 0x06003366 RID: 13158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003366")]
		public static IAIWarningRegion CreateWarningRegion<T0, T>(ResourceID regionResID, Vector3 Pos, Quaternion Rot, T initParam) where T0 : AIWarningRegion<!!1>
		{
			return null;
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003367")]
		[Address(RVA = "0x25D70A8", Offset = "0x25D70A8", VA = "0x7BBCDD70A8")]
		public static IAIWarningRegion CreateCircleRegion(ResourceID regionResID, Vector3 Pos, Quaternion Rot, float radius)
		{
			return null;
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003368")]
		[Address(RVA = "0x25D7184", Offset = "0x25D7184", VA = "0x7BBCDD7184")]
		public static IAIWarningRegion CreateQuadRegion(ResourceID regionResID, Vector3 Pos, Quaternion Rot, float width, float height, float length)
		{
			return null;
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003369")]
		[Address(RVA = "0x25D728C", Offset = "0x25D728C", VA = "0x7BBCDD728C")]
		public AIWarningRegionTool()
		{
		}
	}
}
