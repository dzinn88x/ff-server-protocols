using System;
using Il2CppDummyDll;

// Token: 0x020000B7 RID: 183
[Token(Token = "0x20000B7")]
public interface IGameVoiceInterface
{
	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060002B0 RID: 688
	// (set) Token: 0x060002B1 RID: 689
	[Token(Token = "0x17000033")]
	bool MicrophoneMute { [Token(Token = "0x60002B0")] get; [Token(Token = "0x60002B1")] set; }

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060002B2 RID: 690
	// (set) Token: 0x060002B3 RID: 691
	[Token(Token = "0x17000034")]
	bool SpeakerMute { [Token(Token = "0x60002B2")] get; [Token(Token = "0x60002B3")] set; }

	// Token: 0x060002B4 RID: 692
	[Token(Token = "0x60002B4")]
	void SetRegion(int region_id, string region_name);

	// Token: 0x060002B5 RID: 693
	[Token(Token = "0x60002B5")]
	int Init(string callBack_object);

	// Token: 0x060002B6 RID: 694
	[Token(Token = "0x60002B6")]
	int JoinRoom(RoomInfo info);

	// Token: 0x060002B7 RID: 695
	[Token(Token = "0x60002B7")]
	int LeaveRoom();

	// Token: 0x060002B8 RID: 696
	[Token(Token = "0x60002B8")]
	EGameVoiceEvent ParseEventType(int event_id);

	// Token: 0x060002B9 RID: 697
	[Token(Token = "0x60002B9")]
	string ParseEventName(int event_id);

	// Token: 0x060002BA RID: 698
	[Token(Token = "0x60002BA")]
	string ParseErrorCodeName(int error_code);

	// Token: 0x060002BB RID: 699
	[Token(Token = "0x60002BB")]
	bool HasError(int error_code);

	// Token: 0x060002BC RID: 700
	[Token(Token = "0x60002BC")]
	void SetVolume(uint volume);

	// Token: 0x060002BD RID: 701
	[Token(Token = "0x60002BD")]
	void PauseChannel(bool is_pause);

	// Token: 0x060002BE RID: 702
	[Token(Token = "0x60002BE")]
	void SetMidCallback();

	// Token: 0x060002BF RID: 703
	[Token(Token = "0x60002BF")]
	int UnInit();

	// Token: 0x060002C0 RID: 704
	[Token(Token = "0x60002C0")]
	void OnInited();

	// Token: 0x060002C1 RID: 705
	[Token(Token = "0x60002C1")]
	void OnJoined(string room_id);

	// Token: 0x060002C2 RID: 706
	[Token(Token = "0x60002C2")]
	void OnUpdate();

	// Token: 0x060002C3 RID: 707
	[Token(Token = "0x60002C3")]
	void SetGroupEnvironment(string environment);

	// Token: 0x060002C4 RID: 708
	[Token(Token = "0x60002C4")]
	void EnableVoiceCaptureCallBack(bool enable);

	// Token: 0x060002C5 RID: 709
	[Token(Token = "0x60002C5")]
	int MuteTargetPlayer(string player_id, bool is_mute);
}
