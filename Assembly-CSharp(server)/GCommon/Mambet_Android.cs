using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F36 RID: 3894
	[Token(Token = "0x2000F36")]
	public static class Mambet_Android
	{
		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060037CD RID: 14285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CC")]
		private static AndroidJavaClass Mambet
		{
			[Token(Token = "0x60037CD")]
			[Address(RVA = "0x212C210", Offset = "0x212C210", VA = "0x7BBC92C210")]
			get
			{
				return null;
			}
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CE")]
		[Address(RVA = "0x2128800", Offset = "0x2128800", VA = "0x7BBC928800")]
		public static void SetUnitySendMessageGameObjectName(string gameObjectName)
		{
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037CF")]
		[Address(RVA = "0x212868C", Offset = "0x212868C", VA = "0x7BBC92868C")]
		public static void Init(int game_id, bool debug_mode)
		{
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D0")]
		[Address(RVA = "0x21288E8", Offset = "0x21288E8", VA = "0x7BBC9288E8")]
		public static void SetAccountID(string accountID)
		{
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D1")]
		[Address(RVA = "0x21289D0", Offset = "0x21289D0", VA = "0x7BBC9289D0")]
		public static void PushEvent(string type, string data)
		{
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D2")]
		[Address(RVA = "0x2127DA0", Offset = "0x2127DA0", VA = "0x7BBC927DA0")]
		public static void VoiceDataSender_Start(bool debug_voice)
		{
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D3")]
		[Address(RVA = "0x2127F14", Offset = "0x2127F14", VA = "0x7BBC927F14")]
		public static void VoiceDataSender_Stop()
		{
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D4")]
		[Address(RVA = "0x2129A34", Offset = "0x2129A34", VA = "0x7BBC929A34")]
		public static void VoiceDataSender_SendUnityAudioData(int channels, int samplingRateHz, float[] sample, int id)
		{
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D5")]
		[Address(RVA = "0x212A4D4", Offset = "0x212A4D4", VA = "0x7BBC92A4D4")]
		public static void VoiceDataSender_SendAudioData(int channels, int samplingRateHz, int bytesPerSample, byte[] sample, int source, int id)
		{
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D6")]
		[Address(RVA = "0x2128000", Offset = "0x2128000", VA = "0x7BBC928000")]
		public static void VoiceDataSender_RequestMic()
		{
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037D7")]
		[Address(RVA = "0x2128084", Offset = "0x2128084", VA = "0x7BBC928084")]
		public static void VoiceDataSender_ReleaseMic()
		{
		}

		// Token: 0x04004A37 RID: 18999
		[Token(Token = "0x4004A37")]
		[FieldOffset(Offset = "0x0")]
		private static AndroidJavaClass _Mambet;
	}
}
