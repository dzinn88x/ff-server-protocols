using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020015DD RID: 5597
	[Token(Token = "0x20015DD")]
	public class UIHudMatchResultStateMachine
	{
		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x0600632E RID: 25390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C8")]
		private Dictionary<EUIHudMatchResultState, UIHudMatchResultStateBase> States
		{
			[Token(Token = "0x600632E")]
			[Address(RVA = "0x17AEE6C", Offset = "0x17AEE6C", VA = "0x7BBBFAEE6C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x0600632F RID: 25391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C9")]
		public UIHudMatchResultStateBase CurrentState
		{
			[Token(Token = "0x600632F")]
			[Address(RVA = "0x17AEEE0", Offset = "0x17AEEE0", VA = "0x7BBBFAEEE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06006330 RID: 25392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008CA")]
		public MatchStats StatsData
		{
			[Token(Token = "0x6006330")]
			[Address(RVA = "0x17ADFC0", Offset = "0x17ADFC0", VA = "0x7BBBFADFC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06006331 RID: 25393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008CB")]
		public MatchIncome IncomeData
		{
			[Token(Token = "0x6006331")]
			[Address(RVA = "0x17A5BD4", Offset = "0x17A5BD4", VA = "0x7BBBFA5BD4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06006332 RID: 25394 RVA: 0x0001C998 File Offset: 0x0001AB98
		// (set) Token: 0x06006333 RID: 25395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008CC")]
		public bool HasShowMVP
		{
			[Token(Token = "0x6006332")]
			[Address(RVA = "0x17AEEE8", Offset = "0x17AEEE8", VA = "0x7BBBFAEEE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006333")]
			[Address(RVA = "0x17ADFD8", Offset = "0x17ADFD8", VA = "0x7BBBFADFD8")]
			set
			{
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06006334 RID: 25396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008CD")]
		public TeammateStats MVPData
		{
			[Token(Token = "0x6006334")]
			[Address(RVA = "0x17ADFC8", Offset = "0x17ADFC8", VA = "0x7BBBFADFC8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06006335 RID: 25397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008CE")]
		public UIMaleAvatar MVPAvatar
		{
			[Token(Token = "0x6006335")]
			[Address(RVA = "0x17AE014", Offset = "0x17AE014", VA = "0x7BBBFAE014")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06006336 RID: 25398 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
		[Token(Token = "0x170008CF")]
		public bool IsWin
		{
			[Token(Token = "0x6006336")]
			[Address(RVA = "0x17ADFD0", Offset = "0x17ADFD0", VA = "0x7BBBFADFD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06006337 RID: 25399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D0")]
		public Camera ResultBGCamera
		{
			[Token(Token = "0x6006337")]
			[Address(RVA = "0x17AEEF0", Offset = "0x17AEEF0", VA = "0x7BBBFAEEF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06006338 RID: 25400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D1")]
		public Camera ResultAvatarCamera
		{
			[Token(Token = "0x6006338")]
			[Address(RVA = "0x17AEEF8", Offset = "0x17AEEF8", VA = "0x7BBBFAEEF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06006339 RID: 25401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D2")]
		public Camera ResultMVPCamera
		{
			[Token(Token = "0x6006339")]
			[Address(RVA = "0x17AEF00", Offset = "0x17AEF00", VA = "0x7BBBFAEF00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600633A RID: 25402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600633A")]
		[Address(RVA = "0x17AEF08", Offset = "0x17AEF08", VA = "0x7BBBFAEF08")]
		public UIHudMatchResultStateMachine(MatchStats stats, MatchIncome income)
		{
		}

		// Token: 0x0600633B RID: 25403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600633B")]
		[Address(RVA = "0x17A5DA0", Offset = "0x17A5DA0", VA = "0x7BBBFA5DA0")]
		public void GoTo(EUIHudMatchResultState state)
		{
		}

		// Token: 0x0600633C RID: 25404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600633C")]
		[Address(RVA = "0x17AF48C", Offset = "0x17AF48C", VA = "0x7BBBFAF48C")]
		public void InitData(TeammateStats mvpData, UIMaleAvatar avatar, Camera bgCamera, Camera avatarCamera, bool win, UIHudMatchResultStateMachineFinishDelegate fnFinish)
		{
		}

		// Token: 0x0600633D RID: 25405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600633D")]
		[Address(RVA = "0x17AE01C", Offset = "0x17AE01C", VA = "0x7BBBFAE01C")]
		public void SetMVPRoomObject(GameObject mvpRoom, GameObject mvpCameraOB)
		{
		}

		// Token: 0x0600633E RID: 25406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600633E")]
		[Address(RVA = "0x17AF5A4", Offset = "0x17AF5A4", VA = "0x7BBBFAF5A4")]
		public void DestroyMVPRoomObject()
		{
		}

		// Token: 0x0600633F RID: 25407 RVA: 0x0001C9C8 File Offset: 0x0001ABC8
		[Token(Token = "0x600633F")]
		[Address(RVA = "0x17AD3F4", Offset = "0x17AD3F4", VA = "0x7BBBFAD3F4")]
		public bool CanShowMVP()
		{
			return default(bool);
		}

		// Token: 0x06006340 RID: 25408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006340")]
		[Address(RVA = "0x17AF4A4", Offset = "0x17AF4A4", VA = "0x7BBBFAF4A4")]
		public void EnableResultCamera(bool enable)
		{
		}

		// Token: 0x06006341 RID: 25409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006341")]
		[Address(RVA = "0x17AEF4C", Offset = "0x17AEF4C", VA = "0x7BBBFAEF4C")]
		private void InitStates()
		{
		}

		// Token: 0x06006342 RID: 25410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006342")]
		[Address(RVA = "0x17AF2F0", Offset = "0x17AF2F0", VA = "0x7BBBFAF2F0")]
		private void EnterStateMachine()
		{
		}

		// Token: 0x06006343 RID: 25411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006343")]
		[Address(RVA = "0x17AF3B0", Offset = "0x17AF3B0", VA = "0x7BBBFAF3B0")]
		private void ExitStateMachine()
		{
		}

		// Token: 0x06006344 RID: 25412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006344")]
		[Address(RVA = "0x17AFBE4", Offset = "0x17AFBE4", VA = "0x7BBBFAFBE4")]
		private void OnHandleStateFinish(params object[] param)
		{
		}

		// Token: 0x040081EF RID: 33263
		[Token(Token = "0x40081EF")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<EUIHudMatchResultState, UIHudMatchResultStateBase> m_States;

		// Token: 0x040081F0 RID: 33264
		[Token(Token = "0x40081F0")]
		[FieldOffset(Offset = "0x18")]
		private UIHudMatchResultStateBase m_CurrentState;

		// Token: 0x040081F1 RID: 33265
		[Token(Token = "0x40081F1")]
		[FieldOffset(Offset = "0x20")]
		private MatchStats m_MatchStatsData;

		// Token: 0x040081F2 RID: 33266
		[Token(Token = "0x40081F2")]
		[FieldOffset(Offset = "0x28")]
		private MatchIncome m_MatchIncomeData;

		// Token: 0x040081F3 RID: 33267
		[Token(Token = "0x40081F3")]
		[FieldOffset(Offset = "0x30")]
		private bool m_HasShowMVP;

		// Token: 0x040081F4 RID: 33268
		[Token(Token = "0x40081F4")]
		[FieldOffset(Offset = "0x38")]
		private TeammateStats m_MVPData;

		// Token: 0x040081F5 RID: 33269
		[Token(Token = "0x40081F5")]
		[FieldOffset(Offset = "0x40")]
		private UIMaleAvatar m_MVPAvatar;

		// Token: 0x040081F6 RID: 33270
		[Token(Token = "0x40081F6")]
		[FieldOffset(Offset = "0x48")]
		private bool m_IsWin;

		// Token: 0x040081F7 RID: 33271
		[Token(Token = "0x40081F7")]
		[FieldOffset(Offset = "0x50")]
		private Camera m_ResultBGCamera;

		// Token: 0x040081F8 RID: 33272
		[Token(Token = "0x40081F8")]
		[FieldOffset(Offset = "0x58")]
		private Camera m_ResultAvatarCamera;

		// Token: 0x040081F9 RID: 33273
		[Token(Token = "0x40081F9")]
		[FieldOffset(Offset = "0x60")]
		private Camera m_ResultMVPCamera;

		// Token: 0x040081FA RID: 33274
		[Token(Token = "0x40081FA")]
		[FieldOffset(Offset = "0x68")]
		private GameObject m_MVPRoomOB;

		// Token: 0x040081FB RID: 33275
		[Token(Token = "0x40081FB")]
		[FieldOffset(Offset = "0x70")]
		private GameObject m_MVPCameraOB;

		// Token: 0x040081FC RID: 33276
		[Token(Token = "0x40081FC")]
		[FieldOffset(Offset = "0x78")]
		private UIHudMatchResultStateMachineFinishDelegate fnStateMachineFinish;
	}
}
