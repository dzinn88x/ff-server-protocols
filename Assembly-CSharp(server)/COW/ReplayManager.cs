using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020012B8 RID: 4792
	[Token(Token = "0x20012B8")]
	internal class ReplayManager : SingletonModule<ReplayManager>
	{
		// Token: 0x06004B14 RID: 19220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B14")]
		[Address(RVA = "0x175A220", Offset = "0x175A220", VA = "0x7BBBF5A220", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004B15 RID: 19221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B15")]
		[Address(RVA = "0x175A2EC", Offset = "0x175A2EC", VA = "0x7BBBF5A2EC", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004B16 RID: 19222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B16")]
		[Address(RVA = "0x175A374", Offset = "0x175A374", VA = "0x7BBBF5A374")]
		public void OnStarted()
		{
		}

		// Token: 0x06004B17 RID: 19223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B17")]
		[Address(RVA = "0x175AFF0", Offset = "0x175AFF0", VA = "0x7BBBF5AFF0")]
		public void OnEnded()
		{
		}

		// Token: 0x06004B18 RID: 19224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B18")]
		[Address(RVA = "0x175A4D8", Offset = "0x175A4D8", VA = "0x7BBBF5A4D8")]
		private void OnRecordStarted()
		{
		}

		// Token: 0x06004B19 RID: 19225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B19")]
		[Address(RVA = "0x175B7EC", Offset = "0x175B7EC", VA = "0x7BBBF5B7EC")]
		public void OnMatchEnd()
		{
		}

		// Token: 0x06004B1A RID: 19226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1A")]
		[Address(RVA = "0x175B024", Offset = "0x175B024", VA = "0x7BBBF5B024")]
		public void OnRecordEnded()
		{
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1B")]
		[Address(RVA = "0x175B818", Offset = "0x175B818", VA = "0x7BBBF5B818")]
		public void RecordPackets(Queue<UDPMsgPacket> queue)
		{
		}

		// Token: 0x06004B1C RID: 19228 RVA: 0x000168F0 File Offset: 0x00014AF0
		[Token(Token = "0x6004B1C")]
		[Address(RVA = "0x175B984", Offset = "0x175B984", VA = "0x7BBBF5B984")]
		public float CurTimeSec()
		{
			return 0f;
		}

		// Token: 0x06004B1D RID: 19229 RVA: 0x00016908 File Offset: 0x00014B08
		[Token(Token = "0x6004B1D")]
		[Address(RVA = "0x175B758", Offset = "0x175B758", VA = "0x7BBBF5B758")]
		private long GetNowTimeMS()
		{
			return 0L;
		}

		// Token: 0x06004B1E RID: 19230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1E")]
		[Address(RVA = "0x175A434", Offset = "0x175A434", VA = "0x7BBBF5A434")]
		private void OnReplayStarted()
		{
		}

		// Token: 0x06004B1F RID: 19231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1F")]
		[Address(RVA = "0x175B65C", Offset = "0x175B65C", VA = "0x7BBBF5B65C")]
		private void OnReplayEnded()
		{
		}

		// Token: 0x06004B20 RID: 19232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B20")]
		[Address(RVA = "0x175B9BC", Offset = "0x175B9BC", VA = "0x7BBBF5B9BC")]
		public void GetReplayPackets(Queue<UDPMsgPacket> outPackets)
		{
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B21")]
		[Address(RVA = "0x175BC98", Offset = "0x175BC98", VA = "0x7BBBF5BC98")]
		public List<ReplayInfo> GetReplayList()
		{
			return null;
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B22")]
		[Address(RVA = "0x175BD14", Offset = "0x175BD14", VA = "0x7BBBF5BD14")]
		private void ReadReplayList()
		{
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B23")]
		[Address(RVA = "0x175BF24", Offset = "0x175BF24", VA = "0x7BBBF5BF24")]
		public void DelReplay(ReplayInfo info)
		{
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B24")]
		[Address(RVA = "0x175C014", Offset = "0x175C014", VA = "0x7BBBF5C014")]
		public void ResetReplay()
		{
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B25")]
		[Address(RVA = "0x175C01C", Offset = "0x175C01C", VA = "0x7BBBF5C01C")]
		public void StartReplay(ReplayInfo info)
		{
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06004B26 RID: 19238 RVA: 0x00016920 File Offset: 0x00014B20
		[Token(Token = "0x17000846")]
		public bool IsJumping
		{
			[Token(Token = "0x6004B26")]
			[Address(RVA = "0x175C2D8", Offset = "0x175C2D8", VA = "0x7BBBF5C2D8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B27")]
		[Address(RVA = "0x175C2E0", Offset = "0x175C2E0", VA = "0x7BBBF5C2E0")]
		public void PauseReplay(bool pause)
		{
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B28")]
		[Address(RVA = "0x175C380", Offset = "0x175C380", VA = "0x7BBBF5C380")]
		public void SetPlaySpeed(bool fast)
		{
		}

		// Token: 0x06004B29 RID: 19241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B29")]
		[Address(RVA = "0x1759F5C", Offset = "0x1759F5C", VA = "0x7BBBF59F5C")]
		public void GoToTimePoint(float value, [Optional] Action callback)
		{
		}

		// Token: 0x06004B2A RID: 19242 RVA: 0x00016938 File Offset: 0x00014B38
		[Token(Token = "0x6004B2A")]
		[Address(RVA = "0x175C710", Offset = "0x175C710", VA = "0x7BBBF5C710")]
		public long CurrentGameTime()
		{
			return 0L;
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x00016950 File Offset: 0x00014B50
		[Token(Token = "0x6004B2B")]
		[Address(RVA = "0x175C718", Offset = "0x175C718", VA = "0x7BBBF5C718")]
		public float CurrentProgress()
		{
			return 0f;
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x00016968 File Offset: 0x00014B68
		[Token(Token = "0x6004B2C")]
		[Address(RVA = "0x175C6FC", Offset = "0x175C6FC", VA = "0x7BBBF5C6FC")]
		public long GetGameTimeMS(float value)
		{
			return 0L;
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x00016980 File Offset: 0x00014B80
		[Token(Token = "0x6004B2D")]
		[Address(RVA = "0x175C730", Offset = "0x175C730", VA = "0x7BBBF5C730")]
		public float GetTimeRatio(float time)
		{
			return 0f;
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B2E")]
		[Address(RVA = "0x175C74C", Offset = "0x175C74C", VA = "0x7BBBF5C74C")]
		public void SetState(EReplayState state)
		{
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x00016998 File Offset: 0x00014B98
		[Token(Token = "0x6004B2F")]
		[Address(RVA = "0x175A4C8", Offset = "0x175A4C8", VA = "0x7BBBF5A4C8")]
		public bool IsRecordState()
		{
			return default(bool);
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x000169B0 File Offset: 0x00014BB0
		[Token(Token = "0x6004B30")]
		[Address(RVA = "0x175A424", Offset = "0x175A424", VA = "0x7BBBF5A424")]
		public bool IsReplayState()
		{
			return default(bool);
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B31")]
		[Address(RVA = "0x175C754", Offset = "0x175C754", VA = "0x7BBBF5C754")]
		public List<ReplayEvent> GetReplayEventList()
		{
			return null;
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B32")]
		[Address(RVA = "0x175C780", Offset = "0x175C780", VA = "0x7BBBF5C780")]
		public ReplayManager()
		{
		}

		// Token: 0x0400734C RID: 29516
		[Token(Token = "0x400734C")]
		private const int MS_TO_TICK = 10000;

		// Token: 0x0400734D RID: 29517
		[Token(Token = "0x400734D")]
		private const float S_TO_MS = 1000f;

		// Token: 0x0400734E RID: 29518
		[Token(Token = "0x400734E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FileStream m_ReplayFileStream;

		// Token: 0x0400734F RID: 29519
		[Token(Token = "0x400734F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BinaryWriter m_ReplayBinaryWriter;

		// Token: 0x04007350 RID: 29520
		[Token(Token = "0x4007350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BinaryReader m_ReplayBinaryReader;

		// Token: 0x04007351 RID: 29521
		[Token(Token = "0x4007351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ReplayData m_ReplayData;

		// Token: 0x04007352 RID: 29522
		[Token(Token = "0x4007352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ReplayInfo m_CurReplayInfo;

		// Token: 0x04007353 RID: 29523
		[Token(Token = "0x4007353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private long m_GameTotalTimeMS;

		// Token: 0x04007354 RID: 29524
		[Token(Token = "0x4007354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EReplayState m_CurState;

		// Token: 0x04007355 RID: 29525
		[Token(Token = "0x4007355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long m_StartTimeMS;

		// Token: 0x04007356 RID: 29526
		[Token(Token = "0x4007356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string m_MatchDateTime;

		// Token: 0x04007357 RID: 29527
		[Token(Token = "0x4007357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action m_ReplayJumpCallBack;

		// Token: 0x04007358 RID: 29528
		[Token(Token = "0x4007358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private long m_ReplayTimeMS;

		// Token: 0x04007359 RID: 29529
		[Token(Token = "0x4007359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Started;

		// Token: 0x0400735A RID: 29530
		[Token(Token = "0x400735A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Queue<ReplayData> m_ReplayDataQueue;

		// Token: 0x0400735B RID: 29531
		[Token(Token = "0x400735B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_HasMatchEnd;

		// Token: 0x0400735C RID: 29532
		[Token(Token = "0x400735C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<ReplayInfo> m_CachedReplayInfo;

		// Token: 0x0400735D RID: 29533
		[Token(Token = "0x400735D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_Changed;

		// Token: 0x0400735E RID: 29534
		[Token(Token = "0x400735E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool m_ReplayPaused;

		// Token: 0x0400735F RID: 29535
		[Token(Token = "0x400735F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int m_CurSpeed;

		// Token: 0x04007360 RID: 29536
		[Token(Token = "0x4007360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool m_IsJumping;

		// Token: 0x04007361 RID: 29537
		[Token(Token = "0x4007361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private long m_DestTimeMS;

		// Token: 0x04007362 RID: 29538
		[Token(Token = "0x4007362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Dictionary<int, float> m_LevelSpeedDic;
	}
}
