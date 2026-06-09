using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200125C RID: 4700
	[Token(Token = "0x200125C")]
	public class AlarmAudioComponent : MonoBehaviour
	{
		// Token: 0x060048C8 RID: 18632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C8")]
		[Address(RVA = "0x154BEF8", Offset = "0x154BEF8", VA = "0x7BBBD4BEF8")]
		private void Awake()
		{
		}

		// Token: 0x060048C9 RID: 18633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C9")]
		[Address(RVA = "0x154C224", Offset = "0x154C224", VA = "0x7BBBD4C224")]
		private void Update()
		{
		}

		// Token: 0x060048CA RID: 18634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048CA")]
		[Address(RVA = "0x154C558", Offset = "0x154C558", VA = "0x7BBBD4C558")]
		private void StopAlam()
		{
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048CB")]
		[Address(RVA = "0x154C5D8", Offset = "0x154C5D8", VA = "0x7BBBD4C5D8")]
		private void StartAlarm()
		{
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048CC")]
		[Address(RVA = "0x154C310", Offset = "0x154C310", VA = "0x7BBBD4C310")]
		private void UpdateAlarm()
		{
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048CD")]
		[Address(RVA = "0x154C7F8", Offset = "0x154C7F8", VA = "0x7BBBD4C7F8")]
		public AlarmAudioComponent()
		{
		}

		// Token: 0x040071BA RID: 29114
		[Token(Token = "0x40071BA")]
		[FieldOffset(Offset = "0x18")]
		public float m_StartAlarmSecound;

		// Token: 0x040071BB RID: 29115
		[Token(Token = "0x40071BB")]
		[FieldOffset(Offset = "0x1C")]
		public float m_EndAlarmSecound;

		// Token: 0x040071BC RID: 29116
		[Token(Token = "0x40071BC")]
		[FieldOffset(Offset = "0x20")]
		private AudioSource m_AlarmAudioSource;

		// Token: 0x040071BD RID: 29117
		[Token(Token = "0x40071BD")]
		[FieldOffset(Offset = "0x28")]
		private SafeZone m_SafeZone;

		// Token: 0x040071BE RID: 29118
		[Token(Token = "0x40071BE")]
		[FieldOffset(Offset = "0x30")]
		private AudioClip m_NormalAlarmSound;

		// Token: 0x040071BF RID: 29119
		[Token(Token = "0x40071BF")]
		[FieldOffset(Offset = "0x38")]
		private AudioClip m_SpecialAlarmSound;

		// Token: 0x040071C0 RID: 29120
		[Token(Token = "0x40071C0")]
		[FieldOffset(Offset = "0x40")]
		private float m_OriginVolume;

		// Token: 0x040071C1 RID: 29121
		[Token(Token = "0x40071C1")]
		[FieldOffset(Offset = "0x44")]
		private bool m_IsPlayingAlarm;

		// Token: 0x040071C2 RID: 29122
		[Token(Token = "0x40071C2")]
		[FieldOffset(Offset = "0x48")]
		private GameObject m_CurPlayingObject;
	}
}
