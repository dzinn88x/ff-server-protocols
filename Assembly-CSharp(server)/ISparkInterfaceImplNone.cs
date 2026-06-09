using System;
using GCommon;
using Il2CppDummyDll;

// Token: 0x020000CD RID: 205
[Token(Token = "0x20000CD")]
public class ISparkInterfaceImplNone : ISparkInterface
{
	// Token: 0x06000355 RID: 853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000355")]
	[Address(RVA = "0x24CAC14", Offset = "0x24CAC14", VA = "0x7BBCCCAC14", Slot = "10")]
	public void PushEvent(string type, string data)
	{
	}

	// Token: 0x06000356 RID: 854 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000356")]
	[Address(RVA = "0x24CAC18", Offset = "0x24CAC18", VA = "0x7BBCCCAC18", Slot = "9")]
	public void SetCurrentAccountID(string account_id)
	{
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x06000357 RID: 855 RVA: 0x00002910 File Offset: 0x00000B10
	// (set) Token: 0x06000358 RID: 856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700003F")]
	public bool DebugEvent
	{
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x24CAC1C", Offset = "0x24CAC1C", VA = "0x7BBCCCAC1C", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132A98", Offset = "0x1132A98")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x24CAC24", Offset = "0x24CAC24", VA = "0x7BBCCCAC24", Slot = "5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132AA8", Offset = "0x1132AA8")]
		set
		{
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x06000359 RID: 857 RVA: 0x00002928 File Offset: 0x00000B28
	// (set) Token: 0x0600035A RID: 858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000040")]
	public bool DebugVoice
	{
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x24CAC30", Offset = "0x24CAC30", VA = "0x7BBCCCAC30", Slot = "6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132AB8", Offset = "0x1132AB8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x24CAC38", Offset = "0x24CAC38", VA = "0x7BBCCCAC38", Slot = "7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132AC8", Offset = "0x1132AC8")]
		set
		{
		}
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035B")]
	[Address(RVA = "0x24CAC44", Offset = "0x24CAC44", VA = "0x7BBCCCAC44", Slot = "8")]
	public void Init(int game_id)
	{
	}

	// Token: 0x0600035C RID: 860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035C")]
	[Address(RVA = "0x24CAC48", Offset = "0x24CAC48", VA = "0x7BBCCCAC48", Slot = "11")]
	public void SetCallBack(Action<bool> connected_callback, Action<bool> mic_callback)
	{
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035D")]
	[Address(RVA = "0x24CAC4C", Offset = "0x24CAC4C", VA = "0x7BBCCCAC4C", Slot = "12")]
	public void StartVoiceDataSender()
	{
	}

	// Token: 0x0600035E RID: 862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035E")]
	[Address(RVA = "0x24CAC50", Offset = "0x24CAC50", VA = "0x7BBCCCAC50", Slot = "13")]
	public void StopVoiceDataSender()
	{
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600035F")]
	[Address(RVA = "0x24CAC54", Offset = "0x24CAC54", VA = "0x7BBCCCAC54", Slot = "14")]
	public void OnSceneLoaded()
	{
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00002940 File Offset: 0x00000B40
	[Token(Token = "0x6000360")]
	[Address(RVA = "0x24CAC58", Offset = "0x24CAC58", VA = "0x7BBCCCAC58", Slot = "18")]
	public bool IsCapturingUnityAudio()
	{
		return default(bool);
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000361")]
	[Address(RVA = "0x24CAC60", Offset = "0x24CAC60", VA = "0x7BBCCCAC60", Slot = "19")]
	public void RequestMic()
	{
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000362")]
	[Address(RVA = "0x24CAC64", Offset = "0x24CAC64", VA = "0x7BBCCCAC64", Slot = "20")]
	public void ReleaseMic()
	{
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000363")]
	[Address(RVA = "0x24CAC68", Offset = "0x24CAC68", VA = "0x7BBCCCAC68", Slot = "21")]
	public void OnExternalAudioCaptureStart()
	{
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000364")]
	[Address(RVA = "0x24CACC8", Offset = "0x24CACC8", VA = "0x7BBCCCACC8", Slot = "22")]
	public void OnExternalAudioCaptureStop()
	{
	}

	// Token: 0x06000365 RID: 869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000365")]
	[Address(RVA = "0x24CAD28", Offset = "0x24CAD28", VA = "0x7BBCCCAD28", Slot = "23")]
	public void OnExternalAudioCaptured(byte[] sample, int channels, int sampleRate, Mambet.ExternalAudioChannel channel, int bytesPerSample)
	{
	}

	// Token: 0x06000366 RID: 870 RVA: 0x00002958 File Offset: 0x00000B58
	[Token(Token = "0x6000366")]
	[Address(RVA = "0x24CAD2C", Offset = "0x24CAD2C", VA = "0x7BBCCCAD2C", Slot = "15")]
	public bool IsVoiceDataSenderRunning()
	{
		return default(bool);
	}

	// Token: 0x06000367 RID: 871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000367")]
	[Address(RVA = "0x24CAD34", Offset = "0x24CAD34", VA = "0x7BBCCCAD34", Slot = "16")]
	public void StartCaptureUnityAudio()
	{
	}

	// Token: 0x06000368 RID: 872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000368")]
	[Address(RVA = "0x24CAD38", Offset = "0x24CAD38", VA = "0x7BBCCCAD38", Slot = "17")]
	public void StopCaptureUnityAudio()
	{
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000369")]
	[Address(RVA = "0x24CAD3C", Offset = "0x24CAD3C", VA = "0x7BBCCCAD3C")]
	public ISparkInterfaceImplNone()
	{
	}

	// Token: 0x04000344 RID: 836
	[Token(Token = "0x4000344")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FFF7C", Offset = "0x10FFF7C")]
	private bool <DebugEvent>k__BackingField;

	// Token: 0x04000345 RID: 837
	[Token(Token = "0x4000345")]
	[FieldOffset(Offset = "0x11")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FFF8C", Offset = "0x10FFF8C")]
	private bool <DebugVoice>k__BackingField;
}
