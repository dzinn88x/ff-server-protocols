using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200126B RID: 4715
	[Token(Token = "0x200126B")]
	public class LevelFerrisWheel : BaseLevelObject
	{
		// Token: 0x06004905 RID: 18693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004905")]
		[Address(RVA = "0x1401BD4", Offset = "0x1401BD4", VA = "0x7BBBC01BD4", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004906")]
		[Address(RVA = "0x1401C1C", Offset = "0x1401C1C", VA = "0x7BBBC01C1C")]
		private void Awake()
		{
		}

		// Token: 0x06004907 RID: 18695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004907")]
		[Address(RVA = "0x1401CC0", Offset = "0x1401CC0", VA = "0x7BBBC01CC0", Slot = "14")]
		public override void OnFixedUpdate(float gameTime, float deltaTime)
		{
		}

		// Token: 0x06004908 RID: 18696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004908")]
		[Address(RVA = "0x1401E24", Offset = "0x1401E24", VA = "0x7BBBC01E24")]
		private void UpdateRotationAngle(float newVal, uint tickCount)
		{
		}

		// Token: 0x06004909 RID: 18697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004909")]
		[Address(RVA = "0x1401ED8", Offset = "0x1401ED8", VA = "0x7BBBC01ED8")]
		public void OnPlayerGetOn({QAb\u0082~u pID, byte seatGroup, byte seatIndex)
		{
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600490A")]
		[Address(RVA = "0x1402294", Offset = "0x1402294", VA = "0x7BBBC02294")]
		public void OnPlayerGetOff(byte seatGroup, byte seatIndex)
		{
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600490B")]
		[Address(RVA = "0x140218C", Offset = "0x140218C", VA = "0x7BBBC0218C")]
		private FerrisWheelSeat GetPlayerMountSeat(byte groupID, byte seatInx)
		{
			return null;
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600490C")]
		[Address(RVA = "0x1402410", Offset = "0x1402410", VA = "0x7BBBC02410", Slot = "27")]
		public override void SyncAction(params object[] param)
		{
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600490D")]
		[Address(RVA = "0x1402800", Offset = "0x1402800", VA = "0x7BBBC02800")]
		public LevelFerrisWheel()
		{
		}

		// Token: 0x040071F2 RID: 29170
		[Token(Token = "0x40071F2")]
		[FieldOffset(Offset = "0x68")]
		public FerrisWheelSeatGroup[] SeatGroup;

		// Token: 0x040071F3 RID: 29171
		[Token(Token = "0x40071F3")]
		[FieldOffset(Offset = "0x70")]
		public Transform RotationCenter;

		// Token: 0x040071F4 RID: 29172
		[Token(Token = "0x40071F4")]
		[FieldOffset(Offset = "0x78")]
		public Transform GetOffPos;

		// Token: 0x040071F5 RID: 29173
		[Token(Token = "0x40071F5")]
		[FieldOffset(Offset = "0x80")]
		public float Radius;

		// Token: 0x040071F6 RID: 29174
		[Token(Token = "0x40071F6")]
		[FieldOffset(Offset = "0x84")]
		public float RotaSpeed;

		// Token: 0x040071F7 RID: 29175
		[Token(Token = "0x40071F7")]
		[FieldOffset(Offset = "0x88")]
		private bool m_EnableSeatRota;

		// Token: 0x040071F8 RID: 29176
		[Token(Token = "0x40071F8")]
		[FieldOffset(Offset = "0x89")]
		private bool m_EnaleCenterRota;

		// Token: 0x040071F9 RID: 29177
		[Token(Token = "0x40071F9")]
		[FieldOffset(Offset = "0x90")]
		private LevelFerrisWheel.ShadowState m_ShadowState;

		// Token: 0x040071FA RID: 29178
		[Token(Token = "0x40071FA")]
		[FieldOffset(Offset = "0x98")]
		protected uint m_LastValidTickCount;

		// Token: 0x0200126C RID: 4716
		[Token(Token = "0x200126C")]
		public enum ELevelFerrisWheelAction
		{
			// Token: 0x040071FC RID: 29180
			[Token(Token = "0x40071FC")]
			SYNC_ANGLE,
			// Token: 0x040071FD RID: 29181
			[Token(Token = "0x40071FD")]
			GET_ON,
			// Token: 0x040071FE RID: 29182
			[Token(Token = "0x40071FE")]
			GET_OFF
		}

		// Token: 0x0200126D RID: 4717
		[Token(Token = "0x200126D")]
		private class ShadowState : ShadowStateBase
		{
			// Token: 0x0600490E RID: 18702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600490E")]
			[Address(RVA = "0x1402880", Offset = "0x1402880", VA = "0x7BBBC02880")]
			public ShadowState()
			{
			}

			// Token: 0x040071FF RID: 29183
			[Token(Token = "0x40071FF")]
			[FieldOffset(Offset = "0x18")]
			public float CurAngle;

			// Token: 0x04007200 RID: 29184
			[Token(Token = "0x4007200")]
			[FieldOffset(Offset = "0x1C")]
			public float NextAngle;
		}
	}
}
