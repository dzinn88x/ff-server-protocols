using System;
using Il2CppDummyDll;

// Token: 0x020000B8 RID: 184
[Token(Token = "0x20000B8")]
public class GameVoiceImplNone : IGameVoiceInterface
{
	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060002C6 RID: 710 RVA: 0x000025C8 File Offset: 0x000007C8
	// (set) Token: 0x060002C7 RID: 711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000035")]
	public bool MicrophoneMute
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x224CA18", Offset = "0x224CA18", VA = "0x7BBCA4CA18", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132A18", Offset = "0x1132A18")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x224CA20", Offset = "0x224CA20", VA = "0x7BBCA4CA20", Slot = "5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132A28", Offset = "0x1132A28")]
		set
		{
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060002C8 RID: 712 RVA: 0x000025E0 File Offset: 0x000007E0
	// (set) Token: 0x060002C9 RID: 713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000036")]
	public bool SpeakerMute
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x224CA2C", Offset = "0x224CA2C", VA = "0x7BBCA4CA2C", Slot = "6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132A38", Offset = "0x1132A38")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x224CA34", Offset = "0x224CA34", VA = "0x7BBCA4CA34", Slot = "7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132A48", Offset = "0x1132A48")]
		set
		{
		}
	}

	// Token: 0x060002CA RID: 714 RVA: 0x000025F8 File Offset: 0x000007F8
	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x224CA40", Offset = "0x224CA40", VA = "0x7BBCA4CA40", Slot = "9")]
	public int Init(string callBack_object)
	{
		return 0;
	}

	// Token: 0x060002CB RID: 715 RVA: 0x00002610 File Offset: 0x00000810
	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x224CA48", Offset = "0x224CA48", VA = "0x7BBCA4CA48", Slot = "10")]
	public int JoinRoom(RoomInfo info)
	{
		return 0;
	}

	// Token: 0x060002CC RID: 716 RVA: 0x00002628 File Offset: 0x00000828
	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x224CA50", Offset = "0x224CA50", VA = "0x7BBCA4CA50", Slot = "11")]
	public int LeaveRoom()
	{
		return 0;
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x224CA58", Offset = "0x224CA58", VA = "0x7BBCA4CA58", Slot = "8")]
	public void SetRegion(int region_id, string region_name)
	{
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00002640 File Offset: 0x00000840
	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x224CA5C", Offset = "0x224CA5C", VA = "0x7BBCA4CA5C", Slot = "15")]
	public bool HasError(int error_code)
	{
		return default(bool);
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x224CA64", Offset = "0x224CA64", VA = "0x7BBCA4CA64", Slot = "16")]
	public void SetVolume(uint volume)
	{
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x224CA68", Offset = "0x224CA68", VA = "0x7BBCA4CA68", Slot = "17")]
	public void PauseChannel(bool is_pause)
	{
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x224CA6C", Offset = "0x224CA6C", VA = "0x7BBCA4CA6C", Slot = "18")]
	public void SetMidCallback()
	{
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x00002658 File Offset: 0x00000858
	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x224CA70", Offset = "0x224CA70", VA = "0x7BBCA4CA70", Slot = "19")]
	public int UnInit()
	{
		return 0;
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x00002670 File Offset: 0x00000870
	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x224CA78", Offset = "0x224CA78", VA = "0x7BBCA4CA78", Slot = "12")]
	public EGameVoiceEvent ParseEventType(int event_id)
	{
		return EGameVoiceEvent.None;
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x224CA80", Offset = "0x224CA80", VA = "0x7BBCA4CA80", Slot = "20")]
	public void OnInited()
	{
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x224CA84", Offset = "0x224CA84", VA = "0x7BBCA4CA84", Slot = "21")]
	public void OnJoined(string room_id)
	{
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x224CA88", Offset = "0x224CA88", VA = "0x7BBCA4CA88", Slot = "13")]
	public string ParseEventName(int event_id)
	{
		return null;
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x224CAD0", Offset = "0x224CAD0", VA = "0x7BBCA4CAD0", Slot = "14")]
	public string ParseErrorCodeName(int error_code)
	{
		return null;
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x224CB18", Offset = "0x224CB18", VA = "0x7BBCA4CB18", Slot = "22")]
	public void OnUpdate()
	{
	}

	// Token: 0x060002D9 RID: 729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x224CB1C", Offset = "0x224CB1C", VA = "0x7BBCA4CB1C", Slot = "23")]
	public void SetGroupEnvironment(string environment)
	{
	}

	// Token: 0x060002DA RID: 730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x224CB20", Offset = "0x224CB20", VA = "0x7BBCA4CB20", Slot = "24")]
	public void EnableVoiceCaptureCallBack(bool enable)
	{
	}

	// Token: 0x060002DB RID: 731 RVA: 0x00002688 File Offset: 0x00000888
	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x224CB24", Offset = "0x224CB24", VA = "0x7BBCA4CB24", Slot = "25")]
	public int MuteTargetPlayer(string player_id, bool is_mute)
	{
		return 0;
	}

	// Token: 0x060002DC RID: 732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x224AF98", Offset = "0x224AF98", VA = "0x7BBCA4AF98")]
	public GameVoiceImplNone()
	{
	}

	// Token: 0x040002EA RID: 746
	[Token(Token = "0x40002EA")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FFDDC", Offset = "0x10FFDDC")]
	private bool <MicrophoneMute>k__BackingField;

	// Token: 0x040002EB RID: 747
	[Token(Token = "0x40002EB")]
	[FieldOffset(Offset = "0x11")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FFDEC", Offset = "0x10FFDEC")]
	private bool <SpeakerMute>k__BackingField;
}
