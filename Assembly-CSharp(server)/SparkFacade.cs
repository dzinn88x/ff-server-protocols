using System;
using GCommon;
using Il2CppDummyDll;

// Token: 0x020000CE RID: 206
[Token(Token = "0x20000CE")]
public static class SparkFacade
{
	// Token: 0x0600036A RID: 874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036A")]
	[Address(RVA = "0x22608C8", Offset = "0x22608C8", VA = "0x7BBCA608C8")]
	public static void SetImpl(ISparkInterface impl)
	{
	}

	// Token: 0x0600036B RID: 875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036B")]
	[Address(RVA = "0x2260954", Offset = "0x2260954", VA = "0x7BBCA60954")]
	public static void SetDebugEvent(bool debug)
	{
	}

	// Token: 0x0600036C RID: 876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036C")]
	[Address(RVA = "0x2260A7C", Offset = "0x2260A7C", VA = "0x7BBCA60A7C")]
	public static void SetDebugVoice(bool debug)
	{
	}

	// Token: 0x0600036D RID: 877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036D")]
	[Address(RVA = "0x2260BA4", Offset = "0x2260BA4", VA = "0x7BBCA60BA4")]
	public static void Init(int game_id)
	{
	}

	// Token: 0x0600036E RID: 878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036E")]
	[Address(RVA = "0x2260CCC", Offset = "0x2260CCC", VA = "0x7BBCA60CCC")]
	public static void SetCurrentAccountID(string account_id)
	{
	}

	// Token: 0x0600036F RID: 879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036F")]
	[Address(RVA = "0x2260DF4", Offset = "0x2260DF4", VA = "0x7BBCA60DF4")]
	public static void PushEvent(string type, string data)
	{
	}

	// Token: 0x06000370 RID: 880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000370")]
	[Address(RVA = "0x2260F24", Offset = "0x2260F24", VA = "0x7BBCA60F24")]
	public static void SetCallBack(Action<bool> connected_callback, Action<bool> mic_callback)
	{
	}

	// Token: 0x06000371 RID: 881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000371")]
	[Address(RVA = "0x2261054", Offset = "0x2261054", VA = "0x7BBCA61054")]
	public static void StartVoiceDataSender()
	{
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000372")]
	[Address(RVA = "0x2261168", Offset = "0x2261168", VA = "0x7BBCA61168")]
	public static void StopVoiceDataSender()
	{
	}

	// Token: 0x06000373 RID: 883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000373")]
	[Address(RVA = "0x226127C", Offset = "0x226127C", VA = "0x7BBCA6127C")]
	public static void OnSceneLoaded()
	{
	}

	// Token: 0x06000374 RID: 884 RVA: 0x00002970 File Offset: 0x00000B70
	[Token(Token = "0x6000374")]
	[Address(RVA = "0x2261390", Offset = "0x2261390", VA = "0x7BBCA61390")]
	public static bool IsVoiceDataSenderRunning()
	{
		return default(bool);
	}

	// Token: 0x06000375 RID: 885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000375")]
	[Address(RVA = "0x22614A8", Offset = "0x22614A8", VA = "0x7BBCA614A8")]
	public static void StartCaptureUnityAudio()
	{
	}

	// Token: 0x06000376 RID: 886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000376")]
	[Address(RVA = "0x22615BC", Offset = "0x22615BC", VA = "0x7BBCA615BC")]
	public static void StopCaptureUnityAudio()
	{
	}

	// Token: 0x06000377 RID: 887 RVA: 0x00002988 File Offset: 0x00000B88
	[Token(Token = "0x6000377")]
	[Address(RVA = "0x22616D0", Offset = "0x22616D0", VA = "0x7BBCA616D0")]
	public static bool IsCapturingUnityAudio()
	{
		return default(bool);
	}

	// Token: 0x06000378 RID: 888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000378")]
	[Address(RVA = "0x22617E8", Offset = "0x22617E8", VA = "0x7BBCA617E8")]
	public static void RequestMic()
	{
	}

	// Token: 0x06000379 RID: 889 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000379")]
	[Address(RVA = "0x22618FC", Offset = "0x22618FC", VA = "0x7BBCA618FC")]
	public static void ReleaseMic()
	{
	}

	// Token: 0x0600037A RID: 890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037A")]
	[Address(RVA = "0x2261A10", Offset = "0x2261A10", VA = "0x7BBCA61A10")]
	public static void OnExternalAudioCaptureStart()
	{
	}

	// Token: 0x0600037B RID: 891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037B")]
	[Address(RVA = "0x2261B24", Offset = "0x2261B24", VA = "0x7BBCA61B24")]
	public static void OnExternalAudioCaptureStop()
	{
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037C")]
	[Address(RVA = "0x2261C38", Offset = "0x2261C38", VA = "0x7BBCA61C38")]
	public static void OnExternalAudioCaptured(byte[] sample, int channels, int sampleRate, Mambet.ExternalAudioChannel channel, int bytesPerSample)
	{
	}

	// Token: 0x04000346 RID: 838
	[Token(Token = "0x4000346")]
	[FieldOffset(Offset = "0x0")]
	private static ISparkInterface m_Impl;
}
