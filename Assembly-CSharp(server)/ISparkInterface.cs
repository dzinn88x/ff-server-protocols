using System;
using GCommon;
using Il2CppDummyDll;

// Token: 0x020000CB RID: 203
[Token(Token = "0x20000CB")]
public interface ISparkInterface
{
	// Token: 0x1700003B RID: 59
	// (get) Token: 0x06000329 RID: 809
	// (set) Token: 0x0600032A RID: 810
	[Token(Token = "0x1700003B")]
	bool DebugEvent { [Token(Token = "0x6000329")] get; [Token(Token = "0x600032A")] set; }

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x0600032B RID: 811
	// (set) Token: 0x0600032C RID: 812
	[Token(Token = "0x1700003C")]
	bool DebugVoice { [Token(Token = "0x600032B")] get; [Token(Token = "0x600032C")] set; }

	// Token: 0x0600032D RID: 813
	[Token(Token = "0x600032D")]
	void Init(int game_id);

	// Token: 0x0600032E RID: 814
	[Token(Token = "0x600032E")]
	void SetCurrentAccountID(string account_id);

	// Token: 0x0600032F RID: 815
	[Token(Token = "0x600032F")]
	void PushEvent(string type, string data);

	// Token: 0x06000330 RID: 816
	[Token(Token = "0x6000330")]
	void SetCallBack(Action<bool> connected_callback, Action<bool> mic_callback);

	// Token: 0x06000331 RID: 817
	[Token(Token = "0x6000331")]
	void StartVoiceDataSender();

	// Token: 0x06000332 RID: 818
	[Token(Token = "0x6000332")]
	void StopVoiceDataSender();

	// Token: 0x06000333 RID: 819
	[Token(Token = "0x6000333")]
	void OnSceneLoaded();

	// Token: 0x06000334 RID: 820
	[Token(Token = "0x6000334")]
	bool IsVoiceDataSenderRunning();

	// Token: 0x06000335 RID: 821
	[Token(Token = "0x6000335")]
	void StartCaptureUnityAudio();

	// Token: 0x06000336 RID: 822
	[Token(Token = "0x6000336")]
	void StopCaptureUnityAudio();

	// Token: 0x06000337 RID: 823
	[Token(Token = "0x6000337")]
	bool IsCapturingUnityAudio();

	// Token: 0x06000338 RID: 824
	[Token(Token = "0x6000338")]
	void RequestMic();

	// Token: 0x06000339 RID: 825
	[Token(Token = "0x6000339")]
	void ReleaseMic();

	// Token: 0x0600033A RID: 826
	[Token(Token = "0x600033A")]
	void OnExternalAudioCaptureStart();

	// Token: 0x0600033B RID: 827
	[Token(Token = "0x600033B")]
	void OnExternalAudioCaptureStop();

	// Token: 0x0600033C RID: 828
	[Token(Token = "0x600033C")]
	void OnExternalAudioCaptured(byte[] sample, int channels, int sampleRate, Mambet.ExternalAudioChannel channel, int bytesPerSample);
}
