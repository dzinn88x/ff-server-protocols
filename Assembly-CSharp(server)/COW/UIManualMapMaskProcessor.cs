using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A54 RID: 6740
	[Token(Token = "0x2001A54")]
	public class UIManualMapMaskProcessor
	{
		// Token: 0x06008DC9 RID: 36297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DC9")]
		[Address(RVA = "0x18E3848", Offset = "0x18E3848", VA = "0x7BBC0E3848")]
		public static void ProcessMapMask(UITexture tex, List<UISprite> signList, uint[] radiusArray, bool unlockAll = false)
		{
		}

		// Token: 0x06008DCA RID: 36298 RVA: 0x00025C80 File Offset: 0x00023E80
		[Token(Token = "0x6008DCA")]
		[Address(RVA = "0x18E3F54", Offset = "0x18E3F54", VA = "0x7BBC0E3F54")]
		private static Vector2 Pos2Pixel(UITexture tex, Vector2 localPos)
		{
			return default(Vector2);
		}

		// Token: 0x06008DCB RID: 36299 RVA: 0x00025C98 File Offset: 0x00023E98
		[Token(Token = "0x6008DCB")]
		[Address(RVA = "0x18E40DC", Offset = "0x18E40DC", VA = "0x7BBC0E40DC")]
		private static int CalRdius(int radius)
		{
			return 0;
		}

		// Token: 0x06008DCC RID: 36300 RVA: 0x00025CB0 File Offset: 0x00023EB0
		[Token(Token = "0x6008DCC")]
		[Address(RVA = "0x18E4120", Offset = "0x18E4120", VA = "0x7BBC0E4120")]
		private static bool IsInCircle(Vector2 pos, Vector2 center, float radius)
		{
			return default(bool);
		}

		// Token: 0x06008DCD RID: 36301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008DCD")]
		[Address(RVA = "0x18E41DC", Offset = "0x18E41DC", VA = "0x7BBC0E41DC")]
		public UIManualMapMaskProcessor()
		{
		}

		// Token: 0x040099A8 RID: 39336
		[Token(Token = "0x40099A8")]
		private const int m_MaskTexW = 64;

		// Token: 0x040099A9 RID: 39337
		[Token(Token = "0x40099A9")]
		private const int m_MaskTexH = 64;

		// Token: 0x040099AA RID: 39338
		[Token(Token = "0x40099AA")]
		[FieldOffset(Offset = "0x0")]
		private static Color m_DefMaskColor;
	}
}
