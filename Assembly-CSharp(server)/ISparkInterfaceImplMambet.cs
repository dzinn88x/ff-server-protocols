using System;
using GCommon;
using Il2CppDummyDll;

// Token: 0x020000CC RID: 204
[Token(Token = "0x20000CC")]
public class ISparkInterfaceImplMambet : ISparkInterface
{
	// Token: 0x0600033D RID: 829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033D")]
	[Address(RVA = "0x24C9F88", Offset = "0x24C9F88", VA = "0x7BBCCC9F88")]
	public ISparkInterfaceImplMambet()
	{
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033E")]
	[Address(RVA = "0x24C9FE0", Offset = "0x24C9FE0", VA = "0x7BBCCC9FE0")]
	private static void Log(string log)
	{
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033F")]
	[Address(RVA = "0x24CA048", Offset = "0x24CA048", VA = "0x7BBCCCA048")]
	private static void LogVerbose(string log)
	{
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06000340 RID: 832 RVA: 0x000028B0 File Offset: 0x00000AB0
	// (set) Token: 0x06000341 RID: 833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700003D")]
	public bool DebugEvent
	{
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x24CA0C4", Offset = "0x24CA0C4", VA = "0x7BBCCCA0C4", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132A58", Offset = "0x1132A58")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x24CA0CC", Offset = "0x24CA0CC", VA = "0x7BBCCCA0CC", Slot = "5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132A68", Offset = "0x1132A68")]
		set
		{
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000342 RID: 834 RVA: 0x000028C8 File Offset: 0x00000AC8
	// (set) Token: 0x06000343 RID: 835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700003E")]
	public bool DebugVoice
	{
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x24CA0D8", Offset = "0x24CA0D8", VA = "0x7BBCCCA0D8", Slot = "6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132A78", Offset = "0x1132A78")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x24CA0E0", Offset = "0x24CA0E0", VA = "0x7BBCCCA0E0", Slot = "7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132A88", Offset = "0x1132A88")]
		set
		{
		}
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000344")]
	[Address(RVA = "0x24CA0EC", Offset = "0x24CA0EC", VA = "0x7BBCCCA0EC", Slot = "8")]
	public void Init(int game_id)
	{
	}

	// Token: 0x06000345 RID: 837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000345")]
	[Address(RVA = "0x24CA1DC", Offset = "0x24CA1DC", VA = "0x7BBCCCA1DC", Slot = "10")]
	public void PushEvent(string type, string data)
	{
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000346")]
	[Address(RVA = "0x24CA254", Offset = "0x24CA254", VA = "0x7BBCCCA254", Slot = "9")]
	public void SetCurrentAccountID(string account_id)
	{
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000347")]
	[Address(RVA = "0x24CA2E8", Offset = "0x24CA2E8", VA = "0x7BBCCCA2E8", Slot = "11")]
	public void SetCallBack(Action<bool> connected_callback, Action<bool> mic_callback)
	{
	}

	// Token: 0x06000348 RID: 840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000348")]
	[Address(RVA = "0x24CA468", Offset = "0x24CA468", VA = "0x7BBCCCA468", Slot = "12")]
	public void StartVoiceDataSender()
	{
	}

	// Token: 0x06000349 RID: 841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000349")]
	[Address(RVA = "0x24CA518", Offset = "0x24CA518", VA = "0x7BBCCCA518", Slot = "13")]
	public void StopVoiceDataSender()
	{
	}

	// Token: 0x0600034A RID: 842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034A")]
	[Address(RVA = "0x24CA588", Offset = "0x24CA588", VA = "0x7BBCCCA588", Slot = "14")]
	public void OnSceneLoaded()
	{
	}

	// Token: 0x0600034B RID: 843 RVA: 0x000028E0 File Offset: 0x00000AE0
	[Token(Token = "0x600034B")]
	[Address(RVA = "0x24CA5E8", Offset = "0x24CA5E8", VA = "0x7BBCCCA5E8", Slot = "18")]
	public bool IsCapturingUnityAudio()
	{
		return default(bool);
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034C")]
	[Address(RVA = "0x24CA648", Offset = "0x24CA648", VA = "0x7BBCCCA648", Slot = "19")]
	public void RequestMic()
	{
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034D")]
	[Address(RVA = "0x24CA6B8", Offset = "0x24CA6B8", VA = "0x7BBCCCA6B8", Slot = "20")]
	public void ReleaseMic()
	{
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034E")]
	[Address(RVA = "0x24CA728", Offset = "0x24CA728", VA = "0x7BBCCCA728", Slot = "21")]
	public void OnExternalAudioCaptureStart()
	{
	}

	// Token: 0x0600034F RID: 847 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600034F")]
	[Address(RVA = "0x24CA798", Offset = "0x24CA798", VA = "0x7BBCCCA798", Slot = "22")]
	public void OnExternalAudioCaptureStop()
	{
	}

	// Token: 0x06000350 RID: 848 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000350")]
	[Address(RVA = "0x24CA808", Offset = "0x24CA808", VA = "0x7BBCCCA808")]
	private void OnUnityAudioCaptureCall(int calls)
	{
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000351")]
	[Address(RVA = "0x24CA92C", Offset = "0x24CA92C", VA = "0x7BBCCCA92C", Slot = "23")]
	public void OnExternalAudioCaptured(byte[] sample, int channels, int sampleRate, Mambet.ExternalAudioChannel channel, int bytesPerSample)
	{
	}

	// Token: 0x06000352 RID: 850 RVA: 0x000028F8 File Offset: 0x00000AF8
	[Token(Token = "0x6000352")]
	[Address(RVA = "0x24CAAD4", Offset = "0x24CAAD4", VA = "0x7BBCCCAAD4", Slot = "15")]
	public bool IsVoiceDataSenderRunning()
	{
		return default(bool);
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000353")]
	[Address(RVA = "0x24CAB34", Offset = "0x24CAB34", VA = "0x7BBCCCAB34", Slot = "16")]
	public void StartCaptureUnityAudio()
	{
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000354")]
	[Address(RVA = "0x24CABA4", Offset = "0x24CABA4", VA = "0x7BBCCCABA4", Slot = "17")]
	public void StopCaptureUnityAudio()
	{
	}

	// Token: 0x04000342 RID: 834
	[Token(Token = "0x4000342")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FFF5C", Offset = "0x10FFF5C")]
	private bool <DebugEvent>k__BackingField;

	// Token: 0x04000343 RID: 835
	[Token(Token = "0x4000343")]
	[FieldOffset(Offset = "0x11")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FFF6C", Offset = "0x10FFF6C")]
	private bool <DebugVoice>k__BackingField;
}
