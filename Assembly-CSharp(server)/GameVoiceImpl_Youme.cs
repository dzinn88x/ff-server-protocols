using System;
using Il2CppDummyDll;
using YouMe;

// Token: 0x020000B9 RID: 185
[Token(Token = "0x20000B9")]
public class GameVoiceImpl_Youme : IGameVoiceInterface
{
	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060002DD RID: 733 RVA: 0x000026A0 File Offset: 0x000008A0
	[Token(Token = "0x17000037")]
	public YOUME_RTC_SERVER_REGION RegionID
	{
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x224CB2C", Offset = "0x224CB2C", VA = "0x7BBCA4CB2C")]
		get
		{
			return YOUME_RTC_SERVER_REGION.RTC_CN_SERVER;
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x060002DE RID: 734 RVA: 0x000026B8 File Offset: 0x000008B8
	// (set) Token: 0x060002DF RID: 735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000038")]
	public bool MicrophoneMute
	{
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x224CCF8", Offset = "0x224CCF8", VA = "0x7BBCA4CCF8", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x224CD70", Offset = "0x224CD70", VA = "0x7BBCA4CD70", Slot = "5")]
		set
		{
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060002E0 RID: 736 RVA: 0x000026D0 File Offset: 0x000008D0
	// (set) Token: 0x060002E1 RID: 737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000039")]
	public bool SpeakerMute
	{
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x224CDF0", Offset = "0x224CDF0", VA = "0x7BBCA4CDF0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x224CE68", Offset = "0x224CE68", VA = "0x7BBCA4CE68", Slot = "7")]
		set
		{
		}
	}

	// Token: 0x060002E2 RID: 738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x224CF44", Offset = "0x224CF44", VA = "0x7BBCA4CF44", Slot = "8")]
	public void SetRegion(int region_id, string region_name)
	{
	}

	// Token: 0x060002E3 RID: 739 RVA: 0x000026E8 File Offset: 0x000008E8
	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x224CF50", Offset = "0x224CF50", VA = "0x7BBCA4CF50", Slot = "9")]
	public int Init(string callBack_objectName)
	{
		return 0;
	}

	// Token: 0x060002E4 RID: 740 RVA: 0x00002700 File Offset: 0x00000900
	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x224D0DC", Offset = "0x224D0DC", VA = "0x7BBCA4D0DC", Slot = "10")]
	public int JoinRoom(RoomInfo info)
	{
		return 0;
	}

	// Token: 0x060002E5 RID: 741 RVA: 0x00002718 File Offset: 0x00000918
	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x224D19C", Offset = "0x224D19C", VA = "0x7BBCA4D19C", Slot = "11")]
	public int LeaveRoom()
	{
		return 0;
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x00002730 File Offset: 0x00000930
	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x224D214", Offset = "0x224D214", VA = "0x7BBCA4D214", Slot = "15")]
	public bool HasError(int error_code)
	{
		return default(bool);
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x224D220", Offset = "0x224D220", VA = "0x7BBCA4D220", Slot = "16")]
	public void SetVolume(uint volume)
	{
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x224D2A0", Offset = "0x224D2A0", VA = "0x7BBCA4D2A0", Slot = "17")]
	public void PauseChannel(bool is_pause)
	{
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x224D358", Offset = "0x224D358", VA = "0x7BBCA4D358", Slot = "18")]
	public void SetMidCallback()
	{
	}

	// Token: 0x060002EA RID: 746 RVA: 0x00002748 File Offset: 0x00000948
	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x224D3D4", Offset = "0x224D3D4", VA = "0x7BBCA4D3D4", Slot = "19")]
	public int UnInit()
	{
		return 0;
	}

	// Token: 0x060002EB RID: 747 RVA: 0x00002760 File Offset: 0x00000960
	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x224D44C", Offset = "0x224D44C", VA = "0x7BBCA4D44C", Slot = "12")]
	public EGameVoiceEvent ParseEventType(int event_id)
	{
		return EGameVoiceEvent.None;
	}

	// Token: 0x060002EC RID: 748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x224D46C", Offset = "0x224D46C", VA = "0x7BBCA4D46C", Slot = "20")]
	public void OnInited()
	{
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x224D590", Offset = "0x224D590", VA = "0x7BBCA4D590", Slot = "21")]
	public void OnJoined(string room_id)
	{
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x224D818", Offset = "0x224D818", VA = "0x7BBCA4D818", Slot = "24")]
	public void EnableVoiceCaptureCallBack(bool enable)
	{
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x224DA18", Offset = "0x224DA18", VA = "0x7BBCA4DA18")]
	private void OnPcmCallBack(YouMeVoiceAPI.YoumePcmCallbackData data)
	{
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x224DAA8", Offset = "0x224DAA8", VA = "0x7BBCA4DAA8")]
	private void OnPcmCallBack_Empty(YouMeVoiceAPI.YoumePcmCallbackData data)
	{
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x224DAAC", Offset = "0x224DAAC", VA = "0x7BBCA4DAAC", Slot = "13")]
	public string ParseEventName(int event_id)
	{
		return null;
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x224DB44", Offset = "0x224DB44", VA = "0x7BBCA4DB44", Slot = "14")]
	public string ParseErrorCodeName(int error_code)
	{
		return null;
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x224DBDC", Offset = "0x224DBDC", VA = "0x7BBCA4DBDC", Slot = "23")]
	public void SetGroupEnvironment(string environment)
	{
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x224DBE0", Offset = "0x224DBE0", VA = "0x7BBCA4DBE0", Slot = "22")]
	public void OnUpdate()
	{
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x00002778 File Offset: 0x00000978
	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x224DBE4", Offset = "0x224DBE4", VA = "0x7BBCA4DBE4", Slot = "25")]
	public int MuteTargetPlayer(string player_id, bool is_mute)
	{
		return 0;
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x224AEAC", Offset = "0x224AEAC", VA = "0x7BBCA4AEAC")]
	public GameVoiceImpl_Youme()
	{
	}

	// Token: 0x040002EC RID: 748
	[Token(Token = "0x40002EC")]
	private const string AppKey = "YOUME2F97A1D227B4375ADE03CFFFB617B2209C8B0AE1";

	// Token: 0x040002ED RID: 749
	[Token(Token = "0x40002ED")]
	private const string AppSecret = "rNbymcpQS0C/Vp+69PmovlQ8lJtBeHZBNaiD5nJLwP2zsCxLFrDtqoEqerq1Wbg3rVgjSJbuEKP0yqLBa6Djy5HnB3E5XCXSUfY6TQm1rtQOl7oBhrw0MvXmKfynz9UxjR7Hfv4QvXmyAbBbem/VBMTJWQ0qe7n3Xs23yzqRzeMBAAE=";

	// Token: 0x040002EE RID: 750
	[Token(Token = "0x40002EE")]
	[FieldOffset(Offset = "0x10")]
	private int RegionIDNum;

	// Token: 0x040002EF RID: 751
	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0x18")]
	private string ExtServerRegionName;

	// Token: 0x040002F0 RID: 752
	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x20")]
	private bool HaveEnabledPCM;
}
