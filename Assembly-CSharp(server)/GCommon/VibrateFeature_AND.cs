using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F70 RID: 3952
	[Token(Token = "0x2000F70")]
	public static class VibrateFeature_AND
	{
		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06003987 RID: 14727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006DE")]
		private static AndroidJavaClass VibrateUtil
		{
			[Token(Token = "0x6003987")]
			[Address(RVA = "0x2248D64", Offset = "0x2248D64", VA = "0x7BBCA48D64")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06003988 RID: 14728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006DF")]
		private static AndroidJavaObject CurrentAvtivity
		{
			[Token(Token = "0x6003988")]
			[Address(RVA = "0x2248DF8", Offset = "0x2248DF8", VA = "0x7BBCA48DF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003989")]
		[Address(RVA = "0x2248EB4", Offset = "0x2248EB4", VA = "0x7BBCA48EB4")]
		public static void StartVibrate(long[] _vibrateInfo, bool _isLoop = false)
		{
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600398A")]
		[Address(RVA = "0x2249064", Offset = "0x2249064", VA = "0x7BBCA49064")]
		public static void StopVibrate()
		{
		}

		// Token: 0x04004B15 RID: 19221
		[Token(Token = "0x4004B15")]
		[FieldOffset(Offset = "0x0")]
		private static AndroidJavaClass m_VibrateUtil;

		// Token: 0x04004B16 RID: 19222
		[Token(Token = "0x4004B16")]
		[FieldOffset(Offset = "0x8")]
		private static AndroidJavaObject m_CurrentActivity;
	}
}
