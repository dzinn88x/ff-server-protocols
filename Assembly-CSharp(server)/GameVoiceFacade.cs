using System;
using Il2CppDummyDll;

// Token: 0x020000BB RID: 187
[Token(Token = "0x20000BB")]
public static class GameVoiceFacade
{
	// Token: 0x1700003A RID: 58
	// (get) Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700003A")]
	public static GameVoiceImpl_Youme Youme_impl
	{
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x224ADE4", Offset = "0x224ADE4", VA = "0x7BBCA4ADE4")]
		get
		{
			return null;
		}
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x224AF0C", Offset = "0x224AF0C", VA = "0x7BBCA4AF0C")]
	public static void SetImpl(IGameVoiceInterface impl)
	{
	}

	// Token: 0x060002F9 RID: 761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x224AFA0", Offset = "0x224AFA0", VA = "0x7BBCA4AFA0")]
	public static void SetGroupEnvironment(string environment)
	{
	}

	// Token: 0x060002FA RID: 762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x224B0C8", Offset = "0x224B0C8", VA = "0x7BBCA4B0C8")]
	public static void SetRegion(int region_id, string region_name)
	{
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00002790 File Offset: 0x00000990
	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x224B1F8", Offset = "0x224B1F8", VA = "0x7BBCA4B1F8")]
	public static int Init(string callBack_objectName)
	{
		return 0;
	}

	// Token: 0x060002FC RID: 764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x224B324", Offset = "0x224B324", VA = "0x7BBCA4B324")]
	public static void OnInited()
	{
	}

	// Token: 0x060002FD RID: 765 RVA: 0x000027A8 File Offset: 0x000009A8
	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x224B438", Offset = "0x224B438", VA = "0x7BBCA4B438")]
	public static int JoinRoom(RoomInfo info)
	{
		return 0;
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x224B564", Offset = "0x224B564", VA = "0x7BBCA4B564")]
	public static void OnJoined(string room_id)
	{
	}

	// Token: 0x060002FF RID: 767 RVA: 0x000027C0 File Offset: 0x000009C0
	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x224B68C", Offset = "0x224B68C", VA = "0x7BBCA4B68C")]
	public static int LeaveRoom()
	{
		return 0;
	}

	// Token: 0x06000300 RID: 768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000300")]
	[Address(RVA = "0x224B7A4", Offset = "0x224B7A4", VA = "0x7BBCA4B7A4")]
	public static void PauseChannel(bool is_pause)
	{
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000301")]
	[Address(RVA = "0x224B8CC", Offset = "0x224B8CC", VA = "0x7BBCA4B8CC")]
	public static void SetMidCallback()
	{
	}

	// Token: 0x06000302 RID: 770 RVA: 0x000027D8 File Offset: 0x000009D8
	[Token(Token = "0x6000302")]
	[Address(RVA = "0x224B9E0", Offset = "0x224B9E0", VA = "0x7BBCA4B9E0")]
	public static int UnInit()
	{
		return 0;
	}

	// Token: 0x06000303 RID: 771 RVA: 0x000027F0 File Offset: 0x000009F0
	[Token(Token = "0x6000303")]
	[Address(RVA = "0x224BAF8", Offset = "0x224BAF8", VA = "0x7BBCA4BAF8")]
	public static bool HasError(int error_code)
	{
		return default(bool);
	}

	// Token: 0x06000304 RID: 772 RVA: 0x00002808 File Offset: 0x00000A08
	[Token(Token = "0x6000304")]
	[Address(RVA = "0x224BC24", Offset = "0x224BC24", VA = "0x7BBCA4BC24")]
	public static EGameVoiceEvent ParseEventType(int event_id)
	{
		return EGameVoiceEvent.None;
	}

	// Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000305")]
	[Address(RVA = "0x224BD50", Offset = "0x224BD50", VA = "0x7BBCA4BD50")]
	public static string ParseEventName(int event_id)
	{
		return null;
	}

	// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000306")]
	[Address(RVA = "0x224BE84", Offset = "0x224BE84", VA = "0x7BBCA4BE84")]
	public static string ParseErrorCodeName(int error_code)
	{
		return null;
	}

	// Token: 0x06000307 RID: 775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000307")]
	[Address(RVA = "0x224BFB8", Offset = "0x224BFB8", VA = "0x7BBCA4BFB8")]
	public static void SetVolume(uint volume)
	{
	}

	// Token: 0x06000308 RID: 776 RVA: 0x00002820 File Offset: 0x00000A20
	[Token(Token = "0x6000308")]
	[Address(RVA = "0x224C0E0", Offset = "0x224C0E0", VA = "0x7BBCA4C0E0")]
	public static bool IsSameWithCurMicMute(bool value)
	{
		return default(bool);
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00002838 File Offset: 0x00000A38
	[Token(Token = "0x6000309")]
	[Address(RVA = "0x224C208", Offset = "0x224C208", VA = "0x7BBCA4C208")]
	public static bool IsSameWithCurSpeakerMute(bool value)
	{
		return default(bool);
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030A")]
	[Address(RVA = "0x224C334", Offset = "0x224C334", VA = "0x7BBCA4C334")]
	public static void SetMicAndSpeakerMute(bool micro_mute, bool speaker_mute)
	{
	}

	// Token: 0x0600030B RID: 779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030B")]
	[Address(RVA = "0x224C630", Offset = "0x224C630", VA = "0x7BBCA4C630")]
	public static void OnUpdate()
	{
	}

	// Token: 0x0600030C RID: 780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600030C")]
	[Address(RVA = "0x224C744", Offset = "0x224C744", VA = "0x7BBCA4C744")]
	public static void EnableVoiceCaptureCallBack(bool enable)
	{
	}

	// Token: 0x0600030D RID: 781 RVA: 0x00002850 File Offset: 0x00000A50
	[Token(Token = "0x600030D")]
	[Address(RVA = "0x224C86C", Offset = "0x224C86C", VA = "0x7BBCA4C86C")]
	public static int MuteTargetPlayer(string player_id, bool is_mute)
	{
		return 0;
	}

	// Token: 0x040002F4 RID: 756
	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x0")]
	private static IGameVoiceInterface m_Impl;

	// Token: 0x040002F5 RID: 757
	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x8")]
	private static GameVoiceImpl_Youme m_YoumeImpl;
}
