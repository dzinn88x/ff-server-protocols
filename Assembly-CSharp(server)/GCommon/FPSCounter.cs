using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F23 RID: 3875
	[Token(Token = "0x2000F23")]
	public class FPSCounter : MonoBehaviour
	{
		// Token: 0x06003751 RID: 14161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003751")]
		[Address(RVA = "0x2113BF8", Offset = "0x2113BF8", VA = "0x7BBC913BF8")]
		private void Awake()
		{
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003752")]
		[Address(RVA = "0x2113C64", Offset = "0x2113C64", VA = "0x7BBC913C64")]
		private void Start()
		{
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003753")]
		[Address(RVA = "0x2113C94", Offset = "0x2113C94", VA = "0x7BBC913C94")]
		private void Update()
		{
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x000112C8 File Offset: 0x0000F4C8
		[Token(Token = "0x6003754")]
		[Address(RVA = "0x2113CF4", Offset = "0x2113CF4", VA = "0x7BBC913CF4")]
		public int GetCurrentFPS()
		{
			return 0;
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003755")]
		[Address(RVA = "0x2113CFC", Offset = "0x2113CFC", VA = "0x7BBC913CFC")]
		public FPSCounter()
		{
		}

		// Token: 0x040049F1 RID: 18929
		[Token(Token = "0x40049F1")]
		[FieldOffset(Offset = "0x0")]
		public static FPSCounter instance;

		// Token: 0x040049F2 RID: 18930
		[Token(Token = "0x40049F2")]
		private const float fpsMeasurePeriod = 0.5f;

		// Token: 0x040049F3 RID: 18931
		[Token(Token = "0x40049F3")]
		[FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		// Token: 0x040049F4 RID: 18932
		[Token(Token = "0x40049F4")]
		[FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		// Token: 0x040049F5 RID: 18933
		[Token(Token = "0x40049F5")]
		[FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;
	}
}
