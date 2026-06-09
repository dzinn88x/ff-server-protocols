using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020012BE RID: 4798
	[Token(Token = "0x20012BE")]
	public class GameVoiceEngine : MonoBehaviour
	{
		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06004B44 RID: 19268 RVA: 0x000169E0 File Offset: 0x00014BE0
		[Token(Token = "0x17000847")]
		public bool Inited
		{
			[Token(Token = "0x6004B44")]
			[Address(RVA = "0x1B77608", Offset = "0x1B77608", VA = "0x7BBC377608")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06004B45 RID: 19269 RVA: 0x000169F8 File Offset: 0x00014BF8
		// (set) Token: 0x06004B46 RID: 19270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000848")]
		public bool IsMicroPhoneMute
		{
			[Token(Token = "0x6004B45")]
			[Address(RVA = "0x1B7762C", Offset = "0x1B7762C", VA = "0x7BBC37762C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B46")]
			[Address(RVA = "0x1B77634", Offset = "0x1B77634", VA = "0x7BBC377634")]
			set
			{
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06004B47 RID: 19271 RVA: 0x00016A10 File Offset: 0x00014C10
		// (set) Token: 0x06004B48 RID: 19272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000849")]
		public bool IsSpeakerMute
		{
			[Token(Token = "0x6004B47")]
			[Address(RVA = "0x1B77734", Offset = "0x1B77734", VA = "0x7BBC377734")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B48")]
			[Address(RVA = "0x1B7773C", Offset = "0x1B7773C", VA = "0x7BBC37773C")]
			set
			{
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06004B49 RID: 19273 RVA: 0x00016A28 File Offset: 0x00014C28
		// (set) Token: 0x06004B4A RID: 19274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700084A")]
		public uint GameVoiceVolume
		{
			[Token(Token = "0x6004B49")]
			[Address(RVA = "0x1B77748", Offset = "0x1B77748", VA = "0x7BBC377748")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6004B4A")]
			[Address(RVA = "0x1B77750", Offset = "0x1B77750", VA = "0x7BBC377750")]
			set
			{
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06004B4B RID: 19275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084B")]
		public static GameVoiceEngine Instance
		{
			[Token(Token = "0x6004B4B")]
			[Address(RVA = "0x1B77848", Offset = "0x1B77848", VA = "0x7BBC377848")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06004B4C RID: 19276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700084C")]
		public RoomInfo CurrentRoomInfo
		{
			[Token(Token = "0x6004B4C")]
			[Address(RVA = "0x1B779E0", Offset = "0x1B779E0", VA = "0x7BBC3779E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4D")]
		[Address(RVA = "0x1B779E8", Offset = "0x1B779E8", VA = "0x7BBC3779E8")]
		public void InitEngine()
		{
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4E")]
		[Address(RVA = "0x1B77DA0", Offset = "0x1B77DA0", VA = "0x7BBC377DA0")]
		public void JoinRoom(string roomID, string playerID, string tag = "")
		{
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4F")]
		[Address(RVA = "0x1B78208", Offset = "0x1B78208", VA = "0x7BBC378208")]
		private void JoinRoom(RoomInfo joinRequest)
		{
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B50")]
		[Address(RVA = "0x1B77F94", Offset = "0x1B77F94", VA = "0x7BBC377F94")]
		public void LeaveRoom(bool no_clear_lastJoin = false, string tag = "")
		{
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B51")]
		[Address(RVA = "0x1B7882C", Offset = "0x1B7882C", VA = "0x7BBC37882C")]
		private void JoinLastRequest()
		{
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B52")]
		[Address(RVA = "0x1B7858C", Offset = "0x1B7858C", VA = "0x7BBC37858C")]
		private void RetryJoinRoomLater(string roomID)
		{
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B53")]
		[Address(RVA = "0x1B77B94", Offset = "0x1B77B94", VA = "0x7BBC377B94")]
		private void RetryInitLater()
		{
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B54")]
		[Address(RVA = "0x1B78874", Offset = "0x1B78874", VA = "0x7BBC378874")]
		private void OnEvent(string strParam)
		{
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B55")]
		[Address(RVA = "0x1B7A584", Offset = "0x1B7A584", VA = "0x7BBC37A584")]
		private void OnMemberChange(string strParam)
		{
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B56")]
		[Address(RVA = "0x1B789E4", Offset = "0x1B789E4", VA = "0x7BBC3789E4")]
		public void OnEvent(int event_id, int errorCode, string channelID, string param)
		{
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B57")]
		[Address(RVA = "0x1B7A744", Offset = "0x1B7A744", VA = "0x7BBC37A744")]
		private void SetPlayerVadFlag(string player_id, bool flag)
		{
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x00016A40 File Offset: 0x00014C40
		[Token(Token = "0x6004B58")]
		[Address(RVA = "0x1B7A92C", Offset = "0x1B7A92C", VA = "0x7BBC37A92C")]
		public bool GetPlayerVadFlag(string player_id)
		{
			return default(bool);
		}

		// Token: 0x06004B59 RID: 19289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B59")]
		[Address(RVA = "0x1B7A9AC", Offset = "0x1B7A9AC", VA = "0x7BBC37A9AC")]
		public void MuteTargetPlayer(string player_id, bool is_mute)
		{
		}

		// Token: 0x06004B5A RID: 19290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5A")]
		[Address(RVA = "0x1B7AAC8", Offset = "0x1B7AAC8", VA = "0x7BBC37AAC8")]
		private void SetPlayerMuteFlag(string player_id, bool is_mute)
		{
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x00016A58 File Offset: 0x00014C58
		[Token(Token = "0x6004B5B")]
		[Address(RVA = "0x1B7ACA8", Offset = "0x1B7ACA8", VA = "0x7BBC37ACA8")]
		public bool GetPlayerMuteFlag(string player_id)
		{
			return default(bool);
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5C")]
		[Address(RVA = "0x1B7AD58", Offset = "0x1B7AD58", VA = "0x7BBC37AD58")]
		private void Update()
		{
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5D")]
		[Address(RVA = "0x1B7AFC4", Offset = "0x1B7AFC4", VA = "0x7BBC37AFC4")]
		private void OnChannelResumed()
		{
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5E")]
		[Address(RVA = "0x1B7AFD0", Offset = "0x1B7AFD0", VA = "0x7BBC37AFD0")]
		private void SetMicAndSpeakerMute()
		{
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5F")]
		[Address(RVA = "0x1B7B1B4", Offset = "0x1B7B1B4", VA = "0x7BBC37B1B4")]
		public void OnMembetMicReleased()
		{
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B60")]
		[Address(RVA = "0x1B77640", Offset = "0x1B77640", VA = "0x7BBC377640")]
		private void CheckMicAndSpeakerState()
		{
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B61")]
		[Address(RVA = "0x1B7B120", Offset = "0x1B7B120", VA = "0x7BBC37B120")]
		public void RefreshVoiceCaptureEnabled(bool enable)
		{
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B62")]
		[Address(RVA = "0x1B7B24C", Offset = "0x1B7B24C", VA = "0x7BBC37B24C")]
		private void OnApplicationPause(bool pause)
		{
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B63")]
		[Address(RVA = "0x1B7B320", Offset = "0x1B7B320", VA = "0x7BBC37B320")]
		public void DestroyGameVoiceEngine()
		{
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B64")]
		[Address(RVA = "0x1B7B3D8", Offset = "0x1B7B3D8", VA = "0x7BBC37B3D8")]
		private void OnApplicationQuit()
		{
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B65")]
		[Address(RVA = "0x1B7B438", Offset = "0x1B7B438", VA = "0x7BBC37B438")]
		public GameVoiceEngine()
		{
		}

		// Token: 0x06004B67 RID: 19303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B67")]
		[Address(RVA = "0x1B7B5B4", Offset = "0x1B7B5B4", VA = "0x7BBC37B5B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DE08", Offset = "0x113DE08")]
		private void <RetryJoinRoomLater>b__50_0()
		{
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B68")]
		[Address(RVA = "0x1B7B634", Offset = "0x1B7B634", VA = "0x7BBC37B634")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DE18", Offset = "0x113DE18")]
		private void <RetryInitLater>b__51_0()
		{
		}

		// Token: 0x04007372 RID: 29554
		[Token(Token = "0x4007372")]
		[FieldOffset(Offset = "0x18")]
		private ChannelState m_CurrentState;

		// Token: 0x04007373 RID: 29555
		[Token(Token = "0x4007373")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_EngineInited;

		// Token: 0x04007374 RID: 29556
		[Token(Token = "0x4007374")]
		[FieldOffset(Offset = "0x20")]
		private string m_UserID;

		// Token: 0x04007375 RID: 29557
		[Token(Token = "0x4007375")]
		[FieldOffset(Offset = "0x28")]
		private GameVoiceEngine.OnLeavedRoom onLeavedRoom;

		// Token: 0x04007376 RID: 29558
		[Token(Token = "0x4007376")]
		[FieldOffset(Offset = "0x30")]
		private GameVoiceEngine.OnJoinedRoom onJoinedRoom;

		// Token: 0x04007377 RID: 29559
		[Token(Token = "0x4007377")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int MAX_JOIN_RETRY_COUNT;

		// Token: 0x04007378 RID: 29560
		[Token(Token = "0x4007378")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int MAX_INIT_RETRY_COUNT;

		// Token: 0x04007379 RID: 29561
		[Token(Token = "0x4007379")]
		[FieldOffset(Offset = "0x8")]
		private static readonly float RETRY_DEALY_SECOUND;

		// Token: 0x0400737A RID: 29562
		[Token(Token = "0x400737A")]
		[FieldOffset(Offset = "0x38")]
		private bool m_IsMicroPhoneMute;

		// Token: 0x0400737B RID: 29563
		[Token(Token = "0x400737B")]
		[FieldOffset(Offset = "0x39")]
		private bool m_IsSpeakerMute;

		// Token: 0x0400737C RID: 29564
		[Token(Token = "0x400737C")]
		[FieldOffset(Offset = "0x3C")]
		private uint m_GameVoiceVolume;

		// Token: 0x0400737D RID: 29565
		[Token(Token = "0x400737D")]
		[FieldOffset(Offset = "0x10")]
		private static GameVoiceEngine _instance;

		// Token: 0x0400737E RID: 29566
		[Token(Token = "0x400737E")]
		[FieldOffset(Offset = "0x40")]
		private List<Action> _actions;

		// Token: 0x0400737F RID: 29567
		[Token(Token = "0x400737F")]
		[FieldOffset(Offset = "0x48")]
		private List<Action> _currentActions;

		// Token: 0x04007380 RID: 29568
		[Token(Token = "0x4007380")]
		[FieldOffset(Offset = "0x50")]
		private int m_JoinRetryCount;

		// Token: 0x04007381 RID: 29569
		[Token(Token = "0x4007381")]
		[FieldOffset(Offset = "0x54")]
		private int m_InitRetryCount;

		// Token: 0x04007382 RID: 29570
		[Token(Token = "0x4007382")]
		[FieldOffset(Offset = "0x58")]
		private RoomInfo m_CurrentRoomInfo;

		// Token: 0x04007383 RID: 29571
		[Token(Token = "0x4007383")]
		[FieldOffset(Offset = "0x60")]
		private RoomInfo m_LastJoinRequest;

		// Token: 0x04007384 RID: 29572
		[Token(Token = "0x4007384")]
		[FieldOffset(Offset = "0x68")]
		private uint m_CurrentRetryJoinDelayID;

		// Token: 0x04007385 RID: 29573
		[Token(Token = "0x4007385")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_ChannelResumed;

		// Token: 0x04007386 RID: 29574
		[Token(Token = "0x4007386")]
		[FieldOffset(Offset = "0x70")]
		private GameVoiceEngine.EChannelPauseReason m_ChannelPauseReason;

		// Token: 0x04007387 RID: 29575
		[Token(Token = "0x4007387")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<string, bool> m_PlayerVadDict;

		// Token: 0x04007388 RID: 29576
		[Token(Token = "0x4007388")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<string, bool> m_PlayerMuteDict;

		// Token: 0x04007389 RID: 29577
		[Token(Token = "0x4007389")]
		[FieldOffset(Offset = "0x88")]
		private float m_OwnVoiceOnTime;

		// Token: 0x0400738A RID: 29578
		[Token(Token = "0x400738A")]
		[FieldOffset(Offset = "0x8C")]
		private bool m_OwnVoiceIsOn;

		// Token: 0x020012BF RID: 4799
		[Token(Token = "0x20012BF")]
		private enum EChannelPauseReason
		{
			// Token: 0x0400738C RID: 29580
			[Token(Token = "0x400738C")]
			eNone,
			// Token: 0x0400738D RID: 29581
			[Token(Token = "0x400738D")]
			eAppPause,
			// Token: 0x0400738E RID: 29582
			[Token(Token = "0x400738E")]
			eMute
		}

		// Token: 0x020012C0 RID: 4800
		// (Invoke) Token: 0x06004B6A RID: 19306
		[Token(Token = "0x20012C0")]
		private delegate void OnLeavedRoom();

		// Token: 0x020012C1 RID: 4801
		// (Invoke) Token: 0x06004B6E RID: 19310
		[Token(Token = "0x20012C1")]
		private delegate void OnJoinedRoom();

		// Token: 0x020012C2 RID: 4802
		[Token(Token = "0x20012C2")]
		private class Json_MemberChangeInfo
		{
			// Token: 0x06004B71 RID: 19313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B71")]
			[Address(RVA = "0x1B7CFE0", Offset = "0x1B7CFE0", VA = "0x7BBC37CFE0")]
			public Json_MemberChangeInfo()
			{
			}

			// Token: 0x0400738F RID: 29583
			[Token(Token = "0x400738F")]
			[FieldOffset(Offset = "0x10")]
			public string channelid;

			// Token: 0x04007390 RID: 29584
			[Token(Token = "0x4007390")]
			[FieldOffset(Offset = "0x18")]
			public GameVoiceEngine.Json_MemberInfo[] memchange;

			// Token: 0x04007391 RID: 29585
			[Token(Token = "0x4007391")]
			[FieldOffset(Offset = "0x20")]
			public int type;
		}

		// Token: 0x020012C3 RID: 4803
		[Token(Token = "0x20012C3")]
		private class Json_MemberInfo
		{
			// Token: 0x06004B72 RID: 19314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B72")]
			[Address(RVA = "0x1B7CFE8", Offset = "0x1B7CFE8", VA = "0x7BBC37CFE8")]
			public Json_MemberInfo()
			{
			}

			// Token: 0x04007392 RID: 29586
			[Token(Token = "0x4007392")]
			[FieldOffset(Offset = "0x10")]
			public bool isJoin;

			// Token: 0x04007393 RID: 29587
			[Token(Token = "0x4007393")]
			[FieldOffset(Offset = "0x18")]
			public string userid;
		}

		// Token: 0x020012C4 RID: 4804
		[Token(Token = "0x20012C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB098", Offset = "0x10EB098")]
		private sealed class <>c__DisplayClass53_0
		{
			// Token: 0x06004B73 RID: 19315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B73")]
			[Address(RVA = "0x1B7A734", Offset = "0x1B7A734", VA = "0x7BBC37A734")]
			public <>c__DisplayClass53_0()
			{
			}

			// Token: 0x06004B74 RID: 19316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B74")]
			[Address(RVA = "0x1B7BE80", Offset = "0x1B7BE80", VA = "0x7BBC37BE80")]
			internal void <OnMemberChange>b__0()
			{
			}

			// Token: 0x04007394 RID: 29588
			[Token(Token = "0x4007394")]
			[FieldOffset(Offset = "0x10")]
			public string strParam;
		}

		// Token: 0x020012C5 RID: 4805
		[Token(Token = "0x20012C5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB0A8", Offset = "0x10EB0A8")]
		private sealed class <>c__DisplayClass54_0
		{
			// Token: 0x06004B75 RID: 19317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B75")]
			[Address(RVA = "0x1B7A73C", Offset = "0x1B7A73C", VA = "0x7BBC37A73C")]
			public <>c__DisplayClass54_0()
			{
			}

			// Token: 0x06004B76 RID: 19318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B76")]
			[Address(RVA = "0x1B7BFB8", Offset = "0x1B7BFB8", VA = "0x7BBC37BFB8")]
			internal void <OnEvent>b__1()
			{
			}

			// Token: 0x06004B77 RID: 19319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B77")]
			[Address(RVA = "0x1B7C044", Offset = "0x1B7C044", VA = "0x7BBC37C044")]
			internal void <OnEvent>b__2()
			{
			}

			// Token: 0x06004B78 RID: 19320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B78")]
			[Address(RVA = "0x1B7C808", Offset = "0x1B7C808", VA = "0x7BBC37C808")]
			internal void <OnEvent>b__4()
			{
			}

			// Token: 0x06004B79 RID: 19321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B79")]
			[Address(RVA = "0x1B7C8A0", Offset = "0x1B7C8A0", VA = "0x7BBC37C8A0")]
			internal void <OnEvent>b__5()
			{
			}

			// Token: 0x06004B7A RID: 19322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B7A")]
			[Address(RVA = "0x1B7C920", Offset = "0x1B7C920", VA = "0x7BBC37C920")]
			internal void <OnEvent>b__6()
			{
			}

			// Token: 0x06004B7B RID: 19323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B7B")]
			[Address(RVA = "0x1B7C9A0", Offset = "0x1B7C9A0", VA = "0x7BBC37C9A0")]
			internal void <OnEvent>b__8()
			{
			}

			// Token: 0x06004B7C RID: 19324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B7C")]
			[Address(RVA = "0x1B7CA20", Offset = "0x1B7CA20", VA = "0x7BBC37CA20")]
			internal void <OnEvent>b__9()
			{
			}

			// Token: 0x06004B7D RID: 19325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B7D")]
			[Address(RVA = "0x1B7CAA0", Offset = "0x1B7CAA0", VA = "0x7BBC37CAA0")]
			internal void <OnEvent>b__10()
			{
			}

			// Token: 0x06004B7E RID: 19326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B7E")]
			[Address(RVA = "0x1B7CBD8", Offset = "0x1B7CBD8", VA = "0x7BBC37CBD8")]
			internal void <OnEvent>b__12()
			{
			}

			// Token: 0x06004B7F RID: 19327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B7F")]
			[Address(RVA = "0x1B7CEE0", Offset = "0x1B7CEE0", VA = "0x7BBC37CEE0")]
			internal void <OnEvent>b__13()
			{
			}

			// Token: 0x06004B80 RID: 19328 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B80")]
			[Address(RVA = "0x1B7CF60", Offset = "0x1B7CF60", VA = "0x7BBC37CF60")]
			internal void <OnEvent>b__14()
			{
			}

			// Token: 0x04007395 RID: 29589
			[Token(Token = "0x4007395")]
			[FieldOffset(Offset = "0x10")]
			public GameVoiceEngine <>4__this;

			// Token: 0x04007396 RID: 29590
			[Token(Token = "0x4007396")]
			[FieldOffset(Offset = "0x18")]
			public string channelID;

			// Token: 0x04007397 RID: 29591
			[Token(Token = "0x4007397")]
			[FieldOffset(Offset = "0x20")]
			public string param;

			// Token: 0x04007398 RID: 29592
			[Token(Token = "0x4007398")]
			[FieldOffset(Offset = "0x28")]
			public int errorCode;
		}

		// Token: 0x020012C6 RID: 4806
		[Token(Token = "0x20012C6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB0B8", Offset = "0x10EB0B8")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004B82 RID: 19330 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B82")]
			[Address(RVA = "0x1B7B710", Offset = "0x1B7B710", VA = "0x7BBC37B710")]
			public <>c()
			{
			}

			// Token: 0x06004B83 RID: 19331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B83")]
			[Address(RVA = "0x1B7B718", Offset = "0x1B7B718", VA = "0x7BBC37B718")]
			internal void <OnEvent>b__54_0()
			{
			}

			// Token: 0x06004B84 RID: 19332 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B84")]
			[Address(RVA = "0x1B7B7E0", Offset = "0x1B7B7E0", VA = "0x7BBC37B7E0")]
			internal void <OnEvent>b__54_3()
			{
			}

			// Token: 0x06004B85 RID: 19333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B85")]
			[Address(RVA = "0x1B7BDA8", Offset = "0x1B7BDA8", VA = "0x7BBC37BDA8")]
			internal void <OnEvent>b__54_7()
			{
			}

			// Token: 0x06004B86 RID: 19334 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B86")]
			[Address(RVA = "0x1B7BE20", Offset = "0x1B7BE20", VA = "0x7BBC37BE20")]
			internal void <OnEvent>b__54_11()
			{
			}

			// Token: 0x04007399 RID: 29593
			[Token(Token = "0x4007399")]
			[FieldOffset(Offset = "0x0")]
			public static readonly GameVoiceEngine.<>c <>9;

			// Token: 0x0400739A RID: 29594
			[Token(Token = "0x400739A")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__54_0;

			// Token: 0x0400739B RID: 29595
			[Token(Token = "0x400739B")]
			[FieldOffset(Offset = "0x10")]
			public static Action <>9__54_3;

			// Token: 0x0400739C RID: 29596
			[Token(Token = "0x400739C")]
			[FieldOffset(Offset = "0x18")]
			public static Action <>9__54_7;

			// Token: 0x0400739D RID: 29597
			[Token(Token = "0x400739D")]
			[FieldOffset(Offset = "0x20")]
			public static Action <>9__54_11;
		}
	}
}
